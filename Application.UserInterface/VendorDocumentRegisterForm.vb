Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid

Public Class VendorDocumentRegisterForm
    Dim oAppService As New AppService.DelfinServiceClient
    Dim DOPE_Items As String = ""
    Dim oMasterDataList As New MasterDataList
    Dim dsVendorDocumentRelated As New DataSet
    Dim dsDocumentsProvider As DataSet = New DataSet()
    Dim dtCtaCte As DataTable
    Dim dtCtaCteDetail As DataTable
    Dim dtOperacionDetail As DataTable
    Dim dtDetCtaCteAsientos As DataTable
    Dim dtServiciosProveedor As DataTable
    Dim dtTipoCambio As DataTable
    Dim CCCT_Codigo As Integer = 0
    Dim TipoCambio As String = ""
    Dim AppUser As String = "sistemas"
    Friend InternalCode As Integer

    Private Sub VendorDocumentRegisterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If CCCT_Codigo = 0 Then
            deFechaRegistro.EditValue = New DateTime(Date.Now.Year, Date.Now.Month, Date.Now.Day)
        End If
        'GridView1.OptionsBehavior.Editable = True
        'GridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.Top
        'GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True
        'Obtener los DataSets de Todas las tablas que se necesitarán al grabar

        'Obtiene Tipo de CAmbio

        dtTipoCambio = New DataTable()
        dtTipoCambio = oAppService.ExecuteSQL("EXEC Nextsoft.[dgp].[paObtieneTipoCambio]").Tables(0)
        If dtTipoCambio.Rows.Count > 0 Then
            TipoCambio = dtTipoCambio.Rows(0)("TipoCambio").ToString()
        End If

        'Cuenta Corriente

        dtCtaCte = New DataTable()
        dtCtaCte = oAppService.ExecuteSQL("SELECT * FROM NextSoft..[CAJ_CtaCte] where 1=0").Tables(0)



        Dim column As DataColumn = New DataColumn()
        column.DataType = System.Type.GetType("System.Int32")
        column.ColumnName = "TMovimiento"
        dtCtaCte.Columns.Add(column)

        Dim columnCOPE_Codigo As DataColumn = New DataColumn()
        columnCOPE_Codigo.DataType = System.Type.GetType("System.String")
        columnCOPE_Codigo.ColumnName = "COPE_Codigo"
        dtCtaCte.Columns.Add(columnCOPE_Codigo)




        ' Cuenta Corriente Detalle
        dtCtaCteDetail = New DataTable()
        dtCtaCteDetail = oAppService.ExecuteSQL("SELECT * FROM NextSoft..[CAJ_DetCtaCte] where 1=0").Tables(0)

        ' Operación Detalle
        dtOperacionDetail = New DataTable()
        dtOperacionDetail = oAppService.ExecuteSQL("SELECT * FROM NextSoft..[VEN_CtaCte_Det_Operaciones] where 1=0").Tables(0)


        Dim column2 As DataColumn = New DataColumn()
        column2.DataType = System.Type.GetType("System.String")
        column2.ColumnName = "CTAR_Tipo"
        dtOperacionDetail.Columns.Add(column2)



        Dim columnDTAR_Item As DataColumn = New DataColumn()
        columnDTAR_Item.DataType = System.Type.GetType("System.Int32")
        columnDTAR_Item.ColumnName = "DTAR_Item"
        dtOperacionDetail.Columns.Add(columnDTAR_Item)
        '' CAJ_DetCtaCteAsientos
        'dtCtaCteDetail = New DataTable()
        'dtCtaCteDetail = oAppService.ExecuteSQL("SELECT * FROM NextSoft..[CAJ_DetCtaCteAsientos] where 1=0").Tables(0)


        'Grilla 


        dtServiciosProveedor = New DataTable()
        dtServiciosProveedor = oAppService.ExecuteSQL("NextSoft.dgp.paObtieneServiciosPorDocumentoProveedor 0, null, 0.0, 0").Tables(0)
        gcService.DataSource = dtServiciosProveedor
        GridView1.BestFitColumns()


        For g = 0 To NavBarControl1.Groups.Count - 1
            NavBarControl1.Groups(g).Expanded = True
        Next
        LoadDocumentType()
        LoadCurrency()
        LoadPayTerm()
        LoadDetractionType()
        LoadEntityType()
        LoadIncomeTaxType()
        LoadService()
        LoadEntityDataList(0, "riluRazonSocial")
        If InternalCode = -1 Then 'New Item
            bbiImport.Enabled = True
            NewItem()
        ElseIf InternalCode >= 0 Then 'Edit Item
            bbiImport.Enabled = False
            SetItem()
        End If
        teTipoCambio.EditValue = TipoCambio


    End Sub
    Private Sub GetItem()


        Dim oRowCtaCte As DataRow = dtCtaCte.NewRow()
        oRowCtaCte("EMPR_Codigo") = 1
        If teCodigoInterno.EditValue.ToString() <> "" Then
            oRowCtaCte("CCCT_Codigo") = teCodigoInterno.EditValue.ToString()
        End If


        oRowCtaCte("SUCR_Codigo") = 1
        'oRowCtaCte("DOCV_Codigo") = No será asignado
        oRowCtaCte("TIPE_Codigo") = lueTipoEntidad.EditValue
        oRowCtaCte("ENTC_Codigo") = lueRazonSocial.EditValue
        oRowCtaCte("TIPO_TabTDO") = "TDO"
        oRowCtaCte("TIPO_TabMND") = "MND"
        oRowCtaCte("TIPO_TabFPG") = "FPG"
        oRowCtaCte("TIPO_CodTDO") = lueTipoDocumento.EditValue
        oRowCtaCte("TIPO_CodMND") = lueMoneda.EditValue
        oRowCtaCte("TIPO_CodFPG") = lueFormaPago.EditValue
        oRowCtaCte("CCCT_Serie") = teSerieDocumento.EditValue
        oRowCtaCte("CCCT_Numero") = teNumeroDocumento.EditValue
        'oRowCtaCte("CCCT_AsientoContable") -- No será asignado
        oRowCtaCte("CCCT_FechaEmision") = deFechaEmision.EditValue
        oRowCtaCte("CCCT_TipoCambio") = teTipoCambio.EditValue
        oRowCtaCte("CCCT_FechaRecepcion") = deFechaRegistro.EditValue
        oRowCtaCte("CCCT_FechaVcto") = deFechaVencimiento.EditValue
        'oRowCtaCte("CCCT_FechaPosPago") = No será asignado
        oRowCtaCte("CCCT_ValVta") = seImporteNeto.EditValue
        'Por averiguar oRowCtaCte("CCCT_Discrepancia") = 
        oRowCtaCte("CCCT_Imp1") = seImporteImpuesto.EditValue
        'oRowCtaCte("CCCT_Imp2") = No será asignado
        'oRowCtaCte("CCCT_Imp3") = No será asignado
        'oRowCtaCte("CCCT_Imp4") = No será asignado
        oRowCtaCte("CCCT_Monto") = seImporteTotal.EditValue
        'oRowCtaCte("CCCT_Pendiente") = No será asignado

        If deFechaRegistro.EditValue IsNot Nothing Then
            oRowCtaCte("CCCT_FecReg") = deFechaRegistro.EditValue

        End If
        'oRowCtaCte("CCCT_FecCancel") = NO será asignado
        'oRowCtaCte("CCCT_Adquisicion") = NO será asignado
        'oRowCtaCte("CCCT_Pago") = NO será asignado
        'oRowCtaCte("CCCT_PagoReg") = No será asignado
        'oRowCtaCte("CCCT_Otros") = No será asignado
        oRowCtaCte("CCCT_Glosa") = ""
        'oRowCtaCte("CCCT_Estado") = No se asigna
        'oRowCtaCte("CCCT_NroTransRef") = No se asigna
        'oRowCtaCte("CCCT_TipoLetra") = No se asigna
        'oRowCtaCte("CCCT_Agrupacion") = No se asigna
        'oRowCtaCte("CCCT_RegCompras") = No se asigna
        'oRowCtaCte("CCCT_Anexo") = No se asigna
        oRowCtaCte("TIPO_TabREG") = "REG"
        oRowCtaCte("TIPO_CodREG") = "001"
        'oRowCtaCte("CCCT_CobranzaDudosa") = No se asigna
        'oRowCtaCte("CCCT_TCHistorico") = No se asigna
        'oRowCtaCte("CCCT_FecCierre") = No se asigna
        'oRowCtaCte("CCCT_TCCierre")  = No se asigna
        'oRowCtaCte("CCCT_FecCierreHistorico") = No se asigna
        'oRowCtaCte("CCCT_UltimoCierre") = No se asigna
        'Verificar donde se asigna oRowCtaCte("SERV_Codigo") =
        'oRowCtaCte("CCCT_PagoInmediato") =  No se asigna
        'oRowCtaCte("CCCT_SituacionLetra") = No se asigna
        'oRowCtaCte("CCCT_Aceptada1") =  No se asigna
        'oRowCtaCte("CCCT_Aceptada2") = No se asigna

        'oRowCtaCte("CCCT_Protestada") = No se asigna
        'oRowCtaCte("CCCT_NroProtesto") = No se asigna
        'oRowCtaCte("CCCT_EstadoLetra") = No se asigna
        'oRowCtaCte("CCCT_NroUnicoBCO") =  No se asigna
        'oRowCtaCte("CCCT_FecAceptacion") = No se asigna
        'oRowCtaCte("CCCT_SinDocOrigen") = No se asigna
        'oRowCtaCte("CCCT_FecEnvioBanco") = No se asigna
        'oRowCtaCte("CCCT_FecEnvioProveedor") = No se asigna
        'oRowCtaCte("CCCT_NroDetraccion") = No se asigna
        'oRowCtaCte("CCCT_FecDetraccion") = No se asigna


        oRowCtaCte("TIPO_TabDetrac") = "DET"
        oRowCtaCte("TIPO_CodDetrac") = lueTipoDetraccion.EditValue

        'oRowCtaCte("TIPO_TabBCO") = No se asigna
        'oRowCtaCte("TIPO_CodBCO") = No se asigna
        'oRowCtaCte("CCCT_GlosaCobranza") = No se asigna
        'oRowCtaCte("CCCT_ValorReferencial") = No se asigna


        'oRowCtaCte("CCCT_Notas") = No se asigna


        oRowCtaCte("CCCT_PorDetraccion") = lueTipoDetraccion.GetColumnValue("PorcentajeDetraccion")
        Dim _monto As Decimal = 0.0
        Dim _porcentaje As Decimal = 0.0
        _porcentaje = lueTipoDetraccion.GetColumnValue("PorcentajeDetraccion")
        If lueMoneda.EditValue = "001" Then
            _monto = Math.Round(_porcentaje * oRowCtaCte("CCCT_Monto") / 100, 0, MidpointRounding.AwayFromZero)

        ElseIf lueMoneda.EditValue = "002" Then
            _monto = Math.Round(_porcentaje * oRowCtaCte("CCCT_Monto") * oRowCtaCte("CCCT_TipoCambio") / 100, 0, MidpointRounding.AwayFromZero)
        End If



        oRowCtaCte("CCCT_MontoDetraccion") = _monto
        'oRowCtaCte("CCCT_Codigo")--> Se asigna al retornar grabado
        'oRowCtaCte("CABP_Ano") = No se asigna
        'oRowCtaCte("CABP_Codigo") = No se asigna
        'oRowCtaCte("CCCT_Cuenta") = No se asigna
        'oRowCtaCte("CCCT_CuentaIGV") = No se asigna
        'oRowCtaCte("CCCT_CuentaBI") = 'No se asigna
        'If NavBarGroup3.Visible Then
        '    oRowCtaCte("CCCT_CodReferencia") = teCodigoInternoRef.EditValue
        '    oRowCtaCte("CCCT_SerieReferencia") = teSerieDocumentoRef.EditValue
        '    oRowCtaCte("CCCT_NumeroReferencia") = teNumeroDocumentoRef.EditValue
        '    oRowCtaCte("CCCT_FechaEmisionReferencia") = deFechaEmisionRef.EditValue
        '    oRowCtaCte("TIPO_CodTDOReferencia") = lueTipoDocumentoRef.EditValue


        'End If


        'oRowCtaCte("CCCT_Origen") = No se envia
        'oRowCtaCte("CCCT_PorcImp1") =
        'oRowCtaCte("CCCT_PorcImp2") =No se envia
        'oRowCtaCte("CCCT_PorcImp3") =No se envia
        'oRowCtaCte("CCCT_PorcImp4") =No se envia
        oRowCtaCte("CCCT_RetencionIGV") = tsRetencion.EditValue


        If lueTipoRenta.EditValue IsNot Nothing Then


            oRowCtaCte("TIPO_TabTI3") = "TI3"
            oRowCtaCte("TIPO_CodTI3") = lueTipoRenta.GetColumnValue("CodigoTipoRenta")
            oRowCtaCte("CCCT_PorcImp2") = lueTipoRenta.GetColumnValue("PorcentajeTipoRenta")
        Else
             oRowCtaCte("CCCT_PorcImp2") = 0
        End If



        If seImporteRenta.Value <> 0 Then
            oRowCtaCte("CCCT_Imp2") = seImporteRenta.Value
        End If

        If teCodigoInterno.EditValue.ToString() = "" Then
            oRowCtaCte("AUDI_UsrCrea") = "sistemas"
        Else
            oRowCtaCte("AUDI_UsrMod") = "sistemas"
        End If


        oRowCtaCte("COPE_Codigo") = teCodigoInternoOperacion.EditValue

        'Datos de la grilla
        dtCtaCte.Rows.Add(oRowCtaCte)
        Dim oRowCtaCteDetail As DataRow = dtCtaCteDetail.NewRow()
        dtCtaCteDetail.Rows.Add(oRowCtaCteDetail)
        DOPE_Items = ""
        For i As Integer = 0 To GridView1.DataRowCount - 1
            Dim oRowOperacionDetail As DataRow = dtOperacionDetail.NewRow()

            If GridView1.GetRowCellValue(i, "Monto_Pagado_Servicio").ToString() <> "" Then

                oRowOperacionDetail("CTAR_Tipo") = "S"
                oRowOperacionDetail("TIPE_Codigo") = GridView1.GetRowCellValue(i, "TIPE_Codigo").ToString()
                oRowOperacionDetail("ENTC_Codigo") = GridView1.GetRowCellValue(i, "ENTC_Codigo").ToString()
                oRowOperacionDetail("DCTO_Costo") = GridView1.GetRowCellValue(i, "Monto_Pagado_Servicio").ToString()
                oRowOperacionDetail("DTAR_Item") = 1
                oRowOperacionDetail("DOPE_Item") = GridView1.GetRowCellValue(i, "DOPE_Item").ToString()
                dtOperacionDetail.Rows.Add(oRowOperacionDetail)
                'DOPE_Items = DOPE_Items + String.Format("|{0}|", GridView1.GetRowCellValue(i, "DOPE_Item").ToString())


            End If


            'If GridView1.GetRowCellValue(i, "ColumnFieldName").ToString() = "A" Then
            '    Your code here  
            'End If
        Next i


        dtCtaCte.TableName = "CtaCte"
        dtCtaCteDetail.TableName = "CtaCteDetail"
        dtOperacionDetail.TableName = "dtOperacionDetail"
        dsDocumentsProvider.Tables.Add(dtCtaCte.Copy())
        dsDocumentsProvider.Tables.Add(dtCtaCteDetail.Copy())
        dsDocumentsProvider.Tables.Add(dtOperacionDetail.Copy())



    End Sub
    Private Sub LoadService()
        Dim dtQuery As New DataTable
        dtQuery = oMasterDataList.LoadMasterData("Service", Nothing)
        riluServicios.DataSource = dtQuery
        riluServicios.DisplayMember = "DescripcionServicio"
        riluServicios.ValueMember = "CodigoServicio"






    End Sub

    Private Sub LoadEntityDataList(EntityType As Integer, ControlName As String)
        Dim dtQuery As New DataTable
        Dim aParams As New ArrayList
        If EntityType > 0 Then
            aParams.Add(EntityType.ToString)
        End If

        dtQuery = oMasterDataList.LoadMasterData("EntityByType", aParams)
        riluRazonSocial.DataSource = dtQuery
        riluRazonSocial.DisplayMember = "DescripcionEntidad"
        riluRazonSocial.ValueMember = "CodigoEntidad"

    End Sub



    Private Sub LoadDocumentType()
        Dim dtSource As New DataTable
        dtSource = oMasterDataList.LoadMasterData("AccountingDocumentType", Nothing)
        lueTipoDocumento.Properties.DataSource = dtSource
        lueTipoDocumento.Properties.DisplayMember = "DescripcionTipoDocumento"
        lueTipoDocumento.Properties.ValueMember = "CodigoTipoDocumento"


        lueTipoDocumentoRef.Properties.DataSource = dtSource
        lueTipoDocumentoRef.Properties.DisplayMember = "DescripcionTipoDocumento"
        lueTipoDocumentoRef.Properties.ValueMember = "CodigoTipoDocumento"

    End Sub





    Private Sub LoadCurrency()
        Dim dtSource As New DataTable
        dtSource = oMasterDataList.LoadMasterData("Currency", Nothing)
        lueMoneda.Properties.DataSource = dtSource
        lueMoneda.Properties.DisplayMember = "DescripcionMoneda"
        lueMoneda.Properties.ValueMember = "CodigoMoneda"


        riluMoneda.DataSource = dtSource
        riluMoneda.DisplayMember = "DescripcionMoneda"
        riluMoneda.ValueMember = "CodigoMoneda"


    End Sub

    Private Sub LoadEntityType()
        Dim dtQuery As New DataTable
        dtQuery = oMasterDataList.LoadMasterData("EntityType", Nothing)
        lueTipoEntidad.Properties.DataSource = dtQuery
        lueTipoEntidad.Properties.DisplayMember = "DescripcionTipoEntidad"
        lueTipoEntidad.Properties.ValueMember = "CodigoTipoEntidad"
        lueTipoEntidad.ItemIndex = 1


        riluTipoEntidad.DataSource = dtQuery
        riluTipoEntidad.DisplayMember = "DescripcionTipoEntidad"
        riluTipoEntidad.ValueMember = "CodigoTipoEntidad"


    End Sub

    Private Sub LoadEntityByType()
        Dim dtQuery As New DataTable
        dtQuery = oAppService.ExecuteSQL("EXEC NextSoft.dgp.paListaEntidadPorTipo " & lueTipoEntidad.EditValue.ToString).Tables(0)
        lueRazonSocial.Properties.DataSource = dtQuery
        lueRazonSocial.Properties.DisplayMember = "DescripcionEntidad"
        lueRazonSocial.Properties.ValueMember = "CodigoEntidad"



        'RepositoryItemLookUpEdit6.DataSource = dtQuery
        'RepositoryItemLookUpEdit6.DisplayMember = "DescripcionTipoEntidad"
        'RepositoryItemLookUpEdit6.ValueMember = "CodigoTipoEntidad"
    End Sub

    Private Sub LoadPayTerm()
        Dim dtQuery As New DataTable
        dtQuery = oMasterDataList.LoadMasterData("PayTerm", Nothing)
        lueFormaPago.Properties.DataSource = dtQuery
        lueFormaPago.Properties.DisplayMember = "DescripcionFormaPago"
        lueFormaPago.Properties.ValueMember = "CodigoFormaPago"
    End Sub

    Private Sub LoadDetractionType()
        Dim dtQuery As New DataTable
        dtQuery = oMasterDataList.LoadMasterData("DetractionType", Nothing)
        lueTipoDetraccion.Properties.DataSource = dtQuery
        lueTipoDetraccion.Properties.DisplayMember = "DescripcionTipoDetraccion"
        lueTipoDetraccion.Properties.ValueMember = "CodigoTipoDetraccion"
    End Sub

    Private Sub LoadIncomeTaxType()
        Dim dtSource As New DataTable
        dtSource = oMasterDataList.LoadMasterData("IncomeTaxType", Nothing)
        lueTipoRenta.Properties.DataSource = dtSource
        lueTipoRenta.Properties.DisplayMember = "DescripcionTipoRenta"
        lueTipoRenta.Properties.ValueMember = "CodigoTipoRenta"
        lueTipoRenta.ItemIndex = 0
    End Sub

    Private Sub bbiSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSave.ItemClick
        GetItem()


        If teCodigoInterno.EditValue.ToString() = "" Then
            CCCT_Codigo = oAppService.InsertDocumentsProvider(dsDocumentsProvider, DOPE_Items)
        Else
            oAppService.ActualizarDocumentsProvider(dsDocumentsProvider, DOPE_Items)
        End If


        Dim dsQuery As DataSet = New DataSet()
        Dim oPurchaseInvoiceViewerForm As New PurchaseInvoiceViewerForm
        'If GridView1.GetFocusedRowCellValue("TIPO_Documento").ToString().Contains("CREDITO") Then
        '    dsQuery = oAppService.ExecuteSQL("EXEC NextSoft.sap.upGetDataForPurchaseCreditMemoInterface " & "1, 1, " & CCCT_Codigo.ToString() & ", '" & AppUser & "', 'P'")
        '    oPurchaseInvoiceViewerForm.sInterfaceName = "PurchaseCreditMemo"
        'Else
        '    dsQuery = oAppService.ExecuteSQL("EXEC NextSoft.sap.upGetDataForPurchaseInvoiceInterface " & "1, 1, " & CCCT_Codigo.ToString() & ", '" & AppUser & "', 'P'")
        '    oPurchaseInvoiceViewerForm.sInterfaceName = "PurchaseInvoice"
        'End If
        'oPurchaseInvoiceViewerForm.dsVoucher = dsQuery
        'oPurchaseInvoiceViewerForm.ShowDialog()
        'GridView1.SetFocusedRowCellValue("DocumentoSAP", oPurchaseInvoiceViewerForm.sDocSAP)





    End Sub

    Private Sub bbiImport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiImport.ItemClick

    End Sub

    Private Sub bbiClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiClose.ItemClick
        Close()
    End Sub

    Private Sub teHBL_Leave(sender As Object, e As EventArgs) Handles teHBL.Leave

    End Sub

    Private Sub NewItem()
        deFechaEmision.EditValue = Today
    End Sub

    Private Sub SetItem()
        dsVendorDocumentRelated = oAppService.ExecuteSQL("EXEC NextSoft.dgp.paObtieneDocumentosProveedorRelacionados " & InternalCode.ToString)
        If dsVendorDocumentRelated Is Nothing Or dsVendorDocumentRelated.Tables(0).Rows.Count = 0 Then
            Return
        End If
        Dim drVendorDocument As DataRow = dsVendorDocumentRelated.Tables(0)(0)

        'Datos Generales
        teHBL.EditValue = drVendorDocument("COPE_HBL")
        lueTipoDocumento.EditValue = drVendorDocument("CodigoTipoDocumento")
        lueMoneda.EditValue = drVendorDocument("CodigoMoneda")
        lueTipoDetraccion.EditValue = drVendorDocument("CodigoTipoDetraccion")
        lueTipoEntidad.EditValue = drVendorDocument("TIPE_Codigo")
        LoadEntityByType()
        lueRazonSocial.EditValue = drVendorDocument("ENTC_Codigo")
        teSerieDocumento.EditValue = drVendorDocument("CCCT_Serie")
        teNumeroDocumento.EditValue = drVendorDocument("CCCT_Numero")
        deFechaEmision.EditValue = drVendorDocument("CCCT_FechaEmision")
        deFechaVencimiento.EditValue = drVendorDocument("CCCT_FechaVcto")
        deFechaRegistro.EditValue = drVendorDocument("CCCT_FecReg")
        teCodigoInterno.EditValue = drVendorDocument("CCCT_Codigo")
        teTipoCambio.EditValue = drVendorDocument("CCCT_TipoCambio")
        seImporteNeto.EditValue = drVendorDocument("CCCT_ValVta")
        seImporteImpuesto.EditValue = drVendorDocument("CCCT_Imp1")
        seImporteRenta.EditValue = drVendorDocument("CCCT_Imp2")
        seImporteTotal.EditValue = drVendorDocument("CCCT_Monto")
        lueFormaPago.EditValue = drVendorDocument("CodigoFormaPago")
        tsAutoDetraccion.EditValue = drVendorDocument("AutoDetraccion")
        'lueTipoRenta.GetColumnValue("PorcentajeTipoRenta")
        lueTipoRenta.EditValue = drVendorDocument("TIPO_CodTI3")
        'Documento de Referencia
        If drVendorDocument("RequiereReferencia") = 0 Then
            NavBarGroup3.Visible = False
        Else
            NavBarGroup3.Expanded = True
            lueTipoDocumentoRef.Properties.DataSource = lueTipoDocumento.Properties.DataSource
            lueTipoDocumentoRef.Properties.DisplayMember = "DescripcionTipoDocumento"
            lueTipoDocumentoRef.Properties.ValueMember = "CodigoTipoDocumento"
            lueTipoDocumentoRef.EditValue = drVendorDocument("TIPO_CodTDOReferencia")
            teSerieDocumentoRef.EditValue = drVendorDocument("CCCT_SerieReferencia")
            teNumeroDocumentoRef.EditValue = drVendorDocument("CCCT_NumeroReferencia")
            deFechaEmisionRef.EditValue = drVendorDocument("CCCT_FechaEmisionReferencia")
            teCodigoInternoRef.EditValue = drVendorDocument("CCCT_CodReferencia")
        End If
        'Operación Logística
        lueNumeroOperacion.EditValue = drVendorDocument("COPE_NumDoc")
        teClienteOperacion.EditValue = drVendorDocument("Cliente")
        deFechaEmisionOperacion.EditValue = drVendorDocument("COPE_FecEmi")
        teNumeroHblOperacion.EditValue = drVendorDocument("COPE_HBL")
        teCodigoInternoOperacion.EditValue = drVendorDocument("COPE_Codigo")
        'Servicios
        If dsVendorDocumentRelated.Tables(1).Rows.Count > 0 Then
            gcService.DataSource = dsVendorDocumentRelated.Tables(1)
            GridView1.BestFitColumns()
        End If
    End Sub

    Private Sub lueTipoEntidad_Leave(sender As Object, e As EventArgs) Handles lueTipoEntidad.Leave
        LoadEntityByType()
    End Sub

    Private Sub gcService_EmbeddedNavigator_ButtonClick(sender As Object, e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs) Handles gcService.EmbeddedNavigator.ButtonClick
        If (e.Button.ButtonType = NavigatorButtonType.Append) Then

            GridView1.AddNewRow()


        End If
    End Sub

    Private Sub teHBL_EditValueChanged(sender As Object, e As EventArgs) Handles teHBL.EditValueChanged

        Dim dsOperacion As DataSet
        Dim dtOperacion As DataTable = New DataTable()
        Dim dtServicios As DataTable = New DataTable()
        dsOperacion = New DataSet()
        Dim Query As String = "NextSoft.[dgp].[paObtieneOperacionLogisticaPorHblMblCCCTCodigo] '" + teHBL.EditValue + "' , " + CCCT_Codigo.ToString()
        dsOperacion = oAppService.ExecuteSQL(Query)
        dtOperacion = dsOperacion.Tables(0)
        dtServicios = dsOperacion.Tables(1)
        If dtServicios IsNot Nothing Then
            If dtServicios.Rows.Count > 0 Then
                Dim drOperacion As DataRow = dtOperacion.Rows(0)
                teClienteOperacion.EditValue = drOperacion("Cliente").ToString()
                teCodigoInternoOperacion.EditValue = drOperacion("COPE_Codigo").ToString()
                deFechaEmisionOperacion.EditValue = drOperacion("COPE_FecEmi").ToString()
                teNumeroHblOperacion.EditValue = drOperacion("COPE_HBL").ToString()
                'Llena Numero Operación
                lueNumeroOperacion.Properties.DataSource = Nothing
                lueNumeroOperacion.Properties.DataSource = dtOperacion
                lueNumeroOperacion.Properties.DisplayMember = "COPE_NumDoc"
                lueNumeroOperacion.Properties.ValueMember = "COPE_Codigo"
                lueNumeroOperacion.EditValue = drOperacion("COPE_Codigo")
            End If


        End If

        gcService.DataSource = dtServicios

    End Sub


    Public Sub ObtenerCodigoDocumento(TipoDocumentoRef As String, SerieDocumentoRef As String, NumeroDocumentoRef As String, FechaDocumentoRef As DateTime)
        Dim dsDocumentoReferencia As DataSet = New DataSet()
        Dim dtQuery As String = "select CCCT_Codigo from  NextSoft..CAJ_CtaCte where TIPO_CodTDO='" + TipoDocumentoRef + "' AND CCCT_Serie = '" + SerieDocumentoRef + "' AND CCCT_Numero='" + NumeroDocumentoRef + "' AND CONVERT(varchar,CCCT_FechaEmision,112)='" + FechaDocumentoRef.Year.ToString() + FechaDocumentoRef.Month.ToString().PadLeft(2, "0") + FechaDocumentoRef.Day.ToString().PadLeft(2, "0") + "'"
        Dim CCCT_CodigoRef As String = ""

        dsDocumentoReferencia = oAppService.ExecuteSQL(dtQuery)
        If dsDocumentoReferencia IsNot Nothing Then
            If dsDocumentoReferencia.Tables.Count > 0 Then
                If dsDocumentoReferencia.Tables(0).Rows.Count > 0 Then
                    Dim drDocumentoReferencia As DataRow = dsDocumentoReferencia.Tables(0).Rows.Item(0)
                    CCCT_CodigoRef = drDocumentoReferencia("CCCT_Codigo").ToString()
                End If
            End If
        End If


        teCodigoInternoRef.EditValue = CCCT_CodigoRef
    End Sub

    Private Sub deFechaEmisionRef_EditValueChanged(sender As Object, e As EventArgs) Handles deFechaEmisionRef.EditValueChanged

        If (lueTipoDocumentoRef.EditValue <> "" And teSerieDocumentoRef.EditValue <> "" And teNumeroDocumentoRef.EditValue <> "" And deFechaEmisionRef.EditValue IsNot Nothing) Then

            ObtenerCodigoDocumento(lueTipoDocumentoRef.EditValue, teSerieDocumentoRef.EditValue, teNumeroDocumentoRef.EditValue, deFechaEmisionRef.EditValue)
        End If
    End Sub


End Class
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraSplashScreen

Public Class PreInvoicingPopupForm
    Dim oAppService As New AppService.DelfinServiceClient
    Dim oMasterDataList As New MasterDataList
    Friend AppUser As String = "sistemas"
    Friend OperationsList As String = ""
    Friend InternalCodeList As String = ""
    Friend CodigoMoneda As String
    Friend oProcessType As String = ""
    Friend oQuerySource As String = ""
    Friend IsMultiline As Boolean = Nothing

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.Size = New Size(1200, 600)
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub LogisticOperationInvoicingPopupForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtSource As New DataTable
        LoadTaxDocumentType()
        LoadPaymentType()
        LoadCurrency()
        LoadEntityDataList(1, "lueSocioNegocio")
        deFechaEmision.EditValue = Now
        If oProcessType = "PreInvoicing" Then
            bbiSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            If oQuerySource = "OP" Then
                dtSource = oAppService.ExecuteSQL("EXEC NextSoft.dgp.paObtieneOperacionesLogisticasPorPreFacturar '" & OperationsList & "','" & CodigoMoneda & "'").Tables(0)
            Else
                dtSource = oAppService.ExecuteSQL("EXEC NextSoft.dgp.paObtieneOperacionesLogisticasPorPreFacturar '" & OperationsList & "','" & CodigoMoneda & "'").Tables(0)
            End If
            If IsDBNull(dtSource.Rows(0)("TIPC_Venta")) Then
                XtraMessageBox.Show("No existe tipo de cambio, por favor coordine con el área contable.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                bbiGenerate.Enabled = DevExpress.XtraBars.BarItemVisibility.Never
            End If
        End If
        If oProcessType = "Invoicing" Then
            bbiGenerate.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            dtSource = oAppService.ExecuteSQL("EXEC NextSoft.dgp.VEN_DDOVSS_TodosPorDOCV_Codigo " & InternalCodeList & ", '" & oQuerySource & "'").Tables(0)
            lueMoneda.Properties.ReadOnly = True
            deFechaEmision.Properties.ReadOnly = True
            deFechaVencimiento.Properties.ReadOnly = True
            If dtSource.Rows.Count > 0 Then
                Dim oRow As DataRow = dtSource.Rows(0)
                lueTipoComprobante.EditValue = oRow("TIPO_CodTDO")
                lueSerieComprobante.EditValue = oRow("DOCV_Serie")
                lueMoneda.EditValue = oRow("TIPO_CodMND")
                lueSocioNegocio.EditValue = oRow("ENTC_Codigo")
                seDiasCredito.EditValue = oRow("ENLI_DiasDuracion")
                lueFormaPago.EditValue = oRow("TIPO_CodFPG")
            End If

        End If
        If IsMultiline Then
            lueMoneda.ReadOnly = True
            lueFormaPago.ReadOnly = True
            seDiasCredito.ReadOnly = True
            deFechaVencimiento.ReadOnly = True
            lueSocioNegocio.ReadOnly = True
        Else
            GridView1.Columns("TIPO_CodFPG").Visible = False
            GridView1.Columns("Moneda").Visible = False
            GridView1.Columns("Cliente").Visible = False
            GridView1.Columns("ENLI_DiasDuracion").Visible = False
            GridView1.Columns("DOCV_FechaVcmto").Visible = False
        End If

        lueTipoComprobante.ItemIndex = 0
        gcInvoicing.DataSource = dtSource
        FormatGridView(GridView1)

    End Sub

    Private Sub LoadPaymentType()
        Dim dtQuery As New DataTable
        dtQuery = oMasterDataList.LoadMasterData("PayTerm", Nothing)
        If Not IsMultiline Then
            lueFormaPago.Properties.DataSource = dtQuery
            lueFormaPago.Properties.DisplayMember = "DescripcionFormaPago"
            lueFormaPago.Properties.ValueMember = "CodigoFormaPago"
        Else
            RepositoryItemLookUpEdit1.DataSource = dtQuery
            RepositoryItemLookUpEdit1.DisplayMember = "DescripcionFormaPago"
            RepositoryItemLookUpEdit1.ValueMember = "CodigoFormaPago"
        End If
    End Sub

    Private Sub LoadCurrency()
        Dim dtQuery As New DataTable
        dtQuery = oMasterDataList.LoadMasterData("Currency", Nothing)
        lueMoneda.Properties.DataSource = dtQuery
        lueMoneda.Properties.DisplayMember = "DescripcionMoneda"
        lueMoneda.Properties.ValueMember = "CodigoMoneda"
    End Sub

    Private Sub LoadEntityDataList(EntityType As Integer, ControlName As String)
        Dim dtQuery As New DataTable
        Dim aParams As New ArrayList
        If EntityType > 0 Then
            aParams.Add(EntityType.ToString)
        End If
        dtQuery = oMasterDataList.LoadMasterData("EntityByType", aParams)
        If ControlName = "lueSocioNegocio" Then
            lueSocioNegocio.Properties.DataSource = dtQuery
            lueSocioNegocio.Properties.DisplayMember = "DescripcionEntidad"
            lueSocioNegocio.Properties.ValueMember = "CodigoEntidad"
        End If

    End Sub
    Private Sub LoadTaxDocumentType()
        Dim dtQuery As New DataTable
        dtQuery = oAppService.ExecuteSQL("EXEC NextSoft.dgp.paListaTipoDocumentoContable").Tables(0)
        dtQuery = dtQuery.Select("CodigoTipoDocumento IN ('001','003','007')").CopyToDataTable
        lueTipoComprobante.Properties.DataSource = dtQuery
        lueTipoComprobante.Properties.DisplayMember = "DescripcionTipoDocumento"
        lueTipoComprobante.Properties.ValueMember = "CodigoTipoDocumento"
    End Sub

    Private Sub LoadTaxDocumentSerie()
        Dim dtQuery As New DataTable
        dtQuery = oAppService.ExecuteSQL("EXEC NextSoft.dgp.paListaSerieFacturacion '" & lueTipoComprobante.EditValue & "','003'").Tables(0)
        lueSerieComprobante.Properties.DataSource = dtQuery
        lueSerieComprobante.Properties.DisplayMember = "SERI_Serie"
        lueSerieComprobante.Properties.ValueMember = "SERI_Serie"
        lueSerieComprobante.ItemIndex = 0
    End Sub

    Private Sub bbiGenerate_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGenerate.ItemClick
        If XtraMessageBox.Show("Se generarán las pre-facturas de las operciones seleccionadas, desea continuar? ", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If
        Dim dtHeader, dtDetail As New DataTable
        Dim dsDocVta As New DataSet
        dtHeader = oAppService.ExecuteSQL("SELECT TOP 0 * FROM NextSoft.dbo.VEN_DocsVta").Tables(0)
        dtHeader.TableName = "Header"
        dtDetail = oAppService.ExecuteSQL("SELECT TOP 0 * FROM NextSoft.dbo.VEN_DetDocsVta").Tables(0)
        dtDetail.TableName = "Detail"
        dsDocVta.Tables.Add(dtHeader.Copy)
        dsDocVta.Tables.Add(dtDetail.Copy)
        For r = 0 To GridView1.RowCount - 1
            Dim aResponse As New ArrayList
            Dim oRow As DataRow = GridView1.GetDataRow(r)
            SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)
            SplashScreenManager.Default.SetWaitFormDescription("PreFacturando (" & (r + 1).ToString & " de " & GridView1.RowCount.ToString & ") OP:  " & oRow("COPE_NumDoc"))
            dsDocVta.Tables(0).Rows.Clear()
            dsDocVta.Tables(1).Rows.Clear()
            dsDocVta = GetDataResult(dsDocVta, oRow)
            Try
                aResponse.AddRange(oAppService.PreFacturar(oRow("COPE_Codigo"), dsDocVta))
                If aResponse.Count > 0 Then
                    If aResponse(0) = 0 Then

                    End If
                End If
            Catch ex As Exception

            End Try
        Next
        SplashScreenManager.CloseForm(False)
        'If bError Then
        '    SplashScreenManager.CloseForm(False)
        '    XtraMessageBox.Show("Se identificaron algunos errores durante el proceso de pre facturación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Return
        'End If
    End Sub

    Function GetDataResult(dsResult As DataSet, drSource As DataRow) As DataSet
        Validate()
        Dim iPos As Integer = 0
        'CABECERA
        dsResult.Tables(0).Rows.Add()
        iPos = dsResult.Tables(0).Rows.Count - 1
        Dim oRow As DataRow = dsResult.Tables(0).Rows(iPos)
        oRow("DOCV_Codigo") = 0
        'oRow("DOCV_Numero") = 
        oRow("DOCV_TipoCambio") = drSource("TIPC_Venta")
        oRow("DOCV_FechaEmision") = Now
        oRow("DOCV_FechaVcmto") = drSource("DOCV_FechaVcmto")
        oRow("DOCV_Estado") = "E"
        oRow("DOCV_ValorTotal") = drSource("ValorVenta") * IIf(drSource("TIPO_CodMND") = "002", drSource("TIPC_Venta"), 1)
        oRow("DOCV_ValorTotalD") = drSource("ValorVenta") / IIf(drSource("TIPO_CodMND") = "001", drSource("TIPC_Venta"), 1)
        oRow("DOCV_Descuento") = 0
        oRow("DOCV_DescuentoD") = 0
        oRow("DOCV_Observaciones") = drSource("SERV_Nombre_SPA")
        oRow("DOCV_Impuesto1") = oRow("DOCV_ValorTotal") * (drSource("VALOR_IGV") / 100)
        oRow("DOCV_Impuesto1D") = oRow("DOCV_ValorTotalD") * (drSource("VALOR_IGV") / 100)
        oRow("DOCV_Impuesto2") = 0
        oRow("DOCV_Impuesto2D") = 0
        oRow("DOCV_Impuesto3") = 0
        oRow("DOCV_Impuesto3D") = 0
        oRow("DOCV_Impuesto4") = 0
        oRow("DOCV_Impuesto4D") = 0
        oRow("DOCV_PorcImp1") = drSource("VALOR_IGV")
        oRow("DOCV_PorcImp2") = 0
        oRow("DOCV_PorcImp3") = 0
        oRow("DOCV_PorcImp4") = 0
        oRow("DOCV_ValorVtaTotal") = oRow("DOCV_ValorTotal") + oRow("DOCV_Impuesto1")
        oRow("DOCV_ValorVtaTotalD") = oRow("DOCV_ValorTotalD") + oRow("DOCV_Impuesto1D")
        oRow("DOCV_PrecVtaTotal") = oRow("DOCV_ValorTotal") + oRow("DOCV_Impuesto1")
        oRow("DOCV_PrecVtaTotalD") = oRow("DOCV_ValorTotalD") + oRow("DOCV_Impuesto1D")
        oRow("DOCV_Notas") = ""
        oRow("DOCV_Serie") = lueSerieComprobante.EditValue
        oRow("TIPO_TabFPG") = "FPG"
        oRow("TIPO_CodFPG") = drSource("TIPO_CodFPG")
        oRow("TIPO_TabMND") = "MND"
        oRow("TIPO_CodMND") = drSource("TIPO_CodMND")
        oRow("TIPO_TabTDO") = "TDO"
        oRow("TIPO_CodTDO") = lueTipoComprobante.EditValue
        'oRow("CONS_CodANU") =
        'oRow("CONS_TabANU") =
        'oRow("PDOC_Codigo") =
        oRow("AUDI_UsrCrea") = AppUser
        'oRow("AUDI_FecCrea") =
        oRow("AUDI_UsrMod") = AppUser
        'oRow("AUDI_FecMod") =
        oRow("ENTC_Codigo") = drSource("ENTC_CodCliente")
        oRow("DOCV_HBL") = drSource("COPE_HBL")
        oRow("DOCV_NroOperacion") = drSource("COPE_NumDoc")
        'oRow("DOCV_CodigoPadre") =
        'oRow("AUDI_UsrConfirmacion") =
        'oRow("AUDI_FecConfirmacion") =
        'oRow("AUDI_UsrAnulacion") =
        'oRow("AUDI_FecAnulacion") =
        'oRow("AUDI_UsrFPG") =
        'oRow("AUDI_FecFPG") =
        oRow("TIPE_Codigo") = 1
        'oRow("CCOT_Numero") =
        oRow("COPE_Codigo") = drSource("COPE_Codigo")

        'DETALLE
        dsResult.Tables(1).Rows.Add()
        iPos = dsResult.Tables(1).Rows.Count - 1
        oRow = dsResult.Tables(1).Rows(iPos)
        oRow("DDOV_Item") = iPos + 1
        oRow("DDOV_Cantidad") = 1
        oRow("DDOV_PrecioUnitario") = drSource("ValorVenta") * IIf(drSource("TIPO_CodMND") = "002", drSource("TIPC_Venta"), 1)
        oRow("DDOV_PrecioUnitarioD") = drSource("ValorVenta") / IIf(drSource("TIPO_CodMND") = "001", drSource("TIPC_Venta"), 1)
        oRow("DDOV_ValorVenta") = drSource("ValorVenta") * IIf(drSource("TIPO_CodMND") = "002", drSource("TIPC_Venta"), 1)
        oRow("DDOV_ValorVentaD") = drSource("ValorVenta") / IIf(drSource("TIPO_CodMND") = "001", drSource("TIPC_Venta"), 1)
        oRow("DDOV_Impuesto1") = oRow("DDOV_PrecioUnitario") * (drSource("VALOR_IGV") / 100)
        oRow("DDOV_Impuesto1D") = oRow("DDOV_PrecioUnitarioD") * (drSource("VALOR_IGV") / 100)
        oRow("DDOV_Impuesto2") = 0
        oRow("DDOV_Impuesto2D") = 0
        oRow("DDOV_Impuesto3") = 0
        oRow("DDOV_Impuesto3D") = 0
        oRow("DDOV_Impuesto4") = 0
        oRow("DDOV_Impuesto4D") = 0
        oRow("DDOV_Notas") = ""
        oRow("DOCV_Codigo") = 0
        oRow("SERV_Codigo") = drSource("SERV_Codigo")
        oRow("DDOV_Descripcion") = drSource("SERV_Nombre_SPA")
        oRow("AUDI_UsrCrea") = AppUser
        'oRow("AUDI_FecCrea") =
        oRow("AUDI_UsrMod") = AppUser
        'oRow("AUDI_FecMod") =
        oRow("DDOV_ValorTotal") = drSource("ValorVenta") * IIf(drSource("TIPO_CodMND") = "002", drSource("TIPC_Venta"), 1)
        oRow("DDOV_ValorTotalD") = drSource("ValorVenta") / IIf(drSource("TIPO_CodMND") = "001", drSource("TIPC_Venta"), 1)

        Return dsResult
    End Function
    Private Sub bbiClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiClose.ItemClick
        Close()
    End Sub

    Private Sub lueTipoComprobante_EditValueChanged(sender As Object, e As EventArgs) Handles lueTipoComprobante.EditValueChanged
        LoadTaxDocumentSerie()
    End Sub

    Private Sub GridView1_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        If e.Column.FieldName = "CONS_CodFPG" Then
            If GridView1.GetFocusedRowCellValue("CONS_CodFPG") = "001" Then
                GridView1.SetFocusedRowCellValue("ENLI_DiasDuracion", 0)
            End If
        End If
        If e.Column.FieldName = "ENLI_DiasDuracion" Then
            If GridView1.GetFocusedRowCellValue("ENLI_DiasDuracion") >= 0 Then
                GridView1.SetFocusedRowCellValue("DOCV_FechaVcmto", DateAdd(DateInterval.Day, GridView1.GetFocusedRowCellValue("ENLI_DiasDuracion"), deFechaEmision.DateTime))
            End If
        End If
        Dim oRow As DataRow = GridView1.GetFocusedDataRow
        'GridView1.SetFocusedRowCellValue("Impuesto1", oRow("ValorVenta") * (oRow("VALOR_IGV") / 100))
        'GridView1.SetFocusedRowCellValue("ValorTotal", oRow("ValorVenta") + GridView1.GetFocusedRowCellValue("Impuesto1"))
    End Sub

    Private Sub bbiSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSave.ItemClick
        If SaveChanges Then
            DialogResult = DialogResult.OK
        End If
        Close()
    End Sub

    Function SaveChanges() As Boolean
        Dim bResult As Boolean = True


        Return bResult
    End Function

    Private Sub lueFormaPago_EditValueChanged(sender As Object, e As EventArgs) Handles lueFormaPago.EditValueChanged
        If lueFormaPago.EditValue = "001" Then
            seDiasCredito.EditValue = 0
        End If
        deFechaVencimiento.EditValue = DateAdd(DateInterval.Day, seDiasCredito.EditValue, deFechaEmision.DateTime)
    End Sub

    Private Sub seDiasCredito_EditValueChanged(sender As Object, e As EventArgs) Handles seDiasCredito.EditValueChanged
        deFechaVencimiento.EditValue = DateAdd(DateInterval.Day, seDiasCredito.EditValue, deFechaEmision.DateTime)
    End Sub
End Class
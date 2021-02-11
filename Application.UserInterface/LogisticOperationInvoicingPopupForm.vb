Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraSplashScreen

Public Class LogisticOperationInvoicingPopupForm
    Dim oAppService As New AppService.DelfinServiceClient
    Dim oMasterDataList As New MasterDataList
    Friend AppUser As String = "sistemas"
    Friend OperationsList As String = ""
    Friend CodigoMoneda As String
    Friend oProcessType As String = ""
    Private Sub LogisticOperationInvoicingPopupForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtSource As New DataTable
        LoadTaxDocumentType()
        LoadPaymentType()
        deFechaEmision.EditValue = Now
        dtSource = oAppService.ExecuteSQL("EXEC NextSoft.dgp.paObtieneOperacionesLogisticasPorPreFacturar '" & OperationsList & "','" & CodigoMoneda & "'").Tables(0)
        If IsDBNull(dtSource.Rows(0)("TIPC_Venta")) Then
            XtraMessageBox.Show("No existe tipo de cambio, por favor coordine con el área contable.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            bbiGenerate.Enabled = False
        End If
        If oProcessType = "Single" Then
            'gcInvoicing.MainView = GridView1
            GridView1.Columns("TIPO_CodFPG").Visible = False
        End If

        If oProcessType = "Multiple" Then
            lueMoneda.ReadOnly = True
            lueFormaPago.ReadOnly = True
            seDiasCredito.ReadOnly = True
            deFechaVencimiento.ReadOnly = True
            lueSocioNegocio.ReadOnly = True
            'gcInvoicing.MainView = GridView1
        End If
        lueTipoComprobante.ItemIndex = 0
        gcInvoicing.DataSource = dtSource
        GridView1.BestFitColumns()

    End Sub

    Private Sub LoadPaymentType()
        Dim dtQuery As New DataTable
        dtQuery = oMasterDataList.LoadMasterData("PayTerm", Nothing)
        If oProcessType = "Single" Then
            lueFormaPago.Properties.DataSource = dtQuery
            lueFormaPago.Properties.DisplayMember = "DescripcionFormaPago"
            lueFormaPago.Properties.ValueMember = "CodigoFormaPago"
        Else
            RepositoryItemLookUpEdit1.DataSource = dtQuery
            RepositoryItemLookUpEdit1.DisplayMember = "DescripcionFormaPago"
            RepositoryItemLookUpEdit1.ValueMember = "CodigoFormaPago"
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
        oRow("DOCV_ValorTotal") = drSource("DOPE_PrecioTotVta") * IIf(drSource("TIPO_CodMND") = "002", drSource("TIPC_Venta"), 1)
        oRow("DOCV_ValorTotalD") = drSource("DOPE_PrecioTotVta") / IIf(drSource("TIPO_CodMND") = "001", drSource("TIPC_Venta"), 1)
        oRow("DOCV_Descuento") = 0
        oRow("DOCV_DescuentoD") = 0
        oRow("DOCV_Observaciones") = ""
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
        oRow("DDOV_PrecioUnitario") = drSource("DOPE_PrecioTotVta") * IIf(drSource("TIPO_CodMND") = "002", drSource("TIPC_Venta"), 1)
        oRow("DDOV_PrecioUnitarioD") = drSource("DOPE_PrecioTotVta") / IIf(drSource("TIPO_CodMND") = "001", drSource("TIPC_Venta"), 1)
        oRow("DDOV_ValorVenta") = drSource("DOPE_PrecioTotVta") * IIf(drSource("TIPO_CodMND") = "002", drSource("TIPC_Venta"), 1)
        oRow("DDOV_ValorVentaD") = drSource("DOPE_PrecioTotVta") / IIf(drSource("TIPO_CodMND") = "001", drSource("TIPC_Venta"), 1)
        oRow("DDOV_Impuesto1") = drSource("DOPE_PrecioTotVta") * IIf(drSource("TIPO_CodMND") = "002", drSource("TIPC_Venta"), 1)
        oRow("DDOV_Impuesto1D") = drSource("DOPE_PrecioTotVta") / IIf(drSource("TIPO_CodMND") = "001", drSource("TIPC_Venta"), 1)
        oRow("DDOV_Impuesto2") = 0
        oRow("DDOV_Impuesto2D") = 0
        oRow("DDOV_Impuesto3") = 0
        oRow("DDOV_Impuesto3D") = 0
        oRow("DDOV_Impuesto4") = 0
        oRow("DDOV_Impuesto4D") = 0
        oRow("DDOV_Notas") = ""
        oRow("DOCV_Codigo") = 0
        oRow("SERV_Codigo") = drSource("SERV_Codigo")
        oRow("DDOV_Descripcion") = ""
        oRow("AUDI_UsrCrea") = AppUser
        'oRow("AUDI_FecCrea") =
        oRow("AUDI_UsrMod") = AppUser
        'oRow("AUDI_FecMod") =
        oRow("DDOV_ValorTotal") = drSource("DOPE_PrecioTotVta") * IIf(drSource("TIPO_CodMND") = "002", drSource("TIPC_Venta"), 1)
        oRow("DDOV_ValorTotalD") = drSource("DOPE_PrecioTotVta") / IIf(drSource("TIPO_CodMND") = "001", drSource("TIPC_Venta"), 1)

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
    End Sub
End Class
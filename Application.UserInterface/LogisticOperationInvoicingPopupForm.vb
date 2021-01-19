Imports DevExpress.XtraGrid.Views.Grid

Public Class LogisticOperationInvoicingPopupForm
    Dim oAppService As New AppService.DelfinServiceClient
    Friend dtSource As New DataTable
    Friend oProcessType As String = ""
    Private Sub LogisticOperationInvoicingPopupForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTaxDocumentType()
        deFechaEmision.EditValue = Now

        If oProcessType = "Multiple" Then
            lueMoneda.ReadOnly = True
            lueFormaPago.ReadOnly = True
            seDiasCredito.ReadOnly = True
            deFechaVencimiento.ReadOnly = True
            lueSocioNegocio.ReadOnly = True
        End If
        lueTipoComprobante.ItemIndex = 0
        'gcDetail.DataSource = dtSource

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
        If DevExpress.XtraEditors.XtraMessageBox.Show("Se generarán las pre-facturas de las operciones seleccionadas, desea continuar? ", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If
        Dim bError As Boolean = True
        'For r = 0 To GridView1.RowCount - 1
        '    Dim oRow As DataRow = GridView1.GetDataRow(r)
        '    oRow("Checked") = IIf(IsDBNull(oRow("Checked")), False, oRow("Checked"))
        '    If oRow("Checked") = False Then
        '        Continue For
        '    End If
        '    'If Not oAppService.PreFacturar(1, AppUser) Then
        '    '    bError = False
        '    'End If

        'Next
        'If bError Then

        '    Return
        'End If
    End Sub

    Private Sub bbiClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiClose.ItemClick
        Close()
    End Sub

    Private Sub lueTipoComprobante_EditValueChanged(sender As Object, e As EventArgs) Handles lueTipoComprobante.EditValueChanged
        LoadTaxDocumentSerie()
    End Sub
End Class
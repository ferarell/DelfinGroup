Public Class OperationalTrackingForm
    Private oAppService As New OnlineService.OnLineServiceClient

    Private Sub OperationalTrackingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelControl1.Text = ""
        LoadCustomer()
    End Sub

    Private Sub LoadCustomer()
        Dim dtQuery As New DataTable
        dtQuery = oAppService.ExecuteSQL("EXEC NextSoft.dgp.paObtieneEmpresaVinculada " & ENTC_DocIden).Tables(0)
        lueCustomer.Properties.DataSource = dtQuery
        lueCustomer.Properties.DisplayMember = "DescripcionCliente"
        lueCustomer.Properties.ValueMember = "CodigoCliente"
        lueCustomer.ItemIndex = 0
    End Sub

    Private Sub bbiClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiClose.ItemClick
        Close()
    End Sub

    Private Sub bbiExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExport.ItemClick
        ExportToExcel(GridControl1)
    End Sub

    Private Sub bbiSearch_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSearch.ItemClick
        Dim dtQuery As New DataTable
        dtQuery = oAppService.OperationalTracking(lueCustomer.EditValue, teHBL.Text).Tables(0)
        GridControl1.DataSource = Nothing
        LabelControl1.Text = ""
        If dtQuery.Rows.Count = 0 Then
            LabelControl1.Text = "El HBL no existe o no está asociado a su empresa."
        Else
            GridControl1.DataSource = dtQuery
        End If
    End Sub
End Class
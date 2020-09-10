Imports DevExpress.XtraEditors.DXErrorProvider

Public Class ContactUsForm
    Private oAppService As New OnlineService.OnLineServiceClient
    Dim oMasterDataList As New MasterDataList

    Private Sub ContactUsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDocumentType()
    End Sub

    Private Sub LoadDocumentType()
        Dim dtSource As New DataTable
        dtSource = oMasterDataList.LoadMasterData("DocumentType")
        lueDocumentType.Properties.DataSource = dtSource
        lueDocumentType.Properties.DisplayMember = "DescripcionTipoDocumento"
        lueDocumentType.Properties.ValueMember = "DescripcionTipoDocumento"
    End Sub

    Private Sub bbiSendMail_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSendMail.ItemClick

    End Sub

    Private Sub bbiClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiClose.ItemClick
        Close()
    End Sub
End Class
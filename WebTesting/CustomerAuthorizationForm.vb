Public Class CustomerAuthorizationForm
    Private oAppService As New OnlineService.OnLineServiceClient
    Dim oMasterDataList As New MasterDataList
    Dim dsQuery As New DataSet

    Private Sub CustomerAuthorizationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCustomer()
        'LoadDocumentType()
        LoadRelationType()
        LoadValidityType()
        LoadAuthorizationType()
        NavBarGroup3.Visible = False
    End Sub

    Private Sub LoadCustomer()
        Dim dtQuery As New DataTable
        dtQuery = oAppService.ExecuteSQL("EXEC NextSoft.dgp.paObtieneEmpresaVinculada " & ENTC_DocIden).Tables(0)
        lueCustomer.Properties.DataSource = dtQuery
        lueCustomer.Properties.DisplayMember = "DescripcionCliente"
        lueCustomer.Properties.ValueMember = "CodigoCliente"
        lueCustomer.ItemIndex = 0
    End Sub

    Private Sub LoadCompany()
        Dim dtSource As New DataTable
        dtSource = oAppService.GetDataList("DocumentType", Nothing)
        lueCompany.Properties.DataSource = dtSource
        lueCompany.Properties.DisplayMember = "DescripcionTipoDocumento"
        lueCompany.Properties.ValueMember = "CodigoTipoDocumento"
    End Sub

    Private Sub LoadAuthorizationType()
        Dim dtSource As New DataTable
        dtSource = oMasterDataList.LoadMasterData("AuthorizationType")
        lueAuthorizationType.Properties.DataSource = dtSource
        lueAuthorizationType.Properties.DisplayMember = "DescripcionTipoAutorizacion"
        lueAuthorizationType.Properties.ValueMember = "CodigoTipoAutorizacion"
    End Sub

    Private Sub LoadRelationType()
        Dim dtSource As New DataTable
        dtSource = oMasterDataList.LoadMasterData("RelationType")
        lueRelationType.Properties.DataSource = dtSource
        lueRelationType.Properties.DisplayMember = "DescripcionTipoVinculacion"
        lueRelationType.Properties.ValueMember = "CodigoTipoVinculacion"
    End Sub

    Private Sub LoadValidityType()
        Dim dtSource As New DataTable
        dtSource = oMasterDataList.LoadMasterData("ValidityType")
        lueValidityType.Properties.DataSource = dtSource
        lueValidityType.Properties.DisplayMember = "DescripcionTipoVigencia"
        lueValidityType.Properties.ValueMember = "CodigoTipoVigencia"
    End Sub

    Private Sub bbiClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiClose.ItemClick
        Close()
    End Sub

    Private Sub GridControl1_EmbeddedNavigator_ButtonClick(sender As Object, e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs) Handles GridControl1.EmbeddedNavigator.ButtonClick, GridControl4.EmbeddedNavigator.ButtonClick

    End Sub

    Private Sub lueAuthorizationType_EditValueChanged(sender As Object, e As EventArgs) Handles lueAuthorizationType.EditValueChanged
        If lueAuthorizationType.EditValue = "001" Then
            NavBarGroup3.Visible = True
        Else
            NavBarGroup3.Visible = False
        End If
    End Sub

    Private Sub LoadRelatedCompany()
        If lueRelationType.EditValue Is Nothing Then
            Return
        End If
        Dim dtQuery As New DataTable
        dtQuery = oAppService.ExecuteSQL("EXEC NextSoft.web.upRelatedCompanyQuery " & ENTC_DocIden).Tables(0)
        lueCompany.Properties.DataSource = dtQuery.Select("CodigoTipoVinculacion='" & lueRelationType.EditValue & "'").CopyToDataTable
        lueCompany.Properties.DisplayMember = "ENTC_RazonSocial"
        lueCompany.Properties.ValueMember = "ENTC_DocIden"
    End Sub

    Private Sub lueCompany_Enter(sender As Object, e As EventArgs) Handles lueCompany.Enter
        LoadRelatedCompany()
    End Sub
End Class
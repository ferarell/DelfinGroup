Imports System.Threading
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.DXErrorProvider

Public Class CustomerRegisterForm
    Private oAppService As New OnlineService.OnLineServiceClient
    Dim oMasterDataList As New MasterDataList
    Dim dtDepa, dtProv, dtDist As New DataTable
    Dim dsQuery As New DataSet

    Private Sub CustomerRegisterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'LoadCustomer()
        LoadDocumentType()
        LoadCustomerData()
        LoadUbigeo()

    End Sub

    Private Sub bbiSearch_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSearch.ItemClick
        'LoadInputValidations()
        'If Not vpInputs.Validate Then
        '    Return
        'End If


    End Sub

    Private Sub LoadCustomerData()
        dsQuery.Clear()
        GridControl1.DataSource = Nothing
        GridControl2.DataSource = Nothing
        dsQuery = oAppService.GetDataByEntityType(1, ENTC_DocIden)
        If dsQuery Is Nothing Then
            Return
        End If

        'Cabecera
        If dsQuery.Tables(0).Rows.Count > 0 Then
            lueDocumentType.EditValue = dsQuery.Tables(0).Rows(0)("TIPO_CodTDI")
            teDocumentNumber.EditValue = dsQuery.Tables(0).Rows(0)("ENTC_DocIden")
            teCompany.EditValue = dsQuery.Tables(0).Rows(0)("ENTC_RazonSocial")
            teMail.EditValue = dsQuery.Tables(0).Rows(0)("ENTC_EMail")
            tePhone.EditValue = dsQuery.Tables(0).Rows(0)("ENTC_Telef1")
            teWebSite.EditValue = dsQuery.Tables(0).Rows(0)("ENTC_Web")
        End If

        'Direcciones
        If dsQuery.Tables(1).Rows.Count > 0 Then
            GridControl1.DataSource = dsQuery.Tables(1)

            GridView1.BestFitMaxRowCount = 1
        End If

        'Contactos
        If dsQuery.Tables(2).Rows.Count > 0 Then
            RepositoryItemLookUpEdit1.DataSource = lueDocumentType.Properties.DataSource
            RepositoryItemLookUpEdit1.DisplayMember = lueDocumentType.Properties.DisplayMember
            RepositoryItemLookUpEdit1.ValueMember = lueDocumentType.Properties.ValueMember
            GridControl2.DataSource = dsQuery.Tables(2)
            GridView2.BestFitColumns()
        End If
    End Sub

    Private Sub LoadCustomer()
        Dim dtQuery As New DataTable
        dtQuery = oAppService.ExecuteSQL("EXEC NextSoft.dgp.paObtieneEmpresaVinculada " & ENTC_DocIden).Tables(0)
        lueCustomer.Properties.DataSource = dtQuery
        lueCustomer.Properties.DisplayMember = "DescripcionCliente"
        lueCustomer.Properties.ValueMember = "CodigoCliente"
        lueCustomer.ItemIndex = 0
    End Sub

    Private Sub LoadDocumentType()
        Dim dtSource As New DataTable
        dtSource = oMasterDataList.LoadMasterData("DocumentType")
        lueDocumentType.Properties.DataSource = dtSource
        lueDocumentType.Properties.DisplayMember = "DescripcionTipoDocumento"
        lueDocumentType.Properties.ValueMember = "CodigoTipoDocumento"
    End Sub

    Private Sub bbiClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiClose.ItemClick
        Close()
    End Sub

    Private Sub LoadInputValidations()
        Validate()
        Dim containsValidationRule As New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        containsValidationRule.ConditionOperator = ConditionOperator.IsNotBlank
        containsValidationRule.ErrorText = "Asigne un valor."
        containsValidationRule.ErrorType = ErrorType.Critical
        Dim customValidationRule As New CustomValidationRule()
        customValidationRule.ErrorText = "Valor obligatorio."
        customValidationRule.ErrorType = ErrorType.Critical
        vpInputs.SetValidationRule(Me.lueCustomer, customValidationRule)
        vpInputs.SetValidationRule(Me.lueDocumentType, customValidationRule)
        vpInputs.SetValidationRule(Me.teDocumentNumber, customValidationRule)
    End Sub

    Private Sub lueCustomer_EditValueChanged(sender As Object, e As EventArgs) Handles lueCustomer.EditValueChanged
        LoadCustomerData()
    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        If dsQuery.Tables(0).Rows.Count = 0 Then
            Return
        End If
        'LoadUbigeo()
    End Sub

    Private Sub LoadUbigeo()
        Validate()
        dtDepa.Rows.Clear()
        dtDepa = oAppService.ExecuteSQL("EXEC NextSoft.dgp.paListaDepartamento " & dsQuery.Tables(0).Rows(0)("TIPO_CodPai").ToString).Tables(0)
        RepositoryItemLookUpEdit2.DataSource = dtDepa
        RepositoryItemLookUpEdit2.DisplayMember = "UBIG_Desc"
        RepositoryItemLookUpEdit2.ValueMember = "UBIG_Codigo"
        dtProv.Rows.Clear()
        dtProv = oAppService.ExecuteSQL("EXEC NextSoft.dgp.paListaProvincia " & dsQuery.Tables(0).Rows(0)("TIPO_CodPai").ToString & ", NULL").Tables(0)
        RepositoryItemLookUpEdit3.DataSource = dtProv
        RepositoryItemLookUpEdit3.DisplayMember = "UBIG_Desc"
        RepositoryItemLookUpEdit3.ValueMember = "UBIG_Codigo"
        dtDist.Rows.Clear()
        dtDist = oAppService.ExecuteSQL("EXEC NextSoft.dgp.paListaDistrito " & dsQuery.Tables(0).Rows(0)("TIPO_CodPai").ToString & ", NULL").Tables(0)
        RepositoryItemLookUpEdit4.DataSource = dtDist
        RepositoryItemLookUpEdit4.DisplayMember = "UBIG_Desc"
        RepositoryItemLookUpEdit4.ValueMember = "UBIG_Codigo"
    End Sub

    Private Sub LoadDepartamento()
        Dim dtDepa As New DataTable
        dtDepa = oAppService.ExecuteSQL("EXEC NextSoft.dgp.paListaDepartamento " & dsQuery.Tables(0).Rows(0)("TIPO_CodPai").ToString).Tables(0)
        RepositoryItemLookUpEdit3.DataSource = dtDepa
        RepositoryItemLookUpEdit3.DisplayMember = "UBIG_Desc"
        RepositoryItemLookUpEdit3.ValueMember = "UBIG_Codigo"
    End Sub

    Private Sub LoadProvincia(value As String)
        Dim dtProv As New DataTable
        dtProv = oAppService.ExecuteSQL("EXEC NextSoft.dgp.paListaProvincia " & dsQuery.Tables(0).Rows(0)("TIPO_CodPai").ToString & ",'" & value & "'").Tables(0)
        RepositoryItemLookUpEdit2.DataSource = dtProv
        RepositoryItemLookUpEdit2.DisplayMember = "UBIG_Desc"
        RepositoryItemLookUpEdit2.ValueMember = "UBIG_Codigo"
    End Sub

    Private Sub LoadDistrito(value As String)
        Dim dtDist As New DataTable
        dtDist = oAppService.ExecuteSQL("EXEC NextSoft.dgp.paListaDistrito " & dsQuery.Tables(0).Rows(0)("TIPO_CodPai").ToString & ",'" & value & "'").Tables(0)
        RepositoryItemLookUpEdit4.DataSource = dtDist
        RepositoryItemLookUpEdit4.DisplayMember = "UBIG_Desc"
        RepositoryItemLookUpEdit4.ValueMember = "UBIG_Codigo"
    End Sub

    Private Sub RepositoryItemLookUpEdit2_EditValueChanged(sender As Object, e As EventArgs) Handles RepositoryItemLookUpEdit2.EditValueChanged
        'Dim value As Object = TryCast(sender, LookUpEdit).EditValue
        'LoadProvincia(TryCast(sender, LookUpEdit).EditValue)       
        RepositoryItemLookUpEdit3.DataSource = dtProv.Select("UBIG_Codigo='" & GridView1.GetFocusedRowCellValue("DEPA_Codigo") & "'")
    End Sub

    Private Sub RepositoryItemLookUpEdit3_EditValueChanged(sender As Object, e As EventArgs) Handles RepositoryItemLookUpEdit3.EditValueChanged
        'LoadDistrito(TryCast(sender, LookUpEdit).EditValue)

    End Sub

    Private Sub GridControl1_EmbeddedNavigator_ButtonClick(sender As Object, e As NavigatorButtonClickEventArgs) Handles GridControl1.EmbeddedNavigator.ButtonClick
        If e.Button.ButtonType = NavigatorButtonType.Append Then
            GridView1.EditingValue = True
            'GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "DIRE_Item", (GridView1.RowCount + 1).ToString)
            'dsQuery.Tables(1).Rows.Add()
            'dsQuery.Tables(1).Rows(GridView1.RowCount - 1)("DIRE_Item") = GridView1.RowCount
        End If
    End Sub

    Private Sub bbiSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSave.ItemClick

    End Sub
End Class
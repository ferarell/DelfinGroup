Imports DevExpress.XtraEditors.DXErrorProvider

Public Class CustomerStatementQueryForm
    Private oAppService As New OnlineService.OnLineServiceClient

    Private Sub CustomerDebtQueryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCustomer()
        deDateTo.EditValue = Today
        deDateFrom.EditValue = DateAdd(DateInterval.Day, -180, Today)
    End Sub

    Private Sub LoadCustomer()
        Dim dtQuery As New DataTable
        dtQuery = oAppService.ExecuteSQL("EXEC NextSoft.dgp.paObtieneEmpresaVinculada " & ENTC_DocIden).Tables(0)
        lueCustomer.Properties.DataSource = dtQuery
        lueCustomer.Properties.DisplayMember = "DescripcionCliente"
        lueCustomer.Properties.ValueMember = "CodigoCliente"
        lueCustomer.ItemIndex = 0
    End Sub

    Private Sub bbiSearch_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSearch.ItemClick
        LoadInputValidations()
        If Not vpInputs.Validate Then
            Return
        End If
        gcMainData.DataSource = Nothing
        Dim dtQuery As New DataTable
        dtQuery = oAppService.CustomerStatementQuery(lueCustomer.EditValue.ToString, deDateFrom.EditValue, deDateTo.EditValue, Mid(cbeQueryType.EditValue, 1, 1), Nothing)
        gcMainData.DataSource = Nothing
        If dtQuery.Rows.Count = 0 Then
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "La consulta no retornó datos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        gcMainData.DataSource = dtQuery
        GridView1.BestFitColumns()
        GridView1.ExpandAllGroups()

    End Sub

    Private Sub bbiExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExport.ItemClick
        ExportToExcel(gcMainData)
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

    End Sub

End Class
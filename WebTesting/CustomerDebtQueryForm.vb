Imports DevExpress.XtraEditors.DXErrorProvider

Public Class CustomerDebtQueryForm
    Private oAppService As New OnlineService.OnLineServiceClient

    Private Sub CustomerDebtQueryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCustomer()
        LabelControl1.Text = ""
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
        dtQuery = oAppService.CustomerDebtQuery(lueCustomer.EditValue.ToString, teHBL.Text)
        LabelControl1.Text = ""
        If dtQuery.Rows.Count = 0 Then
            LabelControl1.Text = "El HBL no existe o no está asociado a su empresa"
        Else
            gcMainData.DataSource = dtQuery
        End If
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
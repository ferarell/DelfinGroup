Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Drawing
Imports System.IO
Imports System.Globalization
Imports DevExpress.XtraSplashScreen
Imports System.Threading

Public Class ComisionEjecutivosForm

    Private Sub bbiProcess_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiProcess.ItemClick
        LoadInputValidations()
        If Not vpInputs.Validate Then
            Return
        End If
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)
            DataProcess()
        Catch ex As Exception
            SplashScreenManager.CloseForm(False)
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        SplashScreenManager.CloseForm(False)
    End Sub

    Private Sub DataProcess()
        Dim sQuery As String = ""
        Dim dtQuery As New DataTable
        gcMainData.DataSource = Nothing
        sQuery = "EXEC nxs.OPE_CCOTSS_ReporteComisionEjecutivo 1, 1, NULL, NULL, '" & Format(deDateFrom.EditValue, "yyyyMMdd") & "', '" & Format(deDateTo.EditValue, "yyyyMMdd") & "', NULL, NULL, NULL"
        dtQuery = ExecuteSQL(sQuery)
        gcMainData.DataSource = dtQuery
        LayoutApply()
    End Sub

    Private Sub LayoutApply()
        For i = 0 To GridView1.Columns.Count - 1
            If GridView1.Columns(i).ColumnType = GetType(Double) Or GridView1.Columns(i).ColumnType = GetType(Decimal) Then
                GridView1.Columns(i).SummaryItem.SetSummary(DevExpress.Data.SummaryItemType.Sum, "{0:n2}")
                GridView1.Columns(i).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                GridView1.Columns(i).DisplayFormat.FormatString = "n2"
            End If
        Next
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
        vpInputs.SetValidationRule(Me.deDateFrom, customValidationRule)
        vpInputs.SetValidationRule(Me.deDateTo, customValidationRule)
    End Sub

    Private Sub bbiExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExport.ItemClick
        ExportarExcel(gcMainData)
    End Sub

    Private Sub bbiClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiClose.ItemClick
        Close()
    End Sub
End Class
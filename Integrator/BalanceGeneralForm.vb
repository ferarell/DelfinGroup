Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Drawing
Imports System.IO
Imports System.Globalization
Imports DevExpress.XtraSplashScreen
Imports System.Threading

Public Class BalanceGeneralForm
    Dim dtQuery, dtPrint, dtPrint1, dtPrint2 As New DataTable
    Dim bError As Boolean = False
    Dim AppCode As String = ""
    Dim dsMain As New dsSunat

    Private Sub BalanceGeneralForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bbiExport.Enabled = False
        bbiPrint.Enabled = False
        seFiscalYear.Text = Year(Now).ToString
        seFiscalPeriod.Text = Month(Now).ToString
        dtPrint = dsMain.Tables("ReportLayout")
        Try
            LoadCompany()
        Catch ex As Exception
            bError = True
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadCompany()
        dtCompany = GetCompaniesList("NEXTSIS")
        lueCompany.Properties.DataSource = dtCompany
        lueCompany.Properties.DisplayMember = "CompanyName"
        lueCompany.Properties.ValueMember = "CompanyCode"
    End Sub

    Private Sub bbiClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiClose.ItemClick
        Close()
    End Sub

    Private Sub bbiPrint_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiPrint.ItemClick
        Dim pForm As New PrintForm
        pForm.dtPrint = dtPrint
        pForm.dtPrint1 = dtPrint1
        pForm.dtPrint2 = dtPrint2
        pForm.aParams = GetParamValues()
        pForm.RptFile = "BalanceGeneral.rpt"
        pForm.RptSegments = 2
        pForm.ShowDialog()
    End Sub

    Friend Function GetParamValues() As ArrayList
        Dim aParams As New ArrayList
        aParams.Add("BALANCE GENERAL")
        aParams.Add(seFiscalYear.Text & "-" & Format(seFiscalPeriod.EditValue, "00"))
        aParams.Add(lueCompany.GetColumnValue("DocumentID"))
        aParams.Add(lueCompany.GetColumnValue("CompanyName"))
        aParams.Add(rgCurrency.Properties.Items(rgCurrency.SelectedIndex).Description)
        Return aParams
    End Function

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
        Dim dAmount1 As Double = 0
        Dim dAmount2 As Double = 0
        dtQuery.Rows.Clear()
        AppCode = lueCompany.EditValue
        If rgType.EditValue = "R" Then
            sQuery += "EXEC Integrador..paBalanceGeneral 6" & ", '" & AppCode & "','" & seFiscalYear.Text & "','" & Format(seFiscalPeriod.EditValue, "00") & "','" & rgCurrency.EditValue & "'"
            gcMainData.MainView = GridView1
        Else
            sQuery += "EXEC Integrador..paBalanceGeneral 10" & ", '" & AppCode & "','" & seFiscalYear.Text & "','" & Format(seFiscalPeriod.EditValue, "00") & "','" & rgCurrency.EditValue & "'"
            gcMainData.MainView = GridView2
        End If
        dtQuery = ExecuteSQL(sQuery)
        If dtQuery.Rows.Count = 0 Then
            SplashScreenManager.CloseForm(False)
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "La consulta no retornó datos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If dtQuery.Rows.Count > 0 Then
            bbiExport.Enabled = True
            bbiPrint.Enabled = True
        End If
        If dtQuery.Columns.Count = 0 Then
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "La consulta no retornó información.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        dtPrint.Rows.Clear()
        dtPrint = GetDataPrint(dtQuery)
        dtPrint1 = dtPrint.Select("segment_id=1", "group_id, line_no, code_id").CopyToDataTable
        dtPrint2 = dtPrint.Select("segment_id=2", "group_id, line_no, code_id").CopyToDataTable
        gcMainData.DataSource = dtQuery.Select("line_no<>0 AND amount1+amount2<>0").CopyToDataTable
        If rgType.EditValue = "D" Then
            GridView2.ExpandAllGroups()
        End If
        'LayoutApply()
    End Sub

    Private Function GetDataPrint(dtSource As DataTable) As DataTable
        Dim dAmount1, dAmount2 As Double
        dAmount1 = 0
        dAmount2 = 0
        For Each row As DataRow In dtSource.Rows
            row("account_id") = IIf(IsDBNull(row("account_id")), "", row("account_id"))
            If row("account_id") <> "" Then
                dAmount1 += row("amount1") * (row("factor") * -1)
                dAmount2 += row("amount2") * (row("factor") * -1)
            End If
            If dtPrint.Select("code_id='" & row("code_id") & "'").Length = 0 Then
                dtPrint.ImportRow(row)
            Else
                If row("account_id") <> "" Then
                    dtPrint.Rows(dtPrint.Rows.Count - 1)("amount1") += (row("amount1") * row("factor"))
                    dtPrint.Rows(dtPrint.Rows.Count - 1)("amount2") += (row("amount2") * row("factor"))
                End If
            End If
                If row("account_id") = "0" Then
                dtPrint.Rows(dtPrint.Rows.Count - 1)("amount1") = dAmount1
                dtPrint.Rows(dtPrint.Rows.Count - 1)("amount2") = dAmount2
            End If
        Next
        Return dtPrint
    End Function

    Private Sub LayoutApply()
        For i = 5 To 6
            GridView1.Columns(i).OptionsColumn.ReadOnly = True
            GridView1.Columns(i).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridView1.Columns(i).DisplayFormat.FormatString = "###,###,##0.00"
            GridView1.Columns(i).SummaryItem.SetSummary(DevExpress.Data.SummaryItemType.Sum, "{0:n2}")
            GridView1.Columns(i).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridView1.Columns(i).DisplayFormat.FormatString = "n2"
        Next

    End Sub
    Private Sub bbiExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExport.ItemClick
        ExportarExcel(gcMainData)
    End Sub

    Private Sub bbiDetailView_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiDetailView.ItemClick
        gcMainData.MainView = GridView2
    End Sub

    Private Sub bbiSummaryView_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSummaryView.ItemClick
        gcMainData.MainView = GridView1
    End Sub

    Private Sub rgTipoAsiento_SelectedIndexChanged(sender As Object, e As EventArgs)
        seFiscalPeriod.Enabled = False
        If sender.selectedindex = 0 Then
            seFiscalPeriod.EditValue = 1
        ElseIf sender.selectedindex = 2 Then
            seFiscalPeriod.EditValue = 12
        ElseIf sender.selectedindex = 1 Then
            seFiscalPeriod.Enabled = True
        End If
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
        vpInputs.SetValidationRule(Me.lueCompany, customValidationRule)
    End Sub

    Private Sub BalanceGeneralForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If bError Then
            Close()
        End If
    End Sub
End Class
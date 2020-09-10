Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Drawing
Imports System.IO
Imports System.Globalization
Imports DevExpress.XtraSplashScreen
Imports System.Threading

Public Class LibroInventariosBalancesForm
    Dim dtQuery, dtPrint1, dtPrint2 As New DataTable
    Dim FecIni, FecFin As String
    Dim bError As Boolean = False

    Private Sub LibroInventariosBalancesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bbiExport.Enabled = False
        bbiPrint.Enabled = False
        seFiscalYear.Text = Year(Now).ToString
        seFiscalPeriod.Text = Month(Now).ToString
        Try
            LoadInputValidations()
            LoadCompany()
            LoadReport()
        Catch ex As Exception
            bError = True
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadCompany()
        dtCompany = GetCompaniesList(rgDataSource.EditValue)
        lueCompany.Properties.DataSource = dtCompany
        lueCompany.Properties.DisplayMember = "CompanyName"
        lueCompany.Properties.ValueMember = "AppCode"
    End Sub

    Private Sub LoadReport()
        Dim dtReports As New DataTable
        dtReports = NewExecuteSQL("SELECT * FROM Reportes.dbo.viReportLayout WHERE report_type_id = 5 ORDER BY report_id")
        lueReport.Properties.DataSource = dtReports
        lueReport.Properties.DisplayMember = "report_name"
        lueReport.Properties.ValueMember = "report_id"
    End Sub

    Private Sub bbiClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiClose.ItemClick
        Close()
    End Sub

    Private Sub bbiPrint_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiPrint.ItemClick
        Dim pForm As New PrintForm
        If lueReport.GetColumnValue("group_id") = 1 Then
            pForm.RptSegments = 2
        End If
        If lueReport.GetColumnValue("group_id") = 4 Then
            pForm.dtPrint = UpdateDataPrint2(dtQuery)
        Else
            pForm.dtPrint = dtQuery
        End If

        pForm.dtPrint1 = dtPrint1
        pForm.dtPrint2 = dtPrint2
        pForm.aParams = GetParamValues()
        pForm.RptFile = lueReport.GetColumnValue("report_filename") & ".rpt"
        pForm.ShowDialog()
    End Sub

    Private Function UpdateDataPrint1()
        For r = 0 To dtQuery.Rows.Count - 1
            Dim oRow As DataRow = dtQuery.Rows(r)
            oRow("account_id") = IIf(IsDBNull(oRow("account_id")), "", oRow("account_id"))
            If oRow("account_id") <> "" Then
                oRow("amount1") = oRow("amount1") * oRow("factor")
            End If
            If oRow("account_id") = "0" Then
                oRow("amount1") = dtQuery.Compute("SUM(amount1) * -1", "")
            End If
        Next
        Return dtQuery
    End Function

    Private Function UpdateDataPrint2(dtSource As DataTable) As DataTable
        Dim dAmount1, dAmountI1, dAmountC1, dAmountCI1 As Double
        dAmount1 = 0
        dAmountI1 = 0
        dAmountC1 = 0
        dAmountCI1 = 0
        dtSource = dtSource.Select("", "group_id,line_no").CopyToDataTable
        For Each row As DataRow In dtSource.Rows
            row("account_id") = IIf(IsDBNull(row("account_id")), "", row("account_id"))
            If row("line_no") <> 99 Then
                If row("group_id") = 1 Then
                    dAmountI1 += row("amount1")
                Else
                    dAmountC1 += row("amount1")
                    dAmount1 += row("amount1")
                End If
            ElseIf row("line_no") = 99 Then
                If row("group_id") = 1 Then
                    row("amount1") = dAmountI1
                ElseIf row("group_id") = 2 Then
                    row("amount1") = dAmountC1 * -1
                Else
                    row("amount1") = dAmountI1 + dAmountC1 - dAmount1
                End If
                dAmount1 = 0
            End If
        Next
        Return dtSource.Select("", "code_id").CopyToDataTable
    End Function

    Friend Function GetParamValues() As ArrayList
        Dim aParams As New ArrayList
        Dim sPeriod As String = MonthName(seFiscalPeriod.EditValue).ToUpper & " " & seFiscalYear.Text
        aParams.Add(lueReport.GetColumnValue("report_name"))
        aParams.Add(sPeriod)
        aParams.Add(lueCompany.GetColumnValue("DocumentID"))
        aParams.Add(lueCompany.GetColumnValue("CompanyName"))
        aParams.Add("Soles")
        If lueReport.GetColumnValue("group_id") = 2 Then
            aParams.Add(lueReport.GetColumnValue("remarks"))
        End If
        Return aParams
    End Function

    Private Sub bbiProcess_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiProcess.ItemClick
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
        FecIni = seFiscalYear.Text & "-01-01"
        FecFin = seFiscalYear.Text & "-12-31"
        dtQuery = GetCompanyDetail(lueCompany.EditValue, rgDataSource.EditValue)
        If lueReport.GetColumnValue("group_id") = 1 Then
            sQuery += "EXEC " & lueReport.GetColumnValue("procedure_id") & " 10,'" & dtQuery.Rows(0)(3) & "','" & seFiscalYear.Text & "','" & seFiscalPeriod.Text & "','ML'"
        ElseIf lueReport.GetColumnValue("group_id") = 2 Then
            sQuery += "EXEC " & lueReport.GetColumnValue("procedure_id") & " '" & dtQuery.Rows(0)(3) & " ', NULL, '" & Replace(FecIni, "-", "") & "', '" & Replace(FecFin, "-", "") & "','" & lueReport.GetColumnValue("account_id") & "', NULL"
        ElseIf lueReport.GetColumnValue("group_id") = 3 Then
            sQuery += "EXEC " & lueReport.GetColumnValue("procedure_id") & " '" & dtQuery.Rows(0)(3) & "','" & seFiscalYear.Text & "','" & seFiscalPeriod.Text & "','ML'"
        ElseIf lueReport.GetColumnValue("group_id") = 4 Then
            sQuery += "EXEC " & lueReport.GetColumnValue("procedure_id") & " 7,'" & dtQuery.Rows(0)(3) & "','" & seFiscalYear.Text & "','" & seFiscalPeriod.Text & "','ML'"
        End If
        dtQuery.Rows.Clear()
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
        If lueReport.GetColumnValue("group_id") = 1 Then
            dtQuery = UpdateDataPrint1()
            dtPrint1 = dtQuery.Select("segment_id=1", "group_id, line_no, code_id").CopyToDataTable
            dtPrint2 = dtQuery.Select("segment_id=2", "group_id, line_no, code_id").CopyToDataTable
        End If
        gcExternalData.DataSource = dtQuery
        gcExternalData.MainView.PopulateColumns()
        'LayoutApply()
    End Sub

    Private Sub LayoutApply()
        GridView1.PopulateColumns()
        GridView1.Columns(3).Visible = False
        GridView1.Columns(12).Visible = False
        For i = 8 To 9
            GridView1.Columns(i).SummaryItem.SetSummary(DevExpress.Data.SummaryItemType.Sum, "{0:n2}")
            GridView1.Columns(i).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridView1.Columns(i).DisplayFormat.FormatString = "n2"
        Next

    End Sub
    Private Sub bbiExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExport.ItemClick
        ExportarExcel(gcExternalData)
    End Sub

    Private Sub rgTipoAsiento_SelectedIndexChanged(sender As Object, e As EventArgs)

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
        vpInputs.SetValidationRule(Me.lueReport, customValidationRule)
    End Sub

    Private Sub LibroDiarioForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        If bError Then
            Close()
        End If
    End Sub

    Private Sub rgDataSource_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rgDataSource.SelectedIndexChanged
        LoadCompany()
    End Sub
End Class
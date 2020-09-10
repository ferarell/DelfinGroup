Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Drawing
Imports System.IO
Imports System.Globalization
Imports DevExpress.XtraSplashScreen
Imports System.Threading

Public Class LibroMayorForm
    Dim dtQuery As New DataTable
    Dim FecIni, FecFin As String
    Dim bError As Boolean = False

    Private Sub LibroDiarioForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bbiExport.Enabled = False
        bbiPrint.Enabled = False
        seFiscalYear.Text = Year(Now).ToString
        seFiscalPeriod.Text = Month(Now).ToString
        Try
            LoadInputValidations()
            LoadCompany()
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

    Private Sub bbiClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiClose.ItemClick
        Close()
    End Sub

    Private Sub bbiPrint_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiPrint.ItemClick
        Dim pForm As New PrintForm
        pForm.dtPrint = dtQuery
        pForm.aParams = GetParamValues()
        pForm.RptFile = "LibroMayor.rpt"
        pForm.ShowDialog()
    End Sub

    Friend Function GetParamValues() As ArrayList
        Dim aParams As New ArrayList
        Dim sPeriod As String = MonthName(seFiscalPeriod.EditValue).ToUpper & " " & seFiscalYear.Text
        aParams.Add("FORMATO 6.1 - LIBRO MAYOR")
        aParams.Add(sPeriod)
        aParams.Add(lueCompany.GetColumnValue("DocumentID"))
        aParams.Add(lueCompany.GetColumnValue("CompanyName"))
        aParams.Add("Soles")
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
        FecIni = seFiscalYear.Text & "-" & Format(seFiscalPeriod.EditValue, "00") & "-01"
        FecFin = Format(LastDayOfMonth(FecIni), "yyyy-MM-dd")
        dtQuery = GetCompanyDetail(lueCompany.EditValue, rgDataSource.EditValue)
        sQuery += "EXEC con.paLibroDiarioMayor '" & dtQuery.Rows(0)(3) & "', '" & Mid(seFiscalYear.Text, 3, 2) & "', '" & dtQuery.Rows(0)(4) & "', '" & Replace(FecIni, "-", "") & "', '" & Replace(FecFin, "-", "") & "', '01', '99', 'MN'"
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
        'Dim sCurrency As String = ""
        If dtQuery.Columns.Count = 0 Then
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "La consulta no retornó información.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        'For Each row As DataRow In dtQuery.Rows
        '    sCurrency = "PEN"
        '    If Not IsDBNull(row("currency_id")) Then
        '        sCurrency = "USD"
        '    End If
        '    dtPrint.Rows.Add(row("move"), row("date"), row("glosa"), row("t8_code"), row("move"), row("account_code"), row("account_name"), sCurrency, row("debit"), row("credit"), IIf(row("debit") > 0, row("amount_currency"), 0), IIf(row("credit") > 0, row("amount_currency"), 0), row("sequence_report") & row("move") & row("move_id"))
        'Next
        gcExternalData.DataSource = dtQuery
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

    Private Sub LibroMayorForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If bError Then
            Close()
        End If
    End Sub
End Class
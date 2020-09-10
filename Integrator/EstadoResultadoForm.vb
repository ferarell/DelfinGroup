Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Drawing
Imports System.IO
Imports System.Globalization
Imports DevExpress.XtraSplashScreen
Imports System.Threading

Public Class EstadoResultadoForm
    Dim dtQuery, dtPrint As New DataTable
    Dim bError As Boolean = False
    Dim AppCode As String = ""
    Dim dsMain As New dsSunat

    Private Sub EstadoResultadoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        dtPrint = GetDataPrint(dtQuery)
        pForm.dtPrint = dtPrint
        pForm.aParams = GetParamValues()
        pForm.RptFile = "EstadoResultado.rpt"
        pForm.ShowDialog()
    End Sub

    Friend Function GetParamValues() As ArrayList
        Dim aParams As New ArrayList
        aParams.Add("ESTADO DE GANANCIAS Y PÉRDIDAS")
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
        sQuery += "EXEC Integrador..paEstadoResultado 7" & ", '" & AppCode & "','" & seFiscalYear.Text & "','" & Format(seFiscalPeriod.EditValue, "00") & "','" & rgCurrency.EditValue & "'"
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
        'dtPrint = GetDataPrint(dtQuery)
        gcMainData.DataSource = dtQuery.Select("line_no<>99 AND amount1+amount2<>0").CopyToDataTable
        GridView2.ExpandAllGroups()
    End Sub

    Private Function GetDataPrint(dtSource As DataTable) As DataTable
        Dim dAmount1, dAmount2, dAmountI1, dAmountI2, dAmountC1, dAmountC2, dAmountCI1, dAmountCI2 As Double
        dAmount1 = 0
        dAmount2 = 0
        dAmountI1 = 0
        dAmountI2 = 0
        dAmountC1 = 0
        dAmountC2 = 0
        dAmountCI1 = 0
        dAmountCI2 = 0
        dtSource = dtSource.Select("", "group_id,line_no").CopyToDataTable
        For Each row As DataRow In dtSource.Rows
            row("account_id") = IIf(IsDBNull(row("account_id")), "", row("account_id"))
            If row("line_no") <> 99 Then
                If row("group_id") = 1 Then
                    dAmountI1 += row("amount1")
                    dAmountI2 += row("amount2")
                Else
                    dAmountC1 += row("amount1")
                    dAmountC2 += row("amount2")
                    dAmount1 += row("amount1")
                    dAmount2 += row("amount2")
                End If
            ElseIf row("line_no") = 99 Then
                If row("group_id") = 1 Then
                    row("amount1") = dAmountI1
                    row("amount2") = dAmountI2
                ElseIf row("group_id") = 2 Then
                    row("amount1") = dAmountC1 * -1
                    row("amount2") = dAmountC2 * -1
                Else
                    row("amount1") = dAmountI1 + dAmountC1 - dAmount1
                    row("amount2") = dAmountI2 + dAmountC2 - dAmount2
                End If
                dAmount1 = 0
                dAmount2 = 0
            End If
        Next
        'gcMainData.DataSource = dtSource
        'gcMainData.MainView = GridView1
        'GridView1.PopulateColumns()
        Return dtSource.Select("", "code_id").CopyToDataTable
    End Function

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
        ExportarExcel(gcMainData)
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

    Private Sub EstadoResultadoForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If bError Then
            Close()
        End If
    End Sub
End Class
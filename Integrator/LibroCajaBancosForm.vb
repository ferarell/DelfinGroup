Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Drawing
Imports System.IO
Imports System.Globalization
Imports DevExpress.XtraSplashScreen
Imports System.Threading

Public Class LibroCajaBancosForm
    Dim dtQuery As New DataTable
    Dim FecIni, FecFin As String
    Dim bError As Boolean = False
    Dim RptId As String = "1"

    Private Sub LibroCajaBancosForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        pForm.RptFile = "LibroCajaBancos" & rgFormat.EditValue & ".rpt"
        pForm.ShowDialog()
    End Sub

    Friend Function GetParamValues() As ArrayList
        Dim aParams As New ArrayList
        Dim sPeriod As String = MonthName(seFiscalPeriod.EditValue).ToUpper & " " & seFiscalYear.Text
        Dim sFormat As String = "LIBRO CAJA Y BANCOS - DETALLE DE LOS MOVIMIENTOS "
        If rgFormat.EditValue = "1" Then
            sFormat += "DEL EFECTIVO (Formato 1.1)"
        Else
            sFormat += "DE LA CUENTA CORRIENTE (Formato 1.2)"
        End If
        aParams.Add(sFormat)
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
        sQuery += "EXEC con.paLibroCajaBancos '" & dtQuery.Rows(0)(3) & "', '" & Mid(seFiscalYear.Text, 3, 2) & "', '" & dtQuery.Rows(0)(4) & "', '" & Replace(FecIni, "-", "") & "', '" & Replace(FecFin, "-", "") & "', '01', '99', 'MN'"
        dtQuery.Rows.Clear()
        If rgFormat.EditValue = "1" Then
            dtQuery = ExecuteSQL(sQuery).Select("CTA3='101'").CopyToDataTable
        Else
            dtQuery = ExecuteSQL(sQuery).Select("CTA3='104'").CopyToDataTable
        End If
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

    Private Sub LibroDiarioForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        If bError Then
            Close()
        End If
    End Sub

    Private Sub rgDataSource_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rgDataSource.SelectedIndexChanged
        LoadCompany()
    End Sub
End Class
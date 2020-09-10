Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Drawing
Imports System.IO
Imports System.Globalization
Imports DevExpress.XtraSplashScreen
Imports System.Threading
Imports DevExpress.Utils.ViewInfo

Public Class BalanceComprobacionForm
    Dim dtQuery, dtPrint As New DataTable
    Dim bError As Boolean = False
    Dim AppCode As String = ""

    Private Sub BalanceComprobacionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bbiExport.Enabled = False
        bbiPrint.Enabled = False
        seFiscalYear.Text = Year(Now).ToString
        seFiscalPeriod.Text = Month(Now).ToString
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
        pForm.aParams = GetParamValues()
        pForm.RptFile = "BalanceComprobacion.rpt"
        pForm.ShowDialog()
    End Sub

    Friend Function GetParamValues() As ArrayList
        Dim aParams As New ArrayList
        aParams.Add("BALANCE DE COMPROBACIÓN")
        aParams.Add(GetConditions())
        aParams.Add(lueCompany.GetColumnValue("DocumentID"))
        aParams.Add(lueCompany.GetColumnValue("CompanyName"))
        aParams.Add(lueCompany.GetColumnValue("CompanyAddress"))
        Return aParams
    End Function

    Friend Function GetConditions() As String
        Dim RptCnd As String = "Condiciones: "
        RptCnd += "Periodo = " & seFiscalYear.Text & "-" & Format(seFiscalPeriod.EditValue, "00")
        RptCnd += ", Moneda = " & rgCurrency.Properties.Items(rgCurrency.SelectedIndex).Description
        Return RptCnd
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
        sQuery += "EXEC Integrador..paBalanceComprobacion '" & AppCode & "','" & seFiscalYear.Text & "','" & Format(seFiscalPeriod.EditValue, "00") & "','" & rgCurrency.EditValue & "'"
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
        dtPrint = dtQuery
        gcMainData.DataSource = dtPrint
        LayoutApply()
    End Sub

    Private Sub LayoutApply()
        For i = 3 To GridView1.Columns.Count - 1
            GridView1.Columns(i).OptionsColumn.ReadOnly = True
            GridView1.Columns(i).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridView1.Columns(i).DisplayFormat.FormatString = "###,###,##0.00"
            GridView1.Columns(i).SummaryItem.SetSummary(DevExpress.Data.SummaryItemType.Sum, "{0:n2}")
            GridView1.Columns(i).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridView1.Columns(i).DisplayFormat.FormatString = "n2"
        Next
        For r = 7 To 10
            GridView2.Columns(r).OptionsColumn.ReadOnly = True
            GridView2.Columns(r).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridView2.Columns(r).DisplayFormat.FormatString = "###,###,##0.00"
            GridView2.Columns(r).SummaryItem.SetSummary(DevExpress.Data.SummaryItemType.Sum, "{0:n2}")
            GridView2.Columns(r).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridView2.Columns(r).DisplayFormat.FormatString = "n2"
        Next
    End Sub
    Private Sub bbiExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExport.ItemClick
        If GridView2.IsFocusedView Then
            ExportarExcel(gcAccountDetail)
        Else
            ExportarExcel(gcMainData)
        End If
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

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        If e.FocusedRowHandle < 0 Then
            Return
        End If
        Dim dtResult As New DataTable
        Dim sQuery, sFecIni, sFecFin As String
        Dim sPeriod As String = Format(IIf(seFiscalPeriod.EditValue = 0, 1, IIf(seFiscalPeriod.EditValue = 13, 12, seFiscalPeriod.EditValue)), "00")
        sFecIni = seFiscalYear.Text & "0101"
        sFecFin = Format(LastDayOfMonth(seFiscalYear.Text & "-" & sPeriod & "-01"), "yyyyMMdd")
        sQuery = "EXEC Integrador..paMovimientoContable '" & AppCode & "','','" & sFecIni & "','" & sFecFin & "','" & GridView1.GetFocusedRowCellValue("CUEN_Codigo").ToString.Trim & "',''," & IIf(seFiscalPeriod.EditValue = 13, 1, 0).ToString
        dtResult = ExecuteSQL(sQuery)
        gcAccountDetail.DataSource = dtResult
    End Sub

    Private Sub GridView2_DoubleClick(sender As Object, e As EventArgs) Handles GridView2.DoubleClick
        Dim oRow As DataRow = GridView2.GetDataRow(GridView2.FocusedRowHandle)
        Dim oForm As New VoucherViewerForm
        oForm.Empresa = lueCompany.EditValue
        oForm.Ejercicio = oRow("CABA_Ano")
        oForm.Mes = oRow("CABA_Mes")
        oForm.Libro = oRow("TIPO_tipReg")
        oForm.NoAsiento = oRow("CABA_NroVoucher")
        oForm.Show()
    End Sub
End Class
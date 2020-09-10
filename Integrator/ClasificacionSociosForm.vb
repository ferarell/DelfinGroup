Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Drawing
Imports System.IO
Imports System.Globalization
Imports DevExpress.XtraSplashScreen
Imports System.Threading
Imports DevExpress.Utils.ViewInfo

Public Class ClasificacionSociosForm
    Dim oAppService As New AppService.DelfinServiceClient
    Dim dsQuery As New DataSet
    Dim dtPrint As New DataTable
    Dim bError As Boolean = False
    Dim AppCode As String = ""

    Private Sub BalanceComprobacionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EnableButtons(False)
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
        pForm.RptFile = "ClasificacionSocios.rpt"
        pForm.ShowDialog()
    End Sub

    Friend Function GetParamValues() As ArrayList
        Dim aParams As New ArrayList
        aParams.Add("CLASIFICACIÓN DE " & rgPartnerType.Properties.Items(rgPartnerType.SelectedIndex).Description.ToUpper)
        aParams.Add(GetConditions())
        aParams.Add(lueCompany.GetColumnValue("DocumentID"))
        aParams.Add(lueCompany.GetColumnValue("CompanyName"))
        aParams.Add(lueCompany.GetColumnValue("CompanyAddress"))
        Return aParams
    End Function

    Friend Function GetConditions() As String
        Dim RptCnd As String = "Condiciones: "
        'RptCnd += "Periodo = " & seFiscalYear.Text & "-" & Format(seFiscalPeriod.EditValue, "00")
        'RptCnd += ", Moneda = " & rgCurrency.Properties.Items(rgCurrency.SelectedIndex).Description
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
        Dim dtSummary As New DataTable
        Dim sQuery As String = ""
        Dim dAmount1 As Double = 0
        Dim dAmount2 As Double = 0
        dsQuery.Tables.Clear()
        'AppCode = GetCompanyDetail(lueCompany.EditValue, rgDataSource.EditValue)(0)(3)
        If rgDataSource.SelectedIndex = 0 Then
            sQuery = "EXEC Integrador.con.paDetalleContableSocios '" & lueCompany.EditValue & "','" & Format(deDateFrom.EditValue, "yy") & "','CONCARPE','" & Format(deDateFrom.EditValue, "yyyyMMdd") & "','" & Format(deDateTo.EditValue, "yyyyMMdd") & "','" & rgPartnerType.EditValue & "'"
        Else
            sQuery = "EXEC Integrador.dbo.paDetalleContableSocios '" & lueCompany.EditValue & "','" & Format(deDateFrom.EditValue, "yyyyMMdd") & "','" & Format(deDateTo.EditValue, "yyyyMMdd") & "','" & rgPartnerType.EditValue & "'"
        End If
        dsQuery = oAppService.ExecuteSQL(sQuery)
        'dtDetail = dsQuery.Tables(0)
        If sePosition.EditValue = 0 Then
            dtSummary = dsQuery.Tables(1)
        Else
            dtSummary = dsQuery.Tables(1).AsEnumerable().Take(sePosition.EditValue).CopyToDataTable()
        End If
        'dtSummary.AsEnumerable().Take(seFiscalPeriod.EditValue).CopyToDataTable()
        dtSummary.Columns.Add("Posicion", GetType(Integer))
        For r = 0 To dtSummary.Rows.Count - 1
            dtSummary.Rows(r).Item("Posicion") = r + 1
        Next
        If dtSummary.Rows.Count = 0 Then
            SplashScreenManager.CloseForm(False)
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "La consulta no retornó datos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        gcMainData.DataSource = dtSummary
        GridView1.MoveNext()
        GridView1.MovePrev()
        LayoutApply()
    End Sub

    Private Sub LayoutApply()
        For i = 3 To GridView1.Columns.Count - 1
            'GridView1.Columns(i).OptionsColumn.ReadOnly = True
            GridView1.Columns(i).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridView1.Columns(i).DisplayFormat.FormatString = "###,###,##0.00"
            GridView1.Columns(i).SummaryItem.SetSummary(DevExpress.Data.SummaryItemType.Sum, "{0:n2}")
            GridView1.Columns(i).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridView1.Columns(i).DisplayFormat.FormatString = "n2"
        Next
        For r = 10 To 11
            GridView2.Columns(r).OptionsColumn.ReadOnly = True
            GridView2.Columns(r).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridView2.Columns(r).DisplayFormat.FormatString = "###,###,##0.00"
            GridView2.Columns(r).SummaryItem.SetSummary(DevExpress.Data.SummaryItemType.Sum, "{0:n2}")
            GridView2.Columns(r).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridView2.Columns(r).DisplayFormat.FormatString = "n2"
        Next
    End Sub
    Private Sub bbiExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExport.ItemClick
        If gcAccountDetail.MainView.IsFocusedView Then
            ExportarExcel(gcAccountDetail)
        Else
            ExportarExcel(gcMainData)
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
        Dim dtDetail As New DataTable
        dtDetail = dsQuery.Tables(0).Select("RUC='" & GridView1.GetFocusedRowCellValue("RUC") & "'").CopyToDataTable
        gcAccountDetail.DataSource = dtDetail
    End Sub

    Private Sub gcMainData_DataSourceChanged(sender As Object, e As EventArgs) Handles gcMainData.DataSourceChanged
        EnableButtons(False)
        If GridView1.RowCount > 0 Then
            EnableButtons(True)
        End If
    End Sub

    Private Sub EnableButtons(bEnabled As Boolean)
        bbiExport.Enabled = bEnabled
        bbiPrint.Enabled = bEnabled
    End Sub

End Class
Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Drawing
Imports System.IO
Imports System.Globalization
Imports DevExpress.XtraSplashScreen
Imports System.Threading
Imports DevExpress.Utils.ViewInfo

Public Class CierreAperturaForm
    Dim dtBalance, dtCloseYear, dtOpenYear, dtVoucherH, dtVoucherD As New DataTable
    Dim dsVoucher As New DataSet
    Dim sVoucher As String = ""
    Dim oAppService As New AppService.DelfinServiceClient

    Private Sub CierreAperturaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bbiExport.Enabled = False
        bbiVoucher.Enabled = False
        lbCloseYear.Text = ""
        lbOpenYear.Text = ""
        seFiscalYear.Text = (Year(Now) - 1).ToString
        Try
            LoadCompany()
        Catch ex As Exception
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

    Private Sub bbiProcess_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiProcess.ItemClick
        LoadInputValidations()
        If Not vpInputs.Validate Then
            Return
        End If
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)
            LayoutApply()
            CloseDataProcess()
            OpenDataProcess()
        Catch ex As Exception
            SplashScreenManager.CloseForm(False)
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        SplashScreenManager.CloseForm(False)
    End Sub

    Private Sub CloseDataProcess()
        Dim sQuery As String = ""
        Dim iPos As Integer = 0
        Dim dLocAmount As Double = 0
        Dim dExtAmount As Double = 0
        dtBalance.Rows.Clear()
        sQuery = "EXEC Integrador..paBalanceSaldos '" & lueCompany.EditValue & "','" & seFiscalYear.Text & "','12'"
        dtBalance = ExecuteSQL(sQuery)
        If dtBalance.Rows.Count = 0 Then
            SplashScreenManager.CloseForm(False)
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "La consulta no retornó datos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If dtBalance.Rows.Count > 0 Then
            bbiExport.Enabled = True
            bbiVoucher.Enabled = True
        End If
        If dtBalance.Columns.Count = 0 Then
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "La consulta no retornó información.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        dtCloseYear = dtBalance.Clone
        For r = 0 To dtBalance.Rows.Count - 1
            Dim oRow As DataRow = dtBalance.Rows(r)
            dtCloseYear.Rows.Add()
            iPos = dtCloseYear.Rows.Count - 1
            dtCloseYear.Rows(iPos)("CUEN_codigo") = oRow("CUEN_codigo")
            dtCloseYear.Rows(iPos)("CUEN_Desc") = oRow("CUEN_Desc")
            dtCloseYear.Rows(iPos)("DETA_moneda") = oRow("DETA_moneda")
            dtCloseYear.Rows(iPos)("DETA_Debe") = oRow("DETA_Haber")
            dtCloseYear.Rows(iPos)("DETA_Haber") = oRow("DETA_Debe")
            dtCloseYear.Rows(iPos)("SaldoML") = oRow("DETA_Haber") - oRow("DETA_Debe")
            dLocAmount += dtCloseYear.Rows(iPos)("DETA_Debe") - dtCloseYear.Rows(iPos)("DETA_Haber")
            dtCloseYear.Rows(iPos)("DETA_DebeDol") = oRow("DETA_HaberDol")
            dtCloseYear.Rows(iPos)("DETA_HaberDol") = oRow("DETA_DebeDol")
            dtCloseYear.Rows(iPos)("SaldoME") = oRow("DETA_HaberDol") - oRow("DETA_DebeDol")
            dExtAmount += dtCloseYear.Rows(iPos)("DETA_DebeDol") - dtCloseYear.Rows(iPos)("DETA_HaberDol")
            dtCloseYear.Rows(iPos)("DETA_tCambio") = oRow("DETA_tCambio")
        Next
        dLocAmount = Math.Round(dLocAmount, 2)
        dExtAmount = Math.Round(dExtAmount, 2)
        If dLocAmount <> 0 Then
            dtCloseYear.Rows.Add()
            iPos = dtCloseYear.Rows.Count - 1
            If dLocAmount > 0 Then
                dtCloseYear.Rows(iPos)("CUEN_codigo") = My.Settings.ResultCredit
                dtCloseYear.Rows(iPos)("DETA_Haber") = Math.Abs(dLocAmount)
                dtCloseYear.Rows(iPos)("DETA_Debe") = 0
            Else
                dtCloseYear.Rows(iPos)("CUEN_codigo") = My.Settings.ResultDebit
                dtCloseYear.Rows(iPos)("DETA_Haber") = 0
                dtCloseYear.Rows(iPos)("DETA_Debe") = Math.Abs(dLocAmount)
            End If
            dtCloseYear.Rows(iPos)("DETA_moneda") = "PEN"
            dtCloseYear.Rows(iPos)("DETA_DebeDol") = 0
            dtCloseYear.Rows(iPos)("DETA_HaberDol") = 0
            dtCloseYear.Rows(iPos)("SaldoME") = 0
            dtCloseYear.Rows(iPos)("SaldoML") = dtCloseYear.Rows(iPos)("DETA_Debe") - dtCloseYear.Rows(iPos)("DETA_Haber")
            dtCloseYear.Rows(iPos)("DETA_tCambio") = 0
        End If
        If dExtAmount <> 0 Then
            dtCloseYear.Rows.Add()
            iPos = dtCloseYear.Rows.Count - 1
            If dExtAmount > 0 Then
                dtCloseYear.Rows(iPos)("CUEN_codigo") = My.Settings.ResultCredit
                dtCloseYear.Rows(iPos)("DETA_HaberDol") = Math.Abs(dExtAmount)
                dtCloseYear.Rows(iPos)("DETA_DebeDol") = 0
            Else
                dtCloseYear.Rows(iPos)("CUEN_codigo") = My.Settings.ResultDebit
                dtCloseYear.Rows(iPos)("DETA_HaberDol") = 0
                dtCloseYear.Rows(iPos)("DETA_DebeDol") = Math.Abs(dExtAmount)
            End If
            dtCloseYear.Rows(iPos)("DETA_moneda") = "USD"
            dtCloseYear.Rows(iPos)("DETA_Debe") = 0
            dtCloseYear.Rows(iPos)("DETA_Haber") = 0
            dtCloseYear.Rows(iPos)("SaldoML") = 0
            dtCloseYear.Rows(iPos)("SaldoME") = dtCloseYear.Rows(iPos)("DETA_DebeDol") - dtCloseYear.Rows(iPos)("DETA_HaberDol")
            dtCloseYear.Rows(iPos)("DETA_tCambio") = 0
        End If
        gcCloseYear.DataSource = dtCloseYear
        Return
    End Sub

    Private Sub OpenDataProcess()
        Dim sQuery As String = ""
        Dim iPos As Integer = 0
        Dim dLocAmount As Double = 0
        Dim dExtAmount As Double = 0
        dtBalance.Rows.Clear()
        sQuery = "EXEC Integrador..paBalanceSaldos '" & lueCompany.EditValue & "','" & seFiscalYear.Text & "','12',0"
        dtBalance = ExecuteSQL(sQuery)
        If dtBalance.Rows.Count = 0 Then
            SplashScreenManager.CloseForm(False)
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "La consulta no retornó datos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If dtBalance.Rows.Count > 0 Then
            bbiExport.Enabled = True
            bbiVoucher.Enabled = True
        End If
        If dtBalance.Columns.Count = 0 Then
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "La consulta no retornó información.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        dtOpenYear = dtBalance.Copy
        dExtAmount = Math.Round(dtOpenYear.Compute("SUM(SaldoME)", ""), 2)
        dLocAmount = Math.Round(dtOpenYear.Compute("SUM(SaldoML)", ""), 2)
        If dLocAmount <> 0 Then
            dtOpenYear.Rows.Add()
            iPos = dtOpenYear.Rows.Count - 1
            If dLocAmount > 0 Then
                dtOpenYear.Rows(iPos)("CUEN_codigo") = My.Settings.ResultDebit
                dtOpenYear.Rows(iPos)("DETA_Haber") = Math.Abs(dLocAmount)
                dtOpenYear.Rows(iPos)("DETA_Debe") = 0
            Else
                dtOpenYear.Rows(iPos)("CUEN_codigo") = My.Settings.ResultCredit
                dtOpenYear.Rows(iPos)("DETA_Haber") = 0
                dtOpenYear.Rows(iPos)("DETA_Debe") = Math.Abs(dLocAmount)
            End If
            dtOpenYear.Rows(iPos)("DETA_moneda") = "PEN"
            dtOpenYear.Rows(iPos)("DETA_DebeDol") = 0
            dtOpenYear.Rows(iPos)("DETA_HaberDol") = 0
            dtOpenYear.Rows(iPos)("SaldoME") = 0
            dtOpenYear.Rows(iPos)("SaldoML") = dtOpenYear.Rows(iPos)("DETA_Debe") - dtOpenYear.Rows(iPos)("DETA_Haber")
            dtOpenYear.Rows(iPos)("DETA_tCambio") = 0
        End If
        If dExtAmount <> 0 Then
            dtOpenYear.Rows.Add()
            iPos = dtOpenYear.Rows.Count - 1
            If dExtAmount > 0 Then
                dtOpenYear.Rows(iPos)("CUEN_codigo") = My.Settings.ResultDebit
                dtOpenYear.Rows(iPos)("DETA_HaberDol") = Math.Abs(dExtAmount)
                dtOpenYear.Rows(iPos)("DETA_DebeDol") = 0
            Else
                dtOpenYear.Rows(iPos)("CUEN_codigo") = My.Settings.ResultCredit
                dtOpenYear.Rows(iPos)("DETA_HaberDol") = 0
                dtOpenYear.Rows(iPos)("DETA_DebeDol") = Math.Abs(dExtAmount)
            End If
            dtOpenYear.Rows(iPos)("DETA_moneda") = "USD"
            dtOpenYear.Rows(iPos)("DETA_Debe") = 0
            dtOpenYear.Rows(iPos)("DETA_Haber") = 0
            dtOpenYear.Rows(iPos)("SaldoML") = 0
            dtOpenYear.Rows(iPos)("SaldoME") = dtOpenYear.Rows(iPos)("DETA_DebeDol") - dtOpenYear.Rows(iPos)("DETA_HaberDol")
            dtOpenYear.Rows(iPos)("DETA_tCambio") = 0
        End If
        gcOpenYear.DataSource = dtOpenYear
    End Sub

    Private Sub LayoutApply()
        'GridView1.PopulateColumns()
        For i = 5 To GridView1.Columns.Count - 2
            GridView1.Columns(i).OptionsColumn.ReadOnly = True
            GridView1.Columns(i).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridView1.Columns(i).DisplayFormat.FormatString = "###,###,##0.00"
            GridView1.Columns(i).SummaryItem.SetSummary(DevExpress.Data.SummaryItemType.Sum, "{0:n2}")
            GridView1.Columns(i).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridView1.Columns(i).DisplayFormat.FormatString = "n2"
        Next
        'GridView2.PopulateColumns()
        For r = 7 To GridView2.Columns.Count - 2
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
            ExportarExcel(gcOpenYear)
        Else
            ExportarExcel(gcCloseYear)
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

    Private Sub bbiVoucher_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiVoucher.ItemClick
        If DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Este proceso generará un nuevo asiento contable, desea continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.No Then
            Return
        End If
        If tsCloseYear.EditValue = True Then
            If VoucherGenerate("Cierre") Then
                DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Se generó el asiento contable " & sVoucher, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        If tsOpenYear.EditValue = True Then
            If VoucherGenerate("Apertura") Then
                DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Se generó el asiento contable " & sVoucher, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        GetVouchersNumber()
    End Sub

    Friend Function VoucherGenerate(ProcessType As String) As Boolean
        Dim dtResult As New DataTable
        Dim aResult As New ArrayList
        Dim sYear As String = (seFiscalYear.EditValue + IIf(Mid(ProcessType, 1, 1) = "C", 0, 1)).ToString
        Dim sPeriod As String = IIf(Mid(ProcessType, 1, 1) = "A", "00", "13")
        Dim sGlosa As String = "ASIENTO DE " & ProcessType.ToUpper & Space(1) & sYear
        SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)
        SplashScreenManager.Default.SetWaitFormDescription("Generando plantilla del asiento de " & ProcessType.ToLower & "...")
        dsVoucher.Tables.Clear()
        dtVoucherH = oAppService.NewExecuteSQL("SELECT * FROM NextSis" & lueCompany.EditValue & "..CON_CabAsientos (nolock) WHERE SUCR_Codigo='00'").Tables(0)
        dtVoucherD = oAppService.NewExecuteSQL("SELECT * FROM NextSis" & lueCompany.EditValue & "..CON_DetAsientos (nolock) WHERE SUCR_Codigo='00'").Tables(0)
        If Mid(ProcessType, 1, 1) = "C" Then
            dtResult = dtCloseYear.Copy
        Else
            dtResult = dtOpenYear.Copy
        End If
        For r = 0 To dtResult.Rows.Count - 1
            Dim oRow As DataRow = dtResult.Rows(r)
            If r = 0 Then
                'Inserta Cabecera
                dtVoucherH.Rows.Add()
                dtVoucherH.Rows(r)("SUCR_Codigo") = "01"
                dtVoucherH.Rows(r)("CABA_Mes") = sPeriod
                dtVoucherH.Rows(r)("TIPO_tabReg") = "REG"
                dtVoucherH.Rows(r)("CABA_ano") = sYear
                dtVoucherH.Rows(r)("TIPO_tipReg") = "004"
                dtVoucherH.Rows(r)("CABA_NroVoucher") = "000000"
                dtVoucherH.Rows(r)("CABA_Glosa") = sGlosa
                dtVoucherH.Rows(r)("CABA_moneda") = 1
                dtVoucherH.Rows(r)("CABA_TipoAsiento") = "A"
                dtVoucherH.Rows(r)("CABA_UsrCrea") = "integrador"
                dtVoucherH.Rows(r)("CABA_FecCrea") = Date.Now
                dtVoucherH.Rows(r)("TIPO_tabTRE") = "TRE"
                dtVoucherH.Rows(r)("TIPO_tipregRef") = 1
            End If
            'Inserta Detalle
            dtVoucherD.Rows.Add()
            dtVoucherD.Rows(r)("CABA_Ano") = sYear
            dtVoucherD.Rows(r)("SUCR_Codigo") = "01"
            dtVoucherD.Rows(r)("DETA_Glosa") = sGlosa
            dtVoucherD.Rows(r)("CABA_Mes") = sPeriod
            dtVoucherD.Rows(r)("DETA_elemento") = r + 1
            dtVoucherD.Rows(r)("TIPO_tabReg") = "REG"
            dtVoucherD.Rows(r)("TIPO_tipReg") = "004"
            dtVoucherD.Rows(r)("CUEN_Codigo") = oRow("CUEN_Codigo")
            dtVoucherD.Rows(r)("DETA_Debe") = oRow("DETA_Debe")
            dtVoucherD.Rows(r)("DETA_Haber") = oRow("DETA_Haber")
            dtVoucherD.Rows(r)("DETA_DebeDol") = oRow("DETA_DebeDol")
            dtVoucherD.Rows(r)("DETA_HaberDol") = oRow("DETA_HaberDol")
            dtVoucherD.Rows(r)("TIPO_tabOrigen") = "TDO"
            dtVoucherD.Rows(r)("TIPO_tipOrigen") = "000"
            dtVoucherD.Rows(r)("DETA_tCambio") = oRow("DETA_tCambio")
            dtVoucherD.Rows(r)("DETA_FecDocOrigen") = IIf(Mid(ProcessType, 1, 1) = "A", "01/01/", "31/12/") & sYear
            dtVoucherD.Rows(r)("DETA_referencia") = ""
            dtVoucherD.Rows(r)("DETA_moneda") = IIf(oRow("DETA_moneda") = "PEN", 1, 0)
            dtVoucherD.Rows(r)("DETA_Amarre") = 0
            dtVoucherD.Rows(r)("DETA_porcAmarre") = 0
            dtVoucherD.Rows(r)("DETA_tipoAmarre") = 0
            dtVoucherD.Rows(r)("DETA_numAmarre") = 0
            dtVoucherD.Rows(r)("DETA_NroRetencion") = ""
            dtVoucherD.Rows(r)("DETA_medioPago") = ""
            dtVoucherD.Rows(r)("DETA_anexo") = ""
            dtVoucherD.Rows(r)("DETA_serieReferencia") = ""
            dtVoucherD.Rows(r)("DETA_observacion") = ""
            If Mid(ProcessType, 1, 1) = "A" Then
                dtVoucherD.Rows(r)("DETA_SerieDocOrigen") = oRow("DETA_SerieDocOrigen")
                dtVoucherD.Rows(r)("DETA_NroDocOrigen") = oRow("DETA_NroDocOrigen")
                dtVoucherD.Rows(r)("DETA_anexo") = oRow("DETA_anexo")
                dtVoucherD.Rows(r)("DETA_observacion") = oRow("DETA_observacion")
                If IsDBNull(oRow("TIPO_tipOrigen")) Then
                    oRow("TIPO_tipOrigen") = "000"
                End If
                dtVoucherD.Rows(r)("TIPO_tipOrigen") = oRow("TIPO_tipOrigen")
                If Not oRow("ENTC_Codigo").ToString.Trim = "" Then
                    dtVoucherD.Rows(r)("ENTC_Codigo") = oRow("ENTC_Codigo")
                End If
                'If Not IsDBNull(oRow("TIPO_tipOpe")) Then
                '    dtVoucherD.Rows(r)("TIPO_tipOpe") = oRow("TIPO_tipOpe")
                'End If
                If Not oRow("TIPO_tipOrigen").ToString.Trim = "" Then
                    dtVoucherD.Rows(r)("TIPO_tipOrigen") = oRow("TIPO_tipOrigen")
                End If
                dtVoucherD.Rows(r)("CABA_NroVoucher") = "000000"
                'If Not oRow("CENT_Codigo") = "" Then
                '    dtVoucherD.Rows(r)("CENT_Codigo") = oRow("CENT_Codigo")
                'End If
            End If
        Next
        dsVoucher.Tables.Add(dtVoucherH.Copy)
        dsVoucher.Tables(0).TableName = "VoucherH"
        dsVoucher.Tables.Add(dtVoucherD.Copy)
        dsVoucher.Tables(1).TableName = "VoucherD"
        SplashScreenManager.Default.SetWaitFormDescription("Insertando el nuevo asiento contable...")
        aResult.AddRange(oAppService.GenerateNextSisVoucherBCopy(lueCompany.EditValue, dsVoucher))
        If aResult(0) = 0 Then
            SplashScreenManager.CloseForm(False)
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, aResult(1), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        sVoucher = sYear & sPeriod & "-004-" & aResult(1)
        SplashScreenManager.CloseForm(False)
        Return CBool(aResult(0))
    End Function

    Private Sub lueCompany_Properties_EditValueChanged(sender As Object, e As EventArgs) Handles lueCompany.Properties.EditValueChanged
        GetVouchersNumber()
    End Sub

    Private Sub GetVouchersNumber()
        If lueCompany.Text = "" Then
            Return
        End If
        Dim dtQuery As New DataTable
        tsCloseYear.Enabled = True
        tsOpenYear.Enabled = True
        lbCloseYear.Text = ""
        lbOpenYear.Text = ""
        dtQuery = ExecuteSQL("select CABA_Ano+CABA_Mes+'-'+TIPO_tipReg+'-'+CABA_NroVoucher AS Voucher from NextSis" & lueCompany.EditValue.ToString & ".dbo.CON_DetAsientos where CABA_ano = '" & seFiscalYear.Text & "' AND CABA_mes = '13'")
        If dtQuery.Rows.Count > 0 Then
            tsCloseYear.Enabled = False
            tsCloseYear.EditValue = False
            lbCloseYear.Text = dtQuery.Rows(0)(0)
        End If
        dtQuery.Rows.Clear()
        dtQuery = ExecuteSQL("select CABA_Ano+CABA_Mes+'-'+TIPO_tipReg+'-'+CABA_NroVoucher AS Voucher from NextSis" & lueCompany.EditValue.ToString & ".dbo.CON_DetAsientos where CABA_ano = '" & (CInt(seFiscalYear.Text) + 1).ToString & "' AND CABA_mes = '00'")
        If dtQuery.Rows.Count > 0 Then
            tsOpenYear.Enabled = False
            tsOpenYear.EditValue = False
            lbOpenYear.Text = dtQuery.Rows(0)(0)
        End If
    End Sub
End Class
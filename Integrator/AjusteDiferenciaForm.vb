Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.XtraBars
Imports DevExpress.XtraSplashScreen

Public Class AjusteDiferenciaForm
    Dim dtExchange, dtResult, dtVoucherH, dtVoucherD As New DataTable
    Dim dsVoucher As New DataSet
    Dim sVoucher As String = ""
    Dim oAppService As New AppService.DelfinServiceClient

    Private Sub AjusteDiferencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            deDateTo.EditValue = Today
            seDifML.EditValue = 5
            seDifME.EditValue = 1
            BarButtonEnabled()
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

    Private Sub LoadAccount()
        dtAccount = GetAccountsList(GetDBCia(lueCompany.EditValue))
        lueAccount.Properties.DataSource = dtAccount
        lueAccount.Properties.DisplayMember = "code"
        lueAccount.Properties.ValueMember = "code"
    End Sub

    Private Sub LoadAPartner()
        dtPartner = GetPartnersList(GetDBCia(lueCompany.EditValue))
        luePartner.Properties.DataSource = dtPartner
        luePartner.Properties.DisplayMember = "name"
        luePartner.Properties.ValueMember = "code"
    End Sub

    Private Sub lueCompany_EditValueChanged(sender As Object, e As EventArgs) Handles lueCompany.EditValueChanged
        LoadAccount()
        LoadAPartner()
    End Sub

    Private Sub bbiExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExport.ItemClick
        ExportarExcel(gcMainData)
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
        vpInputs.SetValidationRule(Me.deDateTo, customValidationRule)
        vpInputs.SetValidationRule(Me.lueAccount, customValidationRule)
    End Sub

    Private Sub bbiClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiClose.ItemClick
        Close()
    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        BarButtonEnabled()
    End Sub

    Private Sub BarButtonEnabled()
        For Each bbi As BarButtonItemLink In brBarraAcciones.ItemLinks
            If bbi.Item.Tag = 1 Then
                bbi.Item.Enabled = False
                If GridView1.RowCount > 0 Then
                    bbi.Item.Enabled = True
                End If
            End If
        Next
    End Sub

    Private Sub bbiProcess_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbiProcess.ItemClick
        LoadInputValidations()
        If Not vpInputs.Validate Then
            Return
        End If
        dtExchange = oAppService.NewExecuteSQL("SELECT TIPC_VentaOfi, TIPC_CompraOfi FROM NextSis" & dtCompany.Rows(0)("CompanyCode") & "..TipoCambio WHERE TIPC_Fecha='" & Format(deDateTo.EditValue, "yyyyMMdd") & "'").Tables(0)
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
        Dim aResult As New ArrayList
        Dim dtQuery As New DataTable
        Dim iPos As Integer = 0
        Dim sKey As String = 0
        Dim bCurrency As Boolean = False
        SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)
        SplashScreenManager.Default.SetWaitFormDescription("Generando información preliminar del asiento contable")
        gcMainData.DataSource = Nothing
        dtQuery = oAppService.NewExecuteSQL("EXEC paGeneraAjustePorDiferencia '" & lueCompany.EditValue & "','" & Format(deDateTo.EditValue, "yyyyMMdd") & "','" & lueAccount.EditValue & "', '" & luePartner.EditValue & "','" & teDocument.Text & "'," & seDifML.Text & "," & seDifME.Text).Tables(0)
        If dtQuery.Rows.Count = 0 Then
            SplashScreenManager.CloseForm(False)
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "La consulta no retornó datos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        dtResult = dtQuery.Clone
        dtResult.Columns.Add("Checked", GetType(Boolean)).DefaultValue = False
        For r = 0 To dtQuery.Rows.Count - 1
            Dim oRow As DataRow = dtQuery.Rows(r)
            Dim dLocAmount, dExtAmount As Double
            Dim dDifference As Double = 0
            dLocAmount = 0
            dExtAmount = 0
            'For c = 0 To dtQuery.Columns.Count - 1
            '    If IsDBNull(oRow(c)) Then
            '        If oRow(c).
            '    End If
            'Next
            bCurrency = oRow("DETA_Moneda")
            sKey = oRow("CUEN_Codigo").ToString.Trim & oRow("DETA_Moneda").ToString.Trim
            Do While oRow("CUEN_Codigo").ToString.Trim & oRow("DETA_Moneda").ToString.Trim = sKey
                dLocAmount += oRow("DETA_debe") - oRow("DETA_haber")
                dExtAmount += oRow("DETA_debeDol") - oRow("DETA_haberDol")
                dtResult.Rows.Add()
                iPos = dtResult.Rows.Count - 1
                oRow("DETA_elemento") = dtResult.Rows.Count
                oRow("DETA_Glosa") = oRow("DETA_Glosa")
                oRow("CENT_codigo") = ""
                dtResult.Rows(iPos).ItemArray = oRow.ItemArray
                r += 1
                If r >= dtQuery.Rows.Count Then
                    Exit Do
                End If
                oRow = dtQuery.Rows(r)
            Loop
            r += -1
            oRow = dtQuery.Rows(r)
            If bCurrency Then
                dDifference = dExtAmount
            Else
                dDifference = dLocAmount
            End If
            'dtResult.Rows.Add()
            'iPos = dtResult.Rows.Count - 1
            'dtResult.Rows(iPos)("DETA_moneda") = oRow("DETA_moneda")
            'dtResult.Rows(iPos)("DETA_moneda1") = IIf(oRow("DETA_moneda") = False, "USD", IIf(oRow("DETA_moneda") = True, "PEN", ""))
            'dtResult.Rows(iPos)("CUEN_codigo") = IIf(dDifference > 0, My.Settings.ExchangeRateDebit, My.Settings.ExchangeRateCredit)
            'dtResult.Rows(iPos)("ENTC_Codigo") = "" 'oRow("ENTC_Codigo")
            'dtResult.Rows(iPos)("TIPO_tipOrigen") = "000" 'oRow("TIPO_tipOrigen")
            'dtResult.Rows(iPos)("DETA_FecDocOrigen") = oRow("DETA_FecDocOrigen")
            'dtResult.Rows(iPos)("DETA_elemento") = dtResult.Rows.Count
            'dtResult.Rows(iPos)("DETA_Glosa") = ""
            'dtResult.Rows(iPos)("CENT_codigo") = IIf(Mid(dtResult.Rows(iPos)("CUEN_codigo"), 1, 1) = "6", "03.02", "")
            'dtResult.Rows(iPos)("DETA_SerieDocOrigen") = "" 'oRow("DETA_SerieDocOrigen")
            'dtResult.Rows(iPos)("DETA_nroDocOrigen") = "" 'oRow("DETA_nroDocOrigen")
            'dtResult.Rows(iPos)("DETA_Referencia") = oRow("DETA_Referencia")
            'dtResult.Rows(iPos)("DETA_debe") = IIf(dLocAmount < 0, Math.Abs(dLocAmount), 0)
            'dtResult.Rows(iPos)("DETA_haber") = IIf(dLocAmount >= 0, Math.Abs(dLocAmount), 0)
            'dtResult.Rows(iPos)("DETA_DebeDol") = IIf(dExtAmount < 0, Math.Abs(dExtAmount), 0)
            'dtResult.Rows(iPos)("DETA_HaberDol") = IIf(dExtAmount >= 0, Math.Abs(dExtAmount), 0)
            'dtResult.Rows(iPos)("DETA_Tcambio") = oRow("DETA_Tcambio")
            'If dtResult.Rows(iPos)("CUEN_codigo") = My.Settings.ExchangeRateCredit Then
            '    Dim oRowResult As DataRow = dtResult.Rows(iPos)
            '    For f = 1 To 2
            '        dtResult.Rows.Add()
            '        iPos = dtResult.Rows.Count - 1
            '        dtResult.Rows(iPos).ItemArray = oRowResult.ItemArray
            '        If f = 1 Then
            '            'Debe
            '            dtResult.Rows(iPos)("CUEN_codigo") = My.Settings.FunctionDebit
            '            dtResult.Rows(iPos)("DETA_elemento") = dtResult.Rows.Count
            '            dtResult.Rows(iPos)("DETA_debe") = Math.Abs(dLocAmount)
            '            dtResult.Rows(iPos)("DETA_haber") = 0
            '            dtResult.Rows(iPos)("DETA_DebeDol") = Math.Abs(dExtAmount)
            '            dtResult.Rows(iPos)("DETA_HaberDol") = 0
            '        Else
            '            'Haber
            '            dtResult.Rows(iPos)("CUEN_codigo") = My.Settings.FunctionCredit
            '            dtResult.Rows(iPos)("DETA_elemento") = dtResult.Rows.Count
            '            dtResult.Rows(iPos)("DETA_debe") = 0
            '            dtResult.Rows(iPos)("DETA_haber") = Math.Abs(dLocAmount)
            '            dtResult.Rows(iPos)("DETA_DebeDol") = 0
            '            dtResult.Rows(iPos)("DETA_HaberDol") = Math.Abs(dExtAmount)
            '        End If
            '    Next
            'End If
        Next
        gcMainData.DataSource = dtResult
    End Sub

    Private Sub bbiCalculate_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbiCalculate.ItemClick
        InsertaDiferenciaCambio()
    End Sub

    Private Sub bbiVoucher_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbiVoucher.ItemClick
        If dtResult.Select("Checked=True").Length = 0 Then
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Debe seleccionar al menos 1 documento.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Este proceso generará un nuevo asiento contable, desea continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.No Then
            Return
        End If
        Validate()
        dtResult = dtResult.Select("Checked=True").CopyToDataTable
        If VoucherGenerate() Then
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Se generó el asiento contable " & sVoucher, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Friend Function VoucherGenerate() As Boolean
        Dim aResult As New ArrayList
        'Dim sGlosa As String = "AJUSTES POR DIFERENCIA DE CAMBIO AL " & deDateTo.Text
        SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)
        SplashScreenManager.Default.SetWaitFormDescription("Generando plantilla del asiento contable...")
        dsVoucher.Tables.Clear()
        dtVoucherH = oAppService.NewExecuteSQL("SELECT * FROM NextSis" & lueCompany.EditValue & "..CON_CabAsientos (nolock) WHERE SUCR_Codigo='00'").Tables(0)
        dtVoucherD = oAppService.NewExecuteSQL("SELECT * FROM NextSis" & lueCompany.EditValue & "..CON_DetAsientos (nolock) WHERE SUCR_Codigo='00'").Tables(0)
        'For r = 0 To dtResult.Rows.Count - 1
        InsertaDiferenciaCambio()
        gcMainData.DataSource = dtResult
        For r = 0 To dtResult.Rows.Count - 1
            Dim oRow As DataRow = dtResult.Rows(r)
            If r = 0 Then
                'Inserta Cabecera
                dtVoucherH.Rows.Add()
                dtVoucherH.Rows(r)("SUCR_Codigo") = "01"
                dtVoucherH.Rows(r)("CABA_Mes") = Format(deDateTo.EditValue, "MM")
                dtVoucherH.Rows(r)("TIPO_tabReg") = "REG"
                dtVoucherH.Rows(r)("CABA_ano") = Format(deDateTo.EditValue, "yyyy")
                dtVoucherH.Rows(r)("TIPO_tipReg") = "004"
                dtVoucherH.Rows(r)("CABA_NroVoucher") = "000000"
                dtVoucherH.Rows(r)("CABA_Glosa") = oRow("DETA_Glosa")
                dtVoucherH.Rows(r)("CABA_moneda") = 1
                dtVoucherH.Rows(r)("CABA_TipoAsiento") = "A"
                dtVoucherH.Rows(r)("CABA_UsrCrea") = "integrador"
                dtVoucherH.Rows(r)("CABA_FecCrea") = Date.Now
                'dtVoucherH.Rows(r)("CABA_UsrMod")
                'dtVoucherH.Rows(r)("CABA_FecMod") = ""
                'dtVoucherH.Rows(r)("TIPO_tipTRE") = ""
                dtVoucherH.Rows(r)("TIPO_tabTRE") = "TRE"
                dtVoucherH.Rows(r)("TIPO_tipregRef") = 1
                'dtVoucherH.Rows(r)("TIPO_tabRegRef") = ""
                'dtVoucherH.Rows(r)("CABA_anoRef") = ""
                'dtVoucherH.Rows(r)("CABA_mesRef") = ""
                'dtVoucherH.Rows(r)("CABA_nrovoucherRef") = ""
            End If
            'Inserta Detalle
            dtVoucherD.Rows.Add()
            dtVoucherD.Rows(r)("CABA_Ano") = Format(deDateTo.EditValue, "yyyy")
            dtVoucherD.Rows(r)("SUCR_Codigo") = "01"
            dtVoucherD.Rows(r)("DETA_Glosa") = oRow("DETA_Glosa")
            dtVoucherD.Rows(r)("CABA_Mes") = Format(deDateTo.EditValue, "MM")
            dtVoucherD.Rows(r)("DETA_elemento") = dtVoucherD.Rows.Count
            If Not oRow("ENTC_Codigo").ToString.Trim = "" Then
                dtVoucherD.Rows(r)("ENTC_Codigo") = oRow("ENTC_Codigo")
            End If
            If Not IsDBNull(oRow("TIPO_tipOpe")) Then
                dtVoucherD.Rows(r)("TIPO_tipOpe") = oRow("TIPO_tipOpe")
            End If
            If Not oRow("TIPO_tipOrigen").trim = "" Then
                dtVoucherD.Rows(r)("TIPO_tipOrigen") = oRow("TIPO_tipOrigen")
            End If
            dtVoucherD.Rows(r)("CABA_NroVoucher") = "000000"
            If Not oRow("CENT_Codigo") = "" Then
                dtVoucherD.Rows(r)("CENT_Codigo") = oRow("CENT_Codigo")
            End If
            dtVoucherD.Rows(r)("TIPO_tabReg") = "REG"
            dtVoucherD.Rows(r)("TIPO_tipReg") = "004"
            dtVoucherD.Rows(r)("DETA_FecDocOrigen") = oRow("DETA_FecDocOrigen")
            dtVoucherD.Rows(r)("DETA_SerieDocOrigen") = oRow("DETA_SerieDocOrigen")
            dtVoucherD.Rows(r)("DETA_NroDocOrigen") = oRow("DETA_NroDocOrigen")
            dtVoucherD.Rows(r)("CUEN_Codigo") = oRow("CUEN_Codigo")
            dtVoucherD.Rows(r)("DETA_Debe") = oRow("DETA_Debe")
            dtVoucherD.Rows(r)("DETA_Haber") = oRow("DETA_Haber")
            dtVoucherD.Rows(r)("DETA_DebeDol") = oRow("DETA_DebeDol")
            dtVoucherD.Rows(r)("DETA_HaberDol") = oRow("DETA_HaberDol")
            'dtVoucherD.Rows(r)("TIPO_tabOpe") = oRow("TIPO_tabOpe")
            dtVoucherD.Rows(r)("TIPO_tabOrigen") = "TDO"
            dtVoucherD.Rows(r)("DETA_referencia") = oRow("DETA_referencia")
            dtVoucherD.Rows(r)("DETA_Amarre") = 0
            dtVoucherD.Rows(r)("DETA_porcAmarre") = 0
            dtVoucherD.Rows(r)("DETA_tipoAmarre") = 0
            dtVoucherD.Rows(r)("DETA_numAmarre") = 0
            If dtVoucherD.Rows(r)("CUEN_codigo") = My.Settings.FunctionDebit Then
                dtVoucherD.Rows(r)("DETA_Amarre") = 1
                dtVoucherD.Rows(r)("DETA_porcAmarre") = 100
                dtVoucherD.Rows(r)("DETA_tipoAmarre") = 2
            End If
            dtVoucherD.Rows(r)("DETA_tCambio") = oRow("DETA_tCambio")
            'dtVoucherD.Rows(r)("PPER_Numero") = 0
            'dtVoucherD.Rows(r)("PART_Codigo") = ""
            'dtVoucherD.Rows(r)("TIGA_codigo") = ""
            'dtVoucherD.Rows(r)("DETA_FecRetencion") = ""
            dtVoucherD.Rows(r)("DETA_NroRetencion") = ""
            'dtVoucherD.Rows(r)("DETA_FecVcto") = ""
            'dtVoucherD.Rows(r)("TIPO_DocReferencia") = ""
            'dtVoucherD.Rows(r)("TIPO_tabUbicaciones") = ""
            'dtVoucherD.Rows(r)("TIPO_codUbicaciones") = ""
            dtVoucherD.Rows(r)("DETA_medioPago") = ""
            dtVoucherD.Rows(r)("DETA_anexo") = ""
            dtVoucherD.Rows(r)("DETA_serieReferencia") = ""
            dtVoucherD.Rows(r)("DETA_moneda") = oRow("DETA_moneda")
            dtVoucherD.Rows(r)("DETA_observacion") = ""
        Next
        If Not (Math.Round(dtVoucherD.Compute("SUM(DETA_Debe)", "") - dtVoucherD.Compute("SUM(DETA_Haber)", ""), 2) = 0) And (Math.Round(dtVoucherD.Compute("SUM(DETA_DebeDol)", "") - dtVoucherD.Compute("SUM(DETA_HaberDol)", ""), 2) = 0) Then
            SplashScreenManager.CloseForm(False)
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "El asiento no está debidamente cuadrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
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
        sVoucher = Format(deDateTo.EditValue, "yyyy") & Format(deDateTo.EditValue, "MM") & "-004-" & aResult(1)
        SplashScreenManager.CloseForm(False)
        Return CBool(aResult(0))
    End Function

    Private Sub InsertaDiferenciaCambio()
        Dim dLocAmount, dExtAmount As Double
        'For Each oRow As DataRow In dtResult.Rows
        '    If oRow("CUEN_codigo") = My.Settings.FunctionCredit Or oRow("CUEN_codigo") = My.Settings.FunctionDebit Then
        '        oRow.Delete()
        '    End If
        'Next
        dtResult = dtResult.Select("CUEN_codigo='" & lueAccount.EditValue & "'").CopyToDataTable
        gcMainData.DataSource = dtResult
        For r = 0 To GridView1.RowCount - 1
            Dim oRow1 As DataRow = GridView1.GetDataRow(r)
            dExtAmount += oRow1("DETA_debeDol") - oRow1("DETA_haberDol")
            dLocAmount += oRow1("DETA_debe") - oRow1("DETA_haber")
        Next
        dtResult.Rows.Add()
        Dim oRow2 As DataRow = dtResult.Rows(dtResult.Rows.Count - 1)
        oRow2("CUEN_codigo") = My.Settings.ExchangeRateDebit
        oRow2("TIPO_tipOrigen") = "000"
        oRow2("CENT_Codigo") = ""
        oRow2("DETA_FecDocOrigen") = deDateTo.Text
        oRow2("DETA_tCambio") = dtExchange.Rows(0)("TIPC_VentaOfi")
        oRow2("DETA_elemento") = dtResult.Rows.Count
        If dLocAmount < 0 Then
            'Debe
            oRow2("DETA_debe") = Math.Abs(dLocAmount)
            oRow2("DETA_haber") = 0
        Else
            'Haber
            oRow2("DETA_debe") = 0
            oRow2("DETA_haber") = Math.Abs(dLocAmount)
        End If
        If dExtAmount < 0 Then
            oRow2("DETA_DebeDol") = Math.Abs(dExtAmount)
            oRow2("DETA_HaberDol") = 0
        Else
            oRow2("DETA_DebeDol") = 0
            oRow2("DETA_HaberDol") = Math.Abs(dExtAmount)
        End If
        gcMainData.DataSource = dtResult
        gcMainData.RefreshDataSource()
    End Sub

    Private Sub SeleccionaFilas(caso As Integer)
        For i = 0 To GridView1.RowCount - 1
            Dim row As DataRow = GridView1.GetDataRow(i)
            If caso = 0 Then
                row("Checked") = True
            End If
            If caso = 1 Then
                row("Checked") = False
            End If
            If caso = 2 Then
                If row("Checked") Then
                    row("Checked") = False
                Else
                    row("Checked") = True
                End If
            End If
        Next
    End Sub

    Private Sub SeleccionaTodosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeleccionaTodosToolStripMenuItem.Click
        SeleccionaFilas(0)
    End Sub

    Private Sub DeseleccionaTodosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeseleccionaTodosToolStripMenuItem.Click
        SeleccionaFilas(1)
    End Sub

    Private Sub InvertirSelecciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InvertirSelecciónToolStripMenuItem.Click
        SeleccionaFilas(2)
    End Sub

End Class
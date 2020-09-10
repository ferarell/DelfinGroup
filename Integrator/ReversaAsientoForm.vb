Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.XtraBars
Imports DevExpress.XtraSplashScreen

Public Class ReversaAsientoForm
    Dim dtVoucherH, dtVoucherD As New DataTable
    Dim oAppService As New AppService.DelfinServiceClient

    Private Sub ReversaAsientoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        teEjercicio.Text = Year(Now).ToString
        tePeriodo.Text = Month(Now).ToString
        deDateTo.EditValue = Today
        Try
            BarButtonEnabled()
            LoadCompany()
            LoadTipoRegistro()
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

    Private Sub LoadTipoRegistro()
        Dim dtQuery As New DataTable
        dtQuery = NewExecuteSQL("SELECT TIPO_CodTipo as Codigo, TIPO_Desc1 as Descripcion FROM NextSoft.dbo.Tipos where TIPO_CodTabla = 'REG'")
        lueTipoRegistro.Properties.DataSource = dtQuery
        lueTipoRegistro.Properties.DisplayMember = "Codigo"
        lueTipoRegistro.Properties.ValueMember = "Codigo"
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
        Dim sWhere As String = "SUCR_Codigo='01' AND CABA_Ano='" & teEjercicio.Text & "' AND CABA_Mes='" & tePeriodo.Text & "' AND TIPO_tipReg='" & lueTipoRegistro.EditValue & "' AND CABA_NroVoucher='" & teNroAsiento.Text & "'"
        dtVoucherH = oAppService.NewExecuteSQL("SELECT * FROM NextSis" & lueCompany.EditValue & "..CON_CabAsientos (nolock) WHERE " & sWhere).Tables(0)
        dtVoucherD = oAppService.NewExecuteSQL("SELECT * FROM NextSis" & lueCompany.EditValue & "..CON_DetAsientos (nolock) WHERE " & sWhere).Tables(0)
        SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)
        SplashScreenManager.Default.SetWaitFormDescription("Generando información preliminar del asiento contable")
        If dtVoucherH.Rows.Count = 0 Then
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "El asiento contable no existe, la consulta no retornó datos. ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        'For r = 0 To dtVoucherD.Rows.Count - 1
        '    Dim oRow As DataRow = dtVoucherD.Rows(r)
        '    If oRow("DETA_Debe") = 0 Then
        '        oRow("DETA_Debe") = oRow("DETA_Haber")
        '        oRow("DETA_Haber") = 0
        '    ElseIf oRow("DETA_Haber") = 0 Then
        '        oRow("DETA_Haber") = oRow("DETA_Debe")
        '        oRow("DETA_Debe") = 0
        '    End If
        '    If oRow("DETA_DebeDol") = 0 Then
        '        oRow("DETA_DebeDol") = oRow("DETA_HaberDol")
        '        oRow("DETA_HaberDol") = 0
        '    ElseIf oRow("DETA_HaberDol") = 0 Then
        '        oRow("DETA_HaberDol") = oRow("DETA_DebeDol")
        '        oRow("DETA_DebeDol") = 0
        '    End If
        'Next
        AuditPanelUpdate(dtVoucherH)
        gcMainData.DataSource = dtVoucherD
    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        BarButtonEnabled()
    End Sub

    Private Sub bbiVoucher_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbiVoucher.ItemClick
        Dim aResult As New ArrayList
        Dim sGlosa As String = "REVERSA DE ASIENTO CONTABLE:  " & teEjercicio.Text & tePeriodo.Text & "-" & lueTipoRegistro.EditValue & "-" & teNroAsiento.Text
        Dim dsVoucher As New DataSet
        SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)
        SplashScreenManager.Default.SetWaitFormDescription("Insertando el nuevo asiento contable...")
        dtVoucherH.Rows(0)("CABA_Mes") = Format(deDateTo.EditValue, "MM")
        dtVoucherH.Rows(0)("TIPO_tabReg") = "REG"
        dtVoucherH.Rows(0)("CABA_ano") = Format(deDateTo.EditValue, "yyyy")
        dtVoucherH.Rows(0)("TIPO_tipReg") = "004"
        dtVoucherH.Rows(0)("CABA_NroVoucher") = "000000"
        dtVoucherH.Rows(0)("CABA_Glosa") = sGlosa
        dtVoucherH.Rows(0)("CABA_TipoAsiento") = "A"
        dtVoucherH.Rows(0)("CABA_UsrCrea") = "integrador"
        dtVoucherH.Rows(0)("CABA_FecCrea") = Date.Now
        For r = 0 To dtVoucherD.Rows.Count - 1
            Dim oRow As DataRow = dtVoucherD.Rows(r)
            oRow("CABA_Mes") = Format(deDateTo.EditValue, "MM")
            oRow("TIPO_tabReg") = "REG"
            oRow("CABA_ano") = Format(deDateTo.EditValue, "yyyy")
            oRow("TIPO_tipReg") = "004"
            oRow("CABA_NroVoucher") = "000000"
            oRow("DETA_Glosa") = sGlosa
            If oRow("DETA_Debe") = 0 Then
                oRow("DETA_Debe") = oRow("DETA_Haber")
                oRow("DETA_Haber") = 0
            ElseIf oRow("DETA_Haber") = 0 Then
                oRow("DETA_Haber") = oRow("DETA_Debe")
                oRow("DETA_Debe") = 0
            End If
            If oRow("DETA_DebeDol") = 0 Then
                oRow("DETA_DebeDol") = oRow("DETA_HaberDol")
                oRow("DETA_HaberDol") = 0
            ElseIf oRow("DETA_HaberDol") = 0 Then
                oRow("DETA_HaberDol") = oRow("DETA_DebeDol")
                oRow("DETA_DebeDol") = 0
            End If
        Next
        dsVoucher.Tables.Add(dtVoucherH.Copy)
        dsVoucher.Tables(0).TableName = "VoucherH"
        dsVoucher.Tables.Add(dtVoucherD.Copy)
        dsVoucher.Tables(1).TableName = "VoucherD"
        aResult.AddRange(oAppService.GenerateNextSisVoucherBCopy(lueCompany.EditValue, dsVoucher))
        Dim sVoucher As String = Format(deDateTo.EditValue, "yyyy") & Format(deDateTo.EditValue, "MM") & "-" & "004" & "-" & aResult(1)
        If aResult(0) = 0 Then
            SplashScreenManager.CloseForm(False)
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, aResult(1), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Else
            SplashScreenManager.CloseForm(False)
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "El asiento " & sVoucher & " fue generado satisfactoriamente ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Dim aParams As New ArrayList
        aParams.Add(teEjercicio.Text & tePeriodo.Text & lueTipoRegistro.EditValue & teNroAsiento.Text)
        aParams.Add(Replace(sVoucher, "-", ""))
        oAppService.NewExecuteSQL("EXEC dbo.ActualizaAsientoCtaCte '" & aParams(0) & "', '" & aParams(1) & "'")
        Dim oForm As New VoucherViewerForm
        oForm.Empresa = lueCompany.EditValue
        oForm.Ejercicio = Format(deDateTo.EditValue, "yyyy")
        oForm.Mes = Format(deDateTo.EditValue, "MM")
        oForm.Libro = lueTipoRegistro.EditValue
        oForm.NoAsiento = aResult(1)
        oForm.Show()
    End Sub

    Private Sub bbiExport_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbiExport.ItemClick
        ExportarExcel(gcMainData)
    End Sub

    Private Sub bbiClose_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbiClose.ItemClick
        Close()
    End Sub

    Private Sub AuditPanelUpdate(dtSource As DataTable)
        'Dim oRow As DataRow = dtSource.Rows(0)
        'ucAuditPanel.UsuarioCreacion = Nothing
        'ucAuditPanel.FechaCreacion = Nothing
        'ucAuditPanel.UsuarioModificacion = Nothing
        'ucAuditPanel.FechaModificacion = Nothing
        'If Not oRow Is Nothing Then
        '    If Not IsDBNull(oRow("CABA_UsrCrea")) Then
        '        ucAuditPanel.UsuarioCreacion = oRow("CABA_UsrCrea")
        '        ucAuditPanel.FechaCreacion = oRow("CABA_FecCrea")
        '    End If
        '    If Not IsDBNull(oRow("CABA_UsrMod")) Then
        '        ucAuditPanel.UsuarioModificacion = oRow("CABA_UsrMod")
        '        ucAuditPanel.FechaModificacion = oRow("CABA_FecMod")
        '    End If
        '    ucAuditPanel.pnlAuditoria.Refresh()
        'End If
    End Sub

End Class
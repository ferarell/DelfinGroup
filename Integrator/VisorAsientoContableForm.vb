Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.XtraBars
Imports DevExpress.XtraSplashScreen

Public Class VisorAsientoContableForm
    Dim dtVoucher As New DataTable
    Dim oAppService As New AppService.DelfinServiceClient

    Private Sub VisorAsientoContableForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        teEjercicio.Text = Year(Now).ToString
        tePeriodo.Text = Month(Now).ToString
        Try
            BarButtonEnabled()
            LoadCompany()
            LoadTipoRegistro()
        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadCompany()
        dtCompany = GetCompaniesList(rgDataSource.EditValue)
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
        vpInputs.SetValidationRule(Me.teEjercicio, Nothing)
        vpInputs.SetValidationRule(Me.tePeriodo, Nothing)
        vpInputs.SetValidationRule(Me.lueTipoRegistro, Nothing)
        vpInputs.SetValidationRule(Me.teNroAsiento, Nothing)
        vpInputs.SetValidationRule(Me.teEjercicioC, Nothing)
        vpInputs.SetValidationRule(Me.teSubDiario, Nothing)
        vpInputs.SetValidationRule(Me.teNroAsientoC, Nothing)
        If rgDataSource.EditValue = "NEXTSIS" Then
            vpInputs.SetValidationRule(Me.teEjercicio, customValidationRule)
            vpInputs.SetValidationRule(Me.tePeriodo, customValidationRule)
            vpInputs.SetValidationRule(Me.lueTipoRegistro, customValidationRule)
            vpInputs.SetValidationRule(Me.teNroAsiento, customValidationRule)
        Else
            vpInputs.SetValidationRule(Me.teEjercicioC, customValidationRule)
            vpInputs.SetValidationRule(Me.teSubDiario, customValidationRule)
            vpInputs.SetValidationRule(Me.teNroAsientoC, customValidationRule)
        End If
    End Sub

    Private Sub BarButtonEnabled()
        For Each bbi As BarButtonItemLink In brBarraAcciones.ItemLinks
            If bbi.Item.Tag = 1 Then
                bbi.Item.Enabled = False
                If gcMainData.MainView.RowCount > 0 Then
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
        If rgDataSource.EditValue = "NEXTSIS" Then
            dtVoucher = NewExecuteSQL("EXEC Integrador.dbo.paObtieneAsientoContable '" & lueCompany.EditValue & "','" & teEjercicio.Text & "','" & tePeriodo.Text & "','" & lueTipoRegistro.EditValue & "','" & teNroAsiento.Text & "'")
        Else
            dtVoucher = NewExecuteSQL("EXEC Integrador.con.paObtieneAsientoContable '" & lueCompany.EditValue & "', '" & teEjercicioC.Text & "0101', '" & teEjercicioC.Text & "1231', '" & teSubDiario.Text.Trim & "', '" & teNroAsientoC.EditValue & "'")
        End If
        SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)
        SplashScreenManager.Default.SetWaitFormDescription("Obteniendo información del asiento contable")
        If dtVoucher.Rows.Count = 0 Then
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "El asiento contable no existe, la consulta no retornó datos. ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        AuditPanelUpdate(dtVoucher)
        If rgDataSource.EditValue = "NEXTSIS" Then
            gcMainData.MainView = GridView1
        Else
            gcMainData.MainView = GridView2
        End If
        gcMainData.DataSource = dtVoucher
    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged, GridView2.FocusedRowChanged
        BarButtonEnabled()
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

    Private Sub bbiPrint_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbiPrint.ItemClick
        Dim pForm As New PrintForm
        pForm.dtPrint = dtVoucher
        pForm.aParams = GetParamValues(dtVoucher.Rows(0))
        If rgDataSource.EditValue = "NEXTSIS" Then
            pForm.RptFile = "ImpresionVoucherNextSis.rpt"
        Else
            pForm.RptFile = "ImpresionVoucherConcar.rpt"
        End If

        pForm.ShowDialog()
    End Sub

    Friend Function GetParamValues(oRow As DataRow) As ArrayList
        Dim aParams As New ArrayList
        If rgDataSource.EditValue = "NEXTSIS" Then
            aParams.Add(oRow("CABA_UsrCrea"))
            aParams.Add(lueCompany.GetColumnValue("CompanyName"))
            aParams.Add(lueCompany.GetColumnValue("CompanyAddress"))
            aParams.Add(lueTipoRegistro.GetColumnValue("Descripcion"))
        Else
            aParams.Add(lueCompany.GetColumnValue("CompanyName"))
            aParams.Add(lueCompany.GetColumnValue("CompanyAddress"))
            aParams.Add("DIARIO")
        End If
        Return aParams
    End Function

    Private Sub rgDataSource_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rgDataSource.SelectedIndexChanged
        LoadCompany()
        If rgDataSource.SelectedIndex = 0 Then
            teEjercicio.Enabled = True
            tePeriodo.Enabled = True
            lueTipoRegistro.Enabled = True
            teNroAsiento.Enabled = True
            teEjercicioC.Enabled = False
            teSubDiario.Enabled = False
            teNroAsientoC.Enabled = False
        End If
        If rgDataSource.SelectedIndex = 1 Then
            teEjercicio.Enabled = False
            tePeriodo.Enabled = False
            lueTipoRegistro.Enabled = False
            teNroAsiento.Enabled = False
            teEjercicioC.Enabled = True
            teSubDiario.Enabled = True
            teNroAsientoC.Enabled = True
        End If
    End Sub
End Class
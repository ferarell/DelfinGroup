Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.XtraBars
Imports DevExpress.XtraSplashScreen

Public Class AnulaAsientoForm
    Dim dtVoucher As New DataTable
    Dim oAppService As New AppService.DelfinServiceClient

    Private Sub AnulaAsientoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        vpInputs.SetValidationRule(Me.teEjercicio, customValidationRule)
        vpInputs.SetValidationRule(Me.tePeriodo, customValidationRule)
        vpInputs.SetValidationRule(Me.lueTipoRegistro, customValidationRule)
        vpInputs.SetValidationRule(Me.teNroAsiento, customValidationRule)
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

    Private Sub bbiProcess_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiProcess.ItemClick
        LoadInputValidations()
        If Not vpInputs.Validate Then
            Return
        End If
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)
            VoidVoucher()
            FindVoucher()
        Catch ex As Exception
            SplashScreenManager.CloseForm(False)
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        SplashScreenManager.CloseForm(False)
    End Sub

    Private Sub FindVoucher()
        SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)
        Try
            SplashScreenManager.Default.SetWaitFormDescription("Obteniendo información del asiento contable")
            dtVoucher = NewExecuteSQL("EXEC Integrador.dbo.paObtieneAsientoContable '" & lueCompany.EditValue & "','" & teEjercicio.Text & "','" & tePeriodo.Text & "','" & lueTipoRegistro.EditValue & "','" & teNroAsiento.Text & "'")
        Catch ex As Exception
            SplashScreenManager.CloseForm(False)
        End Try
        SplashScreenManager.CloseForm(False)
        If dtVoucher.Rows.Count = 0 Then
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "El asiento contable no existe, la consulta no retornó datos. ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        gcMainData.DataSource = dtVoucher
    End Sub

    Private Sub VoidVoucher()
        Dim aResult As New ArrayList
        SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)
        Try
            SplashScreenManager.Default.SetWaitFormDescription("Anulando asiento contable")
            aResult.AddRange(NewExecuteSQLNonQuery("EXEC Integrador.dbo.paAnulaAsientoContable '" & lueCompany.EditValue & "','" & teEjercicio.Text & "','" & tePeriodo.Text & "','" & lueTipoRegistro.EditValue & "','" & teNroAsiento.Text & "'"))
            If CInt(aResult(0)) = 0 Then
                DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "El asiento contable ha sido anulado. ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "No fue posible anular el asiento contable. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        Catch ex As Exception
            SplashScreenManager.CloseForm(False)
        End Try
        SplashScreenManager.CloseForm(False)
    End Sub

    Private Sub bbiQuery_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiQuery.ItemClick
        LoadInputValidations()
        If Not vpInputs.Validate Then
            Return
        End If
        FindVoucher()
    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        BarButtonEnabled()
    End Sub

    Private Sub bbiExport_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbiExport.ItemClick
        ExportarExcel(gcMainData)
    End Sub

    Private Sub bbiClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiClose.ItemClick
        Close()
    End Sub

    Private Sub teEjercicio_EditValueChanged(sender As Object, e As EventArgs) Handles teEjercicio.EditValueChanged, tePeriodo.EditValueChanged, lueTipoRegistro.EditValueChanged, teNroAsiento.EditValueChanged
        gcMainData.DataSource = Nothing
    End Sub
End Class
Imports DevExpress.Skins

Public Class ToxicologicoForm
    Dim oAppService As New AppService.DelfinServiceClient

    Private Sub ToxicologicoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.LookAndFeel.UserLookAndFeel.Default.Assign(DefaultLookAndFeel1.LookAndFeel)
        seYear.Value = Year(Now)
        deDateFrom.EditValue = Today
        GetChosenOnes()
    End Sub

    Private Sub ToxicologicoForm_TextChanged(sender As Object, e As EventArgs) Handles MyBase.TextChanged
        Me.Text = My.Application.Info.ProductName + " [" + My.Application.Info.Version.ToString + "]"
    End Sub

    Private Sub GetChosenOnes()
        Dim dtSource As New DataTable
        dtSource = oAppService.ExecuteSQL("EXEC DELFIN.basc.paObtieneEmpleadosParaExmenToxicologico '" & seYear.Text & "'," & seQuantity.Text).Tables(0)
        gcChosenOnes.DataSource = dtSource
    End Sub

    Private Sub XtraTabControl1_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        If XtraTabControl1.SelectedTabPageIndex = 1 Then
            Dim dtQuery As New DataTable
            dtQuery = oAppService.ExecuteSQL("SELECT * FROM Delfin.basc.ControlToxicologico WHERE ANOCTRTOX='" & seYear.Text & "'").Tables(0)
            gcTested.DataSource = dtQuery
        End If
    End Sub

    Private Sub WindowsUIButtonPanel1_ButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles WindowsUIButtonPanel1.ButtonClick
        If e.Button.Properties.VisibleIndex = 1 Then
            GetChosenOnes()
        End If
        If e.Button.Properties.VisibleIndex = 2 Then
            SaveNewChosenOnes()
        End If
    End Sub

    Private Sub SaveNewChosenOnes()
        If DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Desea guardar esta la lista de empleados?", "Confirmar", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.No Then
            Return
        End If

    End Sub

    Private Sub ToxicologicoForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Esta seguro de cerrar la aplicación?", "Salir", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
End Class
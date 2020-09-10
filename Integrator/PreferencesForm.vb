Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports System.Configuration

Public Class PreferencesForm
    Dim dtCompany As New DataTable
    Dim drCompany As DataRow = Nothing
    Dim teWebServiceURL As New TextBox

    Private Sub beArchivoOrigen_Properties_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs)
        If FolderBrowserDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            sender.EditValue = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub bbiCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCerrar.ItemClick
        Close()
    End Sub

    Private Sub bbiGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGuardar.ItemClick
        Try
            Validate()
            My.Settings.DBConnectionString = "Server=" & teDBHostServer.Text & ";Port=" & teDBPortServer.Text & ";Database=" & teDatabase.Text & ";User Id=" & teDBUser.Text & ";Password=" & teDBPassword.Text & ";"
            My.Settings.Save()
            'If My.Settings.WebServiceURL.Count > 0 Then
            '    ConfigurationSettings.AppSettings.Set("OdooConnector_AppService_OdooService", My.Settings.WebServicesURL(My.Settings.WebServiceIndex))
            'End If
        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Los cambios fueron aplicados satisfactoriamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub PreferencesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetInitialGrid()
        LoadSettings()
    End Sub

    Private Sub SetInitialGrid()
        dtCompany.Columns.Add("URL", GetType(String)).DefaultValue = ""
        dtCompany.Columns.Add("Company", GetType(String)).DefaultValue = ""
        dtCompany.Columns.Add("Active", GetType(Boolean)).DefaultValue = False
    End Sub

    Private Sub LoadSettings()
        'teDBHostServer.EditValue = My.Settings.DBHostServer
        'teDBPortServer.EditValue = My.Settings.DBPortServer
        'teDatabase.EditValue = My.Settings.DBName
        'ceSSLDBConnection.Checked = My.Settings.DBSslConnection
        'teDBUser.EditValue = My.Settings.DBUser
        'teDBPassword.EditValue = My.Settings.DBPassword
    End Sub

    Private Sub bbiReset_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiReset.ItemClick
        If DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Se procederá a reiniciar la configuración de la aplicación, desea continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            My.Settings.Reset()
            Me.PreferencesForm_Load(sender, e)
        End If
    End Sub

End Class
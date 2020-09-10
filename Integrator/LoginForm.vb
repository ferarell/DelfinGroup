Imports DevExpress.XtraEditors.DXErrorProvider
Imports System.DirectoryServices

Public Class LoginForm
    Dim iRetry As Integer = 1
    Dim dtDomainList As DataTable
    Dim oAppService As New AppService.DelfinServiceClient
    Public ADDomain, UserId, ADConnStr, ADLogonName As String
    Public IsAuthenticated As Boolean = False

    Public Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        LoadInputValidations()
        If Not vpInputs.Validate Then
            Return
        End If
        iRetry = iRetry + 1
        If iRetry <= 5 Then
            If IsValidate() Then
                IsAuthenticated = True
                dtActiveDirectoryObjects = oAppService.GetActiveDirectoryObjects(ADConnStr, ADLogonName).Tables(0)
                UserName = dtActiveDirectoryObjects.Rows(0).Item("cn").ToString
                UserEmail = dtActiveDirectoryObjects.Rows(0).Item("mail").ToString()
                Me.Close()
            Else
                IsAuthenticated = False
            End If
            tePassword.Focus()
        Else
            MsgBox("Ha superado el número máximo de intentos !", MsgBoxStyle.Critical)
            End
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        End
        'Close()
    End Sub

    Private Sub cnkValidation_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ceIntegrated.CheckedChanged
        If ceIntegrated.Checked Then
            teUserName.Enabled = False
            tePassword.Enabled = False
            lueDomain.Enabled = False
        Else
            teUserName.Enabled = True
            tePassword.Enabled = True
            lueDomain.Enabled = True
        End If
    End Sub

    Private Sub LoginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtActiveDirectoryObjects.Rows.Clear()
    End Sub

    Function IsValidate() As Boolean
        Dim bReturn As Boolean = True
        If ceIntegrated.Checked Then
            Dim parts() As String = Split(My.User.Name, "\")
            ADLogonName = parts(1) + "@" + ADDomain
            UserId = My.User.Name
        Else
            ADDomain = dtDomainList.Rows(lueDomain.ItemIndex).Item("Directory")
            ADConnStr = "LDAP://" + ADDomain
            ADLogonName = teUserName.Text + "@" + ADDomain
            Dim CatchEx As String = oAppService.UserValidation(ADConnStr, ADLogonName, tePassword.Text, My.Settings.MessageLogOnError)
            If CatchEx <> "" Then
                MsgBox(CatchEx, MsgBoxStyle.Exclamation, "Mensaje de inicio de sesión")
                teUserName.Focus()
                bReturn = False
            Else
                UserId = lueDomain.Text + "\" + teUserName.Text
            End If
        End If
        AppUser = ADLogonName
        My.Settings.LastDomain = lueDomain.Text
        My.Settings.LastUser = teUserName.Text
        My.Settings.Save()
        Return bReturn
    End Function

    Private Sub LoginForm_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.Refresh()
        Try
            Dim QryStr As String
            QryStr = "select domain, directory from Seguridad..ApplicationDomain (nolock) order by domain"
            dtDomainList = oAppService.ExecuteSQL(QryStr).Tables(0)
            lueDomain.Properties.DataSource = dtDomainList
            lueDomain.Properties.DisplayMember = "domain"
            lueDomain.Properties.ValueMember = "directory"
            If My.Settings.LastUser <> "" Then
                teUserName.Text = My.Settings.LastUser
            Else
                teUserName.Text = Environment.UserName
            End If
            lueDomain.ItemIndex = lueDomain.Properties.GetDataSourceRowIndex("domain", Environment.UserDomainName)
            ADDomain = lueDomain.EditValue
            ADConnStr = "LDAP://" + ADDomain
            Dim EntryTest As New DirectoryEntry(ADConnStr)
            If EntryTest.Parent.AuthenticationType = AuthenticationTypes.Secure Then
                ceIntegrated.Checked = True
            End If
            EntryTest.Dispose()
        Catch ex As Exception
            ceIntegrated.Checked = False
            ceIntegrated.Enabled = False
            teUserName.Enabled = True
            tePassword.Enabled = True
            'DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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
        vpInputs.SetValidationRule(Me.tePassword, Nothing)
        vpInputs.SetValidationRule(Me.teUserName, customValidationRule)
        If Not ceIntegrated.Checked Then
            vpInputs.SetValidationRule(Me.tePassword, customValidationRule)
        End If
        vpInputs.SetValidationRule(Me.lueDomain, customValidationRule)
    End Sub

    Private Sub LoginForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dim oMainForm As New MainForm
        oMainForm.Show()
        TextToSpeak("Bienvenido, " & UserName)
    End Sub
End Class
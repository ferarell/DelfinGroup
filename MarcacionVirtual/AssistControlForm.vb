Imports System.ComponentModel

Public Class AssistControlForm
    Dim oAppService As New AppService.DelfinServiceClient
    Dim oSharePointTransactions As New SharePointListTransactions
    Dim dtUserAccount As New DataTable
    Dim drUserAccount As DataRow

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        DevExpress.UserSkins.BonusSkins.Register()
        oSharePointTransactions.SharePointUrl = My.Settings.SharePoint_Url
    End Sub

    Private Sub AssistControlForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SplitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
        Me.Icon = NotifyIcon.Icon
        lblLastDateRegistration.Text = ""
        lblLastTimeRegistration.Text = ""
        lblLastTypeRegistration.Text = ""
        NotifyIcon.Visible = True
        TimerActual.Enabled = True
        LoadUser()
        ShowLastRegistration()
    End Sub

    Private Sub LoadUser()
        dtUserAccount = oAppService.ExecuteSQL("SELECT * FROM Integrador.sec.UsersAccount WHERE DomainUserAccount='" & My.User.Name & "'").Tables(0)
        If dtUserAccount.Rows.Count = 0 Then
            DevExpress.XtraEditors.XtraMessageBox.Show("El usuario no está registrado, por favor comunicarse con Administración.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End If
        drUserAccount = dtUserAccount.Rows(0)
        bbiUserApp.Caption = "Usuario: " & drUserAccount("UserName") & " (" & drUserAccount("MailUserAccount") & ")"
    End Sub

    Private Sub ShowLastRegistration()
        Dim dtQuery As New DataTable
        Dim aParams As New ArrayList
        aParams.Add({"UserMail", drUserAccount("MailUserAccount")})
        oSharePointTransactions.SharePointList = "AssistControl"
        oSharePointTransactions.FieldsList.Clear()
        oSharePointTransactions.FieldsList.Add({"ID"})
        oSharePointTransactions.FieldsList.Add({"UserName"})
        oSharePointTransactions.FieldsList.Add({"UserMail"})
        oSharePointTransactions.FieldsList.Add({"UserAccount"})
        oSharePointTransactions.FieldsList.Add({"RegistrationType"})
        oSharePointTransactions.FieldsList.Add({"RegistrationDate"})
        dtQuery = oSharePointTransactions.SelectItem(aParams)
        'dtQuery.Select("", "ID DESC").CopyToDataTable
        If dtQuery.Rows.Count = 0 Then
            Return
            'Dim oRow As DataRow = dtQuery.Rows(dtQuery.Rows.Count - 1)
            'lblLastDateRegistration.Text = Format(CDate(oRow("RegistrationDate")), "dd/MM/yyyy")
            'lblLastTimeRegistration.Text = Format(CDate(oRow("RegistrationDate")), "HH:mm")
            'lblLastTypeRegistration.Text = IIf(oRow("RegistrationType") = "E", "ENTRADA", "SALIDA")
        End If
        For r = 0 To dtQuery.Rows.Count - 1
            Dim oRow As DataRow = dtQuery.Rows(r)
            oRow("RegistrationDate") = DateAdd(DateInterval.Hour, -5, CDate(oRow("RegistrationDate")))
            If Format(CDate(oRow("RegistrationDate")), "yyyy-MM-dd") = Format(Today, "yyyy-MM-dd") And oRow("RegistrationType") = "E" Then
                sbInputRegistration.Enabled = False
            End If
            If Format(CDate(oRow("RegistrationDate")), "yyyy-MM-dd") = Format(Today, "yyyy-MM-dd") And oRow("RegistrationType") = "S" Then
                sbOutputRegistration.Enabled = False
            End If
            If r = dtQuery.Rows.Count - 1 Then
                lblLastDateRegistration.Text = Format(CDate(oRow("RegistrationDate")), "dd/MM/yyyy")
                lblLastTimeRegistration.Text = Format(CDate(oRow("RegistrationDate")), "HH:mm")
                lblLastTypeRegistration.Text = IIf(oRow("RegistrationType") = "E", "ENTRADA", "SALIDA")
            End If

        Next

    End Sub
    Private Sub AssistControlForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'TimerRefresh.Interval = My.Settings.TimeRefresh * 1000
        TimerRefresh.Interval = 5000
        TimerRefresh.Start()
        'tsRefresh.EditValue = TimerRefresh.Enabled
    End Sub

    Private Sub ToolStripTextBox1_Click(sender As Object, e As EventArgs) Handles ToolStripTextBox1.Click
        NotifyIcon.Visible = False
        End
    End Sub

    Private Sub NotifyIcon_DoubleClick(sender As Object, e As EventArgs) Handles NotifyIcon.DoubleClick
        Me.Show()
        TimerRefresh.Start()
    End Sub

    Private Sub TimerActual_Tick(sender As Object, e As EventArgs) Handles TimerActual.Tick
        lblActualTimeRegistration.Text = DateTime.Now.ToString("hh:mm:ss")
        lblActualDateRegistration.Text = DateTime.Now.ToLongDateString()
    End Sub

    Private Sub sbInputRegistration_Click(sender As Object, e As EventArgs) Handles sbInputRegistration.Click
        sbInputRegistration.Enabled = False
        Try
            SetItemValues(drUserAccount("UserName"), drUserAccount("MailUserAccount"), "E")
        Catch ex As Exception
            sbInputRegistration.Enabled = True
        End Try
        ShowLastRegistration()
    End Sub

    Private Sub sbOutputRegistration_Click(sender As Object, e As EventArgs) Handles sbOutputRegistration.Click
        sbInputRegistration.Enabled = False
        Try
            SetItemValues(drUserAccount("UserName"), drUserAccount("MailUserAccount"), "S")
        Catch ex As Exception
            sbInputRegistration.Enabled = True
        End Try
        ShowLastRegistration()
    End Sub

    Private Sub SetItemValues(UserName As String, UserMail As String, RegType As String)
        oSharePointTransactions.SharePointList = "AssistControl"
        oSharePointTransactions.ValuesList.Clear()
        oSharePointTransactions.ValuesList.Add({"UserName", UserName})
        oSharePointTransactions.ValuesList.Add({"UserMail", UserMail})
        'oSharePointTransactions.ValuesList.Add({"UserAccount", drUserAccount("UserName")})
        oSharePointTransactions.ValuesList.Add({"RegistrationType", RegType})
        oSharePointTransactions.ValuesList.Add({"RegistrationDate", Format(DateAdd(DateInterval.Hour, 5, Now), "yyyy-MM-dd HH:mm")})
        oSharePointTransactions.InsertItem()
    End Sub

    Private Sub AssistControlForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        TimerRefresh.Stop()
        Me.Hide()
        e.Cancel = True
    End Sub
End Class
Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports System.Threading
'Imports Microsoft.Office.Interop.Access
Imports System.Globalization

Public Class MainForm

    Public Sub New()

        Dim currentWithOverriddenNumber As CultureInfo = New CultureInfo(CultureInfo.CurrentCulture.Name)
        currentWithOverriddenNumber.NumberFormat.CurrencyPositivePattern = 0 '; // make sure there is no space between symbol and number
        currentWithOverriddenNumber.NumberFormat.CurrencySymbol = "" '; // no currency symbol
        currentWithOverriddenNumber.NumberFormat.CurrencyDecimalSeparator = "." '; //decimal separator
        currentWithOverriddenNumber.NumberFormat.CurrencyDecimalDigits = 2
        currentWithOverriddenNumber.NumberFormat.CurrencyGroupSizes = {3} '; //no digit groupings
        currentWithOverriddenNumber.NumberFormat.CurrencyGroupSeparator = ","
        currentWithOverriddenNumber.NumberFormat.NumberGroupSizes = {3} ';
        currentWithOverriddenNumber.NumberFormat.NumberGroupSeparator = ","
        currentWithOverriddenNumber.NumberFormat.NumberDecimalSeparator = "." '; //decimal separator
        currentWithOverriddenNumber.NumberFormat.NumberDecimalDigits = 2
        currentWithOverriddenNumber.DateTimeFormat.FullDateTimePattern = "dd/MM/yyyy hh:mm"
        currentWithOverriddenNumber.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        Thread.CurrentThread.CurrentCulture = currentWithOverriddenNumber
        InitializeComponent()
        'TextToSpeak("Staring Office Customization for Hapag Lloyd")

        SkinName = My.Settings.LookAndFeel
    End Sub

    Private Sub MainForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
        End
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        If My.Computer.Name <> "FARELLANO" Then
            NavBarItem6.Visible = False
        End If
        'If Not My.Settings.GetPreviousVersion("MDBFileName") Is Nothing Then
        '    If My.Computer.Name <> "FARELLANO" Then
        '        My.Settings.Upgrade()
        '    End If
        'End If
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(SkinName)
        If My.Settings.PaintStyle = "ExplorerBar" Then
            nbcMainMenu.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.ExplorerBar
        Else
            nbcMainMenu.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane
        End If
        nbcMainMenu.PaintStyleName = My.Settings.LookAndFeel
    End Sub

    'Private Sub NavBarItem12_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs)
    '    OpenForm(New PreferencesForm)
    'End Sub

    'Private Sub NavBarItem13_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs)
    '    OpenForm(New LookAndFeelForm)
    'End Sub

    Private Sub SelectPage(ByVal FormName As String)
        For Each myChildForm In MdiChildren
            If myChildForm.Name = FormName Then
                myChildForm.Focus()
            End If
        Next
    End Sub

    Private Sub OpenForm(AppForm As Windows.Forms.Form)
        Try
            Dim myForm As New Windows.Forms.Form
            myForm = AppForm
            If Me.Controls.Find(myForm.Name, True).Count = 0 Then
                myForm.MdiParent = Me
                myForm.Show()
            Else
                SelectPage(myForm.Name)
            End If
        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MainForm_TextChanged(sender As Object, e As EventArgs) Handles MyBase.TextChanged
        Me.Text = My.Application.Info.ProductName + " [" + My.Application.Info.Version.ToString + "]"
        bsiVersion.Caption = "Version: " & My.Application.Info.Version.ToString & " - " & My.Application.Info.Copyright & ". All rights reserved."
    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Are you sure to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub NavBarItem1_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem1.LinkClicked
        OpenForm(New VoyageQueryForm)
    End Sub

    Private Sub NavBarItem8_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem8.LinkClicked
        OpenForm(New InvoicingQueryForm)
    End Sub

    Private Sub NavBarItem7_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem7.LinkClicked
        OpenForm(New CargoNoticeQueryForm)
    End Sub

    Private Sub NavBarItem2_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem2.LinkClicked
        OpenForm(New GetQuoteForm)
    End Sub

    Private Sub NavBarItem3_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem3.LinkClicked
        OpenForm(New CargoAddressingRequestForm)
    End Sub

    Private Sub NavBarItem4_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem4.LinkClicked
        OpenForm(New CustomerRegisterForm)
    End Sub

    Private Sub NavBarItem5_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem5.LinkClicked
        OpenForm(New CustomerAuthorizationForm)
    End Sub

    Private Sub NavBarItem6_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem6.LinkClicked
        OpenForm(New HBLIssuedQueryForm)
    End Sub

    Private Sub NavBarItem15_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem15.LinkClicked
        OpenForm(New HBLStatusQueryForm)
    End Sub

    Private Sub NavBarItem9_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem9.LinkClicked
        OpenForm(New QuoteRequestForm)
    End Sub

    Private Sub NavBarItem10_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem10.LinkClicked
        OpenForm(New ContactUsForm)
    End Sub

    Private Sub NavBarItem16_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem16.LinkClicked
        OpenForm(New RelatedCompanyRequestForm)
    End Sub

    Private Sub NavBarItem17_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem17.LinkClicked
        OpenForm(New CustomerDebtQueryForm)
    End Sub

    Private Sub NavBarItem18_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem18.LinkClicked
        OpenForm(New OperationalTrackingForm)
    End Sub

    Private Sub NavBarItem19_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem19.LinkClicked
        OpenForm(New CustomerStatementQueryForm)
    End Sub

    Private Sub NavBarItem20_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem20.LinkClicked
        OpenForm(New EndoseVirtualForm)
    End Sub
End Class
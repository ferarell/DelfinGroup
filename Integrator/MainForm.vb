Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports System.Threading
Imports System.Globalization

Public Class MainForm

    Public Sub New()
        'Thread.CurrentThread.CurrentCulture = New CultureInfo("es-PE")
        Dim currentWithOverriddenNumber As CultureInfo = New CultureInfo(CultureInfo.CurrentCulture.Name)
        currentWithOverriddenNumber.NumberFormat.CurrencyPositivePattern = 0 '; // make sure there is no space between symbol and number
        currentWithOverriddenNumber.NumberFormat.CurrencySymbol = " " '; // no currency symbol
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
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.UserSkins.BonusSkins.Register()
        SkinName = My.Settings.LookAndFeel
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        If dtActiveDirectoryObjects.Rows.Count > 0 Then
            bbiUserApp.Caption = "Usuario: " & UserName & " (" & AppUser & ")"
        End If
        If My.Computer.Name <> "FARELLANO" Then
            My.Settings.Upgrade()
            NavBarGroup4.Visible = False
        End If
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(SkinName)
        If My.Settings.PaintStyle = "ExplorerBar" Then
            nbcMainMenu.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.ExplorerBar
        Else
            nbcMainMenu.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane
        End If
        nbcMainMenu.PaintStyleName = My.Settings.LookAndFeel
    End Sub

    Private Sub MainForm_TextChanged(sender As Object, e As EventArgs) Handles MyBase.TextChanged
        Me.Text = My.Application.Info.ProductName + " [" + My.Application.Info.Version.ToString + "]"
    End Sub

    Private Sub SelectPage(ByVal FormName As String)
        For Each myChildForm In MdiChildren
            If myChildForm.Name = FormName Then
                myChildForm.Focus()
            End If
        Next
    End Sub

    Private Sub OpenForm(AppForm As Form)
        Try
            Dim myForm As New Form
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

    Private Sub NavBarItem2_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem2.LinkClicked
        OpenForm(PreferencesForm)
    End Sub

    Private Sub NavBarItem1_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem1.LinkClicked
        OpenForm(LookAndFeelForm)
    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Esta seguro de cerrar la aplicación?", "Salir", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
            Try
                For f = 1 To Application.OpenForms.Count - 1
                    Application.OpenForms.Item(f).Close()
                Next
            Catch ex As Exception
            End Try
            TextToSpeak("Hasta luego, " & UserName)
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub NavBarItem9_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem9.LinkClicked
        Dim oForm As New QueryForm
        oForm.MdiParent = Me
        oForm.Show()
    End Sub

    Private Sub NavBarItem5_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem5.LinkClicked
        OpenForm(MovimientoContableForm)
    End Sub

    Private Sub NavBarItem6_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem6.LinkClicked
        OpenForm(LibroDiarioForm)
    End Sub

    Private Sub NavBarItem10_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem10.LinkClicked
        OpenForm(DetraccionesConstanciasForm)
    End Sub

    Private Sub NavBarItem7_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem7.LinkClicked
        OpenForm(LibroMayorForm)
    End Sub

    Private Sub NavBarItem8_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem8.LinkClicked
        OpenForm(LibroCajaBancosForm)
    End Sub

    Private Sub NavBarItem4_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem4.LinkClicked
        Dim oForm As New ReportViewerForm
        oForm.ReportPath = "/Informes Financieros/Reportes Contables (Anual)"
        oForm.ShowDialog()
    End Sub

    Private Sub NavBarItem12_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem12.LinkClicked
        OpenForm(BalanceGeneralForm)
    End Sub

    Private Sub NavBarItem14_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem14.LinkClicked
        OpenForm(BalanceComprobacionForm)
    End Sub

    Private Sub NavBarItem3_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem3.LinkClicked
        OpenForm(RetencionesForm)
    End Sub

    Private Sub NavBarItem15_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem15.LinkClicked
        OpenForm(ContabilizaDatosExternosForm)
    End Sub

    Private Sub NavBarItem16_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem16.LinkClicked
        OpenForm(ClasificacionSociosForm)
    End Sub

    Private Sub NavBarItem17_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem17.LinkClicked
        OpenForm(ImpresionFacturasForm)
    End Sub

    Private Sub NavBarItem18_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem18.LinkClicked
        OpenForm(PagoProveedoresFormvb)
    End Sub

    Private Sub NavBarItem13_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem13.LinkClicked
        OpenForm(EstadoResultadoForm)
    End Sub

    Private Sub NavBarItem19_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem19.LinkClicked
        OpenForm(ComisionEjecutivosForm)
    End Sub

    Private Sub NavBarItem20_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem20.LinkClicked
        OpenForm(ContribuyentesSunatForm)
    End Sub

    Private Sub NavBarItem21_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem21.LinkClicked
        OpenForm(AjusteMonetarioForm)
    End Sub

    Private Sub NavBarItem22_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem22.LinkClicked
        OpenForm(ReclasificaCuentaForm)
    End Sub

    Private Sub NavBarItem23_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem23.LinkClicked
        OpenForm(ReversaAsientoForm)
    End Sub

    Private Sub NavBarItem24_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem24.LinkClicked
        OpenForm(VisorAsientoContableForm)
    End Sub

    Private Sub NavBarItem25_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem25.LinkClicked
        OpenForm(BalanceSaldosForm)
    End Sub

    Private Sub NavBarItem26_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem26.LinkClicked
        OpenForm(CierreAperturaForm)
    End Sub

    Private Sub NavBarItem27_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem27.LinkClicked
        OpenForm(AnulaAsientoForm)
    End Sub

    Private Sub NavBarItem28_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem28.LinkClicked
        OpenForm(AjusteDiferenciaForm)
    End Sub

    Private Sub NavBarItem29_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem29.LinkClicked
        OpenForm(LibroInventariosBalancesForm)
    End Sub
End Class
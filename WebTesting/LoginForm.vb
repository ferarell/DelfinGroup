Imports DevExpress.XtraEditors.DXErrorProvider

Public Class LoginForm
    Dim oAppService As New OnlineService.OnLineServiceClient

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.UserSkins.BonusSkins.Register()
        SkinName = My.Settings.LookAndFeel
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(SkinName)
    End Sub

    Public Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        LoadInputValidations()
        If Not vpInputs.Validate Then
            Return
        End If
        ENTC_Codigo = luePartner.GetColumnValue("CodigoCliente")
        ENTC_DocIden = luePartner.EditValue
        Close()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        End
    End Sub

    Private Sub LoginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadPartner()
    End Sub

    Private Sub LoadPartner()
        Dim dtQuery As New DataTable
        dtQuery = oAppService.ExecuteSQL("EXEC NextSoft.dgp.paListaCliente").Tables(0)
        luePartner.Properties.DataSource = dtQuery
        luePartner.Properties.DisplayMember = "DescripcionCliente"
        luePartner.Properties.ValueMember = "ENTC_DocIden"
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
        'vpInputs.SetValidationRule(Me.tePassword, Nothing)
        'vpInputs.SetValidationRule(Me.teUserName, customValidationRule)
        vpInputs.SetValidationRule(Me.luePartner, customValidationRule)
    End Sub

    Private Sub LoginForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dim oMainForm As New MainForm
        oMainForm.bbiCompany.Caption = luePartner.Text
        oMainForm.Show()
        'TextToSpeak("Bienvenido, " & UserName)
    End Sub
End Class
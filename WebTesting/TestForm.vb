Public Class TestForm
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.UserSkins.BonusSkins.Register()
        SkinName = My.Settings.LookAndFeel
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(SkinName)
    End Sub
End Class
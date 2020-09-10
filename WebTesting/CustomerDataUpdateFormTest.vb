Public Class CustomerDataUpdateFormTest
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.UserSkins.BonusSkins.Register()
        SkinName = My.Settings.LookAndFeel
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(SkinName)
    End Sub

    Private Sub CustomerDataUpdateFormTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub bbiSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSave.ItemClick

    End Sub
End Class
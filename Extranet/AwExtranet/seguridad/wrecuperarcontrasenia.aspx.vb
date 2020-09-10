Imports Negocio
Imports Entidades
Imports System.Web.Services
Public Class wrecuperarcontrasenia
    Inherits System.Web.UI.Page
    Public ReadOnly Property sUrl As String
        Get
            Return (Page.ResolveUrl("~"))
        End Get
    End Property
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    <WebMethod()>
    Public Shared Function fnRecuperarContrasenia(ByVal sEmail As String) As enAjax
        Dim oenAjax As New enAjax
        Try
            Dim sLink As String
            sLink = ConfigurationManager.AppSettings("LinkRC").ToString()
            Dim oEnvioCorreo = New neCorreo()
            Dim oES As New Encryption64()
            Dim sMensaje As String = oEnvioCorreo.bodyEmail(0, "", "", "", oES.Encrypt(sEmail, "!9AZ#$a54DelfinGroup"), "", 3, "", "", sLink)
            Dim sAsunto As String = "Recuperación de Contraseña"
            oEnvioCorreo.EnviarCorreo(sEmail, sAsunto, sMensaje)
            oenAjax.iTipoResultado = 1
            oenAjax.sValor1 = "Se envío un mensaje a su correo, si no lo visualiza buscarlo como SPAM"

        Catch ex As Exception
            oenAjax.iTipoResultado = 2
            oenAjax.sMensajeError = "Ocurrió un error al momento de enviar el email. " + ex.ToString
        End Try
        Return oenAjax
    End Function
End Class
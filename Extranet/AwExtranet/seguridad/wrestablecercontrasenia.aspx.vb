Imports Entidades
Imports Negocio
Imports System.Web.Services
Public Class wrestablecercontrasenia
    Inherits System.Web.UI.Page
    Public ReadOnly Property sUrl As String
        Get
            Return (Page.ResolveUrl("~"))
        End Get
    End Property
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim email As String = Replace(Request.QueryString("e"), " ", "+")
        Dim oES As New Encryption64()
        txtemail.Text = oES.Decrypt(email, "!9AZ#$a54DelfinGroup")
    End Sub

    <WebMethod()>
    Public Shared Function fnRecoveryPassword(ByVal sEmail As String, ByVal spwd As String) As enAjax
        Dim oenAjax As New enAjax
        Try
            Dim oES As New Encryption64()
            Dim oenUsuario As New enUsuario
            Dim oadUsuario As New neUsuario
            Dim iResultado As Integer

            oenUsuario.sPassword = oES.Encrypt(spwd, "!9AZ#$a54DelfinGroup")
            oenUsuario.sCorreo = sEmail
            iResultado = oadUsuario.fnRecoverPassword(oenUsuario)
            oenAjax.iTipoResultado = 1
            oenAjax.sValor1 = "Actualización Exitosa"
        Catch ex As Exception

        End Try
        Return oenAjax
    End Function
End Class
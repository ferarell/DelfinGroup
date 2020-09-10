Imports Entidades
Imports Negocio
Imports System.Web.Services
Public Class wactivarcuenta
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    <WebMethod()>
    Public Shared Function fnActiveAccount(ByVal sEmail As String) As enAjax
        Dim oenAjax As New enAjax
        Try
            Dim oenUsuario As New enUsuario
            Dim oadUsuario As New neUsuario
            oenUsuario.sCorreo = sEmail
            oenUsuario.sStatus = 1

            Dim ST As Integer = oadUsuario.fnUpdateStatus(oenUsuario)
            oenAjax.iTipoResultado = 1
            oenAjax.sMensajeError = "La cuenta ha sido bloqueada porque ha superado el máximo número de intentos fallidos permitidos, por favor espere unos minutos e intente nuevamente."

        Catch ex As Exception

        End Try
        Return oenAjax
    End Function
End Class
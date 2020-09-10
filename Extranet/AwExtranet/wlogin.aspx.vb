Imports Entidades
Imports Negocio
Imports System.Web.Services

Public Class wlogin
    Inherits System.Web.UI.Page
    Public ReadOnly Property sUrl As String
        Get
            Return (Page.ResolveUrl("~"))
        End Get
    End Property
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Session.Contents.RemoveAll()
        End If
    End Sub

    <WebMethod()>
    Public Shared Function fnValidarLogin(ByVal sEmail As String, sPassword As String) As enAjax
        Dim oenAjax As New enAjax
        Try
            Dim oenUsuario As New enUsuario
            Dim oadUsuario As New neUsuario
            Dim oES As New Encryption64()
            oenUsuario.sCorreo = sEmail
            oenUsuario.sPassword = oES.Encrypt(sPassword, "!9AZ#$a54DelfinGroup")
            Dim lst As List(Of enUsuario) = oadUsuario.fnLogin(oenUsuario)

            If lst.Count > 0 Then
                oenAjax.iTipoResultado = lst(0).sStatus
                If lst(0).sStatus = 1 Then
                    HttpContext.Current.Session("lstLogin") = lst
                    oenAjax.sValor1 = "Se registró la información correctamente"
                Else
                    If lst(0).sStatus = 2 Then
                        oenAjax.sMensajeError = "El usuario se encuentra inactivo, por favor comunicarse con atencionalcliente@delfingroupco.com.pe"
                    Else
                        If lst(0).sStatus = 3 Then
                            oenAjax.sMensajeError = "La cuenta ha sido bloqueada porque ha superado el máximo número de intentos fallidos permitidos, por favor espere unos minutos e intente nuevamente."
                            Dim oenCorreo As New neCorreo()
                            Dim sMensaje As String = oenCorreo.bodyEmail(0, 0, "", "", sEmail, "", 4, "", "", "")
                            oenCorreo.EnviarCorreo("webmaster@delfingroupco.com.pe", "CUENTA BLOQUEADA", sMensaje)
                        End If
                    End If
                End If
            Else
                oenAjax.iTipoResultado = 4
                oenAjax.sMensajeError = "El usuario o contraseña no existe, por favor verifique e intente nuevamente."
            End If

        Catch ex As Exception

        End Try
        Return oenAjax
    End Function
    <WebMethod()>
    Public Shared Function fnDestruirSession(ByVal sVacio As String) As enAjax
        Dim oenAjax As New enAjax
        Try
            HttpContext.Current.Session.Contents.RemoveAll()
        Catch ex As Exception

        End Try
        Return oenAjax
    End Function

    <WebMethod()>
    Public Shared Function fnBlockUser(ByVal sEmail As String) As enAjax
        Dim oenAjax As New enAjax
        Try
            Dim oenUsuario As New enUsuario
            Dim oadUsuario As New neUsuario
            oenUsuario.sCorreo = sEmail
            oenUsuario.sStatus = 3

            Dim ST As Integer = oadUsuario.fnUpdateStatus(oenUsuario)
            oenAjax.iTipoResultado = 1
            oenAjax.sMensajeError = "La cuenta ha sido bloqueada porque ha superado el máximo número de intentos fallidos permitidos, por favor espere unos minutos e intente nuevamente."

        Catch ex As Exception

        End Try
        Return oenAjax
    End Function
End Class
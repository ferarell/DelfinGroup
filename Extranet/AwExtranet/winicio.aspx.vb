Imports Entidades
Imports Negocio
Imports System.Web.Services

Public Class winicio
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    <System.Web.Services.WebMethod()>
    Public Shared Function fnDestruirSession(ByVal sVacio As String) As enAjax
        Dim oenAjax As New enAjax
        Try
            Dim lst As New List(Of enUsuario)
            lst = HttpContext.Current.Session("lstLogin")
            If lst Is Nothing Then
                oenAjax.iTipoResultado = 1
            End If
        Catch ex As Exception

        End Try
        Return oenAjax
    End Function


    <WebMethod()>
    Public Shared Function fnListarPermisosUsuario(ByVal profileID As Integer) As enAjax
        Dim oenAjax As New enAjax
        Dim oadPerfil As New nePerfil
        Try
            oenAjax.sValor1 = oadPerfil.fnListarPermisosUsuario(profileID)
        Catch ex As Exception

        End Try
        Return oenAjax
    End Function
End Class
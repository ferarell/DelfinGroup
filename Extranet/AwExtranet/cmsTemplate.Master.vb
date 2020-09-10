Imports Entidades
Public Class cmsTemplate
    Inherits System.Web.UI.MasterPage
    Public ReadOnly Property sUrl As String
        Get
            Return (Page.ResolveUrl("~"))
        End Get
    End Property
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim lst As New List(Of enUsuario)
        lst = Session("lstLogin")
        If lst IsNot Nothing Then
            hdfNombreCliente.Value = lst(0).sNombre + " " + lst(0).sApellidos
            hdRazonSocial.Value = lst(0).sRazonSocial
            hdPerfilID.Value = lst(0).iPerfilID
            hdCode.Value = lst(0).sCodeCustomer
            hdNumberDocument.Value = lst(0).sNroDocumento
            hcorreoClient.Value = lst(0).sCorreo
            idUser.Value = lst(0).iIdUsuario
        Else
            Response.Redirect("../wlogin.aspx")
        End If
        lblversion.Text = "Versión: " & System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString() & " - Copyright © 2019, Delfin Group CO SAC. Todos los derechos reservados."
    End Sub
End Class
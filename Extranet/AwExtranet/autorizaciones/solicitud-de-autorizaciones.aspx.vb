Imports System.Web.Services
Imports Entidades
Imports Negocio
Public Class solicitud_de_autorizaciones
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        loadCustomer()
    End Sub
    Private Sub loadCustomer()
        Try
            Dim oenUsuario As New enUsuario
            Dim oadUsuario As New neUsuario
            Dim lst As New List(Of enUsuario)
            lst = Session("lstLogin")
            If lst IsNot Nothing Then
                oenUsuario.sCorreo = lst(0).sCorreo
                Dim dt As New DataTable
                dt = oadUsuario.fnListar(oenUsuario)
                cbo_client.DataSource = dt
                cbo_client.TextField = "razonsocial"
                cbo_client.ValueField = "code_customer"
                cbo_client.DataBind()
                cbo_client.SelectedIndex = 0
            End If
        Catch ex As Exception

        End Try
    End Sub
    Protected Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Response.Redirect("solicitud-de-autorizaciones-registro.aspx")
    End Sub

    <WebMethod()>
    Public Shared Function listAutorizationByCustomer(ByVal scode As Integer, ByVal shbl As String) As enAjax
        Dim oenAjax As New enAjax
        Try
            Dim oServicio As New ServicioDelfin.OnLineServiceClient
            Dim dt As New DataTable

            dt = oServicio.HBLStatusQuery(shbl, scode)

            If dt.Rows.Count > 0 Then
                oenAjax.sValor1 = CStr(dt.Rows(0).Item(2)) + "|" + CStr(dt.Rows(0).Item(3)) + "|" + CStr(dt.Rows(0).Item(4)) + "|" + CStr(dt.Rows(0).Item(5)) + "|" + CStr(dt.Rows(0).Item(37)) + "|" + CStr(dt.Rows(0).Item(6)) + "|" + CStr(dt.Rows(0).Item(25)) + "|" + CStr(dt.Rows(0).Item(40)) + "|" + CStr(dt.Rows(0).Item(18)) + "|" + CStr(dt.Rows(0).Item(42)) + "|" + CStr(dt.Rows(0).Item(44))
                oenAjax.iTipoResultado = 1
            Else
                oenAjax.iTipoResultado = 2
                oenAjax.sMensajeError = "El HBL no existe o no está asociado a su empresa"
            End If
        Catch ex As Exception
            oenAjax.iTipoResultado = 2
            oenAjax.sValor1 = "ocurrió un error al momento de cargar la información " + ex.ToString()
        End Try
        Return oenAjax
    End Function
End Class
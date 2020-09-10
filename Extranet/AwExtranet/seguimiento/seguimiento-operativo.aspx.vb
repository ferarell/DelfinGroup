Imports System.Web.Services
Imports Entidades
Imports AwExtranet.ServicioDelfin
Public Class seguimiento_operativo
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        loadCustomer()
    End Sub
    Private Sub loadCustomer()
        Try
            Dim lst As New List(Of enUsuario)
            Dim oServicio As New ServicioDelfin.OnLineServiceClient
            lst = Session("lstLogin")
            If lst IsNot Nothing Then
                Dim dt As New DataTable
                dt = oServicio.ExecuteSQL("EXEC NextSoft.dgp.paObtieneEmpresaVinculada " & lst(0).sNroDocumento).Tables(0)
                client.DataSource = dt
                client.TextField = "DescripcionCliente"
                client.ValueField = "CodigoCliente"
                client.DataBind()
                client.SelectedIndex = 0
            End If
        Catch ex As Exception

        End Try
    End Sub

    <WebMethod()>
    Public Shared Function fnSeguimiento(ByVal scode As Integer, ByVal shbl As String) As enAjax
        Dim oenAjax As New enAjax
        Try
            Dim oServicio As New ServicioDelfin.OnLineServiceClient
            Dim dt As New DataTable
            dt = oServicio.OperationalTracking(scode, shbl).Tables(0)

            Dim valor As String = ""
            If dt.Rows.Count > 0 Then
                For Each row As DataRow In dt.Rows
                    valor += CStr(row("EventStatus")) + "," + CStr(row("EventDate")) + "," + String.Format("{0} ", row("EventTime")) + "," + CStr(row("ExternalEventDescription")) + "," + CStr(row("EventCode")) + "|"
                Next
                oenAjax.sValor1 = valor
                oenAjax.iTipoResultado = 1
            Else
                oenAjax.iTipoResultado = 2
                oenAjax.sMensajeError = "La consulta no tiene datos para mostrar"
            End If
            oenAjax.sValor1 = valor
        Catch ex As Exception
            oenAjax.iTipoResultado = 2
            oenAjax.sValor1 = "ocurrió un error al momento de cargar la información " + ex.ToString()
        End Try
        Return oenAjax
    End Function
End Class
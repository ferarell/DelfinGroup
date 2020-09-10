Imports System.Web.Services
Imports Entidades
Imports Negocio
Public Class estado_cuenta
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
                cbo_client.DataSource = dt
                cbo_client.TextField = "DescripcionCliente"
                cbo_client.ValueField = "CodigoCliente"
                cbo_client.DataBind()
                cbo_client.SelectedIndex = 0
            End If
        Catch ex As Exception

        End Try
    End Sub

    <WebMethod()>
    Public Shared Function fnsearchHblByCustomer(ByVal scode As Integer, ByVal dateInit As String, ByVal dateEnd As String, ByVal type As String) As enAjax
        Dim oenAjax As New enAjax
        Try
            Dim oServicio As New ServicioDelfin.OnLineServiceClient
            Dim dt As New DataTable

            dt = oServicio.CustomerStatementQuery(scode, Convert.ToDateTime(dateInit), Convert.ToDateTime(dateEnd), type, Nothing)

            Dim valor As String = ""
            If dt.Rows.Count > 0 Then
                For Each row As DataRow In dt.Rows
                    valor += CStr(row("Grupo")) + "," + CStr(row("HBL")) + "," + CStr(row("TipoDocumento")) + "," + CStr(row("Concepto")) + "," + CStr(row("DOCV_FechaEmision")) + "," + CStr(row("DOCV_FechaVcmto")) + "," + CStr(row("Moneda")) + "," + CStr(row("Importe")) + "," + CStr(row("FormaPago")) + "," + CStr(row("NAVE_Nombre")) + "," + CStr(row("NVIA_NroViaje")) + "," + CStr(row("Saldo")) + "|"
                Next
                oenAjax.sValor1 = valor
                oenAjax.iTipoResultado = 1
            Else
                oenAjax.iTipoResultado = 2
                oenAjax.sMensajeError = "La empresa no tiene datos para mostrar"
            End If

            oenAjax.sValor1 = valor
        Catch ex As Exception
            oenAjax.iTipoResultado = 2
            oenAjax.sValor1 = "ocurrió un error al momento de cargar la información " + ex.ToString()
        End Try
        Return oenAjax
    End Function
End Class
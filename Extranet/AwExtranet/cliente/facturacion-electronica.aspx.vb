Imports System.Web.Services
Imports Entidades
Public Class facturacion_electronica
    Inherits System.Web.UI.Page
    Dim oServicio As New ServicioDelfin.OnLineServiceClient
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        loadCustomer()
    End Sub
    Private Sub loadCustomer()
        Try
            Dim lst As New List(Of enUsuario)

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
    Public Shared Function fnlistBillingByCustomer(ByVal scode As Integer, ByVal dateInit As String, ByVal dateEnd As String) As enAjax
        Dim oenAjax As New enAjax
        Try
            Dim oServicio As New ServicioDelfin.OnLineServiceClient
            Dim dt As New DataTable

            dt = oServicio.InvoicingQuery(scode, Convert.ToDateTime(dateInit), Convert.ToDateTime(dateEnd))
            'dt = oServicio.ExecuteSQL("EXEC NextSoft.web.upInvoicingQuery_FAM " & scode & ",'" & Format(Convert.ToDateTime(dateInit), "yyyy-MM-dd") & "','" & Format(Convert.ToDateTime(dateEnd), "yyyy-MM-dd") & "'").Tables(0)

            Dim valor As String = ""
            If dt.Rows.Count > 0 Then
                For Each row As DataRow In dt.Rows
                    Dim transportista, almacen, terminal, agentePortuario, nave As String
                    If (row("Transportista") Is DBNull.Value) Then
                        transportista = ""
                    Else
                        transportista = CStr(row("Transportista"))
                    End If
                    If (row("Almacen") Is DBNull.Value) Then
                        almacen = ""
                    Else
                        almacen = CStr(row("Almacen"))
                    End If
                    If (row("Terminal") Is DBNull.Value) Then
                        terminal = ""
                    Else
                        terminal = CStr(row("Terminal"))
                    End If
                    If (row("AgentePortuario") Is DBNull.Value) Then
                        agentePortuario = ""
                    Else
                        agentePortuario = CStr(row("AgentePortuario"))
                    End If
                    If (row("Nave") Is DBNull.Value) Then
                        nave = ""
                    Else
                        nave = CStr(row("Nave"))
                    End If

                    valor += (row("COPE_HBL")) + "," + CStr(row("Cliente")) + "," + CStr(row("FecDocVenta")) + "," + CStr(row("TipoDocumento")) + "," + CStr(row("SerieDocumento")) + "," + CStr(row("NumeroDocumento")) + "," + CStr(row("Moneda")) + "," + CStr(row("Importe")) + "," + transportista + "," + almacen + "," + terminal + "," + agentePortuario + "|"
                Next

                oenAjax.sValor1 = valor
                oenAjax.iTipoResultado = 1
            Else
                oenAjax.iTipoResultado = 2
                oenAjax.sMensajeError = "El cliente seleccionado no cuenta con facturas"
            End If

            oenAjax.sValor1 = valor
        Catch ex As Exception
            oenAjax.iTipoResultado = 2
            oenAjax.sValor1 = "ocurrió un error al momento de cargar la información " + ex.ToString()
        End Try
        Return oenAjax
    End Function
End Class
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Web.Services
Imports Entidades
Imports Negocio
Public Class estado_hbl
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
    Public Shared Function fnsearchHblByCustomer(ByVal scode As Integer, ByVal shbl As String) As enAjax
        Dim oenAjax As New enAjax
        Try
            Dim oServicio As New ServicioDelfin.OnLineServiceClient
            Dim dt As New DataTable

            dt = oServicio.HBLStatusQuery(shbl, CInt(scode))
            Dim nave, viaje, eta, transportista, vobo, terminal, deposito, fechacierre, emision, tranmision, agente As String
            If dt.Rows.Count > 0 Then
                If (dt.Rows(0).Item(2) Is DBNull.Value) Then
                    nave = ""
                Else
                    nave = CStr(dt.Rows(0).Item(2))
                End If

                If (dt.Rows(0).Item(3) Is DBNull.Value) Then
                    viaje = ""
                Else
                    viaje = CStr(dt.Rows(0).Item(3))
                End If

                If (dt.Rows(0).Item(4) Is DBNull.Value) Then
                    eta = ""
                Else
                    eta = CStr(dt.Rows(0).Item(4))
                End If

                If (dt.Rows(0).Item(5) Is DBNull.Value) Then
                    transportista = ""
                Else
                    transportista = CStr(dt.Rows(0).Item(5))
                End If

                If (dt.Rows(0).Item(37) Is DBNull.Value) Then
                    vobo = ""
                Else
                    vobo = CStr(dt.Rows(0).Item(37))
                End If

                If (dt.Rows(0).Item(6) Is DBNull.Value) Then
                    terminal = ""
                Else
                    terminal = CStr(dt.Rows(0).Item(6))
                End If

                If (dt.Rows(0).Item(25) Is DBNull.Value) Then
                    deposito = ""
                Else
                    deposito = CStr(dt.Rows(0).Item(25))
                End If

                If (dt.Rows(0).Item(40) Is DBNull.Value) Then
                    fechacierre = ""
                Else
                    fechacierre = CStr(dt.Rows(0).Item(40))
                End If

                If (dt.Rows(0).Item(18) Is DBNull.Value) Then
                    emision = ""
                Else
                    emision = CStr(dt.Rows(0).Item(18))
                End If

                If (dt.Rows(0).Item(42) Is DBNull.Value) Then
                    tranmision = ""
                Else
                    tranmision = CStr(dt.Rows(0).Item(42))
                End If

                If (dt.Rows(0).Item(44) Is DBNull.Value) Then
                    agente = ""
                Else
                    agente = CStr(dt.Rows(0).Item(44))
                End If

                oenAjax.sValor1 = nave + "|" + viaje + "|" + eta + "|" + transportista + "|" + vobo + "|" + terminal + "|" + deposito + "|" + fechacierre + "|" + emision + "|" + tranmision + "|" + agente
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

    Protected Sub btn_export_Click(sender As Object, e As EventArgs) Handles btn_export.Click
        Dim oServicio As New ServicioDelfin.OnLineServiceClient
        Dim dt As New DataTable
        Dim sRuta As String = Server.MapPath("\hbl\EstadoHBL.rpt")
        dt = oServicio.HBLStatusQuery(txt_hbl.Text, cbo_client.Value)

        Dim rpr As New ReportDocument
        rpr.FileName = sRuta
        rpr.SetDataSource(dt)


        Dim TargetFileName As String = ConfigurationManager.AppSettings("basePath").ToString() + "hbl\tmp\HBL_" & txt_hbl.Text & ".pdf"
        rpr.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, TargetFileName)
        hdPdfHBL.Value = ConfigurationManager.AppSettings("urlBase").ToString() + "/hbl\tmp\HBL_" & txt_hbl.Text & ".pdf"

    End Sub
End Class
Imports CrystalDecisions.CrystalReports.Engine
Imports Entidades
Imports System.Web.Services
Public Class consultar_aviso_de_llegada_salida
    Inherits System.Web.UI.Page
    Private oAppService As New ServicioDelfin.OnLineServiceClient
    Dim TargetFileName As String = ""
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        loadCustomer()
    End Sub
    Private Sub loadCustomer()
        Try
            Dim lst As New List(Of enUsuario)

            lst = Session("lstLogin")
            If lst IsNot Nothing Then
                Dim dt As New DataTable
                dt = oAppService.ExecuteSQL("EXEC NextSoft.dgp.paObtieneEmpresaVinculada " & lst(0).sNroDocumento).Tables(0)
                cbo_client.DataSource = dt
                cbo_client.TextField = "DescripcionCliente"
                cbo_client.ValueField = "CodigoCliente"
                cbo_client.DataBind()
                cbo_client.SelectedIndex = 0
            End If
        Catch ex As Exception

        End Try
    End Sub

    Protected Sub btn_preview2_Click(sender As Object, e As EventArgs) Handles btn_preview2.Click
        Try
            Dim oServicio As New ServicioDelfin.OnLineServiceClient

            Dim HBL As String = txt_hbl.Text
            Dim dsTabla As New DataSet

            dsTabla = oAppService.CargoNoticeQuery(HBL)
            Dim sRuta As String = "\avisollegada\"
            Dim oRow As DataRow = dsTabla.Tables(0).Rows(0)

            If oRow("CONS_CodVia") = "001" Then
                If oRow("CONS_CodRGM") = "001" Then 'Impo
                    If oRow("EsLCL") = 0 Then 'FCL
                        If oRow("Puerto").ToString.Contains("ARICA") Then 'Arica
                            sRuta = Server.MapPath(sRuta & "AvisoArriboMaritimoFcl_CLARI.rpt")
                        Else 'Todo Destino
                            sRuta = Server.MapPath(sRuta & "AvisoArriboMaritimoFcl.rpt")
                        End If
                    End If
                    If oRow("EsLCL") = 1 Then 'LCL
                        'Todo Destino
                        sRuta = Server.MapPath(sRuta & "AvisoArriboMaritimoLcl.rpt")
                    End If
                ElseIf oRow("CONS_CodRGM") = "002" Then 'Expo
                    If oRow("EsLCL") = 0 Then 'FCL
                        sRuta = Server.MapPath(sRuta & "AvisoZarpeMaritimoFcl.rpt")
                    End If
                    If oRow("EsLCL") = 1 Then 'LCL
                        'Todo Destino
                        sRuta = Server.MapPath(sRuta & "AvisoZarpeMaritimoLcl.rpt")
                    End If
                End If
            End If
            'Aéreo
            If oRow("CONS_CodVia") = "002" Then
                If oRow("CONS_CodRGM") = "001" Then 'Impo
                    If oRow("EsLCL") = 0 Then 'FCL
                        sRuta = Server.MapPath(sRuta & "AvisoArriboAereo.rpt")
                    End If
                    If oRow("EsLCL") = 1 Then 'LCL
                        sRuta = Server.MapPath(sRuta & "AvisoArriboAereo.rpt")
                    End If
                ElseIf oRow("CONS_CodRGM") = "002" Then 'Expo
                    If oRow("EsLCL") = 0 Then 'FCL
                        sRuta = Server.MapPath(sRuta & "AvisoSalidaAereo.rpt")
                    End If
                    If oRow("EsLCL") = 1 Then 'LCL
                        'Todo Destino
                        sRuta = Server.MapPath(sRuta & "AvisoSalidaAereo.rpt")
                    End If
                End If
            End If

            Dim rpr As New ReportDocument
            rpr.FileName = sRuta
            rpr.SetDataSource(dsTabla.Tables(0))
            For r = 1 To 1
                rpr.Subreports(r - 1).SetDataSource(dsTabla.Tables(r))
            Next

            TargetFileName = ConfigurationManager.AppSettings("basePath").ToString() + "avisollegada\tmp\AVISO_" & HBL & ".pdf"
            rpr.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, TargetFileName)
            hdPdfAviso.Value = ConfigurationManager.AppSettings("urlBase").ToString() + "/avisollegada\tmp\AVISO_" & HBL & ".pdf"
        Catch ex As Exception

        End Try
    End Sub

    <WebMethod()>
    Public Shared Function fnValidHBLByAviso(ByVal shbl As String) As enAjax
        Dim oenAjax As New enAjax
        Try
            Dim oServicio As New ServicioDelfin.OnLineServiceClient
            Dim dtQuery As New DataTable
            dtQuery = oServicio.ExecuteSQL("SELECT CCOT_Numero, DOOV_HBL FROM NextSoft..COM_Cab_Cotizacion_OV (NOLOCK) WHERE DOOV_HBL='" & shbl & "'").Tables(0)
            oenAjax.iTipoResultado = 1
            If dtQuery.Rows.Count = 0 Then
                oenAjax.iTipoResultado = 2
                oenAjax.sMensajeError = "El HBL " & shbl & " no existe en el sistema, por favor verifique."
            Else
                Dim iCCOT_Numero As Integer = dtQuery.Rows(0)(0)
                dtQuery.Clear()
                dtQuery = oServicio.ExecuteSQL("SELECT CCOT_Numero FROM NextSoft..COM_Det_Cotizacion_OV_EventosTareas (NOLOCK) WHERE CCOT_Numero = " & iCCOT_Numero.ToString & " AND TIPO_CodEVE=115").Tables(0)
                If dtQuery.Rows.Count = 0 Then
                    oenAjax.iTipoResultado = 2
                    oenAjax.sMensajeError = "Favor tomar nota que el aviso del HBL " & shbl & " aún no ha sido enviado por el área de Operaciones, por favor remitir su consulta a customerper@delfingroupco.com.pe"
                End If
            End If
        Catch ex As Exception
            oenAjax.iTipoResultado = 2
            oenAjax.sMensajeError = "ocurrió un error al momento de cargar la información " + ex.ToString()
        End Try
        Return oenAjax
    End Function
End Class
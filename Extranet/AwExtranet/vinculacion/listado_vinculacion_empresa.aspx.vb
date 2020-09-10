Imports System.Web.Services
Imports Entidades
Imports AwExtranet.ServicioDelfin
Public Class listado_vinculacion_empresa
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        Response.Redirect("vinculacion_empresa_registro.aspx")
    End Sub

    <WebMethod()>
    Public Shared Function fnlistRelatedCompany(ByVal scode As Integer) As enAjax
        Dim oenAjax As New enAjax
        Try
            Dim oServicio As New ServicioDelfin.OnLineServiceClient
            Dim dt As New DataTable
            Dim oadPerfil As New EntidadVinculada_BE

            oadPerfil.ENTC_Codigo = scode

            dt = oServicio.GetAllDataTableRelatedCompany(oadPerfil)

            Dim valor As String = ""
            If dt.Rows.Count > 0 Then
                For Each row As DataRow In dt.Rows
                    Dim docIden, razonSocial, nombreContacto, correoContacto, tipoVinculacion, tipoVigencia, vigenciaDesde, vigenciaHasta, estado As String
                    If (row("ENTC_DocIden") Is DBNull.Value) Then
                        docIden = ""
                    Else
                        docIden = CStr(row("ENTC_DocIden"))
                    End If

                    If (row("ENTC_RazonSocial") Is DBNull.Value) Then
                        razonSocial = ""
                    Else
                        razonSocial = CStr(row("ENTC_RazonSocial"))
                    End If

                    If (row("NombreContacto") Is DBNull.Value) Then
                        nombreContacto = ""
                    Else
                        nombreContacto = CStr(row("NombreContacto"))
                    End If

                    If (row("CorreoContacto") Is DBNull.Value) Then
                        correoContacto = ""
                    Else
                        correoContacto = CStr(row("CorreoContacto"))
                    End If

                    If (row("TipoVinculacion") Is DBNull.Value) Then
                        tipoVinculacion = ""
                    Else
                        tipoVinculacion = CStr(row("TipoVinculacion"))
                    End If

                    If (row("TipoVigencia") Is DBNull.Value) Then
                        tipoVigencia = ""
                    Else
                        tipoVigencia = CStr(row("TipoVigencia"))
                    End If

                    If (row("VigenciaDesde") Is DBNull.Value) Then
                        vigenciaDesde = ""
                    Else
                        vigenciaDesde = CStr(row("VigenciaDesde"))
                    End If

                    If (row("VigenciaHasta") Is DBNull.Value) Then
                        vigenciaHasta = ""
                    Else
                        vigenciaHasta = CStr(row("VigenciaHasta"))
                    End If

                    If (row("Estado") Is DBNull.Value) Then
                        estado = ""
                    Else
                        estado = CStr(row("Estado"))
                    End If

                    valor += docIden + "," + razonSocial + "," + nombreContacto + "," + correoContacto + "," + tipoVinculacion + "," + tipoVigencia + "," + vigenciaDesde + "," + vigenciaHasta + "," + estado + "|"
                Next
                oenAjax.sValor1 = valor
                oenAjax.iTipoResultado = 1
            Else
                oenAjax.iTipoResultado = 2
                oenAjax.sMensajeError = "El cliente no tiene empresas asociadas"
            End If

            oenAjax.sValor1 = valor
        Catch ex As Exception
            oenAjax.iTipoResultado = 2
            oenAjax.sValor1 = "ocurrió un error al momento de cargar la información " + ex.ToString()
        End Try
        Return oenAjax
    End Function

    <WebMethod()>
    Public Shared Function fnunlink(ByVal scode As Integer, ByVal sNumberDocument As String, ByVal scorreo As String) As enAjax
        Dim oenAjax As New enAjax
        Try
            Dim oServicio As New ServicioDelfin.OnLineServiceClient
            Dim dt As New DataTable
            Dim oRelatedCompanyBE As New EntidadVinculada_BE

            oRelatedCompanyBE.ENTC_Codigo = scode
            oRelatedCompanyBE.ENTC_DocIdenVinculada = sNumberDocument
            oRelatedCompanyBE.Estado = "D"
            oRelatedCompanyBE.AUDI_UsrMod = scorreo
            oRelatedCompanyBE.AUDI_FecMod = Now

            oServicio.StatusUpdateRelatedCompany(oRelatedCompanyBE)
            oenAjax.sMensajeError = "Actualización Exitosa"
            oenAjax.iTipoResultado = 1
        Catch ex As Exception
            oenAjax.iTipoResultado = 2
            oenAjax.sMensajeError = "ocurrió un error al momento de cargar la información " + ex.ToString()
        End Try
        Return oenAjax
    End Function
End Class
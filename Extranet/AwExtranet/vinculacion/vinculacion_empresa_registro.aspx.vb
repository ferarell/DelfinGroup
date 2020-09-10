Imports System.Web.Services
Imports Entidades
Imports Negocio
Imports AwExtranet.ServicioDelfin
Public Class vinculacion_empresa_registro
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        loadTypeDocument()
        loadTypeLink()
        loadTypeValidity()
    End Sub

    Private Sub loadTypeLink()
        Try
            Dim oServicio As New ServicioDelfin.OnLineServiceClient
            Dim dt As New DataTable
            Dim dtSource As New DataTable

            dt = oServicio.ExecuteSQL("EXEC NextSoft.dgp.paListaTipoVinculacion").Tables(0)
            typeBonding.DataSource = dt
            typeBonding.TextField = "DescripcionTipoVinculacion"
            typeBonding.ValueField = "CodigoTipoVinculacion"
            typeBonding.DataBind()
            typeBonding.SelectedIndex = 0
        Catch ex As Exception

        End Try
    End Sub

    Private Sub loadTypeDocument()
        Try
            Dim oServicio As New ServicioDelfin.OnLineServiceClient
            Dim dt As New DataTable
            dt = oServicio.ExecuteSQL("EXEC NextSoft.dgp.paListaTipoDocumento").Tables(0)
            typeDocument.DataSource = dt
            typeDocument.TextField = "DescripcionTipoDocumento"
            typeDocument.ValueField = "CodigoTipoDocumento"
            typeDocument.DataBind()
            typeDocument.SelectedIndex = 0
        Catch ex As Exception

        End Try
    End Sub

    Private Sub loadTypeValidity()
        Try
            Dim oServicio As New ServicioDelfin.OnLineServiceClient
            Dim dt As New DataTable
            dt = oServicio.ExecuteSQL("EXEC NextSoft.dgp.paListaTipoVigencia").Tables(0)
            validityRate.DataSource = dt
            validityRate.TextField = "DescripcionTipoVigencia"
            validityRate.ValueField = "CodigoTipoVigencia"
            validityRate.DataBind()
            validityRate.SelectedIndex = 0
        Catch ex As Exception

        End Try
    End Sub

    <WebMethod()>
    Public Shared Function fnsaveRelatedCompany(ByVal code As Integer, ByVal numberDocument As String, ByVal contact As String, ByVal email As String, ByVal typeBonding As String, ByVal validityRate As String, ByVal dateStart As String, ByVal dateEnd As String, ByVal scorreo As String, ByVal sEmpresaP As String, ByVal sEmpresaV As String) As enAjax
        Dim oenAjax As New enAjax
        Try
            Dim oServicio As New ServicioDelfin.OnLineServiceClient
            Dim oRelatedCompany As New EntidadVinculada_BE

            Dim codigoVinculada As Integer = 0
            Dim dtQuery As New DataTable
            dtQuery = oServicio.ExecuteSQL("SELECT ENTC_Codigo FROM NextSoft.dbo.Entidad (NOLOCK) WHERE ENTC_DocIden='" & numberDocument & "'").Tables(0)
            codigoVinculada = dtQuery.Rows(0)(0)

            oRelatedCompany.ENTC_Codigo = code
            oRelatedCompany.ENTC_CodigoVinculada = codigoVinculada
            oRelatedCompany.NombreContacto = contact
            oRelatedCompany.CorreoContacto = email
            oRelatedCompany.CodigoTipoVinculacion = typeBonding
            oRelatedCompany.CodigoTipoVigencia = validityRate
            oRelatedCompany.VigenciaDesde = "1900-01-01"
            oRelatedCompany.VigenciaHasta = "1900-01-01"
            If validityRate = "002" Then
                oRelatedCompany.VigenciaDesde = Convert.ToDateTime(dateStart)
                oRelatedCompany.VigenciaHasta = Convert.ToDateTime(dateEnd)
            End If
            oRelatedCompany.Estado = "P"
            oRelatedCompany.AUDI_UsrCrea = scorreo
            oRelatedCompany.AUDI_FecCrea = Now
            oServicio.InsertRelatedCompany(oRelatedCompany)
            oenAjax.iTipoResultado = 1
            oenAjax.sValor1 = "La solicituda ha sido registrada satisfactoriamente."

            Dim oenCorreo As New neCorreo()
            Dim sMensaje As String = oenCorreo.bodyEmailVinculacion(sEmpresaP, sEmpresaV, contact, email, typeBonding, validityRate, dateStart, dateEnd)
            oenCorreo.EnviarCorreo("atencionalcliente@delfingroupco.com.pe", "Solicitud de Vinculación de Empresa", sMensaje)

        Catch ex As Exception
            oenAjax.iTipoResultado = 2
            oenAjax.sMensajeError = "ocurrió un error al momento de cargar la información " + ex.ToString()
        End Try
        Return oenAjax
    End Function
End Class
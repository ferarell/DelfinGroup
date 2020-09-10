Imports System.Web.Services
Imports Entidades
Imports Negocio
Imports AwExtranet.ServicioDelfin
Public Class direccionamiento_carga_registro
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        loadCustomer()
        loadDepositoHBLF()
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

    Private Sub loadDepositoHBLF()
        Dim oServicio As New ServicioDelfin.OnLineServiceClient
        Dim dt As New DataTable
        dt = oServicio.ExecuteSQL("EXEC NextSoft.dgp.paListaDeposito").Tables(0)
        depositoF.DataSource = dt
        depositoF.TextField = "DescripcionDepositoTemporal"
        depositoF.ValueField = "CodigoDepositoTemporal"
        depositoF.DataBind()

    End Sub

    <WebMethod()>
    Public Shared Function fnloadHbl(ByVal scode As Integer, ByVal shbl As String) As enAjax
        Dim oenAjax As New enAjax
        Try
            Dim oServicio As New ServicioDelfin.OnLineServiceClient
            Dim dt As New DataTable
            Dim oFiltroDireccionamiento As EntidadDireccionamiento_BE = New EntidadDireccionamiento_BE()
            dt = oServicio.CargoAddressingQuery(scode, 0, shbl)
            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then
                    oenAjax.iTipoResultado = 1
                    oenAjax.sValor1 = dt.Rows(0).Item("CodigoDepositoTemporal").ToString()
                    oenAjax.sValor2 = dt.Rows(0).Item("DepositoTemporal").ToString()
                Else
                    oenAjax.iTipoResultado = 2
                    oenAjax.sValor1 = "No se encontraron Bls con los criterios de búsqueda"
                End If
            End If

        Catch ex As Exception
            oenAjax.iTipoResultado = 2
            oenAjax.sValor1 = "ocurrió un error al momento de cargar la información " + ex.ToString()
        End Try
        Return oenAjax
    End Function

    <WebMethod()>
    Public Shared Function fsave(ByVal scode As Integer, ByVal shbl As String, ByVal type As Integer, ByVal depositoI As String, ByVal depositoF As Integer, ByVal email As String, ByVal userID As Integer) As enAjax
        Dim oenAjax As New enAjax
        Try
            Dim oServicio As New ServicioDelfin.OnLineServiceClient
            Dim oEntidadDireccionamiento_BE As EntidadDireccionamiento_BE = New EntidadDireccionamiento_BE()
            Dim oEntidadDireccionamiento_BE_Valida As EntidadDireccionamiento_BE = New EntidadDireccionamiento_BE()
            Dim oEntidadDireccionamiento_BE_Respuesta As EntidadDireccionamiento_BE = New EntidadDireccionamiento_BE()

            oEntidadDireccionamiento_BE.DOOV_HBL = shbl
            oEntidadDireccionamiento_BE.ENTC_CodDepTemporal = depositoI
            oEntidadDireccionamiento_BE.ENTC_CodDepTemporalSolicitado = depositoF
            oEntidadDireccionamiento_BE.DescargaDirecta = type
            oEntidadDireccionamiento_BE.ENTC_EMailSolicitante = email
            oEntidadDireccionamiento_BE.ENTC_Codigo = scode
            oEntidadDireccionamiento_BE.AUDI_UsrCrea = email
            oEntidadDireccionamiento_BE.AUDI_FecCrea = DateTime.Today
            oEntidadDireccionamiento_BE.ENDI_Estado = "P"

            oEntidadDireccionamiento_BE_Valida = oServicio.ValidarDireccionamiento(oEntidadDireccionamiento_BE)

            If oEntidadDireccionamiento_BE_Valida.CodigoRespuesta = "001" Then
                oEntidadDireccionamiento_BE_Respuesta = oServicio.InsertEntidadDireccionamiento(oEntidadDireccionamiento_BE)
            Else
                oenAjax.sValor1 = oEntidadDireccionamiento_BE_Valida.DescripcionRespuesta
            End If


            oenAjax.iTipoResultado = 0
            If oEntidadDireccionamiento_BE_Respuesta.CodigoRespuesta = "OK" Then
                oenAjax.iTipoResultado = 1
                oenAjax.sValor1 = "La solicitud se registró correctamente"
            Else
                oenAjax.sValor1 = "Ocurrió un error al actualizar los datos"
            End If

            Dim oenCorreo As New neCorreo()
            Dim sMensaje As String = oenCorreo.bodyEmailDireccionamiento(
                                        oEntidadDireccionamiento_BE_Respuesta.NombreCliente,
                                        oEntidadDireccionamiento_BE_Respuesta.DOOV_HBL,
                                        oEntidadDireccionamiento_BE_Respuesta.NombreDepositoTemporal,
                                        oEntidadDireccionamiento_BE_Respuesta.ENTC_EMailSolicitante,
                                        oEntidadDireccionamiento_BE_Respuesta.NombreDepositoTemporalAsignado,
                                        oEntidadDireccionamiento_BE_Respuesta.DescripcionEstado
                                        )


            oenCorreo.EnviarCorreo(oEntidadDireccionamiento_BE_Respuesta.ENTC_EMailSolicitante, "Solicitud de Direccionamiento de Carga", sMensaje)
            oenCorreo.EnviarCorreo("webmaster@delfingroupco.com.pe", "Solicitud de Direccionamiento de Carga", sMensaje)
            oenCorreo.EnviarCorreo("direccionamiento@delfingroupco.com.pe", "Solicitud de Direccionamiento de Carga", sMensaje)

        Catch ex As Exception
            oenAjax.iTipoResultado = 2
            oenAjax.sValor1 = "ocurrió un error al momento de cargar la información " + ex.ToString()
        End Try
        Return oenAjax
    End Function

End Class
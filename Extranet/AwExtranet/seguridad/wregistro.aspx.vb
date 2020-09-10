Imports System.Web.Services
Imports Entidades
Imports Negocio
Imports AwExtranet.ServicioDelfin

Public Class wregistro1
    Inherits System.Web.UI.Page

    Public ReadOnly Property sUrl As String
        Get
            Return (Page.ResolveUrl("~"))
        End Get
    End Property

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        loadTypeDocument()
    End Sub

    Private Sub loadTypeDocument()
        Try
            Dim oServicio As New ServicioDelfin.OnLineServiceClient
            Dim dt As New DataTable
            dt = oServicio.ExecuteSQL("EXEC NextSoft.dgp.paListaTipoDocumento").Tables(0)
            cboTipoDocumento.DataSource = dt
            cboTipoDocumento.TextField = "DescripcionTipoDocumento"
            cboTipoDocumento.ValueField = "CodigoTipoDocumento"
            cboTipoDocumento.DataBind()
            cboTipoDocumento.SelectedIndex = 0
        Catch ex As Exception

        End Try
    End Sub

    <WebMethod()>
    Public Shared Function fnRegistro(ByVal iIdUsuario As Integer, ByVal iTipoDocumento As String, sNroDocumento As String,
    sNombre As String, sApellidos As String, sCorreo As String, sArea As String, isExists As Integer, sPassword As String, sBusinessName As String, sCodeCustomer As Integer, sphone As String, iUserType As Integer) As enAjax
        Dim oenAjax As New enAjax
        Try
            Dim oServicio As New ServicioDelfin.OnLineServiceClient
            If (isExists = 1) Then

                Dim oenUsuario As New enUsuario
                Dim oadUsuario As New neUsuario

                oenUsuario.iTipoDocumento = CInt(iTipoDocumento)
                oenUsuario.sNroDocumento = sNroDocumento
                oenUsuario.sCorreo = sCorreo
                Dim iResultado As Integer = oadUsuario.fnValidarRegistro(oenUsuario)

                If (iResultado > 0) Then
                    oenAjax.iTipoResultado = 2
                    oenAjax.sMensajeError = "El registro ya existe"

                Else
                    Dim dtEmail As DataTable
                    dtEmail = oServicio.CustomerDocumentQuery(iTipoDocumento, sNroDocumento)
                    If dtEmail.Rows.Count > 0 Then
                        Dim isExist As Integer = 0
                        Dim listEmailValid() As String = dtEmail.Rows(0).Item(4).Split(";")

                        For i = 0 To UBound(listEmailValid)
                            If UCase(Trim(listEmailValid(i))) = UCase(sCorreo) Then
                                isExist = 1
                            End If
                        Next i

                        If (isExist = 1) Then
                            Dim oES As New Encryption64()
                            oenUsuario.iIdUsuario = iIdUsuario
                            oenUsuario.sNombre = sNombre
                            oenUsuario.sApellidos = sApellidos
                            oenUsuario.sPassword = oES.Encrypt(sPassword, "!9AZ#$a54DelfinGroup")
                            oenUsuario.sArea = sArea
                            oenUsuario.sRazonSocial = sBusinessName
                            oenUsuario.sCodeCustomer = sCodeCustomer
                            oenUsuario.iUserType = iUserType

                            If (iUserType = 12) Then
                                oenUsuario.iPerfilID = 3
                            Else
                                oenUsuario.iPerfilID = 2
                            End If

                            iResultado = oadUsuario.fnMantenimientoUsuario(oenUsuario)

                            If iResultado > 0 Then
                                oenAjax.iTipoResultado = 1
                                oenAjax.sMensajeError = "Se registró la información correctamente"
                                Dim oenCorreo As New neCorreo()
                                Dim sMensaje As String = oenCorreo.bodyEmail(iTipoDocumento, sNroDocumento, sNombre, sApellidos, sCorreo, sArea, 1, sPassword, sBusinessName, "")
                                oenCorreo.EnviarCorreo(sCorreo, "Correo de Confirmación (Extranet)", sMensaje)
                            Else
                                oenAjax.iTipoResultado = 2
                                oenAjax.sMensajeError = "Ocurrió un error al momento de registrar la información"
                            End If

                        Else
                            oenAjax.iTipoResultado = 2
                            oenAjax.sMensajeError = "La dirección de correo asignada no está registrada en nuestro sistema, por favor comuníquese con Atención al Cliente."
                        End If

                    End If
                End If
            Else
                Dim oenCorreo As New neCorreo()
                Dim sMensaje As String = oenCorreo.bodyEmail(iTipoDocumento, sNroDocumento, sNombre, sApellidos, sCorreo, sArea, 2, sPassword, sBusinessName, "")
                oenCorreo.EnviarCorreo("atencionalcliente@delfingroupco.com.pe", "SOLICITUD REGISTRO NUEVO USUARIO", sMensaje)
                oenAjax.iTipoResultado = 3
                oenAjax.sMensajeError = "El tipo y número de documento no se encuentran registrados como cliente en nuestro sistema. Se enviará un mensaje a Servicio al Cliente para que se contacten con usted a la brevedad posible."

                Dim oCustomerRegister As New EntidadRegistro_BE
                oCustomerRegister.TIPO_CodTDI = iTipoDocumento
                oCustomerRegister.ENTC_DocIden = sNroDocumento
                oCustomerRegister.ENTC_RazonSocial = sBusinessName
                oCustomerRegister.ENTC_EMail = sCorreo
                oCustomerRegister.ENTC_EmailReceptorFE = sCorreo
                oCustomerRegister.ENTC_Telef1 = sphone
                oCustomerRegister.ENTC_Origen = "EXT"
                oCustomerRegister.AUDI_UsrCrea = sCorreo
                oCustomerRegister.AUDI_FecCrea = Now
                oCustomerRegister.REGI_Estado = "P"
                oServicio.InsertCustomerRegister(oCustomerRegister)
            End If

        Catch ex As Exception

        End Try
        Return oenAjax
    End Function

    <WebMethod()>
    Public Shared Function fnValidarRegistros(ByVal sTypeDocument As String, ByVal sNumberDocument As String) As enAjax
        Dim oenAjax As New enAjax
        Try
            Dim oServicio As New ServicioDelfin.OnLineServiceClient
            Dim iRes As Integer = 2
            Dim dt As New DataTable

            dt = oServicio.CustomerDocumentQuery(sTypeDocument, sNumberDocument)

            If dt.Rows.Count > 0 Then
                iRes = 1
            End If
        Catch ex As Exception
            oenAjax.iTipoResultado = 2
            oenAjax.sValor1 = "ocurrió un error al momento de cargar la información " + ex.ToString()
        End Try
        Return oenAjax
    End Function


    <WebMethod()>
    Public Shared Function fnValidarRegistro(ByVal iTipoDocumento As String, ByVal sNroDocumento As String) As enAjax
        Dim oenAjax As New enAjax
        Try
            Dim sCorreoATC As String = ConfigurationManager.AppSettings("CorreoATC").ToString()
            Dim oServicio As New ServicioDelfin.OnLineServiceClient
            Dim iRes As Integer = 2
            Dim dt As New DataTable

            Dim sTipoDoc As String
            sTipoDoc = iTipoDocumento.ToString()
            dt = oServicio.CustomerDocumentQuery(sTipoDoc, sNroDocumento)

            If dt.Rows.Count > 0 Then
                iRes = 1
            End If

            Dim oenCorreo As New neCorreo()
            Dim sMensaje As String = ""


            If iRes = 1 Then
                oenAjax.iTipoResultado = 1
                oenAjax.sValor1 = dt.Rows(0).Item(2)
                oenAjax.sValor2 = dt.Rows(0).Item(1)
                oenAjax.nValor1 = dt.Rows(0).Item(7)

            Else
                oenAjax.iTipoResultado = 2
                oenAjax.sValor1 = sMensaje
            End If

        Catch ex As Exception
            oenAjax.iTipoResultado = 2
            oenAjax.sValor1 = "ocurrió un error al momento de cargar la información " + ex.ToString()

        End Try
        Return oenAjax
    End Function

End Class
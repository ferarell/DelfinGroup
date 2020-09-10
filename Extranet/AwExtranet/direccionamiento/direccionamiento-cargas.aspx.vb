Imports System.Web.Services
Imports Entidades
Imports AwExtranet.ServicioDelfin
Public Class direccionamiento_cargas
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
    Public Shared Function fnlistarDireccionamiento(ByVal scode As Integer, ByVal shbl As String) As enAjax
        Dim oenAjax As New enAjax
        Try
            Dim oServicio As New ServicioDelfin.OnLineServiceClient
            Dim dt As List(Of EntidadDireccionamiento_BE)
            Dim oFiltroDireccionamiento As EntidadDireccionamiento_BE = New EntidadDireccionamiento_BE()
            oFiltroDireccionamiento.ENTC_Codigo = scode
            oFiltroDireccionamiento.DOOV_HBL = shbl

            dt = New List(Of EntidadDireccionamiento_BE)(oServicio.GetByFilterEntidadDireccionamiento(oFiltroDireccionamiento))

            Dim valor As String = ""
            If dt.Count > 0 Then
                For Each item As EntidadDireccionamiento_BE In dt
                    Dim HBL, applicationDate, requestingEmail, currentDeposit, depositRequested, requestStatus, requestStatusDescription, code As String
                    If (item.DOOV_HBL Is DBNull.Value) Then
                        HBL = ""
                    Else
                        HBL = CStr(item.DOOV_HBL)
                    End If

                    applicationDate = CStr(item.AUDI_FecCrea)

                    If (item.ENTC_EMailSolicitante Is DBNull.Value) Then
                        requestingEmail = ""
                    Else
                        requestingEmail = CStr(item.ENTC_EMailSolicitante)
                    End If

                    If (item.NombreDepositoTemporal Is DBNull.Value) Then
                        currentDeposit = ""
                    Else
                        currentDeposit = CStr(item.NombreDepositoTemporal)
                    End If

                    If (item.NombreDepositoTemporalAsignado Is DBNull.Value) Then
                        depositRequested = ""
                    Else
                        depositRequested = CStr(item.NombreDepositoTemporalAsignado)
                    End If

                    If (item.ENDI_Estado Is DBNull.Value) Then
                        requestStatus = ""
                    Else
                        requestStatus = CStr(item.ENDI_Estado)
                    End If

                    If (item.DescripcionEstado Is DBNull.Value) Then
                        requestStatusDescription = ""
                    Else
                        requestStatusDescription = item.DescripcionEstado
                    End If

                    code = item.ENTC_Codigo

                    valor += HBL + "," + applicationDate + "," + requestingEmail + "," + currentDeposit + "," + depositRequested + "," + requestStatus + "," + requestStatusDescription + "," + code + "," +
                      CStr(item.ENTC_CodDepTemporal) + "," + CStr(item.DescargaDirecta) + "," + CStr(item.ENTC_CodDepTemporalSolicitado) + "|"
                Next
                oenAjax.sValor1 = valor
                oenAjax.iTipoResultado = 1

            Else
                oenAjax.iTipoResultado = 2
                oenAjax.sMensajeError = "El cliente no tiene información para mostrar"
            End If

            oenAjax.sValor1 = valor
        Catch ex As Exception
            oenAjax.iTipoResultado = 2
            oenAjax.sValor1 = "ocurrió un error al momento de cargar la información " + ex.ToString()
        End Try
        Return oenAjax
    End Function

    <WebMethod()>
    Public Shared Function deleteDireccionamiento(ByVal codigo As Integer, ByVal hbl As String, ByVal codtemporal As Integer, ByVal descargadirecta As Integer, ByVal coddeptemporalsolicitado As Integer, ByVal userID As Integer, ByVal email As String) As enAjax
        Dim oenAjax As New enAjax
        Try
            Dim oServicio As New ServicioDelfin.OnLineServiceClient
            Dim oEntidadDireccionamiento_BE As EntidadDireccionamiento_BE = New EntidadDireccionamiento_BE()

            oEntidadDireccionamiento_BE.DOOV_HBL = hbl
            oEntidadDireccionamiento_BE.ENTC_CodDepTemporal = codtemporal
            oEntidadDireccionamiento_BE.ENTC_CodDepTemporalSolicitado = coddeptemporalsolicitado
            oEntidadDireccionamiento_BE.DescargaDirecta = descargadirecta
            oEntidadDireccionamiento_BE.ENTC_EMailSolicitante = email
            oEntidadDireccionamiento_BE.ENTC_Codigo = codigo
            oEntidadDireccionamiento_BE.AUDI_UsrMod = userID
            oEntidadDireccionamiento_BE.AUDI_FecMod = DateTime.Today

            oServicio.DeleteEntidadDireccionamiento(oEntidadDireccionamiento_BE)
            oenAjax.iTipoResultado = 1
            oenAjax.sValor1 = "La solicitud se registró correctamente"

        Catch ex As Exception
            oenAjax.iTipoResultado = 2
            oenAjax.sValor1 = "ocurrió un error al momento de cargar la información " + ex.ToString()
        End Try
        Return oenAjax
    End Function
End Class

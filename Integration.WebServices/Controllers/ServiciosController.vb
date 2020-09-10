Imports System.Net
Imports System.Web.Http
Imports System.Web.Http.Results
Imports DataAccessLayer

Namespace Controllers
    Public Class ServiciosController
        Inherits ApiController

        <HttpGet>
        Public Function ObtenerTodosServicios() As JsonResult(Of List(Of DataAccessLayer.COM_Servicio))
            Dim DAL As ServiciosDAL = New ServiciosDAL()
            Dim listServicios As List(Of DataAccessLayer.COM_Servicio) = DAL.GetAllServicios()
            Return Json(Of List(Of DataAccessLayer.COM_Servicio))(listServicios)
        End Function


    End Class
End Namespace
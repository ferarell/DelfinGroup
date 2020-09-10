
Imports System.Net
Imports System.Web.Http
Imports System.Web.Http.Results
Imports DataAccessLayer


Namespace Controllers
    Public Class ConstantesController
        Inherits ApiController

        <HttpGet>
        Public Function ObtenerConstantesPorCriterio(cons_codtabla As String) As JsonResult(Of List(Of DataAccessLayer.Constantes))
            Dim DAL As ConstantesDAL = New ConstantesDAL()
            Dim listConstantes As List(Of DataAccessLayer.Constantes) = DAL.GetConstantesPorCriterio(cons_codtabla)
            Return Json(Of List(Of DataAccessLayer.Constantes))(listConstantes)
        End Function


    End Class
End Namespace
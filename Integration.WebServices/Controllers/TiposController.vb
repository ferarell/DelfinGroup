Imports System.Net
Imports System.Web.Http
Imports System.Web.Http.Results
Imports DataAccessLayer

Namespace Controllers
    Public Class TiposController
        Inherits ApiController

        <HttpGet>
        Public Function ObtenerTiposPorCriterio(Tipo_CodTabla As String) As JsonResult(Of List(Of DataAccessLayer.Tipos))
            Dim DAL As TiposDAL = New TiposDAL()
            Dim listTipo As List(Of DataAccessLayer.Tipos) = DAL.GetTiposPorCriterio(Tipo_CodTabla)
            Return Json(Of List(Of DataAccessLayer.Tipos))(listTipo)
        End Function

    End Class
End Namespace
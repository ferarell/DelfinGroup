Imports System.Net
Imports System.Web.Http
Imports System.Web.Http.Results
Imports DataAccessLayer

Namespace Controllers
    Public Class GroupController
        Inherits ApiController

        <HttpGet>
        Public Function ObtenerGrupos() As JsonResult(Of List(Of DataAccessLayer.Group))
            Dim DAL As GroupDAL = New GroupDAL()
            Dim empGrupos As List(Of DataAccessLayer.Group) = DAL.GetAllGrupos()
            Return Json(Of List(Of DataAccessLayer.Group))(empGrupos)
        End Function


        <HttpGet>
        Public Function ObtenerGrupoPorId(ByVal id As Integer) As JsonResult(Of DataAccessLayer.Group)
            'Dim mapObj As EntityMapper(Of DataAccessLayer.Product, Models.Product) = New EntityMapper(Of DataAccessLayer.Product, Models.Product)
            Dim DAL As GroupDAL = New GroupDAL()
            Dim oGrupo As DataAccessLayer.Group = DAL.GetGrupo(id)
            Return Json(Of DataAccessLayer.Group)(oGrupo)
        End Function

        <HttpPost>
        Public Function InsertarGrupo(ByVal oGrupo As DataAccessLayer.Group) As Boolean
            Dim status = False

            If ModelState.IsValid Then
                Dim DAL As GroupDAL = New GroupDAL()
                status = DAL.InsertGrupo(oGrupo)
            End If

            Return status
        End Function

        <HttpPut>
        Public Function UpdateGrupo(ByVal oGrupo As DataAccessLayer.Group) As Boolean
            'Dim mapObj As EntityMapper(Of Models.Product, DataAccessLayer.Product) = New EntityMapper(Of Models.Product, DataAccessLayer.Product)
            'Dim productObj As DataAccessLayer.Product = New DataAccessLayer.Product
            Dim DAL As GroupDAL = New GroupDAL()
            'productObj = mapObj.Translate(product)
            Dim status = DAL.UpdateGrupo(oGrupo)
            Return status
        End Function

        <HttpDelete>
        Public Function DeleteGrupo(ByVal id As Integer) As Boolean
            Dim DAL As GroupDAL = New GroupDAL()
            Dim status = DAL.DeleteGrupo(id)
            Return status
        End Function

    End Class
End Namespace
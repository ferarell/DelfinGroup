Imports System.Net
Imports System.Web.Http
Imports System.Web.Http.Results
Imports DataAccessLayer

Namespace Controllers
    Public Class UnitController
        Inherits ApiController

        <HttpGet>
        Public Function ObtenerUnidades() As JsonResult(Of List(Of DataAccessLayer.Unit))
            Dim DAL As UnitDAL = New UnitDAL()
            Dim empUnidades As List(Of DataAccessLayer.Unit) = DAL.GetAllUnidades()
            Return Json(Of List(Of DataAccessLayer.Unit))(empUnidades)
        End Function


        <HttpGet>
        Public Function ObtenerUnidadPorId(ByVal id As Integer) As JsonResult(Of DataAccessLayer.Unit)
            'Dim mapObj As EntityMapper(Of DataAccessLayer.Product, Models.Product) = New EntityMapper(Of DataAccessLayer.Product, Models.Product)
            Dim DAL As UnitDAL = New UnitDAL()
            Dim oUnidad As DataAccessLayer.Unit = DAL.GetUnidad(id)
            Return Json(Of DataAccessLayer.Unit)(oUnidad)
        End Function

        <HttpPost>
        Public Function InsertarUnidad(ByVal oUnidad As DataAccessLayer.Unit) As Boolean
            Dim status = False

            If ModelState.IsValid Then
                Dim DAL As UnitDAL = New UnitDAL()
                status = DAL.InsertUnidad(oUnidad)
            End If

            Return status
        End Function

        <HttpPut>
        Public Function UpdateUnidad(ByVal oUnidad As DataAccessLayer.Unit) As Boolean
            'Dim mapObj As EntityMapper(Of Models.Product, DataAccessLayer.Product) = New EntityMapper(Of Models.Product, DataAccessLayer.Product)
            'Dim productObj As DataAccessLayer.Product = New DataAccessLayer.Product
            Dim DAL As UnitDAL = New UnitDAL()
            'productObj = mapObj.Translate(product)
            Dim status = DAL.UpdateUnidad(oUnidad)
            Return status
        End Function

        <HttpDelete>
        Public Function DeleteUnidad(ByVal id As Integer) As Boolean
            Dim DAL As UnitDAL = New UnitDAL()
            Dim status = DAL.DeleteUnidad(id)
            Return status
        End Function



    End Class
End Namespace
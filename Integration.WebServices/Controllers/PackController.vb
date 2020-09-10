Imports System.Net
Imports System.Web.Http
Imports System.Web.Http.Results
Imports DataAccessLayer

Namespace Controllers
    Public Class PackController
        Inherits ApiController

        <HttpGet>
        Public Function ObtenerPaquetes() As JsonResult(Of List(Of DataAccessLayer.Pack))
            Dim DAL As PackDAL = New PackDAL()
            Dim empPaquetes As List(Of DataAccessLayer.Pack) = DAL.GetAllPaquetes()
            Return Json(Of List(Of DataAccessLayer.Pack))(empPaquetes)
        End Function


        <HttpGet>
        Public Function ObtenerPAquetePorId(ByVal id As Integer) As JsonResult(Of DataAccessLayer.Pack)
            'Dim mapObj As EntityMapper(Of DataAccessLayer.Product, Models.Product) = New EntityMapper(Of DataAccessLayer.Product, Models.Product)
            Dim DAL As PackDAL = New PackDAL()
            Dim oPaquete As DataAccessLayer.Pack = DAL.GetPaquete(id)
            Return Json(Of DataAccessLayer.Pack)(oPaquete)
        End Function

        <HttpPost>
        Public Function InsertarPaquete(ByVal oPaquete As DataAccessLayer.Pack) As Boolean
            Dim status = False

            If ModelState.IsValid Then
                Dim DAL As PackDAL = New PackDAL()
                status = DAL.InsertPaquete(oPaquete)
            End If

            Return status
        End Function

        <HttpPut>
        Public Function UpdatePaquete(ByVal oPaquete As DataAccessLayer.Pack) As Boolean
            'Dim mapObj As EntityMapper(Of Models.Product, DataAccessLayer.Product) = New EntityMapper(Of Models.Product, DataAccessLayer.Product)
            'Dim productObj As DataAccessLayer.Product = New DataAccessLayer.Product
            Dim DAL As PackDAL = New PackDAL()
            'productObj = mapObj.Translate(product)
            Dim status = DAL.UpdatePaquete(oPaquete)
            Return status
        End Function

        <HttpDelete>
        Public Function DeletePaquete(ByVal id As Integer) As Boolean
            Dim DAL As PackDAL = New PackDAL()
            Dim status = DAL.DeletePaquete(id)
            Return status
        End Function



    End Class
End Namespace
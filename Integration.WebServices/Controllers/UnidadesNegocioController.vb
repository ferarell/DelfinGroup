Imports System.Net
Imports System.Web.Http
Imports System.Web.Http.Results
Imports DataAccessLayer

Namespace Controllers
    Public Class UnidadesNegocioController
        Inherits ApiController


        <HttpGet>
        Public Function ObtenerUnidadesNegocio() As JsonResult(Of List(Of DataAccessLayer.BusinessUnit))
            Dim DAL As BusinessUnitDAL = New BusinessUnitDAL()
            Dim empUnidadesNegocio As List(Of DataAccessLayer.BusinessUnit) = DAL.GetAllUnidadesNegocio()
            Return Json(Of List(Of DataAccessLayer.BusinessUnit))(empUnidadesNegocio)
        End Function


        <HttpGet>
        Public Function ObtenerUnidadNegocioPorId(ByVal id As Integer) As JsonResult(Of DataAccessLayer.BusinessUnit)
            'Dim mapObj As EntityMapper(Of DataAccessLayer.Product, Models.Product) = New EntityMapper(Of DataAccessLayer.Product, Models.Product)
            Dim DAL As BusinessUnitDAL = New BusinessUnitDAL()
            Dim oUnidadNegocio As DataAccessLayer.BusinessUnit = DAL.GetUnidadNegocio(id)
            Return Json(Of DataAccessLayer.BusinessUnit)(oUnidadNegocio)
        End Function

        <HttpPost>
        Public Function InsertarUnidadNegocio(ByVal oUnidadNegocio As DataAccessLayer.BusinessUnit) As Boolean
            Dim status = False

            If ModelState.IsValid Then
                Dim DAL As BusinessUnitDAL = New BusinessUnitDAL()
                status = DAL.InsertUnidadNegocio(oUnidadNegocio)
            End If

            Return status
        End Function

        <HttpPut>
        Public Function UpdateUnidadNegocio(ByVal oUnidadNegocio As DataAccessLayer.BusinessUnit) As Boolean
            'Dim mapObj As EntityMapper(Of Models.Product, DataAccessLayer.Product) = New EntityMapper(Of Models.Product, DataAccessLayer.Product)
            'Dim productObj As DataAccessLayer.Product = New DataAccessLayer.Product
            Dim DAL As BusinessUnitDAL = New BusinessUnitDAL()
            'productObj = mapObj.Translate(product)
            Dim status = DAL.UpdateUnidadNegocio(oUnidadNegocio)
            Return status
        End Function

        <HttpDelete>
        Public Function DeleteUnidadNegocio(ByVal id As Integer) As Boolean
            Dim DAL As BusinessUnitDAL = New BusinessUnitDAL()
            Dim status = DAL.DeleteUnidadNegocio(id)
            Return status
        End Function

    End Class
End Namespace
Imports System.Net
Imports System.Web.Http
Imports System.Web.Http.Results
Imports DataAccessLayer

Namespace Controllers
    Public Class CompanyController
        Inherits ApiController

        <HttpGet>
        Public Function ObtenerCompanies() As JsonResult(Of List(Of DataAccessLayer.Company))
            Dim DAL As CompanyDAL = New CompanyDAL()
            Dim empCompanies As List(Of DataAccessLayer.Company) = DAL.GetAllCompanies()
            Return Json(Of List(Of DataAccessLayer.Company))(empCompanies)
        End Function


        <HttpGet>
        Public Function ObtenerCompaniaPorId(ByVal id As Integer) As JsonResult(Of DataAccessLayer.Company)
            'Dim mapObj As EntityMapper(Of DataAccessLayer.Product, Models.Product) = New EntityMapper(Of DataAccessLayer.Product, Models.Product)
            Dim DAL As CompanyDAL = New CompanyDAL()
            Dim oCompania As DataAccessLayer.Company = DAL.GetCompania(id)
            Return Json(Of DataAccessLayer.Company)(oCompania)
        End Function

        <HttpPost>
        Public Function InsertarCompania(ByVal oCompania As DataAccessLayer.Company) As Boolean
            Dim status = False

            If ModelState.IsValid Then
                Dim DAL As CompanyDAL = New CompanyDAL()
                status = DAL.InsertCompania(oCompania)
            End If

            Return status
        End Function

        <HttpPut>
        Public Function UpdateCompania(ByVal oCompania As DataAccessLayer.Company) As Boolean
            'Dim mapObj As EntityMapper(Of Models.Product, DataAccessLayer.Product) = New EntityMapper(Of Models.Product, DataAccessLayer.Product)
            'Dim productObj As DataAccessLayer.Product = New DataAccessLayer.Product
            Dim DAL As CompanyDAL = New CompanyDAL()
            'productObj = mapObj.Translate(product)
            Dim status = DAL.UpdateCompania(oCompania)
            Return status
        End Function

        <HttpDelete>
        Public Function DeleteCompania(ByVal id As Integer) As Boolean
            Dim DAL As CompanyDAL = New CompanyDAL()
            Dim status = DAL.DeleteCompania(id)
            Return status
        End Function




    End Class
End Namespace
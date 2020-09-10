Imports System.Net
Imports System.Web.Http
Imports System.Web.Http.Results
Imports DataAccessLayer

Namespace Controllers
    Public Class LayoutController
        Inherits ApiController


        <HttpGet>
        Public Function ObtenerLayouts() As JsonResult(Of List(Of DataAccessLayer.Layout))
            Dim DAL As LayoutDAL = New LayoutDAL()
            Dim empLayouts As List(Of DataAccessLayer.Layout) = DAL.GetAllLayouts()
            Return Json(Of List(Of DataAccessLayer.Layout))(empLayouts)
        End Function


        <HttpGet>
        Public Function ObtenerLayoutPorId(ByVal id As Integer) As JsonResult(Of DataAccessLayer.Layout)
            'Dim mapObj As EntityMapper(Of DataAccessLayer.Product, Models.Product) = New EntityMapper(Of DataAccessLayer.Product, Models.Product)
            Dim DAL As LayoutDAL = New LayoutDAL()
            Dim oLayout As DataAccessLayer.Layout = DAL.GetLayout(id)
            Return Json(Of DataAccessLayer.Layout)(oLayout)
        End Function

        <HttpPost>
        Public Function InsertarLayout(ByVal oLayout As DataAccessLayer.Layout) As Boolean
            Dim status = False

            If ModelState.IsValid Then
                Dim DAL As LayoutDAL = New LayoutDAL()
                status = DAL.InsertLayout(oLayout)
            End If

            Return status
        End Function

        <HttpPut>
        Public Function UpdateLayout(ByVal oLayout As DataAccessLayer.Layout) As Boolean
            'Dim mapObj As EntityMapper(Of Models.Product, DataAccessLayer.Product) = New EntityMapper(Of Models.Product, DataAccessLayer.Product)
            'Dim productObj As DataAccessLayer.Product = New DataAccessLayer.Product
            Dim DAL As LayoutDAL = New LayoutDAL()
            'productObj = mapObj.Translate(product)
            Dim status = DAL.UpdateLayout(oLayout)
            Return status
        End Function

        <HttpDelete>
        Public Function DeleteLayout(ByVal id As Integer) As Boolean
            Dim DAL As LayoutDAL = New LayoutDAL()
            Dim status = DAL.DeleteLayout(id)
            Return status
        End Function


    End Class
End Namespace
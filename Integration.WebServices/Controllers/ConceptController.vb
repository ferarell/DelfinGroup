Imports System.Net
Imports System.Web.Http
Imports System.Web.Http.Results
Imports DataAccessLayer

Namespace Controllers
    Public Class ConceptController
        Inherits ApiController

        <HttpGet>
        Public Function ObtenerConceptos() As JsonResult(Of List(Of DataAccessLayer.Concept))
            Dim DAL As ConceptDAL = New ConceptDAL()
            Dim empConceptos As List(Of DataAccessLayer.Concept) = DAL.GetAllConceptos()
            Return Json(Of List(Of DataAccessLayer.Concept))(empConceptos)
        End Function


        <HttpGet>
        Public Function ObtenerConceptoPorId(ByVal id As Integer) As JsonResult(Of DataAccessLayer.Concept)
            'Dim mapObj As EntityMapper(Of DataAccessLayer.Product, Models.Product) = New EntityMapper(Of DataAccessLayer.Product, Models.Product)
            Dim DAL As ConceptDAL = New ConceptDAL()
            Dim oConcepto As DataAccessLayer.Concept = DAL.GetConcepto(id)
            Return Json(Of DataAccessLayer.Concept)(oConcepto)
        End Function

        <HttpPost>
        Public Function InsertarConcepto(ByVal oConcepto As DataAccessLayer.Concept) As Boolean
            Dim status = False

            If ModelState.IsValid Then
                Dim DAL As ConceptDAL = New ConceptDAL()
                status = DAL.InsertConcepto(oConcepto)
            End If

            Return status
        End Function

        <HttpPut>
        Public Function UpdateConcepto(ByVal oConcepto As DataAccessLayer.Concept) As Boolean
            'Dim mapObj As EntityMapper(Of Models.Product, DataAccessLayer.Product) = New EntityMapper(Of Models.Product, DataAccessLayer.Product)
            'Dim productObj As DataAccessLayer.Product = New DataAccessLayer.Product
            Dim DAL As ConceptDAL = New ConceptDAL()
            'productObj = mapObj.Translate(product)
            Dim status = DAL.UpdateConcepto(oConcepto)
            Return status
        End Function

        <HttpDelete>
        Public Function DeleteConcepto(ByVal id As Integer) As Boolean
            Dim DAL As ConceptDAL = New ConceptDAL()
            Dim status = DAL.DeleteConcepto(id)
            Return status
        End Function



    End Class
End Namespace
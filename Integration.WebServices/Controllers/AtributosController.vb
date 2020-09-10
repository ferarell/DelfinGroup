Imports System.Data.Entity.Core.Objects
Imports System.Net
Imports System.Web.Http
Imports System.Web.Http.Results
Imports DataAccessLayer

Namespace Controllers
    Public Class AtributosController
        Inherits ApiController

        <HttpGet>
        Public Function ObtenerAtributos() As JsonResult(Of List(Of DataAccessLayer.Attribute))
            Dim DAL As AttributeDAL = New AttributeDAL()
            Dim empAtributos As List(Of DataAccessLayer.Attribute) = DAL.GetAllAtributos()
            Return Json(Of List(Of DataAccessLayer.Attribute))(empAtributos)
        End Function


        <HttpGet>
        Public Function GetValuesByAtributo(ByVal id As Integer) As JsonResult(Of ObjectResult(Of uspValueAttributes_Result))
            'Dim mapObj As EntityMapper(Of DataAccessLayer.Product, Models.Product) = New EntityMapper(Of DataAccessLayer.Product, Models.Product)
            Dim DAL As AttributeDAL = New AttributeDAL()
            Dim listValoresAtributos As ObjectResult(Of uspValueAttributes_Result) = DAL.GetValuesByAtributo(id)
            Return Json(Of ObjectResult(Of uspValueAttributes_Result))(listValoresAtributos)
        End Function

        <HttpGet>
        Public Function ObtenerAtributoPorId(ByVal id As Integer) As JsonResult(Of DataAccessLayer.Attribute)
            'Dim mapObj As EntityMapper(Of DataAccessLayer.Product, Models.Product) = New EntityMapper(Of DataAccessLayer.Product, Models.Product)
            Dim DAL As AttributeDAL = New AttributeDAL()
            Dim oAtributo As DataAccessLayer.Attribute = DAL.GetAtributo(id)
            Return Json(Of DataAccessLayer.Attribute)(oAtributo)
        End Function

        <HttpGet>
        Public Function ObtenerDescripcionValorAtributo(ByVal id As Integer, ByVal Valor As String) As ObjectResult(Of String)
            'Dim mapObj As EntityMapper(Of DataAccessLayer.Product, Models.Product) = New EntityMapper(Of DataAccessLayer.Product, Models.Product)
            Dim DAL As AttributeDAL = New AttributeDAL()
            'Dim DescripcionAtributo As String = DAL.GetAttributeDescription(id, Valor)
            Dim resultado As ObjectResult(Of String) = DAL.GetAttributeDescription(id, Valor)
            'Dim listAtributos As List(Of String) = resultado.ToList()
            'Dim descripcionResultado As String = ""
            ''Return resultado
            'If listAtributos.Count > 0 Then
            '    descripcionResultado = listAtributos(0)
            'End If

            Return resultado
        End Function




        <HttpPost>
        Public Function InsertarAtributo(ByVal oAtributo As DataAccessLayer.Attribute) As Boolean
            Dim status = False

            If ModelState.IsValid Then
                Dim DAL As AttributeDAL = New AttributeDAL()
                status = DAL.InsertAtributo(oAtributo)
            End If

            Return status
        End Function

        <HttpPut>
        Public Function UpdateAtributo(ByVal oAtributo As DataAccessLayer.Attribute) As Boolean
            'Dim mapObj As EntityMapper(Of Models.Product, DataAccessLayer.Product) = New EntityMapper(Of Models.Product, DataAccessLayer.Product)
            'Dim productObj As DataAccessLayer.Product = New DataAccessLayer.Product
            Dim DAL As AttributeDAL = New AttributeDAL()
            'productObj = mapObj.Translate(product)
            Dim status = DAL.UpdateAtributo(oAtributo)
            Return status
        End Function

        <HttpDelete>
        Public Function DeleteAtributo(ByVal id As Integer) As Boolean
            Dim DAL As AttributeDAL = New AttributeDAL()
            Dim status = DAL.DeleteAtributo(id)
            Return status
        End Function



    End Class
End Namespace
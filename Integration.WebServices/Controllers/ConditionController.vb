Imports System.Net
Imports System.Web.Http
Imports System.Web.Http.Results
Imports DataAccessLayer

Namespace Controllers
    Public Class ConditionController
        Inherits ApiController


        <HttpGet>
        Public Function ObtenerCondiciones() As JsonResult(Of List(Of DataAccessLayer.Condition))
            Dim DAL As ConditionDAL = New ConditionDAL()
            Dim empCondiciones As List(Of DataAccessLayer.Condition) = DAL.GetAllCondiciones()
            Return Json(Of List(Of DataAccessLayer.Condition))(empCondiciones)
        End Function


        <HttpGet>
        Public Function ObtenerCondicionPorId(ByVal id As Integer) As JsonResult(Of DataAccessLayer.Condition)
            'Dim mapObj As EntityMapper(Of DataAccessLayer.Product, Models.Product) = New EntityMapper(Of DataAccessLayer.Product, Models.Product)
            Dim DAL As ConditionDAL = New ConditionDAL()
            Dim oCondicion As DataAccessLayer.Condition = DAL.GetCondicion(id)
            Return Json(Of DataAccessLayer.Condition)(oCondicion)
        End Function

        <HttpPost>
        Public Function InsertarCondicion(ByVal oCondicion As DataAccessLayer.Condition) As Boolean
            Dim status = False

            If ModelState.IsValid Then
                Dim DAL As ConditionDAL = New ConditionDAL()
                status = DAL.InsertCondicion(oCondicion)
            End If

            Return status
        End Function

        <HttpPut>
        Public Function UpdateCondicion(ByVal oCondicion As DataAccessLayer.Condition) As Boolean
            'Dim mapObj As EntityMapper(Of Models.Product, DataAccessLayer.Product) = New EntityMapper(Of Models.Product, DataAccessLayer.Product)
            'Dim productObj As DataAccessLayer.Product = New DataAccessLayer.Product
            Dim DAL As ConditionDAL = New ConditionDAL()
            'productObj = mapObj.Translate(product)
            Dim status = DAL.UpdateCondicion(oCondicion)
            Return status
        End Function

        <HttpDelete>
        Public Function DeleteCondicion(ByVal id As Integer) As Boolean
            Dim DAL As ConditionDAL = New ConditionDAL()
            Dim status = DAL.DeleteCondicion(id)
            Return status
        End Function


    End Class
End Namespace
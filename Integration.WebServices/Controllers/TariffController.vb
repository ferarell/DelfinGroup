Imports System.Net
Imports System.Web.Http
Imports System.Web.Http.Results
Imports DataAccessLayer

Namespace Controllers
    Public Class TariffController
        Inherits ApiController


        <HttpGet>
        Public Function ObtenerTarifas() As JsonResult(Of List(Of DataAccessLayer.Tariff))
            Dim DAL As TariffDAL = New TariffDAL()
            Dim empTarifas As List(Of DataAccessLayer.Tariff) = DAL.GetAllTarifas()
            Return Json(Of List(Of DataAccessLayer.Tariff))(empTarifas)
        End Function


        <HttpGet>
        Public Function ObtenerTarifaPorId(ByVal id As Integer) As JsonResult(Of DataAccessLayer.Tariff)
            'Dim mapObj As EntityMapper(Of DataAccessLayer.Product, Models.Product) = New EntityMapper(Of DataAccessLayer.Product, Models.Product)
            Dim DAL As TariffDAL = New TariffDAL()
            Dim oTariff As DataAccessLayer.Tariff = DAL.GetTariff(id)
            Return Json(Of DataAccessLayer.Tariff)(oTariff)
        End Function

        <HttpPost>
        Public Function InsertarTarifa(ByVal oTariff As DataAccessLayer.Tariff) As Boolean
            Dim status = False

            If ModelState.IsValid Then
                Dim DAL As TariffDAL = New TariffDAL()
                status = DAL.InsertTariff(oTariff)
            End If

            Return status
        End Function

        <HttpPut>
        Public Function UpdateTarifa(ByVal oTariff As DataAccessLayer.Tariff) As Boolean
            'Dim mapObj As EntityMapper(Of Models.Product, DataAccessLayer.Product) = New EntityMapper(Of Models.Product, DataAccessLayer.Product)
            'Dim productObj As DataAccessLayer.Product = New DataAccessLayer.Product
            Dim DAL As TariffDAL = New TariffDAL()
            'productObj = mapObj.Translate(product)
            Dim status = DAL.UpdateTariff(oTariff)
            Return status
        End Function

        <HttpDelete>
        Public Function DeleteTarifa(ByVal id As Integer) As Boolean
            Dim DAL As TariffDAL = New TariffDAL()
            Dim status = DAL.DeleteTariff(id)
            Return status
        End Function




    End Class
End Namespace
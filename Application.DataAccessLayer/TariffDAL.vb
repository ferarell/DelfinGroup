Public Class TariffDAL
    Dim DbContext As TarifarioEntities = New TarifarioEntities()


    Public Function GetAllTarifas() As List(Of Tariff)
        Return DbContext.Tariff.ToList()
    End Function

    Public Function GetTariff(TariffId As Integer) As Tariff
        Return DbContext.Tariff.Where(Function(p) p.IdTariff = TariffId).FirstOrDefault()
    End Function

    Public Function InsertTariff(ByVal TariffItem As Tariff) As Boolean
        Dim status As Boolean

        Try
            DbContext.Tariff.Add(TariffItem)
            DbContext.SaveChanges()
            status = True
        Catch __unusedException1__ As Exception
            status = False
        End Try

        Return status
    End Function


    Public Function UpdateTariff(ByVal TariffItem As Tariff) As Boolean
        Dim status As Boolean


        Using dbContextTransaction = DbContext.Database.BeginTransaction()

            Try

                Dim condItem As Tariff = DbContext.Tariff.Where(Function(p) p.IdTariff = TariffItem.IdTariff).FirstOrDefault
                If condItem IsNot Nothing Then
                    condItem.IdTariff = TariffItem.IdTariff
                    condItem.TariffType = TariffItem.TariffType
                    condItem.IdLayout = TariffItem.IdLayout
                    condItem.TariffStatus = TariffItem.TariffStatus
                    condItem.Currency = TariffItem.Currency


                    condItem.ValidFrom = TariffItem.ValidFrom
                    condItem.ValidTo = TariffItem.ValidTo
                    condItem.Remarks = TariffItem.Remarks
                    'attbtItem.DateCreate = TariffItem.DateCreate
                    'condItem.DateUpdate = 2TariffItem.DateUpdate
                    condItem.DateUpdate = TariffItem.DateUpdate
                    'condItem.TariffDetail = TariffItem.TariffDetail
                    'attbtItem.UserCreate = TariffItem.UserCreate
                    condItem.UserUpdate = TariffItem.UserUpdate
                    'DbContext.TariffDetail.RemoveRange(TariffItem.TariffDetail)
                    DbContext.Entry(condItem).State = System.Data.Entity.EntityState.Modified
                    'DbContext.Entry(condItem.TariffDetail).State = System.Data.Entity.EntityState.Modified
                    'DbContext.Set(condItem.TariffDetail.GetType).








                    Dim listTariffServiceCurrent As List(Of TariffDetail) = New List(Of TariffDetail)()
                    listTariffServiceCurrent = TariffItem.TariffDetail.ToList()

                    Dim listTariffServicePrevious As List(Of TariffDetail) = New List(Of TariffDetail)()
                    listTariffServicePrevious = condItem.TariffDetail.ToList()




                    'Por Eliminar

                    For Each item As TariffDetail In listTariffServicePrevious

                        Dim deletedTariffDetail As TariffDetail = listTariffServiceCurrent.Find(Function(p) p.IdTariffDetail = item.IdTariffDetail)

                        If deletedTariffDetail Is Nothing Then
                            DbContext.Entry(item).State = System.Data.Entity.EntityState.Deleted
                        End If



                    Next

                    'Por Añadir / Actualizar


                    For Each item As TariffDetail In listTariffServiceCurrent

                        'Dim add_update_TariffDetail As TariffDetail = listTariffServicePrevious.Find(Function(p) p.IdTariffDetail = item.IdTariffDetail)

                        If item.IdTariffDetail = 0 Then
                            DbContext.Entry(item).State = System.Data.Entity.EntityState.Added
                        Else
                            'DbContext.TariffDetail.Add(item)
                            Dim condItemTariffDetail As TariffDetail = DbContext.TariffDetail.Where(Function(p) p.IdTariffDetail = item.IdTariffDetail).FirstOrDefault
                            condItemTariffDetail.IdTariffDetail = item.IdTariffDetail
                            condItemTariffDetail.IdTariff = item.IdTariff
                            condItemTariffDetail.IdUnit = item.IdUnit
                            condItemTariffDetail.IdConcept = item.IdConcept
                            condItemTariffDetail.SalesAmount = item.SalesAmount
                            condItemTariffDetail.CostsAmount = item.CostsAmount
                            condItemTariffDetail.ContributionMargin = item.ContributionMargin
                            condItemTariffDetail.UserUpdate = item.UserUpdate
                            condItemTariffDetail.DateUpdate = item.DateUpdate
                            condItemTariffDetail.Currency = item.Currency
                            DbContext.Entry(condItemTariffDetail).State = System.Data.Entity.EntityState.Modified

                        End If

                    Next

                    DbContext.SaveChanges()
                    dbContextTransaction.Commit()
                End If





                status = True
            Catch __unusedException1__ As Exception
                dbContextTransaction.Rollback()
                status = False
            End Try





        End Using





        Return status
    End Function


    Public Function DeleteTariff(ByVal id As Integer) As Boolean
        Dim status As Boolean

        Try
            Dim attItem As Tariff = DbContext.Tariff.Where(Function(p) p.IdTariff = id).FirstOrDefault

            If attItem IsNot Nothing Then
                DbContext.Tariff.Remove(attItem)
                DbContext.SaveChanges()
            End If

            status = True
        Catch __unusedException1__ As Exception
            status = False
        End Try

        Return status
    End Function
End Class





'Imports System
'Imports System.Collections.Generic
'Imports System.Data.Entity
'Imports System.Data.SqlClient
'Imports System.Linq
'Imports System.Transactions

'Namespace TransactionsExamples
'    Class TransactionsExample
'        Private Shared Sub StartOwnTransactionWithinContext()
'            Using context = New BloggingContext()

'                Using dbContextTransaction = context.Database.BeginTransaction()
'                    context.Database.ExecuteSqlCommand("UPDATE Blogs SET Rating = 5" & " WHERE Name LIKE '%Entity Framework%'")
'                    Dim query = context.Posts.Where(Function(p) p.Blog.Rating >= 5)

'                    For Each post In query
'                        post.Title += "[Cool Blog]"
'                    Next

'                    context.SaveChanges()
'                    dbContextTransaction.Commit()
'                End Using
'            End Using
'        End Sub
'    End Class
'End Namespace

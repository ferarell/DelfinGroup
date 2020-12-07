Public Class PackDAL
    Dim DbContext As TarifarioEntities = New TarifarioEntities()


    Public Function GetAllPaquetes() As List(Of Pack)
        Return DbContext.Pack.ToList()
    End Function

    Public Function GetPaquete(PaqueteId As Integer) As Pack
        Return DbContext.Pack.Where(Function(p) p.IdPack = PaqueteId).FirstOrDefault()
    End Function

    Public Function InsertPaquete(ByVal PaqueteItem As Pack) As Boolean
        Dim status As Boolean

        Try
            DbContext.Pack.Add(PaqueteItem)
            DbContext.SaveChanges()
            status = True
        Catch __unusedException1__ As Exception
            status = False
        End Try

        Return status
    End Function


    Public Function UpdatePaquete(ByVal PaqueteItem As Pack) As Boolean
        Dim status As Boolean


        Using dbContextTransaction = DbContext.Database.BeginTransaction()

            Try

                Dim condItem As Pack = DbContext.Pack.Where(Function(p) p.IdPack = PaqueteItem.IdPack).FirstOrDefault
                If condItem IsNot Nothing Then
                    condItem.IdPack = PaqueteItem.IdPack
                    condItem.PackCode = PaqueteItem.PackCode
                    condItem.PackDescription = PaqueteItem.PackDescription
                    condItem.PackStatus = PaqueteItem.PackStatus



                    condItem.DistributionType = PaqueteItem.DistributionType

                    condItem.DateUpdate = PaqueteItem.DateUpdate
                    'condItem.PackConcept = PaqueteItem.PackConcept
                    'attbtItem.UserCreate = PaqueteItem.UserCreate
                    condItem.UserUpdate = PaqueteItem.UserUpdate
                    'DbContext.PackConcept.RemoveRange(PaqueteItem.PackConcept)
                    DbContext.Entry(condItem).State = System.Data.Entity.EntityState.Modified
                    'DbContext.Entry(condItem.PackConcept).State = System.Data.Entity.EntityState.Modified
                    'DbContext.Set(condItem.PackConcept.GetType).


                    Dim listPackServiceCurrent As List(Of PackDetail) = New List(Of PackDetail)()
                    listPackServiceCurrent = PaqueteItem.PackDetail.ToList()

                    Dim listPackServicePrevious As List(Of PackDetail) = New List(Of PackDetail)()
                    listPackServicePrevious = condItem.PackDetail.ToList()




                    'Por Eliminar

                    For Each item As PackDetail In listPackServicePrevious

                        Dim deletedPackConcept As PackDetail = listPackServiceCurrent.Find(Function(p) p.IdPackDetail = item.IdPackDetail)

                        If deletedPackConcept Is Nothing Then
                            DbContext.Entry(item).State = System.Data.Entity.EntityState.Deleted
                        End If



                    Next

                    'Por Añadir / Actualizar


                    For Each item As PackDetail In listPackServiceCurrent

                        'Dim add_update_PackConcept As PackConcept = listPackServicePrevious.Find(Function(p) p.IdPackConcept = item.IdPackConcept)

                        If item.IdPackDetail = 0 Then
                            item.UserCreate = PaqueteItem.UserUpdate
                            item.DateCreate = PaqueteItem.DateUpdate
                            DbContext.Entry(item).State = System.Data.Entity.EntityState.Added
                        Else
                            'DbContext.PackConcept.Add(item)
                            Dim condItemPackConcept As PackDetail = DbContext.PackDetail.Where(Function(p) p.IdPackDetail = item.IdPackDetail).FirstOrDefault
                            condItemPackConcept.IdPackDetail = item.IdPackDetail
                            condItemPackConcept.DistributionValue = item.DistributionValue
                            condItemPackConcept.VendorEquivalentCode = item.VendorEquivalentCode
                            condItemPackConcept.IdPack = item.IdPack
                            condItemPackConcept.IdConcept = item.IdConcept
                            condItemPackConcept.UserUpdate = item.UserUpdate
                            condItemPackConcept.DateUpdate = item.DateUpdate
                            DbContext.Entry(condItemPackConcept).State = System.Data.Entity.EntityState.Modified


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


    Public Function DeletePaquete(ByVal id As Integer) As Boolean
        Dim status As Boolean

        Try
            Dim attItem As Pack = DbContext.Pack.Where(Function(p) p.IdPack = id).FirstOrDefault

            If attItem IsNot Nothing Then
                DbContext.Pack.Remove(attItem)
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

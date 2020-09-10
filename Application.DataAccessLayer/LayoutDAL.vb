Public Class LayoutDAL
    Dim DbContext As TarifarioEntities = New TarifarioEntities()


    Public Function GetAllLayouts() As List(Of Layout)

        'Dim listLayouts As List(Of Layout) = DbContext.Layout.ToList()
        'For Each item As Layout In listLayouts
        '    Dim listLayoutAttribute As List(Of LayoutAttribute) = New List(Of LayoutAttribute)()
        '    listLayoutAttribute = item.LayoutAttribute
        '    For Each itemDetail As LayoutAttribute In listLayoutAttribute

        '        itemDetail.AttributeDescription = DbContext.upGetAttributeDescription(itemDetail.IdAttribute, itemDetail.Value).ToString()
        '    Next
        'Next


        'Return listLayouts

        Return DbContext.Layout.ToList()

    End Function

    Public Function GetLayout(LayoutId As Integer) As Layout
        'Dim item As Layout = DbContext.Layout.Where(Function(p) p.IdLayout = LayoutId).FirstOrDefault()
        'Dim listLayoutAttribute As List(Of LayoutAttribute) = New List(Of LayoutAttribute)()
        'listLayoutAttribute = item.LayoutAttribute
        'For Each itemDetail As LayoutAttribute In listLayoutAttribute

        '    itemDetail.AttributeDescription = DbContext.upGetAttributeDescription(itemDetail.IdAttribute, itemDetail.Value).ToString()
        'Next

        'Return item
        Return DbContext.Layout.Where(Function(p) p.IdLayout = LayoutId).FirstOrDefault()
    End Function

    Public Function InsertLayout(ByVal LayoutItem As Layout) As Boolean
        Dim status As Boolean

        Try
            DbContext.Layout.Add(LayoutItem)
            DbContext.SaveChanges()
            status = True
        Catch __unusedException1__ As Exception
            status = False
        End Try

        Return status
    End Function


    Public Function UpdateLayout(ByVal LayoutItem As Layout) As Boolean
        Dim status As Boolean


        Using dbContextTransaction = DbContext.Database.BeginTransaction()

            Try

                Dim condItem As Layout = DbContext.Layout.Where(Function(p) p.IdLayout = LayoutItem.IdLayout).FirstOrDefault
                If condItem IsNot Nothing Then
                    condItem.IdLayout = LayoutItem.IdLayout
                    condItem.LayoutCode = LayoutItem.LayoutCode
                    condItem.LayoutDescription = LayoutItem.LayoutDescription
                    condItem.LayoutStatus = LayoutItem.LayoutStatus



                    condItem.IdConcept = LayoutItem.IdConcept
                    condItem.IdCondition = LayoutItem.IdCondition
                    condItem.IdPack = LayoutItem.IdPack
                    'attbtItem.DateCreate = LayoutItem.DateCreate
                    'condItem.DateUpdate = 2LayoutItem.DateUpdate
                    condItem.IdBusinessUnit = LayoutItem.IdBusinessUnit
                    condItem.DateUpdate = LayoutItem.DateUpdate
                    'condItem.LayoutAttribute = LayoutItem.LayoutAttribute
                    'attbtItem.UserCreate = LayoutItem.UserCreate
                    condItem.UserUpdate = LayoutItem.UserUpdate
                    'DbContext.LayoutAttribute.RemoveRange(LayoutItem.LayoutAttribute)
                    DbContext.Entry(condItem).State = System.Data.Entity.EntityState.Modified
                    'DbContext.Entry(condItem.LayoutAttribute).State = System.Data.Entity.EntityState.Modified
                    'DbContext.Set(condItem.LayoutAttribute.GetType).








                    Dim listLayoutServiceCurrent As List(Of LayoutAttribute) = New List(Of LayoutAttribute)()
                    listLayoutServiceCurrent = LayoutItem.LayoutAttribute.ToList()

                    Dim listLayoutServicePrevious As List(Of LayoutAttribute) = New List(Of LayoutAttribute)()
                    listLayoutServicePrevious = condItem.LayoutAttribute.ToList()




                    'Por Eliminar

                    For Each item As LayoutAttribute In listLayoutServicePrevious

                        Dim deletedLayoutAttribute As LayoutAttribute = listLayoutServiceCurrent.Find(Function(p) p.IdLayoutAttribute = item.IdLayoutAttribute)

                        If deletedLayoutAttribute Is Nothing Then
                            DbContext.Entry(item).State = System.Data.Entity.EntityState.Deleted
                        End If



                    Next

                    'Por Añadir / Actualizar


                    For Each item As LayoutAttribute In listLayoutServiceCurrent

                        'Dim add_update_LayoutAttribute As LayoutAttribute = listLayoutServicePrevious.Find(Function(p) p.IdLayoutAttribute = item.IdLayoutAttribute)

                        If item.IdLayoutAttribute = 0 Then
                            DbContext.Entry(item).State = System.Data.Entity.EntityState.Added
                        Else
                            'DbContext.LayoutAttribute.Add(item)
                            Dim condItemLayoutAttribute As LayoutAttribute = DbContext.LayoutAttribute.Where(Function(p) p.IdLayoutAttribute = item.IdLayoutAttribute).FirstOrDefault
                            condItemLayoutAttribute.IdLayoutAttribute = item.IdLayoutAttribute
                            condItemLayoutAttribute.IdLayout = item.IdLayout
                            condItemLayoutAttribute.IdAttribute = item.IdAttribute
                            condItemLayoutAttribute.Value = item.Value
                            condItemLayoutAttribute.UserUpdate = item.UserUpdate
                            condItemLayoutAttribute.DateUpdate = item.DateUpdate
                            DbContext.Entry(condItemLayoutAttribute).State = System.Data.Entity.EntityState.Modified


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


    Public Function DeleteLayout(ByVal id As Integer) As Boolean
        Dim status As Boolean

        Try
            Dim attItem As Layout = DbContext.Layout.Where(Function(p) p.IdLayout = id).FirstOrDefault

            If attItem IsNot Nothing Then
                DbContext.Layout.Remove(attItem)
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

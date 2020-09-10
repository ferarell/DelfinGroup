Public Class ConditionDAL
    Dim DbContext As TarifarioEntities = New TarifarioEntities()


    Public Function GetAllCondiciones() As List(Of Condition)
        Return DbContext.Condition.ToList()
    End Function

    Public Function GetCondicion(CondicionId As Integer) As Condition
        Return DbContext.Condition.Where(Function(p) p.IdCondition = CondicionId).FirstOrDefault()
    End Function

    Public Function InsertCondicion(ByVal CondicionItem As Condition) As Boolean
        Dim status As Boolean

        Try
            DbContext.Condition.Add(CondicionItem)
            DbContext.SaveChanges()
            status = True
        Catch __unusedException1__ As Exception
            status = False
        End Try

        Return status
    End Function


    Public Function UpdateCondicion(ByVal CondicionItem As Condition) As Boolean
        Dim status As Boolean

        Try
            Dim condItem As Condition = DbContext.Condition.Where(Function(p) p.IdCondition = CondicionItem.IdCondition).FirstOrDefault

            If condItem IsNot Nothing Then
                condItem.IdCondition = CondicionItem.IdCondition
                condItem.ConditionCode = CondicionItem.ConditionCode
                condItem.ConditionDescription = CondicionItem.ConditionDescription
                condItem.ConditionStatus = CondicionItem.ConditionStatus
                condItem.IdUnit = CondicionItem.IdUnit
                'attbtItem.DateCreate = CondicionItem.DateCreate
                condItem.DateUpdate = CondicionItem.DateUpdate
                condItem.MaxValue = CondicionItem.MaxValue
                condItem.MinValue = CondicionItem.MinValue
                condItem.DateUpdate = CondicionItem.DateUpdate


                condItem.IdBusinessUnit = CondicionItem.IdBusinessUnit

                'attbtItem.UserCreate = CondicionItem.UserCreate
                condItem.UserUpdate = CondicionItem.UserUpdate
                DbContext.SaveChanges()
            End If

            status = True
        Catch __unusedException1__ As Exception
            status = False
        End Try

        Return status
    End Function


    Public Function DeleteCondicion(ByVal id As Integer) As Boolean
        Dim status As Boolean

        Try
            Dim attItem As Condition = DbContext.Condition.Where(Function(p) p.IdCondition = id).FirstOrDefault

            If attItem IsNot Nothing Then
                DbContext.Condition.Remove(attItem)
                DbContext.SaveChanges()
            End If

            status = True
        Catch __unusedException1__ As Exception
            status = False
        End Try

        Return status
    End Function
End Class

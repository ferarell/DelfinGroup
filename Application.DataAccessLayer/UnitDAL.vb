Public Class UnitDAL
    Dim DbContext As TarifarioEntities = New TarifarioEntities()


    Public Function GetAllUnidades() As List(Of Unit)
        Return DbContext.Unit.ToList()
    End Function

    Public Function GetUnidad(UnidadId As Integer) As Unit
        Return DbContext.Unit.Where(Function(p) p.IdUnit = UnidadId).FirstOrDefault()
    End Function

    Public Function InsertUnidad(ByVal UnidadItem As Unit) As Boolean
        Dim status As Boolean

        Try
            DbContext.Unit.Add(UnidadItem)
            DbContext.SaveChanges()
            status = True
        Catch __unusedException1__ As Exception
            status = False
        End Try

        Return status
    End Function


    Public Function UpdateUnidad(ByVal UnidadItem As Unit) As Boolean
        Dim status As Boolean

        Try
            Dim UnitItem As Unit = DbContext.Unit.Where(Function(p) p.IdUnit = UnidadItem.IdUnit).FirstOrDefault

            If UnitItem IsNot Nothing Then
                UnitItem.IdUnit = UnidadItem.IdUnit
                UnitItem.UnitCode = UnidadItem.UnitCode
                UnitItem.UnitDescription = UnidadItem.UnitDescription
                UnitItem.EquivalentCode = UnidadItem.EquivalentCode
                UnitItem.UnitStatus = UnidadItem.UnitStatus
                'attbtItem.DateCreate = UnidadItem.DateCreate
                UnitItem.DateUpdate = UnidadItem.DateUpdate
                'attbtItem.UserCreate = UnidadItem.UserCreate
                UnitItem.UserUpdate = UnidadItem.UserUpdate
                DbContext.SaveChanges()
            End If

            status = True
        Catch __unusedException1__ As Exception
            status = False
        End Try

        Return status
    End Function


    Public Function DeleteUnidad(ByVal id As Integer) As Boolean
        Dim status As Boolean

        Try
            Dim attItem As Unit = DbContext.Unit.Where(Function(p) p.IdUnit = id).FirstOrDefault

            If attItem IsNot Nothing Then
                DbContext.Unit.Remove(attItem)
                DbContext.SaveChanges()
            End If

            status = True
        Catch __unusedException1__ As Exception
            status = False
        End Try

        Return status
    End Function
End Class

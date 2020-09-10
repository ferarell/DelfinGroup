Public Class BusinessUnitDAL

    Dim DbContext As TarifarioEntities = New TarifarioEntities()


    Public Function GetAllUnidadesNegocio() As List(Of BusinessUnit)
        Return DbContext.BusinessUnit.ToList()
    End Function

    Public Function GetUnidadNegocio(UnidadNegocioId As Integer) As BusinessUnit
        Return DbContext.BusinessUnit.Where(Function(p) p.IdBusinessUnit = UnidadNegocioId).FirstOrDefault()
    End Function

    Public Function InsertUnidadNegocio(ByVal UnidadNegocioItem As BusinessUnit) As Boolean
        Dim status As Boolean

        Try
            DbContext.BusinessUnit.Add(UnidadNegocioItem)
            DbContext.SaveChanges()
            status = True
        Catch __unusedException1__ As Exception
            status = False
        End Try

        Return status
    End Function


    Public Function UpdateUnidadNegocio(ByVal UnidadNegocioItem As BusinessUnit) As Boolean
        Dim status As Boolean

        Try
            Dim unidNegtItem As BusinessUnit = DbContext.BusinessUnit.Where(Function(p) p.IdBusinessUnit = UnidadNegocioItem.IdBusinessUnit).FirstOrDefault

            If unidNegtItem IsNot Nothing Then
                unidNegtItem.IdBusinessUnit = UnidadNegocioItem.IdBusinessUnit
                unidNegtItem.BusinessUnitCode = UnidadNegocioItem.BusinessUnitCode
                unidNegtItem.BusinessUnitDescription = UnidadNegocioItem.BusinessUnitDescription
                unidNegtItem.IdCompany = UnidadNegocioItem.IdCompany
                unidNegtItem.BusinessUnitStatus = UnidadNegocioItem.BusinessUnitStatus
                'attbtItem.DateCreate = UnidadNegocioItem.DateCreate
                unidNegtItem.DateUpdate = UnidadNegocioItem.DateUpdate
                'attbtItem.UserCreate = UnidadNegocioItem.UserCreate
                unidNegtItem.UserUpdate = UnidadNegocioItem.UserUpdate
                DbContext.SaveChanges()
            End If

            status = True
        Catch __unusedException1__ As Exception
            status = False
        End Try

        Return status
    End Function


    Public Function DeleteUnidadNegocio(ByVal id As Integer) As Boolean
        Dim status As Boolean

        Try
            Dim attItem As BusinessUnit = DbContext.BusinessUnit.Where(Function(p) p.IdBusinessUnit = id).FirstOrDefault

            If attItem IsNot Nothing Then
                DbContext.BusinessUnit.Remove(attItem)
                DbContext.SaveChanges()
            End If

            status = True
        Catch __unusedException1__ As Exception
            status = False
        End Try

        Return status
    End Function

End Class

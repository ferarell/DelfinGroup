Public Class GroupDAL
    Dim DbContext As TarifarioEntities = New TarifarioEntities()


    Public Function GetAllGrupos() As List(Of Group)
        Return DbContext.Group.ToList()
    End Function

    Public Function GetGrupo(GrupoId As Integer) As Group
        Return DbContext.Group.Where(Function(p) p.IdGroup = GrupoId).FirstOrDefault()
    End Function

    Public Function InsertGrupo(ByVal GrupoItem As Group) As Boolean
        Dim status As Boolean

        Try
            DbContext.Group.Add(GrupoItem)
            DbContext.SaveChanges()
            status = True
        Catch __unusedException1__ As Exception
            status = False
        End Try

        Return status
    End Function


    Public Function UpdateGrupo(ByVal GrupoItem As Group) As Boolean
        Dim status As Boolean

        Try
            Dim GroupItem As Group = DbContext.Group.Where(Function(p) p.IdGroup = GrupoItem.IdGroup).FirstOrDefault

            If GroupItem IsNot Nothing Then
                GroupItem.IdGroup = GrupoItem.IdGroup
                GroupItem.GroupCode = GrupoItem.GroupCode
                GroupItem.GroupDescription = GrupoItem.GroupDescription

                GroupItem.GrouopStatus = GrupoItem.GrouopStatus
                'attbtItem.DateCreate = GrupoItem.DateCreate
                GroupItem.DateUpdate = GrupoItem.DateUpdate
                'attbtItem.UserCreate = GrupoItem.UserCreate
                GroupItem.UserUpdate = GrupoItem.UserUpdate
                DbContext.SaveChanges()
            End If

            status = True
        Catch __unusedException1__ As Exception
            status = False
        End Try

        Return status
    End Function


    Public Function DeleteGrupo(ByVal id As Integer) As Boolean
        Dim status As Boolean

        Try
            Dim attItem As Group = DbContext.Group.Where(Function(p) p.IdGroup = id).FirstOrDefault

            If attItem IsNot Nothing Then
                DbContext.Group.Remove(attItem)
                DbContext.SaveChanges()
            End If

            status = True
        Catch __unusedException1__ As Exception
            status = False
        End Try

        Return status
    End Function
End Class

Imports System.Data.Entity.Core.Objects

Public Class AttributeDAL
    Dim DbContext As TarifarioEntities = New TarifarioEntities()


    Public Function GetAllAtributos() As List(Of Attribute)
        Return DbContext.Attribute.ToList()
    End Function

    Public Function GetAtributo(atributoId As Integer) As Attribute
        Return DbContext.Attribute.Where(Function(p) p.IdAttribute = atributoId).FirstOrDefault()
    End Function

    Public Function GetAttributeDescription(atributoId As Integer, Value As String) As ObjectResult(Of String)
        Return DbContext.upGetAttributeDescription(atributoId, Value)
    End Function


    Public Function GetValuesByAtributo(atributoId As Integer) As ObjectResult(Of uspValueAttributes_Result)
        'Return DbContext.Attribute.Where(Function(p) p.IdAttribute = atributoId).FirstOrDefault()
        Return DbContext.uspValueAttributes(atributoId)
    End Function



    Public Function InsertAtributo(ByVal atributoItem As Attribute) As Boolean
        Dim status As Boolean

        Try
            DbContext.Attribute.Add(atributoItem)
            DbContext.SaveChanges()
            status = True
        Catch __unusedException1__ As Exception
            status = False
        End Try

        Return status
    End Function


    Public Function UpdateAtributo(ByVal atributoItem As Attribute) As Boolean
        Dim status As Boolean

        Try
            Dim attbtItem As Attribute = DbContext.Attribute.Where(Function(p) p.IdAttribute = atributoItem.IdAttribute).FirstOrDefault

            If attbtItem IsNot Nothing Then
                attbtItem.AttributeCode = atributoItem.AttributeCode
                attbtItem.AttributeDescription = atributoItem.AttributeDescription
                attbtItem.AttributeStatus = atributoItem.AttributeStatus
                'attbtItem.DateCreate = atributoItem.DateCreate
                attbtItem.DateUpdate = atributoItem.DateUpdate
                attbtItem.FieldType = atributoItem.FieldType
                attbtItem.FieldValue = atributoItem.FieldValue
                attbtItem.IdBusinessUnit = atributoItem.IdBusinessUnit
                attbtItem.SourceDatabase = atributoItem.SourceDatabase
                attbtItem.SourceField = atributoItem.SourceField
                attbtItem.SourceTable = atributoItem.SourceTable
                attbtItem.TargetDatabase = atributoItem.TargetDatabase
                attbtItem.TargetField = atributoItem.TargetField
                attbtItem.TargetTable = atributoItem.TargetTable
                'attbtItem.UserCreate = atributoItem.UserCreate
                attbtItem.UserUpdate = atributoItem.UserUpdate
                DbContext.SaveChanges()
            End If

            status = True
        Catch __unusedException1__ As Exception
            status = False
        End Try

        Return status
    End Function


    Public Function DeleteAtributo(ByVal id As Integer) As Boolean
        Dim status As Boolean

        Try
            Dim attItem As Attribute = DbContext.Attribute.Where(Function(p) p.IdAttribute = id).FirstOrDefault

            If attItem IsNot Nothing Then
                DbContext.Attribute.Remove(attItem)
                DbContext.SaveChanges()
            End If

            status = True
        Catch __unusedException1__ As Exception
            status = False
        End Try

        Return status
    End Function


End Class

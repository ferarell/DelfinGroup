    Public Class ConceptDAL
    Dim DbContext As TarifarioEntities = New TarifarioEntities()


    Public Function GetAllConceptos() As List(Of Concept)
        Return DbContext.Concept.ToList()
    End Function

    Public Function GetConcepto(ConceptoId As Integer) As Concept
        Return DbContext.Concept.Where(Function(p) p.IdConcept = ConceptoId).FirstOrDefault()
    End Function

    Public Function InsertConcepto(ByVal ConceptoItem As Concept) As Boolean
        Dim status As Boolean

        Try
            DbContext.Concept.Add(ConceptoItem)
            DbContext.SaveChanges()
            status = True
        Catch __unusedException1__ As Exception
            status = False
        End Try

        Return status
    End Function


    Public Function UpdateConcepto(ByVal ConceptoItem As Concept) As Boolean
        Dim status As Boolean

        Try
            Dim conceptItem As Concept = DbContext.Concept.Where(Function(p) p.IdConcept = ConceptoItem.IdConcept).FirstOrDefault

            If conceptItem IsNot Nothing Then
                conceptItem.IdConcept = ConceptoItem.IdConcept
                conceptItem.ConceptCode = ConceptoItem.ConceptCode
                conceptItem.ConceptDescription = ConceptoItem.ConceptDescription
                conceptItem.ConceptShortDescription = ConceptoItem.ConceptShortDescription
                conceptItem.ConceptSource = ConceptoItem.ConceptSource
                'conceptItem.ConceptType = ConceptoItem.ConceptType
                'conceptItem.IdUnit = ConceptoItem.IdUnit

                'conceptItem.IdBusinessUnit = ConceptoItem.IdBusinessUnit
                conceptItem.EquivalentCode = ConceptoItem.EquivalentCode




                conceptItem.ConceptStatus = ConceptoItem.ConceptStatus
                'attbtItem.DateCreate = ConceptoItem.DateCreate
                conceptItem.DateUpdate = ConceptoItem.DateUpdate

                'attbtItem.UserCreate = ConceptoItem.UserCreate
                conceptItem.UserUpdate = ConceptoItem.UserUpdate
                DbContext.SaveChanges()
            End If

            status = True
        Catch __unusedException1__ As Exception
            status = False
        End Try

        Return status
    End Function


    Public Function DeleteConcepto(ByVal id As Integer) As Boolean
        Dim status As Boolean

        Try
            Dim attItem As Concept = DbContext.Concept.Where(Function(p) p.IdConcept = id).FirstOrDefault

            If attItem IsNot Nothing Then
                DbContext.Concept.Remove(attItem)
                DbContext.SaveChanges()
            End If

            status = True
        Catch __unusedException1__ As Exception
            status = False
        End Try

        Return status
    End Function
End Class

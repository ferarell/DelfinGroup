Public Class ConstantesDAL

    Dim DbContext As NextSoftTarifarioEntities = New NextSoftTarifarioEntities()


    Public Function GetAllConstantes() As List(Of Constantes)
        Return DbContext.Constantes.ToList()
    End Function



    Public Function GetConstantesPorCriterio(cons_codtabla As String) As List(Of Constantes)

        Return DbContext.Constantes.Where(Function(p) p.CONS_CodTabla = cons_codtabla).ToList()


    End Function

End Class

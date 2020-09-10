Public Class TiposDAL


    Dim DbContext As NextSoftTarifarioEntities = New NextSoftTarifarioEntities()


    Public Function GetAllTipos() As List(Of Tipos)
        Return DbContext.Tipos.ToList()
    End Function



    Public Function GetTiposPorCriterio(Tipo_CodTabla As String) As List(Of Tipos)

        Return DbContext.Tipos.Where(Function(p) p.TIPO_CodTabla = Tipo_CodTabla).ToList()


    End Function

    'Public Function GetTipo(UnidadNegocioId As Integer) As BusinessUnit
    '    Return DbContext.BusinessUnit.Where(Function(p) p.IdBusinessUnit = UnidadNegocioId).FirstOrDefault()
    'End Function


End Class

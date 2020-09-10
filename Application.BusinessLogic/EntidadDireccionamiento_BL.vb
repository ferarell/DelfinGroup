Imports Application.BusinessEntities
Imports Application.DataAccess

Public Class EntidadDireccionamiento_BL
    Dim EntidadDireccionamiento_DA As New EntidadDireccionamiento_DA

    Public Function Insert(ByVal BE As EntidadDireccionamiento_BE) As EntidadDireccionamiento_BE
        Return EntidadDireccionamiento_DA.Insert(BE)
    End Function
    Public Function Update(ByVal BE As EntidadDireccionamiento_BE) As Boolean
        Return EntidadDireccionamiento_DA.Update(BE)
    End Function

    Public Function Delete(ByVal BE As EntidadDireccionamiento_BE) As Boolean
        Return EntidadDireccionamiento_DA.Delete(BE)
    End Function
    Public Function GetByFilter(ByVal BE As EntidadDireccionamiento_BE) As List(Of EntidadDireccionamiento_BE)
        Return EntidadDireccionamiento_DA.GetByFilter(BE)
    End Function

    Public Function GetAll(ByVal BE As EntidadDireccionamiento_BE) As EntidadDireccionamiento_BE
        Return EntidadDireccionamiento_DA.GetAll(BE)
    End Function

    Public Function GetAllDataTable(ByVal BE As EntidadDireccionamiento_BE) As DataTable
        Return EntidadDireccionamiento_DA.GetAllDataTable(BE)
    End Function

    Public Function ValidarDireccionamiento(ByVal BE As EntidadDireccionamiento_BE) As EntidadDireccionamiento_BE
        Return EntidadDireccionamiento_DA.ValidarDireccionamiento(BE)
    End Function


End Class

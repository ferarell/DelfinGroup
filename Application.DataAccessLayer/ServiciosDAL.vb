Public Class ServiciosDAL
    Dim DbContext As NextSoftTarifarioEntities = New NextSoftTarifarioEntities()


    Public Function GetAllServicios() As List(Of COM_Servicio)
        Return DbContext.COM_Servicio.ToList()
    End Function




End Class

Imports Application.BusinessEntities
Imports Application.DataAccess
Public Class COM_Det_Cotizacion_OV_EventosTareas_BL
    Dim oCOM_Det_Cotizacion_OV_EventosTareas_DA As New COM_Det_Cotizacion_OV_EventosTareas_DA

    Public Function Insert(ByVal BE As COM_Det_Cotizacion_OV_EventosTareas_BE) As COM_Det_Cotizacion_OV_EventosTareas_BE
        Return oCOM_Det_Cotizacion_OV_EventosTareas_DA.Insert(BE)
    End Function
    Public Function Update(ByVal BE As COM_Det_Cotizacion_OV_EventosTareas_BE) As Boolean
        Return oCOM_Det_Cotizacion_OV_EventosTareas_DA.Update(BE)
    End Function

    Public Function Delete(ByVal BE As COM_Det_Cotizacion_OV_EventosTareas_BE) As Boolean
        Return oCOM_Det_Cotizacion_OV_EventosTareas_DA.Delete(BE)
    End Function
End Class

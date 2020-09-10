Imports System.Runtime.Serialization
Public Class COM_Det_Cotizacion_OV_EventosTareas_BE
    Private _CCOT_Numero As Int32
    Private _CCOT_Tipo As Int16
    Private _EVEN_Item As Int16
    Private _EVEN_Fecha As DateTime
    Private _EVEN_Cumplida As Boolean
    Private _EVEN_Usuario As String
    Private _EVEN_Observaciones As String
    Private _TIPO_TabEVE As String
    Private _TIPO_CodEVE As String
    Private _CONS_TabMOD As String
    Private _CONS_CodMOD As String
    Private _AUDI_UsrCrea As String
    Private _AUDI_FecCrea As DateTime
    Private _AUDI_UsrMod As String
    Private _AUDI_FecMod As DateTime
    Private _EVEN_Manual As Boolean

    Public Sub New()
    End Sub
    <DataMember()>
    Public Property CCOT_Numero As Integer
        Get
            Return _CCOT_Numero
        End Get
        Set(value As Integer)
            _CCOT_Numero = value
        End Set
    End Property
    <DataMember()>
    Public Property CCOT_Tipo As Short
        Get
            Return _CCOT_Tipo
        End Get
        Set(value As Short)
            _CCOT_Tipo = value
        End Set
    End Property
    <DataMember()>
    Public Property EVEN_Item As Short
        Get
            Return _EVEN_Item
        End Get
        Set(value As Short)
            _EVEN_Item = value
        End Set
    End Property
    <DataMember()>
    Public Property EVEN_Fecha As Date
        Get
            Return _EVEN_Fecha
        End Get
        Set(value As Date)
            _EVEN_Fecha = value
        End Set
    End Property
    <DataMember()>
    Public Property EVEN_Cumplida As Boolean
        Get
            Return _EVEN_Cumplida
        End Get
        Set(value As Boolean)
            _EVEN_Cumplida = value
        End Set
    End Property
    <DataMember()>
    Public Property EVEN_Usuario As String
        Get
            Return _EVEN_Usuario
        End Get
        Set(value As String)
            _EVEN_Usuario = value
        End Set
    End Property
    <DataMember()>
    Public Property EVEN_Observaciones As String
        Get
            Return _EVEN_Observaciones
        End Get
        Set(value As String)
            _EVEN_Observaciones = value
        End Set
    End Property
    <DataMember()>
    Public Property TIPO_TabEVE As String
        Get
            Return _TIPO_TabEVE
        End Get
        Set(value As String)
            _TIPO_TabEVE = value
        End Set
    End Property
    <DataMember()>
    Public Property TIPO_CodEVE As String
        Get
            Return _TIPO_CodEVE
        End Get
        Set(value As String)
            _TIPO_CodEVE = value
        End Set
    End Property
    <DataMember()>
    Public Property CONS_TabMOD As String
        Get
            Return _CONS_TabMOD
        End Get
        Set(value As String)
            _CONS_TabMOD = value
        End Set
    End Property
    <DataMember()>
    Public Property CONS_CodMOD As String
        Get
            Return _CONS_CodMOD
        End Get
        Set(value As String)
            _CONS_CodMOD = value
        End Set
    End Property
    <DataMember()>
    Public Property AUDI_UsrCrea As String
        Get
            Return _AUDI_UsrCrea
        End Get
        Set(value As String)
            _AUDI_UsrCrea = value
        End Set
    End Property
    <DataMember()>
    Public Property AUDI_FecCrea As Date
        Get
            Return _AUDI_FecCrea
        End Get
        Set(value As Date)
            _AUDI_FecCrea = value
        End Set
    End Property
    <DataMember()>
    Public Property AUDI_UsrMod As String
        Get
            Return _AUDI_UsrMod
        End Get
        Set(value As String)
            _AUDI_UsrMod = value
        End Set
    End Property
    <DataMember()>
    Public Property AUDI_FecMod As Date
        Get
            Return _AUDI_FecMod
        End Get
        Set(value As Date)
            _AUDI_FecMod = value
        End Set
    End Property
    <DataMember()>
    Public Property EVEN_Manual As Boolean
        Get
            Return _EVEN_Manual
        End Get
        Set(value As Boolean)
            _EVEN_Manual = value
        End Set
    End Property
End Class

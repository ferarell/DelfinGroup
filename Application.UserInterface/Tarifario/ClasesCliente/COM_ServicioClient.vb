
Imports System
Imports System.Collections.Generic
Imports ApplicationForm

Public Class COM_ServicioClient
    Dim _SERV_Codigo As Integer
    Dim _SERV_Nombre_SPA As String
    Dim _SERV_Nombre_ENG As String
    Dim _SERV_AfeIgv As Nullable(Of Boolean)
    Dim _SERV_Flete As Nullable(Of Boolean)
    Dim _SERV_AfeDet As Nullable(Of Boolean)
    Dim _CONS_TabVia As String
    Dim _CONS_CodVia As String
    Dim _SERV_Activo As Boolean
    Dim _SERV_CueVta As String
    Dim _SERV_CueGas As String
    Dim _SERV_Agrup1 As String
    Dim _SERV_Agrup2 As String
    Dim _SERV_PorDet As Decimal
    Dim _SERV_Tipo As String
    Dim _SERV_Valor As Decimal
    Dim _SERV_CobMin As Decimal
    Dim _SERV_Autom As Nullable(Of Boolean)
    Dim _SERV_FrecFac As String
    Dim _TIPO_TabUNT As String
    Dim _TIPO_CodUNT As String
    Dim _AUDI_UsrCrea As String
    Dim _AUDI_FecCrea As Date
    Dim _AUDI_UsrMod As String
    Dim _AUDI_FecMod As String
    Dim _CONS_TabRGM As String
    Dim _CONS_CodRGM As String
    Dim _SERV_CuenIngreso As String
    Dim _SERV_CuenCosto As String
    Dim _SERV_CuenPuente As String
    Dim _TIPO_TabDET As String
    Dim _TIPO_CodDET As String
    Dim _SERV_NombreCorto As String
    Dim _SERV_Glosa As String
    Dim _SERV_Observaciones As String
    Dim _SERV_TipoMov As String
    Dim _CONS_TabBAS As String
    Dim _CONS_CodBAS As String
    Dim _TIPO_TabMND As String
    Dim _TIPO_CodMND As String
    Dim _CONS_TabLNG As String
    Dim _CONS_CodLNG As String
    Dim _SERV_DefinidoPor As String
    Dim _SERV_ExcesoFlete As Boolean
    Dim _CENT_Ano As String
    Dim _CENT_Codigo As String
    Dim _TIPO_TabOPE As String
    Dim _TIPO_CodOPE As String
    Dim _TIPO_TabOPE_Costo As String
    Dim _TIPO_CodOPE_Costo As String

    Dim _Tipos As TiposCliente
    Dim _Tipos1 As TiposCliente

    Public Property SERV_Codigo As Integer
        Get
            Return _SERV_Codigo
        End Get
        Set(value As Integer)
            _SERV_Codigo = value
        End Set
    End Property

    Public Property SERV_Nombre_SPA As String
        Get
            Return _SERV_Nombre_SPA
        End Get
        Set(value As String)
            _SERV_Nombre_SPA = value
        End Set
    End Property

    Public Property SERV_Nombre_ENG As String
        Get
            Return _SERV_Nombre_ENG
        End Get
        Set(value As String)
            _SERV_Nombre_ENG = value
        End Set
    End Property

    Public Property SERV_AfeIgv As Boolean?
        Get
            Return _SERV_AfeIgv
        End Get
        Set(value As Boolean?)
            _SERV_AfeIgv = value
        End Set
    End Property

    Public Property SERV_Flete As Boolean?
        Get
            Return _SERV_Flete
        End Get
        Set(value As Boolean?)
            _SERV_Flete = value
        End Set
    End Property

    Public Property SERV_AfeDet As Boolean?
        Get
            Return _SERV_AfeDet
        End Get
        Set(value As Boolean?)
            _SERV_AfeDet = value
        End Set
    End Property

    Public Property CONS_TabVia As String
        Get
            Return _CONS_TabVia
        End Get
        Set(value As String)
            _CONS_TabVia = value
        End Set
    End Property

    Public Property CONS_CodVia As String
        Get
            Return _CONS_CodVia
        End Get
        Set(value As String)
            _CONS_CodVia = value
        End Set
    End Property

    Public Property SERV_Activo As Boolean
        Get
            Return _SERV_Activo
        End Get
        Set(value As Boolean)
            _SERV_Activo = value
        End Set
    End Property

    Public Property SERV_CueVta As String
        Get
            Return _SERV_CueVta
        End Get
        Set(value As String)
            _SERV_CueVta = value
        End Set
    End Property

    Public Property SERV_CueGas As String
        Get
            Return _SERV_CueGas
        End Get
        Set(value As String)
            _SERV_CueGas = value
        End Set
    End Property

    Public Property SERV_Agrup1 As String
        Get
            Return _SERV_Agrup1
        End Get
        Set(value As String)
            _SERV_Agrup1 = value
        End Set
    End Property

    Public Property SERV_Agrup2 As String
        Get
            Return _SERV_Agrup2
        End Get
        Set(value As String)
            _SERV_Agrup2 = value
        End Set
    End Property

    Public Property SERV_PorDet As Decimal
        Get
            Return _SERV_PorDet
        End Get
        Set(value As Decimal)
            _SERV_PorDet = value
        End Set
    End Property

    Public Property SERV_Tipo As String
        Get
            Return _SERV_Tipo
        End Get
        Set(value As String)
            _SERV_Tipo = value
        End Set
    End Property

    Public Property SERV_Valor As Decimal
        Get
            Return _SERV_Valor
        End Get
        Set(value As Decimal)
            _SERV_Valor = value
        End Set
    End Property

    Public Property SERV_CobMin As Decimal
        Get
            Return _SERV_CobMin
        End Get
        Set(value As Decimal)
            _SERV_CobMin = value
        End Set
    End Property

    Public Property SERV_Autom As Boolean?
        Get
            Return _SERV_Autom
        End Get
        Set(value As Boolean?)
            _SERV_Autom = value
        End Set
    End Property

    Public Property SERV_FrecFac As String
        Get
            Return _SERV_FrecFac
        End Get
        Set(value As String)
            _SERV_FrecFac = value
        End Set
    End Property

    Public Property TIPO_TabUNT As String
        Get
            Return _TIPO_TabUNT
        End Get
        Set(value As String)
            _TIPO_TabUNT = value
        End Set
    End Property

    Public Property TIPO_CodUNT As String
        Get
            Return _TIPO_CodUNT
        End Get
        Set(value As String)
            _TIPO_CodUNT = value
        End Set
    End Property

    Public Property AUDI_UsrCrea As String
        Get
            Return _AUDI_UsrCrea
        End Get
        Set(value As String)
            _AUDI_UsrCrea = value
        End Set
    End Property

    Public Property AUDI_FecCrea As Date
        Get
            Return _AUDI_FecCrea
        End Get
        Set(value As Date)
            _AUDI_FecCrea = value
        End Set
    End Property

    Public Property AUDI_UsrMod As String
        Get
            Return _AUDI_UsrMod
        End Get
        Set(value As String)
            _AUDI_UsrMod = value
        End Set
    End Property

    Public Property AUDI_FecMod As String
        Get
            Return _AUDI_FecMod
        End Get
        Set(value As String)
            _AUDI_FecMod = value
        End Set
    End Property

    Public Property CONS_TabRGM As String
        Get
            Return _CONS_TabRGM
        End Get
        Set(value As String)
            _CONS_TabRGM = value
        End Set
    End Property

    Public Property CONS_CodRGM As String
        Get
            Return _CONS_CodRGM
        End Get
        Set(value As String)
            _CONS_CodRGM = value
        End Set
    End Property

    Public Property SERV_CuenIngreso As String
        Get
            Return _SERV_CuenIngreso
        End Get
        Set(value As String)
            _SERV_CuenIngreso = value
        End Set
    End Property

    Public Property SERV_CuenCosto As String
        Get
            Return _SERV_CuenCosto
        End Get
        Set(value As String)
            _SERV_CuenCosto = value
        End Set
    End Property

    Public Property SERV_CuenPuente As String
        Get
            Return _SERV_CuenPuente
        End Get
        Set(value As String)
            _SERV_CuenPuente = value
        End Set
    End Property

    Public Property TIPO_TabDET As String
        Get
            Return _TIPO_TabDET
        End Get
        Set(value As String)
            _TIPO_TabDET = value
        End Set
    End Property

    Public Property TIPO_CodDET As String
        Get
            Return _TIPO_CodDET
        End Get
        Set(value As String)
            _TIPO_CodDET = value
        End Set
    End Property

    Public Property SERV_NombreCorto As String
        Get
            Return _SERV_NombreCorto
        End Get
        Set(value As String)
            _SERV_NombreCorto = value
        End Set
    End Property

    Public Property SERV_Glosa As String
        Get
            Return _SERV_Glosa
        End Get
        Set(value As String)
            _SERV_Glosa = value
        End Set
    End Property

    Public Property SERV_Observaciones As String
        Get
            Return _SERV_Observaciones
        End Get
        Set(value As String)
            _SERV_Observaciones = value
        End Set
    End Property

    Public Property SERV_TipoMov As String
        Get
            Return _SERV_TipoMov
        End Get
        Set(value As String)
            _SERV_TipoMov = value
        End Set
    End Property

    Public Property CONS_TabBAS As String
        Get
            Return _CONS_TabBAS
        End Get
        Set(value As String)
            _CONS_TabBAS = value
        End Set
    End Property

    Public Property CONS_CodBAS As String
        Get
            Return _CONS_CodBAS
        End Get
        Set(value As String)
            _CONS_CodBAS = value
        End Set
    End Property

    Public Property TIPO_TabMND As String
        Get
            Return _TIPO_TabMND
        End Get
        Set(value As String)
            _TIPO_TabMND = value
        End Set
    End Property

    Public Property TIPO_CodMND As String
        Get
            Return _TIPO_CodMND
        End Get
        Set(value As String)
            _TIPO_CodMND = value
        End Set
    End Property

    Public Property CONS_TabLNG As String
        Get
            Return _CONS_TabLNG
        End Get
        Set(value As String)
            _CONS_TabLNG = value
        End Set
    End Property

    Public Property CONS_CodLNG As String
        Get
            Return _CONS_CodLNG
        End Get
        Set(value As String)
            _CONS_CodLNG = value
        End Set
    End Property

    Public Property SERV_DefinidoPor As String
        Get
            Return _SERV_DefinidoPor
        End Get
        Set(value As String)
            _SERV_DefinidoPor = value
        End Set
    End Property

    Public Property SERV_ExcesoFlete As Boolean
        Get
            Return _SERV_ExcesoFlete
        End Get
        Set(value As Boolean)
            _SERV_ExcesoFlete = value
        End Set
    End Property

    Public Property CENT_Ano As String
        Get
            Return _CENT_Ano
        End Get
        Set(value As String)
            _CENT_Ano = value
        End Set
    End Property

    Public Property CENT_Codigo As String
        Get
            Return _CENT_Codigo
        End Get
        Set(value As String)
            _CENT_Codigo = value
        End Set
    End Property

    Public Property TIPO_TabOPE As String
        Get
            Return _TIPO_TabOPE
        End Get
        Set(value As String)
            _TIPO_TabOPE = value
        End Set
    End Property

    Public Property TIPO_CodOPE As String
        Get
            Return _TIPO_CodOPE
        End Get
        Set(value As String)
            _TIPO_CodOPE = value
        End Set
    End Property

    Public Property TIPO_TabOPE_Costo As String
        Get
            Return _TIPO_TabOPE_Costo
        End Get
        Set(value As String)
            _TIPO_TabOPE_Costo = value
        End Set
    End Property

    Public Property TIPO_CodOPE_Costo As String
        Get
            Return _TIPO_CodOPE_Costo
        End Get
        Set(value As String)
            _TIPO_CodOPE_Costo = value
        End Set
    End Property

    Public Property Tipos As TiposCliente
        Get
            Return _Tipos
        End Get
        Set(value As TiposCliente)
            _Tipos = value
        End Set
    End Property

    Public Property Tipos1 As TiposCliente
        Get
            Return _Tipos1
        End Get
        Set(value As TiposCliente)
            _Tipos1 = value
        End Set
    End Property
End Class
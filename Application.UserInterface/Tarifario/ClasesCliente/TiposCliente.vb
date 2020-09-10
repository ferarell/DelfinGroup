Public Class TiposCliente
    Dim _TIPO_CodTabla As String
    Dim _TIPO_CodTipo As String
    Dim _TIPO_Desc1 As String
    Dim _TIPO_Desc2 As String
    Dim _TIPO_DescC As String
    Dim _TIPO_Num1 As Nullable(Of Decimal)
    Dim _TIPO_Num2 As Nullable(Of Decimal)
    Dim _TIPO_Num3 As Nullable(Of Short)
    Dim _TIPO_Num4 As Nullable(Of Short)
    Dim _TIPO_Activo As Nullable(Of Boolean)
    Dim _TIPO_Mascara As String
    Dim _AUDI_UsrCrea As String
    Dim _AUDI_FecCrea As Date
    Dim _AUDI_UsrMod As String
    Dim _AUDI_FecMod As Nullable(Of Date)
    Dim _TIPO_CodTablaHijo As String
    Dim _TIPO_CodTipoHijo As String
    Dim _TIPO_Desc3 As String

    Dim _Tipos1 As ICollection(Of TiposCliente) = New HashSet(Of TiposCliente)
    Dim _Tipos2 As TiposCliente

    Public Property TIPO_CodTabla As String
        Get
            Return _TIPO_CodTabla
        End Get
        Set(value As String)
            _TIPO_CodTabla = value
        End Set
    End Property

    Public Property TIPO_CodTipo As String
        Get
            Return _TIPO_CodTipo.Trim()
        End Get
        Set(value As String)
            _TIPO_CodTipo = value
        End Set
    End Property

    Public Property TIPO_Desc1 As String
        Get
            Return _TIPO_Desc1
        End Get
        Set(value As String)
            _TIPO_Desc1 = value
        End Set
    End Property

    Public Property TIPO_Desc2 As String
        Get
            Return _TIPO_Desc2
        End Get
        Set(value As String)
            _TIPO_Desc2 = value
        End Set
    End Property

    Public Property TIPO_DescC As String
        Get
            Return _TIPO_DescC
        End Get
        Set(value As String)
            _TIPO_DescC = value
        End Set
    End Property

    Public Property TIPO_Num1 As Decimal?
        Get
            Return _TIPO_Num1
        End Get
        Set(value As Decimal?)
            _TIPO_Num1 = value
        End Set
    End Property

    Public Property TIPO_Num2 As Decimal?
        Get
            Return _TIPO_Num2
        End Get
        Set(value As Decimal?)
            _TIPO_Num2 = value
        End Set
    End Property

    Public Property TIPO_Num3 As Short?
        Get
            Return _TIPO_Num3
        End Get
        Set(value As Short?)
            _TIPO_Num3 = value
        End Set
    End Property

    Public Property TIPO_Num4 As Short?
        Get
            Return _TIPO_Num4
        End Get
        Set(value As Short?)
            _TIPO_Num4 = value
        End Set
    End Property

    Public Property TIPO_Activo As Boolean?
        Get
            Return _TIPO_Activo
        End Get
        Set(value As Boolean?)
            _TIPO_Activo = value
        End Set
    End Property

    Public Property TIPO_Mascara As String
        Get
            Return _TIPO_Mascara
        End Get
        Set(value As String)
            _TIPO_Mascara = value
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

    Public Property AUDI_FecMod As Date?
        Get
            Return _AUDI_FecMod
        End Get
        Set(value As Date?)
            _AUDI_FecMod = value
        End Set
    End Property

    Public Property TIPO_CodTablaHijo As String
        Get
            Return _TIPO_CodTablaHijo
        End Get
        Set(value As String)
            _TIPO_CodTablaHijo = value
        End Set
    End Property

    Public Property TIPO_CodTipoHijo As String
        Get
            Return _TIPO_CodTipoHijo
        End Get
        Set(value As String)
            _TIPO_CodTipoHijo = value
        End Set
    End Property

    Public Property TIPO_Desc3 As String
        Get
            Return _TIPO_Desc3
        End Get
        Set(value As String)
            _TIPO_Desc3 = value
        End Set
    End Property

    Public Property Tipos1 As ICollection(Of TiposCliente)
        Get
            Return _Tipos1
        End Get
        Set(value As ICollection(Of TiposCliente))
            _Tipos1 = value
        End Set
    End Property

    Public Property Tipos2 As TiposCliente
        Get
            Return _Tipos2
        End Get
        Set(value As TiposCliente)
            _Tipos2 = value
        End Set
    End Property
End Class

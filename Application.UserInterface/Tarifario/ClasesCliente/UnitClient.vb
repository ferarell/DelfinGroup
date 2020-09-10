Public Class UnitClient
    Dim _IdUnit As Short
    Dim _UnitCode As String
    Dim _UnitDescription As String
    Dim _UnitStatus As String
    Dim _UserCreate As String
    Dim _DateCreate As Nullable(Of Date)
    Dim _UserUpdate As String
    Dim _DateUpdate As Nullable(Of Date)

    Dim _EquivalentCode As String


    Public Property IdUnit As Short
        Get
            Return _IdUnit
        End Get
        Set(value As Short)
            _IdUnit = value
        End Set
    End Property

    Public Property UnitCode As String
        Get
            Return _UnitCode
        End Get
        Set(value As String)
            _UnitCode = value
        End Set
    End Property

    Public Property UnitDescription As String
        Get
            Return _UnitDescription
        End Get
        Set(value As String)
            _UnitDescription = value
        End Set
    End Property

    Public Property UnitStatus As String
        Get
            Return _UnitStatus
        End Get
        Set(value As String)
            _UnitStatus = value
        End Set
    End Property

    Public Property UserCreate As String
        Get
            Return _UserCreate
        End Get
        Set(value As String)
            _UserCreate = value
        End Set
    End Property

    Public Property DateCreate As Date?
        Get
            Return _DateCreate
        End Get
        Set(value As Date?)
            _DateCreate = value
        End Set
    End Property

    Public Property UserUpdate As String
        Get
            Return _UserUpdate
        End Get
        Set(value As String)
            _UserUpdate = value
        End Set
    End Property

    Public Property DateUpdate As Date?
        Get
            Return _DateUpdate
        End Get
        Set(value As Date?)
            _DateUpdate = value
        End Set
    End Property

    Public Property EquivalentCode As String
        Get
            Return _EquivalentCode
        End Get
        Set(value As String)
            _EquivalentCode = value
        End Set
    End Property
End Class

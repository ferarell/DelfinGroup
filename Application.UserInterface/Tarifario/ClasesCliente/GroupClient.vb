Public Class GroupClient
    Dim _IdGroup As Integer
    Dim _GroupCode As String
    Dim _GroupDescription As String
    Dim _GrouopStatus As String
    Dim _UserCreate As String
    Dim _DateCreate As Nullable(Of Date)
    Dim _UserUpdate As String
    Dim _DateUpdate As Nullable(Of Date)

    Public Property IdGroup As Integer
        Get
            Return _IdGroup
        End Get
        Set(value As Integer)
            _IdGroup = value
        End Set
    End Property

    Public Property GroupCode As String
        Get
            Return _GroupCode.Trim()
        End Get
        Set(value As String)
            _GroupCode = value
        End Set
    End Property

    Public Property GroupDescription As String
        Get
            Return _GroupDescription
        End Get
        Set(value As String)
            _GroupDescription = value
        End Set
    End Property

    Public Property GrouopStatus As String
        Get
            Return _GrouopStatus
        End Get
        Set(value As String)
            _GrouopStatus = value
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
End Class

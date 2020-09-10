Public Class BusinessUnitClient
    Dim _IdBusinessUnit As Integer
    Dim _BusinessUnitCode As String
    Dim _BusinessUnitDescription As String
    Dim _IdCompany As Integer
    Dim _UserCreate As String
    Dim _DateCreate As Nullable(Of Date)
    Dim _UserUpdate As String
    Dim _DateUpdate As Nullable(Of Date)
    Dim _BusinessUnitStatus As String
    Public Property IdBusinessUnit As Integer
        Get
            Return _IdBusinessUnit
        End Get
        Set(value As Integer)
            _IdBusinessUnit = value
        End Set
    End Property

    Public Property BusinessUnitCode As String
        Get
            Return _BusinessUnitCode.Trim()
        End Get
        Set(value As String)
            _BusinessUnitCode = value
        End Set
    End Property

    Public Property BusinessUnitDescription As String
        Get
            Return _BusinessUnitDescription
        End Get
        Set(value As String)
            _BusinessUnitDescription = value
        End Set
    End Property

    Public Property IdCompany As Integer
        Get
            Return _IdCompany
        End Get
        Set(value As Integer)
            _IdCompany = value
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

    Public Property BusinessUnitStatus As String
        Get
            Return _BusinessUnitStatus
        End Get
        Set(value As String)
            _BusinessUnitStatus = value
        End Set
    End Property
End Class

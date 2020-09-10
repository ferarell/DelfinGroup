Public Class AttributeClient
    Dim _IdAttribute As Integer
    Dim _AttributeCode As String
    Dim _AttributeDescription As String
    Dim _IdBusinessUnit As Integer
    Dim _SourceDatabase As String
    Dim _SourceTable As String
    Dim _SourceField As String
    Dim _FieldType As String
    Dim _FieldValue As String
    Dim _TargetDatabase As String
    Dim _TargetTable As String
    Dim _TargetField As String
    Dim _AttributeStatus As String
    Dim _UserCreate As String
    Dim _DateCreate As Nullable(Of Date)
    Dim _UserUpdate As String
    Dim _DateUpdate As Nullable(Of Date)

    Public Property IdAttribute As Integer
        Get
            Return _IdAttribute
        End Get
        Set(value As Integer)
            _IdAttribute = value
        End Set
    End Property

    Public Property AttributeCode As String
        Get
            Return _AttributeCode
        End Get
        Set(value As String)
            _AttributeCode = value
        End Set
    End Property

    Public Property AttributeDescription As String
        Get
            Return _AttributeDescription
        End Get
        Set(value As String)
            _AttributeDescription = value
        End Set
    End Property

    Public Property IdBusinessUnit As Integer
        Get
            Return _IdBusinessUnit
        End Get
        Set(value As Integer)
            _IdBusinessUnit = value
        End Set
    End Property

    Public Property SourceDatabase As String
        Get
            Return _SourceDatabase
        End Get
        Set(value As String)
            _SourceDatabase = value
        End Set
    End Property

    Public Property SourceTable As String
        Get
            Return _SourceTable
        End Get
        Set(value As String)
            _SourceTable = value
        End Set
    End Property

    Public Property SourceField As String
        Get
            Return _SourceField
        End Get
        Set(value As String)
            _SourceField = value
        End Set
    End Property

    Public Property FieldType As String
        Get
            Return _FieldType
        End Get
        Set(value As String)
            _FieldType = value
        End Set
    End Property

    Public Property FieldValue As String
        Get
            Return _FieldValue
        End Get
        Set(value As String)
            _FieldValue = value
        End Set
    End Property

    Public Property TargetDatabase As String
        Get
            Return _TargetDatabase
        End Get
        Set(value As String)
            _TargetDatabase = value
        End Set
    End Property

    Public Property TargetTable As String
        Get
            Return _TargetTable
        End Get
        Set(value As String)
            _TargetTable = value
        End Set
    End Property

    Public Property TargetField As String
        Get
            Return _TargetField
        End Get
        Set(value As String)
            _TargetField = value
        End Set
    End Property

    Public Property AttributeStatus As String
        Get
            Return _AttributeStatus
        End Get
        Set(value As String)
            _AttributeStatus = value
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

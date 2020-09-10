Imports ApplicationForm
Public Class LayoutAttributeClient
    Dim _IdLayoutAttribute As Integer
    Dim _IdLayout As Integer
    Dim _IdAttribute As Integer
    Dim _Value As String
    Dim _UserCreate As String
    Dim _DateCreate As Nullable(Of Date)
    Dim _UserUpdate As String
    Dim _DateUpdate As Nullable(Of Date)
    Dim _AttributeDescription As String
    Dim _Attribute As AttributeClient

    Public Property IdLayoutAttribute As Integer
        Get
            Return _IdLayoutAttribute
        End Get
        Set(value As Integer)
            _IdLayoutAttribute = value
        End Set
    End Property

    Public Property IdLayout As Integer
        Get
            Return _IdLayout
        End Get
        Set(value As Integer)
            _IdLayout = value
        End Set
    End Property

    Public Property IdAttribute As Integer
        Get
            Return _IdAttribute
        End Get
        Set(value As Integer)
            _IdAttribute = value
        End Set
    End Property

    Public Property Value As String
        Get
            Return _Value
        End Get
        Set(value As String)
            _Value = value
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

    Public Property Attribute As AttributeClient

        Get
            Return _Attribute
        End Get
        Set(value As AttributeClient)
            _Attribute = value
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
End Class

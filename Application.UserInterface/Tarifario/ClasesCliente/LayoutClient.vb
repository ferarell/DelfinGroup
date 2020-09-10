Imports ApplicationForm

Public Class LayoutClient

    Dim _IdLayout As Integer
    Dim _LayoutCode As String
    Dim _LayoutDescription As String
    Dim _IdConcept As Nullable(Of Integer)
    Dim _IdPack As Nullable(Of Integer)
    Dim _IdCondition As Nullable(Of Short)
    Dim _Currency As String
    Dim _SalesAmount As Nullable(Of Decimal)
    Dim _CostsAmount As Nullable(Of Decimal)
    Dim _LayoutStatus As String
    Dim _UserCreate As String
    Dim _DateCreate As Nullable(Of Date)
    Dim _UserUpdate As String
    Dim _DateUpdate As Nullable(Of Date)
    Dim _IdBusinessUnit As Nullable(Of Integer)
    Dim _LayoutAttribute As ICollection(Of LayoutAttributeClient) = New HashSet(Of LayoutAttributeClient)

    Public Property IdLayout As Integer
        Get
            Return _IdLayout
        End Get
        Set(value As Integer)
            _IdLayout = value
        End Set
    End Property

    Public Property LayoutCode As String
        Get
            Return _LayoutCode
        End Get
        Set(value As String)
            _LayoutCode = value
        End Set
    End Property

    Public Property LayoutDescription As String
        Get
            Return _LayoutDescription
        End Get
        Set(value As String)
            _LayoutDescription = value
        End Set
    End Property

    Public Property IdConcept As Integer?
        Get
            Return _IdConcept
        End Get
        Set(value As Integer?)
            _IdConcept = value
        End Set
    End Property

    Public Property IdPack As Integer?
        Get
            Return _IdPack
        End Get
        Set(value As Integer?)
            _IdPack = value
        End Set
    End Property

    Public Property IdCondition As Short?
        Get
            Return _IdCondition
        End Get
        Set(value As Short?)
            _IdCondition = value
        End Set
    End Property

    Public Property Currency As String
        Get
            Return _Currency
        End Get
        Set(value As String)
            _Currency = value
        End Set
    End Property

    Public Property SalesAmount As Decimal?
        Get
            Return _SalesAmount
        End Get
        Set(value As Decimal?)
            _SalesAmount = value
        End Set
    End Property

    Public Property CostsAmount As Decimal?
        Get
            Return _CostsAmount
        End Get
        Set(value As Decimal?)
            _CostsAmount = value
        End Set
    End Property

    Public Property LayoutStatus As String
        Get
            Return _LayoutStatus
        End Get
        Set(value As String)
            _LayoutStatus = value
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

    Public Property LayoutAttribute As ICollection(Of LayoutAttributeClient)
        Get
            Return _LayoutAttribute
        End Get
        Set(value As ICollection(Of LayoutAttributeClient))
            _LayoutAttribute = value
        End Set
    End Property

    Public Property IdBusinessUnit As Integer?
        Get
            Return _IdBusinessUnit
        End Get
        Set(value As Integer?)
            _IdBusinessUnit = value
        End Set
    End Property
End Class

Public Class ConceptClient
    Dim _IdConcept As Integer
    Dim _ConceptCode As String
    Dim _ConceptDescription As String
    Dim _ConceptShortDescription As String
    Dim _ConceptSource As String
    Dim _Currency As String
    Dim _SalesAmount As Nullable(Of Decimal)
    Dim _CostsAmount As Nullable(Of Decimal)
    Dim _ConceptStatus As String
    Dim _UserCreate As String
    Dim _DateCreate As Nullable(Of Date)
    Dim _UserUpdate As String
    Dim _DateUpdate As Nullable(Of Date)

    Dim _EquivalentCode As Nullable(Of Integer)


    Public Property IdConcept As Integer
        Get
            Return _IdConcept
        End Get
        Set(value As Integer)
            _IdConcept = value
        End Set
    End Property

    Public Property ConceptCode As String
        Get
            Return _ConceptCode
        End Get
        Set(value As String)
            _ConceptCode = value
        End Set
    End Property

    Public Property ConceptDescription As String
        Get
            Return _ConceptDescription
        End Get
        Set(value As String)
            _ConceptDescription = value
        End Set
    End Property

    Public Property ConceptShortDescription As String
        Get
            Return _ConceptShortDescription
        End Get
        Set(value As String)
            _ConceptShortDescription = value
        End Set
    End Property

    Public Property ConceptSource As String
        Get
            Return _ConceptSource
        End Get
        Set(value As String)
            _ConceptSource = value
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

    Public Property ConceptStatus As String
        Get
            Return _ConceptStatus
        End Get
        Set(value As String)
            _ConceptStatus = value
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



    Public Property EquivalentCode As Integer?
        Get
            Return _EquivalentCode
        End Get
        Set(value As Integer?)
            _EquivalentCode = value
        End Set
    End Property
End Class

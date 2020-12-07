Imports ApplicationForm

Public Class PackClient

    Dim _IdPack As Integer
    Dim _PackCode As String
    Dim _PackDescription As String
    Dim _Currency As String
    Dim _SalesAmount As Nullable(Of Decimal)
    Dim _CostsAmount As Nullable(Of Decimal)
    Dim _PackStatus As String
    Dim _DistributionType As String
    Dim _UserCreate As String
    Dim _DateCreate As Nullable(Of Date)
    Dim _UserUpdate As String
    Dim _DateUpdate As Nullable(Of Date)
    'Dim _IdBusinessUnit As Nullable(Of Integer)
    Dim _PackDetail As ICollection(Of PackDetailClient) = New HashSet(Of PackDetailClient)

    Public Property IdPack As Integer
        Get
            Return _IdPack
        End Get
        Set(value As Integer)
            _IdPack = value
        End Set
    End Property

    Public Property PackCode As String
        Get
            Return _PackCode
        End Get
        Set(value As String)
            _PackCode = value
        End Set
    End Property

    Public Property PackDescription As String
        Get
            Return _PackDescription
        End Get
        Set(value As String)
            _PackDescription = value
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

    Public Property PackStatus As String
        Get
            Return _PackStatus
        End Get
        Set(value As String)
            _PackStatus = value
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

    Public Property PackDetail As ICollection(Of PackDetailClient)
        Get
            Return _PackDetail
        End Get
        Set(value As ICollection(Of PackDetailClient))
            _PackDetail = value
        End Set
    End Property

    'Public Property IdBusinessUnit As Integer?
    '    Get
    '        Return _IdBusinessUnit
    '    End Get
    '    Set(value As Integer?)
    '        _IdBusinessUnit = value
    '    End Set
    'End Property

    Public Property DistributionType As String
        Get
            Return _DistributionType
        End Get
        Set(value As String)
            _DistributionType = value
        End Set
    End Property
End Class

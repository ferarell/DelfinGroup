Imports ApplicationForm
Public Class TariffDetailClient

    Dim _IdTariffDetail As Integer
    Dim _IdTariff As Integer
    Dim _IdUnit As Short
    Dim _IdConcept As Integer
    Dim _SalesAmount As Nullable(Of Decimal)
    Dim _CostsAmount As Nullable(Of Decimal)
    Dim _ContributionMargin As Nullable(Of Decimal)
    Dim _UserCreate As String
    Dim _DateCreate As Nullable(Of Date)
    Dim _UserUpdate As String
    Dim _DateUpdate As Nullable(Of Date)
    Dim _Currency As String
    Dim _Unit As UnitClient

    Public Property IdTariffDetail As Integer
        Get
            Return _IdTariffDetail
        End Get
        Set(value As Integer)
            _IdTariffDetail = value
        End Set
    End Property

    Public Property IdTariff As Integer
        Get
            Return _IdTariff
        End Get
        Set(value As Integer)
            _IdTariff = value
        End Set
    End Property

    Public Property IdUnit As Short
        Get
            Return _IdUnit
        End Get
        Set(value As Short)
            _IdUnit = value
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

    Public Property Unit As UnitClient
        Get
            Return _Unit
        End Get
        Set(value As UnitClient)
            _Unit = value
        End Set
    End Property

    Public Property IdConcept As Integer
        Get
            Return _IdConcept
        End Get
        Set(value As Integer)
            _IdConcept = value
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

    Public Property ContributionMargin As Decimal?
        Get
            Return _ContributionMargin
        End Get
        Set(value As Decimal?)
            _ContributionMargin = value
        End Set
    End Property
End Class


Imports ApplicationForm
Public Class TariffClient

    Dim _IdTariff As Integer
    Dim _TariffType As String
    Dim _IdLayout As Integer
    Dim _Currency As String
    Dim _ValidFrom As Date
    Dim _ValidTo As Date
    Dim _TariffStatus As String
    Dim _UserCreate As String
    Dim _DateCreate As Nullable(Of Date)
    Dim _UserUpdate As String
    Dim _DateUpdate As Nullable(Of Date)
    Dim _Remarks As String

    Dim _TariffDetail As ICollection(Of TariffDetailClient) = New HashSet(Of TariffDetailClient)

    Public Property IdTariff As Integer
        Get
            Return _IdTariff
        End Get
        Set(value As Integer)
            _IdTariff = value
        End Set
    End Property

    Public Property TariffType As String
        Get
            Return _TariffType
        End Get
        Set(value As String)
            _TariffType = value
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

    Public Property Currency As String
        Get
            Return _Currency
        End Get
        Set(value As String)
            _Currency = value
        End Set
    End Property

    Public Property ValidFrom As Date
        Get
            Return _ValidFrom
        End Get
        Set(value As Date)
            _ValidFrom = value
        End Set
    End Property

    Public Property ValidTo As Date
        Get
            Return _ValidTo
        End Get
        Set(value As Date)
            _ValidTo = value
        End Set
    End Property

    Public Property TariffStatus As String
        Get
            Return _TariffStatus
        End Get
        Set(value As String)
            _TariffStatus = value
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

    Public Property Remarks As String
        Get
            Return _Remarks
        End Get
        Set(value As String)
            _Remarks = value
        End Set
    End Property

    Public Property TariffDetail As ICollection(Of TariffDetailClient)
        Get
            Return _TariffDetail
        End Get
        Set(value As ICollection(Of TariffDetailClient))
            _TariffDetail = value
        End Set
    End Property
End Class

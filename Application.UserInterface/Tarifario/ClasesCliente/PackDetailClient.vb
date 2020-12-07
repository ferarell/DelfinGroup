Imports ApplicationForm

Public Class PackDetailClient
    Dim _IdPackDetail As Integer
    Dim _IdPack As Integer
    Dim _IdConcept As Integer
    Dim _UserCreate As String
    Dim _DateCreate As Nullable(Of Date)
    Dim _UserUpdate As String
    Dim _DateUpdate As Nullable(Of Date)
    Dim _VendorEquivalentCode As Integer
    Dim _DistributionValue As Double
    Dim _Pack As PackClient

    Public Property IdPackDetail As Integer
        Get
            Return _IdPackDetail
        End Get
        Set(value As Integer)
            _IdPackDetail = value
        End Set
    End Property

    Public Property IdPack As Integer
        Get
            Return _IdPack
        End Get
        Set(value As Integer)
            _IdPack = value
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

    Public Property Pack As PackClient
        Get
            Return _Pack
        End Get
        Set(value As PackClient)
            _Pack = value
        End Set
    End Property

    Public Property VendorEquivalentCode As Integer
        Get
            Return _VendorEquivalentCode
        End Get
        Set(value As Integer)
            _VendorEquivalentCode = value
        End Set
    End Property

    Public Property DistributionValue As Double
        Get
            Return _DistributionValue
        End Get
        Set(value As Double)
            _DistributionValue = value
        End Set
    End Property
End Class

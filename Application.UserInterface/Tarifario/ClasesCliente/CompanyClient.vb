Imports ApplicationForm

Public Class CompanyClient


    Dim _IdCompany As Integer
    Dim _CompanyCode As String
    Dim _CompanyDescription As String
    Dim _CompanyTaxCode As String
    Dim _IdGroup As Integer
    Dim _CompanyStatus As String
    Dim _UserCreate As String
    Dim _DateCreate As Nullable(Of Date)
    Dim _UserUpdate As String
    Dim _DateUpdate As Nullable(Of Date)
    Dim _Group As GroupClient




    Public Property IdCompany As Integer
        Get
            Return _IdCompany
        End Get
        Set(value As Integer)
            _IdCompany = value
        End Set
    End Property

    Public Property CompanyCode As String
        Get
            Return _CompanyCode
        End Get
        Set(value As String)
            _CompanyCode = value
        End Set
    End Property

    Public Property CompanyDescription As String
        Get
            Return _CompanyDescription
        End Get
        Set(value As String)
            _CompanyDescription = value
        End Set
    End Property

    Public Property CompanyTaxCode As String
        Get
            Return _CompanyTaxCode
        End Get
        Set(value As String)
            _CompanyTaxCode = value
        End Set
    End Property

    Public Property IdGroup As Integer
        Get
            Return _IdGroup
        End Get
        Set(value As Integer)
            _IdGroup = value
        End Set
    End Property

    Public Property CompanyStatus As String
        Get
            Return _CompanyStatus
        End Get
        Set(value As String)
            _CompanyStatus = value
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

    Public Property Group As GroupClient
        Get
            Return _Group
        End Get
        Set(value As GroupClient)
            _Group = value
        End Set
    End Property
End Class

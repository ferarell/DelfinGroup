Public Class ConditionClient
    Dim _IdCondition As Short
    Dim _ConditionCode As String
    Dim _ConditionDescription As String
    Dim _ConditionStatus As String
    Dim _IdUnit As Short
    Dim _MaxValue As Decimal
    Dim _MinValue As Decimal
    Dim _UserCreate As String
    Dim _DateCreate As Nullable(Of Date)
    Dim _UserUpdate As String
    Dim _DateUpdate As Nullable(Of Date)
    Dim _IdBusinessUnit As Nullable(Of Integer)

    Public Property IdCondition As Short
        Get
            Return _IdCondition
        End Get
        Set(value As Short)
            _IdCondition = value
        End Set
    End Property

    Public Property ConditionCode As String
        Get
            Return _ConditionCode.Trim()
        End Get
        Set(value As String)
            _ConditionCode = value
        End Set
    End Property

    Public Property ConditionDescription As String
        Get
            Return _ConditionDescription
        End Get
        Set(value As String)
            _ConditionDescription = value
        End Set
    End Property

    Public Property ConditionStatus As String
        Get
            Return _ConditionStatus
        End Get
        Set(value As String)
            _ConditionStatus = value
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

    Public Property MaxValue As Decimal
        Get
            Return _MaxValue
        End Get
        Set(value As Decimal)
            _MaxValue = value
        End Set
    End Property

    Public Property MinValue As Decimal
        Get
            Return _MinValue
        End Get
        Set(value As Decimal)
            _MinValue = value
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

    Public Property IdBusinessUnit As Integer?
        Get
            Return _IdBusinessUnit
        End Get
        Set(value As Integer?)
            _IdBusinessUnit = value
        End Set
    End Property
End Class

Public Class Sap_upUpdateSynchronizedDocumentNumber
    Private _CCCT_Codigo As Integer
    Private _DocEntry As Integer
    Private _DocNum As String
    Private _EventLog As String

    Public Property CCCT_Codigo As Integer
        Get
            Return _CCCT_Codigo
        End Get
        Set(value As Integer)
            _CCCT_Codigo = value
        End Set
    End Property

    Public Property DocEntry As Integer
        Get
            Return _DocEntry
        End Get
        Set(value As Integer)
            _DocEntry = value
        End Set
    End Property

    Public Property DocNum As String
        Get
            Return _DocNum
        End Get
        Set(value As String)
            _DocNum = value
        End Set
    End Property

    Public Property EventLog As String
        Get
            Return _EventLog
        End Get
        Set(value As String)
            _EventLog = value
        End Set
    End Property
End Class

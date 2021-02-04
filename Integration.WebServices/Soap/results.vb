Public Class results
    Dim _DocEntry As String
    Dim _DocNum As String
    Dim _FolioNum As String
    Dim _FolioPref As String
    Dim _TransId As Integer
    Dim _Number As Integer
    Dim _Line_ID As Integer

    Public Property DocEntry As String
        Get
            Return _DocEntry
        End Get
        Set(value As String)
            _DocEntry = value
        End Set
    End Property

    Public Property FolioNum As String
        Get
            Return _FolioNum
        End Get
        Set(value As String)
            _FolioNum = value
        End Set
    End Property

    Public Property FolioPref As String
        Get
            Return _FolioPref
        End Get
        Set(value As String)
            _FolioPref = value
        End Set
    End Property

    Public Property TransId As Integer
        Get
            Return _TransId
        End Get
        Set(value As Integer)
            _TransId = value
        End Set
    End Property

    Public Property Number As Integer
        Get
            Return _Number
        End Get
        Set(value As Integer)
            _Number = value
        End Set
    End Property

    Public Property Line_ID As Integer
        Get
            Return _Line_ID
        End Get
        Set(value As Integer)
            _Line_ID = value
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
End Class

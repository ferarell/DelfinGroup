Public Class results
    Dim _DocEntry As String
    Dim _FolioNum As String
    Dim _FolioPref As String

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
End Class

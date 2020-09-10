Public Class Wrong
    Dim _code As String
    Dim _message As Message

    Public Property Code As String
        Get
            Return _code
        End Get
        Set(value As String)
            _code = value
        End Set
    End Property

    Public Property Message As Message
        Get
            Return _message
        End Get
        Set(value As Message)
            _message = value
        End Set
    End Property
End Class

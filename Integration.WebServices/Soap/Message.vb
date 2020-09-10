Public Class Message
    Dim _lang As String
    Dim _value As String

    Public Property Lang As String
        Get
            Return _lang
        End Get
        Set(value As String)
            _lang = value
        End Set
    End Property

    Public Property Value As String
        Get
            Return _value
        End Get
        Set(value As String)
            _value = value
        End Set
    End Property
End Class

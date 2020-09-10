Public Class Response
    Dim _error As Wrong

    Public Property [error] As Wrong
        Get
            Return _error
        End Get
        Set(value As Wrong)
            _error = value
        End Set
    End Property
End Class

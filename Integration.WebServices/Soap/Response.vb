Public Class Response
    Dim _error As Wrong
    Dim _DocEntry As Integer
    Dim _DocNum As Integer

    Public Property [error] As Wrong
        Get
            Return _error
        End Get
        Set(value As Wrong)
            _error = value
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

    Public Property DocNum As Integer
        Get
            Return _DocNum
        End Get
        Set(value As Integer)
            _DocNum = value
        End Set
    End Property
End Class

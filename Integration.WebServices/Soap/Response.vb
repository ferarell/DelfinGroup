Public Class Response
    Dim _error As Wrong
    Dim _DocEntry As Integer
    Dim _DocNum As Integer
    Dim _Number As Integer
    Dim _JdtNum As Integer

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

    Public Property Number As Integer
        Get
            Return _Number
        End Get
        Set(value As Integer)
            _Number = value
        End Set
    End Property

    Public Property JdtNum As Integer
        Get
            Return _JdtNum
        End Get
        Set(value As Integer)
            _JdtNum = value
        End Set
    End Property
End Class

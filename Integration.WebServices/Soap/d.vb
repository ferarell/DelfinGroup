Public Class d
    Dim _results As List(Of results)

    Public Property results As List(Of results)
        Get
            Return _results
        End Get
        Set(value As List(Of results))
            _results = value
        End Set
    End Property
End Class

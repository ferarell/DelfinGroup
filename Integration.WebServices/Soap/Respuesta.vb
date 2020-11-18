Imports WASAPB1

Public Class Respuesta
    Dim _ItemCode As String
    Dim _SWW As String
    Dim _ResponseStatus As String
    Dim _RespuestaSAP As Integer
    Dim _RespuestaNexsoft As Integer
    Dim _Value As String
    Dim _Response As List(Of Response)
    Dim _D As d
    Public Property ResponseStatus As String
        Get
            Return _ResponseStatus
        End Get
        Set(value As String)
            _ResponseStatus = value
        End Set
    End Property



    Public Property RespuestaSAP As Integer
        Get
            Return _RespuestaSAP
        End Get
        Set(value As Integer)
            _RespuestaSAP = value
        End Set
    End Property

    Public Property RespuestaNexsoft As Integer
        Get
            Return _RespuestaNexsoft
        End Get
        Set(value As Integer)
            _RespuestaNexsoft = value
        End Set
    End Property

    Public Property ItemCode As String
        Get
            Return _ItemCode
        End Get
        Set(value As String)
            _ItemCode = value
        End Set
    End Property

    Public Property SWW As String
        Get
            Return _SWW
        End Get
        Set(value As String)
            _SWW = value
        End Set
    End Property

    Public Property Value As String
        Get
            Return _Value
        End Get
        Set(value As String)
            _Value = value
        End Set
    End Property

    Public Property Response As List(Of Response)
        Get
            Return _Response
        End Get
        Set(value As List(Of Response))
            _Response = value
        End Set
    End Property






    Public Property d As d
        Get
            Return _D
        End Get
        Set(value As d)
            _D = value
        End Set
    End Property
End Class


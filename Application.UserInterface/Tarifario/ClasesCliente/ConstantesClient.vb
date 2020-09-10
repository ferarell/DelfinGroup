Public Class ConstantesClient

    Dim _CONS_CodTabla As String
    Dim _CONS_CodTipo As String
    Dim _CONS_Desc_SPA As String
    Dim _CONS_Desc_ENG As String

    Public Property CONS_CodTabla As String
        Get
            Return _CONS_CodTabla
        End Get
        Set(value As String)
            _CONS_CodTabla = value
        End Set
    End Property

    Public Property CONS_CodTipo As String
        Get
            Return _CONS_CodTipo
        End Get
        Set(value As String)
            _CONS_CodTipo = value
        End Set
    End Property

    Public Property CONS_Desc_SPA As String
        Get
            Return _CONS_Desc_SPA
        End Get
        Set(value As String)
            _CONS_Desc_SPA = value
        End Set
    End Property

    Public Property CONS_Desc_ENG As String
        Get
            Return _CONS_Desc_ENG
        End Get
        Set(value As String)
            _CONS_Desc_ENG = value
        End Set
    End Property
End Class

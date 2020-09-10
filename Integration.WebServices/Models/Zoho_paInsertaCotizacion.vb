Public Class Zoho_paInsertaCotizacion

    Private _IdCRM As String
    Private _Cliente As String
    Private _Transportista As String
    Private _FechaCierre As DateTime
    Private _ServicioLogistico As Integer
    Private _Observaciones As String
    Private _Regimen As String
    Private _Via As String
    Private _PuertoDestino As String
    Private _PuertoOrigen As String
    Private _Moneda As String
    Private _Usuario As String

    Public Property IdCRM As String
        Get
            Return _IdCRM
        End Get
        Set(value As String)
            _IdCRM = value
        End Set
    End Property

    Public Property Cliente As String
        Get
            Return _Cliente
        End Get
        Set(value As String)
            _Cliente = value
        End Set
    End Property

    Public Property Transportista As String
        Get
            Return _Transportista
        End Get
        Set(value As String)
            _Transportista = value
        End Set
    End Property



    Public Property FechaCierre As String
        Get
            Return _FechaCierre
        End Get
        Set(value As String)
            _FechaCierre = value
        End Set
    End Property

    Public Property ServicioLogistico As Integer
        Get
            Return _ServicioLogistico
        End Get
        Set(value As Integer)
            _ServicioLogistico = value
        End Set
    End Property

    Public Property Observaciones As String
        Get
            Return _Observaciones
        End Get
        Set(value As String)
            _Observaciones = value
        End Set
    End Property

    Public Property Regimen As String
        Get
            Return _Regimen
        End Get
        Set(value As String)
            _Regimen = value
        End Set
    End Property

    Public Property Via As String
        Get
            Return _Via
        End Get
        Set(value As String)
            _Via = value
        End Set
    End Property

    Public Property PuertoDestino As String
        Get
            Return _PuertoDestino
        End Get
        Set(value As String)
            _PuertoDestino = value
        End Set
    End Property

    Public Property PuertoOrigen As String
        Get
            Return _PuertoOrigen
        End Get
        Set(value As String)
            _PuertoOrigen = value
        End Set
    End Property

    Public Property Moneda As String
        Get
            Return _Moneda
        End Get
        Set(value As String)
            _Moneda = value
        End Set
    End Property

    Public Property Usuario As String
        Get
            Return _Usuario
        End Get
        Set(value As String)
            _Usuario = value
        End Set
    End Property
End Class

Imports System.Runtime.Serialization

<DataContract()>
Public Class EntidadDireccionamiento_BE
    Private _ENDI_Numero As Int32
    Private _ENTC_Codigo As Int32
    Private _ENTC_EMailSolicitante As String
    Private _DOOV_HBL As String
    Private _ENTC_CodDepTemporal As Int32
    Private _ENTC_CodDepTemporalSolicitado As Int32
    Private _ENDI_Estado As String
    Private _AUDI_UsrCrea As String
    Private _AUDI_FecCrea As DateTime
    Private _AUDI_UsrMod As String
    Private _AUDI_FecMod As DateTime?
    Private _DescargaDirecta As Boolean
    Private _NombreCliente As String
    Private _NombreDepositoTemporal As String
    Private _NombreDepositoTemporalAsignado As String

    Private _CodigoRespuesta As String
    Private _DescripcionRespuesta As String



    Private _FechaMaxDireccionamiento As DateTime?
    Private _DescripcionEstado As String
    Private _EsAnulable As Boolean










    Public Sub New()
    End Sub
    <DataMember()>
    Public Property ENDI_Numero As Integer
        Get
            Return _ENDI_Numero
        End Get
        Set(value As Integer)
            _ENDI_Numero = value
        End Set
    End Property
    <DataMember()>
    Public Property ENTC_Codigo As Integer
        Get
            Return _ENTC_Codigo
        End Get
        Set(value As Integer)
            _ENTC_Codigo = value
        End Set
    End Property
    <DataMember()>
    Public Property ENTC_EMailSolicitante As String
        Get
            Return _ENTC_EMailSolicitante
        End Get
        Set(value As String)
            _ENTC_EMailSolicitante = value
        End Set
    End Property
    <DataMember()>
    Public Property DOOV_HBL As String
        Get
            Return _DOOV_HBL
        End Get
        Set(value As String)
            _DOOV_HBL = value
        End Set
    End Property
    <DataMember()>
    Public Property ENTC_CodDepTemporal As Integer
        Get
            Return _ENTC_CodDepTemporal
        End Get
        Set(value As Integer)
            _ENTC_CodDepTemporal = value
        End Set
    End Property
    <DataMember()>
    Public Property ENTC_CodDepTemporalSolicitado As Integer
        Get
            Return _ENTC_CodDepTemporalSolicitado
        End Get
        Set(value As Integer)
            _ENTC_CodDepTemporalSolicitado = value
        End Set
    End Property
    <DataMember()>
    Public Property ENDI_Estado As String
        Get
            Return _ENDI_Estado
        End Get
        Set(value As String)
            _ENDI_Estado = value
        End Set
    End Property
    <DataMember()>
    Public Property AUDI_UsrCrea As String
        Get
            Return _AUDI_UsrCrea
        End Get
        Set(value As String)
            _AUDI_UsrCrea = value
        End Set
    End Property
    <DataMember()>
    Public Property AUDI_FecCrea As Date
        Get
            Return _AUDI_FecCrea
        End Get
        Set(value As Date)
            _AUDI_FecCrea = value
        End Set
    End Property
    <DataMember()>
    Public Property AUDI_UsrMod As String
        Get
            Return _AUDI_UsrMod
        End Get
        Set(value As String)
            _AUDI_UsrMod = value
        End Set
    End Property
    <DataMember()>
    Public Property AUDI_FecMod As Date?
        Get
            Return _AUDI_FecMod
        End Get
        Set(value As Date?)
            _AUDI_FecMod = value
        End Set
    End Property
    <DataMember()>
    Public Property NombreCliente As String
        Get
            Return _NombreCliente
        End Get
        Set(value As String)
            _NombreCliente = value
        End Set
    End Property
    <DataMember()>
    Public Property NombreDepositoTemporal As String
        Get
            Return _NombreDepositoTemporal
        End Get
        Set(value As String)
            _NombreDepositoTemporal = value
        End Set
    End Property
    <DataMember()>
    Public Property NombreDepositoTemporalAsignado As String
        Get
            Return _NombreDepositoTemporalAsignado
        End Get
        Set(value As String)
            _NombreDepositoTemporalAsignado = value
        End Set
    End Property
    <DataMember()>
    Public Property DescargaDirecta As Boolean
        Get
            Return _DescargaDirecta
        End Get
        Set(value As Boolean)
            _DescargaDirecta = value
        End Set
    End Property
    <DataMember()>
    Public Property CodigoRespuesta As String
        Get
            Return _CodigoRespuesta
        End Get
        Set(value As String)
            _CodigoRespuesta = value
        End Set
    End Property
    <DataMember()>
    Public Property DescripcionRespuesta As String
        Get
            Return _DescripcionRespuesta
        End Get
        Set(value As String)
            _DescripcionRespuesta = value
        End Set
    End Property
    <DataMember()>
    Public Property FechaMaxDireccionamiento As Date?
        Get
            Return _FechaMaxDireccionamiento
        End Get
        Set(value As Date?)
            _FechaMaxDireccionamiento = value
        End Set
    End Property
    <DataMember()>
    Public Property DescripcionEstado As String
        Get
            Return _DescripcionEstado
        End Get
        Set(value As String)
            _DescripcionEstado = value
        End Set
    End Property
    <DataMember()>
    Public Property EsAnulable As Boolean
        Get
            Return _EsAnulable
        End Get
        Set(value As Boolean)
            _EsAnulable = value
        End Set
    End Property
End Class

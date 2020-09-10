Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Public Class ucAuditPanel


    Public Property pnlAuditoria() As PanelControl
        Get
            Return Me.pnlAuditoriaUp
        End Get
        Set(ByVal value As PanelControl)
            Me.pnlAuditoriaUp = value
        End Set
    End Property


    Private _UsuarioCreacion As String
    Public Property UsuarioCreacion() As String
        Get
            Return _UsuarioCreacion
        End Get
        Set(ByVal value As String)
            _UsuarioCreacion = value
        End Set
    End Property

    Private _UsuarioModificacion As String
    Public Property UsuarioModificacion() As String
        Get
            Return _UsuarioModificacion
        End Get
        Set(ByVal value As String)
            _UsuarioModificacion = value
        End Set
    End Property


    Private _FechaCreacion As DateTime
    Public Property FechaCreacion() As DateTime
        Get
            Return _FechaCreacion
        End Get
        Set(ByVal value As DateTime)
            _FechaCreacion = value
        End Set
    End Property


    Private _FechaModificacion As DateTime
    Public Property FechaModificacion() As DateTime
        Get
            Return _FechaModificacion
        End Get
        Set(ByVal value As DateTime)
            _FechaModificacion = value
        End Set
    End Property

    Private Sub panelControl3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        Me.lblUsuarioC.Text = UsuarioCreacion
        Me.lblUsuarioM.Text = UsuarioModificacion
        Me.lblFechaCreacion.Text = FechaCreacion
        Me.lblFechaModificacion.Text = FechaModificacion
    End Sub
End Class

﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.lueDomain = New DevExpress.XtraEditors.LookUpEdit()
        Me.ceIntegrated = New DevExpress.XtraEditors.CheckEdit()
        Me.btnAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.tePassword = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.teUserName = New DevExpress.XtraEditors.TextEdit()
        Me.grpLogin = New DevExpress.XtraEditors.GroupControl()
        Me.pictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.vpInputs = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelControl1.SuspendLayout()
        CType(Me.lueDomain.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceIntegrated.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tePassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teUserName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLogin.SuspendLayout()
        CType(Me.pictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vpInputs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelControl1
        '
        Me.panelControl1.Controls.Add(Me.lueDomain)
        Me.panelControl1.Controls.Add(Me.ceIntegrated)
        Me.panelControl1.Controls.Add(Me.btnAceptar)
        Me.panelControl1.Controls.Add(Me.btnCancelar)
        Me.panelControl1.Controls.Add(Me.labelControl3)
        Me.panelControl1.Controls.Add(Me.tePassword)
        Me.panelControl1.Controls.Add(Me.LabelControl1)
        Me.panelControl1.Controls.Add(Me.labelControl4)
        Me.panelControl1.Controls.Add(Me.teUserName)
        Me.panelControl1.Location = New System.Drawing.Point(208, 24)
        Me.panelControl1.Name = "panelControl1"
        Me.panelControl1.Size = New System.Drawing.Size(211, 208)
        Me.panelControl1.TabIndex = 10
        '
        'lueDomain
        '
        Me.lueDomain.Location = New System.Drawing.Point(13, 128)
        Me.lueDomain.Name = "lueDomain"
        Me.lueDomain.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueDomain.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("domain", "Dominio"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("directory", "Directorio Activo")})
        Me.lueDomain.Properties.NullText = ""
        Me.lueDomain.Size = New System.Drawing.Size(185, 20)
        Me.lueDomain.TabIndex = 2
        '
        'ceIntegrated
        '
        Me.ceIntegrated.Location = New System.Drawing.Point(13, 9)
        Me.ceIntegrated.Name = "ceIntegrated"
        Me.ceIntegrated.Properties.Caption = "Autenticación Integrada"
        Me.ceIntegrated.Size = New System.Drawing.Size(187, 19)
        Me.ceIntegrated.TabIndex = 5
        '
        'btnAceptar
        '
        Me.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.Location = New System.Drawing.Point(13, 159)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(87, 40)
        Me.btnAceptar.TabIndex = 3
        Me.btnAceptar.Text = "&Aceptar"
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(113, 159)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(87, 40)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "&Cancelar"
        '
        'labelControl3
        '
        Me.labelControl3.Location = New System.Drawing.Point(15, 34)
        Me.labelControl3.Name = "labelControl3"
        Me.labelControl3.Size = New System.Drawing.Size(91, 13)
        Me.labelControl3.TabIndex = 0
        Me.labelControl3.Text = "Nombre de Usuario"
        '
        'tePassword
        '
        Me.tePassword.EditValue = ""
        Me.tePassword.Location = New System.Drawing.Point(13, 89)
        Me.tePassword.Name = "tePassword"
        Me.tePassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tePassword.Size = New System.Drawing.Size(187, 20)
        Me.tePassword.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(15, 112)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl1.TabIndex = 15
        Me.LabelControl1.Text = "Dominio"
        '
        'labelControl4
        '
        Me.labelControl4.Location = New System.Drawing.Point(15, 73)
        Me.labelControl4.Name = "labelControl4"
        Me.labelControl4.Size = New System.Drawing.Size(56, 13)
        Me.labelControl4.TabIndex = 15
        Me.labelControl4.Text = "Contraseña"
        '
        'teUserName
        '
        Me.teUserName.EditValue = ""
        Me.teUserName.Location = New System.Drawing.Point(13, 50)
        Me.teUserName.Name = "teUserName"
        Me.teUserName.Size = New System.Drawing.Size(187, 20)
        Me.teUserName.TabIndex = 0
        '
        'grpLogin
        '
        Me.grpLogin.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grpLogin.AppearanceCaption.Options.UseFont = True
        Me.grpLogin.Controls.Add(Me.panelControl1)
        Me.grpLogin.Controls.Add(Me.pictureEdit1)
        Me.grpLogin.Location = New System.Drawing.Point(10, 12)
        Me.grpLogin.Name = "grpLogin"
        Me.grpLogin.Size = New System.Drawing.Size(437, 237)
        Me.grpLogin.TabIndex = 8
        Me.grpLogin.Text = "Seguridad"
        '
        'pictureEdit1
        '
        Me.pictureEdit1.EditValue = CType(resources.GetObject("pictureEdit1.EditValue"), Object)
        Me.pictureEdit1.Location = New System.Drawing.Point(11, 24)
        Me.pictureEdit1.Name = "pictureEdit1"
        Me.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.pictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pictureEdit1.Properties.Padding = New System.Windows.Forms.Padding(1)
        Me.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.pictureEdit1.Size = New System.Drawing.Size(191, 208)
        Me.pictureEdit1.TabIndex = 9
        '
        'vpInputs
        '
        Me.vpInputs.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual
        '
        'LoginForm
        '
        Me.AcceptButton = Me.btnAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(457, 261)
        Me.ControlBox = False
        Me.Controls.Add(Me.grpLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoginForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelControl1.ResumeLayout(False)
        Me.panelControl1.PerformLayout()
        CType(Me.lueDomain.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceIntegrated.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tePassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teUserName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpLogin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLogin.ResumeLayout(False)
        CType(Me.pictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vpInputs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents panelControl1 As DevExpress.XtraEditors.PanelControl
    Private WithEvents pictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Private WithEvents grpLogin As DevExpress.XtraEditors.GroupControl
    Private WithEvents btnAceptar As DevExpress.XtraEditors.SimpleButton
    Private WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Private WithEvents labelControl3 As DevExpress.XtraEditors.LabelControl
    Private WithEvents tePassword As DevExpress.XtraEditors.TextEdit
    Private WithEvents labelControl4 As DevExpress.XtraEditors.LabelControl
    Private WithEvents teUserName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ceIntegrated As DevExpress.XtraEditors.CheckEdit
    Private WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lueDomain As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents vpInputs As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
End Class

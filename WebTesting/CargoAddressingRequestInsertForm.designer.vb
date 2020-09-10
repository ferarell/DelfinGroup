<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CargoAddressingRequestInsertForm
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CargoAddressingRequestInsertForm))
        Me.brBarraAcciones = New DevExpress.XtraBars.Bar()
        Me.bbiGuardar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiClose = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiGetQuote = New DevExpress.XtraBars.BarButtonItem()
        Me.vpInputs = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.bmActions = New DevExpress.XtraBars.BarManager(Me.components)
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl3 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl4 = New DevExpress.XtraBars.BarDockControl()
        Me.brsDescripcion = New DevExpress.XtraBars.BarStaticItem()
        Me.bbiExport = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiViewer = New DevExpress.XtraBars.BarButtonItem()
        Me.rpiProceso = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
        Me.RepositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtHBL = New DevExpress.XtraEditors.TextEdit()
        Me.lblDescargaDirecta = New DevExpress.XtraEditors.LabelControl()
        Me.chkDescargaDirecta = New DevExpress.XtraEditors.CheckEdit()
        Me.reResult = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.lblNuevoDeposito = New DevExpress.XtraEditors.LabelControl()
        Me.lblDepositoOriginal = New DevExpress.XtraEditors.LabelControl()
        Me.lueNuevoDeposito = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueDepositoOriginal = New DevExpress.XtraEditors.LookUpEdit()
        CType(Me.vpInputs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bmActions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpiProceso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtHBL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDescargaDirecta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reResult.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueNuevoDeposito.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueDepositoOriginal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'brBarraAcciones
        '
        Me.brBarraAcciones.BarName = "Custom 5"
        Me.brBarraAcciones.DockCol = 0
        Me.brBarraAcciones.DockRow = 0
        Me.brBarraAcciones.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.brBarraAcciones.FloatLocation = New System.Drawing.Point(279, 188)
        Me.brBarraAcciones.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbiGuardar, True), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bbiClose, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.brBarraAcciones.OptionsBar.AllowQuickCustomization = False
        Me.brBarraAcciones.OptionsBar.UseWholeRow = True
        Me.brBarraAcciones.Text = "Custom 5"
        '
        'bbiGuardar
        '
        Me.bbiGuardar.Caption = "&Guardar"
        Me.bbiGuardar.Id = 28
        Me.bbiGuardar.ImageOptions.Image = Global.WebTesting.My.Resources.Resources.save_32x32
        Me.bbiGuardar.ImageOptions.LargeImage = Global.WebTesting.My.Resources.Resources.save_32x32
        Me.bbiGuardar.Name = "bbiGuardar"
        Me.bbiGuardar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'bbiClose
        '
        Me.bbiClose.Caption = "&Cerrar"
        Me.bbiClose.Id = 41
        Me.bbiClose.ImageOptions.Image = CType(resources.GetObject("bbiClose.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiClose.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.C))
        Me.bbiClose.Name = "bbiClose"
        Me.bbiClose.ShortcutKeyDisplayString = "Ctrl+C"
        '
        'bbiGetQuote
        '
        Me.bbiGetQuote.Caption = "&Cotizar"
        Me.bbiGetQuote.Id = 33
        Me.bbiGetQuote.ImageOptions.Image = CType(resources.GetObject("bbiGetQuote.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiGetQuote.ImageOptions.LargeImage = CType(resources.GetObject("bbiGetQuote.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.bbiGetQuote.Name = "bbiGetQuote"
        '
        'vpInputs
        '
        Me.vpInputs.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual
        '
        'bmActions
        '
        Me.bmActions.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.brBarraAcciones})
        Me.bmActions.DockControls.Add(Me.BarDockControl1)
        Me.bmActions.DockControls.Add(Me.BarDockControl2)
        Me.bmActions.DockControls.Add(Me.BarDockControl3)
        Me.bmActions.DockControls.Add(Me.BarDockControl4)
        Me.bmActions.Form = Me
        Me.bmActions.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.brsDescripcion, Me.bbiGetQuote, Me.bbiClose, Me.bbiExport, Me.bbiViewer, Me.bbiGuardar})
        Me.bmActions.MaxItemId = 29
        Me.bmActions.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpiProceso, Me.RepositoryItemImageComboBox1})
        Me.bmActions.TransparentEditorsMode = DevExpress.Utils.DefaultBoolean.[False]
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl1.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl1.Manager = Me.bmActions
        Me.BarDockControl1.Size = New System.Drawing.Size(367, 43)
        '
        'BarDockControl2
        '
        Me.BarDockControl2.CausesValidation = False
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl2.Location = New System.Drawing.Point(0, 230)
        Me.BarDockControl2.Manager = Me.bmActions
        Me.BarDockControl2.Size = New System.Drawing.Size(367, 0)
        '
        'BarDockControl3
        '
        Me.BarDockControl3.CausesValidation = False
        Me.BarDockControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl3.Location = New System.Drawing.Point(0, 43)
        Me.BarDockControl3.Manager = Me.bmActions
        Me.BarDockControl3.Size = New System.Drawing.Size(0, 187)
        '
        'BarDockControl4
        '
        Me.BarDockControl4.CausesValidation = False
        Me.BarDockControl4.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl4.Location = New System.Drawing.Point(367, 43)
        Me.BarDockControl4.Manager = Me.bmActions
        Me.BarDockControl4.Size = New System.Drawing.Size(0, 187)
        '
        'brsDescripcion
        '
        Me.brsDescripcion.Id = 30
        Me.brsDescripcion.Name = "brsDescripcion"
        '
        'bbiExport
        '
        Me.bbiExport.Caption = "&Exportar"
        Me.bbiExport.Id = 22
        Me.bbiExport.ImageOptions.Image = CType(resources.GetObject("bbiExport.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiExport.Name = "bbiExport"
        '
        'bbiViewer
        '
        Me.bbiViewer.Caption = "&Vista Preliminar"
        Me.bbiViewer.Id = 27
        Me.bbiViewer.ImageOptions.Image = CType(resources.GetObject("bbiViewer.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiViewer.ImageOptions.LargeImage = CType(resources.GetObject("bbiViewer.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.bbiViewer.Name = "bbiViewer"
        Me.bbiViewer.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'rpiProceso
        '
        Me.rpiProceso.Name = "rpiProceso"
        Me.rpiProceso.ShowTitle = True
        '
        'RepositoryItemImageComboBox1
        '
        Me.RepositoryItemImageComboBox1.AutoHeight = False
        Me.RepositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(), New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemImageComboBox1.Name = "RepositoryItemImageComboBox1"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.txtHBL)
        Me.PanelControl1.Controls.Add(Me.lblDescargaDirecta)
        Me.PanelControl1.Controls.Add(Me.chkDescargaDirecta)
        Me.PanelControl1.Controls.Add(Me.reResult)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.lblNuevoDeposito)
        Me.PanelControl1.Controls.Add(Me.lblDepositoOriginal)
        Me.PanelControl1.Controls.Add(Me.lueNuevoDeposito)
        Me.PanelControl1.Controls.Add(Me.lueDepositoOriginal)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 43)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(367, 187)
        Me.PanelControl1.TabIndex = 4
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(89, 29)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(18, 13)
        Me.LabelControl3.TabIndex = 42
        Me.LabelControl3.Text = "HBL"
        '
        'txtHBL
        '
        Me.txtHBL.Location = New System.Drawing.Point(113, 26)
        Me.txtHBL.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtHBL.MenuManager = Me.bmActions
        Me.txtHBL.Name = "txtHBL"
        Me.txtHBL.Size = New System.Drawing.Size(209, 20)
        Me.txtHBL.TabIndex = 0
        '
        'lblDescargaDirecta
        '
        Me.lblDescargaDirecta.Location = New System.Drawing.Point(25, 104)
        Me.lblDescargaDirecta.Name = "lblDescargaDirecta"
        Me.lblDescargaDirecta.Size = New System.Drawing.Size(82, 13)
        Me.lblDescargaDirecta.TabIndex = 40
        Me.lblDescargaDirecta.Text = "Descarga Directa"
        '
        'chkDescargaDirecta
        '
        Me.chkDescargaDirecta.Location = New System.Drawing.Point(113, 102)
        Me.chkDescargaDirecta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkDescargaDirecta.MenuManager = Me.bmActions
        Me.chkDescargaDirecta.Name = "chkDescargaDirecta"
        Me.chkDescargaDirecta.Properties.Caption = ""
        Me.chkDescargaDirecta.Size = New System.Drawing.Size(81, 18)
        Me.chkDescargaDirecta.TabIndex = 2
        '
        'reResult
        '
        Me.reResult.Location = New System.Drawing.Point(135, 428)
        Me.reResult.MenuManager = Me.bmActions
        Me.reResult.Name = "reResult"
        Me.reResult.Properties.AutoHeight = False
        Me.reResult.Size = New System.Drawing.Size(143, 26)
        Me.reResult.TabIndex = 38
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(48, 434)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(82, 13)
        Me.LabelControl1.TabIndex = 29
        Me.LabelControl1.Text = "Importe (US$)"
        '
        'lblNuevoDeposito
        '
        Me.lblNuevoDeposito.Location = New System.Drawing.Point(19, 139)
        Me.lblNuevoDeposito.Name = "lblNuevoDeposito"
        Me.lblNuevoDeposito.Size = New System.Drawing.Size(90, 13)
        Me.lblNuevoDeposito.TabIndex = 26
        Me.lblNuevoDeposito.Text = "Depósito Solicitado"
        '
        'lblDepositoOriginal
        '
        Me.lblDepositoOriginal.Location = New System.Drawing.Point(32, 66)
        Me.lblDepositoOriginal.Name = "lblDepositoOriginal"
        Me.lblDepositoOriginal.Size = New System.Drawing.Size(75, 13)
        Me.lblDepositoOriginal.TabIndex = 24
        Me.lblDepositoOriginal.Text = "Depósito Actual"
        '
        'lueNuevoDeposito
        '
        Me.lueNuevoDeposito.Location = New System.Drawing.Point(113, 136)
        Me.lueNuevoDeposito.Name = "lueNuevoDeposito"
        Me.lueNuevoDeposito.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lueNuevoDeposito.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueNuevoDeposito.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodigoDepositoTemporal", "Codigo"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DescripcionDepositoTemporal", "Descripcion")})
        Me.lueNuevoDeposito.Properties.NullText = ""
        Me.lueNuevoDeposito.Size = New System.Drawing.Size(209, 20)
        Me.lueNuevoDeposito.TabIndex = 3
        '
        'lueDepositoOriginal
        '
        Me.lueDepositoOriginal.Location = New System.Drawing.Point(113, 63)
        Me.lueDepositoOriginal.Name = "lueDepositoOriginal"
        Me.lueDepositoOriginal.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lueDepositoOriginal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueDepositoOriginal.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodigoDepositoTemporal", "Codigo"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DescripcionDepositoTemporal", "Descripcion")})
        Me.lueDepositoOriginal.Properties.NullText = ""
        Me.lueDepositoOriginal.Size = New System.Drawing.Size(209, 20)
        Me.lueDepositoOriginal.TabIndex = 1
        '
        'CargoAddressingRequestInsertForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 230)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.BarDockControl3)
        Me.Controls.Add(Me.BarDockControl4)
        Me.Controls.Add(Me.BarDockControl2)
        Me.Controls.Add(Me.BarDockControl1)
        Me.Name = "CargoAddressingRequestInsertForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Solicitud de Direccionamiento"
        CType(Me.vpInputs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bmActions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpiProceso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtHBL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDescargaDirecta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reResult.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueNuevoDeposito.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueDepositoOriginal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents brBarraAcciones As DevExpress.XtraBars.Bar
    Private WithEvents bbiGetQuote As DevExpress.XtraBars.BarButtonItem
    Private WithEvents bbiClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents vpInputs As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Private WithEvents bmActions As DevExpress.XtraBars.BarManager
    Private WithEvents brsDescripcion As DevExpress.XtraBars.BarStaticItem
    Private WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Private WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
    Private WithEvents BarDockControl3 As DevExpress.XtraBars.BarDockControl
    Private WithEvents BarDockControl4 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents bbiExport As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiViewer As DevExpress.XtraBars.BarButtonItem
    Private WithEvents rpiProceso As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Friend WithEvents RepositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents lblNuevoDeposito As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDepositoOriginal As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lueNuevoDeposito As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueDepositoOriginal As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents reResult As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtHBL As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblDescargaDirecta As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkDescargaDirecta As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents bbiGuardar As DevExpress.XtraBars.BarButtonItem
End Class

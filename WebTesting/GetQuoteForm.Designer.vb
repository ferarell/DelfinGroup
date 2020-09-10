<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GetQuoteForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GetQuoteForm))
        Me.brBarraAcciones = New DevExpress.XtraBars.Bar()
        Me.bbiGetQuote = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiClose = New DevExpress.XtraBars.BarButtonItem()
        Me.vpInputs = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.bmActions = New DevExpress.XtraBars.BarManager(Me.components)
        Me.bar5 = New DevExpress.XtraBars.Bar()
        Me.brsDescripcion = New DevExpress.XtraBars.BarStaticItem()
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl3 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl4 = New DevExpress.XtraBars.BarDockControl()
        Me.bbiExport = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiViewer = New DevExpress.XtraBars.BarButtonItem()
        Me.rpiProceso = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
        Me.RepositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.seVolume = New DevExpress.XtraEditors.SpinEdit()
        Me.seHeigth = New DevExpress.XtraEditors.SpinEdit()
        Me.seWidth = New DevExpress.XtraEditors.SpinEdit()
        Me.seLarge = New DevExpress.XtraEditors.SpinEdit()
        Me.seWeight = New DevExpress.XtraEditors.SpinEdit()
        Me.seQuantity = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.lueCommodity = New DevExpress.XtraEditors.LookUpEdit()
        Me.luePackingType = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueCargoType = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueIncoterm = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueEquipmentType = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueDestinationPort = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueDestinationCountry = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueOriginPort = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueOriginCountry = New DevExpress.XtraEditors.LookUpEdit()
        Me.reResult = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.vpInputs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bmActions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpiProceso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.seVolume.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seHeigth.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seWidth.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seLarge.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seWeight.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seQuantity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueCommodity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luePackingType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueCargoType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueIncoterm.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueEquipmentType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueDestinationPort.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueDestinationCountry.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueOriginPort.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueOriginCountry.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reResult.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'brBarraAcciones
        '
        Me.brBarraAcciones.BarName = "Custom 5"
        Me.brBarraAcciones.DockCol = 0
        Me.brBarraAcciones.DockRow = 0
        Me.brBarraAcciones.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.brBarraAcciones.FloatLocation = New System.Drawing.Point(279, 188)
        Me.brBarraAcciones.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bbiGetQuote, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bbiClose, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.brBarraAcciones.OptionsBar.AllowQuickCustomization = False
        Me.brBarraAcciones.OptionsBar.UseWholeRow = True
        Me.brBarraAcciones.Text = "Custom 5"
        '
        'bbiGetQuote
        '
        Me.bbiGetQuote.Caption = "&Cotizar"
        Me.bbiGetQuote.Id = 33
        Me.bbiGetQuote.ImageOptions.Image = CType(resources.GetObject("bbiSendMail.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiGetQuote.ImageOptions.LargeImage = CType(resources.GetObject("bbiSendMail.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.bbiGetQuote.Name = "bbiGetQuote"
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
        'vpInputs
        '
        Me.vpInputs.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual
        '
        'bmActions
        '
        Me.bmActions.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.bar5, Me.brBarraAcciones})
        Me.bmActions.DockControls.Add(Me.BarDockControl1)
        Me.bmActions.DockControls.Add(Me.BarDockControl2)
        Me.bmActions.DockControls.Add(Me.BarDockControl3)
        Me.bmActions.DockControls.Add(Me.BarDockControl4)
        Me.bmActions.Form = Me
        Me.bmActions.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.brsDescripcion, Me.bbiGetQuote, Me.bbiClose, Me.bbiExport, Me.bbiViewer})
        Me.bmActions.MaxItemId = 28
        Me.bmActions.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpiProceso, Me.RepositoryItemImageComboBox1})
        Me.bmActions.TransparentEditorsMode = DevExpress.Utils.DefaultBoolean.[False]
        '
        'bar5
        '
        Me.bar5.BarName = "Custom 3"
        Me.bar5.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.bar5.DockCol = 0
        Me.bar5.DockRow = 0
        Me.bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.bar5.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.brsDescripcion)})
        Me.bar5.OptionsBar.AllowQuickCustomization = False
        Me.bar5.OptionsBar.DrawDragBorder = False
        Me.bar5.OptionsBar.MultiLine = True
        Me.bar5.OptionsBar.UseWholeRow = True
        Me.bar5.Text = "Custom 3"
        '
        'brsDescripcion
        '
        Me.brsDescripcion.Id = 30
        Me.brsDescripcion.Name = "brsDescripcion"
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl1.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl1.Manager = Me.bmActions
        Me.BarDockControl1.Size = New System.Drawing.Size(823, 41)
        '
        'BarDockControl2
        '
        Me.BarDockControl2.CausesValidation = False
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl2.Location = New System.Drawing.Point(0, 537)
        Me.BarDockControl2.Manager = Me.bmActions
        Me.BarDockControl2.Size = New System.Drawing.Size(823, 27)
        '
        'BarDockControl3
        '
        Me.BarDockControl3.CausesValidation = False
        Me.BarDockControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl3.Location = New System.Drawing.Point(0, 41)
        Me.BarDockControl3.Manager = Me.bmActions
        Me.BarDockControl3.Size = New System.Drawing.Size(0, 496)
        '
        'BarDockControl4
        '
        Me.BarDockControl4.CausesValidation = False
        Me.BarDockControl4.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl4.Location = New System.Drawing.Point(823, 41)
        Me.BarDockControl4.Manager = Me.bmActions
        Me.BarDockControl4.Size = New System.Drawing.Size(0, 496)
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
        Me.PanelControl1.Controls.Add(Me.reResult)
        Me.PanelControl1.Controls.Add(Me.seVolume)
        Me.PanelControl1.Controls.Add(Me.seHeigth)
        Me.PanelControl1.Controls.Add(Me.seWidth)
        Me.PanelControl1.Controls.Add(Me.seLarge)
        Me.PanelControl1.Controls.Add(Me.seWeight)
        Me.PanelControl1.Controls.Add(Me.seQuantity)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.LabelControl20)
        Me.PanelControl1.Controls.Add(Me.LabelControl19)
        Me.PanelControl1.Controls.Add(Me.LabelControl18)
        Me.PanelControl1.Controls.Add(Me.LabelControl17)
        Me.PanelControl1.Controls.Add(Me.LabelControl16)
        Me.PanelControl1.Controls.Add(Me.LabelControl15)
        Me.PanelControl1.Controls.Add(Me.LabelControl23)
        Me.PanelControl1.Controls.Add(Me.LabelControl14)
        Me.PanelControl1.Controls.Add(Me.LabelControl13)
        Me.PanelControl1.Controls.Add(Me.LabelControl12)
        Me.PanelControl1.Controls.Add(Me.LabelControl11)
        Me.PanelControl1.Controls.Add(Me.LabelControl10)
        Me.PanelControl1.Controls.Add(Me.LabelControl8)
        Me.PanelControl1.Controls.Add(Me.LabelControl9)
        Me.PanelControl1.Controls.Add(Me.LabelControl7)
        Me.PanelControl1.Controls.Add(Me.lueCommodity)
        Me.PanelControl1.Controls.Add(Me.luePackingType)
        Me.PanelControl1.Controls.Add(Me.lueCargoType)
        Me.PanelControl1.Controls.Add(Me.lueIncoterm)
        Me.PanelControl1.Controls.Add(Me.lueEquipmentType)
        Me.PanelControl1.Controls.Add(Me.lueDestinationPort)
        Me.PanelControl1.Controls.Add(Me.lueDestinationCountry)
        Me.PanelControl1.Controls.Add(Me.lueOriginPort)
        Me.PanelControl1.Controls.Add(Me.lueOriginCountry)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 41)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(823, 496)
        Me.PanelControl1.TabIndex = 4
        '
        'seVolume
        '
        Me.seVolume.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seVolume.Location = New System.Drawing.Point(135, 384)
        Me.seVolume.Name = "seVolume"
        Me.seVolume.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.seVolume.Size = New System.Drawing.Size(84, 20)
        Me.seVolume.TabIndex = 14
        '
        'seHeigth
        '
        Me.seHeigth.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seHeigth.Location = New System.Drawing.Point(135, 358)
        Me.seHeigth.Name = "seHeigth"
        Me.seHeigth.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.seHeigth.Size = New System.Drawing.Size(84, 20)
        Me.seHeigth.TabIndex = 13
        '
        'seWidth
        '
        Me.seWidth.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seWidth.Location = New System.Drawing.Point(135, 332)
        Me.seWidth.Name = "seWidth"
        Me.seWidth.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.seWidth.Size = New System.Drawing.Size(84, 20)
        Me.seWidth.TabIndex = 12
        '
        'seLarge
        '
        Me.seLarge.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seLarge.Location = New System.Drawing.Point(136, 306)
        Me.seLarge.Name = "seLarge"
        Me.seLarge.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.seLarge.Size = New System.Drawing.Size(84, 20)
        Me.seLarge.TabIndex = 11
        '
        'seWeight
        '
        Me.seWeight.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seWeight.Location = New System.Drawing.Point(135, 280)
        Me.seWeight.Name = "seWeight"
        Me.seWeight.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.seWeight.Size = New System.Drawing.Size(84, 20)
        Me.seWeight.TabIndex = 10
        '
        'seQuantity
        '
        Me.seQuantity.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seQuantity.Location = New System.Drawing.Point(136, 150)
        Me.seQuantity.MenuManager = Me.bmActions
        Me.seQuantity.Name = "seQuantity"
        Me.seQuantity.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.seQuantity.Size = New System.Drawing.Size(84, 20)
        Me.seQuantity.TabIndex = 5
        '
        'LabelControl20
        '
        Me.LabelControl20.Location = New System.Drawing.Point(90, 387)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl20.TabIndex = 29
        Me.LabelControl20.Text = "Volumen"
        '
        'LabelControl19
        '
        Me.LabelControl19.Location = New System.Drawing.Point(110, 361)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(19, 13)
        Me.LabelControl19.TabIndex = 30
        Me.LabelControl19.Text = "Alto"
        '
        'LabelControl18
        '
        Me.LabelControl18.Location = New System.Drawing.Point(99, 335)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(30, 13)
        Me.LabelControl18.TabIndex = 31
        Me.LabelControl18.Text = "Ancho"
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(103, 309)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl17.TabIndex = 32
        Me.LabelControl17.Text = "Largo"
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(106, 283)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl16.TabIndex = 33
        Me.LabelControl16.Text = "Peso"
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(76, 257)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl15.TabIndex = 34
        Me.LabelControl15.Text = "Mercadería"
        '
        'LabelControl23
        '
        Me.LabelControl23.Location = New System.Drawing.Point(48, 231)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(81, 13)
        Me.LabelControl23.TabIndex = 35
        Me.LabelControl23.Text = "Tipo de Embalaje"
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(63, 205)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl14.TabIndex = 36
        Me.LabelControl14.Text = "Tipo de Carga"
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(86, 179)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl13.TabIndex = 23
        Me.LabelControl13.Text = "Incoterm"
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(86, 153)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl12.TabIndex = 37
        Me.LabelControl12.Text = "Cantidad"
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(58, 126)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(71, 13)
        Me.LabelControl11.TabIndex = 28
        Me.LabelControl11.Text = "Tipo de Unidad"
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(43, 100)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(86, 13)
        Me.LabelControl10.TabIndex = 27
        Me.LabelControl10.Text = "Puerto de Destino"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(48, 48)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(82, 13)
        Me.LabelControl8.TabIndex = 26
        Me.LabelControl8.Text = "Puerto de Origen"
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(56, 74)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(73, 13)
        Me.LabelControl9.TabIndex = 25
        Me.LabelControl9.Text = "País de Destino"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(61, 22)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl7.TabIndex = 24
        Me.LabelControl7.Text = "País de Origen"
        '
        'lueCommodity
        '
        Me.lueCommodity.Location = New System.Drawing.Point(135, 254)
        Me.lueCommodity.Name = "lueCommodity"
        Me.lueCommodity.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lueCommodity.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueCommodity.Properties.NullText = ""
        Me.lueCommodity.Size = New System.Drawing.Size(283, 20)
        Me.lueCommodity.TabIndex = 9
        '
        'luePackingType
        '
        Me.luePackingType.Location = New System.Drawing.Point(135, 228)
        Me.luePackingType.Name = "luePackingType"
        Me.luePackingType.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.luePackingType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luePackingType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DescripcionTipoEmbalaje", "Tipo de Embalaje")})
        Me.luePackingType.Properties.NullText = ""
        Me.luePackingType.Size = New System.Drawing.Size(283, 20)
        Me.luePackingType.TabIndex = 8
        '
        'lueCargoType
        '
        Me.lueCargoType.Location = New System.Drawing.Point(135, 202)
        Me.lueCargoType.Name = "lueCargoType"
        Me.lueCargoType.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lueCargoType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueCargoType.Properties.NullText = ""
        Me.lueCargoType.Size = New System.Drawing.Size(283, 20)
        Me.lueCargoType.TabIndex = 7
        '
        'lueIncoterm
        '
        Me.lueIncoterm.Location = New System.Drawing.Point(135, 176)
        Me.lueIncoterm.Name = "lueIncoterm"
        Me.lueIncoterm.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lueIncoterm.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueIncoterm.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DescripcionIncoterm", "Incoterms")})
        Me.lueIncoterm.Properties.NullText = ""
        Me.lueIncoterm.Size = New System.Drawing.Size(283, 20)
        Me.lueIncoterm.TabIndex = 6
        '
        'lueEquipmentType
        '
        Me.lueEquipmentType.Location = New System.Drawing.Point(135, 123)
        Me.lueEquipmentType.Name = "lueEquipmentType"
        Me.lueEquipmentType.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lueEquipmentType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueEquipmentType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodigoTipoEquipo", "Código Equipo"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DescripcionTipoEquipo", "Descripción")})
        Me.lueEquipmentType.Properties.NullText = ""
        Me.lueEquipmentType.Size = New System.Drawing.Size(283, 20)
        Me.lueEquipmentType.TabIndex = 4
        '
        'lueDestinationPort
        '
        Me.lueDestinationPort.Location = New System.Drawing.Point(135, 97)
        Me.lueDestinationPort.Name = "lueDestinationPort"
        Me.lueDestinationPort.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lueDestinationPort.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueDestinationPort.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NombrePuerto", "Puerto")})
        Me.lueDestinationPort.Properties.NullText = ""
        Me.lueDestinationPort.Size = New System.Drawing.Size(283, 20)
        Me.lueDestinationPort.TabIndex = 3
        '
        'lueDestinationCountry
        '
        Me.lueDestinationCountry.Location = New System.Drawing.Point(135, 71)
        Me.lueDestinationCountry.Name = "lueDestinationCountry"
        Me.lueDestinationCountry.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lueDestinationCountry.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueDestinationCountry.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NombrePais", "País")})
        Me.lueDestinationCountry.Properties.NullText = ""
        Me.lueDestinationCountry.Size = New System.Drawing.Size(283, 20)
        Me.lueDestinationCountry.TabIndex = 2
        '
        'lueOriginPort
        '
        Me.lueOriginPort.Location = New System.Drawing.Point(135, 45)
        Me.lueOriginPort.Name = "lueOriginPort"
        Me.lueOriginPort.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lueOriginPort.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueOriginPort.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NombrePuerto", "Puerto")})
        Me.lueOriginPort.Properties.NullText = ""
        Me.lueOriginPort.Size = New System.Drawing.Size(283, 20)
        Me.lueOriginPort.TabIndex = 1
        '
        'lueOriginCountry
        '
        Me.lueOriginCountry.Location = New System.Drawing.Point(135, 19)
        Me.lueOriginCountry.Name = "lueOriginCountry"
        Me.lueOriginCountry.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lueOriginCountry.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueOriginCountry.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NombrePais", "País")})
        Me.lueOriginCountry.Properties.NullText = ""
        Me.lueOriginCountry.Size = New System.Drawing.Size(283, 20)
        Me.lueOriginCountry.TabIndex = 0
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
        'GetQuoteForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(823, 564)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.BarDockControl3)
        Me.Controls.Add(Me.BarDockControl4)
        Me.Controls.Add(Me.BarDockControl2)
        Me.Controls.Add(Me.BarDockControl1)
        Me.Name = "GetQuoteForm"
        Me.Text = "Consultar Cotización"
        CType(Me.vpInputs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bmActions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpiProceso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.seVolume.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seHeigth.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seWidth.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seLarge.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seWeight.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seQuantity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueCommodity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luePackingType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueCargoType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueIncoterm.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueEquipmentType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueDestinationPort.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueDestinationCountry.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueOriginPort.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueOriginCountry.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reResult.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents brBarraAcciones As DevExpress.XtraBars.Bar
    Private WithEvents bbiGetQuote As DevExpress.XtraBars.BarButtonItem
    Private WithEvents bbiClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents vpInputs As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Private WithEvents bmActions As DevExpress.XtraBars.BarManager
    Private WithEvents bar5 As DevExpress.XtraBars.Bar
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
    Friend WithEvents seVolume As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents seHeigth As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents seWidth As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents seLarge As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents seWeight As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents seQuantity As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lueCommodity As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents luePackingType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueCargoType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueIncoterm As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueEquipmentType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueDestinationPort As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueDestinationCountry As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueOriginPort As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueOriginCountry As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents reResult As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class

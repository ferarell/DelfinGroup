<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImpresionFacturasForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImpresionFacturasForm))
        Me.luePartner = New DevExpress.XtraEditors.LookUpEdit()
        Me.deDate = New DevExpress.XtraEditors.DateEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RepositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.rpiProceso = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiReset = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiLetras = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiCartaNotarial = New DevExpress.XtraBars.BarButtonItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bbiCronograma = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiTarjeta = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiVistaGrilla = New DevExpress.XtraBars.BarButtonItem()
        Me.bsiVistas = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarDockControl3 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl4 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.bbiClose = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiPrint = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiProcess = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiContrato = New DevExpress.XtraBars.BarButtonItem()
        Me.brsDescripcion = New DevExpress.XtraBars.BarStaticItem()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.brBarraAcciones = New DevExpress.XtraBars.Bar()
        Me.bar5 = New DevExpress.XtraBars.Bar()
        Me.vpInputs = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.imActionsBar24x24 = New System.Windows.Forms.ImageList(Me.components)
        Me.bmActions = New DevExpress.XtraBars.BarManager(Me.components)
        Me.lueCompany = New DevExpress.XtraEditors.LookUpEdit()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.gcItems = New DevExpress.XtraGrid.GridControl()
        Me.imNavigation = New System.Windows.Forms.ImageList(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Descripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.Importe = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lueAddress = New DevExpress.XtraEditors.LookUpEdit()
        Me.rgFormat = New DevExpress.XtraEditors.RadioGroup()
        Me.rgCurrency = New DevExpress.XtraEditors.RadioGroup()
        Me.CrystalReportViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        CType(Me.luePartner.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpiProceso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vpInputs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bmActions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueCompany.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.gcItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.lueAddress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgFormat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgCurrency.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'luePartner
        '
        Me.luePartner.Location = New System.Drawing.Point(67, 79)
        Me.luePartner.Margin = New System.Windows.Forms.Padding(2)
        Me.luePartner.Name = "luePartner"
        Me.luePartner.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luePartner.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "Código"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", 120, "Descripción"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ruc", "RUC")})
        Me.luePartner.Properties.NullText = ""
        Me.luePartner.Size = New System.Drawing.Size(299, 20)
        Me.luePartner.TabIndex = 2
        '
        'deDate
        '
        Me.deDate.EditValue = Nothing
        Me.deDate.Location = New System.Drawing.Point(67, 55)
        Me.deDate.Margin = New System.Windows.Forms.Padding(2)
        Me.deDate.Name = "deDate"
        Me.deDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.deDate.Size = New System.Drawing.Size(98, 20)
        Me.deDate.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 58)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Fecha"
        '
        'RepositoryItemImageComboBox1
        '
        Me.RepositoryItemImageComboBox1.AutoHeight = False
        Me.RepositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(), New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemImageComboBox1.Name = "RepositoryItemImageComboBox1"
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        '
        'rpiProceso
        '
        Me.rpiProceso.Name = "rpiProceso"
        Me.rpiProceso.ShowTitle = True
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "BarButtonItem5"
        Me.BarButtonItem5.Id = 24
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'bbiReset
        '
        Me.bbiReset.Caption = "&Reset"
        Me.bbiReset.Glyph = CType(resources.GetObject("bbiReset.Glyph"), System.Drawing.Image)
        Me.bbiReset.Id = 20
        Me.bbiReset.Name = "bbiReset"
        '
        'bbiLetras
        '
        Me.bbiLetras.Caption = "Letras de Cambio"
        Me.bbiLetras.Id = 16
        Me.bbiLetras.Name = "bbiLetras"
        '
        'bbiCartaNotarial
        '
        Me.bbiCartaNotarial.Caption = "Carta Notarial"
        Me.bbiCartaNotarial.Id = 15
        Me.bbiCartaNotarial.Name = "bbiCartaNotarial"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Empresa"
        '
        'bbiCronograma
        '
        Me.bbiCronograma.Caption = "Cronograma de Pagos"
        Me.bbiCronograma.Id = 14
        Me.bbiCronograma.Name = "bbiCronograma"
        '
        'bbiTarjeta
        '
        Me.bbiTarjeta.Caption = "Tarjeta"
        Me.bbiTarjeta.Id = 8
        Me.bbiTarjeta.ImageIndex = 21
        Me.bbiTarjeta.Name = "bbiTarjeta"
        '
        'bbiVistaGrilla
        '
        Me.bbiVistaGrilla.Caption = "Grilla"
        Me.bbiVistaGrilla.Id = 7
        Me.bbiVistaGrilla.ImageIndex = 23
        Me.bbiVistaGrilla.Name = "bbiVistaGrilla"
        '
        'bsiVistas
        '
        Me.bsiVistas.Caption = "Vistas"
        Me.bsiVistas.Id = 6
        Me.bsiVistas.ImageIndex = 20
        Me.bsiVistas.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbiVistaGrilla), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiTarjeta)})
        Me.bsiVistas.Name = "bsiVistas"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Vista"
        Me.BarButtonItem1.Id = 3
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarDockControl3
        '
        Me.BarDockControl3.CausesValidation = False
        Me.BarDockControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl3.Location = New System.Drawing.Point(0, 47)
        Me.BarDockControl3.Size = New System.Drawing.Size(0, 376)
        '
        'BarDockControl4
        '
        Me.BarDockControl4.CausesValidation = False
        Me.BarDockControl4.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl4.Location = New System.Drawing.Point(859, 47)
        Me.BarDockControl4.Size = New System.Drawing.Size(0, 376)
        '
        'BarDockControl2
        '
        Me.BarDockControl2.CausesValidation = False
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl2.Location = New System.Drawing.Point(0, 423)
        Me.BarDockControl2.Size = New System.Drawing.Size(859, 29)
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl1.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl1.Size = New System.Drawing.Size(859, 47)
        '
        'bbiClose
        '
        Me.bbiClose.Caption = "&Cerrar"
        Me.bbiClose.Glyph = CType(resources.GetObject("bbiClose.Glyph"), System.Drawing.Image)
        Me.bbiClose.Id = 41
        Me.bbiClose.ImageIndex = 27
        Me.bbiClose.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.C))
        Me.bbiClose.LargeImageIndex = 0
        Me.bbiClose.Name = "bbiClose"
        Me.bbiClose.ShortcutKeyDisplayString = "Ctrl+C"
        '
        'bbiPrint
        '
        Me.bbiPrint.Caption = "&Preliminar"
        Me.bbiPrint.Glyph = CType(resources.GetObject("bbiPrint.Glyph"), System.Drawing.Image)
        Me.bbiPrint.Id = 23
        Me.bbiPrint.Name = "bbiPrint"
        '
        'bbiProcess
        '
        Me.bbiProcess.Caption = "&Procesar"
        Me.bbiProcess.Glyph = CType(resources.GetObject("bbiProcess.Glyph"), System.Drawing.Image)
        Me.bbiProcess.Id = 33
        Me.bbiProcess.ImageIndex = 28
        Me.bbiProcess.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.G))
        Me.bbiProcess.LargeImageIndex = 7
        Me.bbiProcess.Name = "bbiProcess"
        Me.bbiProcess.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'bbiContrato
        '
        Me.bbiContrato.Caption = "Contrato Compra-Venta"
        Me.bbiContrato.Id = 13
        Me.bbiContrato.Name = "bbiContrato"
        '
        'brsDescripcion
        '
        Me.brsDescripcion.Id = 30
        Me.brsDescripcion.Name = "brsDescripcion"
        Me.brsDescripcion.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 82)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Cliente"
        '
        'brBarraAcciones
        '
        Me.brBarraAcciones.BarName = "Custom 5"
        Me.brBarraAcciones.DockCol = 0
        Me.brBarraAcciones.DockRow = 0
        Me.brBarraAcciones.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.brBarraAcciones.FloatLocation = New System.Drawing.Point(279, 188)
        Me.brBarraAcciones.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bbiProcess, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bbiPrint, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bbiClose, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.brBarraAcciones.OptionsBar.AllowQuickCustomization = False
        Me.brBarraAcciones.OptionsBar.UseWholeRow = True
        Me.brBarraAcciones.Text = "Custom 5"
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
        'vpInputs
        '
        Me.vpInputs.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual
        '
        'imActionsBar24x24
        '
        Me.imActionsBar24x24.ImageStream = CType(resources.GetObject("imActionsBar24x24.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imActionsBar24x24.TransparentColor = System.Drawing.Color.Transparent
        Me.imActionsBar24x24.Images.SetKeyName(0, "ic_save.png")
        Me.imActionsBar24x24.Images.SetKeyName(1, "ic_edit.png")
        Me.imActionsBar24x24.Images.SetKeyName(2, "ic_new.png")
        Me.imActionsBar24x24.Images.SetKeyName(3, "ic_copy.png")
        Me.imActionsBar24x24.Images.SetKeyName(4, "ic_delete2.png")
        Me.imActionsBar24x24.Images.SetKeyName(5, "ic_print.png")
        Me.imActionsBar24x24.Images.SetKeyName(6, "ic_search2.png")
        Me.imActionsBar24x24.Images.SetKeyName(7, "ic_search3.png")
        Me.imActionsBar24x24.Images.SetKeyName(8, "ic_undo.png")
        Me.imActionsBar24x24.Images.SetKeyName(9, "ic_close.png")
        Me.imActionsBar24x24.Images.SetKeyName(10, "ic_save.png")
        Me.imActionsBar24x24.Images.SetKeyName(11, "ic_search2.png")
        Me.imActionsBar24x24.Images.SetKeyName(12, "ic_print.png")
        Me.imActionsBar24x24.Images.SetKeyName(13, "ic_search3.png")
        Me.imActionsBar24x24.Images.SetKeyName(14, "ic_mntTablas16x16.png")
        Me.imActionsBar24x24.Images.SetKeyName(15, "ic_first16x16.png")
        Me.imActionsBar24x24.Images.SetKeyName(16, "ic_previus16x16.png")
        Me.imActionsBar24x24.Images.SetKeyName(17, "ic_next16x16.png")
        Me.imActionsBar24x24.Images.SetKeyName(18, "ic_last16x16.png")
        Me.imActionsBar24x24.Images.SetKeyName(19, "ic_excel16x16.png")
        Me.imActionsBar24x24.Images.SetKeyName(20, "ci_views16x16.png")
        Me.imActionsBar24x24.Images.SetKeyName(21, "ic_cardview16x16.png")
        Me.imActionsBar24x24.Images.SetKeyName(22, "ic_carouselview16x16.png")
        Me.imActionsBar24x24.Images.SetKeyName(23, "ic_gridview16x16.png")
        Me.imActionsBar24x24.Images.SetKeyName(24, "Excel.ico")
        Me.imActionsBar24x24.Images.SetKeyName(25, "previmg.png")
        Me.imActionsBar24x24.Images.SetKeyName(26, "Pinion.png")
        Me.imActionsBar24x24.Images.SetKeyName(27, "Close.png")
        Me.imActionsBar24x24.Images.SetKeyName(28, "Save.png")
        '
        'bmActions
        '
        Me.bmActions.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.bar5, Me.brBarraAcciones})
        Me.bmActions.DockControls.Add(Me.BarDockControl1)
        Me.bmActions.DockControls.Add(Me.BarDockControl2)
        Me.bmActions.DockControls.Add(Me.BarDockControl3)
        Me.bmActions.DockControls.Add(Me.BarDockControl4)
        Me.bmActions.Form = Me
        Me.bmActions.Images = Me.imActionsBar24x24
        Me.bmActions.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.brsDescripcion, Me.bbiProcess, Me.bbiClose, Me.BarButtonItem1, Me.bsiVistas, Me.bbiVistaGrilla, Me.bbiTarjeta, Me.bbiContrato, Me.bbiCronograma, Me.bbiCartaNotarial, Me.bbiLetras, Me.bbiReset, Me.bbiPrint, Me.BarButtonItem5})
        Me.bmActions.MaxItemId = 25
        Me.bmActions.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpiProceso, Me.RepositoryItemLookUpEdit1, Me.RepositoryItemImageComboBox1})
        '
        'lueCompany
        '
        Me.lueCompany.Location = New System.Drawing.Point(67, 31)
        Me.lueCompany.Margin = New System.Windows.Forms.Padding(2)
        Me.lueCompany.Name = "lueCompany"
        Me.lueCompany.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueCompany.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyID", "Empresa"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyName", 60, "Descripción"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DocumentID", "RUC"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AppCode", "AppCode", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default])})
        Me.lueCompany.Properties.NullText = ""
        Me.lueCompany.Size = New System.Drawing.Size(245, 20)
        Me.lueCompany.TabIndex = 0
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 47)
        Me.SplitContainerControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.GroupControl2)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.GroupControl1)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.CrystalReportViewer)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(859, 376)
        Me.SplitContainerControl1.SplitterPosition = 386
        Me.SplitContainerControl1.TabIndex = 4
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'GroupControl2
        '
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.AppearanceCaption.Options.UseTextOptions = True
        Me.GroupControl2.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GroupControl2.Controls.Add(Me.gcItems)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 173)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(382, 199)
        Me.GroupControl2.TabIndex = 0
        Me.GroupControl2.Text = "Detalle"
        '
        'gcItems
        '
        Me.gcItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcItems.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.gcItems.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.gcItems.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.gcItems.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.gcItems.EmbeddedNavigator.Buttons.First.Visible = False
        Me.gcItems.EmbeddedNavigator.Buttons.ImageList = Me.imNavigation
        Me.gcItems.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.gcItems.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.gcItems.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.gcItems.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.gcItems.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.gcItems.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.gcItems.EmbeddedNavigator.CustomButtons.AddRange(New DevExpress.XtraEditors.NavigatorCustomButton() {New DevExpress.XtraEditors.NavigatorCustomButton(0, 0, True, True, "Inserta Fila", "0"), New DevExpress.XtraEditors.NavigatorCustomButton(1, 1, True, True, "Elimina Fila", "1")})
        Me.gcItems.Location = New System.Drawing.Point(2, 21)
        Me.gcItems.MainView = Me.GridView1
        Me.gcItems.MenuManager = Me.bmActions
        Me.gcItems.Name = "gcItems"
        Me.gcItems.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2})
        Me.gcItems.Size = New System.Drawing.Size(378, 176)
        Me.gcItems.TabIndex = 0
        Me.gcItems.UseEmbeddedNavigator = True
        Me.gcItems.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'imNavigation
        '
        Me.imNavigation.ImageStream = CType(resources.GetObject("imNavigation.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imNavigation.TransparentColor = System.Drawing.Color.Transparent
        Me.imNavigation.Images.SetKeyName(0, "Add_16x16.png")
        Me.imNavigation.Images.SetKeyName(1, "Delete_16x16.png")
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Descripcion, Me.Importe})
        Me.GridView1.GridControl = Me.gcItems
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsCustomization.AllowColumnMoving = False
        Me.GridView1.OptionsCustomization.AllowColumnResizing = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsCustomization.AllowSort = False
        Me.GridView1.OptionsFilter.AllowFilterEditor = False
        Me.GridView1.OptionsNavigation.AutoFocusNewRow = True
        Me.GridView1.OptionsNavigation.EnterMoveNextColumn = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'Descripcion
        '
        Me.Descripcion.Caption = "Descripción"
        Me.Descripcion.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.Descripcion.FieldName = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Visible = True
        Me.Descripcion.VisibleIndex = 0
        Me.Descripcion.Width = 267
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        Me.RepositoryItemTextEdit1.ValidateOnEnterKey = True
        '
        'Importe
        '
        Me.Importe.Caption = "Importe (Venta)"
        Me.Importe.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.Importe.DisplayFormat.FormatString = "###,###,##0.00"
        Me.Importe.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Importe.FieldName = "Importe"
        Me.Importe.Name = "Importe"
        Me.Importe.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Importe", "{0:n2}")})
        Me.Importe.Visible = True
        Me.Importe.VisibleIndex = 1
        Me.Importe.Width = 89
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.DisplayFormat.FormatString = "###,###,##0.00"
        Me.RepositoryItemTextEdit2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit2.EditFormat.FormatString = "###,###,##0.00"
        Me.RepositoryItemTextEdit2.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.AppearanceCaption.Options.UseTextOptions = True
        Me.GroupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.lueAddress)
        Me.GroupControl1.Controls.Add(Me.rgFormat)
        Me.GroupControl1.Controls.Add(Me.rgCurrency)
        Me.GroupControl1.Controls.Add(Me.lueCompany)
        Me.GroupControl1.Controls.Add(Me.Label5)
        Me.GroupControl1.Controls.Add(Me.luePartner)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.deDate)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(382, 173)
        Me.GroupControl1.TabIndex = 32
        Me.GroupControl1.Text = "Cabecera"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 106)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Dirección"
        '
        'lueAddress
        '
        Me.lueAddress.Location = New System.Drawing.Point(67, 103)
        Me.lueAddress.Margin = New System.Windows.Forms.Padding(2)
        Me.lueAddress.Name = "lueAddress"
        Me.lueAddress.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueAddress.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("address", "Dirección")})
        Me.lueAddress.Properties.NullText = ""
        Me.lueAddress.Size = New System.Drawing.Size(299, 20)
        Me.lueAddress.TabIndex = 3
        '
        'rgFormat
        '
        Me.rgFormat.EditValue = "F"
        Me.rgFormat.Location = New System.Drawing.Point(223, 132)
        Me.rgFormat.Margin = New System.Windows.Forms.Padding(2)
        Me.rgFormat.Name = "rgFormat"
        Me.rgFormat.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.rgFormat.Properties.Appearance.Options.UseBackColor = True
        Me.rgFormat.Properties.Columns = 3
        Me.rgFormat.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("F", "Factura"), New DevExpress.XtraEditors.Controls.RadioGroupItem("B", "Boleta")})
        Me.rgFormat.Size = New System.Drawing.Size(143, 29)
        Me.rgFormat.TabIndex = 5
        '
        'rgCurrency
        '
        Me.rgCurrency.EditValue = "S/."
        Me.rgCurrency.Location = New System.Drawing.Point(67, 132)
        Me.rgCurrency.Margin = New System.Windows.Forms.Padding(2)
        Me.rgCurrency.Name = "rgCurrency"
        Me.rgCurrency.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.rgCurrency.Properties.Appearance.Options.UseBackColor = True
        Me.rgCurrency.Properties.Columns = 3
        Me.rgCurrency.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("S/", "Soles"), New DevExpress.XtraEditors.Controls.RadioGroupItem("US$", "Dólares")})
        Me.rgCurrency.Size = New System.Drawing.Size(143, 29)
        Me.rgCurrency.TabIndex = 4
        '
        'CrystalReportViewer
        '
        Me.CrystalReportViewer.ActiveViewIndex = -1
        Me.CrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer.EnableRefresh = False
        Me.CrystalReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer.Margin = New System.Windows.Forms.Padding(2)
        Me.CrystalReportViewer.Name = "CrystalReportViewer"
        Me.CrystalReportViewer.ReuseParameterValuesOnRefresh = True
        Me.CrystalReportViewer.ShowGroupTreeButton = False
        Me.CrystalReportViewer.ShowParameterPanelButton = False
        Me.CrystalReportViewer.ShowRefreshButton = False
        Me.CrystalReportViewer.Size = New System.Drawing.Size(468, 376)
        Me.CrystalReportViewer.TabIndex = 1
        Me.CrystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'ImpresionFacturasForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 452)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.BarDockControl3)
        Me.Controls.Add(Me.BarDockControl4)
        Me.Controls.Add(Me.BarDockControl2)
        Me.Controls.Add(Me.BarDockControl1)
        Me.Name = "ImpresionFacturasForm"
        Me.Text = "Impresión de Facturas"
        CType(Me.luePartner.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpiProceso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vpInputs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bmActions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueCompany.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.gcItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.lueAddress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgFormat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgCurrency.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents luePartner As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents deDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents RepositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Private WithEvents rpiProceso As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiReset As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiLetras As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiCartaNotarial As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bbiCronograma As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiTarjeta As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiVistaGrilla As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bsiVistas As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Private WithEvents BarDockControl3 As DevExpress.XtraBars.BarDockControl
    Private WithEvents BarDockControl4 As DevExpress.XtraBars.BarDockControl
    Private WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
    Private WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Private WithEvents bbiClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiPrint As DevExpress.XtraBars.BarButtonItem
    Private WithEvents bbiProcess As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiContrato As DevExpress.XtraBars.BarButtonItem
    Private WithEvents brsDescripcion As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents brBarraAcciones As DevExpress.XtraBars.Bar
    Private WithEvents bar5 As DevExpress.XtraBars.Bar
    Friend WithEvents vpInputs As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Private WithEvents imActionsBar24x24 As System.Windows.Forms.ImageList
    Private WithEvents bmActions As DevExpress.XtraBars.BarManager
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents lueCompany As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gcItems As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Descripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Importe As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents rgCurrency As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lueAddress As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents imNavigation As System.Windows.Forms.ImageList
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents CrystalReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents rgFormat As DevExpress.XtraEditors.RadioGroup
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TariffForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TariffForm))
        Me.bmActions = New DevExpress.XtraBars.BarManager(Me.components)
        Me.bar5 = New DevExpress.XtraBars.Bar()
        Me.brsDescripcion = New DevExpress.XtraBars.BarStaticItem()
        Me.brBarraAcciones = New DevExpress.XtraBars.Bar()
        Me.bbiInsert = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiEdit = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiSave = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiRefresh = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiCopy = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiExport = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiClose = New DevExpress.XtraBars.BarButtonItem()
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl3 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl4 = New DevExpress.XtraBars.BarDockControl()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.bsiVistas = New DevExpress.XtraBars.BarSubItem()
        Me.bbiVistaGrilla = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiTarjeta = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiContrato = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiCronograma = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiCartaNotarial = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiLetras = New DevExpress.XtraBars.BarButtonItem()
        Me.rpiProceso = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
        Me.vpInputs = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.ucAuditPanel = New ApplicationForm.ucAuditPanel()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.meRemarks = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.dtpDe = New System.Windows.Forms.DateTimePicker()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.lueLayout = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.lueTipoTarifa = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.lueMoneda = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueEstado = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.gcUnidades = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rilueConcepto = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rilueUnidad = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rilueMoneda = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemImageEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageEdit()
        Me.rilud = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.gcMainDataTariff = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckedComboBoxEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.LayoutView1 = New DevExpress.XtraGrid.Views.Layout.LayoutView()
        Me.LayoutViewCard1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard()
        Me.CardView1 = New DevExpress.XtraGrid.Views.Card.CardView()
        CType(Me.bmActions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpiProceso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vpInputs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.meRemarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueLayout.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueTipoTarifa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueMoneda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueEstado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcUnidades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rilueConcepto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rilueUnidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rilueMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemImageEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rilud, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcMainDataTariff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckedComboBoxEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutViewCard1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CardView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bmActions
        '
        Me.bmActions.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.bar5, Me.brBarraAcciones})
        Me.bmActions.DockControls.Add(Me.BarDockControl1)
        Me.bmActions.DockControls.Add(Me.BarDockControl2)
        Me.bmActions.DockControls.Add(Me.BarDockControl3)
        Me.bmActions.DockControls.Add(Me.BarDockControl4)
        Me.bmActions.Form = Me
        Me.bmActions.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.brsDescripcion, Me.bbiClose, Me.BarButtonItem1, Me.bsiVistas, Me.bbiVistaGrilla, Me.bbiTarjeta, Me.bbiContrato, Me.bbiCronograma, Me.bbiCartaNotarial, Me.bbiLetras, Me.bbiInsert, Me.bbiEdit, Me.bbiDelete, Me.bbiSave, Me.bbiExport, Me.bbiRefresh, Me.bbiCopy})
        Me.bmActions.MaxItemId = 30
        Me.bmActions.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpiProceso, Me.RepositoryItemLookUpEdit1, Me.RepositoryItemImageComboBox1})
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
        'brBarraAcciones
        '
        Me.brBarraAcciones.BarName = "Custom 5"
        Me.brBarraAcciones.DockCol = 0
        Me.brBarraAcciones.DockRow = 0
        Me.brBarraAcciones.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.brBarraAcciones.FloatLocation = New System.Drawing.Point(279, 188)
        Me.brBarraAcciones.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bbiInsert, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bbiEdit, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bbiDelete, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bbiSave, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bbiRefresh, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bbiCopy, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bbiExport, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bbiClose, "", True, True, False, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.brBarraAcciones.OptionsBar.AllowQuickCustomization = False
        Me.brBarraAcciones.OptionsBar.UseWholeRow = True
        Me.brBarraAcciones.Text = "Custom 5"
        '
        'bbiInsert
        '
        Me.bbiInsert.Caption = "&Nuevo"
        Me.bbiInsert.Id = 21
        Me.bbiInsert.ImageOptions.Image = CType(resources.GetObject("bbiInsert.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiInsert.Name = "bbiInsert"
        Me.bbiInsert.Tag = "0"
        '
        'bbiEdit
        '
        Me.bbiEdit.Caption = "&Editar"
        Me.bbiEdit.Id = 24
        Me.bbiEdit.ImageOptions.Image = CType(resources.GetObject("bbiEdit.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiEdit.Name = "bbiEdit"
        Me.bbiEdit.Tag = "0"
        '
        'bbiDelete
        '
        Me.bbiDelete.Caption = "E&liminar"
        Me.bbiDelete.Id = 25
        Me.bbiDelete.ImageOptions.Image = CType(resources.GetObject("bbiDelete.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiDelete.Name = "bbiDelete"
        Me.bbiDelete.Tag = "1"
        '
        'bbiSave
        '
        Me.bbiSave.Caption = "&Guardar"
        Me.bbiSave.Id = 26
        Me.bbiSave.ImageOptions.Image = CType(resources.GetObject("bbiSave.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiSave.Name = "bbiSave"
        Me.bbiSave.Tag = "2"
        '
        'bbiRefresh
        '
        Me.bbiRefresh.Caption = "&Refrescar"
        Me.bbiRefresh.Id = 28
        Me.bbiRefresh.ImageOptions.Image = CType(resources.GetObject("bbiRefresh.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiRefresh.Name = "bbiRefresh"
        '
        'bbiCopy
        '
        Me.bbiCopy.Caption = "&Copiar"
        Me.bbiCopy.Id = 29
        Me.bbiCopy.ImageOptions.Image = CType(resources.GetObject("bbiCopy.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiCopy.ImageOptions.LargeImage = CType(resources.GetObject("bbiCopy.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.bbiCopy.Name = "bbiCopy"
        '
        'bbiExport
        '
        Me.bbiExport.Caption = "E&xportar"
        Me.bbiExport.Id = 27
        Me.bbiExport.ImageOptions.Image = CType(resources.GetObject("bbiExport.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiExport.Name = "bbiExport"
        Me.bbiExport.Tag = "1"
        '
        'bbiClose
        '
        Me.bbiClose.Caption = "&Cerrar"
        Me.bbiClose.Id = 41
        Me.bbiClose.ImageOptions.Image = CType(resources.GetObject("bbiClose.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiClose.ImageOptions.ImageIndex = 27
        Me.bbiClose.ImageOptions.LargeImageIndex = 0
        Me.bbiClose.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.C))
        Me.bbiClose.Name = "bbiClose"
        Me.bbiClose.ShortcutKeyDisplayString = "Ctrl+C"
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl1.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl1.Manager = Me.bmActions
        Me.BarDockControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BarDockControl1.Size = New System.Drawing.Size(1085, 57)
        '
        'BarDockControl2
        '
        Me.BarDockControl2.CausesValidation = False
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl2.Location = New System.Drawing.Point(0, 609)
        Me.BarDockControl2.Manager = Me.bmActions
        Me.BarDockControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BarDockControl2.Size = New System.Drawing.Size(1085, 36)
        '
        'BarDockControl3
        '
        Me.BarDockControl3.CausesValidation = False
        Me.BarDockControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl3.Location = New System.Drawing.Point(0, 57)
        Me.BarDockControl3.Manager = Me.bmActions
        Me.BarDockControl3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BarDockControl3.Size = New System.Drawing.Size(0, 552)
        '
        'BarDockControl4
        '
        Me.BarDockControl4.CausesValidation = False
        Me.BarDockControl4.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl4.Location = New System.Drawing.Point(1085, 57)
        Me.BarDockControl4.Manager = Me.bmActions
        Me.BarDockControl4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BarDockControl4.Size = New System.Drawing.Size(0, 552)
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Vista"
        Me.BarButtonItem1.Id = 3
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'bsiVistas
        '
        Me.bsiVistas.Caption = "Vistas"
        Me.bsiVistas.Id = 6
        Me.bsiVistas.ImageOptions.ImageIndex = 20
        Me.bsiVistas.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbiVistaGrilla), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiTarjeta)})
        Me.bsiVistas.Name = "bsiVistas"
        '
        'bbiVistaGrilla
        '
        Me.bbiVistaGrilla.Caption = "Grilla"
        Me.bbiVistaGrilla.Id = 7
        Me.bbiVistaGrilla.ImageOptions.ImageIndex = 23
        Me.bbiVistaGrilla.Name = "bbiVistaGrilla"
        '
        'bbiTarjeta
        '
        Me.bbiTarjeta.Caption = "Tarjeta"
        Me.bbiTarjeta.Id = 8
        Me.bbiTarjeta.ImageOptions.ImageIndex = 21
        Me.bbiTarjeta.Name = "bbiTarjeta"
        '
        'bbiContrato
        '
        Me.bbiContrato.Caption = "Contrato Compra-Venta"
        Me.bbiContrato.Id = 13
        Me.bbiContrato.Name = "bbiContrato"
        '
        'bbiCronograma
        '
        Me.bbiCronograma.Caption = "Cronograma de Pagos"
        Me.bbiCronograma.Id = 14
        Me.bbiCronograma.Name = "bbiCronograma"
        '
        'bbiCartaNotarial
        '
        Me.bbiCartaNotarial.Caption = "Carta Notarial"
        Me.bbiCartaNotarial.Id = 15
        Me.bbiCartaNotarial.Name = "bbiCartaNotarial"
        '
        'bbiLetras
        '
        Me.bbiLetras.Caption = "Letras de Cambio"
        Me.bbiLetras.Id = 16
        Me.bbiLetras.Name = "bbiLetras"
        '
        'rpiProceso
        '
        Me.rpiProceso.Name = "rpiProceso"
        Me.rpiProceso.ShowTitle = True
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        '
        'RepositoryItemImageComboBox1
        '
        Me.RepositoryItemImageComboBox1.AutoHeight = False
        Me.RepositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(), New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemImageComboBox1.Name = "RepositoryItemImageComboBox1"
        '
        'vpInputs
        '
        Me.vpInputs.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual
        '
        'ucAuditPanel
        '
        Me.ucAuditPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ucAuditPanel.FechaCreacion = New Date(CType(0, Long))
        Me.ucAuditPanel.FechaModificacion = New Date(CType(0, Long))
        Me.ucAuditPanel.Location = New System.Drawing.Point(0, 563)
        Me.ucAuditPanel.Margin = New System.Windows.Forms.Padding(5)
        Me.ucAuditPanel.Name = "ucAuditPanel"
        Me.ucAuditPanel.Size = New System.Drawing.Size(1085, 46)
        Me.ucAuditPanel.TabIndex = 4
        Me.ucAuditPanel.UsuarioCreacion = Nothing
        Me.ucAuditPanel.UsuarioModificacion = Nothing
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 57)
        Me.SplitContainerControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.SplitContainer1)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.gcMainDataTariff)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1085, 506)
        Me.SplitContainerControl1.SplitterPosition = 524
        Me.SplitContainerControl1.TabIndex = 5
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.meRemarks)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LabelControl6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dtpHasta)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LabelControl5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dtpDe)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LabelControl4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lueLayout)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LabelControl7)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lueTipoTarifa)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LabelControl1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lueMoneda)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lueEstado)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LabelControl9)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LabelControl2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.gcUnidades)
        Me.SplitContainer1.Size = New System.Drawing.Size(520, 502)
        Me.SplitContainer1.SplitterDistance = 240
        Me.SplitContainer1.SplitterWidth = 5
        Me.SplitContainer1.TabIndex = 80
        '
        'meRemarks
        '
        Me.meRemarks.Location = New System.Drawing.Point(146, 158)
        Me.meRemarks.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.meRemarks.MenuManager = Me.bmActions
        Me.meRemarks.Name = "meRemarks"
        Me.meRemarks.Size = New System.Drawing.Size(264, 64)
        Me.meRemarks.TabIndex = 105
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(65, 161)
        Me.LabelControl6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(65, 16)
        Me.LabelControl6.TabIndex = 104
        Me.LabelControl6.Text = "Descripción"
        '
        'dtpHasta
        '
        Me.dtpHasta.Location = New System.Drawing.Point(147, 126)
        Me.dtpHasta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(263, 23)
        Me.dtpHasta.TabIndex = 103
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(99, 132)
        Me.LabelControl5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(32, 16)
        Me.LabelControl5.TabIndex = 102
        Me.LabelControl5.Text = "Hasta"
        '
        'dtpDe
        '
        Me.dtpDe.Location = New System.Drawing.Point(147, 95)
        Me.dtpDe.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpDe.Name = "dtpDe"
        Me.dtpDe.Size = New System.Drawing.Size(263, 23)
        Me.dtpDe.TabIndex = 101
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(115, 103)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(15, 16)
        Me.LabelControl4.TabIndex = 100
        Me.LabelControl4.Text = "De"
        '
        'lueLayout
        '
        Me.lueLayout.Location = New System.Drawing.Point(146, 39)
        Me.lueLayout.Margin = New System.Windows.Forms.Padding(2)
        Me.lueLayout.Name = "lueLayout"
        Me.lueLayout.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.lueLayout.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueLayout.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdLayout", "ID", 15, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("LayoutCode", "Codigo", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("LayoutDescription", "Descripción")})
        Me.lueLayout.Properties.NullText = ""
        Me.lueLayout.Size = New System.Drawing.Size(265, 22)
        Me.lueLayout.TabIndex = 99
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(89, 43)
        Me.LabelControl7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(44, 16)
        Me.LabelControl7.TabIndex = 98
        Me.LabelControl7.Text = "Plantilla"
        '
        'lueTipoTarifa
        '
        Me.lueTipoTarifa.Location = New System.Drawing.Point(146, 11)
        Me.lueTipoTarifa.Margin = New System.Windows.Forms.Padding(2)
        Me.lueTipoTarifa.Name = "lueTipoTarifa"
        Me.lueTipoTarifa.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.lueTipoTarifa.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueTipoTarifa.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TIPO_CodTipo", "Codigo", 15, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TIPO_Desc1", "Descripcion")})
        Me.lueTipoTarifa.Properties.NullText = ""
        Me.lueTipoTarifa.Size = New System.Drawing.Size(265, 22)
        Me.lueTipoTarifa.TabIndex = 92
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(71, 15)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(63, 16)
        Me.LabelControl1.TabIndex = 91
        Me.LabelControl1.Text = "Tipo Tarifa"
        '
        'lueMoneda
        '
        Me.lueMoneda.Location = New System.Drawing.Point(147, 228)
        Me.lueMoneda.Margin = New System.Windows.Forms.Padding(2)
        Me.lueMoneda.Name = "lueMoneda"
        Me.lueMoneda.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.lueMoneda.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueMoneda.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TIPO_CodTipo", "Codigo", 15, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TIPO_Desc1", "Descripcion")})
        Me.lueMoneda.Properties.NullText = ""
        Me.lueMoneda.Size = New System.Drawing.Size(265, 22)
        Me.lueMoneda.TabIndex = 90
        Me.lueMoneda.Visible = False
        '
        'lueEstado
        '
        Me.lueEstado.Location = New System.Drawing.Point(146, 66)
        Me.lueEstado.Margin = New System.Windows.Forms.Padding(2)
        Me.lueEstado.Name = "lueEstado"
        Me.lueEstado.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.lueEstado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueEstado.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TIPO_CodTipo", "Codigo", 15, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TIPO_Desc1", "Descripcion")})
        Me.lueEstado.Properties.NullText = ""
        Me.lueEstado.Size = New System.Drawing.Size(265, 22)
        Me.lueEstado.TabIndex = 89
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(94, 231)
        Me.LabelControl9.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(45, 16)
        Me.LabelControl9.TabIndex = 88
        Me.LabelControl9.Text = "Moneda"
        Me.LabelControl9.Visible = False
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(98, 71)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(38, 16)
        Me.LabelControl2.TabIndex = 83
        Me.LabelControl2.Text = "Estado"
        '
        'gcUnidades
        '
        Me.gcUnidades.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcUnidades.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gcUnidades.Location = New System.Drawing.Point(0, 0)
        Me.gcUnidades.MainView = Me.GridView2
        Me.gcUnidades.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gcUnidades.MenuManager = Me.bmActions
        Me.gcUnidades.Name = "gcUnidades"
        Me.gcUnidades.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rilueUnidad, Me.RepositoryItemImageEdit1, Me.rilud, Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2, Me.rilueConcepto, Me.rilueMoneda, Me.RepositoryItemTextEdit3})
        Me.gcUnidades.Size = New System.Drawing.Size(520, 257)
        Me.gcUnidades.TabIndex = 0
        Me.gcUnidades.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn9, Me.GridColumn17, Me.GridColumn11, Me.GridColumn18, Me.GridColumn16, Me.GridColumn19, Me.GridColumn2, Me.GridColumn10, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14, Me.GridColumn15})
        Me.GridView2.DetailHeight = 431
        Me.GridView2.GridControl = Me.gcUnidades
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsCustomization.AllowGroup = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "IdPackConcept"
        Me.GridColumn9.FieldName = "IdTariffDetail"
        Me.GridColumn9.MinWidth = 23
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Width = 87
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "CONCEPTO"
        Me.GridColumn17.ColumnEdit = Me.rilueConcepto
        Me.GridColumn17.FieldName = "IdConcept"
        Me.GridColumn17.MinWidth = 23
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 0
        Me.GridColumn17.Width = 87
        '
        'rilueConcepto
        '
        Me.rilueConcepto.AutoHeight = False
        Me.rilueConcepto.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rilueConcepto.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdConcept", "IdConcept", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ConceptCode", "CODIGO", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ConceptDescription", "DESCRIPCION")})
        Me.rilueConcepto.Name = "rilueConcepto"
        Me.rilueConcepto.NullText = ""
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "UNIDAD"
        Me.GridColumn11.ColumnEdit = Me.rilueUnidad
        Me.GridColumn11.FieldName = "IdUnit"
        Me.GridColumn11.MinWidth = 23
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 1
        Me.GridColumn11.Width = 87
        '
        'rilueUnidad
        '
        Me.rilueUnidad.AutoHeight = False
        Me.rilueUnidad.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rilueUnidad.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdUnit", "IdUnit", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("UnitCode", "CODIGO"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("UnitDescription", "DESCRIPCION")})
        Me.rilueUnidad.Name = "rilueUnidad"
        Me.rilueUnidad.NullText = ""
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "MONEDA"
        Me.GridColumn18.ColumnEdit = Me.rilueMoneda
        Me.GridColumn18.FieldName = "Currency"
        Me.GridColumn18.MinWidth = 24
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.Visible = True
        Me.GridColumn18.VisibleIndex = 2
        Me.GridColumn18.Width = 94
        '
        'rilueMoneda
        '
        Me.rilueMoneda.AutoHeight = False
        Me.rilueMoneda.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rilueMoneda.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TIPO_CodTipo", "CODIGO"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TIPO_Desc1", "DESCRIPCION")})
        Me.rilueMoneda.Name = "rilueMoneda"
        Me.rilueMoneda.NullText = ""
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "IMPORTE COSTO"
        Me.GridColumn16.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.GridColumn16.FieldName = "CostsAmount"
        Me.GridColumn16.MinWidth = 23
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 3
        Me.GridColumn16.Width = 87
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'GridColumn19
        '
        Me.GridColumn19.Caption = "MARGEN CONTRIBUCION"
        Me.GridColumn19.ColumnEdit = Me.RepositoryItemTextEdit3
        Me.GridColumn19.FieldName = "ContributionMargin"
        Me.GridColumn19.MinWidth = 23
        Me.GridColumn19.Name = "GridColumn19"
        Me.GridColumn19.Visible = True
        Me.GridColumn19.VisibleIndex = 4
        Me.GridColumn19.Width = 108
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.AutoHeight = False
        Me.RepositoryItemTextEdit3.Mask.BeepOnError = True
        Me.RepositoryItemTextEdit3.Mask.EditMask = "P"
        Me.RepositoryItemTextEdit3.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit3.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "IMPORTE VENTA"
        Me.GridColumn2.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.GridColumn2.FieldName = "SalesAmount"
        Me.GridColumn2.MinWidth = 23
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 5
        Me.GridColumn2.Width = 87
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "IdTariff"
        Me.GridColumn10.FieldName = "IdTariff"
        Me.GridColumn10.MinWidth = 23
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Width = 87
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "UserCreate"
        Me.GridColumn12.FieldName = "UserCreate"
        Me.GridColumn12.MinWidth = 23
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Width = 87
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "DateCreate"
        Me.GridColumn13.FieldName = "DateCreate"
        Me.GridColumn13.MinWidth = 23
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Width = 87
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "UserUpdate"
        Me.GridColumn14.FieldName = "UserUpdate"
        Me.GridColumn14.MinWidth = 23
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.Width = 87
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "DateUpdate"
        Me.GridColumn15.FieldName = "DateUpdate"
        Me.GridColumn15.MinWidth = 23
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.Width = 87
        '
        'RepositoryItemImageEdit1
        '
        Me.RepositoryItemImageEdit1.AutoHeight = False
        Me.RepositoryItemImageEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemImageEdit1.Name = "RepositoryItemImageEdit1"
        '
        'rilud
        '
        Me.rilud.AutoHeight = False
        Me.rilud.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rilud.Name = "rilud"
        Me.rilud.NullText = ""
        '
        'gcMainDataTariff
        '
        Me.gcMainDataTariff.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcMainDataTariff.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.gcMainDataTariff.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.gcMainDataTariff.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.gcMainDataTariff.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.gcMainDataTariff.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.gcMainDataTariff.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gcMainDataTariff.Location = New System.Drawing.Point(0, 0)
        Me.gcMainDataTariff.MainView = Me.GridView1
        Me.gcMainDataTariff.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gcMainDataTariff.Name = "gcMainDataTariff"
        Me.gcMainDataTariff.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckedComboBoxEdit1, Me.RepositoryItemCheckEdit1})
        Me.gcMainDataTariff.Size = New System.Drawing.Size(551, 502)
        Me.gcMainDataTariff.TabIndex = 6
        Me.gcMainDataTariff.UseEmbeddedNavigator = True
        Me.gcMainDataTariff.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.LayoutView1, Me.CardView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn3, Me.GridColumn5, Me.GridColumn4, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8})
        Me.GridView1.DetailHeight = 431
        Me.GridView1.GridControl = Me.gcMainDataTariff
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ImporteTotal", Nothing, "", New Decimal(New Integer() {0, 0, 0, 131072}))})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "ID"
        Me.GridColumn1.FieldName = "IdTariff"
        Me.GridColumn1.MinWidth = 23
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 87
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "DESCRIPCION"
        Me.GridColumn3.FieldName = "Remarks"
        Me.GridColumn3.MinWidth = 23
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        Me.GridColumn3.Width = 87
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "ESTADO"
        Me.GridColumn5.FieldName = "TariffStatus"
        Me.GridColumn5.MinWidth = 23
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 2
        Me.GridColumn5.Width = 87
        '
        'GridColumn4
        '
        Me.GridColumn4.FieldName = "UserCreate"
        Me.GridColumn4.MinWidth = 23
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Width = 87
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "GridColumn6"
        Me.GridColumn6.FieldName = "DateCreate"
        Me.GridColumn6.MinWidth = 23
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Width = 87
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "GridColumn7"
        Me.GridColumn7.FieldName = "UserUpdate"
        Me.GridColumn7.MinWidth = 23
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Width = 87
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "GridColumn8"
        Me.GridColumn8.FieldName = "DateUpdate"
        Me.GridColumn8.MinWidth = 23
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Width = 87
        '
        'RepositoryItemCheckedComboBoxEdit1
        '
        Me.RepositoryItemCheckedComboBoxEdit1.AutoHeight = False
        Me.RepositoryItemCheckedComboBoxEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCheckedComboBoxEdit1.Name = "RepositoryItemCheckedComboBoxEdit1"
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.ValueChecked = "A"
        Me.RepositoryItemCheckEdit1.ValueUnchecked = "I"
        '
        'LayoutView1
        '
        Me.LayoutView1.DetailHeight = 431
        Me.LayoutView1.GridControl = Me.gcMainDataTariff
        Me.LayoutView1.Name = "LayoutView1"
        Me.LayoutView1.OptionsBehavior.Editable = False
        Me.LayoutView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways
        Me.LayoutView1.TemplateCard = Me.LayoutViewCard1
        '
        'LayoutViewCard1
        '
        Me.LayoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.LayoutViewCard1.Name = "layoutViewTemplateCard"
        '
        'CardView1
        '
        Me.CardView1.CardWidth = 233
        Me.CardView1.DetailHeight = 431
        Me.CardView1.GridControl = Me.gcMainDataTariff
        Me.CardView1.Name = "CardView1"
        Me.CardView1.OptionsBehavior.Editable = False
        Me.CardView1.OptionsFind.AlwaysVisible = True
        Me.CardView1.OptionsView.ShowQuickCustomizeButton = False
        Me.CardView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.[Auto]
        '
        'TariffForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1085, 645)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.ucAuditPanel)
        Me.Controls.Add(Me.BarDockControl3)
        Me.Controls.Add(Me.BarDockControl4)
        Me.Controls.Add(Me.BarDockControl2)
        Me.Controls.Add(Me.BarDockControl1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "TariffForm"
        Me.Text = "Tarifas"
        CType(Me.bmActions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpiProceso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vpInputs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.meRemarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueLayout.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueTipoTarifa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueMoneda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueEstado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcUnidades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rilueConcepto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rilueUnidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rilueMoneda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemImageEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rilud, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcMainDataTariff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckedComboBoxEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutViewCard1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CardView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents bmActions As DevExpress.XtraBars.BarManager
    Private WithEvents bar5 As DevExpress.XtraBars.Bar
    Private WithEvents brsDescripcion As DevExpress.XtraBars.BarStaticItem
    Private WithEvents brBarraAcciones As DevExpress.XtraBars.Bar
    Friend WithEvents bbiInsert As DevExpress.XtraBars.BarButtonItem
    Private WithEvents bbiClose As DevExpress.XtraBars.BarButtonItem
    Private WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Private WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
    Private WithEvents BarDockControl3 As DevExpress.XtraBars.BarDockControl
    Private WithEvents BarDockControl4 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bsiVistas As DevExpress.XtraBars.BarSubItem
    Friend WithEvents bbiVistaGrilla As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiTarjeta As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiContrato As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiCronograma As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiCartaNotarial As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiLetras As DevExpress.XtraBars.BarButtonItem
    Private WithEvents rpiProceso As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents vpInputs As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents bbiEdit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiExport As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents ucAuditPanel As ucAuditPanel
    Friend WithEvents bbiRefresh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents gcMainDataTariff As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutView1 As DevExpress.XtraGrid.Views.Layout.LayoutView
    Friend WithEvents LayoutViewCard1 As DevExpress.XtraGrid.Views.Layout.LayoutViewCard
    Friend WithEvents CardView1 As DevExpress.XtraGrid.Views.Card.CardView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemCheckedComboBoxEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents lueMoneda As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueEstado As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gcUnidades As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rilueUnidad As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents rilud As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemImageEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemImageEdit
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lueTipoTarifa As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents meRemarks As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtpHasta As DateTimePicker
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtpDe As DateTimePicker
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lueLayout As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rilueConcepto As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents bbiCopy As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rilueMoneda As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
End Class

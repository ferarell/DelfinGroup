<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomerStatementQueryForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomerStatementQueryForm))
        Me.vpInputs = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.deDateTo = New DevExpress.XtraEditors.DateEdit()
        Me.deDateFrom = New DevExpress.XtraEditors.DateEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbeQueryType = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.bmActions = New DevExpress.XtraBars.BarManager(Me.components)
        Me.bar5 = New DevExpress.XtraBars.Bar()
        Me.brsDescripcion = New DevExpress.XtraBars.BarStaticItem()
        Me.brBarraAcciones = New DevExpress.XtraBars.Bar()
        Me.bbiSearch = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiExport = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiViewer = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiClose = New DevExpress.XtraBars.BarButtonItem()
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl3 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl4 = New DevExpress.XtraBars.BarDockControl()
        Me.rpiProceso = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
        Me.RepositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
        Me.lueCustomer = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gcMainData = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.vpInputs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.deDateTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deDateTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deDateFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deDateFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbeQueryType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bmActions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpiProceso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcMainData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vpInputs
        '
        Me.vpInputs.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 41)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.deDateTo)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.deDateFrom)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.cbeQueryType)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.lueCustomer)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.gcMainData)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(865, 371)
        Me.SplitContainerControl1.SplitterPosition = 118
        Me.SplitContainerControl1.TabIndex = 0
        '
        'deDateTo
        '
        Me.deDateTo.EditValue = Nothing
        Me.deDateTo.Location = New System.Drawing.Point(117, 57)
        Me.deDateTo.Margin = New System.Windows.Forms.Padding(2)
        Me.deDateTo.Name = "deDateTo"
        Me.deDateTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deDateTo.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deDateTo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.deDateTo.Size = New System.Drawing.Size(98, 20)
        Me.deDateTo.TabIndex = 2
        '
        'deDateFrom
        '
        Me.deDateFrom.EditValue = Nothing
        Me.deDateFrom.Location = New System.Drawing.Point(117, 33)
        Me.deDateFrom.Margin = New System.Windows.Forms.Padding(2)
        Me.deDateFrom.Name = "deDateFrom"
        Me.deDateFrom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deDateFrom.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deDateFrom.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.deDateFrom.Size = New System.Drawing.Size(98, 20)
        Me.deDateFrom.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 36)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Fecha Desde"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 60)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Fecha Hasta"
        '
        'cbeQueryType
        '
        Me.cbeQueryType.EditValue = "Pendiente"
        Me.cbeQueryType.Location = New System.Drawing.Point(117, 82)
        Me.cbeQueryType.MenuManager = Me.bmActions
        Me.cbeQueryType.Name = "cbeQueryType"
        Me.cbeQueryType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbeQueryType.Properties.Items.AddRange(New Object() {"Todo", "Pendiente", "Cancelado"})
        Me.cbeQueryType.Size = New System.Drawing.Size(97, 20)
        Me.cbeQueryType.TabIndex = 3
        '
        'bmActions
        '
        Me.bmActions.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.bar5, Me.brBarraAcciones})
        Me.bmActions.DockControls.Add(Me.BarDockControl1)
        Me.bmActions.DockControls.Add(Me.BarDockControl2)
        Me.bmActions.DockControls.Add(Me.BarDockControl3)
        Me.bmActions.DockControls.Add(Me.BarDockControl4)
        Me.bmActions.Form = Me
        Me.bmActions.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.brsDescripcion, Me.bbiSearch, Me.bbiClose, Me.bbiExport, Me.bbiViewer})
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
        'brBarraAcciones
        '
        Me.brBarraAcciones.BarName = "Custom 5"
        Me.brBarraAcciones.DockCol = 0
        Me.brBarraAcciones.DockRow = 0
        Me.brBarraAcciones.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.brBarraAcciones.FloatLocation = New System.Drawing.Point(279, 188)
        Me.brBarraAcciones.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bbiSearch, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bbiExport, "", True, True, False, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bbiViewer, "", True, True, False, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bbiClose, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.brBarraAcciones.OptionsBar.AllowQuickCustomization = False
        Me.brBarraAcciones.OptionsBar.UseWholeRow = True
        Me.brBarraAcciones.Text = "Custom 5"
        '
        'bbiSearch
        '
        Me.bbiSearch.Caption = "&Buscar"
        Me.bbiSearch.Id = 33
        Me.bbiSearch.ImageOptions.Image = CType(resources.GetObject("bbiSearch.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiSearch.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.G))
        Me.bbiSearch.Name = "bbiSearch"
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
        'bbiClose
        '
        Me.bbiClose.Caption = "&Cerrar"
        Me.bbiClose.Id = 41
        Me.bbiClose.ImageOptions.Image = CType(resources.GetObject("bbiClose.ImageOptions.Image"), System.Drawing.Image)
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
        Me.BarDockControl1.Size = New System.Drawing.Size(865, 41)
        '
        'BarDockControl2
        '
        Me.BarDockControl2.CausesValidation = False
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl2.Location = New System.Drawing.Point(0, 412)
        Me.BarDockControl2.Manager = Me.bmActions
        Me.BarDockControl2.Size = New System.Drawing.Size(865, 27)
        '
        'BarDockControl3
        '
        Me.BarDockControl3.CausesValidation = False
        Me.BarDockControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl3.Location = New System.Drawing.Point(0, 41)
        Me.BarDockControl3.Manager = Me.bmActions
        Me.BarDockControl3.Size = New System.Drawing.Size(0, 371)
        '
        'BarDockControl4
        '
        Me.BarDockControl4.CausesValidation = False
        Me.BarDockControl4.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl4.Location = New System.Drawing.Point(865, 41)
        Me.BarDockControl4.Manager = Me.bmActions
        Me.BarDockControl4.Size = New System.Drawing.Size(0, 371)
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
        'lueCustomer
        '
        Me.lueCustomer.Location = New System.Drawing.Point(117, 9)
        Me.lueCustomer.Margin = New System.Windows.Forms.Padding(2)
        Me.lueCustomer.Name = "lueCustomer"
        Me.lueCustomer.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.lueCustomer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueCustomer.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodigoCliente", "Código"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DescripcionCliente", "Descripción", 120, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.lueCustomer.Properties.NullText = ""
        Me.lueCustomer.Size = New System.Drawing.Size(427, 20)
        Me.lueCustomer.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 85)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Consulta"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(74, 12)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Cliente"
        '
        'gcMainData
        '
        Me.gcMainData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcMainData.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.gcMainData.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.gcMainData.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.gcMainData.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.gcMainData.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.gcMainData.Location = New System.Drawing.Point(0, 0)
        Me.gcMainData.MainView = Me.GridView1
        Me.gcMainData.Name = "gcMainData"
        Me.gcMainData.Size = New System.Drawing.Size(865, 249)
        Me.gcMainData.TabIndex = 172
        Me.gcMainData.UseEmbeddedNavigator = True
        Me.gcMainData.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridView1.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridView1.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn13, Me.GridColumn12, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn11, Me.GridColumn8, Me.GridColumn9, Me.GridColumn7, Me.GridColumn10})
        Me.GridView1.GridControl = Me.gcMainData
        Me.GridView1.GroupCount = 2
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Importe", Me.GridColumn9, "{0:###,###,##0.00}", New Decimal(New Integer() {0, 0, 0, 131072}))})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn1, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn8, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Tipo de Servicio"
        Me.GridColumn1.FieldName = "Grupo"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Código Cliente"
        Me.GridColumn2.FieldName = "ENTC_Codigo"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "No. HBL"
        Me.GridColumn3.FieldName = "HBL"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 0
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Nave"
        Me.GridColumn13.FieldName = "NAVE_Nombre"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 1
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Viaje"
        Me.GridColumn12.FieldName = "NVIA_NroViaje"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 2
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "DocumentoInterno"
        Me.GridColumn4.FieldName = "NumDocumento"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Tipo Documento"
        Me.GridColumn5.FieldName = "TipoDocumento"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.ReadOnly = True
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 3
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Fecha Emisión"
        Me.GridColumn6.FieldName = "DOCV_FechaEmision"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.ReadOnly = True
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 4
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Concepto"
        Me.GridColumn11.FieldName = "Concepto"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.OptionsColumn.ReadOnly = True
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 5
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Moneda"
        Me.GridColumn8.FieldName = "Moneda"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.ReadOnly = True
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 7
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Importe"
        Me.GridColumn9.DisplayFormat.FormatString = "###,###,##0.00"
        Me.GridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn9.FieldName = "Importe"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.ReadOnly = True
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 6
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Fecha de Vencimiento"
        Me.GridColumn7.FieldName = "DOCV_FechaVcmto"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.ReadOnly = True
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 7
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Forma Pago"
        Me.GridColumn10.FieldName = "FormaPago"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.ReadOnly = True
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 8
        '
        'CustomerStatementQueryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(865, 439)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.BarDockControl3)
        Me.Controls.Add(Me.BarDockControl4)
        Me.Controls.Add(Me.BarDockControl2)
        Me.Controls.Add(Me.BarDockControl1)
        Me.Name = "CustomerStatementQueryForm"
        Me.Text = "Estado de Cuenta del Cliente"
        CType(Me.vpInputs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.deDateTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deDateTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deDateFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deDateFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbeQueryType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bmActions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpiProceso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcMainData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents vpInputs As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Private WithEvents bmActions As DevExpress.XtraBars.BarManager
    Private WithEvents bar5 As DevExpress.XtraBars.Bar
    Private WithEvents brsDescripcion As DevExpress.XtraBars.BarStaticItem
    Private WithEvents brBarraAcciones As DevExpress.XtraBars.Bar
    Private WithEvents bbiSearch As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiExport As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiViewer As DevExpress.XtraBars.BarButtonItem
    Private WithEvents bbiClose As DevExpress.XtraBars.BarButtonItem
    Private WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Private WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
    Private WithEvents BarDockControl3 As DevExpress.XtraBars.BarDockControl
    Private WithEvents BarDockControl4 As DevExpress.XtraBars.BarDockControl
    Private WithEvents rpiProceso As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Friend WithEvents RepositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents lueCustomer As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label5 As Label
    Friend WithEvents gcMainData As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbeQueryType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label1 As Label
    Friend WithEvents deDateTo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents deDateFrom As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HBLStatusQueryForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HBLStatusQueryForm))
        Me.teHBL = New DevExpress.XtraEditors.TextEdit()
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.VGridControl1 = New DevExpress.XtraVerticalGrid.VGridControl()
        Me.row = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.row1 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.row2 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.row3 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.row4 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.row5 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.row10 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.row6 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.row7 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.row8 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.row9 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.vpInputs = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        CType(Me.teHBL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bmActions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpiProceso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.VGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vpInputs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'teHBL
        '
        Me.teHBL.Location = New System.Drawing.Point(119, 35)
        Me.teHBL.MenuManager = Me.bmActions
        Me.teHBL.Name = "teHBL"
        Me.teHBL.Size = New System.Drawing.Size(202, 20)
        Me.teHBL.TabIndex = 36
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
        Me.BarDockControl1.Size = New System.Drawing.Size(862, 41)
        '
        'BarDockControl2
        '
        Me.BarDockControl2.CausesValidation = False
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl2.Location = New System.Drawing.Point(0, 409)
        Me.BarDockControl2.Manager = Me.bmActions
        Me.BarDockControl2.Size = New System.Drawing.Size(862, 27)
        '
        'BarDockControl3
        '
        Me.BarDockControl3.CausesValidation = False
        Me.BarDockControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl3.Location = New System.Drawing.Point(0, 41)
        Me.BarDockControl3.Manager = Me.bmActions
        Me.BarDockControl3.Size = New System.Drawing.Size(0, 368)
        '
        'BarDockControl4
        '
        Me.BarDockControl4.CausesValidation = False
        Me.BarDockControl4.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl4.Location = New System.Drawing.Point(862, 41)
        Me.BarDockControl4.Manager = Me.bmActions
        Me.BarDockControl4.Size = New System.Drawing.Size(0, 368)
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(48, 36)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Número HBL"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(73, 12)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Cliente"
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 41)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl1)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.teHBL)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.lueCustomer)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.VGridControl1)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(862, 368)
        Me.SplitContainerControl1.SplitterPosition = 68
        Me.SplitContainerControl1.TabIndex = 5
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(327, 38)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(75, 13)
        Me.LabelControl1.TabIndex = 37
        Me.LabelControl1.Text = "Result Message"
        '
        'VGridControl1
        '
        Me.VGridControl1.Appearance.DisabledRecordValue.Options.UseForeColor = True
        Me.VGridControl1.Appearance.ReadOnlyRecordValue.Options.UseForeColor = True
        Me.VGridControl1.Appearance.ReadOnlyRow.Options.UseForeColor = True
        Me.VGridControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.VGridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.VGridControl1.CustomizationFormBounds = New System.Drawing.Rectangle(896, 339, 210, 252)
        Me.VGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VGridControl1.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView
        Me.VGridControl1.Location = New System.Drawing.Point(0, 0)
        Me.VGridControl1.Name = "VGridControl1"
        Me.VGridControl1.OptionsBehavior.Editable = False
        Me.VGridControl1.OptionsView.AutoScaleBands = True
        Me.VGridControl1.OptionsView.MaxRowAutoHeight = 40
        Me.VGridControl1.OptionsView.MinRowAutoHeight = 30
        Me.VGridControl1.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.row, Me.row1, Me.row2, Me.row3, Me.row4, Me.row5, Me.row10, Me.row6, Me.row7, Me.row8, Me.row9})
        Me.VGridControl1.Size = New System.Drawing.Size(862, 296)
        Me.VGridControl1.TabIndex = 0
        '
        'row
        '
        Me.row.Height = 29
        Me.row.Name = "row"
        Me.row.Properties.Caption = "Nave"
        Me.row.Properties.FieldName = "NAVE_Nombre"
        Me.row.Properties.ReadOnly = True
        '
        'row1
        '
        Me.row1.Name = "row1"
        Me.row1.Properties.Caption = "Viaje-Vuelo"
        Me.row1.Properties.FieldName = "NVIA_NroViaje"
        Me.row1.Properties.ReadOnly = True
        '
        'row2
        '
        Me.row2.Name = "row2"
        Me.row2.Properties.Caption = "Fecha ETA/ETD"
        Me.row2.Properties.FieldName = "Fecha_Eta_Etd"
        Me.row2.Properties.Format.FormatString = "dd/MM/yyyy"
        Me.row2.Properties.Format.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.row2.Properties.ReadOnly = True
        '
        'row3
        '
        Me.row3.Name = "row3"
        Me.row3.Properties.Caption = "Transportista"
        Me.row3.Properties.FieldName = "ENTC_NomLinea"
        Me.row3.Properties.ReadOnly = True
        '
        'row4
        '
        Me.row4.Name = "row4"
        Me.row4.Properties.Caption = "VoBo (Agencia Marítima)"
        Me.row4.Properties.FieldName = "VoBo"
        Me.row4.Properties.ReadOnly = True
        '
        'row5
        '
        Me.row5.Name = "row5"
        Me.row5.Properties.Caption = "Terminal Portuario"
        Me.row5.Properties.FieldName = "TerminalPortuario"
        Me.row5.Properties.ReadOnly = True
        '
        'row10
        '
        Me.row10.Height = 30
        Me.row10.Name = "row10"
        Me.row10.Properties.Caption = "Depósito"
        Me.row10.Properties.FieldName = "ENTC_NomDeposito"
        Me.row10.Properties.ReadOnly = True
        '
        'row6
        '
        Me.row6.Name = "row6"
        Me.row6.Properties.Caption = "Fecha Cierre Direccionamiento"
        Me.row6.Properties.FieldName = "Fecha_CierreDire"
        Me.row6.Properties.Format.FormatString = "dd/MM/yyyy HH:mm"
        Me.row6.Properties.Format.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.row6.Properties.ReadOnly = True
        '
        'row7
        '
        Me.row7.Name = "row7"
        Me.row7.Properties.Caption = "Emisión HBL"
        Me.row7.Properties.FieldName = "EmitirHBL"
        Me.row7.Properties.ReadOnly = True
        '
        'row8
        '
        Me.row8.Name = "row8"
        Me.row8.Properties.Caption = "Transmisión Aduana"
        Me.row8.Properties.FieldName = "TransmisionAduana"
        Me.row8.Properties.Format.FormatString = "dd/MM/yyyy HH:mm"
        Me.row8.Properties.Format.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.row8.Properties.ReadOnly = True
        '
        'row9
        '
        Me.row9.Name = "row9"
        Me.row9.Properties.Caption = "Entrega de Desglose al Agente Marítimo"
        Me.row9.Properties.FieldName = "FechaDesglose"
        Me.row9.Properties.Format.FormatString = "dd/MM/yyyy HH:mm"
        Me.row9.Properties.Format.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.row9.Properties.ReadOnly = True
        '
        'vpInputs
        '
        Me.vpInputs.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual
        '
        'HBLStatusQueryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 436)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.BarDockControl3)
        Me.Controls.Add(Me.BarDockControl4)
        Me.Controls.Add(Me.BarDockControl2)
        Me.Controls.Add(Me.BarDockControl1)
        Me.Name = "HBLStatusQueryForm"
        Me.Text = "Estado de HBL"
        CType(Me.teHBL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bmActions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpiProceso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.VGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vpInputs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents teHBL As DevExpress.XtraEditors.TextEdit
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
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents lueCustomer As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Private WithEvents rpiProceso As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Friend WithEvents RepositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents vpInputs As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents VGridControl1 As DevExpress.XtraVerticalGrid.VGridControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents row As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents row1 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents row2 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents row3 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents row4 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents row5 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents row10 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents row6 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents row7 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents row8 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents row9 As DevExpress.XtraVerticalGrid.Rows.EditorRow
End Class

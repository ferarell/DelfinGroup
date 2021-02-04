<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConciliacionRebatesForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConciliacionRebatesForm))
        Me.rpiProceso = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
        Me.RepositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
        Me.vpInputs = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.bmActions = New DevExpress.XtraBars.BarManager(Me.components)
        Me.bar5 = New DevExpress.XtraBars.Bar()
        Me.brsDescripcion = New DevExpress.XtraBars.BarStaticItem()
        Me.brBarraAcciones = New DevExpress.XtraBars.Bar()
        Me.bbiProcess = New DevExpress.XtraBars.BarButtonItem()
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
        Me.bbiReset = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiAdd = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiSendMessage = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiEdit = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiVoid = New DevExpress.XtraBars.BarButtonItem()
        Me.RepositoryItemProgressBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
        Me.RepositoryItemImageComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
        Me.lueShipline = New DevExpress.XtraEditors.LookUpEdit()
        Me.deDateTo = New DevExpress.XtraEditors.DateEdit()
        Me.deDateFrom = New DevExpress.XtraEditors.DateEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.beShiplineDataSource = New DevExpress.XtraEditors.ButtonEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.XtraOpenFileDialog1 = New DevExpress.XtraEditors.XtraOpenFileDialog(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.beSourceDataBase = New DevExpress.XtraEditors.ButtonEdit()
        Me.XtraOpenFileDialog2 = New DevExpress.XtraEditors.XtraOpenFileDialog(Me.components)
        CType(Me.rpiProceso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vpInputs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bmActions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueShipline.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deDateTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deDateTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deDateFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deDateFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.beShiplineDataSource.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.beSourceDataBase.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.bmActions.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.brsDescripcion, Me.bbiProcess, Me.bbiClose, Me.BarButtonItem1, Me.bsiVistas, Me.bbiVistaGrilla, Me.bbiTarjeta, Me.bbiContrato, Me.bbiCronograma, Me.bbiCartaNotarial, Me.bbiLetras, Me.bbiReset, Me.bbiExport, Me.bbiAdd, Me.BarButtonItem5, Me.bbiSendMessage, Me.bbiEdit, Me.bbiVoid})
        Me.bmActions.MaxItemId = 28
        Me.bmActions.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemProgressBar1, Me.RepositoryItemImageComboBox2})
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
        Me.brBarraAcciones.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bbiProcess, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bbiExport, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bbiClose, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.brBarraAcciones.OptionsBar.AllowQuickCustomization = False
        Me.brBarraAcciones.OptionsBar.UseWholeRow = True
        Me.brBarraAcciones.Text = "Custom 5"
        '
        'bbiProcess
        '
        Me.bbiProcess.Caption = "&Procesar"
        Me.bbiProcess.Id = 33
        Me.bbiProcess.ImageOptions.Image = CType(resources.GetObject("bbiProcess.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiProcess.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5)
        Me.bbiProcess.Name = "bbiProcess"
        '
        'bbiExport
        '
        Me.bbiExport.Caption = "&Exportar"
        Me.bbiExport.Id = 22
        Me.bbiExport.ImageOptions.Image = CType(resources.GetObject("bbiExport.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiExport.Name = "bbiExport"
        Me.bbiExport.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
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
        Me.BarDockControl1.Size = New System.Drawing.Size(458, 47)
        '
        'BarDockControl2
        '
        Me.BarDockControl2.CausesValidation = False
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl2.Location = New System.Drawing.Point(0, 187)
        Me.BarDockControl2.Manager = Me.bmActions
        Me.BarDockControl2.Size = New System.Drawing.Size(458, 29)
        '
        'BarDockControl3
        '
        Me.BarDockControl3.CausesValidation = False
        Me.BarDockControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl3.Location = New System.Drawing.Point(0, 47)
        Me.BarDockControl3.Manager = Me.bmActions
        Me.BarDockControl3.Size = New System.Drawing.Size(0, 140)
        '
        'BarDockControl4
        '
        Me.BarDockControl4.CausesValidation = False
        Me.BarDockControl4.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl4.Location = New System.Drawing.Point(458, 47)
        Me.BarDockControl4.Manager = Me.bmActions
        Me.BarDockControl4.Size = New System.Drawing.Size(0, 140)
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
        Me.bsiVistas.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbiVistaGrilla), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiTarjeta)})
        Me.bsiVistas.Name = "bsiVistas"
        '
        'bbiVistaGrilla
        '
        Me.bbiVistaGrilla.Caption = "Grilla"
        Me.bbiVistaGrilla.Id = 7
        Me.bbiVistaGrilla.Name = "bbiVistaGrilla"
        '
        'bbiTarjeta
        '
        Me.bbiTarjeta.Caption = "Tarjeta"
        Me.bbiTarjeta.Id = 8
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
        'bbiReset
        '
        Me.bbiReset.Caption = "&Reset"
        Me.bbiReset.Id = 20
        Me.bbiReset.Name = "bbiReset"
        '
        'bbiAdd
        '
        Me.bbiAdd.Caption = "&Nuevo"
        Me.bbiAdd.Id = 23
        Me.bbiAdd.ImageOptions.Image = CType(resources.GetObject("bbiAdd.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiAdd.Name = "bbiAdd"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "BarButtonItem5"
        Me.BarButtonItem5.Id = 24
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'bbiSendMessage
        '
        Me.bbiSendMessage.Caption = "&Notificar Asignación"
        Me.bbiSendMessage.Id = 25
        Me.bbiSendMessage.ImageOptions.Image = CType(resources.GetObject("bbiSendMessage.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiSendMessage.Name = "bbiSendMessage"
        '
        'bbiEdit
        '
        Me.bbiEdit.Caption = "&Editar"
        Me.bbiEdit.Id = 26
        Me.bbiEdit.ImageOptions.Image = CType(resources.GetObject("bbiEdit.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiEdit.Name = "bbiEdit"
        '
        'bbiVoid
        '
        Me.bbiVoid.Caption = "&Anular"
        Me.bbiVoid.Id = 27
        Me.bbiVoid.ImageOptions.Image = CType(resources.GetObject("bbiVoid.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiVoid.Name = "bbiVoid"
        '
        'RepositoryItemProgressBar1
        '
        Me.RepositoryItemProgressBar1.Name = "RepositoryItemProgressBar1"
        Me.RepositoryItemProgressBar1.ShowTitle = True
        '
        'RepositoryItemImageComboBox2
        '
        Me.RepositoryItemImageComboBox2.AutoHeight = False
        Me.RepositoryItemImageComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(), New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemImageComboBox2.Name = "RepositoryItemImageComboBox2"
        '
        'lueShipline
        '
        Me.lueShipline.Enabled = False
        Me.lueShipline.Location = New System.Drawing.Point(111, 69)
        Me.lueShipline.Name = "lueShipline"
        Me.lueShipline.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.lueShipline.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueShipline.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.lueShipline.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodigoTransportista", "Código", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DescripcionTransportista", "Descripción")})
        Me.lueShipline.Properties.NullText = ""
        Me.lueShipline.Size = New System.Drawing.Size(301, 20)
        Me.lueShipline.TabIndex = 0
        '
        'deDateTo
        '
        Me.deDateTo.EditValue = Nothing
        Me.deDateTo.Enabled = False
        Me.deDateTo.Location = New System.Drawing.Point(111, 118)
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
        Me.deDateFrom.Enabled = False
        Me.deDateFrom.Location = New System.Drawing.Point(111, 94)
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
        Me.Label3.Location = New System.Drawing.Point(40, 97)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Fecha Desde"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 121)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Fecha Hasta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 72)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Transportista"
        '
        'beShiplineDataSource
        '
        Me.beShiplineDataSource.Location = New System.Drawing.Point(111, 142)
        Me.beShiplineDataSource.Margin = New System.Windows.Forms.Padding(2)
        Me.beShiplineDataSource.Name = "beShiplineDataSource"
        Me.beShiplineDataSource.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.beShiplineDataSource.Size = New System.Drawing.Size(301, 20)
        Me.beShiplineDataSource.TabIndex = 3
        Me.beShiplineDataSource.ToolTip = "Seleccione el archivo externo que contiene la información que originará el nuevo " &
    "asiento contable."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 145)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Archivo Naviera"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 169)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Base de Datos"
        Me.Label2.Visible = False
        '
        'beSourceDataBase
        '
        Me.beSourceDataBase.Location = New System.Drawing.Point(111, 166)
        Me.beSourceDataBase.Margin = New System.Windows.Forms.Padding(2)
        Me.beSourceDataBase.Name = "beSourceDataBase"
        Me.beSourceDataBase.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.beSourceDataBase.Size = New System.Drawing.Size(301, 20)
        Me.beSourceDataBase.TabIndex = 4
        Me.beSourceDataBase.ToolTip = "Seleccione el archivo externo que contiene la información que originará el nuevo " &
    "asiento contable."
        Me.beSourceDataBase.Visible = False
        '
        'ConciliacionRebatesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 216)
        Me.Controls.Add(Me.beSourceDataBase)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.beShiplineDataSource)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.deDateTo)
        Me.Controls.Add(Me.deDateFrom)
        Me.Controls.Add(Me.lueShipline)
        Me.Controls.Add(Me.BarDockControl3)
        Me.Controls.Add(Me.BarDockControl4)
        Me.Controls.Add(Me.BarDockControl2)
        Me.Controls.Add(Me.BarDockControl1)
        Me.Name = "ConciliacionRebatesForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conciliación de Rebates"
        CType(Me.rpiProceso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vpInputs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bmActions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueShipline.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deDateTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deDateTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deDateFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deDateFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.beShiplineDataSource.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.beSourceDataBase.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents rpiProceso As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Friend WithEvents RepositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents vpInputs As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Private WithEvents bmActions As DevExpress.XtraBars.BarManager
    Private WithEvents bar5 As DevExpress.XtraBars.Bar
    Private WithEvents brsDescripcion As DevExpress.XtraBars.BarStaticItem
    Private WithEvents brBarraAcciones As DevExpress.XtraBars.Bar
    Private WithEvents bbiProcess As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiExport As DevExpress.XtraBars.BarButtonItem
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
    Friend WithEvents bbiReset As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiAdd As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiSendMessage As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiEdit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiVoid As DevExpress.XtraBars.BarButtonItem
    Private WithEvents RepositoryItemProgressBar1 As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Friend WithEvents RepositoryItemImageComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Public WithEvents lueShipline As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents deDateTo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents deDateFrom As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents beShiplineDataSource As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents XtraOpenFileDialog1 As DevExpress.XtraEditors.XtraOpenFileDialog
    Friend WithEvents beSourceDataBase As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents XtraOpenFileDialog2 As DevExpress.XtraEditors.XtraOpenFileDialog
End Class

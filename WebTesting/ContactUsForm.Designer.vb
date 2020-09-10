<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContactUsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ContactUsForm))
        Me.brBarraAcciones = New DevExpress.XtraBars.Bar()
        Me.bbiSendMail = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiClose = New DevExpress.XtraBars.BarButtonItem()
        Me.bar5 = New DevExpress.XtraBars.Bar()
        Me.brsDescripcion = New DevExpress.XtraBars.BarStaticItem()
        Me.vpInputs = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.bmActions = New DevExpress.XtraBars.BarManager(Me.components)
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl3 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl4 = New DevExpress.XtraBars.BarDockControl()
        Me.bbiExport = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiViewer = New DevExpress.XtraBars.BarButtonItem()
        Me.rpiProceso = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
        Me.RepositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.meComments = New DevExpress.XtraEditors.MemoEdit()
        Me.tePhone = New DevExpress.XtraEditors.TextEdit()
        Me.teMail = New DevExpress.XtraEditors.TextEdit()
        Me.teSector = New DevExpress.XtraEditors.TextEdit()
        Me.teContactName = New DevExpress.XtraEditors.TextEdit()
        Me.teSubject = New DevExpress.XtraEditors.TextEdit()
        Me.teCompany = New DevExpress.XtraEditors.TextEdit()
        Me.teDocumentNumber = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.lueDocumentType = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.vpInputs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bmActions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpiProceso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.meComments.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tePhone.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teMail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teSector.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teContactName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teSubject.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teCompany.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teDocumentNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueDocumentType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'brBarraAcciones
        '
        Me.brBarraAcciones.BarName = "Custom 5"
        Me.brBarraAcciones.DockCol = 0
        Me.brBarraAcciones.DockRow = 0
        Me.brBarraAcciones.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.brBarraAcciones.FloatLocation = New System.Drawing.Point(279, 188)
        Me.brBarraAcciones.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bbiSendMail, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bbiClose, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.brBarraAcciones.OptionsBar.AllowQuickCustomization = False
        Me.brBarraAcciones.OptionsBar.UseWholeRow = True
        Me.brBarraAcciones.Text = "Custom 5"
        '
        'bbiSendMail
        '
        Me.bbiSendMail.Caption = "&Enviar Solicitud"
        Me.bbiSendMail.Id = 33
        Me.bbiSendMail.ImageOptions.Image = CType(resources.GetObject("bbiSendMail.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiSendMail.ImageOptions.LargeImage = CType(resources.GetObject("bbiSendMail.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.bbiSendMail.Name = "bbiSendMail"
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
        Me.bmActions.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.brsDescripcion, Me.bbiSendMail, Me.bbiClose, Me.bbiExport, Me.bbiViewer})
        Me.bmActions.MaxItemId = 28
        Me.bmActions.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpiProceso, Me.RepositoryItemImageComboBox1})
        Me.bmActions.TransparentEditorsMode = DevExpress.Utils.DefaultBoolean.[False]
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl1.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl1.Manager = Me.bmActions
        Me.BarDockControl1.Size = New System.Drawing.Size(855, 41)
        '
        'BarDockControl2
        '
        Me.BarDockControl2.CausesValidation = False
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl2.Location = New System.Drawing.Point(0, 425)
        Me.BarDockControl2.Manager = Me.bmActions
        Me.BarDockControl2.Size = New System.Drawing.Size(855, 27)
        '
        'BarDockControl3
        '
        Me.BarDockControl3.CausesValidation = False
        Me.BarDockControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl3.Location = New System.Drawing.Point(0, 41)
        Me.BarDockControl3.Manager = Me.bmActions
        Me.BarDockControl3.Size = New System.Drawing.Size(0, 384)
        '
        'BarDockControl4
        '
        Me.BarDockControl4.CausesValidation = False
        Me.BarDockControl4.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl4.Location = New System.Drawing.Point(855, 41)
        Me.BarDockControl4.Manager = Me.bmActions
        Me.BarDockControl4.Size = New System.Drawing.Size(0, 384)
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
        Me.PanelControl1.Controls.Add(Me.meComments)
        Me.PanelControl1.Controls.Add(Me.tePhone)
        Me.PanelControl1.Controls.Add(Me.teMail)
        Me.PanelControl1.Controls.Add(Me.teSector)
        Me.PanelControl1.Controls.Add(Me.teContactName)
        Me.PanelControl1.Controls.Add(Me.teSubject)
        Me.PanelControl1.Controls.Add(Me.teCompany)
        Me.PanelControl1.Controls.Add(Me.teDocumentNumber)
        Me.PanelControl1.Controls.Add(Me.LabelControl22)
        Me.PanelControl1.Controls.Add(Me.LabelControl21)
        Me.PanelControl1.Controls.Add(Me.LabelControl6)
        Me.PanelControl1.Controls.Add(Me.lueDocumentType)
        Me.PanelControl1.Controls.Add(Me.LabelControl7)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.LabelControl5)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 41)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(855, 384)
        Me.PanelControl1.TabIndex = 4
        '
        'meComments
        '
        Me.meComments.Location = New System.Drawing.Point(140, 235)
        Me.meComments.MenuManager = Me.bmActions
        Me.meComments.Name = "meComments"
        Me.meComments.Size = New System.Drawing.Size(413, 126)
        Me.meComments.TabIndex = 8
        '
        'tePhone
        '
        Me.tePhone.Location = New System.Drawing.Point(140, 182)
        Me.tePhone.Name = "tePhone"
        Me.tePhone.Size = New System.Drawing.Size(181, 20)
        Me.tePhone.TabIndex = 6
        '
        'teMail
        '
        Me.teMail.Location = New System.Drawing.Point(140, 156)
        Me.teMail.Name = "teMail"
        Me.teMail.Size = New System.Drawing.Size(283, 20)
        Me.teMail.TabIndex = 5
        '
        'teSector
        '
        Me.teSector.Location = New System.Drawing.Point(140, 130)
        Me.teSector.Name = "teSector"
        Me.teSector.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.teSector.Size = New System.Drawing.Size(283, 20)
        Me.teSector.TabIndex = 4
        '
        'teContactName
        '
        Me.teContactName.Location = New System.Drawing.Point(140, 104)
        Me.teContactName.Name = "teContactName"
        Me.teContactName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.teContactName.Size = New System.Drawing.Size(413, 20)
        Me.teContactName.TabIndex = 3
        '
        'teSubject
        '
        Me.teSubject.Location = New System.Drawing.Point(140, 208)
        Me.teSubject.Name = "teSubject"
        Me.teSubject.Size = New System.Drawing.Size(413, 20)
        Me.teSubject.TabIndex = 7
        '
        'teCompany
        '
        Me.teCompany.Location = New System.Drawing.Point(140, 78)
        Me.teCompany.Name = "teCompany"
        Me.teCompany.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.teCompany.Size = New System.Drawing.Size(413, 20)
        Me.teCompany.TabIndex = 2
        '
        'teDocumentNumber
        '
        Me.teDocumentNumber.Location = New System.Drawing.Point(140, 52)
        Me.teDocumentNumber.MenuManager = Me.bmActions
        Me.teDocumentNumber.Name = "teDocumentNumber"
        Me.teDocumentNumber.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.teDocumentNumber.Size = New System.Drawing.Size(181, 20)
        Me.teDocumentNumber.TabIndex = 1
        '
        'LabelControl22
        '
        Me.LabelControl22.Location = New System.Drawing.Point(91, 185)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl22.TabIndex = 8
        Me.LabelControl22.Text = "Teléfono"
        '
        'LabelControl21
        '
        Me.LabelControl21.Location = New System.Drawing.Point(100, 159)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl21.TabIndex = 9
        Me.LabelControl21.Text = "Correo"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(102, 133)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl6.TabIndex = 10
        Me.LabelControl6.Text = "Sector"
        '
        'lueDocumentType
        '
        Me.lueDocumentType.Location = New System.Drawing.Point(140, 25)
        Me.lueDocumentType.MenuManager = Me.bmActions
        Me.lueDocumentType.Name = "lueDocumentType"
        Me.lueDocumentType.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lueDocumentType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueDocumentType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DescripcionTipoDocumento", "Tipo de Documento")})
        Me.lueDocumentType.Properties.NullText = ""
        Me.lueDocumentType.Size = New System.Drawing.Size(226, 20)
        Me.lueDocumentType.TabIndex = 0
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(74, 237)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl7.TabIndex = 12
        Me.LabelControl7.Text = "Comentarios"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(100, 211)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl1.TabIndex = 12
        Me.LabelControl1.Text = "Asunto"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(35, 107)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(99, 13)
        Me.LabelControl5.TabIndex = 11
        Me.LabelControl5.Text = "Nombre de Contacto"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(92, 81)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl4.TabIndex = 12
        Me.LabelControl4.Text = "Empresa"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(25, 55)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(109, 13)
        Me.LabelControl3.TabIndex = 13
        Me.LabelControl3.Text = "Número de Documento"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(41, 28)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(92, 13)
        Me.LabelControl2.TabIndex = 14
        Me.LabelControl2.Text = "Tipo de Documento"
        '
        'ContactUsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(855, 452)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.BarDockControl3)
        Me.Controls.Add(Me.BarDockControl4)
        Me.Controls.Add(Me.BarDockControl2)
        Me.Controls.Add(Me.BarDockControl1)
        Me.Name = "ContactUsForm"
        Me.Text = "Contáctanos"
        CType(Me.vpInputs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bmActions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpiProceso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.meComments.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tePhone.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teMail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teSector.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teContactName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teSubject.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teCompany.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teDocumentNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueDocumentType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents brBarraAcciones As DevExpress.XtraBars.Bar
    Private WithEvents bbiSendMail As DevExpress.XtraBars.BarButtonItem
    Private WithEvents bbiClose As DevExpress.XtraBars.BarButtonItem
    Private WithEvents bar5 As DevExpress.XtraBars.Bar
    Private WithEvents brsDescripcion As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents vpInputs As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Private WithEvents bmActions As DevExpress.XtraBars.BarManager
    Private WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Private WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
    Private WithEvents BarDockControl3 As DevExpress.XtraBars.BarDockControl
    Private WithEvents BarDockControl4 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents bbiExport As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiViewer As DevExpress.XtraBars.BarButtonItem
    Private WithEvents rpiProceso As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Friend WithEvents RepositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents meComments As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents tePhone As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teMail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teSector As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teContactName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teSubject As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teCompany As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teDocumentNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lueDocumentType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
End Class

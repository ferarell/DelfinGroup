<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EndoseVirtualForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EndoseVirtualForm))
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.SplitContainerControl2 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.sbCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.sbSave = New DevExpress.XtraEditors.SimpleButton()
        Me.beLoadFiles = New DevExpress.XtraEditors.ButtonEdit()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.XtraOpenFileDialog1 = New DevExpress.XtraEditors.XtraOpenFileDialog()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl2.SuspendLayout()
        CType(Me.beLoadFiles.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel2
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.SplitContainerControl2)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.GridControl1)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(834, 488)
        Me.SplitContainerControl1.SplitterPosition = 165
        Me.SplitContainerControl1.TabIndex = 0
        '
        'SplitContainerControl2
        '
        Me.SplitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl2.Name = "SplitContainerControl2"
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.sbCancel)
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.sbSave)
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.beLoadFiles)
        Me.SplitContainerControl2.Panel1.Text = "Panel1"
        Me.SplitContainerControl2.Panel2.Controls.Add(Me.GridControl2)
        Me.SplitContainerControl2.Panel2.Text = "Panel2"
        Me.SplitContainerControl2.Size = New System.Drawing.Size(834, 165)
        Me.SplitContainerControl2.SplitterPosition = 541
        Me.SplitContainerControl2.TabIndex = 0
        '
        'sbCancel
        '
        Me.sbCancel.ImageOptions.Image = CType(resources.GetObject("sbCancel.ImageOptions.Image"), System.Drawing.Image)
        Me.sbCancel.Location = New System.Drawing.Point(288, 91)
        Me.sbCancel.Name = "sbCancel"
        Me.sbCancel.Size = New System.Drawing.Size(91, 39)
        Me.sbCancel.TabIndex = 1
        Me.sbCancel.Text = "Cancelar"
        '
        'sbSave
        '
        Me.sbSave.ImageOptions.Image = CType(resources.GetObject("sbSave.ImageOptions.Image"), System.Drawing.Image)
        Me.sbSave.Location = New System.Drawing.Point(191, 91)
        Me.sbSave.Name = "sbSave"
        Me.sbSave.Size = New System.Drawing.Size(91, 39)
        Me.sbSave.TabIndex = 1
        Me.sbSave.Text = "Guardar"
        '
        'beLoadFiles
        '
        Me.beLoadFiles.Location = New System.Drawing.Point(27, 47)
        Me.beLoadFiles.Name = "beLoadFiles"
        Me.beLoadFiles.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.beLoadFiles.Size = New System.Drawing.Size(352, 20)
        Me.beLoadFiles.TabIndex = 0
        '
        'GridControl2
        '
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(0, 0)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit2, Me.RepositoryItemLookUpEdit3})
        Me.GridControl2.Size = New System.Drawing.Size(289, 165)
        Me.GridControl2.TabIndex = 2
        Me.GridControl2.UseEmbeddedNavigator = True
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn4, Me.GridColumn3})
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.ShowAutoFilterRow = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Archivo Adjunto"
        Me.GridColumn1.FieldName = "FileName Attached"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Original File Location"
        Me.GridColumn2.FieldName = "OriginalFileLocation"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Tamaño del Archivo"
        Me.GridColumn4.FieldName = "FileSize"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Propiedades del Archivo"
        Me.GridColumn3.FieldName = "FileProperties"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 3
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ConceptCode", "Código"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ConceptName", "Descripción"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CountryCode", "Country", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.NullText = ""
        '
        'RepositoryItemLookUpEdit3
        '
        Me.RepositoryItemLookUpEdit3.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.RepositoryItemLookUpEdit3.AutoHeight = False
        Me.RepositoryItemLookUpEdit3.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.RepositoryItemLookUpEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit3.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CurrencyCode", "Código"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CurrencyName", "Descripción"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.RepositoryItemLookUpEdit3.Name = "RepositoryItemLookUpEdit3"
        Me.RepositoryItemLookUpEdit3.NullText = ""
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(834, 319)
        Me.GridControl1.TabIndex = 1
        Me.GridControl1.UseEmbeddedNavigator = True
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        '
        'XtraOpenFileDialog1
        '
        Me.XtraOpenFileDialog1.FileName = "XtraOpenFileDialog1"
        Me.XtraOpenFileDialog1.Multiselect = True
        '
        'EndoseVirtualForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 488)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Name = "EndoseVirtualForm"
        Me.Text = "EndoseVirtualForm"
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl2.ResumeLayout(False)
        CType(Me.beLoadFiles.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents SplitContainerControl2 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents sbCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sbSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents beLoadFiles As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XtraOpenFileDialog1 As DevExpress.XtraEditors.XtraOpenFileDialog
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
End Class

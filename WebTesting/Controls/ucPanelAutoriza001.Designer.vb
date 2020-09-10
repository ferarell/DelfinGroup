<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucPanelAutoriza001
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.teCompany = New DevExpress.XtraEditors.TextEdit()
        Me.teDocumentNumber = New DevExpress.XtraEditors.TextEdit()
        Me.lueDocumentType = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.deDateTo = New DevExpress.XtraEditors.DateEdit()
        Me.deDateFrom = New DevExpress.XtraEditors.DateEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.teMail = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
        Me.lueValidityType = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueRelationType = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.teCompany.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teDocumentNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueDocumentType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deDateTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deDateTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deDateFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deDateFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teMail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueValidityType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueRelationType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.AutoSize = True
        Me.PanelControl1.Controls.Add(Me.deDateTo)
        Me.PanelControl1.Controls.Add(Me.deDateFrom)
        Me.PanelControl1.Controls.Add(Me.Label3)
        Me.PanelControl1.Controls.Add(Me.Label4)
        Me.PanelControl1.Controls.Add(Me.teMail)
        Me.PanelControl1.Controls.Add(Me.LabelControl21)
        Me.PanelControl1.Controls.Add(Me.lueValidityType)
        Me.PanelControl1.Controls.Add(Me.lueRelationType)
        Me.PanelControl1.Controls.Add(Me.LabelControl6)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.teCompany)
        Me.PanelControl1.Controls.Add(Me.teDocumentNumber)
        Me.PanelControl1.Controls.Add(Me.lueDocumentType)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(667, 262)
        Me.PanelControl1.TabIndex = 0
        '
        'teCompany
        '
        Me.teCompany.Location = New System.Drawing.Point(129, 74)
        Me.teCompany.Name = "teCompany"
        Me.teCompany.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.teCompany.Size = New System.Drawing.Size(413, 20)
        Me.teCompany.TabIndex = 9
        '
        'teDocumentNumber
        '
        Me.teDocumentNumber.Location = New System.Drawing.Point(129, 48)
        Me.teDocumentNumber.Name = "teDocumentNumber"
        Me.teDocumentNumber.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.teDocumentNumber.Size = New System.Drawing.Size(181, 20)
        Me.teDocumentNumber.TabIndex = 8
        '
        'lueDocumentType
        '
        Me.lueDocumentType.Location = New System.Drawing.Point(129, 21)
        Me.lueDocumentType.Name = "lueDocumentType"
        Me.lueDocumentType.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lueDocumentType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueDocumentType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DescripcionTipoDocumento", "Tipo de Documento"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodigoTipoDocumento", "CodigoTipoDocumento", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.lueDocumentType.Properties.NullText = ""
        Me.lueDocumentType.Size = New System.Drawing.Size(283, 20)
        Me.lueDocumentType.TabIndex = 7
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(81, 77)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl4.TabIndex = 4
        Me.LabelControl4.Text = "Empresa"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(14, 51)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(109, 13)
        Me.LabelControl3.TabIndex = 5
        Me.LabelControl3.Text = "Número de Documento"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(30, 24)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(92, 13)
        Me.LabelControl2.TabIndex = 6
        Me.LabelControl2.Text = "Tipo de Documento"
        '
        'deDateTo
        '
        Me.deDateTo.EditValue = Nothing
        Me.deDateTo.Location = New System.Drawing.Point(129, 201)
        Me.deDateTo.Margin = New System.Windows.Forms.Padding(2)
        Me.deDateTo.Name = "deDateTo"
        Me.deDateTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deDateTo.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deDateTo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.deDateTo.Size = New System.Drawing.Size(98, 20)
        Me.deDateTo.TabIndex = 39
        '
        'deDateFrom
        '
        Me.deDateFrom.EditValue = Nothing
        Me.deDateFrom.Location = New System.Drawing.Point(129, 177)
        Me.deDateFrom.Margin = New System.Windows.Forms.Padding(2)
        Me.deDateFrom.Name = "deDateFrom"
        Me.deDateFrom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deDateFrom.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deDateFrom.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.deDateFrom.Size = New System.Drawing.Size(98, 20)
        Me.deDateFrom.TabIndex = 38
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 180)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Vigencia Desde"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(48, 204)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Vigencia Hasta"
        '
        'teMail
        '
        Me.teMail.Location = New System.Drawing.Point(129, 100)
        Me.teMail.Name = "teMail"
        Me.teMail.Size = New System.Drawing.Size(283, 20)
        Me.teMail.TabIndex = 35
        '
        'LabelControl21
        '
        Me.LabelControl21.Location = New System.Drawing.Point(89, 103)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl21.TabIndex = 40
        Me.LabelControl21.Text = "Correo"
        '
        'lueValidityType
        '
        Me.lueValidityType.Location = New System.Drawing.Point(129, 152)
        Me.lueValidityType.Name = "lueValidityType"
        Me.lueValidityType.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lueValidityType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueValidityType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DescripcionTipoVigencia", "Tipo de Vigencia"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodigoTipoVigencia", "CodigoTipoVigencia", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ValidaFechas", "ValidaFechas", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.lueValidityType.Properties.NullText = ""
        Me.lueValidityType.Size = New System.Drawing.Size(226, 20)
        Me.lueValidityType.TabIndex = 37
        '
        'lueRelationType
        '
        Me.lueRelationType.Location = New System.Drawing.Point(129, 126)
        Me.lueRelationType.Name = "lueRelationType"
        Me.lueRelationType.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lueRelationType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueRelationType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DescripcionTipoVinculacion", "Tipo de Vinculación"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodigoTipoVinculacion", "CodigoTipoVinculacion", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.lueRelationType.Properties.NullText = ""
        Me.lueRelationType.Size = New System.Drawing.Size(226, 20)
        Me.lueRelationType.TabIndex = 36
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(45, 155)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(77, 13)
        Me.LabelControl6.TabIndex = 41
        Me.LabelControl6.Text = "Tipo de Vigencia"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(35, 129)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(90, 13)
        Me.LabelControl1.TabIndex = 42
        Me.LabelControl1.Text = "Tipo de Vinculación"
        '
        'ucPanelAutoriza001
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "ucPanelAutoriza001"
        Me.Size = New System.Drawing.Size(806, 395)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.teCompany.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teDocumentNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueDocumentType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deDateTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deDateTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deDateFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deDateFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teMail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueValidityType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueRelationType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents teCompany As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teDocumentNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lueDocumentType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents deDateTo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents deDateFrom As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents teMail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lueValidityType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueRelationType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class

Partial Class CustomizedRibbon
    Inherits Microsoft.Office.Tools.Ribbon.RibbonBase

    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New(ByVal container As System.ComponentModel.IContainer)
        MyClass.New()

        'Requerido para la compatibilidad con el Diseñador de composiciones de clases Windows.Forms
        If (container IsNot Nothing) Then
            container.Add(Me)
        End If

    End Sub

    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New()
        MyBase.New(Globals.Factory.GetRibbonFactory())

        'El Diseñador de componentes requiere esta llamada.
        InitializeComponent()

    End Sub

    'Component invalida a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de componentes
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de componentes requiere el siguiente procedimiento
    'Se puede modificar usando el Diseñador de componentes.
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomizedRibbon))
        Me.Tab1 = Me.Factory.CreateRibbonTab
        Me.Group1 = Me.Factory.CreateRibbonGroup
        Me.Tab2 = Me.Factory.CreateRibbonTab
        Me.Group2 = Me.Factory.CreateRibbonGroup
        Me.btResultadoOperativoV1 = Me.Factory.CreateRibbonButton
        Me.btResultadoOperativoV2 = Me.Factory.CreateRibbonButton
        Me.btResultadoOperativoV3 = Me.Factory.CreateRibbonButton
        Me.Tab1.SuspendLayout()
        Me.Tab2.SuspendLayout()
        Me.Group2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tab1
        '
        Me.Tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office
        Me.Tab1.Groups.Add(Me.Group1)
        Me.Tab1.Label = "TabAddIns"
        Me.Tab1.Name = "Tab1"
        '
        'Group1
        '
        Me.Group1.Label = "Group1"
        Me.Group1.Name = "Group1"
        '
        'Tab2
        '
        Me.Tab2.Groups.Add(Me.Group2)
        Me.Tab2.Label = "DELFIN GROUP PERÚ"
        Me.Tab2.Name = "Tab2"
        '
        'Group2
        '
        Me.Group2.Items.Add(Me.btResultadoOperativoV1)
        Me.Group2.Items.Add(Me.btResultadoOperativoV2)
        Me.Group2.Items.Add(Me.btResultadoOperativoV3)
        Me.Group2.Label = "Resultados"
        Me.Group2.Name = "Group2"
        '
        'btResultadoOperativoV1
        '
        Me.btResultadoOperativoV1.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.btResultadoOperativoV1.Image = CType(resources.GetObject("btResultadoOperativoV1.Image"), System.Drawing.Image)
        Me.btResultadoOperativoV1.Label = "Operativo v.1"
        Me.btResultadoOperativoV1.Name = "btResultadoOperativoV1"
        Me.btResultadoOperativoV1.ShowImage = True
        '
        'btResultadoOperativoV2
        '
        Me.btResultadoOperativoV2.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.btResultadoOperativoV2.Image = CType(resources.GetObject("btResultadoOperativoV2.Image"), System.Drawing.Image)
        Me.btResultadoOperativoV2.Label = "Operativo v.2"
        Me.btResultadoOperativoV2.Name = "btResultadoOperativoV2"
        Me.btResultadoOperativoV2.ShowImage = True
        '
        'btResultadoOperativoV3
        '
        Me.btResultadoOperativoV3.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.btResultadoOperativoV3.Image = CType(resources.GetObject("btResultadoOperativoV3.Image"), System.Drawing.Image)
        Me.btResultadoOperativoV3.Label = "Operativo v.3"
        Me.btResultadoOperativoV3.Name = "btResultadoOperativoV3"
        Me.btResultadoOperativoV3.ShowImage = True
        '
        'CustomizedRibbon
        '
        Me.Name = "CustomizedRibbon"
        Me.RibbonType = "Microsoft.Excel.Workbook"
        Me.Tabs.Add(Me.Tab1)
        Me.Tabs.Add(Me.Tab2)
        Me.Tab1.ResumeLayout(False)
        Me.Tab1.PerformLayout()
        Me.Tab2.ResumeLayout(False)
        Me.Tab2.PerformLayout()
        Me.Group2.ResumeLayout(False)
        Me.Group2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Tab1 As Microsoft.Office.Tools.Ribbon.RibbonTab
    Friend WithEvents Group1 As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents Tab2 As Microsoft.Office.Tools.Ribbon.RibbonTab
    Friend WithEvents Group2 As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents btResultadoOperativoV1 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents btResultadoOperativoV2 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents btResultadoOperativoV3 As Microsoft.Office.Tools.Ribbon.RibbonButton
End Class

Partial Class ThisRibbonCollection

    <System.Diagnostics.DebuggerNonUserCode()> _
    Friend ReadOnly Property Ribbon1() As CustomizedRibbon
        Get
            Return Me.GetRibbon(Of CustomizedRibbon)()
        End Get
    End Property
End Class

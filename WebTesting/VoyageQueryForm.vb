Imports System.IO
Imports System.Runtime.InteropServices
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraSplashScreen
Imports Microsoft.Office.Interop

Public Class VoyageQueryForm

    Private oAppService As New OnlineService.OnLineServiceClient

    Private Sub VoyageQueryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GridView1.RestoreLayoutFromRegistry(Directory.GetCurrentDirectory)
        GridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True
        GridView1.ColumnPanelRowHeight = 4
        GridView1.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        TimerRefresh.Enabled = False
        ShowData()
        FitColumns()
    End Sub

    Private Sub ShowData()
        Dim dtQuery As New DataTable
        'dtQuery = oAppService.VoyageQuery(10)
        Dim drlist As New Object
        drlist = oAppService.VoyageQueryList
        gcMainData.DataSource = drlist
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles TimerRefresh.Tick
        Try
            Dim info As GridViewInfo = TryCast(GridView1.GetViewInfo(), GridViewInfo)
            Dim GridRowInfo As GridRowInfo = info.GetGridRowInfo(GridView1.FocusedRowHandle)
            ShowData()
            If GridRowInfo.RowHandle > 0 Then
                GridView1.MoveBy(GridRowInfo.RowHandle)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub VoyageQueryForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        TimerRefresh.Interval = My.Settings.TimeRefresh * 1000
        TimerRefresh.Start()
    End Sub

    Private Sub NotifyIcon_DoubleClick(sender As Object, e As EventArgs)
        Me.Show()
        TimerRefresh.Start()
    End Sub

    Private Sub FitColumns()
        For c = 0 To GridView1.Columns.Count - 1
            GridView1.Columns.Item(c).BestFit()
        Next
    End Sub

    Friend Sub ExportToExcel(sender As DevExpress.XtraGrid.GridControl)
        Dim oGridView As New GridView
        oGridView = sender.FocusedView
        Dim sPath As String = Path.GetTempPath
        Dim sFileName = ""
        oGridView.OptionsPrint.AutoWidth = False
        oGridView.BestFitColumns()
        oGridView.BestFitMaxRowCount = oGridView.RowCount
        sFileName = (FileIO.FileSystem.GetTempFileName).Replace(".tmp", ".xlsx")
        oGridView.ExportToXlsx(sFileName)
        If IO.File.Exists(sFileName) Then
            Dim oXls As New Excel.Application 'Crea el objeto excel 
            oXls.Workbooks.Open(sFileName, , False) 'El true es para abrir el archivo en modo Solo lectura (False si lo quieres de otro modo)
            oXls.Visible = True
            oXls.WindowState = Excel.XlWindowState.xlMaximized 'Para que la ventana aparezca maximizada.
        End If
    End Sub

    Private Sub GridView1_LayoutUpgrade(sender As Object, e As DevExpress.Utils.LayoutUpgradeEventArgs) Handles GridView1.LayoutUpgrade
        GridView1.SaveLayoutToRegistry(Directory.GetCurrentDirectory)
    End Sub

    Private Sub bbiExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExport.ItemClick
        ExportToExcel(gcMainData)
    End Sub

    Private Sub bbiClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiClose.ItemClick
        Close()
    End Sub
End Class
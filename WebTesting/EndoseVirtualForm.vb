
Imports System.IO
Imports DevExpress.XtraSplashScreen
Imports Microsoft.SharePoint.Client

Public Class EndoseVirtualForm
    Dim dtFiles As New DataTable
    Dim oSharePointTransactions As New SharePointListTransactions

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        oSharePointTransactions.SharePointUrl = My.Settings.SharePoint_Url

    End Sub

    Private Sub EndoseVirtualForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataSourceCreate()
        GridControl2.DataSource = dtFiles
    End Sub

    Private Sub DataSourceCreate()
        dtFiles.Columns.Add("FileName", GetType(String)).AllowDBNull = True
        dtFiles.Columns.Add("OriginalFileLocation", GetType(String)).AllowDBNull = True
        dtFiles.Columns.Add("FileSize", GetType(Decimal)).AllowDBNull = True
        dtFiles.Columns.Add("FileProperties", GetType(String)).AllowDBNull = True
    End Sub

    Private Sub beLoadFiles_Properties_Click(sender As Object, e As EventArgs) Handles beLoadFiles.Properties.Click
        If XtraOpenFileDialog1.ShowDialog() = DialogResult.OK Then
            For f = 0 To XtraOpenFileDialog1.FileNames.Count - 1
                Dim fileInfo As New FileInfo(XtraOpenFileDialog1.FileNames(f))
                dtFiles.Rows.Add()
                dtFiles.Rows(f)("FileName") = Path.GetFileName(XtraOpenFileDialog1.FileNames(f))
                dtFiles.Rows(f)("OriginalFileLocation") = Path.GetDirectoryName(XtraOpenFileDialog1.FileNames(f))
                dtFiles.Rows(f)("FileSize") = fileInfo.Length
                dtFiles.Rows(f)("FileProperties") = fileInfo.ToString
            Next
        End If
    End Sub

    Private Sub sbCancel_Click(sender As Object, e As EventArgs) Handles sbCancel.Click
        Close()
    End Sub

    Private Sub sbSave_Click(sender As Object, e As EventArgs) Handles sbSave.Click
        Dim drFileUpLoad As DataRow = dtFiles.Rows(0)
        SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)
        SplashScreenManager.Default.SetWaitFormDescription("Guardando Endose Virtual")
        oSharePointTransactions.SharePointList = "Test"
        oSharePointTransactions.SharePointFileAttach.Clear()
        oSharePointTransactions.ValuesList.Clear()
        oSharePointTransactions.ValuesList.Add({"FileName", drFileUpLoad("FileName")})
        oSharePointTransactions.ValuesList.Add({"OriginalFileLocation", drFileUpLoad("OriginalFileLocation")})
        oSharePointTransactions.ValuesList.Add({"FileSize", drFileUpLoad("FileSize")})
        oSharePointTransactions.ValuesList.Add({"FileProperties", drFileUpLoad("FileProperties")})
        For i = 0 To dtFiles.Rows.Count - 1
            Dim drFileUpLoad1 As DataRow = dtFiles.Rows(i)
            oSharePointTransactions.SharePointFileAttach.Add({drFileUpLoad1("OriginalFileLocation"), drFileUpLoad1("FileName"), drFileUpLoad1("FileProperties")})
        Next
        oSharePointTransactions.InsertItem()
        SplashScreenManager.CloseForm(False)
    End Sub
End Class
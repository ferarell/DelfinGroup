Imports System.IO
Imports System.Runtime.InteropServices
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraSplashScreen
Imports Microsoft.Office.Interop
'Imports Microsoft.Office.Interop.Outlook

Public Class VoyageQueryForm

    Dim oAppService As New AppService.DelfinServiceClient

    Private Sub VoyageQueryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GridView1.RestoreLayoutFromRegistry(Directory.GetCurrentDirectory)
        SplitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
        Me.Text = My.Application.Info.Title & String.Format(" [{0}] ", My.Application.Info.Version.ToString)
        gcEstilos.Height = 450
        GridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True
        GridView1.ColumnPanelRowHeight = 4
        GridView1.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        NotifyIcon.Visible = True
        FillOperators()
        LoadPreferences()
        ApplyUserAccess
        ShowData()
        FitColumns()
        bbiUserApp.Caption = "Usuario: " & My.User.Name
    End Sub

    Private Sub ShowData()
        Dim dtQuery As New DataTable
        dtQuery = oAppService.ExecuteSQL("EXEC NextSoft.dgp.paConsultaNaves '" & Format(DateAdd(DateInterval.Day, My.Settings.DaysInterval * -1, Now), "yyyyMMdd") & "','" & Format(DateAdd(DateInterval.Day, My.Settings.DaysInterval, Now), "yyyyMMdd") & "'").Tables(0)
        gcMainData.DataSource = dtQuery
    End Sub

    Private Sub ApplyUserAccess()
        Dim dtUsers As New DataTable
        dtUsers = oAppService.ExecuteSQL("select UserName FROM NextSoft.dgp.AplicacionesPermisosUsuario WHERE ApplicationName = '" & My.Settings.AppName & "'").Tables(0)
        'For r = 0 To dtUsers.Rows.Count - 1
        'Dim drUser As DataRow = dtUsers.Rows(r)
        If dtUsers.Select("UserName='" & My.User.Name & "'").Length = 0 Then
            RepositoryItemLookUpEdit1.Buttons(1).Enabled = False
            GridView1.Columns("OperadorNave").OptionsColumn.ReadOnly = True
            GridView1.Columns("NaveEntregada").OptionsColumn.ReadOnly = True
        End If

        'Next
    End Sub

    Private Sub FillOperators()
        Dim dtQuery As New DataTable
        dtQuery = oAppService.ExecuteSQL("EXEC NextSoft.dgp.paListaOperadorNave").Tables(0)
        RepositoryItemLookUpEdit1.DataSource = dtQuery
        RepositoryItemLookUpEdit1.DisplayMember = "OperadorNave"
        RepositoryItemLookUpEdit1.ValueMember = "OperadorNave"
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
        tsRefresh.EditValue = TimerRefresh.Enabled
    End Sub

    Private Sub NotifyIcon_DoubleClick(sender As Object, e As EventArgs) Handles NotifyIcon.DoubleClick
        Me.Show()
        TimerRefresh.Start()
    End Sub

    Private Sub VoyageQueryForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        TimerRefresh.Stop()
        Me.Hide()
        e.Cancel = True
    End Sub

    Private Sub WindowsUIButtonPanel1_ButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles WindowsUIButtonPanel1.ButtonClick
        If e.Button.Properties.Tag = 0 Then
            If SplitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2 Then
                SplitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Both
            Else
                LoadPreferences()
                SplitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
            End If
        End If
        If e.Button.Properties.Tag = 1 Then
            Timer1_Tick(sender, e)
            'GridView1.PopulateColumns()
        End If
        If e.Button.Properties.Tag = 2 Then
            ExportToExcel(gcMainData)
        End If
    End Sub

    Friend Sub LoadPreferences()
        DefaultLookAndFeel1.LookAndFeel.SkinName = My.Settings.LookAndFeel
        For Each cnt In DevExpress.Skins.SkinManager.Default.Skins
            lbcEstilos.Items.Add(cnt.SkinName)
        Next
        Me.LookAndFeel.Assign(DefaultLookAndFeel1.LookAndFeel)
        lbcEstilos.SelectedValue = Me.LookAndFeel.SkinName
        tsSpeech.EditValue = My.Settings.SpeechEnabled
        seRefreshInterval.EditValue = My.Settings.TimeRefresh
        seDaysInterval.EditValue = My.Settings.DaysInterval

    End Sub

    Private Sub FitColumns()
        For c = 0 To GridView1.Columns.Count - 1
            GridView1.Columns.Item(c).BestFit()
        Next
    End Sub

    Private Sub lbcEstilos_Click(sender As Object, e As EventArgs) Handles lbcEstilos.Click
        DefaultLookAndFeel1.LookAndFeel.SkinName = lbcEstilos.SelectedValue
        My.Settings.LookAndFeel = DefaultLookAndFeel1.LookAndFeel.SkinName
        My.Settings.Save()
    End Sub

    Private Sub tsSpeech_Toggled(sender As Object, e As EventArgs) Handles tsSpeech.Toggled
        My.Settings.SpeechEnabled = tsSpeech.EditValue
        My.Settings.Save()
    End Sub

    Private Sub tsRefresh_Toggled(sender As Object, e As EventArgs) Handles tsRefresh.Toggled
        Validate()
        TimerRefresh.Enabled = tsRefresh.EditValue
    End Sub

    Private Sub ToolStripTextBox1_Click(sender As Object, e As EventArgs) Handles ToolStripTextBox1.Click
        NotifyIcon.Visible = False
        End
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

    Private Sub seRefreshInterval_EditValueChanged(sender As Object, e As EventArgs) Handles seRefreshInterval.EditValueChanged
        Validate()
        My.Settings.TimeRefresh = seRefreshInterval.EditValue
        My.Settings.Save()
        TimerRefresh.Interval = My.Settings.TimeRefresh * 1000
    End Sub

    Private Sub seDaysInterval_EditValueChanged(sender As Object, e As EventArgs) Handles seDaysInterval.EditValueChanged
        Validate()
        My.Settings.DaysInterval = seDaysInterval.EditValue
        My.Settings.Save()
        seDaysInterval.EditValue = My.Settings.DaysInterval
    End Sub

    Private Sub GridView1_LayoutUpgrade(sender As Object, e As DevExpress.Utils.LayoutUpgradeEventArgs) Handles GridView1.LayoutUpgrade
        GridView1.SaveLayoutToRegistry(Directory.GetCurrentDirectory)
    End Sub

    Private Sub RepositoryItemLookUpEdit1_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles RepositoryItemLookUpEdit1.ButtonClick
        If e.Button.Index = 0 Then
            TimerRefresh.Enabled = False
        ElseIf e.Button.Index = 1 Then
            If DevExpress.XtraEditors.XtraMessageBox.Show("Está seguro de aplicar la nueva asignación?", "Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                Return
            End If
            If OperatorUpdate() Then
                DevExpress.XtraEditors.XtraMessageBox.Show("El operador ha sido asignado satisfactoriamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                DevExpress.XtraEditors.XtraMessageBox.Show("Se generó un error al asignar el operador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            TimerRefresh.Enabled = True
        End If
    End Sub

    Function OperatorUpdate() As Boolean
        Validate()
        Dim bResult As Boolean = True
        bResult = oAppService.ExecuteSQLNonQuery("EXEC NextSoft.dgp.paAsignaOperadorNave " & GridView1.GetFocusedRowCellValue("CodigoNave").ToString & ",'" & GridView1.GetFocusedRowCellValue("OperadorNave").ToString & "'")
        Return bResult
    End Function

    Function VoyageUpdate(IsCheck As Boolean) As Boolean
        Dim bResult As Boolean = True
        If IsCheck Then
            bResult = oAppService.ExecuteSQLNonQuery("EXEC NextSoft.dgp.paAsignaFechaNaveEntregada " & GridView1.GetFocusedRowCellValue("CodigoNave").ToString & ",'" & Format(Now, "yyyyMMdd HH:mm:ss") & "'")
        Else
            bResult = oAppService.ExecuteSQLNonQuery("EXEC NextSoft.dgp.paAsignaFechaNaveEntregada " & GridView1.GetFocusedRowCellValue("CodigoNave").ToString & ",NULL")
        End If

        Return bResult
    End Function

    Private Sub RepositoryItemCheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles RepositoryItemCheckEdit1.CheckedChanged
        TimerRefresh.Enabled = False
        Validate()
        GridView1.CloseEditor()
        If VoyageUpdate(GridView1.GetFocusedRowCellValue("NaveEntregada")) Then
            If GridView1.GetFocusedRowCellValue("NaveEntregada") = True Then
                CreateSendItem()
            End If
        End If
        TimerRefresh.Enabled = True
    End Sub

    Friend Sub CreateSendItem()
        Dim Application As New Outlook.Application
        Dim mail As Outlook.MailItem = Nothing
        Dim mailRecipients As Outlook.Recipients = Nothing
        Dim mailRecipient As Outlook.Recipient = Nothing
        Try
            mail = Application.CreateItem(Outlook.OlItemType.olMailItem)
            mail.Subject = "NAVE ENTREGADA " & GridView1.GetFocusedRowCellValue("NombreNave").ToString & Space(1) & GridView1.GetFocusedRowCellValue("Viaje_Vuelo").ToString
            mail.HTMLBody = "Estimados," & "<br><br>" & "Se entrega la nave de la referencia con la línea naviera " & GridView1.GetFocusedRowCellValue("Transportista").ToString
            If GridView1.GetFocusedRowCellValue("ETA_ETD").ToString <> "" Then
                mail.HTMLBody += " con ETA " & GridView1.GetFocusedRowCellValue("Puerto").ToString & Space(1) & Format(GridView1.GetFocusedRowCellValue("ETA_ETD"), "dd/MM/yyyy")
            End If
            mail.To = "operations@delfingroupco.com.pe; logistica@delfingroupco.com.pe"
            mail.CC = "vistobueno@delfingroupco.com.pe; controller@delfingroupco.com.pe"
            SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)
            SplashScreenManager.Default.SetWaitFormDescription("Creando nuevo mensaje")
            mail.Display()
            SplashScreenManager.CloseForm(False)
        Catch ex As Exception
            SplashScreenManager.CloseForm(False)
            System.Windows.Forms.MessageBox.Show(ex.Message,
                "An exception is occured in the code of add-in.")
        Finally
            If Not IsNothing(mailRecipient) Then Marshal.ReleaseComObject(mailRecipient)
            If Not IsNothing(mailRecipients) Then Marshal.ReleaseComObject(mailRecipients)
            If Not IsNothing(mail) Then Marshal.ReleaseComObject(mail)
        End Try

    End Sub

End Class
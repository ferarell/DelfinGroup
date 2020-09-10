Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports DevExpress.XtraEditors.DXErrorProvider

Public Class ResultadoOperativoForm
    Private Const WM_SYSCOMMAND As Integer = 274
    Private Const SC_MAXIMIZE As Integer = 61488
    Declare Auto Function SetParent Lib "user32.dll" (ByVal hWndChild As IntPtr, ByVal hWndNewParent As IntPtr) As Integer
    Declare Auto Function SendMessage Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer

    'Private oCurrenteExcel As Object
    'Dim oExcel As New Excel.Application
    Dim bChanges As Boolean = False

    Private Sub bbiProcess_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiProcess.ItemClick
        If Not vpInputs.Validate Then
            Return
        End If
        beDataTarget.Text = beDataSource.Text
        'oCurrenteExcel = oExcel
        Dim sExcelFileName = OpenFileDialog1.FileName
        'oExcel.DisplayAlerts = False
        ''oExcel.Workbooks.Open(sExcelFileName, , False)
        'oExcel.Application.WindowState = Excel.XlWindowState.xlMaximized
        'oExcel.Visible = True

        Dim proc As Process
        proc = Process.Start("EXCEL.EXE", "" & sExcelFileName & "")
        proc.WaitForInputIdle()
        SetParent(proc.MainWindowHandle, SplitContainerControl1.Panel2.Handle)
        SendMessage(proc.MainWindowHandle, WM_SYSCOMMAND, SC_MAXIMIZE, 0)

        'SetParent(oExcel.Hwnd, AxWebBrowser1.Handle)
        'SendMessage(oExcel.Hwnd, WM_SYSCOMMAND, SC_MAXIMIZE, 0)
    End Sub

    Private Sub beDataSource_Properties_Click(sender As Object, e As EventArgs) Handles beDataSource.Properties.Click
        Dim FileNames() As String
        OpenFileDialog1.Filter = "Source File (*.xls*)|*.xls*"
        OpenFileDialog1.FileName = ""
        'OpenFileDialog1.InitialDirectory = My.Settings.SDRDataSourcePath
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            FileNames = OpenFileDialog1.FileNames
            beDataSource.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub beDataTarget_Properties_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles beDataTarget.Properties.ButtonClick
        SaveFileDialog1.Filter = "Excel File (*.xls*)|*.xls*"
        SaveFileDialog1.FileName = ""
        'SaveFileDialog1.InitialDirectory = My.Settings.SDRDataTargetPath
        If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            beDataTarget.Text = SaveFileDialog1.FileName & IIf(beDataTarget.Text.Contains(".xlsx"), "", ".xlsx")
        End If
    End Sub

    Private Sub bbiSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSave.ItemClick
        If (IO.File.Exists(beDataTarget.Text)) Then
            If (DevExpress.XtraEditors.XtraMessageBox.Show("Ya existe un archivo con el mismo nombre, desea sobrescribirlo?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No) Then
                Return
            End If
        End If
        'oCurrenteExcel.Workbooks.Item(1).Save()
        'oExcel.ActiveWorkbook.Save()
        'oExcel.ActiveWorkbook.SaveAs(beDataSource.Text)
        'oExcel.ActiveWorkbook.RefreshAll()
        'If Not oExcel.ActiveWorkbook.Saved Then
        '    DevExpress.XtraEditors.XtraMessageBox.Show("Ocurrió un error al guardar los cambios. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Return
        'Else
        '    bChanges = False
        '    DevExpress.XtraEditors.XtraMessageBox.Show("Los cambios fueron guardados satisfactoriamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End If
    End Sub

    Private Sub LoadInputValidations()
        Dim containsValidationRule As New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()

        containsValidationRule.ConditionOperator = ConditionOperator.IsNotBlank
        containsValidationRule.ErrorText = "Asigne un valor."
        containsValidationRule.ErrorType = ErrorType.Critical

        Dim customValidationRule As New CustomValidationRule()
        customValidationRule.ErrorText = "Valor obligatorio."
        customValidationRule.ErrorType = ErrorType.Critical
        Validate()
        vpInputs.SetValidationRule(Me.beDataSource, customValidationRule)
        vpInputs.SetValidationRule(Me.beDataTarget, customValidationRule)
    End Sub

    Private Sub bbiClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiClose.ItemClick
        If bChanges Then

        Else
            Close()
        End If

    End Sub

End Class
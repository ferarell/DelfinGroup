Imports System.Text
Imports System.Collections
Imports System.Configuration
Imports System.IO
Imports Microsoft.Office.Interop
Imports DevExpress.XtraGrid.Views.Grid

Module SharedModule
    Friend ENTC_Codigo As Integer
    Friend ENTC_DocIden As String
    Friend SkinName As String = ""
    Friend AppUser As String = My.User.Name

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

    Friend Function ValidaRUC(ByRef sRUC As String) As Boolean
        Dim bResult As Boolean = False
        Dim i001, i002, i003, i004 As Integer
        Dim s005 As String
        If sRUC.Trim.Length = 11 Then
            i001 = 5 * sRUC.Substring(0, 1) + 4 * sRUC.Substring(1, 1) + 3 * sRUC.Substring(2, 1) + 2 * sRUC.Substring(3, 1) + 7 * sRUC.Substring(4, 1) + 6 * sRUC.Substring(5, 1) + 5 * sRUC.Substring(6, 1) + 4 * sRUC.Substring(7, 1) + 3 * sRUC.Substring(8, 1) + 2 * sRUC.Substring(9, 1)
            i002 = Int(i001 / 11)
            i003 = Int(i001 - i002 * 11)
            i004 = Int(11 - i003)
            If i004 = 10 Then
                s005 = "0"
            ElseIf i004 = 11 Then
                s005 = "1"
            Else
                s005 = i004.ToString()
            End If
            If s005 = sRUC.Substring(10, 1) Then
                bResult = True
            Else
                MessageBox.Show("El número de RUC ingresado no es válido, por favor verifique.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        Return bResult
    End Function

End Module

Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraSplashScreen

Public Class ConciliacionRebatesForm
    Dim oMasterDataList As New MasterDataList
    Dim oDataAccess As New DataAccess
    Dim dtResult, dtSource As New DataTable
    Dim Hoja = "2020 NEXTSOFT"
    Private Sub ConciliacionRebatesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadShipline()
    End Sub

    Private Sub LoadResultFile()
        Dim ThisFile As String = ""
        ThisFile = Globals.ThisAddIn.Application.ThisWorkbook.FullName()
        dtResult = oDataAccess.LoadExcel(ThisFile, "{0}").Tables(0)
    End Sub

    Private Sub LoadShipline()
        Dim dtQuery As New DataTable
        dtQuery = oMasterDataList.LoadMasterData("Shipline", Nothing)
        lueShipline.Properties.DataSource = oMasterDataList.LoadMasterData("Shipline", Nothing)
        lueShipline.Properties.DisplayMember = "DescripcionTransportista"
        lueShipline.Properties.ValueMember = "CodigoTransportista"
        lueShipline.Properties.DataSource = dtQuery
    End Sub

    Private Sub beShiplineDataSource_Properties_Click(sender As Object, e As EventArgs) Handles beShiplineDataSource.Properties.Click
        XtraOpenFileDialog1.Filter = "Source Files (*.xls*)|*.xls*"
        If XtraOpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            beShiplineDataSource.Text = XtraOpenFileDialog1.FileName
        End If
    End Sub

    Private Sub beSourceDataBase_Properties_Click(sender As Object, e As EventArgs) Handles beSourceDataBase.Properties.Click
        XtraOpenFileDialog2.Filter = "Source Files (*.xls*)|*.xls*"
        If XtraOpenFileDialog2.ShowDialog = Windows.Forms.DialogResult.OK Then
            beSourceDataBase.Text = XtraOpenFileDialog2.FileName
        End If
    End Sub

    Private Sub bbiProcess_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiProcess.ItemClick
        If XtraOpenFileDialog1.FileName.ToString.ToUpper.Contains("XLS") Then
            dtSource = oDataAccess.LoadExcel(XtraOpenFileDialog1.FileName, "{0}").Tables(0)
        End If
        If dtSource.Rows.Count = 0 Then
            Return
        End If
        Try
            SplashScreenManager.ShowForm(GetType(WaitForm))
            SplashScreenManager.Default.SetWaitFormDescription("Procesando archivo seleccionado...")

            Dim wsResult As Excel.Worksheet = CType(Globals.ThisAddIn.Application.ActiveWorkbook.Worksheets(Hoja), Excel.Worksheet)
            Dim bResult As Boolean = True
            'Dim SheetRng As Excel.Range = Globals.ThisAddIn.Application.Sheets(Hoja).Range("A1:CC5000")
            Dim NewColumnRng As Excel.Range = wsResult.Range("AZ1")
            NewColumnRng.EntireColumn.Insert(Excel.XlInsertShiftDirection.xlShiftToRight, Excel.XlInsertFormatOrigin.xlFormatFromLeftOrAbove)
            Dim SheetRng As Excel.Range = wsResult.UsedRange
            Dim iNewColumn As Integer = SheetRng.Columns.Count
            For n = 2 To SheetRng.Rows.CountLarge
                If SheetRng.Cells(n, 1).Value Is Nothing Then
                    Continue For
                End If
                If SheetRng.Cells(n, 2).Value Is Nothing Then
                    Continue For
                End If
                If SheetRng.Cells(n, 6).Value Is Nothing Then
                    Continue For
                End If
                If SheetRng.Cells(n, 29).Value Is Nothing Then
                    Continue For
                End If
                SheetRng.Cells(n, iNewColumn).Value = SheetRng.Cells(n, 1).Value.ToString & SheetRng.Cells(n, 2).Value.ToString & SheetRng.Cells(n, 6).Value.ToString & SheetRng.Cells(n, 29).Value.ToString
            Next

            Dim currentFind As Excel.Range = Nothing
            Dim firstFind As Excel.Range = Nothing

            For r = 0 To dtSource.Rows.Count - 1
                Dim oRow As DataRow = dtSource.Rows(r)
                Dim KeySearch1 As String = oRow("BUQUE").ToString + oRow("VIAJE").ToString + oRow("BL").ToString + oRow("HBL").ToString

                SplashScreenManager.Default.SetWaitFormDescription("Procesando Archivo (Fila: " & (r + 1).ToString & " de " & dtSource.Rows.Count.ToString & ")")

                currentFind = SheetRng.Find(KeySearch1, ,
            Excel.XlFindLookIn.xlValues, Excel.XlLookAt.xlPart,
            Excel.XlSearchOrder.xlByRows, Excel.XlSearchDirection.xlNext, False)
                'While Not currentFind Is Nothing
                '    ' Keep track of the first range you find.
                '    If firstFind Is Nothing Then
                '        firstFind = currentFind
                '        ' If you didn't move to a new range, you are done.
                '    ElseIf currentFind.Address = firstFind.Address Then
                '        Exit While
                '    End If
                '    With currentFind.Font
                '        .Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black)
                '        .Bold = True
                '    End With

                '    currentFind = SheetRng.FindNext(currentFind)

                'End While

                If Not currentFind Is Nothing Then
                    With currentFind.Font
                        .Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Blue)
                        .Bold = True
                    End With
                    SheetRng.Cells(currentFind.Cells.Row, 42) = oRow("REBATE")
                    SheetRng.Cells(currentFind.Cells.Row, 44) = oRow("STATUS")
                    SheetRng.Cells(currentFind.Cells.Row, 45) = oRow("NOMBRE ARCHIVO HENRY")
                    SheetRng.Cells(currentFind.Cells.Row, 46) = oRow("FECHA DE CONCILIACION")
                End If

            Next
            SplashScreenManager.CloseForm(False)
            Globals.ThisAddIn.Application.Sheets(Hoja).Select()
        Catch ex As Exception
            SplashScreenManager.CloseForm(False)
            DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Me.Close()

    End Sub
End Class
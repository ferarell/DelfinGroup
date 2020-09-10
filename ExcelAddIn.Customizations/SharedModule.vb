Imports System.Data
Imports System.Data.SqlClient
Imports System
Imports System.IO
Imports System.IO.Compression
Imports System.Text
Imports System.Collections
Imports System.Configuration
Imports Microsoft.Office.Interop
Imports System.Windows.Forms

Module SharedModule
    Friend oGeneralDAO As New AppService.DelfinServiceClient
    Friend dtCompany, dtAccount, dtPartner As New DataTable
    Friend SkinName As String = ""
    Friend UserApp As String = ""

    Friend Function ExecuteSQL(QueryString As String) As DataTable
        Dim dtResult As New DataTable
        Try
            dtResult = oGeneralDAO.ExecuteSQL(QueryString).Tables(0)
        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dtResult
    End Function

    Friend Function ExecuteSQLNonQuery(QueryString As String) As Boolean
        Dim bResult As Boolean = True
        Try
            bResult = oGeneralDAO.ExecuteSQLNonQuery(QueryString)
        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            bResult = False
        End Try
        Return bResult
    End Function

    Friend Function InsertSQL(ByRef Table As String, ByVal drValues As DataRow) As Boolean
        Dim bResult As Boolean = True
        Dim sQuery As String = ""
        Try
            sQuery += "INSERT " & Table & Space(1)
            For r = 0 To drValues.ItemArray.Count - 1
                sQuery += IIf(r = 0, "SELECT '", ", '") & drValues.Item(r) & "'"
            Next
            bResult = oGeneralDAO.ExecuteSQLNonQuery(sQuery)
        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            bResult = False
        End Try
        Return bResult
    End Function


    Friend Sub ExportarExcel(sender As System.Object)
        Dim sPath As String = Path.GetTempPath
        Dim sFileName = FileIO.FileSystem.GetTempFileName + ".xlsx"
        sender.MainView.ExportToXlsx(sFileName)
        If IO.File.Exists(sFileName) Then
            Dim oXls As New Excel.Application 'Crea el objeto excel 
            oXls.Workbooks.Open(sFileName, , False) 'El true es para abrir el archivo en modo Solo lectura (False si lo quieres de otro modo)
            oXls.Visible = True
            oXls.WindowState = Excel.XlWindowState.xlMaximized 'Para que la ventana aparezca maximizada.
        End If
    End Sub

    Friend Function GetCompaniesList() As DataTable
        Dim dtQuery As New DataTable
        dtQuery = ExecuteSQL("SELECT * FROM Company")
        Return dtQuery
    End Function

    Friend Function GetCompanyDetail(cia As Integer, app As String) As DataTable
        Dim dtQuery As New DataTable
        dtQuery = ExecuteSQL("SELECT * FROM viCompanyDetail where CompanyID=" & cia.ToString & " and AppName='" & app & "'")
        Return dtQuery
    End Function

    Friend Function GetAccountsList(dbname As String) As DataTable
        Dim dtQuery As New DataTable
        dtQuery = ExecuteSQL("SELECT DISTINCT CUEN_Codigo AS code, CUEN_Desc AS name FROM " & dbname & "..CON_Cuentas ORDER BY 1")
        Return dtQuery
    End Function

    Friend Function GetPartnersList(dbname As String) As DataTable
        Dim dtQuery As New DataTable
        dtQuery = ExecuteSQL("SELECT ENTC_Codigo AS code, ENTC_NomCom AS name, ENTC_Ruc AS ruc FROM " & dbname & "..Entidad")
        Return dtQuery
    End Function

    Function LastDayOfMonth(ByVal RefDate As Date) As Date
        LastDayOfMonth = DateSerial(Year(RefDate), Month(RefDate) + 1, 0)
    End Function

    'Friend Function LoadCSV(FileName As String, Header As Boolean, LstSpr As String) As DataTable
    '    Dim dtReading As New DataTable
    '    Dim sColumn As String = ""
    '    Dim txtpos As String = ""
    '    Dim iPosCol As Integer = 0
    '    Dim line As New StreamReader(FileName, False)
    '    Dim sFila As String = line.ReadLine
    '    For i = 1 To sFila.Count + 1
    '        txtpos = Mid(sFila, i, 1)
    '        If (txtpos = LstSpr Or i = sFila.Count + 1) Then
    '            If Header Then
    '                If sColumn <> "" Then
    '                    dtReading.Columns.Add(Strings.RTrim(sColumn)).AllowDBNull = True
    '                End If
    '            Else
    '                dtReading.Columns.Add("C" & (dtReading.Columns.Count + 1).ToString).AllowDBNull = True
    '            End If
    '            sColumn = ""
    '        Else
    '            sColumn = sColumn & txtpos
    '        End If
    '    Next
    '    Using sr As New StreamReader(FileName)
    '        Dim lines As List(Of String) = New List(Of String)
    '        Dim bExit As Boolean = False
    '        Dim sColumnValue As String = ""
    '        Do While Not sr.EndOfStream
    '            lines.Add(sr.ReadLine())
    '        Loop
    '        For i As Integer = 1 To lines.Count - 1
    '            iPosCol = 0
    '            txtpos = ""
    '            dtReading.Rows.Add()
    '            For c = 1 To lines.Item(i).Length + 1
    '                If iPosCol >= dtReading.Columns.Count Then
    '                    Continue For
    '                End If
    '                txtpos = Mid(lines(i), c, 1)
    '                If (txtpos = LstSpr) Or (i = sFila.Count + 1) Then
    '                    dtReading.Rows(i - 1).Item(iPosCol) = sColumnValue.TrimEnd
    '                    iPosCol = iPosCol + 1
    '                    sColumnValue = ""
    '                Else
    '                    sColumnValue = sColumnValue + txtpos.Replace("'", "")
    '                End If
    '            Next
    '        Next
    '    End Using
    '    Return dtReading
    'End Function

    Friend Function LoadCSV(FileName As String, Header As Boolean, LstSpr As String) As DataTable
        Dim dtReading As New DataTable
        Dim sColumn As String = ""
        Dim txtpos As String = ""
        Dim iPosCol As Integer = 0
        Dim line As New StreamReader(FileName, False)
        Dim sFila As String = line.ReadLine
        For i = 1 To sFila.Count + 1
            txtpos = Mid(sFila, i, 1)
            If (txtpos = LstSpr Or i = sFila.Count + 1) Then
                If Header Then
                    If sColumn <> "" Then
                        dtReading.Columns.Add(Strings.RTrim(sColumn)).AllowDBNull = True
                    End If
                Else
                    dtReading.Columns.Add("C" & (dtReading.Columns.Count + 1).ToString).AllowDBNull = True
                End If
                sColumn = ""
            Else
                sColumn = sColumn & txtpos
            End If
        Next
        Using sr As New StreamReader(FileName)
            Dim lines As List(Of String) = New List(Of String)
            Dim bExit As Boolean = False
            Dim sColumnValue As String = ""
            Do While Not sr.EndOfStream
                lines.Add(sr.ReadLine())
            Loop
            For i As Integer = 1 To lines.Count - 1
                iPosCol = 0
                txtpos = ""
                dtReading.Rows.Add()
                For c = 1 To lines.Item(i).Length
                    If iPosCol >= dtReading.Columns.Count Then
                        Continue For
                    End If
                    txtpos = Mid(lines(i), c, 1)
                    If (txtpos = LstSpr Or c - 1 = lines.Item(i).Length) Then
                        dtReading.Rows(i - 1).Item(iPosCol) = sColumnValue.TrimEnd
                        iPosCol = iPosCol + 1
                        sColumnValue = ""
                    Else
                        sColumnValue = sColumnValue + txtpos.Replace("'", "")
                    End If
                Next
            Next
        End Using
        Return dtReading
    End Function

    Friend Function SelectDistinct(ByVal SourceTable As System.Data.DataTable, ByVal Condition As String, ByVal ParamArray FieldNames() As String) As System.Data.DataTable
        Dim lastValues() As Object
        Dim newTable As System.Data.DataTable

        If FieldNames Is Nothing OrElse FieldNames.Length = 0 Then
            Throw New ArgumentNullException("FieldNames")
        End If

        lastValues = New Object(FieldNames.Length - 1) {}
        newTable = New System.Data.DataTable

        For Each field As String In FieldNames
            newTable.Columns.Add(field, SourceTable.Columns(field).DataType)
        Next

        For Each Row As DataRow In SourceTable.Select(Condition, String.Join(", ", FieldNames))
            If Not fieldValuesAreEqual(lastValues, Row, FieldNames) Then
                newTable.Rows.Add(createRowClone(Row, newTable.NewRow(), FieldNames))

                setLastValues(lastValues, Row, FieldNames)
            End If
        Next

        Return newTable
    End Function

    Friend Function fieldValuesAreEqual(ByVal lastValues() As Object, ByVal currentRow As DataRow, ByVal fieldNames() As String) As Boolean
        Dim areEqual As Boolean = True

        For i As Integer = 0 To fieldNames.Length - 1
            If lastValues(i) Is Nothing OrElse Not lastValues(i).Equals(currentRow(fieldNames(i))) Then
                areEqual = False
                Exit For
            End If
        Next

        Return areEqual
    End Function

    Private Function createRowClone(ByVal sourceRow As DataRow, ByVal newRow As DataRow, ByVal fieldNames() As String) As DataRow
        For Each field As String In fieldNames
            newRow(field) = sourceRow(field)
        Next

        Return newRow
    End Function

    Private Sub setLastValues(ByVal lastValues() As Object, ByVal sourceRow As DataRow, ByVal fieldNames() As String)
        For i As Integer = 0 To fieldNames.Length - 1
            lastValues(i) = sourceRow(fieldNames(i))
        Next
    End Sub

End Module

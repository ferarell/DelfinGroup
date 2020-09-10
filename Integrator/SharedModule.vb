Imports System.Data
Imports System.Data.SqlClient
Imports System
Imports System.IO
Imports System.IO.Compression
Imports System.Text
Imports System.Collections
Imports System.Configuration
Imports Microsoft.Office.Interop
Imports DevExpress.XtraGrid.Views.Grid

Module SharedModule
    Friend oGeneralDAO As New AppService.DelfinServiceClient
    Friend dtActiveDirectoryObjects, dtCompany, dtAccount, dtPartner As New DataTable
    Friend SkinName As String = ""
    Friend AppUser As String = ""
    Friend UserName, UserEmail As String
    Friend AppPath As String = IO.Directory.GetCurrentDirectory

    Friend Function ExecuteSQL(QueryString As String) As DataTable
        Dim dtResult As New DataTable
        Try
            dtResult = oGeneralDAO.ExecuteSQL(QueryString).Tables(0)
        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dtResult
    End Function

    Friend Function NewExecuteSQL(QueryString As String) As DataTable
        Dim dsResult As New DataSet
        Try
            dsResult = oGeneralDAO.NewExecuteSQL(QueryString)
            If dsResult.Tables.Contains("Error") Then
                If dsResult.Tables("Error").Rows.Count > 0 Then
                    Throw New ApplicationException(dsResult.Tables("Error")(0)(0))
                End If
            End If
        Catch ex As Exception
            Throw
            DevExpress.XtraEditors.XtraMessageBox.Show(dsResult.Tables("Error")(0)(0), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dsResult.Tables(0)
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

    Friend Function NewExecuteSQLNonQuery(QueryString As String) As ArrayList
        Dim aResult As New ArrayList
        aResult.AddRange(oGeneralDAO.NewExecuteSQLNonQuery(QueryString))
        If Not aResult(0) Then
            DevExpress.XtraEditors.XtraMessageBox.Show(aResult(1), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Return aResult(0)
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

    <System.Runtime.CompilerServices.Extension> _
    Public Function Contains(ByVal str As String, ByVal ParamArray values As String()) As Boolean
        For Each value In values
            If str.Contains(value) Then
                Return True
            End If
        Next
        Return False
    End Function

    Friend Sub ExportarExcel(sender As DevExpress.XtraGrid.GridControl)
        Dim oGridView As New GridView
        oGridView = sender.FocusedView
        Dim sPath As String = Path.GetTempPath
        Dim sFileName = ""
        'oGridView.OptionsPrint.ExpandAllDetails = True
        'sFileName = (FileIO.FileSystem.GetTempFileName).Replace(".tmp", ".xlsx")
        'oGridView.ExportToXlsx(sFileName)
        If oGridView.RowCount <= 60000 Then
            oGridView.OptionsPrint.AutoWidth = False
            oGridView.BestFitColumns()
            oGridView.BestFitMaxRowCount = oGridView.RowCount
            sFileName = (FileIO.FileSystem.GetTempFileName).Replace(".tmp", ".xls")
            oGridView.ExportToXls(sFileName)
        Else
            sFileName = (FileIO.FileSystem.GetTempFileName).Replace(".tmp", ".xlsx")
            oGridView.ExportToXlsx(sFileName)
        End If
        If IO.File.Exists(sFileName) Then
            Dim oXls As New Excel.Application 'Crea el objeto excel 
            oXls.Workbooks.Open(sFileName, , False) 'El true es para abrir el archivo en modo Solo lectura (False si lo quieres de otro modo)
            oXls.Visible = True
            oXls.WindowState = Excel.XlWindowState.xlMaximized 'Para que la ventana aparezca maximizada.
        End If
    End Sub

    Friend Function GetCompaniesList(AppSource As String) As DataTable
        Dim dtQuery As New DataTable
        dtQuery = ExecuteSQL("SELECT * FROM viCompanyDetail WHERE AppName='" & AppSource & "'")
        Return dtQuery
    End Function

    Friend Function GetCompanyDetailOld(cia As Integer, app As String) As DataTable
        Dim dtQuery As New DataTable
        dtQuery = ExecuteSQL("SELECT * FROM viCompanyDetail where CompanyID=" & cia.ToString & " and AppName='" & app & "'")
        Return dtQuery
    End Function

    Friend Function GetDBCia(AppCode As String) As String
        Dim sResult As String = ""
        sResult = ExecuteSQL("select DatabaseName from viCompanyDetail where AppCode='" & AppCode & "'").Rows(0)(0)
        Return sResult
    End Function

    Friend Function GetCompanyDetail(AppCode As String, app As String) As DataTable
        Dim dtResult As New DataTable
        dtResult = ExecuteSQL("select * from viCompanyDetail where AppCode='" & AppCode & "' and AppName='" & app & "'")
        Return dtResult
    End Function

    Friend Function GetAccountsList(dbname As String) As DataTable
        Dim dtQuery As New DataTable
        If dbname.Contains("CONCAR") Then
            dtQuery = ExecuteSQL("SELECT DISTINCT PCUENTA AS code, PDESCRI AS name FROM " & dbname & "..CT0004PLEM ORDER BY 1")
        Else
            dtQuery = ExecuteSQL("SELECT DISTINCT CUEN_Codigo AS code, CUEN_Desc AS name FROM " & dbname & "..CON_Cuentas ORDER BY 1")
        End If

        Return dtQuery
    End Function

    Friend Function GetPartnersList(dbname As String) As DataTable
        Dim dtQuery As New DataTable
        If dbname.Contains("CONCAR") Then
            dtQuery = ExecuteSQL("SELECT DISTINCT *, ACODANE AS code, ADESANE AS name, ARUC AS ruc FROM " & dbname & "..CT0004ANEX ORDER BY 1")
        Else
            dtQuery = ExecuteSQL("SELECT ENTC_Codigo AS code, ENTC_NomCom AS name, ENTC_Ruc AS ruc FROM " & dbname & "..Entidad")
        End If
        Return dtQuery
    End Function

    Friend Function GetPartnerAddressesList(dbname As String, partner As String) As DataTable
        Dim dtQuery As New DataTable
        dtQuery = ExecuteSQL("SELECT DIRE_Desc AS address FROM " & dbname & "..DirecENTC where ENTC_Codigo='" & partner & "'")
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

    Friend Function LoadExcel(ByVal FileName As String, ByRef Hoja As String) As DataSet
        Dim dsResult As New DataSet
        Dim ExcelConnectionString As String = "provider=Microsoft.ACE.OLEDB.12.0; Data Source='" & FileName & "'; Extended Properties='Excel 12.0 Xml;HDR=YES;IMEX=1'"
        Using connection As New System.Data.OleDb.OleDbConnection(ExcelConnectionString)
            Try
                connection.Open()
                If Hoja = "{0}" Then
                    For r = 0 To connection.GetSchema("Tables").Rows.Count - 1
                        If Not connection.GetSchema("Tables").Rows(r)("TABLE_NAME").Contains("#") Then
                            Hoja = connection.GetSchema("Tables").Rows(r)("TABLE_NAME")
                            Exit For
                        End If
                    Next

                End If
                Dim Command As New System.Data.OleDb.OleDbDataAdapter("select * from [" & Hoja & "]", connection)
                Command.Fill(dsResult)
            Catch ex As Exception
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                connection.Close()
            End Try
            Return dsResult
        End Using
    End Function

    Friend Sub TextToSpeak(sText As String)
        If My.Settings.SpeechEnabled Then
            Dim t As New System.Threading.Thread(AddressOf SpeechThread)
            t.Start(sText)
        End If
    End Sub

    Private Sub SpeechThread(sText As String)
        Try
            Dim sapi
            sapi = CreateObject("sapi.spvoice")
            sapi.speak(sText)
        Catch ex As Exception
            My.Settings.SpeechEnabled = False
            My.Settings.Save()
        End Try
    End Sub

    Friend Function GetPartnerCodeByRuc(ciacode As String, ruc As String) As String
        Dim sEntidad As String = ""
        Try
            sEntidad = NewExecuteSQL("select ENTC_Codigo_NextSis" & ciacode & " from viMapeoEntidad where ENTC_DocIden='" & ruc & "'")(0)(0)
        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return sEntidad
    End Function

    Friend Function GetDocTypeSunat(tipdoc As String) As String
        Dim sTipDocSunat As String = ""
        Try
            sTipDocSunat = NewExecuteSQL("select TIPO_Desc2 from viTipoDocumento where TIPO_CodTipo='" & tipdoc & "'")(0)(0)
        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return sTipDocSunat
    End Function

    Friend Function Decompress(zipPath As String, extractPath As String) As Boolean
        Dim bResult As Boolean = True
        Try
            ZipFile.ExtractToDirectory(zipPath, extractPath)
        Catch ex As Exception
            bResult = False
        End Try
        Return bResult
    End Function

    Friend Function LoadTXT(FileName As String, Header As Boolean, ListSeparator As String) As DataTable
        Dim dtReading As New DataTable
        Dim sColumn As String = ""
        Dim txtpos As String = ""
        Dim iPosCol As Integer = 0
        Dim line As New StreamReader(FileName, False)
        Dim sFila As String = line.ReadLine
        For i = 1 To sFila.Count + 1
            txtpos = Mid(sFila, i, 1)
            If txtpos = ListSeparator Or i = sFila.Count + 1 Then
                If Header Then
                    dtReading.Columns.Add(sColumn).AllowDBNull = True
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
                For c = 1 To lines.Item(i).Length + 1
                    txtpos = Mid(lines(i), c, 1)
                    If txtpos = ListSeparator Or c = lines.Item(i).Length + 1 Then
                        dtReading.Rows(i - 1).Item(iPosCol) = sColumnValue
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

    Private Function UnicodeStringToBytes(ByVal str As String) As Byte()
        Return System.Text.Encoding.Unicode.GetBytes(str)
    End Function

    Private Function UnicodeBytesToString(ByVal bytes() As Byte) As String
        Return System.Text.Encoding.Unicode.GetString(bytes)
    End Function

End Module

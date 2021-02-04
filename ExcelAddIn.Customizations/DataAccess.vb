Imports System.Data
Imports System.IO
Imports System.Windows.Forms
Imports Microsoft.Office.Interop

Public Class DataAccess

    Friend Function LoadExcel(ByVal FileName As String, ByRef Hoja As String) As DataSet
        Dim dsResult As New DataSet
        Dim ExcelConnectionString As String = "provider=Microsoft.ACE.OLEDB.12.0; Data Source='" & FileName & "'; Extended Properties=Excel 8.0;"
        Using connection As New System.Data.OleDb.OleDbConnection(ExcelConnectionString)
            Try
                connection.Open()
                If Hoja = "{0}" Then
                    For r = 0 To connection.GetSchema("Tables").Rows.Count - 1
                        If Not connection.GetSchema("Tables").Rows(r)("TABLE_NAME").toupper.contains("FILTER") Then
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

    Friend Function LoadExcelWithConditions(FileName As String, Hoja As String, Condition As String) As DataSet
        Dim dsResult As New DataSet
        Dim ExcelConnectionString As String = "provider=Microsoft.ACE.OLEDB.12.0; Data Source='" & FileName & "'; Extended Properties=Excel 8.0;"
        Using connection As New System.Data.OleDb.OleDbConnection(ExcelConnectionString)
            Try
                connection.Open()
                If Hoja = "{0}" Then
                    For r = 0 To connection.GetSchema("Tables").Rows.Count - 1
                        If Not connection.GetSchema("Tables").Rows(r)("TABLE_NAME").toupper.contains("FILTER") Then
                            Hoja = connection.GetSchema("Tables").Rows(r)("TABLE_NAME")
                            Exit For
                        End If
                    Next
                End If
                Dim Command As New System.Data.OleDb.OleDbDataAdapter("select * from [" & Hoja & "] " & IIf(Condition <> "", " WHERE " & Condition, ""), connection)
                Command.Fill(dsResult)
            Catch ex As Exception
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                connection.Close()
            End Try
            Return dsResult
        End Using
    End Function

    Friend Function QueryExcel(FileName As String, Query As String) As DataSet
        Dim dsResult As New DataSet
        Dim ExcelConnectionString As String = "provider=Microsoft.ACE.OLEDB.12.0; Data Source='" & FileName & "'; Extended Properties=Excel 8.0;"
        Using connection As New System.Data.OleDb.OleDbConnection(ExcelConnectionString)
            Try
                connection.Open()
                Dim Command As New System.Data.OleDb.OleDbDataAdapter(Query, connection)
                Command.Fill(dsResult)
            Catch ex As Exception
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                connection.Close()
            End Try
            Return dsResult
        End Using
    End Function

End Class

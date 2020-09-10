Imports System.Data
Imports System.Collections
Imports System.IO

Module SharedModule
    Friend BlList As New ArrayList
    Friend dtConfig As New DataTable
    Friend drConfig As DataRow
    Friend Identifier As String = ""
    Friend AppPath As String = IO.Path.GetDirectoryName(New Uri(System.Reflection.Assembly.GetExecutingAssembly().CodeBase).LocalPath)
    Friend oGeneralDAO As New AppService.DelfinServiceClient
    Friend oLogFileUpdate As New LogFileGenerate

    Friend Function ExecuteSQL(QueryString As String) As DataTable
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
            'DevExpress.XtraEditors.XtraMessageBox.Show(dsResult.Tables("Error")(0)(0), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dsResult.Tables(0)
    End Function

    Friend Function ExecuteSQLNonQuery(QueryString As String) As ArrayList
        Dim aResult As New ArrayList
        aResult.AddRange(oGeneralDAO.NewExecuteSQLNonQuery(QueryString))
        If Not aResult(0) Then
            'DevExpress.XtraEditors.XtraMessageBox.Show(aResult(1), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Return aResult(0)
    End Function

End Module

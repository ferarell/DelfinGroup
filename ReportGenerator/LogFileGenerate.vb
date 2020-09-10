Imports System.Collections

Public Class LogFileGenerate

    Public Sub TextFileUpdate(ProcessName As String, TextLog As String)
        Dim sFile As System.IO.StreamWriter
        sFile = My.Computer.FileSystem.OpenTextFileWriter(sLOGFILE & "\ReportGenerator_" & DateTime.Now.ToString("yyyyMMdd") & ".Log", True)
        sFile.WriteLine("(" & DateTime.Now.ToString & ")  [" & ProcessName & "]" & Space(2) & TextLog & Space(2))
        sFile.Close()
    End Sub

End Class

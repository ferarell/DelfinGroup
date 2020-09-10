Module Module1

    Friend sHBL, sLOGFILE As String

    Public Sub Main()
        Dim oArgs As ObjectModel.ReadOnlyCollection(Of String) = My.Application.CommandLineArgs()

        For Each arg As String In oArgs
            If arg.ToUpper.StartsWith("/HBL=") Then
                sHBL = arg.Remove(0, "/HBL=".Length)
            End If
            If arg.ToUpper.StartsWith("/LOGFILE=") Then
                sLOGFILE = arg.Remove(0, "/LOGFILE=".Length)
            End If
            Continue For
        Next
        Try
            If sHBL <> "" Then
                Console.Write("HBL: " & sHBL & vbNewLine)
                Dim oProcess As New DataProcess
                oProcess.DataGenerate(sHBL)
            End If
        Catch ex As Exception
            oLogFileUpdate.TextFileUpdate("ReportGenerator (Module1 - Main)", ex.Message)
        End Try
    End Sub



End Module

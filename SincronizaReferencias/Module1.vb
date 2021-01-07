Module Module1
    Friend oProcessName = "SAP_REFERENCES"
    Friend oLogFileGenerate As New LogFileGenerate
    Friend sHBL, sTIPREF, sAppUser As String
    Sub Main()
        Dim oArgs As ObjectModel.ReadOnlyCollection(Of String) = My.Application.CommandLineArgs()

        For Each arg As String In oArgs
            If arg.ToUpper.StartsWith("/HBL=") Then
                sHBL = arg.Remove(0, "/HBL=".Length)
            End If
            If arg.ToUpper.StartsWith("/TIPREF=") Then
                sTIPREF = arg.Remove(0, "/TIPREF=".Length)
            End If
            If arg.ToUpper.StartsWith("/USER=") Then
                sAppUser = arg.Remove(0, "/USER=".Length)
            End If
            Continue For
        Next
        Try
            If sHBL <> "" Then
                Console.Write("HBL: " & sHBL & vbNewLine)
                Dim oProcess As New DataProcess
                oProcess.DataGenerate(sHBL, sTIPREF, sAppUser)
            End If
        Catch ex As Exception
            oLogFileGenerate.TextFileUpdate(oProcessName, ex.Message)
        End Try
    End Sub

End Module

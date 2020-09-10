Imports System
Imports System.Data
Imports System.Collections
Imports System.Windows.Forms

Public Class CongestionPortuaria
    Dim oAppService As New AppService.DelfinServiceClient

    Friend Function DataProcess(oMailItem As Outlook.MailItem) As Boolean
        Dim bResult As Boolean = True
        Dim dtSource As New DataTable
        Dim sFileName = FileIO.FileSystem.GetTempFileName
        For a = 1 To oMailItem.Attachments.Count
            If oMailItem.Attachments(a).FileName.ToUpper.Contains({"XLS", "TXT"}) Then
                sFileName = My.Settings.ProcessedPath & "\" & Format(Now, "ddMMyyyy HHmmss") & " - " & oMailItem.Attachments(a).FileName
                oMailItem.Attachments(a).SaveAsFile(sFileName)
            End If
        Next
        If Not IO.File.Exists(sFileName) Then
            SendErrorMessage(oMailItem, Identifier, "No se descargó el archivo adjunto.", Nothing)
            Return False
        End If
        Try
            If LoadExcel(sFileName, "{0}").Tables(0).Rows.Count > 0 Then
                dtSource = QueryExcel(sFileName, "SELECT RTRIM([RAZON SOCIAL]) AS RazonSocial, LEFT(RTRIM(CStr([RUC])),11) AS DocIden, [ALCONSA] AS Alconsa, [TRAMARSA] AS Tramarsa FROM [CONGESTION PORTUARIA$] ").Tables(0)
            End If
            If UpdateProcess(dtSource) Then
                SendNewMessage("PRC_OK", oMailItem, Identifier, "", Nothing)
            Else
                bResult = False
                SendNewMessage("PRC_ERROR", oMailItem, Identifier, "", Nothing)
            End If
        Catch ex As Exception
            bResult = False
        End Try
        Return bResult
    End Function

    Private Function UpdateProcess(dtSource As DataTable) As Boolean
        Dim bresult As Boolean = True
        Dim aResult As New ArrayList
        aResult.AddRange(oAppService.UpdatingUsingTableAsParameter("ptc.paActualizaCongestionPortuaria", dtSource))
        If aResult(0) = 0 Then
            bresult = False
            DevExpress.XtraEditors.XtraMessageBox.Show(aResult(1), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Return bresult
    End Function

End Class

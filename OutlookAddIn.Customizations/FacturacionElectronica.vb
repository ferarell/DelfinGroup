Imports System.Data
Imports System.Xml

Public Class FacturacionElectronica
    Dim oAppService As New AppService.DelfinServiceClient

    Friend Function DataProcess(oMailItem As Outlook.MailItem) As Boolean
        Dim bResult As Boolean = True
        Dim dtSource As New DataTable
        Dim sFileName = FileIO.FileSystem.GetTempFileName

        For a = 1 To oMailItem.Attachments.Count
            If oMailItem.Attachments(a).FileName.ToUpper.Contains({"XML"}) Then
                sFileName = My.Settings.ProcessedPath & "\" & Format(Now, "ddMMyyyy HHmmss") & " - " & oMailItem.Attachments(a).FileName
                oMailItem.Attachments(a).SaveAsFile(sFileName)
            End If
        Next
        If Not IO.File.Exists(sFileName) Then
            SendErrorMessage(oMailItem, Identifier, "No se descargó el archivo adjunto.", Nothing)
            Return False
        End If
        Dim oReadXML As New ReadXML
        Dim oXmlDocument As New Xml.XmlDocument
        Dim oXmlNodeList As Xml.XmlNodeList
        Dim oXmlNode As Xml.XmlNode

        oXmlDocument = oReadXML.LoadFile(sFileName)

        Try

        Catch ex As Exception

        End Try



        Return bResult
    End Function
End Class

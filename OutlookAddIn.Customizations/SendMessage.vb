Imports System.Collections
Imports System.Data
Imports System.Windows.Forms

Public Class SendMessage
    Dim TextMessage As New RichTextBox

    Friend Sub Response(oMailItem As Outlook.MailItem, InputType As Integer, aFiles As ArrayList)
        Dim oNewMessage As Outlook.MailItem
        Dim AppOutlook As New Outlook.Application
        Dim bResult As Boolean = True
        oNewMessage = AppOutlook.CreateItem(Outlook.OlItemType.olMailItem)
        Dim Recipents As Outlook.Recipients = oNewMessage.Recipients
        Recipents.Add(oMailItem.SenderEmailAddress)
        oNewMessage.BodyFormat = Outlook.OlBodyFormat.olFormatHTML
        oNewMessage.Subject = oMailItem.Subject
        oNewMessage.HTMLBody = GetMessageBody(oMailItem.SenderName, Nothing)
        If Not aFiles Is Nothing Then
            For r = 0 To aFiles.Count - 1
                oNewMessage.Attachments.Add(aFiles(r))
            Next
        End If
        oNewMessage.Send()
    End Sub

    Friend Sub ResponseWithTable(oMailItem As Outlook.MailItem, InputType As Integer, aFiles As ArrayList, Table As DataTable)
        Dim oNewMessage As Outlook.MailItem
        Dim AppOutlook As New Outlook.Application
        Dim bResult As Boolean = True
        oNewMessage = AppOutlook.CreateItem(Outlook.OlItemType.olMailItem)
        Dim Recipents As Outlook.Recipients = oNewMessage.Recipients
        Recipents.Add(oMailItem.SenderEmailAddress)
        oNewMessage.BodyFormat = Outlook.OlBodyFormat.olFormatHTML
        oNewMessage.Subject = oMailItem.Subject
        oNewMessage.HTMLBody = GetMessageBody(oMailItem.SenderName, Table)
        If Not aFiles Is Nothing Then
            For r = 0 To aFiles.Count - 1
                oNewMessage.Attachments.Add(aFiles(r))
            Next
        End If
        oNewMessage.Send()
    End Sub

    Friend Function GetMessageBody(SenderName As String, Table As DataTable) As String
        'Dim sResponseType As Integer = dtConfig.Rows(0)("TipoRespuesta")
        TextMessage.Text = ""
        TextMessage.AppendText("<html><body lang=ES style='tab-interval:35.4pt;font-size:10.0pt;font-family:""Calibri"",sans-serif style='color: #2f5496;'>")
        For r = 0 To dtConfig.Rows.Count - 1
            Dim oRow As DataRow = dtConfig.Rows(r)
            If UnicodeBytesToString(oRow("MessageText")) <> "" Then
                TextMessage.AppendText(UnicodeBytesToString(oRow("MessageText")))
                TextMessage.AppendText("<br>")
            End If
        Next
        'If ActiveNotice() Then
        '    NewMessage.AppendText(GetHtmlText(Filter, "Noticia", sResponseType))
        'End If
        TextMessage.AppendText("</html></body>")
        TextMessage.Text = Replace(TextMessage.Text, "[Sender]", SenderName)
        If Not Table Is Nothing Then
            Dim oGetHtmlTable As New GetHtmlTable
            Dim view As New System.Data.DataView(Table)
            Dim selected As System.Data.DataTable = view.ToTable("Selected", False, "CONCEPTOS", "SOLES (PEN)", "DOLARES (USD)", "Inc.IGV")
            TextMessage.Text = Replace(TextMessage.Text, "[Company]", Table.Rows(0)("ENTC_RazonSocial"))
            TextMessage.Text = Replace(TextMessage.Text, "[TABLA]", oGetHtmlTable.GenerateTable(selected))
        End If
        Return TextMessage.Text
    End Function

End Class

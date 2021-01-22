Imports DevExpress.XtraSplashScreen
Imports Microsoft.Office.Interop
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Windows.Forms

Public Class CreateMailItem
    'Dim Application As New Outlook.Application
    Dim Application As Outlook.Application = CType(Activator.CreateInstance(Type.GetTypeFromCLSID(New Guid("0006F03A-0000-0000-C000-000000000046"))), Microsoft.Office.Interop.Outlook.Application)
    Dim mail As Outlook.MailItem = Nothing
    Dim mailRecipients As Outlook.Recipients = Nothing
    Dim mailRecipient As Outlook.Recipient = Nothing
    Dim body As String = ""
    Friend htmlBody As New RichTextBox
    Friend subject, mailTo, mailCc, mailBcc As String
    Friend aAttachment As New ArrayList

    Friend Function CreateCustomMessage(TypeMessage As String) As String
        Dim sResult As String = ""
        Try
            mail = Application.CreateItem(Outlook.OlItemType.olMailItem)
            'Dim oInspector As Outlook.Inspector = mail.GetInspector
            If Not mailTo Is Nothing Then
                mail.To = mailTo
            End If
            If Not mailCc Is Nothing Then
                mail.CC = mailCc
            End If
            If Not mailBcc Is Nothing Then
                mail.BCC = mailBcc
            End If
            If Not aAttachment Is Nothing Then
                For a = 0 To aAttachment.Count - 1
                    If IO.File.Exists(aAttachment(a)) Then
                        mail.Attachments.Add(aAttachment(a))
                    End If
                Next
            End If
            mail.Subject = subject
            mail.HTMLBody = htmlBody.Text + mail.HTMLBody
            If TypeMessage = "Display" Then
                mail.Display(mail)
            Else
                mail.Send()
            End If
            SplashScreenManager.CloseForm(False)
        Catch ex As Exception
            sResult = ex.Message
            SplashScreenManager.CloseForm(False)
            System.Windows.Forms.MessageBox.Show(ex.Message,
                "An exception is occured in the code of add-in.")
        Finally
            If Not IsNothing(mailRecipient) Then Marshal.ReleaseComObject(mailRecipient)
            If Not IsNothing(mailRecipients) Then Marshal.ReleaseComObject(mailRecipients)
            If Not IsNothing(mail) Then Marshal.ReleaseComObject(mail)
        End Try
        Return sResult
    End Function

    Friend Function GetPorticoMessageBody(SenderName As String, Table As DataTable, IdInputConfiguration As Integer) As String
        Dim TextMessage As New RichTextBox
        Dim oAppService As New AppService.DelfinServiceClient
        TextMessage.Text = ""
        TextMessage.AppendText("<html><body lang=ES style='tab-interval:35.4pt;font-size:10.0pt;font-family:""Tahoma"",sans-serif'>")
        Dim dtConfig As New DataTable
        dtConfig = oAppService.ExecuteSQL("EXEC Integrador.ptc.upGetConfigurationById " & IdInputConfiguration.ToString).Tables(0)
        For r = 0 To dtConfig.Rows.Count - 1
            Dim oRow As DataRow = dtConfig.Rows(r)
            If UnicodeBytesToString(oRow("MessageText")) <> "" Then
                If dtConfig.Rows(r)("Signature") = True Then
                    Continue For
                End If
                TextMessage.AppendText(UnicodeBytesToString(oRow("MessageText")))
            End If
        Next
        'If ActiveNotice() Then
        '    NewMessage.AppendText(GetHtmlText(Filter, "Noticia", sResponseType))
        'End If
        TextMessage.AppendText("</html></body>")
        TextMessage.Text = Replace(TextMessage.Text, "[Sender]", SenderName)
        If Not Table Is Nothing And Table.Rows.Count > 0 Then
            Dim oGetHtmlTable As New GetHtmlTable
            Dim view As New System.Data.DataView(Table)
            Dim selected As System.Data.DataTable = view.ToTable("Selected", False, "CONCEPTOS", "SOLES (PEN)", "DOLARES (USD)") ', "Inc.IGV")
            TextMessage.AppendText("<br><br>")
            TextMessage.Text = Replace(TextMessage.Text, "[Company]", Table.Rows(0)("ENTC_RazonSocial"))
            TextMessage.Text = Replace(TextMessage.Text, "[TABLA]", oGetHtmlTable.GenerateTable(selected))
        Else
            TextMessage.Text = Replace(TextMessage.Text, "[TABLA]", "")
        End If
        Return TextMessage.Text
    End Function

    'Private Function ReadSignature() As String
    '    Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\Microsoft\Firmas"
    '    Dim str1 As String = String.Empty
    '    Dim directoryInfo As New DirectoryInfo(path)
    '    If directoryInfo.Exists Then
    '        Dim files As FileInfo() = directoryInfo.GetFiles("*.htm")
    '        If files.Length > 0 Then
    '            str1 = New StreamReader(files(0).FullName, Encoding.[Default]).ReadToEnd()
    '            If Not String.IsNullOrEmpty(str1) Then
    '                Dim str2 As String = files(0).Name.Replace(files(0).Extension, String.Empty)
    '                str1 = str1.Replace(str2 + "_files/", path + "/" + str2 + "_files/")
    '            End If
    '        End If
    '    End If
    '    Return str1
    'End Function

    'Private Function Signature() As String
    '    Dim stringBuilder As New StringBuilder()
    '    stringBuilder.Append("<table CELLSPACING=10 cellpadding=12>")
    '    stringBuilder.Append("<tr>  ")
    '    stringBuilder.Append("<td><img src=http://www.delfingroupco.com/sitio/mysite/images/logoHeader.png><br>")
    '    stringBuilder.Append("</td>  ")
    '    stringBuilder.Append("<td>  ")
    '    stringBuilder.Append("<font size=2 color= #2f5496 >")
    '    stringBuilder.Append("<b>DELFIN GROUP Co</b><br>")
    '    stringBuilder.Append("Teléfono: (511) 615 3535<br>")
    '    stringBuilder.Append("Web: <a href=«http://www.delfingroupco.com»>http://www.delfingroupco.com</a><br>")
    '    stringBuilder.Append("</font>")
    '    stringBuilder.Append("</td></tr>")
    '    stringBuilder.Append("</table>")
    '    Return stringBuilder.ToString()
    'End Function

End Class

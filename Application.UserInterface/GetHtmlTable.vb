Imports System.Data
Imports System.Windows.Forms

Public Class GetHtmlTable

    Friend Function GenerateTable(dtSource As DataTable) As String
        Dim Msg As New RichTextBox
        'Inicio de Tabla
        Msg.AppendText("<table class='MsoTableGrid' style='height: auto;' border='1' cellspacing='0' cellpadding='0<tr'>")
        'Headers
        Msg.AppendText("<tr style='mso-yfti-irow:0;mso-yfti-firstrow:yes'>")
        For col = 0 To dtSource.Columns.Count - 1
            Msg.AppendText("<td style='width:  148.969px; border: 1pt solid windowtext; background: #0c3954; padding: 0cm 5.4pt;")
            Msg.AppendText(" height: 25px;' valign='middle'>")
            Msg.AppendText("<p class='MsoNormal' style='margin-middle:   .0001pt; text-align: center; line-height: normal;")
            Msg.AppendText("font-size 10.0pt; font-family 'Calibri',sans-serif;' align='center'>")
            Msg.AppendText("<strong><span style='color: #ffffff;'>" & dtSource.Columns(col).ColumnName & "</strong></p></td>")
        Next
        Msg.AppendText("</tr>")
        'DataRows
        For r = 0 To dtSource.Rows.Count - 1
            Msg.AppendText("<tr style='mso-yfti-irow:1;mso-yfti-lastrow:yes'>")
            For c = 0 To dtSource.Columns.Count - 1
                If dtSource.Columns(c).DataType.Name = "String" Then
                    If IsDBNull(dtSource.Rows(r)(c)) Then
                        dtSource.Rows(r)(c) = ""
                    End If
                End If
                'DataColumn
                Msg.AppendText("<td align=center width=auto valign=top style='width:134.45pt;font-size:10.0pt;font-family:""Calibri"",sans-serif'>")
                Msg.AppendText("<p><span style='color: #2f5496;'>" & dtSource.Rows(r)(c).ToString.Trim & "</span></p></td>")
            Next
            Msg.AppendText("</tr>")
        Next
        Msg.AppendText("</table><br>")
        'Fin de Tabla
        Return Msg.Text
    End Function
End Class

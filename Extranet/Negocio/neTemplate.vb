Imports Datos
Public Class neTemplate
    Dim adTemplate As New adTemplate()
    Public Function fnBodyMail(templateId As Integer, titleContent As String, body As String, image As String) As String
        Return adTemplate.fnBodyMail(templateId, titleContent, body, image)
    End Function
End Class

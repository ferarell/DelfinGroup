Imports System.Web.Services
Imports Entidades
Imports Negocio

Public Class comunicados
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub BootstrapButton1_Click(sender As Object, e As EventArgs) Handles BootstrapButton1.Click
        Dim print As String
        Dim body As String = contentBody.Text
        Try

            Dim oenCorreo As New neCorreo()
            Dim oenTemplate As New neTemplate()
            Dim image As String = ""
            Dim email As String = from.Text
            Dim emailArray() As String = email.Split(";")

            If (fileImage.HasFile) Then
                Dim nameFile As String = fileImage.FileName
                Dim extension() As String = nameFile.Split(".")
                Dim ruta As String = "~/comunicados/images/" + String.Format("{0}{1:yyyyMMddHHmmss}{2}", "", DateTime.Now, "") + "." + extension(extension.Length - 1)
                fileImage.SaveAs(Server.MapPath(ruta))
                image = ConfigurationManager.AppSettings("urlBase").ToString() + "/comunicados/images/" + nameFile
            End If

            Dim sMensaje As String = oenTemplate.fnBodyMail(templateIDhd.Text, titleContent.Text, body, image)

            For i = 0 To UBound(emailArray)
                oenCorreo.EnviarCorreo(emailArray(i), subject.Text, sMensaje)
            Next i
            print = "true"
        Catch ex As Exception
            print = "false"
        End Try
        messageHd.Text = print
    End Sub

End Class
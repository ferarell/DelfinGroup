Imports System.Data.SqlClient
Public Class adTemplate
    Public Function fnBodyMail(templateId As Integer, titleContent As String, body As String, image As String) As String
        Dim cn As New SqlConnection(New adConexion().Conexion())
        Dim bodyMail = ""
        Try
            Dim cmd As New SqlCommand("sp_templateBody", cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@type", SqlDbType.Int).Value = templateId
            cn.Open()
            Dim drd As SqlDataReader
            drd = cmd.ExecuteReader(CommandBehavior.SingleResult)
            While drd.Read()
                bodyMail = drd.GetString(0)
                bodyMail = bodyMail.Replace("{{image}}", image)
                bodyMail = bodyMail.Replace("{{title}}", titleContent)
                bodyMail = bodyMail.Replace("{{body}}", body)
            End While
        Catch ex As Exception

        Finally
            cn.Close()
        End Try



        Return bodyMail
    End Function
End Class

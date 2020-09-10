Imports System.Data.SqlClient
Public Class adPerfil
    Public Function fnListarPermisosUsuario(profileID As Integer) As String
        Dim listPermisos As String = ""
        Dim cn As New SqlConnection(New adConexion().Conexion())
        Try
            Dim cmd As New SqlCommand("sp_listarPermisosUsuario", cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@profileID", SqlDbType.VarChar).Value = profileID
            cn.Open()
            Dim drd As SqlDataReader
            drd = cmd.ExecuteReader(CommandBehavior.SingleResult)

            If drd IsNot Nothing Then
                While drd.Read()
                    listPermisos = drd.GetString(0)
                End While
            End If

        Catch ex As Exception

        Finally
            cn.Close()
        End Try

        Return listPermisos
    End Function
End Class

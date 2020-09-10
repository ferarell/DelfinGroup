Imports Entidades
Imports System.Data.SqlClient
Public Class adUsuario

    Public Function fnListar(poenUsuario As enUsuario) As DataTable
        Dim lstUsuario = New DataTable
        Dim oenUsuario As New enUsuario
        Dim cn As New SqlConnection(New adConexion().Conexion())
        Try
            Dim cmd As New SqlCommand("sp_ListarUsuario", cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = poenUsuario.sCorreo
            cn.Open()
            Dim drd As SqlDataReader
            drd = cmd.ExecuteReader(CommandBehavior.SingleResult)

            Dim dc As DataColumn
            dc = New DataColumn("code_customer", Type.GetType("System.Int32"))
            lstUsuario.Columns.Add(dc)
            dc = New DataColumn("razonsocial", Type.GetType("System.String"))
            lstUsuario.Columns.Add(dc)

            If drd IsNot Nothing Then
                While drd.Read()
                    Dim row As DataRow
                    row = lstUsuario.NewRow()
                    row("code_customer") = drd.GetInt32(0)
                    row("razonsocial") = drd.GetString(1)
                    lstUsuario.Rows.Add(row)
                End While

            End If

        Catch ex As Exception

        Finally
            cn.Close()
        End Try

        Return lstUsuario
    End Function

    Public Function fnMantenimientoUsuario(poenUsuario As enUsuario) As Integer
        Dim iResultado As Integer
        Dim cn As New SqlConnection(New adConexion().Conexion())

        Try
            Dim cmd As New SqlCommand("sp_Mantenimiento_User", cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@userID", SqlDbType.Int).Value = poenUsuario.iIdUsuario
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = poenUsuario.sNombre
            cmd.Parameters.Add("@surname", SqlDbType.VarChar).Value = poenUsuario.sApellidos
            cmd.Parameters.Add("@type_document", SqlDbType.Int).Value = poenUsuario.iTipoDocumento
            cmd.Parameters.Add("@number_document", SqlDbType.VarChar).Value = poenUsuario.sNroDocumento
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = poenUsuario.sCorreo
            cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = poenUsuario.sPassword
            cmd.Parameters.Add("@area", SqlDbType.VarChar).Value = poenUsuario.sArea
            cmd.Parameters.Add("@business_name", SqlDbType.VarChar).Value = poenUsuario.sRazonSocial
            cmd.Parameters.Add("@codeCustomer", SqlDbType.Int).Value = poenUsuario.sCodeCustomer
            cmd.Parameters.Add("@profileID", SqlDbType.Int).Value = poenUsuario.iPerfilID
            cmd.Parameters.Add("@userType", SqlDbType.Int).Value = poenUsuario.iUserType
            cn.Open()
            iResultado = Convert.ToInt32(cmd.ExecuteScalar())
        Catch ex As Exception
            MsgBox(ex)
        Finally
            cn.Close()
        End Try
        Return iResultado
    End Function

    Public Function fnValidarRegistro(poenUsuario As enUsuario) As Integer
        Dim iResultado As Integer
        Dim cn As New SqlConnection(New adConexion().Conexion())

        Try
            Dim cmd As New SqlCommand("sp_validarRegistro", cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@type_document", SqlDbType.Int).Value = poenUsuario.iTipoDocumento
            cmd.Parameters.Add("@number_document", SqlDbType.VarChar).Value = poenUsuario.sNroDocumento
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = poenUsuario.sCorreo
            cn.Open()
            iResultado = Convert.ToInt32(cmd.ExecuteScalar())
        Catch ex As Exception
            MsgBox(ex)
        Finally
            cn.Close()
        End Try
        Return iResultado
    End Function

    Public Function fnLogin(poenUsuario As enUsuario) As List(Of enUsuario)
        Dim lstUsuario = New List(Of enUsuario)
        Dim oenUsuario As New enUsuario
        Dim cn As New SqlConnection(New adConexion().Conexion())
        Try

            Dim cmd As New SqlCommand("sp_Login", cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@vCorreo", SqlDbType.VarChar).Value = poenUsuario.sCorreo
            cmd.Parameters.Add("@vPassword", SqlDbType.VarChar).Value = poenUsuario.sPassword
            cn.Open()
            Dim drd As SqlDataReader
            drd = cmd.ExecuteReader(CommandBehavior.SingleResult)
            If drd IsNot Nothing Then
                lstUsuario = New List(Of enUsuario)
                While drd.Read()
                    oenUsuario = New enUsuario
                    oenUsuario.sNroDocumento = drd.GetString(0)
                    oenUsuario.sNombre = drd.GetString(1)
                    oenUsuario.sApellidos = drd.GetString(2)
                    oenUsuario.sCorreo = drd.GetString(3)
                    oenUsuario.sArea = drd.GetString(4)
                    oenUsuario.iTipoDocumento = drd.GetInt32(5)
                    oenUsuario.iIdUsuario = drd.GetInt32(6)
                    oenUsuario.sStatus = drd.GetInt32(7)
                    oenUsuario.sRazonSocial = drd.GetString(8)
                    oenUsuario.iPerfilID = drd.GetInt32(9)
                    oenUsuario.sCodeCustomer = drd.GetInt32(10)
                    oenUsuario.sNroDocumento = drd.GetString(11)
                    lstUsuario.Add(oenUsuario)
                End While
            End If

        Catch ex As Exception

        Finally
            cn.Close()
        End Try

        Return lstUsuario
    End Function

    Public Function fnRecuperarContrasenia(poenUsuario As enUsuario) As Integer
        Dim iResultado As Integer
        Dim cn As New SqlConnection(New adConexion().Conexion())

        Try
            Dim cmd As New SqlCommand("sp_RecoverPassword", cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@vEmail", SqlDbType.VarChar).Value = poenUsuario.sCorreo
            cmd.Parameters.Add("@vPassword", SqlDbType.VarChar).Value = poenUsuario.sPassword
            cn.Open()
            iResultado = Convert.ToInt32(cmd.ExecuteScalar())
        Catch ex As Exception
            Throw ex
        Finally
            cn.Close()
        End Try
        Return iResultado
    End Function

    Public Function fnUpdateStatus(poenUsuario As enUsuario) As Integer
        Dim iResultado As Integer
        Dim cn As New SqlConnection(New adConexion().Conexion())

        Try
            Dim cmd As New SqlCommand("sp_update_status", cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = poenUsuario.sCorreo
            cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = poenUsuario.sStatus
            cn.Open()
            iResultado = Convert.ToInt32(cmd.ExecuteScalar())
        Catch ex As Exception
            Throw ex
        Finally
            cn.Close()
        End Try
        Return iResultado
    End Function

    Public Function fnRecoverPassword(poenUsuario As enUsuario) As Integer
        Dim iResultado As Integer
        Dim cn As New SqlConnection(New adConexion().Conexion())

        Try
            Dim cmd As New SqlCommand("sp_RecoverPassword", cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@vEmail", SqlDbType.VarChar).Value = poenUsuario.sCorreo
            cmd.Parameters.Add("@vPassword", SqlDbType.VarChar).Value = poenUsuario.sPassword
            cn.Open()
            iResultado = Convert.ToInt32(cmd.ExecuteScalar())
        Catch ex As Exception
            Throw ex
        Finally
            cn.Close()
        End Try
        Return iResultado
    End Function

End Class

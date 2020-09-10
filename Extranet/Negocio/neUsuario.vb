Imports Datos
Imports Entidades

Public Class neUsuario

    Dim adusuario As New adUsuario()
    Public Function fnListar(poenUsuario As enUsuario) As DataTable
        Return adusuario.fnListar(poenUsuario)
    End Function
    Public Function fnMantenimientoUsuario(poenUsuario As enUsuario) As Integer
        Return adusuario.fnMantenimientoUsuario(poenUsuario)
    End Function
    Public Function fnValidarRegistro(poenUsuario As enUsuario) As Integer
        Return adusuario.fnValidarRegistro(poenUsuario)
    End Function
    Public Function fnLogin(poenUsuario As enUsuario) As List(Of enUsuario)
        Return adusuario.fnLogin(poenUsuario)
    End Function
    Public Function fnRecuperarContrasenia(poenUsuario As enUsuario) As Integer
        Return adusuario.fnRecuperarContrasenia(poenUsuario)
    End Function
    Public Function fnUpdateStatus(poenUsuario As enUsuario) As Integer
        Return adusuario.fnUpdateStatus(poenUsuario)
    End Function
    Public Function fnRecoverPassword(poenUsuario As enUsuario) As Integer
        Return adusuario.fnRecoverPassword(poenUsuario)
    End Function
End Class

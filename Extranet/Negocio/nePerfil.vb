Imports Datos
Public Class nePerfil
    Dim adPerfil As New adPerfil()
    Public Function fnListarPermisosUsuario(profileID As Integer) As String
        Return adPerfil.fnListarPermisosUsuario(profileID)
    End Function
End Class

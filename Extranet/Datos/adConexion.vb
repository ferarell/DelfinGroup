Imports System.Configuration
Public Class adConexion
    Public Function Conexion() As String
        Return ConfigurationManager.ConnectionStrings("MyConexion").ConnectionString
    End Function
End Class

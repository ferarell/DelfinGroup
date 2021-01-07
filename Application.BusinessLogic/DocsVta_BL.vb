Imports Application.BusinessEntities
Imports Application.DataAccess
Public Class DocsVta_BL
    Dim DocsVta_DA As New DocsVta_DA

    Public Function PreFacturar(PDOC_Codigo As Integer, AUDI_UsrCrea As String) As Boolean
        Return DocsVta_DA.PreFacturar(PDOC_Codigo, AUDI_UsrCrea)
    End Function

End Class

Imports Application.BusinessEntities
Imports Application.DataAccess
Public Class DocsVta_BL
    Dim DocsVta_DA As New DocsVta_DA

    Public Function PreFacturar(COPE_Codigo As Integer, dsDocumentoVenta As DataSet) As ArrayList
        Return DocsVta_DA.PreFacturar(COPE_Codigo, dsDocumentoVenta)
    End Function

End Class

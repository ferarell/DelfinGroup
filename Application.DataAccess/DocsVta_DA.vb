Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Imports Application.BusinessEntities
Public Class DocsVta_DA
    Dim constr As String = ConfigurationSettings.AppSettings("dbNextSoft").ToString()
    Dim cnx As New SqlConnection(constr)
    Dim cmd As New SqlCommand



    Public Function PreFacturar(PDOC_Codigo As Integer, AUDI_UsrCrea As String) As Boolean

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "DGP.VEN_DOCVSI_InsertaUnDocumento"

            With .Parameters
                .Clear()
                .Add("@pintPDOC_Codigo", SqlDbType.Int, 4).Value = PDOC_Codigo
                .Add("@pvchAUDI_UsrCrea", SqlDbType.VarChar, 20).Value = AUDI_UsrCrea
            End With
        End With

        Try
            cnx.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw
        Finally
            cnx.Close()
        End Try
    End Function



    Public Function ImprimirDocumento()




    End Function




End Class

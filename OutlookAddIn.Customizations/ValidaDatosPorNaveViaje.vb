Imports System
Imports System.Data
Imports System.Collections
Imports System.Windows.Forms

Public Class ValidaDatosPorNaveViaje
    Dim oAppService As New AppService.DelfinServiceClient
    Dim dsResult As New DataSet
    Dim Msg As New RichTextBox

    Friend Function DataProcess(oFileName As String, oMailItem As Outlook.MailItem, oNaviera As String) As Boolean
        Dim bResult As Boolean = True
        Dim dtSource As New DataTable
        Dim sQuery As String = ""
        Dim sHoja As String = ""
        If oNaviera = "MAERSK" Then
            sHoja = "Contenedores$"
            sQuery = "SELECT Nave, Viaje, 'MAEU' + Bl AS Bl, Contenedor FROM [" & sHoja & "]"
        End If
        If oNaviera = "HAPAG" Then
            sHoja = "Result$"
            sQuery = "SELECT F19 AS Nave, F20 AS Viaje, F2 AS Bl, F7 AS Contenedor FROM [" & sHoja & "] WHERE F19 IS NOT NULL AND LEFT(F2,4) = 'HLCU' "
        End If
        Try
            If LoadExcel(oFileName, sHoja).Tables(0).Rows.Count > 0 Then
                dtSource = QueryExcel(oFileName, sQuery).Tables(0)
            End If
            dsResult.Tables.Clear()
            Dim dtResult As New DataTable
            dtResult.Columns.Add("Nave", GetType(String)).DefaultValue = ""
            dtResult.Columns.Add("Viaje", GetType(String)).DefaultValue = ""
            dtResult.Columns.Add("Bl", GetType(String)).DefaultValue = ""
            dtResult.Columns.Add("Contenedor", GetType(String)).DefaultValue = ""

            DataValidation1(dtResult.Clone, dtSource) 'Valida Existencia en NextSoft
            DataValidation2(dtResult.Clone, dtSource) 'Valida Existencia en Excel de Naviera

            Msg.AppendText(drConfig("Signature"))

            oMailItem.HTMLBody = Msg.Text & "<br><br>" & oMailItem.HTMLBody

            SendNewMessage("PRC_OK", oMailItem, Identifier, "", Nothing)
        Catch ex As Exception
            bResult = False
            SendNewMessage("PRC_ERROR", oMailItem, Identifier, ex.Message, Nothing)
        End Try
        Return bResult
    End Function

    Private Sub DataValidation1(dtResult As DataTable, dtSource As DataTable)
        Dim dtQuery As New DataTable
        Dim oGetHtmlTable As New GetHtmlTableOld
        For r = 0 To dtSource.Rows.Count - 1
            Dim oRow As DataRow = dtSource.Rows(r)
            oRow("Contenedor") = Replace(oRow("Contenedor"), " ", "")
            dtQuery = oAppService.ExecuteSQL("EXEC Integrador.ope.paConsultaDatosPorNave '" & oRow("Nave") & "','" & oRow("Viaje") & "','" & oRow("Bl") & "','" & oRow("Contenedor") & "'").Tables(0)
            If dtQuery.Rows.Count = 0 Then
                dtResult.Rows.Add(oRow.ItemArray)
            End If
        Next
        If dtResult.Rows.Count > 0 Then
            dsResult.Tables.Add(dtResult.Copy)
            dsResult.Tables(0).TableName = "LOCAL"
            Msg.AppendText("Lista de bls y contenedores que no existen en NextSoft: <br><br>")
            Msg.AppendText(oGetHtmlTable.GenerateTable(dtResult) & "<br><br>")
        Else
            Msg.AppendText("Todos los bls y contenedores del excel enviado por la naviera existen en NextSoft. <br><br>")
        End If
    End Sub

    Private Sub DataValidation2(dtResult As DataTable, dtSource As DataTable)
        Dim dtQuery As New DataTable
        Dim oGetHtmlTable As New GetHtmlTableOld
        Dim dtDistinct As New DataTable
        dtDistinct = SelectDistinct(dtSource, "", "Nave")
        For r = 0 To dtDistinct.Rows.Count - 1
            Dim oRow As DataRow = dtSource.Rows(r)
            dtQuery = oAppService.ExecuteSQL("EXEC Integrador.ope.paConsultaDatosPorNave '" & oRow("Nave") & "',NULL,NULL,NULL").Tables(0)
            If dtQuery.Rows.Count = 0 Then
                Continue For
            End If
            For d = 0 To dtQuery.Rows.Count - 1
                Dim drQuery As DataRow = dtQuery.Rows(d)
                drQuery("Contenedor") = Replace(drQuery("Contenedor"), " ", "")
                If dtSource.Select("Nave='" & drQuery("Nave") & "' AND Bl='" & drQuery("Bl") & "' AND Contenedor='" & drQuery("Contenedor") & "'").Length = 0 Then
                    dtResult.Rows.Add(drQuery.ItemArray)
                End If
            Next
        Next
        If dtResult.Rows.Count > 0 Then
            dsResult.Tables.Add(dtResult.Copy)
            dsResult.Tables(0).TableName = "NAVIERA"
            Msg.AppendText("Lista de bls y contenedores de NextSoft que no existen en archivo enviado por la naviera: <br><br>")
            Msg.AppendText(oGetHtmlTable.GenerateTable(dtResult) & "<br><br>")
        Else
            Msg.AppendText("Todos los bls y contenedores de las naves reportadas por la naviera existen en NextSoft. <br><br>")
        End If
    End Sub

End Class

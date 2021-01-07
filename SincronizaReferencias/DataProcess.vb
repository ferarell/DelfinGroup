Public Class DataProcess
    Dim oAppService As New AppService.DelfinServiceClient
    Dim oIntegrationService As New IntegrationService.IntegradorSBOClient

    Public Sub DataGenerate(sHbl As String, sTipRef As String, sAppUser As String)
        Dim bResult As Boolean = True
        Dim dsReferences As New DataSet
        Try
            'Interfaz de Referencias
            Dim sqlText As String = "NextSoft.sap.upGetDataForReferenciaInterface '" & sTipRef & "','" & sHbl & "','" & sAppUser & "'"
            Console.Write("EJECUTA SP: " & sqlText)
            dsReferences = oAppService.ExecuteSQL(sqlText)
            If dsReferences.Tables(0).Rows.Count = 0 Then
                oLogFileGenerate.TextFileUpdate(oProcessName, "El HBL: " & sHbl & " no tiene referencias asociadas")
                Return
            End If
            Dim aRespuesta As New ArrayList
            aRespuesta.AddRange(oIntegrationService.InsertarActualizarReferencias(dsReferences))
            If aRespuesta(0).RespuestaSAP = 0 Then
                oLogFileGenerate.TextFileUpdate(oProcessName, "Ocurrió un error al actualizar las referencias del HBL: " & sHbl & " en SAP" & vbCrLf & DirectCast(aRespuesta(0), IntegrationService.Respuesta).Response(0).[error].Message.Value)
            End If
        Catch ex As Exception
            oLogFileGenerate.TextFileUpdate(oProcessName, ex.Message)
        End Try

    End Sub

End Class

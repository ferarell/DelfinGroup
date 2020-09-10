
Imports System.Collections
Imports System.Data

Public Class EmisionHBL
    Dim oAppService As New PorticoService.PorticoClient
    Dim oSendMessage As New SendMessage

    Friend Function DataProcess(oMailItem As Outlook.MailItem) As Boolean
        Dim bResult As Boolean = True
        Dim dtQuery As New DataTable
        Dim sHbl As String = Replace(oMailItem.Subject.ToString.ToUpper, drConfig("SubjectIdentifier").ToString.ToUpper, "").ToString.Trim
        dtQuery = ExecuteSQL("SELECT CCOT_Numero, DOOV_HBL FROM NextSoft..COM_Cab_Cotizacion_OV (NOLOCK) WHERE DOOV_HBL='" & sHbl & "'")
        If dtQuery.Rows.Count = 0 Then
            SendNewMessage("PRC_ERROR", oMailItem, Identifier, "El HBL " & sHbl & " no existe en el sistema, por favor verifique.", Nothing)
            Return False
        End If
        Dim iCCOT_Numero As Integer = dtQuery.Rows(0)(0)
        dtQuery.Clear()
        dtQuery = ExecuteSQL("SELECT CCOT_Numero FROM NextSoft..COM_Det_Cotizacion_OV_EventosTareas (NOLOCK) WHERE CCOT_Numero = " & iCCOT_Numero.ToString & " AND TIPO_CodEVE in (102,141)")
        If dtQuery.Rows.Count = 0 Then
            SendNewMessage("PRC_ERROR", oMailItem, Identifier, "El HBL " & sHbl & " consultado no se ha configurado para emisión en destino.", Nothing)
            Return False
        End If
        dtQuery.Clear()
        dtQuery = ExecuteSQL("EXEC NextSoft.ptc.OPE_CCOTSS_PorPagar 1,'" & sHbl & "'")
        If dtQuery.Rows.Count = 0 Then
            SendNewMessage("PRC_ERROR", oMailItem, Identifier, "La consulta del HBL " & sHbl & " no ha retornado datos, por favor verifique.", Nothing)
            Return False
        End If
        Try
            Dim aAttachments As New ArrayList
            aAttachments.Add(My.Settings.LayoutPath & "\COMUNICADO No.10 - VoBo HBL-HAWB ELECTRONICO.PDF")
            oSendMessage.ResponseWithTable(oMailItem, drConfig("IdInputType"), aAttachments, dtQuery)
        Catch ex As Exception
            bResult = False
            SendErrorMessage(oMailItem, Identifier, ex.Message, Nothing)
        End Try
        Return bResult
    End Function

End Class

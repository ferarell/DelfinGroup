Imports System
Imports System.Data
Imports System.Collections
Imports System.Windows.Forms
Imports CrystalDecisions.Shared

Public Class AvisoLlegada
    Dim oAppService As New PorticoService.PorticoClient
    Dim oSendMessage As New SendMessage

    Friend Function DataProcess(oMailItem As Outlook.MailItem) As Boolean
        Dim bResult As Boolean = True
        Dim aAttachments As New ArrayList
        'Dim dsPrint As New DataSet
        'Dim dtPrint1, dtPrint2 As New DataTable
        Dim dtQuery As New DataTable
        Dim sHbl As String = Replace(oMailItem.Subject.ToString.ToUpper, drConfig("SubjectIdentifier").ToString.ToUpper, "").ToString.Trim
        dtQuery = ExecuteSQL("SELECT CCOT_Numero, DOOV_HBL FROM NextSoft..COM_Cab_Cotizacion_OV (NOLOCK) WHERE DOOV_HBL='" & sHbl & "'")
        If dtQuery.Rows.Count = 0 Then
            aAttachments.Add(IO.Path.GetDirectoryName(New Uri(System.Reflection.Assembly.GetExecutingAssembly().CodeBase).LocalPath) & "\Manual Solicitud Aviso Zarpe_Llegada.pdf")
            SendNewMessage("PRC_ERROR", oMailItem, Identifier, "El HBL " & sHbl & " no existe en el sistema o no fue asignado correctamente, por favor revise la información incluida en el manual adjunto.", aAttachments)
            Return False
        End If
        Dim iCCOT_Numero As Integer = dtQuery.Rows(0)(0)
        dtQuery.Clear()
        dtQuery = ExecuteSQL("SELECT CCOT_Numero FROM NextSoft..COM_Det_Cotizacion_OV_EventosTareas (NOLOCK) WHERE CCOT_Numero = " & iCCOT_Numero.ToString & " AND TIPO_CodEVE=115")
        If dtQuery.Rows.Count = 0 Then
            SendNewMessage("PRC_INFO", oMailItem, Identifier, "Favor tomar nota que el aviso del HBL " & sHbl & " aún no ha sido enviado por el área de Operaciones, por favor remitir su consulta a customerper@delfingroupco.com.pe", Nothing)
            Return False
        End If
        dtQuery.Clear()
        dtQuery = ExecuteSQL("EXEC NextSoft.ptc.COM_NVIASS_Avisos 1, 1, NULL, NULL, NULL, NULL, '" & sHbl & "'")
        If dtQuery.Rows.Count = 0 Then
            SendNewMessage("PRC_ERROR", oMailItem, Identifier, "La consulta del HBL " & sHbl & " no ha retornado datos, por favor verifique.", Nothing)
            Return False
        End If
        Dim sFileName As String = My.Settings.ProcessedPath & "\AVISO_" & sHbl & "_" & Now.ToString("yyyyMMdd") & ".pdf"
        Dim iResponse As Integer = 0
        Try
            Dim sExecFile As String = AppPath & "\ReportGenerator.exe"
            Dim oProcess As New System.Diagnostics.Process
            oProcess.StartInfo.FileName = sExecFile
            oProcess.StartInfo.Arguments = "/HBL=" & sHbl & Space(1) & "/LOGFILE=" & My.Settings.LogFilePath
            'oProcess.StartInfo.UseShellExecute = False
            'oProcess.StartInfo.CreateNoWindow = False
            oProcess.StartInfo.WindowStyle = Diagnostics.ProcessWindowStyle.Minimized
            'oProcess.HasExited
            oProcess.Start()
            'iResponse = oProcess.ExitCode
        Catch ex As Exception
            iResponse = -1
        End Try
        If iResponse <> 0 Then
            Return False
        End If
        While IO.File.Exists(sFileName) = False
        End While
        aAttachments.Add(sFileName)
        aAttachments.Add(My.Settings.LayoutPath & "\COMUNICADO No.10 - VoBo HBL-HAWB ELECTRONICO.PDF")
        oSendMessage.Response(oMailItem, drConfig("IdInputType"), aAttachments)
        'SendNewMessage("PRC_OK", oMailItem, Identifier, "", aAttachments)
        Return bResult
    End Function

End Class

Imports System.Data
Imports System.Collections
Imports System.Threading
Imports DevExpress.XtraEditors
Imports System.Windows.Forms

Public Class ThisAddIn
    Dim outlookNameSpace As Outlook.NameSpace
    Dim inbox As Outlook.MAPIFolder
    Public WithEvents items As Outlook.Items
    Dim oAppService As New AppService.DelfinServiceClient
    Dim oSendMessage As New SendMessage

    Private Sub ThisAddIn_Startup() Handles Me.Startup
        If Not My.Settings.GetPreviousVersion("WebServiceURL") Is Nothing Then
            My.Settings.Upgrade()
        End If
        outlookNameSpace = Me.Application.GetNamespace("MAPI")
        inbox = outlookNameSpace.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderInbox)
        items = inbox.Items
    End Sub

    Private Sub Items_ItemAdd(ByVal item As Object) Handles items.ItemAdd
        Dim mailItem As Outlook.MailItem = item
        Identifier = GetFilter(mailItem).ToUpper
        If Identifier = "" Then
            If Not mailItem.SenderEmailAddress.ToUpper.Contains("DELFINGROUPCO.COM.PE") Then
                RejectMailResponse(mailItem, 0)
            End If
            Return
        End If
        If drConfig("IdInputType") = 1 Then
            StaticMailResponse(item)
        ElseIf drConfig("IdInputType") = 2 Then
            DynamicMailResponse(item, drConfig("IdInputConfiguration"))
        ElseIf drConfig("IdInputType") = 3 Then
            InquiryMailResponse(item, drConfig("IdInputConfiguration"))
        ElseIf drConfig("IdInputType") = 4 Then
            CallProcess(item, drConfig("IdInputConfiguration"))
        End If
    End Sub

    Friend Function GetFilter(mailItem As Outlook.MailItem) As String
        Dim dtQuery As New DataTable
        Dim SubjectIdentifier As String = ""
        dtQuery = oAppService.ExecuteSQL("EXEC ptc.upGetIdentifiersById NULL").Tables(0)
        If mailItem.Attachments.Count > 0 Then
            For f = 1 To mailItem.Attachments.Count
                If mailItem.Attachments.Item(f).FileName.ToUpper.Contains(".XML") Then
                    SubjectIdentifier = "FACTURACION"
                End If
            Next
        End If
        For r = 0 To dtQuery.Rows.Count - 1
            If IsDBNull(dtQuery.Rows(r)("SubjectIdentifier")) Or dtQuery.Rows(r)("IdInputType") < 0 Then
                Continue For
            End If
            If mailItem.Subject.ToUpper.Contains(dtQuery.Rows(r)("SubjectIdentifier").ToString.ToUpper) Or (SubjectIdentifier.Length > 0 And dtQuery.Rows(r)("SubjectIdentifier").ToString.ToUpper.Contains(SubjectIdentifier)) Then
                Identifier = dtQuery.Rows(r)("IdInputConfiguration")
                SubjectIdentifier = dtQuery.Rows(r)("SubjectIdentifier")
            End If
        Next
        If SubjectIdentifier <> "" Then
            dtConfig.Rows.Clear()
            dtConfig = oAppService.ExecuteSQL("EXEC ptc.upGetConfigurationById " & Identifier.ToString).Tables(0)
            drConfig = dtQuery.Select("SubjectIdentifier='" & SubjectIdentifier & "'")(0)
        End If



        Return SubjectIdentifier
    End Function

    Private Sub StaticMailResponse(item As Object)
        oSendMessage.Response(item, drConfig("IdInputType"), Nothing)
    End Sub

    Private Sub RejectMailResponse(item As Object, InputType As Integer)
        dtConfig = oAppService.ExecuteSQL("EXEC ptc.upGetConfigurationByTypeId " & InputType.ToString).Tables(0)
        oSendMessage.Response(item, InputType, Nothing)
    End Sub

    Private Sub DynamicMailResponse(item As Object, IdInput As Integer)
        Dim mailItem As Outlook.MailItem = item
        Dim tProc As Thread = Nothing
        If IdInput = 2 Then
            Dim oEmisionHBL As New EmisionHBL
            tProc = New Thread(Sub() oEmisionHBL.DataProcess(item))
        End If
        If IdInput = 4 Then
            Dim oAvisoLlegada As New AvisoLlegada
            tProc = New Thread(Sub() oAvisoLlegada.DataProcess(item))
        End If
        Try
            tProc.Start()
        Catch ex As Exception
            SendErrorMessage(item, Identifier, ex.Message, Nothing)
        End Try
    End Sub

    Private Sub InquiryMailResponse(item As Object, IdInput As Integer)
        oSendMessage.Response(item, drConfig("IdInputType"), Nothing)
    End Sub

    Private Sub CallProcess(item As Object, IdInput As Integer)
        Dim mailItem As Outlook.MailItem = item
        'Dim sFileName = FileIO.FileSystem.GetTempFileName
        'For a = 1 To mailItem.Attachments.Count
        '    If mailItem.Attachments(a).FileName.ToUpper.Contains({"XLS", "TXT"}) Then
        '        sFileName = My.Settings.ProcessedPath & "\" & Format(Now, "ddMMyyyy HHmmss") & " - " & mailItem.Attachments(a).FileName
        '        mailItem.Attachments(a).SaveAsFile(sFileName)
        '    End If
        'Next
        'If Not IO.File.Exists(sFileName) Then
        '    DevExpress.XtraEditors.XtraMessageBox.Show("No se descargó el archivo adjunto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Return
        'End If
        Dim tProc As Thread = Nothing
        If IdInput = 1 Then
            Dim oCongestionPortuaria As New CongestionPortuaria
            tProc = New Thread(Sub() oCongestionPortuaria.DataProcess(item))
        End If
        If IdInput = 7 Then
            Dim oFacturacionElectronica As New FacturacionElectronica
            tProc = New Thread(Sub() oFacturacionElectronica.DataProcess(item))
        End If
        'If Identifier = "DELFIN GROUP SHIPMENTS" Then
        '    Dim oValidaDatosPorNaveViaje As New ValidaDatosPorNaveViaje
        '    tProc = New Thread(Sub() oValidaDatosPorNaveViaje.DataProcess(sFileName, item, "MAERSK"))
        'End If
        'If Identifier = "DELFIN REPORT MN" Then
        '    Dim oValidaDatosPorNaveViaje As New ValidaDatosPorNaveViaje
        '    tProc = New Thread(Sub() oValidaDatosPorNaveViaje.DataProcess(sFileName, item, "HAPAG"))
        'End If
        Try
            tProc.Start()
        Catch ex As Exception
            SendErrorMessage(item, Identifier, ex.Message, Nothing)
        End Try
    End Sub

    Private Sub ThisAddIn_Shutdown() Handles Me.Shutdown

    End Sub

End Class

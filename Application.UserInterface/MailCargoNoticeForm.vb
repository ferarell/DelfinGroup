Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraSplashScreen
Imports Microsoft.Office.Interop
Imports DevExpress.XtraWaitForm
Imports System.Runtime.InteropServices
Imports System.Windows
Imports System.IO
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors

Public Class MailCargoNoticeForm

    Private WithEvents richEditControl As New DevExpress.XtraRichEdit.RichEditControl
    Dim oAppService As New AppService.DelfinServiceClient
    Dim oMasterDataList As New MasterDataList
    Public AppUser As String = "sistemas"
    Public bSearch As Boolean = False

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        'DevExpress.UserSkins.BonusSkins.Register()
        'DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Blue")

    End Sub

    Private Sub MailCargoNoticeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gcMainData.MainView.RestoreLayoutFromRegistry(IO.Directory.GetCurrentDirectory)
        'Me.WindowState = FormWindowState.Maximized
        Me.StartPosition = FormStartPosition.CenterScreen
        SplitContainerControl2.SplitterPosition = SplitContainerControl2.Height * 0.6
        SplitContainerControl3.SplitterPosition = Me.Width * 0.75
        VGridControl1.OptionsView.MinRowAutoHeight = 40
        LoadShipline()
        LoadVoyage()
        LoadDepot()
        LoadNoticeLayout()
        ButtonEnabled()
        If bSearch Then
            lueShipline.Enabled = False
            lueVoyage.Enabled = False
            teHBL.Enabled = False
            lueNoticeLayout.Enabled = False
            bbiSearch.PerformClick()
        End If
    End Sub

    Private Sub LoadNoticeLayout()
        lueNoticeLayout.Properties.DataSource = oMasterDataList.LoadMasterData("NoticeLayout", Nothing)
        lueNoticeLayout.Properties.DisplayMember = "DescripcionFormato"
        lueNoticeLayout.Properties.ValueMember = "CodigoFormato"
        lueNoticeLayout.ItemIndex = 0
    End Sub

    Private Sub LoadShipline()
        lueShipline.Properties.DataSource = GetShipline(Nothing)
        lueShipline.Properties.DisplayMember = "DescripcionTransportista"
        lueShipline.Properties.ValueMember = "CodigoTransportista"
    End Sub

    Private Sub LoadVoyage()
        lueVoyage.Properties.DataSource = GetVoyage(Nothing, lueShipline.EditValue)
        lueVoyage.Properties.DisplayMember = "NombreNave"
        lueVoyage.Properties.ValueMember = "CodigoViaje"
    End Sub

    Private Sub LoadDepot()
        RepositoryItemLookUpEdit1.DataSource = GetDepot(Nothing)
        RepositoryItemLookUpEdit1.DisplayMember = "DescripcionDepositoTemporal"
        RepositoryItemLookUpEdit1.ValueMember = "CodigoDepositoTemporal"
    End Sub

    Private Sub bbiClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiClose.ItemClick
        Me.Close()
    End Sub

    Private Sub lueShipline_Properties_EditValueChanged(sender As Object, e As EventArgs) Handles lueShipline.Properties.EditValueChanged, lueNoticeLayout.Properties.EditValueChanged
        LoadVoyage()
    End Sub

    Private Sub lueVoyage_EditValueChanged(sender As Object, e As EventArgs) Handles lueVoyage.EditValueChanged
        teVoyage.Text = lueVoyage.GetColumnValue("Viaje_Vuelo")
    End Sub

    Private Sub bbiSearch_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSearch.ItemClick
        LoadInputValidations()
        If Not vpInputs.Validate Then
            Return
        End If
        ButtonEnabled()
        gcMainData.DataSource = Nothing
        gcContainer.DataSource = Nothing
        SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)
        SplashScreenManager.Default.SetWaitFormDescription("Consultando datos")
        Try
            Dim dtQuery As New DataTable
            Dim sQuery As String = ""
            sQuery += "EXEC NextSoft.dgp.paObtieneAvisoPorCorreo "
            If Not lueShipline.EditValue Is Nothing Then
                sQuery += lueShipline.EditValue.ToString
            Else
                sQuery += "NULL"
            End If
            If Not lueVoyage.EditValue Is Nothing Then
                sQuery += "," & lueVoyage.EditValue.ToString
            Else
                sQuery += ", NULL"
            End If
            If teHBL.Text.Trim <> "" Then
                sQuery += ",'" & teHBL.Text.Trim & "'"
            Else
                sQuery += ", NULL"
            End If
            If Not lueNoticeLayout.EditValue Is Nothing Then
                sQuery += ",'" & lueNoticeLayout.EditValue.ToString & "'"
            Else
                sQuery += ", NULL"
            End If
            'sQuery += "," & IIf(teHBL.Text.Trim = "", "NULL", "'" & teHBL.Text.Trim & "'")
            dtQuery = oAppService.ExecuteSQL(sQuery).Tables(0)
            dtQuery.Columns.Add("Enviado", GetType(Boolean)).DefaultValue = False
            GridView1.Columns.Item("CCOT_EnviaAvisoLlegada").OptionsColumn.ReadOnly = True
            If lueNoticeLayout.EditValue = "002" Then
                GridView1.Columns.Item("CCOT_EnviaAvisoLlegada").OptionsColumn.ReadOnly = False
            End If
            GridView1.BestFitMaxRowCount = 1
            GridView1.BestFitColumns()
            gcMainData.DataSource = dtQuery
            VGridControl1.DataSource = dtQuery
            ButtonEnabled()
            GridView1.Focus()
            GridView1.MoveFirst()
        Catch ex As Exception
            SplashScreenManager.CloseForm(False)
        End Try
        SplashScreenManager.CloseForm(False)
    End Sub

    Private Sub LoadInputValidations()
        Validate()
        Dim containsValidationRule As New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        containsValidationRule.ConditionOperator = ConditionOperator.IsNotBlank
        containsValidationRule.ErrorText = "Asigne un valor."
        containsValidationRule.ErrorType = ErrorType.Critical
        Dim customValidationRule As New CustomValidationRule()
        customValidationRule.ErrorText = "Valor obligatorio."
        customValidationRule.ErrorType = ErrorType.Critical
        vpInputs.SetValidationRule(Me.lueVoyage, Nothing)
        If teHBL.Text = "" Then
            vpInputs.SetValidationRule(Me.lueVoyage, customValidationRule)
        End If
    End Sub

    Private Sub bbiExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExport.ItemClick
        ExportToExcel(gcMainData)
    End Sub

    Private Sub bbiCreateMessage_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCreateMessage.ItemClick
        Validate()
        If DevExpress.XtraEditors.XtraMessageBox.Show("El envío de este mensaje NO registrará un evento, desea continuar? ", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Forms.DialogResult.No Then
            Return
        End If
        Dim iSelected As Integer = RowSelectedCount(GridView1)
        If iSelected = 0 Then
            XtraMessageBox.Show("Debe seleccionar al menos una fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If lueNoticeLayout.EditValue = "001" Then
            MailGenerate1(GridView1.GetFocusedDataRow, "Display")
        ElseIf lueNoticeLayout.EditValue = "002" Then
            MailGenerate2(GridView1.GetFocusedDataRow, "Display")
        ElseIf lueNoticeLayout.EditValue = "003" Then
            MailGenerate3(GridView1.GetFocusedDataRow, "Display")
        End If

    End Sub

    Private Sub bbiSendAllMessage_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSendAllMessage.ItemClick
        Validate()
        If DevExpress.XtraEditors.XtraMessageBox.Show("El envío masivo registrará un evento por cada HBL, desea continuar? ", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Forms.DialogResult.No Then
            Return
        End If
        Dim iSelected As Integer = RowSelectedCount(GridView1)
        If iSelected = 0 Then
            XtraMessageBox.Show("Debe seleccionar al menos una fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        GridView1.Focus()
        Dim oEventUpdate As New EventUpdate
        For r = 0 To GridView1.DataRowCount - 1
            Dim oRow As DataRow = GridView1.GetDataRow(r)
            If oRow("CCOT_EnviaAvisoLlegada") = False Then
                Continue For
            End If
            If oRow("ENTC_EMail") = "" Then
                Continue For
            End If
            oEventUpdate.CCOT_Numero = oRow("CCOT_Numero")
            oEventUpdate.EVEN_Observaciones = "Se ha enviado el correo al Cliente a través de Gestión de Avisos."
            oEventUpdate.AUDI_UsrCrea = AppUser
            If lueNoticeLayout.EditValue = "001" Then
                If MailGenerate1(oRow, "Send") Then
                    oRow("Enviado") = True
                    oEventUpdate.TIPO_CodEVE = "115"
                    oEventUpdate.InsertEvent()
                End If
            ElseIf lueNoticeLayout.EditValue = "002" Then
                If MailGenerate2(oRow, "Send") Then
                    oRow("Enviado") = True
                    oEventUpdate.TIPO_CodEVE = "128"
                    oEventUpdate.InsertEvent()
                End If
            End If
        Next
        bbiSearch.PerformClick()
    End Sub

    Function MailGenerate1(oRow As DataRow, _MsgType As String) As Boolean
        Dim bResult As Boolean = True
        Dim dsPrint As New DataSet
        Dim dtPrint1, dtPrint2 As New DataTable
        Dim aAttachments As New ArrayList
        Dim oMailItem As New CreateMailItem
        Dim oDocumento As New CreateFileFromCrystalReport

        SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)
        SplashScreenManager.Default.SetWaitFormDescription("Generando mensaje para el HBL: " & oRow("HBL"))

        oDocumento.dsPrint = Nothing

        dtPrint1 = oAppService.ExecuteSQL("EXEC NextSoft.web.upCargoNoticeQuery 1, 1, NULL, NULL, NULL, NULL, '" & oRow("HBL") & "'").Tables(0)
        dtPrint1.TableName = "Query1"
        dsPrint.Tables.Add(dtPrint1.Copy)
        dtPrint2 = oAppService.ExecuteSQL("EXEC NextSoft.dbo.OPE_CCOTSS_PorPagar " & dtPrint1.Rows(0)("EMPR_Codigo").ToString & ", " & dtPrint1.Rows(0)("CCOT_Numero").ToString).Tables(0)
        dtPrint2.TableName = "Query2"
        dsPrint.Tables.Add(dtPrint2.Copy)

        'If dsPrint.Tables(0).Rows.Count = 0 Then
        '    DevExpress.XtraEditors.XtraMessageBox.Show("La consulta no retornó datos para el HBL: " & oRow("HBL"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Return False
        'End If
        Try
            Dim _NoticeFile As String = Path.GetTempPath & "AVISO_" & oRow("HBL") & ".PDF"
            Dim _RptPath As String = IO.Directory.GetCurrentDirectory & "\Reportes\"
            Dim _LabelNotice As String = ""
            Dim _TipoAviso As String = ""
            If oRow("CONS_CodVia") = "001" Then
                If oRow("CONS_CodRGM") = "001" Then 'Impo
                    _LabelNotice = "Aviso de Arribo de Importación Marítima"
                    _TipoAviso = "AVISO DE ARRIBO"
                    If oRow("EsLCL") = 0 Then 'FCL
                        If oRow("Puerto").ToString.Contains("ARICA") Then 'Arica
                            oDocumento.RptFile = _RptPath & "AvisoArriboMaritimoFcl_CLARI.rpt"
                            richEditControl.LoadDocument(IO.Directory.GetCurrentDirectory & "\Plantillas\ContenidoCorreoAvisosImpoFcl_CLARI.htm", DevExpress.XtraRichEdit.DocumentFormat.Html)
                        Else 'Todo Destino
                            oDocumento.RptFile = _RptPath & "AvisoArriboMaritimoFcl.rpt"
                            richEditControl.LoadDocument(IO.Directory.GetCurrentDirectory & "\Plantillas\ContenidoCorreoAvisosImpoFcl.htm", DevExpress.XtraRichEdit.DocumentFormat.Html)
                        End If
                    End If
                    If oRow("EsLCL") = 1 Then 'LCL
                        'Todo Destino
                        oDocumento.RptFile = _RptPath & "AvisoArriboMaritimoLcl.rpt"
                        richEditControl.LoadDocument(IO.Directory.GetCurrentDirectory & "\Plantillas\ContenidoCorreoAvisosImpoLcl.htm", DevExpress.XtraRichEdit.DocumentFormat.Html)
                    End If
                ElseIf oRow("CONS_CodRGM") = "002" Then 'Expo
                    _LabelNotice = "Aviso de Zarpe de Exportación Marítima"
                    _TipoAviso = "AVISO DE ZARPE"
                    If oRow("EsLCL") = 0 Then 'FCL
                        oDocumento.RptFile = _RptPath & "AvisoZarpeMaritimoFcl.rpt"
                        richEditControl.LoadDocument(IO.Directory.GetCurrentDirectory & "\Plantillas\ContenidoCorreoAvisosExpoFcl.htm", DevExpress.XtraRichEdit.DocumentFormat.Html)
                    End If
                    If oRow("EsLCL") = 1 Then 'LCL
                        'Todo Destino
                        oDocumento.RptFile = _RptPath & "AvisoZarpeMaritimoLcl.rpt"
                        richEditControl.LoadDocument(IO.Directory.GetCurrentDirectory & "\Plantillas\ContenidoCorreoAvisosExpoLcl.htm", DevExpress.XtraRichEdit.DocumentFormat.Html)
                    End If
                End If
            End If
            'Aéreo
            If oRow("CONS_CodVia") = "002" Then
                If oRow("CONS_CodRGM") = "001" Then 'Impo
                    _LabelNotice = "Aviso de Arribo de Importación Aérea"
                    _TipoAviso = "AVISO DE ARRIBO"
                    If oRow("EsLCL") = 0 Then 'FCL
                        oDocumento.RptFile = _RptPath & "AvisoArriboAereo.rpt"
                        richEditControl.LoadDocument(IO.Directory.GetCurrentDirectory & "\Plantillas\ContenidoCorreoAvisosImpoAereo.htm", DevExpress.XtraRichEdit.DocumentFormat.Html)
                    End If
                    If oRow("EsLCL") = 1 Then 'LCL
                        oDocumento.RptFile = _RptPath & "AvisoArriboAereo.rpt"
                        richEditControl.LoadDocument(IO.Directory.GetCurrentDirectory & "\Plantillas\ContenidoCorreoAvisosImpoAereo.htm", DevExpress.XtraRichEdit.DocumentFormat.Html)
                    End If
                ElseIf oRow("CONS_CodRGM") = "002" Then 'Expo
                    _LabelNotice = "Aviso de Salida"
                    _TipoAviso = "AVISO DE SALIDA"
                    If oRow("EsLCL") = 0 Then 'FCL
                        oDocumento.RptFile = _RptPath & "AvisoSalidaAereo.rpt"
                        richEditControl.LoadDocument(IO.Directory.GetCurrentDirectory & "\Plantillas\ContenidoCorreoAvisosExpoAereo.htm", DevExpress.XtraRichEdit.DocumentFormat.Html)
                    End If
                    If oRow("EsLCL") = 1 Then 'LCL
                        'Todo Destino
                        oDocumento.RptFile = _RptPath & "AvisoSalidaAereo.rpt"
                        richEditControl.LoadDocument(IO.Directory.GetCurrentDirectory & "\Plantillas\ContenidoCorreoAvisosExpoAereo.htm", DevExpress.XtraRichEdit.DocumentFormat.Html)
                    End If
                End If
            End If
            oDocumento.dsPrint = dsPrint
            oDocumento.TargetFileName = _NoticeFile
            oDocumento.TargetFileFormat = CrystalDecisions.Shared.ExportFormatType.PortableDocFormat
            oDocumento.RptSubreports = 1
            oDocumento.ReportGenerate()
            oMailItem.aAttachment.Add(_NoticeFile)
            oMailItem.aAttachment.Add(IO.Directory.GetCurrentDirectory & "\Plantillas\COMUNICADO No.10 - VoBo HBL-HAWB ELECTRONICO.PDF")
            Dim _Subject As String = _LabelNotice.ToUpper
            _Subject = oRow("Cliente")
            _Subject += " / " & _TipoAviso
            _Subject += " / " & GridView1.GetFocusedRowCellValue("NombreNave").ToString
            _Subject += " / " & GridView1.GetFocusedRowCellValue("Viaje_Vuelo").ToString
            _Subject += " / " & oRow("HBL")
            If oRow("DOOV_CodReferencia").trim <> "" Then
                _Subject += " / " & oRow("DOOV_CodReferencia").ToString.Trim
            End If
            _Subject += " / " & Format(oRow("ETA_ETD"), "dd/MM/yyyy")
            oMailItem.subject = _Subject
            oMailItem.htmlBody.AppendText(Replace(richEditControl.HtmlText, "[TipoAviso]", _LabelNotice.ToUpper))
            oMailItem.htmlBody.Text = Replace(oMailItem.htmlBody.Text, "[CierreDireccionamiento]", oRow("FechaCierreDireccionamiento").ToString)
            oMailItem.htmlBody.Text = Replace(oMailItem.htmlBody.Text, "[PlazoVistoBueno]", oRow("FechaPlazoVistoBueno").ToString)
            oMailItem.mailTo = oRow("ENTC_EMail")
            oMailItem.mailCc = "operations@delfingroupco.com.pe;" & oRow("ENTC_EmailCustomer") & ";" & oRow("ENTC_EmailEjecutivo")
            oMailItem.mailBcc = "auditoria@delfingroupco.com.pe"
            If oMailItem.CreateCustomMessage(_MsgType) <> "" Then
                bResult = False
            End If
        Catch ex As Exception
            bResult = False
            DevExpress.XtraEditors.XtraMessageBox.Show("La consulta del HBL: " & oRow("HBL").ToString & " generó el siguiente error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
        SplashScreenManager.CloseForm(False)
        Return bResult
    End Function

    Function MailGenerate2(oRow As DataRow, _MsgType As String) As Boolean
        Dim bResult As Boolean = True
        Dim aAttachments As New ArrayList
        Dim oMailItem As New CreateMailItem

        Try
            Dim dtQuery As New DataTable
            dtQuery = oAppService.ExecuteSQL("EXEC NextSoft.ptc.OPE_CCOTSS_PorPagar 1,'" & oRow("HBL") & "'").Tables(0)
            'If dtQuery.Rows.Count = 0 Then
            '    DevExpress.XtraEditors.XtraMessageBox.Show("La consulta no retornó datos para el HBL: " & oRow("HBL"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    Return False
            'End If
            Dim _RptPath As String = IO.Directory.GetCurrentDirectory & "\Reportes\"
            oMailItem.aAttachment.Add(IO.Directory.GetCurrentDirectory & "\Plantillas\COMUNICADO No.10 - VoBo HBL-HAWB ELECTRONICO.PDF")
            Dim _Subject As String = "EMISIÓN DE HBL"
            _Subject += " / " & GridView1.GetFocusedRowCellValue("NombreNave").ToString
            _Subject += " / " & GridView1.GetFocusedRowCellValue("Viaje_Vuelo").ToString
            _Subject += " / " & oRow("HBL")
            If oRow("DOOV_CodReferencia").trim <> "" Then
                _Subject += " / " & oRow("DOOV_CodReferencia").ToString.Trim
            End If
            _Subject += " / " & oRow("Cliente")
            _Subject += " / " & Format(oRow("ETA_ETD"), "dd/MM/yyyy")
            oMailItem.subject = _Subject
            'richEditControl.LoadDocument(IO.Directory.GetCurrentDirectory & "\Plantillas\ContenidoCorreoAvisosLcl.htm", DevExpress.XtraRichEdit.DocumentFormat.Html)
            oMailItem.htmlBody.AppendText(oMailItem.GetPorticoMessageBody("Cliente:", dtQuery, 2))
            oMailItem.mailTo = oRow("ENTC_EMail")
            oMailItem.mailCc = "operations@delfingroupco.com.pe;" & oRow("ENTC_EmailCustomer") & ";" & oRow("ENTC_EmailEjecutivo")
            oMailItem.mailBcc = "auditoria@delfingroupco.com.pe"
            If oMailItem.CreateCustomMessage(_MsgType) <> "" Then
                bResult = False
            End If
        Catch ex As Exception
            bResult = False
            DevExpress.XtraEditors.XtraMessageBox.Show("La consulta del HBL: " & oRow("HBL").ToString & " generó el siguiente error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
        SplashScreenManager.CloseForm(False)
        Return bResult
    End Function

    Function MailGenerate3(oRow As DataRow, _MsgType As String) As Boolean
        Dim bResult As Boolean = True
        Dim dsPrint As New DataSet
        Dim dtPrint1, dtPrint2 As New DataTable
        Dim aAttachments As New ArrayList
        Dim oMailItem As New CreateMailItem
        Dim oDocumento As New CreateFileFromCrystalReport

        SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)
        SplashScreenManager.Default.SetWaitFormDescription("Generando mensaje para el HBL: " & oRow("HBL"))

        oDocumento.dsPrint = Nothing

        dtPrint1 = oAppService.ExecuteSQL("EXEC NextSoft.web.upCargoNoticeQuery 1, 1, NULL, NULL, NULL, NULL, '" & oRow("HBL") & "'").Tables(0)
        dtPrint1.TableName = "Query1"
        dsPrint.Tables.Add(dtPrint1.Copy)
        dtPrint2 = oAppService.ExecuteSQL("EXEC NextSoft.dgp.paObtieneServiciosPorPagar " & dtPrint1.Rows(0)("EMPR_Codigo").ToString & ", " & dtPrint1.Rows(0)("CCOT_Numero").ToString).Tables(0)
        dtPrint2.TableName = "Query2"
        dsPrint.Tables.Add(dtPrint2.Copy)

        'If dsPrint.Tables(0).Rows.Count = 0 Then
        '    DevExpress.XtraEditors.XtraMessageBox.Show("La consulta no retornó datos para el HBL: " & oRow("HBL"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Return False
        'End If
        Try
            Dim _NoticeFile As String = Path.GetTempPath & "AVISO_" & oRow("HBL") & ".PDF"
            Dim _RptPath As String = IO.Directory.GetCurrentDirectory & "\Reportes\"
            Dim _LabelNotice As String = ""
            Dim _TipoAviso As String = ""
            If oRow("CONS_CodVia") = "001" Then
                If oRow("CONS_CodRGM") = "001" Then 'Impo
                    _LabelNotice = "Aviso de Arribo de Importación Marítima"
                    _TipoAviso = "AVISO DE ARRIBO"
                    If oRow("EsLCL") = 0 Then 'FCL
                        If oRow("Puerto").ToString.Contains("ARICA") Then 'Arica
                            oDocumento.RptFile = _RptPath & "AvisoArriboMaritimoFcl_CLARI.rpt"
                            richEditControl.LoadDocument(IO.Directory.GetCurrentDirectory & "\Plantillas\ContenidoCorreoAvisosImpoFcl_CLARI.htm", DevExpress.XtraRichEdit.DocumentFormat.Html)
                        Else 'Todo Destino
                            oDocumento.RptFile = _RptPath & "AvisoArriboMaritimoFcl.rpt"
                            richEditControl.LoadDocument(IO.Directory.GetCurrentDirectory & "\Plantillas\ContenidoCorreoAvisosImpoFcl.htm", DevExpress.XtraRichEdit.DocumentFormat.Html)
                        End If
                    End If
                    If oRow("EsLCL") = 1 Then 'LCL
                        'Todo Destino
                        oDocumento.RptFile = _RptPath & "AvisoArriboMaritimoLcl.rpt"
                        richEditControl.LoadDocument(IO.Directory.GetCurrentDirectory & "\Plantillas\ContenidoCorreoAvisosImpoLcl.htm", DevExpress.XtraRichEdit.DocumentFormat.Html)
                    End If
                ElseIf oRow("CONS_CodRGM") = "002" Then 'Expo
                    _LabelNotice = "Aviso de Zarpe de Exportación Marítima"
                    _TipoAviso = "AVISO DE ZARPE"
                    If oRow("EsLCL") = 0 Then 'FCL
                        oDocumento.RptFile = _RptPath & "AvisoZarpeMaritimoFcl.rpt"
                        richEditControl.LoadDocument(IO.Directory.GetCurrentDirectory & "\Plantillas\ContenidoCorreoAvisosExpoFcl.htm", DevExpress.XtraRichEdit.DocumentFormat.Html)
                    End If
                    If oRow("EsLCL") = 1 Then 'LCL
                        'Todo Destino
                        oDocumento.RptFile = _RptPath & "AvisoZarpeMaritimoLcl.rpt"
                        richEditControl.LoadDocument(IO.Directory.GetCurrentDirectory & "\Plantillas\ContenidoCorreoAvisosExpoLcl.htm", DevExpress.XtraRichEdit.DocumentFormat.Html)
                    End If
                End If
            End If
            'Aéreo
            If oRow("CONS_CodVia") = "002" Then
                If oRow("CONS_CodRGM") = "001" Then 'Impo
                    _LabelNotice = "Aviso de Arribo de Importación Aérea"
                    _TipoAviso = "AVISO DE ARRIBO"
                    If oRow("EsLCL") = 0 Then 'FCL
                        oDocumento.RptFile = _RptPath & "AvisoArriboAereo.rpt"
                        richEditControl.LoadDocument(IO.Directory.GetCurrentDirectory & "\Plantillas\ContenidoCorreoAvisosImpoAereo.htm", DevExpress.XtraRichEdit.DocumentFormat.Html)
                    End If
                    If oRow("EsLCL") = 1 Then 'LCL
                        oDocumento.RptFile = _RptPath & "AvisoArriboAereo.rpt"
                        richEditControl.LoadDocument(IO.Directory.GetCurrentDirectory & "\Plantillas\ContenidoCorreoAvisosImpoAereo.htm", DevExpress.XtraRichEdit.DocumentFormat.Html)
                    End If
                ElseIf oRow("CONS_CodRGM") = "002" Then 'Expo
                    _LabelNotice = "Aviso de Salida"
                    _TipoAviso = "AVISO DE SALIDA"
                    If oRow("EsLCL") = 0 Then 'FCL
                        oDocumento.RptFile = _RptPath & "AvisoSalidaAereo.rpt"
                        richEditControl.LoadDocument(IO.Directory.GetCurrentDirectory & "\Plantillas\ContenidoCorreoAvisosExpoAereo.htm", DevExpress.XtraRichEdit.DocumentFormat.Html)
                    End If
                    If oRow("EsLCL") = 1 Then 'LCL
                        'Todo Destino
                        oDocumento.RptFile = _RptPath & "AvisoSalidaAereo.rpt"
                        richEditControl.LoadDocument(IO.Directory.GetCurrentDirectory & "\Plantillas\ContenidoCorreoAvisosExpoAereo.htm", DevExpress.XtraRichEdit.DocumentFormat.Html)
                    End If
                End If
            End If
            oDocumento.dsPrint = dsPrint
            oDocumento.TargetFileName = _NoticeFile
            oDocumento.TargetFileFormat = CrystalDecisions.Shared.ExportFormatType.PortableDocFormat
            oDocumento.RptSubreports = 1
            oDocumento.ReportGenerate()
            oMailItem.aAttachment.Add(_NoticeFile)
            oMailItem.aAttachment.Add(IO.Directory.GetCurrentDirectory & "\Plantillas\COMUNICADO No.10 - VoBo HBL-HAWB ELECTRONICO.PDF")
            Dim _Subject As String = _LabelNotice.ToUpper
            _Subject = oRow("Cliente")
            _Subject += " / " & _TipoAviso
            _Subject += " / " & GridView1.GetFocusedRowCellValue("NombreNave").ToString
            _Subject += " / " & GridView1.GetFocusedRowCellValue("Viaje_Vuelo").ToString
            _Subject += " / " & oRow("HBL")
            If oRow("DOOV_CodReferencia").trim <> "" Then
                _Subject += " / " & oRow("DOOV_CodReferencia").ToString.Trim
            End If
            _Subject += " / " & Format(oRow("ETA_ETD"), "dd/MM/yyyy")
            oMailItem.subject = _Subject
            oMailItem.htmlBody.AppendText(Replace(richEditControl.HtmlText, "[TipoAviso]", _LabelNotice.ToUpper))
            oMailItem.htmlBody.Text = Replace(oMailItem.htmlBody.Text, "[CierreDireccionamiento]", oRow("FechaCierreDireccionamiento").ToString)
            oMailItem.htmlBody.Text = Replace(oMailItem.htmlBody.Text, "[PlazoVistoBueno]", oRow("FechaPlazoVistoBueno").ToString)
            oMailItem.mailTo = oRow("ENTC_EMail")
            oMailItem.mailCc = "operations@delfingroupco.com.pe;" & oRow("ENTC_EmailCustomer") & ";" & oRow("ENTC_EmailEjecutivo")
            oMailItem.mailBcc = "auditoria@delfingroupco.com.pe"
            If oMailItem.CreateCustomMessage(_MsgType) <> "" Then
                bResult = False
            End If
        Catch ex As Exception
            bResult = False
            DevExpress.XtraEditors.XtraMessageBox.Show("La consulta del HBL: " & oRow("HBL").ToString & " generó el siguiente error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
        SplashScreenManager.CloseForm(False)
        Return bResult
    End Function

    Function UpdateAddressingDate(iNVIA_Codigo As Integer) As Boolean
        Dim bResult As Boolean = True
        Try
            oAppService.ExecuteSQLNonQuery("EXEC NextSoft.dgp.paAsignaFechaRegistroDireccionamiento " & iNVIA_Codigo.ToString)
        Catch ex As Exception
            bResult = False
            DevExpress.XtraEditors.XtraMessageBox.Show("No se actualizó la fecha de registro de direccionamiento. " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return bResult
    End Function

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs)
        Validate()
        ButtonEnabled()
    End Sub

    Private Sub ButtonEnabled()
        If GridView1.RowCount = 0 Then
            bbiCreateMessage.Enabled = False
            bbiExport.Enabled = False
            bbiSendAllMessage.Enabled = False
            Return
        End If
        bbiCreateMessage.Enabled = True
        bbiExport.Enabled = True
        bbiSendAllMessage.Enabled = True 'EtaValidate()
        bbiCreateMessage.Enabled = True
        'For r = 0 To GridView1.RowCount - 1
        '    Dim oRow As DataRow = GridView1.GetDataRow(r)
        '    If oRow("DepositoTemporal") = "" Then
        '        'bbiSendMessage.Enabled = False
        '    End If
        'Next
    End Sub

    'Function EtaValidate() As Boolean
    '    Dim bResult As Boolean = True
    '    If Not IsDBNull(GridView1.GetFocusedRowCellValue("ETA_ETD")) Then
    '        bResult = False
    '    End If
    '    Return bResult
    'End Function

    Private Sub GridView1_FocusedRowChanged_1(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        Validate()
        If e.FocusedRowHandle < 0 Then
            Return
        End If
        Dim dtContainers As New DataTable
        dtContainers = oAppService.ExecuteSQL("EXEC NextSoft.dgp.paObtieneContenedoresPorOrdenVenta '" & GridView1.GetFocusedRowCellValue("CCOT_Numero").ToString & "'").Tables(0)
        gcContainer.DataSource = dtContainers
        GridView3.BestFitColumns()
    End Sub

    Private Sub MailCargoNoticeForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        GridView1.ActiveFilterEnabled = False
        GridView1.ClearSorting()
        gcMainData.MainView.SaveLayoutToRegistry(IO.Directory.GetCurrentDirectory)
    End Sub

    Private Sub GridView1_RowStyle(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles GridView1.RowStyle
        Dim View As GridView = sender
        If (e.RowHandle >= 0) Then
            Dim _ENTC_EMail As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("ENTC_EMail"))

            If _ENTC_EMail = "" Then
                e.Appearance.BackColor = Color.Salmon
                e.Appearance.BackColor2 = Color.SeaShell
            End If

        End If
    End Sub

    Private Sub lueNoticeLayout_EditValueChanged(sender As Object, e As EventArgs) Handles lueNoticeLayout.EditValueChanged
        If Not lueVoyage.EditValue Is Nothing Or bSearch Then
            bbiSearch.PerformClick()
        End If
    End Sub

    Friend Function RowSelectedCount(oGridView As GridView) As Integer
        'Validate()
        Dim iChecked As Integer = 0
        For i = 0 To oGridView.RowCount - 1
            If IsDBNull(oGridView.GetRowCellValue(i, "CCOT_EnviaAvisoLlegada")) Then
                Continue For
            End If
            If oGridView.GetRowCellValue(i, "CCOT_EnviaAvisoLlegada") Then
                iChecked += 1
            End If
        Next
        Return iChecked
    End Function

End Class
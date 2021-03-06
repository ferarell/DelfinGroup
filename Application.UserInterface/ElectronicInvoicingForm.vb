﻿Imports System.IO
Imports System.Net.Mail
Imports CrystalDecisions.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraSplashScreen
Imports eFactDelfin
Imports IntegrationService

Public Class ElectronicInvoicingForm
    Dim oAppService As New AppService.DelfinServiceClient
    Dim oIntegrationService As New IntegrationService.IntegradorSBOClient
    Public AppUser As String = "sistemas"

    Private Sub lueShipline_Properties_EditValueChanged(sender As Object, e As EventArgs) Handles lueStatus.Properties.EditValueChanged

    End Sub

    Private Sub ElectronicInvoicingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'gcSalesInvoice.MainView.RestoreLayoutFromRegistry(IO.Directory.GetCurrentDirectory)
        Me.StartPosition = FormStartPosition.CenterScreen
        deDateFrom.EditValue = DateAdd(DateInterval.Day, -60, Now)
        deDateTo.EditValue = Now
        LoadStatus()
    End Sub

    Private Sub LoadStatus()
        Dim dtQuery As New DataTable
        dtQuery = oAppService.ExecuteSQL("EXEC NextSoft.dgp.paListaEstadoFE").Tables(0)
        lueStatus.Properties.DataSource = dtQuery
        lueStatus.Properties.DisplayMember = "DescripcionEstadoFE"
        lueStatus.Properties.ValueMember = "CodigoEstadoFE"
        lueStatus.ItemIndex = 1
    End Sub

    Private Sub bbiExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExport.ItemClick
        ExportToExcel(gcSalesInvoice)
    End Sub

    Private Sub bbiEdit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEdit.ItemClick
        Dim oForm As New PreInvoicingPopupForm
        oForm.AppUser = AppUser
        oForm.oProcessType = "Invoicing"
        oForm.oQuerySource = GridView1.GetFocusedRowCellValue("Origen")
        oForm.InternalCodeList = GridView1.GetFocusedRowCellValue("DOCV_Codigo")
        oForm.IsMultiline = False
        If oForm.ShowDialog() = DialogResult.OK Then
            GridView1.SetFocusedRowCellValue("TIPO_TDO", oForm.lueTipoComprobante.Text)
            GridView1.SetFocusedRowCellValue("DOCV_Serie", oForm.lueSerieComprobante.Text)
            GridView1.SetFocusedRowCellValue("Cliente", oForm.lueSocioNegocio.Text)
            GridView1.SetFocusedRowCellValue("TIPO_FPG", oForm.lueFormaPago.Text)
        End If

    End Sub

    Private Sub bbiVoid_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiVoid.ItemClick
        If DevExpress.XtraEditors.XtraMessageBox.Show("La anulación del comprobante seleccionado generará un comunicado de baja en Sunat, desea continuar? ", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If
        If GridView1.GetFocusedRowCellValue("DOCV_Numero").ToString = "" Then
            Return
        End If
        Dim facturacionElectronica As eFacturacionElectronica = New eFacturacionElectronica()
        Dim dtResultadoFacturacionElectronica As DataTable = New DataTable()
        dtResultadoFacturacionElectronica = facturacionElectronica.ProcesarBajaFacturacionElectronica(GridView1.GetFocusedRowCellValue("DOCV_Numero").ToString, AppUser)
        Dim Resultado As String = dtResultadoFacturacionElectronica.Rows(0)("resultado").ToString()
        Dim ResultadoDetalle As String = dtResultadoFacturacionElectronica.Rows(0)("mensajeerror").ToString()
        If Resultado = "ERROR" Then
            Throw New System.Exception(ResultadoDetalle)
        End If
    End Sub

    Private Sub bbiPreview_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiPreview.ItemClick
        Dim oForm As New PdfViewerForm
        Dim Directorio As String = ""
        Dim TipDoc As String = GridView1.GetFocusedRowCellValue("TIPO_CodTDO")
        Select Case TipDoc
            Case "001"
                Directorio = My.Settings.pathpdfFacturas
            Case "003"
                Directorio = My.Settings.pathpdfBoletas
            Case "007"
                Directorio = My.Settings.pathpdfNotasCredito
            Case "100"
                Directorio = My.Settings.pathpdfRecibos
            Case "105"
                Directorio = My.Settings.pathpdfRecibos
        End Select
        If CInt(TipDoc) < 100 Then
            oForm.pathpdf = Directorio & My.Settings.TaxCode & "-" & Strings.Right(TipDoc, 2) & "-" & GridView1.GetFocusedRowCellValue("DOCV_Serie") & "-" & GridView1.GetFocusedRowCellValue("DOCV_Numero") & ".pdf"
        Else
            oForm.pathpdf = Directorio & "RC-" & GridView1.GetFocusedRowCellValue("DOCV_Serie") & "-" & GridView1.GetFocusedRowCellValue("DOCV_Numero") & ".pdf"
        End If

        oForm.ShowDialog()
    End Sub

    Private Sub bbiGenerate_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGenerate.ItemClick
        Dim TipoDocumento As String = Convert.ToString(GridView1.GetFocusedRowCellValue("TIPO_CodTDO"))
        Dim DOCV_Serie As String = Convert.ToString(GridView1.GetFocusedRowCellValue("DOCV_Serie"))
        Dim DOCV_Codigo As Integer = Convert.ToInt32(GridView1.GetFocusedRowCellValue("DOCV_Codigo"))
        Dim emailFE As String = Convert.ToString(GridView1.GetFocusedRowCellValue("emailFE"))
        Dim CCCT_Codigo As Integer = Convert.ToInt32(GridView1.GetFocusedRowCellValue("CCCT_Codigo"))
        Dim Estado As String = Convert.ToString(GridView1.GetFocusedRowCellValue("DOCV_EstadoStr"))




        If Estado.Equals("ANULADO") Then
            XtraMessageBox.Show("No se puede imprimir el item anulado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If


        If emailFE.Equals("") Then
            XtraMessageBox.Show("Debe Especificar un Email para el Cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        'If Not ItemDocsVta.DOCV_Estado.Equals("I") Then

        '    If Not ValidarTipoCambio(Session.Fecha.Year.ToString() + Session.Fecha.Month.ToString().PadLeft(2, "0"c).Trim() + Session.Fecha.Day.ToString().PadLeft(2, "0"c).Trim()) Then
        '        Return
        '    End If
        'End If



        Dim DSReporte As DataSet = New DataSet()
        If CInt(TipoDocumento) < 100 Then
            DSReporte = oAppService.GetImpresionFEDSDocsVta(1, DOCV_Codigo, "sistemas", DOCV_Serie, 1, emailFE, CCCT_Codigo)
            'If DSReporte IsNot Nothing Then

            '    If DSReporte.Tables(2) IsNot Nothing Then
            '        Dim dtFacturacionElectronica As DataTable = New DataTable()
            '        dtFacturacionElectronica = DSReporte.Tables(2)
            '        Dim pathpdf As String = dtFacturacionElectronica.Rows(0)("pathpdf").ToString()
            '        Dim resultado As String = dtFacturacionElectronica.Rows(0)("resultado").ToString()
            '        Dim mensajeerror As String = dtFacturacionElectronica.Rows(0)("mensajeerror").ToString()

            '        If resultado = "OK" Then
            '            Dim dr As DialogResult = New DialogResult()
            '            Dim oForm As New PdfViewerForm
            '            oForm.pathpdf = pathpdf
            '            oForm.ShowDialog()
            '        Else
            '            XtraMessageBox.Show(mensajeerror, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '        End If
            '    End If
            'End If
        Else
            Dim Directorio As String = "D:\RecibosCaja\" 'My.Settings.pathpdfRecibos
            Dim oForm As New PdfViewerForm
            Dim RptFile As String = "ReciboCaja.rpt"
            DSReporte = oAppService.GetImpresionRC(1, CCCT_Codigo, "sistemas")

            If DSReporte IsNot Nothing Then
                Dim drPrint As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                Dim dtPrint As DataTable = New DataTable()
                dtPrint = DSReporte.Tables(0)

                Dim oRow As DataRow = dtPrint.Rows(0)
                Dim sFile As String = Directorio & "RC-" + oRow("DOCV_Serie") & "-" + oRow("DOCV_Numero") & ".pdf"

                Try
                    drPrint.FileName = Directory.GetCurrentDirectory() & "\Reportes\" & RptFile
                    drPrint.SetDataSource(dtPrint)
                    Dim aParams As ArrayList = New ArrayList()
                    Dim Auditoria As String = "Usuario: " + "sistemas" + "   Fecha: " + DateTime.Now.ToString()
                    aParams.Add("")
                    aParams.Add("")
                    aParams.Add(Auditoria)


                    For p As Integer = 0 To aParams.Count - 1
                        drPrint.SetParameterValue(p, aParams(p))
                    Next

                    If Not File.Exists(sFile) Then
                        drPrint.ExportToDisk(CrystalDecisions.[Shared].ExportFormatType.PortableDocFormat, sFile)
                        'SendMessage(sFile, oRow, emailFE)
                    End If

                    'CrystalReportViewer.ReportSource = drPrint
                Catch ex As Exception
                    DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                End Try


                oForm.pathpdf = sFile 'Directorio & "RC-" & GridView1.GetFocusedRowCellValue("DOCV_Serie") & "-" & GridView1.GetFocusedRowCellValue("DOCV_Numero") & ".pdf"
                oForm.ShowDialog()
            End If

        End If
    End Sub

    Private Sub SendMessage(ByVal sFile As String, ByVal drSource As DataRow, eMail As String)
        Dim oSendMail As MessageSender.SendMessage = New MessageSender.SendMessage()
        Dim _message As MailMessage = New MailMessage()
        Dim _BodyHtml As RichEditControl = New RichEditControl()
        _BodyHtml.LoadDocument("MensajeEmisionRecibo.doc", DevExpress.XtraRichEdit.DocumentFormat.Doc)
        _message.Subject = drSource("TipoDocumento") & " Nº " + drSource("DOCV_Serie") & "-" + drSource("DOCV_Numero")
        _message.From = New MailAddress("delfin@delfingroupco.com.pe", "Delfin Group Co. SAC")
        _message.IsBodyHtml = True
        _message.Body = _BodyHtml.HtmlText
        _message.Priority = MailPriority.Normal
        _message.[To].Add(eMail)
        '_message.To.Add("ferarell@hotmail.com");
        '_message.Bcc.Add("itsupport@delfingroupco.com.pe");
        If Not Equals(sFile, Nothing) Then _message.Attachments.Add(New Attachment(sFile))
        oSendMail.SendMail(_message, False, Nothing)
    End Sub



    Private Sub bbiResend_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiResend.ItemClick
        Dim DSReporte As DataSet = New DataSet()
        Dim TipoDocumento As String = Convert.ToString(GridView1.GetFocusedRowCellValue("TIPO_CodTDO"))

        Dim DOCV_Codigo As Integer = Convert.ToInt32(GridView1.GetFocusedRowCellValue("DOCV_Codigo"))
        Dim emailFE As String = Convert.ToString(GridView1.GetFocusedRowCellValue("emailFE"))

        Dim Estado As Integer = Convert.ToInt32(GridView1.GetFocusedRowCellValue("DOCV_EstadoStr"))

        If Estado.Equals("ANULADO") Then
            XtraMessageBox.Show("No se puede imprimir el item anulado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If


        If emailFE.Equals("") Then
            XtraMessageBox.Show("Debe Especificar un Email para el Cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If





        DSReporte = oAppService.EnviarOSE(DOCV_Codigo, emailFE, "sistemas")
        If DSReporte IsNot Nothing Then

            If DSReporte.Tables(2) IsNot Nothing Then
                Dim dtFacturacionElectronica As DataTable = New DataTable()
                dtFacturacionElectronica = DSReporte.Tables(2)
                Dim pathpdf As String = dtFacturacionElectronica.Rows(0)("pathpdf").ToString()
                Dim resultado As String = dtFacturacionElectronica.Rows(0)("resultado").ToString()
                Dim mensajeerror As String = dtFacturacionElectronica.Rows(0)("mensajeerror").ToString()

                If resultado = "OK" Then
                    Dim dr As DialogResult = New DialogResult()
                    Dim oForm As New PdfViewerForm
                    oForm.pathpdf = pathpdf
                    oForm.ShowDialog()
                Else
                    XtraMessageBox.Show(mensajeerror, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If

    End Sub

    Private Sub bbiClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiClose.ItemClick
        Close()
    End Sub

    Private Sub bbiSearch_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSearch.ItemClick
        Dim dtSource As New DataTable
        gcSalesInvoice.DataSource = Nothing
        SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)
        Try
            dtSource = oAppService.ExecuteSQL("EXEC NextSoft.dgp.paObtieneDocumentosFacturacion 1, '" & Format(deDateFrom.EditValue, "yyyyMMdd") & "','" & Format(deDateTo.EditValue, "yyyyMMdd") & "','" & lueStatus.EditValue.ToString & "'").Tables(0)
        Catch ex As Exception
            SplashScreenManager.CloseForm(False)
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        gcSalesInvoice.DataSource = dtSource
        GridView1.BestFitColumns()
        SplashScreenManager.CloseForm(False)
    End Sub

    Private Sub ElectronicInvoicingForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        gcSalesInvoice.MainView.SaveLayoutToRegistry(IO.Directory.GetCurrentDirectory)
    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        ButtonEnabled(e.FocusedRowHandle)
    End Sub

    Private Sub ButtonEnabled(FocusedRow As Integer)
        If GridView1.RowCount > 0 Then
            For b = 0 To bmActions.Items.Count - 1
                If bmActions.Items(b).Name.Contains("bbi") Then
                    bmActions.Items(b).Enabled = True
                End If
            Next
        End If
        If GridView1.GetFocusedRowCellValue("DOCV_Numero") = "" Then
            bbiPreview.Enabled = False
            bbiResend.Enabled = False
            bbiSyncSAP.Enabled = False
        End If
        If GridView1.GetFocusedRowCellValue("DOCV_Numero") <> "" Then
            bbiEdit.Enabled = False
            bbiGenerate.Enabled = False
            bbiReset.Enabled = False
            If GridView1.GetFocusedRowCellValue("DocumentoSAP").ToString <> "" Or GridView1.GetFocusedRowCellValue("TIPO_CodTDO").ToString.Contains({"100", "105"}) Then
                bbiSyncSAP.Enabled = False
                bbiResend.Enabled = False
            End If
        End If

        If GridView1.RowCount > 0 Then
            If Not GridView1.GetFocusedRowCellValue("TIPO_CodTDO").ToString.Contains({"001", "003", "007"}) Then
                bbiEdit.Enabled = False
            End If
        End If

        If Mid(GridView1.GetFocusedRowCellValue("DOCV_EstadoStr"), 1, 1) = "A" Then
            bbiEdit.Enabled = False
            bbiPreview.Enabled = False
            bbiVoid.Enabled = False
            bbiGenerate.Enabled = False
            bbiSyncSAP.Enabled = False
        Else
            bbiReset.Enabled = False
        End If

    End Sub

    Private Sub bbiReset_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiReset.ItemClick

    End Sub

    Private Sub bbiSyncSAP_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSyncSAP.ItemClick
        If GridView1.RowCount = 0 Then
            Return
        End If
        Dim _DOCV_Codigo As Integer = Convert.ToInt32(GridView1.GetFocusedRowCellValue("DOCV_Codigo"))
        If _DOCV_Codigo = 0 Then
            Return
        End If
        Dim dsQuery As DataSet = New DataSet()
        Dim oInvoiceBillsViewerForm As New InvoiceBillsViewerForm
        If GridView1.GetFocusedRowCellValue("TIPO_TDO").ToString().Contains("CREDITO") Then
            dsQuery = oAppService.ExecuteSQL("EXEC NextSoft.sap.upGetDataForCreditMemoInterface " & "1, 1, " & _DOCV_Codigo.ToString() & ", '" & AppUser & "', 'P'")
            oInvoiceBillsViewerForm.sInterfaceName = "CreditMemo"
        Else
            dsQuery = oAppService.ExecuteSQL("EXEC NextSoft.sap.upGetDataForInvoiceBillsInterface " & "1, 1, " & _DOCV_Codigo.ToString() & ", '" & AppUser & "', 'P'")
            oInvoiceBillsViewerForm.sInterfaceName = "InvoiceBills"
        End If
        Dim DocSAP As String = GridView1.GetFocusedRowCellValue("DocumentoSAP").ToString
        If DocSAP = "" Then
            If GetDocSAP(oInvoiceBillsViewerForm.sInterfaceName, dsQuery) = True Then
                oInvoiceBillsViewerForm.bbiVoucherGenerate.Enabled = False
            End If
        Else
            oInvoiceBillsViewerForm.bbiVoucherGenerate.Enabled = False
        End If
        oInvoiceBillsViewerForm.dsVoucher = dsQuery
        If oInvoiceBillsViewerForm.ShowDialog() = DialogResult.OK Then
            GridView1.SetFocusedRowCellValue("DocumentoSAP", oInvoiceBillsViewerForm.sDocSAP)
        End If
    End Sub

    Private Function GetDocSAP(InterfaceName As String, dsVoucherSAP As DataSet) As Boolean
        Dim bResult As Boolean = False
        Dim oRespuesta As New IntegrationService.Respuesta
        Dim iCodigoCtaCte As Integer = dsVoucherSAP.Tables(2).Rows(0)("CCCT_Codigo")
        Dim oRow As DataRow = dsVoucherSAP.Tables(0).Rows(0)
        Dim TipDoc As String = IIf(InterfaceName = "InvoiceBills", "INV", "CRD")
        oRespuesta = oIntegrationService.VerificarExistenciaDocumento("VE", TipDoc, oRow("Indicator"), oRow("CardCode"), oRow("FolioPrefixString"), oRow("FolioNumber"), Nothing, Nothing)
        If oRespuesta.Existe = "SI" Then
            Dim DocNumber As String = oRespuesta.d.results(0).DocNum.ToString
            Dim DocCode As Integer = oRespuesta.d.results(0).DocEntry
            If DocNumber = "0" Then
                XtraMessageBox.Show("El valor del número de documento is incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return True
            End If
            bResult = True
            Dim SqlText As String = ""
            If TipDoc = "INV" Then
                SqlText = "EXEC NextSoft.sap.upUpdateSynchronizedInvoiceBills " & DocCode.ToString & ",'" & DocNumber & "','InvoiceBills','CAJ_CtaCte'," & iCodigoCtaCte.ToString & ",'" & AppUser & "'"
            Else
                SqlText = "EXEC NextSoft.sap.upUpdateSynchronizedCreditMemo " & DocCode.ToString & ",'" & DocNumber & "','CreditMemo','CAJ_CtaCte'," & iCodigoCtaCte.ToString & ",'" & AppUser & "'"
            End If
            If Not oAppService.ExecuteSQLNonQuery(SqlText) Then
                XtraMessageBox.Show("Ocurrió un error al actualizar la tabla de control de asientos SAP", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return True
            End If
            GridView1.SetFocusedRowCellValue("DocumentoSAP", DocNumber)
            XtraMessageBox.Show("El documento de venta que intenta generar ya existe en SAP, por favor verifique el documento SAP asignado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return bResult
    End Function

End Class
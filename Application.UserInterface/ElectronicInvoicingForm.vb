Imports DevExpress.XtraSplashScreen

Public Class ElectronicInvoicingForm
    Dim oAppService As New AppService.DelfinServiceClient
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
        lueStatus.ItemIndex = 0
    End Sub

    Private Sub bbiExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExport.ItemClick
        ExportToExcel(gcSalesInvoice)
    End Sub

    Private Sub bbiEdit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEdit.ItemClick

    End Sub

    Private Sub bbiVoid_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiVoid.ItemClick

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

    End Sub

    Private Sub bbiResend_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiResend.ItemClick

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
            If GridView1.GetFocusedRowCellValue("DocumentoSAP").ToString <> "" Then
                bbiSyncSAP.Enabled = False
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

    Private Sub bbiVoucherGenerate_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSyncSAP.ItemClick
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
        oInvoiceBillsViewerForm.dsVoucher = dsQuery
        oInvoiceBillsViewerForm.ShowDialog()
        GridView1.SetFocusedRowCellValue("DocumentoSAP", oInvoiceBillsViewerForm.sDocSAP)
    End Sub
End Class
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid

Public Class JournalEntryViewerForm
    Public dsVoucher As New DataSet
    Public sDocSAP As String = ""

    Dim oIntegrationService As New IntegrationService.IntegradorSBOClient
    Private Sub JournalEntryViewerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If dsVoucher Is Nothing Then
            Return
        End If
        If dsVoucher.Tables.Count = 0 Then
            Return
        End If
        Dim dsVoucherViews As New DataSet
        dsVoucherViews = dsVoucher.Copy
        gcVoucherHeader.DataSource = dsVoucherViews.Tables(0)
        FormatGridView(GridView1)
        GridView1.BestFitColumns()
        gcVoucherDetail.DataSource = dsVoucherViews.Tables(1)
        FormatGridView(GridView2)
        GridView2.BestFitColumns()
    End Sub

    Private Sub FormatGridView(oGridView As GridView)
        'For r = 0 To oGridView.RowCount - 1
        '    Dim oRow As DataRow = oGridView.GetDataRow(r)
        For c = 0 To oGridView.Columns.Count - 1
            oGridView.Columns(c).OptionsColumn.ReadOnly = True
            If oGridView.Columns(c).ColumnType = GetType(Decimal) Then
                oGridView.Columns(c).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                oGridView.Columns(c).DisplayFormat.FormatString = "###,###,##0.00"
                oGridView.Columns(c).SummaryItem.SetSummary(DevExpress.Data.SummaryItemType.Sum, "{0:n2}")
                oGridView.Columns(c).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                oGridView.Columns(c).DisplayFormat.FormatString = "n2"
            End If
        Next
        'Next
    End Sub
    Private Sub bbiClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiClose.ItemClick
        Close()
    End Sub

    Private Sub bbiExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExport.ItemClick
        If GridView1.IsFocusedView Then
            ExportToExcel(gcVoucherHeader)
        Else
            ExportToExcel(gcVoucherDetail)
        End If
    End Sub

    Private Sub bbiVoucherGenerate_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiVoucherGenerate.ItemClick
        Validate()
        If DevExpress.XtraEditors.XtraMessageBox.Show("Se generará el asiento de provisión, desea continuar? ", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If
        Try
            'Interfaz de Asiento Diario
            TableColumnsVoid()
            Dim aRespuesta As New ArrayList
            aRespuesta.AddRange(oIntegrationService.InsertarActualizarJournalEntry(dsVoucher))
            If aRespuesta(0).RespuestaSAP = 0 Then
                XtraMessageBox.Show("Ocurrió un error al generar el asiento en SAP" & vbCrLf & DirectCast(aRespuesta(0), ApplicationForm.IntegrationService.Respuesta).Response(0).[error].Message.Value, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            sDocSAP = DirectCast(aRespuesta(0), ApplicationForm.IntegrationService.Respuesta).Response(0).Number.ToString
            XtraMessageBox.Show("Se generó el documento SAP: " & sDocSAP, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Close()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TableColumnsVoid()
        If dsVoucher.Tables(1).Columns.Contains("PartnerName") Then
            dsVoucher.Tables(1).Columns.Remove("PartnerName")
        End If
        If dsVoucher.Tables(1).Columns.Contains("MoveType") Then
            dsVoucher.Tables(1).Columns.Remove("MoveType")
        End If
    End Sub
End Class
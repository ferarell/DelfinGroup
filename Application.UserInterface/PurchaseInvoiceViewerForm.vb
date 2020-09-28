﻿Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid

Public Class PurchaseInvoiceViewerForm
    Public dsVoucher As New DataSet
    Dim oIntegrationService As New IntegrationService.IntegradorSBOClient
    Private Sub JournalEntryViewerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If dsVoucher Is Nothing Then
            Return
        End If
        If dsVoucher.Tables.Count = 0 Then
            Return
        End If
        gcVoucherHeader.DataSource = dsVoucher.Tables(0)
        GridView1.BestFitColumns()
        gcVoucherDetail.DataSource = dsVoucher.Tables(1)
        FormatGridView(GridView2)
        GridView2.BestFitColumns()
    End Sub

    Private Sub FormatGridView(oGridView As GridView)
        'For r = 0 To oGridView.RowCount - 1
        '    Dim oRow As DataRow = oGridView.GetDataRow(r)
        For c = 0 To oGridView.Columns.Count - 1
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
            Dim aRespuesta As New ArrayList
            aRespuesta.AddRange(oIntegrationService.InsertarActualizarJournalEntry(dsVoucher))
            If aRespuesta(0).RespuestaSAP = 0 Then
                XtraMessageBox.Show("Ocurrió un error al generar el asiento en SAP" & vbCrLf & DirectCast(aRespuesta(0), ApplicationForm.IntegrationService.Respuesta).Response(0).[error].Message.Value, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

End Class
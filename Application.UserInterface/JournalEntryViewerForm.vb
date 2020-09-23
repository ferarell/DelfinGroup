Imports DevExpress.XtraGrid.Views.Grid

Public Class JournalEntryViewerForm
    Friend dsVoucher As New DataSet
    Private Sub JournalEntryViewerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If dsVoucher Is Nothing Then
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

End Class

Public Class TariffSelectingForm
    Dim oAppService As New AppService.DelfinServiceClient
    Friend ENTC_CodTransportista As Integer = 0
    Friend IdTariff As Integer = Nothing

    Private Sub TariffInquiryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'LoadBusinessUnit()
        LoadTariff
    End Sub

    Private Sub LoadBusinessUnit()
        Dim dtQuery As New DataTable
        dtQuery = oAppService.ExecuteSQL("SELECT IdBusinessUnit, BusinessUnitDescription FROM NextSoft.tar.BusinessUnit WHERE BusinessUnitStatus='A'").Tables(0)
        lueBusinessUnit.Properties.DataSource = dtQuery
        lueBusinessUnit.Properties.DisplayMember = "BusinessUnitDescription"
        lueBusinessUnit.Properties.ValueMember = "IdBusinessUnit"
    End Sub

    Private Sub LoadTariff()
        Dim dtQuery As New DataTable
        Dim _BusinessUnit As String = "NULL"
        Dim _DateForm As String = "NULL"
        Dim _DateTo As String = "NULL"
        Dim _Status As String = "NULL"
        Dim _Shipline As String = "NULL"
        If Not lueBusinessUnit.EditValue Is Nothing Then
            _BusinessUnit = lueBusinessUnit.EditValue
        End If
        If Not deDateFrom.EditValue Is Nothing Then
            _DateForm = "'" & Format(deDateFrom.EditValue, "yyyyMMdd") & "'"
        End If
        If Not deDateFrom.EditValue Is Nothing Then
            _DateTo = "'" & Format(deDateTo.EditValue, "yyyyMMdd") & "'"
        End If
        If rgTariffStatus.SelectedIndex > 0 Then
            _Status = "'" & rgTariffStatus.EditValue & "'"
        End If
        If ENTC_CodTransportista > 0 Then
            _Shipline = ENTC_CodTransportista.ToString
        End If
        gcTariffInquiry.DataSource = Nothing
        dtQuery = oAppService.ExecuteSQL("EXEC NextSoft.tar.upTariffSelecting " & _BusinessUnit & "," & _DateForm & "," & _DateTo & "," & _Status & "," & _Shipline).Tables(0)
        If dtQuery.Rows.Count = 0 Then
            DevExpress.XtraEditors.XtraMessageBox.Show("La consulta no retornó datos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        dtQuery.Columns.Remove("idLayout")
        dtQuery.Columns.Remove("IdBusinessUnit")
        gcTariffInquiry.DataSource = dtQuery
        GridView1.Columns("IdTariff").GroupIndex = 0
        GridView1.Columns("IdTariff").Caption = "Tarifa"
        'GridView1.Columns("IdTariff").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.None
        GridView1.Columns("IdTariff").SummaryItem.SetSummary(DevExpress.Data.SummaryItemType.None, "")
        GridView1.ExpandAllGroups()
        GridView1.BestFitColumns()
    End Sub

    Private Sub bbiSelect_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSelect.ItemClick
        Validate()
        IdTariff = GridView1.GetFocusedRowCellValue("IdTariff")
        Close()
    End Sub

    Private Sub bbiExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExport.ItemClick
        ExportToExcel(gcTariffInquiry)
    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        bbiSelect.Enabled = False
        If e.FocusedRowHandle >= 0 Then
            bbiSelect.Enabled = True
        End If
    End Sub
End Class
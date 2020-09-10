
Public Class TariffInquiryForm
    Dim oAppService As New AppService.DelfinServiceClient

    Private Sub TariffInquiryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBusinessUnit()
    End Sub

    Private Sub LoadBusinessUnit()
        Dim dtQuery As New DataTable
        dtQuery = oAppService.ExecuteSQL("SELECT IdBusinessUnit, BusinessUnitDescription FROM NextSoft.tar.BusinessUnit WHERE BusinessUnitStatus='A'").Tables(0)
        lueBusinessUnit.Properties.DataSource = dtQuery
        lueBusinessUnit.Properties.DisplayMember = "BusinessUnitDescription"
        lueBusinessUnit.Properties.ValueMember = "IdBusinessUnit"
    End Sub

    Private Sub bbiQuery_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiQuery.ItemClick
        Validate()
        Dim dtQuery As New DataTable
        Dim _BusinessUnit As String = "NULL"
        Dim _DateForm As String = "NULL"
        Dim _DateTo As String = "NULL"
        Dim _Status As String = "NULL"
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
        gcTariffInquiry.DataSource = Nothing
        dtQuery = oAppService.ExecuteSQL("EXEC NextSoft.tar.upTariffInquiry " & _BusinessUnit & "," & _DateForm & "," & _DateTo & "," & _Status).Tables(0)
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

    Private Sub bbiExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExport.ItemClick
        ExportToExcel(gcTariffInquiry)
    End Sub


End Class
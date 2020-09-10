
Imports System.ComponentModel

Public Class ConsolidatedInquiryForm
    Dim oAppService As New AppService.DelfinServiceClient
    Dim oMasterDataList As New MasterDataList

    Private Sub TariffInquiryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gcConsolidatedInquiry.MainView.RestoreLayoutFromRegistry(IO.Directory.GetCurrentDirectory)
        LoadBusinessUnit()
        cbeRefDate.SelectedIndex = 0
        deDateFrom.EditValue = DateAdd(DateInterval.Day, -60, Now)
        deDateTo.EditValue = Now
    End Sub

    Private Sub LoadBusinessUnit()
        Dim dtQuery As New DataTable
        dtQuery = oMasterDataList.LoadMasterData("BusinessUnit", Nothing)
        lueBusinessUnit.Properties.DataSource = dtQuery
        lueBusinessUnit.Properties.DisplayMember = "DescripcionLineaNegocio"
        lueBusinessUnit.Properties.ValueMember = "CodigoLineaNegocio"
    End Sub

    Private Sub bbiQuery_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiQuery.ItemClick
        Validate()
        Dim dtQuery As New DataTable
        Dim _BusinessUnit As String = "NULL"
        Dim _DateForm As String = "NULL"
        Dim _DateTo As String = "NULL"
        Dim _NoCRM As String = "NULL"
        Dim _TipoFecha As String = cbeRefDate.SelectedIndex.ToString
        If Not deDateFrom.EditValue Is Nothing Then
            _DateForm = "'" & Format(deDateFrom.EditValue, "yyyyMMdd") & "'"
        End If
        If Not deDateFrom.EditValue Is Nothing Then
            _DateTo = "'" & Format(deDateTo.EditValue, "yyyyMMdd") & "'"
        End If
        If Not lueBusinessUnit.EditValue Is Nothing Then
            _BusinessUnit = "'" & lueBusinessUnit.EditValue & "'"
        End If
        If teCRM.Text <> "" Then
            _NoCRM = "'" & teCRM.Text & "'"
        End If
        gcConsolidatedInquiry.DataSource = Nothing
        dtQuery = oAppService.ExecuteSQL("EXEC NextSoft.dgp.paConsultaIntegralPorFiltros " & _TipoFecha & "," & _DateForm & "," & _DateTo & "," & _BusinessUnit & "," & _NoCRM).Tables(0)
        If dtQuery.Rows.Count = 0 Then
            DevExpress.XtraEditors.XtraMessageBox.Show("La consulta no retornó datos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        GridView1.OptionsView.ColumnAutoWidth = False
        gcConsolidatedInquiry.DataSource = dtQuery
        GridView1.BestFitColumns()
    End Sub

    Private Sub bbiExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExport.ItemClick
        ExportToExcel(gcConsolidatedInquiry)
    End Sub

    Private Sub ConsolidatedInquiryForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        gcConsolidatedInquiry.MainView.SaveLayoutToRegistry(IO.Directory.GetCurrentDirectory)
    End Sub
End Class
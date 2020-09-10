
Imports DevExpress.XtraEditors.DXErrorProvider

Public Class InvoicingQueryForm
    Private oAppService As New OnlineService.OnLineServiceClient

    Private Sub InvoicingQueryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCustomer()
        deDateTo.EditValue = Today
        deDateFrom.EditValue = DateAdd(DateInterval.Day, -60, Today)
    End Sub

    Private Sub LoadCustomer()
        Dim dtQuery As New DataTable
        dtQuery = oAppService.ExecuteSQL("EXEC NextSoft.dgp.paObtieneEmpresaVinculada " & ENTC_DocIden).Tables(0)
        lueCustomer.Properties.DataSource = dtQuery
        lueCustomer.Properties.DisplayMember = "DescripcionCliente"
        lueCustomer.Properties.ValueMember = "CodigoCliente"
        lueCustomer.ItemIndex = 0
    End Sub

    Private Sub bbiExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExport.ItemClick
        ExportToExcel(gcMainData)
    End Sub

    Private Sub bbiSearch_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSearch.ItemClick
        LoadInputValidations()
        If Not vpInputs.Validate Then
            Return
        End If
        Dim dtQuery As New DataTable
        'dtQuery = oAppService.InvoicingQuery(lueCustomer.EditValue.ToString, deDateFrom.EditValue, deDateTo.EditValue)
        dtQuery = oAppService.ExecuteSQL("EXEC NextSoft.web.upInvoicingQuery_FAM " & lueCustomer.EditValue.ToString & ",'" & Format(deDateFrom.EditValue, "yyyy-MM-dd") & "','" & Format(deDateTo.EditValue, "yyyy-MM-dd") & "'").Tables(0)
        gcMainData.DataSource = dtQuery
        GridView1.BestFitColumns()
    End Sub

    Private Sub bbiClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiClose.ItemClick
        Close()
    End Sub

    Private Sub bbiViewer_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiViewer.ItemClick
        Dim oForm As New PdfViewerForm
        Dim Directorio As String = ""
        Dim TipDocSunat As String = ""
        Select Case GridView1.GetFocusedRowCellValue("TipoDocumento")
            Case "FT"
                Directorio = My.Settings.pathpdfFacturas
                TipDocSunat = "01"
            Case "BV"
                Directorio = My.Settings.pathpdfBoletas
                TipDocSunat = "03"
            Case "NC"
                Directorio = My.Settings.pathpdfNotasCredito
                TipDocSunat = "07"
            Case "RC"
                Directorio = My.Settings.pathpdfRecibos
                TipDocSunat = "RC"
        End Select
        If TipDocSunat = "RC" Then
            oForm.pathpdf = Directorio & TipDocSunat & "-" & GridView1.GetFocusedRowCellValue("SerieDocumento") & "-" & GridView1.GetFocusedRowCellValue("NumeroDocumento") & ".pdf"
        Else
            oForm.pathpdf = Directorio & My.Settings.TaxCode & "-" & TipDocSunat & "-" & GridView1.GetFocusedRowCellValue("SerieDocumento") & "-" & GridView1.GetFocusedRowCellValue("NumeroDocumento") & ".pdf"
        End If

        oForm.ShowDialog()
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
        vpInputs.SetValidationRule(Me.lueCustomer, customValidationRule)
        vpInputs.SetValidationRule(Me.deDateFrom, customValidationRule)
        vpInputs.SetValidationRule(Me.deDateTo, customValidationRule)
    End Sub

End Class
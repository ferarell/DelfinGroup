Imports DevExpress.XtraEditors.DXErrorProvider

Public Class VendorDocumentQueryForm
    Dim oAppService As New AppService.DelfinServiceClient
    Dim oMasterDataList As New MasterDataList
    Public AppUser As String = "sistemas"

    Private Sub VendorDocumentQueryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'gcPurchaseInvoice.MainView.RestoreLayoutFromRegistry(IO.Directory.GetCurrentDirectory)
        Me.StartPosition = FormStartPosition.CenterScreen
        SplitContainerControl2.Collapsed = True
        deDateFrom.EditValue = DateAdd(DateInterval.Day, -60, Now)
        deDateTo.EditValue = Now
        ButtonEnabled()
        LoadEntityType()
    End Sub

    Private Sub LoadEntityType()
        Dim dtQuery As New DataTable
        dtQuery = oMasterDataList.LoadMasterData("EntityType", Nothing)
        lueEntityType.Properties.DataSource = dtQuery
        lueEntityType.Properties.DisplayMember = "DescripcionTipoEntidad"
        lueEntityType.Properties.ValueMember = "CodigoTipoEntidad"
    End Sub

    Private Sub LoadEntityByType()
        Dim dtQuery As New DataTable
        Dim aParams As New ArrayList
        aParams.Add(lueEntityType.EditValue)
        dtQuery = oMasterDataList.LoadMasterData("EntityByType", aParams)
        lueEntity.Properties.DataSource = dtQuery
        lueEntity.Properties.DisplayMember = "DescripcionEntidad"
        lueEntity.Properties.ValueMember = "CodigoEntidad"
    End Sub

    Private Sub ButtonEnabled()
        If GridView1.RowCount = 0 Then
            bbiEdit.Enabled = False
            bbiVoid.Enabled = False
            bbiExport.Enabled = False
            Return
        End If
        If GridView1.RowCount > 0 Then
            For b = 0 To bmActions.Items.Count - 1
                If bmActions.Items(b).Name.Contains("bbi") Then
                    bmActions.Items(b).Enabled = True
                End If
            Next
        End If
        If GridView1.GetFocusedRowCellValue("DocumentoSAP").ToString <> "" Then
            bbiSyncSAP.Enabled = False
        End If
    End Sub

    Private Sub bbiAdd_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAdd.ItemClick
        Dim oNewForm As New VendorDocumentRegisterForm
        oNewForm.ShowDialog()
    End Sub

    Private Sub bbiEdit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEdit.ItemClick
        Dim oEditForm As New VendorDocumentRegisterForm
        oEditForm.InternalCode = GridView1.GetFocusedRowCellValue("CCCT_Codigo")
        oEditForm.ShowDialog()
    End Sub

    Private Sub bbiVoid_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiVoid.ItemClick

    End Sub

    Private Sub bbiSearch_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSearch.ItemClick
        LoadInputValidations()
        If Not vpInputs.Validate Then
            Return
        End If
        Dim dtSource As New DataTable
        Dim sParams As String = ""
        sParams = IIf(lueEntity.EditValue Is Nothing, "NULL", lueEntity.EditValue)
        If lueEntity.Text.Trim = "" Then
            sParams += ", '" & IIf(deDateFrom.EditValue = Nothing, "NULL", Format(deDateFrom.EditValue, "yyyyMMdd")) & "'"
            sParams += ", '" & IIf(deDateTo.EditValue = Nothing, "NULL", Format(deDateTo.EditValue, "yyyyMMdd")) & "'"
        End If
        gcPurchaseInvoice.DataSource = Nothing
        dtSource = oAppService.ExecuteSQL("EXEC NextSoft.dgp.paObtieneDocumentosProveedor " & sParams).Tables(0)
        If dtSource.Rows.Count > 0 Then
            gcPurchaseInvoice.DataSource = dtSource
            GridView1.BestFitColumns()
            ButtonEnabled()
        End If
    End Sub

    Private Sub bbiExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExport.ItemClick
        ExportToExcel(gcPurchaseInvoice)
    End Sub

    Private Sub bbiClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiClose.ItemClick
        Close()
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
        'vpInputs.SetValidationRule(Me.teOperationNumber, Nothing)
        vpInputs.SetValidationRule(Me.deDateFrom, Nothing)
        vpInputs.SetValidationRule(Me.deDateTo, Nothing)
        'If teOperationNumber.Text.Trim = "" Then
        '    vpInputs.SetValidationRule(Me.deDateFrom, customValidationRule)
        '    vpInputs.SetValidationRule(Me.deDateTo, customValidationRule)
        'End If
        'If deDateFrom.EditValue Is Nothing Then
        '    vpInputs.SetValidationRule(Me.teOperationNumber, customValidationRule)
        'End If
    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        If GridView1.GetFocusedRowCellValue("COPE_Codigo") Is Nothing Then
            Return
        End If
        Dim dtQuery As New DataTable
        dtQuery = oAppService.ExecuteSQL("EXEC NextSoft.dgp.paObtieneServiciosPorOperacion " & GridView1.GetFocusedRowCellValue("COPE_Codigo")).Tables(0)
        gcVendorService.DataSource = dtQuery
        GridView2.BestFitColumns()
        ButtonEnabled()
    End Sub

    Private Sub gcVendorItems_DoubleClick(sender As Object, e As EventArgs) Handles gcPurchaseInvoice.DoubleClick
        bbiEdit.PerformClick()
    End Sub

    Private Sub bbiSyncSAP_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSyncSAP.ItemClick
        If GridView1.RowCount = 0 Then
            Return
        End If
        Dim _CCCT_Codigo As Integer = Convert.ToInt32(GridView1.GetFocusedRowCellValue("CCCT_Codigo"))
        If _CCCT_Codigo = 0 Then
            Return
        End If
        Dim dsQuery As DataSet = New DataSet()
        Dim oPurchaseInvoiceViewerForm As New PurchaseInvoiceViewerForm
        If GridView1.GetFocusedRowCellValue("TIPO_Documento").ToString().Contains("CREDITO") Then
            dsQuery = oAppService.ExecuteSQL("EXEC NextSoft.sap.upGetDataForPurchaseCreditMemoInterface " & "1, 1, " & _CCCT_Codigo.ToString() & ", '" & AppUser & "', 'P'")
            oPurchaseInvoiceViewerForm.sInterfaceName = "PurchaseCreditMemo"
        Else
            dsQuery = oAppService.ExecuteSQL("EXEC NextSoft.sap.upGetDataForPurchaseInvoiceInterface " & "1, 1, " & _CCCT_Codigo.ToString() & ", '" & AppUser & "', 'P'")
            oPurchaseInvoiceViewerForm.sInterfaceName = "PurchaseInvoice"
        End If
        oPurchaseInvoiceViewerForm.dsVoucher = dsQuery
        oPurchaseInvoiceViewerForm.ShowDialog()
        GridView1.SetFocusedRowCellValue("DocumentoSAP", oPurchaseInvoiceViewerForm.sDocSAP)
    End Sub
End Class
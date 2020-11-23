Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.XtraGrid.Views.Grid

Public Class LogisticOperationQueryForm
    Dim oAppService As New AppService.DelfinServiceClient
    Dim oMasterDataList As New MasterDataList
    Public AppUser As String = "sistemas"
    Friend _EMPR_Codigo, _SUCR_Codigo As Integer

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub LogisticOperationQueryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        gcRegistered.MainView.RestoreLayoutFromRegistry(IO.Directory.GetCurrentDirectory)
        deDateFrom.EditValue = DateAdd(DateInterval.Day, -60, Now)
        deDateTo.EditValue = Now
        SplitContainerControl2.Collapsed = Not tsShowRO.EditValue
        Dim iHeight As Integer = SplitContainerControl3.Size.Height
        SplitContainerControl3.SplitterPosition = (iHeight / 2) + 50
        ButtonEnabled(GridView1, 0)
        LoadEntityType()
        _EMPR_Codigo = 1
        _SUCR_Codigo = 1
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

    Private Sub bbiAdd1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAdd1.ItemClick
        Dim oNewForm As New LogisticOperationRegisterForm
        oNewForm.InternalCode = -1
        oNewForm.drSource = GridView2.GetFocusedDataRow
        oNewForm._EMPR_Codigo = _EMPR_Codigo
        oNewForm._SUCR_Codigo = _SUCR_Codigo
        oNewForm.ShowDialog()
        bbiSearch.PerformClick()
    End Sub

    Private Sub bbiAdd2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAdd2.ItemClick
        Dim oNewForm As New LogisticOperationRegisterForm
        oNewForm.InternalCode = -1
        oNewForm.ShowDialog()
        bbiSearch.PerformClick()
    End Sub

    Private Sub bbiEdit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEdit.ItemClick
        Dim oEditForm As New LogisticOperationRegisterForm
        oEditForm.InternalCode = GridView1.GetFocusedRowCellValue("COPE_Codigo")
        oEditForm.drSource = GridView1.GetFocusedDataRow
        oEditForm._EMPR_Codigo = _EMPR_Codigo
        oEditForm._SUCR_Codigo = _SUCR_Codigo
        oEditForm.ShowDialog()
        'bbiSearch.PerformClick()
    End Sub

    Private Sub bbiVoid_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiVoid.ItemClick
        If XtraMessageBox.Show("Está seguro de anular la operación seleccionada?", "Confirmación", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
            Return
        End If
        Try
            If oAppService.ExecuteSQLNonQuery("EXEC NextSoft.dgp.paActualizaEstadoOperacionLogistica " & GridView1.GetFocusedRowCellValue("COPE_Codigo").ToString & ", " & GridView1.GetFocusedRowCellValue("COPE_Version").ToString & ", '004'") Then
                XtraMessageBox.Show("La operación ha sido anulada satisfactoriamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                XtraMessageBox.Show("Ocurrió un error al anular la operación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            XtraMessageBox.Show("Ocurrió un error al anular la operación." & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub bbiSearch_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSearch.ItemClick
        LoadInputValidations()
        If Not vpInputs.Validate Then
            Return
        End If
        Dim dtSource As New DataTable
        dtSource.Columns.Add("Checked", GetType(Boolean)).DefaultValue = False
        Dim sParams As String = ""
        sParams = IIf(lueEntity.EditValue Is Nothing, "NULL", lueEntity.EditValue)
        sParams += ", " & IIf(teOperationNumber.Text.Trim = "", "NULL", "'" & teOperationNumber.Text & "'")
            sParams += ", " & IIf(teHBL.Text.Trim = "", "NULL", "'" & teHBL.Text & "'")
        If teOperationNumber.Text.Trim = "" And teHBL.Text.Trim = "" Then
            sParams += ", '" & IIf(deDateFrom.EditValue = Nothing, "NULL", Format(deDateFrom.EditValue, "yyyyMMdd")) & "'"
            sParams += ", '" & IIf(deDateTo.EditValue = Nothing, "NULL", Format(deDateTo.EditValue, "yyyyMMdd")) & "'"
        End If
        gcRegistered.DataSource = Nothing
        SplitContainerControl2.Collapsed = True
        dtSource = oAppService.ExecuteSQL("EXEC NextSoft.dgp.paObtieneOperacionesLogisticas " & sParams).Tables(0)
        If dtSource.Rows.Count > 0 Then
            If dtSource.Select("TipoConsulta=1").Length > 0 Then
                gcRegistered.DataSource = dtSource.Select("TipoConsulta=1").CopyToDataTable
            End If
            If dtSource.Select("TipoConsulta=0").Length > 0 Then
                gcPending.DataSource = dtSource.Select("TipoConsulta=0").CopyToDataTable
            End If
            GridView1.BestFitColumns()
            GridView2.BestFitColumns()
            ButtonEnabled(GridView1, 0)
        End If
    End Sub

    Private Sub bbiExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExport.ItemClick
        If GridView2.IsFocusedView Then
            ExportToExcel(gcPending)
        Else
            ExportToExcel(gcRegistered)
        End If

    End Sub

    Private Sub bbiClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiClose.ItemClick
        Close()
    End Sub

    Private Sub LogisticOperationQueryForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        gcRegistered.MainView.SaveLayoutToRegistry(IO.Directory.GetCurrentDirectory)
    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged, GridView2.FocusedRowChanged
        'If e.FocusedRowHandle = -1 Then 'Or SplitContainerControl2.Collapsed = True Then
        '    Return
        'End If
        ButtonEnabled(sender, e.FocusedRowHandle)
        ShowRoutingOrder(sender)
    End Sub

    Private Sub lueEntityType_EditValueChanged(sender As Object, e As EventArgs) Handles lueEntityType.EditValueChanged
        LoadEntityByType()
    End Sub

    Private Sub ShowRoutingOrder(oGridView As DevExpress.XtraGrid.Views.Grid.GridView)
        If IsDBNull(oGridView.GetFocusedRowCellValue("COPE_HBL")) Then
            Return
        End If
        If SplitContainerControl2.Collapsed Then
            Return
        End If
        Dim OVForm As New VerticalViewerOVForm
        OVForm.bbiClose.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        OVForm.bbiFileViewer.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        OVForm.sHBL = oGridView.GetFocusedRowCellValue("COPE_HBL")
        OVForm.TopLevel = False
        OVForm.FormBorderStyle = FormBorderStyle.None
        OVForm.Dock = DockStyle.Fill
        SplitContainerControl2.Panel2.Controls.Clear()
        SplitContainerControl2.Panel2.Controls.Add(OVForm)
        OVForm.Show()
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
        vpInputs.SetValidationRule(Me.teOperationNumber, Nothing)
        vpInputs.SetValidationRule(Me.deDateFrom, Nothing)
        vpInputs.SetValidationRule(Me.deDateTo, Nothing)
        If teOperationNumber.Text.Trim = "" Then
            vpInputs.SetValidationRule(Me.deDateFrom, customValidationRule)
            vpInputs.SetValidationRule(Me.deDateTo, customValidationRule)
        End If
        If deDateFrom.EditValue Is Nothing Then
            vpInputs.SetValidationRule(Me.teOperationNumber, customValidationRule)
        End If
    End Sub

    Private Sub ButtonEnabled(oGridView As DevExpress.XtraGrid.Views.Grid.GridView, RowHandle As Integer)
        bbiAdd1.Enabled = False
        bbiEdit.Enabled = False
        bbiVoid.Enabled = False
        bbiExport.Enabled = False
        bbiSendMailTo.Enabled = False
        bbiPreInvoicing.Enabled = False
        tsShowRO.Enabled = False
        If RowHandle < 0 Or oGridView.RowCount = 0 Then
            Return
        Else
            bbiExport.Enabled = True
            bbiPreInvoicing.Enabled = True
        End If
        If GridView1.RowCount > 0 And GridView1.IsFocusedView Then
            For b = 0 To bmActions.Items.Count - 1
                If bmActions.Items(b).Name.Contains("bbi") Then
                    If oGridView.GetFocusedRowCellValue("COPE_HBL").ToString.Length = 0 Then
                        If bmActions.Items(b).Name.Contains({"bbiSendMailTo", "bbiPreInvoicing"}) Then
                            Continue For
                        End If
                    End If
                    bmActions.Items(b).Enabled = True
                End If
            Next
        End If
        If oGridView.GetFocusedRowCellValue("COPE_HBL").ToString.Length > 0 Then
            tsShowRO.Enabled = True
        End If
        If oGridView.Name = "GridView2" Then
            bbiAdd1.Enabled = True
        End If
        If GridView1.GetFocusedRowCellValue("CONS_CodEstado") <> "001" Then
            'bbiEdit.Enabled = False
            bbiVoid.Enabled = False
            bbiPreInvoicing.Enabled = False
            If GridView1.GetFocusedRowCellValue("CONS_CodEstado") = "004" Then
                bbiSendMailTo.Enabled = False
            End If
        End If
    End Sub

    Private Sub tsShowRO_Toggled(sender As Object, e As EventArgs) Handles tsShowRO.Toggled
        Validate()
        SplitContainerControl2.Collapsed = Not tsShowRO.EditValue
        If tsShowRO.EditValue Then
            If GridView1.IsFocusedView Then
                ShowRoutingOrder(GridView1)
            ElseIf GridView2.IsFocusedView Then
                ShowRoutingOrder(GridView2)
            End If
        End If
    End Sub

    Private Sub GridView1_DoubleClick(sender As Object, e As EventArgs) Handles GridView1.DoubleClick
        If GridView1.GetFocusedRowCellValue("CONS_CodEstado") = "001" Then
            bbiEdit.PerformClick()
        End If
    End Sub

    Private Sub gcRegistered_Enter(sender As Object, e As EventArgs) Handles gcRegistered.Enter
        bsiAdd.Enabled = False
        tsShowRO.Enabled = True
        bbiEdit.Enabled = True
        bbiVoid.Enabled = True
    End Sub

    Private Sub gcPending_Enter(sender As Object, e As EventArgs) Handles gcPending.Enter
        bsiAdd.Enabled = True
        tsShowRO.EditValue = False
        tsShowRO.Enabled = False
        bbiEdit.Enabled = False
        bbiVoid.Enabled = False
    End Sub

    Private Sub bbiSendMailTo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSendMailTo.ItemClick
        Dim oMailItem As New CreateMailItem
        oMailItem.subject = "Prueba"
        oMailItem.htmlBody.AppendText("Esto es una prueba de correo")
        oMailItem.mailTo = "aremonfe@gmail.com"
        oMailItem.CreateCustomMessage("Display")
    End Sub

    Private Sub bbiPreInvoicing_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiPreInvoicing.ItemClick
        If GridView1.RowCount = 0 Then
            Return
        End If
        Dim iCurrentRow As Integer = 0
        Dim iSelected As Integer = RowSelectedCount(GridView1)
        If iSelected = 0 Then
            XtraMessageBox.Show("Debe seleccionar al menos una fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If DevExpress.XtraEditors.XtraMessageBox.Show("Se generarán las pre-facturas de las operciones seleccionadas, desea continuar? ", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If
        Dim bError As Boolean = False
        For r = 0 To GridView1.RowCount - 1
            Dim oRow As DataRow = GridView1.GetDataRow(r)
            oRow("Checked") = IIf(IsDBNull(oRow("Checked")), False, oRow("Checked"))
            If oRow("Checked") = False Then
                Continue For
            End If
        Next
        If bError Then

            Return
        End If
    End Sub

    Private Sub GridView1_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GridView1.RowClick, GridView2.RowClick
        ButtonEnabled(sender, e.RowHandle)
        'ShowRoutingOrder(sender)
    End Sub

    Private Sub GridView1_RowStyle(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles GridView1.RowStyle
        Dim View As GridView = sender
        If (e.RowHandle >= 0) Then
            Dim _Status As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("CONS_CodEstado"))
            If _Status <> "001" Then
                e.Appearance.ForeColor = Color.Blue
            End If
            If _Status = "004" Then
                e.Appearance.ForeColor = Color.Black
                e.Appearance.BackColor = Color.Salmon
                e.Appearance.BackColor2 = Color.SeaShell
            End If
        End If
    End Sub

    Friend Function RowSelectedCount(oGridView As GridView) As Integer
        Dim iChecked As Integer = 0
        For i = 0 To oGridView.RowCount - 1
            If IsDBNull(oGridView.GetRowCellValue(i, "Checked")) Then
                Continue For
            End If
            If oGridView.GetRowCellValue(i, "Checked") Then
                iChecked += 1
            End If
        Next
        Return iChecked
    End Function

    Private Sub SelectRowsByType(oGridView As GridView, SelectType As Integer)
        For i = 0 To oGridView.RowCount - 1
            Dim row As DataRow = oGridView.GetDataRow(i)
            If IsDBNull(row("Checked")) Then
                row("Checked") = False
            End If
            If SelectType = 0 Then
                If oGridView.Name = "GridView1" Then
                    If row("DocumentoSAP").ToString.Length = 0 Then
                        row("Checked") = True
                    End If
                Else
                    row("Checked") = True
                End If
            End If
            If SelectType = 1 Then
                row("Checked") = False
            End If
            If SelectType = 2 Then
                If row("Checked") Then
                    row("Checked") = False
                Else
                    If oGridView.Name = "GridView1" Then
                        If row("DocumentoSAP").ToString.Length = 0 Then
                            row("Checked") = True
                        End If
                    Else
                        row("Checked") = True
                    End If
                End If
            End If
            Validate()
        Next
    End Sub

    Private Sub SeleccionaTodosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeleccionaTodosToolStripMenuItem.Click
        Dim oGridView As GridView = IIf(GridView1.IsFocusedView, GridView1, GridView2)
        SelectRowsByType(oGridView, 0)
    End Sub

    Private Sub DeseleccionaTodosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeseleccionaTodosToolStripMenuItem.Click
        Dim oGridView As GridView = IIf(GridView1.IsFocusedView, GridView1, GridView2)
        SelectRowsByType(oGridView, 1)
    End Sub

    Private Sub InvertirSelecciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InvertirSelecciónToolStripMenuItem.Click
        Dim oGridView As GridView = IIf(GridView1.IsFocusedView, GridView1, GridView2)
        SelectRowsByType(oGridView, 2)
    End Sub

End Class
Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Drawing
Imports System.IO
Imports System.Globalization
Imports DevExpress.XtraSplashScreen
Imports System.Threading

Public Class MovimientoContableForm
    Dim dtQuery, dtPrint As New DataTable
    Dim bError As Boolean = False
    Dim dExchange As Double = 0

    Private Sub MovimientoContableForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'GridView1.RestoreLayoutFromRegistry(AppPath)
        lbTipoCambio.Text = ""
        bbiExport.Enabled = False
        bbiPrint.Enabled = False
        Try
            LoadInputValidations()
            LoadCompany()
        Catch ex As Exception
            bError = True
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadCompany()
        dtCompany = GetCompaniesList(rgDataSource.EditValue)
        lueCompany.Properties.DataSource = dtCompany
        lueCompany.Properties.DisplayMember = "CompanyName"
        lueCompany.Properties.ValueMember = "CompanyCode"
    End Sub

    Private Sub LoadAccount()
        dtAccount = GetAccountsList(GetDBCia(lueCompany.EditValue))
        lueAccount.Properties.DataSource = dtAccount
        lueAccount.Properties.DisplayMember = "code"
        lueAccount.Properties.ValueMember = "code"
    End Sub

    Private Sub LoadAPartner()
        dtPartner = GetPartnersList(GetDBCia(lueCompany.EditValue))
        luePartner.Properties.DataSource = dtPartner
        luePartner.Properties.DisplayMember = "name"
        luePartner.Properties.ValueMember = "code"
    End Sub

    Private Sub bbiClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiClose.ItemClick
        Close()
    End Sub

    Private Sub bbiPrint_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiPrint.ItemClick
        Dim pForm As New PrintForm
        pForm.dtPrint = dtQuery
        pForm.aParams = GetParamValues()
        pForm.RptFile = "MovimientoContable.rpt"
        pForm.ShowDialog()
    End Sub

    Friend Function GetParamValues() As ArrayList
        Dim aParams As New ArrayList
        aParams.Add("ANALÍTICO CONTABLE")
        aParams.Add(GetConditions())
        aParams.Add(lueCompany.GetColumnValue("DocumentID"))
        aParams.Add(lueCompany.GetColumnValue("CompanyName"))
        aParams.Add(GetCompanyDetail(lueCompany.EditValue, "NEXTSIS").Rows(0)("CompanyAddress"))
        Return aParams
    End Function

    Private Sub bbiProcess_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiProcess.ItemClick
        LoadInputValidations()
        If Not vpInputs.Validate Then
            Return
        End If
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)
            If rgDataSource.SelectedIndex = 0 Then
                DataProcess1()
            Else
                DataProcess2()
            End If

        Catch ex As Exception
            SplashScreenManager.CloseForm(False)
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        SplashScreenManager.CloseForm(False)
    End Sub

    Private Sub DataProcess1()
        Dim sQuery As String = ""
        gcMainData.DataSource = Nothing
        'dtQuery = GetCompanyDetail(lueCompany.EditValue, "NEXTSIS")
        sQuery += "EXEC dbo.paMovimientoContable '" & lueCompany.EditValue & "', '" & Replace(teDocument.Text, "*", "%") & "', '" & Format(deDateFrom.EditValue, "yyyyMMdd") & "', '" & Format(deDateTo.EditValue, "yyyyMMdd") & "', '" & lueAccount.Text.Trim & "', '" & luePartner.EditValue & "'"
        dtQuery = ExecuteSQL(sQuery)
        If Not dtQuery.Columns.Contains("AmountValuedML") Then
            dtQuery.Columns.Add("AmountValuedML", GetType(Double)).DefaultValue = 0
            dtQuery.Columns.Add("DifferenceML", GetType(Double)).DefaultValue = 0
            dtQuery.Columns.Add("AmountValuedME", GetType(Double)).DefaultValue = 0
            dtQuery.Columns.Add("DifferenceME", GetType(Double)).DefaultValue = 0
        End If
        If dtQuery.Rows.Count = 0 Then
            SplashScreenManager.CloseForm(False)
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "La consulta no retornó datos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        UpdateAmountValued()
        bbiExport.Enabled = True
        bbiPrint.Enabled = True
        If rgReportType.SelectedIndex = 1 Then
            dtQuery = DataFilter()
        ElseIf rgReportType.SelectedIndex = 2 Then
            dtQuery = DataFilter2()
        End If
        If dtQuery.Columns.Count = 0 Then
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "La consulta no retornó información.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        gcMainData.MainView = GridView1
        gcMainData.DataSource = dtQuery
        LayoutApply()
    End Sub

    Private Sub DataProcess2()
        Dim sQuery As String = ""
        gcMainData.DataSource = Nothing
        'dtQuery = GetCompanyDetail(lueCompany.EditValue, "NEXTSIS")
        sQuery += "EXEC con.paMovimientoContable '" & lueCompany.EditValue & "', '" & Format(deDateFrom.EditValue, "yyyyMMdd") & "', '" & Format(deDateTo.EditValue, "yyyyMMdd") & "', '" & Replace(teDocument.Text, "*", "%") & "', '" & lueAccount.Text.Trim & "', '" & luePartner.EditValue & "'"
        dtQuery = ExecuteSQL(sQuery)
        'If Not dtQuery.Columns.Contains("AmountValuedML") Then
        '    dtQuery.Columns.Add("AmountValuedML", GetType(Double)).DefaultValue = 0
        '    dtQuery.Columns.Add("DifferenceML", GetType(Double)).DefaultValue = 0
        '    dtQuery.Columns.Add("AmountValuedME", GetType(Double)).DefaultValue = 0
        '    dtQuery.Columns.Add("DifferenceME", GetType(Double)).DefaultValue = 0
        'End If
        If dtQuery.Rows.Count = 0 Then
            SplashScreenManager.CloseForm(False)
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "La consulta no retornó datos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        'UpdateAmountValued()
        bbiExport.Enabled = True
        bbiPrint.Enabled = True
        If rgReportType.SelectedIndex = 1 Then
            dtQuery = DataFilter3()
        End If
        If dtQuery.Columns.Count = 0 Then
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "La consulta no retornó información.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        gcMainData.MainView = GridView2
        gcMainData.DataSource = dtQuery
        LayoutApply2()
    End Sub

    Private Sub UpdateAmountValued()
        For r = 0 To dtQuery.Rows.Count - 1
            If IsDBNull(dtQuery.Rows(r)("CUEN_GeneraAjuste")) Then
                Continue For
            End If
            If dtQuery.Rows(r)("CUEN_GeneraAjuste") = "N" Then
                Continue For
            End If
            Dim drQuery As DataRow = dtQuery.Rows(r)
            If drQuery("DETA_moneda") = "PEN" Then
                drQuery("AmountValuedME") = (drQuery("DETA_Debe") - drQuery("DETA_Haber")) / dExchange
                drQuery("DifferenceME") = drQuery("AmountValuedME") - (drQuery("DETA_DebeDol") - drQuery("DETA_HaberDol"))
                drQuery("AmountValuedML") = 0
                drQuery("DifferenceML") = 0
            Else
                drQuery("AmountValuedME") = 0
                drQuery("DifferenceME") = 0
                drQuery("AmountValuedML") = (drQuery("DETA_DebeDol") - drQuery("DETA_HaberDol")) * dExchange
                drQuery("DifferenceML") = drQuery("AmountValuedML") - (drQuery("DETA_Debe") - drQuery("DETA_Haber"))
            End If
        Next
    End Sub

    Friend Function DataFilter() As DataTable
        Dim dtFilter As New DataTable
        Dim dtResult As New DataTable
        Dim sQuery As String = ""
        Try
            dtFilter = SelectDistinct(dtQuery, "", "CUEN_Codigo", "ENTC_Ruc", "TIPO_tipOrigen", "DETA_SerieDocOrigen", "DETA_NroDocOrigen")
            'dtFilter = SelectDistinct(dtQuery, "", "CUEN_Codigo", "ENTC_Ruc", "DETA_NroDocOrigen")
            dtResult = dtQuery.Clone
            For Each row As DataRow In dtFilter.Rows
                For c = 0 To dtFilter.Columns.Count - 1
                    If IsDBNull(row(c)) Then
                        row(c) = ""
                    End If
                Next
                sQuery = "CUEN_Codigo='" & row(0).trim & "' and ENTC_Ruc='" & row(1) & "' and TIPO_tipOrigen='" & row(2) & "' and DETA_SerieDocOrigen='" & row(3).ToString.Replace("'", "").Trim & "' and DETA_NroDocOrigen='" & row(4).ToString.Replace("'", "").Trim & "' AND DETA_Glosa<>'ASIENTO ANULADO'"
                'sQuery = "CUEN_Codigo='" & row(0).trim & "' and ENTC_Ruc='" & row(1) & "' and DETA_NroDocOrigen='" & row(2).ToString.Replace("'", "").Trim & "'"
                'If row(3) = "72582" Then
                '    DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, row(3), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'End If
                If dtQuery.Select(sQuery).Length > 0 Then
                    If dtQuery.Select(sQuery)(0)("MonedaCuenta") = False Then
                        If dtQuery.Compute("SUM(DETA_DebeDol)-SUM(DETA_HaberDol)", sQuery) <> 0 Then
                            For Each dtrow As DataRow In dtQuery.Select(sQuery).CopyToDataTable.Rows
                                dtResult.ImportRow(dtrow)
                            Next
                        End If
                    ElseIf dtQuery.Select(sQuery)(0)("MonedaCuenta") = True Then
                        If dtQuery.Compute("SUM(DETA_Debe)-SUM(DETA_Haber)", sQuery) <> 0 Then
                            For Each dtrow As DataRow In dtQuery.Select(sQuery).CopyToDataTable.Rows
                                dtResult.ImportRow(dtrow)
                            Next
                        End If
                    ElseIf IsDBNull(dtQuery.Select(sQuery)(0)("MonedaCuenta")) Then
                        If dtQuery.Compute("SUM(DETA_Debe)-SUM(DETA_Haber)", sQuery) <> 0 Or dtQuery.Compute("SUM(DETA_DebeDol)-SUM(DETA_HaberDol)", sQuery) Then
                            For Each dtrow As DataRow In dtQuery.Select(sQuery).CopyToDataTable.Rows
                                dtResult.ImportRow(dtrow)
                            Next
                        End If
                    End If
                End If
            Next
        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dtResult
    End Function

    Friend Function DataFilter2() As DataTable
        Dim dtFilter As New DataTable
        Dim dtResult As New DataTable
        Dim sQuery, sQuery2 As String
        Try
            dtFilter = SelectDistinct(dtQuery, "", "CUEN_Codigo", "ENTC_Ruc", "DETA_SerieDocOrigen", "DETA_NroDocOrigen")
            dtResult = dtQuery.Clone
            For Each row As DataRow In dtFilter.Rows
                For c = 0 To dtFilter.Columns.Count - 1
                    If IsDBNull(row(c)) Then
                        row(c) = ""
                    End If
                Next
                sQuery = "CUEN_Codigo='" & row(0).trim & "' and ENTC_Ruc='" & row(1) & "' and DETA_SerieDocOrigen='" & row(2).ToString.Replace("'", "").Trim & "' and DETA_NroDocOrigen='" & row(3).ToString.Replace("'", "").Trim & "' AND DETA_Glosa<>'ASIENTO ANULADO'"
                If dtQuery.Select(sQuery).Length > 0 Then
                    If IsDBNull(dtQuery.Select(sQuery)(0)("MonedaCuenta")) Then
                        If dtQuery.Compute("SUM(DETA_Debe)-SUM(DETA_Haber)", sQuery) <> 0 Or dtQuery.Compute("SUM(DETA_DebeDol)-SUM(DETA_HaberDol)", sQuery) Then
                            For Each dtrow As DataRow In dtQuery.Select(sQuery).CopyToDataTable.Rows
                                sQuery2 = "CABA_ano='" & dtrow("CABA_ano") & "' and CABA_mes='" & dtrow("CABA_mes") & "' and TIPO_tipReg='" & dtrow("TIPO_tipReg") & "' and CABA_NroVoucher='" & dtrow("CABA_NroVoucher") & "' and DETA_elemento='" & dtrow("DETA_elemento") & "'"
                                If dtResult.Select(sQuery2).Length = 0 Then
                                    dtResult.ImportRow(dtrow)
                                End If
                            Next
                        End If

                    ElseIf dtQuery.Select(sQuery)(0)("MonedaCuenta") = False Then
                        If dtQuery.Compute("SUM(DETA_DebeDol)-SUM(DETA_HaberDol)", sQuery) <> 0 Then
                            For Each dtrow As DataRow In dtQuery.Select(sQuery).CopyToDataTable.Rows
                                sQuery2 = "CABA_ano='" & dtrow("CABA_ano") & "' and CABA_mes='" & dtrow("CABA_mes") & "' and TIPO_tipReg='" & dtrow("TIPO_tipReg") & "' and CABA_NroVoucher='" & dtrow("CABA_NroVoucher") & "' and DETA_elemento='" & dtrow("DETA_elemento") & "'"
                                If dtResult.Select(sQuery2).Length = 0 Then
                                    dtResult.ImportRow(dtrow)
                                End If
                            Next
                        End If
                    ElseIf dtQuery.Select(sQuery)(0)("MonedaCuenta") = True Then
                        If dtQuery.Compute("SUM(DETA_Debe)-SUM(DETA_Haber)", sQuery) <> 0 Then
                            For Each dtrow As DataRow In dtQuery.Select(sQuery).CopyToDataTable.Rows
                                sQuery2 = "CABA_ano='" & dtrow("CABA_ano") & "' and CABA_mes='" & dtrow("CABA_mes") & "' and TIPO_tipReg='" & dtrow("TIPO_tipReg") & "' and CABA_NroVoucher='" & dtrow("CABA_NroVoucher") & "' and DETA_elemento='" & dtrow("DETA_elemento") & "'"
                                If dtResult.Select(sQuery2).Length = 0 Then
                                    dtResult.ImportRow(dtrow)
                                End If
                            Next
                        End If
                    End If
                End If
            Next
        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dtResult
    End Function

    Friend Function DataFilter3() As DataTable
        Dim dtFilter As New DataTable
        Dim dtResult As New DataTable
        Dim sQuery As String = ""
        Try
            dtFilter = SelectDistinct(dtQuery, "", "DCUENTA", "DCODANE", "DCODMON", "DTIPDOC", "DNUMDOC")
            dtResult = dtQuery.Clone
            For Each row As DataRow In dtFilter.Rows
                For c = 0 To dtFilter.Columns.Count - 1
                    If IsDBNull(row(c)) Then
                        row(c) = ""
                    End If
                Next
                sQuery = "DCUENTA='" & row(0).ToString.Trim & "' and DCODANE='" & row(1).ToString.Trim & "' and DCODMON='" & row(2) & "' and DTIPDOC='" & row(3).ToString & "' and DNUMDOC='" & row(4).ToString.Trim & "'"

                If dtQuery.Select(sQuery).Length > 0 Then
                    If dtQuery.Select(sQuery)(0)("DCODMON") = "US" Then
                        If dtQuery.Compute("SUM(DUSIMPOR)", sQuery) <> 0 Then
                            For Each dtrow As DataRow In dtQuery.Select(sQuery).CopyToDataTable.Rows
                                dtResult.ImportRow(dtrow)
                            Next
                        End If
                    ElseIf dtQuery.Select(sQuery)(0)("DCODMON") = "MN" Then
                        If dtQuery.Compute("SUM(DMNIMPOR)", sQuery) <> 0 Then
                            For Each dtrow As DataRow In dtQuery.Select(sQuery).CopyToDataTable.Rows
                                dtResult.ImportRow(dtrow)
                            Next
                        End If
                    End If
                End If
            Next
        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dtResult
    End Function

    Friend Function GetConditions() As String
        Dim RptCnd As String = "Condiciones:"
        If teDocument.EditValue <> "" Then
            RptCnd += IIf(Len(RptCnd) > 12, ", ", "") & " Documento=" & teDocument.EditValue
        End If
        If deDateFrom.Text <> "" Then
            RptCnd += IIf(Len(RptCnd) > 12, ", ", "") & " Fecha Desde=" & deDateFrom.Text
        End If
        If deDateTo.Text <> "" Then
            RptCnd += IIf(Len(RptCnd) > 12, ", ", "") & " Fecha Hasta=" & deDateTo.Text
        End If
        If lueAccount.Text.Trim <> "" Then
            RptCnd += IIf(Len(RptCnd) > 12, ", ", "") & " Cuenta=" & lueAccount.Text.Trim
        End If
        If luePartner.Text.Trim <> "" Then
            RptCnd += IIf(Len(RptCnd) > 12, ", ", "") & " Socio=" & luePartner.Text.Trim
        End If
        Return RptCnd
    End Function

    Private Sub LayoutApply()
        For i = 0 To GridView1.Columns.Count - 1
            If GridView1.Columns(i).ColumnType = GetType(Double) Then
                'GridView2.Columns(i).SummaryItem.SetSummary(DevExpress.Data.SummaryItemType.Sum, "{0:n2}")
                GridView1.Columns(i).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                GridView1.Columns(i).DisplayFormat.FormatString = "n2"
            End If
        Next
    End Sub

    Private Sub LayoutApply2()
        GridView2.Columns("DNUMDOC").UnboundType = DevExpress.Data.UnboundColumnType.String
        GridView2.Columns("DNUMDOC").ColumnEdit = RepositoryItemButtonEdit1
        For i = 15 To 16
            If GridView2.Columns(i).ColumnType = GetType(Decimal) Then
                GridView2.Columns(i).SummaryItem.SetSummary(DevExpress.Data.SummaryItemType.Sum, "{0:n2}")
                GridView2.Columns(i).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                GridView2.Columns(i).DisplayFormat.FormatString = "n2"
            End If
        Next
    End Sub

    Private Sub bbiExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExport.ItemClick
        ExportarExcel(gcMainData)
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
        vpInputs.SetValidationRule(Me.lueCompany, customValidationRule)
        vpInputs.SetValidationRule(Me.deDateFrom, customValidationRule)
    End Sub

    Private Sub lueCompany_EditValueChanged(sender As Object, e As EventArgs) Handles lueCompany.EditValueChanged
        LoadAccount()
        LoadAPartner()
    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        If e.FocusedRowHandle >= 0 Then
            vgcAdditionalData.DataSource = dtQuery.Select("CABA_Ano='" & GridView1.GetFocusedRowCellValue("CABA_Ano") & "' and CABA_Mes='" & GridView1.GetFocusedRowCellValue("CABA_Mes") & "' and CABA_NroVoucher='" & GridView1.GetFocusedRowCellValue("CABA_NroVoucher") & "' and DETA_Elemento='" & GridView1.GetFocusedRowCellValue("DETA_Elemento") & "'").CopyToDataTable
        End If
    End Sub

    Private Sub MovimientoContableForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        SplitContainerControl2.Collapsed = True
    End Sub

    Private Sub MovimientoContableForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        GridView1.SaveLayoutToRegistry(AppPath)
    End Sub

    Private Sub GridView1_DoubleClick(sender As Object, e As EventArgs) Handles GridView1.DoubleClick
        Dim oRow As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        Dim oForm As New VoucherViewerForm
        oForm.Sistema = rgDataSource.EditValue
        oForm.Empresa = lueCompany.EditValue
        oForm.Ejercicio = oRow("CABA_Ano")
        oForm.Mes = oRow("CABA_Mes")
        oForm.Libro = oRow("TIPO_tipReg")
        oForm.Libro = oRow("TIPO_tipReg")
        oForm.NoAsiento = oRow("CABA_NroVoucher")
        oForm.Show()
    End Sub

    Private Sub GridView2_DoubleClick(sender As Object, e As EventArgs) Handles GridView2.DoubleClick
        Dim oRow As DataRow = GridView2.GetDataRow(GridView2.FocusedRowHandle)
        Dim oForm As New VoucherViewerForm
        oForm.Empresa = lueCompany.EditValue
        oForm.Sistema = rgDataSource.EditValue
        oForm.FechaInicio = Format(deDateFrom.EditValue, "yyyyMMdd")
        oForm.FechaFin = Format(deDateTo.EditValue, "yyyyMMdd")
        oForm.Libro = oRow("DSUBDIA")
        oForm.NoAsiento = oRow("DCOMPRO")
        oForm.Show()
    End Sub

    Private Sub rgDataSource_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rgDataSource.SelectedIndexChanged
        LoadCompany()
    End Sub

    Private Sub RepositoryItemButtonEdit1_Click(sender As Object, e As EventArgs) Handles RepositoryItemButtonEdit1.Click
        Dim oGridView As New DevExpress.XtraGrid.Views.Grid.GridView
        Dim sColumn As String = ""
        If rgDataSource.EditValue = "NEXTSIS" Then
            oGridView = GridView1
            sColumn = "DETA_anexo"
        Else
            oGridView = GridView2
            sColumn = "DNUMDOC"
        End If
        If oGridView.GetRowCellValue(oGridView.FocusedRowHandle, sColumn) = "" Then
            Return
        End If
        Dim oRow As DataRow = oGridView.GetDataRow(oGridView.FocusedRowHandle)
        Dim oForm As New VisorOrdenVentaForm
        'If rgDataSource.EditValue = "NEXTSIS" Then
        oForm.sOrdenVenta = Replace(oRow(sColumn), "OV ", "")
        'Else
        '    oForm.sOrdenVenta = oRow("DNUMDOC")
        'End If
        oForm.ShowDialog()
    End Sub

    Private Sub deDateTo_Leave(sender As Object, e As EventArgs) Handles deDateTo.Leave
        lbTipoCambio.Text = ""
        If rgDataSource.SelectedIndex = 0 Then
            If Not sender.editvalue Is Nothing Then
                dExchange = NewExecuteSQL("SELECT TIPC_VentaOfi FROM NextSis" & dtCompany.Rows(0)("CompanyCode") & "..TipoCambio WHERE TIPC_Fecha='" & Format(deDateTo.EditValue, "yyyyMMdd") & "'")(0)("TIPC_VentaOfi")
                lbTipoCambio.Text = "T/C = " & Format(dExchange, "0.000")
            End If
        End If
    End Sub
End Class
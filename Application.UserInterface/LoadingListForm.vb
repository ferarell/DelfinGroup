Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraSplashScreen

Public Class LoadingListForm
    Dim oMasterDataList As New MasterDataList
    Dim dtResultDetail As New AppDataSet.LoadingListDetalladoDataTable
    Dim dtResultSummary As New AppDataSet.LoadingListResumidoDataTable
    Dim oAppService As New AppService.DelfinServiceClient
    'Dim oAppDataSet As New AppDataSet.LoadingListDataTable
    Public AppUser As String = "sistemas"

    Private Sub LoadingList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadVia()
        deLoadDate.EditValue = Today
        SplitContainerControl2.SplitterPosition = SplitContainerControl2.Height / 1.5
    End Sub

    Private Sub LoadVia()
        lueVia.Properties.DataSource = oMasterDataList.LoadMasterData("Via", Nothing)
        lueVia.Properties.DisplayMember = "DescripcionVia"
        lueVia.Properties.ValueMember = "CodigoVia"
        lueVia.ItemIndex = 0
    End Sub

    Private Sub beFilename_Properties_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles beFilename.Properties.ButtonClick
        XtraOpenFileDialog1.Filter = "Source File (*.xls*)|*.xls*"
        If XtraOpenFileDialog1.ShowDialog() = DialogResult.OK Then
            beFilename.EditValue = XtraOpenFileDialog1.FileName
        End If
    End Sub

    Private Sub bbiUpload_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiUpload.ItemClick
        LoadValidations()
        If Not vpInputs.Validate Then
            Return
        End If
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)
            SplashScreenManager.Default.SetWaitFormDescription("Cargando datos")
            Dim dtSource As New DataTable
            If cbTipo.SelectedIndex = 0 Then
                dtSource = ColumnNameStandardization(LoadExcel(XtraOpenFileDialog1.FileName, "{0}").Tables(0).Select("[SHIPPER NAME] IS NOT NULL").CopyToDataTable)
                gcDataSource.DataSource = dtSource
                ProcessDataSourceDetail(dtSource)
                gcLoadingList.DataSource = dtResultDetail
            Else
                dtSource = ColumnNameStandardization(LoadExcel(XtraOpenFileDialog1.FileName, "CALLAO$").Tables(0).Select("[POL] IS NOT NULL").CopyToDataTable)
                gcDataSource.DataSource = dtSource
                ProcessDataSourceSummary(dtSource)
                gcLoadingList.DataSource = dtResultSummary
            End If
        Catch ex As Exception
            SplashScreenManager.CloseForm(False)
            DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
    End Sub

    Function ColumnNameStandardization(dtOriginal As DataTable) As DataTable
        For c = 0 To dtOriginal.Columns.Count - 1
            dtOriginal.Columns(c).ColumnName = dtOriginal.Columns(c).ColumnName.Trim
        Next
        Return dtOriginal
    End Function

    Private Sub ProcessDataSourceDetail(dtSource As DataTable)
        dtResultDetail.Rows.Clear()
        'dtResult = oAppDataSet.Tables("LoadingList").Clone
        For r = 0 To dtSource.Rows.Count - 1
            Try
                dtResultDetail.Rows.Add()
                dtResultDetail.Rows(r)("LOAD_RONOUP") = dtSource(r)("RO NO#Up")
                dtResultDetail.Rows(r)("LOAD_FOLLOWUP") = dtSource(r)("FOLLOWUP")
                If Not IsDBNull(dtSource(r)("SHIPPER NAME")) Then
                    dtResultDetail.Rows(r)("LOAD_SHIPPER") = Mid(dtSource(r)("SHIPPER NAME"), 1, dtResultDetail.Columns("LOAD_SHIPPER").MaxLength)
                End If
                If Not IsDBNull(dtSource(r)("CONSIGNEE NAME")) Then
                    dtResultDetail.Rows(r)("LOAD_CONSIGNEE") = Mid(dtSource(r)("CONSIGNEE NAME"), 1, dtResultDetail.Columns("LOAD_CONSIGNEE").MaxLength)
                End If
                If Not IsDBNull(dtSource(r)("NOTIFY NAME")) Then
                    dtResultDetail.Rows(r)("LOAD_NOTIFY") = Mid(dtSource(r)("NOTIFY NAME"), 1, dtResultDetail.Columns("LOAD_NOTIFY").MaxLength)
                End If
                If Not IsDBNull(dtSource(r)("POL")) Then
                    dtResultDetail.Rows(r)("LOAD_POL") = Mid(dtSource(r)("POL"), 1, dtResultDetail.Columns("LOAD_POL").MaxLength)
                End If
                dtResultDetail.Rows(r)("LOAD_POLNAME") = dtSource(r)("POL_NAME")
                If Not IsDBNull(dtSource(r)("POD")) Then
                    dtResultDetail.Rows(r)("LOAD_POD") = Mid(dtSource(r)("POD"), 1, dtResultDetail.Columns("LOAD_POD").MaxLength)
                End If
                dtResultDetail.Rows(r)("LOAD_PODNAME") = dtSource(r)("POD_NAME")
                dtResultDetail.Rows(r)("LOAD_CARRIER") = dtSource(r)("CARRIER")
                dtResultDetail.Rows(r)("LOAD_BOOKING") = dtSource(r)("BOOKINGNBR")
                dtResultDetail.Rows(r)("LOAD_MBL") = dtSource(r)("MBL")
                dtResultDetail.Rows(r)("LOAD_HBL") = dtSource(r)("HBL")
                dtResultDetail.Rows(r)("LOAD_ETD") = dtSource(r)("ETD")
                dtResultDetail.Rows(r)("LOAD_ETA") = dtSource(r)("ETA")
                dtResultDetail.Rows(r)("LODE_TIPOCNT") = dtSource(r)("CNTRTYPE")
                dtResultDetail.Rows(r)("LODE_TAMANIOCNTR") = dtSource(r)("CNTRSIZE")
                dtResultDetail.Rows(r)("LODE_NUMEROCNTR") = dtSource(r)("CNTR ID")
                dtResultDetail.Rows(r)("LODE_PRECINTO") = dtSource(r)("SEAL NUMBER")
                dtResultDetail.Rows(r)("LODE_CARGAPELIGROSA") = dtSource(r)("HAZARDOUS")
                dtResultDetail.Rows(r)("LODE_IMOCLASS") = dtSource(r)("IMO CLASS")
                dtResultDetail.Rows(r)("LODE_PESOBRUTO") = dtSource(r)("GROSS WEIGHT")
                dtResultDetail.Rows(r)("LODE_PACKTYPE") = dtSource(r)("PACK TYPE")
                dtResultDetail.Rows(r)("LODE_CANTBULTOS") = dtSource(r)("PACK QTY")
                dtResultDetail.Rows(r)("LODE_VOLUMEN") = dtSource(r)("VOLUME")
                dtResultDetail.Rows(r)("LODE_DESCCARGA") = dtSource(r)("COMMODITY DESCRIPTION")
                dtResultDetail.Rows(r)("LODE_MARCASNUMEROS") = dtSource(r)("MARKS & NUMBERS")
                dtResultDetail.Rows(r)("LOAD_CONTRACTCODE") = dtSource(r)("CONTRACT CODE")
            Catch ex As Exception
                dtResultDetail.Rows(r)("ERROR_DESCRIPTION") = ex.Message
            End Try
        Next
    End Sub

    Private Sub ProcessDataSourceSummary(dtSource As DataTable)
        dtResultSummary.Rows.Clear()
        'dtResultSummary = oAppDataSet.Tables("LoadingList").Clone

        For r = 0 To dtSource.Rows.Count - 1
            Try
                dtResultSummary.Rows.Add()
                If Not IsDBNull(dtSource(r)("POL")) Then
                    dtResultSummary.Rows(r)("LOAD_POL") = Mid(dtSource(r)("POL"), 1, dtResultSummary.Columns("LOAD_POL").MaxLength)
                End If
                dtResultSummary.Rows(r)("LOAD_MV") = dtSource(r)("M/V")
                dtResultSummary.Rows(r)("LOAD_ETD") = dtSource(r)("ETD")
                dtResultSummary.Rows(r)("LOAD_CARRIER") = dtSource(r)("CARRIER")
                dtResultSummary.Rows(r)("LOAD_BOOKING") = dtSource(r)("BOOKING NO#")
                dtResultSummary.Rows(r)("LOAD_MBL") = dtSource(r)("MB/L")
                dtResultSummary.Rows(r)("LOAD_HBL") = dtSource(r)("HB/L")

                If Not IsDBNull(dtSource(r)("POD")) Then
                    dtResultSummary.Rows(r)("LOAD_POD") = Mid(dtSource(r)("POD"), 1, dtResultSummary.Columns("LOAD_POD").MaxLength)
                End If
                dtResultSummary.Rows(r)("LOAD_OFTERM") = dtSource(r)("O/F TERM")
                dtResultSummary.Rows(r)("LOAD_CNTR") = dtSource(r)("CNTR")

                If Not IsDBNull(dtSource(r)("SHIPPER")) Then
                    dtResultSummary.Rows(r)("LOAD_SHIPPER") = Mid(dtSource(r)("SHIPPER"), 1, dtResultSummary.Columns("LOAD_SHIPPER").MaxLength)
                End If
                If Not IsDBNull(dtSource(r)("CONSIGNEE")) Then
                    dtResultSummary.Rows(r)("LOAD_CONSIGNEE") = Mid(dtSource(r)("CONSIGNEE"), 1, dtResultSummary.Columns("LOAD_CONSIGNEE").MaxLength)
                End If
                dtResultSummary.Rows(r)("LOAD_CODE") = dtSource(r)("CODE")
            Catch ex As Exception
                dtResultSummary.Rows(r)("ERROR_DESCRIPTION") = ex.Message
            End Try
        Next
    End Sub

    Private Sub LoadValidations()
        Validate()
        Dim containsValidationRule As New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        containsValidationRule.ConditionOperator = ConditionOperator.IsNotBlank
        containsValidationRule.ErrorText = "Assign value."
        containsValidationRule.ErrorType = ErrorType.Critical
        Dim customValidationRule As New CustomValidationRule()
        customValidationRule.ErrorText = "Required value."
        customValidationRule.ErrorType = ErrorType.Critical
        vpInputs.SetValidationRule(Me.beFilename, customValidationRule)
    End Sub

    Private Sub bbiUpdate_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiUpdate.ItemClick
        Dim aResult As New ArrayList
        If cbTipo.SelectedIndex = 0 And dtResultDetail.Rows.Count = 0 Then
            Return
        End If
        If cbTipo.SelectedIndex = 1 And dtResultSummary.Rows.Count = 0 Then
            Return
        End If
        Dim dtLoadingList As New DataTable
        If cbTipo.SelectedIndex = 0 Then
            dtLoadingList = GetDataResultDetail(dtResultDetail)
        Else
            dtLoadingList = GetDataResultSummary(dtResultSummary)
        End If
        Dim oParams, oValues As New ArrayList
        oParams.Add("@pvchLOAD_CargaUsuario")
        oValues.Add(AppUser)
        oParams.Add("@pdtmLOAD_CargaFecha")
        oValues.Add(deLoadDate.EditValue)
        oParams.Add("@pchrCONS_TabVIA")
        oValues.Add("VIA")
        oParams.Add("@pchrCONS_CodVIA")
        oValues.Add(lueVia.EditValue)
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)
            SplashScreenManager.Default.SetWaitFormDescription("Procesando Loading List")
            If cbTipo.SelectedIndex = 0 Then
                aResult.AddRange(oAppService.UpdatingWithTableAndParameters("NextSoft.dbo.OPE_LOADSI_ImportacionDetalladoNS", dtLoadingList, oParams.ToArray, oValues.ToArray))
            Else
                aResult.AddRange(oAppService.UpdatingWithTableAndParameters("NextSoft.dbo.OPE_LOADSI_ImportacionResumidoNS", dtLoadingList, oParams.ToArray, oValues.ToArray))
            End If
            SplashScreenManager.CloseForm(False)
            If aResult(0) = 1 Then
                DevExpress.XtraEditors.XtraMessageBox.Show("El proceso de actualización finalizó correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                DevExpress.XtraEditors.XtraMessageBox.Show("El proceso de actualización finalizó con el siguiente error: " & aResult(1), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            SplashScreenManager.CloseForm(False)
            DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
    End Sub

    Function GetDataResultDetail(dtSource As DataTable) As DataTable
        If dtSource.Columns.Contains("ERROR_DESCRIPTION") Then
            dtSource.Columns.Remove("ERROR_DESCRIPTION")
        End If
        Dim dtQuery As New DataTable
        dtQuery = dtResultDetail.CopyToDataTable
        dtQuery.TableName = "DataTable"
        dtQuery.Rows.Clear()
        'dtQuery = oAppService.ExecuteSQL("SELECT TOP 0 * FROM NextSoft..OPE_LoadingListTemp").Tables(0)
        'dtQuery.Columns.Remove("LOAD_CARGAFECHA")
        'dtQuery.Columns.Remove("LOAD_CODIGO")
        For r = 0 To dtSource.Rows.Count - 1
            dtQuery.Rows.Add(dtSource.Rows(r).ItemArray)
        Next
        Return dtQuery
    End Function

    Function GetDataResultSummary(dtSource As DataTable) As DataTable
        If dtSource.Columns.Contains("ERROR_DESCRIPTION") Then
            dtSource.Columns.Remove("ERROR_DESCRIPTION")
        End If
        Dim dtQuery As New DataTable
        dtQuery = dtResultSummary.CopyToDataTable
        dtQuery.TableName = "DataTable"
        dtQuery.Rows.Clear()
        For r = 0 To dtSource.Rows.Count - 1
            dtQuery.Rows.Add(dtSource.Rows(r).ItemArray)
        Next
        Return dtQuery
    End Function

    'Private Sub ImportSchema(ByVal dest As DataTable, ByVal source As DataTable) As 
    '    'For Each c In source.Columns
    '    '    dest.Columns.Add(c)
    '    'Next
    '    Dim schema As DataTable = source.CreateDataReader.GetSchemaTable()
    '    ImportSchema(dest, schema)
    'End Sub

    Private Sub bbiExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExport.ItemClick
        ExportToExcel(gcLoadingList)
    End Sub

    Private Sub GridView1_RowStyle(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles GridView1.RowStyle
        Dim View As GridView = sender
        If (e.RowHandle >= 0) Then
            Dim _ErrorDescription As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("ERROR_DESCRIPTION"))

            If _ErrorDescription <> "" Then
                e.Appearance.BackColor = Color.Salmon
                e.Appearance.BackColor2 = Color.SeaShell
            End If

        End If
    End Sub

End Class
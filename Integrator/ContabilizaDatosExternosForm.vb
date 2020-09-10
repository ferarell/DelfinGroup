Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraSplashScreen
Imports System.Threading

Public Class ContabilizaDatosExternosForm
    Dim bError As Boolean = False
    Dim dTipoCambio As Double = 0
    Dim dtSource, dtMapping, dtVoucherH, dtVoucherD As New DataTable
    Dim dsVoucher As New DataSet
    Dim CiaCode As String = ""
    Dim sVoucher As String = ""
    Dim oAppService As New AppService.DelfinServiceClient

    Private Sub ContabilizaDatosExternosForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        seFiscalYear.Text = Year(Now).ToString
        seFiscalPeriod.Text = Month(Now).ToString
        EnableButtons(False)
        Try
            LoadCompany()
            LoadInterfaces()
            LoadMapping()
        Catch ex As Exception
            bError = True
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadCompany()
        dtCompany = GetCompaniesList("NEXTSIS")
        lueCompany.Properties.DataSource = dtCompany
        lueCompany.Properties.DisplayMember = "CompanyName"
        lueCompany.Properties.ValueMember = "CompanyCode"
    End Sub

    Private Sub LoadInterfaces()
        Dim dtInterfaces As New DataTable
        dtInterfaces = NewExecuteSQL("select * from InterfacesContables (nolock) where origen='E' ")
        lueInterface.Properties.DataSource = dtInterfaces
        lueInterface.Properties.DisplayMember = "Descripcion"
        lueInterface.Properties.ValueMember = "ID"
    End Sub

    Private Sub LoadMapping()
        dtMapping = NewExecuteSQL("select * from ExternalMapping")
    End Sub

    Private Sub bbiProcess_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiProcess.ItemClick
        bError = False
        LoadInputValidations()
        If Not vpInputs.Validate Then
            Return
        End If
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)
            LoadDataSources()
        Catch ex As Exception
            bError = True
            SplashScreenManager.CloseForm(False)
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        SplashScreenManager.CloseForm(False)
        gcMainData.DataSource = dtSource
        LayoutApply()
    End Sub

    Private Sub LayoutApply()
        'GridView1.PopulateColumns()
        For i = 4 To 5
            GridView1.Columns(i).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridView1.Columns(i).DisplayFormat.FormatString = "###,###,##0.00"
            GridView1.Columns(i).SummaryItem.SetSummary(DevExpress.Data.SummaryItemType.Sum, "{0:n2}")
            GridView1.Columns(i).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridView1.Columns(i).DisplayFormat.FormatString = "n2"
        Next

    End Sub

    Private Sub LoadDataSources()
        Dim iStep As Integer = 1
        If OpenFileDialog1.FileName.ToUpper.Contains(".XLS") Then
            Try
                SplashScreenManager.Default.SetWaitFormDescription("Cargando datos externos...")
                dtSource.Rows.Clear()
                dtSource = GetExternalData(LoadExcel(beDataSource.Text, "{0}").Tables(0), lueInterface.ItemIndex)
                SplashScreenManager.Default.SetWaitFormDescription("Validando datos cargados...")
                DataSourceValidate(lueInterface.ItemIndex)
            Catch ex As Exception
                bError = True
                DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Error al cargar archivo " & OpenFileDialog1.FileName & ". " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Friend Function GetExternalData(dtSource As DataTable, iSource As Integer) As DataTable
        Dim dtResult As New DataTable
        Dim CtaCtb As String = ""
        Dim Row As DataRow
        dtResult.Columns.Add("C1", GetType(String)).AllowDBNull = True
        dtResult.Columns.Add("C2", GetType(String)).AllowDBNull = True
        dtResult.Columns.Add("C3", GetType(String)).AllowDBNull = True
        dtResult.Columns.Add("C4", GetType(String)).AllowDBNull = True
        dtResult.Columns.Add("C5", GetType(Double)).DefaultValue = 0
        dtResult.Columns.Add("C6", GetType(Double)).DefaultValue = 0
        dtResult.Columns.Add("C7", GetType(String)).AllowDBNull = True
        For r = 0 To dtSource.Rows.Count - 1
            Row = dtSource.Rows(r)
            For c = 0 To dtSource.Columns.Count - 1
                If Row.Table.Columns(c).ColumnName.ToUpper = "DEBE" And Not Row.Table.Columns(c).DataType Is System.Type.GetType("System.Double") Or Row.Table.Columns(c).ColumnName.ToUpper = "HABER" And Not Row.Table.Columns(c).DataType Is System.Type.GetType("System.Double") Then
                    DevExpress.XtraEditors.XtraMessageBox.Show("Las columnas DEBE y HABER deben ser numéricas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return dtResult
                End If
                Dim Col As DataColumn = dtSource.Columns(c)
                If IsDBNull(Row(c)) Then
                    If Row.Table.Columns(c).DataType Is System.Type.GetType("System.String") Then
                        Row(c) = ""
                        If c = 4 Or c = 5 Then
                            Row(c) = "0"
                        End If
                    ElseIf Row.Table.Columns(c).DataType Is System.Type.GetType("System.Double") Then
                        Row(c) = 0
                    End If
                End If
                If Row.Table.Columns(c).ColumnName.ToUpper = "DEBE" Or Row.Table.Columns(c).ColumnName.ToUpper = "HABER" Then
                    If Not IsNumeric(Row(c)) Then
                        If Row(c) = "-" Then
                            Row(c) = "0"
                        End If
                    End If
                End If
            Next
            If Row(0) = "" Or (Row(4) = 0 And Row(5) = 0) Then
                Continue For
            End If
            CtaCtb = ""
            If CStr(Row(3)) <> "" Then
                CtaCtb = Mid(Row(3), 1, 2) & "." & Mid(Row(3), 3, 1) & "." & Mid(Row(3), 4, 1) & "." & Mid(Row(3), 5, 2)
            End If
            If (Row(4) - Row(5) <> 0) Then
                dtResult.Rows.Add(Row(0), IIf(Mid(CtaCtb, 1, 1) = "6", GetDataMap("CECO", Row(1), 1), Row(1)), Row(2), CtaCtb, Math.Round(CDbl(Row(4)), 2), Math.Round(CDbl(Row(5)), 2))
                If Mid(CtaCtb, 1, 1) = "6" Then
                    dtResult.Rows.Add(Row(0), "", Row(2), GetDataMap("CECO", Row(1), 2), Math.Round(CDbl(Row(4)), 2), Math.Round(CDbl(Row(5)), 2))
                    If Row(4) = 0 Then
                        dtResult.Rows.Add(Row(0), "", Row(2), GetDataMap("CECO", Row(1), 3), Math.Round(CDbl(Row(5)), 2), 0)
                    Else
                        dtResult.Rows.Add(Row(0), "", Row(2), GetDataMap("CECO", Row(1), 3), 0, Math.Round(CDbl(Row(4)), 2))
                    End If
                End If
            End If
        Next
        Dim dDiff As Double = Math.Round(dtResult.Compute("SUM(C5)-SUM(C6)", ""), 2)
        If dDiff <> 0 Then
            If dDiff > 0 Then
                dtResult.Rows.Add("REDONDEO AUTOGENERADO", "", "REDONDEO", My.Settings.RoundingCredit, 0, Math.Abs(dDiff))
            Else
                dtResult.Rows.Add("REDONDEO AUTOGENERADO", GetDataMap("CUENTA", My.Settings.RoundingDebit, 1), "REDONDEO", My.Settings.RoundingDebit, Math.Abs(dDiff), 0)
                dtResult.Rows.Add("REDONDEO AUTOGENERADO", "", "REDONDEO", GetDataMap("CUENTA", My.Settings.RoundingDebit, 2), Math.Abs(dDiff), 0)
                dtResult.Rows.Add("REDONDEO AUTOGENERADO", "", "REDONDEO", GetDataMap("CUENTA", My.Settings.RoundingDebit, 3), 0, Math.Abs(dDiff))
            End If
        End If
        Return dtResult
    End Function

    Private Sub DataSourceValidate(IdSource As Integer)
        CiaCode = lueCompany.EditValue
        Dim dtAccount As New DataTable
        dtAccount = NewExecuteSQL("select CUEN_Codigo from NextSis" & CiaCode & "..CON_Cuentas (nolock) where CUEN_ano='" & seFiscalYear.Text & "'")
        bError = False
        For r = 0 To dtSource.Rows.Count - 1
            Dim row As DataRow = dtSource.Rows(r)
            If row("C4") = My.Settings.RoundingCredit Or row("C4") = My.Settings.RoundingDebit Then
                Continue For
            End If
            If dtAccount.Select("CUEN_Codigo='" & row(3) & "'").Count = 0 Then
                bError = True
                row("C7") = "No se encontró la cuenta contable " & row(3) & ", por favor verifique el plan de cuentas de la empresa."
            End If
            If row("C3") = "REDONDEO" Then
                If row("C5") + row("C6") > 1 Then
                    bError = True
                    row("C7") = "El redondeo excede el importe máximo permitido (1.00) "
                End If
            End If
            If (Mid(row("C4"), 1, 2) = "14" Or Mid(row("C4"), 1, 2) = "75") And row("C2") = "" Then
                bError = True
                row("C7") = "Debe asignar el DNI del empleado "
            End If
            If row("C2").ToString.Trim.Length = 8 Or row("C2").ToString.Trim.Length = 11 Then
                If Not PartnerValidate(row("C2")) Then
                    bError = True
                    row("C7") = "El documento de identidad " & row("C2") & " no existe en el maestro de socios de la empresa."
                End If
            End If
            If (row("C1").Contains("A.F.P.") Or row("C1").Contains("BIF")) And row("C2") = "" Then
                bError = True
                row("C7") = "Debe asignar el RUC de la Entidad "
            End If
            If row("C1").Contains("Vacacion") And Mid(row("C4"), 1, 2) <> "41" Then
                bError = True
                row("C7") = "La cuenta es incorrecta para este concepto."
            End If
        Next
    End Sub

    Friend Function PartnerValidate(PartnerId As String) As Boolean
        Dim bResult As Boolean = True
        If NewExecuteSQL("select ENTC_Codigo from NextSis" & CiaCode & ".dbo.Entidad (nolock) where ENTC_Ruc='" & PartnerId & "'").Rows.Count = 0 Then
            bResult = False
        End If
        Return bResult
    End Function

    Friend Function GetDataMap(Table As String, sInput As String, iOutput As Integer) As String
        Dim sResult As String = ""
        If dtMapping.Select("MapTable='" & Table & "' and ExternalInput='" & sInput.Trim & "'").Length > 0 Then
            sResult = dtMapping.Select("MapTable='" & Table & "' and ExternalInput='" & sInput.Trim & "'")(0)("LocalOutput" & iOutput.ToString)
        End If
        Return sResult
    End Function

    Private Sub bbiVoucher_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiVoucher.ItemClick
        Dim sQuery As String = ""
        dTipoCambio = GetExchange(LastDayOfMonth(seFiscalYear.Text & "-" & Format(seFiscalPeriod.EditValue, "00") & "-01"))
        If dTipoCambio = 0 Then
            DevExpress.XtraEditors.XtraMessageBox.Show("No existe tipo de cambio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Este proceso generará un nuevo asiento contable, desea continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.No Then
            Return
        End If
        Try
            sQuery = "select CABA_NroVoucher from NextSis" & CiaCode & ".dbo.CON_CabAsientos where SUCR_Codigo='01' and CABA_Ano='" & seFiscalYear.Text & "' and CABA_Mes='" & Format(seFiscalPeriod.EditValue, "00") & "' and TIPO_tabReg='REG' and TIPO_tipReg='" & lueInterface.GetColumnValue("TipoRegistro") & "' and TIPO_tipRegRef='" & lueInterface.EditValue.ToString & "'"
            If NewExecuteSQL(sQuery).Rows.Count > 0 Then
                DevExpress.XtraEditors.XtraMessageBox.Show("El registro contable seleccionado ya tiene un asiento contable asociado, por favor verifique.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            If lueInterface.GetColumnValue("TipoRegistro") = "005" Then
                If DataProcess01() Then
                    DevExpress.XtraEditors.XtraMessageBox.Show("Se generó el asiento contable " & sVoucher, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    DevExpress.XtraEditors.XtraMessageBox.Show("No fue posible generar el asiento contable.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            SplashScreenManager.CloseForm(False)
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Friend Function DataProcess01() As Boolean
        Dim aResult As New ArrayList
        Dim sGlosa As String = lueInterface.Text & Space(1) & seFiscalYear.Text & "-" & Format(seFiscalPeriod.EditValue, "00")
        Dim dDifME As Double = 0
        SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)
        SplashScreenManager.Default.SetWaitFormDescription("Generando información preliminar del asiento contable")
        dsVoucher.Tables.Clear()
        dtVoucherH = NewExecuteSQL("SELECT * FROM NextSis" & CiaCode & "..CON_CabAsientos (nolock) WHERE SUCR_Codigo='00'")
        dtVoucherD = NewExecuteSQL("SELECT * FROM NextSis" & CiaCode & "..CON_DetAsientos (nolock) WHERE SUCR_Codigo='00'")
        For r = 0 To dtSource.Rows.Count - 1
            Dim row As DataRow = dtSource.Rows(r)
            If r = 0 Then
                'Inserta Cabecera
                dtVoucherH.Rows.Add()
                dtVoucherH.Rows(r)("SUCR_Codigo") = "01"
                dtVoucherH.Rows(r)("CABA_Mes") = Format(seFiscalPeriod.EditValue, "00")
                dtVoucherH.Rows(r)("TIPO_tabReg") = "REG"
                dtVoucherH.Rows(r)("CABA_ano") = seFiscalYear.Text
                dtVoucherH.Rows(r)("TIPO_tipReg") = lueInterface.GetColumnValue("TipoRegistro")
                dtVoucherH.Rows(r)("CABA_NroVoucher") = "000000"
                dtVoucherH.Rows(r)("CABA_Glosa") = sGlosa
                dtVoucherH.Rows(r)("CABA_moneda") = 1
                dtVoucherH.Rows(r)("CABA_TipoAsiento") = "A"
                dtVoucherH.Rows(r)("CABA_UsrCrea") = "integrador"
                dtVoucherH.Rows(r)("CABA_FecCrea") = Date.Now
                'dtVoucherH.Rows(r)("CABA_UsrMod")
                'dtVoucherH.Rows(r)("CABA_FecMod") = ""
                'dtVoucherH.Rows(r)("TIPO_tipTRE") = ""
                dtVoucherH.Rows(r)("TIPO_tabTRE") = "TRE"
                dtVoucherH.Rows(r)("TIPO_tipregRef") = lueInterface.GetColumnValue("ID")
                'dtVoucherH.Rows(r)("TIPO_tabRegRef") = ""
                'dtVoucherH.Rows(r)("CABA_anoRef") = ""
                'dtVoucherH.Rows(r)("CABA_mesRef") = ""
                'dtVoucherH.Rows(r)("CABA_nrovoucherRef") = ""
            End If
            'Inserta Detalle
            'dDifME += row(4) - row(5)
            dtVoucherD.Rows.Add()
            dtVoucherD.Rows(r)("CABA_Ano") = seFiscalYear.Text
            dtVoucherD.Rows(r)("DETA_Elemento") = r + 1
            dtVoucherD.Rows(r)("SUCR_Codigo") = "01"
            dtVoucherD.Rows(r)("DETA_Glosa") = sGlosa
            dtVoucherD.Rows(r)("CABA_Mes") = Format(seFiscalPeriod.EditValue, "00")
            If row("C2").ToString.Trim.Length = 8 Or row("C2").ToString.Trim.Length = 11 Then
                dtVoucherD.Rows(r)("ENTC_Codigo") = GetPartnerCodeByDocId(row(1))
            End If
            'dtVoucherD.Rows(r)("TIPO_tipOpe") = ""
            dtVoucherD.Rows(r)("TIPO_tipOrigen") = lueInterface.GetColumnValue("TipoDocumento")
            dtVoucherD.Rows(r)("CABA_NroVoucher") = "000000"
            If Mid(row(3), 1, 1) = "6" Then
                dtVoucherD.Rows(r)("CENT_Codigo") = row(1)
            End If
            dtVoucherD.Rows(r)("TIPO_tabReg") = "REG"
            dtVoucherD.Rows(r)("TIPO_tipReg") = lueInterface.GetColumnValue("TipoRegistro")
            dtVoucherD.Rows(r)("DETA_FecDocOrigen") = LastDayOfMonth(seFiscalYear.Text & "-" & Format(seFiscalPeriod.EditValue, "00") & "-01")
            dtVoucherD.Rows(r)("DETA_SerieDocOrigen") = Format(seFiscalPeriod.EditValue, "00")
            dtVoucherD.Rows(r)("DETA_NroDocOrigen") = Format(dtVoucherD.Rows(r)("DETA_FecDocOrigen"), "ddMMyyyy")
            dtVoucherD.Rows(r)("CUEN_Codigo") = row(3)
            dtVoucherD.Rows(r)("DETA_Debe") = row(4)
            dtVoucherD.Rows(r)("DETA_Haber") = row(5)
            dtVoucherD.Rows(r)("DETA_DebeDol") = row(4) / dTipoCambio
            dtVoucherD.Rows(r)("DETA_HaberDol") = row(5) / dTipoCambio
            If row(2) = "REDONDEO" Then
                If row(4) > 0 Then
                    dtVoucherD.Rows(r)("DETA_DebeDol") = IIf(dDifME < 0, Math.Abs(dDifME), 0)
                    dtVoucherD.Rows(r)("DETA_HaberDol") = IIf(dDifME >= 0, Math.Abs(dDifME), 0)
                Else
                    dtVoucherD.Rows(r)("DETA_DebeDol") = IIf(dDifME >= 0, Math.Abs(dDifME), 0)
                    dtVoucherD.Rows(r)("DETA_HaberDol") = IIf(dDifME < 0, Math.Abs(dDifME), 0)
                End If
            Else
                dDifME += Math.Round(dtVoucherD.Rows(r)("DETA_DebeDol") - dtVoucherD.Rows(r)("DETA_HaberDol"), 2)
            End If
            'dtVoucherD.Rows(r)("TIPO_tabOpe") = ""
            dtVoucherD.Rows(r)("TIPO_tabOrigen") = "TDO"
            dtVoucherD.Rows(r)("DETA_referencia") = row(0)
            dtVoucherD.Rows(r)("DETA_Amarre") = 0
            dtVoucherD.Rows(r)("DETA_porcAmarre") = 0
            dtVoucherD.Rows(r)("DETA_tipoAmarre") = 0
            dtVoucherD.Rows(r)("DETA_numAmarre") = 0
            If dtVoucherD.Rows(r)("CUEN_codigo") = "97.2" Then
                dtVoucherD.Rows(r)("DETA_Amarre") = 1
                dtVoucherD.Rows(r)("DETA_porcAmarre") = 100
                dtVoucherD.Rows(r)("DETA_tipoAmarre") = 2
            End If
            dtVoucherD.Rows(r)("DETA_tCambio") = dTipoCambio
            'dtVoucherD.Rows(r)("PPER_Numero") = 0
            'dtVoucherD.Rows(r)("PART_Codigo") = ""
            'dtVoucherD.Rows(r)("TIGA_codigo") = ""
            'dtVoucherD.Rows(r)("DETA_FecRetencion") = ""
            dtVoucherD.Rows(r)("DETA_NroRetencion") = ""
            'dtVoucherD.Rows(r)("DETA_FecVcto") = ""
            'dtVoucherD.Rows(r)("TIPO_DocReferencia") = ""
            'dtVoucherD.Rows(r)("TIPO_tabUbicaciones") = ""
            'dtVoucherD.Rows(r)("TIPO_codUbicaciones") = ""
            dtVoucherD.Rows(r)("DETA_medioPago") = ""
            dtVoucherD.Rows(r)("DETA_anexo") = ""
            dtVoucherD.Rows(r)("DETA_serieReferencia") = ""
            dtVoucherD.Rows(r)("DETA_moneda") = 1
            dtVoucherD.Rows(r)("DETA_observacion") = ""
        Next
        dsVoucher.Tables.Add(dtVoucherH.Copy)
        dsVoucher.Tables(0).TableName = "VoucherH"
        dsVoucher.Tables.Add(dtVoucherD.Copy)
        dsVoucher.Tables(1).TableName = "VoucherD"
        SplashScreenManager.Default.SetWaitFormDescription("Insertando el nuevo asiento contable...")
        aResult.AddRange(oAppService.GenerateNextSisVoucher(CiaCode, dsVoucher))
        If aResult(0) = 0 Then
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, aResult(1), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        sVoucher = seFiscalYear.Text & "-" & Format(seFiscalPeriod.EditValue, "00") & "-" & aResult(1) & "-" & lueInterface.GetColumnValue("TipoRegistro")
        SplashScreenManager.CloseForm(False)
        Return CBool(aResult(0))
    End Function

    Friend Function GetPartnerCodeByDocId(PartnerId As String) As String
        Dim dtQuery As New DataTable
        Dim dsResult As String = ""
        dtQuery = NewExecuteSQL("select ENTC_Codigo from NextSis" & CiaCode & ".dbo.Entidad (nolock) where ENTC_Ruc='" & PartnerId & "'")
        If dtQuery.Rows.Count > 0 Then
            dsResult = dtQuery(0)(0)
        End If
        Return dsResult
    End Function

    Friend Function GetExchange(RefDate As Date) As Decimal
        Dim dResult As Double = 0
        Dim dtQuery As New DataTable
        dtQuery = NewExecuteSQL("select TIPC_VentaOfi from NextSis" & CiaCode & ".dbo.TipoCambio (nolock) where TIPC_Fecha='" & Format(RefDate, "yyyyMMdd") & "'")
        If dtQuery.Rows.Count > 0 Then
            dResult = dtQuery(0)(0)
        End If
        Return dResult
    End Function

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
    End Sub

    Private Sub bbiClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiClose.ItemClick
        Close()
    End Sub

    Private Sub beArchivoOrigen_Properties_Click(sender As Object, e As EventArgs) Handles beDataSource.Properties.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            beDataSource.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub bbiExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExport.ItemClick
        ExportarExcel(gcMainData)
    End Sub

    Private Sub gcMainData_DataSourceChanged(sender As Object, e As EventArgs) Handles gcMainData.DataSourceChanged
        EnableButtons(True)
        If GridView1.RowCount = 0 Then
            EnableButtons(False)
        End If
    End Sub

    Private Sub EnableButtons(bEnabled As Boolean)
        bbiVoucher.Enabled = False
        bbiExport.Enabled = bEnabled
        If GridView1.RowCount > 0 And Not bError Then
            bbiVoucher.Enabled = bEnabled
        End If
    End Sub

    Private Sub GridView1_RowCellStyle(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles GridView1.RowStyle
        Dim View As GridView = sender
        If (e.RowHandle >= 0) Then
            Dim Errors As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("C7"))
            If Errors <> "" Then
                e.Appearance.BackColor = Color.Salmon
                e.Appearance.BackColor2 = Color.SeaShell
            End If
        End If
    End Sub

End Class
Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Drawing
Imports System.IO
Imports System.Globalization
Imports DevExpress.XtraSplashScreen
Imports System.Threading

Public Class PagoProveedoresFormvb
    Dim bError As Boolean = False
    Dim dtQuery, dtResult, dtMapping, dtVoucherH, dtVoucherD As New DataTable
    Dim dsResult, dsVoucher As New DataSet
    Dim CiaCode As String = ""
    Dim sVoucher As String = ""
    Dim oAppService As New AppService.DelfinServiceClient

    Private Sub PagoProveedoresFormvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        deDateFrom.EditValue = New DateTime(DateTime.Now.Year, 1, 1)
        'deDateTo.EditValue = Today
        cbeProcessType.SelectedIndex=0
        GridView1.RestoreLayoutFromRegistry(AppPath)
        EnableButtons(False)
        Try
            LoadAccountBank()
            LoadOperationType()
            LoadPartner()
        Catch ex As Exception
            bError = True
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub bbiSearch_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSearch.ItemClick
        LoadInputValidations()
        If Not vpInputs.Validate Then
            Return
        End If
        Dim sFecIni As String = Format(deDateFrom.EditValue, "yyyyMMdd")
        'Dim sFecFin As String = Format(deDateTo.EditValue, "yyyyMMdd")
        dtQuery.Rows.Clear()
        SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)
        Try
            dtResult = NewExecuteSQL("EXEC NextSoft.dbo.CAJ_CCCTSS_TodosPendientesEgresos 1, " & CInt(luePartner.EditValue).ToString & ", '" & sFecIni & "', 'EG', NULL, NULL, NULL, NULL, NULL, NULL")
            dtQuery = dtResult
            dtQuery.Columns.Add("Checked", GetType(Boolean)).DefaultValue = False
            dtQuery.Columns.Add("OperationDate", GetType(Date)).AllowDBNull = True
            dtQuery.Columns.Add("OperationNumber", GetType(String)).DefaultValue = ""
            dtQuery.Columns.Add("Exchange", GetType(Decimal)).DefaultValue = 0
            dtQuery.Columns.Add("Reference", GetType(String)).DefaultValue = ""
            dtQuery.Columns.Add("VoucherDG", GetType(String)).DefaultValue = ""
            dtQuery.Columns.Add("VoucherDC", GetType(String)).DefaultValue = ""
            gcMainData.DataSource = dtQuery
            SetOperationValues()
            LayoutApply()
        Catch ex As Exception
            SplashScreenManager.CloseForm(False)
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
    End Sub

    Private Sub bbiExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExport.ItemClick
        ExportarExcel(gcMainData)
    End Sub

    Private Sub bbiClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiClose.ItemClick
        Close()
    End Sub

    Private Sub SetOperationValues()
        For r = 0 To GridView1.RowCount - 1
            If Not deOperationDate.EditValue Is Nothing Then
                If IsDBNull(GridView1.GetRowCellValue(r, "OperationDate")) Then
                    GridView1.SetRowCellValue(r, "OperationDate", deOperationDate.EditValue)
                    GridView1.SetRowCellValue(r, "Exchange", GetExchange(GridView1.GetRowCellValue(r, "OperationDate")))
                End If
                If teOperationNumber.Text <> "" Then
                    GridView1.SetRowCellValue(r, "OperationNumber", teOperationNumber.Text)
                End If
            End If
            If IsDBNull(GridView1.GetRowCellValue(r, "Checked")) Then
                GridView1.SetRowCellValue(r, "Checked", False)
            End If
        Next
    End Sub

    Private Sub LayoutApply()
        For i = 0 To GridView1.Columns.Count - 1
            If GridView1.Columns(i).ColumnType = GetType(Double) Then
                GridView1.Columns(i).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                GridView1.Columns(i).DisplayFormat.FormatString = "###,###,##0.00"
                GridView1.Columns(i).SummaryItem.SetSummary(DevExpress.Data.SummaryItemType.Sum, "{0:n2}")
                GridView1.Columns(i).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                GridView1.Columns(i).DisplayFormat.FormatString = "n2"
            End If
        Next
    End Sub

    Private Sub LoadAccountBank()
        Dim dtAccountBank As New DataTable
        dtAccountBank = NewExecuteSQL("SELECT * FROM Integrador.dbo.viCuentaBancaria")
        lueAccountBank.Properties.DataSource = dtAccountBank
        lueAccountBank.Properties.DisplayMember = "CUBA_NroCuenta"
        lueAccountBank.Properties.ValueMember = "CUBA_NroCuenta"
    End Sub

    Private Sub LoadOperationType()
        Dim dtOperationType As New DataTable
        dtOperationType = NewExecuteSQL("SELECT * FROM Integrador.dbo.viTipoOperacion WHERE TIPO_Desc2 = 'E' ORDER BY TIPO_Num1  ")
        lueOperationType.Properties.DataSource = dtOperationType
        lueOperationType.Properties.DisplayMember = "TIPO_Desc1"
        lueOperationType.Properties.ValueMember = "TIPO_CodTipo"
    End Sub

    Private Sub LoadPartner()
        dtPartner = NewExecuteSQL("SELECT ENTC_Codigo_NextSoft AS code, ENTC_RazonSocial AS name, ENTC_DocIden AS ruc, ENTC_Codigo_NextSisDG, ENTC_Codigo_NextSisDC FROM viMapeoEntidad ORDER BY 2")
        'SELECT ENTC_Codigo AS code, ENTC_RazonSocial AS name, ENTC_DocIden AS ruc FROM NextSoft.dbo.Entidad WHERE ENTC_TipEnt = 'J' AND CONVERT(VARCHAR, ENTC_Codigo) <> ENTC_DocIden AND ENTC_Activo = 1 ORDER BY 2")
        luePartner.Properties.DataSource = dtPartner
        luePartner.Properties.DisplayMember = "name"
        luePartner.Properties.ValueMember = "code"
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
        vpInputs.SetValidationRule(Me.lueAccountBank, customValidationRule)
        vpInputs.SetValidationRule(Me.lueOperationType, customValidationRule)
        vpInputs.SetValidationRule(Me.luePartner, customValidationRule)
        vpInputs.SetValidationRule(Me.deDateFrom, customValidationRule)
        vpInputs.SetValidationRule(Me.cbeProcessType, customValidationRule)
        'vpInputs.SetValidationRule(Me.deDateTo, customValidationRule)
    End Sub

    Friend Function RowSelectedCount() As Integer
        Dim iChecked As Integer = 0
        For i = 0 To GridView1.RowCount - 1
            If IsDBNull(GridView1.GetRowCellValue(i, "Checked")) Then
                Continue For
            End If
            If GridView1.GetRowCellValue(i, "Checked") Then
                iChecked += 1
            End If
        Next
        Return iChecked
    End Function

    Private Sub SeleccionaFilas(caso As Integer)
        For i = 0 To GridView1.RowCount - 1
            Dim row As DataRow = GridView1.GetDataRow(i)
            If IsDBNull(row("OperationDate")) Or IsDBNull(row("OperationNumber")) Then
                Continue For
            End If
            If caso = 0 Then
                row("Checked") = True
            End If
            If caso = 1 Then
                row("Checked") = False
            End If
            If caso = 2 Then
                If row("Checked") Then
                    row("Checked") = False
                Else
                    row("Checked") = True
                End If
            End If
        Next
    End Sub

    Private Sub SeleccionaTodosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeleccionaTodosToolStripMenuItem.Click
        SeleccionaFilas(0)
    End Sub

    Private Sub DeseleccionaTodosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeseleccionaTodosToolStripMenuItem.Click
        SeleccionaFilas(1)
    End Sub

    Private Sub InvertirSelecciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InvertirSelecciónToolStripMenuItem.Click
        SeleccionaFilas(2)
    End Sub

    Private Sub PagoProveedoresFormvb_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        GridView1.SaveLayoutToRegistry(AppPath)
    End Sub

    Private Sub EnableButtons(bEnabled As Boolean)
        bbiExport.Enabled = bEnabled
        bbiVoucher.Enabled = bEnabled
    End Sub

    Private Sub gcMainData_DataSourceChanged(sender As Object, e As EventArgs) Handles gcMainData.DataSourceChanged
        EnableButtons(True)
        If GridView1.RowCount = 0 Then
            EnableButtons(False)
        End If
    End Sub

    Private Sub RepositoryItemCheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles RepositoryItemCheckEdit1.CheckedChanged
        If IsDBNull(GridView1.GetFocusedRowCellValue("OperationDate")) Or IsDBNull(GridView1.GetFocusedRowCellValue("OperationNumber")) Then
            GridView1.SetFocusedRowCellValue("Checked", False)
        End If
        GridView1.CloseEditor()
    End Sub

    Private Sub bbiVoucher_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiVoucher.ItemClick
        If Not vpInputs.Validate Then
            Return
        End If
        If RowSelectedCount = 0 Then
            DevExpress.XtraEditors.XtraMessageBox.Show("Debe seleccionar al menos un documento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Este proceso generará uno o varios asientos contables, desea continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.No Then
            Return
        End If
        CiaCode = "DG"
        bError = False
        'bbiVoucher.Enabled = False
        Try
            dtVoucherH = NewExecuteSQL("SELECT * FROM NextSis" & CiaCode & "..CON_CabAsientos (nolock) WHERE SUCR_Codigo='00'")
            dtVoucherD = NewExecuteSQL("SELECT * FROM NextSis" & CiaCode & "..CON_DetAsientos (nolock) WHERE SUCR_Codigo='00'")
            GridView1.ActiveFilterEnabled = False
            GridView1.ClearSorting()
            For r = 0 To GridView1.RowCount - 1
                Dim row As DataRow = dtQuery.Rows(r)
                If IsDBNull(GridView1.GetRowCellValue(r, "Checked")) Then
                    Continue For
                End If
                If Not GridView1.GetRowCellValue(r, "Checked") Then
                    Continue For
                End If
                If Not IsDBNull(GridView1.GetRowCellValue(r, "VoucherDG")) Or Not IsDBNull(GridView1.GetRowCellValue(r, "VoucherDC")) Then
                    Continue For
                End If
                SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)
                SplashScreenManager.Default.SetWaitFormDescription("Generando plantilla del asiento contable...")
                If cbeProcessType.SelectedIndex = 0 Then
                    SingleVoucherGenerate(row)
                    '    If Not lueAccountBank.GetColumnValue("CUBA_CtaEmprVinculada") Then
                    '        SingleProcessDG(row, 0)
                    '    Else
                    '        SingleProcessDG(row, 1)
                    '        SingleProcessDC(row, 1)
                    '    End If

                Else
                    '    BatchProcess(dtQuery)
                    '    Exit For
                End If
            Next
            GridView1.ActiveFilterEnabled = True
            SplashScreenManager.CloseForm(False)
            If bError Then
                DevExpress.XtraEditors.XtraMessageBox.Show("El proceso finalizó con errores.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                DevExpress.XtraEditors.XtraMessageBox.Show("El proceso finalizó satisfactoriamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            SplashScreenManager.CloseForm(False)
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
    End Sub

    Private Sub SingleVoucherGenerate(oRow As DataRow)
        Dim dtMovimiento, dtCtaCte As New DataTable
        Dim aResult As New ArrayList
        dtMovimiento = ExecuteSQL("SELECT TOP(0) * FROM NextSoft..CAJ_Movimiento (NOLOCK)")
        dtCtaCte = ExecuteSQL("SELECT TOP(0) * FROM NextSoft..CAJ_DetCtaCte (NOLOCK)")
        'dtCtaCte = ExecuteSQL("SELECT * FROM NextSoft..CAJ_CtaCte (NOLOCK) WHERE CCCT_Codigo=" & oRow("CCCT_Codigo").ToString)
        'Movimiento
        dtMovimiento.Rows.Add()
        dtMovimiento.Rows(0)("EMPR_Codigo") = oRow("EMPR_Codigo")
        dtMovimiento.Rows(0)("MOVI_Codigo") = 0
        dtMovimiento.Rows(0)("MOVI_CodPadre") = DBNull.Value
        dtMovimiento.Rows(0)("SUCR_Codigo") = oRow("SUCR_Codigo")
        dtMovimiento.Rows(0)("CUBA_Codigo") = lueAccountBank.GetColumnValue("CUBA_Codigo")
        dtMovimiento.Rows(0)("PLAN_Tipo") = DBNull.Value
        dtMovimiento.Rows(0)("PLAN_Codigo") = DBNull.Value
        dtMovimiento.Rows(0)("TRAN_Codigo") = DBNull.Value
        dtMovimiento.Rows(0)("TIPE_Codigo") = 2
        dtMovimiento.Rows(0)("ENTC_Codigo") = oRow("ENTC_Codigo")
        dtMovimiento.Rows(0)("TIPO_TabMOV") = "MOV"
        dtMovimiento.Rows(0)("TIPO_CodMOV") = "003" 'verificar origen
        dtMovimiento.Rows(0)("CONS_TabEST") = "EST"
        dtMovimiento.Rows(0)("CONS_CodEST") = "001"
        dtMovimiento.Rows(0)("TIPO_TabDES") = DBNull.Value
        dtMovimiento.Rows(0)("TIPO_CodDES") = DBNull.Value
        dtMovimiento.Rows(0)("TIPO_TabSerie") = DBNull.Value
        dtMovimiento.Rows(0)("TIPO_CodSerie") = DBNull.Value
        dtMovimiento.Rows(0)("MOVI_DocNumero") = DBNull.Value
        dtMovimiento.Rows(0)("MOVI_AsientoContable") = DBNull.Value
        dtMovimiento.Rows(0)("MOVI_Numero") = DBNull.Value
        dtMovimiento.Rows(0)("MOVI_FecEmision") = oRow("OperationDate")
        dtMovimiento.Rows(0)("MOVI_Concepto") = oRow("CCCT_Glosa")
        dtMovimiento.Rows(0)("MOVI_OrdenDe") = DBNull.Value
        dtMovimiento.Rows(0)("MOVI_MontoDebe") = 0
        dtMovimiento.Rows(0)("MOVI_TipoCambio") = oRow("Exchange")
        dtMovimiento.Rows(0)("MOVI_MontoHaber") = oRow("CCCT_Pendiente_Real")
        dtMovimiento.Rows(0)("MOVI_Agrupacion") = DBNull.Value
        dtMovimiento.Rows(0)("MOVI_Cheque") = False
        dtMovimiento.Rows(0)("MOVI_EstadoCheque") = "C"
        dtMovimiento.Rows(0)("MOVI_UserEntregaCheque") = DBNull.Value
        dtMovimiento.Rows(0)("MOVI_FecEntregaCheque") = DBNull.Value
        dtMovimiento.Rows(0)("MOVI_FecDiferido") = DBNull.Value
        dtMovimiento.Rows(0)("MOVI_FecDiferidoAnterior") = DBNull.Value
        dtMovimiento.Rows(0)("MOVI_ChequeImpreso") = DBNull.Value
        dtMovimiento.Rows(0)("MOVI_UserAnulacion") = DBNull.Value
        dtMovimiento.Rows(0)("MOVI_FecAnulacion") = DBNull.Value
        dtMovimiento.Rows(0)("MOVI_GlosaAnulacion") = DBNull.Value
        dtMovimiento.Rows(0)("MOVI_NroOperacion") = oRow("OperationNumber")
        dtMovimiento.Rows(0)("MOVI_NroOficina") = DBNull.Value
        dtMovimiento.Rows(0)("MOVI_Referencia") = IIf(oRow("Reference") <> "", oRow("Reference"), oRow("CCCT_Glosa"))
        dtMovimiento.Rows(0)("MOVI_FecVigencia") = DBNull.Value
        dtMovimiento.Rows(0)("MOVI_Responsable") = DBNull.Value
        dtMovimiento.Rows(0)("MOVI_MontoLimite") = DBNull.Value
        dtMovimiento.Rows(0)("MOVI_MontoDescuadre") = DBNull.Value
        dtMovimiento.Rows(0)("MOVI_FecEjecutado") = DBNull.Value
        dtMovimiento.Rows(0)("MOVI_NoNegociable") = False
        dtMovimiento.Rows(0)("MOVI_FecOperacion") = oRow("OperationDate")
        dtMovimiento.Rows(0)("TIPO_TabMDP") = "MDP"
        dtMovimiento.Rows(0)("TIPO_CodMDP") = DirectCast(lueOperationType.GetSelectedDataRow, System.Data.DataRowView).Row("Tipo_Mascara")
        dtMovimiento.Rows(0)("AUDI_UsrCrea") = "integrador"
        'Cuenta Corriente
        dtCtaCte.Rows.Add()
        dtCtaCte.Rows(0)("EMPR_Codigo") = oRow("EMPR_Codigo")
        dtCtaCte.Rows(0)("CCCT_Codigo") = oRow("CCCT_Codigo")
        dtCtaCte.Rows(0)("DCCT_Item") = 0
        dtCtaCte.Rows(0)("MOVI_Codigo") = 0
        dtCtaCte.Rows(0)("TIPO_TabMND") = oRow("TIPO_TabMND")
        dtCtaCte.Rows(0)("TIPO_CodMND") = oRow("TIPO_CodMND")
        dtCtaCte.Rows(0)("CONS_TabTDC") = "TDC"
        dtCtaCte.Rows(0)("CONS_CodTDC") = "002"
        dtCtaCte.Rows(0)("CCCT_CodReferencia") = DBNull.Value
        dtCtaCte.Rows(0)("DCCT_ItemReferencia") = DBNull.Value
        dtCtaCte.Rows(0)("DCCT_TipoPago") = DBNull.Value
        dtCtaCte.Rows(0)("DCCT_FechaTrans") = Now
        dtCtaCte.Rows(0)("DCCT_TipoCambio") = oRow("Exchange")
        dtCtaCte.Rows(0)("DCCT_MontoDebe") = IIf(oRow("TIPO_CodMND") = "001", oRow("CCCT_Pendiente_Real"), (oRow("CCCT_Pendiente_Real") * oRow("Exchange")))
        dtCtaCte.Rows(0)("DCCT_MontoHaber") = 0
        dtCtaCte.Rows(0)("DCCT_MontoDebeD") = IIf(oRow("TIPO_CodMND") = "002", oRow("CCCT_Pendiente_Real"), (oRow("CCCT_Pendiente_Real") / oRow("Exchange")))
        dtCtaCte.Rows(0)("DCCT_MontoHaberD") = 0
        dtCtaCte.Rows(0)("DCCT_PPago") = 0
        dtCtaCte.Rows(0)("DCCT_PPagoD") = 0
        dtCtaCte.Rows(0)("DCCT_PagoDetraccion") = 0
        dtCtaCte.Rows(0)("AUDI_UsrCrea") = "integrador"
        'Asiento Contable
        aResult.AddRange(oAppService.GenerateNextSoftVoucher(dtMovimiento, dtCtaCte))
        If aResult(0) = 1 Then
            oRow("VoucherDG") = aResult(1)
            oRow("VoucherDC") = aResult(2)
            oRow.AcceptChanges()
        Else
            bError = True
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, aResult(1), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ''Private Sub SingleProcessDG(oRow As DataRow, linked As Boolean)
    ''    Dim aResult As New ArrayList
    ''    Dim dDifML As Double = 0
    ''    Dim dDifME As Double = 0
    ''    Dim dtQuery As New DataTable
    ''    Dim ibMoneda As Integer = IIf(oRow("TIPO_CodMND") = "002", 0, 1)
    ''    Dim dTipoCambio As Decimal = 0
    ''    Dim sRegValues As String = ""
    ''    Dim sTipReg As String = IIf(linked, "004", "003")
    ''    dtQuery = NewExecuteSQL("select * from viMapeoInterfazContable where CuentaOrigen='" & lueAccountBank.EditValue & "'")
    ''    dsVoucher.Tables.Clear()
    ''    dtVoucherH.Rows.Clear()
    ''    dtVoucherD.Rows.Clear()
    ''    CiaCode = "DG"
    ''    'Inserta Cabecera DG
    ''    dtVoucherH.Rows.Add()
    ''    dtVoucherH.Rows(0)("SUCR_Codigo") = "01"
    ''    dtVoucherH.Rows(0)("CABA_Mes") = Format(oRow("OperationDate"), "MM")
    ''    dtVoucherH.Rows(0)("TIPO_tabReg") = "REG"
    ''    dtVoucherH.Rows(0)("CABA_ano") = Format(oRow("OperationDate"), "yyyy")
    ''    dtVoucherH.Rows(0)("TIPO_tipReg") = sTipReg
    ''    dtVoucherH.Rows(0)("CABA_NroVoucher") = "000000"
    ''    dtVoucherH.Rows(0)("CABA_Glosa") = IIf(IsDBNull(oRow("Reference")), luePartner.Text, oRow("Reference"))
    ''    dtVoucherH.Rows(0)("CABA_moneda") = ibMoneda
    ''    dtVoucherH.Rows(0)("CABA_TipoAsiento") = "A"
    ''    dtVoucherH.Rows(0)("CABA_UsrCrea") = "integrador"
    ''    dtVoucherH.Rows(0)("CABA_FecCrea") = Date.Now
    ''    'dtVoucherH.Rows(0)("CABA_UsrMod")
    ''    'dtVoucherH.Rows(0)("CABA_FecMod") = ""
    ''    'dtVoucherH.Rows(0)("TIPO_tipTRE") = ""
    ''    'dtVoucherH.Rows(0)("TIPO_tabTRE") = "TRE"
    ''    'dtVoucherH.Rows(0)("TIPO_tipregRef") = ""
    ''    'dtVoucherH.Rows(0)("TIPO_tabRegRef") = ""
    ''    'dtVoucherH.Rows(0)("CABA_anoRef") = ""
    ''    'dtVoucherH.Rows(0)("CABA_mesRef") = ""
    ''    'dtVoucherH.Rows(0)("CABA_nrovoucherRef") = ""

    ''    'Inserta Detalle DG
    ''    For r = 0 To 1
    ''        sRegValues = Format(oRow("OperationDate"), "yyyy") & "-" & Format(oRow("OperationDate"), "MM") & "-" & sTipReg & "-"
    ''        dTipoCambio = IIf(r = 0, oRow("Exchange"), GetExchange(oRow("CCCT_FechaEmision")))
    ''        dtVoucherD.Rows.Add()
    ''        dtVoucherD.Rows(r)("CABA_Ano") = Format(oRow("OperationDate"), "yyyy")
    ''        dtVoucherD.Rows(r)("DETA_Elemento") = r + 1
    ''        dtVoucherD.Rows(r)("SUCR_Codigo") = "01"
    ''        If r = 0 Then
    ''            dtVoucherD.Rows(r)("DETA_Glosa") = IIf(IsDBNull(oRow("Reference")), luePartner.Text, oRow("Reference"))
    ''        Else
    ''            dtVoucherD.Rows(r)("DETA_Glosa") = oRow("SERV_Nombre_SPA")
    ''        End If
    ''        dtVoucherD.Rows(r)("CABA_Mes") = Format(oRow("OperationDate"), "MM")
    ''        If linked Then
    ''            If r = 0 Then
    ''                dtVoucherD.Rows(r)("ENTC_Codigo") = GetPartnerCodeByRuc(CiaCode, "20600122020")
    ''            Else
    ''                dtVoucherD.Rows(r)("ENTC_Codigo") = luePartner.GetColumnValue("ENTC_Codigo_NextSisDG")
    ''            End If
    ''        Else
    ''            If r = 1 Then
    ''                dtVoucherD.Rows(r)("ENTC_Codigo") = luePartner.GetColumnValue("ENTC_Codigo_NextSisDC")
    ''            End If
    ''        End If
    ''        'dtVoucherD.Rows(r)("TIPO_tipOpe") = ""
    ''        dtVoucherD.Rows(r)("TIPO_tipOrigen") = IIf(r = 0, lueOperationType.GetColumnValue("TIPO_Desc3"), GetDocTypeSunat(oRow("TIPO_CodTDO")))
    ''        dtVoucherD.Rows(r)("CABA_NroVoucher") = "000000"
    ''        'dtVoucherD.Rows(r)("CENT_Codigo") = row(1)
    ''        dtVoucherD.Rows(r)("TIPO_tabReg") = "REG"
    ''        dtVoucherD.Rows(r)("TIPO_tipReg") = sTipReg
    ''        If r = 0 Then
    ''            dtVoucherD.Rows(r)("DETA_FecDocOrigen") = oRow("OperationDate")
    ''            dtVoucherD.Rows(r)("DETA_SerieDocOrigen") = ""
    ''            dtVoucherD.Rows(r)("DETA_NroDocOrigen") = oRow("OperationNumber")
    ''        Else
    ''            dtVoucherD.Rows(r)("DETA_FecDocOrigen") = oRow("CCCT_FechaEmision")
    ''            dtVoucherD.Rows(r)("DETA_SerieDocOrigen") = oRow("CCCT_Serie")
    ''            dtVoucherD.Rows(r)("DETA_NroDocOrigen") = oRow("CCCT_Numero")
    ''        End If
    ''        dtVoucherD.Rows(r)("CUEN_Codigo") = dtQuery.Rows(0).Item("CuentaCOntable" & (r + IIf(linked, 3, 1)).ToString)
    ''        If oRow("TIPO_CodMND") = "001" Then
    ''            dtVoucherD.Rows(r)("DETA_Debe") = IIf(r = 0, 0, oRow("CCCT_Pendiente_Real"))
    ''            dtVoucherD.Rows(r)("DETA_Haber") = IIf(r = 0, oRow("CCCT_Pendiente_Real"), 0)
    ''            dtVoucherD.Rows(r)("DETA_DebeDol") = Math.Round(dtVoucherD.Rows(r)("DETA_Debe") / dTipoCambio, 2)
    ''            dtVoucherD.Rows(r)("DETA_HaberDol") = Math.Round(dtVoucherD.Rows(r)("DETA_Haber") / dTipoCambio, 2)
    ''            dDifML += dtVoucherD.Rows(r)("DETA_Debe") - dtVoucherD.Rows(r)("DETA_Haber")
    ''            dDifME += dtVoucherD.Rows(r)("DETA_DebeDol") - dtVoucherD.Rows(r)("DETA_HaberDol")
    ''        Else
    ''            dtVoucherD.Rows(r)("DETA_DebeDol") = IIf(r = 0, 0, oRow("CCCT_Pendiente_Real"))
    ''            dtVoucherD.Rows(r)("DETA_HaberDol") = IIf(r = 0, oRow("CCCT_Pendiente_Real"), 0)
    ''            dtVoucherD.Rows(r)("DETA_Debe") = Math.Round(dtVoucherD.Rows(r)("DETA_DebeDol") * dTipoCambio, 2)
    ''            dtVoucherD.Rows(r)("DETA_Haber") = Math.Round(dtVoucherD.Rows(r)("DETA_HaberDol") * dTipoCambio, 2)
    ''            dDifML += dtVoucherD.Rows(r)("DETA_Debe") - dtVoucherD.Rows(r)("DETA_Haber")
    ''            dDifME += dtVoucherD.Rows(r)("DETA_DebeDol") - dtVoucherD.Rows(r)("DETA_HaberDol")
    ''        End If
    ''        If r = 1 Then
    ''            dtVoucherD.Rows(r)("TIPO_tabOpe") = "OPE"
    ''        End If
    ''        dtVoucherD.Rows(r)("TIPO_tabOrigen") = "TDO"
    ''        dtVoucherD.Rows(r)("DETA_referencia") = ""
    ''        dtVoucherD.Rows(r)("DETA_Amarre") = 0
    ''        dtVoucherD.Rows(r)("DETA_porcAmarre") = 0
    ''        dtVoucherD.Rows(r)("DETA_tipoAmarre") = 0
    ''        dtVoucherD.Rows(r)("DETA_numAmarre") = 0
    ''        dtVoucherD.Rows(r)("DETA_tCambio") = dTipoCambio
    ''        'dtVoucherD.Rows(r)("PPER_Numero") = 0
    ''        'dtVoucherD.Rows(r)("PART_Codigo") = ""
    ''        'dtVoucherD.Rows(r)("TIGA_codigo") = ""
    ''        'dtVoucherD.Rows(r)("DETA_FecRetencion") = ""
    ''        'dtVoucherD.Rows(r)("DETA_NroRetencion") = ""
    ''        dtVoucherD.Rows(r)("DETA_FecVcto") = IIf(r = 0, oRow("OperationDate"), oRow("CCCT_FechaEmision"))
    ''        'dtVoucherD.Rows(r)("TIPO_DocReferencia") = ""
    ''        'dtVoucherD.Rows(r)("TIPO_tabUbicaciones") = ""
    ''        'dtVoucherD.Rows(r)("TIPO_codUbicaciones") = ""
    ''        If r = 0 Then
    ''            dtVoucherD.Rows(r)("DETA_medioPago") = lueOperationType.GetColumnValue("Tipo_Mascara")
    ''        End If
    ''        dtVoucherD.Rows(r)("DETA_anexo") = IIf(r = 0, lueOperationType.GetColumnValue("Tipo_Mascara"), oRow("OV_OP"))
    ''        'dtVoucherD.Rows(r)("DETA_serieReferencia") = ""
    ''        dtVoucherD.Rows(r)("DETA_moneda") = ibMoneda
    ''        dtVoucherD.Rows(r)("DETA_observacion") = ""
    ''        If r = 1 And (dDifML <> 0 Or dDifME <> 0) Then
    ''            'Inserta Diferencia de Cambio DG
    ''            dtVoucherD.Rows.Add(dtVoucherD.Rows(r).ItemArray)
    ''            Dim dRow As DataRow = dtVoucherD.Rows(dtVoucherD.Rows.Count - 1)
    ''            dRow("DETA_Elemento") = r + 1
    ''            dRow("DETA_Glosa") = "GANANCIA/PERDIDA POR DIFERENCIA DE CAMBIO"
    ''            dRow("TIPO_tipOrigen") = "000"
    ''            dRow("ENTC_Codigo") = DBNull.Value
    ''            dRow("CENT_Codigo") = "03.02"
    ''            dRow("DETA_FecDocOrigen") = Today.Date
    ''            dRow("DETA_SerieDocOrigen") = ""
    ''            dRow("DETA_NroDocOrigen") = ""
    ''            dRow("TIPO_tabOpe") = ""
    ''            dRow("DETA_Debe") = IIf(dDifML < 0, Math.Abs(dDifML), 0)
    ''            dRow("DETA_Haber") = IIf(dDifML >= 0, Math.Abs(dDifML), 0)
    ''            dRow("DETA_DebeDol") = IIf(dDifME < 0, Math.Abs(dDifME), 0)
    ''            dRow("DETA_HaberDol") = IIf(dDifME >= 0, Math.Abs(dDifME), 0)
    ''            dRow("CUEN_Codigo") = IIf(dRow("DETA_Debe") <> 0 Or dRow("DETA_DebeDol") <> 0, My.Settings.ExchangeRateCredit, My.Settings.ExchangeRateDebit)
    ''            dRow("DETA_tCambio") = 0
    ''            dRow("DETA_FecVcto") = Today.Date
    ''            dRow("DETA_anexo") = ""
    ''            dRow.AcceptChanges()
    ''        End If
    ''    Next
    ''    If dtVoucherH.Rows.Count > 0 Then
    ''        dsVoucher.Tables.Add(dtVoucherH.Copy)
    ''        dsVoucher.Tables(0).TableName = "VoucherH"
    ''        dsVoucher.Tables.Add(dtVoucherD.Copy)
    ''        dsVoucher.Tables(1).TableName = "VoucherD"
    ''        SplashScreenManager.Default.SetWaitFormDescription("Insertando el nuevo asiento contable...")
    ''        aResult.AddRange(oAppService.GenerateVoucher(CiaCode, dsVoucher))
    ''        If aResult(0) = 1 Then
    ''            oRow("VoucherDG") = sRegValues & aResult(1)
    ''            oRow.AcceptChanges()
    ''        End If
    ''    End If
    ''End Sub

    ''Private Sub SingleProcessDC(oRow As DataRow, linked As Boolean)
    ''    Dim aResult As New ArrayList
    ''    Dim dDifML As Double = 0
    ''    Dim dDifME As Double = 0
    ''    Dim dtQuery As New DataTable
    ''    Dim ibMoneda As Integer = IIf(oRow("TIPO_CodMND") = "002", 0, 1)
    ''    Dim dTipoCambio As Decimal = 0
    ''    Dim sRegValues As String = ""
    ''    Dim sTipReg As String = "003"
    ''    dtQuery = NewExecuteSQL("select * from viMapeoInterfazContable where CuentaOrigen='" & lueAccountBank.EditValue & "'")
    ''    dsVoucher.Tables.Clear()
    ''    dtVoucherH.Rows.Clear()
    ''    dtVoucherD.Rows.Clear()
    ''    CiaCode = "DC"
    ''    'Inserta Cabecera DC
    ''    dtVoucherH.Rows.Add()
    ''    dtVoucherH.Rows(0)("SUCR_Codigo") = "01"
    ''    dtVoucherH.Rows(0)("CABA_Mes") = Format(oRow("OperationDate"), "MM")
    ''    dtVoucherH.Rows(0)("TIPO_tabReg") = "REG"
    ''    dtVoucherH.Rows(0)("CABA_ano") = Format(oRow("OperationDate"), "yyyy")
    ''    dtVoucherH.Rows(0)("TIPO_tipReg") = sTipReg
    ''    dtVoucherH.Rows(0)("CABA_NroVoucher") = "000000"
    ''    dtVoucherH.Rows(0)("CABA_Glosa") = IIf(IsDBNull(oRow("Reference")), luePartner.Text, oRow("Reference"))
    ''    dtVoucherH.Rows(0)("CABA_moneda") = ibMoneda
    ''    dtVoucherH.Rows(0)("CABA_TipoAsiento") = "A"
    ''    dtVoucherH.Rows(0)("CABA_UsrCrea") = "integrador"
    ''    dtVoucherH.Rows(0)("CABA_FecCrea") = Date.Now

    ''    'Inserta Detalle DC
    ''    For r = 0 To 1
    ''        sRegValues = Format(oRow("OperationDate"), "yyyy") & "-" & Format(oRow("OperationDate"), "MM") & "-003-"
    ''        dTipoCambio = oRow("Exchange")
    ''        dtVoucherD.Rows.Add()
    ''        dtVoucherD.Rows(r)("CABA_Ano") = Format(oRow("OperationDate"), "yyyy")
    ''        dtVoucherD.Rows(r)("DETA_Elemento") = r + 1
    ''        dtVoucherD.Rows(r)("SUCR_Codigo") = "01"
    ''        dtVoucherD.Rows(r)("DETA_Glosa") = IIf(IsDBNull(oRow("Reference")), luePartner.Text, oRow("Reference"))
    ''        dtVoucherD.Rows(r)("CABA_Mes") = Format(oRow("OperationDate"), "MM")
    ''        If r = 1 Then
    ''            dtVoucherD.Rows(r)("ENTC_Codigo") = GetPartnerCodeByRuc(CiaCode, "20516667550")
    ''        End If
    ''        dtVoucherD.Rows(r)("TIPO_tipOrigen") = lueOperationType.GetColumnValue("TIPO_Desc3")
    ''        dtVoucherD.Rows(r)("CABA_NroVoucher") = "000000"
    ''        dtVoucherD.Rows(r)("TIPO_tabReg") = "REG"
    ''        dtVoucherD.Rows(r)("TIPO_tipReg") = sTipReg
    ''        dtVoucherD.Rows(r)("DETA_FecDocOrigen") = oRow("OperationDate")
    ''        dtVoucherD.Rows(r)("DETA_SerieDocOrigen") = ""
    ''        dtVoucherD.Rows(r)("DETA_NroDocOrigen") = oRow("OperationNumber")
    ''        dtVoucherD.Rows(r)("CUEN_Codigo") = dtQuery.Rows(0).Item("CuentaCOntable" & (r + 1).ToString)
    ''        If oRow("TIPO_CodMND") = "001" Then
    ''            dtVoucherD.Rows(r)("DETA_Debe") = IIf(r = 0, 0, oRow("CCCT_Pendiente_Real"))
    ''            dtVoucherD.Rows(r)("DETA_Haber") = IIf(r = 0, oRow("CCCT_Pendiente_Real"), 0)
    ''            dtVoucherD.Rows(r)("DETA_DebeDol") = Math.Round(dtVoucherD.Rows(r)("DETA_Debe") / dTipoCambio, 2)
    ''            dtVoucherD.Rows(r)("DETA_HaberDol") = Math.Round(dtVoucherD.Rows(r)("DETA_Haber") / dTipoCambio, 2)
    ''            dDifML += dtVoucherD.Rows(r)("DETA_Debe") - dtVoucherD.Rows(r)("DETA_Haber")
    ''            dDifME += dtVoucherD.Rows(r)("DETA_DebeDol") - dtVoucherD.Rows(r)("DETA_HaberDol")
    ''        Else
    ''            dtVoucherD.Rows(r)("DETA_DebeDol") = IIf(r = 0, 0, oRow("CCCT_Pendiente_Real"))
    ''            dtVoucherD.Rows(r)("DETA_HaberDol") = IIf(r = 0, oRow("CCCT_Pendiente_Real"), 0)
    ''            dtVoucherD.Rows(r)("DETA_Debe") = Math.Round(dtVoucherD.Rows(r)("DETA_DebeDol") * dTipoCambio, 2)
    ''            dtVoucherD.Rows(r)("DETA_Haber") = Math.Round(dtVoucherD.Rows(r)("DETA_HaberDol") * dTipoCambio, 2)
    ''            dDifML += dtVoucherD.Rows(r)("DETA_Debe") - dtVoucherD.Rows(r)("DETA_Haber")
    ''            dDifME += dtVoucherD.Rows(r)("DETA_DebeDol") - dtVoucherD.Rows(r)("DETA_HaberDol")
    ''        End If
    ''        If r = 1 Then
    ''            dtVoucherD.Rows(r)("TIPO_tabOpe") = "OPE"
    ''        End If
    ''        dtVoucherD.Rows(r)("TIPO_tabOrigen") = "TDO"
    ''        dtVoucherD.Rows(r)("DETA_referencia") = ""
    ''        dtVoucherD.Rows(r)("DETA_Amarre") = 0
    ''        dtVoucherD.Rows(r)("DETA_porcAmarre") = 0
    ''        dtVoucherD.Rows(r)("DETA_tipoAmarre") = 0
    ''        dtVoucherD.Rows(r)("DETA_numAmarre") = 0
    ''        dtVoucherD.Rows(r)("DETA_tCambio") = oRow("Exchange")
    ''        dtVoucherD.Rows(r)("DETA_FecVcto") = oRow("OperationDate")
    ''        If r = 0 Then
    ''            dtVoucherD.Rows(r)("DETA_medioPago") = lueOperationType.GetColumnValue("Tipo_Mascara")
    ''        End If
    ''        dtVoucherD.Rows(r)("DETA_anexo") = ""
    ''        dtVoucherD.Rows(r)("DETA_moneda") = ibMoneda
    ''        dtVoucherD.Rows(r)("DETA_observacion") = ""
    ''        If r = 1 And (dDifML <> 0 Or dDifME <> 0) Then
    ''            'Inserta Diferencia de Cambio DC
    ''            dtVoucherD.Rows.Add(dtVoucherD.Rows(r).ItemArray)
    ''            Dim dRow As DataRow = dtVoucherD.Rows(dtVoucherD.Rows.Count - 1)
    ''            dRow("DETA_Elemento") = r + 1
    ''            dRow("DETA_Glosa") = "GANANCIA/PERDIDA POR DIFERENCIA DE CAMBIO"
    ''            dRow("TIPO_tipOrigen") = "000"
    ''            dRow("ENTC_Codigo") = DBNull.Value
    ''            dRow("CENT_Codigo") = "03.02"
    ''            dRow("DETA_FecDocOrigen") = Today.Date
    ''            dRow("DETA_SerieDocOrigen") = ""
    ''            dRow("DETA_NroDocOrigen") = ""
    ''            dRow("TIPO_tabOpe") = ""
    ''            dRow("DETA_Debe") = IIf(dDifML < 0, Math.Abs(dDifML), 0)
    ''            dRow("DETA_Haber") = IIf(dDifML >= 0, Math.Abs(dDifML), 0)
    ''            dRow("DETA_DebeDol") = IIf(dDifME < 0, Math.Abs(dDifME), 0)
    ''            dRow("DETA_HaberDol") = IIf(dDifME >= 0, Math.Abs(dDifME), 0)
    ''            dRow("CUEN_Codigo") = IIf(dRow("DETA_Debe") <> 0 Or dRow("DETA_DebeDol") <> 0, My.Settings.ExchangeRateCredit, My.Settings.ExchangeRateDebit)
    ''            dRow("DETA_tCambio") = 0
    ''            dRow("DETA_FecVcto") = Today.Date
    ''            dRow("DETA_anexo") = ""
    ''            dRow.AcceptChanges()
    ''        End If
    ''    Next
    ''    If dtVoucherH.Rows.Count > 0 Then
    ''        dsVoucher.Tables.Add(dtVoucherH.Copy)
    ''        dsVoucher.Tables(0).TableName = "VoucherH"
    ''        dsVoucher.Tables.Add(dtVoucherD.Copy)
    ''        dsVoucher.Tables(1).TableName = "VoucherD"
    ''        SplashScreenManager.Default.SetWaitFormDescription("Insertando el nuevo asiento contable...")
    ''        aResult.AddRange(oAppService.GenerateVoucher(CiaCode, dsVoucher))
    ''        If aResult(0) = 1 Then
    ''            oRow("VoucherDC") = sRegValues & aResult(1)
    ''            oRow.AcceptChanges()
    ''        End If
    ''    End If
    ''End Sub

    'Private Sub BatchProcess(oDataTable As DataTable)
    '    Dim aResult As New ArrayList
    '    Dim dDifML As Double = 0
    '    Dim dDifME As Double = 0
    '    Dim dtQuery As New DataTable
    '    Dim dTipoCambio As Decimal = 0
    '    Dim sRegValues As String = ""
    '    Dim sTipReg As String = "003"
    '    dtQuery = NewExecuteSQL("select * from viMapeoInterfazContable where CuentaOrigen='" & lueAccountBank.EditValue & "'")
    '    dsVoucher.Tables.Clear()
    '    dtVoucherH.Rows.Clear()
    '    dtVoucherD.Rows.Clear()
    '    CiaCode = "DG"
    '    For r = 0 To GridView1.RowCount - 1
    '        Dim oRow As DataRow = oDataTable.Rows(r)
    '        Dim ibMoneda As Integer = IIf(oRow("TIPO_CodMND") = "002", 0, 1)
    '        If Not GridView1.GetRowCellValue(r, "Checked") Then
    '            Continue For
    '        End If
    '        SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)
    '        SplashScreenManager.Default.SetWaitFormDescription("Generando plantilla del asiento contable...")
    '        If r = 0 Then
    '            'Inserta Cabecera DC
    '            dtVoucherH.Rows.Add()
    '            dtVoucherH.Rows(0)("SUCR_Codigo") = "01"
    '            dtVoucherH.Rows(0)("CABA_Mes") = Format(oRow("OperationDate"), "MM")
    '            dtVoucherH.Rows(0)("TIPO_tabReg") = "REG"
    '            dtVoucherH.Rows(0)("CABA_ano") = Format(oRow("OperationDate"), "yyyy")
    '            dtVoucherH.Rows(0)("TIPO_tipReg") = sTipReg
    '            dtVoucherH.Rows(0)("CABA_NroVoucher") = "000000"
    '            dtVoucherH.Rows(0)("CABA_Glosa") = IIf(IsDBNull(oRow("Reference")), luePartner.Text, oRow("Reference"))
    '            dtVoucherH.Rows(0)("CABA_moneda") = ibMoneda
    '            dtVoucherH.Rows(0)("CABA_TipoAsiento") = "A"
    '            dtVoucherH.Rows(0)("CABA_UsrCrea") = "integrador"
    '            dtVoucherH.Rows(0)("CABA_FecCrea") = Date.Now
    '        End If
    '        'Inserta Detalle DC
    '        sRegValues = Format(oRow("OperationDate"), "yyyy") & "-" & Format(oRow("OperationDate"), "MM") & "-003-"
    '        dTipoCambio = IIf(r = 0, oRow("Exchange"), oRow("CCCT_TipoCambio"))
    '        dtVoucherD.Rows.Add()
    '        dtVoucherD.Rows(r)("CABA_Ano") = Format(oRow("OperationDate"), "yyyy")
    '        dtVoucherD.Rows(r)("DETA_Elemento") = r + 1
    '        dtVoucherD.Rows(r)("SUCR_Codigo") = "01"
    '        dtVoucherD.Rows(r)("DETA_Glosa") = IIf(IsDBNull(oRow("Reference")), luePartner.Text, oRow("Reference"))
    '        dtVoucherD.Rows(r)("CABA_Mes") = Format(oRow("OperationDate"), "MM")
    '        If r = 1 Then
    '            dtVoucherD.Rows(r)("ENTC_Codigo") = Format(oRow("ENTC_Codigo"), "000000000000")
    '        End If
    '        dtVoucherD.Rows(r)("TIPO_tipOrigen") = IIf(r = 0, lueOperationType.GetColumnValue("TIPO_Desc3"), oRow("TIPO_CodTDO"))
    '        dtVoucherD.Rows(r)("CABA_NroVoucher") = "000000"
    '        dtVoucherD.Rows(r)("TIPO_tabReg") = "REG"
    '        dtVoucherD.Rows(r)("TIPO_tipReg") = sTipReg
    '        If r = 0 Then
    '            dtVoucherD.Rows(r)("DETA_FecDocOrigen") = oRow("OperationDate")
    '            dtVoucherD.Rows(r)("DETA_SerieDocOrigen") = ""
    '            dtVoucherD.Rows(r)("DETA_NroDocOrigen") = oRow("OperationNumber")
    '        Else
    '            dtVoucherD.Rows(r)("DETA_FecDocOrigen") = oRow("CCCT_FechaEmision")
    '            dtVoucherD.Rows(r)("DETA_SerieDocOrigen") = oRow("CCCT_Serie")
    '            dtVoucherD.Rows(r)("DETA_NroDocOrigen") = oRow("CCCT_Numero")
    '        End If
    '        dtVoucherD.Rows(r)("CUEN_Codigo") = dtQuery.Rows(0).Item("CuentaCOntable2")
    '        If oRow("TIPO_CodMND") = "001" Then
    '            dtVoucherD.Rows(r)("DETA_Debe") = IIf(r = 0, 0, oRow("CCCT_Pendiente_Real"))
    '            dtVoucherD.Rows(r)("DETA_Haber") = IIf(r = 0, oRow("CCCT_Pendiente_Real"), 0)
    '            dtVoucherD.Rows(r)("DETA_DebeDol") = Math.Round(dtVoucherD.Rows(r)("DETA_Debe") / dTipoCambio, 2)
    '            dtVoucherD.Rows(r)("DETA_HaberDol") = Math.Round(dtVoucherD.Rows(r)("DETA_Haber") / dTipoCambio, 2)
    '            dDifML += dtVoucherD.Rows(r)("DETA_Debe") - dtVoucherD.Rows(r)("DETA_Haber")
    '            dDifME += dtVoucherD.Rows(r)("DETA_DebeDol") - dtVoucherD.Rows(r)("DETA_HaberDol")
    '        Else
    '            dtVoucherD.Rows(r)("DETA_Debe") = IIf(r = 0, 0, oRow("CCCT_Pendiente_Real"))
    '            dtVoucherD.Rows(r)("DETA_Haber") = IIf(r = 0, oRow("CCCT_Pendiente_Real"), 0)
    '            dtVoucherD.Rows(r)("DETA_DebeDol") = Math.Round(dtVoucherD.Rows(r)("DETA_Debe") * dTipoCambio, 2)
    '            dtVoucherD.Rows(r)("DETA_HaberDol") = Math.Round(dtVoucherD.Rows(r)("DETA_Haber") * dTipoCambio, 2)
    '            dDifML += dtVoucherD.Rows(r)("DETA_Debe") - dtVoucherD.Rows(r)("DETA_Haber")
    '            dDifME += dtVoucherD.Rows(r)("DETA_DebeDol") - dtVoucherD.Rows(r)("DETA_HaberDol")
    '        End If
    '        If r = 1 Then
    '            dtVoucherD.Rows(r)("TIPO_tabOpe") = "OPE"
    '        End If
    '        dtVoucherD.Rows(r)("TIPO_tabOrigen") = "TDO"
    '        dtVoucherD.Rows(r)("DETA_referencia") = ""
    '        dtVoucherD.Rows(r)("DETA_Amarre") = 0
    '        dtVoucherD.Rows(r)("DETA_porcAmarre") = 0
    '        dtVoucherD.Rows(r)("DETA_tipoAmarre") = 0
    '        dtVoucherD.Rows(r)("DETA_numAmarre") = 0
    '        dtVoucherD.Rows(r)("DETA_tCambio") = IIf(r = 0, oRow("Exchange"), oRow("CCCT_TipoCambio"))
    '        dtVoucherD.Rows(r)("DETA_FecVcto") = IIf(r = 0, oRow("OperationDate"), oRow("CCCT_FechaEmision"))
    '        If r = 0 Then
    '            dtVoucherD.Rows(r)("DETA_medioPago") = lueOperationType.GetColumnValue("Tipo_Mascara")
    '        End If
    '        dtVoucherD.Rows(r)("DETA_anexo") = ""
    '        dtVoucherD.Rows(r)("DETA_moneda") = ibMoneda
    '        dtVoucherD.Rows(r)("DETA_observacion") = ""
    '    Next
    '    If dDifML <> 0 Or dDifME <> 0 Then
    '        'Inserta Diferencia de Cambio DC
    '        dtVoucherD.Rows.Add(dtVoucherD.Rows(dtVoucherD.Rows.Count - 2).ItemArray)
    '        Dim dRow As DataRow = dtVoucherD.Rows(dtVoucherD.Rows.Count - 1)
    '        dRow("DETA_Elemento") = dtVoucherD.Rows.Count
    '        dRow("DETA_Glosa") = "GANANCIA/PERDIDA POR DIFERENCIA DE CAMBIO"
    '        dRow("TIPO_tipOrigen") = "000"
    '        dRow("ENTC_Codigo") = DBNull.Value
    '        dRow("CENT_Codigo") = "03.02"
    '        dRow("DETA_FecDocOrigen") = Today.Date
    '        dRow("DETA_SerieDocOrigen") = ""
    '        dRow("DETA_NroDocOrigen") = ""
    '        dRow("TIPO_tabOpe") = ""
    '        dRow("DETA_Debe") = IIf(dDifML < 0, Math.Abs(dDifML), 0)
    '        dRow("DETA_Haber") = IIf(dDifML >= 0, Math.Abs(dDifML), 0)
    '        dRow("DETA_DebeDol") = IIf(dDifME < 0, Math.Abs(dDifME), 0)
    '        dRow("DETA_HaberDol") = IIf(dDifME >= 0, Math.Abs(dDifME), 0)
    '        dRow("CUEN_Codigo") = IIf(dRow("DETA_Debe") <> 0 Or dRow("DETA_DebeDol") <> 0, My.Settings.ExchangeRateDebit, My.Settings.ExchangeRateCredit)
    '        dRow("DETA_tCambio") = 0
    '        dRow("DETA_FecVcto") = Today.Date
    '        dRow.AcceptChanges()
    '    End If
    '    If dtVoucherH.Rows.Count > 0 Then
    '        dsVoucher.Tables.Add(dtVoucherH.Copy)
    '        dsVoucher.Tables(0).TableName = "VoucherH"
    '        dsVoucher.Tables.Add(dtVoucherD.Copy)
    '        dsVoucher.Tables(1).TableName = "VoucherD"
    '        SplashScreenManager.Default.SetWaitFormDescription("Insertando el nuevo asiento contable...")
    '        aResult.AddRange(oAppService.GenerateVoucher(CiaCode, dsVoucher))
    '        For Each row As DataRow In oDataTable.Rows
    '            row("VoucherDG") = sRegValues & aResult(1)
    '        Next
    '    End If

    'End Sub

    Friend Function GetExchange(RefDate As Date) As Decimal
        Dim dResult As Decimal = 0
        Dim dtResult As New DataTable
        Try
            dtResult = NewExecuteSQL("select TIPC_VentaOfi from NextSisDG.dbo.TipoCambio (nolock) where TIPC_Fecha='" & Format(RefDate, "yyyyMMdd") & "'")
            If dtResult.Rows.Count > 0 Then
                dResult = dtResult(0)(0)
            End If
        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dResult
    End Function

    Private Sub RepositoryItemDateEdit1_Leave(sender As Object, e As EventArgs) Handles RepositoryItemDateEdit1.Leave
        GridView1.CloseEditor()
        If IsDBNull(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "OperationDate")) Then
            Return
        End If
        GridView1.SetFocusedRowCellValue("Exchange", GetExchange(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "OperationDate")))
        If Not IsDBNull(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "OperationDate")) Then
            GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "Checked", True)
        End If
    End Sub

    Private Sub ActualizarDatosDeLaOperaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarDatosDeLaOperaciónToolStripMenuItem.Click
        SetOperationValues()
    End Sub

End Class
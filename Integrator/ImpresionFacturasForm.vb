Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.XtraGrid.Views.Grid
Imports CrystalDecisions.Windows.Forms

Public Class ImpresionFacturasForm
    Dim dtPrint As New DataTable
    Dim dsMain As New dsSunat

    Private Sub ImpresionFacturasForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtPrint = dsMain.Tables("Facturacion")
        Try
            LoadInputValidations()
            LoadCompany()
            dtPrint.Rows.Add()
            gcItems.DataSource = dtPrint
        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadCompany()
        dtCompany = GetCompaniesList("NEXTSIS")
        lueCompany.Properties.DataSource = dtCompany
        lueCompany.Properties.DisplayMember = "CompanyName"
        lueCompany.Properties.ValueMember = "CompanyCode"
    End Sub

    Private Sub LoadPartner()
        dtPartner = GetPartnersList(GetDBCia(lueCompany.EditValue))
        luePartner.Properties.DataSource = dtPartner
        luePartner.Properties.DisplayMember = "name"
        luePartner.Properties.ValueMember = "code"
    End Sub

    Private Sub LoadPartnerAddress(partner As String)
        Dim dtAddresses As New DataTable
        dtAddresses = GetPartnerAddressesList(GetDBCia(lueCompany.EditValue), partner)
        lueAddress.Properties.DataSource = dtAddresses
        lueAddress.Properties.DisplayMember = "address"
        lueAddress.Properties.ValueMember = "address"
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
        vpInputs.SetValidationRule(Me.deDate, customValidationRule)
        vpInputs.SetValidationRule(Me.luePartner, customValidationRule)
        vpInputs.SetValidationRule(Me.lueAddress, customValidationRule)
    End Sub

    Private Sub bbiPrint_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiPrint.ItemClick
        If Not vpInputs.Validate Then
            Return
        End If
        If GridView1.RowCount = 0 Then
            DevExpress.XtraEditors.XtraMessageBox.Show("Por favor ingrese al menos un registro en el detalle.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Dim drPrint As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim sFecha As String = deDate.DateTime.Day.ToString & " de " & MonthName(deDate.DateTime.Month) & " de " & deDate.DateTime.Year.ToString
        Try
            If rgFormat.SelectedIndex = 0 Then
                drPrint.FileName = IO.Directory.GetCurrentDirectory & "\Reports\ImpresionFactura.rpt"
            Else
                drPrint.FileName = IO.Directory.GetCurrentDirectory & "\Reports\ImpresionBoleta.rpt"
            End If
            drPrint.SetDataSource(dtPrint)
            drPrint.SetParameterValue(0, sFecha)
            drPrint.SetParameterValue(1, luePartner.Text)
            drPrint.SetParameterValue(2, lueAddress.Text)
            drPrint.SetParameterValue(3, luePartner.GetColumnValue("ruc"))
            drPrint.SetParameterValue(4, rgCurrency.EditValue)
            CrystalReportViewer.ReportSource = drPrint
        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub bbiClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiClose.ItemClick
        Close()
    End Sub

    Private Sub lueCompany_EditValueChanged(sender As Object, e As EventArgs) Handles lueCompany.EditValueChanged
        LoadPartner()
    End Sub

    Private Sub lueAddress_Enter(sender As Object, e As EventArgs) Handles lueAddress.Enter
        LoadPartnerAddress(luePartner.EditValue)
    End Sub

    Private Sub gcItems_EmbeddedNavigator_ButtonClick(sender As Object, e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs) Handles gcItems.EmbeddedNavigator.ButtonClick
        If e.Button.Tag = 0 Then
            RepositoryItemTextEdit1.AllowFocused = True
            GridView1.AddNewRow()
        ElseIf e.Button.Tag = 1 Then
            GridView1.DeleteSelectedRows()
        End If
    End Sub

    'Private Sub GridView1_ValidateRow(sender As Object, e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GridView1.ValidateRow
    '    Dim NewRow As Boolean = True
    '    For c = 0 To dtPrint.Columns.Count - 1
    '        If dtPrint.Rows(e.RowHandle)(c).ToString = "" Or dtPrint.Rows(e.RowHandle)(c).ToString = "0" Then
    '            NewRow = False
    '        End If
    '    Next
    '    If NewRow Then
    '        dtPrint.Rows.Add()
    '    End If
    'End Sub

    'Private Sub GridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles GridView1.KeyDown
    '    Validate()
    '    If GridView1.FocusedRowHandle < 0 Then
    '        Return
    '    End If
    '    Dim NewRow As Boolean = True
    '    Dim DelRow As Boolean = True
    '    For c = 0 To dtPrint.Columns.Count - 1
    '        If dtPrint.Rows(GridView1.FocusedRowHandle)(c).ToString = "" Then
    '            NewRow = False
    '        End If
    '        If dtPrint.Rows(GridView1.FocusedRowHandle)(c).ToString <> "" Then
    '            DelRow = False
    '        End If
    '    Next
    '    If NewRow Then
    '        GridView1.FocusedColumn = GridView1.VisibleColumns(0)
    '        GridView1.ShowEditor()
    '        dtPrint.Rows.Add()
    '    End If
    '    If DelRow Then
    '        dtPrint.Rows(GridView1.FocusedRowHandle).Delete()
    '    End If
    'End Sub
End Class
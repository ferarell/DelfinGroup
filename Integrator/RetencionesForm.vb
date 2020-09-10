Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.XtraBars
Imports DevExpress.XtraSplashScreen

Public Class RetencionesForm
    Dim dtRetenciones As New DataTable
    Dim oAppService As New AppService.DelfinServiceClient

    Private Sub RetencionesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tePeriod.Text = Year(Now).ToString & Format(Month(Now), "00")
        Try
            BarButtonEnabled()
            LoadCompany()
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
        vpInputs.SetValidationRule(Me.tePeriod, customValidationRule)
    End Sub

    Private Sub BarButtonEnabled()
        For Each bbi As BarButtonItemLink In brBarraAcciones.ItemLinks
            If bbi.Item.Tag = 1 Then
                bbi.Item.Enabled = False
                If GridView1.RowCount > 0 Then
                    bbi.Item.Enabled = True
                End If
            End If
        Next
    End Sub

    Private Sub bbiInsert_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiInsert.ItemClick

    End Sub

    Private Sub bbiDelete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiDelete.ItemClick

    End Sub

    Private Sub bbiQuery_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiQuery.ItemClick
        dtRetenciones.Clear()
        dtRetenciones = ExecuteSQL("SELECT * FROM Integrador..Retenciones (NOLOCK) WHERE Periodo='" & tePeriod.Text & "'")
        gcMainData.DataSource = dtRetenciones
    End Sub

    Private Sub bbiUpdate_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiUpdate.ItemClick

    End Sub

    Private Sub bbiExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExport.ItemClick

    End Sub

    Private Sub bbiClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiClose.ItemClick
        Close()
    End Sub
End Class
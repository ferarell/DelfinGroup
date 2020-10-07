Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraSplashScreen
Imports Microsoft.Office.Interop
Imports DevExpress.XtraWaitForm
Imports System.Runtime.InteropServices
Imports System.Windows
Imports System.IO
Imports DevExpress.XtraGrid.Views.Grid
Imports ApplicationForm.AppService

Public Class EventManagementForm

    Private WithEvents richEditControl As New DevExpress.XtraRichEdit.RichEditControl
    Dim oAppService As New AppService.DelfinServiceClient
    Dim oMasterDataList As New MasterDataList
    Public AppUser As String = "sistemas"
    Public bInsert As Boolean = False
    Dim oEvento As New COM_Det_Cotizacion_OV_EventosTareas_BE

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        'DevExpress.UserSkins.BonusSkins.Register()
        'DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Blue")

    End Sub

    Private Sub EventManagementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        deDateTime.EditValue = DateTime.Now
        SplitContainerControl3.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
        LoadShipline()
        LoadVoyage()
        LoadEvent()
        ButtonEnabled(Nothing)
        If bInsert Then
            lueShipline.Enabled = False
            lueVoyage.Enabled = False
            teHBL.Enabled = False
            bbiSearch.PerformClick()
            bbiInsert.PerformClick()
            bbiInsert.Enabled = False
            bbiEdit.Enabled = False
            bbiDelete.Enabled = False
            bbiSearch.Enabled = False
            bbiClose.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        End If
    End Sub

    Private Sub LoadShipline()
        lueShipline.Properties.DataSource = GetShipline(Nothing)
        lueShipline.Properties.DisplayMember = "DescripcionTransportista"
        lueShipline.Properties.ValueMember = "CodigoTransportista"
    End Sub

    Private Sub LoadVoyage()
        lueVoyage.Properties.DataSource = GetVoyage(Nothing, lueShipline.EditValue)
        lueVoyage.Properties.DisplayMember = "NombreNave"
        lueVoyage.Properties.ValueMember = "CodigoViaje"
    End Sub

    Private Sub LoadEvent()
        lueEvent.Properties.DataSource = oMasterDataList.LoadMasterData("Event", Nothing)
        lueEvent.Properties.DisplayMember = "DescripcionEvento"
        lueEvent.Properties.ValueMember = "CodigoEvento"
    End Sub

    Private Sub lueShipline_Properties_EditValueChanged(sender As Object, e As EventArgs) Handles lueShipline.Properties.EditValueChanged
        LoadVoyage()
    End Sub

    Private Sub lueVoyage_EditValueChanged(sender As Object, e As EventArgs) Handles lueVoyage.EditValueChanged
        teVoyage.Text = lueVoyage.GetColumnValue("Viaje_Vuelo")
    End Sub

    Private Sub bbiSearch_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSearch.ItemClick
        LoadInputValidations("Search")
        SplitContainerControl3.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
        gcHblList.Enabled = True
        gcEventList.Enabled = True
        If Not vpInputs.Validate Then
            Return
        End If
        ButtonEnabled(Nothing)
        gcHblList.DataSource = Nothing
        gcEventList.DataSource = Nothing
        SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)
        SplashScreenManager.Default.SetWaitFormDescription("Consultando datos")
        Try
            Dim dtQuery As New DataTable
            Dim sQuery As String = ""
            sQuery += "EXEC NextSoft.dgp.paObtieneListaOvPorFiltros "
            If Not lueShipline.EditValue Is Nothing Then
                sQuery += lueShipline.EditValue.ToString
            Else
                sQuery += "NULL"
            End If
            If Not lueVoyage.EditValue Is Nothing Then
                sQuery += "," & lueVoyage.EditValue.ToString & ", NULL"
            Else
                sQuery += ", NULL, NULL"
            End If
            If teHBL.Text.Trim <> "" Then
                sQuery += ",'" & teHBL.Text.Trim & "'"
            Else
                sQuery += ", NULL"
            End If
            dtQuery = oAppService.ExecuteSQL(sQuery).Tables(0)
            'dtQuery.Columns.Add("Enviado", GetType(Boolean)).DefaultValue = False
            'GridView1.Columns.Item("CCOT_EnviaAvisoLlegada").OptionsColumn.ReadOnly = True
            GridView1.BestFitMaxRowCount = 10
            GridView1.BestFitColumns()
            gcHblList.DataSource = dtQuery
            ButtonEnabled(Nothing)
        Catch ex As Exception
            SplashScreenManager.CloseForm(False)
        End Try
        SplashScreenManager.CloseForm(False)
    End Sub

    Private Sub bbiRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiRefresh.ItemClick
        bbiSearch.PerformClick()
    End Sub

    Private Sub LoadInputValidations(ValType As String)
        Validate()
        Dim containsValidationRule As New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        containsValidationRule.ConditionOperator = ConditionOperator.IsNotBlank
        containsValidationRule.ErrorText = "Asigne un valor."
        containsValidationRule.ErrorType = ErrorType.Critical
        Dim customValidationRule As New CustomValidationRule()
        customValidationRule.ErrorText = "Valor obligatorio."
        customValidationRule.ErrorType = ErrorType.Critical
        vpInputs.SetValidationRule(Me.lueVoyage, Nothing)
        vpInputs.SetValidationRule(Me.lueEvent, Nothing)
        vpInputs.SetValidationRule(Me.deDateTime, Nothing)
        If ValType = "Search" Then
            If teHBL.Text = "" Then
                vpInputs.SetValidationRule(Me.lueVoyage, customValidationRule)
            End If
        End If
        If ValType = "Save" Then
            vpInputs.SetValidationRule(Me.lueEvent, customValidationRule)
            vpInputs.SetValidationRule(Me.deDateTime, customValidationRule)
        End If
    End Sub

    Private Sub bbiExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExport.ItemClick
        If gcHblList.IsFocused Then
            ExportToExcel(gcHblList)
        ElseIf gcEventList.IsFocused Then
            ExportToExcel(gcEventList)
        End If
    End Sub

    Private Sub bbiOVQuery_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiOVQuery.ItemClick
        Dim OVForm As New VerticalViewerOVForm
        OVForm.sHBL = GridView1.GetFocusedRowCellValue("HBL")
        OVForm.ShowDialog()
    End Sub

    Private Sub bbiInsert_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiInsert.ItemClick
        SplitContainerControl3.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Both
        gcHblList.Enabled = False
        gcEventList.Enabled = False
        ButtonEnabled(e.Item.Name)
        lueEvent.EditValue = Nothing
        tsEstado.EditValue = Nothing
        meRemarks.Text = Nothing
        deDateTime.EditValue = DateTime.Now

        oEvento.EVEN_Usuario = AppUser
        oEvento.AUDI_UsrCrea = AppUser
        oEvento.AUDI_FecCrea = Now
    End Sub

    Private Sub bbiEdit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEdit.ItemClick
        SplitContainerControl3.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Both
        gcHblList.Enabled = False
        gcEventList.Enabled = False
        ButtonEnabled(e.Item.Name)
        Dim oDataRow As DataRow = GridView2.GetFocusedDataRow
        lueEvent.EditValue = oDataRow("TIPO_CodEVE")
        tsEstado.EditValue = oDataRow("EVEN_Cumplida")
        meRemarks.Text = oDataRow("EVEN_Observaciones")
        deDateTime.EditValue = oDataRow("EVEN_Fecha")

        oEvento.EVEN_Item = oDataRow("EVEN_Item")
        oEvento.EVEN_Observaciones = oDataRow("EVEN_Observaciones")
        oEvento.EVEN_Fecha = oDataRow("EVEN_Fecha")
        oEvento.EVEN_Usuario = oDataRow("EVEN_Usuario")
        oEvento.AUDI_UsrCrea = oDataRow("AUDI_UsrCrea")
        oEvento.AUDI_FecCrea = oDataRow("AUDI_FecCrea")
        oEvento.AUDI_UsrCrea = AppUser
        oEvento.AUDI_FecCrea = Now
    End Sub

    Private Sub bbiDelete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiDelete.ItemClick
        If DevExpress.XtraEditors.XtraMessageBox.Show("Está seguro que desea eliminar el registro seleccionado? ", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Forms.DialogResult.No Then
            Return
        End If
        ButtonEnabled(e.Item.Name)
        Dim oDataRow As DataRow = GridView2.GetFocusedDataRow
        oEvento.CCOT_Numero = oDataRow("CCOT_Numero")
        oEvento.CCOT_Tipo = oDataRow("CCOT_Tipo")
        oEvento.EVEN_Item = oDataRow("EVEN_Item")
        Try
            oAppService.DeleteEvento(oEvento)
        Catch ex As Exception

        End Try
        bbiSearch.PerformClick()
    End Sub

    Private Sub bbiSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSave.ItemClick
        'SplitContainerControl3.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
        LoadInputValidations("Save")
        If Not vpInputs.Validate Then
            Return
        End If
        If DevExpress.XtraEditors.XtraMessageBox.Show("Está seguro que desea guardar los cambios? ", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Forms.DialogResult.No Then
            Return
        End If
        'Dim dt As List(Of COM_Det_Cotizacion_OV_EventosTareas_BE)
        Dim oDataRow As DataRow = GridView1.GetFocusedDataRow
        oEvento.CCOT_Numero = oDataRow("CCOT_Numero")
        oEvento.CCOT_Tipo = oDataRow("CCOT_Tipo")
        oEvento.CONS_TabMOD = "MOD"
        oEvento.CONS_CodMOD = "001"
        oEvento.TIPO_TabEVE = "EVE"
        oEvento.TIPO_CodEVE = lueEvent.EditValue
        oEvento.EVEN_Manual = True
        oEvento.EVEN_Fecha = deDateTime.EditValue
        oEvento.EVEN_Observaciones = IIf(meRemarks.EditValue = Nothing, "", meRemarks.EditValue)
        oEvento.EVEN_Cumplida = tsEstado.EditValue
        Try
            If oEvento.EVEN_Item = 0 Then
                oAppService.InsertEvento(oEvento)
            Else
                oAppService.UpdateEvento(oEvento)
            End If
        Catch ex As Exception

        End Try
        If bInsert Then
            Close
        End If
        bbiSearch.PerformClick()
    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        Validate()
        If e.FocusedRowHandle < 0 Then
            Return
        End If
        ButtonEnabled(Nothing)
        Dim dtEvents As New DataTable
        dtEvents = oAppService.ExecuteSQL("EXEC NextSoft.dgp.paObtieneEventosPorHbl '" & GridView1.GetFocusedRowCellValue("HBL").ToString & "'").Tables(0)
        gcEventList.DataSource = dtEvents
        'GridView2.BestFitColumns()
        GridView2.RefreshData()
    End Sub

    Private Sub ButtonEnabled(btName As String)
        If GridView1.RowCount = 0 Then
            bbiInsert.Enabled = False
            bbiEdit.Enabled = False
            bbiDelete.Enabled = False
            bbiExport.Enabled = False
            bbiOVQuery.Enabled = False
            bbiSave.Enabled = False
            Return
        End If
        For b = 0 To bmActions.Items.Count - 1
            If bmActions.Items(b).Name.Contains("bbi") Then
                If bmActions.Items(b).Name <> "bbiSave" Then
                    bmActions.Items(b).Enabled = True
                End If
            End If
        Next
        If Not btName Is Nothing Then
            If btName.Contains({"bbiInsert", "bbiEdit", "bbiDelete"}) Then
                bbiInsert.Enabled = False
                bbiEdit.Enabled = False
                bbiDelete.Enabled = False
                bbiExport.Enabled = False
                bbiOVQuery.Enabled = False
                bbiSave.Enabled = True
            End If
        End If
    End Sub

    Private Sub bbiClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiClose.ItemClick
        Close()
    End Sub
End Class
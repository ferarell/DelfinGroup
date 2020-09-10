Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.DXErrorProvider
Imports System.Net.Http
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Text
Imports DevExpress.XtraGrid.Views.Grid
Imports System.ComponentModel
Imports DevExpress.XtraGrid
Imports System.Configuration

Public Class TariffForm
    Public AppUser As String = "sistemas"
    'Dim oAttentionPointDAO As New AttentionPointDAO
    'Dim oAttentionPointBE As New AttentionPointBE
    'Dim oGeneralDAO As New GeneralDAO
    Dim client As HttpClient = New HttpClient
    Dim Index, IdAttentionPoint As Integer
    Dim IdTariff As Integer
    Dim UrlTarifasRest As String = ConfigurationManager.AppSettings("urlServiciosTarifa")

    Private Sub OperacionesForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        SplitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2
        GridView2.OptionsView.NewItemRowPosition = NewItemRowPosition.Top
        LoadMainData()
        LoadOperationType()
        LoadAppUser()
        LoadEstados()
        LoadMonedas()
        LoadUnidades()
        LoadLayouts()
        LoadConceptos()
        LoadTiposTarifa()
        LoadMonedasDetalle()
        BarButtonEnabled()
    End Sub

    Private Sub bbiClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiClose.ItemClick
        Close()
    End Sub

    Private Sub bbiExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExport.ItemClick
        ExportToExcel(gcMainDataTariff)
    End Sub

    Private Sub bbiRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiRefresh.ItemClick
        BarButtonEnabled()
        LoadMainData()
        gcMainDataTariff.Enabled = True
        SplitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2
    End Sub

    Private Sub LoadMainData()

        client.DefaultRequestHeaders.Accept.Add(
            New System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"))

        Dim response As HttpResponseMessage = client.GetAsync(
                               New Uri(UrlTarifasRest + "/Tariff/ObtenerTarifas")).Result

        If response.IsSuccessStatusCode Then
            Dim jsonString As String = response.Content.ReadAsStringAsync().Result
            'Dim bearerToken As String = DirectCast(
            '           JObject.Parse(json).SelectToken("access_token"),
            '                                String)
            'Return True
            'Else
            '    Return False

            Dim listTarifas As List(Of TariffClient) = Newtonsoft.Json.JsonConvert.DeserializeObject(Of List(Of TariffClient))(jsonString)
            gcMainDataTariff.DataSource = listTarifas


            'Dim listTariffServices As List(Of TariffUnitClient) = Newtonsoft.Json.JsonConvert.DeserializeObject(Of List(Of TariffUnitClient))("")
            'gcServicios.DataSource = listTariffServices




            Refresh()

        End If


        'Dim dtQuery As New DataTable
        'dtQuery = oAttentionPointDAO.AttentionPointSelect
        'gcMainData.DataSource = dtQuery

    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        BarButtonEnabled()

        Dim dgrItem As TariffClient = GridView1.GetRow(GridView1.FocusedRowHandle)

        ucAuditPanel.UsuarioCreacion = Nothing
        ucAuditPanel.FechaCreacion = Nothing
        ucAuditPanel.UsuarioModificacion = Nothing
        ucAuditPanel.FechaModificacion = Nothing
        If Not dgrItem Is Nothing Then
            If Not dgrItem.UserCreate Is Nothing Then
                ucAuditPanel.UsuarioCreacion = dgrItem.UserCreate
                ucAuditPanel.FechaCreacion = dgrItem.DateCreate
            End If
            If Not dgrItem.UserUpdate Is Nothing Then
                ucAuditPanel.UsuarioModificacion = dgrItem.UserUpdate
                ucAuditPanel.FechaModificacion = dgrItem.DateUpdate
            End If
            ucAuditPanel.pnlAuditoria.Refresh()
        End If
        LoadInputs()
        EnableInputs(False)
    End Sub

    Private Sub BarButtonEnabled()
        For Each bbi As BarButtonItemLink In brBarraAcciones.ItemLinks
            bbi.Item.Enabled = False
            If bbi.Item.Tag = 0 Then
                bbi.Item.Enabled = True
            End If
            If bbi.Item.Tag = 1 Then
                If GridView1.RowCount > 0 Then
                    bbi.Item.Enabled = True
                End If
            End If
        Next
    End Sub

    Private Sub LoadInputValidations()
        Validate()
        'Dim containsValidationRule As New DevExpress.XtraEditors.DXErrorProvider.ConditsionValidationRule()
        'containsValidationRule.CondsitionOperator = ConditsionOperator.IsNotBlank
        'containsValidationRule.ErrorText = "Asigne un valor."
        'containsValidationRule.ErrorType = ErrorType.Critical
        'Dim customValidationRule As New CustomValidationRule()
        'customValidationRule.ErrorText = "Valor obligatorio."
        'customValidationRule.ErrorType = ErrorType.Critical
        'vpInputs.SetValidationRule(Me.txtCodigo, customValidationRule)
        'vpInputs.SetValidationRule(Me.deDateFrom, customValidationRule)
        'vpInputs.SetValidationRule(Me.lueOperationType, customValidationRule)
        'vpInputs.SetValidationRule(Me.lueTarifa, customValidationRule)
    End Sub

    Private Sub bbiInsert_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbiInsert.ItemClick
        Index = 0
        SplitContainerControl1.PanelVisibility = SplitPanelVisibility.Both
        SplitContainerControl1.Collapsed = False
        gcMainDataTariff.Enabled = False
        ClearInputs(Me.meRemarks)
        EnableInputs(True)
        bbiSave.Enabled = True
        bbiEdit.Enabled = False
        bbiDelete.Enabled = False
        Me.lueTipoTarifa.EditValue = "R"


    End Sub

    Private Sub ClearInputs(ControlFocused As Object)
        For Each oInputs As Object In SplitContainer1.Panel1.Controls
            If oInputs.ToString.Contains("TextEdit") Then
                oInputs.EditValue = ""
            ElseIf oInputs.ToString.Contains("ToggleSwitch") Then
                oInputs.EditValue = False
            ElseIf oInputs.ToString.Contains("DateTimePicker") Then
                oInputs.Value = DateTime.Now
            ElseIf oInputs.ToString.Contains("MemoEdit") Then
                oInputs.EditValue = ""
            End If
        Next
        Dim listTariffUnits As BindingList(Of TariffDetailClient) = New BindingList(Of TariffDetailClient)()
        gcUnidades.DataSource = listTariffUnits
        ControlFocused.Focus()
    End Sub

    Private Sub EnableInputs(bEnabled As Boolean)
        For Each oInputs As Object In SplitContainerControl1.Panel1.Controls
            oInputs.Enabled = bEnabled
        Next
    End Sub

    Private Sub bbiEdit_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbiEdit.ItemClick
        Index = 1
        SplitContainerControl1.PanelVisibility = SplitPanelVisibility.Both
        SplitContainerControl1.Collapsed = False
        EnableInputs(True)
        bbiSave.Enabled = True
        bbiInsert.Enabled = False
        bbiDelete.Enabled = False
    End Sub

    Private Sub LoadInputs()


        Dim dgrItem As TariffClient = GridView1.GetRow(GridView1.FocusedRowHandle)
        If dgrItem IsNot Nothing Then
            IdTariff = dgrItem.IdTariff
            'txtCodigo.EditValue = dgrItem. 'dgrItem("GroupCode")
            'txtDescripcion.EditValue = dgrItem.TariffDescription 'dgrItem("GroupDescription")
            ''oTariffClient.IdUnit = 5
            'txtImporteCompra.Text = dgrItem.CostsAmount.ToString()
            'txtImporteVenta.Text = dgrItem.SalesAmount.ToString()
            lueEstado.EditValue = dgrItem.TariffStatus
            lueLayout.EditValue = dgrItem.IdLayout
            lueMoneda.EditValue = dgrItem.Currency
            lueTipoTarifa.EditValue = dgrItem.TariffType
            meRemarks.Text = dgrItem.Remarks
            dtpDe.Value = dgrItem.ValidFrom
            dtpHasta.Value = dgrItem.ValidTo
            'gcServicios.DataSource = dgrItem.TariffUnit
            'txtImporteCompra.Text = dgrItem.SalesAmount.ToString()
            'txtImporteVenta.Text = dgrItem.SalesAmount.ToString()

            'If dgrItem.TariffUnit.Count > 0 Then
            Dim TariffDetailList As BindingList(Of TariffDetailClient) = New BindingList(Of TariffDetailClient)(dgrItem.TariffDetail.ToList())
            gcUnidades.DataSource = TariffDetailList




            'End If


            'oTariffClient.TariffUnit = TariffUnitList

            'oTariffClient.IdUnit = 5
            'oTariffClient.Currency = "PEN"
            'oTariffClient.TariffType = "AC"
            'oTariffClient.CostsAmount = Convert.ToDecimal(txtImporteCompra.Text)
            'oTariffClient.SalesAmount = Convert.ToDecimal(txtImporteVenta.Text)
            'oTariffClient.TariffStatus = "A"

        End If


        'deDateTo.EditValue = dgrItem("valid_date_to")
        'lueOperationType.ItemIndex = lueOperationType.Properties.GetDataSourceRowIndex("operation_type_id", dgrItem("operation_type_id"))
        'lueAppUser.ItemIndex = lueAppUser.Properties.GetDataSourceRowIndex("UserAccount", dgrItem("user_account"))
        'tsActive.EditValue = IIf(dgrItem("status") = "A", True, False)
        'tsConnected.EditValue = dgrItem("connected")
        'meConectionProperty.Text = dgrItem("connection_property")
    End Sub

    Private Sub bbiDelete_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbiDelete.ItemClick
        If DevExpress.XtraEditors.XtraMessageBox.Show("La eliminación del registro seleccionado podría afectar la integridad de la información, desea continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = System.Windows.Forms.DialogResult.Yes Then


            Dim dgrItem As TariffClient = GridView1.GetRow(GridView1.FocusedRowHandle)
            dgrItem.TariffStatus = "I"
            Dim jsonSerialice As String = Newtonsoft.Json.JsonConvert.SerializeObject(dgrItem)
            Dim content As StringContent = New StringContent(jsonSerialice, Encoding.UTF8, "application/json")
            'Dim response2 As HttpResponseMessage = client.DeleteAsync(UrlTarifasRest + "/Tariff/DeleteTarifa" + "/" + dgrItem.IdTariff.ToString()).Result
            Dim response2 As HttpResponseMessage = client.PutAsync(UrlTarifasRest + "/Tariff/UpdateTarifa", content).Result

            bbiRefresh.PerformClick()

        End If
    End Sub

    'Private Sub lueOperationType_Enter(sender As Object, e As EventArgs) Handles lueOperationType.Enter
    '    LoadOperationType()
    'End Sub

    Private Sub LoadOperationType()
        'Dim dtSource As New DataTable
        'dtSource = GetDataRowsFromTable("OperationType")
        'lueOperationType.Properties.DataSource = dtSource
        'lueOperationType.Properties.DisplayMember = "remarks"
        'lueOperationType.Properties.ValueMember = "operation_type_id"
    End Sub

    Private Sub lueAppUser_Enter(sender As System.Object, e As System.EventArgs)
        LoadAppUser()
    End Sub

    Private Sub LoadAppUser()
        'Dim dtSource As New DataTable
        'dtSource = GetDataRowsFromTable("vwActiveAppUser")
        'lueAppUser.Properties.DataSource = dtSource
        'lueAppUser.Properties.DisplayMember = "UserName"
        'lueAppUser.Properties.ValueMember = "UserAccount"
    End Sub

    Private Sub bbiSave_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbiSave.ItemClick
        'LoadInputValidations()
        If Not vpInputs.Validate Then
            Return
        End If


        Me.GridView2.CloseEditor()
        Me.GridView2.UpdateCurrentRow()


        bbiSave.Enabled = False
        Dim oTariffClient As TariffClient = New TariffClient()


        'oTariffClient.IdUnit = 5
        'oTariffClient.Currency = lueMoneda.EditValue.ToString().Trim()
        oTariffClient.TariffStatus = lueEstado.EditValue.ToString().Trim()
        oTariffClient.IdLayout = lueLayout.EditValue
        oTariffClient.TariffType = lueTipoTarifa.EditValue.ToString().Trim()
        oTariffClient.Remarks = Me.meRemarks.Text
        oTariffClient.ValidFrom = dtpDe.Value
        oTariffClient.ValidTo = dtpHasta.Value




        Dim TariffDetailList As BindingList(Of TariffDetailClient) = New BindingList(Of TariffDetailClient)((TryCast(gcUnidades.DataSource, IEnumerable(Of TariffDetailClient))).ToList())
        oTariffClient.TariffDetail = TariffDetailList


        'oAttentionPointBE.attention_point_id = IdAttentionPoint
        'oAttentionPointBE.description = teUserDescription.Text
        'oAttentionPointBE.valid_date_from = deDateFrom.EditValue
        'If Not IsDBNull(deDateTo.EditValue) Then
        '    oAttentionPointBE.valid_date_to = deDateTo.EditValue
        'End If
        'oAttentionPointBE.operation_type_id = lueOperationType.EditValue
        'oAttentionPointBE.user_account = lueAppUser.EditValue
        'oAttentionPointBE.connected = tsConnected.EditValue
        'oAttentionPointBE.connection_property = meConectionProperty.Text
        'oAttentionPointBE.status = IIf(tsActive.EditValue = True, "A", "I")
        If DevExpress.XtraEditors.XtraMessageBox.Show("Está seguro de guardar los cambios?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            Try
                If Index = 0 Then
                    oTariffClient.UserCreate = AppUser
                    oTariffClient.DateCreate = DateTime.Now
                    'oTariffClient.IdTariff = -1
                    IdTariff = Nothing
                    For Each item As TariffDetailClient In oTariffClient.TariffDetail
                        item.IdTariff = IdTariff
                        item.IdTariffDetail = Nothing
                    Next

                    Dim jsonSerialice As String = Newtonsoft.Json.JsonConvert.SerializeObject(oTariffClient)
                    Dim content As StringContent = New StringContent(jsonSerialice, Encoding.UTF8, "application/json")
                    Dim response2 As HttpResponseMessage = client.PostAsync(UrlTarifasRest + "/Tariff/InsertarTarifa", content).Result
                Else
                    oTariffClient.UserUpdate = AppUser
                    oTariffClient.DateUpdate = DateTime.Now
                    oTariffClient.IdTariff = IdTariff
                    Dim jsonSerialice As String = Newtonsoft.Json.JsonConvert.SerializeObject(oTariffClient)
                    Dim content As StringContent = New StringContent(jsonSerialice, Encoding.UTF8, "application/json")
                    Dim response2 As HttpResponseMessage = client.PutAsync(UrlTarifasRest + "/Tariff/UpdateTarifa", content).Result
                End If
            Catch ex As Exception
                Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
                DevExpress.XtraEditors.XtraMessageBox.Show("La actualización generó el siguiente error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        DevExpress.XtraEditors.XtraMessageBox.Show("Los datos se guardaron satisfactoriamente. ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        bbiRefresh.PerformClick()
    End Sub



    Private Sub LoadEstados()
        client.DefaultRequestHeaders.Accept.Add(
            New System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"))

        Dim response As HttpResponseMessage = client.GetAsync(
                               New Uri(UrlTarifasRest + "/Tipos/ObtenerTiposPorCriterio?Tipo_CodTabla=ETR")).Result

        If response.IsSuccessStatusCode Then
            Dim jsonString As String = response.Content.ReadAsStringAsync().Result
            Dim listTipos As List(Of TiposCliente) = Newtonsoft.Json.JsonConvert.DeserializeObject(Of List(Of TiposCliente))(jsonString)
            lueEstado.Properties.DataSource = listTipos
            lueEstado.Properties.DisplayMember = "TIPO_Desc1"
            lueEstado.Properties.ValueMember = "TIPO_CodTipo"
            lueEstado.ItemIndex = 0

        End If
    End Sub

    Private Sub gcServicios_EmbeddedNavigator_ButtonClick(sender As Object, e As NavigatorButtonClickEventArgs) Handles gcUnidades.EmbeddedNavigator.ButtonClick
        If (e.Button.ButtonType = NavigatorButtonType.Append) Then

            GridView2.AddNewRow()


        End If
    End Sub


    'Private Sub LoadUnidades()
    '    client.DefaultRequestHeaders.Accept.Add(
    '        New System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"))

    '    Dim response As HttpResponseMessage = client.GetAsync(
    '                           New Uri(UrlTarifasRest + "/Unit/ObtenerUnidades")).Result

    '    If response.IsSuccessStatusCode Then
    '        Dim jsonString As String = response.Content.ReadAsStringAsync().Result
    '        Dim listUnidades As List(Of UnitClient) = Newtonsoft.Json.JsonConvert.DeserializeObject(Of List(Of UnitClient))(jsonString)
    '        lueUnidad.Properties.DataSource = listUnidades
    '        lueUnidad.Properties.DisplayMember = "UnitCode"
    '        lueUnidad.Properties.ValueMember = "IdUnit"
    '        lueUnidad.ItemIndex = 0

    '    End If
    'End Sub


    Private Sub LoadLayouts()
        client.DefaultRequestHeaders.Accept.Add(
            New System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"))

        Dim response As HttpResponseMessage = client.GetAsync(
                               New Uri(UrlTarifasRest + "/Layout/ObtenerLayouts")).Result

        If response.IsSuccessStatusCode Then
            Dim jsonString As String = response.Content.ReadAsStringAsync().Result
            Dim listLayouts As List(Of LayoutClient) = Newtonsoft.Json.JsonConvert.DeserializeObject(Of List(Of LayoutClient))(jsonString)
            Dim listLayoutsActivas As List(Of LayoutClient) = listLayouts.FindAll(Function(x) x.LayoutStatus = "A")

            lueLayout.Properties.DataSource = listLayoutsActivas
            lueLayout.Properties.DisplayMember = "LayoutDescription"
            lueLayout.Properties.ValueMember = "IdLayout"
            lueLayout.ItemIndex = 0

        End If
    End Sub


    Private Sub LoadMonedasDetalle()
        client.DefaultRequestHeaders.Accept.Add(
            New System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"))

        Dim response As HttpResponseMessage = client.GetAsync(
                               New Uri(UrlTarifasRest + "/Tipos/ObtenerTiposPorCriterio?Tipo_CodTabla=MOT")).Result

        If response.IsSuccessStatusCode Then
            Dim jsonString As String = response.Content.ReadAsStringAsync().Result
            Dim listTipos As List(Of TiposCliente) = Newtonsoft.Json.JsonConvert.DeserializeObject(Of List(Of TiposCliente))(jsonString)
            rilueMoneda.DataSource = listTipos
            rilueMoneda.DisplayMember = "TIPO_Desc1"
            rilueMoneda.ValueMember = "TIPO_CodTipo"
            'rilueMoneda.ItemIndex = 0

        End If
    End Sub



    Private Sub LoadMonedas()
        client.DefaultRequestHeaders.Accept.Add(
            New System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"))

        Dim response As HttpResponseMessage = client.GetAsync(
                               New Uri(UrlTarifasRest + "/Tipos/ObtenerTiposPorCriterio?Tipo_CodTabla=MOT")).Result

        If response.IsSuccessStatusCode Then
            Dim jsonString As String = response.Content.ReadAsStringAsync().Result
            Dim listTipos As List(Of TiposCliente) = Newtonsoft.Json.JsonConvert.DeserializeObject(Of List(Of TiposCliente))(jsonString)
            lueMoneda.Properties.DataSource = listTipos
            lueMoneda.Properties.DisplayMember = "TIPO_Desc1"
            lueMoneda.Properties.ValueMember = "TIPO_CodTipo"
            lueMoneda.ItemIndex = 0

        End If
    End Sub

    Private Sub GridView2_InitNewRow(sender As Object, e As InitNewRowEventArgs) Handles GridView2.InitNewRow

        Dim view As GridView = CType(sender, GridView)


        If Index = 0 Then
            view.SetRowCellValue(e.RowHandle, view.Columns("UserCreate"), AppUser)
            view.SetRowCellValue(e.RowHandle, view.Columns("DateCreate"), Date.Today)

        Else
            view.SetRowCellValue(e.RowHandle, view.Columns("UserUpdate"), AppUser)
            view.SetRowCellValue(e.RowHandle, view.Columns("DateUpdate"), Date.Today)
            view.SetRowCellValue(e.RowHandle, view.Columns("IdTariff"), IdTariff)
        End If




    End Sub

    Private Sub gcServicios_ProcessGridKey(sender As Object, e As KeyEventArgs) Handles gcUnidades.ProcessGridKey
        If e.KeyCode = Keys.Delete AndAlso e.Modifiers = Keys.Control Then
            If XtraMessageBox.Show("Delete row(s)?", "Delete rows dialog", MessageBoxButtons.YesNo) <> DialogResult.Yes Then Return
            Dim grid As GridControl = TryCast(sender, GridControl)
            Dim view As GridView = TryCast(grid.FocusedView, GridView)
            view.DeleteSelectedRows()
        End If
    End Sub

    'Private Sub GridView2_dNewRow(sender As Object, e As InitNewRowEventArgs) Handles GridView2.InitNewRow


    '    Dim view As GridView = CType(sender, GridView)
    '    view.SetRowCellValue(e.RowHandle, view.Columns("RecordDate"), Date.Today)
    '    view.SetRowCellValue(e.RowHandle, view.Columns("Name"), "CustomName")
    '    view.SetRowCellValue(e.RowHandle, view.Columns("Notes"), "New Note")
    'End Sub








    Private Sub LoadTiposTarifa()
        client.DefaultRequestHeaders.Accept.Add(
            New System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"))

        Dim response As HttpResponseMessage = client.GetAsync(
                               New Uri(UrlTarifasRest + "/Tipos/ObtenerTiposPorCriterio?Tipo_CodTabla=TCT")).Result

        If response.IsSuccessStatusCode Then
            Dim jsonString As String = response.Content.ReadAsStringAsync().Result
            Dim listTipos As List(Of TiposCliente) = Newtonsoft.Json.JsonConvert.DeserializeObject(Of List(Of TiposCliente))(jsonString)
            lueTipoTarifa.Properties.DataSource = listTipos
            lueTipoTarifa.Properties.DisplayMember = "TIPO_Desc1"
            lueTipoTarifa.Properties.ValueMember = "TIPO_CodTipo"
            lueTipoTarifa.ItemIndex = 0

        End If
    End Sub

    Private Sub LoadUnidades()
        client.DefaultRequestHeaders.Accept.Add(
            New System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"))

        Dim response As HttpResponseMessage = client.GetAsync(
                               New Uri(UrlTarifasRest + "/Unit/ObtenerUnidades")).Result

        If response.IsSuccessStatusCode Then
            Dim jsonString As String = response.Content.ReadAsStringAsync().Result
            Dim listUnits As List(Of UnitClient) = Newtonsoft.Json.JsonConvert.DeserializeObject(Of List(Of UnitClient))(jsonString)
            rilueUnidad.DataSource = listUnits
            rilueUnidad.DisplayMember = "UnitCode"
            rilueUnidad.ValueMember = "IdUnit"
            'rilueConcepto.ItemIndex = 0

        End If
    End Sub

    Private Sub lueLayout_EditValueChanged(sender As Object, e As EventArgs) Handles lueLayout.EditValueChanged
        Me.meRemarks.Text = lueLayout.Text
    End Sub

    Private Sub bbiCopiar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbiCopy.ItemClick
        Index = 0
        SplitContainerControl1.PanelVisibility = SplitPanelVisibility.Both
        SplitContainerControl1.Collapsed = False
        EnableInputs(True)
        bbiSave.Enabled = True
        bbiInsert.Enabled = False
        bbiDelete.Enabled = False
    End Sub

    Private Sub GridView2_CellValueChanged(sender As Object, e As Views.Base.CellValueChangedEventArgs) Handles GridView2.CellValueChanged
        If e.Column.FieldName.Contains({"ContributionMargin"}) Then
            Dim ValorContribucion As String = ""
            Dim ValorContribucionDecimal As Decimal = 0.0
            Dim ValorVenta As String = ""
            If IsDBNull(GridView2.GetFocusedRowCellValue("ContributionMargin")) Then
                ' GridView1.SetFocusedRowCellValue("DOPE_PrecioUnitVta", 0)
                ValorContribucion = 0
            Else
                ValorContribucion = GridView2.GetFocusedRowCellValue("ContributionMargin").ToString()
            End If
            'If IsDBNull(GridView1.GetFocusedRowCellValue("DOPE_Cantidad")) Then
            '    GridView1.SetFocusedRowCellValue("DOPE_Cantidad", 1)
            'End If
            ValorContribucionDecimal = Convert.ToDecimal(ValorContribucion)

            If ValorContribucionDecimal = 0 Then

                GridView2.SetFocusedRowCellValue("SalesAmount", Convert.ToDecimal(GridView2.GetFocusedRowCellValue("CostsAmount")))
            Else
                GridView2.SetFocusedRowCellValue("SalesAmount", (Convert.ToDecimal(GridView2.GetFocusedRowCellValue("CostsAmount")) * ValorContribucionDecimal / 100) + Convert.ToDecimal(GridView2.GetFocusedRowCellValue("CostsAmount")))
            End If


        End If
    End Sub

    Private Sub GridView1_DoubleClick(sender As Object, e As EventArgs) Handles GridView1.DoubleClick
        Index = 1
        SplitContainerControl1.PanelVisibility = SplitPanelVisibility.Both
        SplitContainerControl1.Collapsed = False
        EnableInputs(True)
        bbiSave.Enabled = True
        bbiInsert.Enabled = False
        bbiDelete.Enabled = False
        bbiEdit.PerformClick()
    End Sub

    Private Sub LoadConceptos()
        client.DefaultRequestHeaders.Accept.Add(
            New System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"))

        Dim response As HttpResponseMessage = client.GetAsync(
                               New Uri(UrlTarifasRest + "/Concept/ObtenerConceptos")).Result

        If response.IsSuccessStatusCode Then
            Dim jsonString As String = response.Content.ReadAsStringAsync().Result
            Dim listConcepts As List(Of ConceptClient) = Newtonsoft.Json.JsonConvert.DeserializeObject(Of List(Of ConceptClient))(jsonString)
            rilueConcepto.DataSource = listConcepts
            rilueConcepto.DisplayMember = "ConceptDescription"
            rilueConcepto.ValueMember = "IdConcept"
            'rilueConcepto.ItemIndex = 0

        End If
    End Sub



End Class
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

Public Class PackForm
    Public AppUser As String = "sistemas"
    'Dim oAttentionPointDAO As New AttentionPointDAO
    'Dim oAttentionPointBE As New AttentionPointBE
    'Dim oGeneralDAO As New GeneralDAO
    Dim client As HttpClient = New HttpClient
    Dim Index, IdAttentionPoint As Integer
    Dim IdPack As Integer
    Dim UrlTarifasRest As String = ConfigurationManager.AppSettings("urlServiciosTarifa")
    Private Sub OperacionesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMainData()
        LoadOperationType()
        LoadAppUser()
        LoadEstados()
        LoadUnidadesNegocio()
        LoadConceptos()
        'LoadUnidades()
        'LoadTiposPaquete()
        SplitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2


        GridView2.OptionsView.NewItemRowPosition = NewItemRowPosition.Top



    End Sub



    Private Sub bbiClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiClose.ItemClick
        Close()
    End Sub

    Private Sub bbiExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExport.ItemClick
        ExportToExcel(gcMainDataPack)
    End Sub

    Private Sub bbiRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiRefresh.ItemClick
        BarButtonEnabled()
        LoadMainData()
        gcMainDataPack.Enabled = True
        SplitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2
    End Sub

    Private Sub LoadMainData()

        client.DefaultRequestHeaders.Accept.Add(
            New System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"))

        Dim response As HttpResponseMessage = client.GetAsync(
                               New Uri(UrlTarifasRest + "/Pack/ObtenerPaquetes")).Result

        If response.IsSuccessStatusCode Then
            Dim jsonString As String = response.Content.ReadAsStringAsync().Result
            'Dim bearerToken As String = DirectCast(
            '           JObject.Parse(json).SelectToken("access_token"),
            '                                String)
            'Return True
            'Else
            '    Return False

            Dim listPaquetes As List(Of PackClient) = Newtonsoft.Json.JsonConvert.DeserializeObject(Of List(Of PackClient))(jsonString)
            gcMainDataPack.DataSource = listPaquetes


            'Dim listPackServices As List(Of PackConceptClient) = Newtonsoft.Json.JsonConvert.DeserializeObject(Of List(Of PackConceptClient))("")
            'gcSerirvicios.DataSource = listPackServices




            Refresh()

        End If


        'Dim dtQuery As New DataTable
        'dtQuery = oAttentionPointDAO.AttentionPointSelect
        'gcMainData.DataSource = dtQuery

    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        BarButtonEnabled()

        Dim dgrItem As PackClient = GridView1.GetRow(GridView1.FocusedRowHandle)

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
        'vpInputs.SetValidationRule(Me.luePaquete, customValidationRule)
    End Sub

    Private Sub bbiInsert_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbiInsert.ItemClick
        Index = 0
        SplitContainerControl1.PanelVisibility = SplitPanelVisibility.Both
        SplitContainerControl1.Collapsed = False
        gcMainDataPack.Enabled = False
        ClearInputs(txtDescripcion)
        EnableInputs(True)
        bbiSave.Enabled = True
        bbiEdit.Enabled = False
        bbiDelete.Enabled = False



    End Sub

    Private Sub ClearInputs(ControlFocused As Object)
        For Each oInputs As Object In SplitContainer1.Panel1.Controls
            If oInputs.ToString.Contains("TextEdit") Then
                oInputs.EditValue = ""
            ElseIf oInputs.ToString.Contains("ToggleSwitch") Then
                oInputs.EditValue = False
            End If
        Next
        Dim listPAckConcepts As BindingList(Of PackConceptClient) = New BindingList(Of PackConceptClient)()
        gcServicios.DataSource = listPAckConcepts
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


        Dim dgrItem As PackClient = GridView1.GetRow(GridView1.FocusedRowHandle)
        If dgrItem IsNot Nothing Then
            IdPack = dgrItem.IdPack
            'txtCodigo.EditValue = dgrItem.PackCode 'dgrItem("GroupCode")
            txtDescripcion.EditValue = dgrItem.PackDescription 'dgrItem("GroupDescription")
            'oPackClient.IdUnit = 5

            lueEstado.EditValue = dgrItem.PackStatus

            lueUnidadNegocio.EditValue = dgrItem.IdBusinessUnit
            'gcServicios.DataSource = dgrItem.PackConcept
            'txtImporteCompra.Text = dgrItem.SalesAmount.ToString()
            'txtImporteVenta.Text = dgrItem.SalesAmount.ToString()

            'If dgrItem.PackConcept.Count > 0 Then
            Dim PackConceptList As BindingList(Of PackConceptClient) = New BindingList(Of PackConceptClient)(dgrItem.PackConcept.ToList())
            gcServicios.DataSource = PackConceptList
            'End If


            'oPackClient.PackConcept = PackConceptList

            'oPackClient.IdUnit = 5
            'oPackClient.Currency = "PEN"
            'oPackClient.PackType = "AC"
            'oPackClient.CostsAmount = Convert.ToDecimal(txtImporteCompra.Text)
            'oPackClient.SalesAmount = Convert.ToDecimal(txtImporteVenta.Text)
            'oPackClient.PackStatus = "A"

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


            Dim dgrItem As PackClient = GridView1.GetRow(GridView1.FocusedRowHandle)
            dgrItem.PackStatus = "I"
            Dim jsonSerialice As String = Newtonsoft.Json.JsonConvert.SerializeObject(dgrItem)
            Dim content As StringContent = New StringContent(jsonSerialice, Encoding.UTF8, "application/json")
            'Dim response2 As HttpResponseMessage = client.DeleteAsync(UrlTarifasRest + "/Pack/DeletePaquete" + "/" + dgrItem.IdPack.ToString()).Result
            Dim response2 As HttpResponseMessage = client.PutAsync(UrlTarifasRest + "/Pack/UpdatePaquete", content).Result
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
        Dim oPackClient As PackClient = New PackClient()
        oPackClient.PackCode = "" 'txtCodigo.Text
        oPackClient.PackDescription = txtDescripcion.Text

        'oPackClient.IdUnit = 5

        oPackClient.PackStatus = lueEstado.EditValue.ToString().Trim()





        Dim PackConceptList As BindingList(Of PackConceptClient) = New BindingList(Of PackConceptClient)((TryCast(gcServicios.DataSource, IEnumerable(Of PackConceptClient))).ToList())
        oPackClient.PackConcept = PackConceptList

        oPackClient.IdBusinessUnit = lueUnidadNegocio.EditValue
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
                    oPackClient.UserCreate = AppUser
                    oPackClient.DateCreate = DateTime.Now
                    'oPackClient.IdPack = -1
                    Dim jsonSerialice As String = Newtonsoft.Json.JsonConvert.SerializeObject(oPackClient)
                    Dim content As StringContent = New StringContent(jsonSerialice, Encoding.UTF8, "application/json")
                    Dim response2 As HttpResponseMessage = client.PostAsync(UrlTarifasRest + "/Pack/InsertarPaquete", content).Result
                Else
                    oPackClient.UserUpdate = AppUser
                    oPackClient.DateUpdate = DateTime.Now
                    oPackClient.IdPack = IdPack
                    Dim jsonSerialice As String = Newtonsoft.Json.JsonConvert.SerializeObject(oPackClient)
                    Dim content As StringContent = New StringContent(jsonSerialice, Encoding.UTF8, "application/json")
                    Dim response2 As HttpResponseMessage = client.PutAsync(UrlTarifasRest + "/Pack/UpdatePaquete", content).Result
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

    Private Sub gcServicios_EmbeddedNavigator_ButtonClick(sender As Object, e As NavigatorButtonClickEventArgs) Handles gcServicios.EmbeddedNavigator.ButtonClick
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






    Private Sub GridView2_InitNewRow(sender As Object, e As InitNewRowEventArgs) Handles GridView2.InitNewRow

        Dim view As GridView = CType(sender, GridView)


        If Index = 0 Then
            view.SetRowCellValue(e.RowHandle, view.Columns("UserCreate"), AppUser)
            view.SetRowCellValue(e.RowHandle, view.Columns("DateCreate"), Date.Today)

        Else
            view.SetRowCellValue(e.RowHandle, view.Columns("UserUpdate"), AppUser)
            view.SetRowCellValue(e.RowHandle, view.Columns("DateUpdate"), Date.Today)
            view.SetRowCellValue(e.RowHandle, view.Columns("IdPack"), IdPack)
        End If




    End Sub

    Private Sub gcServicios_ProcessGridKey(sender As Object, e As KeyEventArgs) Handles gcServicios.ProcessGridKey
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








    'Private Sub LoadTiposPaquete()
    '    client.DefaultRequestHeaders.Accept.Add(
    '        New System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"))

    '    Dim response As HttpResponseMessage = client.GetAsync(
    '                           New Uri(UrlTarifasRest + "/Tipos/ObtenerTiposPorCriterio?Tipo_CodTabla=TCT")).Result

    '    If response.IsSuccessStatusCode Then
    '        Dim jsonString As String = response.Content.ReadAsStringAsync().Result
    '        Dim listTipos As List(Of TiposCliente) = Newtonsoft.Json.JsonConvert.DeserializeObject(Of List(Of TiposCliente))(jsonString)
    '        lueTipoPaquete.Properties.DataSource = listTipos
    '        lueTipoPaquete.Properties.DisplayMember = "TIPO_Desc1"
    '        lueTipoPaquete.Properties.ValueMember = "TIPO_CodTipo"
    '        lueTipoPaquete.ItemIndex = 0

    '    End If
    'End Sub

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

    Private Sub GridView1_DoubleClick(sender As Object, e As EventArgs) Handles GridView1.DoubleClick
        Index = 1
        SplitContainerControl1.PanelVisibility = SplitPanelVisibility.Both
        SplitContainerControl1.Collapsed = False
        EnableInputs(True)
        bbiSave.Enabled = True
        bbiInsert.Enabled = False
    End Sub

    Private Sub LoadUnidadesNegocio()
        client.DefaultRequestHeaders.Accept.Add(
            New System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"))

        Dim response As HttpResponseMessage = client.GetAsync(
                               New Uri(UrlTarifasRest + "/UnidadesNegocio/ObtenerUnidadesNegocio")).Result

        If response.IsSuccessStatusCode Then
            Dim jsonString As String = response.Content.ReadAsStringAsync().Result
            Dim listUnidades As List(Of BusinessUnitClient) = Newtonsoft.Json.JsonConvert.DeserializeObject(Of List(Of BusinessUnitClient))(jsonString)
            Dim listUnidadesActivas As List(Of BusinessUnitClient) = listUnidades.FindAll(Function(x) x.BusinessUnitStatus = "A")
            lueUnidadNegocio.Properties.DataSource = listUnidadesActivas
            lueUnidadNegocio.Properties.DisplayMember = "BusinessUnitDescription"
            lueUnidadNegocio.Properties.ValueMember = "IdBusinessUnit"
            lueUnidadNegocio.ItemIndex = 0

        End If
    End Sub

End Class
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.DXErrorProvider
Imports System.Net.Http
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Text
Imports System.Configuration

Public Class GroupForm
    Public AppUser As String = "sistemas"
    'Dim oAttentionPointDAO As New AttentionPointDAO
    'Dim oAttentionPointBE As New AttentionPointBE
    'Dim oGeneralDAO As New GeneralDAO
    Dim client As HttpClient = New HttpClient
    Dim Index, IdAttentionPoint As Integer
    Dim IdGroup As Integer
    Dim UrlTarifasRest As String = ConfigurationManager.AppSettings("urlServiciosTarifa")

    Private Sub GroupForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        SplitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2
        LoadMainData()
        LoadOperationType()
        LoadAppUser()
        LoadEstados()
        BarButtonEnabled()
    End Sub

    Private Sub bbiClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiClose.ItemClick
        Close()
    End Sub

    Private Sub bbiExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExport.ItemClick
        ExportToExcel(gcMainDataGroup)
    End Sub

    Private Sub bbiRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiRefresh.ItemClick
        BarButtonEnabled()
        LoadMainData()
        gcMainDataGroup.Enabled = True
        SplitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2
    End Sub

    Private Sub LoadMainData()

        client.DefaultRequestHeaders.Accept.Add(
            New System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"))

        Dim response As HttpResponseMessage = client.GetAsync(
                               New Uri(UrlTarifasRest + "/Group/ObtenerGrupos")).Result

        If response.IsSuccessStatusCode Then
            Dim jsonString As String = response.Content.ReadAsStringAsync().Result
            'Dim bearerToken As String = DirectCast(
            '           JObject.Parse(json).SelectToken("access_token"),
            '                                String)
            'Return True
            'Else
            '    Return False

            Dim listGrupos As List(Of GroupClient) = Newtonsoft.Json.JsonConvert.DeserializeObject(Of List(Of GroupClient))(jsonString)
            gcMainDataGroup.DataSource = listGrupos
            Refresh()

        End If


        'Dim dtQuery As New DataTable
        'dtQuery = oAttentionPointDAO.AttentionPointSelect
        'gcMainData.DataSource = dtQuery

    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        BarButtonEnabled()

        Dim dgrItem As GroupClient = GridView1.GetRow(GridView1.FocusedRowHandle)

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
        Dim containsValidationRule As New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        containsValidationRule.ConditionOperator = ConditionOperator.IsNotBlank
        containsValidationRule.ErrorText = "Asigne un valor."
        containsValidationRule.ErrorType = ErrorType.Critical
        Dim customValidationRule As New CustomValidationRule()
        customValidationRule.ErrorText = "Valor obligatorio."
        customValidationRule.ErrorType = ErrorType.Critical
        'mvpInputs.SetValidationRule(Me.txtCodigo, customValidationRule)
        'vpInputs.SetValidationRule(Me.deDateFrom, customValidationRule)
        'vpInputs.SetValidationRule(Me.lueOperationType, customValidationRule)
        'vpInputs.SetValidationRule(Me.lueGrupo, customValidationRule)
    End Sub

    Private Sub bbiInsert_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbiInsert.ItemClick
        Index = 0
        SplitContainerControl1.PanelVisibility = SplitPanelVisibility.Both
        SplitContainerControl1.Collapsed = False
        gcMainDataGroup.Enabled = False
        ClearInputs(txtDescripcion)
        EnableInputs(True)
        bbiSave.Enabled = True
        bbiEdit.Enabled = False
        bbiDelete.Enabled = False
    End Sub

    Private Sub ClearInputs(ControlFocused As Object)
        For Each oInputs As Object In SplitContainerControl1.Panel1.Controls
            If oInputs.ToString.Contains("TextEdit") Then
                oInputs.EditValue = ""
            ElseIf oInputs.ToString.Contains("ToggleSwitch") Then
                oInputs.EditValue = False
            End If
        Next
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


        Dim dgrItem As GroupClient = GridView1.GetRow(GridView1.FocusedRowHandle)
        If dgrItem IsNot Nothing Then
            IdGroup = dgrItem.IdGroup
            'txtCodigo.EditValue = dgrItem.GroupCode 'dgrItem("GroupCode")
            txtDescripcion.EditValue = dgrItem.GroupDescription 'dgrItem("GroupDescription")
            lueEstado.EditValue = dgrItem.GrouopStatus
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


            Dim dgrItem As GroupClient = GridView1.GetRow(GridView1.FocusedRowHandle)
            dgrItem.GrouopStatus = "I"
            Dim jsonSerialice As String = Newtonsoft.Json.JsonConvert.SerializeObject(dgrItem)
            Dim content As StringContent = New StringContent(jsonSerialice, Encoding.UTF8, "application/json")
            'Dim response2 As HttpResponseMessage = client.DeleteAsync(UrlTarifasRest + "/Group/DeleteGrupo" + "/" + dgrItem.IdGroup.ToString()).Result
            Dim response2 As HttpResponseMessage = client.PutAsync(UrlTarifasRest + "/Group/UpdateGrupo", content).Result
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
        bbiSave.Enabled = False
        Dim oGroupClient As GroupClient = New GroupClient()
        oGroupClient.GroupCode = ""
        oGroupClient.GroupDescription = txtDescripcion.Text

        oGroupClient.GrouopStatus = lueEstado.EditValue.ToString().Trim()
        'oGroupClient.UserCreate = 1
        'oGroupClient.UserUpdate = 1



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
                    oGroupClient.UserCreate = AppUser
                    oGroupClient.DateCreate = DateTime.Now
                    Dim jsonSerialice As String = Newtonsoft.Json.JsonConvert.SerializeObject(oGroupClient)
                    Dim content As StringContent = New StringContent(jsonSerialice, Encoding.UTF8, "application/json")
                    Dim response2 As HttpResponseMessage = client.PostAsync(UrlTarifasRest + "/Group/InsertarGrupo", content).Result
                Else
                    oGroupClient.UserUpdate = AppUser
                    oGroupClient.DateUpdate = DateTime.Now
                    oGroupClient.IdGroup = IdGroup
                    Dim jsonSerialice As String = Newtonsoft.Json.JsonConvert.SerializeObject(oGroupClient)
                    Dim content As StringContent = New StringContent(jsonSerialice, Encoding.UTF8, "application/json")
                    Dim response2 As HttpResponseMessage = client.PutAsync(UrlTarifasRest + "/Group/UpdateGrupo", content).Result
                End If
            Catch ex As Exception
                Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
                DevExpress.XtraEditors.XtraMessageBox.Show("La actualización generó el siguiente error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        DevExpress.XtraEditors.XtraMessageBox.Show("Los datos se guardaron satisfactoriamente. ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        bbiRefresh.PerformClick()
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

    Private Sub LoadEstados()

        client.DefaultRequestHeaders.Accept.Add(
            New System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"))

        Dim response As HttpResponseMessage = client.GetAsync(
                               New Uri(UrlTarifasRest + "/Tipos/ObtenerTiposPorCriterio?Tipo_CodTabla=ETR")).Result

        If response.IsSuccessStatusCode Then
            Dim jsonString As String = response.Content.ReadAsStringAsync().Result
            'Dim bearerToken As String = DirectCast(
            '           JObject.Parse(json).SelectToken("access_token"),
            '                                String)
            'Return True
            'Else
            '    Return False

            Dim listTipos As List(Of TiposCliente) = Newtonsoft.Json.JsonConvert.DeserializeObject(Of List(Of TiposCliente))(jsonString)
            lueEstado.Properties.DataSource = listTipos
            lueEstado.Properties.DisplayMember = "TIPO_Desc1"
            lueEstado.Properties.ValueMember = "TIPO_CodTipo"
            lueEstado.ItemIndex = 0

        End If
    End Sub

End Class
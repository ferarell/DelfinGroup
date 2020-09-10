Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.DXErrorProvider
Imports System.Net.Http
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Text
Imports System.Configuration
Imports DevExpress.XtraGrid.Views.Grid

Public Class CompanyForm
    Public AppUser As String = "sistemas"
    'Dim oAttentionPointDAO As New AttentionPointDAO
    'Dim oAttentionPointBE As New AttentionPointBE
    'Dim oGeneralDAO As New GeneralDAO
    Dim client As HttpClient = New HttpClient
    Dim Index, IdAttentionPoint As Integer
    Dim IdCompany As Integer
    Dim UrlTarifasRest As String = ConfigurationManager.AppSettings("urlServiciosTarifa")

    Private Sub CompanyForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        SplitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2
        LoadMainData()
        LoadOperationType()
        LoadAppUser()
        LoadGrupos()
        LoadEstados()
        BarButtonEnabled()
    End Sub

    Private Sub bbiClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiClose.ItemClick
        Close()
    End Sub

    Private Sub bbiExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExport.ItemClick
        ExportToExcel(gcMainData)
    End Sub

    Private Sub bbiRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiRefresh.ItemClick
        BarButtonEnabled()
        LoadMainData()
        gcMainData.Enabled = True
        SplitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2
    End Sub

    Private Sub LoadMainData()

        client.DefaultRequestHeaders.Accept.Add(
            New System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"))

        Dim response As HttpResponseMessage = client.GetAsync(
                               New Uri(UrlTarifasRest + "/Company/ObtenerCompanies")).Result

        If response.IsSuccessStatusCode Then
            Dim jsonString As String = response.Content.ReadAsStringAsync().Result
            'Dim bearerToken As String = DirectCast(
            '           JObject.Parse(json).SelectToken("access_token"),
            '                                String)
            'Return True
            'Else
            '    Return False

            Dim listAtributos As List(Of CompanyClient) = Newtonsoft.Json.JsonConvert.DeserializeObject(Of List(Of CompanyClient))(jsonString)
            gcMainData.DataSource = listAtributos

        End If


        'Dim dtQuery As New DataTable
        'dtQuery = oAttentionPointDAO.AttentionPointSelect
        'gcMainData.DataSource = dtQuery
        'Refresh()
    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        BarButtonEnabled()

        Dim dgrItem As CompanyClient = GridView1.GetRow(GridView1.FocusedRowHandle)

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
        'vpInputs.SetValidationRule(Me.txtCodigo, customValidationRule)
        'vpInputs.SetValidationRule(Me.deDateFrom, customValidationRule)
        'vpInputs.SetValidationRule(Me.lueOperationType, customValidationRule)
        vpInputs.SetValidationRule(Me.lueGrupo, customValidationRule)
    End Sub

    Private Sub bbiInsert_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbiInsert.ItemClick
        Index = 0
        SplitContainerControl1.PanelVisibility = SplitPanelVisibility.Both
        SplitContainerControl1.Collapsed = False
        gcMainData.Enabled = False
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



        Dim dgrItem As CompanyClient = GridView1.GetRow(GridView1.FocusedRowHandle)
        If dgrItem IsNot Nothing Then
            IdCompany = dgrItem.IdCompany
            'ZWtxtCodigo.EditValue = dgrItem.CompanyCode 'dgrItem("GroupCode")
            txtDescripcion.EditValue = dgrItem.CompanyDescription 'dgrItem("GroupDescription")
            'oConditionClient.IdUnit = 5

            lueEstado.EditValue = dgrItem.CompanyStatus
            lueGrupo.EditValue = dgrItem.IdGroup

        End If


        'Dim dgrItem As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        'IdAttentionPoint = dgrItem("attention_point_id")
        'teUserDescription.EditValue = dgrItem("description")
        'deDateFrom.EditValue = dgrItem("valid_date_from")
        'deDateTo.EditValue = dgrItem("valid_date_to")
        'lueOperationType.ItemIndex = lueOperationType.Properties.GetDataSourceRowIndex("operation_type_id", dgrItem("operation_type_id"))
        'lueAppUser.ItemIndex = lueAppUser.Properties.GetDataSourceRowIndex("UserAccount", dgrItem("user_account"))
        'tsActive.EditValue = IIf(dgrItem("status") = "A", True, False)
        'tsConnected.EditValue = dgrItem("connected")
        'meConectionProperty.Text = dgrItem("connection_property")
    End Sub

    Private Sub bbiDelete_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbiDelete.ItemClick
        'If DevExpress.XtraEditors.XtraMessageBox.Show("La eliminación del registro seleccionado podría afectar la integridad de la información, desea continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
        '    oAttentionPointBE.attention_point_id = GridView1.GetDataRow(GridView1.FocusedRowHandle)("attention_point_id")
        '    If oAttentionPointDAO.AttentionPointDelete(oAttentionPointBE) Then
        '        bbiRefresh.PerformClick()
        '    End If
        'End If
        If DevExpress.XtraEditors.XtraMessageBox.Show("La eliminación del registro seleccionado podría afectar la integridad de la información, desea continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = System.Windows.Forms.DialogResult.Yes Then


            Dim dgrItem As CompanyClient = GridView1.GetRow(GridView1.FocusedRowHandle)
            dgrItem.CompanyStatus = "I"
            Dim jsonSerialice As String = Newtonsoft.Json.JsonConvert.SerializeObject(dgrItem)
            Dim content As StringContent = New StringContent(jsonSerialice, Encoding.UTF8, "application/json")
            Dim response2 As HttpResponseMessage = client.PutAsync(UrlTarifasRest + "/Company/UpdateCompania", content).Result
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

    Private Sub lueAppUser_Enter(sender As System.Object, e As System.EventArgs) Handles lueGrupo.Enter
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

        Dim oCompanyClient As CompanyClient = New CompanyClient()
        oCompanyClient.CompanyCode = "" 'txtCodigo.Text
        oCompanyClient.CompanyDescription = txtDescripcion.Text
        oCompanyClient.IdGroup = lueGrupo.EditValue
        oCompanyClient.CompanyStatus = lueEstado.EditValue.ToString().Trim()
        oCompanyClient.CompanyTaxCode = "" 'txtCompanyTaxCode.Text

        'oCompanyClient.UserCreate = 1
        'oCompanyClient.UserUpdate = 1





        If DevExpress.XtraEditors.XtraMessageBox.Show("Está seguro de guardar los cambios?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            Try
                If Index = 0 Then
                    oCompanyClient.UserCreate = AppUser
                    oCompanyClient.DateCreate = DateTime.Now
                    Dim jsonSerialice As String = Newtonsoft.Json.JsonConvert.SerializeObject(oCompanyClient)
                    Dim content As StringContent = New StringContent(jsonSerialice, Encoding.UTF8, "application/json")
                    Dim response2 As HttpResponseMessage = client.PostAsync(UrlTarifasRest + "/Company/InsertarCompania", content).Result
                Else
                    oCompanyClient.UserUpdate = AppUser
                    oCompanyClient.IdCompany = IdCompany
                    oCompanyClient.DateUpdate = DateTime.Now
                    Dim jsonSerialice As String = Newtonsoft.Json.JsonConvert.SerializeObject(oCompanyClient)
                    Dim content As StringContent = New StringContent(jsonSerialice, Encoding.UTF8, "application/json")
                    Dim response2 As HttpResponseMessage = client.PutAsync(UrlTarifasRest + "/Company/UpdateCompania", content).Result
                End If
            Catch ex As Exception
                Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
                DevExpress.XtraEditors.XtraMessageBox.Show("La actualización generó el siguiente error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        DevExpress.XtraEditors.XtraMessageBox.Show("Los datos se guardaron satisfactoriamente. ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        bbiRefresh.PerformClick()













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
        'If DevExpress.XtraEditors.XtraMessageBox.Show("Está seguro de guardar los cambios?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
        '    Try
        '        If Index = 0 Then
        '            oAttentionPointBE.user_cr = AppUser
        '            oAttentionPointBE.date_cr = Now
        '            oAttentionPointDAO.AttentionPointInsert(oAttentionPointBE)
        '        Else
        '            oAttentionPointBE.user_up = AppUser
        '            oAttentionPointBE.date_up = Now
        '            oAttentionPointDAO.AttentionPointUpdate(oAttentionPointBE)
        '        End If
        '    Catch ex As Exception
        '        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        '        DevExpress.XtraEditors.XtraMessageBox.Show("La actualización generó el siguiente error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    End Try
        'End If
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

    Private Sub GridView1_CustomUnboundColumnData(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles GridView1.CustomUnboundColumnData
        Dim View As GridView = TryCast(sender, GridView)
        Dim DescripcionGrupo As String = ""
        Dim companyRow As CompanyClient = TryCast(e.Row, CompanyClient)
        If companyRow IsNot Nothing Then
            Dim grupodesc As GroupClient = companyRow.Group
            DescripcionGrupo = grupodesc.GroupDescription
        Else
            DescripcionGrupo = ""
        End If
        If (e.Column.FieldName = "GroupDescription") Then
            e.Value = DescripcionGrupo
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

    Private Sub LoadGrupos()
        client.DefaultRequestHeaders.Accept.Add(
            New System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"))

        Dim response As HttpResponseMessage = client.GetAsync(
                               New Uri(UrlTarifasRest + "/Group/ObtenerGrupos")).Result

        If response.IsSuccessStatusCode Then
            Dim jsonString As String = response.Content.ReadAsStringAsync().Result

            Dim listGrupos As List(Of GroupClient) = Newtonsoft.Json.JsonConvert.DeserializeObject(Of List(Of GroupClient))(jsonString)
            Dim listGruposActivas As List(Of GroupClient) = listGrupos.FindAll(Function(x) x.GrouopStatus = "A")

            lueGrupo.Properties.DataSource = listGruposActivas
            lueGrupo.Properties.DisplayMember = "GroupDescription"
            lueGrupo.Properties.ValueMember = "IdGroup"
            lueGrupo.ItemIndex = 0

        End If
    End Sub


End Class
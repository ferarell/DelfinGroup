Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.DXErrorProvider
Imports System.Net.Http
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Text
Imports System.Configuration
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class AttributeForm
    Public AppUser As String = "sistemas"
    'Dim oAttentionPointDAO As New AttentionPointDAO
    'Dim oAttentionPointBE As New AttentionPointBE
    'Dim oGeneralDAO As New GeneralDAO
    Dim client As HttpClient = New HttpClient
    Dim Index, IdAttentionPoint As Integer
    Dim IdAttribute As Integer
    Dim UrlTarifasRest As String = ConfigurationManager.AppSettings("urlServiciosTarifa")

    Private Sub AttributeForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        SplitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2
        LoadMainData()
        LoadOperationType()
        LoadAppUser()
        LoadEstados()
        LoadUnidadesNegocio()
        LoadTipoDatos()
        BarButtonEnabled()
    End Sub

    Private Sub bbiClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiClose.ItemClick
        Close()
    End Sub

    Private Sub bbiExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExport.ItemClick
        ExportToExcel(gcMainDataAttribute)
    End Sub

    Private Sub bbiRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiRefresh.ItemClick
        BarButtonEnabled()
        LoadMainData()
        gcMainDataAttribute.Enabled = True
        SplitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2
    End Sub

    Private Sub LoadMainData()

        client.DefaultRequestHeaders.Accept.Add(
            New System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"))

        Dim response As HttpResponseMessage = client.GetAsync(
                               New Uri(UrlTarifasRest + "/Atributos/ObtenerAtributos")).Result

        If response.IsSuccessStatusCode Then
            Dim jsonString As String = response.Content.ReadAsStringAsync().Result
            'Dim bearerToken As String = DirectCast(
            '           JObject.Parse(json).SelectToken("access_token"),
            '                                String)
            'Return True
            'Else
            '    Return False

            Dim listAtributos As List(Of AttributeClient) = Newtonsoft.Json.JsonConvert.DeserializeObject(Of List(Of AttributeClient))(jsonString)
            gcMainDataAttribute.DataSource = listAtributos
            Refresh()

        End If


        'Dim dtQuery As New DataTable
        'dtQuery = oAttentionPointDAO.AttentionPointSelect
        'gcMainData.DataSource = dtQuery

    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        BarButtonEnabled()

        Dim dgrItem As AttributeClient = GridView1.GetRow(GridView1.FocusedRowHandle)

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
        'vpInputs.SetValidationRule(Me.lueAtributo, customValidationRule)
    End Sub

    Private Sub bbiInsert_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbiInsert.ItemClick
        Index = 0
        SplitContainerControl1.PanelVisibility = SplitPanelVisibility.Both
        SplitContainerControl1.Collapsed = False
        gcMainDataAttribute.Enabled = False
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

        For Each oInputs As Object In gcDestino.Controls
            If oInputs.ToString.Contains("TextEdit") Then
                oInputs.EditValue = ""
            ElseIf oInputs.ToString.Contains("ToggleSwitch") Then
                oInputs.EditValue = False
            End If
        Next


        For Each oInputs As Object In gcOrigen.Controls
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


        Dim dgrItem As AttributeClient = GridView1.GetRow(GridView1.FocusedRowHandle)
        If dgrItem IsNot Nothing Then
            IdAttribute = dgrItem.IdAttribute
            'txtCodigo.EditValue = dgrItem.AttributeCode 'dgrItem("GroupCode")
            txtDescripcion.EditValue = dgrItem.AttributeDescription 'dgrItem("GroupDescription")
            'oAttributeClient.IdUnit = 5
            lueUnidadNegocio.EditValue = dgrItem.IdBusinessUnit
            lueTipoDato.EditValue = dgrItem.FieldType
            lueEstado.EditValue = dgrItem.AttributeStatus
            txtValor.EditValue = dgrItem.FieldValue

            'ORIGEN
            txtBaseDatosOrigen.EditValue = dgrItem.SourceDatabase
            txtTablaOrigen.EditValue = dgrItem.SourceTable
            txtCampoOrigen.EditValue = dgrItem.SourceField

            'DESTINO


            txtBaseDatosDestino.EditValue = dgrItem.TargetDatabase
            txtTablaDestino.EditValue = dgrItem.TargetTable
            txtCampoDestino.EditValue = dgrItem.TargetField


            'txtImporteCompra.Text = dgrItem.CostsAmount.ToString()
            'txtImporteVenta.Text = dgrItem.SalesAmount.ToString()
            'txtDescripcionCorta.Text = dgrItem.AttributeShortDescription




            'lueTipoAtributo.EditValue = dgrItem.AttributeType

            'txtImporteCompra.Text = dgrItem.SalesAmount.ToString()
            'txtImporteVenta.Text = dgrItem.SalesAmount.ToString()



            'oAttributeClient.IdUnit = 5
            'oAttributeClient.Currency = "PEN"
            'oAttributeClient.AttributeType = "AC"
            'oAttributeClient.CostsAmount = Convert.ToDecimal(txtImporteCompra.Text)
            'oAttributeClient.SalesAmount = Convert.ToDecimal(txtImporteVenta.Text)
            'oAttributeClient.AttributeStatus = "A"

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


            'Dim dgrItem As AttributeClient = GridView1.GetRow(GridView1.FocusedRowHandle)
            'Dim jsonSerialice As String = Newtonsoft.Json.JsonConvert.SerializeObject(dgrItem)
            'Dim content As StringContent = New StringContent(jsonSerialice, Encoding.UTF8, "application/json")
            'Dim response2 As HttpResponseMessage = client.DeleteAsync(UrlTarifasRest + "/Atributos/DeleteAtributo" + "/" + dgrItem.IdAttribute.ToString()).Result

            'Dim jsonSerialice As String = Newtonsoft.Json.JsonConvert.SerializeObject(oAttributeClient)
            'Dim content As StringContent = New StringContent(jsonSerialice, Encoding.UTF8, "application/json")
            'Dim response2 As HttpResponseMessage = client.PutAsync(UrlTarifasRest + "/Atributos/UpdateAtributo", content).Result

            Dim dgrItem As AttributeClient = GridView1.GetRow(GridView1.FocusedRowHandle)
            dgrItem.AttributeStatus = "I"
            Dim jsonSerialice As String = Newtonsoft.Json.JsonConvert.SerializeObject(dgrItem)
            Dim content As StringContent = New StringContent(jsonSerialice, Encoding.UTF8, "application/json")
            Dim response2 As HttpResponseMessage = client.PutAsync(UrlTarifasRest + "/Atributos/UpdateAtributo", content).Result
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
        Dim oAttributeClient As AttributeClient = New AttributeClient()
        oAttributeClient.AttributeCode = "" '    txtCodigo.Text
        oAttributeClient.AttributeDescription = txtDescripcion.Text

        oAttributeClient.AttributeStatus = lueEstado.EditValue.ToString().Trim()
        oAttributeClient.IdBusinessUnit = lueUnidadNegocio.EditValue




        oAttributeClient.FieldType = lueTipoDato.EditValue
        oAttributeClient.AttributeStatus = lueEstado.EditValue.ToString().Trim()
        oAttributeClient.FieldValue = txtValor.Text

        'ORIGEN
        oAttributeClient.SourceDatabase = txtBaseDatosOrigen.Text
        oAttributeClient.SourceTable = txtTablaOrigen.Text
        oAttributeClient.SourceField = txtCampoOrigen.Text

        'DESTINO


        oAttributeClient.TargetDatabase = txtBaseDatosDestino.Text
        oAttributeClient.TargetTable = txtTablaDestino.Text
        oAttributeClient.TargetField = txtCampoDestino.Text


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
                    oAttributeClient.UserCreate = AppUser
                    oAttributeClient.DateCreate = DateTime.Now
                    'oAttributeClient.IdAttribute = -1
                    Dim jsonSerialice As String = Newtonsoft.Json.JsonConvert.SerializeObject(oAttributeClient)
                    Dim content As StringContent = New StringContent(jsonSerialice, Encoding.UTF8, "application/json")
                    Dim response2 As HttpResponseMessage = client.PostAsync(UrlTarifasRest + "/Atributos/InsertarAtributo", content).Result
                Else
                    oAttributeClient.UserUpdate = AppUser
                    oAttributeClient.DateUpdate = DateTime.Now
                    oAttributeClient.IdAttribute = IdAttribute
                    Dim jsonSerialice As String = Newtonsoft.Json.JsonConvert.SerializeObject(oAttributeClient)
                    Dim content As StringContent = New StringContent(jsonSerialice, Encoding.UTF8, "application/json")
                    Dim response2 As HttpResponseMessage = client.PutAsync(UrlTarifasRest + "/Atributos/UpdateAtributo", content).Result
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
            'lueUnidadNegocio.ItemIndex = 0

        End If
    End Sub

    Private Sub GridView1_DoubleClick(sender As Object, e As EventArgs) Handles GridView1.DoubleClick
        'Dim ea As DXMouseEventArgs = TryCast(e, DXMouseEventArgs)
        'Dim view As GridView = TryCast(sender, GridView)
        'Dim info As GridHitInfo = view.CalcHitInfo(ea.Location)
        'If info.InRow OrElse info.InRowCell Then
        '    Dim colCaption As String = If(info.Column Is Nothing, "N/A", info.Column.GetCaption())
        '    MessageBox.Show(String.Format("DoubleClick on row: {0}, column: {1}.", info.RowHandle, colCaption))
        'End If

        Index = 1
        SplitContainerControl1.PanelVisibility = SplitPanelVisibility.Both
        SplitContainerControl1.Collapsed = False
        EnableInputs(True)
        bbiSave.Enabled = True
        bbiInsert.Enabled = False
        bbiDelete.Enabled = False
        bbiEdit.PerformClick()
    End Sub


    Private Sub LoadTipoDatos()
        client.DefaultRequestHeaders.Accept.Add(
            New System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"))

        Dim response As HttpResponseMessage = client.GetAsync(
                               New Uri(UrlTarifasRest + "/Tipos/ObtenerTiposPorCriterio?Tipo_CodTabla=TDT")).Result

        If response.IsSuccessStatusCode Then
            Dim jsonString As String = response.Content.ReadAsStringAsync().Result
            Dim listTipos As List(Of TiposCliente) = Newtonsoft.Json.JsonConvert.DeserializeObject(Of List(Of TiposCliente))(jsonString)
            lueTipoDato.Properties.DataSource = listTipos
            lueTipoDato.Properties.DisplayMember = "TIPO_Desc1"
            lueTipoDato.Properties.ValueMember = "TIPO_CodTipo"
            lueTipoDato.ItemIndex = 0

        End If
    End Sub



    'Private Sub LoadTiposAtributo()
    '    client.DefaultRequestHeaders.Accept.Add(
    '        New System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"))

    '    Dim response As HttpResponseMessage = client.GetAsync(
    '                           New Uri("http://localhost:54180/api/Tipos/ObtenerTiposPorCriterio?Tipo_CodTabla=TCT")).Result

    '    If response.IsSuccessStatusCode Then
    '        Dim jsonString As String = response.Content.ReadAsStringAsync().Result
    '        Dim listTipos As List(Of TiposCliente) = Newtonsoft.Json.JsonConvert.DeserializeObject(Of List(Of TiposCliente))(jsonString)
    '        lueTipoAtributo.Properties.DataSource = listTipos
    '        lueTipoAtributo.Properties.DisplayMember = "TIPO_Desc1"
    '        lueTipoAtributo.Properties.ValueMember = "TIPO_CodTipo"
    '        lueTipoAtributo.ItemIndex = 0

    '    End If
    'End Sub



End Class
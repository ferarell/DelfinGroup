Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.DXErrorProvider
Imports System.Net.Http
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Text
Imports System.Configuration


Public Class ConceptForm
    Public AppUser As String = "sistemas"
    'Dim oAttentionPointDAO As New AttentionPointDAO
    'Dim oAttentionPointBE As New AttentionPointBE
    'Dim oGeneralDAO As New GeneralDAO
    Dim client As HttpClient = New HttpClient
    Dim Index, IdAttentionPoint As Integer
    Dim IdConcept As Integer
    Dim UrlTarifasRest As String = ConfigurationManager.AppSettings("urlServiciosTarifa")

    Private Sub ConceptForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        SplitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2
        LoadMainData()
        LoadOperationType()
        LoadAppUser()
        LoadEstados()
        'LoadUnidadesNegocio()
        'LoadUnidades()
        'LoadTiposConcepto()
        LoadCodigoERP()
        BarButtonEnabled()
    End Sub

    Private Sub bbiClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiClose.ItemClick
        Close()
    End Sub

    Private Sub bbiExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExport.ItemClick
        ExportToExcel(gcMainDataConcept)
    End Sub

    Private Sub bbiRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiRefresh.ItemClick
        BarButtonEnabled()
        LoadMainData()
        gcMainDataConcept.Enabled = True
        SplitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2
    End Sub

    Private Sub LoadMainData()

        client.DefaultRequestHeaders.Accept.Add(
            New System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"))

        Dim response As HttpResponseMessage = client.GetAsync(
                               New Uri(UrlTarifasRest + "/Concept/ObtenerConceptos")).Result

        If response.IsSuccessStatusCode Then
            Dim jsonString As String = response.Content.ReadAsStringAsync().Result
            'Dim bearerToken As String = DirectCast(
            '           JObject.Parse(json).SelectToken("access_token"),
            '                                String)
            'Return True
            'Else
            '    Return False

            Dim listConceptos As List(Of ConceptClient) = Newtonsoft.Json.JsonConvert.DeserializeObject(Of List(Of ConceptClient))(jsonString)
            gcMainDataConcept.DataSource = listConceptos
            Refresh()

        End If


        'Dim dtQuery As New DataTable
        'dtQuery = oAttentionPointDAO.AttentionPointSelect
        'gcMainData.DataSource = dtQuery

    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        BarButtonEnabled()

        Dim dgrItem As ConceptClient = GridView1.GetRow(GridView1.FocusedRowHandle)

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
        'vpInputs.SetValidationRule(Me.lueConcepto, customValidationRule)
    End Sub

    Private Sub bbiInsert_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbiInsert.ItemClick
        Index = 0
        SplitContainerControl1.PanelVisibility = SplitPanelVisibility.Both
        SplitContainerControl1.Collapsed = False
        gcMainDataConcept.Enabled = False
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


        Dim dgrItem As ConceptClient = GridView1.GetRow(GridView1.FocusedRowHandle)
        If dgrItem IsNot Nothing Then
            IdConcept = dgrItem.IdConcept
            'txtCodigo.EditValue = dgrItem.ConceptCode 'dgrItem("GroupCode")
            txtDescripcion.EditValue = dgrItem.ConceptDescription 'dgrItem("GroupDescription")
            'oConceptClient.IdUnit = 5

            'txtDescripcionCorta.Text = dgrItem.ConceptShortDescription


            lueEstado.EditValue = dgrItem.ConceptStatus
            'lueUnidad.EditValue = dgrItem.IdUnit

            'lueTipoConcepto.EditValue = dgrItem.ConceptType
            lueCodigoERP.EditValue = dgrItem.EquivalentCode
            'lueUnidadNegocio.EditValue = dgrItem.IdBusinessUnit

            'txtImporteCompra.Text = dgrItem.SalesAmount.ToString()
            'txtImporteVenta.Text = dgrI8tem.SalesAmount.ToString()



            'oConceptClient.IdUnit = 5
            'oConceptClient.Currency = "PEN"
            'oConceptClient.ConceptType = "AC"
            'oConceptClient.CostsAmount = Convert.ToDecimal(txtImporteCompra.Text)
            'oConceptClient.SalesAmount = Convert.ToDecimal(txtImporteVenta.Text)
            'oConceptClient.ConceptStatus = "A"

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


            Dim dgrItem As ConceptClient = GridView1.GetRow(GridView1.FocusedRowHandle)
            dgrItem.ConceptStatus = "I"
            Dim jsonSerialice As String = Newtonsoft.Json.JsonConvert.SerializeObject(dgrItem)
            Dim content As StringContent = New StringContent(jsonSerialice, Encoding.UTF8, "application/json")
            'Dim response2 As HttpResponseMessage = client.DeleteAsync(UrlTarifasRest + "/Concept/DeleteConcepto" + "/" + dgrItem.IdConcept.ToString()).Result
            Dim response2 As HttpResponseMessage = client.PutAsync(UrlTarifasRest + "/Concept/UpdateConcepto", content).Result
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
        Dim oConceptClient As ConceptClient = New ConceptClient()
        oConceptClient.ConceptCode = ""
        oConceptClient.ConceptDescription = txtDescripcion.Text
        oConceptClient.ConceptShortDescription = ""
        'oConceptClient.IdUnit = 5

        'oConceptClient.ConceptType = lueTipoConcepto.EditValue.ToString().Trim()

        oConceptClient.ConceptStatus = lueEstado.EditValue.ToString().Trim()
        'oConceptClient.IdUnit = lueUnidad.EditValue
        'oConceptClient.UserCreate = 1
        'oConceptClient.UserUpdate = 1
        oConceptClient.ConceptSource = "1"
        'oConceptClient.ConceptType = "S"
        'oConceptClient.IdBusinessUnit = lueUnidadNegocio.EditValue
        oConceptClient.EquivalentCode = lueCodigoERP.EditValue

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
                    oConceptClient.UserCreate = AppUser
                    oConceptClient.DateCreate = DateTime.Now
                    'oConceptClient.IdConcept = -1
                    Dim jsonSerialice As String = Newtonsoft.Json.JsonConvert.SerializeObject(oConceptClient)
                    Dim content As StringContent = New StringContent(jsonSerialice, Encoding.UTF8, "application/json")
                    Dim response2 As HttpResponseMessage = client.PostAsync(UrlTarifasRest + "/Concept/InsertarConcepto", content).Result
                Else
                    oConceptClient.UserUpdate = AppUser
                    oConceptClient.DateUpdate = DateTime.Now
                    oConceptClient.IdConcept = IdConcept
                    Dim jsonSerialice As String = Newtonsoft.Json.JsonConvert.SerializeObject(oConceptClient)
                    Dim content As StringContent = New StringContent(jsonSerialice, Encoding.UTF8, "application/json")
                    Dim response2 As HttpResponseMessage = client.PutAsync(UrlTarifasRest + "/Concept/UpdateConcepto", content).Result
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


    'Private Sub LoadUnidades()
    '    client.DefaultRequestHeaders.Accept.Add(
    '        New System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"))

    '    Dim response As HttpResponseMessage = client.GetAsync(
    '                           New Uri(UrlTarifasRest + "/Unit/ObtenerUnidades")).Result

    '    If response.IsSuccessStatusCode Then
    '        Dim jsonString As String = response.Content.ReadAsStringAsync().Result
    '        Dim listUnidades As List(Of UnitClient) = Newtonsoft.Json.JsonConvert.DeserializeObject(Of List(Of UnitClient))(jsonString)
    '        Dim listUnidadesActivas As List(Of UnitClient) = listUnidades.FindAll(Function(x) x.UnitStatus = "A")
    '        lueUnidad.Properties.DataSource = listUnidadesActivas
    '        lueUnidad.Properties.DisplayMember = "UnitCode"
    '        lueUnidad.Properties.ValueMember = "IdUnit"
    '        lueUnidad.ItemIndex = 0

    '    End If
    'End Sub







    'Private Sub LoadTiposConcepto()
    '    client.DefaultRequestHeaders.Accept.Add(
    '        New System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"))

    '    Dim response As HttpResponseMessage = client.GetAsync(
    '                           New Uri(UrlTarifasRest + "/Tipos/ObtenerTiposPorCriterio?Tipo_CodTabla=TCT")).Result

    '    If response.IsSuccessStatusCode Then
    '        Dim jsonString As String = response.Content.ReadAsStringAsync().Result
    '        Dim listTipos As List(Of TiposCliente) = Newtonsoft.Json.JsonConvert.DeserializeObject(Of List(Of TiposCliente))(jsonString)
    '        lueTipoConcepto.Properties.DataSource = listTipos
    '        lueTipoConcepto.Properties.DisplayMember = "TIPO_Desc1"
    '        lueTipoConcepto.Properties.ValueMember = "TIPO_CodTipo"
    '        lueTipoConcepto.ItemIndex = 0

    '    End If
    'End Sub


    'Private Sub LoadUnidadesNegocio()
    '    client.DefaultRequestHeaders.Accept.Add(
    '        New System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"))

    '    Dim response As HttpResponseMessage = client.GetAsync(
    '                           New Uri(UrlTarifasRest + "/UnidadesNegocio/ObtenerUnidadesNegocio")).Result

    '    If response.IsSuccessStatusCode Then
    '        Dim jsonString As String = response.Content.ReadAsStringAsync().Result
    '        Dim listUnidades As List(Of BusinessUnitClient) = Newtonsoft.Json.JsonConvert.DeserializeObject(Of List(Of BusinessUnitClient))(jsonString)
    '        Dim listUnidadesActivas As List(Of BusinessUnitClient) = listUnidades.FindAll(Function(x) x.BusinessUnitStatus = "A")
    '        lueUnidadNegocio.Properties.DataSource = listUnidadesActivas
    '        lueUnidadNegocio.Properties.DisplayMember = "BusinessUnitDescription"
    '        lueUnidadNegocio.Properties.ValueMember = "IdBusinessUnit"
    '        lueUnidadNegocio.ItemIndex = 0

    '    End If
    'End Sub



    Private Sub LoadCodigoERP()
        client.DefaultRequestHeaders.Accept.Add(
            New System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"))

        Dim response As HttpResponseMessage = client.GetAsync(
                               New Uri(UrlTarifasRest + "/Servicios/ObtenerTodosServicios")).Result

        If response.IsSuccessStatusCode Then
            Dim jsonString As String = response.Content.ReadAsStringAsync().Result
            Dim listServicios As List(Of COM_ServicioClient) = Newtonsoft.Json.JsonConvert.DeserializeObject(Of List(Of COM_ServicioClient))(jsonString)
            lueCodigoERP.Properties.DataSource = listServicios
            lueCodigoERP.Properties.DisplayMember = "SERV_Nombre_SPA"
            lueCodigoERP.Properties.ValueMember = "SERV_Codigo"
            lueCodigoERP.ItemIndex = 0

        End If
    End Sub


End Class
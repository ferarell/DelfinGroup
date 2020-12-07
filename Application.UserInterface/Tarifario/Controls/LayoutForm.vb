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


Public Class LayoutForm
    Public AppUser As String = "sistemas"
    'Dim oAttentionPointDAO As New AttentionPointDAO
    'Dim oAttentionPointBE As New AttentionPointBE
    'Dim oGeneralDAO As New GeneralDAO
    Dim client As HttpClient = New HttpClient
    Dim Index, IdAttentionPoint As Integer
    Dim IdLayout As Integer
    Dim UrlTarifasRest As String = ConfigurationManager.AppSettings("urlServiciosTarifa")
    Dim LayoutAttributeList As BindingList(Of LayoutAttributeClient)

    Private Sub LayoutForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        SplitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2
        LoadMainData()
        LoadOperationType()
        LoadAppUser()
        LoadEstados()
        LoadUnidadesNegocio()
        'LoadConceptos()
        LoadPaquetes()
        LoadCondicion()
        LoadAtributos()
        LoadAtributosCabecera()
        BarButtonEnabled()
        'GridView2.OptionsView.NewItemRowPosition = NewItemRowPosition.Top
    End Sub

    Private Sub bbiClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiClose.ItemClick
        Close()
    End Sub

    Private Sub bbiExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExport.ItemClick
        ExportToExcel(gcMainDataLayout)
    End Sub

    Private Sub bbiRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiRefresh.ItemClick
        BarButtonEnabled()
        LoadMainData()
        gcMainDataLayout.Enabled = True
        SplitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2
    End Sub

    Private Sub LoadMainData()

        client.DefaultRequestHeaders.Accept.Add(
            New System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"))

        Dim response As HttpResponseMessage = client.GetAsync(
                               New Uri(UrlTarifasRest + "/Layout/ObtenerLayouts")).Result

        If response.IsSuccessStatusCode Then
            Dim jsonString As String = response.Content.ReadAsStringAsync().Result
            'Dim bearerToken As String = DirectCast(
            '           JObject.Parse(json).SelectToken("access_token"),
            '                                String)
            'Return True
            'Else
            '    Return False


            Dim listLayouts As List(Of LayoutClient) = Newtonsoft.Json.JsonConvert.DeserializeObject(Of List(Of LayoutClient))(jsonString)
            gcMainDataLayout.DataSource = listLayouts


            'Dim listLayoutServices As List(Of LayoutAttributeClient) = Newtonsoft.Json.JsonConvert.DeserializeObject(Of List(Of LayoutAttributeClient))("")
            'gcServicios.DataSource = listLayoutServices




            Refresh()

        End If


        'Dim dtQuery As New DataTable
        'dtQuery = oAttentionPointDAO.AttentionPointSelect
        'gcMainData.DataSource = dtQuery

    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        BarButtonEnabled()

        Dim dgrItem As LayoutClient = GridView1.GetRow(GridView1.FocusedRowHandle)

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
        'vpInputs.SetValidationRule(Me.lueLayout, customValidationRule)
    End Sub

    Private Sub bbiInsert_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbiInsert.ItemClick
        Index = 0
        SplitContainerControl1.PanelVisibility = SplitPanelVisibility.Both
        SplitContainerControl1.Collapsed = False
        gcMainDataLayout.Enabled = False
        ClearInputs(txtDescripcion)
        EnableInputs(True)
        bbiSave.Enabled = True
        bbiEdit.Enabled = False
        bbiDelete.Enabled = False
        LayoutAttributeList = New BindingList(Of LayoutAttributeClient)()


    End Sub

    Private Sub ClearInputs(ControlFocused As Object)
        For Each oInputs As Object In SplitContainer1.Panel1.Controls
            If oInputs.ToString.Contains("TextEdit") Then
                oInputs.EditValue = ""
            ElseIf oInputs.ToString.Contains("ToggleSwitch") Then
                oInputs.EditValue = False
            End If
        Next
        Dim listLayoutAttributes As BindingList(Of LayoutAttributeClient) = New BindingList(Of LayoutAttributeClient)()
        gcAtributos.DataSource = listLayoutAttributes
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


        Dim dgrItem As LayoutClient = GridView1.GetRow(GridView1.FocusedRowHandle)
        If dgrItem IsNot Nothing Then
            IdLayout = dgrItem.IdLayout
            'txtCodigo.EditValue = dgrItem.LayoutCode 'dgrItem("GroupCode")
            txtDescripcion.EditValue = dgrItem.LayoutDescription 'dgrItem("Gro3upDescription")
            'oLayoutClient.IdUnit = 5

            lueEstado.EditValue = dgrItem.LayoutStatus
            lueUnidadNegocio.EditValue = dgrItem.IdBusinessUnit



            'luePack.EditValue = dgrItem.IdPack
            lueCondicion.EditValue = dgrItem.IdCondition
            'lueConcepto.EditValue = dgrItem.IdConcept
            'gcServicios.DataSource = dgrItem.LayoutAttribute
            'txtImporteCompra.Text = dgrItem.SalesAmount.ToString()
            'txtImporteVenta.Text = dgrItem.SalesAmount.ToString()

            'If dgrItem.LayoutAttribute.Count > 0 Then

            LayoutAttributeList = New BindingList(Of LayoutAttributeClient)(dgrItem.LayoutAttribute.ToList())

            For Each item As LayoutAttributeClient In LayoutAttributeList
                item.AttributeDescription = ObtenerDescripcion(item.IdAttribute, item.Value)
            Next

            gcAtributos.DataSource = LayoutAttributeList
            'End If


            'oLayoutClient.LayoutAttribute = LayoutAttributeList

            'oLayoutClient.IdUnit = 5
            'oLayoutClient.Currency = "PEN"
            'oLayoutClient.LayoutType = "AC"
            'oLayoutClient.CostsAmount = Convert.ToDecimal(txtImporteCompra.Text)
            'oLayoutClient.SalesAmount = Convert.ToDecimal(txtImporteVenta.Text)
            'oLayoutClient.LayoutStatus = "A"

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


            Dim dgrItem As LayoutClient = GridView1.GetRow(GridView1.FocusedRowHandle)
            dgrItem.LayoutStatus = "I"
            Dim jsonSerialice As String = Newtonsoft.Json.JsonConvert.SerializeObject(dgrItem)
            Dim content As StringContent = New StringContent(jsonSerialice, Encoding.UTF8, "application/json")
            'Dim response2 As HttpResponseMessage = client.DeleteAsync(UrlTarifasRest + "/Layout/DeleteLayout" + "/" + dgrItem.IdLayout.ToString()).Result
            Dim response2 As HttpResponseMessage = client.PutAsync(UrlTarifasRest + "/Layout/UpdateLayout", content).Result
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
        Dim oLayoutClient As LayoutClient = New LayoutClient()
        oLayoutClient.LayoutCode = "" 'txtCodigo.Text
        oLayoutClient.LayoutDescription = txtDescripcion.Text

        'oLayoutClient.IdUnit = 5



        oLayoutClient.IdBusinessUnit = lueUnidadNegocio.EditValue

        oLayoutClient.LayoutStatus = lueEstado.EditValue.ToString().Trim()


        'oLayoutClient.IdConcept = lueConcepto.EditValue
        oLayoutClient.IdCondition = lueCondicion.EditValue
        oLayoutClient.IdPack = luePack.EditValue


        Dim LayoutAttributeList As BindingList(Of LayoutAttributeClient) = New BindingList(Of LayoutAttributeClient)((TryCast(gcAtributos.DataSource, IEnumerable(Of LayoutAttributeClient))).ToList())
        oLayoutClient.LayoutAttribute = LayoutAttributeList


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
                    oLayoutClient.UserCreate = AppUser
                    oLayoutClient.DateCreate = DateTime.Now

                    IdLayout = Nothing
                    For Each item As LayoutAttributeClient In oLayoutClient.LayoutAttribute
                        item.IdLayout = IdLayout
                        item.IdLayoutAttribute = Nothing
                    Next



                    Dim jsonSerialice As String = Newtonsoft.Json.JsonConvert.SerializeObject(oLayoutClient)
                    Dim content As StringContent = New StringContent(jsonSerialice, Encoding.UTF8, "application/json")
                    Dim response2 As HttpResponseMessage = client.PostAsync(UrlTarifasRest + "/Layout/InsertarLayout", content).Result
                Else
                    oLayoutClient.UserUpdate = AppUser
                    oLayoutClient.DateUpdate = DateTime.Now
                    oLayoutClient.IdLayout = IdLayout
                    Dim jsonSerialice As String = Newtonsoft.Json.JsonConvert.SerializeObject(oLayoutClient)
                    Dim content As StringContent = New StringContent(jsonSerialice, Encoding.UTF8, "application/json")
                    Dim response2 As HttpResponseMessage = client.PutAsync(UrlTarifasRest + "/Layout/UpdateLayout", content).Result
                End If
            Catch ex As Exception
                Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
                DevExpress.XtraEditors.XtraMessageBox.Show("La actualización generó el siguiente error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        DevExpress.XtraEditors.XtraMessageBox.Show("Los datos se guardaron satisfactoriamente. ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        bbiRefresh.PerformClick()
    End Sub



    Private Function ObtenerDescripcion(idAtributo As Integer, Valor As String) As String
        Dim jsonString As String = ""
        Dim DescripcionAtributo As String = ""
        client.DefaultRequestHeaders.Accept.Add(
            New System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"))

        Dim response As HttpResponseMessage = client.GetAsync(
                               New Uri(UrlTarifasRest + "/Atributos/ObtenerDescripcionValorAtributo?id=" + idAtributo.ToString + "&Valor=" + Valor)).Result

        If response.IsSuccessStatusCode Then
            'jsonString = response.Content.ReadAsStringAsync().Result
            jsonString = response.Content.ReadAsStringAsync().Result
            Dim listDescriptions As List(Of String) = Newtonsoft.Json.JsonConvert.DeserializeObject(Of List(Of String))(jsonString)
            For Each item As String In listDescriptions
                DescripcionAtributo = item
            Next


        End If

        Return DescripcionAtributo
    End Function


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

    Private Sub gcServicios_EmbeddedNavigator_ButtonClick(sender As Object, e As NavigatorButtonClickEventArgs) Handles gcAtributos.EmbeddedNavigator.ButtonClick
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






    Private Sub GridView2_InitNewRow(sender As Object, e As InitNewRowEventArgs)

        Dim view As GridView = CType(sender, GridView)


        If Index = 0 Then
            view.SetRowCellValue(e.RowHandle, view.Columns("UserCreate"), AppUser)
            view.SetRowCellValue(e.RowHandle, view.Columns("DateCreate"), Date.Today)

        Else
            view.SetRowCellValue(e.RowHandle, view.Columns("UserUpdate"), AppUser)
            view.SetRowCellValue(e.RowHandle, view.Columns("DateUpdate"), Date.Today)
            view.SetRowCellValue(e.RowHandle, view.Columns("IdLayout"), IdLayout)
        End If




    End Sub

    Private Sub LoadAtributos()
        client.DefaultRequestHeaders.Accept.Add(
            New System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"))

        Dim response As HttpResponseMessage = client.GetAsync(
                               New Uri(UrlTarifasRest + "/Atributos/ObtenerAtributos")).Result

        If response.IsSuccessStatusCode Then
            Dim jsonString As String = response.Content.ReadAsStringAsync().Result
            Dim listatributos As List(Of AttributeClient) = Newtonsoft.Json.JsonConvert.DeserializeObject(Of List(Of AttributeClient))(jsonString)
            rilueAtributo.DataSource = listatributos
            rilueAtributo.DisplayMember = "AttributeDescription"
            rilueAtributo.ValueMember = "IdAttribute"
            'rilueConcepto.ItemIndex = 0

        End If
    End Sub






    Private Sub LoadAtributosCabecera()
        client.DefaultRequestHeaders.Accept.Add(
            New System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"))

        Dim response As HttpResponseMessage = client.GetAsync(
                               New Uri(UrlTarifasRest + "/Atributos/ObtenerAtributos")).Result

        If response.IsSuccessStatusCode Then
            Dim jsonString As String = response.Content.ReadAsStringAsync().Result
            Dim listatributos As List(Of AttributeClient) = Newtonsoft.Json.JsonConvert.DeserializeObject(Of List(Of AttributeClient))(jsonString)


            Dim listatributosActivas As List(Of AttributeClient) = listatributos.FindAll(Function(x) x.AttributeStatus = "A")


            lueAtributo.Properties.DataSource = listatributosActivas
            lueAtributo.Properties.DisplayMember = "AttributeDescription"
            lueAtributo.Properties.ValueMember = "IdAttribute"
            lueAtributo.ItemIndex = 0

        End If
    End Sub



    Private Sub gcServicios_ProcessGridKey(sender As Object, e As KeyEventArgs)
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








    'Private Sub LoadTiposLayout()
    '    client.DefaultRequestHeaders.Accept.Add(
    '        New System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"))

    '    Dim response As HttpResponseMessage = client.GetAsync(
    '                           New Uri(UrlTarifasRest + "/Tipos/ObtenerTiposPorCriterio?Tipo_CodTabla=TCT")).Result

    '    If response.IsSuccessStatusCode Then
    '        Dim jsonString As String = response.Content.ReadAsStringAsync().Result
    '        Dim listTipos As List(Of TiposCliente) = Newtonsoft.Json.JsonConvert.DeserializeObject(Of List(Of TiposCliente))(jsonString)
    '        lueTipoLayout.Properties.DataSource = listTipos
    '        lueTipoLayout.Properties.DisplayMember = "TIPO_Desc1"
    '        lueTipoLayout.Properties.ValueMember = "TIPO_CodTipo"
    '        lueTipoLayout.ItemIndex = 0

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
            Dim listConceptsActivas As List(Of ConceptClient) = listConcepts.FindAll(Function(x) x.ConceptStatus = "A")
            lueConcepto.Properties.DataSource = listConceptsActivas
            lueConcepto.Properties.DisplayMember = "ConceptDescription"
            lueConcepto.Properties.ValueMember = "IdConcept"
            lueConcepto.ItemIndex = 0

        End If
    End Sub

    Private Sub LoadCondicion()
        client.DefaultRequestHeaders.Accept.Add(
            New System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"))

        Dim response As HttpResponseMessage = client.GetAsync(
                               New Uri(UrlTarifasRest + "/Condition/ObtenerCondiciones")).Result

        If response.IsSuccessStatusCode Then
            Dim jsonString As String = response.Content.ReadAsStringAsync().Result
            Dim listConditions As List(Of ConditionClient) = Newtonsoft.Json.JsonConvert.DeserializeObject(Of List(Of ConditionClient))(jsonString)
            Dim listConditionsActivas As List(Of ConditionClient) = listConditions.FindAll(Function(x) x.ConditionStatus = "A")
            lueCondicion.Properties.DataSource = listConditionsActivas
            lueCondicion.Properties.DisplayMember = "ConditionDescription"
            lueCondicion.Properties.ValueMember = "IdCondition"
            lueCondicion.ItemIndex = 0

        End If
    End Sub



    Private Sub LoadPaquetes()
        client.DefaultRequestHeaders.Accept.Add(
            New System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"))

        Dim response As HttpResponseMessage = client.GetAsync(
                               New Uri(UrlTarifasRest + "/Pack/ObtenerPaquetes")).Result

        If response.IsSuccessStatusCode Then
            Dim jsonString As String = response.Content.ReadAsStringAsync().Result
            Dim listPaquetes As List(Of PackClient) = Newtonsoft.Json.JsonConvert.DeserializeObject(Of List(Of PackClient))(jsonString)
            Dim listPaquetesActivas As List(Of PackClient) = listPaquetes.FindAll(Function(x) x.PackStatus = "A")
            luePack.Properties.DataSource = listPaquetesActivas
            luePack.Properties.DisplayMember = "PackDescription"
            luePack.Properties.ValueMember = "IdPack"
            luePack.ItemIndex = 0

        End If
    End Sub

    Private Sub rilueAtributo_EditValueChanged(sender As Object, e As EventArgs)
        Dim edit As LookUpEdit = CType(sender, LookUpEdit)
        Dim test1 As String = edit.Text
        Dim iest2 As Object = edit.EditValue
        LoadValoresAtributos(CType(edit.EditValue, Integer))
    End Sub
    Private Sub LoadValoresAtributos(idAtributo As Integer)
        client.DefaultRequestHeaders.Accept.Add(
            New System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"))

        Dim response As HttpResponseMessage = client.GetAsync(
                               New Uri(UrlTarifasRest + "/Atributos/GetValuesByAtributo?id=" + idAtributo.ToString())).Result

        If response.IsSuccessStatusCode Then
            Dim jsonString As String = response.Content.ReadAsStringAsync().Result
            Dim listResultados As List(Of uspValueAttributes_ResultClient) = Newtonsoft.Json.JsonConvert.DeserializeObject(Of List(Of uspValueAttributes_ResultClient))(jsonString)


            lueValor.Properties.DataSource = listResultados
            lueValor.Properties.DisplayMember = "Descripcion"
            lueValor.Properties.ValueMember = "Codigo"
            lueValor.ItemIndex = 0
        End If
    End Sub

    Private Sub lueAtributo_EditValueChanged(sender As Object, e As EventArgs) Handles lueAtributo.EditValueChanged
        Dim edit As LookUpEdit = CType(sender, LookUpEdit)
        Dim test1 As String = edit.Text
        Dim iest2 As Object = edit.EditValue
        LoadValoresAtributos(CType(edit.EditValue, Integer))
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click



        Dim oLayoutAttributeClient As LayoutAttributeClient = New LayoutAttributeClient()
        oLayoutAttributeClient.Value = lueValor.EditValue.ToString()
        oLayoutAttributeClient.IdAttribute = lueAtributo.EditValue
        oLayoutAttributeClient.AttributeDescription = lueValor.Text

        If Index = 0 Then
            oLayoutAttributeClient.UserCreate = AppUser
            oLayoutAttributeClient.DateCreate = Date.Today

        Else
            oLayoutAttributeClient.UserUpdate = AppUser
            oLayoutAttributeClient.DateUpdate = Date.Today
            oLayoutAttributeClient.IdLayout = IdLayout
        End If
        LayoutAttributeList.Add(oLayoutAttributeClient)
        gcAtributos.DataSource = LayoutAttributeList
    End Sub

    Private Sub gcAtributos_ProcessGridKey(sender As Object, e As KeyEventArgs) Handles gcAtributos.ProcessGridKey
        If e.KeyCode = Keys.Delete AndAlso e.Modifiers = Keys.Control Then
            If XtraMessageBox.Show("Delete row(s)?", "Delete rows dialog", MessageBoxButtons.YesNo) <> DialogResult.Yes Then Return
            Dim grid As GridControl = TryCast(sender, GridControl)
            Dim view As GridView = TryCast(grid.FocusedView, GridView)
            view.DeleteSelectedRows()
        End If
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
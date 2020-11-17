Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraLayout
Imports DevExpress.XtraNavBar

Public Class LogisticOperationRegisterForm
    Dim oAppService As New AppService.DelfinServiceClient
    Dim oMasterDataList As New MasterDataList
    Dim dsOperationRelated, dsLogisticOperation As New DataSet
    Dim dtOriginalService, dtOriginalChangeControl As New DataTable
    Friend InternalCode, _EMPR_Codigo, _SUCR_Codigo, _CCOT_Numero, _CCOT_Tipo As Integer
    'Friend InternalCode As Integer
    Friend drSource As DataRow
    Friend AppUser As String = "sistemas"

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        dsLogisticOperation = Nothing
        GridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.Top
        GridView5.OptionsView.NewItemRowPosition = NewItemRowPosition.Top
    End Sub

    Public Property EnableAutoTabOrder As Boolean = False

    Private Sub LogisticOperationRegisterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'NavBarGroup4.Visible = False
        ExpandAllGroups()
        NavBarGroup4.Expanded = False
        tsSADA.Properties.ReadOnly = True
        tsIMO.Properties.ReadOnly = True
        LoadOperationRelated()
        LoadEntityDataList(1, "lueCliente")
        LoadEntityDataList(5, "lueTransportista")
        LoadEntityDataList(11, "lueAgenciaMaritima")
        LoadEntityDataList(14, "lueAlmacen")
        LoadEntityDataList(17, "lueTerminalPortuario")
        LoadEntityDataList(0, "RepositoryItemLookUpEdit3")
        LoadEntityDataList(0, "RepositoryItemLookUpEdit8")
        LoadCargoCondition()
        LoadCommodity()
        LoadEntityType()
        LoadService()
        LoadBaseUnit()
        LoadCurrency()
        LoadBusinessUnit()
        LoadRegimen
        LoadVia
        teHBL.Focus()

        If InternalCode = -1 Then 'New Item
            NewItem()
        ElseIf InternalCode >= 0 Then 'Edit Item
            SetItem()
        End If

        'LoadTariff(InternalCode)

    End Sub

    Private Sub LoadRegimen()
        Dim dtQuery As New DataTable
        dtQuery = oMasterDataList.LoadMasterData("Regimen", Nothing)
        lueRegimen.Properties.DataSource = dtQuery
        lueRegimen.Properties.DisplayMember = "DescripcionRegimen"
        lueRegimen.Properties.ValueMember = "CodigoRegimen"
    End Sub

    Private Sub LoadVia()
        Dim dtQuery As New DataTable
        dtQuery = oMasterDataList.LoadMasterData("Via", Nothing)
        lueVia.Properties.DataSource = dtQuery
        lueVia.Properties.DisplayMember = "DescripcionVia"
        lueVia.Properties.ValueMember = "CodigoVia"
    End Sub

    Private Sub LoadBusinessUnit()
        Dim dtQuery As New DataTable
        dtQuery = oMasterDataList.LoadMasterData("BusinessUnit", Nothing)
        lueUnidadNegocio.Properties.DataSource = dtQuery
        lueUnidadNegocio.Properties.DisplayMember = "DescripcionLineaNegocio"
        lueUnidadNegocio.Properties.ValueMember = "CodigoLineaNegocio"
        RepositoryItemLookUpEdit11.DataSource = dtQuery
        RepositoryItemLookUpEdit11.DisplayMember = "DescripcionLineaNegocio"
        RepositoryItemLookUpEdit11.ValueMember = "CodigoLineaNegocio"
        RepositoryItemLookUpEdit12.DataSource = dtQuery
        RepositoryItemLookUpEdit12.DisplayMember = "DescripcionLineaNegocio"
        RepositoryItemLookUpEdit12.ValueMember = "CodigoLineaNegocio"
    End Sub

    Private Sub LoadCommodity()
        Dim dtQuery As New DataTable
        dtQuery = oMasterDataList.LoadMasterData("Commodity", Nothing)
        lueTipoMercancia.Properties.DataSource = dtQuery
        lueTipoMercancia.Properties.DisplayMember = "DescripcionTipoCommodity"
        lueTipoMercancia.Properties.ValueMember = "CodigoTipoCommodity"
    End Sub

    Private Sub LoadEntityType()
        Dim dtQuery As New DataTable
        dtQuery = oMasterDataList.LoadMasterData("EntityType", Nothing)
        RepositoryItemLookUpEdit2.DataSource = dtQuery
        RepositoryItemLookUpEdit2.DisplayMember = "DescripcionTipoEntidad"
        RepositoryItemLookUpEdit2.ValueMember = "CodigoTipoEntidad"
        RepositoryItemLookUpEdit7.DataSource = dtQuery
        RepositoryItemLookUpEdit7.DisplayMember = "DescripcionTipoEntidad"
        RepositoryItemLookUpEdit7.ValueMember = "CodigoTipoEntidad"
    End Sub

    Private Sub LoadService()
        Dim dtQuery As New DataTable
        dtQuery = oMasterDataList.LoadMasterData("Service", Nothing)
        RepositoryItemLookUpEdit1.DataSource = dtQuery
        RepositoryItemLookUpEdit1.DisplayMember = "DescripcionServicio"
        RepositoryItemLookUpEdit1.ValueMember = "CodigoServicio"
        RepositoryItemLookUpEdit5.DataSource = dtQuery
        RepositoryItemLookUpEdit5.DisplayMember = "DescripcionServicio"
        RepositoryItemLookUpEdit5.ValueMember = "CodigoServicio"
    End Sub

    Private Sub LoadBaseUnit()
        Dim dtQuery As New DataTable
        dtQuery = oMasterDataList.LoadMasterData("BaseUnit", Nothing)
        RepositoryItemLookUpEdit4.DataSource = dtQuery
        RepositoryItemLookUpEdit4.DisplayMember = "DescripcionUnidadBase"
        RepositoryItemLookUpEdit4.ValueMember = "CodigoUnidadBase"
        RepositoryItemLookUpEdit6.DataSource = dtQuery
        RepositoryItemLookUpEdit6.DisplayMember = "DescripcionUnidadBase"
        RepositoryItemLookUpEdit6.ValueMember = "CodigoUnidadBase"
    End Sub

    Private Sub LoadEntityDataList(EntityType As Integer, ControlName As String)
        Dim dtQuery As New DataTable
        Dim aParams As New ArrayList
        If EntityType > 0 Then
            aParams.Add(EntityType.ToString)
        End If
        dtQuery = oMasterDataList.LoadMasterData("EntityByType", aParams)
        If ControlName = "lueCliente" Then
            lueCliente.Properties.DataSource = dtQuery
            lueCliente.Properties.DisplayMember = "DescripcionEntidad"
            lueCliente.Properties.ValueMember = "CodigoEntidad"
        ElseIf ControlName.Contains({"lueTransportista", "lueTransportistaTerrestre"}) Then
            lueTransportista.Properties.DataSource = dtQuery
            lueTransportista.Properties.DisplayMember = "DescripcionEntidad"
            lueTransportista.Properties.ValueMember = "CodigoEntidad"
            lueTransportistaTerrestre.Properties.DataSource = dtQuery
            lueTransportistaTerrestre.Properties.DisplayMember = "DescripcionEntidad"
            lueTransportistaTerrestre.Properties.ValueMember = "CodigoEntidad"
        ElseIf ControlName = "lueAgenciaMaritima" Then
            dtQuery = oMasterDataList.LoadMasterData("EntityByType", aParams)
            lueAgenciaMaritima.Properties.DataSource = dtQuery
            lueAgenciaMaritima.Properties.DisplayMember = "DescripcionEntidad"
            lueAgenciaMaritima.Properties.ValueMember = "CodigoEntidad"
        ElseIf ControlName = "lueAlmacen" Then
            lueAlmacen.Properties.DataSource = dtQuery
            lueAlmacen.Properties.DisplayMember = "DescripcionEntidad"
            lueAlmacen.Properties.ValueMember = "CodigoEntidad"
        ElseIf ControlName = "lueTerminalPortuario" Then
            lueTerminalPortuario.Properties.DataSource = dtQuery
            lueTerminalPortuario.Properties.DisplayMember = "DescripcionEntidad"
            lueTerminalPortuario.Properties.ValueMember = "CodigoEntidad"
        ElseIf ControlName = "RepositoryItemLookUpEdit3" Then
            RepositoryItemLookUpEdit3.DataSource = dtQuery
            RepositoryItemLookUpEdit3.DisplayMember = "DescripcionEntidad"
            RepositoryItemLookUpEdit3.ValueMember = "CodigoEntidad"
        ElseIf ControlName = "RepositoryItemLookUpEdit8" Then
            RepositoryItemLookUpEdit8.DataSource = dtQuery
            RepositoryItemLookUpEdit8.DisplayMember = "DescripcionEntidad"
            RepositoryItemLookUpEdit8.ValueMember = "CodigoEntidad"
        End If

    End Sub

    'Private Sub LoadTariff(InternalCode As Integer)
    '    If dsOperationRelated.Tables.Count = 0 Then
    '        Return
    '    End If
    '    Dim dtQuery As New DataTable
    '    Dim ValidityDate As String = Format(Date.Now, "yyyyMMdd")
    '    Dim IdBusinessUnit As Integer = 2 'SLI
    '    Dim IdTariff As Integer = Nothing
    '    Dim drHeader As DataRow = Nothing
    '    If dsOperationRelated.Tables(0).Rows.Count > 0 Then
    '        drHeader = dsOperationRelated.Tables(0).Rows(0)
    '    End If
    '    If InternalCode >= 0 Then
    '        If Not IsDBNull(dsOperationRelated.Tables(0).Rows(0)("CTAR_Codigo")) Then
    '            IdTariff = dsOperationRelated.Tables(0).Rows(0)("CTAR_Codigo")
    '        End If
    '    End If
    '    Dim ENTC_CodTransportista As String = "NULL"
    '    Dim ENTC_CodCliente As String = "NULL"
    '    Dim ENTC_CodAgenPort As String = "NULL"
    '    Dim ENTC_CodTermPort As String = "NULL"
    '    Dim ENTC_CodDepTemporal As String = "NULL"
    '    Dim NVIA_Codigo As String = "NULL"
    '    Dim COPE_HBL As String = "NULL"
    '    Dim COPE_MBL As String = "NULL"
    '    Dim CONS_CodVia As String = "NULL"
    '    If Not IsDBNull(drHeader("CONS_CodVia")) Then
    '        CONS_CodVia = drHeader("CONS_CodVia")
    '    End If
    '    If lueTransportista.ItemIndex >= 0 And CONS_CodVia <> "003" Then
    '        ENTC_CodTransportista = lueTransportista.EditValue
    '    End If
    '    If lueTransportistaTerrestre.ItemIndex >= 0 And CONS_CodVia = "003" Then
    '        ENTC_CodTransportista = lueTransportistaTerrestre.EditValue
    '    End If
    '    Dim _Query As String = "EXEC NextSoft.tar.upGetTariffByFilter "
    '    _Query += "'" & ValidityDate & "', "
    '    _Query += IdBusinessUnit & ", "
    '    _Query += IdTariff & ", "
    '    _Query += ENTC_CodTransportista & ", "
    '    _Query += ENTC_CodCliente & ", "
    '    _Query += ENTC_CodAgenPort & ", "
    '    _Query += ENTC_CodTermPort & ", "
    '    _Query += ENTC_CodDepTemporal & ", "
    '    _Query += NVIA_Codigo & ", "
    '    _Query += COPE_HBL & ", "
    '    _Query += COPE_MBL & ", "
    '    _Query += CONS_CodVia
    '    dtQuery = oAppService.ExecuteSQL(_Query).Tables(0)
    '    lueTarifa.Properties.DataSource = dtQuery
    '    lueTarifa.Properties.DisplayMember = "IdTariff"
    '    lueTarifa.Properties.ValueMember = "IdTariff"
    'End Sub

    Private Sub LoadCargoCondition()
        Dim dtQuery As New DataTable
        dtQuery = oMasterDataList.LoadMasterData("CargoCondition", Nothing)
        lueCondicionEmbarque.Properties.DataSource = dtQuery
        lueCondicionEmbarque.Properties.DisplayMember = "DescripcionCondicionEmbarque"
        lueCondicionEmbarque.Properties.ValueMember = "CodigoCondicionEmbarque"
    End Sub

    Private Sub LoadCurrency()
        Dim dtQuery As New DataTable
        dtQuery = oMasterDataList.LoadMasterData("Currency", Nothing)
        lueMoneda.Properties.DataSource = dtQuery
        lueMoneda.Properties.DisplayMember = "DescripcionMoneda"
        lueMoneda.Properties.ValueMember = "CodigoMoneda"
        RepositoryItemLookUpEdit9.DataSource = dtQuery
        RepositoryItemLookUpEdit9.DisplayMember = "DescripcionMoneda"
        RepositoryItemLookUpEdit9.ValueMember = "CodigoMoneda"
        RepositoryItemLookUpEdit10.DataSource = dtQuery
        RepositoryItemLookUpEdit10.DisplayMember = "DescripcionMoneda"
        RepositoryItemLookUpEdit10.ValueMember = "CodigoMoneda"
    End Sub

    Private Sub LoadOperationRelated()
        'dsOperationRelated = oAppService.ExecuteSQL("EXEC NextSoft.dgp.paObtieneOperacionesLogisticasRelacionadas '" & sHBL & "'")
    End Sub

    Private Sub NewItem()
        If drSource Is Nothing Then
            Return
        End If
        beTarifa.Properties.ReadOnly = False
        Dim dsQuery As New DataSet
        dsQuery = oAppService.ExecuteSQL("EXEC NextSoft.dgp.paConsultaOrdenVenta '" & drSource("COPE_HBL") & "'")
        Dim drQuery As DataRow = dsQuery.Tables(0)(0)

        'Datos Generales
        deFechaEmision.EditValue = Today
        teHBL.EditValue = drQuery("DOOV_HBL")
        teMBL.EditValue = drQuery("DOOV_MBL")
        lueMoneda.EditValue = drQuery("TIPO_CodMND")
        lueCliente.EditValue = drQuery("ENTC_CodCliente")
        lueTransportista.EditValue = drQuery("ENTC_CodTransportista")
        lueAlmacen.EditValue = drQuery("ENTC_CodDepTemporal")
        lueAgenciaMaritima.EditValue = drQuery("DOOV_MBL")
        lueTerminalPortuario.EditValue = drQuery("ENTC_CodTermPort")
        lueCondicionEmbarque.EditValue = drQuery("CONS_CodFLE")
        lueTipoMercancia.EditValue = dsQuery.Tables(2)(0)("TIPO_CodCDT")
        tsSADA.Enabled = CBool(drQuery("CCOT_SADA"))
        tsIMO.Enabled = CBool(drQuery("CCOT_IMO"))
        'Nave-Viaje
        teCodigoViaje.EditValue = drQuery("CodigoViaje")
        teNombreNave.EditValue = drQuery("NombreNave")
        teNumeroViaje.EditValue = drQuery("Viaje_Vuelo")
        deFechaEtaEtd.EditValue = drQuery("ETA_ETD")
        'Contenedores (Agrupado)
        If dsQuery.Tables(1).Rows.Count > 0 Then
            gcContainerGroup.DataSource = dsQuery.Tables(1)
            GridView2.BestFitColumns()
        End If
        'Contenedores (Detallado)
        If dsQuery.Tables(2).Rows.Count > 0 Then
            gcContainerDetail.DataSource = dsQuery.Tables(2)
            'GridView4.BestFitColumns()
        End If


    End Sub

    Private Sub SetItem()
        dsOperationRelated = oAppService.ExecuteSQL("EXEC NextSoft.dgp.paObtieneOperacionesLogisticasRelacionadas " & InternalCode.ToString)
        If dsOperationRelated Is Nothing Or dsOperationRelated.Tables(0).Rows.Count = 0 Then
            Return
        End If
        beTarifa.Properties.ReadOnly = True
        Dim drOperation As DataRow = dsOperationRelated.Tables(0)(0)
        'Datos Generales
        teNumeroOperacion.EditValue = drOperation("COPE_NumDoc")
        deFechaEmision.EditValue = drOperation("COPE_FecEmi")
        teHBL.EditValue = drOperation("COPE_HBL")
        teMBL.EditValue = drOperation("COPE_MBL")
        lueCliente.EditValue = drOperation("ENTC_CodigoCliente")
        lueTransportista.EditValue = drOperation("ENTC_CodigoTransportista")
        lueTransportistaTerrestre.EditValue = drOperation("ENTC_CodTransTerre")
        lueAgenciaMaritima.EditValue = drOperation("ENTC_CodigoAgenciaMaritima")
        lueAlmacen.EditValue = drOperation("ENTC_CodigoAlmacen")
        lueTerminalPortuario.EditValue = drOperation("ENTC_CodigoTerminalPortuario")
        lueCondicionEmbarque.EditValue = drOperation("CodigoCondicionEmbarque")
        lueMoneda.EditValue = drOperation("TIPO_CodMND")
        lueUnidadNegocio.EditValue = drOperation("CONS_CodLNG")
        lueRegimen.EditValue = drOperation("CONS_CodRGM")
        lueVia.EditValue = drOperation("CONS_CodVIA")
        If dsOperationRelated.Tables(2).Rows.Count > 0 Then
            lueTipoMercancia.EditValue = dsOperationRelated.Tables(2).Rows(0)("TIPO_CodCDT")
        End If
        'Nave-Viaje
        teCodigoViaje.EditValue = drOperation("NVIA_Codigo")
        teNombreNave.EditValue = drOperation("NAVE_Nombre")
        teNumeroViaje.EditValue = drOperation("NVIA_NroViaje")
        deFechaEtaEtd.EditValue = drOperation("FechaEtaEtd")
        'Contenedores (Agrupado)
        If dsOperationRelated.Tables(1).Rows.Count > 0 Then
            gcContainerGroup.DataSource = dsOperationRelated.Tables(1)
            GridView2.BestFitColumns()
        End If
        'Contenedores (Detallado)
        If dsOperationRelated.Tables(2).Rows.Count > 0 Then
            gcContainerDetail.DataSource = dsOperationRelated.Tables(2)
            GridView4.BestFitColumns()
        End If
        'Tarifa
        'If dsOperationRelated.Tables(3).Rows.Count > 0 Then
        '    Dim drTariff As DataRow = dsOperationRelated.Tables(3)(0)
        '    lueTarifa.EditValue = drTariff("IdTariff")
        '    teTipoTarifa.EditValue = drTariff("TariffType")
        '    deVigenciaDesde.EditValue = drTariff("ValidFrom")
        '    deVigenciaHasta.EditValue = drTariff("ValidTo")
        '    meObservacionesTarifa.EditValue = drTariff("Remarks")
        'End If
        beTarifa.EditValue = dsOperationRelated.Tables(0).Rows(0)("CTAR_Codigo")
        'Tarifa Detalle
        'If dsOperationRelated.Tables(4).Rows.Count > 0 Then
        '    gcTariff.DataSource = dsOperationRelated.Tables(4)
        '    GridView3.BestFitColumns()
        'End If
        LoadTariffDetail()
        'Servicios
        dtOriginalService = dsOperationRelated.Tables(5).Copy()
        'If dsOperationRelated.Tables(5).Select("DOPE_ChangeControl=0").Length > 0 Then
        'If dsOperationRelated.Tables(5).Rows.Count > 0 Then
        gcServiceRelated.DataSource = dsOperationRelated.Tables(5)
        GridView1.BestFitColumns()
        'End If
        'Change Controls
        dtOriginalChangeControl = dsOperationRelated.Tables(6).Copy()
        gcChangeControlRelated.DataSource = dsOperationRelated.Tables(6)
        GridView5.BestFitColumns()
        'End If
    End Sub

    Private Sub ExpandAllGroups()
        Dim I As Integer
        For I = 0 To NavBarControl1.Groups.Count - 1
            Dim CurrGroup As NavBarGroup = NavBarControl1.Groups(I)
            CurrGroup.Expanded = True
        Next
    End Sub

    Private Sub bbiQuery_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiQuery.ItemClick
        If Not vpInputs.Validate Then
            Return
        End If
        If teHBL.EditValue.ToString = "" Then
            Return
        End If
        Dim oForm As New VerticalViewerOVForm
        oForm.sHBL = teHBL.EditValue
        oForm.ShowDialog()
    End Sub

    Private Sub bbiClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiClose.ItemClick
        Close()
    End Sub

    Private Sub bbiSendMailTo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSendMailTo.ItemClick

    End Sub

    Private Sub teHBL_Leave(sender As Object, e As EventArgs) Handles teHBL.Leave
        SetItem()
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
        'vpInputs.SetValidationRule(Me.lueCustomer, customValidationRule)
        'vpInputs.SetValidationRule(Me.deDateFrom, customValidationRule)
        'vpInputs.SetValidationRule(Me.deDateTo, customValidationRule)
    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged

    End Sub

    Private Sub GridView1_FocusedColumnChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs) Handles GridView1.FocusedColumnChanged
        'If e.FocusedColumn.FieldName = "TIPE_Codigo" Then
        '    LoadEntityDataList(GridView1.GetFocusedRowCellValue("TIPE_Codigo"), "RepositoryItemLookUpEdit3")
        'End If
    End Sub

    Private Sub LoadTariffDetail()
        'gcTariff.DataSource = Nothing
        'Dim dtTariffDetail As New DataTable
        'dtTariffDetail = oAppService.ExecuteSQL("EXEC NextSoft.tar.upGetTariffDetailById " & lueTarifa.EditValue.ToString).Tables(0)
        'gcTariff.DataSource = dtTariffDetail
        'GridView3.BestFitColumns()
        'teTipoTarifa.EditValue = IIf(lueTarifa.GetColumnValue("TariffType") = "B", "BASE", IIf(lueTarifa.GetColumnValue("TariffType") = "R", "REGULAR", IIf(lueTarifa.GetColumnValue("TariffType") = "E", "ESPECIAL", "")))
        'deVigenciaDesde.EditValue = lueTarifa.GetColumnValue("ValidFrom")
        'deVigenciaHasta.EditValue = lueTarifa.GetColumnValue("ValidTo")
        'meObservacionesTarifa.EditValue = lueTarifa.GetColumnValue("Remarks")
        gcTariff.DataSource = Nothing
        Dim dtTariffDetail As New DataTable
        dtTariffDetail = oAppService.ExecuteSQL("EXEC NextSoft.tar.upGetTariffDetailById " & beTarifa.EditValue.ToString).Tables(0)
        gcTariff.DataSource = dtTariffDetail
        GridView3.BestFitColumns()
        teTipoTarifa.EditValue = IIf(GridView3.GetRowCellValue(0, "TariffType") = "B", "BASE", IIf(GridView3.GetRowCellValue(0, "TariffType") = "R", "REGULAR", IIf(GridView3.GetRowCellValue(0, "TariffType") = "E", "ESPECIAL", "")))
        deVigenciaDesde.EditValue = GridView3.GetRowCellValue(0, "ValidFrom")
        deVigenciaHasta.EditValue = GridView3.GetRowCellValue(0, "ValidTo")
        meObservacionesTarifa.EditValue = GridView3.GetRowCellValue(0, "Remarks")
    End Sub

    'Private Sub lueTarifa_EditValueChanged(sender As Object, e As EventArgs)
    '    If lueTarifa.ItemIndex = -1 Then
    '        If InternalCode = -1 Then
    '            gcServiceRelated.DataSource = Nothing
    '            gcTariff.DataSource = Nothing
    '            teTipoTarifa.EditValue = Nothing
    '            deVigenciaDesde.EditValue = Nothing
    '            deVigenciaHasta.EditValue = Nothing
    '            meObservacionesTarifa.EditValue = Nothing
    '        End If
    '        Return
    '    End If
    '    Dim dtServiceRelated As New DataTable
    '    'If dsLogisticOperation.Tables(5).Select("SERV_Tipo='REGULAR'").Length > 0 Then
    '    '    If XtraMessageBox.Show("Ya existen servicios asociados a una tarifa, desea reemplazarlos", "Confirmación", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
    '    '        Return
    '    '    End If
    '    'End If
    '    gcServiceRelated.DataSource = Nothing
    '    Dim _CCOT_Numero As String = "NULL"
    '    Dim _CCOT_Tipo As String = "NULL"
    '    Dim _DOOV_HBL As String = "NULL"
    '    If Not IsDBNull(drSource("CCOT_Numero")) Then
    '        _CCOT_Numero = drSource("CCOT_Numero").ToString
    '    End If
    '    If Not IsDBNull(drSource("CCOT_Tipo")) Then
    '        _CCOT_Tipo = drSource("CCOT_Tipo").ToString
    '    End If
    '    If Not IsDBNull(drSource("COPE_HBL")) Or drSource("COPE_HBL").ToString.Length > 0 Then
    '        _DOOV_HBL = "'" & drSource("COPE_HBL") & "'"
    '    End If
    '    dtServiceRelated = oAppService.ExecuteSQL("EXEC NextSoft.tar.upGetServiceCalulatedByTariff " & lueTarifa.EditValue.ToString & "," & _CCOT_Numero & "," & _CCOT_Tipo & "," & _DOOV_HBL).Tables(0)
    '    gcServiceRelated.DataSource = dtServiceRelated
    '    GridView1.BestFitColumns()
    '    LoadTariffDetail()
    'End Sub

    Private Sub bbiSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSave.ItemClick
        Validate()
        If beTarifa.EditValue Is Nothing Then
            XtraMessageBox.Show("Debe asignar una tarifa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        LogisticOperationRegister(InternalCode)
        Dim _exception As New ArrayList()
        If InternalCode = -1 Then 'Inserta
            Try
                _exception.AddRange(oAppService.InsertLogisticOperation(dsOperationRelated))
                If _exception(0).Equals(0) Then
                    Throw New System.ArgumentException(_exception(1).ToString())
                End If
            Catch ex As Exception
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                gcServiceRelated.RefreshDataSource()
                XtraMessageBox.Show("Los datos se guardaron correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End Try
        Else 'Actualiza
            Try
                _exception.AddRange(oAppService.UpdateLogisticOperation(dsOperationRelated, dtOriginalService, dtOriginalChangeControl))
                If _exception(0).Equals(0) Then
                    Throw New System.ArgumentException(_exception(1).ToString())
                End If
            Catch ex As Exception
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                gcServiceRelated.RefreshDataSource()
                XtraMessageBox.Show("Los datos se guardaron correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End Try
        End If
    End Sub

    Private Sub LogisticOperationRegister(InternalCode As Integer)
        Dim _TransType As String = ""
        Dim drOperation As DataRow
        'Header
        dsOperationRelated.Tables(0).TableName = "Header"
        _TransType = IIf(dsOperationRelated.Tables(0).Rows.Count = 0, "I", "U")
        If InternalCode >= 0 Then
            drOperation = dsOperationRelated.Tables(0)(0)
            dsLogisticOperation = oAppService.ExecuteSQL("EXEC NextSoft.dgp.paObtieneServicioLogisticoPorCotizacion " & _EMPR_Codigo.ToString & "," & _SUCR_Codigo.ToString & "," & drOperation("CCOT_Numero").ToString & "," & drOperation("CCOT_Tipo").ToString)
        End If
        If InternalCode = -1 And dsOperationRelated.Tables(0).Rows.Count = 0 Then
            dsOperationRelated.Tables(0).Rows.Add()
        End If
        'Dim drHeader As DataRow = dsLogisticOperation.Tables(0).Rows(0)
        Dim drHeader As DataRow = dsOperationRelated.Tables(0).Rows(0)
        drHeader("COPE_Codigo") = InternalCode
        drHeader("COPE_NumDoc") = teNumeroOperacion.EditValue
        drHeader("COPE_Version") = 1
        drHeader("CCOT_Codigo") = dsOperationRelated.Tables(0).Rows(0)("CCOT_Codigo")
        drHeader("COPE_HBL") = teHBL.EditValue
        drHeader("ENTC_CodCliente") = lueCliente.EditValue
        drHeader("ENTC_CodTransporte") = DBNull.Value
        If lueTransportista.ItemIndex >= 0 Then
            drHeader("ENTC_CodTransporte") = lueTransportista.EditValue
        End If
        drHeader("ENTC_CodTransTerre") = DBNull.Value
        If lueTransportistaTerrestre.ItemIndex >= 0 Then
            drHeader("ENTC_CodTransTerre") = lueTransportistaTerrestre.EditValue
        End If
        If lueAlmacen.ItemIndex >= 0 Then
            drHeader("ENTC_CodDepTemporal") = lueAlmacen.EditValue
        End If
        If lueAgenciaMaritima.ItemIndex >= 0 Then
            drHeader("ENTC_CodAgenPort") = lueAgenciaMaritima.EditValue
        End If
        If lueTerminalPortuario.ItemIndex >= 0 Then
            drHeader("ENTC_CodTermPort") = lueTerminalPortuario.EditValue
        End If
        drHeader("ENTC_CodAgente") = drSource("ENTC_CodAgente")
        drHeader("CONS_CodEstado") = IIf(_TransType = "I", "001", drHeader("CONS_CodEstado"))
        drHeader("CONS_TabEstado") = "OPE"
        drHeader("TIPO_TabMND") = "MND"
        drHeader("TIPO_CodMND") = lueMoneda.EditValue
        drHeader("CONS_TabCRG") = "CRG"
        If lueCondicionEmbarque.EditValue.ToString.Contains({"003", "004"}) Then
            drHeader("CONS_CodCRG") = "001"
        Else
            drHeader("CONS_CodCRG") = "002"
        End If
        drHeader("CONS_TabLNG") = "LNG"
        drHeader("CONS_CodLNG") = lueUnidadNegocio.EditValue
        drHeader("CONS_TabRGM") = "RGM"
        drHeader("CONS_CodRGM") = lueRegimen.EditValue
        drHeader("CONS_TabVIA") = "VIA"
        drHeader("CONS_CodVIA") = lueVia.EditValue
        drHeader("CTAR_Codigo") = beTarifa.EditValue
        drHeader("CTAR_Version") = 1
        drHeader("COPE_Fob") = 0
        drHeader("COPE_Seguro") = 0
        drHeader("COPE_Flete") = 0
        drHeader("COPE_Cif") = 0
        drHeader("COPE_PartArancelaria") = 0
        drHeader("COPE_Ipm") = 0
        drHeader("COPE_Igv") = 0
        drHeader("COPE_Percepcion") = 0
        drHeader("COPE_TasaDespacho") = 0
        drHeader("COPE_AdValorem") = 0
        If InternalCode > 0 Then
            drHeader("AUDI_UsrMod") = AppUser
            drHeader("COPE_FecEmi") = deFechaEmision.EditValue
        Else
            drHeader("AUDI_UsrCrea") = AppUser
            'drHeader("COPE_FecEmi") = DateTime.Today
        End If

        'Servicios
        dsOperationRelated.Tables(5).TableName = "Service"
        '_TransType = IIf(dsOperationRelated.Tables(5).Rows.Count = 0, "I", "U")
        For i = 0 To GridView1.RowCount - 1
            Dim drDetail As DataRow
            If _TransType = "I" Then
                dsOperationRelated.Tables(5).Rows.Add()
            End If
            drDetail = dsOperationRelated.Tables(5).Rows(i)
            drDetail("COPE_Codigo") = drHeader("COPE_Codigo")
            drDetail("COPE_Version") = 1
            drDetail("DOPE_ChangeControl") = 0
            drDetail("DTAR_Item") = IIf(drDetail("DTAR_Item") Is Nothing, 0, drDetail("DTAR_Item"))
            'If GridView1.GetRowCellValue(i, "IdTariffDetail") IsNot Nothing Then
            '    drDetail("DTAR_Item") = GridView1.GetRowCellValue(i, "IdTariffDetail")
            '    'drDetail("CTAR_Codigo") = beTarifa.EditValue
            '    'drDetail("CTAR_Tipo") = lueTarifa.GetColumnValue("TariffType")
            'End If
            drDetail("CONS_CodBas") = GridView1.GetRowCellValue(i, "CONS_CodBas")
            drDetail("CONS_TabBas") = "BAS"
            drDetail("DOPE_Cantidad") = GridView1.GetRowCellValue(i, "DOPE_Cantidad")
            drDetail("DOPE_PrecioUnitCosto") = GridView1.GetRowCellValue(i, "DOPE_PrecioUnitCosto")
            drDetail("DOPE_PrecioTotCosto") = GridView1.GetRowCellValue(i, "DOPE_PrecioTotCosto")
            drDetail("DOPE_PrecioUnitVta") = GridView1.GetRowCellValue(i, "DOPE_PrecioUnitVta")
            drDetail("DOPE_PrecioTotVta") = GridView1.GetRowCellValue(i, "DOPE_PrecioTotVta")
            drDetail("TIPE_Codigo") = GridView1.GetRowCellValue(i, "TIPE_Codigo")
            drDetail("ENTC_Codigo") = GridView1.GetRowCellValue(i, "ENTC_Codigo")
            drDetail("CONS_TabEST") = "EDO"
            drDetail("SERV_Codigo") = GridView1.GetRowCellValue(i, "SERV_Codigo")
            drDetail("DOPE_Minimo") = 0
            drDetail("DOPE_VentaSada") = 0
            drDetail("DOPE_Venta") = 0
            drDetail("CONS_TabLNG") = "LNG"
            drDetail("CONS_CodLNG") = GridView1.GetRowCellValue(i, "CONS_CodLNG")
            drDetail("TIPO_TabMND") = "MND"
            drDetail("TIPO_CodMND") = GridView1.GetRowCellValue(i, "TIPO_CodMnd")
            If drDetail.RowState = DataRowState.Added Then
                drDetail("AUDI_UsrCrea") = AppUser
                drDetail("CONS_CodEST") = "001"
            Else
                drDetail("USR_UsrMod") = AppUser
                drDetail("CONS_CodEST") = GridView1.GetRowCellValue(i, "CONS_CodEST")
            End If
        Next

        'Change Control
        dsOperationRelated.Tables(6).TableName = "ChangeControl"
        For i = 0 To GridView5.RowCount - 1
            Dim drDetail As DataRow
            If _TransType = "I" Then
                dsOperationRelated.Tables(6).Rows.Add()
            End If
            drDetail = dsOperationRelated.Tables(6).Rows(i)
            drDetail("COPE_Codigo") = drHeader("COPE_Codigo")
            drDetail("COPE_Version") = 1
            drDetail("DOPE_ChangeControl") = 1
            drDetail("DTAR_Item") = IIf(drDetail("DTAR_Item") Is Nothing, 0, drDetail("DTAR_Item"))
            'If GridView5.GetRowCellValue(i, "IdTariffDetail") IsNot Nothing Then
            '    drDetail("DTAR_Item") = GridView5.GetRowCellValue(i, "IdTariffDetail")
            '    'drDetail("CTAR_Codigo") = beTarifa.EditValue
            '    'drDetail("CTAR_Tipo") = lueTarifa.GetColumnValue("TariffType")
            'End If
            drDetail("CONS_CodBas") = GridView5.GetRowCellValue(i, "CONS_CodBas")
            drDetail("CONS_TabBas") = "BAS"
            drDetail("DOPE_Cantidad") = GridView5.GetRowCellValue(i, "DOPE_Cantidad")
            drDetail("DOPE_PrecioUnitCosto") = GridView5.GetRowCellValue(i, "DOPE_PrecioUnitCosto")
            drDetail("DOPE_PrecioTotCosto") = GridView5.GetRowCellValue(i, "DOPE_PrecioTotCosto")
            drDetail("DOPE_PrecioUnitVta") = GridView5.GetRowCellValue(i, "DOPE_PrecioUnitVta")
            drDetail("DOPE_PrecioTotVta") = GridView5.GetRowCellValue(i, "DOPE_PrecioTotVta")
            drDetail("TIPE_Codigo") = GridView5.GetRowCellValue(i, "TIPE_Codigo")
            drDetail("ENTC_Codigo") = GridView5.GetRowCellValue(i, "ENTC_Codigo")
            drDetail("CONS_TabEST") = "EDO"
            drDetail("SERV_Codigo") = GridView5.GetRowCellValue(i, "SERV_Codigo")
            drDetail("DOPE_Minimo") = 0
            drDetail("DOPE_VentaSada") = 0
            drDetail("DOPE_Venta") = 0
            drDetail("CONS_TabLNG") = "LNG"
            drDetail("CONS_CodLNG") = GridView5.GetRowCellValue(i, "CONS_CodLNG")
            drDetail("TIPO_TabMND") = "MND"
            drDetail("TIPO_CodMND") = GridView5.GetRowCellValue(i, "TIPO_CodMnd")
            If drDetail.RowState = DataRowState.Added Then
                drDetail("AUDI_UsrCrea") = AppUser
                drDetail("CONS_CodEST") = "001"
            Else
                drDetail("USR_UsrMod") = AppUser
                drDetail("CONS_CodEST") = GridView5.GetRowCellValue(i, "CONS_CodEST")
            End If
        Next
    End Sub

    Private Sub tsmiChangeControl_Click(sender As Object, e As EventArgs) Handles tsmiChangeControl.Click

    End Sub

    Private Sub beTarifa_Properties_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles beTarifa.Properties.ButtonClick
        Dim oTariffSelecting As New TariffSelectingForm
        oTariffSelecting.ENTC_CodTransportista = IIf(lueTransportista.EditValue Is Nothing, lueTransportistaTerrestre.EditValue, lueTransportista.EditValue)
        If Not lueTransportistaTerrestre.EditValue Is Nothing Then
            oTariffSelecting.ENTC_CodTransportista = lueTransportistaTerrestre.EditValue
        End If
        oTariffSelecting.ShowDialog()
        beTarifa.EditValue = oTariffSelecting.IdTariff
        LoadTariffDetail()
    End Sub

    Private Sub tsmiEliminarServicio_Click(sender As Object, e As EventArgs) Handles tsmiEliminarServicio.Click
        If XtraMessageBox.Show("Está seguro de eliminar el registro?", "Confirmación", MessageBoxButtons.YesNo) <> DialogResult.Yes Then Return
        Dim grid As GridControl = gcServiceRelated
        Dim view As GridView = TryCast(grid.FocusedView, GridView)
        view.DeleteSelectedRows()
    End Sub

    Private Sub gcServiceRelated_Enter(sender As Object, e As EventArgs) Handles gcServiceRelated.Enter
        cmsServices.Enabled = True
        If GridView1.RowCount = 0 Then
            cmsServices.Enabled = False
        End If
        cmsChangeControl.Enabled = True
        If GridView5.RowCount = 0 Then
            cmsChangeControl.Enabled = False
        End If
        cmsServices.Items("tsmiChangeControl").Enabled = True
        If GridView1.GetFocusedRowCellValue("DOPE_DocProvVenta") Is Nothing Then
            cmsServices.Items("tsmiChangeControl").Enabled = False
        End If
    End Sub

    Private Sub gcServiceRelated_ProcessGridKey(sender As Object, e As KeyEventArgs) Handles gcServiceRelated.ProcessGridKey
        If e.KeyCode = Keys.Delete AndAlso e.Modifiers = Keys.Control Then
            'If Mid(GridView1.GetFocusedRowCellValue("SERV_Tipo"), 1, 1) = "R" Then
            '    XtraMessageBox.Show("No es posible eliminar un servicio de tipo REGULAR debido a que éste es parte de un acuerdo, para aplicar algún cambio en este servicio deberá hacerlo a través de la tarifa asociada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Return
            'End If
            If XtraMessageBox.Show("Está seguro de eliminar el registro?", "Confirmación", MessageBoxButtons.YesNo) <> DialogResult.Yes Then Return
            Dim grid As GridControl = TryCast(sender, GridControl)
            Dim view As GridView = TryCast(grid.FocusedView, GridView)
            view.DeleteSelectedRows()
        End If
    End Sub

    Private Sub gcServiceRelated_EmbeddedNavigator_ButtonClick(sender As Object, e As NavigatorButtonClickEventArgs) Handles gcServiceRelated.EmbeddedNavigator.ButtonClick, gcChangeControlRelated.EmbeddedNavigator.ButtonClick
        If e.Button.Tag = "Delete" Then
            'If Mid(GridView1.GetFocusedRowCellValue("SERV_Tipo"), 1, 1) = "R" Then
            '    XtraMessageBox.Show("No es posible eliminar un servicio de tipo REGULAR debido a que éste es parte de un acuerdo, para aplicar algún cambio en este servicio deberá hacerlo a través de la tarifa asociada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Return
            'End If
            If XtraMessageBox.Show("Está seguro de eliminar el registro?", "Confirmación", MessageBoxButtons.YesNo) <> DialogResult.Yes Then Return
            Dim grid As GridControl = gcServiceRelated
            Dim view As GridView = TryCast(grid.FocusedView, GridView)
            view.DeleteSelectedRows()
        End If
    End Sub

    Private Sub GridView1_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        'Validate()
        GridView1.SetFocusedRowCellValue("DOPE_ChangeControl", 0)
        If e.Column.FieldName.Contains({"DOPE_PrecioUnitVta", "DOPE_PrecioUnitCosto", "DOPE_Cantidad"}) Then
            If IsDBNull(GridView1.GetFocusedRowCellValue("DOPE_PrecioUnitVta")) Then
                GridView1.SetFocusedRowCellValue("DOPE_PrecioUnitVta", 0)
            End If
            If IsDBNull(GridView1.GetFocusedRowCellValue("DOPE_PrecioUnitCosto")) Then
                GridView1.SetFocusedRowCellValue("DOPE_PrecioUnitCosto", 0)
            End If
            If IsDBNull(GridView1.GetFocusedRowCellValue("DOPE_Cantidad")) Then
                GridView1.SetFocusedRowCellValue("DOPE_Cantidad", 1)
            End If
            GridView1.SetFocusedRowCellValue("DOPE_PrecioTotVta", GridView1.GetFocusedRowCellValue("DOPE_PrecioUnitVta") * GridView1.GetFocusedRowCellValue("DOPE_Cantidad"))
            GridView1.SetFocusedRowCellValue("DOPE_PrecioTotCosto", GridView1.GetFocusedRowCellValue("DOPE_PrecioUnitCosto") * GridView1.GetFocusedRowCellValue("DOPE_Cantidad"))
        End If
    End Sub

    Private Sub GridView5_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView5.CellValueChanged
        'Validate()
        GridView5.SetFocusedRowCellValue("DOPE_ChangeControl", 1)
        If e.Column.FieldName.Contains({"DOPE_PrecioUnitVta", "DOPE_PrecioUnitCosto", "DOPE_Cantidad"}) Then
            If IsDBNull(GridView5.GetFocusedRowCellValue("DOPE_PrecioUnitVta")) Then
                GridView5.SetFocusedRowCellValue("DOPE_PrecioUnitVta", 0)
            End If
            If IsDBNull(GridView5.GetFocusedRowCellValue("DOPE_PrecioUnitCosto")) Then
                GridView5.SetFocusedRowCellValue("DOPE_PrecioUnitCosto", 0)
            End If
            If IsDBNull(GridView5.GetFocusedRowCellValue("DOPE_Cantidad")) Then
                GridView5.SetFocusedRowCellValue("DOPE_Cantidad", 1)
            End If
            GridView5.SetFocusedRowCellValue("DOPE_PrecioTotVta", GridView5.GetFocusedRowCellValue("DOPE_PrecioUnitVta") * GridView5.GetFocusedRowCellValue("DOPE_Cantidad"))
            GridView5.SetFocusedRowCellValue("DOPE_PrecioTotCosto", GridView5.GetFocusedRowCellValue("DOPE_PrecioUnitCosto") * GridView5.GetFocusedRowCellValue("DOPE_Cantidad"))
        End If
    End Sub

    Private Sub RepositoryItemLookUpEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles RepositoryItemLookUpEdit1.EditValueChanged
        GridView1.SetFocusedRowCellValue("SERV_Tipo", DirectCast(DirectCast(sender, DevExpress.XtraEditors.LookUpEditBase).GetSelectedDataRow, System.Data.DataRowView).Row.ItemArray(2))
    End Sub

    Private Sub RepositoryItemLookUpEdit1_Leave(sender As Object, e As EventArgs) Handles RepositoryItemLookUpEdit1.Leave
        If GridView1.RowCount = 0 Then
            Return
        End If
        Try
            If IsDBNull(GridView1.GetFocusedRowCellValue("CTAR_Codigo")) Then
                GridView1.Columns("DOPE_PrecioUnitVta").OptionsColumn.ReadOnly = False
            Else
                GridView1.Columns("DOPE_PrecioUnitVta").OptionsColumn.ReadOnly = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    'Private Sub RepositoryItemLookUpEdit5_Leave(sender As Object, e As EventArgs) Handles RepositoryItemLookUpEdit5.Leave
    '    If GridView5.RowCount = 0 Then
    '        Return
    '    End If
    '    Try
    '        If IsDBNull(GridView5.GetFocusedRowCellValue("CTAR_Codigo")) Then
    '            GridView5.Columns("DOPE_PrecioUnitVta").OptionsColumn.ReadOnly = False
    '        Else
    '            GridView5.Columns("DOPE_PrecioUnitVta").OptionsColumn.ReadOnly = True
    '        End If
    '    Catch ex As Exception

    '    End Try
    'End Sub

End Class
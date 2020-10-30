Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid

Public Class SalesLogisticOperationForm
    Public Item As Object
    Public dsLogisticOperation As New DataSet
    Public _EMPR_Codigo, _SUCR_Codigo, _CCOT_Numero, _CCOT_Tipo, _ENTC_CodTransportista As Integer
    Dim oAppService As New AppService.DelfinServiceClient
    Dim oMasterDataList As New MasterDataList

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        dsLogisticOperation = Nothing
        GridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.Top

    End Sub

    Private Sub SalesLogisticOperationForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        '_EMPR_Codigo = 1
        '_SUCR_Codigo = 1
        '_CCOT_Numero = 30420
        '_CCOT_Tipo = 1
        'If dsLogisticOperation Is Nothing Then
        'GetSalesLogisticOperation()
        'End If
        LoadEntityDataList(5, "lueTransportistaTerrestre")
        'LoadTariff()
        LoadCurrency
        LoadService()
        LoadEntityType()
        LoadEntityByType()
        LoadBaseUnit()
        LoadLogisticOperation()

    End Sub

    Private Sub LoadEntityDataList(EntityType As Integer, ControlName As String)
        Dim dtQuery As New DataTable
        Dim aParams As New ArrayList
        If EntityType > 0 Then
            aParams.Add(EntityType.ToString)
        End If
        dtQuery = oMasterDataList.LoadMasterData("EntityByType", aParams)
        If ControlName = "lueTransportistaTerrestre" Then
            lueTransportistaTerrestre.Properties.DataSource = dtQuery
            lueTransportistaTerrestre.Properties.DisplayMember = "DescripcionEntidad"
            lueTransportistaTerrestre.Properties.ValueMember = "CodigoEntidad"
        End If

    End Sub

    Private Sub LoadCurrency()
        Dim dtQuery As New DataTable
        dtQuery = oMasterDataList.LoadMasterData("Currency", Nothing)
        RepositoryItemLookUpEdit5.DataSource = dtQuery
        RepositoryItemLookUpEdit5.DisplayMember = "DescripcionMoneda"
        RepositoryItemLookUpEdit5.ValueMember = "CodigoMoneda"
    End Sub
    Public Function GetSalesLogisticOperation() As DataSet
        'Dim dsResult As New DataSet
        '_EMPR_Codigo = Convert.ToUInt16(Item.EMPR_Codigo)
        '_SUCR_Codigo = Convert.ToUInt16(Item.SUCR_Codigo)
        '_CCOT_Numero = Item.CCOT_Numero
        '_CCOT_Tipo = Convert.ToUInt16(Item.CCOT_Tipo)
        dsLogisticOperation = oAppService.ExecuteSQL("EXEC NextSoft.dgp.paObtieneServicioLogisticoPorCotizacion " & _EMPR_Codigo.ToString & "," & _SUCR_Codigo.ToString & "," & _CCOT_Numero.ToString & "," & _CCOT_Tipo.ToString)
        Return dsLogisticOperation
    End Function

    Public Sub LoadLogisticOperation()
        'dsLogisticOperation = Nothing
        'dsLogisticOperation = GetSalesLogisticOperation()
        If dsLogisticOperation Is Nothing Then
            Return
        End If
        If dsLogisticOperation.Tables(0).Rows.Count = 0 Then
            Return
        End If
        teCodigoOperacion.EditValue = dsLogisticOperation.Tables(0).Rows(0)("COPE_Codigo")
        teNumeroOperacion.EditValue = dsLogisticOperation.Tables(0).Rows(0)("COPE_NumDoc")
        deFechaEmision.EditValue = dsLogisticOperation.Tables(0).Rows(0)("COPE_FecEmi")
        teCliente.EditValue = dsLogisticOperation.Tables(0).Rows(0)("ENTC_NombreCliente")
        teTransportista.EditValue = dsLogisticOperation.Tables(0).Rows(0)("ENTC_NombreTransportista")
        lueTransportistaTerrestre.EditValue = dsLogisticOperation.Tables(0).Rows(0)("ENTC_CodTransTerre")
        teAlmacen.EditValue = dsLogisticOperation.Tables(0).Rows(0)("ENTC_NombreAlmacen")
        teAgenciaMaritima.EditValue = dsLogisticOperation.Tables(0).Rows(0)("ENTC_NombreAgenciaMaritima")
        teTerminalPortuario.EditValue = dsLogisticOperation.Tables(0).Rows(0)("ENTC_NombreTerminalPortuario")
        teCondicionEmbarque.EditValue = dsLogisticOperation.Tables(0).Rows(0)("DescripcionCondicionEmbarque")

        beTarifa.EditValue = dsLogisticOperation.Tables(0).Rows(0)("CTAR_Codigo")
        LoadTariffDetail()
        gcServiceRelated.DataSource = dsLogisticOperation.Tables(5)
        GridView1.BestFitColumns()
    End Sub

    Private Sub LoadEntityType()
        Dim dtQuery As New DataTable
        dtQuery = oMasterDataList.LoadMasterData("EntityType", Nothing)
        RepositoryItemLookUpEdit2.DataSource = dtQuery
        RepositoryItemLookUpEdit2.DisplayMember = "DescripcionTipoEntidad"
        RepositoryItemLookUpEdit2.ValueMember = "CodigoTipoEntidad"
    End Sub

    Private Sub LoadEntityByType()
        Dim dtQuery As New DataTable
        Dim aParams As New ArrayList
        aParams.Add(DBNull.Value)
        dtQuery = oMasterDataList.LoadMasterData("EntityByType", aParams)
        RepositoryItemLookUpEdit3.DataSource = dtQuery
        RepositoryItemLookUpEdit3.DisplayMember = "DescripcionEntidad"
        RepositoryItemLookUpEdit3.ValueMember = "CodigoEntidad"
    End Sub

    Public Sub LoadTariff()
        ''If dsLogisticOperation.Tables(0).Rows.Count = 0 Then
        ''    Return
        ''End If
        'Dim dtQuery As New DataTable
        'Dim ValidityDate As String = Format(Date.Now, "yyyyMMdd")
        'Dim IdBusinessUnit As Integer = 2 'SLI
        'Dim IdTariff As Integer = Nothing
        'Dim ENTC_CodTransportista As String = "NULL"
        'Dim ENTC_CodCliente As String = "NULL"
        'Dim ENTC_CodAgenPort As String = "NULL"
        'Dim ENTC_CodTermPort As String = "NULL"
        'Dim ENTC_CodDepTemporal As String = "NULL"
        'Dim NVIA_Codigo As String = "NULL"
        'Dim COPE_HBL As String = "NULL"
        'Dim COPE_MBL As String = "NULL"
        'Dim CONS_CodVia As String = "NULL"
        'If dsLogisticOperation.Tables(0).Rows.Count > 0 Then
        '    If Not IsDBNull(dsLogisticOperation.Tables(0).Rows(0)("CTAR_Codigo")) Then
        '        IdTariff = dsLogisticOperation.Tables(0).Rows(0)("CTAR_Codigo")
        '    End If
        '    'If dsLogisticOperation.Tables(0).Rows(0)("ENTC_CodigoTransportista") > 0 Then
        '    '    ENTC_CodTransportista = dsLogisticOperation.Tables(0).Rows(0)("ENTC_CodigoTransportista")
        '    'End If
        'End If
        'If Not Item.ENTC_CodTransportista Is Nothing Then
        '    ENTC_CodTransportista = Item.ENTC_CodTransportista
        'End If
        'If Not Item.ENTC_CodCliente Is Nothing Then
        '    ENTC_CodCliente = Item.ENTC_CodCliente
        'End If
        'If Not Item.CONS_CodVia Is Nothing Then
        '    CONS_CodVia = "'" & Item.CONS_CodVia & "'"
        'End If
        'Dim _Query As String = "EXEC NextSoft.tar.upGetTariffByFilter "
        '_Query += "'" & ValidityDate & "', "
        '_Query += IdBusinessUnit & ", "
        '_Query += IdTariff & ", "
        '_Query += ENTC_CodTransportista & ", "
        '_Query += ENTC_CodCliente & ", "
        '_Query += ENTC_CodAgenPort & ", "
        '_Query += ENTC_CodTermPort & ", "
        '_Query += ENTC_CodDepTemporal & ", "
        '_Query += NVIA_Codigo & ", "
        '_Query += COPE_HBL & ", "
        '_Query += COPE_MBL & ", "
        '_Query += CONS_CodVia
        'dtQuery = oAppService.ExecuteSQL(_Query).Tables(0)
        'lueTarifa.Properties.DataSource = dtQuery
        'lueTarifa.Properties.DisplayMember = "IdTariff"
        'lueTarifa.Properties.ValueMember = "IdTariff"
    End Sub

    Private Sub LoadBaseUnit()
        Dim dtQuery As New DataTable
        dtQuery = oMasterDataList.LoadMasterData("BaseUnit", Nothing)
        RepositoryItemLookUpEdit4.DataSource = dtQuery
        RepositoryItemLookUpEdit4.DisplayMember = "DescripcionUnidadBase"
        RepositoryItemLookUpEdit4.ValueMember = "CodigoUnidadBase"
    End Sub

    Private Sub GridView1_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        'Validate()
        If e.Column.FieldName.Contains({"DOPE_PrecioUnitVta", "DOPE_PrecioUnitCosto", "DOPE_Cantidad"}) Then
            If IsDBNull(GridView1.GetFocusedRowCellValue("DOPE_PrecioUnitVta")) Then
                GridView1.SetFocusedRowCellValue("DOPE_PrecioUnitVta", 0)
            ElseIf IsDBNull(GridView1.GetFocusedRowCellValue("DOPE_PrecioUnitCosto")) Then
                GridView1.SetFocusedRowCellValue("DOPE_PrecioUnitCosto", 0)
            End If
            If IsDBNull(GridView1.GetFocusedRowCellValue("DOPE_Cantidad")) Then
                GridView1.SetFocusedRowCellValue("DOPE_Cantidad", 1)
            End If
            GridView1.SetFocusedRowCellValue("DOPE_PrecioTotVta", GridView1.GetFocusedRowCellValue("DOPE_PrecioUnitVta") * GridView1.GetFocusedRowCellValue("DOPE_Cantidad"))
            GridView1.SetFocusedRowCellValue("DOPE_PrecioTotCosto", GridView1.GetFocusedRowCellValue("DOPE_PrecioUnitCosto") * GridView1.GetFocusedRowCellValue("DOPE_Cantidad"))
        End If
    End Sub

    Private Sub LoadService()
        Dim dtQuery As New DataTable
        dtQuery = oMasterDataList.LoadMasterData("Service", Nothing)
        RepositoryItemLookUpEdit1.DataSource = dtQuery
        RepositoryItemLookUpEdit1.DisplayMember = "DescripcionServicio"
        RepositoryItemLookUpEdit1.ValueMember = "CodigoServicio"
    End Sub

    Private Sub RepositoryItemLookUpEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles RepositoryItemLookUpEdit1.EditValueChanged
        GridView1.SetFocusedRowCellValue("SERV_Tipo", DirectCast(DirectCast(sender, DevExpress.XtraEditors.LookUpEditBase).GetSelectedDataRow, System.Data.DataRowView).Row.ItemArray(2))
    End Sub

    Private Sub LoadTariffDetail()
        gcTariff.DataSource = Nothing
        Dim dtTariffDetail As New DataTable
        dtTariffDetail = oAppService.ExecuteSQL("EXEC NextSoft.tar.upGetTariffDetailById " & beTarifa.EditValue.ToString).Tables(0)
        gcTariff.DataSource = dtTariffDetail
        GridView3.BestFitColumns()
        teTipoTarifa.EditValue = IIf(GridView3.GetRowCellValue(0, "TariffType") = "B", "BASE", IIf(GridView3.GetRowCellValue(0, "TariffType") = "R", "REGULAR", IIf(GridView3.GetRowCellValue(0, "TariffType") = "E", "ESPECIAL", "")))
        deVigenciaDesde.EditValue = GridView3.GetRowCellValue(0, "ValidFrom")
        deVigenciaHasta.EditValue = GridView3.GetRowCellValue(0, "ValidTo")
        meObservacionesTarifa.EditValue = GridView3.GetRowCellValue(0, "Remarks")
        LoadServiceRelated()
    End Sub

    'Private Sub lueTarifa_EditValueChanged(sender As Object, e As EventArgs)
    Private Sub LoadServiceRelated()
        If beTarifa.EditValue.ToString = "" Then
            If teCodigoOperacion.Text = "0" Then
                gcServiceRelated.DataSource = Nothing
                gcTariff.DataSource = Nothing
                teTipoTarifa.EditValue = Nothing
                deVigenciaDesde.EditValue = Nothing
                deVigenciaHasta.EditValue = Nothing
                meObservacionesTarifa.EditValue = Nothing
            End If
            Return
        End If
        'If Not dsLogisticOperation Is Nothing Then
        '    If dsLogisticOperation.Tables(5).Rows.Count > 0 Then
        '        If dsLogisticOperation.Tables(5).Select("SERV_Tipo='REGULAR'").Length > 0 Then
        '            If XtraMessageBox.Show("Ya existen servicios asociados a una tarifa, desea reemplazarlos", "Confirmación", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
        '                Return
        '            End If
        '        End If
        '    End If
        'End If
        Dim dtServiceRelated As New DataTable
        gcServiceRelated.DataSource = Nothing
        dtServiceRelated = oAppService.ExecuteSQL("EXEC NextSoft.tar.upGetServiceCalulatedByTariff " & beTarifa.EditValue.ToString & "," & _CCOT_Numero.ToString & "," & _CCOT_Tipo.ToString).Tables(0)
        gcServiceRelated.DataSource = dtServiceRelated
        GridView1.BestFitColumns()
    End Sub

    Private Sub gcServiceRelated_EmbeddedNavigator_ButtonClick(sender As Object, e As NavigatorButtonClickEventArgs) Handles gcServiceRelated.EmbeddedNavigator.ButtonClick
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

    'Private Sub lueTarifa_Properties_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles lueTarifa.Properties.ButtonClick

    'End Sub

    'Private Sub lueTarifa_Properties_Enter(sender As Object, e As EventArgs) Handles lueTarifa.Properties.Enter
    '    LoadTariff()
    'End Sub

    Private Sub beTarifa_Properties_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles beTarifa.Properties.ButtonClick
        Dim oTariffSelecting As New TariffSelectingForm
        If lueTransportistaTerrestre.EditValue.ToString = "" Then
            oTariffSelecting.ENTC_CodTransportista = Item.ENTC_CodTransportista
        Else
            oTariffSelecting.ENTC_CodTransportista = lueTransportistaTerrestre.EditValue
        End If
        oTariffSelecting.ShowDialog()
        beTarifa.EditValue = oTariffSelecting.IdTariff
        LoadTariffDetail()
    End Sub

    Private Sub RepositoryItemLookUpEdit2_EditValueChanged(sender As Object, e As EventArgs)
        'LoadEntityByType()
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

    'Private Sub SalesLogisticOperationForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    '    AddHandler beTarifa.EditValueChanged, AddressOf beTarifa_EditValueChanged
    'End Sub
End Class
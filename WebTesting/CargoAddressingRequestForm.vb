Imports System.Threading
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.XtraGrid.Views.Grid
Imports WebTesting.OnlineService


Public Class CargoAddressingRequestForm

    Private oAppService As New OnlineService.OnLineServiceClient

    Private Sub CargoAddressingRequestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCustomer()
        LoadDepotType()
        LoadDepositoTemporal()
        ObtenerDireccionamientos()
    End Sub

    Private Sub LoadCustomer()
        Dim dtQuery As New DataTable
        dtQuery = oAppService.GetRelatedCompany(ENTC_DocIden)         'ExecuteSQL("EXEC NextSoft.dgp.paObtieneEmpresaVinculada " & ENTC_DocIden).Tables(0)
        lueCustomer.Properties.DataSource = dtQuery
        lueCustomer.Properties.DisplayMember = "DescripcionCliente"
        lueCustomer.Properties.ValueMember = "CodigoCliente"
        lueCustomer.ItemIndex = 0
    End Sub

    Private Sub LoadDepositoTemporal()
        Dim dtQuery As New DataTable
        dtQuery = oAppService.ExecuteSQL("EXEC NextSoft.dgp.paListaDepositoExtranet").Tables(0)         'ExecuteSQL("EXEC NextSoft.dgp.paObtieneEmpresaVinculada " & ENTC_DocIden).Tables(0)
        rilueDepositoTemporal.DataSource = dtQuery
        rilueDepositoTemporal.DisplayMember = "DescripcionDepositoTemporal"
        rilueDepositoTemporal.ValueMember = "CodigoDepositoTemporal"

    End Sub





    Private Sub LoadVoyageByCustomer()
        Dim dtQuery As New DataTable
        dtQuery = oAppService.GetVoyageByCustomer(lueCustomer.EditValue)
        lueVoyage.Properties.DataSource = dtQuery
        lueVoyage.Properties.DisplayMember = "NombreNave"
        lueVoyage.Properties.ValueMember = "CodigoViaje"
    End Sub

    Private Sub LoadDepotType()
        Dim dtQuery As New DataTable
        dtQuery = oAppService.ExecuteSQL("EXEC NextSoft.dgp.paListaTipoDeposito").Tables(0)
        RepositoryItemLookUpEdit2.DataSource = dtQuery
        RepositoryItemLookUpEdit2.DisplayMember = "TIPE_Descripcion"
        RepositoryItemLookUpEdit2.ValueMember = "TIPE_Codigo"
    End Sub

    Private Sub CargarHBLs()
        gcMainData.DataSource = Nothing
        Dim dtQuery As New DataTable
        dtQuery = oAppService.CargoAddressingQuery(lueCustomer.EditValue, lueVoyage.EditValue, IIf(teHBL.Text <> "", teHBL.Text, Nothing))

        gcMainData.DataSource = dtQuery

    End Sub

    Public Sub ObtenerDireccionamientos()
        Dim listDireccionamientos As List(Of EntidadDireccionamiento_BE)
        Dim oFiltroDireccionamiento As EntidadDireccionamiento_BE = New EntidadDireccionamiento_BE()
        oFiltroDireccionamiento.ENTC_Codigo = lueCustomer.EditValue
        listDireccionamientos = New List(Of EntidadDireccionamiento_BE)(oAppService.GetByFilterEntidadDireccionamiento(oFiltroDireccionamiento))
        gcAudit.DataSource = listDireccionamientos
    End Sub



    Private Sub bbiSearch_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSearch.ItemClick
        CargarHBLs()
    End Sub

    Private Sub bbiExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExport.ItemClick
        ExportToExcel(gcMainData)
    End Sub

    Private Sub bbiDepotAssign_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiDepotAssign.ItemClick
        'Dim dt As DataTable = TryCast(gcMainData.DataSource, DataTable)
        gcMainData.EndUpdate()
        Me.GridView1.CloseEditor()
        Me.GridView1.UpdateCurrentRow()
        For i As Integer = 0 To gcMainData.MainView.RowCount - 1
            Dim drDeposito As DataRowView = gcMainData.MainView.GetRow(i)

            If drDeposito.Row.RowState = DataRowState.Modified Then

                Dim oEntidadDireccionamiento As EntidadDireccionamiento_BE = New EntidadDireccionamiento_BE()
                oEntidadDireccionamiento.ENTC_EMailSolicitante = "mcomun@zytrust.com"
                oEntidadDireccionamiento.ENTC_CodDepTemporal = GridView1.GetRowCellValue(i, "CodigoDepositoTemporal").ToString()
                oEntidadDireccionamiento.ENTC_CodDepTemporalSolicitado = GridView1.GetRowCellValue(i, "CodigoDepositoTemporalAsignado").ToString()
                oEntidadDireccionamiento.ENTC_Codigo = GridView1.GetRowCellValue(i, "CodigoCliente").ToString()
                oEntidadDireccionamiento.DOOV_HBL = GridView1.GetRowCellValue(i, "HBL").ToString()
                oEntidadDireccionamiento.AUDI_FecCrea = DateTime.Now
                oEntidadDireccionamiento.ENDI_Numero = 0
                oEntidadDireccionamiento.AUDI_UsrCrea = "mcomun"

                oEntidadDireccionamiento.ENDI_Estado = "I"
                oAppService.InsertEntidadDireccionamiento(oEntidadDireccionamiento)





            End If
            Dim ostring As String = ""
        Next
        CargarHBLs()
        ObtenerDireccionamientos()
    End Sub

    Private Sub bbiClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiClose.ItemClick
        Close()
    End Sub

    Private Sub lueCustomer_EditValueChanged(sender As Object, e As EventArgs) Handles lueCustomer.EditValueChanged
        Validate()
        If Not lueCustomer.EditValue = Nothing Then
            LoadVoyageByCustomer()
        End If

    End Sub

    Private Sub lueVoyage_EditValueChanged(sender As Object, e As EventArgs) Handles lueVoyage.EditValueChanged
        Validate()
        If Not lueVoyage.EditValue = Nothing Then
            teVoyage.Text = lueVoyage.GetColumnValue("Viaje_Vuelo")
        End If
    End Sub

    Private Sub button_delete_Click(sender As Object, e As EventArgs) Handles button_delete.Click

        If DevExpress.XtraEditors.XtraMessageBox.Show("Esta seguro que desea eliminar la solicitud de Direccionamiento?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = System.Windows.Forms.DialogResult.Yes Then

            Dim oEntidadDireccionamiento As EntidadDireccionamiento_BE = GridView2.GetFocusedRow
            oEntidadDireccionamiento.AUDI_UsrMod = "mcomun"
            oEntidadDireccionamiento.AUDI_FecMod = DateTime.Now
            oAppService.DeleteEntidadDireccionamiento(oEntidadDireccionamiento)
            CargarHBLs()
            ObtenerDireccionamientos()
        End If
    End Sub

    Private Sub bbiNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiNuevo.ItemClick
        Dim oFormInsertarDireccionamiento As CargoAddressingRequestInsertForm = New CargoAddressingRequestInsertForm()
        oFormInsertarDireccionamiento.Compania = lueCustomer.EditValue



        If (oFormInsertarDireccionamiento.ShowDialog(Me) = DialogResult.OK) Then

            Dim oEntidadDireccionamiento As EntidadDireccionamiento_BE = New EntidadDireccionamiento_BE()
            Dim oEntidadDireccionamientoReturn As EntidadDireccionamiento_BE = New EntidadDireccionamiento_BE()
            oEntidadDireccionamiento.ENTC_EMailSolicitante = "mcomun@zytrust.com"
            oEntidadDireccionamiento.ENTC_CodDepTemporal = oFormInsertarDireccionamiento.lueDepositoOriginal.EditValue
            oEntidadDireccionamiento.ENTC_CodDepTemporalSolicitado = oFormInsertarDireccionamiento.lueNuevoDeposito.EditValue
            oEntidadDireccionamiento.ENTC_Codigo = lueCustomer.EditValue
            oEntidadDireccionamiento.DOOV_HBL = oFormInsertarDireccionamiento.txtHBL.Text
            oEntidadDireccionamiento.AUDI_FecCrea = DateTime.Now
            oEntidadDireccionamiento.ENDI_Numero = 0
            oEntidadDireccionamiento.AUDI_UsrCrea = "mcomun"
            oEntidadDireccionamiento.DescargaDirecta = oFormInsertarDireccionamiento.chkDescargaDirecta.EditValue
            oEntidadDireccionamiento.ENDI_Estado = "P"

            oEntidadDireccionamientoReturn = oAppService.InsertEntidadDireccionamiento(oEntidadDireccionamiento)
            CargarHBLs()
            ObtenerDireccionamientos()

            MessageBox.Show("Codigo : " + oEntidadDireccionamientoReturn.ENTC_Codigo.ToString + "Estado : " + oEntidadDireccionamientoReturn.ENDI_Estado)

        Else
            Dim Hola2 As String = "Hola"


        End If
        oFormInsertarDireccionamiento.Dispose()




    End Sub
    Private Function EsPendiente(view As GridView, row As Integer) As Boolean
        Dim oEntidadDireccionamiento As EntidadDireccionamiento_BE = New EntidadDireccionamiento_BE()
        oEntidadDireccionamiento = view.GetRow(row)
        Dim Retorno As Boolean
        If oEntidadDireccionamiento.EsAnulable Then
            Retorno = True
        Else
            Retorno = False
        End If

        Return Retorno

    End Function


    Private Sub GridView2_CustomRowCellEdit(sender As Object, e As CustomRowCellEditEventArgs) Handles GridView2.CustomRowCellEdit
        If e.Column.Name = "Eliminar" Then
            If Not EsPendiente(TryCast(sender, GridView), e.RowHandle) Then
                e.RepositoryItem = button_delete_disabled
            Else
                e.RepositoryItem = button_delete
            End If
        End If
    End Sub


End Class
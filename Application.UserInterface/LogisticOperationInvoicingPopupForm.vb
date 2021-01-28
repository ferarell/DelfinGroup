Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid

Public Class LogisticOperationInvoicingPopupForm
    Dim oAppService As New AppService.DelfinServiceClient
    Dim oMasterDataList As New MasterDataList
    'Friend dtSource As New DataTable
    Friend OperationsList As String = ""
    Friend CodigoMoneda As String
    Friend oProcessType As String = ""
    Private Sub LogisticOperationInvoicingPopupForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtSource As New DataTable
        LoadTaxDocumentType()
        LoadPaymentType()
        deFechaEmision.EditValue = Now
        dtSource = oAppService.ExecuteSQL("EXEC NextSoft.dgp.paObtieneOperacionesLogisticasPorPreFacturar '" & OperationsList & "','" & CodigoMoneda & "'").Tables(0)

        If oProcessType = "Single" Then
            'gcInvoicing.MainView = GridView1
            GridView1.Columns("CONS_CodFPG").Visible = False
        End If

        If oProcessType = "Multiple" Then
            lueMoneda.ReadOnly = True
            lueFormaPago.ReadOnly = True
            seDiasCredito.ReadOnly = True
            deFechaVencimiento.ReadOnly = True
            lueSocioNegocio.ReadOnly = True
            'gcInvoicing.MainView = GridView1
        End If
        lueTipoComprobante.ItemIndex = 0
        gcInvoicing.DataSource = dtSource
        GridView1.BestFitColumns()

    End Sub

    Private Sub LoadPaymentType()
        Dim dtQuery As New DataTable
        dtQuery = oMasterDataList.LoadMasterData("PayTerm", Nothing)
        If oProcessType = "Single" Then
            lueFormaPago.Properties.DataSource = dtQuery
            lueFormaPago.Properties.DisplayMember = "DescripcionFormaPago"
            lueFormaPago.Properties.ValueMember = "CodigoFormaPago"
        Else
            RepositoryItemLookUpEdit1.DataSource = dtQuery
            RepositoryItemLookUpEdit1.DisplayMember = "DescripcionFormaPago"
            RepositoryItemLookUpEdit1.ValueMember = "CodigoFormaPago"
        End If
    End Sub

    Private Sub LoadTaxDocumentType()
        Dim dtQuery As New DataTable
        dtQuery = oAppService.ExecuteSQL("EXEC NextSoft.dgp.paListaTipoDocumentoContable").Tables(0)
        dtQuery = dtQuery.Select("CodigoTipoDocumento IN ('001','003','007')").CopyToDataTable
        lueTipoComprobante.Properties.DataSource = dtQuery
        lueTipoComprobante.Properties.DisplayMember = "DescripcionTipoDocumento"
        lueTipoComprobante.Properties.ValueMember = "CodigoTipoDocumento"
    End Sub

    Private Sub LoadTaxDocumentSerie()
        Dim dtQuery As New DataTable
        dtQuery = oAppService.ExecuteSQL("EXEC NextSoft.dgp.paListaSerieFacturacion '" & lueTipoComprobante.EditValue & "','003'").Tables(0)
        lueSerieComprobante.Properties.DataSource = dtQuery
        lueSerieComprobante.Properties.DisplayMember = "SERI_Serie"
        lueSerieComprobante.Properties.ValueMember = "SERI_Serie"
        lueSerieComprobante.ItemIndex = 0
    End Sub

    Private Sub bbiGenerate_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGenerate.ItemClick
        If XtraMessageBox.Show("Se generarán las pre-facturas de las operciones seleccionadas, desea continuar? ", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If
        Dim bError As Boolean = True
        Dim dsDocVta As New DataSet
        dsDocVta.Tables.Add(oAppService.ExecuteSQL("SELECT TOP 0 * FROM NextSoft.dbo.VEN_DocsVta").Tables(0))
        dsDocVta.Tables.Add(oAppService.ExecuteSQL("SELECT TOP 0 * FROM NextSoft.dbo.VEN_DetDocsVta").Tables(0))
        For r = 0 To GridView1.RowCount - 1
            Dim oRow As DataRow = GridView1.GetDataRow(r)
            dsDocVta = GetDataResult(dsDocVta, oRow)
            Try
                If Not oAppService.PreFacturar(oRow("COPE_Codigo"), dsDocVta) Then
                    bError = False
                End If

            Catch ex As Exception
                bError = False
            End Try
        Next
        If bError Then
            XtraMessageBox.Show("Se identificaron algunos errores durante el proceso de pre facturación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
    End Sub

    Function GetDataResult(dsResult As DataSet, drSource As DataRow) As DataSet


        Return dsResult
    End Function
    Private Sub bbiClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiClose.ItemClick
        Close()
    End Sub

    Private Sub lueTipoComprobante_EditValueChanged(sender As Object, e As EventArgs) Handles lueTipoComprobante.EditValueChanged
        LoadTaxDocumentSerie()
    End Sub

    Private Sub GridView1_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        If e.Column.FieldName = "CONS_CodFPG" Then
            If GridView1.GetFocusedRowCellValue("CONS_CodFPG") = "001" Then
                GridView1.SetFocusedRowCellValue("ENLI_DiasDuracion", 0)
            End If
        End If
        If e.Column.FieldName = "ENLI_DiasDuracion" Then
            If GridView1.GetFocusedRowCellValue("ENLI_DiasDuracion") >= 0 Then
                GridView1.SetFocusedRowCellValue("DOCV_FechaVcmto", DateAdd(DateInterval.Day, GridView1.GetFocusedRowCellValue("ENLI_DiasDuracion"), deFechaEmision.DateTime))
            End If
        End If
    End Sub
End Class
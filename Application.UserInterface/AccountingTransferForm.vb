﻿Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraSplashScreen

Public Class AccountingTransferForm
    Dim oAppService As New AppService.DelfinServiceClient
    Dim oIntegrationService As New IntegrationService.IntegradorSBOClient
    Public AppUser As String = "sistemas"

    Private Sub AccountingTransferForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gcVouchers.MainView.RestoreLayoutFromRegistry(IO.Directory.GetCurrentDirectory)
        SplitContainerControl2.SplitterPosition = SplitContainerControl2.Height * 0.8
        deDateFrom.EditValue = DateAdd(DateInterval.Day, -90, Now)
        deDateTo.EditValue = Now
        'LoadBusinessUnit()
    End Sub

    'Private Sub LoadBusinessUnit()
    '    Dim dtQuery As New DataTable
    '    dtQuery = oAppService.ExecuteSQL("EXEC NextSoft.dgp.paListaLineaNegocio").Tables(0)
    '    lueBusinessUnit.Properties.DataSource = dtQuery
    '    lueBusinessUnit.Properties.DisplayMember = "DescripcionLineaNegocio"
    '    lueBusinessUnit.Properties.ValueMember = "CodigoLineaNegocio"
    'End Sub

    Private Sub bbiSearch_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSearch.ItemClick
        Dim dtSource As New DataTable
        dtSource = oAppService.ExecuteSQL("EXEC NextSoft.dgp.paObtieneStatementsPorNaveViaje '" & Format(deDateFrom.EditValue, "yyyyMMdd") & "','" & Format(deDateTo.EditValue, "yyyyMMdd") & "'").Tables(0)
        dtSource.Columns.Add("Checked", GetType(Boolean)).DefaultValue = False
        gcVouchers.DataSource = dtSource
        GridView1.BestFitColumns()
    End Sub

    Private Sub bbiTransfer_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiStatements.ItemClick
        Validate()
        If DevExpress.XtraEditors.XtraMessageBox.Show("Se generarán asientos de provisión de cada Nave/Viaje seleccionado, desea continuar? ", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If
        For r = 0 To GridView1.DataRowCount - 1
            Dim oRow As DataRow = GridView1.GetDataRow(r)
            If oRow("Checked") = False Then
                Continue For
            End If
            'Interfaz de Asiento Diario

        Next

    End Sub

    Private Sub bbiExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExport.ItemClick

    End Sub

    Private Sub bbiClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiClose.ItemClick
        Close()
    End Sub

    Private Sub AccountingTransferForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        gcVouchers.MainView.SaveLayoutToRegistry(IO.Directory.GetCurrentDirectory)
    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        'If IsDBNull(GridView1.GetFocusedRowCellValue("Checked")) Then
        '    GridView1.SetFocusedRowCellValue("Checked", False)
        'End If
        If GridView1.GetFocusedRowCellValue("NVIA_Codigo") Is Nothing Then
            Return
        End If
        Dim dtQuery As New DataTable
        dtQuery = oAppService.ExecuteSQL("EXEC NextSoft.dgp.paObtieneListaOvPorFiltros NULL, " & GridView1.GetFocusedRowCellValue("NVIA_Codigo").ToString & ", NULL, NULL").Tables(0)
        If dtQuery.Rows.Count = 0 Then
            Return
        End If
        If Not dtQuery.Columns.Contains("Checked") Then
            dtQuery.Columns.Add("Checked", GetType(Boolean)).DefaultValue = False
        End If
        gcListaHBL.DataSource = dtQuery
        'GridView2.BestFitColumns()
    End Sub

    Private Sub bbiReferences_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiReferences.ItemClick
        Validate()
        If DevExpress.XtraEditors.XtraMessageBox.Show("Se actualizarán las referencias de cada HBL seleccionado, desea continuar? ", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If
        Dim dsReferences As New DataSet
        Dim TipoReferencia, HBL As String
        TipoReferencia = GridView1.GetFocusedRowCellValue("Origen")
        For r = 0 To GridView2.DataRowCount - 1
            Dim oRow As DataRow = GridView2.GetDataRow(r)
            Try
                SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)
                SplashScreenManager.Default.SetWaitFormDescription("Sincronizando (" & (r + 1).ToString & " de " & (GridView2.DataRowCount).ToString & ") HBL:  " & oRow("HBL"))
                If IsDBNull(oRow("Checked")) Then
                    oRow("Checked") = False
                End If
                If oRow("Checked") = False Then
                    Continue For
                End If
                'Interfaz de Referncias
                HBL = oRow("HBL")
                dsReferences = oAppService.ExecuteSQL("NextSoft.sap.upGetDataForReferenciaInterface '" & TipoReferencia & "','" & HBL & "','" & AppUser & "'")
                If dsReferences.Tables(0).Rows.Count = 0 Then
                    XtraMessageBox.Show("El HBL: " & HBL & " no tiene referencias asociadas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
                Dim aRespuesta As New ArrayList
                aRespuesta.AddRange(oIntegrationService.InsertarActualizarReferencias(dsReferences))
                If aRespuesta(0).RespuestaSAP = 0 Then
                    XtraMessageBox.Show("Ocurrió un error al actualizar las referencias del HBL: " & HBL & " en SAP" & vbCrLf & DirectCast(aRespuesta(0), ApplicationForm.IntegrationService.Respuesta).Response(0).[error].Message.Value, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                'SplashScreenManager.CloseForm(False)
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Next
        SplashScreenManager.CloseForm(False)
    End Sub

    Private Sub RepositoryItemCheckEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles RepositoryItemCheckEdit1.EditValueChanged
        If Mid(GridView1.GetFocusedRowCellValue("NVIA_DesEstado"), 1, 1) <> "P" Then
            GridView1.SetFocusedRowCellValue("Checked", False)
            DevExpress.XtraEditors.XtraMessageBox.Show("No puede generar la provisión de una Nave/Viaje que aún no se ha pre-facturado. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If GridView1.GetFocusedRowCellValue("AsientoContable").ToString.Length > 0 Then
            GridView1.SetFocusedRowCellValue("Checked", False)
        End If
    End Sub

    Friend Function RowSelectedCount(oGridView As GridView) As Integer
        Dim iChecked As Integer = 0
        For i = 0 To oGridView.RowCount - 1
            If IsDBNull(oGridView.GetRowCellValue(i, "Checked")) Then
                Continue For
            End If
            If oGridView.GetRowCellValue(i, "Checked") Then
                iChecked += 1
            End If
        Next
        Return iChecked
    End Function

    Private Sub SelectRowsByType(oGridView As GridView, SelectType As Integer)
        For i = 0 To oGridView.RowCount - 1
            Dim row As DataRow = oGridView.GetDataRow(i)
            If IsDBNull(row("Checked")) Then
                row("Checked") = False
            End If
            If SelectType = 0 Then
                row("Checked") = True
            End If
            If SelectType = 1 Then
                row("Checked") = False
            End If
            If SelectType = 2 Then
                If row("Checked") Then
                    row("Checked") = False
                Else
                    row("Checked") = True
                End If
            End If
            Validate()
        Next
    End Sub

    Private Sub SeleccionaTodosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeleccionaTodosToolStripMenuItem.Click
        Dim oGridView As GridView = IIf(GridView1.IsFocusedView, GridView1, GridView2)
        SelectRowsByType(oGridView, 0)
    End Sub

    Private Sub DeseleccionaTodosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeseleccionaTodosToolStripMenuItem.Click
        Dim oGridView As GridView = IIf(GridView1.IsFocusedView, GridView1, GridView2)
        SelectRowsByType(oGridView, 1)
    End Sub

    Private Sub InvertirSelecciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InvertirSelecciónToolStripMenuItem.Click
        Dim oGridView As GridView = IIf(GridView1.IsFocusedView, GridView1, GridView2)
        SelectRowsByType(oGridView, 2)
    End Sub

    Private Sub GridView2_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView2.FocusedRowChanged
        'If IsDBNull(GridView2.GetFocusedRowCellValue("Checked")) Then
        '    GridView2.SetFocusedRowCellValue("Checked", False)
        'End If
    End Sub
End Class
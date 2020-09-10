Public Class LogisticsServiceUpdatePopupForm
    Dim oAppService As New AppService.DelfinServiceClient
    Public iEMPR_Codigo, iSUCR_Codigo, iCCOT_Numero, iCCOT_Tipo As Integer
    Public bCCOT_ServicioLogistico, bCCOT_VoBoGateIn As Boolean
    Public sAUDI_UsrMod As String

    Private Sub LogisticsServiceUpdatePopupForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tsLogisticService.EditValue = bCCOT_ServicioLogistico
        tsWithoutDepot.EditValue = bCCOT_VoBoGateIn
    End Sub

    Private Sub bbiSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSave.ItemClick
        If DevExpress.XtraEditors.XtraMessageBox.Show("Está seguro que desea guardar los cambios? ", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If
        Dim cmdtext As String = "EXEC NextSoft.dbo.TCOM_SP_ACTUALIZAR_Cab_Cotizacion_OV_ServicioLogistico "
        cmdtext += iCCOT_Numero.ToString & ", "
        cmdtext += iCCOT_Tipo.ToString & ", "
        cmdtext += iEMPR_Codigo.ToString & ", "
        cmdtext += iSUCR_Codigo.ToString & ", "
        cmdtext += CInt(tsLogisticService.EditValue).ToString & ", "
        cmdtext += CInt(tsWithoutDepot.EditValue).ToString & ", "
        cmdtext += "'" & sAUDI_UsrMod & "'"
        If Not oAppService.ExecuteSQLNonQuery(cmdtext) Then
            DialogResult = DialogResult.No
            DevExpress.XtraEditors.XtraMessageBox.Show("Ocurrió un error y los datos no han sido actualizados. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Close()
        End If
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub tsLogisticService_Toggled(sender As Object, e As EventArgs) Handles tsLogisticService.Toggled
        Validate()
        If tsWithoutDepot.EditValue = True And tsLogisticService.EditValue = True Then
            tsWithoutDepot.EditValue = False
        End If
    End Sub

    Private Sub bbiClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiClose.ItemClick
        Close()
    End Sub

    Private Sub tsWithoutDepot_Toggled(sender As Object, e As EventArgs) Handles tsWithoutDepot.Toggled
        Validate()
        If tsLogisticService.EditValue = True And tsWithoutDepot.EditValue = True Then
            tsLogisticService.EditValue = False
        End If
    End Sub
End Class
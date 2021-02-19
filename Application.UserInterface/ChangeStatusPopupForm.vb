Public Class ChangeStatusPopupForm
    Dim oAppService As New AppService.DelfinServiceClient
    Public CCOT_NumDoc As String = ""
    Public CONS_CodEST As String = ""
    Public AUDI_UsrMod As String = ""
    Public OriginType As String = ""

    Private Sub LogisticsServiceUpdatePopupForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtQuery As New DataTable
        dtQuery = oAppService.ExecuteSQL("EXEC NExtSoft.dgp.paListaEstado" & OriginType).Tables(0)
        lueActualStatus.Properties.DataSource = dtQuery
        lueActualStatus.Properties.DisplayMember = "DescripcionEstado"
        lueActualStatus.Properties.ValueMember = "CodigoEstado"
        lueActualStatus.EditValue = CONS_CodEST
        lueNewStatus.Properties.DataSource = dtQuery
        lueNewStatus.Properties.DisplayMember = "DescripcionEstado"
        lueNewStatus.Properties.ValueMember = "CodigoEstado"
    End Sub

    Private Sub bbiSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSave.ItemClick
        If DevExpress.XtraEditors.XtraMessageBox.Show("Está seguro que desea guardar los cambios? ", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If
        Dim cmdtext As String = "EXEC NextSoft.dgp.paActualizaEstadoOrdenVenta "
        cmdtext += "'" & CCOT_NumDoc & "', '"
        cmdtext += lueNewStatus.EditValue & "', '"
        cmdtext += AUDI_UsrMod & "'"
        If Not oAppService.ExecuteSQLNonQuery(cmdtext) Then
            DialogResult = DialogResult.No
            DevExpress.XtraEditors.XtraMessageBox.Show("Ocurrió un error y los datos no han sido actualizados. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Close()
        End If
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub bbiClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiClose.ItemClick
        Close()
    End Sub

End Class
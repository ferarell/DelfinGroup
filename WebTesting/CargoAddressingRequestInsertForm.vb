
Imports WebTesting.OnlineService
Public Class CargoAddressingRequestInsertForm
    Public Compania As String
    Private oAppService As New OnlineService.OnLineServiceClient
    Private Sub GetQuoteForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDepositoTemporalHBL()
        LoadDepositoTemporalNuevo()
    End Sub



    Private Sub bbiClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiClose.ItemClick
        Close()
    End Sub


    Private Sub LoadDepositoTemporalHBL()
        Dim dtQuery As New DataTable
        dtQuery = oAppService.ExecuteSQL("EXEC NextSoft.dgp.paListaDeposito").Tables(0)         'ExecuteSQL("EXEC NextSoft.dgp.paObtieneEmpresaVinculada " & ENTC_DocIden).Tables(0)
        lueDepositoOriginal.Properties.DataSource = dtQuery
        lueDepositoOriginal.Properties.DisplayMember = "DescripcionDepositoTemporal"
        lueDepositoOriginal.Properties.ValueMember = "CodigoDepositoTemporal"

    End Sub


    Private Sub LoadDepositoTemporalNuevo()
        Dim dtQuery As New DataTable
        dtQuery = oAppService.ExecuteSQL("EXEC NextSoft.dgp.paListaDepositoExtranet").Tables(0)         'ExecuteSQL("EXEC NextSoft.dgp.paObtieneEmpresaVinculada " & ENTC_DocIden).Tables(0)
        lueNuevoDeposito.Properties.DataSource = dtQuery
        lueNuevoDeposito.Properties.DisplayMember = "DescripcionDepositoTemporal"
        lueNuevoDeposito.Properties.ValueMember = "CodigoDepositoTemporal"

    End Sub

    Private Sub bbiGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGuardar.ItemClick
        Dim oEntidadDireccionamiento_BE As EntidadDireccionamiento_BE = New EntidadDireccionamiento_BE()
        Dim oEntidadDireccionamiento_BE_Respuesta As EntidadDireccionamiento_BE = New EntidadDireccionamiento_BE()
        oEntidadDireccionamiento_BE.DOOV_HBL = txtHBL.Text.Trim
        oEntidadDireccionamiento_BE.ENTC_CodDepTemporal = lueDepositoOriginal.EditValue
        oEntidadDireccionamiento_BE.ENTC_CodDepTemporalSolicitado = lueNuevoDeposito.EditValue
        oEntidadDireccionamiento_BE.DescargaDirecta = chkDescargaDirecta.EditValue
        oEntidadDireccionamiento_BE_Respuesta = oAppService.ValidarDireccionamiento(oEntidadDireccionamiento_BE)

        If oEntidadDireccionamiento_BE_Respuesta.CodigoRespuesta = "001" Then
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Else
            MsgBox(oEntidadDireccionamiento_BE_Respuesta.DescripcionRespuesta)
        End If


    End Sub

    Private Sub txtHBL_Leave(sender As Object, e As EventArgs) Handles txtHBL.Leave
        Dim dtQuery As New DataTable
        Dim CodigoDeposito As String = ""
        dtQuery = oAppService.CargoAddressingQuery(Convert.ToInt32(Compania), 0, IIf(txtHBL.Text <> "", txtHBL.Text, Nothing))

        If Not IsNothing(dtQuery) Then
            If dtQuery.Rows.Count > 0 Then
                lblDepositoOriginal.Visible = True
                lblDescargaDirecta.Visible = True
                lblNuevoDeposito.Visible = True
                lueDepositoOriginal.Visible = True
                lueDepositoOriginal.ReadOnly = True
                lueDepositoOriginal.Enabled = False
                lueNuevoDeposito.Visible = True
                chkDescargaDirecta.Visible = True

                CodigoDeposito = dtQuery.Rows(0).Item("CodigoDepositoTemporal").ToString()

                lueDepositoOriginal.EditValue = Convert.ToInt32(CodigoDeposito)

            Else
                MsgBox("No se encontraron Bls con los criterios de búsqueda")

            End If



        End If









    End Sub

    Private Sub chkDescargaDirecta_EditValueChanged(sender As Object, e As EventArgs) Handles chkDescargaDirecta.EditValueChanged
        If chkDescargaDirecta.Checked Then
            lueNuevoDeposito.Enabled = False
            lblNuevoDeposito.Enabled = False
            lueNuevoDeposito.EditValue = Nothing
        Else
            lueNuevoDeposito.Enabled = True
            lblNuevoDeposito.Enabled = True


        End If
    End Sub
End Class
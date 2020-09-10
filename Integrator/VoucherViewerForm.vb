Public Class VoucherViewerForm
    Friend Sistema, Empresa, Ejercicio, FechaInicio, FechaFin, Mes, Libro, NoAsiento As String

    Private Sub VoucherViewerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainForm.Icon
        Dim dtQuery As New DataTable
        If Sistema = "NEXTSIS" Then
            lcVoucher.Text = Ejercicio & Mes & "-" & Libro & "-" & NoAsiento
            dtQuery = ExecuteSQL("Integrador.dbo.paObtieneAsientoContable '" & Empresa & "','" & Ejercicio & "','" & Mes & "','" & Libro & "','" & NoAsiento & "'")
            lcVoucherType.Text = IIf(dtQuery.Rows(0)("CABA_TipoAsiento") = "A", "Automático", "Manual")
            AuditPanelUpdate(dtQuery)
        Else
            lcVoucher.Text = Libro.Trim & "-" & NoAsiento.Trim
            dtQuery = ExecuteSQL("Integrador.con.paObtieneAsientoContable '" & Empresa & "','" & FechaInicio & "','" & FechaFin & "','" & Libro & "','" & NoAsiento & "'")
        End If
        If Sistema = "CONCAR" Then
            GridView1.PopulateColumns()
        End If
        gcMainData.DataSource = dtQuery

    End Sub

    Private Sub bbiClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiClose.ItemClick
        Close()
    End Sub

    Private Sub bbiExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExport.ItemClick
        ExportarExcel(gcMainData)
    End Sub

    Private Sub AuditPanelUpdate(dtSource As DataTable)
        Dim oRow As DataRow = dtSource.Rows(0)
        ucAuditPanel.UsuarioCreacion = Nothing
        ucAuditPanel.FechaCreacion = Nothing
        ucAuditPanel.UsuarioModificacion = Nothing
        ucAuditPanel.FechaModificacion = Nothing
        If Not oRow Is Nothing Then
            If Not IsDBNull(oRow("CABA_UsrCrea")) Then
                ucAuditPanel.UsuarioCreacion = oRow("CABA_UsrCrea")
                ucAuditPanel.FechaCreacion = oRow("CABA_FecCrea")
            End If
            If Not IsDBNull(oRow("CABA_UsrMod")) Then
                ucAuditPanel.UsuarioModificacion = oRow("CABA_UsrMod")
                ucAuditPanel.FechaModificacion = oRow("CABA_FecMod")
            End If
            ucAuditPanel.pnlAuditoria.Refresh()
        End If
    End Sub
End Class
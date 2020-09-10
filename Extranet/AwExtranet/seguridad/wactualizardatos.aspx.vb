Public Class wactualizardatos
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        loadTypeDocument()
    End Sub

    Private Sub loadTypeDocument()
        Try
            Dim oServicio As New ServicioDelfin.OnLineServiceClient

            Dim dt As New DataTable
            dt = oServicio.ExecuteSQL("EXEC NextSoft.dgp.paListaTipoDocumento").Tables(0)
            typeDocument.DataSource = dt
            typeDocument.TextField = "DescripcionTipoDocumento"
            typeDocument.ValueField = "CodigoTipoDocumento"
            typeDocument.DataBind()
            typeDocument.SelectedIndex = 0
        Catch ex As Exception

        End Try
    End Sub
End Class
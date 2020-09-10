Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Drawing
Imports DevExpress.XtraSplashScreen
Imports System.Threading

Public Class DetraccionesConstanciasForm
    Dim dtSource As New DataTable
    Dim LastButton As String

    Private Sub DetraccionesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'FiltersEnabled()
    End Sub

    Private Sub bbiProcess_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiProcess.ItemClick
        LastButton = e.Item.Name
        LoadInputValidations()
        If vpInputs.Validate Then
            SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)
            Try
                LoadDataSource()
            Catch ex As Exception
            Finally
                SplashScreenManager.CloseForm(False)
            End Try
        End If
    End Sub

    Private Sub LoadDataSource()
        Dim dtTarget As New DataTable
        Dim bProcess As Boolean = True
        Dim iFiles As Integer = OpenFileDialog1.FileNames.Count
        Dim WaitText As String = ""
        For i = 0 To iFiles - 1
            Try
                WaitText = "Cargando archivos Sunat (Archivo: " & (i + 1).ToString & " de " & iFiles.ToString & ")"
                If OpenFileDialog1.FileNames(i).ToUpper.EndsWith(".CSV") Then
                    Dim dtMasterTmp As New DataTable
                    SplashScreenManager.Default.SetWaitFormDescription(WaitText)
                    dtMasterTmp = LoadCSV(OpenFileDialog1.FileNames(i), True, ",")
                    InsertDataFile(dtMasterTmp, WaitText)
                End If
            Catch ex As Exception
                DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Ocurrió un error durante la carga de datos del archivo " & OpenFileDialog1.FileNames(i) & ". " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                SplashScreenManager.CloseForm(False)
                bProcess = False
            End Try
        Next
        SplashScreenManager.CloseForm(False)
        If bProcess Then
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Los datos fueron cargados satisfactoriamente.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Ocurrió un error durante la carga de datos. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub InsertDataFile(dtFile As DataTable, WaitText As String)
        Dim sQuery As String = ""
        dtSource = ExecuteSQL("select * from Integrador..ConstanciasDetracciones (nolock) where RucProveedor='#'")
        Try
            For Each row As DataRow In dtFile.Rows
                SplashScreenManager.Default.SetWaitFormDescription(WaitText & " (Fila: " & (dtFile.Rows.IndexOf(row) + 1).ToString & " de " & dtFile.Rows.Count.ToString & ")")
                If ExecuteSQL("select * from Integrador..ConstanciasDetracciones (nolock) where RucProveedor='" & row(4) & "' and TipoComprobante='" & row(13) & "' and SerieComprobante='" & row(14) & "' and NumeroComprobante='" & row(15) & "'").Rows.Count = 0 Then
                    sQuery = "EXEC Integrador.sun.paInsertaDetracciones '" & row(0) & "', '" & row(1) & "', '" & row(2) & "', '" & row(3) & "', '" & row(4) & "', '" & row(5) & "', '" & row(6) & "', '" & row(7) & "', '" & row(8) & "', '" & Format(CDate(row(9)), "yyyy-MM-dd") & "', " & row(10) & ", '" & row(11) & "', '" & row(12) & "', '" & row(13) & "', '" & row(14) & "', '" & row(15) & "', '" & AppUser & "'"
                    If ExecuteSQLNonQuery(sQuery) Then
                        dtSource.Rows.Add(row(0), row(1), row(2), row(3), row(4), row(5), row(6), row(7), row(8), Format(CDate(row(9)), "yyyy-MM-dd"), CDbl(row(10)), row(11), row(12), row(13), row(14), row(15))
                    Else
                        DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "No fue posible insertar la fila " & (dtFile.Rows.IndexOf(row) + 1).ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            Next
        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        gcDetracciones.DataSource = dtSource
        LayoutApply()
    End Sub

    Private Sub SearchData()
        Dim dtTarget As New DataTable
        Dim sQuery As String = ""
        sQuery += "EXEC paObtieneConstanciasDetracciones '" & tePeriodoDesde.Text & "', '" & tePeriodoHasta.Text & "'"
        dtTarget = ExecuteSQL(sQuery)
        gcDetracciones.DataSource = dtTarget
        LayoutApply()
    End Sub

    Private Sub LayoutApply()
        GridView1.PopulateColumns()
        For i = 10 To 10
            GridView1.Columns(i).SummaryItem.SetSummary(DevExpress.Data.SummaryItemType.Sum, "{0:n2}")
            GridView1.Columns(i).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridView1.Columns(i).DisplayFormat.FormatString = "n2"
        Next
    End Sub
    Private Sub bbiExportar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExport.ItemClick
        ExportarExcel(gcDetracciones)
    End Sub

    Private Sub bbiCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiClose.ItemClick
        Close()
    End Sub

    Private Sub beArchivoOrigen_Properties_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles beArchivoOrigen.Properties.ButtonClick
        OpenFileDialog1.Filter = "Archivos de Origen (*.csv)|*.csv"
        OpenFileDialog1.FileName = ""
        'OpenFileDialog1.InitialDirectory = IIf(My.Settings.LedgerSourceDirectory8 <> "", My.Settings.LedgerSourceDirectory8, "")
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            beArchivoOrigen.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub LoadInputValidations()
        Dim containsValidationRule As New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()

        containsValidationRule.ConditionOperator = ConditionOperator.IsNotBlank
        containsValidationRule.ErrorText = "Asigne un valor."
        containsValidationRule.ErrorType = ErrorType.Critical

        Dim customValidationRule As New CustomValidationRule()
        customValidationRule.ErrorText = "Valor obligatorio."
        customValidationRule.ErrorType = ErrorType.Critical
        Validate()
        vpInputs.SetValidationRule(beArchivoOrigen, Nothing)
        vpInputs.SetValidationRule(tePeriodoDesde, Nothing)
        vpInputs.SetValidationRule(tePeriodoHasta, Nothing)
        If LastButton = "bbiProcess" Then
            vpInputs.SetValidationRule(beArchivoOrigen, customValidationRule)
        Else
            vpInputs.SetValidationRule(tePeriodoDesde, customValidationRule)
            vpInputs.SetValidationRule(tePeriodoHasta, customValidationRule)
        End If
    End Sub

    Private Sub bbiSearch_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSearch.ItemClick
        LastButton = e.Item.Name
        LoadInputValidations()
        If vpInputs.Validate Then
            SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)
            Try
                SearchData()
            Catch ex As Exception
            Finally
                SplashScreenManager.CloseForm(False)
            End Try
        End If
    End Sub

    Private Sub bbiUpdate_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiUpdate.ItemClick
        LoadInputValidations()
        If Not vpInputs.Validate Then
            Return
        End If
        If DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Este proceso actualizará el número de detracción en NextSoft, desea continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.No Then
            Return
        End If
        Dim sQuery As String = ""
        Try
            sQuery += "EXEC paActualizaConstanciasDetracciones '" & tePeriodoDesde.Text & "', '" & tePeriodoHasta.Text & "'"
            If Not ExecuteSQLNonQuery(sQuery) Then
                DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Ocurrió un error al actualizar la información, por favor verifique el periodo no se encuentre cerrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            SearchData()
            SplashScreenManager.CloseForm(False)
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "El proceso de actualización finalizó satisfactoriamente.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            SplashScreenManager.CloseForm(False)
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
    End Sub
End Class
Imports System.IO

Public Class VisorOrdenVentaForm
    Friend sOrdenVenta As String

    Private Sub VisorOrdenVentaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtQuery, dtFiles As New DataTable
        dtQuery = NewExecuteSQL("EXEC dbo.paConsultaOrdenVenta '" & sOrdenVenta & "'")
        VGridControl1.DataSource = dtQuery
        If dtQuery.Rows.Count > 0 Then
            dtFiles = NewExecuteSQL("EXEC dbo.paObtieneArchivosPorOrdenVenta '" & dtQuery.Rows(0)("CCOT_Numero") & "'")
            gcFileStream.DataSource = dtFiles
        End If
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        Close()
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        VGridControl1.ExportToXlsx((FileIO.FileSystem.GetTempFileName).Replace(".tmp", ".xlsx"))
    End Sub

    Private Sub VGridControl1_DoubleClick(sender As Object, e As EventArgs) Handles VGridControl1.DoubleClick

    End Sub

    Private Sub bbiFileViewer_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiFileViewer.ItemClick
        Try
            Dim oRow As DataRow = GridView1.GetDataRow(GridView1.GetFocusedDataSourceRowIndex)
            Dim fileName As String = System.IO.Path.GetTempPath() + oRow("OVAR_Descrip")
            Using fileStream As New FileStream(fileName, FileMode.Create)
                ' Write the data to the file, byte by byte. 
                Dim i As Integer = 0
                While i < oRow("OVAR_Archivo").Length
                    fileStream.WriteByte(oRow("OVAR_Archivo")(i))
                    i += 1
                End While

                ' Set the stream position to the beginning of the file.
                fileStream.Seek(0, SeekOrigin.Begin)

                ' Read and verify the data. 
                i = 0
                While i < fileStream.Length
                    If oRow("OVAR_Archivo")(i) <> fileStream.ReadByte() Then
                        DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Ha ocurrido un error al crear le archivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        'Return False
                    End If
                    i += 1
                End While
            End Using

            'Infrastructure.WinForms.Controls.Dialogos.MostrarMensajeSatisfactorio(Title, "Se ha creado satifactoriamente el archivo.");
            System.Diagnostics.Process.Start(fileName)
            'System.IO.File.Delete(fileName);
            '}
            'else
            '{ return false; }
            'Return True
        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Ha ocurrido un error al descargar le archivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Return False
        End Try
    End Sub


End Class
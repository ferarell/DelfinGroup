Imports System.IO

Public Class VerticalViewerOVForm
    Dim oAppService As New AppService.DelfinServiceClient
    Public sHBL As String = "DLNB19030665"

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        'DevExpress.UserSkins.BonusSkins.Register()
        'DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Blue")

    End Sub

    Private Sub VerticalViewerOVForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtFiles, dtContainers As New DataTable
        Dim dsQuery As New DataSet
        dsQuery = oAppService.ExecuteSQL("EXEC NextSoft.dgp.paConsultaOrdenVenta '" & sHBL & "'")
        VGridControl1.DataSource = dsQuery.Tables(0)
        If dsQuery.Tables(0).Rows.Count > 0 Then
            'dtContainers = oAppService.ExecuteSQL("EXEC NextSoft.dgp.paObtieneContenedoresPorOrdenVenta '" & dtQuery.Rows(0)("CCOT_Numero") & "'").Tables(0)
            gcContainer.DataSource = dsQuery.Tables(2)
            GridView3.BestFitColumns()
            'dtFiles = oAppService.ExecuteSQL("EXEC NextSoft.dgp.paObtieneArchivosPorOrdenVenta '" & dtQuery.Rows(0)("CCOT_Numero") & "'").Tables(0)
            gcFileStream.DataSource = dsQuery.Tables(3) 'dtFiles
        End If
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
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Ha ocurrido un error al descargar el archivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Return False
        End Try
    End Sub


    Private Sub bbiClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiClose.ItemClick
        Close()
    End Sub

    Private Sub bbiExcelExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExcelExport.ItemClick
        ExportToExcel(VGridControl1)
        'VGridControl1.ExportToXlsx((FileIO.FileSystem.GetTempFileName).Replace(".tmp", ".xlsx"))
    End Sub
End Class
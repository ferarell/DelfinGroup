Imports System.Collections
Imports System.Data
Imports CrystalDecisions.ReportSource

Public Class Reporting
    'Friend dtPrint, dtPrint1, dtPrint2 As New DataTable
    Friend dsPrint As New DataSet
    Friend aParams As New ArrayList
    Friend RptFile As String
    Friend RptSubreports As Integer = 1
    Friend TargetFileName As String = ""

    Friend Sub ReportGenerate()
        Dim drPrint As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Try
            If IO.File.Exists(AppPath & "\Reports\" & RptFile) Then
                Console.Write("NOMBRE DE REPORTE: " & AppPath & "\Reports\" & RptFile & vbNewLine)
                drPrint.FileName = AppPath & "\Reports\" & RptFile
                drPrint.SetDataSource(dsPrint.Tables(0))
                For r = 1 To RptSubreports
                    drPrint.Subreports(r - 1).SetDataSource(dsPrint.Tables(r))
                Next
                For p = 0 To aParams.Count - 1
                    drPrint.SetParameterValue(p, aParams(p))
                Next
                Console.Write("NOMBRE DE ARCHIVO PDF: " & TargetFileName & vbNewLine)
                drPrint.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, TargetFileName)
                oLogFileUpdate.TextFileUpdate("ReportGenerator", "Se generó el archivo " & TargetFileName)
            End If

        Catch ex As Exception
            'DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            oLogFileUpdate.TextFileUpdate("ReportGenerator (Reporting - Friend Sub ReportGenerate)", ex.Message)
        End Try
    End Sub

End Class

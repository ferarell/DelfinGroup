Imports System.Collections
Imports System.Data
Imports CrystalDecisions.ReportSource

Public Class CreateFileFromCrystalReport
    Friend dsPrint As New DataSet
    Friend aParams As New ArrayList
    Friend RptFile As String
    Friend RptSubreports As Integer = 0
    Friend TargetFileName As String = ""
    Friend TargetFileFormat As New CrystalDecisions.Shared.ExportFormatType

    Friend Sub ReportGenerate()
        Dim drPrint As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Try
            drPrint.FileName = IO.Directory.GetCurrentDirectory & "\Reports\" & RptFile
            drPrint.SetDataSource(dsPrint.Tables(0))
            For r = 1 To RptSubreports
                drPrint.Subreports(r - 1).SetDataSource(dsPrint.Tables(r))
            Next
            For p = 0 To aParams.Count - 1
                drPrint.SetParameterValue(p, aParams(p))
            Next
            drPrint.ExportToDisk(TargetFileFormat, TargetFileName)
        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class

Imports Microsoft.Reporting.WinForms
Imports System.Net

Public Class ReportViewerForm
    Friend ReportPath As String
    Dim oAppService As New AppService.DelfinServiceClient

    Private Sub ReportViewerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim serverReport As ServerReport = ReportViewer.ServerReport
        Me.ReportViewer.ProcessingMode = ProcessingMode.Remote
        Me.ReportViewer.ServerReport.ReportServerUrl = New Uri("http://" & oAppService.Endpoint.ListenUri.Host & ":64999/ReportServer")
        Me.ReportViewer.ServerReport.ReportPath = ReportPath
        Me.ReportViewer.ServerReport.ReportServerCredentials.NetworkCredentials = New NetworkCredential("reporting", "Lim@2017", "DELFINGROUPCO")
        Me.ReportViewer.RefreshReport()
    End Sub
End Class

Imports System.IO

Public Class CargoNoticeQueryForm

    Private oAppService As New OnlineService.OnLineServiceClient
    Dim TargetFileName As String = ""
    Dim NoticeType As String = ""

    Private Sub CargoNoticeQueryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCustomer()
    End Sub

    Private Sub LoadCustomer()
        Dim dtQuery As New DataTable
        dtQuery = oAppService.ExecuteSQL("EXEC NextSoft.dgp.paObtieneEmpresaVinculada " & ENTC_DocIden).Tables(0)
        lueCustomer.Properties.DataSource = dtQuery
        lueCustomer.Properties.DisplayMember = "DescripcionCliente"
        lueCustomer.Properties.ValueMember = "CodigoCliente"
        lueCustomer.ItemIndex = 0
    End Sub

    Private Sub bbiViewer_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiViewer.ItemClick
        SplitContainerControl1.Panel2.Controls.Clear()
        If Not PdfGenerate() Then
            Return
        End If
        Dim oParentForm As New PdfViewerForm
        oParentForm.Dock = DockStyle.Fill
        oParentForm.TopLevel = False
        oParentForm.Parent = SplitContainerControl1.Panel2
        oParentForm.FormBorderStyle = FormBorderStyle.None
        oParentForm.pathpdf = TargetFileName
        oParentForm.Show()
    End Sub

    Friend Function PdfGenerate() As Boolean
        Dim dtQuery As New DataTable
        dtQuery = oAppService.ExecuteSQL("SELECT CCOT_Numero, DOOV_HBL FROM NextSoft..COM_Cab_Cotizacion_OV (NOLOCK) WHERE DOOV_HBL='" & teHBL.Text & "'").Tables(0)
        If dtQuery.Rows.Count = 0 Then
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "El HBL " & teHBL.Text & " no existe en el sistema, por favor verifique.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Dim iCCOT_Numero As Integer = dtQuery.Rows(0)(0)
        dtQuery.Clear()
        dtQuery = oAppService.ExecuteSQL("SELECT CCOT_Numero FROM NextSoft..COM_Det_Cotizacion_OV_EventosTareas (NOLOCK) WHERE CCOT_Numero = " & iCCOT_Numero.ToString & " AND TIPO_CodEVE=115").Tables(0)
        If dtQuery.Rows.Count = 0 Then
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "El HBL " & teHBL.Text & " aún no ha sido confirmado por el área de operaciones, por favor enviar su consulta a operations@delfingroupco.com.pe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Dim dsPrint As New DataSet
        Try
            dsPrint = oAppService.CargoNoticeQuery(teHBL.Text)
        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        If dsPrint.Tables(0).Rows.Count = 0 Then
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "La consulta de datos asociados al aviso del HBL " & teHBL.Text & " no ha retornado datos, por favor comuniquese con sistemas (itsupport@delfingroupco.com.pe)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Dim oReporting As New CreateFileFromCrystalReport
        If dsPrint.Tables(0).Rows(0)("CONS_CodRGM") = "001" And dsPrint.Tables(0).Rows(0)("CONS_CodVia") = "001" Then
            oReporting.RptFile = "AvisoArriboMaritimo.rpt"
            NoticeType = "_LLEGADA_"
        ElseIf dsPrint.Tables(0).Rows(0)("CONS_CodRGM") = "001" And dsPrint.Tables(0).Rows(0)("CONS_CodVia") = "002" Then
            oReporting.RptFile = "AvisoArriboAereo.rpt"
            NoticeType = "_LLEGADA_"
        ElseIf dsPrint.Tables(0).Rows(0)("CONS_CodRGM") = "002" And dsPrint.Tables(0).Rows(0)("CONS_CodVia") = "001" Then
            oReporting.RptFile = "AvisoZarpeMaritimo.rpt"
            NoticeType = "_SALIDA_"
        End If
        TargetFileName = Path.GetDirectoryName(FileIO.FileSystem.GetTempFileName) & "\AVISO" & NoticeType & teHBL.Text & "_" & Now.ToString("yyyyMMddHHmmss") & ".pdf"
        oReporting.dsPrint = dsPrint
        oReporting.RptSubreports = 1
        oReporting.TargetFileName = TargetFileName
        oReporting.TargetFileFormat = CrystalDecisions.Shared.ExportFormatType.PortableDocFormat
        oReporting.ReportGenerate()
        Return True
    End Function

    Private Sub bbiClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiClose.ItemClick
        Close()
    End Sub

    Private Sub bbiSearch_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSearch.ItemClick

    End Sub
End Class
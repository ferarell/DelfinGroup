Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.XtraBars
Imports DevExpress.XtraSplashScreen
Imports System.Threading
Imports System.IO

Public Class ContribuyentesSunatForm
    Dim dtSource As New DataTable
    Dim oAppService As New AppService.DelfinServiceClient

    Private Sub ContribuyentesSunatForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillMainView()
    End Sub

    Private Sub bbiSearch_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSearch.ItemClick
        Dim dtQuery As New DataTable
        dtQuery = NewExecuteSQL("SELECT * FROM Integrador.sun.Contribuyente")
    End Sub

    Private Sub bbiProcess_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiProcess.ItemClick
        Dim WaitText As String = ""
        SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)
        Dim iFiles As Integer = OpenFileDialog1.FileNames.Count
        Try
            For i = 0 To iFiles - 1
                WaitText = "Cargando archivos Sunat (Archivo: " & (i + 1).ToString & " de " & iFiles.ToString & ")"
                SplashScreenManager.Default.SetWaitFormDescription(WaitText)
                If OpenFileDialog1.FileNames(i).ToUpper.Contains(".XLS") Then
                    LoadSunatFiles(OpenFileDialog1.FileNames(i))
                End If
                If OpenFileDialog1.FileNames(i).ToUpper.EndsWith(".ZIP") Then
                    Decompress(OpenFileDialog1.FileNames(i), Path.GetDirectoryName(OpenFileDialog1.FileNames(i)))
                    LoadSunatFiles(OpenFileDialog1.FileNames(i).ToUpper.Replace(".ZIP", ".TXT"))
                End If
            Next
        Catch ex As Exception
            SplashScreenManager.CloseForm(False)
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
        FillMainView()
    End Sub

    Private Sub FillMainView()
        Try
            dtSource.Rows.Clear()
            dtSource = NewExecuteSQL("SELECT TOP 0 * FROM Integrador.sun.Contribuyente")
            gcMainData.DataSource = dtSource
        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadSunatFiles(sFileName As String)
        Dim aResult As New ArrayList
        Dim dtQuery, dtSource As New DataTable
        Dim iPos As Integer = 0
        Dim sColumn, SetValues, Condition As String
        sColumn = ""
        If sFileName.ToUpper.Contains("AGENRET_TXT") Then
            sColumn = "AgenteRetencion"
        ElseIf sFileName.ToUpper.Contains("BUECONT_TXT") Then
            sColumn = "BuenContribuyente"
        ElseIf sFileName.ToUpper.Contains("AFISEE_TXT") Then
            sColumn = "AfiliadoSEE"
        ElseIf sFileName.ToUpper.Contains({"AGENPERC_TXT", "AGENPERCVI_TXT"}) Then
            sColumn = "AgentePercepcion"
        ElseIf sFileName.ToUpper.Contains("NOHABI") Then
            sColumn = "NoHabido"
        End If
        If sFileName.ToUpper.Contains(".XLS") Then
            dtSource = LoadExcel(sFileName, "{0}").Tables(0)
        ElseIf sFileName.ToUpper.Contains(".TXT") Then
            dtSource = LoadTXT(sFileName, True, "|")
        End If
        SplashScreenManager.Default.SetWaitFormDescription("Actualizando Contribuyentes SUNAT (" & sColumn & ")")
        For r = 0 To dtSource.Rows.Count - 1
            SplashScreenManager.Default.SetWaitFormDescription("Procesando " & sColumn & " (Fila: " & (r + 1).ToString & " de " & (dtSource.Rows.Count - 1).ToString & ")")
            Dim row As DataRow = dtSource.Rows(r)
            dtQuery.Rows.Clear()
            dtQuery = NewExecuteSQL("select * from Integrador.sun.Contribuyente where NroRUC='" & row(0).ToString.Trim & "'")
            If dtQuery.Rows.Count = 0 Then
                dtQuery.Rows.Add()
                dtQuery.Rows(0)("NroRUC") = row(0)
                dtQuery.Rows(0)("RazonSocial") = row(1)
                dtQuery.Rows(0)("BuenContribuyente") = False
                dtQuery.Rows(0)("AgenteRetencion") = False
                dtQuery.Rows(0)("AfiliadoSEE") = False
                dtQuery.Rows(0)("AgentePercepcion") = False
                dtQuery.Rows(0)("NoHabido") = False
                If sColumn = "BuenContribuyente" Then
                    dtQuery.Rows(0)("BuenContribuyente") = True
                End If
                If sColumn = "AgenteRetencion" Then
                    dtQuery.Rows(0)("AgenteRetencion") = True
                End If
                If sColumn = "AfiliadoSEE" Then
                    dtQuery.Rows(0)("AfiliadoSEE") = True
                End If
                If sColumn = "AgentePercepcion" Then
                    dtQuery.Rows(0)("AgentePercepcion") = True
                End If
                If sColumn = "AgentePercepcion" Then
                    dtQuery.Rows(0)("AgentePercepcion") = True
                End If
                If sColumn = "NoHabido" Then
                    dtQuery.Rows(0)("NoHabido") = True
                End If
                dtQuery.Rows(0)("UserCreate") = AppUser
                dtQuery.Rows(0)("DateCreate") = Now
                aResult.AddRange(oAppService.InsertarContribuyente(dtQuery))
            Else
                If sColumn = "BuenContribuyente" Then
                    dtQuery.Rows(0)("BuenContribuyente") = True
                End If
                If sColumn = "AgenteRetencion" Then
                    dtQuery.Rows(0)("AgenteRetencion") = True
                End If
                If sColumn = "AfiliadoSEE" Then
                    dtQuery.Rows(0)("AfiliadoSEE") = True
                End If
                If sColumn = "AgentePercepcion" Then
                    dtQuery.Rows(0)("AgentePercepcion") = True
                End If
                If sColumn = "AgentePercepcion" Then
                    dtQuery.Rows(0)("AgentePercepcion") = True
                End If
                dtQuery.Rows(0)("UserUpdate") = AppUser
                dtQuery.Rows(0)("DateUpdate") = Now
                aResult.AddRange(oAppService.ActualizarContribuyente(dtQuery))
            End If
            If aResult(0) = 0 Then
                If DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, aResult(1) & ". Desea cancelar el proceso?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) = Windows.Forms.DialogResult.Yes Then
                    Exit For
                End If
            End If
        Next
    End Sub

    Private Sub bbiExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExport.ItemClick
        ExportarExcel(gcMainData)
    End Sub

    Private Sub bbiClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiClose.ItemClick
        Close()
    End Sub

    Private Sub LoadValidations()
        Dim containsValidationRule As New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()

        containsValidationRule.ConditionOperator = ConditionOperator.IsNotBlank
        containsValidationRule.ErrorText = "Asigne un valor."
        containsValidationRule.ErrorType = ErrorType.Critical

        Dim customValidationRule As New CustomValidationRule()
        customValidationRule.ErrorText = "Valor obligatorio."
        customValidationRule.ErrorType = ErrorType.Critical

        vpInputs.SetValidationRule(beArchivoOrigen, customValidationRule)

    End Sub

    Private Sub bbiSunat_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbiSunat.ItemClick
        System.Diagnostics.Process.Start("http://www.sunat.gob.pe/padronesnotificaciones/")
    End Sub

    Private Sub beArchivoOrigen_Properties_Click(sender As Object, e As EventArgs) Handles beArchivoOrigen.Properties.Click
        OpenFileDialog1.Filter = "Source Files (*.xls*;*.txt;*.zip)|*.xls*;*.txt;*.zip"
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            beArchivoOrigen.Text = OpenFileDialog1.FileName
        End If
    End Sub
End Class

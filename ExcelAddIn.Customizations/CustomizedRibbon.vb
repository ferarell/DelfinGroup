Imports Microsoft.Office.Tools.Ribbon
Imports Microsoft.Office.Interop.Excel
Imports System.Windows.Forms


Public Class CustomizedRibbon

    Private Sub Ribbon1_Load(ByVal sender As System.Object, ByVal e As RibbonUIEventArgs) Handles MyBase.Load
        Group2.Label = "Automations (" & My.Application.Info.Version.ToString & ")"
    End Sub

    Private Sub btResultadoOperativoV1_Click(sender As Object, e As RibbonControlEventArgs) Handles btResultadoOperativoV1.Click
        Dim TittleRng As Excel.Range = Globals.ThisAddIn.Application.Sheets("Clasificado").Range("A3")
        If Not TittleRng.Text.Contains("ESTADO DE RESULTADOS CLASIFICADO") Then
            DevExpress.XtraEditors.XtraMessageBox.Show("Este archivo no es válido para esta opción, verifique por favor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Dim oForm As New ResultadoOperativoV1Form
        oForm.ShowDialog()
    End Sub

    Private Sub btResultadoOperativoV2_Click(sender As Object, e As RibbonControlEventArgs) Handles btResultadoOperativoV2.Click
        Dim TittleRng As Excel.Range = Globals.ThisAddIn.Application.Sheets("Clasificado").Range("A3")
        If Not TittleRng.Text.Contains("ESTADO DE RESULTADOS CLASIFICADO") Then
            DevExpress.XtraEditors.XtraMessageBox.Show("Este archivo no es válido para esta opción, verifique por favor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Dim oForm As New ResultadoOperativoV2Form
        oForm.ShowDialog()
    End Sub

    Private Sub btResultadoOperativoV3_Click(sender As Object, e As RibbonControlEventArgs) Handles btResultadoOperativoV3.Click
        Dim TittleRng As Excel.Range = Globals.ThisAddIn.Application.Sheets("Clasificado").Range("A3")
        If Not TittleRng.Text.Contains("ESTADO DE RESULTADOS CLASIFICADO") Then
            DevExpress.XtraEditors.XtraMessageBox.Show("Este archivo no es válido para esta opción, verifique por favor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Dim oForm As New ResultadoOperativoV3Form
        oForm.ShowDialog()
    End Sub
End Class

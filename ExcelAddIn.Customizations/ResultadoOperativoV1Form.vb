Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraEditors.DXErrorProvider
Imports System.Data
Imports System.Windows.Forms

Public Class ResultadoOperativoV1Form
    Dim oAppService As New AppService.DelfinServiceClient
    Dim dsSource As New DataSet
    Dim dTeus As Double = 0
    Dim sPeriodo As String = ""

    Private Sub ResultadoOperativoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        seFiscalYear.Text = Year(Now).ToString
        seFiscalPeriod.Text = Month(Now).ToString
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Black")
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Hide()
        SplashScreenManager.ShowForm(GetType(WaitForm))
        Dim FecIni As String = seFiscalYear.Text & Format(seFiscalPeriod.EditValue, "-00") & "-01"
        Dim FecFin As String = Format(LastDayOfMonth(FecIni), "yyyy-MM-dd")
        sPeriodo = Format(seFiscalPeriod.EditValue, "00")
        dTeus = 0
        Try
            'Impo FCL
            ProcesoImpoFCL("EXEC Integrador.dbo.paResultadoOperativo 'RGM', '001', 'FCL', '" & FecIni & "', '" & FecFin & "'", "Impo FCL")
            'Impo LCL
            ProcesoImpoLCL("EXEC Integrador.dbo.paResultadoOperativo 'RGM', '001', 'LCL', '" & FecIni & "', '" & FecFin & "'", "Impo LCL")
            'Expo FCL
            ProcesoExpoFCL("EXEC Integrador.dbo.paResultadoOperativo 'RGM', '002', 'FCL', '" & FecIni & "', '" & FecFin & "'", "Expo FCL")
            'Expo LCL
            ProcesoExpoLCL("EXEC Integrador.dbo.paResultadoOperativo 'RGM', '002', 'LCL', '" & FecIni & "', '" & FecFin & "'", "Expo LCL")
            'Gastos por Centro de Costo
            ProcesoGastos("EXEC Reportes.dbo.paSaldosPorCentroCostoDG 3, '" & seFiscalYear.Text & "', '" & sPeriodo & "', '" & sPeriodo & "', 'D'", "Impo Gastos DG")
            ProcesoGastos("EXEC Reportes.dbo.paSaldosPorCentroCostoDG 3, '" & seFiscalYear.Text & "', '" & sPeriodo & "', '" & sPeriodo & "', 'D'", "Expo Gastos DG")
            ProcesoGastos("EXEC Reportes.dbo.paSaldosPorCentroCostoDG 3, '" & seFiscalYear.Text & "', '" & sPeriodo & "', '" & sPeriodo & "', 'D'", "SLI Gastos DG")
            ProcesoGastos("EXEC Reportes.dbo.paSaldosPorCentroCostoDC 3, '" & seFiscalYear.Text & "', '" & sPeriodo & "', '" & sPeriodo & "', 'D'", "Impo Gastos DC")
            'Ingresos
            ProcesoIngresos("EXEC Reportes.dbo.paSaldosPorCuentaDG 2,'" & seFiscalYear.Text & "', '" & sPeriodo & "', '" & sPeriodo & "', 'D', '70'", "Impo Ingresos DG")
            ProcesoIngresos("EXEC Reportes.dbo.paSaldosPorCuentaDC 2,'" & seFiscalYear.Text & "', '" & sPeriodo & "', '" & sPeriodo & "', 'D', '70'", "Impo Ingresos DC")
        Catch ex As Exception
            SplashScreenManager.CloseForm(False)
            DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
        Globals.ThisAddIn.Application.Sheets("dg.impo").Select()
        DevExpress.XtraEditors.XtraMessageBox.Show("El proceso finalizó satisfactoriamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub ProcesoImpoFCL(CmdStr As String, PrcTxt As String)
        dsSource.Tables.Clear()
        SplashScreenManager.Default.SetWaitFormDescription("Procesando " & PrcTxt & "...")
        Try
            dsSource = oAppService.ExecuteSQL(CmdStr)
            If Not dsSource Is Nothing Then
                ActualizaHoja("dg.impo", dsSource, PrcTxt)
            End If
        Catch ex As Exception
            SplashScreenManager.CloseForm(False)
            DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try
    End Sub

    Private Sub ProcesoImpoLCL(CmdStr As String, PrcTxt As String)
        dsSource.Tables.Clear()
        SplashScreenManager.Default.SetWaitFormDescription("Procesando " & PrcTxt & "...")
        Try
            dsSource = oAppService.ExecuteSQL(CmdStr)
            If Not dsSource Is Nothing Then
                ActualizaHoja("dg.impo", dsSource, PrcTxt)
            End If
        Catch ex As Exception
            SplashScreenManager.CloseForm(False)
            DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try
    End Sub

    Private Sub ProcesoExpoFCL(CmdStr As String, PrcTxt As String)
        dsSource.Tables.Clear()
        SplashScreenManager.Default.SetWaitFormDescription("Procesando " & PrcTxt & "...")
        Try
            dsSource = oAppService.ExecuteSQL(CmdStr)
            If Not dsSource Is Nothing Then
                ActualizaHoja("dg.expo", dsSource, PrcTxt)
            End If
        Catch ex As Exception
            SplashScreenManager.CloseForm(False)
            DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try
    End Sub

    Private Sub ProcesoExpoLCL(CmdStr As String, PrcTxt As String)
        dsSource.Tables.Clear()
        SplashScreenManager.Default.SetWaitFormDescription("Procesando " & PrcTxt & "...")
        Try
            dsSource = oAppService.ExecuteSQL(CmdStr)
            If Not dsSource Is Nothing Then
                ActualizaHoja("dg.expo", dsSource, PrcTxt)
            End If
        Catch ex As Exception
            SplashScreenManager.CloseForm(False)
            DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try
    End Sub

    Private Sub ProcesoGastos(CmdStr As String, PrcTxt As String)
        Dim cia As String = Strings.Right(PrcTxt, 2).ToLower
        dsSource.Tables.Clear()
        SplashScreenManager.Default.SetWaitFormDescription("Procesando " & PrcTxt & "...")
        Try
            dsSource = oAppService.ExecuteSQL(CmdStr)
            If Not dsSource Is Nothing Then
                If PrcTxt.ToUpper.Contains("IMPO") Then
                    ActualizaHoja(cia & ".impo", dsSource, PrcTxt)
                ElseIf PrcTxt.ToUpper.Contains("EXPO") Then
                    ActualizaHoja(cia & ".expo", dsSource, PrcTxt)
                ElseIf PrcTxt.ToUpper.Contains("SLI") Then
                    ActualizaHoja(cia & ".sli", dsSource, PrcTxt)
                End If
            End If
        Catch ex As Exception
            SplashScreenManager.CloseForm(False)
            DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try
    End Sub

    Private Sub ProcesoIngresos(CmdStr As String, PrcTxt As String)
        Dim cia As String = Strings.Right(PrcTxt, 2).ToLower
        dsSource.Tables.Clear()
        SplashScreenManager.Default.SetWaitFormDescription("Procesando " & PrcTxt & "...")
        Try
            dsSource = oAppService.ExecuteSQL(CmdStr)
            If Not dsSource Is Nothing Then
                ActualizaHoja(cia & ".impo", dsSource, PrcTxt)
            End If
        Catch ex As Exception
            SplashScreenManager.CloseForm(False)
            DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try
    End Sub

    Friend Function ActualizaHoja(Hoja As String, dsSource As DataSet, CodCnd As String) As Boolean
        Dim sMes As String = MonthName(seFiscalPeriod.EditValue)
        Dim iRows As Integer = 0
        If dsSource.Tables(0).Rows.Count = 0 Then
            Return False
        End If
        Dim bResult As Boolean = True
        Dim SheetRng As Excel.Range = Globals.ThisAddIn.Application.Sheets(Hoja).Range("A1:CC5000")

        Dim currentFind As Excel.Range = Nothing
        Dim firstFind As Excel.Range = Nothing

        currentFind = SheetRng.Find(seFiscalYear.Text & Format(seFiscalPeriod.EditValue, "00"), , _
        Excel.XlFindLookIn.xlValues, Excel.XlLookAt.xlPart, _
        Excel.XlSearchOrder.xlByRows, Excel.XlSearchDirection.xlNext, False)
        While Not currentFind Is Nothing
            ' Keep track of the first range you find.
            If firstFind Is Nothing Then
                firstFind = currentFind
                ' If you didn't move to a new range, you are done.
            ElseIf currentFind.Address = firstFind.Address Then
                Exit While
            End If
            With currentFind.Font
                .Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black)
                .Bold = True
            End With
            currentFind = SheetRng.FindNext(currentFind)
        End While
        Dim dtotal_c As Double = 0
        Dim dtotal_p As Double = 0
        Dim dprov1_c As Double = 0
        Dim dprov2_c As Double = 0
        Dim dprovi_v As Double = 0
        If Strings.Right(CodCnd, 2) = "CL" Then
            If dsSource.Tables(0).Columns.Contains("TOTAL_A_COBRAR") Then
                dtotal_c = dsSource.Tables(0).Compute("SUM(TOTAL_A_COBRAR)", "")
            End If
            If dsSource.Tables(0).Columns.Contains("TOTAL_A_PAGAR") Then
                dtotal_p = dsSource.Tables(0).Compute("SUM(TOTAL_A_PAGAR)", "")
            End If
            If dsSource.Tables(0).Columns.Contains("PROVI_C_Tr") Then
                dprov1_c = dsSource.Tables(0).Compute("SUM(PROVI_C_Tr)", "")
            End If
            If dsSource.Tables(0).Columns.Contains("PROVISION_C_Tr") Then
                dprov2_c = dsSource.Tables(0).Compute("SUM(PROVISION_C_Tr)", "")
            End If
            If dsSource.Tables(0).Columns.Contains("PROVISION_V_Tr") Then
                dprovi_v = dsSource.Tables(0).Compute("SUM(PROVISION_V_Tr)", "")
            End If
            Dim iTable As Integer = dsSource.Tables.Count - 1
            If Not IsDBNull(dsSource.Tables(iTable).Compute("SUM(" & sMes & ")", "DESC='TEUS'")) Then
                dTeus = dsSource.Tables(iTable).Compute("SUM(" & sMes & ")", "DESC='TEUS'")
            End If
            If Strings.Right(CodCnd, 3) = "FCL" Then
                SheetRng.Cells(firstFind.Cells.Row + 3, firstFind.Cells.Column) = dtotal_c
                SheetRng.Cells(firstFind.Cells.Row + IIf(Mid(CodCnd, 1, 1) = "I", 17, 11), firstFind.Cells.Column) = (dtotal_p) * -1 + dprov1_c + dprov2_c - dprovi_v
            Else
                SheetRng.Cells(firstFind.Cells.Row + 4, firstFind.Cells.Column) = dtotal_c
                SheetRng.Cells(firstFind.Cells.Row + IIf(Mid(CodCnd, 1, 1) = "I", 18, 12), firstFind.Cells.Column) = (dtotal_p) * -1 + dprov1_c + dprov2_c - dprovi_v
            End If
            SheetRng.Cells(firstFind.Cells.Row + IIf(Mid(CodCnd, 1, 1) = "I", 54, 38), firstFind.Cells.Column) = dTeus
        End If
        'If CodCnd.Contains("Impo Ingresos") Then
        '    If Not IsDBNull(dsSource.Tables(0).Compute("SUM(M" & sPeriodo & ")", "CUEN_Codigo='70.4.1.10'")) Then
        '        SheetRng.Cells(firstFind.Cells.Row + 5, firstFind.Cells.Column) = dsSource.Tables(0).Compute("SUM(M" & sPeriodo & ")", "CUEN_Codigo='70.4.1.10'") * -1
        '    End If
        '    If Not IsDBNull(dsSource.Tables(0).Compute("SUM(M" & sPeriodo & ")", "CUEN_Codigo='70.4.1.70'")) Then Ingreso SLI
        '        SheetRng.Cells(firstFind.Cells.Row + 9, firstFind.Cells.Column) = dsSource.Tables(0).Compute("SUM(M" & sPeriodo & ")", "CUEN_Codigo='70.4.1.70'") * -1
        '    End If
        '69.4.1.80 Costo SLI
        'End If
        If CodCnd.Contains("Impo Gastos") Then
            If Not IsDBNull(dsSource.Tables(0).Compute("SUM(M" & sPeriodo & ")", "group_id='02.02'")) Then
                iRows = IIf(Hoja.Contains("dg"), 25, IIf(Hoja.Contains("dc"), 16, 0))
                SheetRng.Cells(firstFind.Cells.Row + iRows, firstFind.Cells.Column) = dsSource.Tables(0).Compute("SUM(M" & sPeriodo & ")", "group_id='02.02'") * -1
            End If
            If Not IsDBNull(dsSource.Tables(0).Compute("SUM(M" & sPeriodo & ")", "group_id='02.03'")) Then
                iRows = IIf(Hoja.Contains("dg"), 27, IIf(Hoja.Contains("dc"), 18, 0))
                SheetRng.Cells(firstFind.Cells.Row + iRows, firstFind.Cells.Column) = dsSource.Tables(0).Compute("SUM(M" & sPeriodo & ")", "group_id='02.03'") * -1
            End If
            If Not IsDBNull(dsSource.Tables(0).Compute("SUM(M" & sPeriodo & ")", "group_id='02.04'")) Then
                iRows = IIf(Hoja.Contains("dg"), 28, IIf(Hoja.Contains("dc"), 19, 0))
                SheetRng.Cells(firstFind.Cells.Row + iRows, firstFind.Cells.Column) = dsSource.Tables(0).Compute("SUM(M" & sPeriodo & ")", "group_id='02.04'") * -1
            End If
            If Not IsDBNull(dsSource.Tables(0).Compute("SUM(M" & sPeriodo & ")", "group_id='02.05'")) Then
                iRows = IIf(Hoja.Contains("dg"), 29, IIf(Hoja.Contains("dc"), 20, 0))
                SheetRng.Cells(firstFind.Cells.Row + iRows, firstFind.Cells.Column) = dsSource.Tables(0).Compute("SUM(M" & sPeriodo & ")", "group_id='02.05'") * -1
            End If
            If Not IsDBNull(dsSource.Tables(0).Compute("SUM(M" & sPeriodo & ")", "group_id='02.06'")) Then
                iRows = IIf(Hoja.Contains("dg"), 30, IIf(Hoja.Contains("dc"), 21, 0))
                SheetRng.Cells(firstFind.Cells.Row + iRows, firstFind.Cells.Column) = dsSource.Tables(0).Compute("SUM(M" & sPeriodo & ")", "group_id='02.06'") * -1
            End If
            If Not IsDBNull(dsSource.Tables(0).Compute("SUM(M" & sPeriodo & ")", "group_id='02.07'")) Then
                iRows = IIf(Hoja.Contains("dg"), 31, IIf(Hoja.Contains("dc"), 22, 0))
                SheetRng.Cells(firstFind.Cells.Row + iRows, firstFind.Cells.Column) = dsSource.Tables(0).Compute("SUM(M" & sPeriodo & ")", "group_id='02.07'") * -1
            End If
            If Not IsDBNull(dsSource.Tables(0).Compute("SUM(M" & sPeriodo & ")", "group_id='02.08'")) Then
                iRows = IIf(Hoja.Contains("dg"), 32, IIf(Hoja.Contains("dc"), 23, 0))
                SheetRng.Cells(firstFind.Cells.Row + iRows, firstFind.Cells.Column) = dsSource.Tables(0).Compute("SUM(M" & sPeriodo & ")", "group_id='02.08'") * -1
            End If
            If Not IsDBNull(dsSource.Tables(0).Compute("SUM(M" & sPeriodo & ")", "group_id='02.09'")) Then
                iRows = IIf(Hoja.Contains("dg"), 33, IIf(Hoja.Contains("dc"), 24, 0))
                SheetRng.Cells(firstFind.Cells.Row + iRows, firstFind.Cells.Column) = dsSource.Tables(0).Compute("SUM(M" & sPeriodo & ")", "group_id='02.09'") * -1
            End If
            If Not IsDBNull(dsSource.Tables(0).Compute("SUM(M" & sPeriodo & ")", "group_id='03.01'")) Then
                iRows = IIf(Hoja.Contains("dg"), 40, IIf(Hoja.Contains("dc"), 30, 0))
                SheetRng.Cells(firstFind.Cells.Row + iRows, firstFind.Cells.Column) = dsSource.Tables(0).Compute("SUM(M" & sPeriodo & ")", "group_id='03.01'") * -1
            End If
            If Not IsDBNull(dsSource.Tables(0).Compute("SUM(M" & sPeriodo & ")", "CUEN_Codigo = '68.4.1.04'")) Then
                iRows = IIf(Hoja.Contains("dg"), 41, IIf(Hoja.Contains("dc"), 31, 0))
                SheetRng.Cells(firstFind.Cells.Row + iRows, firstFind.Cells.Column) = dsSource.Tables(0).Compute("SUM(M" & sPeriodo & ")", "CUEN_Codigo LIKE = '68.4.1.04'") * -1
            End If
            If Not IsDBNull(dsSource.Tables(0).Compute("SUM(M" & sPeriodo & ")", "group_id='03.02'")) Then
                iRows = IIf(Hoja.Contains("dg"), 42, IIf(Hoja.Contains("dc"), 32, 0))
                SheetRng.Cells(firstFind.Cells.Row + iRows, firstFind.Cells.Column) = dsSource.Tables(0).Compute("SUM(M" & sPeriodo & ")", "group_id='03.02'") * -1
            End If
        End If
        If CodCnd.Contains("Expo Gastos") Then
            If Not IsDBNull(dsSource.Tables(0).Compute("SUM(M" & sPeriodo & ")", "group_id='02.01'")) Then
                iRows = IIf(Hoja.Contains("dg"), 19, IIf(Hoja.Contains("dc"), 17, 17))
                SheetRng.Cells(firstFind.Cells.Row + iRows, firstFind.Cells.Column) = dsSource.Tables(0).Compute("SUM(M" & sPeriodo & ")", "group_id='02.01'") * -1
            End If
        End If
        If CodCnd.Contains("SLI Gastos") Then
            If Not IsDBNull(dsSource.Tables(0).Compute("SUM(M" & sPeriodo & ")", "group_id='02.10'")) Then
                iRows = IIf(Hoja.Contains("dg"), 22, IIf(Hoja.Contains("dc"), 22, 22))
                SheetRng.Cells(firstFind.Cells.Row + iRows, firstFind.Cells.Column) = dsSource.Tables(0).Compute("SUM(M" & sPeriodo & ")", "group_id='02.10'") * -1
            End If
        End If

        Return bResult
    End Function

    Private Sub LoadInputValidations()
        Validate()
        Dim containsValidationRule As New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        containsValidationRule.ConditionOperator = ConditionOperator.IsNotBlank
        containsValidationRule.ErrorText = "Asigne un valor."
        containsValidationRule.ErrorType = ErrorType.Critical
        Dim customValidationRule As New CustomValidationRule()
        customValidationRule.ErrorText = "Valor obligatorio."
        customValidationRule.ErrorType = ErrorType.Critical
        vpInputs.SetValidationRule(Me.seFiscalPeriod, customValidationRule)
        vpInputs.SetValidationRule(Me.seFiscalYear, customValidationRule)
    End Sub

End Class
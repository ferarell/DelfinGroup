Public Class DataProcess

    Public Sub DataGenerate(sHbl As String)
        Dim bResult As Boolean = True
        Dim aAttachments As New ArrayList
        Dim dsPrint As New DataSet
        Dim dtPrint1, dtPrint2 As New DataTable
        Dim sFileName As String = ""
        Console.Write("EJECUTA SP: EXEC NextSoft.web.upCargoNoticeQuery 1, 1, NULL, NULL, NULL, NULL, '" & sHbl & "'" & vbNewLine)
        dtPrint1 = ExecuteSQL("EXEC NextSoft.web.upCargoNoticeQuery 1, 1, NULL, NULL, NULL, NULL, '" & sHbl & "'").Copy
        dsPrint.Tables.Add(dtPrint1)
        dsPrint.Tables(0).TableName = "Query1"
        If dsPrint.Tables(0).Rows.Count = 0 Then
            'SendNewMessage("PRC_ERROR", oMailItem, Identifier, "El HBL indicado no ha sido encontrado en el sistema, por favor verifique.", Nothing)
            Return
        End If
        Console.Write("FILAS RETORNADAS DE CONSULTA1: " & dtPrint1.Rows.Count & vbNewLine)
        dtPrint2 = ExecuteSQL("EXEC NextSoft.dbo.OPE_CCOTSS_PorPagar " & dsPrint.Tables(0)(0)("EMPR_Codigo").ToString & ", " & dsPrint.Tables(0)(0)("CCOT_Numero").ToString).Copy
        dsPrint.Tables.Add(dtPrint2)
        dsPrint.Tables(1).TableName = "Query2"
        Console.Write("FILAS RETORNADAS DE CONSULTA2: " & dtPrint2.Rows.Count & vbNewLine)
        sFileName = My.Settings.ProcessedPath & "\AVISO_" & sHbl & "_" & Now.ToString("yyyyMMdd") & ".pdf"
        Dim oReporting As New Reporting
        oReporting.dsPrint = dsPrint
        Dim oRow As DataRow = dtPrint1.Rows(0)
        If oRow("CONS_CodVia") = "001" Then
            If oRow("CONS_CodRGM") = "001" Then 'Impo
                '_LabelNotice = "Aviso de Arribo de Importación Marítima"
                '_TipoAviso = "AVISO DE ARRIBO"
                If oRow("EsLCL") = 0 Then 'FCL
                    If oRow("Puerto").ToString.Contains("ARICA") Then 'Arica
                        oReporting.RptFile = "AvisoArriboMaritimoFcl_CLARI.rpt"
                        'richEditControl.LoadDocument(IO.Directory.GetCurrentDirectory & "\Plantillas\ContenidoCorreoAvisosImpoFcl_CLARI.htm", DevExpress.XtraRichEdit.DocumentFormat.Html)
                    Else 'Todo Destino
                        oReporting.RptFile = "AvisoArriboMaritimoFcl.rpt"
                        'richEditControl.LoadDocument(IO.Directory.GetCurrentDirectory & "\Plantillas\ContenidoCorreoAvisosImpoFcl.htm", DevExpress.XtraRichEdit.DocumentFormat.Html)
                    End If
                End If
                If oRow("EsLCL") = 1 Then 'LCL
                    'Todo Destino
                    oReporting.RptFile = "AvisoArriboMaritimoLcl.rpt"
                    'richEditControl.LoadDocument(IO.Directory.GetCurrentDirectory & "\Plantillas\ContenidoCorreoAvisosImpoLcl.htm", DevExpress.XtraRichEdit.DocumentFormat.Html)
                End If
            ElseIf oRow("CONS_CodRGM") = "002" Then 'Expo
                '_LabelNotice = "Aviso de Zarpe de Exportación Marítima"
                '_TipoAviso = "AVISO DE ZARPE"
                If oRow("EsLCL") = 0 Then 'FCL
                    oReporting.RptFile = "AvisoZarpeMaritimoFcl.rpt"
                    'richEditControl.LoadDocument(IO.Directory.GetCurrentDirectory & "\Plantillas\ContenidoCorreoAvisosExpoFcl.htm", DevExpress.XtraRichEdit.DocumentFormat.Html)
                End If
                If oRow("EsLCL") = 1 Then 'LCL
                    'Todo Destino
                    oReporting.RptFile = "AvisoZarpeMaritimoLcl.rpt"
                    'richEditControl.LoadDocument(IO.Directory.GetCurrentDirectory & "\Plantillas\ContenidoCorreoAvisosExpoLcl.htm", DevExpress.XtraRichEdit.DocumentFormat.Html)
                End If
            End If
        End If
        'Aéreo
        If oRow("CONS_CodVia") = "002" Then
            If oRow("CONS_CodRGM") = "001" Then 'Impo
                '_LabelNotice = "Aviso de Arribo de Importación Aérea"
                '_TipoAviso = "AVISO DE ARRIBO"
                If oRow("EsLCL") = 0 Then 'FCL
                    oReporting.RptFile = "AvisoArriboAereo.rpt"
                    'richEditControl.LoadDocument(IO.Directory.GetCurrentDirectory & "\Plantillas\ContenidoCorreoAvisosImpoAereo.htm", DevExpress.XtraRichEdit.DocumentFormat.Html)
                End If
                If oRow("EsLCL") = 1 Then 'LCL
                    oReporting.RptFile = "AvisoArriboAereo.rpt"
                    'richEditControl.LoadDocument(IO.Directory.GetCurrentDirectory & "\Plantillas\ContenidoCorreoAvisosImpoAereo.htm", DevExpress.XtraRichEdit.DocumentFormat.Html)
                End If
            ElseIf oRow("CONS_CodRGM") = "002" Then 'Expo
                '_LabelNotice = "Aviso de Salida"
                '_TipoAviso = "AVISO DE SALIDA"
                If oRow("EsLCL") = 0 Then 'FCL
                    oReporting.RptFile = "AvisoSalidaAereo.rpt"
                    'richEditControl.LoadDocument(IO.Directory.GetCurrentDirectory & "\Plantillas\ContenidoCorreoAvisosExpoAereo.htm", DevExpress.XtraRichEdit.DocumentFormat.Html)
                End If
                If oRow("EsLCL") = 1 Then 'LCL
                    'Todo Destino
                    oReporting.RptFile = "AvisoSalidaAereo.rpt"
                    'richEditControl.LoadDocument(IO.Directory.GetCurrentDirectory & "\Plantillas\ContenidoCorreoAvisosExpoAereo.htm", DevExpress.XtraRichEdit.DocumentFormat.Html)
                End If
            End If
        End If

        'If dtPrint1.Rows(0)("CONS_CodRGM") = "001" And dtPrint1.Rows(0)("CONS_CodVia") = "001" Then
        '    If dtPrint1.Rows(0)("EsLCL") = 1 Then
        '        oReporting.RptFile = "AvisoArriboMaritimoLcl.rpt"
        '    Else
        '        oReporting.RptFile = "AvisoArriboMaritimoFcl.rpt"
        '    End If
        'ElseIf dtPrint1.Rows(0)("CONS_CodRGM") = "001" And dtPrint1.Rows(0)("CONS_CodVia") = "002" Then
        '    oReporting.RptFile = "AvisoArriboAereo.rpt"
        'ElseIf dtPrint1.Rows(0)("CONS_CodRGM") = "002" And dtPrint1.Rows(0)("CONS_CodVia") = "001" Then
        '    oReporting.RptFile = "AvisoZarpeMaritimo.rpt"
        'End If

        oReporting.RptSubreports = 1
        oReporting.TargetFileName = sFileName
        oReporting.ReportGenerate()
    End Sub

End Class

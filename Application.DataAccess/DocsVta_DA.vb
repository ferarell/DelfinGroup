Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Imports Application.BusinessEntities
Public Class DocsVta_DA
    Dim constr As String = ConfigurationSettings.AppSettings("dbNextSoft").ToString()
    Dim cnx As New SqlConnection(constr)
    Dim cmd As New SqlCommand



    'Public Function PreFacturar(PDOC_Codigo As Integer, AUDI_UsrCrea As String) As Boolean
    Public Function PreFacturar(COPE_Codigo As Integer, dsDocumentoVenta As DataSet) As ArrayList
        'With cmd
        '    .Connection = cnx
        '    .CommandType = CommandType.StoredProcedure
        '    .CommandText = "DGP.VEN_DOCVSI_InsertaUnDocumento"

        '    With .Parameters
        '        .Clear()
        '        .Add("@pintPDOC_Codigo", SqlDbType.Int, 4).Value = PDOC_Codigo
        '        .Add("@pvchAUDI_UsrCrea", SqlDbType.VarChar, 20).Value = AUDI_UsrCrea
        '    End With
        'End With

        'Try
        '    cnx.Open()
        '    If cmd.ExecuteNonQuery() > 0 Then
        '        Return True
        '    Else
        '        Return False
        '    End If
        'Catch ex As Exception
        '    Throw
        'Finally
        '    cnx.Close()
        'End Try


        Dim aResult As New ArrayList
        Dim dtHeader As DataTable = dsDocumentoVenta.Tables("Header")
        Dim dtDetail As DataTable = dsDocumentoVenta.Tables("Detail")

        Dim _DOCV_Codigo As String = ""
        aResult.AddRange({2, ""})
        Using connection As New SqlConnection(ConfigurationSettings.AppSettings("dbNextSoft").ToString())
            connection.Open()
            Dim Command As New SqlCommand
            Dim transaction As SqlTransaction
            transaction = connection.BeginTransaction("PreFactura")
            Command.Connection = connection
            Command.Transaction = transaction
            Try
                'Cabecera
                Dim oRowH As DataRow = dtHeader.Rows(0)
                Command.CommandType = CommandType.StoredProcedure
                Command.CommandText = "NextSoft.dgp.VEN_DOCVSI_UnReg"
                Command.Parameters.Clear()
                With Command.Parameters
                    .Add("@pintCOPE_Codigo", SqlDbType.Int).Value = oRowH("COPE_Codigo")
                    .Add("@pintDOCV_Codigo", SqlDbType.Int).Value = oRowH("DOCV_Codigo")
                    .Add("@pvchDOCV_Numero", SqlDbType.VarChar, 20).Value = oRowH("DOCV_Numero")
                    .Add(New SqlParameter("@pnumDOCV_TipoCambio", SqlDbType.Decimal) With {.Precision = 18, .Scale = 4}).Value = oRowH("DOCV_TipoCambio")
                    .Add("@pdtmDOCV_FechaEmision", SqlDbType.DateTime).Value = oRowH("DOCV_FechaEmision")
                    .Add("@pdtmDOCV_FechaVcmto", SqlDbType.DateTime).Value = oRowH("DOCV_FechaVcmto")
                    .Add("@pchrDOCV_Estado", SqlDbType.Char, 1).Value = oRowH("DOCV_Estado")

                    .Add(New SqlParameter("@pdecDOCV_PrecVtaTotal", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowH("DOCV_PrecVtaTotal")
                    .Add(New SqlParameter("@pdecDOCV_PrecVtaTotalD", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowH("DOCV_PrecVtaTotalD")
                    .Add(New SqlParameter("@pdecDOCV_ValorTotal", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowH("DOCV_ValorTotal")
                    .Add(New SqlParameter("@pdecDOCV_ValorTotalD", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowH("DOCV_ValorTotalD")
                    .Add(New SqlParameter("@pdecDOCV_ValorVtaTotal", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowH("DOCV_ValorVtaTotal")
                    .Add(New SqlParameter("@pdecDOCV_ValorVtaTotalD", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowH("DOCV_ValorVtaTotalD")
                    .Add(New SqlParameter("@pdecDOCV_Descuento", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowH("DOCV_Descuento")
                    .Add(New SqlParameter("@pdecDOCV_DescuentoD", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowH("DOCV_DescuentoD")


                    .Add("@pvchDOCV_Observaciones", SqlDbType.VarChar, 1024).Value = oRowH("DOCV_Observaciones")


                    .Add(New SqlParameter("@pdecDOCV_Impuesto1", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowH("DOCV_Impuesto1")
                    .Add(New SqlParameter("@pdecDOCV_Impuesto1D", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowH("DOCV_Impuesto1D")
                    .Add(New SqlParameter("@pdecDOCV_Impuesto2", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowH("DOCV_Impuesto2")
                    .Add(New SqlParameter("@pdecDOCV_Impuesto2D", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowH("DOCV_Impuesto2D")
                    .Add(New SqlParameter("@pdecDOCV_Impuesto3", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowH("DOCV_Impuesto3")
                    .Add(New SqlParameter("@pdecDOCV_Impuesto3D", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowH("DOCV_Impuesto3D")
                    .Add(New SqlParameter("@pdecDOCV_Impuesto4", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowH("DOCV_Impuesto4")
                    .Add(New SqlParameter("@pdecDOCV_Impuesto4D", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowH("DOCV_Impuesto4D")
                    .Add(New SqlParameter("@pdecDOCV_PorcImp1", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowH("DOCV_PorcImp1")
                    .Add(New SqlParameter("@pdecDOCV_PorcImp2", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowH("DOCV_PorcImp2")
                    .Add(New SqlParameter("@pdecDOCV_PorcImp3", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowH("DOCV_PorcImp3")
                    .Add(New SqlParameter("@pdecDOCV_PorcImp4", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowH("DOCV_PorcImp4")





                    .Add("@pvchDOCV_Notas", SqlDbType.VarChar, 1000).Value = oRowH("DOCV_Notas")
                    .Add("@pvchDOCV_Serie", SqlDbType.VarChar, 10).Value = oRowH("DOCV_Serie")




                    .Add("@pchrTIPO_TabFPG", SqlDbType.Char, 3).Value = oRowH("TIPO_TabFPG")
                    .Add("@pchrTIPO_CodFPG", SqlDbType.Char, 3).Value = oRowH("TIPO_CodFPG")
                    .Add("@pchrTIPO_TabTDO", SqlDbType.Char, 3).Value = oRowH("TIPO_TabTDO")
                    .Add("@pchrTIPO_CodTDO", SqlDbType.Char, 3).Value = oRowH("TIPO_CodTDO")
                    .Add("@pchrTIPO_TabMND", SqlDbType.Char, 3).Value = oRowH("TIPO_TabMND")
                    .Add("@pchrTIPO_CodMND", SqlDbType.Char, 3).Value = oRowH("TIPO_CodMND")
                    .Add("@pchrCONS_CodANU", SqlDbType.Char, 3).Value = oRowH("CONS_CodANU")
                    .Add("@pchrCONS_TabANU", SqlDbType.Char, 3).Value = oRowH("CONS_TabANU")


                    .Add("@pvchAUDI_UsrCrea", SqlDbType.VarChar, 20).Value = oRowH("AUDI_UsrCrea")
                    .Add("@pintENTC_Codigo", SqlDbType.Int).Value = oRowH("ENTC_Codigo")
                    .Add("@psinTIPE_Codigo", SqlDbType.SmallInt).Value = oRowH("TIPE_Codigo")
                    .Add("@pvchDOCV_HBL", SqlDbType.VarChar, 30).Value = oRowH("DOCV_HBL")
                    .Add("@pvchCOPE_NumDoc", SqlDbType.VarChar, 30).Value = oRowH("DOCV_NroOperacion")

                End With
                _DOCV_Codigo = Command.ExecuteScalar
                aResult(1) = _DOCV_Codigo
                'aResult(2) = oRowH("COPE_NumDoc")
                'Servicios
                For r = 0 To dtDetail.Rows.Count - 1
                    Dim oRowD As DataRow = dtDetail.Rows(r)
                    Command.CommandType = CommandType.StoredProcedure
                    Command.CommandText = "NextSoft.dgp.VEN_DDOVSI_UnReg"
                    With Command.Parameters
                        .Clear()
                        .Add("@pintCOPE_Codigo", SqlDbType.Int).Value = oRowH("COPE_Codigo")
                        .Add("@pintDOCV_Codigo", SqlDbType.Int).Value = _DOCV_Codigo
                        .Add("@psinDDOV_Item", SqlDbType.SmallInt).Value = oRowD("DDOV_Item")


                        .Add(New SqlParameter("@pdecDDOV_Cantidad", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowD("DDOV_Cantidad")
                        .Add(New SqlParameter("@pdecDDOV_PrecioUnitario", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowD("DDOV_PrecioUnitario")
                        .Add(New SqlParameter("@pdecDDOV_PrecioUnitarioD", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowD("DDOV_PrecioUnitarioD")
                        .Add(New SqlParameter("@pdecDDOV_ValorVenta", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowD("DDOV_ValorVenta")
                        .Add(New SqlParameter("@pdecDDOV_ValorVentaD", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowD("DDOV_ValorVentaD")
                        .Add(New SqlParameter("@pdecDDOV_Impuesto1", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowD("DDOV_Impuesto1")
                        .Add(New SqlParameter("@pdecDDOV_Impuesto1D", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowD("DDOV_Impuesto1D")
                        .Add(New SqlParameter("@pdecDDOV_Impuesto2", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowD("DDOV_Impuesto2")
                        .Add(New SqlParameter("@pdecDDOV_Impuesto2D", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowD("DDOV_Impuesto2D")
                        .Add(New SqlParameter("@pdecDDOV_Impuesto3", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowD("DDOV_Impuesto3")
                        .Add(New SqlParameter("@pdecDDOV_Impuesto3D", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowD("DDOV_Impuesto3D")
                        .Add(New SqlParameter("@pdecDDOV_Impuesto4", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowD("DDOV_Impuesto4")
                        .Add(New SqlParameter("@pdecDDOV_Impuesto4D", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowD("DDOV_Impuesto4D")





                        .Add("@pvchDDOV_Notas", SqlDbType.VarChar, 1000).Value = oRowD("DDOV_Notas")
                        .Add("@pintSERV_Codigo", SqlDbType.Int).Value = oRowD("SERV_Codigo")
                        .Add("@pvchDDOV_Descripcion", SqlDbType.VarChar, 100).Value = oRowD("DDOV_Descripcion")
                        .Add("@pvchAUDI_UsrCrea", SqlDbType.VarChar, 20).Value = oRowD("AUDI_UsrCrea")

                        .Add(New SqlParameter("@pdecDDOV_ValorTotal", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowD("DDOV_ValorTotal")
                        .Add(New SqlParameter("@pdecDDOV_ValorTotalD", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowD("DDOV_ValorTotalD")
                        .Add("@DOPE_Item_List", SqlDbType.VarChar, 100).Value = oRowD("ItemList")

                    End With
                    Command.ExecuteNonQuery()
                Next

                transaction.Commit()
            Catch ex As Exception
                aResult(0) = 0
                aResult(1) = ex.Message
                transaction.Rollback()
            Finally
                connection.Close()
            End Try
            Return aResult
        End Using
        Return aResult



    End Function



    Public Function ImprimirDocumento()




    End Function




End Class

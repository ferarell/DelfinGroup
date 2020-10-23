﻿' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "DelfinService" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione DelfinService.svc o DelfinService.svc.vb en el Explorador de soluciones e inicie la depuración.
Imports System.DirectoryServices
Imports System.Data
Imports System.Data.SqlClient
Imports System.Net
Imports Application.BusinessLogic
Imports Application.BusinessEntities

Public Class DelfinService
    Implements IDelfinService

    Public Function ExecuteSQL(ByVal QueryString As String) As DataSet Implements IDelfinService.ExecuteSQL
        Try
            Dim oDataAccess As New DataAccess
            Return oDataAccess.ExecuteSQL(QueryString)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function NewExecuteSQL(ByVal QueryString As String) As DataSet Implements IDelfinService.NewExecuteSQL
        Dim dsResult As New DataSet
        Dim oDataAccess As New DataAccess
        dsResult = oDataAccess.NewExecuteSQL(QueryString)
        Return dsResult
    End Function

    Public Function ExecuteSQLNonQuery(ByVal QueryString As String) As Boolean Implements IDelfinService.ExecuteSQLNonQuery
        Dim bResult As Boolean = True
        Try
            Dim oDataAccess As New DataAccess
            Return oDataAccess.ExecuteSQLNonQuery(QueryString)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function NewExecuteSQLNonQuery(ByVal QueryString As String) As ArrayList Implements IDelfinService.NewExecuteSQLNonQuery
        Dim aResult As New ArrayList
        aResult.AddRange({True, ""})
        Try
            Dim oDataAccess As New DataAccess
            aResult(0) = oDataAccess.ExecuteSQLNonQuery(QueryString)
        Catch ex As Exception
            aResult(1) = ex.Message
        End Try
        Return aResult
    End Function

    Public Function GetActiveDirectoryObjects(ByVal DirectoryEntry As String, ByVal DirectoryUserName As String) As DataSet Implements IDelfinService.GetActiveDirectoryObjects
        Try
            Dim Entry As New DirectoryEntry(DirectoryEntry)
            Dim Searcher As New DirectorySearcher(Entry)
            Dim QueryResults As SearchResultCollection
            Dim SrchResult As SearchResult

            Dim myDataSet As New DataSet
            Dim myTable As New DataTable("DirectoryObjects")
            Dim colName As String

            Searcher.PropertiesToLoad.AddRange(New String() {"cn", "mail", "wwwHomePage"})
            Searcher.ServerTimeLimit = New TimeSpan(0, 0, 3)
            Searcher.Filter = "(&(objectCategory=person)(userPrincipalName=" + DirectoryUserName + "*))"
            QueryResults = Searcher.FindAll()

            For Each colName In Searcher.PropertiesToLoad
                myTable.Columns.Add(colName, GetType(System.String))
            Next

            For Each SrchResult In QueryResults
                Dim dr As DataRow = myTable.NewRow()
                For Each colName In Searcher.PropertiesToLoad
                    If SrchResult.Properties.Contains(colName) Then
                        dr(colName) = CStr(SrchResult.Properties(colName)(0))
                    Else
                        dr(colName) = ""
                    End If
                Next
                myTable.Rows.Add(dr)
            Next
            Entry.Dispose()
            myDataSet.Tables.Add(myTable)
            Return myDataSet
        Catch ex As Exception
            Throw (ex)
        End Try

    End Function

    Public Function UserValidation(ByVal DirectoryEntry As String, ByVal DirectoryUserName As String, ByVal DirectoryPassword As String, ByVal ErrorMessage As String) As String Implements IDelfinService.UserValidation
        Dim Result As String = ""
        Dim Entry As New DirectoryEntry(DirectoryEntry)
        If DirectoryUserName = "" Then
            Result = ErrorMessage
        End If
        Try
            Entry.Username = DirectoryUserName
            Entry.Password = DirectoryPassword
            Entry.Parent.AuthenticationType = AuthenticationTypes.Secure
            Entry.Dispose()
        Catch e As Exception
            Result = ErrorMessage
        End Try
        Return Result
    End Function

    Public Function GenerateNextSisVoucher(ByVal Company As String, ByVal dsVoucher As DataSet) As ArrayList Implements IDelfinService.GenerateNextSisVoucher
        Dim aResult As New ArrayList
        Dim dtHeader As DataTable = dsVoucher.Tables("VoucherH")
        Dim dtDetail As DataTable = dsVoucher.Tables("VoucherD")
        Dim sNroVoucher As String = ""
        aResult.AddRange({1, ""})
        Using connection As New SqlConnection(ConfigurationManager.AppSettings("dbSolution"))
            connection.Open()
            Dim Command As New SqlCommand
            Dim transaction As SqlTransaction
            transaction = connection.BeginTransaction("VoucherNextSis")
            Command.Connection = connection
            Command.Transaction = transaction
            Try
                'Cabecera
                Command.CommandType = CommandType.StoredProcedure
                Command.CommandText = "Integrador.dbo.paInsertaCabeceraAsientoNextSis"
                Dim hRow As DataRow = dtHeader.Rows(0)
                Command.Parameters.Clear()
                Command.Parameters.Add("@EMPRESA", SqlDbType.VarChar, 2).Value = Company
                Command.Parameters.Add("@SUCR_CODIGO", SqlDbType.VarChar, 2).Value = hRow("SUCR_CODIGO")
                Command.Parameters.Add("@CABA_MES", SqlDbType.VarChar, 2).Value = hRow("CABA_MES")
                Command.Parameters.Add("@TIPO_TABREG", SqlDbType.VarChar, 3).Value = hRow("TIPO_TABREG")
                Command.Parameters.Add("@CABA_ANO", SqlDbType.VarChar, 4).Value = hRow("CABA_ANO")
                Command.Parameters.Add("@TIPO_TIPREG", SqlDbType.VarChar, 3).Value = hRow("TIPO_TIPREG")
                Command.Parameters.Add("@CABA_NROVOUCHER", SqlDbType.VarChar, 6).Value = hRow("CABA_NROVOUCHER")
                Command.Parameters.Add("@CABA_GLOSA", SqlDbType.VarChar, 100).Value = hRow("CABA_GLOSA")
                Command.Parameters.Add("@CABA_MONEDA", SqlDbType.Bit).Value = hRow("CABA_MONEDA")
                Command.Parameters.Add("@CABA_TIPOASIENTO", SqlDbType.VarChar, 1).Value = hRow("CABA_TIPOASIENTO")
                Command.Parameters.Add("@CABA_USRCREA", SqlDbType.VarChar, 20).Value = hRow("CABA_USRCREA")
                Command.Parameters.Add("@CABA_FECCREA", SqlDbType.DateTime).Value = hRow("CABA_FECCREA")
                Command.Parameters.Add("@CABA_USRMOD", SqlDbType.VarChar, 20).Value = hRow("CABA_USRMOD")
                Command.Parameters.Add("@CABA_FECMOD", SqlDbType.DateTime).Value = hRow("CABA_FECMOD")
                Command.Parameters.Add("@TIPO_TIPTRE", SqlDbType.VarChar, 3).Value = hRow("TIPO_TIPTRE")
                Command.Parameters.Add("@TIPO_TABTRE", SqlDbType.VarChar, 3).Value = hRow("TIPO_TABTRE")
                Command.Parameters.Add("@TIPO_TIPREGREF", SqlDbType.VarChar, 3).Value = hRow("TIPO_TIPREGREF")
                Command.Parameters.Add("@TIPO_TABREGREF", SqlDbType.VarChar, 3).Value = hRow("TIPO_TABREGREF")
                Command.Parameters.Add("@CABA_ANOREF", SqlDbType.VarChar, 4).Value = hRow("CABA_ANOREF")
                Command.Parameters.Add("@CABA_MESREF", SqlDbType.VarChar, 2).Value = hRow("CABA_MESREF")
                Command.Parameters.Add("@CABA_NROVOUCHERREF", SqlDbType.VarChar, 6).Value = hRow("CABA_NROVOUCHERREF")
                sNroVoucher = Command.ExecuteScalar
                aResult(1) = sNroVoucher
                'Detalle
                For r = 0 To dtDetail.Rows.Count - 1
                    Dim dRow As DataRow = dtDetail.Rows(r)
                    Command.CommandType = CommandType.StoredProcedure
                    Command.CommandText = "Integrador.dbo.paInsertaDetalleAsientoNextSis"
                    Command.Parameters.Clear()
                    Command.Parameters.Add("@EMPRESA", SqlDbType.VarChar, 2).Value = Company
                    Command.Parameters.Add("@CABA_ANO", SqlDbType.VarChar, 4).Value = dRow("CABA_ANO")
                    Command.Parameters.Add("@DETA_ELEMENTO", SqlDbType.Int).Value = r + 1
                    Command.Parameters.Add("@SUCR_CODIGO", SqlDbType.VarChar, 2).Value = dRow("SUCR_CODIGO")
                    Command.Parameters.Add("@DETA_GLOSA", SqlDbType.VarChar, 100).Value = dRow("DETA_GLOSA")
                    Command.Parameters.Add("@CABA_MES", SqlDbType.VarChar, 2).Value = dRow("CABA_MES")
                    Command.Parameters.Add("@ENTC_CODIGO", SqlDbType.VarChar, 12).Value = dRow("ENTC_CODIGO")
                    Command.Parameters.Add("@TIPO_TIPOPE", SqlDbType.VarChar, 3).Value = dRow("TIPO_TIPOPE")
                    Command.Parameters.Add("@TIPO_TIPORIGEN", SqlDbType.VarChar, 3).Value = dRow("TIPO_TIPORIGEN")
                    Command.Parameters.Add("@CABA_NROVOUCHER", SqlDbType.VarChar, 6).Value = sNroVoucher
                    Command.Parameters.Add("@CENT_CODIGO", SqlDbType.VarChar, 17).Value = dRow("CENT_CODIGO")
                    Command.Parameters.Add("@TIPO_TABREG", SqlDbType.VarChar, 3).Value = dRow("TIPO_TABREG")
                    Command.Parameters.Add("@TIPO_TIPREG", SqlDbType.VarChar, 3).Value = dRow("TIPO_TIPREG")
                    Command.Parameters.Add("@DETA_FECDOCORIGEN", SqlDbType.DateTime).Value = dRow("DETA_FECDOCORIGEN")
                    Command.Parameters.Add("@DETA_SERIEDOCORIGEN", SqlDbType.VarChar, 20).Value = dRow("DETA_SERIEDOCORIGEN")
                    Command.Parameters.Add("@DETA_NRODOCORIGEN", SqlDbType.VarChar, 20).Value = dRow("DETA_NRODOCORIGEN")
                    Command.Parameters.Add("@CUEN_CODIGO", SqlDbType.VarChar, 17).Value = dRow("CUEN_CODIGO")
                    Command.Parameters.Add("@DETA_DEBE", SqlDbType.Decimal, 12, 2).Value = dRow("DETA_DEBE")
                    Command.Parameters.Add("@DETA_HABER", SqlDbType.Decimal, 12, 2).Value = dRow("DETA_HABER")
                    Command.Parameters.Add("@DETA_DEBEDOL", SqlDbType.Decimal, 12, 2).Value = dRow("DETA_DEBEDOL")
                    Command.Parameters.Add("@TIPO_TABOPE", SqlDbType.VarChar, 3).Value = dRow("TIPO_TABOPE")
                    Command.Parameters.Add("@TIPO_TABORIGEN", SqlDbType.VarChar, 3).Value = dRow("TIPO_TABORIGEN")
                    Command.Parameters.Add("@DETA_HABERDOL", SqlDbType.Decimal, 12, 2).Value = dRow("DETA_HABERDOL")
                    Command.Parameters.Add("@DETA_REFERENCIA", SqlDbType.VarChar, 50).Value = dRow("DETA_REFERENCIA")
                    Command.Parameters.Add("@DETA_AMARRE", SqlDbType.Bit).Value = dRow("DETA_AMARRE")
                    Command.Parameters.Add("@DETA_PORCAMARRE", SqlDbType.Decimal).Value = dRow("DETA_PORCAMARRE")
                    Command.Parameters.Add("@DETA_TIPOAMARRE", SqlDbType.Int).Value = dRow("DETA_TIPOAMARRE")
                    Command.Parameters.Add("@DETA_NUMAMARRE", SqlDbType.Int).Value = dRow("DETA_NUMAMARRE")
                    Command.Parameters.Add("@DETA_TCAMBIO", SqlDbType.Decimal).Value = dRow("DETA_TCAMBIO")
                    Command.Parameters.Add("@PPER_NUMERO", SqlDbType.Int).Value = dRow("PPER_NUMERO")
                    Command.Parameters.Add("@PART_CODIGO", SqlDbType.VarChar, 17).Value = dRow("PART_CODIGO")
                    Command.Parameters.Add("@TIGA_CODIGO", SqlDbType.VarChar, 17).Value = dRow("TIGA_CODIGO")
                    Command.Parameters.Add("@DETA_FECRETENCION", SqlDbType.DateTime).Value = dRow("DETA_FECRETENCION")
                    Command.Parameters.Add("@DETA_NRORETENCION", SqlDbType.VarChar, 20).Value = dRow("DETA_NRORETENCION")
                    Command.Parameters.Add("@DETA_FECVCTO", SqlDbType.DateTime).Value = dRow("DETA_FECVCTO")
                    Command.Parameters.Add("@TIPO_DOCREFERENCIA", SqlDbType.VarChar, 3).Value = dRow("TIPO_DOCREFERENCIA")
                    Command.Parameters.Add("@TIPO_TABUBICACIONES", SqlDbType.VarChar, 3).Value = dRow("TIPO_TABUBICACIONES")
                    Command.Parameters.Add("@TIPO_CODUBICACIONES", SqlDbType.VarChar, 3).Value = dRow("TIPO_CODUBICACIONES")
                    Command.Parameters.Add("@DETA_MEDIOPAGO", SqlDbType.VarChar, 30).Value = dRow("DETA_MEDIOPAGO")
                    Command.Parameters.Add("@DETA_ANEXO", SqlDbType.VarChar, 30).Value = dRow("DETA_ANEXO")
                    Command.Parameters.Add("@DETA_SERIEREFERENCIA", SqlDbType.VarChar, 20).Value = dRow("DETA_SERIEREFERENCIA")
                    Command.Parameters.Add("@DETA_MONEDA", SqlDbType.Bit).Value = dRow("DETA_MONEDA")
                    Command.Parameters.Add("@DETA_OBSERVACION", SqlDbType.VarChar, 100).Value = dRow("DETA_OBSERVACION")
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

    Public Function GenerateNextSisVoucherBCopy(ByVal Company As String, ByVal dsVoucher As DataSet) As ArrayList Implements IDelfinService.GenerateNextSisVoucherBCopy
        Dim aResult As New ArrayList
        Dim dtHeader As DataTable = dsVoucher.Tables("VoucherH")
        Dim dtDetail As DataTable = dsVoucher.Tables("VoucherD")
        Dim sNroVoucher As String = ""
        aResult.AddRange({1, ""})
        Using connection As New SqlConnection(ConfigurationManager.AppSettings("dbSolution"))
            connection.Open()
            Dim Command As New SqlCommand
            Dim transaction As SqlTransaction
            transaction = connection.BeginTransaction("VoucherNextSis")
            Command.Connection = connection
            Command.Transaction = transaction
            Try
                'Cabecera
                Command.CommandType = CommandType.StoredProcedure
                Command.CommandText = "Integrador.dbo.paInsertaCabeceraAsientoNextSis"
                Dim hRow As DataRow = dtHeader.Rows(0)
                Command.Parameters.Clear()
                Command.Parameters.Add("@EMPRESA", SqlDbType.VarChar, 2).Value = Company
                Command.Parameters.Add("@SUCR_CODIGO", SqlDbType.VarChar, 2).Value = hRow("SUCR_CODIGO")
                Command.Parameters.Add("@CABA_MES", SqlDbType.VarChar, 2).Value = hRow("CABA_MES")
                Command.Parameters.Add("@TIPO_TABREG", SqlDbType.VarChar, 3).Value = hRow("TIPO_TABREG")
                Command.Parameters.Add("@CABA_ANO", SqlDbType.VarChar, 4).Value = hRow("CABA_ANO")
                Command.Parameters.Add("@TIPO_TIPREG", SqlDbType.VarChar, 3).Value = hRow("TIPO_TIPREG")
                Command.Parameters.Add("@CABA_NROVOUCHER", SqlDbType.VarChar, 6).Value = hRow("CABA_NROVOUCHER")
                Command.Parameters.Add("@CABA_GLOSA", SqlDbType.VarChar, 100).Value = hRow("CABA_GLOSA")
                Command.Parameters.Add("@CABA_MONEDA", SqlDbType.Bit).Value = hRow("CABA_MONEDA")
                Command.Parameters.Add("@CABA_TIPOASIENTO", SqlDbType.VarChar, 1).Value = hRow("CABA_TIPOASIENTO")
                Command.Parameters.Add("@CABA_USRCREA", SqlDbType.VarChar, 20).Value = hRow("CABA_USRCREA")
                Command.Parameters.Add("@CABA_FECCREA", SqlDbType.DateTime).Value = hRow("CABA_FECCREA")
                Command.Parameters.Add("@CABA_USRMOD", SqlDbType.VarChar, 20).Value = hRow("CABA_USRMOD")
                Command.Parameters.Add("@CABA_FECMOD", SqlDbType.DateTime).Value = hRow("CABA_FECMOD")
                Command.Parameters.Add("@TIPO_TIPTRE", SqlDbType.VarChar, 3).Value = hRow("TIPO_TIPTRE")
                Command.Parameters.Add("@TIPO_TABTRE", SqlDbType.VarChar, 3).Value = hRow("TIPO_TABTRE")
                Command.Parameters.Add("@TIPO_TIPREGREF", SqlDbType.VarChar, 3).Value = hRow("TIPO_TIPREGREF")
                Command.Parameters.Add("@TIPO_TABREGREF", SqlDbType.VarChar, 3).Value = hRow("TIPO_TABREGREF")
                Command.Parameters.Add("@CABA_ANOREF", SqlDbType.VarChar, 4).Value = hRow("CABA_ANOREF")
                Command.Parameters.Add("@CABA_MESREF", SqlDbType.VarChar, 2).Value = hRow("CABA_MESREF")
                Command.Parameters.Add("@CABA_NROVOUCHERREF", SqlDbType.VarChar, 6).Value = hRow("CABA_NROVOUCHERREF")
                sNroVoucher = Command.ExecuteScalar
                aResult(1) = sNroVoucher
                'Detalle
                For Each row As DataRow In dtDetail.Rows
                    row("CABA_NROVOUCHER") = sNroVoucher
                Next
                Dim Bulk As New SqlBulkCopy(connection, SqlBulkCopyOptions.Default, transaction)
                Bulk.DestinationTableName = "NextSis" & Company & "..CON_DetAsientos"
                For Each col As DataColumn In dtDetail.Columns
                    Bulk.ColumnMappings.Add(col.ColumnName, col.ColumnName)
                Next
                Bulk.WriteToServer(dtDetail)
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

    Public Function GenerateNextSoftVoucher(dtMovimiento As DataTable, dtCtaCte As DataTable) As ArrayList Implements IDelfinService.GenerateNextSoftVoucher
        Dim aResult As New ArrayList
        Dim drMovimiento As DataRow = dtMovimiento.Rows(0)
        Dim drCtaCte As DataRow = dtCtaCte.Rows(0)
        Dim iEMPR_Codigo, iMOVI_Codigo As Integer
        aResult.AddRange({1, "", ""})
        Using connection As New SqlConnection(ConfigurationManager.AppSettings("dbSolution"))
            connection.Open()
            Dim Command As New SqlCommand
            Dim transaction As SqlTransaction
            transaction = connection.BeginTransaction("VoucherNextSoft")
            Command.Connection = connection
            Command.Transaction = transaction
            Try
                'Movimiento
                Command.CommandType = CommandType.StoredProcedure
                Command.CommandText = "NextSoft.dbo.CAJ_MOVISI_UnReg"
                Command.Parameters.Clear()
                Command.Parameters.Add("@psinEMPR_Codigo", SqlDbType.SmallInt, 2).Direction = ParameterDirection.InputOutput
                Command.Parameters("@psinEMPR_Codigo").Value = drMovimiento("EMPR_Codigo")
                Command.Parameters.Add("@pintMOVI_Codigo", SqlDbType.Int, 4).Direction = ParameterDirection.InputOutput
                Command.Parameters("@pintMOVI_Codigo").Value = drMovimiento("MOVI_Codigo")
                Command.Parameters.Add("@pintMOVI_CodPadre", SqlDbType.Int, 4, ParameterDirection.Input).Value = drMovimiento("MOVI_CodPadre")
                Command.Parameters.Add("@psinSUCR_Codigo", SqlDbType.SmallInt, 2, ParameterDirection.Input).Value = drMovimiento("SUCR_Codigo")
                Command.Parameters.Add("@pchrCUBA_Codigo", SqlDbType.Char, 3, ParameterDirection.Input).Value = drMovimiento("CUBA_Codigo")
                Command.Parameters.Add("@pchrPLAN_Tipo", SqlDbType.Char, 3, ParameterDirection.Input).Value = drMovimiento("PLAN_Tipo")
                Command.Parameters.Add("@pvchPLAN_Codigo", SqlDbType.VarChar, 20, ParameterDirection.Input).Value = drMovimiento("PLAN_Codigo")
                Command.Parameters.Add("@pintTRAN_Codigo", SqlDbType.Int, 4, ParameterDirection.Input).Value = drMovimiento("TRAN_Codigo")
                Command.Parameters.Add("@psinTIPE_Codigo", SqlDbType.SmallInt, 2, ParameterDirection.Input).Value = drMovimiento("TIPE_Codigo")
                Command.Parameters.Add("@pintENTC_Codigo", SqlDbType.Int, 4, ParameterDirection.Input).Value = drMovimiento("ENTC_Codigo")
                Command.Parameters.Add("@pchrTIPO_TabMOV", SqlDbType.Char, 3, ParameterDirection.Input).Value = drMovimiento("TIPO_TabMOV")
                Command.Parameters.Add("@pchrTIPO_CodMOV", SqlDbType.Char, 3, ParameterDirection.Input).Value = drMovimiento("TIPO_CodMOV")
                Command.Parameters.Add("@pchrCONS_TabEST", SqlDbType.Char, 3, ParameterDirection.Input).Value = drMovimiento("CONS_TabEST")
                Command.Parameters.Add("@pchrCONS_CodEST", SqlDbType.Char, 3, ParameterDirection.Input).Value = drMovimiento("CONS_CodEST")
                Command.Parameters.Add("@pchrTIPO_TabDES", SqlDbType.Char, 3, ParameterDirection.Input).Value = drMovimiento("TIPO_TabDES")
                Command.Parameters.Add("@pchrTIPO_CodDES", SqlDbType.Char, 3, ParameterDirection.Input).Value = drMovimiento("TIPO_CodDES")
                Command.Parameters.Add("@pchrTIPO_TabSerie", SqlDbType.Char, 3, ParameterDirection.Input).Value = drMovimiento("TIPO_TabSerie")
                Command.Parameters.Add("@pchrTIPO_CodSerie", SqlDbType.Char, 3, ParameterDirection.Input).Value = drMovimiento("TIPO_CodSerie")
                Command.Parameters.Add("@pintMOVI_DocNumero", SqlDbType.Int, 4, ParameterDirection.Input).Value = drMovimiento("MOVI_DocNumero")
                Command.Parameters.Add("@pvchMOVI_AsientoContable", SqlDbType.VarChar, 50, ParameterDirection.Input).Value = drMovimiento("MOVI_AsientoContable")
                Command.Parameters.Add("@pvchMOVI_Numero", SqlDbType.VarChar, 15, ParameterDirection.Input).Value = drMovimiento("MOVI_Numero")
                Command.Parameters.Add("@pdtmMOVI_FecEmision", SqlDbType.DateTime, 8, ParameterDirection.Input).Value = drMovimiento("MOVI_FecEmision")
                Command.Parameters.Add("@pvchMOVI_Concepto", SqlDbType.VarChar, 100, ParameterDirection.Input).Value = drMovimiento("MOVI_Concepto")
                Command.Parameters.Add("@pvchMOVI_OrdenDe", SqlDbType.VarChar, 100, ParameterDirection.Input).Value = drMovimiento("MOVI_OrdenDe")
                Command.Parameters.Add("@pdecMOVI_MontoDebe", SqlDbType.Decimal, ParameterDirection.Input).Value = drMovimiento("MOVI_MontoDebe")
                Command.Parameters.Add("@pdecMOVI_TipoCambio", SqlDbType.Decimal, ParameterDirection.Input).Value = drMovimiento("MOVI_TipoCambio")
                Command.Parameters.Add("@pdecMOVI_MontoHaber", SqlDbType.Decimal, ParameterDirection.Input).Value = drMovimiento("MOVI_MontoHaber")
                Command.Parameters.Add("@pvchMOVI_Agrupacion", SqlDbType.VarChar, 20, ParameterDirection.Input).Value = drMovimiento("MOVI_Agrupacion")
                Command.Parameters.Add("@pbitMOVI_Cheque", SqlDbType.Bit, 1, ParameterDirection.Input).Value = drMovimiento("MOVI_Cheque")
                Command.Parameters.Add("@pchrMOVI_EstadoCheque", SqlDbType.Char, 1, ParameterDirection.Input).Value = drMovimiento("MOVI_EstadoCheque")
                Command.Parameters.Add("@pvchMOVI_UserEntregaCheque", SqlDbType.VarChar, 20, ParameterDirection.Input).Value = drMovimiento("MOVI_UserEntregaCheque")
                Command.Parameters.Add("@pdtmMOVI_FecEntregaCheque", SqlDbType.DateTime, 8, ParameterDirection.Input).Value = drMovimiento("MOVI_FecEntregaCheque")
                Command.Parameters.Add("@pdtmMOVI_FecDiferido", SqlDbType.DateTime, 8, ParameterDirection.Input).Value = drMovimiento("MOVI_FecDiferido")
                Command.Parameters.Add("@pdtmMOVI_FecDiferidoAnterior", SqlDbType.DateTime, 8, ParameterDirection.Input).Value = drMovimiento("MOVI_FecDiferidoAnterior")
                Command.Parameters.Add("@pbitMOVI_ChequeImpreso", SqlDbType.Bit, 1, ParameterDirection.Input).Value = drMovimiento("MOVI_ChequeImpreso")
                Command.Parameters.Add("@pvchMOVI_UserAnulacion", SqlDbType.VarChar, 20, ParameterDirection.Input).Value = drMovimiento("MOVI_UserAnulacion")
                Command.Parameters.Add("@pdtmMOVI_FecAnulacion", SqlDbType.DateTime, 8, ParameterDirection.Input).Value = drMovimiento("MOVI_FecAnulacion")
                Command.Parameters.Add("@pvchMOVI_GlosaAnulacion", SqlDbType.VarChar, 100, ParameterDirection.Input).Value = drMovimiento("MOVI_GlosaAnulacion")
                Command.Parameters.Add("@pvchMOVI_NroOperacion", SqlDbType.VarChar, 20, ParameterDirection.Input).Value = drMovimiento("MOVI_NroOperacion")
                Command.Parameters.Add("@pvchMOVI_NroOficina", SqlDbType.VarChar, 20, ParameterDirection.Input).Value = drMovimiento("MOVI_NroOficina")
                Command.Parameters.Add("@pvchMOVI_Referencia", SqlDbType.VarChar, 100, ParameterDirection.Input).Value = drMovimiento("MOVI_Referencia")
                Command.Parameters.Add("@pdtmMOVI_FecVigencia", SqlDbType.DateTime, 8, ParameterDirection.Input).Value = drMovimiento("MOVI_FecVigencia")
                Command.Parameters.Add("@pvchMOVI_Responsable", SqlDbType.VarChar, 50, ParameterDirection.Input).Value = drMovimiento("MOVI_Responsable")
                Command.Parameters.Add("@pdecMOVI_MontoLimite", SqlDbType.Decimal, ParameterDirection.Input).Value = drMovimiento("MOVI_MontoLimite")
                Command.Parameters.Add("@pdecMOVI_MontoDescuadre", SqlDbType.Decimal, ParameterDirection.Input).Value = drMovimiento("MOVI_MontoDescuadre")
                Command.Parameters.Add("@pdtmMOVI_FecEjecutado", SqlDbType.DateTime, 8, ParameterDirection.Input).Value = drMovimiento("MOVI_FecEjecutado")
                Command.Parameters.Add("@pbitMOVI_NoNegociable", SqlDbType.Bit, 1, ParameterDirection.Input).Value = drMovimiento("MOVI_NoNegociable")
                Command.Parameters.Add("@pdtmMOVI_FecOperacion", SqlDbType.DateTime, 8, ParameterDirection.Input).Value = drMovimiento("MOVI_FecOperacion")
                Command.Parameters.Add("@pchrTIPO_TabMDP", SqlDbType.Char, 3, ParameterDirection.Input).Value = drMovimiento("TIPO_TabMDP")
                Command.Parameters.Add("@pchrTIPO_CodMDP", SqlDbType.Char, 3, ParameterDirection.Input).Value = drMovimiento("TIPO_CodMDP")
                Command.Parameters.Add("@pvchAUDI_UsrCrea", SqlDbType.VarChar, 20, ParameterDirection.Input).Value = drMovimiento("AUDI_UsrCrea")
                If Command.ExecuteNonQuery() <= 0 Then
                    aResult(0) = 0
                    aResult(1) = "Error al ejecutar el procedimiento almacenado NextSoft.dbo.CAJ_MOVISI_UnReg"
                    transaction.Rollback()
                    Return aResult
                End If
                iEMPR_Codigo = Command.Parameters(0).Value
                iMOVI_Codigo = Command.Parameters(1).Value
                'Cuenta Corriente
                Command.CommandType = CommandType.StoredProcedure
                Command.CommandText = "NextSoft.dbo.CAJ_DCCTSI_UnReg"
                Command.Parameters.Clear()
                Command.Parameters.Add("@psinEMPR_Codigo", SqlDbType.SmallInt, 2).Value = iEMPR_Codigo
                Command.Parameters.Add("@pintCCCT_Codigo", SqlDbType.Int, 4).Value = drCtaCte("CCCT_Codigo")
                Command.Parameters.Add("@psinDCCT_Item", SqlDbType.SmallInt, 2).Value = drCtaCte("DCCT_Item")
                Command.Parameters.Add("@pintMOVI_Codigo", SqlDbType.Int, 4).Value = iMOVI_Codigo
                Command.Parameters.Add("@pchrTIPO_TabMND", SqlDbType.Char, 3).Value = drCtaCte("TIPO_TabMND")
                Command.Parameters.Add("@pchrTIPO_CodMND", SqlDbType.Char, 3).Value = drCtaCte("TIPO_CodMND")
                Command.Parameters.Add("@pchrCONS_TabTDC", SqlDbType.Char, 3).Value = drCtaCte("CONS_TabTDC")
                Command.Parameters.Add("@pchrCONS_CodTDC", SqlDbType.Char, 3).Value = drCtaCte("CONS_CodTDC")
                Command.Parameters.Add("@pintCCCT_CodReferencia", SqlDbType.Int, 4).Value = drCtaCte("CCCT_CodReferencia")
                Command.Parameters.Add("@psinDCCT_ItemReferencia", SqlDbType.SmallInt, 2).Value = drCtaCte("DCCT_ItemReferencia")
                Command.Parameters.Add("@pchrDCCT_TipoPago", SqlDbType.Char, 1).Value = drCtaCte("DCCT_TipoPago")
                Command.Parameters.Add("@pdtmDCCT_FechaTrans", SqlDbType.DateTime, 8).Value = drCtaCte("DCCT_FechaTrans")
                Command.Parameters.Add("@pnumDCCT_TipoCambio", SqlDbType.Decimal, 10, 4).Value = drCtaCte("DCCT_TipoCambio")
                Command.Parameters.Add("@pdecDCCT_MontoDebe", SqlDbType.Decimal, 15, 2).Value = drCtaCte("DCCT_MontoDebe")
                Command.Parameters.Add("@pdecDCCT_MontoHaber", SqlDbType.Decimal, 15, 2).Value = drCtaCte("DCCT_MontoHaber")
                Command.Parameters.Add("@pdecDCCT_MontoDebeD", SqlDbType.Decimal, 15, 2).Value = drCtaCte("DCCT_MontoDebeD")
                Command.Parameters.Add("@pdecDCCT_MontoHaberD", SqlDbType.Decimal, 15, 2).Value = drCtaCte("DCCT_MontoHaberD")
                Command.Parameters.Add("@pdecDCCT_PPago", SqlDbType.Decimal, 15, 2).Value = drCtaCte("DCCT_PPago")
                Command.Parameters.Add("@pdecDCCT_PPagoD", SqlDbType.Decimal, 15, 2).Value = drCtaCte("DCCT_PPagoD")
                Command.Parameters.Add("@pbitDCCT_PagoDetraccion", SqlDbType.Bit, 1).Value = drCtaCte("DCCT_PagoDetraccion")
                Command.Parameters.Add("@pvchAUDI_UsrCrea", SqlDbType.VarChar, 20).Value = drCtaCte("AUDI_UsrCrea")
                If Command.ExecuteNonQuery() <= 0 Then
                    aResult(0) = 0
                    aResult(1) = "Error al ejecutar el procedimiento almacenado NextSoft.dbo.CAJ_DCCTSI_UnReg"
                    transaction.Rollback()
                    Return aResult
                End If
                'Asiento Contable
                Command.CommandType = CommandType.StoredProcedure
                Command.CommandText = "NextSoft.dbo.CAJ_MOVISI_GenerarAsientoCaja"
                Command.Parameters.Clear()
                Command.Parameters.Add("@EMPR_Codigo", SqlDbType.SmallInt, 2).Value = iEMPR_Codigo
                Command.Parameters.Add("@MOVI_Codigo", SqlDbType.Int, 4).Value = iMOVI_Codigo
                Command.Parameters.Add("@AUDI_Usuario", SqlDbType.VarChar, 20).Value = drMovimiento("AUDI_UsrCrea")
                If Command.ExecuteNonQuery() <= 0 Then
                    aResult(0) = 0
                    aResult(1) = "Error al ejecutar el procedimiento almacenado NextSoft.dbo.CAJ_MOVISI_GenerarAsientoCaja"
                    transaction.Rollback()
                    Return aResult
                End If
                Dim dtQuery As New DataTable
                'dtQuery = NewExecuteSQL("SELECT CABA_Ano + CABA_Mes + '-' + TIPO_CodREG + '-' + CABA_NroVoucher AS VoucherDG, CABA_Ano_DC + CABA_Mes_DC + '-' + TIPO_CodREG_DC + '-' + CABA_NroVoucher_DC AS VoucherDC FROM [NextSoft].[dbo].[CAJ_Movimiento](nolock) WHERE MOVI_Codigo=" & iMOVI_Codigo.ToString).Tables(0)
                dtQuery = NewExecuteSQL("SELECT CABA_Ano + CABA_Mes + '-' + TIPO_CodREG + '-' + CABA_NroVoucher AS VoucherDG FROM [NextSoft].[dbo].[CAJ_Movimiento](nolock) WHERE MOVI_Codigo=" & iMOVI_Codigo.ToString).Tables(0)
                transaction.Commit()
                aResult(0) = 1
                aResult(1) = dtQuery.Rows(0)("VoucherDG")
                'aResult(2) = dtQuery.Rows(0)("VoucherDC")
            Catch ex As Exception
                aResult(0) = 0
                aResult(1) = ex.Message
                transaction.Rollback()
            Finally
                connection.Close()
            End Try
        End Using
        Return aResult
    End Function

    Public Function InsertarContribuyente(ByVal dtSource As DataTable) As ArrayList Implements IDelfinService.InsertarContribuyente
        Dim aResult As New ArrayList
        aResult.AddRange({1, ""})
        Dim drSource As DataRow = dtSource.Rows(0)
        Using connection As New SqlConnection(ConfigurationManager.AppSettings("dbSolution"))
            connection.Open()
            Dim Command As New SqlCommand
            Dim transaction As SqlTransaction
            transaction = connection.BeginTransaction
            Command.Connection = connection
            Command.Transaction = transaction
            Try
                Command.CommandType = CommandType.StoredProcedure
                Command.CommandText = "Integrador.sun.paContribuyenteInsert"
                With Command.Parameters
                    .Clear()
                    .Add("@NroRUC", SqlDbType.VarChar, 20).Value = drSource(0)
                    .Add("@RazonSocial", SqlDbType.VarChar, 255).Value = drSource(1)
                    .Add("@BuenContribuyente", SqlDbType.Bit).Value = drSource(2)
                    .Add("@AgenteRetencion", SqlDbType.Bit).Value = drSource(3)
                    .Add("@NoHabido", SqlDbType.Bit).Value = drSource(4)
                    .Add("@AfiliadoSEE", SqlDbType.Bit).Value = drSource(5)
                    .Add("@AgentePercepcion", SqlDbType.Bit).Value = drSource(6)
                    .Add("@UserCreate", SqlDbType.NVarChar, 150).Value = drSource(7)
                    .Add("@DateCreate", SqlDbType.DateTime).Value = drSource(8)
                    .Add("@UserUpdate", SqlDbType.NVarChar, 150).Value = drSource(9)
                    .Add("@DateUpdate", SqlDbType.DateTime).Value = drSource(10)
                End With
                Command.CommandTimeout = 60000
                If Command.ExecuteNonQuery() <= 0 Then
                    transaction.Commit()
                    aResult(0) = 1
                Else
                    transaction.Rollback()
                End If
            Catch ex As Exception
                aResult(0) = 0
                aResult(1) = ex.Message
                transaction.Rollback()
            Finally
                Command.Connection.Close()
            End Try
            Return aResult
        End Using
    End Function

    Public Function ActualizarContribuyente(ByVal dtSource As DataTable) As ArrayList Implements IDelfinService.ActualizarContribuyente
        Dim aResult As New ArrayList
        aResult.AddRange({1, ""})
        Dim drSource As DataRow = dtSource.Rows(0)
        Using connection As New SqlConnection(ConfigurationManager.AppSettings("dbSolution"))
            connection.Open()
            Dim Command As New SqlCommand
            Dim transaction As SqlTransaction
            transaction = connection.BeginTransaction
            Command.Connection = connection
            Command.Transaction = transaction
            Try
                Command.CommandType = CommandType.StoredProcedure
                Command.CommandText = "Integrador.sun.paContribuyenteUpdate"
                With Command.Parameters
                    .Clear()
                    .Add("@NroRUC", SqlDbType.VarChar, 20).Value = drSource(0)
                    .Add("@RazonSocial", SqlDbType.VarChar, 255).Value = drSource(1)
                    .Add("@BuenContribuyente", SqlDbType.Bit).Value = drSource(2)
                    .Add("@AgenteRetencion", SqlDbType.Bit).Value = drSource(3)
                    .Add("@NoHabido", SqlDbType.Bit).Value = drSource(4)
                    .Add("@AfiliadoSEE", SqlDbType.Bit).Value = drSource(5)
                    .Add("@AgentePercepcion", SqlDbType.Bit).Value = drSource(6)
                    .Add("@UserCreate", SqlDbType.NVarChar, 150).Value = drSource(7)
                    .Add("@DateCreate", SqlDbType.DateTime).Value = drSource(8)
                    .Add("@UserUpdate", SqlDbType.NVarChar, 150).Value = drSource(9)
                    .Add("@DateUpdate", SqlDbType.DateTime).Value = drSource(10)
                End With
                Command.CommandTimeout = 60000
                If Command.ExecuteNonQuery() <= 0 Then
                    transaction.Commit()
                    aResult(0) = 1
                Else
                    transaction.Rollback()
                End If
            Catch ex As Exception
                aResult(0) = 0
                aResult(1) = ex.Message
                transaction.Rollback()
            Finally
                Command.Connection.Close()
            End Try
            Return aResult
        End Using
    End Function

    Public Function UpdateTableWithBulkCopy(ByVal Table As String, ByVal dtSource As DataTable, ByVal ProcessType As String) As ArrayList Implements IDelfinService.UpdateTableWithBulkCopy
        Dim aResult As New ArrayList
        Dim sNroVoucher As String = ""
        aResult.AddRange({1, ""})
        Using connection As New SqlConnection(ConfigurationManager.AppSettings("dbSolution"))
            connection.Open()
            Dim Command As New SqlCommand
            Dim transaction As SqlTransaction
            transaction = connection.BeginTransaction("UpdateTableWithBulkCopy")
            Command.Connection = connection
            Command.Transaction = transaction
            Try
                If ProcessType = "R" Then 'Replace All Data
                    Command.CommandText = "TRUNCATE TABLE " & Table
                    Command.ExecuteNonQuery()
                End If
                Dim Bulk As New SqlBulkCopy(connection, SqlBulkCopyOptions.Default, transaction)
                Bulk.DestinationTableName = Table
                For Each col As DataColumn In dtSource.Columns
                    Bulk.ColumnMappings.Add(col.ColumnName, col.ColumnName)
                Next
                Bulk.WriteToServer(dtSource)
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

    Public Function UpdatingUsingTableAsParameter(ByVal StoreProcedure As String, ByVal dtSource As DataTable) As ArrayList Implements IDelfinService.UpdatingUsingTableAsParameter
        Dim aResult As New ArrayList
        Dim sNroVoucher As String = ""
        aResult.AddRange({1, ""})
        Using connection As New SqlConnection(ConfigurationManager.AppSettings("dbSolution"))
            connection.Open()
            Dim Command As New SqlCommand
            Dim transaction As SqlTransaction
            transaction = connection.BeginTransaction("UpdatingUsingTableAsParameter")
            Command.Connection = connection
            Command.Transaction = transaction
            Try
                Command.CommandType = CommandType.StoredProcedure
                Command.CommandText = StoreProcedure
                With Command.Parameters
                    .Clear()
                    .AddWithValue("@TableVar", dtSource)
                End With
                Command.CommandTimeout = 60000
                If Command.ExecuteNonQuery() <= 0 Then
                    transaction.Commit()
                    aResult(0) = 1
                Else
                    transaction.Rollback()
                End If
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

    Public Function UpdatingWithTableAndParameters(ByVal StoreProcedure As String, ByVal dtSource As DataTable, ByVal Params As ArrayList, ByVal Values As ArrayList) As ArrayList Implements IDelfinService.UpdatingWithTableAndParameters
        Dim aResult As New ArrayList
        Dim iReturn As Integer
        aResult.AddRange({1, ""})
        Using connection As New SqlConnection(ConfigurationManager.AppSettings("dbSolution"))
            connection.Open()
            Dim Command As New SqlCommand
            'Dim transaction As SqlTransaction
            'transaction = connection.BeginTransaction("UpdatingUsingTableAsParameter")
            Command.Connection = connection
            'Command.Transaction = transaction
            Try
                Command.CommandType = CommandType.StoredProcedure
                Command.CommandText = StoreProcedure
                With Command.Parameters
                    .Clear()
                    .AddWithValue("@TableVar", dtSource)
                    If Params.Count > 0 Then
                        For p = 0 To Params.Count - 1
                            .AddWithValue(Params.Item(p), Values.Item(p))
                        Next
                    End If
                End With
                Command.CommandTimeout = 60000
                iReturn = Command.ExecuteNonQuery()
                If iReturn <= 0 Then
                    'transaction.Commit()
                    aResult(0) = 1
                    'Else
                    'transaction.Rollback()
                End If
            Catch ex As Exception
                aResult(0) = 0
                aResult(1) = ex.Message
                'transaction.Rollback()
            Finally
                connection.Close()
            End Try
            Return aResult
        End Using
        Return aResult
    End Function

    Public Function ExecuteStoreProcedure(sp_name As String, sp_parameters As List(Of List(Of String)), sp_type As String) As DataSet Implements IDelfinService.ExecuteStoreProcedure
        Dim dsResult As New DataSet
        Using connection As New SqlConnection(ConfigurationManager.AppSettings("dbNextSoft"))
            connection.Open()
            Dim Command As New SqlCommand
            'Dim transaction As SqlTransaction
            'transaction = connection.BeginTransaction()
            Command.Connection = connection
            'Command.Transaction = transaction
            Try
                Command.CommandType = CommandType.StoredProcedure
                Command.CommandText = sp_name
                With Command.Parameters
                    .Clear()
                    For p = 0 To sp_parameters.Count - 1
                        .AddWithValue(sp_parameters(p)(0), sp_parameters(p)(1))
                    Next

                End With
                Command.CommandTimeout = 60000
                'If Command.ExecuteNonQuery() <= 0 Then
                '    transaction.Commit()
                'Else
                '    transaction.Rollback()
                'End If
            Catch ex As Exception
                'transaction.Rollback()
            Finally
                connection.Close()
            End Try
        End Using
        Return dsResult
    End Function

#Region "Eventos"
    Dim oEventoBL As New COM_Det_Cotizacion_OV_EventosTareas_BL

    Public Function InsertEvento(oEvento As COM_Det_Cotizacion_OV_EventosTareas_BE) As COM_Det_Cotizacion_OV_EventosTareas_BE Implements IDelfinService.InsertEvento
        Return oEventoBL.Insert(oEvento)
    End Function

    Public Sub UpdateEntidadDireccionamiento(oEvento As COM_Det_Cotizacion_OV_EventosTareas_BE) Implements IDelfinService.UpdateEvento
        oEventoBL.Update(oEvento)
    End Sub

    Public Sub DeleteEntidadDireccionamiento(oEvento As COM_Det_Cotizacion_OV_EventosTareas_BE) Implements IDelfinService.DeleteEvento
        oEventoBL.Delete(oEvento)
    End Sub

#End Region

#Region "ServicioLogistico"
    Public Function InsertLogisticOperation(dsLogisticOperation As DataSet) As ArrayList Implements IDelfinService.InsertLogisticOperation
        Dim aResult As New ArrayList
        Dim dtHeader As DataTable = dsLogisticOperation.Tables("Header")
        Dim dtDetail As DataTable = dsLogisticOperation.Tables("Detail")
        Dim _CodOper As String = ""
        aResult.AddRange({2, ""})
        Using connection As New SqlConnection(ConfigurationManager.AppSettings("dbSolution"))
            connection.Open()
            Dim Command As New SqlCommand
            Dim transaction As SqlTransaction
            transaction = connection.BeginTransaction("LogisticOperation")
            Command.Connection = connection
            Command.Transaction = transaction
            Try
                'Cabecera
                Dim oRowH As DataRow = dtHeader.Rows(0)
                Command.CommandType = CommandType.StoredProcedure
                Command.CommandText = "NextSoft.dgp.SLI_COPESI_Unreg"
                Command.Parameters.Clear()
                With Command.Parameters
                    .Add("@pintCOPE_Codigo", SqlDbType.Int).Value = oRowH("COPE_Codigo")
                    .Add("@pintCOPE_Version", SqlDbType.SmallInt).Value = oRowH("COPE_Version")
                    .Add("@pvchCOPE_NumDoc", SqlDbType.VarChar, 11).Value = oRowH("COPE_NumDoc")
                    .Add("@pdtmCOPE_FecEmi", SqlDbType.DateTime).Value = oRowH("COPE_FecEmi")
                    .Add("@pvchCOPE_Observacion", SqlDbType.VarChar, 1024).Value = oRowH("COPE_Observacion")
                    .Add("@pvchCOPE_HBL", SqlDbType.VarChar, 20).Value = oRowH("COPE_HBL")
                    .Add("@pintCCOT_Codigo", SqlDbType.Int).Value = oRowH("CCOT_Codigo")
                    .Add("@pintENTC_CodCliente", SqlDbType.Int).Value = oRowH("ENTC_CodCliente")
                    .Add("@pintENTC_CodTransporte", SqlDbType.Int).Value = oRowH("ENTC_CodTransporte")
                    .Add("@pintENTC_CodAgente", SqlDbType.Int).Value = oRowH("ENTC_CodAgente")
                    .Add("@pchrCONS_CodEstado", SqlDbType.Char, 3).Value = oRowH("CONS_CodEstado")
                    .Add("@pchrCONS_TabEstado", SqlDbType.Char, 3).Value = oRowH("CONS_TabEstado")
                    .Add("@pbitCOPE_Excepcion", SqlDbType.Bit).Value = oRowH("COPE_Excepcion")
                    .Add(New SqlParameter("@pdecCOPE_Fob", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowH("COPE_Fob")
                    .Add(New SqlParameter("@pdecCOPE_Seguro", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowH("COPE_Seguro")
                    .Add(New SqlParameter("@pdecCOPE_Flete", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowH("COPE_Flete")
                    .Add(New SqlParameter("@pdecCOPE_Cif", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowH("COPE_Cif")
                    .Add(New SqlParameter("@pdecCOPE_PartArancelaria", SqlDbType.Decimal) With {.Precision = 5, .Scale = 2}).Value = oRowH("COPE_PartArancelaria")
                    .Add(New SqlParameter("@pdecCOPE_Ipm", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowH("COPE_Ipm")
                    .Add(New SqlParameter("@pdecCOPE_Igv", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowH("COPE_Igv")
                    .Add(New SqlParameter("@pdecCOPE_Percepcion", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowH("COPE_Percepcion")
                    .Add(New SqlParameter("@pdecCOPE_TasaDespacho", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowH("COPE_TasaDespacho")
                    .Add(New SqlParameter("@pdecCOPE_AdValorem", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowH("COPE_AdValorem")
                    .Add("@pbitCOPE_1erEmbarque", SqlDbType.Bit).Value = oRowH("COPE_1erEmbarque")
                    .Add("@pvchAUDI_UsrCrea", SqlDbType.VarChar, 20).Value = oRowH("AUDI_UsrCrea")
                    .Add("@pchrTIPO_TabMND", SqlDbType.Char, 3).Value = oRowH("TIPO_TabMND")
                    .Add("@pchrTIPO_CodMND", SqlDbType.Char, 3).Value = oRowH("TIPO_CodMND")
                    .Add("@pchrCONS_CodCRG", SqlDbType.Char, 3).Value = oRowH("CONS_CodCRG")
                    .Add("@pchrCONS_TabCRG", SqlDbType.Char, 3).Value = oRowH("CONS_TabCRG")
                    .Add("@pintCCOT_CodAduana", SqlDbType.Int).Value = oRowH("CCOT_CodAduana")
                    .Add("@pintCCOT_CodLogistico", SqlDbType.Int).Value = oRowH("CCOT_CodLogistico")
                    .Add("@pintCCOT_CodTransporte", SqlDbType.Int).Value = oRowH("CCOT_CodTransporte")
                    .Add("@pvchCOPE_Nave", SqlDbType.VarChar, 20).Value = oRowH("COPE_Nave")
                    .Add("@pvchCOPE_Viaje", SqlDbType.VarChar, 20).Value = oRowH("COPE_Viaje")
                    .Add("@pvchCOPE_MBL", SqlDbType.VarChar, 20).Value = oRowH("COPE_MBL")
                    .Add("@pdtmCOPE_FechaArribo", SqlDbType.DateTime).Value = oRowH("COPE_FechaArribo")
                    .Add("@psinCOPE_CantidadDias", SqlDbType.SmallInt).Value = oRowH("COPE_CantidadDias")
                    .Add(New SqlParameter("@pdecCOPE_Kilos", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowH("COPE_Kilos")
                    .Add(New SqlParameter("@pdecCOPE_Volumen", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowH("COPE_Volumen")
                    .Add("@pbitCOPE_PrecioSada", SqlDbType.Bit).Value = oRowH("COPE_PrecioSada")
                    .Add("@pintENTC_CodAgenPort", SqlDbType.Int).Value = oRowH("ENTC_CodAgenPort")
                    .Add("@pintENTC_CodTermPort", SqlDbType.Int).Value = oRowH("ENTC_CodTermPort")
                    .Add("@pintENTC_CodDepTemporal", SqlDbType.Int).Value = oRowH("ENTC_CodDepTemporal")
                    .Add("@pintENTC_CodTransTerre", SqlDbType.Int).Value = oRowH("ENTC_CodTransTerre")
                    .Add("@pintCTAR_Codigo", SqlDbType.Int).Value = oRowH("CTAR_Codigo")
                    .Add("@pintCTAR_Version", SqlDbType.SmallInt).Value = oRowH("CTAR_Version")
                End With
                _CodOper = Command.ExecuteScalar
                aResult(1) = _CodOper
                'aResult(2) = oRowH("COPE_NumDoc")
                'Detalle
                For r = 0 To dtDetail.Rows.Count - 1
                    Dim oRowD As DataRow = dtDetail.Rows(r)
                    Command.CommandType = CommandType.StoredProcedure
                    Command.CommandText = "NextSoft.dgp.SLI_DOPESI_Unreg"
                    With Command.Parameters
                        .Clear()
                        .Add("@pintDOPE_Item", SqlDbType.Int).Value = oRowD("DOPE_Item")
                        .Add("@pintCOPE_Codigo", SqlDbType.Int).Value = _CodOper
                        .Add("@pintCOPE_Version", SqlDbType.SmallInt).Value = oRowH("COPE_Version")
                        .Add("@psinDTAR_Item", SqlDbType.SmallInt).Value = oRowD("DTAR_Item")
                        .Add("@pintCTAR_Codigo", SqlDbType.Int).Value = oRowD("CTAR_Codigo")
                        .Add("@pchrCTAR_Tipo", SqlDbType.Char, 1).Value = oRowD("CTAR_Tipo")
                        .Add("@pintPACK_Codigo", SqlDbType.Int).Value = oRowD("PACK_Codigo")
                        .Add("@pchrCONS_CodBas", SqlDbType.Char, 3).Value = oRowD("CONS_CodBas")
                        .Add("@pchrCONS_TabBas", SqlDbType.Char, 3).Value = oRowD("CONS_TabBas")
                        .Add("@psinDOPE_Cantidad", SqlDbType.SmallInt).Value = oRowD("DOPE_Cantidad")
                        .Add(New SqlParameter("@pdecDOPE_PrecioUnitCosto", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowD("DOPE_PrecioUnitCosto")
                        .Add(New SqlParameter("@pdecDOPE_PrecioTotCosto", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowD("DOPE_PrecioTotCosto")
                        .Add(New SqlParameter("@pdecDOPE_PrecioUnitVta", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowD("DOPE_PrecioUnitVta")
                        .Add(New SqlParameter("@pdecDOPE_PrecioTotVta", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowD("DOPE_PrecioTotVta")
                        .Add(New SqlParameter("@pdecDOPE_Minimo", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowD("DOPE_Minimo")
                        .Add(New SqlParameter("@pnumDOPE_Peso", SqlDbType.Decimal) With {.Precision = 12, .Scale = 4}).Value = oRowD("DOPE_Peso")
                        .Add(New SqlParameter("@pnumDOPE_Volumen", SqlDbType.Decimal) With {.Precision = 12, .Scale = 4}).Value = oRowD("DOPE_Volumen")
                        .Add("@pvchAUDI_UsrCrea", SqlDbType.VarChar, 20).Value = oRowD("AUDI_UsrCrea")
                        .Add(New SqlParameter("@pdecDOPE_CostoSada", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowD("DOPE_CostoSada")
                        .Add(New SqlParameter("@pdecDOPE_Costo", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowD("DOPE_Costo")
                        .Add(New SqlParameter("@pdecDOPE_VentaSada", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowD("DOPE_VentaSada")
                        .Add(New SqlParameter("@pdecDOPE_Venta", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowD("DOPE_Venta")
                        .Add("@pchrTIPO_TabZON", SqlDbType.Char, 3).Value = oRowD("TIPO_TabZON")
                        .Add("@pchrTIPO_CodZONOrigen", SqlDbType.Char, 3).Value = oRowD("TIPO_CodZONOrigen")
                        .Add("@pchrCONS_CodTRA", SqlDbType.Char, 3).Value = oRowD("CONS_CodTRA")
                        .Add("@pchrCONS_TabTRA", SqlDbType.Char, 3).Value = oRowD("CONS_TabTRA")
                        .Add("@pchrTIPO_CodZONDestino", SqlDbType.Char, 3).Value = oRowD("TIPO_CodZONDestino")
                        .Add("@psinTIPE_Codigo", SqlDbType.SmallInt).Value = oRowD("TIPE_Codigo")
                        .Add("@pintENTC_Codigo", SqlDbType.Int).Value = oRowD("ENTC_Codigo")
                        .Add("@pchrCONS_CodEST", SqlDbType.Char, 3).Value = oRowD("CONS_CodEST")
                        .Add("@pchrCONS_TabEST", SqlDbType.Char, 3).Value = oRowD("CONS_TabEST")
                        .Add("@pintSERV_Codigo", SqlDbType.Int, 3).Value = oRowD("SERV_Codigo")
                        .Add("@pchrTIPO_TabMND", SqlDbType.Char, 3).Value = oRowD("TIPO_TabMND")
                        .Add("@pchrTIPO_CodMND", SqlDbType.Char, 3).Value = oRowD("TIPO_CodMND")
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

    Public Function UpdateLogisticOperation(dsLogisticOperation As DataSet, dtOriginalDetail As DataTable) As ArrayList Implements IDelfinService.UpdateLogisticOperation
        Dim aResult As New ArrayList
        Dim dtHeader As DataTable = dsLogisticOperation.Tables("Header")
        Dim dtDetail As DataTable = dsLogisticOperation.Tables("Detail")
        Dim _CodOper As String = ""
        aResult.AddRange({1, ""})
        Using connection As New SqlConnection(ConfigurationManager.AppSettings("dbSolution"))
            connection.Open()
            Dim Command As New SqlCommand
            Dim transaction As SqlTransaction
            transaction = connection.BeginTransaction("LogisticOperation")
            Command.Connection = connection
            Command.Transaction = transaction
            Try
                'Cabecera
                Dim oRowH As DataRow = dtHeader.Rows(0)
                Command.CommandType = CommandType.StoredProcedure
                Command.CommandText = "NextSoft.dgp.SLI_COPESU_Unreg"
                Command.Parameters.Clear()
                With Command.Parameters
                    .Add("@pintCOPE_Codigo", SqlDbType.Int).Value = oRowH("COPE_Codigo")
                    .Add("@pintCOPE_Version", SqlDbType.SmallInt).Value = oRowH("COPE_Version")
                    .Add("@pvchCOPE_NumDoc", SqlDbType.VarChar, 11).Value = oRowH("COPE_NumDoc")
                    .Add("@pdtmCOPE_FecEmi", SqlDbType.DateTime).Value = oRowH("COPE_FecEmi")
                    .Add("@pvchCOPE_Observacion", SqlDbType.VarChar, 1024).Value = oRowH("COPE_Observacion")
                    .Add("@pvchCOPE_HBL", SqlDbType.VarChar, 20).Value = oRowH("COPE_HBL")
                    .Add("@pintCCOT_Codigo", SqlDbType.Int).Value = oRowH("CCOT_Codigo")
                    .Add("@pintENTC_CodCliente", SqlDbType.Int).Value = oRowH("ENTC_CodCliente")
                    .Add("@pintENTC_CodTransporte", SqlDbType.Int).Value = oRowH("ENTC_CodTransporte")
                    .Add("@pintENTC_CodAgente", SqlDbType.Int).Value = oRowH("ENTC_CodAgente")
                    .Add("@pchrCONS_CodEstado", SqlDbType.Char, 3).Value = oRowH("CONS_CodEstado")
                    .Add("@pchrCONS_TabEstado", SqlDbType.Char, 3).Value = oRowH("CONS_TabEstado")
                    .Add("@pbitCOPE_Excepcion", SqlDbType.Bit).Value = oRowH("COPE_Excepcion")
                    .Add(New SqlParameter("@pdecCOPE_Fob", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowH("COPE_Fob")
                    .Add(New SqlParameter("@pdecCOPE_Seguro", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowH("COPE_Seguro")
                    .Add(New SqlParameter("@pdecCOPE_Flete", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowH("COPE_Flete")
                    .Add(New SqlParameter("@pdecCOPE_Cif", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowH("COPE_Cif")
                    .Add(New SqlParameter("@pdecCOPE_PartArancelaria", SqlDbType.Decimal) With {.Precision = 5, .Scale = 2}).Value = oRowH("COPE_PartArancelaria")
                    .Add(New SqlParameter("@pdecCOPE_Ipm", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowH("COPE_Ipm")
                    .Add(New SqlParameter("@pdecCOPE_Igv", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowH("COPE_Igv")
                    .Add(New SqlParameter("@pdecCOPE_Percepcion", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowH("COPE_Percepcion")
                    .Add(New SqlParameter("@pdecCOPE_TasaDespacho", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowH("COPE_TasaDespacho")
                    .Add(New SqlParameter("@pdecCOPE_AdValorem", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowH("COPE_AdValorem")
                    .Add("@pbitCOPE_1erEmbarque", SqlDbType.Bit).Value = oRowH("COPE_1erEmbarque")
                    .Add("@pvchAUDI_UsrMod", SqlDbType.VarChar, 20).Value = oRowH("AUDI_UsrMod")
                    .Add("@pchrTIPO_TabMND", SqlDbType.Char, 3).Value = oRowH("TIPO_TabMND")
                    .Add("@pchrTIPO_CodMND", SqlDbType.Char, 3).Value = oRowH("TIPO_CodMND")
                    .Add("@pchrCONS_CodCRG", SqlDbType.Char, 3).Value = oRowH("CONS_CodCRG")
                    .Add("@pchrCONS_TabCRG", SqlDbType.Char, 3).Value = oRowH("CONS_TabCRG")
                    .Add("@pintCCOT_CodAduana", SqlDbType.Int).Value = oRowH("CCOT_CodAduana")
                    .Add("@pintCCOT_CodLogistico", SqlDbType.Int).Value = oRowH("CCOT_CodLogistico")
                    .Add("@pintCCOT_CodTransporte", SqlDbType.Int).Value = oRowH("CCOT_CodTransporte")
                    .Add("@pvchCOPE_Nave", SqlDbType.VarChar, 20).Value = oRowH("COPE_Nave")
                    .Add("@pvchCOPE_Viaje", SqlDbType.VarChar, 20).Value = oRowH("COPE_Viaje")
                    .Add("@pvchCOPE_MBL", SqlDbType.VarChar, 20).Value = oRowH("COPE_MBL")
                    .Add("@pdtmCOPE_FechaArribo", SqlDbType.DateTime).Value = oRowH("COPE_FechaArribo")
                    .Add("@psinCOPE_CantidadDias", SqlDbType.SmallInt).Value = oRowH("COPE_CantidadDias")
                    .Add(New SqlParameter("@pdecCOPE_Kilos", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowH("COPE_Kilos")
                    .Add(New SqlParameter("@pdecCOPE_Volumen", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowH("COPE_Volumen")
                    .Add("@pbitCOPE_PrecioSada", SqlDbType.Bit).Value = oRowH("COPE_PrecioSada")
                    .Add("@pintENTC_CodAgenPort", SqlDbType.Int).Value = oRowH("ENTC_CodAgenPort")
                    .Add("@pintENTC_CodTermPort", SqlDbType.Int).Value = oRowH("ENTC_CodTermPort")
                    .Add("@pintENTC_CodDepTemporal", SqlDbType.Int).Value = oRowH("ENTC_CodDepTemporal")
                    .Add("@pintENTC_CodTransTerre", SqlDbType.Int).Value = oRowH("ENTC_CodTransTerre")
                    .Add("@pintCTAR_Codigo", SqlDbType.Int).Value = oRowH("CTAR_Codigo")
                    .Add("@pintCTAR_Version", SqlDbType.SmallInt).Value = oRowH("CTAR_Version")
                End With
                Command.ExecuteNonQuery()
                aResult(1) = oRowH("COPE_Codigo")
                'aResult(2) = oRowH("COPE_NumDoc")
                'Detalle
                '(Delete)
                For s = 0 To dtOriginalDetail.Rows.Count - 1
                    Dim oRowA As DataRow = dtOriginalDetail.Rows(s)
                    If oRowA("DOPE_Item").ToString() = "" Then
                        Continue For
                    End If
                    Dim CodigoFilaActual As String = oRowA("DOPE_Item").ToString()
                    'Dim result() As DataRow = 
                    If dtDetail.Select("DOPE_Item = " + CodigoFilaActual).Length = 0 Then
                        Command.CommandType = CommandType.StoredProcedure
                        Command.CommandText = "NextSoft.dgp.SLI_DOPESD_UnReg"
                        With Command.Parameters
                            .Clear()
                            .Add("@pintDOPE_Item", SqlDbType.Int).Value = oRowA("DOPE_Item")
                            .Add("@pintCOPE_Codigo", SqlDbType.Int).Value = oRowA("COPE_Codigo")
                            .Add("@pintCOPE_Version", SqlDbType.SmallInt).Value = oRowA("COPE_Version")
                        End With
                        Command.ExecuteNonQuery()
                    End If
                Next
                '(Insert/Update)
                For r = 0 To dtDetail.Rows.Count - 1
                    If dtDetail.Rows(r).RowState = DataRowState.Deleted Then
                        Continue For
                    End If
                    Dim oRowD As DataRow = dtDetail.Rows(r)
                    If oRowD("DOPE_Item").ToString() = "" And oRowD("COPE_Codigo").ToString() <> "" Then
                        Command.CommandType = CommandType.StoredProcedure
                        Command.CommandText = "NextSoft.dgp.SLI_DOPESI_Unreg"
                        With Command.Parameters
                            .Clear()
                            .Add("@pintDOPE_Item", SqlDbType.Int).Value = oRowD("DOPE_Item")
                            .Add("@pintCOPE_Codigo", SqlDbType.Int).Value = oRowD("COPE_Codigo")
                            .Add("@pintCOPE_Version", SqlDbType.SmallInt).Value = oRowD("COPE_Version")
                            .Add("@psinDTAR_Item", SqlDbType.SmallInt).Value = oRowD("DTAR_Item")
                            .Add("@pintCTAR_Codigo", SqlDbType.Int).Value = oRowD("CTAR_Codigo")
                            .Add("@pchrCTAR_Tipo", SqlDbType.Char, 1).Value = oRowD("CTAR_Tipo")
                            .Add("@pintPACK_Codigo", SqlDbType.Int).Value = oRowD("PACK_Codigo")
                            .Add("@pchrCONS_CodBas", SqlDbType.Char, 3).Value = oRowD("CONS_CodBas")
                            .Add("@pchrCONS_TabBas", SqlDbType.Char, 3).Value = oRowD("CONS_TabBas")
                            .Add("@psinDOPE_Cantidad", SqlDbType.SmallInt).Value = oRowD("DOPE_Cantidad")
                            .Add(New SqlParameter("@pdecDOPE_PrecioUnitCosto", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowD("DOPE_PrecioUnitCosto")
                            .Add(New SqlParameter("@pdecDOPE_PrecioTotCosto", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowD("DOPE_PrecioTotCosto")
                            .Add(New SqlParameter("@pdecDOPE_PrecioUnitVta", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowD("DOPE_PrecioUnitVta")
                            .Add(New SqlParameter("@pdecDOPE_PrecioTotVta", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowD("DOPE_PrecioTotVta")
                            .Add(New SqlParameter("@pdecDOPE_Minimo", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowD("DOPE_Minimo")
                            .Add(New SqlParameter("@pnumDOPE_Peso", SqlDbType.Decimal) With {.Precision = 12, .Scale = 4}).Value = oRowD("DOPE_Peso")
                            .Add(New SqlParameter("@pnumDOPE_Volumen", SqlDbType.Decimal) With {.Precision = 12, .Scale = 4}).Value = oRowD("DOPE_Volumen")
                            .Add("@pvchAUDI_UsrCrea", SqlDbType.VarChar, 20).Value = oRowD("AUDI_UsrCrea")
                            .Add(New SqlParameter("@pdecDOPE_CostoSada", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowD("DOPE_CostoSada")
                            .Add(New SqlParameter("@pdecDOPE_Costo", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowD("DOPE_Costo")
                            .Add(New SqlParameter("@pdecDOPE_VentaSada", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowD("DOPE_VentaSada")
                            .Add(New SqlParameter("@pdecDOPE_Venta", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowD("DOPE_Venta")
                            .Add("@pchrTIPO_TabZON", SqlDbType.Char, 3).Value = oRowD("TIPO_TabZON")
                            .Add("@pchrTIPO_CodZONOrigen", SqlDbType.Char, 3).Value = oRowD("TIPO_CodZONOrigen")
                            .Add("@pchrCONS_CodTRA", SqlDbType.Char, 3).Value = oRowD("CONS_CodTRA")
                            .Add("@pchrCONS_TabTRA", SqlDbType.Char, 3).Value = oRowD("CONS_TabTRA")
                            .Add("@pchrTIPO_CodZONDestino", SqlDbType.Char, 3).Value = oRowD("TIPO_CodZONDestino")
                            .Add("@psinTIPE_Codigo", SqlDbType.SmallInt).Value = oRowD("TIPE_Codigo")
                            .Add("@pintENTC_Codigo", SqlDbType.Int).Value = oRowD("ENTC_Codigo")
                            .Add("@pchrCONS_CodEST", SqlDbType.Char, 3).Value = oRowD("CONS_CodEST")
                            .Add("@pchrCONS_TabEST", SqlDbType.Char, 3).Value = oRowD("CONS_TabEST")
                            .Add("@pintSERV_Codigo", SqlDbType.Int, 3).Value = oRowD("SERV_Codigo")
                            .Add("@pchrTIPO_TabMND", SqlDbType.Char, 3).Value = oRowD("TIPO_TabMND")
                            .Add("@pchrTIPO_CodMND", SqlDbType.Char, 3).Value = oRowD("TIPO_CodMND")
                        End With
                    Else
                        Command.CommandType = CommandType.StoredProcedure
                        Command.CommandText = "NextSoft.dgp.SLI_DOPESU_Unreg"
                        With Command.Parameters
                            .Clear()
                            .Add("@pintDOPE_Item", SqlDbType.Int).Value = oRowD("DOPE_Item")
                            .Add("@pintCOPE_Codigo", SqlDbType.Int).Value = oRowD("COPE_Codigo")
                            .Add("@pintCOPE_Version", SqlDbType.SmallInt).Value = oRowD("COPE_Version")
                            .Add("@psinDTAR_Item", SqlDbType.SmallInt).Value = oRowD("DTAR_Item")
                            .Add("@pintCTAR_Codigo", SqlDbType.Int).Value = oRowD("CTAR_Codigo")
                            .Add("@pchrCTAR_Tipo", SqlDbType.Char, 1).Value = oRowD("CTAR_Tipo")
                            .Add("@pintPACK_Codigo", SqlDbType.Int).Value = oRowD("PACK_Codigo")
                            .Add("@pchrCONS_CodBas", SqlDbType.Char, 3).Value = oRowD("CONS_CodBas")
                            .Add("@pchrCONS_TabBas", SqlDbType.Char, 3).Value = oRowD("CONS_TabBas")
                            .Add("@psinDOPE_Cantidad", SqlDbType.SmallInt).Value = oRowD("DOPE_Cantidad")
                            .Add(New SqlParameter("@pdecDOPE_PrecioUnitCosto", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowD("DOPE_PrecioUnitCosto")
                            .Add(New SqlParameter("@pdecDOPE_PrecioTotCosto", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowD("DOPE_PrecioTotCosto")
                            .Add(New SqlParameter("@pdecDOPE_PrecioUnitVta", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowD("DOPE_PrecioUnitVta")
                            .Add(New SqlParameter("@pdecDOPE_PrecioTotVta", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowD("DOPE_PrecioTotVta")
                            .Add(New SqlParameter("@pdecDOPE_Minimo", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowD("DOPE_Minimo")
                            .Add(New SqlParameter("@pnumDOPE_Peso", SqlDbType.Decimal) With {.Precision = 12, .Scale = 4}).Value = oRowD("DOPE_Peso")
                            .Add(New SqlParameter("@pnumDOPE_Volumen", SqlDbType.Decimal) With {.Precision = 12, .Scale = 4}).Value = oRowD("DOPE_Volumen")
                            .Add("@pvchUSR_UsrMod", SqlDbType.VarChar, 20).Value = oRowD("USR_UsrMod")
                            .Add(New SqlParameter("@pdecDOPE_CostoSada", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowD("DOPE_CostoSada")
                            .Add(New SqlParameter("@pdecDOPE_Costo", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowD("DOPE_Costo")
                            .Add(New SqlParameter("@pdecDOPE_VentaSada", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowD("DOPE_VentaSada")
                            .Add(New SqlParameter("@pdecDOPE_Venta", SqlDbType.Decimal) With {.Precision = 15, .Scale = 2}).Value = oRowD("DOPE_Venta")
                            .Add("@pchrTIPO_TabZON", SqlDbType.Char, 3).Value = oRowD("TIPO_TabZON")
                            .Add("@pchrTIPO_CodZONOrigen", SqlDbType.Char, 3).Value = oRowD("TIPO_CodZONOrigen")
                            .Add("@pchrCONS_CodTRA", SqlDbType.Char, 3).Value = oRowD("CONS_CodTRA")
                            .Add("@pchrCONS_TabTRA", SqlDbType.Char, 3).Value = oRowD("CONS_TabTRA")
                            .Add("@pchrTIPO_CodZONDestino", SqlDbType.Char, 3).Value = oRowD("TIPO_CodZONDestino")
                            .Add("@psinTIPE_Codigo", SqlDbType.SmallInt).Value = oRowD("TIPE_Codigo")
                            .Add("@pintENTC_Codigo", SqlDbType.Int).Value = oRowD("ENTC_Codigo")
                            .Add("@pchrCONS_CodEST", SqlDbType.Char, 3).Value = oRowD("CONS_CodEST")
                            .Add("@pchrCONS_TabEST", SqlDbType.Char, 3).Value = oRowD("CONS_TabEST")
                            .Add("@pintSERV_Codigo", SqlDbType.Int, 3).Value = oRowD("SERV_Codigo")
                            .Add("@pchrTIPO_TabMND", SqlDbType.Char, 3).Value = oRowD("TIPO_TabMND")
                            .Add("@pchrTIPO_CodMND", SqlDbType.Char, 3).Value = oRowD("TIPO_CodMND")
                        End With
                    End If
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
#End Region

End Class

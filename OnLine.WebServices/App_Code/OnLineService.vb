Imports System.Data
Imports Application.BusinessEntities
Imports Application.BusinessLogic


' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "Service" en el código, en svc y en el archivo de configuración.
Public Class OnLineService
    Implements IOnLineService

    Public Sub New()
    End Sub

    Public Function GetData(ByVal value As Integer) As String Implements IOnLineService.GetData
        Return String.Format("You entered: {0}", value)
    End Function

    Public Function GetDataUsingDataContract(ByVal composite As CompositeType) As CompositeType Implements IOnLineService.GetDataUsingDataContract
        If composite Is Nothing Then
            Throw New ArgumentNullException("composite")
        End If
        If composite.BoolValue Then
            composite.StringValue &= "Suffix"
        End If
        Return composite
    End Function

#Region "General"

    Public Function ExecuteSQL(ByVal QueryString As String) As DataSet Implements IOnLineService.ExecuteSQL
        Try
            Dim oDataAccess As New DataAccess
            Return oDataAccess.ExecuteSQL(QueryString)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function ExecuteSQLNonQuery(ByVal QueryString As String) As ArrayList Implements IOnLineService.ExecuteSQLNonQuery
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


#End Region

#Region "Web"
    Public Function VoyageQuery(ByVal Days As Integer) As DataTable Implements IOnLineService.VoyageQuery
        Dim dtResult As New DataTable
        Dim oDataAccess As New DataAccess
        Try
            dtResult = oDataAccess.ExecuteSQL("EXEC NextSoft.web.upVoyageQuery '" & Format(DateAdd(DateInterval.Day, Days * -1, Now), "yyyyMMdd") & "','" & Format(DateAdd(DateInterval.Day, Days, Now), "yyyyMMdd") & "'").Tables("Result")
            Return dtResult
        Catch ex As Exception
            Throw
        End Try

    End Function

    Public Property VoyageList() As New List(Of VoyageListDTO)

    Public Function VoyageQueryList() As List(Of VoyageListDTO) Implements IOnLineService.VoyageQueryList
        Dim dtResult As New DataTable
        Dim oDataAccess As New DataAccess
        dtResult = oDataAccess.ExecuteSQL("EXEC NextSoft.web.upVoyageList ").Tables("Result")
        Try
            For Each row As DataRow In dtResult.Rows
                VoyageList.Add(New VoyageListDTO With {.CodigoNave = IIf(row("CodigoNave") Is DBNull.Value, "", row("CodigoNave")),
                                                        .ETA_ETD = IIf(row("ETA_ETD") Is DBNull.Value, Nothing, row("ETA_ETD")),
                                                        .FechaCierreDireccionamiento = IIf(row("FechaCierreDireccionamiento") Is DBNull.Value, Nothing, row("FechaCierreDireccionamiento")),
                                                        .NombreNave = IIf(row("NombreNave") Is DBNull.Value, "", row("NombreNave")),
                                                        .Puerto = IIf(row("Puerto") Is DBNull.Value, "", row("Puerto")),
                                                        .TerminalPortuario = IIf(row("TerminalPortuario") Is DBNull.Value, "", row("TerminalPortuario")),
                                                        .Transportista = IIf(row("Transportista") Is DBNull.Value, "", row("Transportista")),
                                                        .Viaje_Vuelo = IIf(row("Viaje_Vuelo") Is DBNull.Value, "", row("Viaje_Vuelo"))})
            Next row
            Return VoyageList
        Catch ex As Exception
            Throw
        End Try

    End Function
#End Region

#Region "Extranet"

    Public Function InvoicingQuery(ByVal CustomerCode As Integer, ByVal DateFrom As Date, ByVal DateTo As Date) As DataTable Implements IOnLineService.InvoicingQuery
        Dim dtResult As New DataTable
        Dim oDataAccess As New DataAccess
        Try
            dtResult = oDataAccess.ExecuteSQL("EXEC NextSoft.web.upInvoicingQuery " & CustomerCode.ToString & ",'" & Format(DateFrom, "yyyy-MM-dd") & "','" & Format(DateTo, "yyyy-MM-dd") & "'").Tables("Result")
            Return dtResult
        Catch ex As Exception
            Throw
        End Try

    End Function

    Public Function CargoNoticeQuery(ByVal HouseBL As String) As DataSet Implements IOnLineService.CargoNoticeQuery
        Dim dsResult As New DataSet
        Dim oDataAccess As New DataAccess
        Try
            dsResult.Tables.Add(oDataAccess.ExecuteSQL("EXEC NextSoft.web.upCargoNoticeQuery 1, 1, NULL, NULL, NULL, NULL, '" & HouseBL & "'").Tables(0).Copy)
            dsResult.Tables(0).TableName = "Result1"
            dsResult.Tables.Add(oDataAccess.ExecuteSQL("EXEC NextSoft.dbo.OPE_CCOTSS_PorPagar " & dsResult.Tables(0)(0)("EMPR_Codigo").ToString & ", " & dsResult.Tables(0)(0)("CCOT_Numero").ToString).Tables(0).Copy)
            dsResult.Tables(1).TableName = "Result2"
            Return dsResult
        Catch ex As Exception
            Throw
        End Try

    End Function

    Public Function GetVoyageByCustomer(ByVal CustomerCode As Integer) As DataTable Implements IOnLineService.GetVoyageByCustomer
        Dim dtResult As New DataTable
        Dim oDataAccess As New DataAccess
        Try
            dtResult = oDataAccess.ExecuteSQL("EXEC NextSoft.web.upGetVoyageByCustomer " & CustomerCode.ToString).Tables("Result")
            Return dtResult
        Catch ex As Exception
            Throw
        End Try

    End Function

    Public Function CargoAddressingQuery(ByVal CustomerCode As Integer, ByVal VoyageCode As Integer, ByVal HouseBL As String) As DataTable Implements IOnLineService.CargoAddressingQuery
        Dim dtResult As New DataTable
        Dim oDataAccess As New DataAccess
        Try
            If HouseBL Is Nothing Then
                dtResult = oDataAccess.ExecuteSQL("EXEC NextSoft.web.upCargoAddressingQuery " & VoyageCode.ToString & "," & CustomerCode.ToString).Tables("Result")
            Else
                dtResult = oDataAccess.ExecuteSQL("EXEC NextSoft.web.upCargoAddressingQuery " & VoyageCode.ToString & "," & CustomerCode.ToString & ",'" & HouseBL & "'").Tables("Result")
            End If

            Return dtResult
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function CustomerDocumentQuery(ByVal DocumentType As String, ByVal DocumentNumber As String) As DataTable Implements IOnLineService.CustomerDocumentQuery
        Dim dtResult As New DataTable
        Dim oDataAccess As New DataAccess
        Try
            dtResult = oDataAccess.ExecuteSQL("EXEC NextSoft.web.upCustomerDocumentQuery '" & DocumentType & "','" & DocumentNumber.ToString & "'").Tables("Result")
            Return dtResult
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function CustomerDebtQuery(ByVal CustomerCode As Integer, ByVal HouseBL As String) As DataTable Implements IOnLineService.CustomerDebtQuery
        Dim dtResult As New DataTable
        Dim oDataAccess As New DataAccess
        Try
            dtResult = oDataAccess.ExecuteSQL("EXEC NextSoft.web.upGetCustomerDebt " & CustomerCode.ToString & ",'" & HouseBL & "'").Tables("Result")
            Return dtResult
        Catch ex As Exception
            Throw
        End Try

    End Function

    Public Function HBLStatusQuery(ByVal HouseBL As String, ByVal CustomerCode As Integer) As DataTable Implements IOnLineService.HBLStatusQuery
        Dim dtResult As New DataTable
        Dim oDataAccess As New DataAccess
        Try
            dtResult = oDataAccess.ExecuteSQL("EXEC NextSoft.web.upHBLStatusQuery '" & HouseBL & "'," & CustomerCode.ToString).Tables(0)
            Return dtResult
        Catch ex As Exception
            Throw
        End Try

    End Function

    Public Function GetDataList(TableName As String, Params As ArrayList) As DataTable Implements IOnLineService.GetDataList
        Dim dtResult As New DataTable
        Dim oMastarDataList As New MasterDataList
        Try
            dtResult = oMastarDataList.LoadMasterData(TableName, Params)
            Return dtResult
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GetRelatedCompany(DocumentNumber As String) As DataTable Implements IOnLineService.GetRelatedCompany
        Dim dtResult As New DataTable
        Dim oDataAccess As New DataAccess
        Try
            dtResult = oDataAccess.ExecuteSQL("EXEC NextSoft.dgp.paObtieneEmpresaVinculada '" & DocumentNumber & "'").Tables(0)
            Return dtResult
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GetDataByEntityType(EntityType As Integer, DocumentNumber As String) As DataSet Implements IOnLineService.GetDataByEntityType
        Dim dsResult As New DataSet
        Dim oDataAccess As New DataAccess
        Try
            dsResult = oDataAccess.ExecuteSQL("EXEC NextSoft.dgp.paObtieneDatosPorTipoEntidad " & EntityType.ToString & ", '" & DocumentNumber & "'")
            Return dsResult
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function OperationalTracking(ByVal CustomerCode As Integer, ByVal HouseBL As String) As DataSet Implements IOnLineService.OperationalTracking
        Dim dsResult As New DataSet
        Dim oDataAccess As New DataAccess
        Try
            dsResult = oDataAccess.ExecuteSQL("EXEC NextSoft.web.upOperationalTrackingByHbl " & CustomerCode.ToString & ",'" & HouseBL & "'")
            Return dsResult
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function CustomerStatementQuery(ByVal CustomerCode As Integer, ByVal DateFrom As Date, ByVal DateTo As Date, ByVal QueryType As String, ByVal HouseBL As String) As DataTable Implements IOnLineService.CustomerStatementQuery
        Dim dtResult As New DataTable
        Dim oDataAccess As New DataAccess
        Try
            dtResult = oDataAccess.ExecuteSQL("EXEC NextSoft.web.upGetCustomerStatement " & CustomerCode.ToString & ",'" & Format(DateFrom, "yyyy-MM-dd") & "','" & Format(DateTo, "yyyy-MM-dd") & "','" & QueryType & "','" & HouseBL & "'").Tables("Result")
            Return dtResult
        Catch ex As Exception
            Throw
        End Try

    End Function

#End Region

#Region "Eliminar"
    Public Function RelatedCompanyQuery(ByVal CompanyCode As Integer) As DataTable Implements IOnLineService.RelatedCompanyQuery
        Dim dtResult As New DataTable
        Dim oDataAccess As New DataAccess
        Try
            dtResult = oDataAccess.ExecuteSQL("EXEC NextSoft.web.upRelatedCompanyQuery " & CompanyCode.ToString).Tables("Result")
            Return dtResult
        Catch ex As Exception
            Throw
        End Try
    End Function
#End Region

#Region "EntidadVinculada"
    Dim oRelatedCompanyBL As New EntidadVinculada_BL

    Public Sub InsertRelatedCompany(oRelatedCompany As EntidadVinculada_BE) Implements IOnLineService.InsertRelatedCompany
        oRelatedCompanyBL.Insert(oRelatedCompany)
    End Sub

    Public Sub UpdateRelatedCompany(oRelatedCompany As EntidadVinculada_BE) Implements IOnLineService.UpdateRelatedCompany
        oRelatedCompanyBL.Update(oRelatedCompany)
    End Sub

    Public Sub StatusUpdateRelatedCompany(oRelatedCompany As EntidadVinculada_BE) Implements IOnLineService.StatusUpdateRelatedCompany
        oRelatedCompanyBL.StatusUpdate(oRelatedCompany)
    End Sub

    Public Sub DeleteRelatedCompany(oRelatedCompany As EntidadVinculada_BE) Implements IOnLineService.DeleteRelatedCompany
        oRelatedCompanyBL.Delete(oRelatedCompany)
    End Sub

    Public Function GetAllRelatedCompany(oRelatedCompany As EntidadVinculada_BE) As EntidadVinculada_BE Implements IOnLineService.GetAllRelatedCompany
        Return oRelatedCompanyBL.GetAll(oRelatedCompany)
    End Function

    Public Function GetAllDataTableRelatedCompany(oRelatedCompany As EntidadVinculada_BE) As DataTable Implements IOnLineService.GetAllDataTableRelatedCompany
        Return oRelatedCompanyBL.GetAllDataTable(oRelatedCompany)
    End Function

#End Region

#Region "Entidad Registro"
    Dim oEntidadRegistroBL As New EntidadRegistro_BL

    Public Sub InsertCustomerRegister(oCustomerRegister As EntidadRegistro_BE) Implements IOnLineService.InsertCustomerRegister
        oEntidadRegistroBL.Insert(oCustomerRegister)
    End Sub


    Public Sub StatusUpdateCustomerRegister(oCustomerRegister As EntidadRegistro_BE) Implements IOnLineService.StatusUpdateCustomerRegister
        oEntidadRegistroBL.StatusUpdate(oCustomerRegister)
    End Sub

    Public Function GetAllDataTableCustomerRegister(oCustomerRegister As EntidadRegistro_BE) As DataTable Implements IOnLineService.GetAllDataTableCustomerRegister
        Return oEntidadRegistroBL.GetAllDataTable(oCustomerRegister)
    End Function

#End Region

#Region "EntidadDireccionamiento"
    Dim oEntidadDireccionamientoBL As New EntidadDireccionamiento_BL

    Public Function InsertEntidadDireccionamiento(oEntidadDireccionamiento As EntidadDireccionamiento_BE) As EntidadDireccionamiento_BE Implements IOnLineService.InsertEntidadDireccionamiento
        Return oEntidadDireccionamientoBL.Insert(oEntidadDireccionamiento)
    End Function

    Public Sub UpdateEntidadDireccionamiento(oEntidadDireccionamiento As EntidadDireccionamiento_BE) Implements IOnLineService.UpdateEntidadDireccionamiento
        oEntidadDireccionamientoBL.Update(oEntidadDireccionamiento)
    End Sub



    Public Sub DeleteEntidadDireccionamiento(oEntidadDireccionamiento As EntidadDireccionamiento_BE) Implements IOnLineService.DeleteEntidadDireccionamiento
        oEntidadDireccionamientoBL.Delete(oEntidadDireccionamiento)
    End Sub

    Public Function GetAllEntidadDireccionamiento(oEntidadDireccionamiento As EntidadDireccionamiento_BE) As EntidadDireccionamiento_BE Implements IOnLineService.GetAllEntidadDireccionamiento
        Return oEntidadDireccionamientoBL.GetAll(oEntidadDireccionamiento)
    End Function


    Public Function GetByFilterEntidadDireccionamiento(oEntidadDireccionamiento As EntidadDireccionamiento_BE) As List(Of EntidadDireccionamiento_BE) Implements IOnLineService.GetByFilterEntidadDireccionamiento
        Return oEntidadDireccionamientoBL.GetByFilter(oEntidadDireccionamiento)
    End Function



    Public Function ValidarDireccionamiento(oEntidadDireccionamiento As EntidadDireccionamiento_BE) As EntidadDireccionamiento_BE Implements IOnLineService.ValidarDireccionamiento
        Return oEntidadDireccionamientoBL.ValidarDireccionamiento(oEntidadDireccionamiento)
    End Function


    Public Function GetAllDataTableEntidadDireccionamiento(oEntidadDireccionamiento As EntidadDireccionamiento_BE) As DataTable Implements IOnLineService.GetAllDataTableEntidadDireccionamiento
        Return oEntidadDireccionamientoBL.GetAllDataTable(oEntidadDireccionamiento)
    End Function


#End Region

#Region "Consulta Tarifario"
    Public Property TariffList() As New List(Of TariffListDTO)

    Public Function TariffQueryList() As List(Of TariffListDTO) Implements IOnLineService.TariffQueryList
        Dim dtResult As New DataTable
        Dim oDataAccess As New DataAccess
        dtResult = oDataAccess.ExecuteSQL("EXEC NextSoft.web.upGetPublicTariff ").Tables("Result")
        Try
            For Each row As DataRow In dtResult.Rows
                TariffList.Add(New TariffListDTO With {.Concepto = IIf(row("Concepto") Is DBNull.Value, "", row("Concepto")),
                                                        .BaseCobro = IIf(row("BaseCobro") Is DBNull.Value, Nothing, row("BaseCobro")),
                                                        .Moneda = IIf(row("Moneda") Is DBNull.Value, Nothing, row("Moneda")),
                                                        .Tarifa = row("Tarifa")})
            Next row
            Return TariffList
        Catch ex As Exception
            Throw
        End Try

    End Function
#End Region
End Class

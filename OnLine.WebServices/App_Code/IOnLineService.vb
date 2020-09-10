Imports System.Data
Imports Application.BusinessEntities

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "IService" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface IOnLineService

    <OperationContract()>
    Function GetData(ByVal value As Integer) As String

    <OperationContract()>
    Function GetDataUsingDataContract(ByVal composite As CompositeType) As CompositeType

    ' TODO: agregue aquí sus operaciones de servicio
#Region "General"

    <OperationContract()>
    Function ExecuteSQL(ByVal QueryString As String) As DataSet

    <OperationContract()>
    Function ExecuteSQLNonQuery(ByVal QueryString As String) As ArrayList

#End Region

#Region "Web"

    <OperationContract()>
    Function VoyageQuery(ByVal Days As Integer) As DataTable

    <OperationContract()>
    Function VoyageQueryList() As List(Of VoyageQueryDTO)


#End Region

#Region "Extranet"

    <OperationContract()>
    Function InvoicingQuery(ByVal CustomerCode As Integer, ByVal DateFrom As Date, ByVal DateTo As Date) As DataTable

    <OperationContract()>
    Function CargoNoticeQuery(ByVal HouseBL As String) As DataSet

    <OperationContract()>
    Function GetVoyageByCustomer(ByVal CustomerCode As Integer) As DataTable

    <OperationContract()>
    Function CargoAddressingQuery(ByVal CustomerCode As Integer, ByVal Voyage As Integer, ByVal HouseBL As String) As DataTable

    <OperationContract()>
    Function CustomerDocumentQuery(ByVal DocumentType As String, ByVal DocumentNUmber As String) As DataTable

    <OperationContract()>
    Function CustomerDebtQuery(ByVal CustomerCode As Integer, ByVal HouseBL As String) As DataTable

    <OperationContract()>
    Function HBLStatusQuery(ByVal HouseBL As String, ByVal CustomerCode As Integer) As DataTable

    <OperationContract()>
    Function RelatedCompanyQuery(ByVal CompanyCode As Integer) As DataTable

    <OperationContract()>
    Sub InsertRelatedCompany(oRelatedCompany As EntidadVinculada_BE)

    <OperationContract()>
    Sub UpdateRelatedCompany(oRelatedCompany As EntidadVinculada_BE)

    <OperationContract()>
    Sub StatusUpdateRelatedCompany(oRelatedCompany As EntidadVinculada_BE)

    <OperationContract()>
    Sub DeleteRelatedCompany(oRelatedCompany As EntidadVinculada_BE)

    <OperationContract()>
    Function GetAllRelatedCompany(oRelatedCompany As EntidadVinculada_BE) As EntidadVinculada_BE

    <OperationContract()>
    Function GetAllDataTableRelatedCompany(oRelatedCompany As EntidadVinculada_BE) As DataTable

    <OperationContract()>
    Function GetDataList(TableName As String, Params As ArrayList) As DataTable

    <OperationContract>
    Function GetRelatedCompany(DocumentNumber As String) As DataTable

    <OperationContract>
    Function GetDataByEntityType(EntityType As Integer, DocumentNumber As String) As DataSet

    <OperationContract()>
    Sub InsertCustomerRegister(oCustomerRegister As EntidadRegistro_BE)

    <OperationContract()>
    Sub StatusUpdateCustomerRegister(oCustomerRegister As EntidadRegistro_BE)

    <OperationContract()>
    Function GetAllDataTableCustomerRegister(oCustomerRegister As EntidadRegistro_BE) As DataTable

    <OperationContract()>
    Function OperationalTracking(ByVal CustomerCode As Integer, ByVal HouseBL As String) As DataSet

    <OperationContract()>
    Function CustomerStatementQuery(ByVal CustomerCode As Integer, ByVal DateFrom As Date, ByVal DateTo As Date, ByVal QueryType As String, ByVal HouseBL As String) As DataTable

#End Region

#Region "Entidad Direccionamiento"



    <OperationContract()>
    Function InsertEntidadDireccionamiento(oEntidadDireccionamiento As EntidadDireccionamiento_BE) As EntidadDireccionamiento_BE

    <OperationContract()>
    Sub UpdateEntidadDireccionamiento(oEntidadDireccionamiento As EntidadDireccionamiento_BE)

    <OperationContract()>
    Sub DeleteEntidadDireccionamiento(oEntidadDireccionamiento As EntidadDireccionamiento_BE)

    <OperationContract()>
    Function ValidarDireccionamiento(oEntidadDireccionamiento As EntidadDireccionamiento_BE) As EntidadDireccionamiento_BE

    <OperationContract()>
    Function GetByFilterEntidadDireccionamiento(oEntidadDireccionamiento As EntidadDireccionamiento_BE) As List(Of EntidadDireccionamiento_BE)

    <OperationContract()>
    Function GetAllDataTableEntidadDireccionamiento(oEntidadDireccionamiento As EntidadDireccionamiento_BE) As DataTable

    <OperationContract()>
    Function GetAllEntidadDireccionamiento(oEntidadDireccionamiento As EntidadDireccionamiento_BE) As EntidadDireccionamiento_BE

#End Region

End Interface

' Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.

<DataContract()>
Public Class CompositeType

    <DataMember()>
    Public Property BoolValue() As Boolean
    <DataMember()>
    Public Property StringValue() As String

End Class

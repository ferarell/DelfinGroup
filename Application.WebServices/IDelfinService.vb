Imports System.ServiceModel
Imports Application.BusinessEntities

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "IDelfinService" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface IDelfinService

    <OperationContract()>
    Function ExecuteSQL(ByVal QueryString As String) As DataSet

    <OperationContract()>
    Function NewExecuteSQL(ByVal QueryString As String) As DataSet

    <OperationContract()>
    Function ExecuteSQLNonQuery(ByVal QueryString As String) As Boolean

    <OperationContract()>
    Function NewExecuteSQLNonQuery(ByVal QueryString As String) As ArrayList

    <OperationContract()>
    Function GetActiveDirectoryObjects(ByVal DirectoryEntry As String, ByVal DirectoryUserName As String) As DataSet

    <OperationContract()>
    Function UserValidation(ByVal DirectoryEntry As String, ByVal DirectoryUserName As String, ByVal DirectoryPassword As String, ByVal ErrorMessage As String) As String

    <OperationContract()>
    Function GenerateNextSisVoucher(ByVal Company As String, ByVal dsVoucher As DataSet) As ArrayList

    <OperationContract()>
    Function GenerateNextSisVoucherBCopy(ByVal Company As String, ByVal dsVoucher As DataSet) As ArrayList

    <OperationContract()>
    Function GenerateNextSoftVoucher(dtMovimiento As DataTable, dtCtaCte As DataTable) As ArrayList

    <OperationContract()>
    Function InsertarContribuyente(dtSource As DataTable) As ArrayList

    <OperationContract()>
    Function ActualizarContribuyente(dtSource As DataTable) As ArrayList

    <OperationContract()>
    Function UpdateTableWithBulkCopy(ByVal Table As String, ByVal dtSource As DataTable, ByVal ProcessType As String) As ArrayList

    <OperationContract()>
    Function UpdatingUsingTableAsParameter(ByVal StoreProcedure As String, ByVal dtSource As DataTable) As ArrayList

    <OperationContract()>
    Function UpdatingWithTableAndParameters(ByVal StoreProcedure As String, ByVal dtSource As DataTable, ByVal Params As ArrayList, ByVal Values As ArrayList) As ArrayList

    <OperationContract()>
    Function ExecuteStoreProcedure(sp_name As String, sp_parameters As List(Of List(Of String)), sp_type As String) As DataSet

#Region "Eventos"

    <OperationContract()>
    Function InsertEvento(oEvento As COM_Det_Cotizacion_OV_EventosTareas_BE) As COM_Det_Cotizacion_OV_EventosTareas_BE

    <OperationContract()>
    Sub UpdateEvento(oEvento As COM_Det_Cotizacion_OV_EventosTareas_BE)

    <OperationContract()>
    Sub DeleteEvento(oEvento As COM_Det_Cotizacion_OV_EventosTareas_BE)


#End Region

    <OperationContract>
    Function InsertLogisticOperation(dsLogisticOperation As DataSet) As ArrayList

    <OperationContract>
    Function UpdateLogisticOperation(dsLogisticOperation As DataSet, dtOriginalDetail As DataTable, dtOriginalChangeControl As DataTable) As ArrayList

End Interface

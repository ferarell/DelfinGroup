Imports System.ServiceModel
Imports Application.BusinessEntities

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "INextSoftService" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface INextSoftService

#Region "General"

    <OperationContract()>
    Function ExecuteSQL(ByVal QueryString As String) As DataSet

    <OperationContract()>
    Function ExecuteSQLNonQuery(ByVal QueryString As String) As ArrayList

#End Region

#Region "COM_Sobrestadia"

    <OperationContract()>
    Function InsertSobrestadia(oSobrestadiaBE As COM_Sobrestadia_BE) As Boolean

    <OperationContract()>
    Function UpdateSobrestadia(oSobrestadiaBE As COM_Sobrestadia_BE) As Boolean

    <OperationContract()>
    Function DeleteSobrestadia(oSobrestadiaBE As COM_Sobrestadia_BE) As Boolean

    <OperationContract()>
    Function GetAllSobrestadia(oSobrestadiaBE As COM_Sobrestadia_BE) As COM_Sobrestadia_BE

    <OperationContract()>
    Function GetSobrestadiaByFilter(oSobrestadiaBE As COM_Sobrestadia_BE) As DataTable

#End Region

#Region "COM_DetSobrestadia"

    <OperationContract()>
    Function InsertDetSobrestadia(oDetSobrestadiaBE As COM_DetSobrestadia_BE) As Boolean

    <OperationContract()>
    Function UpdateDetSobrestadia(oDetSobrestadiaBE As COM_DetSobrestadia_BE) As Boolean

    <OperationContract()>
    Function DeleteDetSobrestadia(oDetSobrestadiaBE As COM_DetSobrestadia_BE) As Boolean

    <OperationContract()>
    Function GetAllDetSobrestadia(oDetSobrestadiaBE As COM_DetSobrestadia_BE) As COM_DetSobrestadia_BE

    <OperationContract()>
    Function GetDetSobrestadiaByFilter(oDetSobrestadiaBE As COM_DetSobrestadia_BE) As DataTable

#End Region

End Interface

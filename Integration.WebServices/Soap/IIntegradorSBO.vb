Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "IIntegradorSBO" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface IIntegradorSBO

    <OperationContract()>
    Function InsertarActualizarServicio(dsServicio As DataSet) As List(Of Respuesta)
	
	<OperationContract()>
    Function InsertarActualizarSocioNegocio(dsCliente As DataSet) As List(Of Respuesta)

    <OperationContract()>
    Function InsertarActualizarReferencias(dsReferencias As DataSet) As List(Of Respuesta)

    <OperationContract()>
    Function InsertarActualizarJournalEntry(dsJournalEntry As DataSet) As List(Of Respuesta)

    <OperationContract()>
    Function InsertarActualizarInvoiceBills(dsInvoiceBills As DataSet) As List(Of Respuesta)

    <OperationContract()>
    Function InsertarActualizarCreditMemo(dsCreditMemo As DataSet) As List(Of Respuesta)




End Interface

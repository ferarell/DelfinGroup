﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.42000
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Runtime.Serialization

Namespace IntegrationService
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute(Name:="Respuesta", [Namespace]:="http://schemas.datacontract.org/2004/07/IntegrationServicesRest"),  _
     System.SerializableAttribute()>  _
    Partial Public Class Respuesta
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
        
        <System.NonSerializedAttribute()>  _
        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private ItemCodeField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private ResponseField() As IntegrationService.Response
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private ResponseStatusField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private RespuestaNexsoftField As Integer
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private RespuestaSAPField As Integer
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private SWWField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private ValueField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private dField As IntegrationService.d
        
        <Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
            Get
                Return Me.extensionDataField
            End Get
            Set
                Me.extensionDataField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property ItemCode() As String
            Get
                Return Me.ItemCodeField
            End Get
            Set
                If (Object.ReferenceEquals(Me.ItemCodeField, value) <> true) Then
                    Me.ItemCodeField = value
                    Me.RaisePropertyChanged("ItemCode")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Response() As IntegrationService.Response()
            Get
                Return Me.ResponseField
            End Get
            Set
                If (Object.ReferenceEquals(Me.ResponseField, value) <> true) Then
                    Me.ResponseField = value
                    Me.RaisePropertyChanged("Response")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property ResponseStatus() As String
            Get
                Return Me.ResponseStatusField
            End Get
            Set
                If (Object.ReferenceEquals(Me.ResponseStatusField, value) <> true) Then
                    Me.ResponseStatusField = value
                    Me.RaisePropertyChanged("ResponseStatus")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property RespuestaNexsoft() As Integer
            Get
                Return Me.RespuestaNexsoftField
            End Get
            Set
                If (Me.RespuestaNexsoftField.Equals(value) <> true) Then
                    Me.RespuestaNexsoftField = value
                    Me.RaisePropertyChanged("RespuestaNexsoft")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property RespuestaSAP() As Integer
            Get
                Return Me.RespuestaSAPField
            End Get
            Set
                If (Me.RespuestaSAPField.Equals(value) <> true) Then
                    Me.RespuestaSAPField = value
                    Me.RaisePropertyChanged("RespuestaSAP")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property SWW() As String
            Get
                Return Me.SWWField
            End Get
            Set
                If (Object.ReferenceEquals(Me.SWWField, value) <> true) Then
                    Me.SWWField = value
                    Me.RaisePropertyChanged("SWW")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Value() As String
            Get
                Return Me.ValueField
            End Get
            Set
                If (Object.ReferenceEquals(Me.ValueField, value) <> true) Then
                    Me.ValueField = value
                    Me.RaisePropertyChanged("Value")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property d() As IntegrationService.d
            Get
                Return Me.dField
            End Get
            Set
                If (Object.ReferenceEquals(Me.dField, value) <> true) Then
                    Me.dField = value
                    Me.RaisePropertyChanged("d")
                End If
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute(Name:="d", [Namespace]:="http://schemas.datacontract.org/2004/07/IntegrationServicesRest"),  _
     System.SerializableAttribute()>  _
    Partial Public Class d
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
        
        <System.NonSerializedAttribute()>  _
        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private resultsField() As IntegrationService.results
        
        <Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
            Get
                Return Me.extensionDataField
            End Get
            Set
                Me.extensionDataField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property results() As IntegrationService.results()
            Get
                Return Me.resultsField
            End Get
            Set
                If (Object.ReferenceEquals(Me.resultsField, value) <> true) Then
                    Me.resultsField = value
                    Me.RaisePropertyChanged("results")
                End If
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute(Name:="Response", [Namespace]:="http://schemas.datacontract.org/2004/07/IntegrationServicesRest"),  _
     System.SerializableAttribute()>  _
    Partial Public Class Response
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
        
        <System.NonSerializedAttribute()>  _
        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private DocEntryField As Integer
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private DocNumField As Integer
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private JdtNumField As Integer
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private NumberField As Integer
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private errorField As IntegrationService.Wrong
        
        <Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
            Get
                Return Me.extensionDataField
            End Get
            Set
                Me.extensionDataField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property DocEntry() As Integer
            Get
                Return Me.DocEntryField
            End Get
            Set
                If (Me.DocEntryField.Equals(value) <> true) Then
                    Me.DocEntryField = value
                    Me.RaisePropertyChanged("DocEntry")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property DocNum() As Integer
            Get
                Return Me.DocNumField
            End Get
            Set
                If (Me.DocNumField.Equals(value) <> true) Then
                    Me.DocNumField = value
                    Me.RaisePropertyChanged("DocNum")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property JdtNum() As Integer
            Get
                Return Me.JdtNumField
            End Get
            Set
                If (Me.JdtNumField.Equals(value) <> true) Then
                    Me.JdtNumField = value
                    Me.RaisePropertyChanged("JdtNum")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Number() As Integer
            Get
                Return Me.NumberField
            End Get
            Set
                If (Me.NumberField.Equals(value) <> true) Then
                    Me.NumberField = value
                    Me.RaisePropertyChanged("Number")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property [error]() As IntegrationService.Wrong
            Get
                Return Me.errorField
            End Get
            Set
                If (Object.ReferenceEquals(Me.errorField, value) <> true) Then
                    Me.errorField = value
                    Me.RaisePropertyChanged("error")
                End If
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute(Name:="Wrong", [Namespace]:="http://schemas.datacontract.org/2004/07/IntegrationServicesRest"),  _
     System.SerializableAttribute()>  _
    Partial Public Class Wrong
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
        
        <System.NonSerializedAttribute()>  _
        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private CodeField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private MessageField As IntegrationService.Message
        
        <Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
            Get
                Return Me.extensionDataField
            End Get
            Set
                Me.extensionDataField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Code() As String
            Get
                Return Me.CodeField
            End Get
            Set
                If (Object.ReferenceEquals(Me.CodeField, value) <> true) Then
                    Me.CodeField = value
                    Me.RaisePropertyChanged("Code")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Message() As IntegrationService.Message
            Get
                Return Me.MessageField
            End Get
            Set
                If (Object.ReferenceEquals(Me.MessageField, value) <> true) Then
                    Me.MessageField = value
                    Me.RaisePropertyChanged("Message")
                End If
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute(Name:="Message", [Namespace]:="http://schemas.datacontract.org/2004/07/IntegrationServicesRest"),  _
     System.SerializableAttribute()>  _
    Partial Public Class Message
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
        
        <System.NonSerializedAttribute()>  _
        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private LangField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private ValueField As String
        
        <Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
            Get
                Return Me.extensionDataField
            End Get
            Set
                Me.extensionDataField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Lang() As String
            Get
                Return Me.LangField
            End Get
            Set
                If (Object.ReferenceEquals(Me.LangField, value) <> true) Then
                    Me.LangField = value
                    Me.RaisePropertyChanged("Lang")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Value() As String
            Get
                Return Me.ValueField
            End Get
            Set
                If (Object.ReferenceEquals(Me.ValueField, value) <> true) Then
                    Me.ValueField = value
                    Me.RaisePropertyChanged("Value")
                End If
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute(Name:="results", [Namespace]:="http://schemas.datacontract.org/2004/07/IntegrationServicesRest"),  _
     System.SerializableAttribute()>  _
    Partial Public Class results
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
        
        <System.NonSerializedAttribute()>  _
        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private DocEntryField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private FolioNumField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private FolioPrefField As String
        
        <Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
            Get
                Return Me.extensionDataField
            End Get
            Set
                Me.extensionDataField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property DocEntry() As String
            Get
                Return Me.DocEntryField
            End Get
            Set
                If (Object.ReferenceEquals(Me.DocEntryField, value) <> true) Then
                    Me.DocEntryField = value
                    Me.RaisePropertyChanged("DocEntry")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property FolioNum() As String
            Get
                Return Me.FolioNumField
            End Get
            Set
                If (Object.ReferenceEquals(Me.FolioNumField, value) <> true) Then
                    Me.FolioNumField = value
                    Me.RaisePropertyChanged("FolioNum")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property FolioPref() As String
            Get
                Return Me.FolioPrefField
            End Get
            Set
                If (Object.ReferenceEquals(Me.FolioPrefField, value) <> true) Then
                    Me.FolioPrefField = value
                    Me.RaisePropertyChanged("FolioPref")
                End If
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="IntegrationService.IIntegradorSBO")>  _
    Public Interface IIntegradorSBO
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IIntegradorSBO/InsertarActualizarServicio", ReplyAction:="http://tempuri.org/IIntegradorSBO/InsertarActualizarServicioResponse")>  _
        Function InsertarActualizarServicio(ByVal dsServicio As System.Data.DataSet) As IntegrationService.Respuesta()
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IIntegradorSBO/InsertarActualizarServicio", ReplyAction:="http://tempuri.org/IIntegradorSBO/InsertarActualizarServicioResponse")>  _
        Function InsertarActualizarServicioAsync(ByVal dsServicio As System.Data.DataSet) As System.Threading.Tasks.Task(Of IntegrationService.Respuesta())
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IIntegradorSBO/InsertarActualizarSocioNegocio", ReplyAction:="http://tempuri.org/IIntegradorSBO/InsertarActualizarSocioNegocioResponse")>  _
        Function InsertarActualizarSocioNegocio(ByVal dsCliente As System.Data.DataSet) As IntegrationService.Respuesta()
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IIntegradorSBO/InsertarActualizarSocioNegocio", ReplyAction:="http://tempuri.org/IIntegradorSBO/InsertarActualizarSocioNegocioResponse")>  _
        Function InsertarActualizarSocioNegocioAsync(ByVal dsCliente As System.Data.DataSet) As System.Threading.Tasks.Task(Of IntegrationService.Respuesta())
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IIntegradorSBO/InsertarActualizarReferencias", ReplyAction:="http://tempuri.org/IIntegradorSBO/InsertarActualizarReferenciasResponse")>  _
        Function InsertarActualizarReferencias(ByVal dsReferencias As System.Data.DataSet) As IntegrationService.Respuesta()
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IIntegradorSBO/InsertarActualizarReferencias", ReplyAction:="http://tempuri.org/IIntegradorSBO/InsertarActualizarReferenciasResponse")>  _
        Function InsertarActualizarReferenciasAsync(ByVal dsReferencias As System.Data.DataSet) As System.Threading.Tasks.Task(Of IntegrationService.Respuesta())
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IIntegradorSBO/InsertarActualizarJournalEntry", ReplyAction:="http://tempuri.org/IIntegradorSBO/InsertarActualizarJournalEntryResponse")>  _
        Function InsertarActualizarJournalEntry(ByVal dsJournalEntry As System.Data.DataSet) As IntegrationService.Respuesta()
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IIntegradorSBO/InsertarActualizarJournalEntry", ReplyAction:="http://tempuri.org/IIntegradorSBO/InsertarActualizarJournalEntryResponse")>  _
        Function InsertarActualizarJournalEntryAsync(ByVal dsJournalEntry As System.Data.DataSet) As System.Threading.Tasks.Task(Of IntegrationService.Respuesta())
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IIntegradorSBO/InsertarActualizarInvoiceBills", ReplyAction:="http://tempuri.org/IIntegradorSBO/InsertarActualizarInvoiceBillsResponse")>  _
        Function InsertarActualizarInvoiceBills(ByVal dsInvoiceBills As System.Data.DataSet) As IntegrationService.Respuesta()
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IIntegradorSBO/InsertarActualizarInvoiceBills", ReplyAction:="http://tempuri.org/IIntegradorSBO/InsertarActualizarInvoiceBillsResponse")>  _
        Function InsertarActualizarInvoiceBillsAsync(ByVal dsInvoiceBills As System.Data.DataSet) As System.Threading.Tasks.Task(Of IntegrationService.Respuesta())
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IIntegradorSBO/InsertarActualizarCreditMemo", ReplyAction:="http://tempuri.org/IIntegradorSBO/InsertarActualizarCreditMemoResponse")>  _
        Function InsertarActualizarCreditMemo(ByVal dsCreditMemo As System.Data.DataSet) As IntegrationService.Respuesta()
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IIntegradorSBO/InsertarActualizarCreditMemo", ReplyAction:="http://tempuri.org/IIntegradorSBO/InsertarActualizarCreditMemoResponse")>  _
        Function InsertarActualizarCreditMemoAsync(ByVal dsCreditMemo As System.Data.DataSet) As System.Threading.Tasks.Task(Of IntegrationService.Respuesta())
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IIntegradorSBO/InsertarActualizarPurchaseInvoice", ReplyAction:="http://tempuri.org/IIntegradorSBO/InsertarActualizarPurchaseInvoiceResponse")>  _
        Function InsertarActualizarPurchaseInvoice(ByVal dsPurchaseInvoice As System.Data.DataSet) As IntegrationService.Respuesta()
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IIntegradorSBO/InsertarActualizarPurchaseInvoice", ReplyAction:="http://tempuri.org/IIntegradorSBO/InsertarActualizarPurchaseInvoiceResponse")>  _
        Function InsertarActualizarPurchaseInvoiceAsync(ByVal dsPurchaseInvoice As System.Data.DataSet) As System.Threading.Tasks.Task(Of IntegrationService.Respuesta())
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IIntegradorSBO/InsertarActualizarPurchaseCreditMemo", ReplyAction:="http://tempuri.org/IIntegradorSBO/InsertarActualizarPurchaseCreditMemoResponse")>  _
        Function InsertarActualizarPurchaseCreditMemo(ByVal PurchaseCreditMemo As System.Data.DataSet) As IntegrationService.Respuesta()
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IIntegradorSBO/InsertarActualizarPurchaseCreditMemo", ReplyAction:="http://tempuri.org/IIntegradorSBO/InsertarActualizarPurchaseCreditMemoResponse")>  _
        Function InsertarActualizarPurchaseCreditMemoAsync(ByVal PurchaseCreditMemo As System.Data.DataSet) As System.Threading.Tasks.Task(Of IntegrationService.Respuesta())
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IIntegradorSBO/VerificarExistenciaDocumento", ReplyAction:="http://tempuri.org/IIntegradorSBO/VerificarExistenciaDocumentoResponse")>  _
        Function VerificarExistenciaDocumento(ByVal CompraVenta As String, ByVal TipoDocumento As String, ByVal Serie As String, ByVal Numero As String) As String
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IIntegradorSBO/VerificarExistenciaDocumento", ReplyAction:="http://tempuri.org/IIntegradorSBO/VerificarExistenciaDocumentoResponse")>  _
        Function VerificarExistenciaDocumentoAsync(ByVal CompraVenta As String, ByVal TipoDocumento As String, ByVal Serie As String, ByVal Numero As String) As System.Threading.Tasks.Task(Of String)
    End Interface
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface IIntegradorSBOChannel
        Inherits IntegrationService.IIntegradorSBO, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class IntegradorSBOClient
        Inherits System.ServiceModel.ClientBase(Of IntegrationService.IIntegradorSBO)
        Implements IntegrationService.IIntegradorSBO
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        Public Function InsertarActualizarServicio(ByVal dsServicio As System.Data.DataSet) As IntegrationService.Respuesta() Implements IntegrationService.IIntegradorSBO.InsertarActualizarServicio
            Return MyBase.Channel.InsertarActualizarServicio(dsServicio)
        End Function
        
        Public Function InsertarActualizarServicioAsync(ByVal dsServicio As System.Data.DataSet) As System.Threading.Tasks.Task(Of IntegrationService.Respuesta()) Implements IntegrationService.IIntegradorSBO.InsertarActualizarServicioAsync
            Return MyBase.Channel.InsertarActualizarServicioAsync(dsServicio)
        End Function
        
        Public Function InsertarActualizarSocioNegocio(ByVal dsCliente As System.Data.DataSet) As IntegrationService.Respuesta() Implements IntegrationService.IIntegradorSBO.InsertarActualizarSocioNegocio
            Return MyBase.Channel.InsertarActualizarSocioNegocio(dsCliente)
        End Function
        
        Public Function InsertarActualizarSocioNegocioAsync(ByVal dsCliente As System.Data.DataSet) As System.Threading.Tasks.Task(Of IntegrationService.Respuesta()) Implements IntegrationService.IIntegradorSBO.InsertarActualizarSocioNegocioAsync
            Return MyBase.Channel.InsertarActualizarSocioNegocioAsync(dsCliente)
        End Function
        
        Public Function InsertarActualizarReferencias(ByVal dsReferencias As System.Data.DataSet) As IntegrationService.Respuesta() Implements IntegrationService.IIntegradorSBO.InsertarActualizarReferencias
            Return MyBase.Channel.InsertarActualizarReferencias(dsReferencias)
        End Function
        
        Public Function InsertarActualizarReferenciasAsync(ByVal dsReferencias As System.Data.DataSet) As System.Threading.Tasks.Task(Of IntegrationService.Respuesta()) Implements IntegrationService.IIntegradorSBO.InsertarActualizarReferenciasAsync
            Return MyBase.Channel.InsertarActualizarReferenciasAsync(dsReferencias)
        End Function
        
        Public Function InsertarActualizarJournalEntry(ByVal dsJournalEntry As System.Data.DataSet) As IntegrationService.Respuesta() Implements IntegrationService.IIntegradorSBO.InsertarActualizarJournalEntry
            Return MyBase.Channel.InsertarActualizarJournalEntry(dsJournalEntry)
        End Function
        
        Public Function InsertarActualizarJournalEntryAsync(ByVal dsJournalEntry As System.Data.DataSet) As System.Threading.Tasks.Task(Of IntegrationService.Respuesta()) Implements IntegrationService.IIntegradorSBO.InsertarActualizarJournalEntryAsync
            Return MyBase.Channel.InsertarActualizarJournalEntryAsync(dsJournalEntry)
        End Function
        
        Public Function InsertarActualizarInvoiceBills(ByVal dsInvoiceBills As System.Data.DataSet) As IntegrationService.Respuesta() Implements IntegrationService.IIntegradorSBO.InsertarActualizarInvoiceBills
            Return MyBase.Channel.InsertarActualizarInvoiceBills(dsInvoiceBills)
        End Function
        
        Public Function InsertarActualizarInvoiceBillsAsync(ByVal dsInvoiceBills As System.Data.DataSet) As System.Threading.Tasks.Task(Of IntegrationService.Respuesta()) Implements IntegrationService.IIntegradorSBO.InsertarActualizarInvoiceBillsAsync
            Return MyBase.Channel.InsertarActualizarInvoiceBillsAsync(dsInvoiceBills)
        End Function
        
        Public Function InsertarActualizarCreditMemo(ByVal dsCreditMemo As System.Data.DataSet) As IntegrationService.Respuesta() Implements IntegrationService.IIntegradorSBO.InsertarActualizarCreditMemo
            Return MyBase.Channel.InsertarActualizarCreditMemo(dsCreditMemo)
        End Function
        
        Public Function InsertarActualizarCreditMemoAsync(ByVal dsCreditMemo As System.Data.DataSet) As System.Threading.Tasks.Task(Of IntegrationService.Respuesta()) Implements IntegrationService.IIntegradorSBO.InsertarActualizarCreditMemoAsync
            Return MyBase.Channel.InsertarActualizarCreditMemoAsync(dsCreditMemo)
        End Function
        
        Public Function InsertarActualizarPurchaseInvoice(ByVal dsPurchaseInvoice As System.Data.DataSet) As IntegrationService.Respuesta() Implements IntegrationService.IIntegradorSBO.InsertarActualizarPurchaseInvoice
            Return MyBase.Channel.InsertarActualizarPurchaseInvoice(dsPurchaseInvoice)
        End Function
        
        Public Function InsertarActualizarPurchaseInvoiceAsync(ByVal dsPurchaseInvoice As System.Data.DataSet) As System.Threading.Tasks.Task(Of IntegrationService.Respuesta()) Implements IntegrationService.IIntegradorSBO.InsertarActualizarPurchaseInvoiceAsync
            Return MyBase.Channel.InsertarActualizarPurchaseInvoiceAsync(dsPurchaseInvoice)
        End Function
        
        Public Function InsertarActualizarPurchaseCreditMemo(ByVal PurchaseCreditMemo As System.Data.DataSet) As IntegrationService.Respuesta() Implements IntegrationService.IIntegradorSBO.InsertarActualizarPurchaseCreditMemo
            Return MyBase.Channel.InsertarActualizarPurchaseCreditMemo(PurchaseCreditMemo)
        End Function
        
        Public Function InsertarActualizarPurchaseCreditMemoAsync(ByVal PurchaseCreditMemo As System.Data.DataSet) As System.Threading.Tasks.Task(Of IntegrationService.Respuesta()) Implements IntegrationService.IIntegradorSBO.InsertarActualizarPurchaseCreditMemoAsync
            Return MyBase.Channel.InsertarActualizarPurchaseCreditMemoAsync(PurchaseCreditMemo)
        End Function
        
        Public Function VerificarExistenciaDocumento(ByVal CompraVenta As String, ByVal TipoDocumento As String, ByVal Serie As String, ByVal Numero As String) As String Implements IntegrationService.IIntegradorSBO.VerificarExistenciaDocumento
            Return MyBase.Channel.VerificarExistenciaDocumento(CompraVenta, TipoDocumento, Serie, Numero)
        End Function
        
        Public Function VerificarExistenciaDocumentoAsync(ByVal CompraVenta As String, ByVal TipoDocumento As String, ByVal Serie As String, ByVal Numero As String) As System.Threading.Tasks.Task(Of String) Implements IntegrationService.IIntegradorSBO.VerificarExistenciaDocumentoAsync
            Return MyBase.Channel.VerificarExistenciaDocumentoAsync(CompraVenta, TipoDocumento, Serie, Numero)
        End Function
    End Class
End Namespace

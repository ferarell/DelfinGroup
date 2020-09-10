Imports System.Threading
Imports DevExpress.XtraEditors.DXErrorProvider

Public Class QuoteRequestForm
    Private oAppService As New OnlineService.OnLineServiceClient
    Dim oMasterDataList As New MasterDataList
    Dim tProcess As Thread = Nothing

    Private Sub QuoteRequestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'tProcess = New Thread(Sub() FillDropDownListBox())
        'tProcess.Start()
        FillDropDownListBox()
    End Sub

    Private Sub FillDropDownListBox()
        LoadServiceCompany()
        LoadDocumentType()
        LoadOriginCountry()
        LoadDestinationCountry()
        LoadEquipmentType()
        LoadIncoterm()
        LoadPackingType()
        LoadCargoType()
        LoadCommodity()
    End Sub

    Private Sub LoadServiceCompany()
        Dim dtSource As New DataTable
        dtSource = oMasterDataList.LoadMasterData("ServiceCompany")
        lueServiceCompany.Properties.DataSource = dtSource
        lueServiceCompany.Properties.DisplayMember = "ServiceDescription"
        lueServiceCompany.Properties.ValueMember = "ServiceDescription"
    End Sub

    Private Sub LoadDocumentType()
        Dim dtSource As New DataTable
        dtSource = oMasterDataList.LoadMasterData("DocumentType")
        lueDocumentType.Properties.DataSource = dtSource
        lueDocumentType.Properties.DisplayMember = "DescripcionTipoDocumento"
        lueDocumentType.Properties.ValueMember = "CodigoTipoDocumento"
    End Sub

    Private Sub LoadOriginCountry()
        Dim dtSource As New DataTable
        dtSource = oMasterDataList.LoadMasterData("OriginCountry")
        lueOriginCountry.Properties.DataSource = dtSource
        lueOriginCountry.Properties.DisplayMember = "NombrePais"
        lueOriginCountry.Properties.ValueMember = "NombrePais"
    End Sub

    Private Sub LoadOriginPort(CodPais As String)
        Dim dtSource As New DataTable
        dtSource = oAppService.ExecuteSQL("EXEC NextSoft.dgp.paListaPuerto '" & CodPais & "'").Tables(0)
        lueOriginPort.Properties.DataSource = dtSource
        lueOriginPort.Properties.DisplayMember = "NombrePuerto"
        lueOriginPort.Properties.ValueMember = "NombrePuerto"
    End Sub

    Private Sub LoadDestinationCountry()
        Dim dtSource As New DataTable
        lueDestinationCountry.Properties.DataSource = lueOriginCountry.Properties.DataSource
        lueDestinationCountry.Properties.DisplayMember = "NombrePais"
        lueDestinationCountry.Properties.ValueMember = "NombrePais"
    End Sub

    Private Sub LoadDestinationPort(CodPais As String)
        Dim dtSource As New DataTable
        dtSource = oAppService.ExecuteSQL("EXEC NextSoft.dgp.paListaPuerto '" & CodPais & "'").Tables(0)
        lueDestinationPort.Properties.DataSource = dtSource
        lueDestinationPort.Properties.DisplayMember = "NombrePuerto"
        lueDestinationPort.Properties.ValueMember = "NombrePuerto"
    End Sub

    Private Sub LoadEquipmentType()
        Dim dtSource As New DataTable
        dtSource = oMasterDataList.LoadMasterData("EquipmentType")
        lueEquipmentType.Properties.DataSource = dtSource
        lueEquipmentType.Properties.DisplayMember = "DescripcionTipoEquipo"
        lueEquipmentType.Properties.ValueMember = "DescripcionTipoEquipo"
    End Sub

    Private Sub LoadIncoterm()
        Dim dtSource As New DataTable
        dtSource = oMasterDataList.LoadMasterData("Incoterm")
        lueIncoterm.Properties.DataSource = dtSource
        lueIncoterm.Properties.DisplayMember = "DescripcionIncoterm"
        lueIncoterm.Properties.ValueMember = "DescripcionIncoterm"
    End Sub

    Private Sub LoadPackingType()
        Dim dtSource As New DataTable
        dtSource = oMasterDataList.LoadMasterData("PackingType")
        luePackingType.Properties.DataSource = dtSource
        luePackingType.Properties.DisplayMember = "DescripcionTipoEmbalaje"
        luePackingType.Properties.ValueMember = "DescripcionTipoEmbalaje"
    End Sub

    Private Sub LoadCargoType()
        Dim dtSource As New DataTable
        dtSource = oMasterDataList.LoadMasterData("CargoCondition")
        lueCargoCondition.Properties.DataSource = dtSource
        lueCargoCondition.Properties.DisplayMember = "DescripcionCondicionEmbarque"
        lueCargoCondition.Properties.ValueMember = "DescripcionCondicionEmbarque"
    End Sub

    Private Sub LoadCommodity()
        Dim dtSource As New DataTable
        dtSource = oMasterDataList.LoadMasterData("Commodity")
        lueCommodity.Properties.DataSource = dtSource
        lueCommodity.Properties.DisplayMember = "DescripcionTipoCommodity"
        lueCommodity.Properties.ValueMember = "DescripcionTipoCommodity"
    End Sub

    Private Sub bbiSendMail_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSendMail.ItemClick
        LoadInputValidations()
        If Not vpInputs.Validate Then
            Return
        End If
        Dim dtMail As New DataTable
        Dim sCommerceType As String = IIf(lueOriginCountry.EditValue = "PE", "E", "I")
        dtMail = oAppService.ExecuteSQL("EXEC NextSoft.web.upGetMailCompanyService '" & lueDocumentType.EditValue & "','" & sCommerceType & "'").Tables(0)

    End Sub

    Private Sub LoadInputValidations()
        Validate()
        Dim containsValidationRule As New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        containsValidationRule.ConditionOperator = ConditionOperator.IsNotBlank
        containsValidationRule.ErrorText = "Asigne un valor."
        containsValidationRule.ErrorType = ErrorType.Critical
        Dim customValidationRule As New CustomValidationRule()
        customValidationRule.ErrorText = "Valor obligatorio."
        customValidationRule.ErrorType = ErrorType.Critical
        vpInputs.SetValidationRule(Me.lueServiceCompany, customValidationRule)
        vpInputs.SetValidationRule(Me.lueDocumentType, customValidationRule)
        vpInputs.SetValidationRule(Me.teDocumentNumber, customValidationRule)
        vpInputs.SetValidationRule(Me.teCompany, customValidationRule)
        vpInputs.SetValidationRule(Me.teContactName, customValidationRule)
        vpInputs.SetValidationRule(Me.teMail, customValidationRule)
        vpInputs.SetValidationRule(Me.tePhone, customValidationRule)
        vpInputs.SetValidationRule(Me.lueOriginCountry, customValidationRule)
        vpInputs.SetValidationRule(Me.lueOriginPort, customValidationRule)
        vpInputs.SetValidationRule(Me.lueDestinationCountry, customValidationRule)
        vpInputs.SetValidationRule(Me.lueDestinationPort, customValidationRule)
        vpInputs.SetValidationRule(Me.lueEquipmentType, customValidationRule)
        vpInputs.SetValidationRule(Me.seQuantity, customValidationRule)
        vpInputs.SetValidationRule(Me.lueIncoterm, customValidationRule)
        vpInputs.SetValidationRule(Me.lueCargoCondition, customValidationRule)
        vpInputs.SetValidationRule(Me.lueCommodity, customValidationRule)
        vpInputs.SetValidationRule(Me.seWeight, customValidationRule)
        vpInputs.SetValidationRule(Me.seHeigth, customValidationRule)
        vpInputs.SetValidationRule(Me.seLarge, customValidationRule)
        vpInputs.SetValidationRule(Me.seWidth, customValidationRule)
        vpInputs.SetValidationRule(Me.seVolume, customValidationRule)
    End Sub

    Private Sub bbiClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiClose.ItemClick
        Close()
    End Sub

    Private Sub lueOriginCountry_EditValueChanged(sender As Object, e As EventArgs) Handles lueOriginCountry.EditValueChanged
        LoadOriginPort(lueOriginCountry.EditValue)
    End Sub

    Private Sub teDocumentNumber_EditValueChanged(sender As Object, e As EventArgs) Handles teDocumentNumber.EditValueChanged
        Validate()
        Dim dtQuery As New DataTable
        If teDocumentNumber.EditValue <> "" Then
            dtQuery = oAppService.CustomerDocumentQuery(lueDocumentType.EditValue, teDocumentNumber.EditValue)
            If dtQuery.Rows.Count > 0 Then
                teCompany.EditValue = dtQuery.Rows(0)("RazonSocial")
                teMail.EditValue = dtQuery.Rows(0)("EMail")
                tePhone.EditValue = dtQuery.Rows(0)("Telef1")
            End If
        End If
    End Sub

    Private Sub lueDestinationCountry_EditValueChanged(sender As Object, e As EventArgs) Handles lueDestinationCountry.EditValueChanged
        LoadDestinationPort(lueDestinationCountry.EditValue)
    End Sub
End Class
Imports DevExpress.XtraEditors.DXErrorProvider
Imports WebTesting.OnlineService

Public Class RelatedCompanyRequestForm
    Private oAppService As New OnlineService.OnLineServiceClient
    Dim oMasterDataList As New MasterDataList
    Dim oRelatedCompanyBE As New EntidadVinculada_BE
    Dim dtSource As New DataTable

    Private Sub RelatedCompanyRequestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetRelatedCompany
        LoadDocumentType()
        LoadRelationType()
        LoadValidityType()
    End Sub

    Private Sub bbiSendMail_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSendMail.ItemClick
        LoadInputValidations()
        If Not vpInputs.Validate Then
            Return
        End If
        'Enviar Correo
        If dtSource.Select("ENTC_DocIden='" & teDocumentNumber.Text & "'").Length = 0 Then
            RelatedCompanyRegister()
        Else
            RelatedCompanyUpdate(dtSource.Select("ENTC_DocIden='" & teDocumentNumber.Text & "'")(0))
        End If
        GetRelatedCompany()
        DevExpress.XtraEditors.XtraMessageBox.Show("La solicitud ha sido registrada satisfactoriamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub bbiClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiClose.ItemClick
        Close()
    End Sub

    Private Sub RelatedCompanyRegister()
        oRelatedCompanyBE.ENTC_Codigo = ENTC_Codigo
        oRelatedCompanyBE.ENTC_CodigoVinculada = GetCustomerCode(teDocumentNumber.EditValue)
        oRelatedCompanyBE.NombreContacto = teContactName.Text
        oRelatedCompanyBE.CorreoContacto = teMail.Text
        oRelatedCompanyBE.CodigoTipoVinculacion = lueRelationType.EditValue
        oRelatedCompanyBE.CodigoTipoVigencia = lueValidityType.EditValue
        If lueValidityType.GetColumnValue("ValidaFechas") = True Then
            oRelatedCompanyBE.VigenciaDesde = deDateFrom.EditValue
            oRelatedCompanyBE.VigenciaHasta = deDateTo.EditValue
        End If
        oRelatedCompanyBE.Estado = "P"
        oRelatedCompanyBE.AUDI_UsrCrea = AppUser
        oRelatedCompanyBE.AUDI_FecCrea = Now
        Try
            oAppService.InsertRelatedCompany(oRelatedCompanyBE)
        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show("Se generó un error al registrar la solicitud. " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Finally
            DevExpress.XtraEditors.XtraMessageBox.Show("La solicituda ha sido registrada satisfactoriamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub RelatedCompanyUpdate(drSource As DataRow)
        If drSource("Estado") = "A" Then
            DevExpress.XtraEditors.XtraMessageBox.Show("No se puede actualizar una vinculación aprobada. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If DevExpress.XtraEditors.XtraMessageBox.Show("La solicitud para una empresa existente actualizará los datos y quedará en estado PENDIENTE, desea continuar? ", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.No Then
            Return
        End If
        oRelatedCompanyBE.ENTC_Codigo = ENTC_Codigo
        oRelatedCompanyBE.ENTC_CodigoVinculada = GetCustomerCode(teDocumentNumber.EditValue)
        oRelatedCompanyBE.NombreContacto = teContactName.Text
        oRelatedCompanyBE.CorreoContacto = teMail.Text
        oRelatedCompanyBE.CodigoTipoVinculacion = lueRelationType.EditValue
        oRelatedCompanyBE.CodigoTipoVigencia = lueValidityType.EditValue
        If lueValidityType.GetColumnValue("ValidaFechas") = True Then
            oRelatedCompanyBE.VigenciaDesde = deDateFrom.EditValue
            oRelatedCompanyBE.VigenciaHasta = deDateTo.EditValue
        End If
        oRelatedCompanyBE.Estado = "P"
        oRelatedCompanyBE.AUDI_UsrMod = AppUser
        oRelatedCompanyBE.AUDI_FecMod = Now
        Try
            oAppService.UpdateRelatedCompany(oRelatedCompanyBE)
        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show("Se generó un error al actualizar la solicitud. " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Finally
            DevExpress.XtraEditors.XtraMessageBox.Show("La solicituda ha sido actualizada satisfactoriamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Function GetCustomerCode(DocIden As String) As Integer
        Dim iResult As Integer = 0
        Dim dtQuery As New DataTable
        dtQuery = oAppService.ExecuteSQL("SELECT ENTC_Codigo FROM NextSoft.dbo.Entidad (NOLOCK) WHERE ENTC_DocIden='" & DocIden & "'").Tables(0)
        iResult = dtQuery.Rows(0)(0)
        Return iResult
    End Function

    Private Sub GetRelatedCompany()
        dtSource.Clear()
        oRelatedCompanyBE.ENTC_Codigo = ENTC_Codigo
        dtSource = oAppService.GetAllDataTableRelatedCompany(oRelatedCompanyBE)
        gcMainData.DataSource = dtSource
    End Sub

    Private Sub LoadDocumentType()
        Dim dtSource As New DataTable
        dtSource = oAppService.GetDataList("DocumentType", Nothing)
        lueDocumentType.Properties.DataSource = dtSource
        lueDocumentType.Properties.DisplayMember = "DescripcionTipoDocumento"
        lueDocumentType.Properties.ValueMember = "CodigoTipoDocumento"
    End Sub

    Private Sub LoadRelationType()
        Dim dtSource As New DataTable
        dtSource = oMasterDataList.LoadMasterData("RelationType")
        lueRelationType.Properties.DataSource = dtSource
        lueRelationType.Properties.DisplayMember = "DescripcionTipoVinculacion"
        lueRelationType.Properties.ValueMember = "CodigoTipoVinculacion"
    End Sub

    Private Sub LoadValidityType()
        Dim dtSource As New DataTable
        dtSource = oMasterDataList.LoadMasterData("ValidityType")
        lueValidityType.Properties.DataSource = dtSource
        lueValidityType.Properties.DisplayMember = "DescripcionTipoVigencia"
        lueValidityType.Properties.ValueMember = "CodigoTipoVigencia"
    End Sub

    Private Sub teDocumentNumber_EditValueChanged(sender As Object, e As EventArgs) Handles teDocumentNumber.EditValueChanged
        Validate()
        Dim dtQuery As New DataTable
        If teDocumentNumber.EditValue <> "" Then
            dtQuery = oAppService.CustomerDocumentQuery(lueDocumentType.EditValue, teDocumentNumber.EditValue)
            If dtQuery.Rows.Count > 0 Then
                teCompany.EditValue = dtQuery.Rows(0)("RazonSocial")
            End If
        End If
    End Sub

    Private Sub lueValidityType_EditValueChanged(sender As Object, e As EventArgs) Handles lueValidityType.EditValueChanged
        deDateFrom.Enabled = False
        deDateTo.Enabled = False
        If lueValidityType.GetColumnValue("ValidaFechas") = True Then
            deDateFrom.Enabled = True
            deDateTo.Enabled = True
        End If
    End Sub

    Private Sub bbiApprove_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiApprove.ItemClick
        If DevExpress.XtraEditors.XtraMessageBox.Show("Esta seguro que desea aprobar la vinculación seleccionada? ", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.No Then
            Return
        End If
        oRelatedCompanyBE.ENTC_Codigo = ENTC_Codigo
        oRelatedCompanyBE.ENTC_CodigoVinculada = GetCustomerCode(GridView2.GetFocusedRowCellValue("ENTC_DocIden"))
        oRelatedCompanyBE.Estado = "A"
        oRelatedCompanyBE.AUDI_UsrMod = AppUser
        oRelatedCompanyBE.AUDI_FecMod = Now
        oAppService.StatusUpdateRelatedCompany(oRelatedCompanyBE)
        GetRelatedCompany()
    End Sub

    Private Sub bbiReject_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiReject.ItemClick
        If DevExpress.XtraEditors.XtraMessageBox.Show("Esta seguro que desea rechazar la vinculación seleccionada? ", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.No Then
            Return
        End If
        oRelatedCompanyBE.ENTC_Codigo = ENTC_Codigo
        oRelatedCompanyBE.ENTC_CodigoVinculada = GetCustomerCode(GridView2.GetFocusedRowCellValue("ENTC_DocIden"))
        oRelatedCompanyBE.Estado = "R"
        oRelatedCompanyBE.AUDI_UsrMod = AppUser
        oRelatedCompanyBE.AUDI_FecMod = Now
        oAppService.StatusUpdateRelatedCompany(oRelatedCompanyBE)
        GetRelatedCompany()
    End Sub

    Private Sub RepositoryItemHyperLinkEdit1_Click(sender As Object, e As EventArgs) Handles RepositoryItemHyperLinkEdit1.Click
        If DevExpress.XtraEditors.XtraMessageBox.Show("Esta seguro que desea desvincular la empresa seleccionada? ", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.No Then
            Return
        End If
        oRelatedCompanyBE.ENTC_Codigo = ENTC_Codigo
        oRelatedCompanyBE.ENTC_CodigoVinculada = GetCustomerCode(GridView2.GetFocusedRowCellValue("ENTC_DocIden"))
        oRelatedCompanyBE.Estado = "D"
        oRelatedCompanyBE.AUDI_UsrMod = AppUser
        oRelatedCompanyBE.AUDI_FecMod = Now
        oAppService.StatusUpdateRelatedCompany(oRelatedCompanyBE)
        GetRelatedCompany()
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

        vpInputs.SetValidationRule(deDateFrom, Nothing)
        vpInputs.SetValidationRule(deDateTo, Nothing)

        vpInputs.SetValidationRule(lueDocumentType, customValidationRule)
        vpInputs.SetValidationRule(teDocumentNumber, customValidationRule)
        vpInputs.SetValidationRule(teCompany, customValidationRule)
        vpInputs.SetValidationRule(teContactName, customValidationRule)
        vpInputs.SetValidationRule(teMail, customValidationRule)
        vpInputs.SetValidationRule(lueRelationType, customValidationRule)
        vpInputs.SetValidationRule(lueValidityType, customValidationRule)
        If lueValidityType.Text = "LIMITADA" Then
            vpInputs.SetValidationRule(deDateFrom, customValidationRule)
            vpInputs.SetValidationRule(deDateTo, customValidationRule)
        End If
    End Sub

End Class
Public Class MainForm 

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        DevExpress.UserSkins.BonusSkins.Register()

    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MainForm_TextChanged(sender As Object, e As EventArgs) Handles MyBase.TextChanged
        Me.Text = My.Application.Info.ProductName + " [" + My.Application.Info.Version.ToString + "]"
    End Sub

    Private Sub SelectPage(ByVal FormName As String)
        For Each myChildForm In MdiChildren
            If myChildForm.Name = FormName Then
                myChildForm.Focus()
            End If
        Next
    End Sub

    Private Sub OpenForm(AppForm As Form)
        Try
            Dim myForm As New Form
            myForm = AppForm
            If Me.Controls.Find(myForm.Name, True).Count = 0 Then
                myForm.MdiParent = Me
                myForm.Show()
            Else
                SelectPage(myForm.Name)
            End If
        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AccordionControlElement9_Click(sender As Object, e As EventArgs) Handles AccordionControlElement9.Click
        OpenForm(RoutingOrderServiceAssignForm)
    End Sub

    Private Sub AccordionControlElement10_Click(sender As Object, e As EventArgs) Handles AccordionControlElement10.Click
        OpenForm(AccountingTransferForm)
    End Sub

    Private Sub AccordionControlElement12_Click(sender As Object, e As EventArgs) Handles AccordionControlElement12.Click
        OpenForm(ElectronicInvoicingForm)
    End Sub

    Private Sub AccordionControlElement14_Click(sender As Object, e As EventArgs) Handles AccordionControlElement14.Click
        OpenForm(LogisticOperationQueryForm)
    End Sub

    Private Sub AccordionControlElement13_Click(sender As Object, e As EventArgs) Handles AccordionControlElement13.Click
        OpenForm(VendorDocumentQueryForm)
    End Sub

    Private Sub AccordionControlElement15_Click(sender As Object, e As EventArgs) Handles AccordionControlElement15.Click
        OpenForm(DemurrageForm)
    End Sub

    Private Sub AccordionControlElement16_Click(sender As Object, e As EventArgs) Handles AccordionControlElement16.Click
        OpenForm(CustomerRegisterRequestForm)
    End Sub

    Private Sub AccordionControlElement17_Click(sender As Object, e As EventArgs) Handles AccordionControlElement17.Click
        OpenForm(RelatedCompanyRequestForm)
    End Sub

    Private Sub AccordionControlElement18_Click(sender As Object, e As EventArgs) Handles AccordionControlElement18.Click
        OpenForm(SalesLogisticOperationForm)
    End Sub

    Private Sub AccordionControlElement19_Click(sender As Object, e As EventArgs) Handles AccordionControlElement19.Click
        OpenForm(CargoAddressingForm)
    End Sub

    Private Sub AccordionControlElement20_Click(sender As Object, e As EventArgs) Handles AccordionControlElement20.Click
        OpenForm(CompanyForm)
    End Sub

    Private Sub AccordionControlElement21_Click(sender As Object, e As EventArgs) Handles AccordionControlElement21.Click
        OpenForm(GroupForm)
    End Sub

    Private Sub AccordionControlElement22_Click(sender As Object, e As EventArgs) Handles AccordionControlElement22.Click
        OpenForm(BusinessUnitForm)
    End Sub

    Private Sub AccordionControlElement23_Click(sender As Object, e As EventArgs) Handles AccordionControlElement23.Click
        OpenForm(AttributeForm)
    End Sub

    Private Sub AccordionControlElement24_Click(sender As Object, e As EventArgs) Handles AccordionControlElement24.Click
        OpenForm(ConceptForm)
    End Sub

    Private Sub AccordionControlElement25_Click(sender As Object, e As EventArgs) Handles AccordionControlElement25.Click
        OpenForm(UnitForm)
    End Sub

    Private Sub AccordionControlElement26_Click(sender As Object, e As EventArgs) Handles AccordionControlElement26.Click
        OpenForm(ConditionForm)
    End Sub

    Private Sub AccordionControlElement28_Click(sender As Object, e As EventArgs) Handles AccordionControlElement28.Click
        OpenForm(LayoutForm)
    End Sub

    Private Sub AccordionControlElement27_Click(sender As Object, e As EventArgs) Handles AccordionControlElement27.Click
        OpenForm(TariffForm)
    End Sub

    Private Sub AccordionControlElement29_Click(sender As Object, e As EventArgs) Handles AccordionControlElement29.Click
        OpenForm(MailCargoNoticeForm)
    End Sub

    Private Sub AccordionControlElement30_Click(sender As Object, e As EventArgs) Handles AccordionControlElement30.Click
        OpenForm(ConsolidatedInquiryForm)
    End Sub

    Private Sub AccordionControlElement31_Click(sender As Object, e As EventArgs) Handles AccordionControlElement31.Click
        OpenForm(LoadingListForm)
    End Sub

    Private Sub AccordionControlElement32_Click(sender As Object, e As EventArgs) Handles AccordionControlElement32.Click
        OpenForm(EventManagementForm)
    End Sub

    Private Sub AccordionControlElement33_Click(sender As Object, e As EventArgs) Handles AccordionControlElement33.Click
        OpenForm(ConsolidatedInquiryForm)
    End Sub

    Private Sub AccordionControlElement34_Click(sender As Object, e As EventArgs) Handles AccordionControlElement34.Click
        OpenForm(PackForm)
    End Sub
End Class
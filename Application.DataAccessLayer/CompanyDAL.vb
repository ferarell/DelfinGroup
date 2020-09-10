Public Class CompanyDAL
    Dim DbContext As TarifarioEntities = New TarifarioEntities()


    Public Function GetAllCompanies() As List(Of Company)
        Return DbContext.Company.ToList()
    End Function

    Public Function GetCompania(CompaniaId As Integer) As Company
        Return DbContext.Company.Where(Function(p) p.IdCompany = CompaniaId).FirstOrDefault()
    End Function

    Public Function InsertCompania(ByVal CompaniaItem As Company) As Boolean
        Dim status As Boolean

        Try
            DbContext.Company.Add(CompaniaItem)
            DbContext.SaveChanges()
            status = True
        Catch __unusedException1__ As Exception
            status = False
        End Try

        Return status
    End Function


    Public Function UpdateCompania(ByVal CompaniaItem As Company) As Boolean
        Dim status As Boolean

        Try
            Dim companyItem As Company = DbContext.Company.Where(Function(p) p.IdCompany = CompaniaItem.IdCompany).FirstOrDefault

            If companyItem IsNot Nothing Then
                companyItem.IdCompany = CompaniaItem.IdCompany
                companyItem.CompanyCode = CompaniaItem.CompanyCode
                companyItem.CompanyDescription = CompaniaItem.CompanyDescription
                companyItem.CompanyTaxCode = CompaniaItem.CompanyTaxCode
                companyItem.IdGroup = CompaniaItem.IdGroup
                companyItem.CompanyStatus = CompaniaItem.CompanyStatus
                'attbtItem.DateCreate = CompaniaItem.DateCreate
                companyItem.DateUpdate = CompaniaItem.DateUpdate
                'attbtItem.UserCreate = CompaniaItem.UserCreate
                companyItem.UserUpdate = CompaniaItem.UserUpdate
                DbContext.SaveChanges()
            End If

            status = True
        Catch __unusedException1__ As Exception
            status = False
        End Try

        Return status
    End Function


    Public Function DeleteCompania(ByVal id As Integer) As Boolean
        Dim status As Boolean

        Try
            Dim attItem As Company = DbContext.Company.Where(Function(p) p.IdCompany = id).FirstOrDefault

            If attItem IsNot Nothing Then
                DbContext.Company.Remove(attItem)
                DbContext.SaveChanges()
            End If

            status = True
        Catch __unusedException1__ As Exception
            status = False
        End Try

        Return status
    End Function
End Class

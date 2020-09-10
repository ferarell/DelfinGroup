Imports System.Security.Principal
Imports System.Data
Imports Microsoft.Reporting.WinForms
Imports System.Net

Public Class ReportServerCredentials
    Implements IReportServerCredentials

    Private _userName As String
    Private _password As String
    Private _domain As String

    Public Sub New(ByVal userName As String, ByVal password As String, ByVal domain As String)
        _userName = userName
        _password = password
        _domain = domain
    End Sub

    Public Function GetFormsCredentials(ByRef authCookie As System.Net.Cookie, ByRef userName As String, ByRef password As String, ByRef authority As String) As Boolean Implements Microsoft.Reporting.WinForms.IReportServerCredentials.GetFormsCredentials
        authCookie = Nothing
        userName = password = authority = Nothing
        Return False
    End Function

    Public ReadOnly Property ImpersonationUser() As System.Security.Principal.WindowsIdentity Implements Microsoft.Reporting.WinForms.IReportServerCredentials.ImpersonationUser

        Get
            Return Nothing
        End Get

    End Property

    Public ReadOnly Property NetworkCredentials() As System.Net.ICredentials Implements Microsoft.Reporting.WinForms.IReportServerCredentials.NetworkCredentials

        Get
            Return New NetworkCredential(_userName, _password, _domain)
        End Get

    End Property

End Class
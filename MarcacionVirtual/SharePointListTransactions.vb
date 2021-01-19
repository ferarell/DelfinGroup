Imports System
Imports System.Security
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading
Imports System.Configuration
Imports System.Globalization
Imports Microsoft.SharePoint
Imports Microsoft.SharePoint.Client
Imports System.Collections
Imports System.Data

Public Class SharePointListTransactions
    Dim Password As New SecureString
    Friend SharePointUrl As String
    Friend SharePointList As String
    Friend ValuesList, FieldsList As New ArrayList

    Public Sub New()
        Thread.CurrentThread.CurrentCulture = New CultureInfo("en-US")
        For Each c As Char In My.Settings.SharePoint_Password
            Password.AppendChar(c)
        Next
    End Sub

    Friend Sub InsertItem()
        Try
            Dim clienContext As New ClientContext(SharePointUrl)
            clienContext.Credentials = New SharePointOnlineCredentials(My.Settings.SharePoint_User, Password)
            Dim oList As List = clienContext.Web.Lists.GetByTitle(SharePointList)
            Dim listItemCreationInformation As New ListItemCreationInformation
            Dim oListItem As ListItem = oList.AddItem(listItemCreationInformation)

            For c = 0 To ValuesList.Count - 1
                oListItem(ValuesList(c)(0)) = ValuesList(c)(1)
            Next

            oListItem.Update()
            clienContext.ExecuteQuery()

        Catch ex As Exception

        End Try

    End Sub

    Friend Sub UpdateItem(IdRow As Integer)
        Dim clienContext As New ClientContext(SharePointUrl)
        clienContext.Credentials = New SharePointOnlineCredentials(My.Settings.SharePoint_User, Password)

        'Dim targetWeb As Web = clienContext.Web
        'Dim regionalSettings As RegionalSettings = targetWeb.RegionalSettings
        'clienContext.Load(targetWeb, Function(w) w.RegionalSettings, Function(w) w.RegionalSettings.TimeZones)
        'clienContext.ExecuteQuery()

        Dim oList As List = clienContext.Web.Lists.GetByTitle(SharePointList)
        Dim oListItem As ListItem = oList.GetItemById(IdRow)

        For c = 0 To ValuesList.Count - 1
            oListItem(ValuesList(c)(0)) = ValuesList(c)(1)
        Next

        'Dim utcTimeZone As Microsoft.SharePoint.Client.TimeZone = targetWeb.RegionalSettings.TimeZones.Where(Function(timezone) timezone.Description = "(UTC-05:00) Bogota, Lima, Quito").First()
        'targetWeb.RegionalSettings.TimeZone = utcTimeZone

        oListItem.Update()
        clienContext.ExecuteQuery()
    End Sub

    Friend Sub DeleteItem(IdRows As Integer)

    End Sub

    Friend Function SelectItem(oParams As ArrayList) As DataTable
        Dim clienContext As New ClientContext(SharePointUrl)
        clienContext.Credentials = New SharePointOnlineCredentials(My.Settings.SharePoint_User, Password)

        Dim targetWeb As Web = clienContext.Web
        Dim regionalSettings As RegionalSettings = targetWeb.RegionalSettings
        clienContext.Load(targetWeb, Function(w) w.RegionalSettings, Function(w) w.RegionalSettings.TimeZones)
        clienContext.ExecuteQuery()


        'clienContext.Web.RegionalSettings.LocaleId = "1033"
        Dim oList As List = clienContext.Web.Lists.GetByTitle(SharePointList)
        Dim oQuery As New CamlQuery
        Dim sQuery As String = ""
        oQuery = CamlQuery.CreateAllItemsQuery()
        For p = 0 To oParams.Count - 1
            sQuery += sQuery & "<Eq><FieldRef Name='" & oParams(p)(0) & "' /><Value Type='Text'>" & oParams(p)(1) & "</Value></Eq>"
        Next
        oQuery.ViewXml = "'<View><Query><Where>" & sQuery & "</Where></Query></View>'"
        Dim oItemsList As ListItemCollection = oList.GetItems(oQuery)
        clienContext.Load(oList)
        clienContext.Load(oItemsList)
        Dim utcTimeZone As Microsoft.SharePoint.Client.TimeZone = targetWeb.RegionalSettings.TimeZones.Where(Function(timezone) timezone.Description = "(UTC+05:00) Tashkent").First()
        targetWeb.RegionalSettings.TimeZone = utcTimeZone

        clienContext.ExecuteQuery()
        Dim listFields As FieldCollection = oList.Fields

        Dim dtItems As New DataTable
        For c = 0 To FieldsList.Count - 1
            Try
                If oItemsList(0).FieldValues(FieldsList(c)(0)) Is Nothing Then
                    dtItems.Columns.Add(FieldsList(c)(0))
                    Continue For
                End If
                If oItemsList(0).FieldValues(FieldsList(c)(0)).ToString.Contains("FieldLookupValue[]") Then
                    dtItems.Columns.Add(FieldsList(c)(0), GetType(Object))
                Else
                    dtItems.Columns.Add(FieldsList(c)(0))
                End If
            Catch ex As Exception

            End Try
        Next

        For Each Item As ListItem In oItemsList
            dtItems.Rows.Add()
            For c = 0 To dtItems.Columns.Count - 1
                Try
                    If Not Item(FieldsList(c)(0)) Is Nothing Then
                        'If Item(FieldsList(c)(0)).ToString.Contains("FieldLookupValue[]") Then
                        '    dtItems.Rows(dtItems.Rows.Count - 1)(c)() = DirectCast(Item(FieldsList(c)(0)), Microsoft.SharePoint.Client.FieldLookupValue).LookupValue()
                        If Item(FieldsList(c)(0)).ToString.Contains("FieldLookupValue") Then
                            dtItems.Rows(dtItems.Rows.Count - 1)(c) = DirectCast(Item(FieldsList(c)(0)), Microsoft.SharePoint.Client.FieldLookupValue).LookupValue
                        ElseIf Item(FieldsList(c)(0)).ToString.Contains("FieldUserValue") Then
                            dtItems.Rows(dtItems.Rows.Count - 1)(c) = DirectCast(Item(FieldsList(c)(0)), Microsoft.SharePoint.Client.FieldUserValue).Email
                        Else
                            dtItems.Rows(dtItems.Rows.Count - 1)(c) = Item(FieldsList(c)(0))
                        End If
                    End If
                Catch ex As Exception

                End Try

            Next
        Next
        Return dtItems

    End Function

    Friend Function GetItems() As DataTable
        Dim clienContext As New ClientContext(SharePointUrl)
        clienContext.Credentials = New SharePointOnlineCredentials(My.Settings.SharePoint_User, Password)
        Dim oList As List = clienContext.Web.Lists.GetByTitle(SharePointList)
        Dim oQuery As New CamlQuery
        oQuery = CamlQuery.CreateAllItemsQuery()
        oQuery.ViewXml = "<View/>"
        Dim oItemsList As ListItemCollection = oList.GetItems(oQuery)
        clienContext.Load(oList)
        clienContext.Load(oItemsList)
        clienContext.ExecuteQuery()
        Dim listFields As FieldCollection = oList.Fields

        Dim dtItems As New DataTable
        For c = 0 To FieldsList.Count - 1
            Try
                If oItemsList(0).FieldValues(FieldsList(c)(0)) Is Nothing Then
                    dtItems.Columns.Add(FieldsList(c)(0))
                    Continue For
                End If
                If oItemsList(0).FieldValues(FieldsList(c)(0)).ToString.Contains("FieldLookupValue[]") Then
                    dtItems.Columns.Add(FieldsList(c)(0), GetType(Object))
                Else
                    dtItems.Columns.Add(FieldsList(c)(0))
                End If
            Catch ex As Exception

            End Try
        Next

        For Each Item As ListItem In oItemsList
            dtItems.Rows.Add()
            For c = 0 To dtItems.Columns.Count - 1
                Try
                    If Not Item(FieldsList(c)(0)) Is Nothing Then
                        'If Item(FieldsList(c)(0)).ToString.Contains("FieldLookupValue[]") Then
                        '    dtItems.Rows(dtItems.Rows.Count - 1)(c)() = DirectCast(Item(FieldsList(c)(0)), Microsoft.SharePoint.Client.FieldLookupValue).LookupValue()
                        If Item(FieldsList(c)(0)).ToString.Contains("FieldLookupValue") Then
                            dtItems.Rows(dtItems.Rows.Count - 1)(c) = DirectCast(Item(FieldsList(c)(0)), Microsoft.SharePoint.Client.FieldLookupValue).LookupValue
                        ElseIf Item(FieldsList(c)(0)).ToString.Contains("FieldUserValue") Then
                            dtItems.Rows(dtItems.Rows.Count - 1)(c) = DirectCast(Item(FieldsList(c)(0)), Microsoft.SharePoint.Client.FieldUserValue).Email
                        Else
                            dtItems.Rows(dtItems.Rows.Count - 1)(c) = Item(FieldsList(c)(0))
                        End If
                    End If
                Catch ex As Exception

                End Try

            Next
        Next
        Return dtItems
    End Function

    'Friend Function GetDataTableFromListItemCollection() As DataTable
    '    Dim strWhere As String = String.Empty
    '    Dim dtGetReqForm As New DataTable()
    '    Using clientContext = New ClientContext("sharepoint host url")
    '        Try
    '            Dim spList As Microsoft.SharePoint.Client.List = clientContext.Web.Lists.GetByTitle("ReqList")
    '            clientContext.Load(spList)
    '            clientContext.ExecuteQuery()

    '            If spList IsNot Nothing AndAlso spList.ItemCount > 0 Then
    '                Dim camlQuery As Microsoft.SharePoint.Client.CamlQuery = New CamlQuery()
    '                camlQuery.ViewXml = "<View>" + "<Query> " + "<Where>" + "<And>" + "<IsNotNull><FieldRef Name='ID' /></IsNotNull>" + "<Eq><FieldRef Name='ReqNo' /><Value Type='Text'>123</Value></Eq>" + "</And>" + "</Where>" + "</Query> " + "<ViewFields>" + "<FieldRef Name='ID' />" + "</ViewFields>" + "</View>"

    '                Dim listItems As SPClient.ListItemCollection = spList.GetItems(camlQuery)
    '                clientContext.Load(listItems)
    '                clientContext.ExecuteQuery()

    '                If listItems IsNot Nothing AndAlso listItems.Count > 0 Then
    '                    For Each field As Object In listItems(0).FieldValues.Keys
    '                        dtGetReqForm.Columns.Add(field)
    '                    Next

    '                    For Each item As Object In listItems
    '                        Dim dr As DataRow = dtGetReqForm.NewRow()

    '                        For Each obj As Object In item.FieldValues
    '                            If obj.Value IsNot Nothing Then
    '                                Dim key As String = obj.Key
    '                                Dim type As String = obj.Value.[GetType]().FullName

    '                                If type = "Microsoft.SharePoint.Client.FieldLookupValue" Then
    '                                    dr(obj.Key) = CType(obj.Value, FieldLookupValue).LookupValue
    '                                ElseIf type = "Microsoft.SharePoint.Client.FieldUserValue" Then
    '                                    dr(obj.Key) = CType(obj.Value, FieldUserValue).LookupValue
    '                                ElseIf type = "Microsoft.SharePoint.Client.FieldUserValue[]" Then
    '                                    Dim multValue As FieldUserValue() = CType(obj.Value, FieldUserValue())
    '                                    For Each fieldUserValue As FieldUserValue In multValue
    '                                        dr(obj.Key) += (fieldUserValue).LookupValue
    '                                    Next
    '                                ElseIf type = "System.DateTime" Then
    '                                    If obj.Value.ToString().Length > 0 Then
    '                                        Dim [date] = obj.Value.ToString().Split(" "c)
    '                                        If [date](0).Length > 0 Then
    '                                            dr(obj.Key) = [date](0)
    '                                        End If
    '                                    End If
    '                                Else
    '                                    dr(obj.Key) = obj.Value
    '                                End If
    '                            Else
    '                                dr(obj.Key) = Nothing
    '                            End If
    '                        Next
    '                        dtGetReqForm.Rows.Add(dr)
    '                    Next
    '                End If
    '            End If
    '        Catch ex As Exception
    '        Finally
    '            If clientContext IsNot Nothing Then
    '                clientContext.Dispose()
    '            End If
    '        End Try
    '    End Using
    '    Return dtGetReqForm

    'End Function

End Class

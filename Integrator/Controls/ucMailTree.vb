Imports System.ComponentModel
Imports System.Text
Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraTreeList.Nodes
Imports DevExpress.XtraTreeList
Imports DevExpress.Utils.Design

Namespace DevExpress.MailClient.Win
    Partial Public Class ucMailTree
        Inherits BaseControl

        Public Event DataSourceChanged As DataSourceChangedEventHandler
        Public Event ShowMenu As MouseEventHandler
        Private allowDataSourceChanged As Boolean = False
        Public Sub New()
            InitializeComponent()
            InitData()
            treeList1.RowHeight = Math.Max(Convert.ToInt32(treeList1.Font.GetHeight()), icFolders.ImageSize.Height) + 5
        End Sub
        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            If Not DesignTimeTools.IsDesignMode Then
                treeList1.FocusedNode = treeList1.Nodes(0).Nodes(0)
            End If
        End Sub
        Private Sub InitData()
            Dim tlAnnouncements As TreeListNode = treeList1.AppendNode(New Object() {My.Resources.Announcements, MailType.Inbox, MailFolder.Announcements, 5}, -1)
            treeList1.AppendNode(New Object() {My.Resources.Inbox, MailType.Inbox, MailFolder.Announcements}, tlAnnouncements)
            treeList1.AppendNode(New Object() {My.Resources.SentItems, MailType.Sent, MailFolder.Announcements, 1}, tlAnnouncements)
            treeList1.AppendNode(New Object() {My.Resources.DeletedItems, MailType.Deleted, MailFolder.Announcements, 2}, tlAnnouncements)
            Dim tlPerson As TreeListNode = treeList1.AppendNode(New Object() {My.Resources.OwnerName, MailType.Inbox, MailFolder.All, 4}, -1)
            Dim tlPersonInbox As TreeListNode = treeList1.AppendNode(New Object() {My.Resources.Inbox, MailType.Inbox, MailFolder.All}, tlPerson)
            treeList1.AppendNode(New Object() {My.Resources.ASP, MailType.Inbox, MailFolder.ASP, 6}, tlPersonInbox)
            treeList1.AppendNode(New Object() {My.Resources.WinForms, MailType.Inbox, MailFolder.WinForms, 9}, tlPersonInbox)
            treeList1.AppendNode(New Object() {My.Resources.IDETools, MailType.Inbox, MailFolder.IDETools, 7}, tlPersonInbox)
            treeList1.AppendNode(New Object() {My.Resources.Frameworks, MailType.Inbox, MailFolder.Frameworks, 8}, tlPersonInbox)
            treeList1.AppendNode(New Object() {My.Resources.SentItems, MailType.Sent, MailFolder.All, 1}, tlPerson)
            treeList1.AppendNode(New Object() {My.Resources.DeletedItems, MailType.Deleted, MailFolder.All, 2}, tlPerson)
            treeList1.AppendNode(New Object() {My.Resources.Drafts, MailType.Draft, MailFolder.All, 3}, tlPerson)

            treeList1.ExpandAll()
            If Not DesignTimeTools.IsDesignMode Then
                CreateMessagesList(treeList1.Nodes)
            End If
            allowDataSourceChanged = True
        End Sub

        Private Sub CreateMessagesList(ByVal nodes As TreeListNodes)
            For Each node As TreeListNode In nodes
                CreateMessagesForNode(node)
                CreateMessagesList(node.Nodes)
            Next node
        End Sub
        Private Sub CreateMessagesForNode(ByVal node As TreeListNode)
            Dim messages As New List(Of Message)()
            Dim mailType As MailType = CType(node.GetValue(colType), MailType)
            Dim mailFolder As MailFolder = CType(node.GetValue(colFolder), MailFolder)
            For Each message As Message In DataHelper.Messages
                If message.MailType = mailType AndAlso (message.MailFolder = mailFolder OrElse mailFolder = MailFolder.All) AndAlso (Not message.Deleted) Then
                    messages.Add(message)
                End If
            Next message
            node.SetValue(colData, messages)
        End Sub
        Protected Overrides Sub LookAndFeelStyleChanged()
            MyBase.LookAndFeelStyleChanged()
            Dim controlColor As Color = CommonSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default).Colors.GetColor("Control")
            treeList1.Appearance.Empty.BackColor = controlColor
            treeList1.Appearance.Row.BackColor = controlColor
        End Sub
        Private Sub treeList1_FocusedNodeChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles treeList1.FocusedNodeChanged
            RaiseDataSourceChanged(e.Node)
        End Sub
        Private Sub RaiseDataSourceChanged(ByVal node As TreeListNode)
            If allowDataSourceChanged Then
                RaiseEvent DataSourceChanged(treeList1, New DataSourceChangedEventArgs(GetNodeCaption(node), node.GetValue(colData), node.GetValue(colType)))
            End If
        End Sub
        Private Function GetNodeCaption(ByVal node As TreeListNode) As String
            Dim ret As String = String.Format("{0}", node.GetValue(colName))
            Do While node.ParentNode IsNot Nothing
                node = node.ParentNode
                ret = String.Format("{0} - {1}", node.GetValue(colName), ret)
            Loop
            Return ret
        End Function
        Private Sub treeList1_CustomDrawNodeCell(ByVal sender As Object, ByVal e As CustomDrawNodeCellEventArgs) Handles treeList1.CustomDrawNodeCell
            If DesignTimeTools.IsDesignMode Then
                Return
            End If
            If e.Column Is colName Then
                Dim textColor As String = GetHtmlTextColor(treeList1.FocusedNode.Equals(e.Node))
                Dim textValue As Object = e.Node.GetValue(colName)
                e.CellText = String.Format("<Color={1}>{0}", textValue, textColor)
                If e.Node.ParentNode Is Nothing OrElse Not (DataHelper.ShowAllMessageCount OrElse DataHelper.ShowUnreadMessageCount) Then
                    Return
                End If
                Dim list As List(Of Message) = TryCast(e.Node.GetValue(colData), List(Of Message))
                Dim unread As Integer = GetUnreadMessagesCount(list)
                If unread > 0 AndAlso DataHelper.ShowUnreadMessageCount Then
                    If DataHelper.ShowAllMessageCount Then
                        e.CellText = String.Format("<Color={5}><b>{0}</b><Size=-1><Color={2}> [{1}/<Color={4}>{3}<Color={2}>]", textValue, unread, ColorHelper.HtmlQuestionColor, list.Count, ColorHelper.HtmlWarningColor, textColor)
                    Else
                        e.CellText = String.Format("<Color={3}><b>{0}</b><Size=-1><Color={2}> [{1}]", textValue, unread, ColorHelper.HtmlQuestionColor, textColor)
                    End If
                Else
                    If DataHelper.ShowAllMessageCount AndAlso list.Count > 0 Then
                        e.CellText = String.Format("<Color={3}>{0}<Size=-1><Color={2}> [{1}]", textValue, list.Count, ColorHelper.HtmlWarningColor, textColor)
                    End If
                End If
            End If
        End Sub
        Private Shared Function GetHtmlTextColor(ByVal focused As Boolean) As String
            If focused Then
                Return ColorHelper.HtmlHighlightTextColor
            End If
            If AllowControlTextColor() Then
                Return ColorHelper.HtmlControlTextColor
            Else
                Return ColorHelper.HtmlControlTextColor2
            End If
        End Function
        Private Shared Function AllowControlTextColor() As Boolean
            Return DevExpress.LookAndFeel.UserLookAndFeel.Default.ActiveSkinName <> "Glass Oceans"
        End Function

        Private Function GetUnreadMessagesCount(ByVal list As List(Of Message)) As Integer
            Dim ret = From message In list Where message.IsUnread = True Select message
            Return ret.Count
            'Return list.Count 'list.Count(Function(p As Message) p.IsUnread)
        End Function
        Friend Sub RefreshTreeList()
            treeList1.LayoutChanged()
        End Sub
        Private Sub treeList1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles treeList1.MouseDown
            If e.Button = MouseButtons.Right Then
                RaiseEvent ShowMenu(sender, e)
            End If
        End Sub

        Friend Sub UpdateTreeViewMessages()
            CreateMessagesList(treeList1.Nodes)
            RefreshTreeList()
            RaiseDataSourceChanged(treeList1.FocusedNode)
        End Sub
        Private WithEvents icFolders As DevExpress.Utils.ImageCollection

        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucMailTree))
            Me.icFolders = New DevExpress.Utils.ImageCollection()
            CType(Me.icFolders, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'icFolders
            '
            Me.icFolders.ImageStream = CType(resources.GetObject("icFolders.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
            Me.icFolders.Images.SetKeyName(0, "Inbox_16x16.png")
            Me.icFolders.Images.SetKeyName(1, "SentItems_16x16.png")
            Me.icFolders.Images.SetKeyName(2, "DeletedItems_16x16.png")
            Me.icFolders.Images.SetKeyName(3, "Drafts_16x16.png")
            Me.icFolders.Images.SetKeyName(4, "Customer.png")
            Me.icFolders.Images.SetKeyName(5, "Announcements.png")
            Me.icFolders.Images.SetKeyName(6, "ASP.png")
            Me.icFolders.Images.SetKeyName(7, "IDE.png")
            Me.icFolders.Images.SetKeyName(8, "Frameworks.png")
            Me.icFolders.Images.SetKeyName(9, "WinForms_16x16.png")
            '
            'ucMailTree
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "ucMailTree"
            CType(Me.icFolders, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
    End Class
End Namespace

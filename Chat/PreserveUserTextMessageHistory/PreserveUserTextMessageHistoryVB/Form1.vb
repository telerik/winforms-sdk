Imports System.ComponentModel
Imports Telerik.WinControls.UI

Partial Public Class Form1
    Inherits RadForm

    Private authors As BindingList(Of Author) = New BindingList(Of Author)()
    Private chatHistory As Dictionary(Of Author, List(Of BaseChatDataItem)) = New Dictionary(Of Author, List(Of BaseChatDataItem))()
    Private scrollbar As RadScrollBarElement
    Private messageCounter As Integer = 0
    Public Property Person As Author

    Public Sub New()
        InitializeComponent()
        authors.Add(New Author(My.Resources.andrew45x45, "Andrew"))
        authors.Add(New Author(My.Resources.bob45x45, "Bob"))
        authors.Add(New Author(My.Resources.nancy45x45, "Nancy"))
        chatHistory.Add(authors(0), New List(Of BaseChatDataItem)())
        chatHistory.Add(authors(1), New List(Of BaseChatDataItem)())
        chatHistory.Add(authors(2), New List(Of BaseChatDataItem)())
        Me.radListControl1.DataSource = authors
        Me.radListControl1.DisplayMember = "name"
        Me.radListControl1.ValueMember = "name"
        Me.radChat1.Author = New Author(My.Resources.architect, "Morpheus")
    End Sub

    Private Sub radListControl1_CreatingVisualListItem(ByVal sender As Object, ByVal args As CreatingVisualListItemEventArgs) Handles radListControl1.CreatingVisualListItem
        args.VisualItem = New CustomVisualItem()
    End Sub

    Private Sub RadListControl1_VisualItemFormatting(ByVal sender As Object, ByVal args As VisualItemFormattingEventArgs) Handles radListControl1.VisualItemFormatting
        args.VisualItem.ImageLayout = ImageLayout.Zoom
    End Sub

    Private Sub RadListControl1_SelectedIndexChanging(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangingCancelEventArgs) Handles radListControl1.SelectedIndexChanging
        If Me.radListControl1.SelectedItem IsNot Nothing Then

            If Person Is Nothing Then
                Person = TryCast(Me.radListControl1.SelectedItem.DataBoundItem, Author)
            End If

            Dim currentHistory As List(Of BaseChatDataItem) = New List(Of BaseChatDataItem)()

            For i As Integer = 0 To radChat1.ChatElement.MessagesViewElement.Items.Count - 1
                currentHistory.Add(radChat1.ChatElement.MessagesViewElement.Items(0))
            Next

            If chatHistory(Person).Count < radChat1.ChatElement.MessagesViewElement.Items.Count Then
                chatHistory(Person) = radChat1.ChatElement.MessagesViewElement.Items.ToList()
            End If

            TryCast(Me.radListControl1.Items(e.Position).VisualItem, CustomVisualItem).MessageNotification = Telerik.WinControls.ElementVisibility.Hidden
            radChat1.ChatElement.MessagesViewElement.Items.Clear()
        End If
    End Sub

    Private Sub RadListControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles radListControl1.SelectedIndexChanged
        Person = TryCast(Me.radListControl1.SelectedItem.DataBoundItem, Author)
        Me.radChat1.ChatElement.MessagesViewElement.BeginUpdate()

        If chatHistory.ContainsKey(Person) Then
            Dim newHistory As List(Of BaseChatDataItem) = chatHistory(Person)

            For i As Integer = 0 To newHistory.Count - 1
                Dim addItem = TryCast(newHistory(i), BaseChatDataItem)

                If Not (TypeOf addItem Is ChatTimeSeparatorDataItem) Then

                    If addItem IsNot Nothing Then
                        radChat1.ChatElement.MessagesViewElement.Items.Add(addItem)
                    End If
                End If
            Next
        End If

        Me.radChat1.ChatElement.MessagesViewElement.EndUpdate()
        ScrollToLastItem()
    End Sub

    Private Sub RadListControl1_ItemDataBound(ByVal sender As Object, ByVal args As ListItemDataBoundEventArgs) Handles radListControl1.ItemDataBound
        args.NewItem.Image = (CType(args.NewItem.DataBoundItem, Author)).Avatar
    End Sub

    Private Sub radButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButton1.Click
        Me.radChat1.ChatElement.MessagesViewElement.BeginUpdate()
        Dim simulateChatMessageNumber As Integer = 1

        For i As Integer = 0 To simulateChatMessageNumber - 1
            Dim currentAuthor As Author = TryCast(Me.radListControl1.SelectedItem.DataBoundItem, Author)
            Dim message1 As ChatTextMessage = New ChatTextMessage(currentAuthor.Name & ": " & "Hello : " + messageCounter.ToString(), currentAuthor, DateTime.Now)
            Me.radChat1.AddMessage(message1)
            messageCounter += 1
        Next

        Me.radChat1.ChatElement.MessagesViewElement.EndUpdate()
        ScrollToLastItem()
    End Sub

    Private Sub radButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButton2.Click
        If Me.radListControl1.SelectedItem IsNot Me.radListControl1.Items(1) Then
            TryCast(Me.radListControl1.Items(1).VisualItem, CustomVisualItem).MessageNotification = Telerik.WinControls.ElementVisibility.Visible
            Dim bobUser = authors(1)
            Dim bobUserMessages = chatHistory(bobUser)
            bobUserMessages.Add(New TextMessageDataItem(New ChatTextMessage("Are you here?", bobUser, DateTime.Now)))
            chatHistory(authors(1)) = bobUserMessages
        Else
            Dim currentAuthor As Author = TryCast(Me.radListControl1.SelectedItem.DataBoundItem, Author)
            Dim message1 As ChatTextMessage = New ChatTextMessage(currentAuthor.Name & ":" & "Are you here : " + messageCounter, currentAuthor, DateTime.Now)
            Me.radChat1.AddMessage(message1)
        End If

        ScrollToLastItem()
    End Sub

    Private Sub ScrollToLastItem()
        Dim scrollbar As RadScrollBarElement = radChat1.ChatElement.MessagesViewElement.Scroller.Scrollbar
        scrollbar.Value = 0

        While scrollbar.Value < scrollbar.Maximum - scrollbar.LargeChange + 1
            scrollbar.PerformSmallIncrement(1)
            radChat1.ChatElement.MessagesViewElement.Scroller.UpdateScrollRange()
            Application.DoEvents()
        End While

        scrollbar.PerformLast()
    End Sub
End Class


Imports Telerik.WinControls.UI.TaskBoard
Imports Telerik.WinControls.UI

Public Class RadForm1
    Private user1 As UserInfo = New UserInfo()
    Private user2 As UserInfo = New UserInfo()
    Private user3 As UserInfo = New UserInfo()
    Private user4 As UserInfo = New UserInfo()

    Public Sub New()
        InitializeComponent()
        user1.FirstName = "Anne"
        user1.LastName = "Dodsworth"
        user1.Avatar = My.Resources.AnneDodsworth22
        user2.FirstName = "Andrew"
        user2.LastName = "Fuller"
        user2.Avatar = My.Resources.AndrewFuller22
        user3.FirstName = "Bob"
        user3.LastName = "Smill"
        user3.Avatar = My.Resources.BobSmill22
        user4.FirstName = "Nancy"
        user4.LastName = "Fuller"
        user4.Avatar = My.Resources.nancy22
        Me.RadTaskBoard1.Users.Add(user1)
        Me.RadTaskBoard1.Users.Add(user2)
        Me.RadTaskBoard1.Users.Add(user3)
        Me.RadTaskBoard1.Users.Add(user4)
        AddTaskCards()

        For Each col As RadTaskBoardColumnElement In Me.RadTaskBoard1.Columns
            AddHandler col.TaskCardAdding, AddressOf col_TaskCardAdding
        Next

        AddHandler Me.RadTaskBoard1.MouseDown, AddressOf radTaskBoard1_MouseDown
        AddHandler Me.RadTaskBoard1.MouseDoubleClick, AddressOf radTaskBoard1_MouseDoubleClick
    End Sub

    Private Sub radTaskBoard1_MouseDoubleClick(ByVal sender As Object, ByVal e As MouseEventArgs)
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Dim taskCard As RadTaskCardElement = TryCast(Me.RadTaskBoard1.ElementTree.GetElementAtPoint(e.Location), RadTaskCardElement)

            If taskCard IsNot Nothing Then
                Dim editDialog As TaskCardEditDialog = New TaskCardEditDialog(taskCard, Me.RadTaskBoard1)
                editDialog.ShowDialog()
            End If
        End If
    End Sub

    Private Sub radTaskBoard1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            Me.radContextMenu1.Items(0).Tag = Nothing
            Dim taskCard As RadTaskCardElement = TryCast(Me.RadTaskBoard1.ElementTree.GetElementAtPoint(e.Location), RadTaskCardElement)

            If taskCard IsNot Nothing Then
                Dim pt As Point = Me.RadTaskBoard1.PointToScreen(e.Location)
                Me.radContextMenu1.Items(0).Tag = taskCard
                Me.radContextMenu1.DropDown.ClosePopup(RadPopupCloseReason.CloseCalled)
                Me.radContextMenu1.Show(pt)
            End If
        End If
    End Sub

    Private Sub col_TaskCardAdding(ByVal args As RadTaskBoardColumnElement.TaskCardAddingEventArgs)
        Dim defaultTaskCard As RadTaskCardElement = New RadTaskCardElement()
        Dim editDialog As TaskCardEditDialog = New TaskCardEditDialog(defaultTaskCard, Me.RadTaskBoard1)

        If editDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            args.TaskCard = defaultTaskCard
        Else
            args.Cancel = True
        End If
    End Sub

    Private Sub AddTaskCards()
        Dim card As RadTaskCardElement = New RadTaskCardElement()
        Dim c1 As RadTaskBoardColumnElement = New RadTaskBoardColumnElement()
        c1.Title = "Backlog"
        c1.Subtitle = "Internal Issues"
        Dim c2 As RadTaskBoardColumnElement = New RadTaskBoardColumnElement()
        c2.Title = "In Development"
        c2.Subtitle = "Prioritized Issues"
        c2.IsCollapsed = True
        Me.RadTaskBoard1.Columns.Add(c1)
        Me.RadTaskBoard1.Columns.Add(c2)
        card.TitleText = "ListView improvements"
        card.DescriptionText = "Research phase"
        card.AccentSettings.Color = Color.Red
        card.Users.Add(user1)
        card.Users.Add(user2)
        Dim tagWF As RadTaskCardTagElement = New RadTaskCardTagElement()
        tagWF.Text = "WinForms"
        Dim tagWPF As RadTaskCardTagElement = New RadTaskCardTagElement()
        tagWPF.Text = "WPF"
        card.TagElements.Add(tagWF)
        card.TagElements.Add(tagWPF)
        card.SubTasks.Add(New SubTask(card))
        card.SubTasks.Add(New SubTask(card))
        card.SubTasks.Add(New SubTask(card))
        Dim x As SubTask = New SubTask(card)
        x.Completed = True
        card.SubTasks.Add(x)
        c1.TaskCardCollection.Add(card)
    End Sub

    Private Sub radMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles RadMenuItem1.Click
        Dim item As RadMenuItem = TryCast(sender, RadMenuItem)
        Dim taskCardToEdit As RadTaskCardElement = TryCast(item.Tag, RadTaskCardElement)
        Dim editDialog As TaskCardEditDialog = New TaskCardEditDialog(taskCardToEdit, Me.RadTaskBoard1)
        editDialog.ShowDialog()
    End Sub
End Class

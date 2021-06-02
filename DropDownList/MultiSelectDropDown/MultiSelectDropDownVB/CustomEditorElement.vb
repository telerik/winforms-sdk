Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Layouts
Imports Telerik.WinControls
Imports System.Text

Public Class CustomEditorElement
    Inherits RadDropDownListEditorElement
    Private customText As LightVisualElement
    Private closeButton As RadButtonElement
    Private textChanged As Boolean

    Public Sub New()
        closeButton = New RadButtonElement("Close")
        closeButton.SetValue(DockLayoutPanel.DockProperty, Dock.Bottom)
        AddHandler closeButton.Click, AddressOf closeButton_Click
        Me.Popup.SizingGripDockLayout.Children.Insert(1, closeButton)
        Me.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple

        AddHandler Me.PopupClosing, AddressOf CustomEditorElement_PopupClosing
        AddHandler Me.CreatingVisualItem, AddressOf CustomEditorElement_CreatingVisualItem
        AddHandler Me.ListElement.ItemDataBinding, AddressOf Me.CustomEditorElement_ItemDataBinding
    End Sub

    Private Sub deselectAll_Click(sender As Object, e As EventArgs)
        Me.SetItemsCheckSelect(False)
    End Sub

    Private Sub selectAll_Click(sender As Object, e As EventArgs)
        Me.SetItemsCheckSelect(True)
    End Sub

    Private Sub SetItemsCheckSelect(value As Boolean)
        For Each item As CustomListDataItem In Me.Items
            item.Selected = value
            item.Checked = value
        Next

        Me.SynchronizeText()
    End Sub

    Protected Overrides Sub SyncVisualProperties(listItem As RadListDataItem)
    End Sub

    Private Sub closeButton_Click(sender As Object, e As EventArgs)
        ClosePopup()
        Dim cell As GridDataCellElement = TryCast(Me.Parent, GridDataCellElement)
        If cell IsNot Nothing Then
            cell.GridViewElement.EndEdit()
        End If
    End Sub

    Private Sub CustomEditorElement_ItemDataBinding(sender As Object, args As ListItemDataBindingEventArgs)
        args.NewItem = New CustomListDataItem()
    End Sub

    Private Sub CustomEditorElement_CreatingVisualItem(sender As Object, args As CreatingVisualListItemEventArgs)
        args.VisualItem = New CustomListVisualItem()
    End Sub

    Private Sub CustomEditorElement_PopupClosing(sender As Object, args As RadPopupClosingEventArgs)
        Dim editor As CustomEditorElement = DirectCast(sender, CustomEditorElement)
        If args.CloseReason = RadPopupCloseReason.Mouse Then
            If editor.PopupForm.Bounds.Contains(Control.MousePosition) Then
                args.Cancel = True
            End If
        End If
    End Sub

    Protected Overrides Sub CreateChildElements()
        MyBase.CreateChildElements()

        customText = New LightVisualElement()
        customText.DrawBorder = False
        customText.DrawFill = True
        customText.GradientStyle = GradientStyles.Solid
        customText.BackColor = Color.White
        customText.TextAlignment = ContentAlignment.MiddleLeft
        Me.EditableElement.Children.Add(customText)
        Me.TextBox.Visibility = ElementVisibility.Collapsed
        Me.MinSize = New Size(0, 21)
    End Sub

    Public Overrides Sub ShowPopup()
        Dim selected As Boolean() = New Boolean(Me.Items.Count - 1) {}
        For i As Integer = 0 To selected.Length - 1
            selected(i) = Me.Items(i).Selected
        Next

        MyBase.ShowPopup()
        For i As Integer = 0 To selected.Length - 1
            Me.Items(i).Selected = selected(i)
        Next
    End Sub

    Protected Overrides Sub OnTextChanged(e As EventArgs)
        SynchronizeText()
    End Sub

    Friend Sub SynchronizeText()
        If textChanged Then
            Return
        End If

        textChanged = True
        Dim text As New StringBuilder()
        For Each item As CustomListDataItem In Me.ListElement.Items
            If item.Checked Then
                text.AppendFormat("{0}; ", item.Text)
            End If
        Next

        customText.Text = text.ToString()
        textChanged = False
    End Sub
End Class
Imports Telerik.WinControls.UI

Public Class CustomListVisualItem
    Inherits RadListVisualItem
    Private checkbox As RadCheckBoxElement
    Private content As LightVisualElement

    Protected Overrides Sub CreateChildElements()
        MyBase.CreateChildElements()

        Dim stack As New StackLayoutElement()
        stack.Orientation = Orientation.Horizontal
        Me.Children.Add(stack)

        checkbox = New RadCheckBoxElement()
        AddHandler checkbox.ToggleStateChanged, AddressOf checkbox_ToggleStateChanged
        stack.Children.Add(checkbox)

        content = New LightVisualElement()
        content.StretchHorizontally = False
        content.StretchVertically = True
        content.TextAlignment = ContentAlignment.MiddleLeft
        content.NotifyParentOnMouseInput = True
        stack.Children.Add(content)
    End Sub

    Private Sub checkbox_ToggleStateChanged(sender As Object, e As StateChangedEventArgs)
        DirectCast(Me.Data, CustomListDataItem).Checked = Me.checkbox.Checked

        Dim form As DropDownPopupForm = TryCast(Me.ElementTree.Control, DropDownPopupForm)
        DirectCast(form.OwnerDropDownListElement, CustomEditorElement).SynchronizeText()
    End Sub

    Protected Overrides ReadOnly Property ThemeEffectiveType() As Type
        Get
            Return GetType(RadListVisualItem)
        End Get
    End Property

    Protected Overrides Sub SynchronizeProperties()
        MyBase.SynchronizeProperties()
        checkbox.IsChecked = Me.Data.Selected
        Me.content.Text = Me.Data.Text
        Me.Text = ""
    End Sub
End Class
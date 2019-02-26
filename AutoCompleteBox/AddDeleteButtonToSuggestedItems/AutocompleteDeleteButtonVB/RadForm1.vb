Option Infer On
Imports Telerik.WinControls.UI

Partial Public Class RadForm1
    Inherits Telerik.WinControls.UI.RadForm


    Public Sub New()
        InitializeComponent()
        AddHandler RadAutoCompleteBox1.TextBoxElement.ListElement.CreatingVisualItem, AddressOf ListElement_CreatingVisualItem


        For i As Integer = 0 To 9
            RadAutoCompleteBox1.AutoCompleteItems.Add("Item" & i)
        Next i
        AddHandler RadAutoCompleteBox1.TextBoxElement.AutoCompleteDropDown.PopupClosing, AddressOf AutoCompleteDropDown_PopupClosing
        RadAutoCompleteBox1.ListElement.ItemHeight = 30
    End Sub

    Private Sub AutoCompleteDropDown_PopupClosing(ByVal sender As Object, ByVal args As RadPopupClosingEventArgs)
        If args.CloseReason = RadPopupCloseReason.Mouse Then
            Dim popup = TryCast(sender, RadTextBoxAutoCompleteDropDown)
            Dim mousePosition As Point = popup.PointToClient(Control.MousePosition)
            Dim item = TryCast(RadAutoCompleteBox1.ListElement.GetVisualItemAtPoint(mousePosition), CustomVisualItem)
            If item IsNot Nothing Then
                If item.RemoveButton.BoundingRectangle.Contains(mousePosition) Then
                    args.Cancel = True
                End If
            End If

        End If
    End Sub

    Private Sub ListElement_CreatingVisualItem(ByVal sender As Object, ByVal args As CreatingVisualListItemEventArgs)
        args.VisualItem = New CustomVisualItem()
    End Sub
End Class

Public Class CustomVisualItem
    Inherits RadListVisualItem

    Private _removeButton As LightVisualElement

    Protected Overrides ReadOnly Property ThemeEffectiveType() As Type
        Get
            Return GetType(RadListVisualItem)
        End Get
    End Property

    Public ReadOnly Property RemoveButton() As LightVisualElement
        Get
            Return Me._removeButton
        End Get
    End Property

    Protected Overrides Sub CreateChildElements()
        MyBase.CreateChildElements()
        _removeButton = New LightVisualElement()
        _removeButton.DrawImage = True
        _removeButton.Image = Image.FromFile("..\..\delete.png").GetThumbnailImage(25, 25, Nothing, IntPtr.Zero)
        AddHandler _removeButton.Click, AddressOf RemoveButton_Click
        _removeButton.ImageAlignment = ContentAlignment.MiddleRight
        _removeButton.NotifyParentOnMouseInput = False
        _removeButton.ShouldHandleMouseInput = True
        _removeButton.StretchHorizontally = False

        Me.Children.Add(_removeButton)
    End Sub

    Private Sub RemoveButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim list = Me.FindAncestor(Of RadListElement)()
        list.Items.Remove(Me.Data)
    End Sub
    Protected Overrides Function ArrangeOverride(ByVal finalSize As SizeF) As SizeF
        Dim result = MyBase.ArrangeOverride(finalSize)
        Dim rectangle = New RectangleF(finalSize.Width - _removeButton.DesiredSize.Width, 0, _removeButton.DesiredSize.Width, _removeButton.DesiredSize.Height)
        _removeButton.Arrange(rectangle)
        Return result
    End Function
End Class

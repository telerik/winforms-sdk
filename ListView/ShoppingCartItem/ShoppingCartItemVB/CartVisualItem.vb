Option Infer On

Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports Telerik.WinControls.UI


Public Class CartVisualItem
    Inherits SimpleListViewVisualItem

    Private buttonElement1 As RadButtonElement
    Private buttonElement2 As RadButtonElement
    Private titleElement As LightVisualElement
    Private descriptionElement As LightVisualElement
    Private priceElement As LightVisualElement
    Private amountElement As RadLabelElement
    Private stackLayout As StackLayoutElement
    Private stackLayout2 As StackLayoutElement
    Private stackLayout3 As StackLayoutElement

    Protected Overrides Sub CreateChildElements()
        MyBase.CreateChildElements()
        'left part
        Me.stackLayout = New StackLayoutElement()
        Me.stackLayout.Orientation = Orientation.Vertical
        Me.stackLayout.ShouldHandleMouseInput = False
        Me.stackLayout.NotifyParentOnMouseInput = True
        Me.stackLayout.StretchHorizontally = True

        Me.titleElement = New LightVisualElement()
        Me.titleElement.Font = New Font("Segoe UI", 12, FontStyle.Regular)
        Me.titleElement.TextAlignment = ContentAlignment.MiddleLeft
        Me.titleElement.StretchHorizontally = True
        Me.titleElement.ShouldHandleMouseInput = False
        Me.titleElement.NotifyParentOnMouseInput = True

        Me.priceElement = New LightVisualElement()
        Me.priceElement.StretchHorizontally = True
        Me.priceElement.TextAlignment = ContentAlignment.MiddleLeft
        Me.priceElement.ShouldHandleMouseInput = False
        Me.priceElement.NotifyParentOnMouseInput = True

        Me.descriptionElement = New LightVisualElement()
        Me.descriptionElement.StretchHorizontally = True
        Me.descriptionElement.Font = New Font("Segoe UI", 7, FontStyle.Regular)
        Me.descriptionElement.TextAlignment = ContentAlignment.MiddleLeft
        Me.descriptionElement.ShouldHandleMouseInput = False
        Me.descriptionElement.NotifyParentOnMouseInput = True

        Me.stackLayout.Children.Add(Me.titleElement)
        Me.stackLayout.Children.Add(Me.priceElement)
        Me.stackLayout.Children.Add(Me.descriptionElement)

        'right part

        Me.stackLayout2 = New StackLayoutElement()
        Me.stackLayout2.Orientation = Orientation.Horizontal
        Me.stackLayout2.ShouldHandleMouseInput = False
        Me.stackLayout2.NotifyParentOnMouseInput = True
        Me.stackLayout2.StretchHorizontally = True
        Me.stackLayout2.StretchVertically = True

        Me.buttonElement1 = New RadButtonElement()
        Me.buttonElement1.Text = "-"
        Me.buttonElement1.Margin = New Padding(15)
        AddHandler Me.buttonElement1.Click, AddressOf ButtonElement1_Click
        Me.stackLayout2.Children.Add(Me.buttonElement1)

        Me.amountElement = New RadLabelElement()
        Me.amountElement.Margin = New Padding(15)

        Me.amountElement.TextAlignment = ContentAlignment.MiddleCenter
        Me.stackLayout2.Children.Add(amountElement)

        Me.buttonElement2 = New RadButtonElement()
        Me.buttonElement2.Margin = New Padding(15)
        Me.buttonElement2.Text = "+"
        AddHandler Me.buttonElement2.Click, AddressOf ButtonElement2_Click
        Me.stackLayout2.Children.Add(Me.buttonElement2)

        'combine
        Me.stackLayout3 = New StackLayoutElement()
        Me.stackLayout3.Orientation = Orientation.Horizontal
        Me.stackLayout3.ShouldHandleMouseInput = False
        Me.stackLayout3.NotifyParentOnMouseInput = True
        Me.stackLayout3.StretchHorizontally = True

        Me.stackLayout3.Children.Add(stackLayout)
        Me.stackLayout3.Children.Add(stackLayout2)
        Me.Children.Add(Me.stackLayout3)
    End Sub

    Private Sub ButtonElement2_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim data = TryCast(Me.Data.DataBoundItem, OrderItem)
        data.Amount += 1

    End Sub

    Private Sub ButtonElement1_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim data = TryCast(Me.Data.DataBoundItem, OrderItem)
        data.Amount -= 1

    End Sub

    Protected Overrides Sub SynchronizeProperties()
        MyBase.SynchronizeProperties()

        Me.Text = ""
        Dim data = TryCast(Me.Data.DataBoundItem, OrderItem)
        Me.titleElement.Text = data.Name
        Me.amountElement.Text = data.Amount.ToString()
        Me.priceElement.Text = data.Price.ToString("C")
        Me.descriptionElement.Text = data.QuantityPerUnit
    End Sub

    Protected Overrides ReadOnly Property ThemeEffectiveType() As Type
        Get
            Return GetType(SimpleListViewVisualItem)
        End Get
    End Property
End Class


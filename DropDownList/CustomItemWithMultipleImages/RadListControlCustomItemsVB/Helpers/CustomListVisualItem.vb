Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Primitives
Imports Telerik.WinControls.Layouts
Imports Telerik.WinControls.Enumerations
Imports Telerik.WinControls

''' <summary>
''' The custom list visual item.
''' </summary>
Public Class CustomListVisualItem
    Inherits RadListVisualItem
#Region "Constants and Fields"

    ''' <summary>
    ''' The label.
    ''' </summary>
    Private label As RadLabelElement

    ''' <summary>
    ''' The image.
    ''' </summary>
    Private Shadows image As ImagePrimitive

    ''' <summary>
    ''' The image 2.
    ''' </summary>
    Private image2 As ImagePrimitive

#End Region

#Region "Constructors and Destructors"

    ''' <summary>
    ''' Initializes static members of the <see cref="CustomListVisualItem"/> class.
    ''' </summary>
    Shared Sub New()
        SynchronizationProperties.Add(CustomListDataItem.ImageProperty)
        SynchronizationProperties.Add(CustomListDataItem.Image2Property)
        SynchronizationProperties.Add(CustomListDataItem.NameProperty)
    End Sub

#End Region

#Region "Properties"

    ''' <summary>
    ''' Gets ThemeEffectiveType.
    ''' </summary>
    Protected Overrides ReadOnly Property ThemeEffectiveType() As Type
        Get
            Return GetType(RadListVisualItem)
        End Get
    End Property

#End Region

#Region "Methods"

    ''' <summary>
    ''' The create child elements.
    ''' </summary>
    Protected Overrides Sub CreateChildElements()
        MyBase.CreateChildElements()

        label = New RadLabelElement()
        image = New ImagePrimitive()
        image2 = New ImagePrimitive()

        Me.label.StretchHorizontally = True

        Dim stack = New StackLayoutPanel() With { _
         .Orientation = Orientation.Horizontal _
        }

        Me.image.ImageScaling = ImageScaling.SizeToFit
        Me.image2.ImageScaling = ImageScaling.SizeToFit

        stack.Children.Add(Me.label)
        stack.Children.Add(Me.image)
        stack.Children.Add(Me.image2)

        Me.Children.Add(stack)
    End Sub

    ''' <summary>
    ''' The property synchronized.
    ''' </summary>
    ''' <param name="property">
    ''' The property.
    ''' </param>
    Protected Overrides Sub PropertySynchronized(ByVal [property] As RadProperty)
        Dim dataItem = DirectCast(Me.Data, CustomListDataItem)
        Dim boItem = TryCast(dataItem.DataBoundItem, BussinessObject)

        If boItem Is Nothing Then
            Return
        End If

        Me.image2.Image = boItem.Image2
        Me.image.Image = boItem.Image
        Me.label.Text = boItem.Name
    End Sub

#End Region
End Class
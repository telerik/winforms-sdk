Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports System.ComponentModel

''' <summary>
''' The custom list data item.
''' </summary>
Public Class CustomListDataItem
    Inherits RadListDataItem
#Region "Constants and Fields"

    ''' <summary>
    ''' The image property.
    ''' </summary>
    Public Shared ReadOnly ImageProperty As RadProperty = RadProperty.Register("Image", GetType(Image), GetType(CustomListDataItem), New RadElementPropertyMetadata(Nothing))

    ''' <summary>
    ''' The image 2 property.
    ''' </summary>
    Public Shared ReadOnly Image2Property As RadProperty = RadProperty.Register("Image2", GetType(Image), GetType(CustomListDataItem), New RadElementPropertyMetadata(Nothing))

    ''' <summary>
    ''' The name property.
    ''' </summary>
    Public Shared ReadOnly NameProperty As RadProperty = RadProperty.Register("Name", GetType(String), GetType(CustomListDataItem), New RadElementPropertyMetadata(String.Empty))

#End Region

#Region "Properties"

    ''' <summary>
    ''' Gets or sets Image.
    ''' </summary>
    Public Shadows Property Image() As Image
        Get
            Return DirectCast(Me.GetValue(ImageProperty), Image)
        End Get

        Set(ByVal value As Image)
            Me.SetValue(ImageProperty, value)
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets Image2.
    ''' </summary>
    Public Property Image2() As Image
        Get
            Return DirectCast(Me.GetValue(Image2Property), Image)
        End Get

        Set(ByVal value As Image)
            Me.SetValue(Image2Property, value)
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets Name.
    ''' </summary>
    Public Property Name() As String
        Get
            Return DirectCast(Me.GetValue(NameProperty), String)
        End Get

        Set(ByVal value As String)
            Me.SetValue(NameProperty, value)
        End Set
    End Property

#End Region

#Region "Methods"

    ''' <summary>
    ''' The set data bound item.
    ''' </summary>
    ''' <param name="dataBinding">
    ''' The data binding.
    ''' </param>
    ''' <param name="value">
    ''' The value.
    ''' </param>
    Protected Overrides Sub SetDataBoundItem(ByVal dataBinding As Boolean, ByVal value As Object)
        MyBase.SetDataBoundItem(dataBinding, value)
        If TypeOf value Is INotifyPropertyChanged Then
            Dim item = TryCast(value, INotifyPropertyChanged)
            AddHandler item.PropertyChanged, AddressOf item_PropertyChanged
        End If
    End Sub

    ''' <summary>
    ''' The item_ property changed.
    ''' </summary>
    ''' <param name="sender">
    ''' The sender.
    ''' </param>
    ''' <param name="e">
    ''' The e.
    ''' </param>
    Private Sub item_PropertyChanged(ByVal sender As Object, ByVal e As PropertyChangedEventArgs)
        If e.PropertyName = "Image" Then
            Me.Image = TryCast(Me.DataBoundItem, BussinessObject).Image
        End If

        If e.PropertyName = "Image2" Then
            Me.Image2 = TryCast(Me.DataBoundItem, BussinessObject).Image2
        End If

        If e.PropertyName = "Name" Then
            Me.Name = TryCast(Me.DataBoundItem, BussinessObject).Name
        End If
    End Sub

#End Region
End Class
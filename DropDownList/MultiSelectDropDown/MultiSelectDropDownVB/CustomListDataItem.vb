Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports System.ComponentModel

Public Class CustomListDataItem
    Inherits RadListDataItem
#Region "RadProperties"

    Public Shared ReadOnly CheckedProperty As RadProperty = RadProperty.Register("Checked", GetType(Boolean), GetType(CustomListDataItem), New RadElementPropertyMetadata(False))

#End Region

#Region "Properties"

    Public Property Checked() As Boolean
        Get
            Return CBool(Me.GetValue(CustomListDataItem.CheckedProperty))
        End Get
        Set(value As Boolean)
            Me.SetValue(CustomListDataItem.CheckedProperty, value)
        End Set
    End Property

    Protected Overrides Sub OnPropertyChanged(e As RadPropertyChangedEventArgs)
        MyBase.OnPropertyChanged(e)
    End Sub

#End Region

#Region "Overrides"

    Protected Overrides Sub SetDataBoundItem(dataBinding As Boolean, value As Object)
        MyBase.SetDataBoundItem(dataBinding, value)
        If TypeOf value Is INotifyPropertyChanged Then
            Dim item As INotifyPropertyChanged = TryCast(value, INotifyPropertyChanged)
            AddHandler item.PropertyChanged, AddressOf item_PropertyChanged
        End If
    End Sub

#End Region

#Region "Private Methods"

    Private Sub item_PropertyChanged(sender As Object, e As PropertyChangedEventArgs)
        If e.PropertyName = "Checked" Then
            Me.Checked = TryCast(Me.DataBoundItem, RadListDataItem).Selected
        End If
    End Sub
#End Region
End Class
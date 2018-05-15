Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks


Friend Class OrderItem
    Implements INotifyPropertyChanged


    Private name_ As String

    Private quantityPerUnit_ As String

    Private price_ As Decimal

    Private amount_ As Integer

    Public Property Name() As String
        Get
            Return name_
        End Get
        Set(ByVal value As String)
            name_ = value
            OnPropertyChanged("Name")
        End Set
    End Property

    Public Property QuantityPerUnit() As String
        Get
            Return quantityPerUnit_
        End Get
        Set(ByVal value As String)
            quantityPerUnit_ = value
            OnPropertyChanged("QuantityPerUnit")
        End Set
    End Property

    Public Property Price() As Decimal
        Get
            Return price_
        End Get
        Set(ByVal value As Decimal)
            price_ = value
            OnPropertyChanged("Price")
        End Set
    End Property

    Public Property Amount() As Integer
        Get
            Return amount_
        End Get
        Set(ByVal value As Integer)
            amount_ = value
            OnPropertyChanged("Amount")
        End Set
    End Property

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Protected Overridable Sub OnPropertyChanged(ByVal propertyName As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub
End Class



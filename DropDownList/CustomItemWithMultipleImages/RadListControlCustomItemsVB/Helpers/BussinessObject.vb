Imports System.ComponentModel

''' <summary>
''' The bussiness object.
''' </summary>
Public Class BussinessObject
    Implements INotifyPropertyChanged

#Region "Constants and Fields"

    ''' <summary>
    ''' The image.
    ''' </summary>
    Private m_image As Image

    ''' <summary>
    ''' The image 2.
    ''' </summary>
    Private m_image2 As Image

    ''' <summary>
    ''' The name.
    ''' </summary>
    Private m_name As String

#End Region

#Region "Events"

    ''' <summary>
    ''' The property changed.
    ''' </summary>
    Public Event PropertyChanged(ByVal sender As Object, ByVal e As System.ComponentModel.PropertyChangedEventArgs) _
                Implements INotifyPropertyChanged.PropertyChanged

#End Region

#Region "Properties"

    ''' <summary>
    ''' Gets or sets Image.
    ''' </summary>
    Public Property Image() As Image
        Get
            Return Me.m_image
        End Get

        Set(ByVal value As Image)
            Me.m_image = value
            Me.OnNotifyPropertyChanged("Image")
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets Image2.
    ''' </summary>
    Public Property Image2() As Image
        Get
            Return Me.m_image2
        End Get

        Set(ByVal value As Image)
            Me.m_image2 = value
            Me.OnNotifyPropertyChanged("Image2")
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets Name.
    ''' </summary>
    Public Property Name() As String
        Get
            Return Me.m_name
        End Get

        Set(ByVal value As String)
            If Me.m_name = value Then
                Return
            End If

            Me.m_name = value
            Me.OnNotifyPropertyChanged("Name")
        End Set
    End Property

#End Region

#Region "Methods"

    ''' <summary>
    ''' The on notify property changed.
    ''' </summary>
    ''' <param name="property">
    ''' The property.
    ''' </param>
    Private Sub OnNotifyPropertyChanged(ByVal [property] As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs([property]))
    End Sub

#End Region

End Class
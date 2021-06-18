Public Class Customer
    Private id_Renamed As Integer
    Private name_Renamed As String
    Private address_Renamed As String

    Public Property Id() As Integer
        Get
            Return id_Renamed
        End Get
        Set(ByVal value As Integer)
            id_Renamed = value
        End Set
    End Property

    Public Property Name() As String
        Get
            Return name_Renamed
        End Get
        Set(ByVal value As String)
            name_Renamed = value
        End Set
    End Property

    Public Property Address() As String
        Get
            Return address_Renamed
        End Get
        Set(ByVal value As String)
            address_Renamed = value
        End Set
    End Property

    Public Sub New(ByVal id As Integer, ByVal name As String, ByVal address As String)
        Me.id_Renamed = id
        Me.name_Renamed = name
        Me.address_Renamed = address
    End Sub
End Class

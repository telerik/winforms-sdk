<Serializable> _
Public Class Album
    Private m_id As Integer
    Private m_artistId As Integer
    Private m_title As String
    Private m_tracks As New List(Of Track)()


    Public Sub New()
    End Sub

    Public Sub New(id As Integer, artistId As Integer, title As String)
        Me.m_id = id
        Me.m_artistId = artistId
        Me.m_title = title
    End Sub

    Public Property Id() As Integer
        Get
            Return m_id
        End Get
        Set(value As Integer)
            m_id = value
        End Set
    End Property

    Public Property ArtistId() As Integer
        Get
            Return m_artistId
        End Get
        Set(value As Integer)
            m_artistId = value
        End Set
    End Property

    Public Property Title() As String
        Get
            Return m_title
        End Get
        Set(value As String)
            m_title = value
        End Set
    End Property

    Public ReadOnly Property Tracks() As List(Of Track)
        Get
            Return Me.m_tracks
        End Get
    End Property
End Class

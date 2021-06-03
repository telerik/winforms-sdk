<Serializable> _
Public Class Track
    Private m_id As Integer
    Private m_name As String
    Private m_mediaType As String
    Private m_genre As String
    Private m_size As String


    Public Sub New()
    End Sub

    Public Sub New(id As Integer, name As String, mediaType As String, genre As String, size As String)
        Me.m_id = id
        Me.m_name = name
        Me.m_mediaType = mediaType
        Me.m_genre = genre
        Me.m_size = size
    End Sub

    Public Property Id() As Integer
        Get
            Return m_id
        End Get
        Set(value As Integer)
            m_id = value
        End Set
    End Property

    Public Property Name() As String
        Get
            Return m_name
        End Get
        Set(value As String)
            m_name = value
        End Set
    End Property

    Public Property MediaType() As String
        Get
            Return m_mediaType
        End Get
        Set(value As String)
            m_mediaType = value
        End Set
    End Property

    Public Property Genre() As String
        Get
            Return m_genre
        End Get
        Set(value As String)
            m_genre = value
        End Set
    End Property

    Public Property Size() As String
        Get
            Return m_size
        End Get
        Set(value As String)
            m_size = value
        End Set
    End Property
End Class
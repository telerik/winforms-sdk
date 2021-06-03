<Serializable> _
Public Class Artist
    Private m_id As Integer
    Private m_name As String
    Private m_albums As New List(Of Album)()


    Public Sub New()
    End Sub

    Public Sub New(id As Integer, name As String)
        Me.m_id = id
        Me.m_name = name
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

    Public ReadOnly Property Albums() As List(Of Album)
        Get
            Return m_albums
        End Get
    End Property
End Class
Public Class Order
    Public Property OrderId() As Integer
        Get
            Return m_OrderId
        End Get
        Set(value As Integer)
            m_OrderId = Value
        End Set
    End Property
    Private m_OrderId As Integer

    Public Property OrderTypeId() As Integer
        Get
            Return m_OrderTypeId
        End Get
        Set(value As Integer)
            m_OrderTypeId = Value
        End Set
    End Property
    Private m_OrderTypeId As Integer

    Public Overridable Property OrderType() As OrderType
        Get
            Return m_OrderType
        End Get
        Set(value As OrderType)
            m_OrderType = Value
        End Set
    End Property
    Private m_OrderType As OrderType

    Public Property Description() As String
        Get
            Return m_Description
        End Get
        Set(value As String)
            m_Description = Value
        End Set
    End Property
    Private m_Description As String

    Public Property IsFinished() As Boolean
        Get
            Return m_IsFinished
        End Get
        Set(value As Boolean)
            m_IsFinished = Value
        End Set
    End Property
    Private m_IsFinished As Boolean
End Class

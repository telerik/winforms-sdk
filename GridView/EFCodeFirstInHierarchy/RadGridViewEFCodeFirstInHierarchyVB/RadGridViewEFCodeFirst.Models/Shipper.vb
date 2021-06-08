Public Class Shipper
    Public Property ShipperId() As Integer
        Get
            Return m_ShipperId
        End Get
        Set(value As Integer)
            m_ShipperId = Value
        End Set
    End Property
    Private m_ShipperId As Integer

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

    Public Property Name() As String
        Get
            Return m_Name
        End Get
        Set(value As String)
            m_Name = Value
        End Set
    End Property
    Private m_Name As String

    Public Property Address() As String
        Get
            Return m_Address
        End Get
        Set(value As String)
            m_Address = Value
        End Set
    End Property
    Private m_Address As String
End Class

Public Class OrderType
    Private m_orders As ICollection(Of Order)
    Private m_shippers As ICollection(Of Shipper)

    Public Sub New()
        Me.m_orders = New HashSet(Of Order)()
        Me.m_shippers = New HashSet(Of Shipper)()
    End Sub

    Public Property OrderTypeId() As Integer
        Get
            Return m_OrderTypeId
        End Get
        Set(value As Integer)
            m_OrderTypeId = Value
        End Set
    End Property
    Private m_OrderTypeId As Integer

    Public Overridable Property Orders() As ICollection(Of Order)
        Get
            Return Me.m_orders
        End Get
        Set(value As ICollection(Of Order))
            Me.m_orders = value
        End Set
    End Property

    Public Overridable Property Shippers() As ICollection(Of Shipper)
        Get
            Return Me.m_shippers
        End Get
        Set(value As ICollection(Of Shipper))
            Me.m_shippers = value
        End Set
    End Property

    Public Property Description() As String
        Get
            Return m_Description
        End Get
        Set(value As String)
            m_Description = Value
        End Set
    End Property
    Private m_Description As String
End Class

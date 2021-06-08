Imports System.Data.Entity
Imports RadGridViewEFCodeFirst.Models

Public Class RadGridViewEFCodeFirstContext
    Inherits DbContext
    Implements IRadGridViewEFCodeFirstContext

    Public Sub New()
        MyBase.New("RadGridViewEFCodeFirstConnection")
        Database.SetInitializer(New MigrateDatabaseToLatestVersion(Of RadGridViewEFCodeFirstContext, Migrations.Configuration)())
    End Sub

    Public Property Orders() As IDbSet(Of Order) Implements IRadGridViewEFCodeFirstContext.Orders
        Get
            Return m_Orders
        End Get
        Set(value As IDbSet(Of Order))
            m_Orders = value
        End Set
    End Property
    Private m_Orders As IDbSet(Of Order)

    Public Property OrderTypes() As IDbSet(Of OrderType) Implements IRadGridViewEFCodeFirstContext.OrderTypes
        Get
            Return m_OrderTypes
        End Get
        Set(value As IDbSet(Of OrderType))
            m_OrderTypes = value
        End Set
    End Property
    Private m_OrderTypes As IDbSet(Of OrderType)

    Public Property Shippers() As IDbSet(Of Shipper) Implements IRadGridViewEFCodeFirstContext.Shippers
        Get
            Return m_Shippers
        End Get
        Set(value As IDbSet(Of Shipper))
            m_Shippers = value
        End Set
    End Property
    Private m_Shippers As IDbSet(Of Shipper)

    Public Shadows Function [Set](Of T As Class)() As IDbSet(Of T) Implements IRadGridViewEFCodeFirstContext.Set
        Return MyBase.[Set](Of T)()
    End Function

    Public Shadows Sub SaveChanges() Implements IRadGridViewEFCodeFirstContext.SaveChanges
        MyBase.SaveChanges()
    End Sub

    Public Overloads Function Entry(Of T As Class)(entity As T) As Infrastructure.DbEntityEntry(Of T) Implements IRadGridViewEFCodeFirstContext.Entry
        Return MyBase.[Entry](Of T)(entity)
    End Function

End Class

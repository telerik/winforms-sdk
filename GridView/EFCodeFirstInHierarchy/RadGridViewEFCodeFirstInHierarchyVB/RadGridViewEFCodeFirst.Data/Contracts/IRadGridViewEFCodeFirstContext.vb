Imports System.Data.Entity
Imports RadGridViewEFCodeFirst.Models
Imports System.Data.Entity.Infrastructure

Public Interface IRadGridViewEFCodeFirstContext
    Property Orders() As IDbSet(Of Order)

    Property OrderTypes() As IDbSet(Of OrderType)

    Property Shippers() As IDbSet(Of Shipper)

    Function [Set](Of T As Class)() As IDbSet(Of T)

    Function Entry(Of T As Class)(entity As T) As DbEntityEntry(Of T)

    Sub SaveChanges()
End Interface

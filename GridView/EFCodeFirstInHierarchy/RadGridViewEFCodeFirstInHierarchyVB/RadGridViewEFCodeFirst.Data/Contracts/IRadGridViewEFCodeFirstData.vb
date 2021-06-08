Imports RadGridViewEFCodeFirst.Models

Public Interface IRadGridViewEFCodeFirstData
    ReadOnly Property Orders() As IGenericRepository(Of Order)

    ReadOnly Property OrderTypes() As IGenericRepository(Of OrderType)

    ReadOnly Property Shippers() As IGenericRepository(Of Shipper)

    Sub SaveChanges()
End Interface


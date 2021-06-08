Imports RadGridViewEFCodeFirst.Models

Public Class RadGridViewEFCodeFirstData
    Implements IRadGridViewEFCodeFirstData

    Private context As IRadGridViewEFCodeFirstContext
    Private repositories As IDictionary(Of Type, Object)

    Public Sub New()
        Me.New(New RadGridViewEFCodeFirstContext())
    End Sub

    Public Sub New(context As IRadGridViewEFCodeFirstContext)
        Me.context = context
        Me.repositories = New Dictionary(Of Type, Object)()
    End Sub

    Public ReadOnly Property Orders() As IGenericRepository(Of Order) Implements IRadGridViewEFCodeFirstData.Orders
        Get
            Return Me.GetRepository(Of Order)()
        End Get
    End Property

    Public ReadOnly Property OrderTypes() As IGenericRepository(Of OrderType) Implements IRadGridViewEFCodeFirstData.OrderTypes
        Get
            Return Me.GetRepository(Of OrderType)()
        End Get
    End Property

    Public ReadOnly Property Shippers() As IGenericRepository(Of Shipper) Implements IRadGridViewEFCodeFirstData.Shippers
        Get
            Return Me.GetRepository(Of Shipper)()
        End Get
    End Property

    Public Sub SaveChanges() Implements IRadGridViewEFCodeFirstData.SaveChanges
        Me.context.SaveChanges()
    End Sub

    Private Function GetRepository(Of T As Class)() As IGenericRepository(Of T)
        Dim typeOfModel = GetType(T)
        If Not Me.repositories.ContainsKey(typeOfModel) Then
            Dim type = GetType(RadGridViewEFCodeFirstRepository(Of T))

            Me.repositories.Add(typeOfModel, Activator.CreateInstance(type, Me.context))
        End If

        Return DirectCast(Me.repositories(typeOfModel), IGenericRepository(Of T))
    End Function
End Class

#Region "MockRepository"
Public Class VirtualGridRepository
    Private rand As Random = New Random()
    Private _orders As IQueryable(Of OrderDataModel)
    Private _columnNames As String() = New String() {"OrderId", "OrderDetails", "ProductId", "ClientId", "ShipAddress", "ShippingType"}

    Public ReadOnly Property Orders As IQueryable(Of OrderDataModel)
        Get

            If Me._orders Is Nothing Then
                Me.GenerateData()
            End If

            Return Me._orders
        End Get
    End Property

    Public ReadOnly Property ColumnNames As String()
        Get
            Return Me._columnNames
        End Get
    End Property

    Private Function GenerateData() As IQueryable(Of OrderDataModel)
        Dim data As IList(Of OrderDataModel) = New List(Of OrderDataModel)()

        For i As Integer = 0 To 1000 - 1
            data.Add(New OrderDataModel With {
                .OrderId = i,
                .OrderDetails = "Order " & i,
                .ProductId = Me.rand.[Next](1000),
                .ClientId = Me.rand.[Next](1000),
                .ShipAddress = "Address " & i,
                .ShippingType = CType(rand.[Next](3), ShippingType)
            })
        Next

        Me._orders = data.AsQueryable()
        Return Orders
    End Function
End Class
#End Region
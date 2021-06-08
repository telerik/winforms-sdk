Imports RadGridViewEFCodeFirst.Models

Public Class DataGenerator
    Public Shared Sub PopulateData(data As IRadGridViewEFCodeFirstData)
        For i As Integer = 1 To 100
            Dim orderType As New OrderType() With {
                 .OrderTypeId = i,
                 .Description = "Test" & i
            }

            Dim order As New Order() With {
                 .OrderId = i, _
                 .Description = "Description" & i,
                 .OrderTypeId = orderType.OrderTypeId
            }

            Dim shipper As New Shipper() With {
                 .ShipperId = i,
                 .Name = "Name" & i,
                 .OrderTypeId = orderType.OrderTypeId,
                 .Address = "Address" & i
            }

            data.OrderTypes.Add(orderType)
            data.Orders.Add(order)
            data.Shippers.Add(shipper)

            If i Mod 10 = 0 Then
                data.SaveChanges()
            End If
        Next

        data.SaveChanges()
    End Sub
End Class
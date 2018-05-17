#Region "DataModel"
Public Class OrderDataModel
    Public Property OrderId As Integer
    Public Property OrderDetails As String
    Public Property ProductId As Integer
    Public Property ClientId As Integer
    Public Property ShipAddress As String
    Public Property ShippingType As ShippingType

    Default Public ReadOnly Property Item(ByVal i As Integer) As Object
        Get

            Select Case i
                Case 0
                    Return OrderId
                Case 1
                    Return OrderDetails
                Case 2
                    Return ProductId
                Case 3
                    Return ClientId
                Case 4
                    Return ShipAddress
                Case 5
                    Return ShippingType
                Case Else
                    Return String.Empty
            End Select
        End Get
    End Property
End Class

Public Enum ShippingType
    None
    Plane
    Truck
End Enum

#End Region
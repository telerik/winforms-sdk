Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace CustomMergeField
	Public Class Customer
		Public Property FirstName() As String
		Public Property LastName() As String

		Public Property HasOrders() As Boolean
		Public Property Orders() As List(Of Order)
	End Class
End Namespace

Imports Telerik.WinControls.UI
Imports System.ComponentModel

Public Class RadForm1
    Private radDataEntry1 As RadDataEntry = New RadDataEntry()

    Sub New()

        InitializeComponent()

        Me.Controls.Add(radDataEntry1)
        radDataEntry1.Location = New Point(10, 10)
        radDataEntry1.Anchor = AnchorStyles.Left Or AnchorStyles.Bottom
        Me.radDataEntry1.DataSource = New List(Of Person) From {
            New Person("Smith", "John", New DateTime(1980, 1, 1), 12345, "452 Holly Lane Hopewell, VA 23860")
        }
        Me.radDataEntry1.DataSource = New DataEntrySort(Of OrderedPerson) From {
            New OrderedPerson("Smith", "John", New DateTime(1980, 1, 1), 12345, "452 Holly Lane Hopewell, VA 23860")
        }

    End Sub

    Public Class Person
        Public Property LastName As String
        Public Property FirstName As String
        Public Property BirthDate As DateTime
        Public Property Id As Integer
        Public Property Address As String

        Public Sub New(ByVal lastName As String, ByVal firstName As String, ByVal dateOfBirth As DateTime, ByVal id As Integer, ByVal address As String)
            Me.LastName = lastName
            Me.FirstName = firstName
            Me.BirthDate = dateOfBirth
            Me.Id = id
            Me.Address = address
        End Sub
    End Class

    Public Class OrderedPerson
        <RadSortOrder(3)>
        Public Property LastName As String
        <RadSortOrder(2)>
        Public Property FirstName As String
        <RadSortOrder(4)>
        Public Property BirthDate As DateTime
        <RadSortOrder(1)>
        Public Property Id As Integer
        <RadSortOrder(5)>
        Public Property Address As String

        Public Sub New(ByVal lastName As String, ByVal firstName As String, ByVal dateOfBirth As DateTime, ByVal id As Integer, ByVal address As String)
            Me.LastName = lastName
            Me.FirstName = firstName
            Me.BirthDate = dateOfBirth
            Me.Id = id
            Me.Address = address
        End Sub
    End Class

    Public Class PropertyDescriptorComparer
        Implements System.Collections.IComparer

 
        Public Function [Compare](x As Object, y As Object) As Integer Implements IComparer.[Compare]
            If x.Equals(y) Then Return 0
            If x Is Nothing Then Return 1
            If y Is Nothing Then Return -1
            Dim propertyDescriptorX As PropertyDescriptor = TryCast(x, PropertyDescriptor)
            Dim propertyDescriptorY As PropertyDescriptor = TryCast(y, PropertyDescriptor)
            Dim propertyOrderAttributeX As RadSortOrderAttribute = TryCast(propertyDescriptorX.Attributes(GetType(RadSortOrderAttribute)), RadSortOrderAttribute)
            Dim propertyOrderAttributeY As RadSortOrderAttribute = TryCast(propertyDescriptorY.Attributes(GetType(RadSortOrderAttribute)), RadSortOrderAttribute)
            If Equals(propertyOrderAttributeX, propertyOrderAttributeY) Then Return 0
            If propertyOrderAttributeX Is Nothing Then Return 1
            If propertyOrderAttributeY Is Nothing Then Return -1
            Return propertyOrderAttributeX.Value.CompareTo(propertyOrderAttributeY.Value)
        End Function

    End Class

    Public Class DataEntrySort(Of T)
        Inherits BindingList(Of T)
        Implements ITypedList
        Public Function GetItemProperties(listAccessors As PropertyDescriptor()) As PropertyDescriptorCollection Implements ITypedList.GetItemProperties
            Dim typePropertiesCollection As PropertyDescriptorCollection = TypeDescriptor.GetProperties(GetType(T))
            Return typePropertiesCollection.Sort(New PropertyDescriptorComparer())
        End Function

        Public Function GetListName(listAccessors As PropertyDescriptor()) As String Implements ITypedList.GetListName
            Return String.Format("A list with Properties for {0}", GetType(T).Name)
        End Function

    End Class

End Class

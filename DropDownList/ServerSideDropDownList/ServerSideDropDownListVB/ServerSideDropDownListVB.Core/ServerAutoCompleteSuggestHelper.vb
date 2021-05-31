Imports Telerik.WinControls.UI

Public Class ServerAutoCompleteSuggestHelper(Of T)
    Inherits AutoCompleteSuggestHelper
    Public Property Data() As IQueryable(Of T)
        Get
            Return m_Data
        End Get
        Private Set(value As IQueryable(Of T))
            m_Data = value
        End Set
    End Property
    Private m_Data As IQueryable(Of T)
    Public Property MaxItems() As Integer
        Get
            Return m_MaxItems
        End Get
        Set(value As Integer)
            m_MaxItems = value
        End Set
    End Property
    Private m_MaxItems As Integer

    Public Sub New(owner As RadDropDownListElement, data As IEnumerable(Of T), Optional maxItems As Integer = 1000)
        MyBase.New(owner)
        Me.Data = data.AsQueryable()
        Me.MaxItems = maxItems
        ExpressionBuilder.Instance.Optimize(Me.Data)
    End Sub

    Public Overrides Sub ApplyFilterToDropDown(filter As String)
        Me.DropDownList.BeginUpdate()

        Me.DropDownList.ListElement.Items.Clear()

        Dim dataItemsExp = ExpressionBuilder.Instance.BuildContainsExpression(Of T)(Me.Owner.AutoCompleteValueMember, filter)
        Dim dataItemsQuery = Me.Data.Where(dataItemsExp).Take(Me.MaxItems)
        Dim dataItems = dataItemsQuery.ToList()

        Dim selectExp = ExpressionBuilder.Instance.BuildSelectExpression(Of T)(Me.Owner.AutoCompleteValueMember)
        Dim displayItemsQuery = dataItemsQuery.[Select](selectExp)
        Dim displayItems = displayItemsQuery.ToList()

        For i As Integer = 0 To dataItems.Count - 1
            Dim dataItem = dataItems(i)
            Dim displayMember = displayItems(i)
            Me.DropDownList.ListElement.Items.Add(New RadListDataItem(displayMember, dataItem))
        Next

        Me.DropDownList.EndUpdate()
        Me.Owner.SelectionLength = Me.Owner.Text.Length
    End Sub
End Class
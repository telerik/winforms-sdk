Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Layouts
Imports System.ComponentModel
Imports Telerik.WinControls

Public Class DropDownGridFilterCellElement
    Inherits GridFilterCellElement
    Private dropDown As RadDropDownListElement
    Private operatorElement As LightVisualElement
    Private container As StackLayoutPanel
    Private filterValues As BindingList(Of String)
    Private bc As BindingContext
    Public Sub New(column As GridViewDataColumn, row As GridRowElement)
        MyBase.New(column, row)
    End Sub
    Protected Overrides Sub CreateChildElements()
        MyBase.CreateChildElements()
        filterValues = New BindingList(Of String)()
        bc = New Windows.Forms.BindingContext()
        operatorElement = New LightVisualElement()
        container = New StackLayoutPanel()
        dropDown = New RadDropDownListElement()
        dropDown.BindingContext = bc
        dropDown.DropDownStyle = RadDropDownStyle.DropDownList
        AddHandler dropDown.SelectedIndexChanged, AddressOf dropDown_SelectedIndexChanged
        Me.Children.Add(container)
        container.Children.Add(operatorElement)
        container.Children.Add(dropDown)
    End Sub
    Private Sub dropDown_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
        Dim dataColumn As GridViewDataColumn = TryCast(Me.ColumnInfo, GridViewDataColumn)
        If dataColumn.FilterDescriptor Is Nothing Then
            dataColumn.FilterDescriptor = New Telerik.WinControls.Data.FilterDescriptor(Me.ColumnInfo.Name, Telerik.WinControls.Data.FilterOperator.Contains, Nothing)
            dataColumn.FilterDescriptor.IsFilterEditor = True
        End If
        If e.Position > -1 Then
            Me.Value = dropDown.Items(e.Position).Text
            Me.RowInfo.Tag = e.Position
            dataColumn.FilterDescriptor.Value = Me.Value
        End If
        If e.Position = 0 Then
            dataColumn.FilterDescriptor = Nothing
        End If
    End Sub
    Public Overrides Sub Detach()
        RemoveHandler dropDown.SelectedIndexChanged, AddressOf dropDown_SelectedIndexChanged
        MyBase.Detach()
    End Sub
    Protected Overrides Sub SetContentCore(ByVal value As Object)
        MyBase.SetContentCore(value)
        Dim dataColumn As GridViewDataColumn = TryCast(Me.ColumnInfo, GridViewDataColumn)
        If dropDown.DataSource Is Nothing Then
            filterValues.Add("No filter")
            For Each distinctValue As String In dataColumn.DistinctValues
                filterValues.Add(distinctValue)
            Next
            RemoveHandler dropDown.SelectedIndexChanged, AddressOf dropDown_SelectedIndexChanged
            dropDown.DataSource = filterValues
            dropDown.SelectedIndex = 0
            AddHandler dropDown.SelectedIndexChanged, AddressOf dropDown_SelectedIndexChanged
        End If
        Me.DrawText = False
        Me.ForeColor = Color.Transparent
        operatorElement.ForeColor = Color.Black
        If Me.RowInfo.Tag IsNot Nothing AndAlso Me.RowInfo.Tag.ToString() <> dropDown.SelectedIndex.ToString() Then
            RemoveHandler dropDown.SelectedIndexChanged, AddressOf dropDown_SelectedIndexChanged
            dropDown.SelectedIndex = CInt(Me.RowInfo.Tag)
            AddHandler dropDown.SelectedIndexChanged, AddressOf dropDown_SelectedIndexChanged
        End If
        If dataColumn IsNot Nothing AndAlso dataColumn.FilterDescriptor IsNot Nothing Then
            Me.operatorElement.Text = dataColumn.FilterDescriptor.[Operator].ToString()
        Else
            RemoveHandler dropDown.SelectedIndexChanged, AddressOf dropDown_SelectedIndexChanged
            dropDown.SelectedIndex = 0
            AddHandler dropDown.SelectedIndexChanged, AddressOf dropDown_SelectedIndexChanged
        End If
    End Sub
    Protected Overrides Sub UpdateFilterButtonVisibility(ByVal enabled As Boolean)
        enabled = False
        MyBase.UpdateFilterButtonVisibility(enabled)
    End Sub
    Public Overrides Function IsCompatible(ByVal data As GridViewColumn, ByVal context As Object) As Boolean
        Return TypeOf data Is CustomColumn AndAlso TypeOf context Is GridViewFilteringRowInfo
    End Function
End Class

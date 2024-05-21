Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Public Class Form1

    Private _loadOnDemandCellEditor As LoadOnDemandCellEditor

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        InitializeLinesGrid()

        LoadGrid()

    End Sub

    'Load the grid columns, set grid properties, etc.
    Private Sub InitializeLinesGrid()
        Dim gridMultiColumnComboColumn As GridViewMultiComboBoxColumn

        With rgData.MasterTemplate

            .Columns.Clear()
            .AutoGenerateColumns = False

            gridMultiColumnComboColumn = CreateGridMultiComboBoxColumn("COUNTRY", "COUNTRY", "Country", Nothing, "COUNTRY", "COUNTRY", 400)
            .Columns.Add(gridMultiColumnComboColumn)

            'Set MasterGridViewTemplate properties
            .AllowEditRow = True
            .AllowAddNewRow = False
            .EnableGrouping = False
            .AllowColumnChooser = False
            .AllowColumnHeaderContextMenu = False

        End With

        rgData.MultiSelect = True
        rgData.SelectionMode = GridViewSelectionMode.FullRowSelect
        rgData.ShowGroupPanel = False

    End Sub

    'Create GridViewMultiComboBoxColumn with values passed in
    Private Function CreateGridMultiComboBoxColumn(ByVal Name As String, ByVal fieldName As String, ByVal headerText As String, ByVal dataSource As BindingSource, ByVal valueMember As String, ByVal displayMember As String, ByVal width As Integer) As GridViewMultiComboBoxColumn
        Dim multiComboBoxColumn As New GridViewMultiComboBoxColumn

        With multiComboBoxColumn

            .Name = Name
            .FieldName = fieldName
            .HeaderText = headerText
            .DataSource = dataSource
            .ValueMember = valueMember
            .DisplayMember = displayMember
            .Width = width

            'Set default values
            .HeaderTextAlignment = ContentAlignment.BottomLeft
            .DropDownStyle = RadDropDownStyle.DropDown

        End With

        Return multiComboBoxColumn

    End Function

    'Load the grid
    Private Sub LoadGrid()
        Dim rowInfo As GridViewRowInfo

        rowInfo = rgData.Rows.AddNew
        rowInfo.Cells("COUNTRY").Value = "United States of America"

        rowInfo = rgData.Rows.AddNew
        rowInfo.Cells("COUNTRY").Value = "Malta"

        rowInfo = rgData.Rows.AddNew
        rowInfo.Cells("COUNTRY").Value = "Canada"

        rowInfo = rgData.Rows.AddNew
        rowInfo.Cells("COUNTRY").Value = "Spain"

        rowInfo = rgData.Rows.AddNew
        rowInfo.Cells("COUNTRY").Value = "Italy"

    End Sub

    'This event fires when a field is put into edit mode. 
    Private Sub rgData_EditorRequired(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.EditorRequiredEventArgs) Handles rgData.EditorRequired
        Dim currentColumnIndex As Integer
        Dim currentRowIndex As Integer
        Dim country As Object
        Dim columnWidth As Integer

        currentColumnIndex = rgData.Columns.IndexOf(rgData.CurrentColumn)

        Select Case currentColumnIndex

            Case rgData.Columns("COUNTRY").Index

                currentRowIndex = rgData.Rows.IndexOf(rgData.CurrentRow)
                country = rgData.Rows(currentRowIndex).Cells(currentColumnIndex).Value
                columnWidth = rgData.Columns(currentColumnIndex).Width

                _loadOnDemandCellEditor = New LoadOnDemandCellEditor(country, columnWidth, rgData)
                e.Editor = _loadOnDemandCellEditor

        End Select

    End Sub

    'Fires when a cell is taken out of edit mode
    Private Sub rgData_CellEndEdit(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles rgData.CellEndEdit

        If e.ColumnIndex = rgData.Columns("COUNTRY").Index Then

            'Set the editor text from editor element and update the cell value (sometimes the grid did not hold
            'the updated value)
            rgData.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = _loadOnDemandCellEditor.EditorElement.Text

            _loadOnDemandCellEditor.Dispose()

        End If

    End Sub

End Class
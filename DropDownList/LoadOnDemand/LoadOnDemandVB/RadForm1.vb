Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Public Class RadForm1


    Private _dropDownDataSource As List(Of ExampleData) = ExampleData.CreateList


    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    ''' <summary>
    ''' Initialize the load on demand controls..
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub RadForm1_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        SetRadDropDownList1()
        SetRadGridView1()

    End Sub



    ''' <summary>
    ''' Three things are required to create a Load on Demand dropdownlist:<br/>
    ''' 1 - Set autocompletemode to suggest<br/>
    ''' 2 - Set the display- and valuemember of the dropdownlist<br/>
    ''' 3 - Add custom handlers to the KeyUp and Leave event of the dropdownlist<br/>
    ''' </summary>
    ''' <remarks>The properties and handlers could also be set in the visual studio designer</remarks>
    Private Sub SetRadDropDownList1()

        With RadDropDownList1
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .DisplayMember = "ExampleDisplayMember"
            .ValueMember = "ExampleValueMember"
            AddHandler .KeyUp, AddressOf RadDropDownList1_KeyUp
            AddHandler .Leave, AddressOf RadDropDownList1_leave
        End With

        'show current values of the dropdownlist in thui UI.
        lblSelectedIndex.DataBindings.Add(New Binding("Text", RadDropDownList1, "SelectedIndex", True))
        lblSelectedValue.DataBindings.Add(New Binding("Text", RadDropDownList1, "SelectedValue", True))
        lblSelectedItem.DataBindings.Add(New Binding("Text", RadDropDownList1, "SelectedItem", True))

    End Sub


    ''' <summary>
    ''' Three things need to be done to create a Load on Demand dropdownlist:<br/>
    ''' 1 - Set dropdownstyle to dropdown and autocompletemode to suggest<br/>
    ''' 2 - Set the display- and valuemember of the dropdownlist<br/>
    ''' 3 - Add custom handlers to the EditorRequired and CelEndEdit event of the radgridview<br/>
    ''' </summary>
    ''' <remarks>The columns, properties and handlers could also be set in the visual studio designer</remarks>
    Private Sub SetRadGridView1()

        'create the columns, first the dropdown column
        Dim ddlCol As New GridViewComboBoxColumn() With {.HeaderText = "Example ddl", _
                                                         .Name = "ddlExample", _
                                                         .DropDownStyle = RadDropDownStyle.DropDown, _
                                                         .AutoCompleteMode = AutoCompleteMode.Suggest, _
                                                         .FieldName = "ExampleValueMember", _
                                                         .ValueMember = "ExampleValueMember", _
                                                         .DisplayMember = "ExampleDisplayMember" _
                                                        }
        Dim txtCol1 As New GridViewTextBoxColumn() With {.Name = "ExampleDisplayMember", .HeaderText = "Display"}
        Dim txtCol2 As New GridViewTextBoxColumn() With {.Name = "Guid", .HeaderText = "Value"}
        Dim txtCol3 As New GridViewTextBoxColumn() With {.Name = "WhateverOtherProps", .HeaderText = "Other"}

        'Initialize the grid (add columns and handlers and set a few other properties)
        'column and radgridview definitions could be done in the Visual Studio designer too
        With RadGridView1
            .MasterTemplate.AddNewRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom
            .MasterTemplate.AllowCellContextMenu = False
            .MasterTemplate.AutoGenerateColumns = False
            .MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
            .MasterTemplate.Columns.AddRange(New GridViewDataColumn() {ddlCol, txtCol1, txtCol2, txtCol3})
            AddHandler .EditorRequired, AddressOf RadGridView1_EditorRequired
            AddHandler .CellEndEdit, AddressOf RadGridView1_CellEndEdit
        End With


    End Sub

#Region "Load on Demand RadDropDownList1"

    ''' <summary>
    ''' Handle the KeyUp event of RadDropDownList1.
    ''' Loads the dropdown datasource when atleast 2 characters are entered
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub RadDropDownList1_KeyUp(sender As Object, e As KeyEventArgs)

        'Change datasource only when a char or number was entered
        If (e.KeyCode >= Keys.A AndAlso e.KeyCode <= Keys.Z) OrElse _
            (e.KeyValue >= 48 AndAlso e.KeyValue <= 58) Then

            'we need also atleast 2 input chars to get the data
            If RadDropDownList1.Text.Length > 1 Then

                'catch any keypresses while processing
                AddHandler RadDropDownList1.KeyDown, AddressOf SuspendKeyboard

                'input state
                Dim txt As String = RadDropDownList1.Text
                Dim cursorPos As Integer = RadDropDownList1.SelectionStart

                'change the RadDropDownList1 datasource, only get records starting with the inputed text..
                'notice the Guid's of the items change(!) since the list is generated each 'load on emand'-request!
                'just to demonstrate the datasource is really changed!
                RadDropDownList1.DataSource = _dropDownDataSource.Where(Function(c) c.ExampleDisplayMember.StartsWith(txt))

                'reset the user input
                RadDropDownList1.Text = txt
                RadDropDownList1.SelectionStart = cursorPos

                'release the keypress 'lock'
                RemoveHandler RadDropDownList1.KeyDown, AddressOf SuspendKeyboard

            End If

            'Cancel any processing of the handled keypress
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    ''' <summary>
    ''' Whenever an item is not selected but partly entered, the dropdown needs to be cleared since the user
    ''' dit not make an actual selection from the available values...
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub RadDropDownList1_leave(sender As Object, e As System.EventArgs)
        Dim ddl As RadDropDownList = sender
        Dim clear As Boolean = True

        'check if the selected item display member equals the dropdownlist textproperty.
        If ddl.SelectedItem IsNot Nothing Then
            Dim data As ExampleData = ddl.SelectedItem.DataBoundItem
            If data IsNot Nothing Then
                If ddl.Text.Trim = data.ExampleDisplayMember.Trim Then clear = False
            End If
        End If

        'if it is not, the user did not make a selection.
        If clear Then
            ddl.SelectedIndex = -1
            ddl.Text = String.Empty
            ddl.SelectedItem = Nothing
            ddl.Update()
        End If

    End Sub

    ''' <summary>
    ''' Catch any keyboard input and ignor it!
    ''' Helper functie for the load on demand dropdownlists to ignore keypresses
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub SuspendKeyboard(sender As Object, e As KeyEventArgs)
        e.Handled = True
        e.SuppressKeyPress = True
    End Sub

#End Region

#Region "Load on Demand RadDropDownListEditor"

    ''' <summary>
    ''' Replace the default RadDropDownListEditor with a load on demand editor when the column is "ddlExample"!
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub RadGridView1_EditorRequired(sender As Object, e As Telerik.WinControls.UI.EditorRequiredEventArgs)
        If RadGridView1.CurrentColumn.Name = "ddlExample" Then
            Dim ddl As New LoadOnDemandRadDropDownListEditor()
            ddl.DisplayMember = "ExampleDisplayMember"
            ddl.Valuemember = "ExampleValueMember"
            AddHandler ddl.KeyUp, AddressOf RadGridView1_ddlExample_KeyUp
            AddHandler ddl.SelectedIndexChanged, AddressOf RadGridView1_ddlExample_SelectedIndexChanged
            e.Editor = ddl
        End If
    End Sub

    ''' <summary>
    ''' For column "ddlExample" check if the user input (stored in the cell.Tag of the dropdownlist cell) equals the
    ''' full displaymember text. If so, the user selected the item. If not the user did not select an item!
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub RadGridView1_CellEndEdit(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs)

        If e.Column.Name = "ddlExample" Then
            Dim clear As Boolean = True


            If e.Value IsNot Nothing Then

                'get the user input, stored in the cell.Tag
                Dim mngr As GridViewEditManager = sender
                Dim input As String = mngr.GridViewElement.CurrentCell.Tag.ToString

                'In the example, the valuemember is a typeof Guid. But the e.Value is an object. We nee to cast it..
                Dim id As Guid = New Guid(e.Value.ToString)
                'and find the databound item
                Dim selected As ExampleData = _dropDownDataSource.FirstOrDefault(Function(c) c.ExampleValueMember.Equals(id))
                If selected IsNot Nothing Then
                    ' if the user input equals the dataitem displaymember, we have a winner
                    If input.Equals(selected.ExampleDisplayMember) Then
                        e.Row.Cells("ddlExample").Value = selected.ExampleDisplayMember
                        e.Row.Cells("ExampleDisplayMember").Value = selected.ExampleDisplayMember
                        e.Row.Cells("Guid").Value = selected.ExampleValueMember
                        e.Row.Cells("WhateverOtherProps").Value = selected.WhateverOtherProps
                        e.Row.InvalidateRow()
                        clear = False
                    End If
                End If
            End If

            'if the input does not equal the selected items displaymember, the user did not make a selection.
            If clear Then
                e.Row.Cells("ddlExample").Value = Nothing
                e.Row.Cells("ExampleDisplayMember").Value = String.Empty
                e.Row.Cells("Guid").Value = String.Empty
                e.Row.Cells("WhateverOtherProps").Value = String.Empty
            End If

            e.Row.InvalidateRow()
        End If

    End Sub

    ''' <summary>
    ''' De event handler of the load on demand dropdown editor from column  "ddlExample"  
    ''' Handles KeyUp event  
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub RadGridView1_ddlExample_KeyUp(sender As Object, e As LoadOnDemandRadDropDownListEditorEventargs)

        Dim ddl As RadDropDownListEditorElement = e.RadDropDownListEditorElement

        'input state
        Dim txt As String = ddl.TextBox.Text
        Dim cell As GridComboBoxCellElement = ddl.Parent


        'change the RadDropDownList1 datasource, only get records starting with the inputed text..
        ddl.DataSource = _dropDownDataSource.Where(Function(c) c.ExampleDisplayMember.StartsWith(txt))

        'reset the user input
        ddl.TextBox.Text = txt
        ddl.SelectionStart = ddl.TextBox.Text.Length
        ddl.Text = txt
        'the text input is stored in the cell Tag property for alter evaluation
        cell.Tag = txt

    End Sub

    ''' <summary>
    ''' The event handler of the load on demand dropdown editor from column  "ddlExample"  
    ''' Handles the RadDropDownListEditorElement.SelectedIndexChanged event 
    ''' The user input is stored in the cell.Tag property, when the user selects an item.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub RadGridView1_ddlExample_SelectedIndexChanged(sender As Object, e As LoadOnDemandRadDropDownListEditorEventargs)
        Dim ddl As RadDropDownListEditorElement = e.RadDropDownListEditorElement
        Dim cell As GridComboBoxCellElement = ddl.Parent

        If ddl.SelectedItem IsNot Nothing AndAlso ddl.SelectedItem.DataBoundItem IsNot Nothing Then
            Dim data As ExampleData = ddl.SelectedItem.DataBoundItem
            'when the user makes a selection, the cell.Tag property should contain the displaymember property of the
            'databound item.
            cell.Tag = data.ExampleDisplayMember
        End If
    End Sub


#End Region





End Class

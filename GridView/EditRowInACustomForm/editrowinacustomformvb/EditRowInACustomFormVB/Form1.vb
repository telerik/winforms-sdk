Imports Telerik.WinControls.UI

Public Class Form1
    Public Sub New()
        InitializeComponent()
        BindGrid()
        AddHandler RadGridView1.CreateCell, AddressOf radGridView1_CreateCell
    End Sub

    Public Class CustomCell
    Inherits GridDataCellElement
        Private button As RadDropDownButtonElement
        Private userControl As UserControl1

        Public Sub New(ByVal column As GridViewColumn, ByVal row As GridRowElement)
            MyBase.New(column, row)

        End Sub

        Protected Overrides Sub CreateChildElements()
            MyBase.CreateChildElements()
            Me.button = New RadDropDownButtonElement()
            Me.button.Text = "Click For Edit"
            Me.Children.Add(button)
            Me.button.Items.Add(CreateDropDownButton())

            'subscribe for RadDropDownButtonClick event
            AddHandler button.Click, AddressOf button_Click

            'subscribe for UserControl's saveButton click event
            Dim saveButton As RadButton = CType(userControl.Controls("saveButton"), RadButton)
            AddHandler saveButton.Click, AddressOf saveButton_Click
        End Sub

        Private Function CreateDropDownButton() As RadMenuHostItem
            Me.userControl = New UserControl1()
            Dim host As RadMenuHostItem = New RadMenuHostItem(userControl)
            host.MaxSize = New Size(userControl.Size.Width, 0)

            Return host
        End Function

        Private Sub button_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim textBox As RadTextBox = CType(userControl.Controls("textBox"), RadTextBox)

            If Not Me.RowInfo.Cells("TextBoxColumn").Value Is Nothing Then
                textBox.Text = Me.RowInfo.Cells("TextBoxColumn").Value.ToString()
            Else
                textBox.Text = String.Empty
            End If

            Dim dateTimePicker As RadDateTimePicker = CType(userControl.Controls("dateTimePicker"), RadDateTimePicker)

            If Not Me.RowInfo.Cells("DateTimeColumn").Value Is Nothing Then
                dateTimePicker.Value = CDate(Me.RowInfo.Cells("DateTimeColumn").Value)
            Else
                dateTimePicker.SetToNullValue()
            End If
        End Sub

        Private Sub saveButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim textBox As RadTextBox = CType(Me.userControl.Controls("textBox"), RadTextBox)
            Me.RowInfo.Cells("TextBoxColumn").Value = textBox.Text

            Dim dateTimePicker As RadDateTimePicker = CType(Me.userControl.Controls("dateTimePicker"), RadDateTimePicker)
            If dateTimePicker.Value <> dateTimePicker.NullDate Then
                Me.RowInfo.Cells("DateTimeColumn").Value = dateTimePicker.Value
            End If

            'add new row
            Dim newRow As GridViewNewRowInfo = TryCast(Me.RowInfo, GridViewNewRowInfo)
            If newRow IsNot Nothing Then
                newRow.EndAddNewRow()
            End If

            Me.button.DropDownMenu.ClosePopup(RadPopupCloseReason.AppFocusChange)
        End Sub
    End Class

    Private Sub radGridView1_CreateCell(ByVal sender As Object, ByVal e As GridViewCreateCellEventArgs)
        If e.Column.Name = "Edit" AndAlso (TypeOf e.Row Is GridDataRowElement OrElse TypeOf e.Row Is GridNewRowElement) Then
            e.CellType = GetType(CustomCell)
            e.CellElement = New CustomCell(e.Column, e.Row)
        End If
    End Sub

    Private Sub BindGrid()
        'in this column we are going to store our RadDropDownButton 
        'which comes from our CustomCell
        Dim editButtonColumn As GridViewTextBoxColumn = New GridViewTextBoxColumn("Edit")
        editButtonColumn.FieldName = "Edit"
        editButtonColumn.ReadOnly = True
        editButtonColumn.HeaderText = "Edit"
        editButtonColumn.Width = 200
        RadGridView1.MasterTemplate.Columns.Add(editButtonColumn)

        Dim textBoxColumn As GridViewTextBoxColumn = New GridViewTextBoxColumn("TextBoxColumn")
        textBoxColumn.FieldName = "TextBoxColumn"
        textBoxColumn.HeaderText = "TextBoxColumn"
        textBoxColumn.Width = 200
        RadGridView1.MasterTemplate.Columns.Add(textBoxColumn)

        Dim dateTimeColumn As GridViewDateTimeColumn = New GridViewDateTimeColumn("DateTimeColumn")
        dateTimeColumn.FieldName = "DateTimeColumn"
        dateTimeColumn.HeaderText = "DateTimeColumn"
        dateTimeColumn.Width = 200
        RadGridView1.MasterTemplate.Columns.Add(dateTimeColumn)

        For i As Integer = 0 To 9
            RadGridView1.Rows.Add(Nothing, "Some Text " & i, DateTime.Now.AddHours(i))
        Next i
    End Sub
End Class

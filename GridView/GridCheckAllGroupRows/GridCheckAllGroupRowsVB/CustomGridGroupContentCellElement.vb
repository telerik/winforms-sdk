Imports Telerik.WinControls.UI

Public Class CustomGridGroupContentCellElement
    Inherits GridGroupContentCellElement
    Private checkBoxElement As RadCheckBoxElement
    Private textElement As LightVisualElement
    Private stack As StackLayoutElement

    Public Sub New(column As GridViewColumn, row As GridRowElement)
        MyBase.New(column, row)
    End Sub

    Protected Overrides ReadOnly Property ThemeEffectiveType() As Type
        Get
            Return GetType(GridGroupContentCellElement)
        End Get
    End Property

    Protected Overrides Sub CreateChildElements()
        MyBase.CreateChildElements()
        checkBoxElement = New RadCheckBoxElement()
        textElement = New LightVisualElement()
        stack = New StackLayoutElement()
        stack.Orientation = Orientation.Horizontal
        stack.StretchHorizontally = True

        checkBoxElement.StretchHorizontally = False
        AddHandler checkBoxElement.CheckStateChanged, AddressOf checkBoxElement_CheckStateChanged
        textElement.TextAlignment = ContentAlignment.MiddleLeft
        Me.Children.Add(stack)
        stack.Children.Add(checkBoxElement)
        stack.Children.Add(textElement)
    End Sub

    Private Sub checkBoxElement_CheckStateChanged(sender As Object, e As EventArgs)
        'update child rows
        Dim group As GridViewGroupRowInfo = TryCast(Me.RowInfo, GridViewGroupRowInfo)
        group.Tag = checkBoxElement.Checked
        Me.GridViewElement.GridControl.BeginUpdate()
        Dim scrollValue As Integer = Me.GridControl.TableElement.VScrollBar.Value
        For Each row As GridViewRowInfo In Me.RowInfo.ChildRows
            Dim groupRow As GridViewGroupRowInfo = TryCast(row, GridViewGroupRowInfo)
            If groupRow IsNot Nothing Then
                Toggle(groupRow, checkBoxElement.Checked)
            End If

            row.Cells("Discontinued").Value = checkBoxElement.Checked
        Next
        Me.GridViewElement.GridControl.EndUpdate()
        Me.GridViewElement.GridControl.TableElement.VScrollBar.Value = scrollValue
    End Sub

    Private Sub Toggle(groupRow As GridViewGroupRowInfo, state As Boolean)
        groupRow.Tag = state
        For Each row As GridViewRowInfo In groupRow.ChildRows
            Dim g As GridViewGroupRowInfo = TryCast(row, GridViewGroupRowInfo)
            If g IsNot Nothing Then
                Toggle(g, state)
            End If

            row.Cells("Discontinued").Value = state
        Next
    End Sub

    Public Overrides Sub SetContent()
        MyBase.SetContent()
        Me.DrawText = False
        textElement.Text = DirectCast(Me.RowInfo, GridViewGroupRowInfo).HeaderText
        RemoveHandler checkBoxElement.CheckStateChanged, AddressOf checkBoxElement_CheckStateChanged
        If Me.RowInfo.Tag IsNot Nothing Then
            checkBoxElement.Checked = CBool(Me.RowInfo.Tag)
        Else
            checkBoxElement.Checked = False
        End If
        AddHandler checkBoxElement.CheckStateChanged, AddressOf checkBoxElement_CheckStateChanged
    End Sub
End Class

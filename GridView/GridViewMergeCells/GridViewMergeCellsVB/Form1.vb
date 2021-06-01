Imports Telerik.WinControls.UI
Imports System.ComponentModel

Partial Public Class Form1
Inherits Form
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim list As New BindingList(Of DataElement)() From { _
            New DataElement(1, "Mike", "Toshiba portage", "Sony"), _
            New DataElement(2, "Mike", "Asus", "Asus"), _
            New DataElement(3, "Nancy", "Toshiba portage", "Asus"), _
            New DataElement(4, "Nancy", "Sony", "Toshiba portage"), _
            New DataElement(5, "Rosa", "Asus", "Sony"), _
            New DataElement(6, "Rosa", "Hp", "Sony"), _
            New DataElement(7, "Robert", "Lenovo", "Lenovo"), _
            New DataElement(8, "Robin", "Sony", "Sony"), _
            New DataElement(9, "Jason", "IBM", "Sony"), _
            New DataElement(10, "Jason", "Asus", "Lenovo") _
        }
        Me.RadGridView1.DataSource = list

        MergeVertically(Me.RadGridView1, New Integer() {1, 2})
        MergeHorizontally(Me.RadGridView1, 2, 3)

        Me.RadGridView1.ShowRowHeaderColumn = False
        Me.RadGridView1.EnableGrouping = False
        RadGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
        RadGridView1.Size = New Size(400, 310)
        RadGridView1.EnableFiltering = True

        AddHandler RadGridView1.SortChanged, AddressOf radGridView1_SortChanged
        AddHandler RadGridView1.FilterChanged, AddressOf radGridView1_FilterChanged
        AddHandler RadGridView1.PrintCellPaint, AddressOf radGridView1_PrintCellPaint
        AddHandler RadGridView1.CellValueChanged, AddressOf radGridView1_CellValueChanged
    End Sub

    Private Sub radGridView1_CellValueChanged(sender As Object, e As GridViewCellEventArgs)
        MergeVertically(Me.radGridView1, New Integer() {1, 2})
        MergeHorizontally(Me.radGridView1, 2, 3)
    End Sub

    Private Sub radGridView1_FilterChanged(sender As Object, e As GridViewCollectionChangedEventArgs)
        MergeVertically(Me.radGridView1, New Integer() {1, 2})
        MergeHorizontally(Me.radGridView1, 2, 3)
    End Sub

    Private Sub radGridView1_SortChanged(sender As Object, e As GridViewCollectionChangedEventArgs)
        MergeVertically(Me.radGridView1, New Integer() {1, 2})
        MergeHorizontally(Me.radGridView1, 2, 3)
    End Sub

    Private Sub MergeHorizontally(radGridView As RadGridView, startColumnIndex As Integer, endColumnIndex As Integer)
        For Each item As GridViewRowInfo In radGridView.Rows
            For i As Integer = startColumnIndex To endColumnIndex - 1
                Dim firstCell As GridViewCellInfo = item.Cells(i)
                Dim secondCell As GridViewCellInfo = item.Cells(i + 1)

                Dim firstCellText As String = (If(firstCell IsNot Nothing AndAlso firstCell.Value IsNot Nothing, firstCell.Value.ToString(), String.Empty))
                Dim secondCellText As String = (If(secondCell IsNot Nothing AndAlso secondCell.Value IsNot Nothing, secondCell.Value.ToString(), String.Empty))

                setCellBorders(firstCell, Color.FromArgb(209, 225, 245))
                setCellBorders(secondCell, Color.FromArgb(209, 225, 245))

                If firstCellText = secondCellText Then
                    firstCell.Style.BorderRightColor = Color.Transparent
                    secondCell.Style.BorderLeftColor = Color.Transparent
                    secondCell.Style.ForeColor = Color.Transparent
                Else
                    secondCell.Style.ForeColor = Color.Black
                End If
            Next
        Next
    End Sub

    Private Sub MergeVertically(radGridView As RadGridView, columnIndexes As Integer())
        Dim Prev As GridViewRowInfo = Nothing
        For Each item As GridViewRowInfo In radGridView.Rows
            If Prev IsNot Nothing Then
                Dim firstCellText As String = String.Empty
                Dim secondCellText As String = String.Empty

                For Each i As Integer In columnIndexes
                    Dim firstCell As GridViewCellInfo = Prev.Cells(i)
                    Dim secondCell As GridViewCellInfo = item.Cells(i)

                    firstCellText = (If(firstCell IsNot Nothing AndAlso firstCell.Value IsNot Nothing, firstCell.Value.ToString(), String.Empty))
                    secondCellText = (If(secondCell IsNot Nothing AndAlso secondCell.Value IsNot Nothing, secondCell.Value.ToString(), String.Empty))

                    setCellBorders(firstCell, Color.FromArgb(209, 225, 245))
                    setCellBorders(secondCell, Color.FromArgb(209, 225, 245))

                    

                    If firstCellText = secondCellText Then
                        firstCell.Style.BorderBottomColor = Color.Transparent
                        secondCell.Style.BorderTopColor = Color.Transparent
                        secondCell.Style.ForeColor = Color.Transparent
                    Else
                        secondCell.Style.ForeColor = Color.Black
                        Prev = item
                        Exit For
                    End If
                Next
            Else
                Prev = item
            End If
        Next
    End Sub

    Private Sub setCellBorders(cell As GridViewCellInfo, color As Color)
        cell.Style.CustomizeBorder = True
        cell.Style.BorderBoxStyle = Telerik.WinControls.BorderBoxStyle.FourBorders
        cell.Style.BorderLeftColor = color
        cell.Style.BorderRightColor = color
        cell.Style.BorderBottomColor = color
        If cell.Style.BorderTopColor <> color.Transparent Then
            cell.Style.BorderTopColor = color
        End If
    End Sub

    Private Sub radGridView1_PrintCellPaint(sender As Object, e As PrintCellPaintEventArgs)
        If e.Row.Index >= 0 Then
            Dim cell As GridViewCellInfo = Me.radGridView1.Rows(e.Row.Index).Cells(e.Column.Index)

            If cell.Style.BorderTopColor = Color.Transparent Then
                e.Graphics.DrawLine(Pens.White, New Point(e.CellRect.Left + 1, e.CellRect.Top), New Point(e.CellRect.Right - 1, e.CellRect.Top))
            End If
            If cell.Style.BorderLeftColor = Color.Transparent Then
                e.Graphics.DrawLine(Pens.White, New Point(e.CellRect.Left, e.CellRect.Top), New Point(e.CellRect.Left - 1, e.CellRect.Bottom))
            End If
            If cell.Style.ForeColor = Color.Transparent Then
                Dim r As New Rectangle(e.CellRect.X + 1, e.CellRect.Y + 1, e.CellRect.Width - 2, e.CellRect.Height - 2)
                e.Graphics.FillRectangle(Brushes.White, r)
            End If
        End If
    End Sub
End Class

Public Class DataElement
    Public Property Id() As Integer
        Get
            Return m_Id
        End Get
        Set(value As Integer)
            m_Id = Value
        End Set
    End Property
    Private m_Id As Integer

    Public Property Name() As String
        Get
            Return m_Name
        End Get
        Set(value As String)
            m_Name = Value
        End Set
    End Property
    Private m_Name As String

    Public Property FirstOwnedItem() As String
        Get
            Return m_FirstOwnedItem
        End Get
        Set(value As String)
            m_FirstOwnedItem = Value
        End Set
    End Property
    Private m_FirstOwnedItem As String

    Public Property SecondOwnedItem() As String
        Get
            Return m_SecondOwnedItem
        End Get
        Set(value As String)
            m_SecondOwnedItem = Value
        End Set
    End Property
    Private m_SecondOwnedItem As String

    Public Sub New(id As Integer, name As String, firstOwnedItem As String, secondOwnedItem As String)
        Me.Id = id
        Me.Name = name
        Me.FirstOwnedItem = firstOwnedItem
        Me.SecondOwnedItem = secondOwnedItem
    End Sub
End Class

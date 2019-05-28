Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Namespace _1408634
    Partial Public Class RadForm1
        Inherits Telerik.WinControls.UI.RadForm

        Public Sub New()
            InitializeComponent()
            radGridView2.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
            radGridView2.Columns.Add(New GridViewMultiComboBoxColumn())

            For i As Integer = 0 To 9
                radGridView2.Rows.Add("Sam")
            Next i

            AddHandler radGridView2.EditorRequired, AddressOf RadGridView1_EditorRequired
            AddHandler radGridView2.CellEditorInitialized, AddressOf RadGridView2_CellEditorInitialized
        End Sub

        Private Sub RadGridView2_CellEditorInitialized(ByVal sender As Object, ByVal e As GridViewCellEventArgs)
            Dim editor = TryCast(e.ActiveEditor, MyCustomEditor)
            If editor IsNot Nothing Then
                Dim control = TryCast((CType(editor.EditorElement, RadHostItem).HostedControl), CustomMCCBEditor)
                control.TextBox.Text = ""
                RemoveHandler control.PopupEditor.PopupClosed, AddressOf PopupEditor_PopupClosed
                AddHandler control.PopupEditor.PopupClosed, AddressOf PopupEditor_PopupClosed
                RemoveHandler control.TextBox.TextChanged, AddressOf TextBox_TextChanged
                AddHandler control.TextBox.TextChanged, AddressOf TextBox_TextChanged
            End If
        End Sub

        Private Sub PopupEditor_PopupClosed(ByVal sender As Object, ByVal args As RadPopupClosedEventArgs)
            Dim control = TryCast(DirectCast(sender, RadPopupEditorElement).ElementTree.Control.Parent, CustomMCCBEditor)
            radGridView2.EndEdit()
            control.GridControl.CurrentRow = Nothing
        End Sub

        Private Sub TextBox_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim textBoxElement = TryCast(sender, RadTextBoxElement)
            Dim control = TryCast(textBoxElement.ElementTree.Control.Parent, CustomMCCBEditor)
            Dim grid = control.GridControl

            If textBoxElement.Text.Length < 2 Then
                Return
            End If
            If Not control.PopupEditor.PopupEditorElement.IsPopupOpen Then
                control.PopupEditor.PopupEditorElement.ShowPopup()
            End If


            grid.BeginUpdate()
            If grid.Columns.Count = 0 Then
                grid.Columns.Add("Data")
            End If
            grid.Rows.Clear()

            Dim data = GetData(textBoxElement.Text)

            For Each item In data
                grid.Rows.Add(item.Text)
            Next item

            grid.EndUpdate()


        End Sub

        Private Sub RadGridView1_EditorRequired(ByVal sender As Object, ByVal e As EditorRequiredEventArgs)
            If e.EditorType Is GetType(RadMultiColumnComboBoxElement) Then
                e.EditorType = GetType(MyCustomEditor)
            End If
        End Sub

        Public Function GetData(ByVal filter As String) As List(Of Data)
            Dim items As New List(Of Data)()
            For i As Integer = 0 To 9
                items.Add(New Data("Sam"))
                items.Add(New Data("Sam1"))
                items.Add(New Data("Melanie"))
                items.Add(New Data("Christoff"))
                items.Add(New Data("David"))
                items.Add(New Data("Melanie"))
            Next i
            If Not String.IsNullOrEmpty(filter) Then
                Return items.Where(Function(x) x.Text.Contains(filter)).ToList()
            End If
            Return items

        End Function
    End Class

    Friend Class MyCustomEditor
        Inherits BaseGridEditor

        Private control As New CustomMCCBEditor()
        Public Overrides Property Value() As Object
            Get
                Return control.Value
            End Get
            Set(ByVal value As Object)

            End Set
        End Property
        Protected Overrides Function CreateEditorElement() As RadElement
            Dim hostItem = New RadHostItem(control)
            Return hostItem
        End Function
        Public Overrides Sub BeginEdit()
            MyBase.BeginEdit()
            Me.control.PopupEditor.TextBoxElement.Focus()
        End Sub
    End Class
    Public Class Data
        Public Sub New(ByVal text As String)
            Me.Text = text
        End Sub

        Public Property Text() As String
    End Class
End Namespace

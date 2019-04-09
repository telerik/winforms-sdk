Imports Telerik.WinControls.UI

Public Class RadForm1

    Private columns As String()
    Private fields As String()
    Sub New()

        InitializeComponent()

    End Sub
    Private Sub RadForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NwindDataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.NwindDataSet.Products)
        Me.columns = New String() {"Product Name", "Units in stock", "Units on order", "Discontinued"}
        Me.fields = New String() {"ProductName", "UnitsInStock", "UnitsOnOrder", "Discontinued"}
        Me.RadVirtualGrid1.ColumnCount = Me.columns.Length
        Me.RadVirtualGrid1.RowCount = Me.NwindDataSet.Products.Rows.Count
        Me.RadVirtualGrid1.TableElement.ColumnWidth = 150
        Me.RadVirtualGrid1.TableElement.SetColumnWidth(0, 500)
        AddHandler Me.RadVirtualGrid1.CreateCellElement, AddressOf radVirtualGrid1_CreateCellElement
        AddHandler Me.RadVirtualGrid1.CellValueNeeded, AddressOf radVirtualGrid1_CellValueNeeded
        AddHandler Me.RadVirtualGrid1.CellValuePushed, AddressOf radVirtualGrid1_CellValuePushed
        AddHandler Me.RadVirtualGrid1.CellFormatting, AddressOf radVirtualGrid1_CellFormatting
        AddHandler Me.RadVirtualGrid1.EditorRequired, AddressOf radVirtualGrid1_EditorRequired
        Me.RadVirtualGrid1.MasterViewInfo.RegisterCustomColumn(3)
    End Sub

    Private Sub radVirtualGrid1_EditorRequired(ByVal sender As Object, ByVal e As VirtualGridEditorRequiredEventArgs)
        Dim columnName As String = Me.columns(e.ColumnIndex)

        Select Case columnName
            Case "ProductName"
                e.Editor = New VirtualGridTextBoxEditor()
            Case "UnitsInStock", "UnitsOnOrder"
                e.Editor = New VirtualGridSpinEditor()
            Case "Discontinued"
                e.Cancel = True
        End Select
    End Sub

    Private Sub radVirtualGrid1_CellFormatting(ByVal sender As Object, ByVal e As VirtualGridCellElementEventArgs)
        If e.CellElement.RowIndex < 0 OrElse e.CellElement.ColumnIndex < 0 Then
            Return
        End If

        Dim columnName As String = Me.fields(e.CellElement.ColumnIndex)

        Select Case columnName
            Case "ProductName"
                e.CellElement.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Case "UnitsInStock", "UnitsOnOrder"
                e.CellElement.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        End Select
    End Sub

    Private Sub radVirtualGrid1_CellValueNeeded(ByVal sender As Object, ByVal e As VirtualGridCellValueNeededEventArgs)
        If e.ColumnIndex < 0 Then
            Return
        End If

        If e.RowIndex = RadVirtualGrid.HeaderRowIndex Then
            e.Value = Me.columns(e.ColumnIndex)
        End If

        If e.RowIndex < 0 Then
            Return
        End If

        e.FieldName = Me.fields(e.ColumnIndex)
        e.Value = Me.NwindDataSet.Products.Rows(e.RowIndex)(e.FieldName)
        e.FieldName = Me.fields(e.ColumnIndex)
        e.Value = Me.NwindDataSet.Products.Rows(e.RowIndex)(e.FieldName)
    End Sub

    Private Sub radVirtualGrid1_CellValuePushed(ByVal sender As Object, ByVal e As VirtualGridCellValuePushedEventArgs)
        Try
            Me.NwindDataSet.Products.Rows(e.RowIndex)(Me.fields(e.ColumnIndex)) = e.Value
        Catch __unusedException1__ As Exception
        End Try
    End Sub

    Private Sub radVirtualGrid1_CreateCellElement(ByVal sender As Object, ByVal e As VirtualGridCreateCellEventArgs)
        If e.ColumnIndex = 3 Then

            If e.RowIndex >= 0 Then
                e.CellElement = New MyVirtualGridCheckBoxCellElement()
            End If
        End If

        If e.RowIndex = -1 Then

            If e.ColumnIndex = 3 Then
                e.CellElement = New CustomVirtualGridHeaderCellElement()
            End If
        End If
    End Sub

    Public Class MyVirtualGridCheckBoxCellElement
    Inherits VirtualGridCellElement

        Private checkBox As RadCheckBoxElement

        Protected Overrides Sub CreateChildElements()
            MyBase.CreateChildElements()
            Me.checkBox = New RadCheckBoxElement()
            Me.Children.Add(Me.checkBox)
        End Sub

        Protected Overrides Sub UpdateInfo(ByVal args As VirtualGridCellValueNeededEventArgs)
            MyBase.UpdateInfo(args)

            If TypeOf args.Value Is Boolean Then
                Me.checkBox.Checked = CBool(args.Value)
            End If

            Me.Text = String.Empty
        End Sub

        Public Overrides Function IsCompatible(ByVal data As Integer, ByVal context As Object) As Boolean
            Dim rowElement As VirtualGridRowElement = TryCast(context, VirtualGridRowElement)
            Return data = 3 AndAlso rowElement.RowIndex >= 0
        End Function

        Public Overrides Sub Attach(ByVal data As Integer, ByVal context As Object)
            MyBase.Attach(data, context)
            AddHandler Me.checkBox.ToggleStateChanged, AddressOf checkBox_ToggleStateChanged
        End Sub

        Public Overrides Sub Detach()
            RemoveHandler Me.checkBox.ToggleStateChanged, AddressOf checkBox_ToggleStateChanged
            MyBase.Detach()
        End Sub

        Protected Overrides ReadOnly Property ThemeEffectiveType As Type
            Get
                Return GetType(VirtualGridCellElement)
            End Get
        End Property

        Private Sub checkBox_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
            Me.TableElement.GridElement.SetCellValue(Me.checkBox.Checked, Me.RowIndex, Me.ColumnIndex, Me.ViewInfo)
            Me.TableElement.SynchronizeRow(-1, True)
        End Sub

        Protected Overrides Function ArrangeOverride(ByVal finalSize As SizeF) As SizeF
            Dim size As SizeF = MyBase.ArrangeOverride(finalSize)
            Me.checkBox.Arrange(New RectangleF((finalSize.Width - Me.checkBox.DesiredSize.Width) / 2.0F, (finalSize.Height - Me.checkBox.DesiredSize.Height) / 2.0F, Me.checkBox.DesiredSize.Width, Me.checkBox.DesiredSize.Height))
            Return size
        End Function
    End Class

    Public Class CustomVirtualGridHeaderCellElement
    Inherits VirtualGridHeaderCellElement

        Private headerCheckBox As RadCheckBoxElement

        Protected Overrides ReadOnly Property ThemeEffectiveType As Type
            Get
                Return GetType(VirtualGridHeaderCellElement)
            End Get
        End Property

        Public Overrides Function IsCompatible(ByVal data As Integer, ByVal context As Object) As Boolean
            Return data = 3
        End Function

        Protected Overrides Sub CreateChildElements()
            MyBase.CreateChildElements()
            headerCheckBox = New RadCheckBoxElement()
            Me.Children.Add(headerCheckBox)
            AddHandler Me.headerCheckBox.ToggleStateChanged, AddressOf headerCheckBox_ToggleStateChanged
        End Sub

        Public Overrides Sub Synchronize()
            MyBase.Synchronize()
            RemoveHandler Me.headerCheckBox.ToggleStateChanged, AddressOf headerCheckBox_ToggleStateChanged
            headerCheckBox.IsChecked = GetCheckState(Me.ColumnIndex)
            AddHandler Me.headerCheckBox.ToggleStateChanged, AddressOf headerCheckBox_ToggleStateChanged
        End Sub

        Private Function GetCheckState(ByVal columnIndex As Integer) As Boolean
            Dim isChecked As Boolean = True

            For i As Integer = 0 To Me.TableElement.RowCount - 1
                isChecked = isChecked And CBool((CType(Me.TableElement.GridElement, CustomRadVirtualGridElement)).GetCellValue(Me.headerCheckBox.Checked, i, Me.ColumnIndex, Me.ViewInfo))

                If isChecked = False Then
                    Exit For
                End If
            Next

            Return isChecked
        End Function

        Private Sub headerCheckBox_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
            For i As Integer = 0 To Me.TableElement.RowCount - 1
                Me.TableElement.GridElement.SetCellValue(Me.headerCheckBox.Checked, i, Me.ColumnIndex, Me.ViewInfo)
            Next

            Me.TableElement.SynchronizeRows()
        End Sub
    End Class

    Public Class CustomVirtualGrid
    Inherits RadVirtualGrid

        Public Overrides Property ThemeClassName As String
            Get
                Return GetType(RadVirtualGrid).FullName
            End Get
            Set(value As String)
                MyBase.ThemeClassName = value
            End Set
        End Property

        Protected Overrides Function CreateElement() As RadVirtualGridElement
            Return New CustomRadVirtualGridElement()
        End Function
    End Class

    Public Class CustomRadVirtualGridElement
    Inherits RadVirtualGridElement

        Public Function GetCellValue(ByVal value As Object, ByVal rowIndex As Integer, ByVal columnIndex As Integer, ByVal viewInfo As VirtualGridViewInfo) As Object
            Dim args As VirtualGridCellValueNeededEventArgs = New VirtualGridCellValueNeededEventArgs(rowIndex, columnIndex, viewInfo)
            Me.OnCellValueNeeded(args)
            Return args.Value
        End Function
    End Class

End Class

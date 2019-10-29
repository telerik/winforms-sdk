Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class IndicatedColorCellElement
    Inherits GridColorCellElement

    Private indicator As RadButtonElement

    Public Sub New(ByVal column As GridViewColumn, ByVal row As GridRowElement)
        MyBase.New(column, row)
    End Sub

    Protected Overrides Sub CreateChildElements()
        MyBase.CreateChildElements()

        indicator = New RadButtonElement()

        indicator.Text = ". . ."
        indicator.FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentBounds
        indicator.LayoutPanel.Alignment = ContentAlignment.MiddleCenter
        indicator.MaxSize = New System.Drawing.Size(30, 17)
        indicator.NotifyParentOnMouseInput = False
        indicator.StretchHorizontally = False
        indicator.Margin = New System.Windows.Forms.Padding(0, 1, 2, 1)
        indicator.Alignment = ContentAlignment.MiddleRight
        AddHandler indicator.Click, AddressOf indicator_Click

        Me.Children.Add(indicator)
    End Sub

    Protected Overrides Sub OnCellFormatting(ByVal e As CellFormattingEventArgs)
        MyBase.OnCellFormatting(e)
        If indicator IsNot Nothing Then
            indicator.Visibility = If(CType(Me.ColumnInfo, IndicatedColorColumn).EnableIndicator = True, ElementVisibility.Visible, ElementVisibility.Collapsed)
        End If
    End Sub

    Private Sub indicator_Click(ByVal sender As Object, ByVal e As EventArgs)
        AddHandler Me.GridControl.CellEditorInitialized, AddressOf grid_CellEditorInitialized
        Me.GridControl.EndEdit()
        Me.GridControl.BeginEdit()
    End Sub

    Private Sub grid_CellEditorInitialized(ByVal sender As Object, ByVal e As GridViewCellEventArgs)

        Dim currentEditor As GridColorPickerEditor = TryCast(e.ActiveEditor, GridColorPickerEditor)
        If currentEditor IsNot Nothing Then
            RemoveHandler Me.GridControl.CellEditorInitialized, AddressOf grid_CellEditorInitialized
            Dim element As RadColorPickerEditorElement = TryCast(currentEditor.EditorElement, RadColorPickerEditorElement)
            element.ColorPickerButton.PerformClick()
        End If
    End Sub

    Protected Overrides Function ArrangeOverride(ByVal finalSize As SizeF) As SizeF
        Dim clientRect As RectangleF = Me.GetClientRectangle(finalSize)

        Dim MySize As SizeF = MyBase.ArrangeOverride(finalSize)

        indicator.Arrange(clientRect)
        Dim lmpRect As New RectangleF(Me.ColorBox.DesiredSize.Width, clientRect.Y, clientRect.Width - Me.ColorBox.DesiredSize.Width, clientRect.Height)
        lmpRect.Width -= indicator.DesiredSize.Width
        Me.Layout.Arrange(lmpRect)

        Return MySize
    End Function

    Protected Overrides ReadOnly Property ThemeEffectiveType() As Type
        Get
            Return GetType(GridColorCellElement)
        End Get
    End Property

    Public Overrides Function IsCompatible(ByVal data As GridViewColumn, ByVal context As Object) As Boolean
        Return TypeOf data Is IndicatedColorColumn AndAlso TypeOf context Is GridDataRowElement
    End Function
End Class

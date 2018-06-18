Imports Telerik.WinControls
Imports Telerik.WinControls.UI

#Region "CustomGridFilterCellElement"
Public Class MyGridFilterCellElement
    Inherits GridFilterCellElement

    Private _clearButtonElement As RadButtonElement

    Public Sub New(ByVal column As GridViewDataColumn, ByVal row As GridRowElement)
        MyBase.New(column, row)
    End Sub

    Protected Overrides ReadOnly Property ThemeEffectiveType As Type
        Get
            Return GetType(GridFilterCellElement)
        End Get
    End Property

    Public ReadOnly Property ClearButtonElement As RadButtonElement
        Get
            Return Me._clearButtonElement
        End Get
    End Property

    Protected Overrides Sub CreateChildElements()
        MyBase.CreateChildElements()
        Me._clearButtonElement = New RadButtonElement()
        Me._clearButtonElement.Image = Image.FromFile("..\..\cross16x16.png")
        AddHandler Me._clearButtonElement.Click, AddressOf ClearButtonElement_Click
        Me.ClearButtonElement.NotifyParentOnMouseInput = False
        Me.Children.Add(Me.ClearButtonElement)
    End Sub

    Protected Overrides Function ArrangeOverride(ByVal finalSize As SizeF) As SizeF
        Dim size As SizeF = MyBase.ArrangeOverride(finalSize)

        If Me.IsFilterApplied Then
            Dim arrangeRect As RectangleF = New RectangleF(finalSize.Width - Me.FilterButton.DesiredSize.Width - Me.ClearButtonElement.DesiredSize.Width - Me.ElementSpacing, 4, Me.ClearButtonElement.DesiredSize.Width, Me.ClearButtonElement.DesiredSize.Height)
            Me.ClearButtonElement.Arrange(arrangeRect)
        End If

        If TypeOf Me.ColumnInfo Is GridViewDecimalColumn Then
            Me.TextAlignment = ContentAlignment.MiddleLeft
        End If

        Return size
    End Function

    Protected Overrides Sub SetTextAlignment()
        MyBase.SetTextAlignment()

        If TypeOf Me.ColumnInfo Is GridViewDecimalColumn Then
            Me.TextAlignment = ContentAlignment.MiddleLeft
        End If
    End Sub

    Protected Overrides Sub SetContentCore(ByVal value As Object)
        MyBase.SetContentCore(value)
        Me.ClearButtonElement.Visibility = If(Me.DataColumnInfo.FilterDescriptor IsNot Nothing, ElementVisibility.Visible, ElementVisibility.Collapsed)
    End Sub

    Public Overrides Function IsCompatible(ByVal data As GridViewColumn, ByVal context As Object) As Boolean
        Return TypeOf context Is GridFilterRowElement
    End Function

    Private Sub ClearButtonElement_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.DataColumnInfo.FilterDescriptor = Nothing
    End Sub
End Class
#End Region
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class IndicatedBrowseCellElement
    Inherits GridBrowseCellElement

    Private indicator As BrowseEditorButton

    Public Sub New(ByVal column As GridViewColumn, ByVal row As GridRowElement)
        MyBase.New(column, row)
        indicator = New BrowseEditorButton()

        'this code adds a registration for RadDropDownListArrowButtonElement in order to allow its usage in other controls
        Dim theme As Theme = ThemeRepository.ControlDefault
        Dim sg As StyleGroup = theme.FindStyleGroup("Telerik.WinControls.UI.RadBrowseEditor")
        sg.Registrations.Add(New StyleRegistration("Telerik.WinControls.UI.BrowseEditorButton"))

        indicator.Alignment = ContentAlignment.MiddleRight
        indicator.ShouldHandleMouseInput = True
        indicator.NotifyParentOnMouseInput = False

        indicator.FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentBounds
        indicator.MaxSize = New System.Drawing.Size(30, 15)
        indicator.Margin = New System.Windows.Forms.Padding(0, 1, 4, 1)
        AddHandler indicator.Click, AddressOf indicator_Click

        Me.Children.Add(indicator)

    End Sub

    Protected Overrides Sub OnCellFormatting(ByVal e As CellFormattingEventArgs)
        MyBase.OnCellFormatting(e)
        If indicator IsNot Nothing Then
            indicator.Visibility = If(CType(Me.ColumnInfo, IndicatedBrowseColumn).EnableIndicator = True, ElementVisibility.Visible, ElementVisibility.Collapsed)
        End If
    End Sub

    Private Sub indicator_Click(ByVal sender As Object, ByVal e As EventArgs)
        AddHandler Me.GridControl.CellEditorInitialized, AddressOf grid_CellEditorInitialized
        Me.GridControl.EndEdit()
        Me.GridControl.BeginEdit()
    End Sub

    Private Sub grid_CellEditorInitialized(ByVal sender As Object, ByVal e As GridViewCellEventArgs)

        Dim currentEditor As GridBrowseEditor = TryCast(e.ActiveEditor, GridBrowseEditor)
        If currentEditor IsNot Nothing Then
            RemoveHandler Me.GridControl.CellEditorInitialized, AddressOf grid_CellEditorInitialized

            Dim element As RadBrowseEditorElement = TryCast(currentEditor.EditorElement, RadBrowseEditorElement)
            element.BrowseButton.PerformClick()
        End If
    End Sub

    Protected Overrides ReadOnly Property ThemeEffectiveType() As Type
        Get
            Return GetType(GridBrowseCellElement)
        End Get
    End Property

    Public Overrides Function IsCompatible(ByVal data As GridViewColumn, ByVal context As Object) As Boolean
        Return TypeOf data Is IndicatedBrowseColumn AndAlso TypeOf context Is GridDataRowElement
    End Function
End Class

Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class IndicatedDecimalCellElement
    Inherits GridDataCellElement

    Private indicatorUP As RadRepeatArrowElement
    Private indicatorDown As RadRepeatArrowElement

    Public Sub New(ByVal column As GridViewColumn, ByVal row As GridRowElement)
        MyBase.New(column, row)
        'this code adds a registration for RadDropDownListArrowButtonElement in order to allow its usage in other controls
        Dim theme As Theme = ThemeRepository.ControlDefault
        Dim sg As StyleGroup = theme.FindStyleGroup("Telerik.WinControls.UI.RadSpinEditor")
        sg.Registrations.Add(New StyleRegistration("Telerik.WinControls.UI.RadSpinElementUpButton"))
        sg.Registrations.Add(New StyleRegistration("Telerik.WinControls.UI.RadSpinElementDownButton"))

        indicatorUP = New RadSpinElementUpButton()
        indicatorUP.Class = "UpButton"
        indicatorUP.Arrow.Direction = ArrowDirection.Up
        indicatorUP.StretchVertically = True
        AddHandler indicatorUP.Click, AddressOf indicator_Click
        indicatorUP.Tag = True

        indicatorDown = New RadSpinElementDownButton()
        indicatorDown.Class = "DownButton"
        indicatorDown.Arrow.Direction = ArrowDirection.Down
        indicatorDown.StretchVertically = True
        AddHandler indicatorDown.Click, AddressOf indicator_Click
        indicatorDown.Tag = False


        Dim layoutElement As New StackLayoutElement()
        layoutElement.Orientation = System.Windows.Forms.Orientation.Vertical
        layoutElement.Alignment = System.Drawing.ContentAlignment.MiddleRight
        layoutElement.StretchHorizontally = False
        layoutElement.StretchVertically = True
        layoutElement.MaxSize = New System.Drawing.Size(20, 18)
        layoutElement.FitToSizeMode = RadFitToSizeMode.FitToParentBounds
        layoutElement.Children.Add(indicatorUP)
        layoutElement.Children.Add(indicatorDown)
        layoutElement.Margin = New System.Windows.Forms.Padding(0, 1, 4, 1)
        layoutElement.ElementSpacing = 0

        Me.Children.Add(layoutElement)
    End Sub

    Protected Overrides Sub OnCellFormatting(ByVal e As CellFormattingEventArgs)
        MyBase.OnCellFormatting(e)
        Me.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        If indicatorUP IsNot Nothing Then
            indicatorUP.Visibility = If(CType(Me.ColumnInfo, IndicatedDecimalColumn).EnableIndicator = True, ElementVisibility.Visible, ElementVisibility.Collapsed)
        End If
    End Sub

    Private Updown As Boolean

    Private Sub indicator_Click(ByVal sender As Object, ByVal e As EventArgs)
        AddHandler Me.GridControl.CellEditorInitialized, AddressOf grid_CellEditorInitialized

        Updown = DirectCast(DirectCast(sender, RadRepeatArrowElement).Tag, Boolean)
        Me.GridControl.BeginEdit()
    End Sub

    Private Sub grid_CellEditorInitialized(ByVal sender As Object, ByVal e As GridViewCellEventArgs)

        Dim currentEditor As GridSpinEditor = TryCast(e.ActiveEditor, GridSpinEditor)
        If currentEditor IsNot Nothing Then
            RemoveHandler Me.GridControl.CellEditorInitialized, AddressOf grid_CellEditorInitialized
            Dim element As RadSpinEditorElement = TryCast(currentEditor.EditorElement, RadSpinEditorElement)

            If Updown Then
                element.ButtonUp.PerformClick()
            Else
                element.ButtonDown.PerformClick()
            End If
        End If
    End Sub

    Protected Overrides ReadOnly Property ThemeEffectiveType() As Type
        Get
            Return GetType(GridDataCellElement)
        End Get
    End Property

    Public Overrides Function IsCompatible(ByVal data As GridViewColumn, ByVal context As Object) As Boolean
        Return TypeOf data Is IndicatedDecimalColumn AndAlso TypeOf context Is GridDataRowElement
    End Function
End Class

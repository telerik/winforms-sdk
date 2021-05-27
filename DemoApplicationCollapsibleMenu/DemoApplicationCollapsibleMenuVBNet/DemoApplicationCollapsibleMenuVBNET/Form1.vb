Imports Telerik.WinControls.UI

Public Class Form1
    Private font As New Font("Arial", 14.0F)
    Private itemsFont As New Font("Arial", 11.0F)

    Public Sub New()
        InitializeComponent()

        Me.BackColor = Color.White
        Me.RadCollapsiblePanel1.Width = 250

        Me.RadCollapsiblePanel1.Dock = DockStyle.Left
        Me.RadCollapsiblePanel1.ExpandDirection = Telerik.WinControls.UI.RadDirection.Right

        Me.RadPanorama1.Dock = DockStyle.Fill
        Me.RadPanorama1.PanoramaElement.BackColor = Color.Transparent

        Me.RadCollapsiblePanel1.HeaderText = "ALL CONTROLS"
        Me.RadCollapsiblePanel1.CollapsiblePanelElement.HeaderElement.Margin = New Padding(0, 0, -5, 0)
        Me.RadCollapsiblePanel1.CollapsiblePanelElement.HeaderElement.HeaderTextElement.AngleTransform = 180
        Me.RadCollapsiblePanel1.CollapsiblePanelElement.HeaderElement.HeaderTextElement.Font = font
        Me.RadCollapsiblePanel1.CollapsiblePanelElement.HeaderElement.HeaderTextElement.ForeColor = Color.White
        Me.RadCollapsiblePanel1.CollapsiblePanelElement.HeaderElement.HeaderTextElement.StretchHorizontally = True
        Me.RadCollapsiblePanel1.CollapsiblePanelElement.HeaderElement.HeaderTextElement.StretchVertically = True
        Me.RadCollapsiblePanel1.CollapsiblePanelElement.ShowHeaderLine = False
        Me.RadCollapsiblePanel1.ControlsContainer.PanelElement.Border.Visibility = Telerik.WinControls.ElementVisibility.Collapsed

        AddHandler Me.RadCollapsiblePanel1.Collapsed, AddressOf radCollapsiblePanel1_Collapsed
        AddHandler Me.RadCollapsiblePanel1.Expanded, AddressOf radCollapsiblePanel1_Expanded

        Me.RadCollapsiblePanel1.CollapsiblePanelElement.HeaderElement.HeaderButtonElement.MinSize = New Size(40, 40)
        Me.RadCollapsiblePanel1.CollapsiblePanelElement.HeaderElement.HeaderButtonElement.Image = My.Resources.chevron_left
        Me.RadCollapsiblePanel1.CollapsiblePanelElement.HeaderElement.HeaderButtonElement.ImageLayout = ImageLayout.Zoom
        Me.RadCollapsiblePanel1.CollapsiblePanelElement.HeaderElement.HeaderButtonElement.Shape = Nothing
        Me.RadCollapsiblePanel1.CollapsiblePanelElement.HeaderElement.HeaderButtonElement.DrawFill = False
        Me.RadCollapsiblePanel1.CollapsiblePanelElement.HeaderElement.HeaderButtonElement.DrawBorder = False

        Dim greenColor As Color = Color.FromArgb(55, 155, 83)
        Me.RadCollapsiblePanel1.CollapsiblePanelElement.HeaderElement.BackColor = greenColor
        Me.RadCollapsiblePanel1.PanelContainer.BackColor = greenColor
        Me.RadCollapsiblePanel1.PanelContainer.Margin = New Padding(20, 0, 0, 0)
        Me.RadCollapsiblePanel1.CollapsiblePanelElement.HeaderElement.GradientStyle = Telerik.WinControls.GradientStyles.Solid

        Dim upButton As New LightVisualElement()
        upButton.StretchVertically = False
        upButton.MaxSize =   New System.Drawing.Size(50, 35)
        upButton.MinSize = upButton.MaxSize

        AddHandler upButton.Click, AddressOf upButton_Click
        upButton.Image = My.Resources.arrow_up
        AddHandler upButton.MouseEnter, AddressOf upButton_MouseEnter
        AddHandler upButton.MouseLeave, AddressOf upButton_MouseLeave
        Me.RadCollapsiblePanel1.CollapsiblePanelElement.HeaderElement.Children.Add(upButton)

        Dim downButton As New LightVisualElement()
        downButton.StretchVertically = False
        downButton.MaxSize = New System.Drawing.Size(50, 35)
        downButton.MinSize = downButton.MaxSize
        AddHandler downButton.Click, AddressOf downButton_Click
        downButton.Image = My.Resources.arrow_down
        AddHandler downButton.MouseEnter, AddressOf downButton_MouseEnter
        AddHandler downButton.MouseLeave, AddressOf downButton_MouseLeave
        Me.RadCollapsiblePanel1.CollapsiblePanelElement.HeaderElement.Children.Add(downButton)

        RadListControl1.ListElement.BackColor = Color.Transparent

        RadListControl1.ItemHeight = 40
        AddHandler RadListControl1.VisualItemFormatting, AddressOf listControl_VisualItemFormatting
        RadListControl1.Dock = DockStyle.Fill
        RadListControl1.ListElement.DrawBorder = False
        For i As Integer = 0 To 49
            RadListControl1.Items.Add("Item" & i)
        Next
        RadListControl1.ListElement.Scroller.ScrollState = ScrollState.AlwaysHide
        AddHandler RadListControl1.SelectedIndexChanged, AddressOf radListControl1_SelectedIndexChanged
        Me.RadCollapsiblePanel1.PanelContainer.Controls.Add(RadListControl1)
    End Sub

    Private Sub radListControl1_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
        Me.RadPanorama1.Items.Clear()
        For i As Integer = 0 To 4
            Dim tile As New RadTileElement()
            tile.Text = "Tile" & e.Position & "." & i
            Me.RadPanorama1.Items.Add(tile)
        Next
    End Sub

    Private Sub radCollapsiblePanel1_Expanded(sender As Object, e As EventArgs)
        Me.RadCollapsiblePanel1.CollapsiblePanelElement.HeaderElement.HeaderButtonElement.Image = My.Resources.chevron_left
    End Sub

    Private Sub radCollapsiblePanel1_Collapsed(sender As Object, e As EventArgs)
        Me.RadCollapsiblePanel1.CollapsiblePanelElement.HeaderElement.HeaderButtonElement.Image = My.Resources.chevron_right
    End Sub

    Private Sub downButton_Click(sender As Object, e As EventArgs)
        DoScrollList(False)
    End Sub

    Private Sub upButton_Click(sender As Object, e As EventArgs)
        DoScrollList(True)
    End Sub

    Public Sub DoScrollList(scrollUp As Boolean)
        If scrollUp Then
            If Me.RadListControl1.ListElement.VScrollBar.Value >= Me.RadListControl1.ListElement.ItemHeight Then
                Me.RadListControl1.ListElement.VScrollBar.Value -= Me.RadListControl1.ListElement.ItemHeight
            Else
                Me.RadListControl1.ListElement.VScrollBar.Value = 0
            End If
        Else
            If Me.RadListControl1.ListElement.VScrollBar.Value < Me.RadListControl1.ListElement.VScrollBar.Maximum -
            Me.RadListControl1.ListElement.VScrollBar.LargeChange Then
                Dim p As Integer = Me.RadListControl1.ListElement.VScrollBar.Value + Me.RadListControl1.ListElement.ItemHeight
                p = Math.Min(p, Me.RadListControl1.ListElement.VScrollBar.Maximum - Me.RadListControl1.ListElement.VScrollBar.LargeChange)
                Me.RadListControl1.ListElement.VScrollBar.Value = p
            End If
        End If
    End Sub

    Private Sub listControl_VisualItemFormatting(sender As Object, args As VisualItemFormattingEventArgs)
        args.VisualItem.ForeColor = Color.White
        args.VisualItem.Font = itemsFont
        args.VisualItem.DrawBorder = True
        args.VisualItem.BorderBoxStyle = Telerik.WinControls.BorderBoxStyle.FourBorders
        args.VisualItem.BorderBottomWidth = 0.5F
        args.VisualItem.BorderBottomColor = Color.White
        args.VisualItem.BorderTopWidth = 0
        args.VisualItem.BorderLeftWidth = 0
        args.VisualItem.BorderRightWidth = 0
        args.VisualItem.DrawFill = False

        If args.VisualItem.Selected Then
            args.VisualItem.Image = My.Resources.active_tab_arrow_menu_1
            args.VisualItem.ImageAlignment = ContentAlignment.MiddleRight
            args.VisualItem.TextImageRelation = TextImageRelation.TextBeforeImage
            args.VisualItem.GradientStyle = Telerik.WinControls.GradientStyles.Linear
            args.VisualItem.DrawFill = True
            args.VisualItem.BackColor = Color.FromArgb(26, 155, 86)
            args.VisualItem.BackColor2 = Color.FromArgb(24, 149, 81)
            args.VisualItem.BackColor3 = Color.FromArgb(21, 143, 74)
            args.VisualItem.BackColor4 = Color.FromArgb(20, 138, 70)
        Else
            args.VisualItem.ResetValue(LightVisualElement.ImageProperty, Telerik.WinControls.ValueResetFlags.Local)
            args.VisualItem.ResetValue(LightVisualElement.TextImageRelationProperty, Telerik.WinControls.ValueResetFlags.Local)
            args.VisualItem.ResetValue(LightVisualElement.BackColorProperty, Telerik.WinControls.ValueResetFlags.Local)
            args.VisualItem.BackColor = Color.Transparent
            args.VisualItem.GradientStyle = Telerik.WinControls.GradientStyles.Solid
        End If
    End Sub

    Private Sub downButton_MouseLeave(sender As Object, e As EventArgs)
        Dim btn As LightVisualElement = TryCast(sender, LightVisualElement)
        btn.Image = My.Resources.arrow_down
    End Sub

    Private Sub downButton_MouseEnter(sender As Object, e As EventArgs)
        Dim btn As LightVisualElement = TryCast(sender, LightVisualElement)
        btn.Image = My.Resources.arrow_down_hover
    End Sub

    Private Sub upButton_MouseLeave(sender As Object, e As EventArgs)
        Dim btn As LightVisualElement = TryCast(sender, LightVisualElement)
        btn.Image = My.Resources.arrow_up_hover
    End Sub

    Private Sub upButton_MouseEnter(sender As Object, e As EventArgs)
        Dim btn As LightVisualElement = TryCast(sender, LightVisualElement)
        btn.Image = My.Resources.arrow_up
    End Sub
End Class

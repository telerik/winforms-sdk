Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Primitives

Namespace AppPortfolioVB
    Partial Public Class Form1
        Inherits ShapedForm
        Private carouselLabelElement As RadLabelElement = Nothing

        Public Sub New()
            InitializeComponent()

            ThemeResolutionService.LoadPackageResource("AppPortfolioTheme.tssp")
            Me.radTitleBar1.ThemeName = "AppPortfolioTheme"
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

            Me.carouselLabelElement = New RadLabelElement()
            Me.carouselLabelElement.Font = New Font("Verdana", 13.0F, FontStyle.Bold)
            Me.carouselLabelElement.ZIndex = 5
            Me.carouselLabelElement.StretchHorizontally = False
            Me.carouselLabelElement.StretchVertically = False
            Me.carouselLabelElement.TextAlignment = ContentAlignment.MiddleRight
            Me.carouselLabelElement.Alignment = ContentAlignment.BottomCenter
            Me.carouselLabelElement.Margin = New Padding(10, 0, 0, 110)

            Me.SetSelectedItemText()

            Me.radCarousel1.CarouselElement.Children.Add(Me.carouselLabelElement)

            Dim winFormsImage As ImagePrimitive = New ImagePrimitive()
            winFormsImage.Image = Resources.WinForms
            winFormsImage.Alignment = ContentAlignment.TopLeft
            winFormsImage.Margin = New Padding(20, 20, 0, 0)
            Me.radCarousel1.CarouselElement.Children.Add(winFormsImage)

            Dim telerikImage As ImagePrimitive = New ImagePrimitive()
            telerikImage.Image = Resources.Telerik
            telerikImage.Alignment = ContentAlignment.BottomRight
            telerikImage.Margin = New Padding(0, 0, 20, 20)
            Me.radCarousel1.CarouselElement.Children.Add(telerikImage)

            AddHandler radCarousel1.SelectedValueChanged, AddressOf radCarousel1_SelectedValueChanged

            For Each item As RadItem In Me.radCarousel1.Items
                AddHandler item.MouseDown, AddressOf item_MouseDown
            Next item

            AddHandler radCarousel1.CarouselElement.AnimationStarted, AddressOf CarouselElement_AnimationStarted
        End Sub

        Private detailsPanel As AppDetailsPanel = Nothing

        Private Sub item_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
            If Not sender Is Me.radCarousel1.SelectedItem Then
                Return
            End If

            If Me.detailsPanel Is Nothing Then
                Me.detailsPanel = New AppDetailsPanel()
                Me.detailsPanel.Hide()
                AddHandler detailsPanel.VisibleChanged, AddressOf detailsPanel_VisibleChanged
                Me.Controls.Add(detailsPanel)
            End If

            Me.detailsPanel.PortfolioButton = TryCast(sender, PortfolioButtonElement)

            Me.detailsPanel.Location = New Point(CInt((Me.Width - detailsPanel.Width) / 2), CInt((Me.Height - detailsPanel.Height) / 2))
            Me.detailsPanel.Show()
            Me.detailsPanel.BringToFront()
            Me.detailsPanel.Focus()
        End Sub

        Private Sub detailsPanel_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.radCarousel1.EnableAutoLoop = Not Me.detailsPanel.Visible

            If Me.detailsPanel.Visible Then
                Me.detailsPanel.PanelElement.PerformInitAnimation()
            End If
        End Sub

        Private Sub radCarousel1_SelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.SetSelectedItemText()
        End Sub

        Private Sub CarouselElement_AnimationStarted(ByVal sender As Object, ByVal e As EventArgs)
            Dim setting As AnimatedPropertySetting = New AnimatedPropertySetting()
            setting.Property = VisualElement.ForeColorProperty
            setting.EndValue = Color.Transparent
            setting.NumFrames = 10
            setting.Interval = 40

            If Not Me.carouselLabelElement Is Nothing Then
                setting.ApplyValue(Me.carouselLabelElement)
            End If
        End Sub

        Private Sub SetSelectedItemText()
            If Me.carouselLabelElement Is Nothing Then
                Return
            End If

            Dim selectedElement As PortfolioButtonElement = Nothing
            If Not Me.radCarousel1 Is Nothing Then
                selectedElement = TryCast(Me.radCarousel1.SelectedItem, PortfolioButtonElement)
            End If

            Dim text As String
            If (Not selectedElement Is Nothing) Then
                text = selectedElement.Text
            Else
                text = "Select Item"
            End If
            Me.carouselLabelElement.Text = text

            'Animate selected text

            Dim setting As AnimatedPropertySetting = New AnimatedPropertySetting(VisualElement.ForeColorProperty, Color.Transparent, Color.White, 10, 40)

            setting.ApplyValue(Me.carouselLabelElement)
        End Sub

        Private Sub radCarousel1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles radCarousel1.KeyDown
            If e.KeyCode = Keys.F11 Then
                If Me.WindowState = FormWindowState.Maximized Then
                    Me.WindowState = FormWindowState.Normal
                    Me.FormBorderStyle = FormBorderStyle.Sizable
                Else
                    Me.FormBorderStyle = FormBorderStyle.None
                    Me.WindowState = FormWindowState.Maximized
                End If
            ElseIf e.KeyCode = Keys.F5 Then
                Me.radCarousel1.EnableAutoLoop = Not Me.radCarousel1.EnableAutoLoop
            ElseIf e.KeyCode = Keys.Escape Then
                If Not Me.detailsPanel Is Nothing AndAlso Me.detailsPanel.Visible Then
                    Me.detailsPanel.Hide()
                End If
            End If
        End Sub
    End Class
End Namespace
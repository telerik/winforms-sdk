Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports Telerik.WinControls
Imports Telerik.WinControls.Layouts
Imports Telerik.WinControls.Primitives
Imports Telerik.WinControls.UI
Imports System.Drawing

Namespace AppPortfolioVB
    Public Class AppDetailsPanel
        Inherits RadControl
        Private panelElement_Renamed As AppDetailsPanelElement


        Shared Sub New()
            ThemeResolutionService.LoadPackageResource("AppPortfolioTheme.tssp")
        End Sub

        Public Sub New()
            Me.Size = New Size(950, 450)
            Me.ThemeName = "AppPortfolioTheme"
            AddHandler KeyDown, AddressOf AppDetailsPanel_KeyDown
        End Sub

        Private Sub AppDetailsPanel_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
            If e.KeyCode = Keys.F5 Then
                Me.PanelElement.PerformInitAnimation()
            ElseIf e.KeyCode = Keys.Escape Then
                Me.Hide()
            End If
        End Sub

        Public ReadOnly Property PanelElement() As AppDetailsPanelElement
            Get
                Return Me.panelElement_Renamed
            End Get
        End Property

        Public Property PortfolioButton() As PortfolioButtonElement
            Get
                Return Me.panelElement_Renamed.PortfolioButton
            End Get
            Set(value As PortfolioButtonElement)
                Me.panelElement_Renamed.PortfolioButton = Value
            End Set
        End Property

        Protected Overrides Sub OnDoubleClick(ByVal e As EventArgs)
            MyBase.OnDoubleClick(e)

            Me.Hide()
        End Sub

        Protected Overrides Sub CreateChildItems(ByVal parent As RadElement)
            Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.BackgroundImage = Resources.BackgroundItemBig

            MyBase.CreateChildItems(parent)

            Me.panelElement_Renamed = New AppDetailsPanelElement()
            parent.Children.Add(Me.panelElement_Renamed)
        End Sub
    End Class

    Public Class AppDetailsPanelElement
        Inherits RadPanelElement
        Private productImage_Renamed As ImagePrimitive
        Private titleLabel As TextPrimitive
        Private descriptionLabel As TextPrimitive
        Private buttonElement As RadButtonElement
        Private backButtonElement As RadButtonElement

        Private portfolioButton_Renamed As PortfolioButtonElement

        Public Property ProductImage() As Image
            Get
                Return Me.productImage_Renamed.Image
            End Get
            Set(value As Image)
                Me.productImage_Renamed.Image = Value
            End Set
        End Property

        Public Property Title() As String
            Get
                Return Me.titleLabel.Text
            End Get
            Set(value As String)
                Me.titleLabel.Text = Value
            End Set
        End Property

        Public Property Description() As String
            Get
                Return Me.descriptionLabel.Text
            End Get
            Set(value As String)
                Me.descriptionLabel.Text = Value
            End Set
        End Property

        Public Property PortfolioButton() As PortfolioButtonElement
            Get
                Return portfolioButton_Renamed
            End Get
            Set(value As PortfolioButtonElement)
                If Not Me.portfolioButton_Renamed Is Value Then
                    Me.portfolioButton_Renamed = Value

                    If Not Me.portfolioButton_Renamed Is Nothing Then
                        Me.productImage_Renamed.Image = Me.portfolioButton_Renamed.GetProductImage()
                        Me.titleLabel.Text = Me.portfolioButton_Renamed.ProductTitle
                        Me.descriptionLabel.Text = Me.portfolioButton_Renamed.ProductDescription
                    Else
                        Me.productImage_Renamed.Image = Nothing
                        Me.titleLabel.Text = String.Empty
                        Me.descriptionLabel.Text = String.Empty
                    End If
                End If
            End Set
        End Property

        Protected Overrides Sub CreateChildElements()
            MyBase.CreateChildElements()

            Me.productImage_Renamed = New ImagePrimitive()
            Me.productImage_Renamed.Image = Resources.Telerik

            Me.descriptionLabel = New TextPrimitive()
            Me.descriptionLabel.ForeColor = Color.White
            Me.descriptionLabel.Font = New Font("Segoe UI", 10.0F)
            Me.descriptionLabel.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
            Me.descriptionLabel.StretchHorizontally = True
            Me.descriptionLabel.TextAlignment = ContentAlignment.TopLeft
            Me.descriptionLabel.MaxSize = New Size(450, 0)
            Me.descriptionLabel.MinSize = New Size(0, 200)
            Me.descriptionLabel.TextWrap = True
            Me.descriptionLabel.Text = "Description"

            Me.titleLabel = New TextPrimitive()
            Me.titleLabel.Margin = New Padding(0, 0, 0, 20)
            Me.titleLabel.ForeColor = Color.Red
            Me.titleLabel.Font = New Font("Verdana", 20.0F, FontStyle.Bold)
            Me.titleLabel.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
            Me.titleLabel.Text = "Title"

            Me.buttonElement = New RadButtonElement()
            Me.buttonElement.StretchHorizontally = False
            Me.buttonElement.StretchVertically = False
            Me.buttonElement.Text = "SEE DEMO"
            AddHandler buttonElement.Click, AddressOf buttonElement_Click

            Me.backButtonElement = New RadButtonElement()
            Me.backButtonElement.StretchHorizontally = False
            Me.backButtonElement.StretchVertically = False
            Me.backButtonElement.Text = "BACK"
            AddHandler Me.backButtonElement.Click, AddressOf backButtonElement_Click

            Dim verticalLayout As BoxLayout = New BoxLayout()
            verticalLayout.Orientation = System.Windows.Forms.Orientation.Vertical
            verticalLayout.Children.Add(Me.titleLabel)
            verticalLayout.Children.Add(Me.descriptionLabel)
            verticalLayout.Children.Add(Me.buttonElement)
            verticalLayout.Children.Add(Me.backButtonElement)

            Dim horizontalLayout As BoxLayout = New BoxLayout()
            horizontalLayout.Margin = New Padding(20)
            horizontalLayout.StretchHorizontally = True
            horizontalLayout.StretchVertically = True
            horizontalLayout.Orientation = System.Windows.Forms.Orientation.Horizontal
            BoxLayout.SetProportion(Me.productImage_Renamed, 1)
            BoxLayout.SetProportion(verticalLayout, 1)
            horizontalLayout.Children.Add(Me.productImage_Renamed)
            horizontalLayout.Children.Add(verticalLayout)

            Me.Children.Add(horizontalLayout)
        End Sub

        Private Sub backButtonElement_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.ElementTree.Control.Hide()
        End Sub

        Private Sub buttonElement_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Not Me.portfolioButton_Renamed Is Nothing Then
                Me.PortfolioButton.ExecuteCommand()
            End If
        End Sub

        Public Sub PerformInitAnimation()
            Dim setting As AnimatedPropertySetting = New AnimatedPropertySetting(RadElement.MarginProperty, New Padding(0, 20, 0, 0), New Padding(0, 0, 0, 0), 10, 40)

            Dim setting1 As AnimatedPropertySetting = New AnimatedPropertySetting(VisualElement.OpacityProperty, 0.0R, 1.0R, 10, 40)

            setting.ApplyValue(Me.productImage_Renamed)
            setting.ApplyValue(Me.descriptionLabel)

            setting1.ApplyValue(Me.productImage_Renamed)
            setting1.ApplyValue(Me.descriptionLabel)
            setting1.ApplyValue(Me.titleLabel)

            setting = New AnimatedPropertySetting(RadElement.MarginProperty, New Padding(0, 20, 0, 20), New Padding(0, 0, 0, 20), 10, 40)

            setting.ApplyValue(Me.titleLabel)
        End Sub
    End Class
End Namespace

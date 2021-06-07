Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Layouts

Public Class Form1
    Public Sub New()
        InitializeComponent()

        Dim searchBox As New SearchTextBox()
        searchBox.Size = New System.Drawing.Size(200, 20)
        searchBox.Location = New Point(10, 200)
        AddHandler searchBox.Search, AddressOf searchBox_Search
        Me.Controls.Add(searchBox)
    End Sub
    Private Sub searchBox_Search(sender As Object, e As SearchTextBox.SearchBoxEventArgs)
        RadMessageBox.Show("Search >> " & e.SearchText)
    End Sub

    Public Class SearchTextBox
    Inherits RadTextBox
        Public Overrides Property ThemeClassName As String
            Get
                Return GetType(RadTextBox).FullName
            End Get
            Set(value As String)
                MyBase.ThemeClassName = value
            End Set
        End Property

        Protected Overrides Sub OnLoad(desiredSize As Size)
            MyBase.OnLoad(desiredSize)

            searchButton.ButtonFillElement.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            searchButton.ShowBorder = False
        End Sub

        Private searchButton As RadButtonElement

        Protected Overrides Sub InitializeTextElement()
            MyBase.InitializeTextElement()
            searchButton = New RadButtonElement()
            Me.TextBoxElement.TextBoxItem.NullText = "Enter search criteria"
            AddHandler searchButton.Click, AddressOf button_Click
            searchButton.Margin = New Padding(0, 0, 0, 0)
            searchButton.Text = String.Empty
            searchButton.Image = My.Resources.SearchIcon

            Dim stackPanel As New StackLayoutElement()
            stackPanel.Orientation = Orientation.Horizontal
            stackPanel.Margin = New Padding(1, 0, 1, 0)
            stackPanel.Children.Add(searchButton)
            Dim tbItem As RadTextBoxItem = Me.TextBoxElement.TextBoxItem
            Me.TextBoxElement.Children.Remove(tbItem)

            Dim dockPanel As New DockLayoutPanel()
            dockPanel.Children.Add(stackPanel)
            dockPanel.Children.Add(tbItem)
            DockLayoutPanel.SetDock(tbItem, Telerik.WinControls.Layouts.Dock.Left)
            DockLayoutPanel.SetDock(stackPanel, Telerik.WinControls.Layouts.Dock.Right)
            Me.TextBoxElement.Children.Add(dockPanel)
        End Sub

        Public Class SearchBoxEventArgs
        Inherits EventArgs
            Private m_searchText As String

            Public Property SearchText() As String
                Get
                    Return m_searchText
                End Get
                Set(value As String)
                    m_searchText = value
                End Set
            End Property
        End Class

        Public Event Search As EventHandler(Of SearchBoxEventArgs)

        Private Sub button_Click(sender As Object, e As EventArgs)
            Dim newEvent As New SearchBoxEventArgs()
            newEvent.SearchText = Me.Text
            SearchEventRaiser(newEvent)
        End Sub

        Private Sub SearchEventRaiser(e As SearchBoxEventArgs)
            RaiseEvent Search(Me, e)
        End Sub
    End Class
End Class

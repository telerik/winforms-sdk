Imports Telerik.WinControls.UI

Partial Public Class Form1
Inherits RadForm
    Public Sub New()
        InitializeComponent()
        
        Dim row As New CommandBarRowElement()
        Dim strip As New CommandBarStripElement()
        row.Strips.Add(strip)
        radCommandBar1.Rows.Add(row)

        For Each page As RadPageViewPage In radPageView1.Pages
            If strip.Items.Count > 3 Then
                row = New CommandBarRowElement()
                strip = New CommandBarStripElement()
                row.Strips.Add(strip)
                RadCommandBar1.Rows.Add(row)
            End If

            Dim pageButton As New CommandBarButton()
            pageButton.DrawText = True
            pageButton.Orientation = Orientation.Horizontal
            pageButton.Image = Nothing
            pageButton.Text = page.Item.Text
            pageButton.StretchHorizontally = True
            AddHandler pageButton.Click, AddressOf pageButton_Click
            strip.Items.Add(pageButton)

            strip.OverflowButton.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            strip.StretchHorizontally = True
            'adding a label to each page in order to verify the change when a command bar button is clicked
            Dim pageTitle As New RadLabel()
            pageTitle.Text = "Current page = " & page.Item.Text
            pageTitle.Location = New Point(10, 10)
            page.Controls.Add(pageTitle)
        Next
        Dim stripElement As RadPageViewStripElement = TryCast(radPageView1.ViewElement, RadPageViewStripElement)
        stripElement.ItemContainer.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
    End Sub

    Private Sub pageButton_Click(sender As Object, e As EventArgs)
        Dim pageButton As CommandBarButton = TryCast(sender, CommandBarButton)

        RadPageView1.SelectedPage = RadPageView1.Pages(pageButton.Text)
        'reset all buttons colors
        For Each row As CommandBarRowElement In RadCommandBar1.Rows
            For Each strip As CommandBarStripElement In row.Strips
                For Each button As CommandBarButton In strip.Items
                    button.ResetValue(LightVisualElement.BackColorProperty, Telerik.WinControls.ValueResetFlags.Local)
                    button.ResetValue(LightVisualElement.NumberOfColorsProperty, Telerik.WinControls.ValueResetFlags.Local)
                Next
            Next
        Next
        pageButton.BackColor = Color.LightSalmon
        pageButton.NumberOfColors = 1
    End Sub
End Class

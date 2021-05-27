Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports Telerik.WinControls
Imports Telerik.WinControls.Themes
Imports Telerik.WinControls.UI

Namespace WindowsFormsApplication44
	Partial Public Class Form1
		Inherits Form

		Private textBox As New RadTextBoxElement()

		Public Sub New()
			InitializeComponent()

			Dim TempWindows8Theme As Windows8Theme = New Windows8Theme()
			ThemeResolutionService.ApplicationThemeName = "Windows8"

			' This is the first item which expands/collapses the menu.
			AddHandler expandCollapseItem.Item.Click, AddressOf expandCollapseItem_Click

			'SearchItem
			textBox.MaxSize = New Size(0, 20)
			searchPage.Item.Children.Add(textBox)

			searchPage.Item.DrawBorder = False
			searchPage.Item.DrawFill = False
			searchPage.Item.DrawImage = False

			AddHandler searchPage.Item.Click, AddressOf SearchItem_Click

			'separator
			separatorPage.Item.Margin = New Padding(0, 300, 0, 0)
			separatorPage.Item.Children.Add(New SeparatorElement())
		End Sub

		Private Sub SearchItem_Click(ByVal sender As Object, ByVal e As EventArgs)
			Toggle()
		End Sub

		Private Sub expandCollapseItem_Click(ByVal sender As Object, ByVal e As EventArgs)
			Toggle()
		End Sub

		Private Sub Toggle()
			Dim backstage As RadPageViewBackstageElement = CType(radPageView1.ViewElement, RadPageViewBackstageElement)
			Dim expanded As Boolean = backstage.ItemContainer.MinSize.Width > 36

            Dim menu_width As Integer = If(expanded, 36, 200)
            backstage.ItemContainer.MinSize = New Size(menu_width, 0)
            backstage.ItemContainer.MaxSize = New Size(menu_width, 0)
			searchPage.Item.DrawImage = expanded
			textBox.Visibility = If(expanded, ElementVisibility.Hidden, ElementVisibility.Visible)

			For Each page As RadPageViewPage In radPageView1.Pages
				page.Item.DrawText = Not expanded
			Next page
		End Sub

		Private Sub radPageView1_SelectedPageChanging(ByVal sender As Object, ByVal e As RadPageViewCancelEventArgs) Handles radPageView1.SelectedPageChanging
			'we don't need content for this page since it is used for expanding/collapsing the menu
			e.Cancel = e.Page.Name = "expandCollapseItem"
		End Sub
	End Class
End Namespace
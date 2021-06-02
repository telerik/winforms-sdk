Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Namespace PageViewAnnimation
	Partial Public Class RadForm1
		Inherits Telerik.WinControls.UI.RadForm

		Private timer As System.Windows.Forms.Timer
		Private currentPage As RadPageViewPage

		Public Sub New()
			InitializeComponent()

			Dim explorerBarElement As RadPageViewExplorerBarElement = TryCast(radPageView1.ViewElement, RadPageViewExplorerBarElement)

			For Each item As RadPageViewExplorerBarItem In explorerBarElement.Items
				AddHandler item.MouseHover, AddressOf item_MouseHover
				AddHandler item.AssociatedContentAreaElement.RadPropertyChanging, AddressOf AssociatedContentAreaElement_RadPropertyChanging
			Next item

			timer = New System.Windows.Forms.Timer()
			timer.Interval = 30
			AddHandler timer.Tick, AddressOf timer_Tick
			AddHandler radPageView1.PageExpanded, AddressOf radPageView1_PageExpanded
		End Sub

		Private Sub timer_Tick(ByVal sender As Object, ByVal e As EventArgs)
			currentPage.PageLength += 20
			If currentPage.PageLength >= 300 Then
				timer.Stop()
			End If
		End Sub

		Private Sub radPageView1_PageExpanded(ByVal sender As Object, ByVal e As RadPageViewEventArgs)
			timer.Stop()
			currentPage = e.Page
			currentPage.PageLength = 0
			timer.Start()
		End Sub

		Private Sub AssociatedContentAreaElement_RadPropertyChanging(ByVal sender As Object, ByVal args As RadPropertyChangingEventArgs)
			If args.Property.Name = "Bounds" Then
				'suspend layout when animating
				args.Cancel = timer.Enabled
			End If
		End Sub

		Private Sub item_MouseHover(ByVal sender As Object, ByVal e As EventArgs)
			Dim item As RadPageViewExplorerBarItem = DirectCast(sender, RadPageViewExplorerBarItem)

			Dim explorerBarElement As RadPageViewExplorerBarElement = TryCast(radPageView1.ViewElement, RadPageViewExplorerBarElement)
			For Each i As RadPageViewExplorerBarItem In explorerBarElement.Items
				i.IsExpanded = False
			Next i

			item.IsExpanded = True
		End Sub
	End Class
End Namespace
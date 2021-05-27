Namespace WindowsFormsApplication44
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.radPageView1 = New Telerik.WinControls.UI.RadPageView()
			Me.expandCollapseItem = New Telerik.WinControls.UI.RadPageViewPage()
			Me.searchPage = New Telerik.WinControls.UI.RadPageViewPage()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.moviesPage = New Telerik.WinControls.UI.RadPageViewPage()
			Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
			Me.tvPage = New Telerik.WinControls.UI.RadPageViewPage()
			Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
			Me.videosPage = New Telerik.WinControls.UI.RadPageViewPage()
			Me.radLabel4 = New Telerik.WinControls.UI.RadLabel()
			Me.separatorPage = New Telerik.WinControls.UI.RadPageViewItemPage()
			Me.radPageViewPage1 = New Telerik.WinControls.UI.RadPageViewPage()
			Me.radLabel5 = New Telerik.WinControls.UI.RadLabel()
			Me.radPageViewPage2 = New Telerik.WinControls.UI.RadPageViewPage()
			Me.radLabel6 = New Telerik.WinControls.UI.RadLabel()
			DirectCast(Me.radPageView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPageView1.SuspendLayout()
			Me.searchPage.SuspendLayout()
			DirectCast(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.moviesPage.SuspendLayout()
			DirectCast(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.tvPage.SuspendLayout()
			DirectCast(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.videosPage.SuspendLayout()
			DirectCast(Me.radLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPageViewPage1.SuspendLayout()
			DirectCast(Me.radLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPageViewPage2.SuspendLayout()
			DirectCast(Me.radLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radPageView1
			' 
			Me.radPageView1.Controls.Add(Me.expandCollapseItem)
			Me.radPageView1.Controls.Add(Me.searchPage)
			Me.radPageView1.Controls.Add(Me.moviesPage)
			Me.radPageView1.Controls.Add(Me.tvPage)
			Me.radPageView1.Controls.Add(Me.videosPage)
			Me.radPageView1.Controls.Add(Me.separatorPage)
			Me.radPageView1.Controls.Add(Me.radPageViewPage1)
			Me.radPageView1.Controls.Add(Me.radPageViewPage2)
			Me.radPageView1.Location = New System.Drawing.Point(26, 27)
			Me.radPageView1.Name = "radPageView1"
			Me.radPageView1.SelectedPage = Me.searchPage
			Me.radPageView1.Size = New System.Drawing.Size(715, 563)
			Me.radPageView1.TabIndex = 0
			Me.radPageView1.Text = "radPageView1"
			Me.radPageView1.ViewMode = Telerik.WinControls.UI.PageViewMode.Backstage
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.radPageView1.SelectedPageChanging += new System.EventHandler(Of Telerik.WinControls.UI.RadPageViewCancelEventArgs)(this.radPageView1_SelectedPageChanging);
			' 
			' expandCollapseItem
			' 
			Me.expandCollapseItem.Image = My.Resources.hamburger
			Me.expandCollapseItem.ItemSize = New System.Drawing.SizeF(96F, 45F)
			Me.expandCollapseItem.Location = New System.Drawing.Point(305, 4)
			Me.expandCollapseItem.Name = "expandCollapseItem"
			Me.expandCollapseItem.Size = New System.Drawing.Size(406, 555)
			' 
			' searchPage
			' 
			Me.searchPage.Controls.Add(Me.radLabel1)
			Me.searchPage.Image = My.Resources.search
			Me.searchPage.ItemSize = New System.Drawing.SizeF(96F, 45F)
			Me.searchPage.Location = New System.Drawing.Point(305, 4)
			Me.searchPage.Name = "searchPage"
			Me.searchPage.Size = New System.Drawing.Size(406, 555)
			Me.searchPage.Text = "searchPage"
			' 
			' radLabel1
			' 
			Me.radLabel1.Location = New System.Drawing.Point(85, 69)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New System.Drawing.Size(109, 18)
			Me.radLabel1.TabIndex = 0
			Me.radLabel1.Text = "Search page content"
			' 
			' moviesPage
			' 
			Me.moviesPage.Controls.Add(Me.radLabel2)
			Me.moviesPage.Image = My.Resources.mov
			Me.moviesPage.ItemSize = New System.Drawing.SizeF(96F, 45F)
			Me.moviesPage.Location = New System.Drawing.Point(305, 4)
			Me.moviesPage.Name = "moviesPage"
			Me.moviesPage.Size = New System.Drawing.Size(406, 555)
			Me.moviesPage.Text = "Movies"
			' 
			' radLabel2
			' 
			Me.radLabel2.Location = New System.Drawing.Point(76, 109)
			Me.radLabel2.Name = "radLabel2"
			Me.radLabel2.Size = New System.Drawing.Size(111, 18)
			Me.radLabel2.TabIndex = 1
			Me.radLabel2.Text = "Movies page content"
			' 
			' tvPage
			' 
			Me.tvPage.Controls.Add(Me.radLabel3)
			Me.tvPage.Image = My.Resources.tv
			Me.tvPage.ItemSize = New System.Drawing.SizeF(96F, 45F)
			Me.tvPage.Location = New System.Drawing.Point(305, 4)
			Me.tvPage.Name = "tvPage"
			Me.tvPage.Size = New System.Drawing.Size(406, 555)
			Me.tvPage.Text = "TV"
			' 
			' radLabel3
			' 
			Me.radLabel3.Location = New System.Drawing.Point(84, 158)
			Me.radLabel3.Name = "radLabel3"
			Me.radLabel3.Size = New System.Drawing.Size(89, 18)
			Me.radLabel3.TabIndex = 1
			Me.radLabel3.Text = "TV page content"
			' 
			' videosPage
			' 
			Me.videosPage.Controls.Add(Me.radLabel4)
			Me.videosPage.Image = My.Resources.vid
			Me.videosPage.ItemSize = New System.Drawing.SizeF(96F, 45F)
			Me.videosPage.Location = New System.Drawing.Point(305, 4)
			Me.videosPage.Name = "videosPage"
			Me.videosPage.Size = New System.Drawing.Size(406, 555)
			Me.videosPage.Text = "Videos"
			' 
			' radLabel4
			' 
			Me.radLabel4.Location = New System.Drawing.Point(84, 205)
			Me.radLabel4.Name = "radLabel4"
			Me.radLabel4.Size = New System.Drawing.Size(110, 18)
			Me.radLabel4.TabIndex = 1
			Me.radLabel4.Text = "Videos page content"
			' 
			' separatorPage
			' 
			Me.separatorPage.ItemSize = New System.Drawing.SizeF(96F, 40F)
			Me.separatorPage.ItemType = Telerik.WinControls.UI.PageViewItemType.GroupHeaderItem
			Me.separatorPage.Location = New System.Drawing.Point(305, 4)
			Me.separatorPage.Name = "separatorPage"
			Me.separatorPage.Size = New System.Drawing.Size(406, 555)
			' 
			' radPageViewPage1
			' 
			Me.radPageViewPage1.Controls.Add(Me.radLabel5)
			Me.radPageViewPage1.Image = My.Resources.signIn
			Me.radPageViewPage1.ItemSize = New System.Drawing.SizeF(96F, 45F)
			Me.radPageViewPage1.Location = New System.Drawing.Point(305, 4)
			Me.radPageViewPage1.Name = "radPageViewPage1"
			Me.radPageViewPage1.Size = New System.Drawing.Size(406, 555)
			Me.radPageViewPage1.Text = "Sign In"
			' 
			' radLabel5
			' 
			Me.radLabel5.Location = New System.Drawing.Point(157, 251)
			Me.radLabel5.Name = "radLabel5"
			Me.radLabel5.Size = New System.Drawing.Size(110, 18)
			Me.radLabel5.TabIndex = 1
			Me.radLabel5.Text = "Sign In page content"
			' 
			' radPageViewPage2
			' 
			Me.radPageViewPage2.Controls.Add(Me.radLabel6)
			Me.radPageViewPage2.Image = My.Resources.settings
			Me.radPageViewPage2.ItemSize = New System.Drawing.SizeF(96F, 45F)
			Me.radPageViewPage2.Location = New System.Drawing.Point(305, 4)
			Me.radPageViewPage2.Name = "radPageViewPage2"
			Me.radPageViewPage2.Size = New System.Drawing.Size(406, 555)
			Me.radPageViewPage2.Text = "Settings"
			' 
			' radLabel6
			' 
			Me.radLabel6.Location = New System.Drawing.Point(149, 268)
			Me.radLabel6.Name = "radLabel6"
			Me.radLabel6.Size = New System.Drawing.Size(116, 18)
			Me.radLabel6.TabIndex = 1
			Me.radLabel6.Text = "Settings page content"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = System.Drawing.Color.White
			Me.ClientSize = New System.Drawing.Size(776, 615)
			Me.Controls.Add(Me.radPageView1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			DirectCast(Me.radPageView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPageView1.ResumeLayout(False)
			Me.searchPage.ResumeLayout(False)
			Me.searchPage.PerformLayout()
			DirectCast(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.moviesPage.ResumeLayout(False)
			Me.moviesPage.PerformLayout()
			DirectCast(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.tvPage.ResumeLayout(False)
			Me.tvPage.PerformLayout()
			DirectCast(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.videosPage.ResumeLayout(False)
			Me.videosPage.PerformLayout()
			DirectCast(Me.radLabel4, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPageViewPage1.ResumeLayout(False)
			Me.radPageViewPage1.PerformLayout()
			DirectCast(Me.radLabel5, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPageViewPage2.ResumeLayout(False)
			Me.radPageViewPage2.PerformLayout()
			DirectCast(Me.radLabel6, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents radPageView1 As Telerik.WinControls.UI.RadPageView
		Private expandCollapseItem As Telerik.WinControls.UI.RadPageViewPage
		Private searchPage As Telerik.WinControls.UI.RadPageViewPage
		Private moviesPage As Telerik.WinControls.UI.RadPageViewPage
		Private tvPage As Telerik.WinControls.UI.RadPageViewPage
		Private videosPage As Telerik.WinControls.UI.RadPageViewPage
		Private separatorPage As Telerik.WinControls.UI.RadPageViewItemPage
		Private radPageViewPage1 As Telerik.WinControls.UI.RadPageViewPage
		Private radPageViewPage2 As Telerik.WinControls.UI.RadPageViewPage
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private radLabel2 As Telerik.WinControls.UI.RadLabel
		Private radLabel3 As Telerik.WinControls.UI.RadLabel
		Private radLabel4 As Telerik.WinControls.UI.RadLabel
		Private radLabel5 As Telerik.WinControls.UI.RadLabel
		Private radLabel6 As Telerik.WinControls.UI.RadLabel
	End Class
End Namespace


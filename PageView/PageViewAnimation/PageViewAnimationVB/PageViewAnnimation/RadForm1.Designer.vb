Namespace PageViewAnnimation
	Partial Public Class RadForm1
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
			Me.radPageViewPage1 = New Telerik.WinControls.UI.RadPageViewPage()
			Me.radPageViewPage2 = New Telerik.WinControls.UI.RadPageViewPage()
			Me.radPageViewPage3 = New Telerik.WinControls.UI.RadPageViewPage()
			DirectCast(Me.radPageView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPageView1.SuspendLayout()
			DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radPageView1
			' 
			Me.radPageView1.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(191)))), (CInt((CByte(219)))), (CInt((CByte(255)))))
			Me.radPageView1.Controls.Add(Me.radPageViewPage1)
			Me.radPageView1.Controls.Add(Me.radPageViewPage2)
			Me.radPageView1.Controls.Add(Me.radPageViewPage3)
			Me.radPageView1.ItemSizeMode = (CType((Telerik.WinControls.UI.PageViewItemSizeMode.EqualWidth Or Telerik.WinControls.UI.PageViewItemSizeMode.EqualHeight), Telerik.WinControls.UI.PageViewItemSizeMode))
			Me.radPageView1.Location = New System.Drawing.Point(7, 12)
			Me.radPageView1.Name = "radPageView1"
			Me.radPageView1.SelectedPage = Me.radPageViewPage1
			Me.radPageView1.Size = New System.Drawing.Size(730, 513)
			Me.radPageView1.TabIndex = 0
			Me.radPageView1.Text = "radPageView1"
			Me.radPageView1.ViewMode = Telerik.WinControls.UI.PageViewMode.ExplorerBar
			CType(Me.radPageView1.GetChildAt(0), Telerik.WinControls.UI.RadPageViewExplorerBarElement).BackColor = System.Drawing.Color.FromArgb((CInt((CByte(191)))), (CInt((CByte(219)))), (CInt((CByte(255)))))
			' 
			' radPageViewPage1
			' 
			Me.radPageViewPage1.IsContentVisible = True
			Me.radPageViewPage1.ItemSize = New System.Drawing.SizeF(730F, 32F)
			Me.radPageViewPage1.Location = New System.Drawing.Point(4, 93)
			Me.radPageViewPage1.Name = "radPageViewPage1"
			Me.radPageViewPage1.Size = New System.Drawing.Size(720, 292)
			Me.radPageViewPage1.Text = "radPageViewPage1"
			' 
			' radPageViewPage2
			' 
			Me.radPageViewPage2.ItemSize = New System.Drawing.SizeF(815F, 32F)
			Me.radPageViewPage2.Location = New System.Drawing.Point(4, 4)
			Me.radPageViewPage2.Name = "radPageViewPage2"
			Me.radPageViewPage2.Size = New System.Drawing.Size(-8, -8)
			Me.radPageViewPage2.Text = "radPageViewPage2"
			' 
			' radPageViewPage3
			' 
			Me.radPageViewPage3.ItemSize = New System.Drawing.SizeF(815F, 32F)
			Me.radPageViewPage3.Location = New System.Drawing.Point(4, 4)
			Me.radPageViewPage3.Name = "radPageViewPage3"
			Me.radPageViewPage3.Size = New System.Drawing.Size(-8, -8)
			Me.radPageViewPage3.Text = "radPageViewPage3"
			' 
			' RadForm1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = System.Drawing.SystemColors.ControlLightLight
			Me.ClientSize = New System.Drawing.Size(749, 538)
			Me.Controls.Add(Me.radPageView1)
			Me.Name = "RadForm1"
			' 
			' 
			' 
			Me.RootElement.ApplyShapeToControl = True
			Me.Text = "RadForm1"
			Me.ThemeName = "ControlDefault"
			DirectCast(Me.radPageView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPageView1.ResumeLayout(False)
			DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radPageView1 As Telerik.WinControls.UI.RadPageView
		Private radPageViewPage1 As Telerik.WinControls.UI.RadPageViewPage
		Private radPageViewPage2 As Telerik.WinControls.UI.RadPageViewPage
		Private radPageViewPage3 As Telerik.WinControls.UI.RadPageViewPage
	End Class
End Namespace
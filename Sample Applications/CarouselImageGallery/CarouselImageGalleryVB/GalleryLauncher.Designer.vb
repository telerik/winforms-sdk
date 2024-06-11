Imports Microsoft.VisualBasic
Imports System
Namespace CarouselImageGallery
	Public Partial Class GalleryLauncher
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (Not components Is Nothing) Then
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
			Me.btnBrowse = New Telerik.WinControls.UI.RadButton()
			Me.radDropDownList1 = New Telerik.WinControls.UI.RadDropDownList()
			Me.radButton2 = New Telerik.WinControls.UI.RadButton()
			Me.radPanel1 = New Telerik.WinControls.UI.RadPanel()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.office2010BlackTheme1 = New Telerik.WinControls.Themes.Office2010BlackTheme()
			CType(Me.btnBrowse, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radDropDownList1.SuspendLayout()
			CType(Me.radButton2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanel1.SuspendLayout()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' btnBrowse
			' 
			Me.btnBrowse.ForeColor = System.Drawing.Color.Teal
			Me.btnBrowse.Location = New System.Drawing.Point(153, 67)
			Me.btnBrowse.Name = "btnBrowse"
			' 
			' 
			' 
			Me.btnBrowse.RootElement.ForeColor = System.Drawing.Color.Teal
			Me.btnBrowse.Size = New System.Drawing.Size(102, 33)
			Me.btnBrowse.TabIndex = 4
			Me.btnBrowse.Text = "Browse images"
'			Me.btnBrowse.Click += New System.EventHandler(Me.btnBrowse_Click);
			' 
			' radDropDownList1
			' 
			Me.radDropDownList1.Controls.Add(Me.radButton2)
			Me.radDropDownList1.DropDownAnimationEnabled = True
			Me.radDropDownList1.ForeColor = System.Drawing.Color.Teal
			Me.radDropDownList1.Location = New System.Drawing.Point(15, 36)
			Me.radDropDownList1.Name = "radDropDownList1"
			' 
			' 
			' 
			Me.radDropDownList1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radDropDownList1.RootElement.ForeColor = System.Drawing.Color.Teal
			Me.radDropDownList1.ShowImageInEditorArea = True
			Me.radDropDownList1.Size = New System.Drawing.Size(388, 20)
			Me.radDropDownList1.TabIndex = 3
			Me.radDropDownList1.Text = "radDropDownList1"
			' 
			' radButton2
			' 
			Me.radButton2.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.radButton2.ForeColor = System.Drawing.Color.Teal
			Me.radButton2.Location = New System.Drawing.Point(369, 0)
			Me.radButton2.Name = "radButton2"
			' 
			' 
			' 
			Me.radButton2.RootElement.ForeColor = System.Drawing.Color.Teal
			Me.radButton2.Size = New System.Drawing.Size(19, 20)
			Me.radButton2.TabIndex = 6
			Me.radButton2.Text = "..."
'			Me.radButton2.Click += New System.EventHandler(Me.radButton2_Click);
			' 
			' radPanel1
			' 
			Me.radPanel1.BackColor = System.Drawing.Color.Transparent
			Me.radPanel1.Controls.Add(Me.radLabel1)
			Me.radPanel1.Controls.Add(Me.btnBrowse)
			Me.radPanel1.Controls.Add(Me.radDropDownList1)
			Me.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radPanel1.ForeColor = System.Drawing.Color.Teal
			Me.radPanel1.Location = New System.Drawing.Point(0, 0)
			Me.radPanel1.Name = "radPanel1"
			' 
			' 
			' 
			Me.radPanel1.RootElement.ForeColor = System.Drawing.Color.Teal
			Me.radPanel1.Size = New System.Drawing.Size(415, 112)
			Me.radPanel1.TabIndex = 5
			CType(Me.radPanel1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(125))))), (CInt(Fix((CByte(153))))))
			CType(Me.radPanel1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientAngle = 45F
			CType(Me.radPanel1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(51))))), (CInt(Fix((CByte(56))))))
			CType(Me.radPanel1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
			' 
			' radLabel1
			' 
			Me.radLabel1.ForeColor = System.Drawing.Color.Turquoise
			Me.radLabel1.Location = New System.Drawing.Point(15, 12)
			Me.radLabel1.Name = "radLabel1"
			' 
			' 
			' 
			Me.radLabel1.RootElement.ForeColor = System.Drawing.Color.Turquoise
			Me.radLabel1.Size = New System.Drawing.Size(68, 18)
			Me.radLabel1.TabIndex = 5
			Me.radLabel1.Text = "Select folder"
			' 
			' GalleryLauncher
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(415, 112)
			Me.Controls.Add(Me.radPanel1)
			Me.Name = "GalleryLauncher"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.GalleryLauncher_Load);
			CType(Me.btnBrowse, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radDropDownList1.ResumeLayout(False)
			Me.radDropDownList1.PerformLayout()
			CType(Me.radButton2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanel1.ResumeLayout(False)
			Me.radPanel1.PerformLayout()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents btnBrowse As Telerik.WinControls.UI.RadButton
		Private radDropDownList1 As Telerik.WinControls.UI.RadDropDownList
		Private radPanel1 As Telerik.WinControls.UI.RadPanel
		Private WithEvents radButton2 As Telerik.WinControls.UI.RadButton
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private office2010BlackTheme1 As Telerik.WinControls.Themes.Office2010BlackTheme

	End Class
End Namespace


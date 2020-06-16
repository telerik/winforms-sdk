Namespace CustomDecoder
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
			Me.radPdfViewer1 = New Telerik.WinControls.UI.RadPdfViewer()
			Me.radPdfViewerNavigator1 = New Telerik.WinControls.UI.RadPdfViewerNavigator()
			CType(Me.radPdfViewer1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPdfViewerNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radPdfViewer1
			' 
			Me.radPdfViewer1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radPdfViewer1.Location = New System.Drawing.Point(0, 38)
			Me.radPdfViewer1.Name = "radPdfViewer1"
			Me.radPdfViewer1.Size = New System.Drawing.Size(1064, 733)
			Me.radPdfViewer1.TabIndex = 0
			Me.radPdfViewer1.ThumbnailsScaleFactor = 0.15F
			' 
			' radPdfViewerNavigator1
			' 
			Me.radPdfViewerNavigator1.AssociatedViewer = Me.radPdfViewer1
			Me.radPdfViewerNavigator1.Dock = System.Windows.Forms.DockStyle.Top
			Me.radPdfViewerNavigator1.Location = New System.Drawing.Point(0, 0)
			Me.radPdfViewerNavigator1.Name = "radPdfViewerNavigator1"
			Me.radPdfViewerNavigator1.Size = New System.Drawing.Size(1064, 38)
			Me.radPdfViewerNavigator1.TabIndex = 1
			' 
			' RadForm1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1064, 771)
			Me.Controls.Add(Me.radPdfViewer1)
			Me.Controls.Add(Me.radPdfViewerNavigator1)
			Me.Name = "RadForm1"
			' 
			' 
			' 
			Me.RootElement.ApplyShapeToControl = True
			Me.Text = "RadForm1"
			CType(Me.radPdfViewer1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPdfViewerNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private radPdfViewer1 As Telerik.WinControls.UI.RadPdfViewer
		Private radPdfViewerNavigator1 As Telerik.WinControls.UI.RadPdfViewerNavigator
	End Class
End Namespace
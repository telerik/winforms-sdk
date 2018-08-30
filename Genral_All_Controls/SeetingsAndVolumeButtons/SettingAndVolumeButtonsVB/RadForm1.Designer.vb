Namespace SettingAndVolumeButtons
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
			Me.fluentTheme1 = New Telerik.WinControls.Themes.FluentTheme()
			Me.radDropDownButton1 = New Telerik.WinControls.UI.RadDropDownButton()
			Me.radMenuItem1 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem2 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem3 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem4 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem5 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radPopupEditor1 = New Telerik.WinControls.UI.RadPopupEditor()
			Me.radPopupContainer1 = New Telerik.WinControls.UI.RadPopupContainer()
			Me.radTrackBar1 = New Telerik.WinControls.UI.RadTrackBar()
			DirectCast(Me.radDropDownButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radPopupEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radPopupContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPopupContainer1.PanelContainer.SuspendLayout()
			Me.radPopupContainer1.SuspendLayout()
			DirectCast(Me.radTrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radDropDownButton1
			' 
			Me.radDropDownButton1.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem1, Me.radMenuItem2, Me.radMenuItem3, Me.radMenuItem4, Me.radMenuItem5})
			Me.radDropDownButton1.Location = New System.Drawing.Point(631, 12)
			Me.radDropDownButton1.Name = "radDropDownButton1"
			Me.radDropDownButton1.Size = New System.Drawing.Size(44, 24)
			Me.radDropDownButton1.TabIndex = 0
			Me.radDropDownButton1.Text = "radDropDownButton1"
			Me.radDropDownButton1.ThemeName = "Fluent"
			' 
			' radMenuItem1
			' 
			Me.radMenuItem1.Name = "radMenuItem1"
			Me.radMenuItem1.Text = "radMenuItem1"
			' 
			' radMenuItem2
			' 
			Me.radMenuItem2.Name = "radMenuItem2"
			Me.radMenuItem2.Text = "radMenuItem2"
			' 
			' radMenuItem3
			' 
			Me.radMenuItem3.Name = "radMenuItem3"
			Me.radMenuItem3.Text = "radMenuItem3"
			' 
			' radMenuItem4
			' 
			Me.radMenuItem4.Name = "radMenuItem4"
			Me.radMenuItem4.Text = "radMenuItem4"
			' 
			' radMenuItem5
			' 
			Me.radMenuItem5.Name = "radMenuItem5"
			Me.radMenuItem5.Text = "radMenuItem5"
			' 
			' radPopupEditor1
			' 
			Me.radPopupEditor1.AssociatedControl = Me.radPopupContainer1
			Me.radPopupEditor1.Location = New System.Drawing.Point(631, 346)
			Me.radPopupEditor1.Name = "radPopupEditor1"
			Me.radPopupEditor1.ShowTextBox = False
			Me.radPopupEditor1.Size = New System.Drawing.Size(44, 24)
			Me.radPopupEditor1.TabIndex = 1
			Me.radPopupEditor1.Text = "radPopupEditor1"
			Me.radPopupEditor1.ThemeName = "Fluent"
			' 
			' radPopupContainer1
			' 
			Me.radPopupContainer1.Location = New System.Drawing.Point(13, 13)
			Me.radPopupContainer1.Name = "radPopupContainer1"
			' 
			' radPopupContainer1.PanelContainer
			' 
			Me.radPopupContainer1.PanelContainer.Controls.Add(Me.radTrackBar1)
			Me.radPopupContainer1.PanelContainer.Size = New System.Drawing.Size(38, 170)
			Me.radPopupContainer1.Size = New System.Drawing.Size(40, 172)
			Me.radPopupContainer1.TabIndex = 2
			Me.radPopupContainer1.ThemeName = "Fluent"
			' 
			' radTrackBar1
			' 
			Me.radTrackBar1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radTrackBar1.Location = New System.Drawing.Point(0, 0)
			Me.radTrackBar1.Name = "radTrackBar1"
			Me.radTrackBar1.Orientation = System.Windows.Forms.Orientation.Vertical
			' 
			' 
			' 
			Me.radTrackBar1.RootElement.StretchHorizontally = False
			Me.radTrackBar1.RootElement.StretchVertically = True
			Me.radTrackBar1.Size = New System.Drawing.Size(34, 170)
			Me.radTrackBar1.TabIndex = 0
			Me.radTrackBar1.ThemeName = "Fluent"
			Me.radTrackBar1.ThumbSize = New System.Drawing.Size(8, 20)
			' 
			' RadForm1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(687, 392)
			Me.Controls.Add(Me.radPopupContainer1)
			Me.Controls.Add(Me.radPopupEditor1)
			Me.Controls.Add(Me.radDropDownButton1)
			Me.Name = "RadForm1"
			' 
			' 
			' 
			Me.RootElement.ApplyShapeToControl = True
			Me.Text = "RadForm1"
			Me.ThemeName = "Fluent"
			DirectCast(Me.radDropDownButton1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radPopupEditor1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPopupContainer1.PanelContainer.ResumeLayout(False)
			Me.radPopupContainer1.PanelContainer.PerformLayout()
			DirectCast(Me.radPopupContainer1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPopupContainer1.ResumeLayout(False)
			DirectCast(Me.radTrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private fluentTheme1 As Telerik.WinControls.Themes.FluentTheme
		Private radDropDownButton1 As Telerik.WinControls.UI.RadDropDownButton
		Private radMenuItem1 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem2 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem3 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem4 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem5 As Telerik.WinControls.UI.RadMenuItem
		Private radPopupEditor1 As Telerik.WinControls.UI.RadPopupEditor
		Private radPopupContainer1 As Telerik.WinControls.UI.RadPopupContainer
		Private radTrackBar1 As Telerik.WinControls.UI.RadTrackBar
	End Class
End Namespace
Namespace _1408634
	Partial Public Class CustomMCCBEditor
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

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim tableViewDefinition1 As New Telerik.WinControls.UI.TableViewDefinition()
			Me.radPopupEditor1 = New Telerik.WinControls.UI.RadPopupEditor()
			Me.radPopupContainer1 = New Telerik.WinControls.UI.RadPopupContainer()
			Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
			CType(Me.radPopupEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPopupContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPopupContainer1.PanelContainer.SuspendLayout()
			Me.radPopupContainer1.SuspendLayout()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radPopupEditor1
			' 
			Me.radPopupEditor1.AssociatedControl = Me.radPopupContainer1
			Me.radPopupEditor1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radPopupEditor1.Location = New System.Drawing.Point(0, 0)
			Me.radPopupEditor1.Name = "radPopupEditor1"
			Me.radPopupEditor1.ShowTextBox = False
			Me.radPopupEditor1.Size = New System.Drawing.Size(501, 20)
			Me.radPopupEditor1.TabIndex = 0
			Me.radPopupEditor1.Text = "radPopupEditor1"
			' 
			' radPopupContainer1
			' 
			Me.radPopupContainer1.Location = New System.Drawing.Point(48, 127)
			Me.radPopupContainer1.Name = "radPopupContainer1"
			' 
			' radPopupContainer1.PanelContainer
			' 
			Me.radPopupContainer1.PanelContainer.Controls.Add(Me.radGridView1)
			Me.radPopupContainer1.PanelContainer.Size = New System.Drawing.Size(362, 185)
			Me.radPopupContainer1.Size = New System.Drawing.Size(364, 187)
			Me.radPopupContainer1.TabIndex = 1
			' 
			' radGridView1
			' 
			Me.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radGridView1.Location = New System.Drawing.Point(0, 0)
			' 
			' 
			' 
			Me.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1
			Me.radGridView1.Name = "radGridView1"
			Me.radGridView1.Size = New System.Drawing.Size(362, 185)
			Me.radGridView1.TabIndex = 0
			' 
			' CustomMCCBEditor
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.radPopupContainer1)
			Me.Controls.Add(Me.radPopupEditor1)
			Me.Name = "CustomMCCBEditor"
			Me.Size = New System.Drawing.Size(501, 413)
			CType(Me.radPopupEditor1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPopupContainer1.PanelContainer.ResumeLayout(False)
			CType(Me.radPopupContainer1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPopupContainer1.ResumeLayout(False)
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private radPopupEditor1 As Telerik.WinControls.UI.RadPopupEditor
		Private radPopupContainer1 As Telerik.WinControls.UI.RadPopupContainer
		Private radGridView1 As Telerik.WinControls.UI.RadGridView
	End Class
End Namespace

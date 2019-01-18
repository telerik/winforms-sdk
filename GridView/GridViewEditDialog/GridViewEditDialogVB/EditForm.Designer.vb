Namespace GridViewEditDialog
	Partial Public Class EditForm
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
			Me.components = New System.ComponentModel.Container()
			Me.tableLayoutPanel1 = New TableLayoutPanel()
			Me.save_Button = New Telerik.WinControls.UI.RadButton()
			Me.cancel_Button = New Telerik.WinControls.UI.RadButton()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
			Me.radTextBox1 = New Telerik.WinControls.UI.RadTextBox()
			Me.radDropDownList1 = New Telerik.WinControls.UI.RadDropDownList()
			Me.radSpinEditor1 = New Telerik.WinControls.UI.RadSpinEditor()
			Me.errorProvider1 = New ErrorProvider(Me.components)
			Me.tableLayoutPanel1.SuspendLayout()
			CType(Me.save_Button, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cancel_Button, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSpinEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.errorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' tableLayoutPanel1
			' 
			Me.tableLayoutPanel1.ColumnCount = 2
			Me.tableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.tableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.tableLayoutPanel1.Controls.Add(Me.save_Button, 0, 3)
			Me.tableLayoutPanel1.Controls.Add(Me.cancel_Button, 1, 3)
			Me.tableLayoutPanel1.Controls.Add(Me.radLabel1, 0, 0)
			Me.tableLayoutPanel1.Controls.Add(Me.radLabel2, 0, 1)
			Me.tableLayoutPanel1.Controls.Add(Me.radLabel3, 0, 2)
			Me.tableLayoutPanel1.Controls.Add(Me.radTextBox1, 1, 1)
			Me.tableLayoutPanel1.Controls.Add(Me.radDropDownList1, 1, 2)
			Me.tableLayoutPanel1.Controls.Add(Me.radSpinEditor1, 1, 0)
			Me.tableLayoutPanel1.Dock = DockStyle.Fill
			Me.tableLayoutPanel1.Location = New Point(0, 0)
			Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
			Me.tableLayoutPanel1.RowCount = 5
			Me.tableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
			Me.tableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
			Me.tableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
			Me.tableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
			Me.tableLayoutPanel1.RowStyles.Add(New RowStyle())
			Me.tableLayoutPanel1.Size = New Size(277, 133)
			Me.tableLayoutPanel1.TabIndex = 0
			' 
			' save_Button
			' 
			Me.save_Button.Dock = DockStyle.Bottom
			Me.save_Button.Image = My.Resources.save_as1
			Me.save_Button.ImageAlignment = ContentAlignment.MiddleRight
			Me.save_Button.Location = New Point(3, 105)
			Me.save_Button.Name = "save_Button"
			Me.save_Button.Size = New Size(132, 24)
			Me.save_Button.TabIndex = 0
			Me.save_Button.Text = "Save"
			Me.save_Button.TextAlignment = ContentAlignment.MiddleLeft
			Me.save_Button.TextImageRelation = TextImageRelation.ImageBeforeText
'			Me.save_Button.Click += New System.EventHandler(Me.save_Button_Click)
			' 
			' cancel_Button
			' 
			Me.cancel_Button.Dock = DockStyle.Bottom
			Me.cancel_Button.Image = My.Resources.splitcon_firstlook_Delete_small
			Me.cancel_Button.ImageAlignment = ContentAlignment.MiddleRight
			Me.cancel_Button.Location = New Point(141, 105)
			Me.cancel_Button.Name = "cancel_Button"
			Me.cancel_Button.Size = New Size(133, 24)
			Me.cancel_Button.TabIndex = 1
			Me.cancel_Button.Text = "Cancel"
			Me.cancel_Button.TextAlignment = ContentAlignment.MiddleLeft
			Me.cancel_Button.TextImageRelation = TextImageRelation.ImageBeforeText
'			Me.cancel_Button.Click += New System.EventHandler(Me.cancel_Button_Click)
			' 
			' radLabel1
			' 
			Me.radLabel1.Dock = DockStyle.Fill
			Me.radLabel1.Location = New Point(3, 3)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New Size(20, 18)
			Me.radLabel1.TabIndex = 2
			Me.radLabel1.Text = "ID:"
			' 
			' radLabel2
			' 
			Me.radLabel2.Dock = DockStyle.Fill
			Me.radLabel2.Location = New Point(3, 36)
			Me.radLabel2.Name = "radLabel2"
			Me.radLabel2.Size = New Size(39, 18)
			Me.radLabel2.TabIndex = 3
			Me.radLabel2.Text = "Name:"
			' 
			' radLabel3
			' 
			Me.radLabel3.Dock = DockStyle.Fill
			Me.radLabel3.Location = New Point(3, 69)
			Me.radLabel3.Name = "radLabel3"
			Me.radLabel3.Size = New Size(39, 18)
			Me.radLabel3.TabIndex = 4
			Me.radLabel3.Text = "Grade:"
			' 
			' radTextBox1
			' 
			Me.radTextBox1.Dock = DockStyle.Left
			Me.radTextBox1.Location = New Point(141, 36)
			Me.radTextBox1.Name = "radTextBox1"
			Me.radTextBox1.Size = New Size(76, 20)
			Me.radTextBox1.TabIndex = 5
			' 
			' radDropDownList1
			' 
			Me.radDropDownList1.Dock = DockStyle.Left
			Me.radDropDownList1.Location = New Point(141, 69)
			Me.radDropDownList1.Name = "radDropDownList1"
			Me.radDropDownList1.Size = New Size(76, 20)
			Me.radDropDownList1.TabIndex = 6
			' 
			' radSpinEditor1
			' 
			Me.radSpinEditor1.Dock = DockStyle.Left
			Me.radSpinEditor1.Location = New Point(141, 3)
			Me.radSpinEditor1.Name = "radSpinEditor1"
			Me.radSpinEditor1.Size = New Size(76, 20)
			Me.radSpinEditor1.TabIndex = 7
			' 
			' errorProvider1
			' 
			Me.errorProvider1.ContainerControl = Me
			' 
			' EditForm
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.ClientSize = New Size(277, 133)
			Me.Controls.Add(Me.tableLayoutPanel1)
			Me.Name = "EditForm"
			' 
			' 
			' 
			Me.RootElement.ApplyShapeToControl = True
			Me.Text = "EditForm"
			Me.tableLayoutPanel1.ResumeLayout(False)
			Me.tableLayoutPanel1.PerformLayout()
			CType(Me.save_Button, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cancel_Button, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSpinEditor1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.errorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private tableLayoutPanel1 As TableLayoutPanel
		Private WithEvents save_Button As Telerik.WinControls.UI.RadButton
		Private WithEvents cancel_Button As Telerik.WinControls.UI.RadButton
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private radLabel2 As Telerik.WinControls.UI.RadLabel
		Private radLabel3 As Telerik.WinControls.UI.RadLabel
		Private radTextBox1 As Telerik.WinControls.UI.RadTextBox
		Private radDropDownList1 As Telerik.WinControls.UI.RadDropDownList
		Private radSpinEditor1 As Telerik.WinControls.UI.RadSpinEditor
		Private errorProvider1 As ErrorProvider
	End Class
End Namespace

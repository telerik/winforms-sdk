Namespace ScalingZoom
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
			Dim tableViewDefinition1 As New Telerik.WinControls.UI.TableViewDefinition()
			Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
			Me.radTextBox1 = New Telerik.WinControls.UI.RadTextBox()
			Me.radTextBox2 = New Telerik.WinControls.UI.RadTextBox()
			Me.radTextBox3 = New Telerik.WinControls.UI.RadTextBox()
			Me.radButton1 = New Telerik.WinControls.UI.RadButton()
			Me.radButton2 = New Telerik.WinControls.UI.RadButton()
			Me.radButton3 = New Telerik.WinControls.UI.RadButton()
			Me.radDropDownList1 = New Telerik.WinControls.UI.RadDropDownList()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			DirectCast(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radTextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radTextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radButton2, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radButton3, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radGridView1
			' 
			Me.radGridView1.Location = New System.Drawing.Point(103, 180)
			' 
			' 
			' 
			Me.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1
			Me.radGridView1.Name = "radGridView1"
			Me.radGridView1.Size = New System.Drawing.Size(589, 482)
			Me.radGridView1.TabIndex = 0
			' 
			' radTextBox1
			' 
			Me.radTextBox1.Location = New System.Drawing.Point(765, 180)
			Me.radTextBox1.Name = "radTextBox1"
			Me.radTextBox1.Size = New System.Drawing.Size(100, 20)
			Me.radTextBox1.TabIndex = 1
			' 
			' radTextBox2
			' 
			Me.radTextBox2.Location = New System.Drawing.Point(765, 246)
			Me.radTextBox2.Name = "radTextBox2"
			Me.radTextBox2.Size = New System.Drawing.Size(100, 20)
			Me.radTextBox2.TabIndex = 2
			' 
			' radTextBox3
			' 
			Me.radTextBox3.Location = New System.Drawing.Point(765, 316)
			Me.radTextBox3.Name = "radTextBox3"
			Me.radTextBox3.Size = New System.Drawing.Size(100, 20)
			Me.radTextBox3.TabIndex = 3
			' 
			' radButton1
			' 
			Me.radButton1.Location = New System.Drawing.Point(765, 368)
			Me.radButton1.Name = "radButton1"
			Me.radButton1.Size = New System.Drawing.Size(110, 24)
			Me.radButton1.TabIndex = 4
			Me.radButton1.Text = "radButton1"
			' 
			' radButton2
			' 
			Me.radButton2.Location = New System.Drawing.Point(765, 451)
			Me.radButton2.Name = "radButton2"
			Me.radButton2.Size = New System.Drawing.Size(110, 24)
			Me.radButton2.TabIndex = 5
			Me.radButton2.Text = "radButton2"
			' 
			' radButton3
			' 
			Me.radButton3.Location = New System.Drawing.Point(765, 531)
			Me.radButton3.Name = "radButton3"
			Me.radButton3.Size = New System.Drawing.Size(110, 24)
			Me.radButton3.TabIndex = 6
			Me.radButton3.Text = "radButton3"
			' 
			' radDropDownList1
			' 
			Me.radDropDownList1.Location = New System.Drawing.Point(750, 12)
			Me.radDropDownList1.Name = "radDropDownList1"
			Me.radDropDownList1.Size = New System.Drawing.Size(246, 20)
			Me.radDropDownList1.TabIndex = 7
			Me.radDropDownList1.Text = "radDropDownList1"
			' 
			' radLabel1
			' 
			Me.radLabel1.Location = New System.Drawing.Point(700, 12)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New System.Drawing.Size(34, 18)
			Me.radLabel1.TabIndex = 8
			Me.radLabel1.Text = "Scale:"
			' 
			' RadForm1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(96F, 96F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
			Me.ClientSize = New System.Drawing.Size(1006, 687)
			Me.Controls.Add(Me.radLabel1)
			Me.Controls.Add(Me.radDropDownList1)
			Me.Controls.Add(Me.radButton3)
			Me.Controls.Add(Me.radButton2)
			Me.Controls.Add(Me.radButton1)
			Me.Controls.Add(Me.radTextBox3)
			Me.Controls.Add(Me.radTextBox2)
			Me.Controls.Add(Me.radTextBox1)
			Me.Controls.Add(Me.radGridView1)
			Me.Name = "RadForm1"
			' 
			' 
			' 
			Me.RootElement.ApplyShapeToControl = True
			Me.Text = "RadForm1"
			DirectCast(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radTextBox2, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radTextBox3, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radButton1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radButton2, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radButton3, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private radGridView1 As Telerik.WinControls.UI.RadGridView
		Private radTextBox1 As Telerik.WinControls.UI.RadTextBox
		Private radTextBox2 As Telerik.WinControls.UI.RadTextBox
		Private radTextBox3 As Telerik.WinControls.UI.RadTextBox
		Private radButton1 As Telerik.WinControls.UI.RadButton
		Private radButton2 As Telerik.WinControls.UI.RadButton
		Private radButton3 As Telerik.WinControls.UI.RadButton
		Private radDropDownList1 As Telerik.WinControls.UI.RadDropDownList
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
	End Class
End Namespace
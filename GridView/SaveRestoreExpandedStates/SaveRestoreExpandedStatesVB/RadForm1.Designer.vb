Namespace _1414148
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
			Dim tableViewDefinition5 As New Telerik.WinControls.UI.TableViewDefinition()
			Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
			Me.radButton1 = New Telerik.WinControls.UI.RadButton()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radGridView1
			' 
			Me.radGridView1.Location = New System.Drawing.Point(24, 29)
			' 
			' 
			' 
			Me.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition5
			Me.radGridView1.Name = "radGridView1"
			Me.radGridView1.Size = New System.Drawing.Size(1062, 627)
			Me.radGridView1.TabIndex = 0
			' 
			' radButton1
			' 
			Me.radButton1.Location = New System.Drawing.Point(222, 713)
			Me.radButton1.Name = "radButton1"
			Me.radButton1.Size = New System.Drawing.Size(137, 30)
			Me.radButton1.TabIndex = 1
			Me.radButton1.Text = "radButton1"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.radButton1.Click += new System.EventHandler(this.RadButton1_Click);
			' 
			' RadForm1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1166, 862)
			Me.Controls.Add(Me.radButton1)
			Me.Controls.Add(Me.radGridView1)
			Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
			Me.Name = "RadForm1"
			' 
			' 
			' 
			Me.RootElement.ApplyShapeToControl = True
			Me.Text = "RadForm1"

			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radGridView1 As Telerik.WinControls.UI.RadGridView
		Private WithEvents radButton1 As Telerik.WinControls.UI.RadButton
	End Class
End Namespace
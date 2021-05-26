Namespace GridViewCustomCells
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer

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
			Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
			Me.radButton1 = New Telerik.WinControls.UI.RadButton()
			DirectCast(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radGridView1
			' 
			Me.radGridView1.Location = New System.Drawing.Point(13, 13)
			Me.radGridView1.Name = "radGridView1"
			Me.radGridView1.Size = New System.Drawing.Size(1184, 353)
			Me.radGridView1.TabIndex = 0
			Me.radGridView1.Text = "radGridView1"
			' 
			' radButton1
			' 
			Me.radButton1.Location = New System.Drawing.Point(210, 386)
			Me.radButton1.Name = "radButton1"
			Me.radButton1.Size = New System.Drawing.Size(110, 24)
			Me.radButton1.TabIndex = 1
			Me.radButton1.Text = "radButton1"

			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1254, 617)
			Me.Controls.Add(Me.radButton1)
			Me.Controls.Add(Me.radGridView1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			DirectCast(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radButton1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radGridView1 As Telerik.WinControls.UI.RadGridView
		Private radButton1 As Telerik.WinControls.UI.RadButton
	End Class
End Namespace


Namespace _1407985
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
			Me.radListView1 = New MyRadListView()
			Me.radButton1 = New Telerik.WinControls.UI.RadButton()
			CType(Me.radListView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radListView1
			' 
			Me.radListView1.Location = New Point(80, 25)
			Me.radListView1.Name = "radListView1"
			Me.radListView1.Size = New Size(1006, 605)
			Me.radListView1.TabIndex = 0
			' 
			' radButton1
			' 
			Me.radButton1.Location = New Point(1009, 737)
			Me.radButton1.Name = "radButton1"
			Me.radButton1.Size = New Size(110, 24)
			Me.radButton1.TabIndex = 1
			Me.radButton1.Text = "radButton1"
			' 
			' RadForm1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.ClientSize = New Size(1295, 866)
			Me.Controls.Add(Me.radButton1)
			Me.Controls.Add(Me.radListView1)
			Me.Name = "RadForm1"
			' 
			' 
			' 
			Me.RootElement.ApplyShapeToControl = True
			Me.Text = "RadForm1"
			CType(Me.radListView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radListView1 As MyRadListView
		Private radButton1 As Telerik.WinControls.UI.RadButton
	End Class
End Namespace
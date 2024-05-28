Imports Microsoft.VisualBasic
Imports System
Namespace RadUserControl
	Public Partial Class Form1
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
			Me.elementHost1 = New System.Windows.Forms.Integration.ElementHost()
			Me.wpfUserControl1 = New WpfApplication.WpfUserControl()
			Me.SuspendLayout()
			' 
			' elementHost1
			' 
			Me.elementHost1.Location = New System.Drawing.Point(40, 30)
			Me.elementHost1.Name = "elementHost1"
			Me.elementHost1.Size = New System.Drawing.Size(481, 366)
			Me.elementHost1.TabIndex = 0
			Me.elementHost1.Text = "elementHost1"
			Me.elementHost1.Child = Me.wpfUserControl1
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(557, 452)
			Me.Controls.Add(Me.elementHost1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private elementHost1 As System.Windows.Forms.Integration.ElementHost
		Private wpfUserControl1 As WpfApplication.WpfUserControl
	End Class
End Namespace


Imports Microsoft.VisualBasic
Imports System
Namespace RadUserControls
	Public Partial Class UserControl1
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

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControl1))
			Me.radCalendar1 = New Telerik.WinControls.UI.RadCalendar()
			Me.radButton1 = New Telerik.WinControls.UI.RadButton()
			CType(Me.radCalendar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radCalendar1
			' 
			Me.radCalendar1.CellAlign = System.Drawing.ContentAlignment.MiddleCenter
			Me.radCalendar1.CellMargin = New System.Windows.Forms.Padding(0)
			Me.radCalendar1.CellPadding = New System.Windows.Forms.Padding(0)
			Me.radCalendar1.FastNavigationNextImage = (CType(resources.GetObject("radCalendar1.FastNavigationNextImage"), System.Drawing.Image))
			Me.radCalendar1.FastNavigationPrevImage = (CType(resources.GetObject("radCalendar1.FastNavigationPrevImage"), System.Drawing.Image))
			Me.radCalendar1.HeaderHeight = 17
			Me.radCalendar1.HeaderWidth = 17
			Me.radCalendar1.Location = New System.Drawing.Point(3, 3)
			Me.radCalendar1.Name = "radCalendar1"
			Me.radCalendar1.NavigationNextImage = (CType(resources.GetObject("radCalendar1.NavigationNextImage"), System.Drawing.Image))
			Me.radCalendar1.NavigationPrevImage = (CType(resources.GetObject("radCalendar1.NavigationPrevImage"), System.Drawing.Image))
			Me.radCalendar1.RangeMaxDate = New System.DateTime(2099, 12, 30, 0, 0, 0, 0)
			Me.radCalendar1.Size = New System.Drawing.Size(257, 227)
			Me.radCalendar1.TabIndex = 0
			Me.radCalendar1.Text = "radCalendar1"
			' 
			' radButton1
			' 
			Me.radButton1.Location = New System.Drawing.Point(68, 236)
			Me.radButton1.Name = "radButton1"
			Me.radButton1.Size = New System.Drawing.Size(123, 39)
			Me.radButton1.TabIndex = 1
			Me.radButton1.Text = "radButton1"
'			Me.radButton1.Click += New System.EventHandler(Me.radButton1_Click);
			' 
			' UserControl1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.radButton1)
			Me.Controls.Add(Me.radCalendar1)
			Me.Name = "UserControl1"
			Me.Size = New System.Drawing.Size(266, 278)
			CType(Me.radCalendar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private radCalendar1 As Telerik.WinControls.UI.RadCalendar
		Private WithEvents radButton1 As Telerik.WinControls.UI.RadButton
	End Class
End Namespace

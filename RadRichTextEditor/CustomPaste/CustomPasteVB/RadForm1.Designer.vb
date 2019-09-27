Namespace _1431704
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
			Me.radRichTextEditor1 = New Telerik.WinControls.UI.RadRichTextEditor()
			Me.radButton1 = New Telerik.WinControls.UI.RadButton()
			CType(Me.radRichTextEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radRichTextEditor1
			' 
			Me.radRichTextEditor1.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(156)))), (CInt((CByte(189)))), (CInt((CByte(232)))))
			Me.radRichTextEditor1.Location = New System.Drawing.Point(104, 36)
			Me.radRichTextEditor1.Name = "radRichTextEditor1"
			Me.radRichTextEditor1.SelectionFill = System.Drawing.Color.FromArgb((CInt((CByte(128)))), (CInt((CByte(78)))), (CInt((CByte(158)))), (CInt((CByte(255)))))
			Me.radRichTextEditor1.Size = New System.Drawing.Size(982, 563)
			Me.radRichTextEditor1.TabIndex = 0
			' 
			' radButton1
			' 
			Me.radButton1.Location = New System.Drawing.Point(806, 632)
			Me.radButton1.Name = "radButton1"
			Me.radButton1.Size = New System.Drawing.Size(110, 24)
			Me.radButton1.TabIndex = 1
			Me.radButton1.Text = "radButton1"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
			' 
			' RadForm1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1145, 700)
			Me.Controls.Add(Me.radButton1)
			Me.Controls.Add(Me.radRichTextEditor1)
			Me.Name = "RadForm1"
			' 
			' 
			' 
			Me.RootElement.ApplyShapeToControl = True
			Me.Text = "RadForm1"
			CType(Me.radRichTextEditor1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radRichTextEditor1 As Telerik.WinControls.UI.RadRichTextEditor
		Private WithEvents radButton1 As Telerik.WinControls.UI.RadButton
	End Class
End Namespace
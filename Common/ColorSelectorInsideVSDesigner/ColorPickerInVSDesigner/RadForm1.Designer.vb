<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RadForm1
    Inherits Telerik.WinControls.UI.RadForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Me.BorderPanel1 = New CustomColorPicker.BorderPanel()
		CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'BorderPanel1
		'
		Me.BorderPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(215, Byte), Integer))
		Me.BorderPanel1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
		Me.BorderPanel1.Location = New System.Drawing.Point(48, 42)
		Me.BorderPanel1.Name = "BorderPanel1"
		Me.BorderPanel1.ShowBottom = True
		Me.BorderPanel1.ShowLeft = True
		Me.BorderPanel1.ShowRight = True
		Me.BorderPanel1.ShowTop = True
		Me.BorderPanel1.Size = New System.Drawing.Size(194, 163)
		Me.BorderPanel1.TabIndex = 0
		'
		'RadForm1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(292, 270)
		Me.Controls.Add(Me.BorderPanel1)
		Me.Name = "RadForm1"
		'
		'
		'
		Me.RootElement.ApplyShapeToControl = True
		Me.Text = "RadForm1"
		CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents BorderPanel1 As CustomColorPicker.BorderPanel
End Class

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
        Me.radGridView1 = New Telerik.WinControls.UI.RadGridView
        CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'radGridView1
        '
        Me.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.radGridView1.Location = New System.Drawing.Point(0, 0)
        Me.radGridView1.Name = "radGridView1"
        Me.radGridView1.Size = New System.Drawing.Size(446, 339)
        Me.radGridView1.TabIndex = 0
        '
        'RadForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 339)
        Me.Controls.Add(Me.radGridView1)
        Me.Name = "RadForm1"
        Me.Text = "Form1"
        CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private radGridView1 As Telerik.WinControls.UI.RadGridView

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

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
        Me.RadCheckBox1 = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadReadOnlyTreeView1 = New RadTreeView_ReadOnly_VB.RadReadOnlyTreeView()
        CType(Me.RadCheckBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadReadOnlyTreeView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadCheckBox1
        '
        Me.RadCheckBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadCheckBox1.Location = New System.Drawing.Point(0, 0)
        Me.RadCheckBox1.Name = "RadCheckBox1"
        Me.RadCheckBox1.Size = New System.Drawing.Size(148, 18)
        Me.RadCheckBox1.TabIndex = 0
        Me.RadCheckBox1.Text = "Checkboxes are read only"
        '
        'RadReadOnlyTreeView1
        '
        Me.RadReadOnlyTreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadReadOnlyTreeView1.Location = New System.Drawing.Point(0, 18)
        Me.RadReadOnlyTreeView1.Name = "RadReadOnlyTreeView1"
        Me.RadReadOnlyTreeView1.Size = New System.Drawing.Size(284, 244)
        Me.RadReadOnlyTreeView1.SpacingBetweenNodes = -1
        Me.RadReadOnlyTreeView1.TabIndex = 1
        Me.RadReadOnlyTreeView1.Text = "RadReadOnlyTreeView1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.RadReadOnlyTreeView1)
        Me.Controls.Add(Me.RadCheckBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.RadCheckBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadReadOnlyTreeView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadCheckBox1 As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadReadOnlyTreeView1 As RadTreeView_ReadOnly_VB.RadReadOnlyTreeView

End Class

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
        Me.RadImageBindingPanel1 = New RadImageBindingPanelVB.RadImageBindingPanelTest.RadImageBindingPanel
        CType(Me.RadImageBindingPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadImageBindingPanel1
        '
        Me.RadImageBindingPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.RadImageBindingPanel1.ButtonSize = New System.Drawing.Size(284, 20)
        Me.RadImageBindingPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadImageBindingPanel1.Image = Nothing
        Me.RadImageBindingPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RadImageBindingPanel1.Name = "RadImageBindingPanel1"
        Me.RadImageBindingPanel1.OpenDialogTitle = "Open Image"
        Me.RadImageBindingPanel1.ReadOnly = False
        Me.RadImageBindingPanel1.Size = New System.Drawing.Size(284, 262)
        Me.RadImageBindingPanel1.TabIndex = 0
        Me.RadImageBindingPanel1.Text = "RadImageBindingPanel1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.RadImageBindingPanel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.RadImageBindingPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadImageBindingPanel1 As RadImageBindingPanelVB.RadImageBindingPanelTest.RadImageBindingPanel

End Class

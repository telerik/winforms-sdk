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
        Me.rgData = New Telerik.WinControls.UI.RadGridView
        CType(Me.rgData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgData.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rgData
        '
        Me.rgData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rgData.Location = New System.Drawing.Point(0, 0)
        Me.rgData.Name = "rgData"
        Me.rgData.Size = New System.Drawing.Size(852, 481)
        Me.rgData.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(852, 481)
        Me.Controls.Add(Me.rgData)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.rgData.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rgData As Telerik.WinControls.UI.RadGridView

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RadGanttViewForm
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
        Me.CustomRadGanttView = New CustomGanttView() 'New Telerik.WinControls.UI.RadGanttView()
        CType(Me.CustomRadGanttView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CustomRadGanttView
        '
        Me.CustomRadGanttView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CustomRadGanttView.Location = New System.Drawing.Point(0, 0)
        Me.CustomRadGanttView.Name = "CustomRadGanttView"
        Me.CustomRadGanttView.Size = New System.Drawing.Size(1115, 644)
        Me.CustomRadGanttView.SplitterWidth = 7
        Me.CustomRadGanttView.TabIndex = 0
        Me.CustomRadGanttView.Text = "RadGanttView1"
        '
        'RadGanttViewForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1115, 644)
        Me.Controls.Add(Me.CustomRadGanttView)
        Me.Name = "RadGanttViewForm"
        Me.Text = "Form1"
        CType(Me.CustomRadGanttView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CustomRadGanttView As CustomGanttView 'Telerik.WinControls.UI.RadGanttView

End Class

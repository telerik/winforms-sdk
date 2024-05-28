<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form
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
        Me.RadGridViewSmartTags1 = New TestSmartTags.RadGridViewSmartTags
        CType(Me.RadGridViewSmartTags1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridViewSmartTags1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadGridViewSmartTags1
        '
        Me.RadGridViewSmartTags1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadGridViewSmartTags1.Location = New System.Drawing.Point(0, 0)
        Me.RadGridViewSmartTags1.MyContextMenuEnabled = False
        Me.RadGridViewSmartTags1.MyContextMenuVisible = True
        Me.RadGridViewSmartTags1.Name = "RadGridViewSmartTags1"
        Me.RadGridViewSmartTags1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.RadGridViewSmartTags1.Size = New System.Drawing.Size(308, 292)
        Me.RadGridViewSmartTags1.TabIndex = 0
        Me.RadGridViewSmartTags1.Text = "RadGridViewSmartTags1"
        '
        'Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(308, 292)
        Me.Controls.Add(Me.RadGridViewSmartTags1)
        Me.Name = "Form"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "Form"
        CType(Me.RadGridViewSmartTags1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridViewSmartTags1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadGridViewSmartTags1 As TestSmartTags.RadGridViewSmartTags
End Class

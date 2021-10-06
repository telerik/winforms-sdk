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
        Me.components = New System.ComponentModel.Container()
        Me.RadTaskBoard1 = New Telerik.WinControls.UI.RadTaskBoard()
        Me.RadContextMenu1 = New Telerik.WinControls.UI.RadContextMenu(Me.components)
        Me.RadMenuItem1 = New Telerik.WinControls.UI.RadMenuItem()
        CType(Me.RadTaskBoard1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadTaskBoard1
        '
        Me.RadTaskBoard1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadTaskBoard1.Location = New System.Drawing.Point(0, 0)
        Me.RadTaskBoard1.Name = "RadTaskBoard1"
        Me.RadTaskBoard1.Size = New System.Drawing.Size(831, 602)
        Me.RadTaskBoard1.TabIndex = 0
        '
        'RadContextMenu1
        '
        Me.RadContextMenu1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadMenuItem1})
        '
        'RadMenuItem1
        '
        Me.RadMenuItem1.Name = "RadMenuItem1"
        Me.RadMenuItem1.Text = "Edit task card"
        '
        'RadForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(831, 602)
        Me.Controls.Add(Me.RadTaskBoard1)
        Me.Name = "RadForm1"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "RadForm1"
        CType(Me.RadTaskBoard1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadTaskBoard1 As Telerik.WinControls.UI.RadTaskBoard
    Friend WithEvents RadContextMenu1 As Telerik.WinControls.UI.RadContextMenu
    Friend WithEvents RadMenuItem1 As Telerik.WinControls.UI.RadMenuItem
End Class

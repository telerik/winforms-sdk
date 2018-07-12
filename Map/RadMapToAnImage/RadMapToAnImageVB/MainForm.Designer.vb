<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.RadMap1 = New Telerik.WinControls.UI.RadMap()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        CType(Me.RadMap1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadMap1
        '
        Me.RadMap1.Location = New System.Drawing.Point(13, 32)
        Me.RadMap1.Name = "RadMap1"
        Me.RadMap1.Size = New System.Drawing.Size(956, 729)
        Me.RadMap1.TabIndex = 0
        '
        'RadButton1
        '
        Me.RadButton1.Location = New System.Drawing.Point(13, 2)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(110, 24)
        Me.RadButton1.TabIndex = 1
        Me.RadButton1.Text = "Export"
        '
        'RadForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(981, 773)
        Me.Controls.Add(Me.RadButton1)
        Me.Controls.Add(Me.RadMap1)
        Me.Name = "MainForm"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "MainForm"
        CType(Me.RadMap1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RadMap1 As Telerik.WinControls.UI.RadMap
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
End Class

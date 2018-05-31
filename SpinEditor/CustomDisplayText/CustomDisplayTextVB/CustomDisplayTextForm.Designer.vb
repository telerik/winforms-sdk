<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomDisplayTextForm
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
        Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadSpinEditor3 = New CustomDisplayTextVB.MyRadSpinEditor()
        Me.RadSpinEditor2 = New CustomDisplayTextVB.MyRadSpinEditor()
        Me.RadSpinEditor1 = New CustomDisplayTextVB.MyRadSpinEditor()
        Me.TelerikMetroTheme1 = New Telerik.WinControls.Themes.TelerikMetroTheme()
        CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadSpinEditor3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadSpinEditor2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadSpinEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'radLabel3
        '
        Me.radLabel3.Location = New System.Drawing.Point(416, 8)
        Me.radLabel3.Name = "radLabel3"
        Me.radLabel3.Size = New System.Drawing.Size(26, 16)
        Me.radLabel3.TabIndex = 8
        Me.radLabel3.Text = "Hex"
        Me.radLabel3.ThemeName = "TelerikMetro"
        '
        'radLabel2
        '
        Me.radLabel2.Location = New System.Drawing.Point(214, 8)
        Me.radLabel2.Name = "radLabel2"
        Me.radLabel2.Size = New System.Drawing.Size(73, 16)
        Me.radLabel2.TabIndex = 7
        Me.radLabel2.Text = "Leading Zero"
        Me.radLabel2.ThemeName = "TelerikMetro"
        '
        'radLabel1
        '
        Me.radLabel1.Location = New System.Drawing.Point(12, 12)
        Me.radLabel1.Name = "radLabel1"
        Me.radLabel1.Size = New System.Drawing.Size(97, 16)
        Me.radLabel1.TabIndex = 6
        Me.radLabel1.Text = "Scientific Notation"
        Me.radLabel1.ThemeName = "TelerikMetro"
        '
        'RadSpinEditor3
        '
        Me.RadSpinEditor3.Hexadecimal = True
        Me.RadSpinEditor3.Location = New System.Drawing.Point(415, 36)
        Me.RadSpinEditor3.Name = "RadSpinEditor3"
        Me.RadSpinEditor3.Size = New System.Drawing.Size(179, 24)
        Me.RadSpinEditor3.TabIndex = 11
        Me.RadSpinEditor3.TabStop = False
        Me.RadSpinEditor3.ThemeName = "TelerikMetro"
        '
        'RadSpinEditor2
        '
        Me.RadSpinEditor2.LeadingZero = True
        Me.RadSpinEditor2.Location = New System.Drawing.Point(213, 36)
        Me.RadSpinEditor2.Name = "RadSpinEditor2"
        Me.RadSpinEditor2.ScientificNatation = False
        Me.RadSpinEditor2.Size = New System.Drawing.Size(179, 24)
        Me.RadSpinEditor2.TabIndex = 10
        Me.RadSpinEditor2.TabStop = False
        Me.RadSpinEditor2.ThemeName = "TelerikMetro"
        '
        'RadSpinEditor1
        '
        Me.RadSpinEditor1.LeadingZero = False
        Me.RadSpinEditor1.Location = New System.Drawing.Point(12, 36)
        Me.RadSpinEditor1.Name = "RadSpinEditor1"
        Me.RadSpinEditor1.ScientificNatation = True
        Me.RadSpinEditor1.Size = New System.Drawing.Size(179, 24)
        Me.RadSpinEditor1.TabIndex = 9
        Me.RadSpinEditor1.TabStop = False
        Me.RadSpinEditor1.ThemeName = "TelerikMetro"
        '
        'CustomDisplayTextForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 119)
        Me.Controls.Add(Me.RadSpinEditor3)
        Me.Controls.Add(Me.RadSpinEditor2)
        Me.Controls.Add(Me.RadSpinEditor1)
        Me.Controls.Add(Me.radLabel3)
        Me.Controls.Add(Me.radLabel2)
        Me.Controls.Add(Me.radLabel1)
        Me.Name = "CustomDisplayTextForm"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "CustomDisplayTextForm"
        Me.ThemeName = "TelerikMetro"
        CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadSpinEditor3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadSpinEditor2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadSpinEditor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents radLabel3 As Telerik.WinControls.UI.RadLabel
    Private WithEvents radLabel2 As Telerik.WinControls.UI.RadLabel
    Private WithEvents radLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadSpinEditor1 As MyRadSpinEditor
    Friend WithEvents RadSpinEditor2 As MyRadSpinEditor
    Friend WithEvents RadSpinEditor3 As MyRadSpinEditor
    Friend WithEvents TelerikMetroTheme1 As Telerik.WinControls.Themes.TelerikMetroTheme
End Class

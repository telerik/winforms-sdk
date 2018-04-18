<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomDraggingServiceForm
    Inherits Telerik.WinControls.UI.RadForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomDraggingServiceForm))
        Me.RadDiagram1 = New Telerik.WinControls.UI.RadDiagram()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.TelerikMetroTheme1 = New Telerik.WinControls.Themes.TelerikMetroTheme()
        CType(Me.RadDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadDiagram1.SuspendLayout()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadDiagram1
        '
        Me.RadDiagram1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadDiagram1.Controls.Add(Me.RadButton1)
        Me.RadDiagram1.Location = New System.Drawing.Point(13, 13)
        Me.RadDiagram1.Name = "RadDiagram1"
        Me.RadDiagram1.SerializedXml = resources.GetString("RadDiagram1.SerializedXml")
        Me.RadDiagram1.Size = New System.Drawing.Size(533, 494)
        Me.RadDiagram1.TabIndex = 0
        Me.RadDiagram1.Text = "RadDiagram1"
        Me.RadDiagram1.ThemeName = "TelerikMetro"
        '
        'RadButton1
        '
        Me.RadButton1.Location = New System.Drawing.Point(4, 4)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(218, 24)
        Me.RadButton1.TabIndex = 0
        Me.RadButton1.Text = "Toggle Drag Mode"
        Me.RadButton1.ThemeName = "TelerikMetro"
        '
        'CustomDraggingServiceForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 519)
        Me.Controls.Add(Me.RadDiagram1)
        Me.Name = "CustomDraggingServiceForm"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "CustomDraggingServiceForm"
        Me.ThemeName = "TelerikMetro"
        CType(Me.RadDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadDiagram1.ResumeLayout(False)
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RadDiagram1 As Telerik.WinControls.UI.RadDiagram
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents TelerikMetroTheme1 As Telerik.WinControls.Themes.TelerikMetroTheme
End Class

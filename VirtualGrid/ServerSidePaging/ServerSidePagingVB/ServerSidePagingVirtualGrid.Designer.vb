<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ServerSidePagingVirtualGrid
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
        Me.RadVirtualGrid1 = New Telerik.WinControls.UI.RadVirtualGrid()
        Me.TelerikMetroTheme1 = New Telerik.WinControls.Themes.TelerikMetroTheme()
        CType(Me.RadVirtualGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadVirtualGrid1
        '
        Me.RadVirtualGrid1.Location = New System.Drawing.Point(13, 13)
        Me.RadVirtualGrid1.MasterViewInfo.ShowFilterRow = False
        Me.RadVirtualGrid1.MasterViewInfo.ShowNewRow = False
        Me.RadVirtualGrid1.Name = "RadVirtualGrid1"
        Me.RadVirtualGrid1.Size = New System.Drawing.Size(813, 566)
        Me.RadVirtualGrid1.TabIndex = 0
        Me.RadVirtualGrid1.ThemeName = "TelerikMetro"
        '
        'ServerSidePagingVirtualGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(838, 591)
        Me.Controls.Add(Me.RadVirtualGrid1)
        Me.Name = "ServerSidePagingVirtualGrid"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "ServerSidePagingVirtualGrid"
        Me.ThemeName = "TelerikMetro"
        CType(Me.RadVirtualGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RadVirtualGrid1 As Telerik.WinControls.UI.RadVirtualGrid
    Friend WithEvents TelerikMetroTheme1 As Telerik.WinControls.Themes.TelerikMetroTheme
End Class

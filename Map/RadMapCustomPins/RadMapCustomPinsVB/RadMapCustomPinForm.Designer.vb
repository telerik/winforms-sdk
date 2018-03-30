<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RadMapCustomPinForm
    Inherits System.Windows.Forms.Form

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
    Private Sub InitializeComponent()
        Me.radMap1 = New Telerik.WinControls.UI.RadMap()
        CType((Me.radMap1), System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        Me.radMap1.Location = New System.Drawing.Point(13, 13)
        Me.radMap1.Name = "radMap1"
        Me.radMap1.Size = New System.Drawing.Size(1231, 832)
        Me.radMap1.TabIndex = 0
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0F, 16.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1256, 857)
        Me.Controls.Add(Me.radMap1)
        Me.Name = "RadMapCustomPinForm"
        Me.Text = "RadMapCustomPinForm"
        CType((Me.radMap1), System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Private radMap1 As Telerik.WinControls.UI.RadMap

End Class
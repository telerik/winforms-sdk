<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RadGanttViewTimelineSnapping
    Inherits Telerik.WinControls.UI.RadForm

    Private components As System.ComponentModel.IContainer = Nothing

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If

        MyBase.Dispose(disposing)
    End Sub

    Private Sub InitializeComponent()
        Me.radGanttView1 = New Telerik.WinControls.UI.RadGanttView()
        CType((Me.radGanttView1), System.ComponentModel.ISupportInitialize).BeginInit()
        CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        Me.radGanttView1.Location = New System.Drawing.Point(12, 12)
        Me.radGanttView1.Name = "radGanttView1"
        Me.radGanttView1.Ratio = 0.32F
        Me.radGanttView1.Size = New System.Drawing.Size(886, 585)
        Me.radGanttView1.SplitterWidth = 7
        Me.radGanttView1.TabIndex = 0
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(910, 609)
        Me.Controls.Add(Me.radGanttView1)
        Me.Name = "RadGanttViewTimelineSnapping"
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "RadGanttViewTimelineSnapping"
        CType((Me.radGanttView1), System.ComponentModel.ISupportInitialize).EndInit()
        CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Private radGanttView1 As Telerik.WinControls.UI.RadGanttView
End Class


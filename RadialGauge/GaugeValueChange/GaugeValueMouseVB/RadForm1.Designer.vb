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
        Me.RadRadialGauge1 = New Telerik.WinControls.UI.Gauges.RadRadialGauge()
        Me.RadialGaugeArc1 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
        Me.RadialGaugeArc2 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
        Me.RadialGaugeArc3 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
        Me.RadialGaugeTicks1 = New Telerik.WinControls.UI.Gauges.RadialGaugeTicks()
        Me.RadialGaugeLabels1 = New Telerik.WinControls.UI.Gauges.RadialGaugeLabels()
        Me.RadialGaugeNeedle1 = New Telerik.WinControls.UI.Gauges.RadialGaugeNeedle()
        CType(Me.RadRadialGauge1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadRadialGauge1
        '
        Me.RadRadialGauge1.BackColor = System.Drawing.Color.White
        Me.RadRadialGauge1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadRadialGauge1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadialGaugeArc1, Me.RadialGaugeArc2, Me.RadialGaugeArc3, Me.RadialGaugeTicks1, Me.RadialGaugeLabels1, Me.RadialGaugeNeedle1})
        Me.RadRadialGauge1.Location = New System.Drawing.Point(0, 0)
        Me.RadRadialGauge1.Name = "RadRadialGauge1"
        Me.RadRadialGauge1.RangeEnd = 180.0R
        Me.RadRadialGauge1.Size = New System.Drawing.Size(292, 270)
        Me.RadRadialGauge1.StartAngle = 130.0R
        Me.RadRadialGauge1.SweepAngle = 280.0R
        Me.RadRadialGauge1.TabIndex = 6
        Me.RadRadialGauge1.Text = "radRadialGauge1"
        Me.RadRadialGauge1.Value = 0.0!
        '
        'RadialGaugeArc1
        '
        Me.RadialGaugeArc1.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.RadialGaugeArc1.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.RadialGaugeArc1.Name = "RadialGaugeArc1"
        Me.RadialGaugeArc1.RangeEnd = 60.0R
        Me.RadialGaugeArc1.Width = 3.0R
        '
        'RadialGaugeArc2
        '
        Me.RadialGaugeArc2.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.RadialGaugeArc2.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.RadialGaugeArc2.Name = "RadialGaugeArc2"
        Me.RadialGaugeArc2.RangeEnd = 120.0R
        Me.RadialGaugeArc2.RangeStart = 61.0R
        Me.RadialGaugeArc2.Width = 3.0R
        '
        'RadialGaugeArc3
        '
        Me.RadialGaugeArc3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.RadialGaugeArc3.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.RadialGaugeArc3.Name = "RadialGaugeArc3"
        Me.RadialGaugeArc3.RangeEnd = 180.0R
        Me.RadialGaugeArc3.RangeStart = 121.0R
        Me.RadialGaugeArc3.Width = 3.0R
        '
        'RadialGaugeTicks1
        '
        Me.RadialGaugeTicks1.DrawText = False
        Me.RadialGaugeTicks1.Name = "RadialGaugeTicks1"
        Me.RadialGaugeTicks1.TickColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.RadialGaugeTicks1.TicksCount = 18
        Me.RadialGaugeTicks1.TicksLenghtPercentage = 4.0!
        Me.RadialGaugeTicks1.TicksRadiusPercentage = 83.0!
        Me.RadialGaugeTicks1.TickThickness = 1.0!
        '
        'RadialGaugeLabels1
        '
        Me.RadialGaugeLabels1.DrawText = False
        Me.RadialGaugeLabels1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.RadialGaugeLabels1.LabelFontSize = 5.0!
        Me.RadialGaugeLabels1.LabelRadiusPercentage = 68.0!
        Me.RadialGaugeLabels1.LabelsCount = 9
        Me.RadialGaugeLabels1.Name = "RadialGaugeLabels1"
        '
        'RadialGaugeNeedle1
        '
        Me.RadialGaugeNeedle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.RadialGaugeNeedle1.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.RadialGaugeNeedle1.BackLenghtPercentage = 0.0R
        Me.RadialGaugeNeedle1.InnerPointRadiusPercentage = 0.0R
        Me.RadialGaugeNeedle1.LenghtPercentage = 70.0R
        Me.RadialGaugeNeedle1.Name = "RadialGaugeNeedle1"
        Me.RadialGaugeNeedle1.PointRadiusPercentage = 7.0R
        Me.RadialGaugeNeedle1.Thickness = 1.5R
        Me.RadialGaugeNeedle1.Value = 130.0!
        '
        'RadForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 270)
        Me.Controls.Add(Me.RadRadialGauge1)
        Me.Name = "RadForm1"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "RadForm1"
        CType(Me.RadRadialGauge1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadRadialGauge1 As Telerik.WinControls.UI.Gauges.RadRadialGauge
    Friend WithEvents RadialGaugeArc1 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
    Friend WithEvents RadialGaugeArc2 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
    Friend WithEvents RadialGaugeArc3 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
    Friend WithEvents RadialGaugeTicks1 As Telerik.WinControls.UI.Gauges.RadialGaugeTicks
    Friend WithEvents RadialGaugeLabels1 As Telerik.WinControls.UI.Gauges.RadialGaugeLabels
    Friend WithEvents RadialGaugeNeedle1 As Telerik.WinControls.UI.Gauges.RadialGaugeNeedle
End Class

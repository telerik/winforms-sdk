using Telerik.WinControls.UI.Gauges;
namespace GaugeValueMouse
{
    partial class RadForm1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radRadialGauge1 = new Telerik.WinControls.UI.Gauges.RadRadialGauge();
            this.radialGaugeArc1 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeArc2 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeArc3 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeTicks1 = new Telerik.WinControls.UI.Gauges.RadialGaugeTicks();
            this.radialGaugeLabels1 = new Telerik.WinControls.UI.Gauges.RadialGaugeLabels();
            this.radialGaugeNeedle1 = new Telerik.WinControls.UI.Gauges.RadialGaugeNeedle();
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radRadialGauge1
            // 
            this.radRadialGauge1.BackColor = System.Drawing.Color.White;
            this.radRadialGauge1.CausesValidation = false;
            this.radRadialGauge1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radRadialGauge1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radialGaugeArc1,
            this.radialGaugeArc2,
            this.radialGaugeArc3,
            this.radialGaugeTicks1,
            this.radialGaugeLabels1,
            this.radialGaugeNeedle1});
            this.radRadialGauge1.Location = new System.Drawing.Point(0, 0);
            this.radRadialGauge1.Name = "radRadialGauge1";
            this.radRadialGauge1.RangeEnd = 180D;
            this.radRadialGauge1.Size = new System.Drawing.Size(292, 270);
            this.radRadialGauge1.StartAngle = 130D;
            this.radRadialGauge1.SweepAngle = 280D;
            this.radRadialGauge1.TabIndex = 6;
            this.radRadialGauge1.Text = "radRadialGauge1";
            this.radRadialGauge1.Value = 0F;
            // 
            // radialGaugeArc1
            // 
            this.radialGaugeArc1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(206)))), ((int)(((byte)(103)))));
            this.radialGaugeArc1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(206)))), ((int)(((byte)(103)))));
            this.radialGaugeArc1.Name = "radialGaugeArc1";
            this.radialGaugeArc1.RangeEnd = 60D;
            this.radialGaugeArc1.Width = 3D;
            // 
            // radialGaugeArc2
            // 
            this.radialGaugeArc2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeArc2.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeArc2.Name = "radialGaugeArc2";
            this.radialGaugeArc2.RangeEnd = 120D;
            this.radialGaugeArc2.RangeStart = 61D;
            this.radialGaugeArc2.Width = 3D;
            // 
            // radialGaugeArc3
            // 
            this.radialGaugeArc3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.radialGaugeArc3.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.radialGaugeArc3.Name = "radialGaugeArc3";
            this.radialGaugeArc3.RangeEnd = 180D;
            this.radialGaugeArc3.RangeStart = 121D;
            this.radialGaugeArc3.Width = 3D;
            // 
            // radialGaugeTicks1
            // 
            this.radialGaugeTicks1.DrawText = false;
            this.radialGaugeTicks1.Name = "radialGaugeTicks1";
            this.radialGaugeTicks1.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeTicks1.TicksCount = 18;
            this.radialGaugeTicks1.TicksLenghtPercentage = 4F;
            this.radialGaugeTicks1.TicksRadiusPercentage = 83F;
            this.radialGaugeTicks1.TickThickness = 1F;
            // 
            // radialGaugeLabels1
            // 
            this.radialGaugeLabels1.DrawText = false;
            this.radialGaugeLabels1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeLabels1.LabelFontSize = 5F;
            this.radialGaugeLabels1.LabelRadiusPercentage = 68F;
            this.radialGaugeLabels1.LabelsCount = 9;
            this.radialGaugeLabels1.Name = "radialGaugeLabels1";
            // 
            // radialGaugeNeedle1
            // 
            this.radialGaugeNeedle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.radialGaugeNeedle1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.radialGaugeNeedle1.BackLenghtPercentage = 0D;
            this.radialGaugeNeedle1.InnerPointRadiusPercentage = 0D;
            this.radialGaugeNeedle1.LenghtPercentage = 70D;
            this.radialGaugeNeedle1.Name = "radialGaugeNeedle1";
            this.radialGaugeNeedle1.PointRadiusPercentage = 7D;
            this.radialGaugeNeedle1.Thickness = 1.5D;
            this.radialGaugeNeedle1.Value = 130F;
            // 
            // RadForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 270);
            this.Controls.Add(this.radRadialGauge1);
            this.Name = "RadForm1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "RadForm1";
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.Gauges.RadRadialGauge radRadialGauge1;
        private RadialGaugeArc radialGaugeArc1;
        private RadialGaugeArc radialGaugeArc2;
        private RadialGaugeArc radialGaugeArc3;
        private RadialGaugeTicks radialGaugeTicks1;
        private RadialGaugeLabels radialGaugeLabels1;
        private RadialGaugeNeedle radialGaugeNeedle1;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI.Gauges;

namespace GaugeValueMouse
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        Timer timer = new Timer();

        public RadForm1()
        {
            InitializeComponent();

            this.radRadialGauge1.MouseMove += radRadialGauge1_MouseMove;
            this.radialGaugeNeedle1.BindValue = true;

            this.radRadialGauge1.PreviewKeyDown += radRadialGauge1_PreviewKeyDown;
            this.radRadialGauge1.KeyUp += radRadialGauge1_KeyUp;
            timer.Tick += timer_Tick;
            timer.Interval = 100;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            float newValue;
            if (isDownArrow)
            {
                newValue = Math.Max(0, this.radRadialGauge1.Value - 1);
                this.radRadialGauge1.Value = newValue;
            }
            else if (isUpArrow)
            {
                newValue = Math.Max(this.radRadialGauge1.Value + 1, (float)this.radRadialGauge1.RangeEnd);
                this.radRadialGauge1.Value += 1;
            }
        }

        private void radRadialGauge1_KeyUp(object sender, KeyEventArgs e)
        {
            isDownArrow = false;
            isUpArrow = false;
            timer.Stop();
        }

        bool isDownArrow = false;
        bool isUpArrow = false;

        private void radRadialGauge1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Down)
            {
                isDownArrow = true;
            }
            else if (e.KeyData == Keys.Up)
            {
                isUpArrow = true;
            }
            timer.Start();
        }

        private void radRadialGauge1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                UpdateValue(e.Location);
            }
        }

        private void UpdateValue(Point pointLocation)
        {
            float centerX = this.radRadialGauge1.GaugeElement.GaugeCenter.X + this.radialGaugeNeedle1.TotalTransform.DX;
            float centerY = this.radRadialGauge1.GaugeElement.GaugeCenter.Y + this.radialGaugeNeedle1.TotalTransform.DY;
            PointF center = new PointF(centerX, centerY);

            double radian = Math.Atan2(pointLocation.Y - center.Y, pointLocation.X - center.X);
            double angle = radian * (180 / Math.PI);
            if (angle < 0.0)
            {
                angle += 360.0;
            }

            float newValue = CalculateValueByAngle(angle, this.radRadialGauge1.RangeStart, this.radRadialGauge1.RangeEnd, this.radRadialGauge1.StartAngle, this.radRadialGauge1.SweepAngle);
            this.radRadialGauge1.Value = Math.Min(newValue, (float)this.radRadialGauge1.RangeEnd);
        }

        public float CalculateValueByAngle(double needleAngleDegree, double rangeStart, double rangeEnd, double startAngle, double sweepAngle)
        {
            float value = 0;
            double angleDiff = needleAngleDegree - startAngle;
            if (angleDiff < 0)
            {
                angleDiff += 360;
            }
            double ratio = (angleDiff) / sweepAngle;
            value = (float)(ratio * Math.Abs(rangeEnd - rangeStart) + rangeStart);
            return value;
        }
    }
}
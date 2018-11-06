using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Reflection;
using Telerik.Charting;
using Telerik.WinControls;
using Telerik.WinControls.Paint;
using Telerik.WinControls.Primitives;
using Telerik.WinControls.UI;

namespace _3DBarChart
{
    public class CustomBarSeriesDrawPart : BarSeriesDrawPart
    {
        private Font summaryFont = new Font("Calibri", 12, FontStyle.Bold);

        public CustomBarSeriesDrawPart(BarSeries series, IChartRenderer renderer)
            : base(series, renderer)
        { }

        public bool DrawCap { get; set; }

        public override void DrawSeriesParts()
        {
            CustomCartesianRenderer customRenderer = this.Renderer as CustomCartesianRenderer;
            Graphics graphics = customRenderer.Graphics;
            RadGdiGraphics radGraphics = new RadGdiGraphics(graphics);

            for (int j = 0; j < this.Element.DataPoints.Count; j++)
            {
                DataPoint dataPoint = this.Element.DataPoints[j];
                RadRect slot = dataPoint.LayoutSlot;

                if ((bool)dataPoint.GetType().GetField("isEmpty", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(dataPoint))
                {
                    continue;
                }

                RectangleF barBounds = new RectangleF((float)(this.OffsetX + slot.X), (float)(this.OffsetY + slot.Y), (float)slot.Width, (float)slot.Height);
                bool isAreaVertical = (((CartesianSeries)this.Element).Parent as CartesianArea).Orientation == System.Windows.Forms.Orientation.Vertical;

                DataPointElement childElement = (DataPointElement)this.Element.Children[j];

                if (isAreaVertical)
                {
                    float realHeight = barBounds.Height * childElement.HeightAspectRatio;
                    barBounds.Y += barBounds.Height - realHeight;
                    barBounds.Height = realHeight;
                }
                else
                {
                    float realWidth = barBounds.Width * childElement.HeightAspectRatio;
                    barBounds.Width = realWidth;
                }

                barBounds = AdjustBarDataPointBounds(childElement, barBounds);

                if (isAreaVertical)
                {
                    barBounds.Width = Math.Max(barBounds.Width, 1f);
                }
                else
                {
                    barBounds.Height = Math.Max(barBounds.Height, 1f);
                }

                RadImageShape background = childElement.BackgroundShape;

                if (background != null)
                {
                    background.Paint(graphics, barBounds);
                }

                FillPrimitiveImpl fill = new FillPrimitiveImpl(childElement, null);
                fill.PaintFill(radGraphics, 0, new SizeF(1, 1), barBounds);

                BorderPrimitiveImpl border = new BorderPrimitiveImpl(childElement, null);
                border.PaintBorder(radGraphics, 0, new SizeF(1, 1), barBounds);

                if (childElement.Image != null)
                {
                    graphics.SetClip(barBounds);
                    ImagePrimitiveImpl pointImage = new ImagePrimitiveImpl(childElement);
                    pointImage.PaintImage(radGraphics, childElement.Image, barBounds, childElement.ImageLayout, childElement.ImageAlignment, childElement.ImageOpacity, false);
                    graphics.ResetClip();
                }

                float xOffset = 20;
                float yOffset = 20;

                GraphicsPath path = new GraphicsPath();
                List<PointF> lines = new List<PointF>();
                lines.Add(new PointF(barBounds.Right, barBounds.Y));
                lines.Add(new PointF(barBounds.Right + xOffset, barBounds.Y - yOffset));
                lines.Add(new PointF(barBounds.Right + xOffset, barBounds.Bottom - yOffset));
                lines.Add(new PointF(barBounds.Right, barBounds.Bottom));
                path.AddLines(lines.ToArray());
                path.CloseFigure();

                using (Pen pen = new Pen(this.Element.BorderColor), pen2 = new Pen(Color.FromArgb(100, Color.Black)))
                {
                    graphics.DrawPath(pen, path);
                    graphics.DrawPath(pen2, path);
                }

                using (Brush brush = new SolidBrush(this.Element.BackColor), brush2 = new SolidBrush(Color.FromArgb(100, Color.Black)))
                {
                    graphics.FillPath(brush, path);
                    graphics.FillPath(brush2, path);
                }

                if (this.DrawCap)
                {
                    path = new GraphicsPath();
                    lines = new List<PointF>();
                    lines.Add(new PointF(barBounds.X, barBounds.Y));
                    lines.Add(new PointF(barBounds.X + xOffset, barBounds.Y - yOffset));
                    lines.Add(new PointF(barBounds.Right + xOffset, barBounds.Y - yOffset));
                    lines.Add(new PointF(barBounds.Right, barBounds.Y));
                    path.AddLines(lines.ToArray());
                    path.CloseFigure();

                    using (Pen pen = new Pen(this.Element.BorderColor), pen2 = new Pen(Color.FromArgb(100, Color.White)))
                    {
                        graphics.DrawPath(pen, path);
                        graphics.DrawPath(pen2, path);
                    }

                    using (Brush brush = new SolidBrush(this.Element.BackColor), brush2 = new SolidBrush(Color.FromArgb(100, Color.White)))
                    {
                        graphics.FillPath(brush, path);
                        graphics.FillPath(brush2, path);
                    }

                    using (StringFormat sf = new StringFormat(StringFormat.GenericTypographic))
                    {
                        object category = ((CategoricalDataPoint)dataPoint).Category;
                        string text = customRenderer.Summaries[category].ToString();
                        SizeF textSize = graphics.MeasureString(text, this.summaryFont);

                        RectangleF rect = ChartRenderer.ToRectangleF(slot);
                        rect.Offset(this.Element.View.Margin.Right + (rect.Width - textSize.Width) / 2, this.Element.View.Margin.Top + textSize.Height - 10);
                        radGraphics.DrawString(text, rect, this.summaryFont, Color.Black, sf, System.Windows.Forms.Orientation.Horizontal, false);
                    }
                }
            }
        }

        private RectangleF AdjustBarDataPointBounds(DataPointElement point, RectangleF bounds)
        {
            RectangleF barBounds = bounds;

            if (point.BorderBoxStyle == BorderBoxStyle.SingleBorder || point.BorderBoxStyle == BorderBoxStyle.OuterInnerBorders)
            {
                barBounds.X += point.BorderWidth - (int)((point.BorderWidth - 1f) / 2f);
                barBounds.Width -= point.BorderWidth;
                barBounds.Y += point.BorderWidth - (int)((point.BorderWidth - 1f) / 2f);
                barBounds.Height -= point.BorderWidth;
            }
            else if (point.BorderBoxStyle == BorderBoxStyle.FourBorders)
            {
                barBounds.Y += 1;
                barBounds.Height -= 1;
                barBounds.X += 1;
                barBounds.Width -= 1;
            }

            if (((CartesianRenderer)this.Renderer).Area.Orientation == System.Windows.Forms.Orientation.Horizontal)
            {
                barBounds.X--;
            }

            return barBounds;
        }
    }
}

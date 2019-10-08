using System;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace PanAndZoomExample
{
    public class ImageElement : LightVisualElement
    {
        private SizeF localOffset;
        private Point mouseDownLocation;
        private SizeF offset;
        private bool flag = false;
        private float zoom = 20f;

        protected override void InitializeFields()
        {
            base.InitializeFields();

            this.ImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }

        public SizeF Offset
        {
            get
            {
                return offset;
            }
            set
            {
                offset = value;
            }
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);

            this.ElementTree.Control.Cursor = Cursors.Hand;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);

            this.ElementTree.Control.Cursor = Cursors.Default;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            this.localOffset = this.Offset;
            this.mouseDownLocation = e.Location;
            this.Capture = true;
            this.flag = true;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (e.Button == MouseButtons.Left && this.flag)
            {
                float width = this.localOffset.Width + e.Location.X - this.mouseDownLocation.X;
                float height = this.localOffset.Height + e.Location.Y - this.mouseDownLocation.Y;

                if (width > 0)
                {
                    width = 0;
                }

                if (height > 0)
                {
                    height = 0;
                }

                if (width < this.Parent.Size.Width - this.Size.Width)
                {
                    width = this.Parent.Size.Width - this.Size.Width;
                }

                if (height < this.Parent.Size.Height - this.Size.Height)
                {
                    height = this.Parent.Size.Height - this.Size.Height;
                }

                this.Offset = new SizeF(width, height);
                this.Parent.InvalidateArrange();
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            this.flag = false;
            this.Capture = false;
        }

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            base.OnMouseWheel(e);

            if (Control.ModifierKeys == Keys.Control)
            {
                zoom += (e.Delta / 120);

                if (zoom < 1f)
                {
                    zoom = 1f;
                }

                if (zoom > 40f)
                {
                    zoom = 40f;
                }

                this.Parent.InvalidateMeasure(true);
                this.Parent.UpdateLayout();

                if (this.Size.Width > this.Parent.Size.Width)
                {
                    if (this.Offset.Width + this.Size.Width < this.Parent.Size.Width)
                    {
                        this.Offset = new SizeF(this.Offset.Width + (this.Parent.ControlBoundingRectangle.Right -
                             this.ControlBoundingRectangle.Right), this.Offset.Height);
                    }
                }

                if (this.Size.Height > this.Parent.Size.Height)
                {
                    if (this.Offset.Height + this.Size.Height < this.Parent.Size.Height)
                    {
                        this.Offset = new SizeF(this.Offset.Width, this.Offset.Height +
                             this.Parent.ControlBoundingRectangle.Bottom - this.ControlBoundingRectangle.Bottom);
                    }
                }

                this.Parent.InvalidateArrange(true);
            }
        }

        protected override SizeF MeasureOverride(SizeF availableSize)
        {
            if (Image != null)
                return new SizeF(this.Image.Width * zoom / 20f, this.Image.Height * zoom / 20f);

            return new SizeF(this.Parent.Size.Width, this.Parent.Size.Height);
        }
    }
}
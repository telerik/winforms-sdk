using System.Drawing;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace PanAndZoomExample
{
    public class PanImageElement : LightVisualElement
    {
        private ImageElement imageElement;

        protected override void InitializeFields()
        {
            base.InitializeFields();

            this.DrawBorder = true;
            this.BorderColor = Color.LightBlue;
            this.BorderGradientStyle = GradientStyles.Solid;
            this.ClipDrawing = true;
        }

        protected override void CreateChildElements()
        {
            base.CreateChildElements();

            this.imageElement = new ImageElement();
            this.Children.Add(this.imageElement);
        }

        public ImageElement ImageElement
        {
            get
            {
                return imageElement;
            }
        }

        protected override SizeF MeasureOverride(SizeF availableSize)
        {
            SizeF finalSize = base.MeasureOverride(availableSize);

            this.ImageElement.Measure(new SizeF(float.PositiveInfinity, float.PositiveInfinity));

            return finalSize;
        }

        protected override SizeF ArrangeOverride(SizeF finalSize)
        {
            RectangleF clientRect = this.GetClientRectangle(finalSize);
            
            RectangleF imageRect = new RectangleF(
                clientRect.X + this.ImageElement.Offset.Width,
                clientRect.Y + this.imageElement.Offset.Height,
                this.ImageElement.DesiredSize.Width,
                this.ImageElement.DesiredSize.Height);

            if (imageRect.Width < clientRect.Width)
            {
                imageRect.X = clientRect.X;
                this.ImageElement.Offset = new SizeF(0, this.ImageElement.Offset.Height);
            }

            if (imageRect.Height < clientRect.Height)
            {
                imageRect.Y = clientRect.Y;
                this.ImageElement.Offset = new SizeF(this.ImageElement.Offset.Width, 0);
            }

            this.ImageElement.Arrange(imageRect);

            return clientRect.Size;
        }
    }
}
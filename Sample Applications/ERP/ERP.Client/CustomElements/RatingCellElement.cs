using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace ERP.Client
{
    class RatingCellElement : VirtualGridCellElement
    {
        private RadRatingElement ratingElement;

        protected override void CreateChildElements()
        {
            base.CreateChildElements();
            this.ratingElement = new RadRatingElement();
            ratingElement.StretchHorizontally = true;
            ratingElement.StretchVertically = true;
            ratingElement.ShouldHandleMouseInput = false;
            ratingElement.ReadOnly = true;
            ratingElement.Minimum = 0;
            ratingElement.Maximum = 5;
            
            this.ratingElement.CaptionElement.Visibility = ElementVisibility.Collapsed;
            this.ratingElement.DescriptionElement.Visibility = ElementVisibility.Collapsed;
            this.ratingElement.SubCaptionElement.Visibility = ElementVisibility.Collapsed;

            for (int i = 0; i < 5; i++)
            {
                RatingStarVisualElement star = new RatingStarVisualElement();
                star.MinSize = new System.Drawing.Size(10, 10);
                this.ratingElement.Items.Add(star);
            }
            this.ratingElement.IsInRadGridView = true;
            this.Children.Add(ratingElement);
        }
        protected override void UpdateInfo(VirtualGridCellValueNeededEventArgs args)
        {
            base.UpdateInfo(args);
            this.Text = String.Empty;
            if (args.Value is byte)
            {
                this.ratingElement.Value = (byte)args.Value;
            }
        }
        public override bool IsCompatible(int data, object context)
        {
            VirtualGridRowElement rowElement = context as VirtualGridRowElement;

            return data == 2 && rowElement.RowIndex >= 0;
        }
        protected override Type ThemeEffectiveType
        {
            get
            {
                return typeof(VirtualGridCellElement);
            }
        }
        protected override SizeF ArrangeOverride(SizeF finalSize)
        {
            SizeF size = base.ArrangeOverride(finalSize);
            this.ratingElement.Arrange(new RectangleF(new Point(0, 0), size));
            return size;
        }
        protected override void DisposeManagedResources()
        {
            base.DisposeManagedResources();
            ratingElement = null;
        }
        public override bool CanEdit
        {
            get
            {
                return false;
            }
        }
    }
}

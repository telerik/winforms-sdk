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
    internal class RatingCellElement : VirtualGridCellElement
    {
        private RadRatingElement ratingElement;

        protected override void CreateChildElements()
        {
            base.CreateChildElements();
            this.ratingElement = new RadRatingElement();
            this.ratingElement.StretchHorizontally = true;
            this.ratingElement.StretchVertically = true;
            this.ratingElement.ShouldHandleMouseInput = false;
            this.ratingElement.ReadOnly = true;
            this.ratingElement.Minimum = 0;
            this.ratingElement.Maximum = 5;
            
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
            this.Children.Add(this.ratingElement);
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
            this.ratingElement = null;
        }
        public override bool CanEdit
        {
            get
            {
                return false;
            }
        }
    }

    public class DefaultVirtualGridCellElement : VirtualGridCellElement
    {
        public int ExcludeColumnIndex { get; set; } 
        public override bool IsCompatible(int data, object context)
        {
            VirtualGridRowElement rowElement = context as VirtualGridRowElement;

            return data != this.ExcludeColumnIndex && rowElement.RowIndex >= 0;
        }
        protected override Type ThemeEffectiveType
        {
            get
            {
                return typeof(VirtualGridCellElement);
            }
        }
    }
}

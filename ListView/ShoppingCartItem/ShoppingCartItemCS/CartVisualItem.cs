using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace _1165384
{
    public class CartVisualItem : SimpleListViewVisualItem
    {
        private RadButtonElement buttonElement1;
        private RadButtonElement buttonElement2;
        private LightVisualElement titleElement;
        private LightVisualElement descriptionElement;
        private LightVisualElement priceElement;
        private RadLabelElement amountElement;
        private StackLayoutElement stackLayout;
        private StackLayoutElement stackLayout2;
        private StackLayoutElement stackLayout3;

        protected override void CreateChildElements()
        {
            base.CreateChildElements();
            //left part
            this.stackLayout = new StackLayoutElement();
            this.stackLayout.Orientation = Orientation.Vertical;
            this.stackLayout.ShouldHandleMouseInput = false;
            this.stackLayout.NotifyParentOnMouseInput = true;
            this.stackLayout.StretchHorizontally = true;

            this.titleElement = new LightVisualElement();
            this.titleElement.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            this.titleElement.TextAlignment = ContentAlignment.MiddleLeft;
            this.titleElement.StretchHorizontally = true;
            this.titleElement.ShouldHandleMouseInput = false;
            this.titleElement.NotifyParentOnMouseInput = true;

            this.priceElement = new LightVisualElement();
            this.priceElement.StretchHorizontally = true;
            this.priceElement.TextAlignment = ContentAlignment.MiddleLeft;
            this.priceElement.ShouldHandleMouseInput = false;
            this.priceElement.NotifyParentOnMouseInput = true;

            this.descriptionElement = new LightVisualElement();
            this.descriptionElement.StretchHorizontally = true;
            this.descriptionElement.Font = new Font("Segoe UI", 7, FontStyle.Regular);
            this.descriptionElement.TextAlignment = ContentAlignment.MiddleLeft;
            this.descriptionElement.ShouldHandleMouseInput = false;
            this.descriptionElement.NotifyParentOnMouseInput = true;

            this.stackLayout.Children.Add(this.titleElement);
            this.stackLayout.Children.Add(this.priceElement);
            this.stackLayout.Children.Add(this.descriptionElement);

            //right part

            this.stackLayout2 = new StackLayoutElement();
            this.stackLayout2.Orientation = Orientation.Horizontal;
            this.stackLayout2.ShouldHandleMouseInput = false;
            this.stackLayout2.NotifyParentOnMouseInput = true;
            this.stackLayout2.StretchHorizontally = true;
            this.stackLayout2.StretchVertically = true;

            this.buttonElement1 = new RadButtonElement();
            this.buttonElement1.Text = "-";
            this.buttonElement1.Margin = new Padding(15);
            this.buttonElement1.Click += ButtonElement1_Click;
            this.stackLayout2.Children.Add(this.buttonElement1);

            this.amountElement = new RadLabelElement();
            this.amountElement.Margin = new Padding(15);

            this.amountElement.TextAlignment = ContentAlignment.MiddleCenter;
            this.stackLayout2.Children.Add(amountElement);

            this.buttonElement2 = new RadButtonElement();
            this.buttonElement2.Margin = new Padding(15);
            this.buttonElement2.Text = "+";
            this.buttonElement2.Click += ButtonElement2_Click;
            this.stackLayout2.Children.Add(this.buttonElement2);

            //combine
            this.stackLayout3 = new StackLayoutElement();
            this.stackLayout3.Orientation = Orientation.Horizontal;
            this.stackLayout3.ShouldHandleMouseInput = false;
            this.stackLayout3.NotifyParentOnMouseInput = true;
            this.stackLayout3.StretchHorizontally = true;

            this.stackLayout3.Children.Add(stackLayout);
            this.stackLayout3.Children.Add(stackLayout2);
            this.Children.Add(this.stackLayout3);
        }

        private void ButtonElement2_Click(object sender, EventArgs e)
        {
            var data = this.Data.DataBoundItem as OrderItem;
            data.Amount++;

        }

        private void ButtonElement1_Click(object sender, EventArgs e)
        {
            var data = this.Data.DataBoundItem as OrderItem;
            data.Amount--;

        }

        protected override void SynchronizeProperties()
        {
            base.SynchronizeProperties();

            this.Text = "";
            var data = this.Data.DataBoundItem as OrderItem;
            this.titleElement.Text = data.Name;
            this.amountElement.Text = data.Amount.ToString();
            this.priceElement.Text = data.Price.ToString("C");
            this.descriptionElement.Text = data.QuantityPerUnit;
        }

        protected override Type ThemeEffectiveType
        {
            get
            {
                return typeof(SimpleListViewVisualItem);
            }
        }
    }
}

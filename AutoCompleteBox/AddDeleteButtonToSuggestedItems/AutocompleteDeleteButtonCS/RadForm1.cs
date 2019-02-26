using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.RadControlSpy;
using Telerik.WinControls.UI;

namespace _1389443
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {


        public RadForm1()
        {
            InitializeComponent();
            radAutoCompleteBox1.TextBoxElement.ListElement.CreatingVisualItem += ListElement_CreatingVisualItem;
            new RadControlSpyForm().Show();

            for (int i = 0; i < 10; i++)
            {
                radAutoCompleteBox1.AutoCompleteItems.Add("Item" + i);
            }
            radAutoCompleteBox1.TextBoxElement.AutoCompleteDropDown.PopupClosing += AutoCompleteDropDown_PopupClosing;
            radAutoCompleteBox1.ListElement.ItemHeight = 30;
        }

        private void AutoCompleteDropDown_PopupClosing(object sender, RadPopupClosingEventArgs args)
        {
            if (args.CloseReason == RadPopupCloseReason.Mouse)
            {
                var popup = sender as RadTextBoxAutoCompleteDropDown;
                Point mousePosition = popup.PointToClient(Control.MousePosition);
                var item = radAutoCompleteBox1.ListElement.GetVisualItemAtPoint(mousePosition) as CustomVisualItem;
                if (item != null)
                {
                    if (item.RemoveButton.BoundingRectangle.Contains(mousePosition))
                    {
                        args.Cancel = true;
                    }
                }
                 
            }
        }

        private void ListElement_CreatingVisualItem(object sender, CreatingVisualListItemEventArgs args)
        {
            args.VisualItem = new CustomVisualItem();
        }
    }

    public class CustomVisualItem : RadListVisualItem
    {

        LightVisualElement removeButton;

        protected override Type ThemeEffectiveType
        {
            get
            {
                return typeof(RadListVisualItem);
            }
        }

        public LightVisualElement RemoveButton
        {
            get
            {
                return this.removeButton;
            }
        }

        protected override void CreateChildElements()
        {
            base.CreateChildElements();
            removeButton = new LightVisualElement();
            removeButton.DrawImage = true;
            removeButton.Image = Image.FromFile(@"..\..\delete.png").GetThumbnailImage(25, 25, null, IntPtr.Zero);
            removeButton.Click += RemoveButton_Click;
            removeButton.ImageAlignment = ContentAlignment.MiddleRight;
            removeButton.NotifyParentOnMouseInput = false;
            removeButton.ShouldHandleMouseInput = true;
            removeButton.StretchHorizontally = false;

            this.Children.Add(removeButton);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            var list = this.FindAncestor<RadListElement>();
            list.Items.Remove(this.Data);
        }
        protected override SizeF ArrangeOverride(SizeF finalSize)
        {
            var result = base.ArrangeOverride(finalSize);
            var rectangle = new RectangleF(finalSize.Width - removeButton.DesiredSize.Width, 0, removeButton.DesiredSize.Width, removeButton.DesiredSize.Height);
            removeButton.Arrange(rectangle);
            return result;
        }
    }
}

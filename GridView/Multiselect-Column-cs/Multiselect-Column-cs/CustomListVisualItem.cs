using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.WinControls.UI;
using System.Windows.Forms;
using System.Drawing;
using Telerik.WinControls.Enumerations;

namespace _547099
{
    public class CustomListVisualItem : RadListVisualItem
    {
        RadCheckBoxElement checkbox;
        LightVisualElement content;

        protected override void CreateChildElements()
        {
            base.CreateChildElements();

            StackLayoutElement stack = new StackLayoutElement();
            stack.Orientation = Orientation.Horizontal;
            this.Children.Add(stack);

            checkbox = new RadCheckBoxElement();
            checkbox.ToggleStateChanged += new StateChangedEventHandler(checkbox_ToggleStateChanged);
            stack.Children.Add(checkbox);

            content = new LightVisualElement();
            content.StretchHorizontally = false;
            content.StretchVertically = true;
            content.TextAlignment = ContentAlignment.MiddleLeft;
            content.NotifyParentOnMouseInput = true;
            stack.Children.Add(content);
        }

        void checkbox_ToggleStateChanged(object sender, StateChangedEventArgs e)
        {
            ((CustomListDataItem)this.Data).Checked = this.checkbox.Checked;
        }

        protected override Type ThemeEffectiveType
        {
            get
            {
                return typeof(RadListVisualItem);
            }
        }

        protected override void SynchronizeProperties()
        {
            base.SynchronizeProperties();
            checkbox.IsChecked = this.Data.Selected;
            this.content.Text = this.Data.Text;
            this.Text = "";
        }
    }
}

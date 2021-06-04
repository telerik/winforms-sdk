using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.WinControls.UI;

namespace DisabledEditors
{
    public class MyRadDateTimePicker : RadDateTimePicker
    {
        public override string ThemeClassName
        {
            get
            {
                return typeof(RadDateTimePicker).FullName;
            }
        }

        MyTextBox mtb = new MyTextBox();
        RadTextBoxItem tbi;

        protected override void CreateChildItems(Telerik.WinControls.RadElement parent)
        {
            base.CreateChildItems(parent);

            tbi = new RadTextBoxItem(mtb);
            mtb.Font = this.Font;
            this.DateTimePickerElement.TextBoxElement.Children.Add(tbi);
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            if (!this.Enabled)
            {
                tbi.Text = this.DateTimePickerElement.TextBoxElement.TextBoxItem.Text;
                this.DateTimePickerElement.TextBoxElement.TextBoxItem.Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            }
            else
            {
                this.DateTimePickerElement.TextBoxElement.TextBoxItem.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            }

            base.OnEnabledChanged(e);
        }
    }
}

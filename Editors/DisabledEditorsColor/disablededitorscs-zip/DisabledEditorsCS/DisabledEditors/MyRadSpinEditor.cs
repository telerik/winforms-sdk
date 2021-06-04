using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.WinControls.UI;

namespace DisabledEditors
{
    public class MyRadSpinEditor : RadSpinEditor
    {
        RadTextBoxItem realTB;

        public override string ThemeClassName
        {
            get
            {
                return typeof(RadSpinEditor).FullName;
            }
        }

        MyTextBox mtb = new MyTextBox();
        RadTextBoxItem tbi;

        protected override void CreateChildItems(Telerik.WinControls.RadElement parent)
        {
            base.CreateChildItems(parent);

            realTB = this.SpinElement.TextBoxItem;
            tbi = new RadTextBoxItem(mtb);
            mtb.Font = this.Font;
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            if (!this.Enabled)
            {
                tbi.Text = this.Text;
                this.SpinElement.Children[2].Children.Remove(realTB);
                this.SpinElement.Children[2].Children.Add(tbi);
            }
            else
            {
                this.SpinElement.Children[2].Children.Add(realTB);
                this.SpinElement.Children[2].Children.Remove(tbi);
            }

            base.OnEnabledChanged(e);
        }
    }
}

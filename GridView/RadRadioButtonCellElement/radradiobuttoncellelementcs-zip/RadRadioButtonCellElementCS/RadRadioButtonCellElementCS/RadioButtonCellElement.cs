using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using System.Drawing;
using Telerik.WinControls.Primitives;

namespace RadRadioButtonCellElementCS
{
    public class RadioButtonCellElement : GridDataCellElement
    {
        private RadRadioButtonElement radioButtonElement1;
        private RadRadioButtonElement radioButtonElement2;
        private RadRadioButtonElement radioButtonElement3;

        public RadioButtonCellElement(GridViewColumn column, GridRowElement row)
            : base(column, row)
        {
        }

        protected override Type ThemeEffectiveType
        {
            get
            {
                return typeof(GridDataCellElement);
            }
        }

        public override void Initialize(GridViewColumn column, GridRowElement row)
        {
            base.Initialize(column, row);

            ((RadioPrimitive)radioButtonElement1.Children[1].Children[1].Children[0]).BackColor2 = Color.Red;
            ((RadioPrimitive)radioButtonElement2.Children[1].Children[1].Children[0]).BackColor2 = Color.Blue;
            ((RadioPrimitive)radioButtonElement3.Children[1].Children[1].Children[0]).BackColor2 = Color.Green;
        }

        protected override void CreateChildElements()
        {
            base.CreateChildElements();

            radioButtonElement1 = new RadRadioButtonElement();
            radioButtonElement1.Margin = new Padding(0, 2, 0, 0);
            radioButtonElement1.MinSize = new Size(50, 20);
            radioButtonElement1.Text = "Red";

            radioButtonElement2 = new RadRadioButtonElement();
            radioButtonElement2.Margin = new Padding(0, 2, 0, 0);
            radioButtonElement2.MinSize = new Size(50, 20);
            radioButtonElement2.Text = "Blue";

            radioButtonElement3 = new RadRadioButtonElement();
            radioButtonElement3.Margin = new Padding(0, 2, 0, 0);
            radioButtonElement3.MinSize = new Size(50, 20);
            radioButtonElement3.Text = "Green";

            this.Children.Add(radioButtonElement1);
            this.Children.Add(radioButtonElement2);
            this.Children.Add(radioButtonElement3);

            radioButtonElement1.MouseDown += new MouseEventHandler(radioButtonElement1_MouseDown);
            radioButtonElement2.MouseDown += new MouseEventHandler(radioButtonElement2_MouseDown);
            radioButtonElement3.MouseDown += new MouseEventHandler(radioButtonElement3_MouseDown);
        }

        protected override void DisposeManagedResources()
        {
            radioButtonElement1.MouseDown -= new MouseEventHandler(radioButtonElement1_MouseDown);
            radioButtonElement2.MouseDown -= new MouseEventHandler(radioButtonElement2_MouseDown);
            radioButtonElement3.MouseDown -= new MouseEventHandler(radioButtonElement3_MouseDown);

            base.DisposeManagedResources();
        }

        protected override void SetContentCore(object value)
        {
            if (this.Value != null && this.Value != DBNull.Value)
            {
                for (int i = 0; i < this.Children.Count; i++)
                {
                    ((RadRadioButtonElement)this.Children[i]).ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off;
                }

                switch (int.Parse(((GridDataCellElement)this).Value.ToString()))
                {
                    case 0:
                        ((RadRadioButtonElement)this.Children[0]).ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
                        break;
                    case 1:
                        ((RadRadioButtonElement)this.Children[1]).ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
                        break;
                    case 2:
                        ((RadRadioButtonElement)this.Children[2]).ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
                        break;
                }
            }
        }

        protected override SizeF ArrangeOverride(SizeF finalSize)
        {
            if (this.Children.Count == 3)
            {
                this.Children[0].Arrange(new RectangleF(
                    0,
                    (finalSize.Height / 2) - (this.Children[0].DesiredSize.Height / 2),
                    this.Children[0].DesiredSize.Width,
                    this.Children[0].DesiredSize.Height));

                this.Children[1].Arrange(new RectangleF(
                    this.Children[0].Size.Width,
                    (finalSize.Height / 2) - (this.Children[1].DesiredSize.Height / 2),
                    this.Children[1].DesiredSize.Width,
                    this.Children[1].DesiredSize.Height));

                this.Children[2].Arrange(new RectangleF(
                    this.Children[0].DesiredSize.Width + this.Children[1].DesiredSize.Width,
                    (finalSize.Height / 2) - (this.Children[2].DesiredSize.Height / 2),
                    this.Children[2].DesiredSize.Width,
                    this.Children[2].DesiredSize.Height));
            }

            return finalSize;
        }

        public override bool IsCompatible(GridViewColumn data, object context)
        {
            return data is RadioButtonColumn && context is GridDataRowElement;
        }

        private void radioButtonElement1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            this.Value = 0;
        }

        private void radioButtonElement2_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            this.Value = 1;
        }

        private void radioButtonElement3_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            this.Value = 2;
        }
    }
}

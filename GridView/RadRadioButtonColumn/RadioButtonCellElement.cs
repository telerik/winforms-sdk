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

        protected override void CreateChildElements()
        {
            base.CreateChildElements();

            radioButtonElement1 = new RadRadioButtonElement();
            radioButtonElement1.Margin = new Padding(0, 2, 0, 0);
            radioButtonElement1.MinSize = new Size(50, 20);
            radioButtonElement1.StretchHorizontally = true;

            this.Children.Add(radioButtonElement1);

            radioButtonElement1.MouseDown += new MouseEventHandler(radioButtonElement1_MouseDown);
        }

        protected override void DisposeManagedResources()
        {
            radioButtonElement1.MouseDown -= new MouseEventHandler(radioButtonElement1_MouseDown);

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
                        ((RadRadioButtonElement)this.Children[0]).ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off;
                        break;
                    case 1:
                        ((RadRadioButtonElement)this.Children[0]).ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
                        break;
                }
            }
        }

        public override bool IsCompatible(GridViewColumn data, object context)
        {
            return data is RadioButtonColumn && context is GridDataRowElement;
        }

        private void radioButtonElement1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            this.Value = 1;
            ((RadioButtonColumn)this.ColumnInfo).OnRadioButtonToggleStateChanged(new RadioButtonEventArgs(this.RowIndex));
        }
    }
}

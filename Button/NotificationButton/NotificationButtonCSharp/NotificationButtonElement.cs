using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace NotificationButtonCSharp
{
    public class NotificationButtonElement : RadItem
    {
        RadButtonElement buttonElement;

        public event EventHandler Click;

        int result;
        LightVisualElement lve;
        int sizeConst = 20;

        protected override void CreateChildElements()
        {
            base.CreateChildElements();

            buttonElement = new RadButtonElement();
            buttonElement.Class = "RibbonBarButtonElement";
            buttonElement.ButtonFillElement.Class = "ButtonInRibbonFill";
            buttonElement.BorderElement.Class = "ButtonInRibbonBorder";
            buttonElement.Margin = new System.Windows.Forms.Padding(0, 10, 10, 0);
            buttonElement.Click += new EventHandler(buttonElement_Click);
            this.Children.Add(buttonElement);

            lve = new LightVisualElement();
            lve.BackColor = Color.Red;
            lve.DrawFill = true;
            lve.StretchHorizontally = false;
            lve.StretchVertically = false;
            lve.GradientStyle = Telerik.WinControls.GradientStyles.Solid;
            lve.Shape = new RoundRectShape(sizeConst / 2);
            lve.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            lve.ForeColor = Color.White;
            lve.MinSize = new Size(sizeConst, sizeConst);
            lve.Visibility = ElementVisibility.Collapsed;
            this.Children.Add(lve);
        }

        protected override void OnPropertyChanged(RadPropertyChangedEventArgs e)
        {
            base.OnPropertyChanged(e);

            if (e.Property.Name == "Bounds")
            {
                lve.Margin = new System.Windows.Forms.Padding(this.Bounds.Width - sizeConst - 1, 0, 0, 0);
            }
        }

        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                base.Text = value;
                this.ButtonElement.Text = value;
            }
        }

        void buttonElement_Click(object sender, EventArgs e)
        {
            if (Click != null)
                Click(this.ButtonElement, e);
        }

        public RadButtonElement ButtonElement
        {
            get
            {
                return this.buttonElement;
            }
        }

        [DefaultValue(0)]
        public int NotificationCount
        {
            get
            {
                if (lve.Text != null)
                {
                    bool isInt = int.TryParse(lve.Text, out result);
                    if (isInt)
                    {
                        return result;
                    }
                }

                return 0;
            }
            set
            {
                if (value > 0)
                {
                    lve.Visibility = ElementVisibility.Visible;
                }
                else
                {
                    lve.Visibility = ElementVisibility.Collapsed;
                }
                lve.Text = value.ToString();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace NotificationButtonCSharp
{
    public class NotificationButton : RadButton
    {
        int result;
        LightVisualElement lve;
        int sizeConst = 26;

        protected override void CreateChildItems(Telerik.WinControls.RadElement parent)
        {
            base.CreateChildItems(parent);

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
            this.RootElement.Children.Add(lve);

            // Pushing the ButtonElement off the top and right edges
            // so that the badge is not completely overlapped with the button
            this.ButtonElement.Margin = new System.Windows.Forms.Padding(0, 5, 5, 0);
        }

        protected override void InitLayout()
        {
            base.InitLayout();

            lve.Margin = new System.Windows.Forms.Padding(this.Size.Width - sizeConst - 1, 0, 0, 0);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            lve.Margin = new System.Windows.Forms.Padding(this.Size.Width - sizeConst - 1, 0, 0, 0);
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

        protected override Size DefaultSize
        {
            get
            {
                return new Size(150, 50);
            }
        }
    }
}
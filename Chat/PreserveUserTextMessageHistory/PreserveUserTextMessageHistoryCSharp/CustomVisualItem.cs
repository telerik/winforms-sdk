using System;
using System.Drawing;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace PreserveUserTextMessageHistory
{
    public class CustomVisualItem : RadListVisualItem
    {
        private LightVisualElement lve = null;
        FontFamily font1 = ThemeResolutionService.GetCustomFont(ThemeResolutionService.TelerikWebUIFontName);

        protected override void CreateChildElements()
        {
            base.CreateChildElements();
            this.lve = new LightVisualElement();
            this.lve.CustomFont = font1.Name;
            lve.Visibility = ElementVisibility.Hidden;
            lve.Text = TelerikWebUIFont.GlyphEmail;
            lve.TextAlignment = ContentAlignment.MiddleRight;
            this.Children.Add(lve);
        }

        public ElementVisibility MessageNotification
        {
            get { return lve.Visibility; }
            set { lve.Visibility = value; }
        }

        protected override Type ThemeEffectiveType
        {
            get
            {
                return typeof(RadListVisualItem);
            }
        }
    }
}

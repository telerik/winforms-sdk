using System.ComponentModel;
using Telerik.WinControls;

namespace PanAndZoomExample
{
    [ToolboxItem(true)]
    public class PanImageControl : RadControl
    {
        private PanImageElement panImageElement;

        protected override void CreateChildItems(RadElement parent)
        {
            base.CreateChildItems(parent);

            this.panImageElement = new PanImageElement();
            parent.Children.Add(this.panImageElement);            
        }

        public PanImageElement PanImageElement
        {
            get { return panImageElement; }
        }
    }
}

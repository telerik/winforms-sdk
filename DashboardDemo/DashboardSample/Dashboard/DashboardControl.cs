using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.WinControls;

namespace TicketTest
{
    public class DashboardControl: RadControl
    {
        DashboardElement element;

        public DashboardElement Element { get { return this.element; } }

        protected override void CreateChildItems(RadElement parent)
        {
            element = new DashboardElement();
            parent.Children.Add(element);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Docking;
using System.Diagnostics;
using Telerik.WinControls;
using Telerik.WinControls.Data;

namespace TicketTest
{
    public partial class Form1 : RadForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            DashboardControl control = new DashboardControl();
            control.Dock = DockStyle.Fill;
            Controls.Add(control);

            control.Element.Pending.Content.Children.Add(new TaskElement("Some hard task"));
            control.Element.Pending.Content.Children.Add(new TaskElement("Another task"));
            control.Element.Pending.Content.Children.Add(new TaskElement("Third task."));

            control.Element.InProgress.Content.Children.Add(new TaskElement("A running task.") { BackColor = Color.LightGreen });
        }
    }
}

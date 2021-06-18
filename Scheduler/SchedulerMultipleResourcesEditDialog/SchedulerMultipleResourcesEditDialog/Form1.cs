using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace SchedulerMultipleResourcesEditDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Color[] colors = new Color[]{Color.LightBlue, Color.LightGreen, Color.LightYellow,
                                         Color.Red, Color.Orange, Color.Pink, Color.Purple, Color.Peru, Color.PowderBlue};

            string[] names = new string[]{"Alan Smith", "Anne Dodsworth",
                                        "Boyan Mastoni", "Richard Duncan", "Maria Shnaider"};

            for (int i = 0; i < names.Length; i++)
            {
                Resource resource = new Resource();
                resource.Id = new EventId(i);
                resource.Name = names[i];
                resource.Color = colors[i];

                this.radScheduler1.Resources.Add(resource);
            }

            radScheduler1.GroupType = GroupType.Resource; 
        }

        private void radScheduler1_AppointmentEditDialogShowing(object sender, AppointmentEditDialogShowingEventArgs e)
        {
            e.AppointmentEditDialog = new MultipleResourcesDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace SchedulerMonthViewComparer
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        public RadForm1()
        {
            InitializeComponent();

            ThemeResolutionService.ApplicationThemeName = "TelerikMetro";

            this.radScheduler1.ActiveViewType = SchedulerViewType.Month;
           
            SchedulerMonthViewElement monthViewElement = this.radScheduler1.SchedulerElement.ViewElement as SchedulerMonthViewElement;
             monthViewElement.MonthViewAreaElement.AppointmentsComparer = new MyComparer();

            this.radScheduler1.Appointments.Add(new Appointment(DateTime.Today.AddHours(12),TimeSpan.FromHours(1),"A1"));
            this.radScheduler1.Appointments.Add(new Appointment(DateTime.Today.AddHours(8),TimeSpan.FromHours(1),"A2"));
            this.radScheduler1.Appointments.Add(new Appointment(DateTime.Today.AddHours(10),TimeSpan.FromHours(1),"A3"));  
        }

        public class MyComparer : IComparer<AppointmentElement> 
        {
            public int Compare(AppointmentElement x, AppointmentElement y)
            {
                return x.Appointment.Summary.CompareTo(y.Appointment.Summary);
            }
        }
    }
}
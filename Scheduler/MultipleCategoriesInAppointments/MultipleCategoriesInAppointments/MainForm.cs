using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace MultipleCategoriesInAppointments
{
    public partial class MainForm : Telerik.WinControls.UI.RadForm
    {
        public MainForm()
        {
            InitializeComponent();

            this.radScheduler1.ElementProvider = new MyElementProvider(this.radScheduler1);
            this.radScheduler1.AppointmentFactory = new CustomAppointmentFactory();
            this.radScheduler1.AppointmentEditDialogShowing += RadScheduler1_AppointmentEditDialogShowing;

            AppointmentWithCategories a = new AppointmentWithCategories() { Summary = "Telerik UI for WinForms", Start = DateTime.Now, Duration = TimeSpan.FromHours(2) };
            a.CategoryIds.Add(3);
            a.CategoryIds.Add(6);
            this.radScheduler1.Appointments.Add(a);
        }

        private void RadScheduler1_AppointmentEditDialogShowing(object sender, AppointmentEditDialogShowingEventArgs e)
        {
            if (this.appointmentDialog == null)
            {
                this.appointmentDialog = new CustomAppointmentEditForm();
            }
            e.AppointmentEditDialog = this.appointmentDialog;
        }

        CustomAppointmentEditForm appointmentDialog = null;
        public class MyElementProvider : SchedulerElementProvider
        {
            public MyElementProvider(RadScheduler scheduler)
                : base(scheduler)
            {
            }

            protected override T CreateElement<T>(SchedulerView view, object context)
            {
                if (typeof(T) == typeof(AppointmentElement))
                {
                    return new CustomAppointmentElement(this.Scheduler, view, (IEvent)context) as T;
                }

                return base.CreateElement<T>(view, context);
            }
        }

        public class CustomAppointmentElement : AppointmentElement
        {
            public CustomAppointmentElement(RadScheduler scheduler, SchedulerView view, IEvent appointment)
                : base(scheduler, view, appointment)
            {

            }
            StackLayoutElement categoriesStack;
            protected override void CreateChildElements()
            {
                base.CreateChildElements();
                categoriesStack = new StackLayoutElement();
                categoriesStack.StretchHorizontally = false;
                categoriesStack.Alignment = ContentAlignment.BottomRight;
                categoriesStack.ShouldHandleMouseInput = false;
                categoriesStack.NotifyParentOnMouseInput = true;
                this.Children.Add(categoriesStack);
            }

            public override void Synchronize()
            {
                base.Synchronize();
                categoriesStack.Children.Clear();
                AppointmentWithCategories categorizedAppointment = this.Appointment as AppointmentWithCategories;
                foreach (int categoryId in categorizedAppointment.CategoryIds)
                {
                    LightVisualElement lve = new LightVisualElement();
                    lve.Alignment = ContentAlignment.MiddleRight;
                    lve.StretchHorizontally = false;
                    lve.ShouldHandleMouseInput = false;
                    lve.NotifyParentOnMouseInput = true;
                    lve.DrawFill = true;
                    lve.DrawBorder = true;
                    lve.BorderGradientStyle = GradientStyles.Solid;
                    lve.BorderColor = Color.Gray;
                    lve.MinSize = new Size(10, 20);
                    lve.GradientStyle = GradientStyles.Solid;
                    lve.BackColor = GetBackgroundById(categoryId);
                    categoriesStack.Children.Add(lve);
                }
            }

            public Color GetBackgroundById(int categoryId)
            { 
                foreach (AppointmentBackgroundInfo bc in this.Scheduler.Backgrounds)
                {

                    if (bc.Id == categoryId)
                    {
                        if (this.Scheduler.UseModernAppointmentStyles)
                        {
                            return bc.BackColor;
                        }
                        return bc.BackColor2;
                    }
                }
                return Color.Red;
            }
        }

        public class CustomAppointmentFactory : IAppointmentFactory
        {
            public IEvent CreateNewAppointment()
            {
                return new AppointmentWithCategories();
            }
        }
        public class AppointmentWithCategories : Appointment
        {
            public AppointmentWithCategories() : base()
            {
            }

            protected override Event CreateOccurrenceInstance()
            {
                return new AppointmentWithCategories();
            }

            private BindingList<int> categoryIds = new BindingList<int>();

            public BindingList<int> CategoryIds
            {
                get
                {
                    return this.categoryIds;
                }
                set
                {
                    if (this.categoryIds != value)
                    {
                        this.categoryIds = value;
                        this.OnPropertyChanged("CategoryIds");
                    }
                }
            }
        }
    }
}

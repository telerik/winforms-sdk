using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace RadGanttViewExample
{
    public partial class Form1 : Form
    {
        private Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();

            this.Text = "Truck system";

            DataTable table = new DataTable();

            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Title", typeof(string));
            table.Columns.Add("Start", typeof(DateTime));
            table.Columns.Add("End", typeof(DateTime));
            table.Columns.Add("DrivingToPickUpLocation", typeof(TimeSpan));
            table.Columns.Add("Loading", typeof(TimeSpan));
            table.Columns.Add("Driving", typeof(TimeSpan));
            table.Columns.Add("DriverRest", typeof(TimeSpan));
            table.Columns.Add("Waiting", typeof(TimeSpan));
            table.Columns.Add("Unloading", typeof(TimeSpan));

            int minValue = 20;
            int maxValue = 90;

            for (int i = 0; i < 10; i++)
            {
                DateTime start = DateTime.Now.AddHours(i);
                TimeSpan drivingToPickup = new TimeSpan(0, this.rnd.Next(minValue, maxValue), 0);
                TimeSpan loading = new TimeSpan(0, this.rnd.Next(minValue, maxValue), 0);
                TimeSpan driving = new TimeSpan(0, this.rnd.Next(minValue, maxValue), 0);
                TimeSpan rest = new TimeSpan(0, this.rnd.Next(minValue, maxValue), 0);
                TimeSpan waiting = new TimeSpan(0, this.rnd.Next(minValue, maxValue), 0);
                TimeSpan unloading = new TimeSpan(0, this.rnd.Next(minValue, maxValue), 0);
                DateTime end = start.Add(drivingToPickup + loading + driving + rest + waiting + unloading);

                table.Rows.Add(i, "Title " + i, start, end, drivingToPickup, loading, driving, rest, waiting, unloading);
            }

            this.radGanttView1.Columns.Add("Title");

            this.radGanttView1.ChildMember = "Id";
            this.radGanttView1.TitleMember = "Title";
            this.radGanttView1.StartMember = "Start";
            this.radGanttView1.EndMember = "End";
            this.radGanttView1.DataSource = table;

            this.radGanttView1.GanttViewElement.GraphicalViewElement.TimelineStart = DateTime.Now.AddHours(-1);
            this.radGanttView1.GanttViewElement.GraphicalViewElement.TimelineEnd = DateTime.Now.AddDays(2);
            this.radGanttView1.GanttViewElement.GraphicalViewElement.TimelineRange = TimeRange.Day;
            this.radGanttView1.GanttViewElement.GraphicalViewElement.OnePixelTime = new TimeSpan(0, 1, 0);
            this.radGanttView1.ItemHeight = 40;
            this.radGanttView1.Ratio = 0.10f;

            this.radGanttView1.ItemElementCreating += radGanttView1_ItemElementCreating;
            this.radGanttView1.ToolTipTextNeeded += radGanttView1_ToolTipTextNeeded; 
        }

        private void radGanttView1_ToolTipTextNeeded(object sender, Telerik.WinControls.ToolTipTextNeededEventArgs e)
        {
            Point mousePosition = this.radGanttView1.PointToClient(Control.MousePosition);
            RadElement elementUnderMouse = this.radGanttView1.ElementTree.GetElementAtPoint(mousePosition);

            if (elementUnderMouse == null)
            {
                return;
            }

            GanttGraphicalViewBaseItemElement itemElement = elementUnderMouse as GanttGraphicalViewBaseItemElement;

            if (itemElement == null)
            {
                itemElement = elementUnderMouse.FindAncestor<GanttGraphicalViewBaseItemElement>();
            }

            if (itemElement == null)
            {
                return;
            }

            if (elementUnderMouse is DrivingToPickUpLocationElement)
            {
                e.ToolTipText = string.Format("Driving to site: {0}", ((DataRowView)itemElement.Data.DataBoundItem)["DrivingToPickUpLocation"]);
            }
            else if (elementUnderMouse is LoadingElement)
            {
                e.ToolTipText = string.Format("Loading time: {0}", ((DataRowView)itemElement.Data.DataBoundItem)["Loading"]);
            }
            else if (elementUnderMouse is DrivingElement)
            {
                e.ToolTipText = string.Format("Driving: {0}", ((DataRowView)itemElement.Data.DataBoundItem)["Driving"]);
            }
            else if (elementUnderMouse is DriverRestElement)
            {
                e.ToolTipText = string.Format("Driver rest: {0}", ((DataRowView)itemElement.Data.DataBoundItem)["DriverRest"]);
            }
            else if (elementUnderMouse is WaitingElement)
            {
                e.ToolTipText = string.Format("Waiting: {0}", ((DataRowView)itemElement.Data.DataBoundItem)["Waiting"]);
            }
            else if (elementUnderMouse is UnloadingElement)
            {
                e.ToolTipText = string.Format("Unloading: {0}", ((DataRowView)itemElement.Data.DataBoundItem)["Unloading"]);
            }
        }

        private void radGanttView1_ItemElementCreating(object sender, GanttViewItemElementCreatingEventArgs e)
        {
            GanttViewGraphicalViewElement graphicalView = e.ViewElement as GanttViewGraphicalViewElement;

            if (graphicalView != null && e.Item.Items.Count == 0 && e.Item.Start != e.Item.End)
            {
                e.ItemElement = new CustomGanttViewTaskItemElement(graphicalView);
            }
        }
    }
}

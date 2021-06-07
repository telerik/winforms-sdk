using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace RadGanttViewIndicatingSpecialDays
{
    public partial class RadGanttViewForm : Form
    {
        public RadGanttViewForm()
        {
            InitializeComponent();

            this.Load += RadGanttViewForm_Load;
            this.customRadGanttView.GraphicalViewItemFormatting += radGanttView1_GraphicalViewItemFormatting;
            this.customRadGanttView.TimelineItemFormatting += radGanttView1_TimelineItemFormatting;

            ((CustomGanttViewGraphicalViewElement)this.customRadGanttView.GanttViewElement.GraphicalViewElement).SpecialDates.Add(new DateTime(2014, 12, 25));
            ((CustomGanttViewGraphicalViewElement)this.customRadGanttView.GanttViewElement.GraphicalViewElement).SpecialDates.Add(new DateTime(2014, 12, 26));
        }

        private void RadGanttViewForm_Load(object sender, EventArgs e)
        {
            this.customRadGanttView.EnableCustomPainting = true;
            this.customRadGanttView.GanttViewElement.GraphicalViewElement.TimelineStart = new DateTime(2014, 12, 15);
            this.customRadGanttView.GanttViewElement.GraphicalViewElement.TimelineEnd = new DateTime(2015, 1, 15);

            this.AddTasks();
        }

        private void radGanttView1_TimelineItemFormatting(object sender, GanttViewTimelineItemFormattingEventArgs e)
        {
            DateTime date;
            LightVisualElement element;
            for (int i = 0; i < e.ItemElement.Children[1].Children.Count; i++)
            {
                date = e.ItemElement.Data.Start.AddDays(i);
                element = e.ItemElement.Children[1].Children[i] as LightVisualElement;
                if (element != null)
                {
                    element.Text = date.Day + "\n" + date.DayOfWeek.ToString().Substring(0, 2);
                    element.Font = new Font("Arial", 7.5f);
                }
            }
        }

        private void radGanttView1_GraphicalViewItemFormatting(object sender, GanttViewGraphicalViewItemFormattingEventArgs e)
        {
            e.ItemElement.DrawFill = false;
        }

        private void AddTasks()
        {
            //Setup data items
            GanttViewDataItem item1 = new GanttViewDataItem();
            item1.Start = new DateTime(2014, 12, 15);
            item1.End = new DateTime(2014, 12, 20);
            item1.Progress = 30m;
            item1.Title = "Summary task.1. title";

            GanttViewDataItem subItem11 = new GanttViewDataItem();
            subItem11.Start = new DateTime(2014, 12, 16);
            subItem11.End = new DateTime(2014, 12, 18);
            subItem11.Progress = 10m;
            subItem11.Title = "Sub-task.1.1 title";

            GanttViewDataItem subItem12 = new GanttViewDataItem();
            subItem12.Start = new DateTime(2014, 12, 21);
            subItem12.End = new DateTime(2014, 12, 23);
            subItem12.Progress = 20m;
            subItem12.Title = "Sub-task.1.2 title";

            //Add subitems
            item1.Items.Add(subItem11);
            item1.Items.Add(subItem12);

            this.customRadGanttView.Items.Add(item1);

            GanttViewDataItem item2 = new GanttViewDataItem();
            item2.Start = new DateTime(2014, 12, 21);
            item2.End = new DateTime(2014, 12, 12);
            item2.Progress = 40m;
            item2.Title = "Summary task.2. title";

            GanttViewDataItem subitem21 = new GanttViewDataItem();
            subitem21.Start = new DateTime(2014, 12, 17);
            subitem21.End = new DateTime(2014, 12, 20);
            subitem21.Progress = 10m;
            subitem21.Title = "Sub-task.2.1 title";

            GanttViewDataItem subitem22 = new GanttViewDataItem();
            subitem22.Start = new DateTime(2014, 12, 21);
            subitem22.End = new DateTime(2014, 12, 23);
            subitem22.Progress = 30m;
            subitem22.Title = "Sub-task.2.2 title";

            GanttViewDataItem subitem23 = new GanttViewDataItem();
            subitem23.Start = new DateTime(2014, 12, 18);
            subitem23.End = new DateTime(2014, 12, 20);
            subitem23.Title = "Sub-task.2.3 title";

            //Add subitems
            item2.Items.Add(subitem21);
            item2.Items.Add(subitem22);
            item2.Items.Add(subitem23);

            this.customRadGanttView.Items.Add(item2);

            //Add links between items
            GanttViewLinkDataItem link1 = new GanttViewLinkDataItem();
            link1.StartItem = subItem11;
            link1.EndItem = subItem12;
            link1.LinkType = TasksLinkType.FinishToStart;
            this.customRadGanttView.Links.Add(link1);

            GanttViewLinkDataItem link2 = new GanttViewLinkDataItem();
            link2.StartItem = subitem21;
            link2.EndItem = subitem22;
            link2.LinkType = TasksLinkType.StartToStart;
            this.customRadGanttView.Links.Add(link2);

            GanttViewLinkDataItem link3 = new GanttViewLinkDataItem();
            link3.StartItem = subitem22;
            link3.EndItem = subitem23;
            link3.LinkType = TasksLinkType.FinishToStart;
            this.customRadGanttView.Links.Add(link3);

            GanttViewTextViewColumn titleColumn = new GanttViewTextViewColumn("Title");
            GanttViewTextViewColumn startColumn = new GanttViewTextViewColumn("Start");
            GanttViewTextViewColumn endColumn = new GanttViewTextViewColumn("End");

            this.customRadGanttView.GanttViewElement.Columns.Add(titleColumn);
            this.customRadGanttView.GanttViewElement.Columns.Add(startColumn);
            this.customRadGanttView.GanttViewElement.Columns.Add(endColumn);
        }
    }
}

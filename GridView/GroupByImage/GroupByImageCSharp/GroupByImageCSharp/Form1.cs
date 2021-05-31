using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls.Data;
using Telerik.WinControls;

namespace GroupByImageCSharp
{
    public partial class Form1 : Form
    {
        List<Image> images = new List<Image>()
        {
            Properties.Resources.open,
            Properties.Resources.paste,
            Properties.Resources.pdf
        };

        public Form1()
        {
            InitializeComponent();

            Random rand = new Random();
            List<MyObject> list = new List<MyObject>() { };
            for (int i = 0; i < 10; i++)
            {
                list.Add(new MyObject(rand.Next(0, 4), "Name " + i, images[rand.Next(0, images.Count)]));
            }

            radGridView1.DataSource = list;
            radGridView1.AutoSizeRows = true;
            radGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;

            //populate the grid with data
            RadDragDropService svc = this.radGridView1.GridViewElement.GetService<RadDragDropService>();
            svc.PreviewDragStart += svc_PreviewDragStart;
            svc.PreviewDragOver += svc_PreviewDragOver;

            radGridView1.GroupByChanged += radGridView1_GroupByChanged;
            radGridView1.EnableCustomGrouping = true;
            radGridView1.CustomGrouping += radGridView1_CustomGrouping;
            radGridView1.GroupSummaryEvaluate += radGridView1_GroupSummaryEvaluate;
        }

        private void svc_PreviewDragStart(object sender, PreviewDragStartEventArgs e)
        {
            SnapshotDragItem dragged = e.DragInstance as SnapshotDragItem;
            if (dragged != null && dragged.Item is GridHeaderCellElement)
            {
                e.CanStart = true;
            }
        }

        private void svc_PreviewDragOver(object sender, RadDragOverEventArgs e)
        {
            SnapshotDragItem dragged = e.DragInstance as SnapshotDragItem;
            if (dragged != null && dragged.Item is GridHeaderCellElement)
            {
                e.CanDrop = e.HitTarget is GroupPanelElement;
            }
        }

        private void radGridView1_GroupByChanged(object sender, GridViewCollectionChangedEventArgs e)
        {
            if (this.radGridView1.GridViewElement.GroupPanelElement.PanelContainer.Children != null &&
                this.radGridView1.GridViewElement.GroupPanelElement.PanelContainer.Children.Count > 0)
            {
                TemplateGroupsElement templateGroupsElement = radGridView1.GridViewElement.GroupPanelElement.PanelContainer.Children[0] as TemplateGroupsElement;
                if (templateGroupsElement != null)
                {
                    foreach (GroupElement groupElement in templateGroupsElement.GroupElements)
                    {
                        foreach (GroupFieldElement groupFieldsElement in groupElement.GroupingFieldElements)
                        {
                            if (groupFieldsElement.RemoveButton.Visibility != ElementVisibility.Visible)
                            {
                                groupFieldsElement.RemoveButton.Visibility = ElementVisibility.Visible;
                            }
                        }
                    }
                }
            }
        }

        private void radGridView1_CustomGrouping(object sender, GridViewCustomGroupingEventArgs e)
        {
            if (this.UseDefaultGrouping(e.Level))
            {
                e.Handled = false;
                return;
            }
            Image photo = e.Row.Cells["Photo"].Value as Image;
            int index = images.IndexOf(photo);

            switch (index)
            {
                case 0:
                    e.GroupKey = "open";

                    break;
                case 1:
                    e.GroupKey = "paste";
                    break;
                case 2:
                    e.GroupKey = "pdf";
                    break;
                default:
                    e.GroupKey = "Other image";
                    break;
            }
        }

        private bool UseDefaultGrouping(int level)
        {
            GroupDescriptor groupDescriptor = this.radGridView1.GroupDescriptors[level];
            for (int i = 0; i < groupDescriptor.GroupNames.Count; i++)
            {
                if (groupDescriptor.GroupNames[i].PropertyName.Equals("Photo", StringComparison.InvariantCultureIgnoreCase))
                {
                    return false;
                }
            }
            return true;
        }

        private void radGridView1_GroupSummaryEvaluate(object sender, GroupSummaryEvaluationEventArgs e)
        {
            if (this.UseDefaultGrouping(e.Group.Level))
            {
                return;
            }

            if (e.Value == null)
            {
                e.FormatString = "Photo \"" + e.Group.Key.ToString() + "\"";
            }
        }

        public class MyObject
        {
            public int ID { get; set; }

            public string Title { get; set; }

            public Image Photo { get; set; }

            public MyObject(int iD, string title, Image photo)
            {
                this.ID = iD;
                this.Title = title;
                this.Photo = photo;
            }
        }
    }
}
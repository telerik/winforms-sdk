using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.UI;

namespace ListViewCheckAllGroups
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        private RadCheckBoxElement checkBox;

        public RadForm1()
        {
            InitializeComponent();

            this.radListView1.VisualItemFormatting += radListView1_VisualItemFormatting;

            this.radListView1.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView;
            for (int i = 0; i < 3; i++)
            {
                this.radListView1.Columns.Add("Column " + i);
            }
            for (int i = 0; i < 40; i++)
            {
                CustomListViewGroupItem group = new CustomListViewGroupItem();
                group.Text = "Group " + i;
                this.radListView1.Groups.Add(group);

                for (int j = 0; j < 3; j++)
                {
                    ListViewDataItem item = new ListViewDataItem();
                    this.radListView1.Items.Add(item);
                    item[0] = i;
                    item[1] = j;
                    item[2] = "Item " + (10 * i + j);
                    item.Group = group;
                }
            }

            this.radListView1.EnableCustomGrouping = true;
            this.radListView1.ShowGroups = true;
            this.radListView1.ShowCheckBoxes = true;

            this.checkBox = new RadCheckBoxElement();
            this.checkBox.Margin = new Padding(0, 10, 0, 0);
            this.checkBox.ToggleStateChanged += new StateChangedEventHandler(checkBox_ToggleStateChanged);
            this.checkBox.ZIndex = 1000;
            this.checkBox.Alignment = ContentAlignment.TopLeft;
            this.checkBox.StretchHorizontally = this.checkBox.StretchVertically = false;
            this.checkBox.IsThreeState = true;
            this.radListView1.ListViewElement.Children.Add(this.checkBox);

            this.radListView1.ItemCheckedChanged += new ListViewItemEventHandler(radListView1_ItemCheckedChanged);
            this.radListView1.VisualItemCreating += new ListViewVisualItemCreatingEventHandler(radListView1_VisualItemCreating);

            this.radListView1.MouseUp += radListView1_MouseUp;
        }

        private void radListView1_MouseUp(object sender, MouseEventArgs e)
        {
            this.radListView1.ListViewElement.SynchronizeVisualItems();
        }

        private void radListView1_VisualItemFormatting(object sender, ListViewVisualItemEventArgs e)
        {
            DetailListViewVisualItem visualItem = e.VisualItem as DetailListViewVisualItem;
            if (visualItem != null)
            {
                e.VisualItem.Margin = new Padding(20, 0, 0, 0);
            }
            else
            {
                e.VisualItem.Margin = new Padding(0);
            }
        }

        private void checkBox_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (this.checkBox.ToggleState == ToggleState.Indeterminate)
            {
                this.checkBox.ToggleState = ToggleState.Off;
                return;
            }
            this.radListView1.BeginUpdate();
            this.radListView1.ItemCheckedChanged -= new ListViewItemEventHandler(radListView1_ItemCheckedChanged);

            foreach (ListViewDataItem item in this.radListView1.Items)
            {
                item.CheckState = this.checkBox.ToggleState;
            }
            this.radListView1.EndUpdate();
            this.radListView1.ItemCheckedChanged += new ListViewItemEventHandler(radListView1_ItemCheckedChanged);
        }

        private void radListView1_ItemCheckedChanged(object sender, ListViewItemEventArgs e)
        {
            this.checkBox.ToggleStateChanged -= new StateChangedEventHandler(checkBox_ToggleStateChanged);
            ToggleState checkState = ToggleState.Off;

            for (int i = 0; i < this.radListView1.Items.Count; i++)
            {
                if (i == 0)
                {
                    checkState = this.radListView1.Items[0].CheckState;
                }
                else if (this.radListView1.Items[i].CheckState != this.radListView1.Items[i - 1].CheckState)
                {
                    checkState = ToggleState.Indeterminate;
                    break;
                }
            }

            this.checkBox.ToggleState = checkState;

            this.checkBox.ToggleStateChanged += new StateChangedEventHandler(checkBox_ToggleStateChanged);

            this.radListView1.ListViewElement.SynchronizeVisualItems();
        }

        private void radListView1_ItemCreating(object sender, ListViewItemCreatingEventArgs e)
        {
            if (e.Item is ListViewDataItemGroup)
            {
                e.Item = new CustomListViewGroupItem();
            }
        }

        private void radListView1_VisualItemCreating(object sender, Telerik.WinControls.UI.ListViewVisualItemCreatingEventArgs e)
        {
            if (e.VisualItem is DetailListViewGroupVisualItem)
            {
                e.VisualItem = new CustomVisualGroupItem();
            }
        }

        private void RadForm1_Load(object sender, EventArgs e)
        {
        }

        public class CustomListViewGroupItem : ListViewDataItemGroup
        {
            public override ToggleState CheckState
            {
                get
                {
                    bool hasItems = false;
                    ToggleState previousState = ToggleState.Off;

                    foreach (ListViewDataItem item in this.Items)
                    {
                        if (!hasItems)
                        {
                            hasItems = true;
                        }
                        else
                        {
                            if (item.CheckState != previousState)
                            {
                                return ToggleState.Indeterminate;
                            }
                        }

                        previousState = item.CheckState;
                    }

                    return previousState;
                }
                set
                {
                    ToggleState stateToSet = value != ToggleState.On ? ToggleState.Off : ToggleState.On;

                    this.Owner.BeginUpdate();
                    foreach (ListViewDataItem item in this.Items)
                    {
                        item.CheckState = stateToSet;
                    }
                    this.Owner.EndUpdate();
                }
            }
        }

        public class CustomVisualGroupItem : DetailListViewGroupVisualItem
        {
            private RadCheckBoxElement checkBox;

            public override bool IsCompatible(ListViewDataItem data, object context)
            {
                return data is CustomListViewGroupItem;
            }

            protected override void CreateChildElements()
            {
                base.CreateChildElements();

                this.checkBox = new RadCheckBoxElement();
                checkBox.StretchHorizontally = false;
                this.checkBox.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
                this.checkBox.ToggleStateChanged += new StateChangedEventHandler(checkBox_ToggleStateChanged);
                this.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
                this.checkBox.Margin = new System.Windows.Forms.Padding(-16, 0, 0, 0);
                this.checkBox.IsThreeState = true;
                this.Children.Add(checkBox);
            }

            void checkBox_ToggleStateChanged(object sender, StateChangedEventArgs args)
            {
                if (this.Data != null)
                {
                    this.Data.CheckState = checkBox.ToggleState;
                }
            }

            protected override void SynchronizeProperties()
            {
                base.SynchronizeProperties();

                this.checkBox.ToggleStateChanged -= new StateChangedEventHandler(checkBox_ToggleStateChanged);
                this.checkBox.ToggleState = this.Data.CheckState;
                this.checkBox.ToggleStateChanged += new StateChangedEventHandler(checkBox_ToggleStateChanged);
            }

            protected override Type ThemeEffectiveType
            {
                get
                {
                    return typeof(DetailListViewGroupVisualItem);
                }
            }
        }
    }
}
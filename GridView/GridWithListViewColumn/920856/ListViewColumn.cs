using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.WinControls.UI;
using System.Drawing;

namespace _920856
{
    class ListViewCellInfo
    {
		// Can add more list view settings to here if they need to be changed at runtime
        public List<ListViewRowDataItem> Items;
        public int Height { get; set; }
        public int Width { get; set; }
        public String ThemeRole { get; set; }
        public ListViewCellInfo()
        {
            Height = 20; // Default used for ItemSize setting
            Width = 100;
            Items = new List<ListViewRowDataItem>();
        }
    }

    class ListViewRowDataItem
    {
        public String Text { get; set; }
        public Image Image { get; set; }
        public Color ForeColor { get; set; }

        public ListViewRowDataItem()
        {
            Text = "";
            Image = null;
            ForeColor = Color.Black;
        }

        public ListViewRowDataItem(String _text, Image _image)
        {
            Text = _text;
            Image = _image;
            ForeColor = Color.Black;
        }
    }

    public class ListViewColumn : GridViewDataColumn
    {
        public ListViewColumn(String _name)
            : base(_name)
        {
            this.DataType = typeof(ListViewCellInfo);
        }

        public override Type GetCellType(GridViewRowInfo row)
        {
            if (row is GridViewDataRowInfo)
                return typeof(ListViewCell);
            return base.GetCellType(row);
        }
    }

    class ListViewCell : GridDataCellElement
    {
        public RadListViewElement listView;
        public ListViewCell(GridViewColumn column, GridRowElement row)
            : base(column, row)
        {
        }

        protected override void CreateChildElements()
        {
            base.CreateChildElements();
            listView = new RadListViewElement();
            listView.SelectedIndex = -1;
            listView.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.Auto;
            listView.ViewType = ListViewType.DetailsView;
            listView.ShowColumnHeaders = false;
            listView.AutoSize = true;
            listView.ThemeRole = "Desert";
            listView.VisualItemFormatting += listView_VisualItemFormatting;
            listView.Columns.Add("Graphic");
            listView.Columns["Graphic"].Width = 40; // Width of graphics used
            listView.Columns.Add("Text");
            listView.Columns["Text"].Width = 100; // Text width
            Children.Add(listView);
        }

		public int GetHeight()
		{
			return listView.ItemSize.Height * listView.Items.Count;
		}

        void listView_VisualItemFormatting(object sender, ListViewVisualItemEventArgs e)
        {
            BaseListViewVisualItem lvi = e.VisualItem as BaseListViewVisualItem;
            lvi.DrawBorder = false; // Don't want list view borders
            lvi.DrawFill = false; // Don't want list view highlighting
        }

        protected override void SetContentCore(object value)
        {
            // base.SetContentCore(value);
            ListViewCellInfo info = value as ListViewCellInfo;
            listView.Items.Clear();
			int height = info.Height;
            foreach (ListViewRowDataItem item in info.Items)
            {
                ListViewDataItem row = new ListViewDataItem();
                listView.Items.Add(row);
                row.Text = ""; // Text is shown in next column
                row.Image = item.Image;

                row["Text"] = item.Text;
				row.ForeColor = item.ForeColor;
				row.TextAlignment = ContentAlignment.MiddleLeft;
                row.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            }
            listView.ItemSize = new Size(info.Width, info.Height);
            listView.SelectedItem = null;
        }

        protected override Type ThemeEffectiveType
        {
            get
            {
                return typeof(GridDataCellElement);
            }
        }

        public override bool IsCompatible(GridViewColumn data, object context)
        {
            return data is ListViewColumn && context is GridDataRowElement;
        }
    }
}

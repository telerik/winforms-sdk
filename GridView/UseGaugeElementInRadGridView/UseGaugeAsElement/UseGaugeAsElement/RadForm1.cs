using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Gauges;
using Telerik.WinControls.XmlSerialization;

namespace UseGaugeAsElement
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
            radGridView1.CreateCell += RadGridView1_CreateCell;
            radGridView1.DataSource = GetTable();

            GridViewSummaryItem summaryItem = new GridViewSummaryItem();
            summaryItem.Name = "Dosage";
            summaryItem.Aggregate = GridAggregateFunction.Avg;
            GridViewSummaryRowItem summaryRowItem = new GridViewSummaryRowItem();
            summaryRowItem.Add(summaryItem);
            this.radGridView1.SummaryRowsTop.Add(summaryRowItem);

            radGridView1.TableElement.RowHeight = 60;
            radGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
        }

        private void RadGridView1_CreateCell(object sender, GridViewCreateCellEventArgs e)
        {
            if (e.CellType == typeof(GridSummaryCellElement) && e.Column.Name == "Dosage")
            {
                e.CellElement = new CustomSummaryCell(e.Column, e.Row);
            }
        }

        static DataTable GetTable()
        {

            DataTable table = new DataTable();
            table.Columns.Add("Dosage", typeof(int));
            table.Columns.Add("Drug", typeof(string));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Date", typeof(DateTime));
            table.Columns.Add("Bool", typeof(bool));


            table.Rows.Add(25, "Indocin", "David", DateTime.Now.AddDays(-1), true);
            table.Rows.Add(50, "Enebrel", "Sam", DateTime.Now.AddDays(4), true);
            table.Rows.Add(10, "Hydralazine", "John", DateTime.Now.AddDays(2), true);
            table.Rows.Add(21, "Combivent", "Janet", DateTime.Now.AddDays(5), true);
            table.Rows.Add(100, "Dilantin", "Melanie", DateTime.Now.AddMonths(4), true);


            return table;
        }

    }
    class CustomSummaryCell : GridSummaryCellElement
    {
        public CustomSummaryCell(GridViewColumn col, GridRowElement row) : base(col, row)
        { }
        RadLinearGaugeElement bullet1;
        protected override void CreateChildElements()
        {
            base.CreateChildElements();
            bullet1 = new RadLinearGaugeElement();
            bullet1.Padding = new Padding(5,3,7,3);
            using (StreamReader sr = new StreamReader(@"..\..\BulletDefault1.xml"))
            {
                var ser = new ComponentXmlSerializer();
                using (XmlTextReader textReader = new XmlTextReader(sr))
                {
                    ser.ReadObjectElement(textReader, bullet1);
                }
            }

            this.Children.Add(bullet1);

        }
        public override void SetContent()
        {
            base.SetContent();
            ((LinearGaugeNeedleIndicator )this.bullet1.Items[4]).Value = Convert.ToSingle(this.Value.ToString());
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.Charting;
using Telerik.WinControls.UI;

namespace GridChartIntegration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.radGridView1.MultiSelect = true;
            this.radGridView1.SelectionMode = Telerik.WinControls.UI.GridViewSelectionMode.CellSelect;

            this.radGridView1.SelectionChanged += radGridView1_SelectionChanged;
        }

        private void radGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (this.radGridView1.SelectedCells.Count > 0)
            {
                PopulateChart(this.radGridView1.SelectedCells);
            }
        }

        private void PopulateChart(GridViewSelectedCellsCollection gridViewSelectedCellsCollection)
        {
            List<string> orderIds = new List<string>();
            this.radChartView1.Series.Clear();
            this.radChartView1.Axes.Clear();
            this.radChartView1.ShowLegend = true;

            foreach (GridViewCellInfo cell in gridViewSelectedCellsCollection)
            {
                double cellValue;
                if (double.TryParse(cell.Value + "", out cellValue))
                {
                    BarSeries barSeries;
                    DataRowView rowView = cell.RowInfo.DataBoundItem as DataRowView;
                    if (!orderIds.Contains(rowView.Row["OrderID"].ToString()))
                    {
                        orderIds.Add(rowView.Row["OrderID"].ToString());
                        barSeries = new BarSeries();
                        barSeries.Name = rowView.Row["OrderID"].ToString();
                        barSeries.LegendTitle = barSeries.Name;
                     
                        this.radChartView1.Series.Add(barSeries);
                    }
                    else
                    {
                        barSeries = GetBarSeries(rowView.Row["OrderID"].ToString()) as BarSeries ;
                    }
                    barSeries.DataPoints.Add(new CategoricalDataPoint(cellValue, cell.ColumnInfo.Name));  
                }
            }

            this.radChartView1.Invalidate();
        }

        private ChartSeries GetBarSeries(string p)
        {
            foreach (ChartSeries s in this.radChartView1.Series)
            {
                if (s.Name == p)
                {
                    return s;
                }
            }

            return null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nwindDataSet.Order_Details' table. You can move, or remove it, as needed.
            this.order_DetailsTableAdapter.Fill(this.nwindDataSet.Order_Details);

            this.radGridView1.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.Charting;
using Telerik.WinControls.UI;

namespace _3DBarChart
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        List<DataPointModel> barSeries1Data;
        List<DataPointModel> barSeries2Data;

        public RadForm1()
        {
            InitializeComponent();
            
            this.radChartView1.CreateRenderer += radChartView1_CreateRenderer;
            this.radChartView1.Title = "Title";
            this.radChartView1.ShowTitle = true;

            this.barSeries1Data = new List<DataPointModel>();
            this.barSeries2Data = new List<DataPointModel>();
            this.GenerateData();
            this.SetupBarSeries();
        }

        private void radChartView1_CreateRenderer(object sender, ChartViewCreateRendererEventArgs e)
        {
            e.Renderer = new CustomCartesianRenderer(e.Area as CartesianArea);
        }

        private void SetupBarSeries()
        {
            this.barSeries1Data.Sort(new MyDataPointComparer());
            this.barSeries2Data.Sort(new MyDataPointComparer());

            BarSeries barSeries1 = new BarSeries() { Name = "First" };
            barSeries1.DataSource = this.barSeries1Data;
            barSeries1.ValueMember = "Value";
            barSeries1.CategoryMember = "Year";

            BarSeries barSeries2 = new BarSeries() { Name = "Second" };
            barSeries2.DataSource = this.barSeries2Data;
            barSeries2.ValueMember = "Value";
            barSeries2.CategoryMember = "Year";

            CategoricalAxis categoricalAxis = new CategoricalAxis();
            categoricalAxis.PlotMode = AxisPlotMode.BetweenTicks;
            barSeries1.HorizontalAxis = categoricalAxis;
            barSeries2.HorizontalAxis = categoricalAxis;
            categoricalAxis.Font = new Font("Calibri", 16, FontStyle.Bold);

            barSeries1.CombineMode = ChartSeriesCombineMode.Stack;
            barSeries2.CombineMode = ChartSeriesCombineMode.Stack;

            this.radChartView1.Series.Add(barSeries1);
            this.radChartView1.Series.Add(barSeries2);


            for (int i = 0; i < 13; i++)
            {
                BarSeries series = new BarSeries();
                List<DataPointModel> data = new List<DataPointModel>();
                for (int j = 0; j < 5; j++)
                {
                    data.Add(new DataPointModel
                    {
                        Value = 10 * j + 10,
                        Year = 2010 + j
                    });
                }

                series.CombineMode = ChartSeriesCombineMode.Stack;
                series.DataSource = data;
                series.ValueMember = "Value";
                series.CategoryMember = "Year";

                if (i == 12)
                {
                    series.Name = "Last";
                }

                this.radChartView1.Series.Add(series);
            }
        }

        private void GenerateData()
        {
            this.barSeries1Data.Add(new DataPointModel
            {
                Value = 177,
                Year = 2010
            });

            this.barSeries1Data.Add(new DataPointModel
            {
                Value = 111,
                Year = 2014
            });

            this.barSeries1Data.Add(new DataPointModel
            {
                Value = 118,
                Year = 2011
            });

            this.barSeries1Data.Add(new DataPointModel
            {
                Value = 128,
                Year = 2012
            });

            this.barSeries1Data.Add(new DataPointModel
            {
                Value = 143,
                Year = 2013
            });

            this.barSeries2Data.Add(new DataPointModel
            {
                Value = 153,
                Year = 2010
            });

            this.barSeries2Data.Add(new DataPointModel
            {
                Value = 88,
                Year = 2014
            });

            this.barSeries2Data.Add(new DataPointModel
            {
                Value = 141,
                Year = 2011
            });

            this.barSeries2Data.Add(new DataPointModel
            {
                Value = 109,
                Year = 2012
            });

            this.barSeries2Data.Add(new DataPointModel
            {
                Value = 130,
                Year = 2013
            });
        }
    }

    public class DataPointModel
    {
        public int Value { get; set; }

        public int Year { get; set; }
    }
}

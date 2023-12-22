using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.Charting;
using System.Drawing.Drawing2D;
using HotelApp.Data;

namespace HotelApp
{
    public partial class UserControlCurrentStatus : UserControl
    {
        public UserControlCurrentStatus()
        {
            InitializeComponent();

            this.reportsRangeSelectorPanel.BackColor = Color.White;
            this.reportsRangeSelectorPanel.RootElement.EnableElementShadow = false;

            this.trendsRangeSelector.RangeSelectorElement.Margin = new Padding(120, 0, 40, 40);
            this.trendsRangeSelector.ShowButtons = false;
            this.trendsRangeSelector.SelectionChanged += trendsRangeSelector_SelectionChanged;
            this.trendsRangeSelector.ScaleInitializing += trendsRangeSelector_ScaleInitializing;

            this.occupiedPerDayChartView.ShowTitle = true;
            this.occupiedPerDayChartView.Title = "OCCUPIED PER DAY";
            this.occupiedPerDayChartView.ChartElement.TitleElement.CustomFont = Utils.MainFontMedium;
            this.occupiedPerDayChartView.ChartElement.TitleElement.CustomFontSize = 10f;
            this.occupiedPerDayChartView.ChartElement.TitleElement.TextAlignment = ContentAlignment.MiddleCenter;
            CartesianArea area = this.occupiedPerDayChartView.GetArea<CartesianArea>();
            area.ShowGrid = true;
            CartesianGrid grid = area.GetGrid<CartesianGrid>();
            grid.DrawHorizontalFills = false;
            grid.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.occupiedPerDayChartView.Area.View.Palette = KnownPalette.Rainbow;
            this.trendsChartView.Area.View.Palette = KnownPalette.Rainbow;

            this.trendsChartView.ShowTitle = true;
            this.trendsChartView.Title = "TRENDS";
            this.trendsChartView.ChartElement.TitleElement.CustomFont = Utils.MainFontMedium;
            this.trendsChartView.ChartElement.TitleElement.CustomFontSize = 10f;
            this.trendsChartView.ChartElement.TitleElement.TextAlignment = ContentAlignment.MiddleCenter;

            this.trendsRangeSelector.AssociatedControl = this.trendsChartView;
        }

        private void trendsRangeSelector_ScaleInitializing(object sender, ScaleInitializingEventArgs e)
        {
            DateTime dt;
            foreach (RangeSelectorChartScaleLabelElement label in e.ScaleElement.Children)
            {
                if (DateTime.TryParse(label.Text, out dt))
                {
                    label.Text = dt.ToString("dd/MM/yyyy");
                }
            }
        }

        private void trendsRangeSelector_SelectionChanged(object sender, EventArgs e)
        {
            if (this.trendsChartView.Series.Count > 0)
            {
                this.trendsChartView.ChartElement.InvalidateMeasure(true);
                this.trendsChartView.ChartElement.UpdateLayout();
                LineSeries ls = this.trendsChartView.Series[0] as LineSeries;
                RemoveBorderFromAxis(ls.VerticalAxis as LinearAxis, ls.HorizontalAxis as CategoricalAxis);
            }
        }

        public void Initialize(string reportsInterval, BindingList<Booking> bookings, BindingList<Room> rooms, DateTime date)
        {
            this.occupiedPerDayChartView.Series.Clear();
            this.occupiedPerDayChartView.Axes.Clear();
            this.occupiedPerDayChartView.Annotations.Clear();
            this.trendsChartView.Series.Clear();
            this.trendsChartView.Axes.Clear();
            this.trendsRangeSelector.AssociatedControl = null;

            switch (reportsInterval)
            {
                case "Days":
                    LoadChart(bookings, date, 3);
                    break;
                case "Weekly":
                    LoadChart(bookings, date, 7);
                    break;
                case "Monthly":
                    LoadChart(bookings, date, 30);
                    break;
            }

            this.trendsRangeSelector.AssociatedControl = this.trendsChartView;
            this.trendsRangeSelector.StartRange = 0;
            this.trendsRangeSelector.EndRange = 100;
        }

        private void LoadChart(BindingList<Booking> bookings, DateTime date, int days)
        {
            this.occupiedPerDayChartView.LabelFormatting -= occupiedPerDayChartView_LabelFormatting;
            this.occupiedPerDayChartView.LabelFormatting += occupiedPerDayChartView_LabelFormatting; 
            BarSeries barSeries = new BarSeries();
            LineSeries lineSeries = new LineSeries();
            barSeries.ShowLabels = true;
            int verticalMaxValue = 0;

            int occupiedPerDay = 0;
            for (int i = 0; i < days; i++)
            {
                occupiedPerDay = GetOccupiedRooms(bookings, date.AddDays(i));
                barSeries.DataPoints.Add(new CategoricalDataPoint(occupiedPerDay, date.AddDays(i)));
                lineSeries.DataPoints.Add(new CategoricalDataPoint(occupiedPerDay, date.AddDays(i)));
                if (occupiedPerDay > verticalMaxValue)
                {
                    verticalMaxValue = occupiedPerDay;
                }
            }
            this.occupiedPerDayChartView.Series.Add(barSeries);
            this.trendsChartView.Series.Add(lineSeries);

            LinearAxis verticalAxis = barSeries.VerticalAxis as LinearAxis;
            verticalAxis.BorderColor = Color.FromArgb(209, 209, 209);
            verticalAxis.CustomFont = Utils.MainFontMedium;
            verticalAxis.CustomFontSize = 10f;
            verticalAxis.Minimum = 0;
            verticalAxis.Maximum = Math.Max(verticalMaxValue, 5);
            verticalAxis.MajorStep = 1;

            LinearAxis trendsVerticalAxis = lineSeries.VerticalAxis as LinearAxis;
            trendsVerticalAxis.BorderColor = Color.FromArgb(209, 209, 209);
            trendsVerticalAxis.CustomFont = Utils.MainFontMedium;
            trendsVerticalAxis.CustomFontSize = 10f;
            trendsVerticalAxis.Minimum = 0;
            trendsVerticalAxis.Maximum = Math.Max(verticalMaxValue, 5);
            trendsVerticalAxis.MajorStep = verticalMaxValue / 2;

            CategoricalAxis horizontalAxis = barSeries.HorizontalAxis as CategoricalAxis;
            if (days <= 7)
            {
                horizontalAxis.MajorTickInterval = 1; 
            }
            else if (days > 7)
            {
                horizontalAxis.MajorTickInterval = 5;
            }
            horizontalAxis.LabelFitMode = AxisLabelFitMode.MultiLine;
            horizontalAxis.GapLength = 0.58;
            horizontalAxis.CustomFont = Utils.MainFontMedium;
            horizontalAxis.CustomFontSize = 10f;
            horizontalAxis.LabelFormat = "{0:dd/MM/yyyy}";
            horizontalAxis.BorderColor = Color.FromArgb(209, 209, 209);

            CategoricalAxis trendsHorizontalAxis = lineSeries.HorizontalAxis as CategoricalAxis;
            if (days <= 7)
            {
                trendsHorizontalAxis.MajorTickInterval = 1;
            }
            else if (days > 7)
            {
                trendsHorizontalAxis.MajorTickInterval = 5;
            }
            trendsHorizontalAxis.LabelFitMode = AxisLabelFitMode.MultiLine;
            trendsHorizontalAxis.ClipLabels = true;
            trendsHorizontalAxis.CustomFont = Utils.MainFontMedium;
            trendsHorizontalAxis.CustomFontSize = 10f;
            trendsHorizontalAxis.PlotMode = AxisPlotMode.BetweenTicks; 
            trendsHorizontalAxis.LabelFormat = "{0:dd/MM/yyyy}";
            trendsHorizontalAxis.BorderColor = Color.FromArgb(209, 209, 209);

            this.occupiedPerDayChartView.ChartElement.View.Margin = new Padding(60, 20, 40, 20);
            this.trendsChartView.ChartElement.View.Margin = new Padding(100, 20, 40, 10);

            if (verticalMaxValue > 0)
            {
                CartesianGridLineAnnotation annotation1 = new CartesianGridLineAnnotation();
                annotation1.Axis = verticalAxis;
                annotation1.Value = verticalMaxValue;
                annotation1.BorderColor = Color.FromArgb(255, 145, 0);
                annotation1.BorderDashStyle = DashStyle.Solid;
                annotation1.BorderWidth = 2;
                this.occupiedPerDayChartView.Annotations.Add(annotation1);
            }
            this.occupiedPerDayChartView.ChartElement.InvalidateMeasure(true);
            this.occupiedPerDayChartView.ChartElement.UpdateLayout();
            RemoveBorderFromAxis(verticalAxis, horizontalAxis);

            this.trendsChartView.ChartElement.InvalidateMeasure(true);
            this.trendsChartView.ChartElement.UpdateLayout();
            RemoveBorderFromAxis(trendsVerticalAxis, trendsHorizontalAxis);
        }
 
        private void RemoveBorderFromAxis(LinearAxis verticalAxis, CategoricalAxis horizontalAxis)
        {
            foreach (UIChartElement el in verticalAxis.Children)
            {
                AxisLabelElement label = el as AxisLabelElement;
                if (label != null)
                {
                    label.BorderWidth = 0;
                }
            }
            foreach (UIChartElement el in horizontalAxis.Children)
            {
                AxisLabelElement label = el as AxisLabelElement;
                if (label != null)
                {
                    label.BorderWidth = 0;
                }
            }
        }

        private void occupiedPerDayChartView_LabelFormatting(object sender, ChartViewLabelFormattingEventArgs e)
        {
            e.LabelElement.BackColor = Color.Transparent;
            e.LabelElement.BorderColor = Color.Transparent; 
        }

        private int GetOccupiedRooms(BindingList<Booking> bookings, DateTime date)
        {
            int occupiedRooms = 0;
            foreach (Booking b in bookings)
            {
                if (b.From <= date && b.To >= date && (b.Status == BookingStatus.Actual || b.Status == BookingStatus.Reservation))
                {
                    occupiedRooms++;
                }
            }

            return occupiedRooms;
        }
    }
}
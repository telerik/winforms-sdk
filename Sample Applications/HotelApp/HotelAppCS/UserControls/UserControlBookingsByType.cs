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
using HotelApp.Data;

namespace HotelApp
{
    public partial class UserControlBookingsByType : UserControl
    {
        public BindingList<Booking> Bookings;
        public BindingList<Room> Rooms;
        public static ColorConverter converter = new ColorConverter();

        public UserControlBookingsByType()
        {
            InitializeComponent();

            this.bookingsByTypeChartView.LabelFormatting += LabelFormatting;
            this.bookingsByRoomTypeChartView.LabelFormatting += LabelFormatting;
            this.availabilityChartView.LabelFormatting += availabilityChartView_LabelFormatting; 
            this.bookingsByTypeChartView.Area.View.Palette = new BookingTypesPalette(); 
            this.bookingsByTypeChartView.ChartElement.CustomFont = Utils.MainFont;
            this.bookingsByTypeChartView.ChartElement.CustomFontSize = 9;
            this.bookingsByRoomTypeChartView.Area.View.Palette = KnownPalette.Rainbow; 
            this.bookingsByRoomTypeChartView.ChartElement.CustomFont = Utils.MainFont;
            this.bookingsByRoomTypeChartView.ChartElement.CustomFontSize = 9;
            this.availabilityChartView.Area.View.Palette = new AvailabilityPalette(); 
            this.availabilityChartView.ChartElement.CustomFont = Utils.MainFont;
            this.availabilityChartView.ChartElement.CustomFontSize = 9;
            this.averageChartView.Area.View.Palette = KnownPalette.Rainbow;

            this.bookingsByTypeChartView.ChartElement.View.Margin = new Padding(60);
            this.bookingsByTypeChartView.Title = "BOOKINGS BY TYPE";
            this.bookingsByTypeChartView.ShowTitle = true;
            this.bookingsByTypeChartView.ChartElement.TitleElement.Margin = new Padding(0, 10, 0, 0);
            this.bookingsByTypeChartView.ChartElement.TitleElement.CustomFont = Utils.MainFontMedium;
            this.bookingsByTypeChartView.ChartElement.TitleElement.CustomFontSize = 10f;
            this.bookingsByTypeChartView.ChartElement.TitleElement.TextAlignment = ContentAlignment.MiddleCenter;

            this.bookingsByRoomTypeChartView.ChartElement.View.Margin = new Padding(60);
            this.bookingsByRoomTypeChartView.Title = "ACTUAL BOOKINGS BY ROOM TYPE";
            this.bookingsByRoomTypeChartView.ShowTitle = true;
            this.bookingsByRoomTypeChartView.ChartElement.TitleElement.Margin = new Padding(0, 10, 0, 0);
            this.bookingsByRoomTypeChartView.ChartElement.TitleElement.CustomFont = Utils.MainFontMedium;
            this.bookingsByRoomTypeChartView.ChartElement.TitleElement.CustomFontSize = 10f;
            this.bookingsByRoomTypeChartView.ChartElement.TitleElement.TextAlignment = ContentAlignment.MiddleCenter;

            this.availabilityChartView.ChartElement.View.Margin = new Padding(60);
            this.availabilityChartView.Title = "AVAILABILITY";
            this.availabilityChartView.ShowTitle = true;
            this.availabilityChartView.ChartElement.TitleElement.Margin = new Padding(0, 10, 0, 0);
            this.availabilityChartView.ChartElement.TitleElement.CustomFont = Utils.MainFontMedium;
            this.availabilityChartView.ChartElement.TitleElement.CustomFontSize = 10f;
            this.availabilityChartView.ChartElement.TitleElement.TextAlignment = ContentAlignment.MiddleCenter;

            this.averageChartView.Title = "AVERAGE STAY BY ROOM TYPE";
            this.averageChartView.ShowTitle = true;
            this.averageChartView.ChartElement.TitleElement.CustomFont = Utils.MainFontMedium;
            this.averageChartView.ChartElement.TitleElement.Padding = new Padding(0, 10, 0, 0);
            this.averageChartView.ChartElement.TitleElement.CustomFontSize = 10f;
            this.averageChartView.ChartElement.TitleElement.TextAlignment = ContentAlignment.MiddleCenter;
            this.averageChartView.ChartElement.View.Margin = new Padding(0, 20, 10, 10);

            CartesianArea area = this.averageChartView.GetArea<CartesianArea>();
            area.ShowGrid = true;
            CartesianGrid grid = area.GetGrid<CartesianGrid>();
            grid.DrawHorizontalFills = false;
            grid.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
        }

        private void availabilityChartView_LabelFormatting(object sender, ChartViewLabelFormattingEventArgs e)
        {
            PieDataPoint dp = e.LabelElement.DataPoint as PieDataPoint;
            if (dp != null)
            {
                PieLabelElement pieLabel = e.LabelElement as PieLabelElement;

                pieLabel.Text = dp.LegendTitle;
                pieLabel.BackColor = Color.Transparent;
                pieLabel.BorderColor = pieLabel.DataPointElement.BackColor;
                pieLabel.BorderGradientStyle = Telerik.WinControls.GradientStyles.Solid;
                if (dp.Value == 0)
                {
                    pieLabel.IsVisible = false;
                }
                else
                {
                    pieLabel.IsVisible = true;
                }
            }
        }

        internal void Initialize(string reportsInterval, BindingList<Booking> bookings, BindingList<Room> rooms, DateTime dateTime)
        {
            this.Bookings = bookings;
            this.Rooms = rooms;

            this.bookingsByTypeChartView.Series.Clear();
            this.bookingsByRoomTypeChartView.Series.Clear();
            this.availabilityChartView.Series.Clear();
            this.averageChartView.Series.Clear();
            this.averageChartView.GetArea<CartesianArea>().Orientation = Orientation.Vertical;
            this.averageChartView.Axes.Clear();

            this.bookingsByTypeChartView.AreaType = ChartAreaType.Pie;
            PieSeries series = new PieSeries();
            series.LabelsOffsetFromCenter = 1.05f;

            foreach (BookingStatus bookingStatus in Enum.GetValues(typeof(BookingStatus)))
            {
                PieDataPoint dataPoint = new PieDataPoint(GetBookingsByType(bookings, bookingStatus, dateTime, reportsInterval), Utils.GetBookingTypeByStatus(bookingStatus));
                if (dataPoint.Value > 0)
                {
                    series.DataPoints.Add(dataPoint);
                }
            }

            series.ShowLabels = true;
            if (series.DataPoints.Count > 0)
            {
                this.bookingsByTypeChartView.Series.Add(series);
            }

            this.bookingsByRoomTypeChartView.AreaType = ChartAreaType.Pie;
            PieSeries series2 = new PieSeries();
            series2.LabelsOffsetFromCenter = 1.05f;
            foreach (RoomType roomType in Enum.GetValues(typeof(RoomType)))
            {
                PieDataPoint dataPoint = new PieDataPoint(GetBookingsByRoomType(bookings, roomType, dateTime, reportsInterval), Utils.GetRoomType(roomType));
                if (dataPoint.Value > 0)
                {
                    series2.DataPoints.Add(dataPoint);
                }
            }

            series2.ShowLabels = true;
            if (series2.DataPoints.Count > 0)
            {
                this.bookingsByRoomTypeChartView.Series.Add(series2);
            }

            this.availabilityChartView.AreaType = ChartAreaType.Pie;
            PieSeries series3 = new PieSeries();
            series3.LabelsOffsetFromCenter = 1.05f;

            Availability needRepairs = GetBookingsByRoomRepairs(this.Bookings, dateTime, reportsInterval);

            if (needRepairs.Actual > 0)
            {
                series3.DataPoints.Add(new PieDataPoint(needRepairs.Actual, "Actual"));
            }
            if (needRepairs.Maintenance > 0)
            {
                series3.DataPoints.Add(new PieDataPoint(needRepairs.Maintenance, "Maintenance"));
            }

            series3.ShowLabels = true;
            if (series3.DataPoints.Count > 0)
            {
                this.availabilityChartView.Series.Add(series3);
            }

            foreach (RoomType roomType in Enum.GetValues(typeof(RoomType)))
            {
                BarSeries series4 = new BarSeries();
                CategoricalDataPoint dataPoint = new CategoricalDataPoint(GetBookingsDurationByRoomType(bookings, roomType, dateTime, reportsInterval), Utils.GetRoomType(roomType));
                if (dataPoint.Value > 0)
                {
                    series4.DataPoints.Add(dataPoint);
                }
                if (series4.DataPoints.Count > 0)
                {
                    this.averageChartView.Series.Add(series4);
                }
                LinearAxis verticalAxis = series4.VerticalAxis as LinearAxis;
                if (verticalAxis != null)
                {
                    verticalAxis.BorderColor = Color.FromArgb(209, 209, 209);
                    verticalAxis.CustomFont = Utils.MainFontMedium;
                    verticalAxis.CustomFontSize = 10f;
                    verticalAxis.Minimum = 0;
                    verticalAxis.Maximum = 3;
                    verticalAxis.LastLabelVisibility = AxisLastLabelVisibility.Hidden;
                    verticalAxis.LabelFormatProvider = new MyFormatProvider();
                    verticalAxis.MajorStep = 1;
                }

                CategoricalAxis horizontalAxis = series4.HorizontalAxis as CategoricalAxis;
                if (horizontalAxis != null)
                {
                    horizontalAxis.LabelFitMode = AxisLabelFitMode.MultiLine;
                    horizontalAxis.GapLength = 0.6;
                    horizontalAxis.CustomFont = Utils.MainFontMedium;
                    horizontalAxis.CustomFontSize = 10f;
                    horizontalAxis.LabelFormat = "{0:dd/MM/yyyy}";
                    horizontalAxis.BorderColor = Color.FromArgb(209, 209, 209);
                }

                this.averageChartView.ChartElement.InvalidateMeasure(true);
                this.averageChartView.ChartElement.UpdateLayout();
                RemoveBorderFromAxis(verticalAxis, horizontalAxis);
            }

            this.averageChartView.GetArea<CartesianArea>().Orientation = Orientation.Horizontal;
            this.bookingsByTypeChartView.ChartElement.InvalidateMeasure(true);
            this.bookingsByTypeChartView.ChartElement.UpdateLayout();
            this.bookingsByRoomTypeChartView.ChartElement.InvalidateMeasure(true);
            this.bookingsByRoomTypeChartView.ChartElement.UpdateLayout();
            this.availabilityChartView.ChartElement.InvalidateMeasure(true);
            this.availabilityChartView.ChartElement.UpdateLayout();
            
            this.bookingsByTypeChartView.ChartElement.Text = bookingsByTypeChartView.Series.Count > 0 ? "" : "No available data";
            this.bookingsByRoomTypeChartView.ChartElement.Text = bookingsByTypeChartView.Series.Count > 0 ? "" : "No available data";
            this.availabilityChartView.ChartElement.Text = bookingsByTypeChartView.Series.Count > 0 ? "" : "No available data";
        }

        private void RemoveBorderFromAxis(LinearAxis verticalAxis, CategoricalAxis horizontalAxis)
        {
            if (verticalAxis == null || horizontalAxis == null)
            {
                return;
            }
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

        private double GetBookingsDurationByRoomType(BindingList<Booking> bookings, RoomType roomType, DateTime date, string reportsInterval)
        {
            int days = 0;
            if (reportsInterval == "Days")
            {
                days = 3;
            }
            else if (reportsInterval == "Weekly")
            {
                days = 7;
            }
            else
            {
                days = 30;
            }
            int cnt = 0;
            double durationInDays = 0;
            foreach (Booking b in bookings)
            {
                if (Utils.GetRoomById(b.RoomId, this.Rooms).Type == roomType &&
                    (b.From >= date && b.From <= date.AddDays(days) || b.To >= date && b.To <= date.AddDays(days)))
                {
                    durationInDays = b.To.Subtract(b.From).TotalDays;
                    cnt++;
                }
            }
            return durationInDays / days;
        }

        private Availability GetBookingsByRoomRepairs(BindingList<Booking> bookings, DateTime date, string reportsInterval)
        {
            Availability needRepairs = new Availability(0, 0);
            int days = 0;
            if (reportsInterval == "Days")
            {
                days = 2;
            }
            else if (reportsInterval == "Weekly")
            {
                days = 6;
            }
            else
            {
                days = 29;
            }
            Room room;
            foreach (Booking booking in bookings)
            {
                room = Utils.GetRoomById(booking.RoomId, this.Rooms);
                if ((booking.From >= date && booking.From <= date.AddDays(days) || booking.To >= date && booking.To <= date.AddDays(days)))
                {
                    if (room.NeedsRepairs)
                    {
                        needRepairs.Actual++;
                    }
                    else
                    {
                        needRepairs.Maintenance++;
                    }
                }
            }
            return needRepairs;
        }

        private void LabelFormatting(object sender, ChartViewLabelFormattingEventArgs e)
        {
            PieDataPoint dp = e.LabelElement.DataPoint as PieDataPoint;
            if (dp != null)
            {
                PieLabelElement pieLabel = e.LabelElement as PieLabelElement;

                pieLabel.Text = dp.LegendTitle;
                pieLabel.BackColor = Color.Transparent;
                pieLabel.BorderColor = pieLabel.DataPointElement.BackColor;
                pieLabel.BorderGradientStyle = Telerik.WinControls.GradientStyles.Solid;
                if (dp.Value == 0)
                {
                    pieLabel.IsVisible = false;
                }
                else
                {
                    pieLabel.IsVisible = true;
                }
            }
        }

        private double GetBookingsByRoomType(BindingList<Booking> bookings, RoomType roomType, DateTime date, string reportsInterval)
        {
            int days = 0;
            if (reportsInterval == "Days")
            {
                days = 2;
            }
            else if (reportsInterval == "Weekly")
            {
                days = 6;
            }
            else
            {
                days = 29;
            }
            int cnt = 0;

            foreach (Booking b in bookings)
            {
                if (Utils.GetRoomById(b.RoomId, this.Rooms).Type == roomType &&
                    (b.From >= date && b.From <= date.AddDays(days) || b.To >= date && b.To <= date.AddDays(days)))
                {
                    cnt++;
                }
            }
            return cnt;
        }

        private double GetBookingsByType(BindingList<Booking> bookings, BookingStatus bookingStatus, DateTime date, string reportsInterval)
        {
            int days = 0;
            if (reportsInterval == "Days")
            {
                days = 2;
            }
            else if (reportsInterval == "Weekly")
            {
                days = 6;
            }
            else
            {
                days = 29;
            }
            int cnt = 0;

            foreach (Booking b in bookings)
            {
                if (b.Status == bookingStatus &&
                    (b.From >= date && b.From <= date.AddDays(days) || b.To >= date && b.To <= date.AddDays(days)))
                {
                    cnt++;
                }
            }
            return cnt;
        }

        private class Availability
        {
            public int Actual { get; set; }

            public int Maintenance { get; set; }

            public Availability(int actual, int maintenance)
            {
                this.Actual = actual;
                this.Maintenance = maintenance;
            }
        }

        public class BookingTypesPalette : ChartPalette
        {
            public BookingTypesPalette()
            {
                Color color1 = (Color)converter.ConvertFromString("#FF1171CA");
                Color color2 = (Color)converter.ConvertFromString("#FF3294DA");
                Color color3 = (Color)converter.ConvertFromString("#FFE03D0B");
                Color color4 = (Color)converter.ConvertFromString("#FFF58E13");

                this.GlobalEntries.Add(color1, color1);
                this.GlobalEntries.Add(color2, color2);
                this.GlobalEntries.Add(color3, color3);
                this.GlobalEntries.Add(color4, color4);
            }
        }

        public class AvailabilityPalette : ChartPalette
        {
            public AvailabilityPalette()
            {
                Color color1 = (Color)converter.ConvertFromString("#FFE3DA20");
                Color color2 = (Color)converter.ConvertFromString("#FFE03D0B");

                this.GlobalEntries.Add(color1, color1);
                this.GlobalEntries.Add(color2, color2);
            }
        }

        public class MyFormatProvider : IFormatProvider, ICustomFormatter
        {
            public object GetFormat(Type formatType)
            {
                return this;
            }

            public string Format(string format, object arg, IFormatProvider formatProvider)
            {
                string s = arg.ToString();
                switch (s)
                {
                    case "0":
                        return "1 Day";
                    case "1":
                        return "2 Days";
                    case "2":
                        return "3 Days";
                    default:
                        return "N/A";
                }
            }
        }
    }
}
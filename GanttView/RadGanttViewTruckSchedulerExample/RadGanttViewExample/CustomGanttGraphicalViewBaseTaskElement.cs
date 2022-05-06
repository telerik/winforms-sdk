using System;
using System.Data;
using System.Drawing;
using Telerik.WinControls;
using Telerik.WinControls.Paint;
using Telerik.WinControls.UI;

namespace RadGanttViewExample
{
    public class CustomGanttGraphicalViewBaseTaskElement : GanttGraphicalViewBaseTaskElement
    {
        private Random rnd = new Random();
        private DrivingToPickUpLocationElement drivingToPickUpLocationElement;
        private LoadingElement loadingElement;
        private DrivingElement drivingElement;
        private DriverRestElement driverRestElement;
        private WaitingElement waitingElement;
        private UnloadingElement unloadingElement;
        private LightVisualElement borderElement;

        protected override void InitializeFields()
        {
            base.InitializeFields();

            this.TextAlignment = ContentAlignment.MiddleLeft;
            this.DrawFill = true;
            this.GradientStyle = Telerik.WinControls.GradientStyles.Solid;
            this.BackColor = Color.LightGray;
            this.DrawBorder = true;
            this.BorderGradientStyle = Telerik.WinControls.GradientStyles.Solid;
            this.BorderColor = Color.Black;
        }

        protected override void CreateChildElements()
        {
            base.CreateChildElements();

            this.drivingToPickUpLocationElement = new DrivingToPickUpLocationElement();
            this.drivingToPickUpLocationElement.DrawFill = true;
            this.drivingToPickUpLocationElement.GradientStyle = Telerik.WinControls.GradientStyles.Solid;
            this.drivingToPickUpLocationElement.BackColor = Color.LightBlue;

            this.loadingElement = new LoadingElement();
            this.loadingElement.DrawFill = true;
            this.loadingElement.GradientStyle = Telerik.WinControls.GradientStyles.Solid;
            this.loadingElement.BackColor = Color.DarkBlue;

            this.drivingElement = new DrivingElement();
            this.drivingElement.DrawFill = true;
            this.drivingElement.GradientStyle = Telerik.WinControls.GradientStyles.Solid;
            this.drivingElement.BackColor = Color.Green;

            this.driverRestElement = new DriverRestElement();
            this.driverRestElement.DrawFill = true;
            this.driverRestElement.GradientStyle = Telerik.WinControls.GradientStyles.Solid;
            this.driverRestElement.BackColor = Color.SlateGray;

            this.waitingElement = new WaitingElement();
            this.waitingElement.DrawFill = true;
            this.waitingElement.GradientStyle = Telerik.WinControls.GradientStyles.Solid;
            this.waitingElement.BackColor = Color.Gold;

            this.unloadingElement = new UnloadingElement();
            this.unloadingElement.DrawFill = true;
            this.unloadingElement.GradientStyle = Telerik.WinControls.GradientStyles.Solid;
            this.unloadingElement.BackColor = Color.RosyBrown;

            this.borderElement = new LightVisualElement();
            this.borderElement.DrawBorder = true;
            this.borderElement.BorderGradientStyle = Telerik.WinControls.GradientStyles.Solid;
            this.borderElement.BorderColor = Color.Black;
            this.borderElement.ShouldHandleMouseInput = false;
            this.borderElement.NotifyParentOnMouseInput = true;

            this.Children.Add(this.drivingToPickUpLocationElement);
            this.Children.Add(this.loadingElement);
            this.Children.Add(this.drivingElement);
            this.Children.Add(this.driverRestElement);
            this.Children.Add(this.waitingElement);
            this.Children.Add(this.unloadingElement);
            this.Children.Add(this.borderElement);
        }

        protected override void PaintElement(Telerik.WinControls.Paint.IGraphics graphics, float angle, SizeF scale)
        {
            base.PaintElement(graphics, angle, scale);

            PointF[] points = new PointF[4];
            points[0] = new PointF(this.loadingElement.BoundingRectangle.X, this.Size.Height - 1);
            points[1] = new PointF(this.loadingElement.BoundingRectangle.Right, this.Size.Height * 0.35f);
            points[2] = new PointF(this.unloadingElement.BoundingRectangle.X, this.Size.Height * 0.35f);
            points[3] = new PointF(this.unloadingElement.BoundingRectangle.Right, this.Size.Height - 1);

            graphics.ChangeSmoothingMode(System.Drawing.Drawing2D.SmoothingMode.AntiAlias);
            graphics.FillPolygon(Color.FromArgb(100, Color.Gray), points);
            graphics.RestoreSmoothingMode();
        }
        
        protected override SizeF ArrangeOverride(SizeF finalSize)
        {
            CustomGanttViewTaskItemElement itemElement = (CustomGanttViewTaskItemElement)this.Parent;
            DataRowView boundItem = itemElement.Data.DataBoundItem as DataRowView;
            GanttViewGraphicalViewElement graphicalView = itemElement.GraphicalViewElement;

            SizeF availableSize = base.ArrangeOverride(finalSize);
            RectangleF clientRect = new RectangleF(PointF.Empty, availableSize);
            RectangleF arrangeRect = new RectangleF(clientRect.X, clientRect.Y, 0, clientRect.Height * 0.3f);

            float arrangeRectWidth = graphicalView.GetDrawRectangle(itemElement.Data, itemElement.Data.Start, itemElement.Data.Start.Add((TimeSpan)boundItem["DrivingToPickUpLocation"])).Width;
            arrangeRect.Width = arrangeRectWidth;
            this.drivingToPickUpLocationElement.Arrange(arrangeRect);

            arrangeRect.X += arrangeRectWidth;
            arrangeRectWidth = graphicalView.GetDrawRectangle(itemElement.Data, itemElement.Data.Start, itemElement.Data.Start.Add((TimeSpan)boundItem["Loading"])).Width;
            arrangeRect.Width = arrangeRectWidth;
            this.loadingElement.Arrange(arrangeRect);

            arrangeRect.X += arrangeRectWidth;
            arrangeRectWidth = graphicalView.GetDrawRectangle(itemElement.Data, itemElement.Data.Start, itemElement.Data.Start.Add((TimeSpan)boundItem["Driving"])).Width;
            arrangeRect.Width = arrangeRectWidth;
            this.drivingElement.Arrange(arrangeRect);

            arrangeRect.X += arrangeRectWidth;
            arrangeRectWidth = graphicalView.GetDrawRectangle(itemElement.Data, itemElement.Data.Start, itemElement.Data.Start.Add((TimeSpan)boundItem["DriverRest"])).Width;
            arrangeRect.Width = arrangeRectWidth;
            this.driverRestElement.Arrange(arrangeRect);

            arrangeRect.X += arrangeRectWidth;
            arrangeRectWidth = graphicalView.GetDrawRectangle(itemElement.Data, itemElement.Data.Start, itemElement.Data.Start.Add((TimeSpan)boundItem["Waiting"])).Width;
            arrangeRect.Width = arrangeRectWidth;
            this.waitingElement.Arrange(arrangeRect);

            arrangeRect.X += arrangeRectWidth;
            arrangeRectWidth = graphicalView.GetDrawRectangle(itemElement.Data, itemElement.Data.Start, itemElement.Data.Start.Add((TimeSpan)boundItem["Unloading"])).Width;
            arrangeRect.Width = arrangeRectWidth;
            this.unloadingElement.Arrange(arrangeRect);

            arrangeRect.X = clientRect.X;
            arrangeRect.Width = clientRect.Width;
            this.borderElement.Arrange(arrangeRect);

            return availableSize;
        }
    }

    public class DrivingToPickUpLocationElement : LightVisualElement
    { }

    public class LoadingElement : LightVisualElement
    { }

    public class DrivingElement : LightVisualElement
    { }

    public class DriverRestElement : LightVisualElement
    { }

    public class WaitingElement : LightVisualElement
    { }

    public class UnloadingElement : LightVisualElement
    { }
}

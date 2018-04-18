using Telerik.Windows.Diagrams.Core;

namespace CustomDraggingService
{
    #region CustomDraggingService
    public class CustomDraggingService : DraggingService
    {
        private Telerik.Windows.Diagrams.Core.Point startDragPoint;
        private DragMode dragMode = DragMode.Both;

        public CustomDraggingService(IGraphInternal graph)
            : base(graph)
        { }

        public DragMode DragMode
        {
            get
            {
                return this.dragMode;
            }
            set
            {
                this.dragMode = value;
            }
        }

        public override void InitializeDrag(Telerik.Windows.Diagrams.Core.Point point)
        {
            this.startDragPoint = point;

            base.InitializeDrag(point);
        }

        public override void Drag(Telerik.Windows.Diagrams.Core.Point newPoint)
        {
            Telerik.Windows.Diagrams.Core.Point dragPoint = newPoint;
            if (this.DragMode == DragMode.Horizontal)
            {
                dragPoint = new Telerik.Windows.Diagrams.Core.Point(newPoint.X, this.startDragPoint.Y);
            }
            else if (this.DragMode == DragMode.Vertical)
            {
                dragPoint = new Telerik.Windows.Diagrams.Core.Point(this.startDragPoint.X, newPoint.Y);
            }

            base.Drag(dragPoint);
        }
    }

    #endregion

    #region DragModeEnum
    public enum DragMode
    {
        Both,
        Horizontal,
        Vertical,
    }
    #endregion
}

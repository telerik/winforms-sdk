using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace TicketTest
{
    public class DashboardDragDropService: RadDragDropService
    {
        protected override void OnPreviewDragOver(RadDragOverEventArgs e)
        {
            base.OnPreviewDragOver(e);

            StackLayoutElement dropTarget = e.HitTarget as StackLayoutElement;
            TaskElement draggedObject = e.DragInstance as TaskElement;

            if (draggedObject != null && dropTarget != null && dropTarget != draggedObject.Parent)
            {
                e.CanDrop = true;
            }            
        }

        protected override void OnPreviewDragDrop(RadDropEventArgs e)
        {
            StackLayoutElement dropTarget = e.HitTarget as StackLayoutElement;
            TaskElement draggedObject = e.DragInstance as TaskElement;

            if (draggedObject != null && dropTarget != null)
            {
                draggedObject.Parent.Children.Remove(draggedObject);
                dropTarget.Children.Add(draggedObject);
            }

            base.OnPreviewDragDrop(e);
        }
    }
}

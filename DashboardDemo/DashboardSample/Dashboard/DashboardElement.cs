using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.WinControls.UI;
using System.Drawing;

namespace TicketTest
{
    public class DashboardElement: StackLayoutElement
    {
        ColumnElement pending;
        ColumnElement inProgress;
        ColumnElement readyForTest;
        ColumnElement done;
        DashboardDragDropService dragDropService = new DashboardDragDropService();

        public ColumnElement Pending { get { return this.pending; } }
        public ColumnElement InProgress { get { return this.inProgress; } }
        public ColumnElement ReadyForTest { get { return this.readyForTest; } }
        public ColumnElement Done { get { return this.done; } }

        public DashboardDragDropService DragDropService { get { return this.dragDropService; } }

        protected override void InitializeFields()
        {
            base.InitializeFields();

            this.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.StretchHorizontally = true;
            this.StretchVertically = true;
            this.BackColor = Color.White;
            this.DrawFill = true;
            this.GradientStyle = Telerik.WinControls.GradientStyles.Solid;
            this.DrawBorder = false;
        }

        protected override void CreateChildElements()
        {
            base.CreateChildElements();

            pending = new ColumnElement("Pending");
            this.Children.Add(pending);
            
            inProgress = new ColumnElement("In Progress");
            this.Children.Add(inProgress);
            
            readyForTest = new ColumnElement("Ready for test");
            this.Children.Add(readyForTest);
            
            done = new ColumnElement("Done");
            this.Children.Add(done);
        }
    }
}

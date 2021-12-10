using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.WinControls.UI;
using System.Drawing;

namespace TicketTest
{
    public class TaskElement: LightVisualElement
    {
        public TaskElement(string text)
        {
            this.Text = text;
        }

        protected override void InitializeFields()
        {
            base.InitializeFields();

            this.DrawFill = true;
            this.DrawBorder = true;
            this.GradientStyle = Telerik.WinControls.GradientStyles.Solid;
            this.BorderGradientStyle = Telerik.WinControls.GradientStyles.Solid;
            this.BackColor = Color.Yellow;
            this.BorderColor = Color.Black;
            this.AllowDrag = true;
            this.StretchHorizontally = true;
            this.StretchVertically = false;
            this.TextWrap = true;
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Margin = new System.Windows.Forms.Padding(5);
        }

        protected override void OnMouseDown(System.Windows.Forms.MouseEventArgs e)
        {
            base.OnMouseDown(e);
            
            DashboardElement dashboard = FindAncestor<DashboardElement>();
            dashboard.DragDropService.Start(this);
        }
    }
}

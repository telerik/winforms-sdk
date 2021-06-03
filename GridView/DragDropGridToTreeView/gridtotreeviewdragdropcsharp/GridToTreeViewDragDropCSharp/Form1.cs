using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace GridToTreeViewDragDropCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //populate with data
            GridViewTextBoxColumn col = new GridViewTextBoxColumn("col");
            col.Width = 200;
            radGridView1.Columns.Add(col);

            for (int i = 0; i < 10; i++)
            {
                radGridView1.Rows.Add("Row " + i);
                radTreeView1.Nodes.Add("Node " + i);
            }

            //register the custom row behavior
            BaseGridBehavior gridBehavior = this.radGridView1.GridBehavior as BaseGridBehavior;
            gridBehavior.UnregisterBehavior(typeof(GridViewDataRowInfo));
            gridBehavior.RegisterBehavior(typeof(GridViewDataRowInfo), new CustomGridDataRowBehavior());

            RadDragDropService dragDropService = radGridView1.GridViewElement.GetService<RadDragDropService>();
            dragDropService.PreviewDragStart += dragDropService_PreviewDragStart;
            dragDropService.PreviewDragOver += dragDropService_PreviewDragOver;
            dragDropService.PreviewDragDrop += dragDropService_PreviewDragDrop;
            dragDropService.PreviewDragHint += dragDropService_PreviewDragHint;
            dragDropService.Stopped += dragDropService_Stopped;
        }

        private void dragDropService_PreviewDragStart(object sender, PreviewDragStartEventArgs e)
        {
            e.CanStart = true;
        }
        
        void dragDropService_PreviewDragHint(object sender, PreviewDragHintEventArgs e)
        {
            e.UseDefaultHint = false;
        }

        RadLayeredWindow dropHintWindow = new RadLayeredWindow();

        private void dragDropService_PreviewDragOver(object sender, RadDragOverEventArgs e)
        {
            dropHintWindow.Hide();

            if (e.DragInstance is GridDataRowElement)
            {
                if (e.HitTarget is RadTreeViewElement)
                {
                    e.CanDrop = true;
                }
                else if (e.HitTarget is TreeNodeElement)
                {
                    e.CanDrop = true;
                    SetHintWindowPosition(MousePosition, (TreeNodeElement)e.HitTarget, e.DragInstance.GetDragHint());
                }
            }
        }

        protected void SetHintWindowPosition(Point mousePt, TreeNodeElement nodeElement, Image originalHintImage)
        {
            dropHintWindow.Hide();

            Point point = this.radTreeView1.ElementTree.Control.PointToClient(mousePt);
            point = nodeElement.PointFromScreen(mousePt);
            DropPosition dropPosition = this.GetDropPosition(point, nodeElement);
            Image dropPositionImage = null;

            switch (dropPosition)
            {
                case DropPosition.None:
                    break;
                case DropPosition.BeforeNode:
                    dropPositionImage = Properties.Resources.RadTreeViewDropBefore;
                    break;
                case DropPosition.AfterNode:
                    dropPositionImage = Properties.Resources.RadTreeViewDropAfter;
                    break;
                case DropPosition.AsChildNode:
                    dropPositionImage = Properties.Resources.RadTreeViewDropAsChild;
                    break;
            }

            int offset = 10;
            Bitmap newHintImage = new Bitmap(originalHintImage.Width + dropPositionImage.Width + offset,
                Math.Max(originalHintImage.Height, dropPositionImage.Height));

            using (Graphics g = Graphics.FromImage(newHintImage))
            {
                g.Clear(Color.White);
                g.DrawImage(dropPositionImage, Point.Empty);
                g.DrawImage(originalHintImage, new Point(dropPositionImage.Width + offset, 0));
                g.DrawRectangle(Pens.LightGray, new Rectangle(0, 0, newHintImage.Width - 1, newHintImage.Height - 1));
            }

            dropHintWindow.TopMost = true;
            dropHintWindow.BackgroundImage = newHintImage;
            dropHintWindow.ShowWindow(mousePt);
        }

        protected DropPosition GetDropPosition(Point dropLocation, TreeNodeElement targetNodeElement)
        {
            int part = targetNodeElement.Size.Height / 3;
            int mouseY = dropLocation.Y;
            bool dropAtTop = mouseY < part;

            if (dropAtTop)
            {
                return DropPosition.BeforeNode;
            }

            if (mouseY >= part && mouseY <= part * 2)
            {
                return DropPosition.AsChildNode;
            }

            return DropPosition.AfterNode;
        }

        private void dragDropService_PreviewDragDrop(object sender, RadDropEventArgs e)
        {
            GridDataRowElement rowElement = e.DragInstance as GridDataRowElement;
            if (rowElement == null)
            {
                return;
            }
            string sourceText = rowElement.RowInfo.Cells[0].Value.ToString();
            TreeNodeElement targetNodeElement = e.HitTarget as TreeNodeElement;
            if (targetNodeElement != null)
            {
                RadTreeViewElement treeViewElement = targetNodeElement.TreeViewElement;
                RadTreeNode targetNode = targetNodeElement.Data;
                DropPosition dropPosition = this.GetDropPosition(e.DropLocation, targetNodeElement);

                switch (dropPosition)
                {
                    case DropPosition.None:
                        break;
                    case DropPosition.BeforeNode:
                        radGridView1.Rows.Remove(rowElement.RowInfo);

                        RadTreeNodeCollection nodes = targetNode.Parent == null ? treeViewElement.Nodes : targetNode.Parent.Nodes;
                        nodes.Insert(targetNode.Index, new RadTreeNode(sourceText));

                        break;
                    case DropPosition.AfterNode:
                        radGridView1.Rows.Remove(rowElement.RowInfo);

                        RadTreeNodeCollection nodes1 = targetNode.Parent == null ? treeViewElement.Nodes : targetNode.Parent.Nodes;
                        int targetIndex = targetNodeElement.Data.Index <= treeViewElement.Nodes.Count - 1 ? 
                            (targetNodeElement.Data.Index + 1) : treeViewElement.Nodes.Count - 1;
                        nodes1.Insert(targetIndex, new RadTreeNode(sourceText));

                        break;
                    case DropPosition.AsChildNode:
                        radGridView1.Rows.Remove(rowElement.RowInfo);

                        targetNode.Nodes.Add(new RadTreeNode(sourceText));

                        break;
                }
            }

            RadTreeViewElement treeElement = e.HitTarget as RadTreeViewElement;
            if (treeElement != null)
            {
                radGridView1.Rows.Remove(rowElement.RowInfo);
                radTreeView1.Nodes.Add(new RadTreeNode(sourceText));
            }
        }

        void dragDropService_Stopped(object sender, EventArgs e)
        {
            dropHintWindow.Hide();
        }

        //initiates drag and drop service for clicked row
        public class CustomGridDataRowBehavior : GridDataRowBehavior
        {
            protected override bool OnMouseDownLeft(MouseEventArgs e)
            {
                GridDataRowElement row = this.GetRowAtPoint(e.Location) as GridDataRowElement;
                if (row != null)
                {
                    RadGridViewDragDropService svc = this.GridViewElement.GetService<RadGridViewDragDropService>();
                    svc.AllowAutoScrollColumnsWhileDragging = false;
                    svc.AllowAutoScrollRowsWhileDragging = false;
                    svc.Start(row);
                }
                return base.OnMouseDownLeft(e);
            }
        }
    }
}
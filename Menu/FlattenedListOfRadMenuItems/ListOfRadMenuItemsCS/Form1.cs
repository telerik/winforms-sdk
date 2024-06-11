using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace ListOfRadMenuItems
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Debug.Assert(GetRadMenuItems(radMenu1.Items).Count == 10);
            Debug.Assert(GetRadTreeNodes(radTreeView1.Nodes).Count == 10);
        }

        public static ReadOnlyCollection<RadMenuItemBase> GetRadMenuItems(Telerik.WinControls.RadItemCollection items)
        {
            List<RadMenuItemBase> returnItems = new List<RadMenuItemBase>();
            foreach (RadMenuItemBase item in items)
            {
                returnItems.Add(item);
                ReadOnlyCollection<RadMenuItemBase> subItems = GetRadMenuItems(item.Items);
                returnItems.AddRange(subItems);
            }
            ReadOnlyCollection<RadMenuItemBase> readOnlyItems = new ReadOnlyCollection<RadMenuItemBase>(returnItems);
            return readOnlyItems;
        }

        public static ReadOnlyCollection<RadTreeNode> GetRadTreeNodes(Telerik.WinControls.UI.RadTreeNodeCollection nodes)
        {
            List<RadTreeNode> returnNodes = new List<RadTreeNode>();
            foreach (RadTreeNode node in nodes)
            {
                returnNodes.Add(node);
                ReadOnlyCollection<RadTreeNode> subNodes = GetRadTreeNodes(node.Nodes);
                returnNodes.AddRange(subNodes);
            }
            ReadOnlyCollection<RadTreeNode> readOnlyNodes = new ReadOnlyCollection<RadTreeNode>(returnNodes);
            return readOnlyNodes;
        }
    }
}
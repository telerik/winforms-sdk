using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace RadTreeView_ReadOnly_CS
{
    public partial class Form1 : Form
    {
        RadReadOnlyTreeView RadReadOnlyTreeView1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            RadReadOnlyTreeView1 = new RadReadOnlyTreeView();
            RadReadOnlyTreeView1.Dock = DockStyle.Fill;
            this.radPanel1.Controls.Add(RadReadOnlyTreeView1);

            RadTreeNode node1 = new RadTreeNode("Node1");
            RadTreeNode node2 = new RadTreeNode("Node2");
            RadTreeNode node3 = new RadTreeNode("Node3");
            RadTreeNode node4 = new RadTreeNode("Node4");
            RadTreeNode node5 = new RadTreeNode("Node5");
            RadTreeNode node6 = new RadTreeNode("Node6");
            RadTreeNode node7 = new RadTreeNode("Node7");
            RadTreeNode node8 = new RadTreeNode("Node8");
            RadTreeNode node9 = new RadTreeNode("Node9");
            RadTreeNode node10 = new RadTreeNode("Node10");

            node1.Nodes.Add(node2);
            node1.Nodes.Add(node3);

            node4.Nodes.Add(node5);
            node4.Nodes.Add(node6);

            node6.Nodes.Add(node7);

            RadReadOnlyTreeView1.Nodes.Add(node1);
            RadReadOnlyTreeView1.Nodes.Add(node4);
            RadReadOnlyTreeView1.Nodes.Add(node8);
            RadReadOnlyTreeView1.Nodes.Add(node9);
            RadReadOnlyTreeView1.Nodes.Add(node10);

            RadReadOnlyTreeView1.CheckBoxes = true;
        }

        private void radCheckBox1_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            RadReadOnlyTreeView1.BeginUpdate();
            RadReadOnlyTreeView1.CheckBoxReadOnly = (radCheckBox1.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On);
            RadReadOnlyTreeView1.EndUpdate();
        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

public partial class Form1 : Telerik.WinControls.UI.RadForm
{
    private RadButtonElement m_FilterCancelButton;
    private RadLabelElement m_FilterLabel;

    public Form1()
    {
        InitializeComponent();
        this.Load += new EventHandler(Form1_Load);
    }

    void Form1_Load(object sender, EventArgs e)
    {
        this.radGridView1.EnableFiltering = true;
        this.radGridView1.ShowFilteringRow = true;

        this.radGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.None;
        this.radGridView1.Columns.Add(new GridViewTextBoxColumn("Name"));
        this.radGridView1.Columns.Add(new GridViewDecimalColumn("Value"));

        GridViewRowInfo rowInfo = this.radGridView1.Rows.AddNew();
        rowInfo.Cells[0].Value = "A1";
        rowInfo.Cells[1].Value = 3;
        rowInfo = this.radGridView1.Rows.AddNew();
        rowInfo.Cells[0].Value = "A2";
        rowInfo.Cells[1].Value = 4;
        rowInfo = this.radGridView1.Rows.AddNew();
        rowInfo.Cells[0].Value = "A3";
        rowInfo.Cells[1].Value = 5;
        rowInfo = this.radGridView1.Rows.AddNew();
        rowInfo.Cells[0].Value = "A4";
        rowInfo.Cells[1].Value = 6;
        rowInfo = this.radGridView1.Rows.AddNew();
        rowInfo.Cells[0].Value = "A2";
        rowInfo.Cells[1].Value = 4;
        rowInfo = this.radGridView1.Rows.AddNew();
        rowInfo.Cells[0].Value = "A3";
        rowInfo.Cells[1].Value = 5;
        rowInfo = this.radGridView1.Rows.AddNew();
        rowInfo.Cells[0].Value = "A4";
        rowInfo.Cells[1].Value = 6;

        RadStatusStrip statusBar = new RadStatusStrip();
        statusBar.StatusBarElement.GripStyle = ToolStripGripStyle.Hidden;

        m_FilterCancelButton = new RadButtonElement();
        m_FilterCancelButton.Text = "-";
        m_FilterCancelButton.MouseDown += new MouseEventHandler(m_FilterCancelButton_MouseDown);

        m_FilterLabel = new RadLabelElement();
        m_FilterLabel.Text = " Currently Unfiltered";

        statusBar.Items.Add(m_FilterCancelButton);
        statusBar.Items.Add(m_FilterLabel);

        RadHostItem hostItem = new RadHostItem(statusBar);
        hostItem.MinSize = new Size(0, 25);
        this.radGridView1.GridViewElement.Panel.Children.Insert(1, hostItem);
        Telerik.WinControls.Layouts.DockLayoutPanel.SetDock(hostItem, Telerik.WinControls.Layouts.Dock.Bottom);

        this.radGridView1.FilterExpressionChanged += new GridViewFilterExpressionChangedEventHandler(radGridView1_FilterExpressionChanged);
    }

    void m_FilterCancelButton_MouseDown(object sender, MouseEventArgs e)
    {
        this.radGridView1.FilterDescriptors.Clear();
    }


    void radGridView1_FilterExpressionChanged(object sender, FilterExpressionChangedEventArgs e)
    {
        if (e.FilterExpression.Length > 0)
        {
           m_FilterLabel.Text = e.FilterExpression; 
        }
        else
        {   
            if (m_FilterLabel != null)
            {
                m_FilterLabel.Text = "Currently unfiltered";
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace IndicatingOperations
{
    public partial class MainForm : RadForm
    {
        BackgroundWorker worker;
        DataTable dt;

        public MainForm()
        {
            InitializeComponent();

            worker = new BackgroundWorker();
            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);

            this.radGridView1.DataBindingComplete += new GridViewBindingCompleteEventHandler(radGridView1_DataBindingComplete);
        }

        private void rbtnPrepareDataSource_Click(object sender, EventArgs e)
        {
            this.rbtnPrepareDataSource.Enabled = false;
            this.radWaitingBar1.Visible = true;
            this.radWaitingBar1.StartWaiting();
            worker.RunWorkerAsync();
        }

        private void rbtnBind_Click(object sender, EventArgs e)
        {
            if (this.radGridView1.DataSource == null)
            {
                WaitingForm.ShowForm();
                this.radGridView1.DataSource = dt;
            }
        }

        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            dt = new DataTable();

            DataColumn dc = new DataColumn();
            dc.ColumnName = "ID";
            dt.Columns.Add(dc);

            DataColumn dc2 = new DataColumn();
            dc2.ColumnName = "Name";
            dt.Columns.Add(dc2);

            for (int i = 0; i < 1000000; i++)
            {
                DataRow dr = dt.NewRow();
                dr[0] = i;
                dr[1] = "Name " + i.ToString();
                dt.Rows.Add(dr);
            }
        }

        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.radWaitingBar1.StopWaiting();
            this.radWaitingBar1.Visible = false;
            this.rbtnBind.Enabled = true;
        }

        void radGridView1_DataBindingComplete(object sender, Telerik.WinControls.UI.GridViewBindingCompleteEventArgs e)
        {
            WaitingForm.CloseForm();
        }
    }
}

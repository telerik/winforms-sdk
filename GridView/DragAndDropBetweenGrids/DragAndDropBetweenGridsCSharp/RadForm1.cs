using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace DragAndDropBetweenGrids
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
            leftGrid.ShowGroupPanel = false;
            rightGrid.ShowGroupPanel = false;
            leftGrid.AllowAddNewRow = false;
            rightGrid.AllowAddNewRow = false;
            leftGrid.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            rightGrid.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
        }
        private void ResetGrids()
        {
            leftGrid.DataSource = null;
            leftGrid.Rows.Clear();
            leftGrid.Columns.Clear();
            rightGrid.DataSource = null;
            rightGrid.Rows.Clear();
            rightGrid.Columns.Clear();
        }

        private void btnUnbound_Click(object sender, EventArgs e)
        {
            ResetGrids();
            PrepareUnboundGrid(leftGrid);
            leftGrid.Rows.Add("Carey", "Payette");
            leftGrid.Rows.Add("Michael", "Crump");
            leftGrid.Rows.Add("Jeff", "Fritz");
            PrepareUnboundGrid(rightGrid);
            rightGrid.Rows.Add("Phil", "Japikse");
            rightGrid.Rows.Add("Jesse", "Liberty");
            rightGrid.Rows.Add("Iris", "Classon");
        }

        private void PrepareUnboundGrid(DragAndDropRadGrid grid)
        {
            GridViewTextBoxColumn firstName = new GridViewTextBoxColumn("FirstName", "FirstName");
            firstName.HeaderText = "First Name";
            GridViewTextBoxColumn lastName = new GridViewTextBoxColumn("LastName", "LastName");
            lastName.HeaderText = "Last Name";
            grid.Columns.AddRange(firstName, lastName);
        }

        private void btnBoundObjects_Click(object sender, EventArgs e)
        {
            ResetGrids();
            BindingList<Player> dataList1 = new BindingList<Player>();
            dataList1.Add(new Player() { FirstName = "Carey", LastName = "Payette" });
            dataList1.Add(new Player() { FirstName = "Michael", LastName = "Crump" });
            dataList1.Add(new Player() { FirstName = "Jeff", LastName = "Fritz" });
            BindingList<Player> dataList2 = new BindingList<Player>();
            dataList2.Add(new Player() { FirstName = "Phil", LastName = "Japikse" });
            dataList2.Add(new Player() { FirstName = "Jesse", LastName = "Liberty" });
            dataList2.Add(new Player() { FirstName = "Iris", LastName = "Classon" });
            leftGrid.DataSource = dataList1;
            rightGrid.DataSource = dataList2;
        }

        private void btnBoundDataset_Click(object sender, EventArgs e)
        {
            ResetGrids();
            DataSet ds1 = new DataSet();
            DataTable team1 = new DataTable();
            team1.Columns.Add("First Name", typeof(string));
            team1.Columns.Add("Last Name", typeof(string));
            team1.Rows.Add("Carey", "Payette");
            team1.Rows.Add("Michael", "Crump");
            team1.Rows.Add("Jeff", "Fritz");
            ds1.Tables.Add(team1);
            DataSet ds2 = new DataSet();
            DataTable team2 = new DataTable();
            team2.Columns.Add("First Name", typeof(string));
            team2.Columns.Add("Last Name", typeof(string));
            team2.Rows.Add("Phil", "Japikse");
            team2.Rows.Add("Jesse", "Liberty");
            team2.Rows.Add("Iris", "Classon");
            ds2.Tables.Add(team2);
            leftGrid.DataSource = ds1;
            leftGrid.DataMember = "Table1";
            rightGrid.DataSource = ds2;
            rightGrid.DataMember = "Table1";
        }
    }
    public class Player
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}

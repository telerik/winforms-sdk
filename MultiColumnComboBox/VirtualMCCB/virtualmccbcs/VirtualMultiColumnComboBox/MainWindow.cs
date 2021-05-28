using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Telerik.WinControls.UI;

namespace VirtualMultiColumnComboBox
{
    public partial class MainWindow : Form
    {
        public class Dummy
        {
            public int Id { get; set; }

            public string Name { get; set; }

            public DummysDummy DummysDummy { get; set; }
        }

        public class DummysDummy
        {
            public int Id { get; set; }

            public string Name { get; set; }
        }

        private ObservableCollection<Dummy> ds = new ObservableCollection<Dummy>();

        public MainWindow()
        {
            InitializeComponent();

            for (int i = 0; i < 100000; i++)
            {
                Dummy dummy = new Dummy();
                dummy.Id = i;
                dummy.Name = Generator.GenerateName(Generator.Random.Next(5, 16)) + " " + i;
                dummy.DummysDummy = new DummysDummy
                {
                    Id = i,
                    Name = Generator.GenerateName(Generator.Random.Next(5, 16)) + " " + i
                };

                ds.Add(dummy);
            }

            ds.CollectionChanging += ds_CollectionChanging;

            this.virtualRadMultiColumnComboBox1.LoadDataSourceAsync = false;
            this.virtualRadMultiColumnComboBox1.ValueMember = "DummysDummy.Name";
            this.virtualRadMultiColumnComboBox1.DisplayMember = "DummysDummy";
            this.virtualRadMultiColumnComboBox1.DataSource = this.ds;
            this.virtualRadMultiColumnComboBox1.AutoFilter = true;
            this.virtualRadMultiColumnComboBox1.AutoShowHidePopup = true;
            this.virtualRadMultiColumnComboBox1.SearchType = TrieImplementation.SearchType.Contains;
            this.virtualRadMultiColumnComboBox1.EditorControl.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;

            this.virtualRadMultiColumnComboBox1.SearchCompleted += radMultiColumnComboBox1_SearchCompleted;
            this.virtualRadMultiColumnComboBox1.SearchStarting += radMultiColumnComboBox1_SearchStarting;
            this.virtualRadMultiColumnComboBox1.EditorControlCellValueNeeded += virtualRadMultiColumnComboBox1_EditorControlCellValueNeeded;
            this.virtualRadMultiColumnComboBox1.DataSourceLoaded += virtualRadMultiColumnComboBox1_DataSourceLoaded;
        }

        void virtualRadMultiColumnComboBox1_DataSourceLoaded(object sender, EventArgs e)
        {
            RadMessageBox.Show("LOADED");
        }

        void ds_CollectionChanging(object sender, NotifyCollectionChangingEventArgs e)
        {
        }

        void virtualRadMultiColumnComboBox1_EditorControlCellValueNeeded(object sender, Implementation.EditorControlCellValueNeededEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                e.Value = (e.VirtualDataSource[e.RowIndex] as Dummy).DummysDummy.Name;
            }
        }

        void radMultiColumnComboBox1_SearchStarting(object sender, Implementation.SearchStartingEventArgs e)
        {
        }

        void radMultiColumnComboBox1_SearchCompleted(object sender, Implementation.SearchCompletedEventArgs e)
        {
        }
    }

    public static class Generator
    {
        public static readonly Random Random = new Random();

        public static string GenerateName(int length)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                sb.Append((char)Random.Next('a', 'z' + 1));           
            }

            sb[0] = char.ToUpper(sb[0]);

            return sb.ToString();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using VirtualRadGridViewSortingFiltering.Core;

namespace VirtualRadGridViewSortingFiltering.Form
{
    public partial class Form1 : RadForm
    {
        private BindingList<Dummy> dataSource;
        private Stopwatch stopWatch;
        private VirtualRadGridView grid;
        private RadTextBox textBox;
        private Random rnd;

        public const int RowsCount = 2000000;

        public Form1()
        {
            InitializeComponent();

            this.rnd = new Random();
            this.stopWatch = new Stopwatch();
            this.grid = new VirtualRadGridView
            {
                Parent = this,
                Dock = DockStyle.Fill
            };

            this.textBox = new RadTextBox
            {
                Parent = this,
                Dock = DockStyle.Bottom,
                Enabled = false
            };

            this.dataSource = new BindingList<Dummy>();

            for (int i = 0; i < RowsCount / 2; i++)
            {
                this.dataSource.Add(new Dummy
                    {
                        Id = i,
                        Name = this.GenerateName(),
                        CreationDate = DateTime.Now
                    });

                this.dataSource.Add(new Dummy
                {
                    Id = i,
                    Name = this.GenerateName(),
                    CreationDate = DateTime.Now
                });
            }

            grid.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            grid.VirtualDataSource = this.dataSource;

            this.grid.ItemsSource.OperationStarted += ItemsSource_OperationStarted;
            this.grid.ItemsSource.OperationCompleted += ItemsSource_OperationCompleted;
        }

        private string GenerateName()
        {
            int random = rnd.Next(5, 13);
            char[] chars = new char[random];
            for (int j = 0; j < random; j++)
            {
                chars[j] = ((char)rnd.Next('a', 'z' + 1));
            }

            return new string(chars);
        }

        void ItemsSource_OperationCompleted(object sender, ItemSourceOperationCompletedEventArgs e)
        {
            this.textBox.Text = "Last operation took " + this.stopWatch.Elapsed;
            this.stopWatch.Stop();
        }

        void ItemsSource_OperationStarted(object sender, ItemSourceOperationEventArgs e)
        {
            this.stopWatch.Reset();
            this.stopWatch.Start();
        }
    }

    public class Dummy
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
    }
}

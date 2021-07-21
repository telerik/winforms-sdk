using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls.Themes;
using Telerik.WinControls;

namespace ThemeLoader
{
    public partial class Form1 : RadForm
    {
        public Form1()
        {
            InitializeComponent();
           
            this.radComboBox1.SelectedValueChanged += new EventHandler(radComboBox1_SelectedValueChanged);
            SetComboBoxItems();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += delegate { this.LoadThemeComponents(); };
            BeginInvoke(new MethodInvoker(worker.RunWorkerAsync));
        }

        void LoadThemeComponents()
        {
            new Office2007BlackTheme();
            new Office2007SilverTheme();
            new AquaTheme();
            new BreezeTheme();
            new MiscellaneousTheme();
            new DesertTheme();
            new TelerikTheme();
            new VistaTheme();
        }

        void SetComboBoxItems()
        {
            this.radComboBox1.Items.Add(new RadComboBoxItem("ControlDefault"));
            this.radComboBox1.Items.Add(new RadComboBoxItem("Aqua"));
            this.radComboBox1.Items.Add(new RadComboBoxItem("Vista"));
            this.radComboBox1.Items.Add(new RadComboBoxItem("Telerik"));
            this.radComboBox1.Items.Add(new RadComboBoxItem("Office2007Black"));
            this.radComboBox1.Items.Add(new RadComboBoxItem("Office2007Silver"));
            this.radComboBox1.Items.Add(new RadComboBoxItem("Breeze"));
            this.radComboBox1.Items.Add(new RadComboBoxItem("Desert"));
        }

        void radComboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            ThemeResolutionService.ApplicationThemeName = this.radComboBox1.SelectedText;
        }
    }
}
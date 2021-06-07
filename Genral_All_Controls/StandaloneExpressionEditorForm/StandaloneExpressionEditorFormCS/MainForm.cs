using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace StandaloneRadExpressionEdtiorForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.radButton1.Click += radButton1_Click;
        }

        void radButton1_Click(object sender, EventArgs e)
        {
            StandaloneExpressionEditorForm form = new StandaloneExpressionEditorForm();
            if (form.ShowDialog(this.radTextBox1.Text) == System.Windows.Forms.DialogResult.OK)
            {
                this.radTextBox2.Text = form.ReturnValue;
            }
        }
    }
}

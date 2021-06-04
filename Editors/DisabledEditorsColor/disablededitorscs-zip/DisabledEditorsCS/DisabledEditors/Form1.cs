using System;
using System.Windows.Forms;

namespace DisabledEditors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.myTextBox1.SelectionStart = 0;
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            myTextBox1.Enabled = !myTextBox1.Enabled;
            myRadDateTimePicker1.Enabled = !myRadDateTimePicker1.Enabled;
            myRadMaskedEditBox1.Enabled = !myRadMaskedEditBox1.Enabled;
            myRadSpinEditor1.Enabled = !myRadSpinEditor1.Enabled;
            myRadDropDownList1.Enabled = !myRadDropDownList1.Enabled;
        }
    }
}

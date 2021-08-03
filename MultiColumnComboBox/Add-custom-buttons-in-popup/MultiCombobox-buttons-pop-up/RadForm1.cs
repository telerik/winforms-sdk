using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Layouts;
using Telerik.WinControls.RadControlSpy;
using Telerik.WinControls.UI;

namespace MultiCombobox_buttons_pop_up
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        public RadForm1()
        {
            InitializeComponent();

            FillData();
            this.radMultiColumnComboBox1.EditorControl.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
        }
        private void FillData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("FirstName");
            dt.Columns.Add("LastName");
            dt.Columns.Add("Occupation");
            dt.Columns.Add("StartingDate", typeof(DateTime));
            dt.Columns.Add("IsMarried", typeof(bool));
            dt.Columns.Add("Salary");
            dt.Rows.Add("Sarah", "Blake", "Supplied Manager", new DateTime(2005, 04, 12), true, 3500);
            dt.Rows.Add("Jane", "Simpson", "Security", new DateTime(2008, 12, 03), true, 2000);

            dt.Rows.Add("John", "Peterson", "Consultant", new DateTime(2005, 04, 12), false, 2600);
            dt.Rows.Add("Peter", "Bush", "Cashier", new DateTime(2005, 04, 12), true, 2300);
            dt.Rows.Add("Harry", "Forth", "Agent", new DateTime(205, 04, 12), true, 2000);
            dt.Rows.Add("Mery", "Keneth", "Consultant", new DateTime(205, 04, 12), false, 2100);
            dt.Rows.Add("Jane", "Millan", "Sales", new DateTime(205, 04, 12), false, 2600);
            this.radMultiColumnComboBox1.DataSource = dt;
        }
    }
    public class MyRadMultiColumnComboBox : RadMultiColumnComboBox
    {

        public override string ThemeClassName
        {
            get
            {
                return typeof(RadMultiColumnComboBox).FullName;
            }
        }

        protected override RadMultiColumnComboBoxElement CreateMultiColumnComboBoxElement()
        {
            return new MyRadMultiColumnComboBoxElement();
        }
    }

    public class MyRadMultiColumnComboBoxElement : RadMultiColumnComboBoxElement
    {
        protected override Type ThemeEffectiveType
        {
            get
            {
                return typeof(RadMultiColumnComboBoxElement);
            }
        }

        protected override RadPopupControlBase CreatePopupForm()
        {
            MultiColumnComboPopupForm popupForm = new MyMultiColumnComboPopupForm(this);
            popupForm.SizingMode = SizingMode.UpDownAndRightBottom;
            this.WirePopupFormEvents(popupForm);

            return popupForm;
        }
    }

    public class MyMultiColumnComboPopupForm : MultiColumnComboPopupForm
    {
        internal bool closed;
        private RadButtonElement deleteButton;
        private RadButtonElement addButton;
        private StackLayoutPanel panel;
        RadMultiColumnComboBoxElement element;
        public MyMultiColumnComboPopupForm(RadMultiColumnComboBoxElement element)
            : base(element)
        { this.element = element; }

        public override void ClosePopup(RadPopupCloseReason reason)
        {
            if (base.EditorControl.GridViewElement.ContainsMouse)
            {
                return;
            }
            base.ClosePopup(reason);
        }
        protected override void CreateChildItems(RadElement parent)
        {

            base.CreateChildItems(parent);
            panel = new StackLayoutPanel();
            panel.StretchVertically = false;

            addButton = new RadButtonElement();
            addButton.Text = "AddButton";
            addButton.MinSize = new Size(200, 20);
            addButton.StretchVertically = true;
            addButton.StretchHorizontally = true;
            addButton.Click += this.AddButton_Click;
            panel.Children.Add(addButton);


            deleteButton = new RadButtonElement();
            deleteButton.Text = "DeleteButton";
            deleteButton.MinSize = new Size(200, 20);
            deleteButton.StretchVertically = true;
            deleteButton.StretchHorizontally = true;
            deleteButton.Click += this.DeleteButton_Click;
            panel.Children.Add(deleteButton);
            base.SizingGripDockLayout.Children.Insert(1, this.panel);
            
            DockLayoutPanel.SetDock(this.SizingGrip, Telerik.WinControls.Layouts.Dock.Bottom);
            DockLayoutPanel.SetDock(panel, Telerik.WinControls.Layouts.Dock.Bottom);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            DataEntryForm entryForm = new DataEntryForm(element);
            entryForm.TopMost = true;
            entryForm.Show();
        }
        

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            base.EditorControl.Rows.Remove(base.EditorControl.CurrentRow);
        }
    }
}

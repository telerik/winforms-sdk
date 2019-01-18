using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace GridViewEditDialog
{
    public partial class MainForms : Telerik.WinControls.UI.RadForm
    {
        public MainForms()
        {
            InitializeComponent();

            ThemeResolutionService.ApplicationThemeName = "Fluent";
        }

        public class Student : System.ComponentModel.INotifyPropertyChanged
        {
            int m_id;
            string m_name;
            string m_grade;

            public event PropertyChangedEventHandler PropertyChanged;

            public Student(int m_id, string m_name, string m_grade)
            {
                this.m_id = m_id;
                this.m_name = m_name;
                this.m_grade = m_grade;
            }

            public int Id
            {
                get
                {
                    return m_id;
                }
                set
                {
                    if (this.m_id != value)
                    {
                        this.m_id = value;
                        OnPropertyChanged("Id");
                    }
                }
            }

            public string Name
            {
                get
                {
                    return m_name;
                }
                set
                {
                    if (this.m_name != value)
                    {
                        this.m_name = value;
                        OnPropertyChanged("Name");
                    }
                }
            }

            public string Grade
            {
                get
                {
                    return m_grade;
                }
                set
                {
                    if (this.m_grade != value)
                    {
                        this.m_grade = value;
                        OnPropertyChanged("Grade");
                    }
                }
            }

            protected virtual void OnPropertyChanged(string propertyName)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                }
            }
        }

        BindingList<Student> collectionOfStudents = new BindingList<Student>();

        private void RadForm1_Load(object sender, EventArgs e)
        {
            collectionOfStudents.Add(new Student(0, "Peter", "A+"));
            collectionOfStudents.Add(new Student(1, "John", "D-"));
            collectionOfStudents.Add(new Student(2, "Antony", "B+"));
            collectionOfStudents.Add(new Student(3, "David", "A-"));
            collectionOfStudents.Add(new Student(4, "John", "D-"));
            this.radGridView1.DataSource = collectionOfStudents;

            GridViewCommandColumn editColumn = new GridViewCommandColumn("Edit");
            editColumn.UseDefaultText = true;
            editColumn.DefaultText = "Edit";
            radGridView1.MasterTemplate.Columns.Add(editColumn);

            this.radGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            this.radGridView1.CommandCellClick += radGridView1_CommandCellClick;
        }

        private void radGridView1_CommandCellClick(object sender, GridViewCellEventArgs e)
        {
            EditForm f = new EditForm(this.radGridView1.CurrentRow.DataBoundItem as Student);
            f.StartPosition = FormStartPosition.Manual;
            f.Location = new Point(this.Location.X + this.Size.Width / 2 - f.Size.Width / 2, this.Location.Y + this.Size.Height / 2 - f.Size.Height / 2);
            f.ShowDialog();
        }
    }
}
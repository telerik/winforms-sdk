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

namespace IDataErrorInfoExmapleCS
{
    public partial class Form1 : RadForm
    {
        private bool m_ShowCellImage;

        public Form1()
        {
            InitializeComponent();
            radGridView1.CellFormatting += new CellFormattingEventHandler(radGridView1_CellFormatting);
            RadCheckBoxIncludeCellImage.ToggleStateChanged += new StateChangedEventHandler(RadCheckBoxIncludeCellImage_ToggleStateChanged);
            RadCheckBoxShowRowHeaderColumn.ToggleStateChanged += new StateChangedEventHandler(RadCheckBoxShowRowHeaderColumn_ToggleStateChanged);
            RadDropDownTextImageRelation.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(RadDropDownTextImageRelation_SelectedIndexChanged);
            RadPanelBorderColor.BackColorChanged += new EventHandler(RadPanelBorderColor_BackColorChanged);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Somethings somethings = new Somethings();
                this.radGridView1.BeginUpdate();
                this.radGridView1.DataSource = new BindingList<Something>(somethings.GetSomethings());
                this.radGridView1.MasterTemplate.BestFitColumns();
                this.radGridView1.EndUpdate();
                this.PopulateTextImagerelationDropDown();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PopulateTextImagerelationDropDown()
        {
            foreach (TextImageRelation relation in Enum.GetValues(typeof(TextImageRelation)))
            {
                this.RadDropDownTextImageRelation.Items.Add(relation.ToString());
            }
            if (this.RadDropDownTextImageRelation.Items.Count > 0)
            {
                this.RadDropDownTextImageRelation.SelectedIndex = 0;
            }
        }

        private void radGridView1_CellFormatting(System.Object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
        {
            GridDataCellElement cell = e.CellElement as GridDataCellElement;
            if (cell != null)
            {
                if (cell.ContainsErrors)
                {
                    cell.DrawBorder = true;
                    cell.BorderBoxStyle = BorderBoxStyle.SingleBorder;
                    cell.BorderWidth = 2;
                    cell.BorderColor = this.RadPanelBorderColor.BackColor;
                    if (m_ShowCellImage)
                    {
                        cell.Image = this.imageList1.Images[0];
                        // following line ensures cell image is placed consistantly
                        if (string.IsNullOrEmpty(e.CellElement.Text))
                            e.CellElement.Text = " ";

                        foreach (TextImageRelation relation in Enum.GetValues(typeof(TextImageRelation)))
                        {
                            if (string.Equals(this.RadDropDownTextImageRelation.SelectedItem.Text, relation.ToString()))
                            {
                                cell.TextImageRelation = relation;
                                break;
                            }
                        }
                        if (cell.TextImageRelation == TextImageRelation.TextBeforeImage)
                        {
                            cell.ImageAlignment = ContentAlignment.MiddleRight;
                        }
                        else if (cell.TextImageRelation == TextImageRelation.ImageBeforeText)
                        {
                            cell.ImageAlignment = ContentAlignment.MiddleLeft;
                        }
                    }
                    else
                    {
                        cell.Image = null;
                    }
                }
                else
                {
                    cell.ResetValue(LightVisualElement.DrawBorderProperty, ValueResetFlags.Local);
                    cell.ResetValue(LightVisualElement.BorderBoxStyleProperty, ValueResetFlags.Local);
                    cell.ResetValue(LightVisualElement.BorderWidthProperty, ValueResetFlags.Local);
                    cell.ResetValue(LightVisualElement.BorderColorProperty, ValueResetFlags.Local);
                    cell.Image = null;
                }
            }
        }

        private void RadButtonBorderColor_Click_1(System.Object sender, System.EventArgs e)
        {
            if (this.radColorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.RadPanelBorderColor.BackColor = this.radColorDialog1.SelectedColor;
            }
        }

        private void RadCheckBoxIncludeCellImage_ToggleStateChanged(System.Object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            this.RadDropDownTextImageRelation.Enabled = (RadCheckBoxIncludeCellImage.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On);
            m_ShowCellImage = (RadCheckBoxIncludeCellImage.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On);
            this.radGridView1.MasterTemplate.Refresh();
            this.radGridView1.MasterTemplate.BestFitColumns();
        }

        private void RadCheckBoxShowRowHeaderColumn_ToggleStateChanged(System.Object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            this.radGridView1.ShowRowHeaderColumn = (this.RadCheckBoxShowRowHeaderColumn.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On);
        }

        private void RadDropDownTextImageRelation_SelectedIndexChanged(System.Object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            this.radGridView1.TableElement.Update(GridUINotifyAction.RowHeightChanged);
            this.radGridView1.Refresh();
            this.radGridView1.MasterTemplate.BestFitColumns();
        }

        private void RadPanelBorderColor_BackColorChanged(System.Object sender, System.EventArgs e)
        {
            this.radGridView1.MasterTemplate.Refresh();
        }
    }

    public class Somethings
    {
        public Somethings()
        {
        }

        public System.Collections.Generic.List<Something> GetSomethings()
        {
            System.Collections.Generic.List<Something> somethingList = new System.Collections.Generic.List<Something>();
            somethingList.Add(new Something("", "Blank Name Description"));
            somethingList.Add(new Something("Name", "Name Description"));
            somethingList.Add(new Something("Name1", "Description1"));
            somethingList.Add(new Something("Name2", "Description2"));
            somethingList.Add(new Something("Name3", "Description3"));
            somethingList.Add(new Something("Name4", "Description4"));
            return somethingList;
        }
    }

    public class Something : IDataErrorInfo
    {
        private string m_Name;

        private string m_Description;

        public Something()
        {
        }

        public Something(string name, string description)
        {
            m_Name = name;
            m_Description = description;
        }

        public string Name
        {
            get { return m_Name; }
            set { m_Name = value; }
        }

        public string Description
        {
            get { return m_Description; }
            set { m_Description = value; }
        }

        public string Error
        {
            get
            {
                if (!IsNameValid())
                {
                    return "Cannot be 'Name' or Empty";
                }
                else
                {
                    return "";
                }
            }
        }

        public string this[string columnName]
        {
            get
            {
                if (columnName == "Name" && !IsNameValid())
                {
                    return "Not a valid value";
                }
                else
                {
                    return "";
                }
            }
        }

        private bool IsNameValid()
        {
            if (string.IsNullOrEmpty(this.Name))
            {
                return false;
            }
            if (string.Equals(this.Name.ToUpperInvariant(), "NAME"))
            {
                return false;
            }
            return true;
        }
    }
}
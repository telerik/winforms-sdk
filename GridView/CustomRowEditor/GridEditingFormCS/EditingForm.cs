using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using System.Collections;
using System.IO;

namespace GridEditingForm
{
    public partial class EditingForm : Form
    {
        //members
        private GridViewRowInfo currentRow;
        private Hashtable addedControls;
        RadButton radButtonUpdate;
        RadButton radButtonCancel;

        public EditingForm()
        {
            InitializeComponent();
            this.addedControls = new Hashtable();

            radButtonUpdate = new RadButton();
            radButtonUpdate.Text = "Update";
            radButtonUpdate.Size = new Size(75, 23);
            radButtonUpdate.Click += new EventHandler(radButtonUpdate_Click);
            radButtonUpdate.EndInit();


            radButtonCancel = new RadButton();
            radButtonCancel.Text = "Cancel";
            radButtonCancel.Size = new Size(75, 23);
            radButtonCancel.Click += new EventHandler(radButtonCancel_Click);
            radButtonCancel.EndInit();
        }     

        /// <summary>
        ///fill form with controls depend cells from currentRow 
        /// </summary>
        /// <param name="currentRow">row with cell for building form</param>
        public void BuildEditFormFromRow( GridViewRowInfo currentRow )
        {
            this.addedControls.Clear();

            this.CurrentRow = currentRow;

            if (this.CurrentRow != null)            
            {
                int yOffset = 20;
                foreach (GridViewCellInfo cell in currentRow.Cells)
                {
                    Control ctrl = null;
                    object cellValue = cell.Value;
                    
                    #region create controls depend from cell type

                    if (cell.ColumnInfo is GridViewCommandColumn)
                    {
                        continue;
                    }
                    else if (cell.ColumnInfo is GridViewImageColumn)
                    {
                        ctrl = new PictureBox();
                        byte[] bytes = (byte[])cell.Value;
   
                        //For old MS pictures in Northwind
                        System.IO.MemoryStream ms = new System.IO.MemoryStream();
                        
                        // 78 is the size of the OLE header for Northwind images.
                        int offset = 78;
                        ms.Write(bytes, offset, bytes.Length - offset);

                        Bitmap bmp = new Bitmap(ms);
                        ms.Close();

                        ((PictureBox)ctrl).Image = bmp;
                    }
                    else if (cell.ColumnInfo is GridViewCheckBoxColumn)
                    {
                        ctrl = new RadCheckBox();
                        ((RadCheckBox)ctrl).ThemeName = "ControlDefault";
                        ((RadCheckBox)ctrl).EndInit();

                        if ((bool)cellValue == true)
                            ((RadCheckBox)ctrl).ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
                        else
                            ((RadCheckBox)ctrl).ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off;
                    }
                    else if (cell.ColumnInfo is GridViewDateTimeColumn)
                    {
                        ctrl = new RadDateTimePicker();
                        ((RadDateTimePicker)ctrl).ThemeName = "ControlDefault";
                        ((RadDateTimePicker)ctrl).EndInit();
                        ((RadDateTimePicker)ctrl).Value = (DateTime)cellValue;
                    }
                    else if (cell.ColumnInfo is GridViewDecimalColumn)
                    {
                        ctrl = new RadSpinEditor();
                        ((RadSpinEditor)ctrl).ThemeName = "ControlDefault";
                        ((RadSpinEditor)ctrl).EndInit();
                        ((RadSpinEditor)ctrl).Value = decimal.Parse(cellValue.ToString());
                    }
                    else
                    {
                        ctrl = new RadTextBox();
                        ((RadTextBox)ctrl).ThemeName = "ControlDefault";
                        ((RadTextBox)ctrl).EndInit();
                        ((RadTextBox)ctrl).Text = cellValue.ToString();
                    }

                    if (cell.ColumnInfo.ReadOnly)
                    {
                        ctrl.Enabled = false;
                    }
                    #endregion
                    #region put control and label in form

                    Point location = new Point( 0, yOffset );
                    Label label = new Label();
                    this.Controls.Add( label );
                    
                    label.Location = location;
                    label.Text = string.Format("{0}:",cell.ColumnInfo.FieldName );

                    this.Controls.Add( ctrl );

                    //this cell point to db layer
                    GridViewCellInfo dbCell = cell;
                    this.addedControls.Add( ctrl, dbCell );//Save pair in hashtable- controls from forms and associated cell to this  controls

                    location = new Point( label.Width + 10, yOffset );
                    ctrl.Location = location;
                    yOffset += ctrl.Size.Height + 8;//vertical offset for next control

                    #endregion
                }                
            }

            Control ctrl1 = this.Controls[this.Controls.Count - 1] as Control;

            radButtonCancel.Location = new Point(this.Size.Width - radButtonCancel.Size.Width, ctrl1.Location.Y + ctrl1.Size.Height + 10);
            this.Controls.Add(radButtonCancel);

            radButtonUpdate.Location = new Point(radButtonCancel.Location.X - radButtonUpdate.Size.Width - 5, ctrl1.Location.Y + ctrl1.Size.Height + 10);
            this.Controls.Add(radButtonUpdate);
        }

        //get or set the current row
        public GridViewRowInfo CurrentRow
        {
            get { return currentRow; }
            set { currentRow = value; }
        }

        private void radButtonUpdate_Click( object sender, EventArgs e )
        {
            UpdateRow();
            this.Close();
        }

        public void UpdateRow()
        {
            //CurrentRow.ViewInfo.ViewTemplate.BeginUpdate();
            foreach (DictionaryEntry de in this.addedControls)
            {                
                Control ctrl = de.Key as Control;
                GridViewCellInfo dbCell = de.Value as GridViewCellInfo;

                if (ctrl is RadCheckBox)
                {                    
                    dbCell.Value = ((RadCheckBox)ctrl).ToggleState == Telerik.WinControls.Enumerations.ToggleState.On;
                }
                else if (ctrl is RadDateTimePicker)
                {                 
                    dbCell.Value = ((RadDateTimePicker)ctrl).Value;
                }
                else if (ctrl is RadSpinEditor)
                {
                    dbCell.Value = ((RadSpinEditor)ctrl).Value;
                }
                else if (ctrl is RadTextBox)
                {
                    dbCell.Value = ((RadTextBox)ctrl).Text;
                }                
            }
            //this.CurrentRow.ViewInfo.ViewTemplate.EndUpdate();            
        }

        private void radButtonCancel_Click( object sender, EventArgs e )
        {
            this.Close();
        }
    }
}
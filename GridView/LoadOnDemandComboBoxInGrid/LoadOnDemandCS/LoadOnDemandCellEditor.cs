using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using Telerik.WinControls.UI;

namespace SampleApp
{
    public class LoadOnDemandCellEditor : RadMultiColumnComboBoxElement
    {
        private const int MinDropDownWidth = 320;
        private const int ShortNameWidth = 25;
        private const int GridOffset = 70;
        private const int TimerInterval = 425;
        private const string ItemInfoTableName = "ITEMS";

        private System.Timers.Timer _timer;

        private bool _showDropDown;

        private bool ShowDropDown
        {
            get
            {
                return _showDropDown;
            }
            set
            {
                //This property can be updated on a background thread, so we need to ensure thread-safety
                lock (this)
                {
                    _showDropDown = value;
                }
            }
        }

        private bool _newItemsLoaded;

        private bool NewItemsLoaded
        {
            get
            {
                return _newItemsLoaded;
            }
            set
            {
                //This property can be updated on a background thread, so we need to ensure thread-safety
                lock (this)
                {
                    _newItemsLoaded = value;
                }
            }
        }

        private string _currentText = null;

        private string CurrentText
        {
            get
            {
                return _currentText;
            }
            set
            {
                _currentText = value;
            }
        }

        public LoadOnDemandCellEditor(object text, int columnWidth, RadGridView ownerGrid)
            : base()
        {
            InitializeCellEditor(text, columnWidth, ownerGrid);
        }

        //Initialize the cell editor (set properties and load matching data)
        private void InitializeCellEditor(object text, int columnWidth, RadGridView ownerGrid)
        {
            RadGridView grid = null;

            if (!(text is DBNull) && !(string.IsNullOrEmpty(text.ToString())))
            {
                CurrentText = text.ToString();
            }

            this.DisplayMember = "COUNTRY";
            this.ValueMember = "COUNTRY";
            this.Virtualized = false;

            //Make sure the drop down is at least minDropDownWidth
            if (columnWidth > MinDropDownWidth)
            {
                this.DropDownWidth = columnWidth;
            }
            else
            {
                this.DropDownWidth = MinDropDownWidth;
            }

            grid = this.EditorControl;

            //Setup the grid that is displayed in the drop down list
            InitializeGrid(ref grid, this.DropDownWidth);

            //Only load data if we have at least 3 characters
            if (CurrentText != null && CurrentText.Length >= 3)
            {
                GetMatchingItems_AsyncBegin(CurrentText, false);

                //Text of the combo gets cleared when the items are loaded, so make sure to set it here
                this.TextBoxElement.Text = CurrentText;
            }

            //KeyUp and KeyDown events will allow us to load matching data on-demand
            this.KeyDown += DropDown_KeyDown;
            this.KeyUp += DropDown_KeyUp;

            InitializeTimer(ownerGrid);
        }

        //Configure the grid that is displayed within the drop down list.
        private void InitializeGrid(ref RadGridView grid, int gridWidth)
        {
            GridViewTextBoxColumn gridTextBoxColumn = null;

            //Set the grid to fill the drop down list
            grid.Width = gridWidth;

            grid.AutoSizeRows = true;
            grid.VirtualMode = false;

            grid.MasterTemplate.AutoGenerateColumns = false;
            grid.MasterTemplate.ShowColumnHeaders = false;
            grid.MasterTemplate.AllowColumnResize = false;
            grid.MasterTemplate.AllowRowResize = false;

            grid.MasterTemplate.Columns.Clear();

            gridTextBoxColumn = CreateGridTextBoxColumn("SHORTNAME", "SHORTNAME", "SHORTNAME");
            gridTextBoxColumn.Width = ShortNameWidth;
            grid.MasterTemplate.Columns.Add(gridTextBoxColumn);

            gridTextBoxColumn = CreateGridTextBoxColumn("COUNTRY", "COUNTRY", "COUNTRY");

            //Set the column to fill the remaining space in the drop down
            gridTextBoxColumn.Width = gridWidth - ShortNameWidth - GridOffset;
            gridTextBoxColumn.WrapText = true;
            grid.MasterTemplate.Columns.Add(gridTextBoxColumn);
        }

        //Initialize the Timer that is used to buffer the requests to the web service. So instead of firing
        //off a request on every keystroke, we will build in a short wait to make sure the user is done typing.
        private void InitializeTimer(RadGridView ownerGrid)
        {
            _timer = new System.Timers.Timer();
            _timer.Interval = TimerInterval;

            //The GridViewMultiComboBoxElement does not implement the InvokeRequired property or Invoke() method.
            //These are needed to update a control that was created on another thread. So we will need to
            //synchronize the timer with the another control so that we can update the UI in the timers Elasped
            //event handler, since the timer runs on a background thread. We can't access the grid that hosts this
            //control from the control itself, so we us a reference to the grid that is passed in the constructor.
            _timer.SynchronizingObject = ownerGrid;

            _timer.Elapsed += Timer_Elapsed;
        }

        //Make an asynchronous call into the web service to get items that match the text that is passed in
        private void GetMatchingItems_AsyncBegin(string text, bool showDropDownFlag)
        {
            using (localhost.Service ws = new localhost.Service())
            {
                ShowDropDown = showDropDownFlag;
                ws.GetMatchingItemsCompleted += GetMatchingItems_AsyncCompleted;
                ws.GetMatchingItemsAsync(text);
            }
        }

        //Asynchronous callback event handler for the GetMatchingItemsAsync call to the web service
        private void GetMatchingItems_AsyncCompleted(object sender, localhost.GetMatchingItemsCompletedEventArgs e)
        {
            RadGridView grid = null;
            DataSet returnDataSet = null;
            DataTable itemInfo = null;

            if (e.Error != null || e.Result == null)
            {
                //WS call errored out, or nothing was returned
                return;
            }

            returnDataSet = (DataSet)e.Result;
            itemInfo = returnDataSet.Tables[ItemInfoTableName];

            grid = this.EditorControl;
            grid.DataSource = itemInfo;

            if (ShowDropDown)
            {
                this.ShowPopup();
            }

            NewItemsLoaded = true;
        }

        //Handles the KeyDown event for the drop down editor.
        private void DropDown_KeyDown(object sender, KeyEventArgs e)
        {
            //Store the current text so that we can tell if it has changed in the KeyUp event.
            CurrentText = this.Text;

            //If the down key was pressed, there are items loaded in the drop down and an item has not already
            //been selected, then force the selection. This is to workaround an issue where pressing the down
            //key would not force focus to the grid (allowing the user to scroll through the items).
            if (e.KeyCode == Keys.Down)
            {
                if (this.EditorControl.Rows.Count > 0 && NewItemsLoaded == true)
                {
                    this.SelectedIndex = 0;
                    this.ShowPopup();
                }

                //Reset NewItemsLoaded for next iteration
                NewItemsLoaded = false;
            }
        }

        //Handles the KeyUp event for the drop down editor. We load any matching items.
        private void DropDown_KeyUp(object sender, KeyEventArgs e)
        {
            //Force the timer to stop. We will only start the timer if the text is valid
            _timer.Stop();

            //Escape navigation keys (ex. up/down arrow) so we don't reload the drop down when the
            //user scrolls through the items in the grid.
            switch (e.KeyCode)
            {
                case Keys.Up:
                case Keys.Down:
                    return;
            }

            //Just exit if the text has not changed (user could have pressed F1, CTRL, SHIFT, etc.)
            if (CurrentText == this.Text)
            {
                return;
            }

            if (!(string.IsNullOrEmpty(this.Text)))
            {
                //Restart timer
                _timer.Start();
            }
            else
            {
                //Not text, close drop down
                this.ClosePopup();
            }
        }

        //This event fires after the specified Timer.Interval has passed.
        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            _timer.Stop();
            GetMatchingItems_AsyncBegin(this.Text, true);
        }

        //Generic function to create a gridViewTextBoxColumn with common attributes set
        private GridViewTextBoxColumn CreateGridTextBoxColumn(string Name, string fieldName, string headerText)
        {
            GridViewTextBoxColumn gridViewTextBoxColumn = new GridViewTextBoxColumn();

            gridViewTextBoxColumn.Name = Name;
            gridViewTextBoxColumn.FieldName = fieldName;
            gridViewTextBoxColumn.HeaderText = headerText;
            gridViewTextBoxColumn.ReadOnly = true;
            gridViewTextBoxColumn.HeaderTextAlignment = ContentAlignment.BottomLeft;

            return gridViewTextBoxColumn;
        }

        //Fires when the cell is moved out of edit mode. Perform cleanup.
        public override bool EndEdit()
        {
            _timer.Stop();
            _timer.Dispose();
            return base.EndEdit();
        }
    }
}
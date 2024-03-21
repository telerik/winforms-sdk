using System.ComponentModel;
using Telerik.WinControls.UI;
using System;

namespace GridView
{
    public class RadGridViewDynamicSummary : Telerik.WinControls.UI.RadGridView
    {
        private CurrentColumnTypeSummary m_CurrentColumnTypeSummary;
        private GridViewDateTimeColumn m_GroupSummaryDateTimeColumn;
        private GridViewDecimalColumn m_GroupSummaryDecimalColumn;
        private GridViewSummaryItem m_Summary;
        private GridViewSummaryRowItem m_SummaryRowItem;
        private AggregateFunction m_AggregateFunction = AggregateFunction.Count;
        private SummaryRowPosition m_SummaryRowPosition = SummaryRowPosition.Bottom;

        private RadDropDownMenu m_ContextMenu = new RadDropDownMenu();

        public delegate void DynamicGroupSummaryChangedEventHandler(object sender, DynamicGroupSummaryRowChangedEventArgs e);
        public event DynamicGroupSummaryChangedEventHandler DynamicGroupSummaryChanged;

        public RadGridViewDynamicSummary()
            : base()
        {
            this.ThemeClassName = "Telerik.WinControls.UI.RadGridView";
            this.ContextMenuOpening += new ContextMenuOpeningEventHandler(this.RadGridView_ContextMenuOpening);
        }

        /// <summary>
        /// Enable (add) a dynamic group summary row for a GridViewDateTimeColumn
        /// </summary>
        /// <param name="startingFunction">the starting aggregate function to use. E.g. Count</param>
        /// <param name="column">The GridViewDateTimeColumn to apply the group summary to</param>
        /// <param name="summaryRowPosition">specifies the summary row position</param>
        /// <remarks>Avg and Sum are not allowed on this type</remarks>

        public void EnableDynamicRowSummary(AggregateFunction startingFunction, GridViewDateTimeColumn column, SummaryRowPosition summaryRowPosition)
        {
            if (DynamicSummarySupport.GetEnumAllowOnDateTimeColumn(startingFunction) == false)
            {
                throw new InvalidEnumArgumentException("This Aggregate Function is not available for this method");
            }
            Disable();
            m_CurrentColumnTypeSummary = CurrentColumnTypeSummary.DateTime;
            this.m_GroupSummaryDecimalColumn = null;
            this.m_AggregateFunction = startingFunction;
            this.m_GroupSummaryDateTimeColumn = column;
            this.m_SummaryRowPosition = summaryRowPosition;
            SetUp();
        }

        /// <summary>
        /// Enable (add) a dynamic group summary row for a GridViewDecimalColumn
        /// </summary>
        /// <param name="startingFunction">the starting aggregate function to use. E.g. Count</param>
        /// <param name="column">The GridViewDecimalColumn to apply the group summary to</param>
        /// <param name="summaryRowPosition">specifies the summary row position</param>
        public void EnableDynamicRowSummary(AggregateFunction startingFunction, GridViewDecimalColumn column, SummaryRowPosition summaryRowPosition)
        {
            Disable();
            m_CurrentColumnTypeSummary = CurrentColumnTypeSummary.Deciaml;
            this.m_GroupSummaryDateTimeColumn = null;
            this.m_AggregateFunction = startingFunction;
            this.m_GroupSummaryDecimalColumn = column;
            this.m_SummaryRowPosition = summaryRowPosition;
            SetUp();
        }


        /// <summary>Disables (removes) the group summary row</summary>
        public void DisableDynamicRowSummary()
        {
            Disable();

            DynamicGroupSummaryRowChangedEventArgs args = new DynamicGroupSummaryRowChangedEventArgs(null, m_SummaryRowPosition, m_AggregateFunction, false);
            if (DynamicGroupSummaryChanged != null)
            {
                DynamicGroupSummaryChanged(this, args);
            }
        }

        /// <summary>Disables (removes) the group summary row</summary>
        /// <remarks>Private version of DisableDynamicRowSummary so we don't fire the DynamicGroupSummaryChanged when calling internally</remarks>
        private void Disable()
        {
            if (this.m_SummaryRowPosition == SummaryRowPosition.Top)
            {
                base.SummaryRowsTop.Clear();
            }
            else
            {
                base.SummaryRowsBottom.Clear();
            }
            this.m_ContextMenu.Items.Clear();
        }

        /// <summary>Sets up the dynamic group summary row and context menus</summary>
        private void SetUp()
        {
            string summarytext = DynamicSummarySupport.GetEnumDescription(m_AggregateFunction);

            if (m_CurrentColumnTypeSummary == CurrentColumnTypeSummary.DateTime)
            {
                m_Summary = new GridViewSummaryItem(m_GroupSummaryDateTimeColumn.HeaderText, summarytext + "[" + m_GroupSummaryDateTimeColumn.HeaderText + "] is: {0}", DynamicSummarySupport.AggregateFunctionToGridAggregateFunction(m_AggregateFunction));
            }
            else
            {
                m_Summary = new GridViewSummaryItem(m_GroupSummaryDecimalColumn.HeaderText, summarytext + "[" + m_GroupSummaryDecimalColumn.HeaderText + "] is: {0}", DynamicSummarySupport.AggregateFunctionToGridAggregateFunction(m_AggregateFunction));
            }

            m_SummaryRowItem = new GridViewSummaryRowItem();
            m_SummaryRowItem.Add(m_Summary);

            if (this.m_SummaryRowPosition == SummaryRowPosition.Top)
            {
                base.MasterTemplate.SummaryRowsTop.Add(m_SummaryRowItem);
            }
            else
            {
                base.MasterTemplate.SummaryRowsBottom.Add(m_SummaryRowItem);
            }

            foreach (AggregateFunction func in Enum.GetValues(typeof(AggregateFunction)))
            {
                RadMenuItem menuItem = new RadMenuItem(func.ToString());

                bool addMenu = true;
                if (m_CurrentColumnTypeSummary == CurrentColumnTypeSummary.DateTime)
                {
                    addMenu = DynamicSummarySupport.GetEnumAllowOnDateTimeColumn(func);
                }
                if (addMenu)
                {
                    m_ContextMenu.Items.Add(menuItem);
                    menuItem.Click += MenuItem_Click;
                    menuItem.CheckOnClick = true;
                    if (string.Equals(m_AggregateFunction.ToString(), func.ToString()))
                    {
                        menuItem.IsChecked = true;
                    }
                }
            }

            DynamicGroupSummaryRowChangedEventArgs args = null;
            if (m_CurrentColumnTypeSummary == CurrentColumnTypeSummary.DateTime)
            {
                args = new DynamicGroupSummaryRowChangedEventArgs(m_GroupSummaryDateTimeColumn, m_SummaryRowPosition, m_AggregateFunction, true);
            }
            else
            {
                args = new DynamicGroupSummaryRowChangedEventArgs(m_GroupSummaryDecimalColumn, m_SummaryRowPosition, m_AggregateFunction, true);
            }
            if (DynamicGroupSummaryChanged != null)
            {
                DynamicGroupSummaryChanged(this, args);
            }

        }

        /// <summary>
        /// Handles the context menu click and changes the group summary accordingly
        /// </summary>
        /// <param name="sender">the sender (RadMenuItem)</param>
        /// <param name="e">The event arguments</param>

        private void MenuItem_Click(object sender, EventArgs e)
        {
            RadMenuItem menuItem = (RadMenuItem)sender;
            string summarytext = "";
            AggregateFunction useThisFunction = default(AggregateFunction);
            foreach (AggregateFunction func in Enum.GetValues(typeof(AggregateFunction)))
            {
                if (string.Equals(func.ToString(), menuItem.Text))
                {
                    this.m_AggregateFunction = func;
                    summarytext = DynamicSummarySupport.GetEnumDescription(func);
                    useThisFunction = func;
                }
            }

            foreach (RadMenuItem menu in this.m_ContextMenu.Items)
            {
                if (!string.Equals(menu.Text, menuItem.Text))
                {
                    menu.IsChecked = false;
                }
            }
            if (this.m_SummaryRowPosition == SummaryRowPosition.Top)
            {
                base.SummaryRowsTop.Clear();
            }
            else
            {
                base.SummaryRowsBottom.Clear();
            }

            if (m_CurrentColumnTypeSummary == CurrentColumnTypeSummary.DateTime)
            {
                m_Summary = new GridViewSummaryItem(m_GroupSummaryDateTimeColumn.HeaderText, summarytext + "[" + m_GroupSummaryDateTimeColumn.HeaderText + "] is: {0}", DynamicSummarySupport.AggregateFunctionToGridAggregateFunction(m_AggregateFunction));
            }
            else
            {
                m_Summary = new GridViewSummaryItem(m_GroupSummaryDecimalColumn.HeaderText, summarytext + "[" + m_GroupSummaryDecimalColumn.HeaderText + "] is: {0}", DynamicSummarySupport.AggregateFunctionToGridAggregateFunction(m_AggregateFunction));
            }

            m_SummaryRowItem = new GridViewSummaryRowItem();
            m_SummaryRowItem.Add(m_Summary);
            if (this.m_SummaryRowPosition == SummaryRowPosition.Top)
            {
                base.MasterTemplate.SummaryRowsTop.Add(m_SummaryRowItem);
            }
            else
            {
                base.MasterTemplate.SummaryRowsBottom.Add(m_SummaryRowItem);
            }

            DynamicGroupSummaryRowChangedEventArgs args = null;
            if (m_CurrentColumnTypeSummary == CurrentColumnTypeSummary.DateTime)
            {
                args = new DynamicGroupSummaryRowChangedEventArgs(m_GroupSummaryDateTimeColumn, m_SummaryRowPosition, useThisFunction, true);
            }
            else
            {
                args = new DynamicGroupSummaryRowChangedEventArgs(m_GroupSummaryDecimalColumn, m_SummaryRowPosition, useThisFunction, true);
            }
            if (DynamicGroupSummaryChanged != null)
            {
                DynamicGroupSummaryChanged(sender, args);
            }

        }

        /// <summary>Gets the GridViewDecimalColumn that should be used for dynamic group summary</summary>
        [Description("Gets the GridViewDecimalColumn that should be used for dynamic group summary")]
        [Browsable(true)]
        [ReadOnly(true)]
        public Telerik.WinControls.UI.GridViewDataColumn GroupSummaryColumn
        {
            get
            {
                if (m_CurrentColumnTypeSummary == CurrentColumnTypeSummary.Deciaml)
                {
                    return m_GroupSummaryDecimalColumn;
                }
                else
                {
                    return m_GroupSummaryDateTimeColumn;
                }
            }
        }

        /// <summary>Gets the current aggregate function</summary>
        [Description("gets the current aggregate function")]
        [Browsable(true)]
        [ReadOnly(true)]
        public AggregateFunction CurrentAggregateFunction
        {
            get { return m_AggregateFunction; }
        }

        /// <summary>
        /// Context Menu Opening. Assigns the context mmenu if this is the summary cell
        /// </summary>
        /// <param name="sender">the sender</param>
        /// <param name="e">the event arguments</param>
        private void RadGridView_ContextMenuOpening(System.Object sender, Telerik.WinControls.UI.ContextMenuOpeningEventArgs e)
        {
            if (e.ContextMenuProvider is GridSummaryCellElement)
            {
                e.ContextMenu = m_ContextMenu;
            }
        }

        /// <summary>the type of column currently being used</summary>
        private enum CurrentColumnTypeSummary
        {
            Deciaml,
            DateTime
        }

        public override string ThemeClassName
        {
            get
            {
                return typeof(RadGridView).FullName;
            }
        }
    }

}




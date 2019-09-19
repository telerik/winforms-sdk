using System;
using System.Collections.Generic;
using System.Data;
using Telerik.WinControls.UI;

namespace _1414148
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        DataTable master = new DataTable();
        DataTable child = new DataTable();
        public RadForm1()
        {
            InitializeComponent();
            radGridView1.UseScrollbarsInHierarchy = true;

            master.Columns.Add("ID", typeof(int));
            master.Columns.Add("F_ID", typeof(int));
            master.Columns.Add("test", typeof(string));

            child.Columns.Add("F_ID", typeof(int));
            child.Columns.Add("test", typeof(string));

            for (int i = 0; i < 100; i++)
            {
                master.Rows.Add(i, i % 2, "Row " + i);
                child.Rows.Add(i % 2, "Child " + i);
            }

            radGridView1.DataSource = master;
            GridViewTemplate template = new GridViewTemplate();
            template.DataSource = child;
            radGridView1.MasterTemplate.Templates.Add(template);

            GridViewRelation relation = new GridViewRelation(radGridView1.MasterTemplate);
            relation.ChildTemplate = template;
            relation.RelationName = "Test";
            relation.ParentColumnNames.Add("F_ID");
            relation.ChildColumnNames.Add("F_ID");
            radGridView1.Relations.Add(relation);
        }


        private void RadButton1_Click(object sender, EventArgs e)
        {
            int scrollBarValue = radGridView1.TableElement.VScrollBar.Value;
            foreach (GridViewDataRowInfo rowToSave in radGridView1.Rows)
            {
                SaveExpandedStates(rowToSave);
            }
            radGridView1.DataSource = null;
            radGridView1.DataSource = master;
            foreach (GridViewDataRowInfo rowToRestore in radGridView1.Rows)
            {
                RestoreExpandedStates(rowToRestore);
            }

            radGridView1.TableElement.VScrollBar.Value = scrollBarValue;
        }

        private void SaveExpandedStates(GridViewDataRowInfo rowToSave)
        {
            if (rowToSave != null && rowToSave.DataBoundItem != null)
            {
                if (!nodeStates.ContainsKey(rowToSave.DataBoundItem))
                {
                    nodeStates.Add(rowToSave.DataBoundItem, new State(rowToSave.IsExpanded, rowToSave.IsCurrent));
                }
                else
                {
                    nodeStates[rowToSave.DataBoundItem] = new State(rowToSave.IsExpanded, rowToSave.IsCurrent);
                }
            }
            foreach (GridViewDataRowInfo childRow in rowToSave.ChildRows)
            {
                SaveExpandedStates(childRow);
            }
        }

        private void RestoreExpandedStates(GridViewDataRowInfo rowToRestore)
        {
            if (rowToRestore != null && rowToRestore.DataBoundItem != null &&
                nodeStates.ContainsKey(rowToRestore.DataBoundItem))
            {
                rowToRestore.IsExpanded = nodeStates[rowToRestore.DataBoundItem].Expanded;
                rowToRestore.IsCurrent = nodeStates[rowToRestore.DataBoundItem].Selected;
                rowToRestore.IsSelected = nodeStates[rowToRestore.DataBoundItem].Selected;
            }

            foreach (GridViewDataRowInfo childRow in rowToRestore.ChildRows)
            {
                RestoreExpandedStates(childRow);
            }
        }

        Dictionary<object, State> nodeStates = new Dictionary<object, State>();

        struct State
        {
            public bool Expanded { get; set; }

            public bool Selected { get; set; }

            public State(bool expanded, bool selected) : this()
            {
                this.Expanded = expanded;
                this.Selected = selected;
            }
        }
    }
}

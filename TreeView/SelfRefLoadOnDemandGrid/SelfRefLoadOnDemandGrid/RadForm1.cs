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

namespace SelfRefLoadOnDemandGrid
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        DataTable externalSource = new DataTable();
        public static int columnWidth = 220;
        public static Color borderColor = Color.FromArgb(21, 215, 255);

        public RadForm1()
        {
            InitializeComponent();  

            externalSource.Columns.Add("Id", typeof(string));
            externalSource.Columns.Add("ParentId", typeof(string));
            externalSource.Columns.Add("Title", typeof(string));
            externalSource.Columns.Add("Date", typeof(DateTime));
            externalSource.Columns.Add("DeliveryType", typeof(DeliveryType));
            string id = string.Empty;
            string childId = string.Empty;
            for (int i = 0; i < 100; i++)
            {
                id = Guid.NewGuid().ToString();
                externalSource.Rows.Add(id, null, "Root " + i, DateTime.Now.AddDays(i).AddHours(i),
                    i % 2 == 0 ? DeliveryType.PickUp : DeliveryType.Delivery);
                for (int j = 0; j < 20; j++)
                {
                    childId = Guid.NewGuid().ToString();
                    externalSource.Rows.Add(childId, id, "Child " + i + "." + j, DateTime.Now.AddDays(i).AddHours(i),
                        j % 2 == 0 ? DeliveryType.PickUp : DeliveryType.Delivery);
                    for (int k = 0; k < 5; k++)
                    {
                        externalSource.Rows.Add(Guid.NewGuid().ToString(), childId, "Child " + i + "." + j + "." + k, DateTime.Now.AddDays(i).AddHours(i),
                            j % 2 == 0 ? DeliveryType.PickUp : DeliveryType.Delivery);
                    }
                }
            }

            this.radTreeView1.TreeViewElement.CreateNodeElement += TreeViewElement_CreateNodeElement;
            this.radTreeView1.LazyMode = true;
            this.radTreeView1.NodesNeeded += radTreeView1_NodesNeeded;

            this.radTreeView1.ItemHeight = 50;
            this.radTreeView1.AllowEdit = true;
            this.radTreeView1.TreeViewElement.EditMode = TreeNodeEditMode.Text;
            this.radTreeView1.EditorRequired += radTreeView1_EditorRequired;
            this.radTreeView1.EditorInitialized += RadTreeView1_EditorInitialized;

        }


        private void RadTreeView1_EditorInitialized(object sender, TreeNodeEditorInitializedEventArgs e)
        {

        }

        private void radTreeView1_EditorRequired(object sender, TreeNodeEditorRequiredEventArgs e)
        {
            e.Editor = new CustomRadTreeViewEditor();
        }

        void TreeViewElement_CreateNodeElement(object sender, Telerik.WinControls.UI.CreateTreeNodeElementEventArgs e)
        {
            e.NodeElement = new CustomTreeNodeElement();
        }

        private void radTreeView1_NodesNeeded(object sender, NodesNeededEventArgs e)
        {
            LoadNodesForParent(e.Parent, e.Nodes);
        }

        private void LoadNodesForParent(RadTreeNode parentNode, IList<RadTreeNode> nodes)
        {
            if (parentNode == null)
            {
                foreach (DataRow row in externalSource.Rows)
                {
                    if (row["ParentId"] == null || row["ParentId"].Equals(System.DBNull.Value))
                    {
                        nodes.Add(new RadTreeNode() { Text = row["Title"].ToString(), Tag = row, Value = row["Id"] });
                    }
                }
            }
            else
            {
                foreach (DataRow row in externalSource.Rows)
                {
                    if (row["ParentId"].ToString() == parentNode.Value.ToString())
                    {
                        nodes.Add(new RadTreeNode() { Text = row["Title"].ToString(), Tag = row, Value = row["Id"] });
                    }
                }
            }
        }

        public enum DeliveryType
        {
            PickUp,
            Delivery
        }

        public class CustomTreeNodeElement : TreeNodeElement
        {
            protected override TreeNodeContentElement CreateContentElement()
            {
                return new CustomContentElement();
            }

            protected override Type ThemeEffectiveType
            {
                get
                {
                    return typeof(TreeNodeElement);
                }
            }
        }
        class CustomContentElement : TreeNodeContentElement
        {
            StackLayoutElement mainContainer;
            StackLayoutElement headersContainer;
            StackLayoutElement nodeContentContainer;

            protected override Type ThemeEffectiveType
            {
                get
                {
                    return typeof(TreeNodeContentElement);
                }
            }

            protected override void CreateChildElements()
            {
                base.CreateChildElements();
                mainContainer = new StackLayoutElement();
                mainContainer.Orientation = Orientation.Vertical;
                headersContainer = new StackLayoutElement();
                // headersContainer.Orientation = Orientation.Horizontal;
                nodeContentContainer = new StackLayoutElement();
                mainContainer.Children.Add(headersContainer);
                mainContainer.Children.Add(nodeContentContainer);
                this.Children.Add(mainContainer);
            }

            public override void Synchronize()
            {
                base.Synchronize();
                this.DrawText = false;

                DataRow row = this.NodeElement.Data.Tag as DataRow;
                if (row != null)
                {
                    mainContainer.MinSize = new Size(columnWidth * row.Table.Columns.Count, this.NodeElement.Data.TreeView.ItemHeight);
                    if (headersContainer.Children.Count == 0)
                    {
                        foreach (DataColumn col in row.Table.Columns)
                        {
                            //generate columns
                            LightVisualElement columnHeader = new LightVisualElement();
                            columnHeader.Margin = new Padding(0, 0, -1, 0);
                            columnHeader.MinSize = columnHeader.MaxSize = new System.Drawing.Size(columnWidth, 20);
                            columnHeader.StretchHorizontally = true;
                            columnHeader.Text = col.ColumnName;
                            headersContainer.Children.Add(columnHeader);
                            StyleBorder(columnHeader);

                            //generate data cells
                            LightVisualElement contentCell = new LightVisualElement();
                            contentCell.Margin = new System.Windows.Forms.Padding(0, -1, -1, 0);
                            StyleBorder(contentCell);
                            contentCell.MinSize = new System.Drawing.Size(columnWidth, 24);
                            nodeContentContainer.Children.Add(contentCell);
                        }
                    }

                    for (int i = 0; i < nodeContentContainer.Children.Count; i++)
                    {
                        LightVisualElement contentCell = nodeContentContainer.Children[i] as LightVisualElement;
                        string text = row[i].ToString();
                        DateTime dt = DateTime.MinValue;
                        if (i == nodeContentContainer.Children.Count - 2)
                        {
                            if (DateTime.TryParse(text, out dt))
                            {
                                text = dt.ToString("dd/MM/yyyy");
                            }

                        }
                        else if (i == nodeContentContainer.Children.Count - 1)
                        {
                            text = Enum.GetName(typeof(DeliveryType), row[i]);
                        }

                        contentCell.Text = text;
                    }
                }
            }


        }
        private static void StyleBorder(LightVisualElement element)
        {
            element.DrawBorder = true;
            element.BorderGradientStyle = GradientStyles.Solid;
            element.BorderColor = borderColor;
        }
        public class CustomRadTreeViewEditor : BaseInputEditor
        {
            protected override RadElement CreateEditorElement()
            {
                return new CustomRadTreeViewEditorElement();
            }

            public new CustomRadTreeViewEditorElement EditorElement
            {
                get
                {
                    return base.EditorElement as CustomRadTreeViewEditorElement;
                }
            }

            public override Type DataType => typeof(string);

            public override object Value
            {
                get
                {
                    TreeNodeContentElement nodeElement = this.EditorElement.Parent as TreeNodeContentElement;
                    DataRow row = nodeElement.NodeElement.Data.Tag as DataRow;
                    return row;
                }
                set { }
            }

            public override void BeginEdit()
            {
                base.BeginEdit();
                TreeNodeContentElement nodeElement = this.EditorElement.Parent as TreeNodeContentElement;
                nodeElement.NodeElement.Data.Image = Properties.Resources.pen;
            }

            public override bool EndEdit()
            {
                TreeNodeContentElement nodeElement = this.EditorElement.Parent as TreeNodeContentElement;
                nodeElement.NodeElement.Data.Image = null;
                return base.EndEdit();
            }

            public class CustomRadTreeViewEditorElement : BaseTextBoxEditorElement
            {
                StackLayoutElement mainContainer;
                StackLayoutElement headersContainer;
                StackLayoutElement nodeContentContainer;
                RadDropDownListElement dropDownList;
                RadDateTimeEditorElement dateEditor;
                LightVisualElement idEditor;
                LightVisualElement parentIdEditor;
                RadTextBoxControlElement titleEditor;


                protected override void CreateChildElements()
                {
                    mainContainer = new StackLayoutElement();
                    mainContainer.Orientation = Orientation.Vertical;
                    mainContainer.StretchHorizontally = true;
                    mainContainer.StretchVertically = true;
                    headersContainer = new StackLayoutElement();
                    headersContainer.Orientation = Orientation.Horizontal;
                    nodeContentContainer = new StackLayoutElement();
                    nodeContentContainer.StretchHorizontally = true;

                    mainContainer.Children.Add(headersContainer);
                    mainContainer.Children.Add(nodeContentContainer);
                    this.Children.Add(mainContainer);
                    dropDownList = new RadDropDownListElement();
                }

                protected override void OnLoaded()
                {
                    base.OnLoaded();
                    if (this.Children.Contains(this.TextBoxItem))
                    {
                        this.Children.Remove(this.TextBoxItem);
                    }

                    TreeNodeContentElement nodeElement = this.Parent as TreeNodeContentElement;
                    if (nodeElement.NodeElement.Data != null)
                    {
                        DataRow row = nodeElement.NodeElement.Data.Tag as DataRow;
                        mainContainer.MinSize = new Size(columnWidth * row.Table.Columns.Count,
                            nodeElement.NodeElement.Data.TreeView.ItemHeight);

                        mainContainer.DrawFill = true;
                        mainContainer.GradientStyle = GradientStyles.Solid;
                        mainContainer.BackColor = nodeElement.NodeElement.BackColor;
                        mainContainer.Margin = new Padding(-2, -4, 0, 0);
                        if (headersContainer.Children.Count == 0)
                        {
                            foreach (DataColumn col in row.Table.Columns)
                            {
                                //generate columns
                                LightVisualElement columnHeader = new LightVisualElement();
                                columnHeader.MinSize = new System.Drawing.Size(columnWidth, 20);
                                columnHeader.StretchHorizontally = true;
                                columnHeader.Text = col.ColumnName;
                                headersContainer.Children.Add(columnHeader);
                                StyleBorder(columnHeader);

                                //generate data cells
                                if (col.ColumnName == "DeliveryType")
                                {
                                    this.dropDownList = new RadDropDownListElement();
                                    this.dropDownList.DropDownStyle = RadDropDownStyle.DropDownList;
                                    this.dropDownList.MinSize = new System.Drawing.Size(columnWidth, 0);
                                    nodeContentContainer.Children.Add(this.dropDownList);
                                    this.dropDownList.DataSource = Enum.GetValues(typeof(DeliveryType));
                                    this.dropDownList.SelectedValueChanged += DropDownList_SelectedValueChanged;

                                }
                                else if (col.ColumnName == "Date")
                                {
                                    this.dateEditor = new RadDateTimeEditorElement();
                                    this.dateEditor.Format = DateTimePickerFormat.Custom;
                                    this.dateEditor.CustomFormat = "dd/MM/yyyy";
                                    this.dateEditor.MinSize = new System.Drawing.Size(columnWidth, 20);
                                    nodeContentContainer.Children.Add(this.dateEditor);
                                    this.dateEditor.ValueChanged += DateEditor_ValueChanged;
                                }
                                else if (col.ColumnName == "Id")
                                {
                                    this.idEditor = new LightVisualElement();
                                    this.idEditor.StretchVertically = true;
                                    this.idEditor.MinSize = new System.Drawing.Size(columnWidth, 24);
                                    StyleBorder(this.idEditor);
                                    nodeContentContainer.Children.Add(this.idEditor);

                                }
                                else if (col.ColumnName == "ParentId")
                                {
                                    this.parentIdEditor = new LightVisualElement();
                                    this.parentIdEditor.MinSize = new System.Drawing.Size(columnWidth, 20);
                                    this.parentIdEditor.Margin = new System.Windows.Forms.Padding(0, -1, 0, 0);
                                    StyleBorder(this.parentIdEditor);
                                    nodeContentContainer.Children.Add(this.parentIdEditor);
                                }
                                else if (col.ColumnName == "Title")
                                {
                                    this.titleEditor = new RadTextBoxControlElement();
                                    this.titleEditor.Margin = new System.Windows.Forms.Padding(0, -1, 0, 0);
                                    StyleBorder(this.titleEditor);
                                    this.titleEditor.MinSize = new System.Drawing.Size(columnWidth, 20);
                                    nodeContentContainer.Children.Add(this.titleEditor);
                                    this.titleEditor.TextChanged += TitleEditor_TextChanged;
                                }
                            }
                        }

                        this.dropDownList.SelectedValueChanged -= DropDownList_SelectedValueChanged;
                        this.dateEditor.ValueChanged -= DateEditor_ValueChanged;
                        this.titleEditor.TextChanged -= TitleEditor_TextChanged;

                        this.idEditor.Text = row["Id"].ToString();
                        this.parentIdEditor.Text = row["ParentId"].ToString();
                        this.titleEditor.Text = row["Title"].ToString();
                        this.dateEditor.Value = (DateTime)row["Date"];
                        this.dropDownList.SelectedValue = row["DeliveryType"];

                        this.titleEditor.TextChanged += TitleEditor_TextChanged;
                        this.dateEditor.ValueChanged += DateEditor_ValueChanged;
                        this.dropDownList.SelectedValueChanged += DropDownList_SelectedValueChanged;
                    }
                }

                private void DropDownList_SelectedValueChanged(object sender, Telerik.WinControls.UI.Data.ValueChangedEventArgs e)
                {
                    TreeNodeContentElement nodeElement = this.Parent as TreeNodeContentElement;
                    DataRow row = nodeElement.NodeElement.Data.Tag as DataRow;
                    row["DeliveryType"] = this.dropDownList.SelectedValue;
                }

                private void DateEditor_ValueChanged(object sender, EventArgs e)
                {
                    TreeNodeContentElement nodeElement = this.Parent as TreeNodeContentElement;
                    DataRow row = nodeElement.NodeElement.Data.Tag as DataRow;
                    row["Date"] = this.dateEditor.Value;
                }

                private void TitleEditor_TextChanged(object sender, EventArgs e)
                {
                    TreeNodeContentElement nodeElement = this.Parent as TreeNodeContentElement;
                    DataRow row = nodeElement.NodeElement.Data.Tag as DataRow;
                    row["Title"] = this.titleEditor.Text;
                }
            }
        }
    }
}
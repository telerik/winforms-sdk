using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Primitives;
using Telerik.WinControls.UI;

namespace TreeViewDifferentCustomNodes
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
            ThemeResolutionService.ApplicationThemeName = "TelerikMetro";

            this.radTreeView1.MultiSelect = true;
            this.radTreeView1.TreeViewElement.ShowLines = true;
            this.radTreeView1.TreeViewElement.AutoSizeItems = true;
            this.radTreeView1.AllowArbitraryItemHeight = true;

            this.radTreeView1.CreateNodeElement += radTreeView1_CreateNodeElement;
        }

        private void radTreeView1_CreateNodeElement(object sender, CreateTreeNodeElementEventArgs e)
        {
            if (e.Node.Level == 1)
            {
                e.NodeElement = new ProductTreeNodeElement();
            }
            else if (e.Node.Level == 0)
            {
                e.NodeElement = new CategoryTreeNodeElement();
            }
        }

        private void RadForm1_Load(object sender, EventArgs e)
        {
            this.productsTableAdapter.Fill(this.nwindDataSet.Products);
            this.categoriesTableAdapter.Fill(this.nwindDataSet.Categories);
            
            this.radTreeView1.DataSource = this.categoriesBindingSource;             
            this.radTreeView1.DisplayMember = "CategoryName";
            this.radTreeView1.ValueMember = "CategoryID"; 
            this.radTreeView1.RelationBindings.Add(new RelationBinding(this.productsBindingSource, "ProductName", "CategoryID", "CategoryID", "ProductID"));

            this.radTreeView1.ExpandAll();
        }

        public class ProductTreeNodeContentElement : TreeNodeContentElement
        {
            StackLayoutElement container;
            LightVisualElement infoElement;
            LightVisualElement unitElement;
            LinePrimitive linePrimitive;

            protected override void CreateChildElements()
            {
                base.CreateChildElements();
                container = new StackLayoutElement();
                container.StretchVertically = true;
                container.StretchHorizontally = true;
                container.Orientation = Orientation.Vertical;
                infoElement = new LightVisualElement();
                infoElement.StretchVertically = false;
                infoElement.MaxSize = new System.Drawing.Size(0,30);
                container.Children.Add(infoElement);
                linePrimitive = new LinePrimitive();
                container.Children.Add(linePrimitive);
                unitElement = new LightVisualElement();
                container.Children.Add(unitElement);

                this.Children.Add(container);
            }

            public override void Synchronize()
            {
                this.DrawText = false;
                DataRowView rowView = this.NodeElement.Data.DataBoundItem as DataRowView;
                if (rowView != null && this.NodeElement.Data.Level == 1)
                {
                    infoElement.Text = rowView.Row["ProductID"].ToString() + "." + rowView.Row["ProductName"].ToString();
                    using (var ms = new MemoryStream(rowView.Row["Picture"] as byte[]))
                    {
                        infoElement.Image = Image.FromStream(ms);
                    }
                    infoElement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
                    infoElement.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                    unitElement.Text = rowView.Row["QuantityPerUnit"].ToString();
                    linePrimitive.BackColor = Color.Black;
                    linePrimitive.Margin = new Padding(10, 0, 10, 0);
                    linePrimitive.StretchVertically = false;
                    container.DrawBorder = true;
                    container.BorderGradientStyle = Telerik.WinControls.GradientStyles.Solid;
                }
            }
        }

        public class ProductTreeNodeElement : TreeNodeElement
        {
            protected override TreeNodeContentElement CreateContentElement()
            {
                return new ProductTreeNodeContentElement();
            }

            public override bool IsCompatible(RadTreeNode data, object context)
            {
                return data.Level == 1;
            }

            protected override Type ThemeEffectiveType
            {
                get
                {
                    return typeof(TreeNodeElement);
                }
            }
        }

        public class CategoryTreeNodeContentElement : TreeNodeContentElement
        {
            StackLayoutElement container;
            LightVisualElement descriptionElement;
            LinePrimitive linePrimitive;
            RadButtonElement selectButton;

            protected override void CreateChildElements()
            {
                base.CreateChildElements();
                container = new StackLayoutElement();
                container.Orientation = Orientation.Vertical;
                container.StretchVertically = true;
                
                descriptionElement = new LightVisualElement();
                descriptionElement.StretchVertically = false;
                container.Children.Add(descriptionElement);
                linePrimitive = new LinePrimitive();
                container.Children.Add(linePrimitive);
                selectButton = new RadButtonElement();
                container.Children.Add(selectButton);

                this.Children.Add(container);
                selectButton.Text = "Select all child nodes";
                selectButton.Click += selectButton_Click;
            }

            private void selectButton_Click(object sender, EventArgs e)
            { 
                foreach (RadTreeNode node in this.NodeElement.Data.Nodes)
                {
                    node.Selected = true;
                }
            }

            public override void Synchronize()
            {
                base.Synchronize();

                this.DrawText = false;
                DataRowView rowView = this.NodeElement.Data.DataBoundItem as DataRowView;
                if (rowView != null && this.NodeElement.Data.Level == 0)
                {
                    descriptionElement.Text = rowView.Row["CategoryID"].ToString() + "." + rowView.Row["CategoryName"].ToString();
                    
                    linePrimitive.BackColor = Color.Black;
                    linePrimitive.Margin = new Padding(0,0,0,10);
                    linePrimitive.StretchVertically = false;
                }
            }
        }

        public class CategoryTreeNodeElement : TreeNodeElement
        {
            protected override TreeNodeContentElement CreateContentElement()
            {
                return new CategoryTreeNodeContentElement();
            }

            public override bool IsCompatible(RadTreeNode data, object context)
            {
                return data.Level == 0;
            }

            protected override Type ThemeEffectiveType
            {
                get
                {
                    return typeof(TreeNodeElement);
                }
            }
        }
    }
}
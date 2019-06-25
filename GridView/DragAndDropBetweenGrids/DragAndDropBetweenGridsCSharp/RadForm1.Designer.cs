namespace DragAndDropBetweenGrids
{
    partial class RadForm1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.btnUnbound = new Telerik.WinControls.UI.RadButton();
            this.btnBoundObjects = new Telerik.WinControls.UI.RadButton();
            this.btnBoundDataset = new Telerik.WinControls.UI.RadButton();
            this.rightGrid = new DragAndDropBetweenGrids.DragAndDropRadGrid();
            this.leftGrid = new DragAndDropBetweenGrids.DragAndDropRadGrid();
            ((System.ComponentModel.ISupportInitialize)(this.btnUnbound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBoundObjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBoundDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightGrid.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftGrid.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUnbound
            // 
            this.btnUnbound.Location = new System.Drawing.Point(26, 325);
            this.btnUnbound.Name = "btnUnbound";
            this.btnUnbound.Size = new System.Drawing.Size(110, 24);
            this.btnUnbound.TabIndex = 2;
            this.btnUnbound.Text = "Unbound";
            this.btnUnbound.Click += new System.EventHandler(this.btnUnbound_Click);
            // 
            // btnBoundObjects
            // 
            this.btnBoundObjects.Location = new System.Drawing.Point(184, 327);
            this.btnBoundObjects.Name = "btnBoundObjects";
            this.btnBoundObjects.Size = new System.Drawing.Size(110, 24);
            this.btnBoundObjects.TabIndex = 3;
            this.btnBoundObjects.Text = "Bound Objects";
            this.btnBoundObjects.Click += new System.EventHandler(this.btnBoundObjects_Click);
            // 
            // btnBoundDataset
            // 
            this.btnBoundDataset.Location = new System.Drawing.Point(339, 327);
            this.btnBoundDataset.Name = "btnBoundDataset";
            this.btnBoundDataset.Size = new System.Drawing.Size(110, 24);
            this.btnBoundDataset.TabIndex = 4;
            this.btnBoundDataset.Text = "Bound DataSet";
            this.btnBoundDataset.Click += new System.EventHandler(this.btnBoundDataset_Click);
            // 
            // rightGrid
            // 
            this.rightGrid.Location = new System.Drawing.Point(434, 27);
            // 
            // 
            // 
            this.rightGrid.MasterTemplate.MultiSelect = true;
            this.rightGrid.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rightGrid.Name = "rightGrid";
            this.rightGrid.Size = new System.Drawing.Size(240, 150);
            this.rightGrid.TabIndex = 1;
            // 
            // leftGrid
            // 
            this.leftGrid.Location = new System.Drawing.Point(26, 27);
            // 
            // 
            // 
            this.leftGrid.MasterTemplate.MultiSelect = true;
            this.leftGrid.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.leftGrid.Name = "leftGrid";
            this.leftGrid.Size = new System.Drawing.Size(240, 150);
            this.leftGrid.TabIndex = 0;
            // 
            // RadForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 363);
            this.Controls.Add(this.btnBoundDataset);
            this.Controls.Add(this.btnBoundObjects);
            this.Controls.Add(this.btnUnbound);
            this.Controls.Add(this.rightGrid);
            this.Controls.Add(this.leftGrid);
            this.Name = "RadForm1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "RadForm1";
            ((System.ComponentModel.ISupportInitialize)(this.btnUnbound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBoundObjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBoundDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightGrid.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftGrid.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DragAndDropRadGrid leftGrid;
        private DragAndDropRadGrid rightGrid;
        private Telerik.WinControls.UI.RadButton btnUnbound;
        private Telerik.WinControls.UI.RadButton btnBoundObjects;
        private Telerik.WinControls.UI.RadButton btnBoundDataset;
    }
}
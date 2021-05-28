namespace VirtualMultiColumnComboBox
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.virtualRadMultiColumnComboBox1 = new VirtualMultiColumnComboBox.Implementation.VirtualMultiColumnComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.virtualRadMultiColumnComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.virtualRadMultiColumnComboBox1.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.virtualRadMultiColumnComboBox1.EditorControl.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // radMultiColumnComboBox1
            // 
            this.virtualRadMultiColumnComboBox1.DataSource = ((object)(resources.GetObject("radMultiColumnComboBox1.DataSource")));
            // 
            // radMultiColumnComboBox1.NestedRadGridView
            // 
            this.virtualRadMultiColumnComboBox1.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.virtualRadMultiColumnComboBox1.EditorControl.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.virtualRadMultiColumnComboBox1.EditorControl.ForeColor = System.Drawing.Color.Black;
            this.virtualRadMultiColumnComboBox1.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // radMultiColumnComboBox1.NestedRadGridView
            // 
            this.virtualRadMultiColumnComboBox1.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.virtualRadMultiColumnComboBox1.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.virtualRadMultiColumnComboBox1.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.virtualRadMultiColumnComboBox1.EditorControl.MasterTemplate.EnableGrouping = false;
            this.virtualRadMultiColumnComboBox1.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.virtualRadMultiColumnComboBox1.EditorControl.Name = "NestedRadGridView";
            this.virtualRadMultiColumnComboBox1.EditorControl.ReadOnly = true;
            this.virtualRadMultiColumnComboBox1.EditorControl.ShowGroupPanel = false;
            this.virtualRadMultiColumnComboBox1.EditorControl.Size = new System.Drawing.Size(506, 33);
            this.virtualRadMultiColumnComboBox1.EditorControl.TabIndex = 0;
            this.virtualRadMultiColumnComboBox1.EditorControl.ThemeName = "ControlDefault";
            this.virtualRadMultiColumnComboBox1.EditorControl.VirtualMode = true;
            this.virtualRadMultiColumnComboBox1.Location = new System.Drawing.Point(13, 13);
            this.virtualRadMultiColumnComboBox1.Name = "radMultiColumnComboBox1";
            this.virtualRadMultiColumnComboBox1.Size = new System.Drawing.Size(506, 20);
            this.virtualRadMultiColumnComboBox1.TabIndex = 0;
            this.virtualRadMultiColumnComboBox1.TabStop = false;
            this.virtualRadMultiColumnComboBox1.Text = "radMultiColumnComboBox1";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 221);
            this.Controls.Add(this.virtualRadMultiColumnComboBox1);
            this.Name = "MainWindow";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.virtualRadMultiColumnComboBox1.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.virtualRadMultiColumnComboBox1.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.virtualRadMultiColumnComboBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private VirtualMultiColumnComboBox.Implementation.VirtualMultiColumnComboBox virtualRadMultiColumnComboBox1;
    }
}


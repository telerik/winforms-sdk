namespace IndicatingOperations
{
    partial class MainForm
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
            this.rbtnPrepareDataSource = new Telerik.WinControls.UI.RadButton();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.radWaitingBar1 = new Telerik.WinControls.UI.RadWaitingBar();
            this.rbtnBind = new Telerik.WinControls.UI.RadButton();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnPrepareDataSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            this.radGridView1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radWaitingBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnBind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtnPrepareDataSource
            // 
            this.rbtnPrepareDataSource.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbtnPrepareDataSource.Location = new System.Drawing.Point(0, 0);
            this.rbtnPrepareDataSource.Name = "rbtnPrepareDataSource";
            this.rbtnPrepareDataSource.Size = new System.Drawing.Size(232, 26);
            this.rbtnPrepareDataSource.TabIndex = 0;
            this.rbtnPrepareDataSource.Text = "1. Prepare Data Source";
            this.rbtnPrepareDataSource.Click += new System.EventHandler(this.rbtnPrepareDataSource_Click);
            // 
            // radGridView1
            // 
            this.radGridView1.Controls.Add(this.radWaitingBar1);
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView1.Location = new System.Drawing.Point(0, 0);
            // 
            // radGridView1
            // 
            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Size = new System.Drawing.Size(471, 319);
            this.radGridView1.TabIndex = 1;
            this.radGridView1.Text = "radGridView1";
            // 
            // radWaitingBar1
            // 
            this.radWaitingBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radWaitingBar1.Location = new System.Drawing.Point(129, 145);
            this.radWaitingBar1.Name = "radWaitingBar1";
            this.radWaitingBar1.Size = new System.Drawing.Size(220, 30);
            this.radWaitingBar1.TabIndex = 0;
            this.radWaitingBar1.Text = "radWaitingBar1";
            this.radWaitingBar1.Visible = false;
            this.radWaitingBar1.WaitingIndicatorSize = new System.Drawing.Size(50, 30);
            // 
            // rbtnBind
            // 
            this.rbtnBind.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbtnBind.Enabled = false;
            this.rbtnBind.Location = new System.Drawing.Point(232, 0);
            this.rbtnBind.Name = "rbtnBind";
            this.rbtnBind.Size = new System.Drawing.Size(239, 26);
            this.rbtnBind.TabIndex = 2;
            this.rbtnBind.Text = "2. Bind";
            this.rbtnBind.Click += new System.EventHandler(this.rbtnBind_Click);
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.rbtnBind);
            this.radPanel1.Controls.Add(this.rbtnPrepareDataSource);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radPanel1.Location = new System.Drawing.Point(0, 319);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(471, 26);
            this.radPanel1.TabIndex = 3;
            this.radPanel1.Text = "radPanel1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 345);
            this.Controls.Add(this.radGridView1);
            this.Controls.Add(this.radPanel1);
            this.Name = "MainForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.rbtnPrepareDataSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            this.radGridView1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radWaitingBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnBind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton rbtnPrepareDataSource;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadButton rbtnBind;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadWaitingBar radWaitingBar1;
    }
}


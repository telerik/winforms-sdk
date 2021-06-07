namespace RadGanttViewIndicatingSpecialDays
{
    partial class RadGanttViewForm
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
            this.customRadGanttView = new RadGanttViewIndicatingSpecialDays.CustomGanttView();
            ((System.ComponentModel.ISupportInitialize)(this.customRadGanttView)).BeginInit();
            this.SuspendLayout();
            // 
            // customRadGanttView
            // 
            this.customRadGanttView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customRadGanttView.Location = new System.Drawing.Point(0, 0);
            this.customRadGanttView.Name = "customRadGanttView";
            this.customRadGanttView.Size = new System.Drawing.Size(1165, 399);
            this.customRadGanttView.SplitterWidth = 7;
            this.customRadGanttView.TabIndex = 0;
            this.customRadGanttView.Text = "radGanttView1";
            // 
            // RadGanttViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 399);
            this.Controls.Add(this.customRadGanttView);
            this.Name = "RadGanttViewForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.customRadGanttView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomGanttView customRadGanttView;//Telerik.WinControls.UI.RadGanttView radGanttView1;
    }
}


namespace RadGanttViewExample
{
    partial class Form1
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
            this.radGanttView1 = new Telerik.WinControls.UI.RadGanttView();
            ((System.ComponentModel.ISupportInitialize)(this.radGanttView1)).BeginInit();
            this.SuspendLayout();
            // 
            // radGanttView1
            // 
            this.radGanttView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGanttView1.Location = new System.Drawing.Point(0, 0);
            this.radGanttView1.Name = "radGanttView1";
            this.radGanttView1.Size = new System.Drawing.Size(1378, 788);
            this.radGanttView1.SplitterWidth = 7;
            this.radGanttView1.TabIndex = 0;
            this.radGanttView1.Text = "radGanttView1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 788);
            this.Controls.Add(this.radGanttView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.radGanttView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGanttView radGanttView1;
    }
}


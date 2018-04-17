namespace RadGanttViewSnapping
{
    partial class RadGanttViewTimelineSnapping
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
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGanttView1
            // 
            this.radGanttView1.Location = new System.Drawing.Point(12, 12);
            this.radGanttView1.Name = "radGanttView1";
            this.radGanttView1.Ratio = 0.32F;
            this.radGanttView1.Size = new System.Drawing.Size(886, 585);
            this.radGanttView1.SplitterWidth = 7;
            this.radGanttView1.TabIndex = 0;
            // 
            // RadForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 609);
            this.Controls.Add(this.radGanttView1);
            this.Name = "RadGanttViewTimelineSnapping";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "RadGanttViewTimelineSnapping";
            ((System.ComponentModel.ISupportInitialize)(this.radGanttView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGanttView radGanttView1;
    }
}
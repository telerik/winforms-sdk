namespace HotelApp
{
    partial class UserControlCurrentStatus
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.CartesianArea cartesianArea2 = new Telerik.WinControls.UI.CartesianArea();
            Telerik.WinControls.UI.CartesianArea cartesianArea3 = new Telerik.WinControls.UI.CartesianArea();
            this.occupiedPerDayChartView = new Telerik.WinControls.UI.RadChartView();
            this.trendsChartView = new Telerik.WinControls.UI.RadChartView();
            this.trendsRangeSelector = new Telerik.WinControls.UI.RadRangeSelector();
            this.reportsRangeSelectorPanel = new Telerik.WinControls.UI.RadPanel();
            ((System.ComponentModel.ISupportInitialize)(this.occupiedPerDayChartView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trendsChartView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trendsRangeSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsRangeSelectorPanel)).BeginInit();
            this.reportsRangeSelectorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // occupiedPerDayChartView
            // 
            this.occupiedPerDayChartView.AreaDesign = cartesianArea2;
            this.occupiedPerDayChartView.Dock = System.Windows.Forms.DockStyle.Left;
            this.occupiedPerDayChartView.Location = new System.Drawing.Point(0, 0);
            this.occupiedPerDayChartView.Name = "occupiedPerDayChartView";
            this.occupiedPerDayChartView.ShowGrid = false;
            this.occupiedPerDayChartView.Size = new System.Drawing.Size(518, 340);
            this.occupiedPerDayChartView.TabIndex = 0;
            this.occupiedPerDayChartView.Text = "radChartView1";
            // 
            // trendsChartView
            // 
            this.trendsChartView.AreaDesign = cartesianArea3;
            this.trendsChartView.Dock = System.Windows.Forms.DockStyle.Top;
            this.trendsChartView.Location = new System.Drawing.Point(518, 0);
            this.trendsChartView.Name = "trendsChartView";
            this.trendsChartView.ShowGrid = false;
            this.trendsChartView.Size = new System.Drawing.Size(802, 200);
            this.trendsChartView.TabIndex = 1;
            this.trendsChartView.Text = "radChartView2";
            // 
            // trendsRangeSelector
            // 
            this.trendsRangeSelector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trendsRangeSelector.Location = new System.Drawing.Point(0, 0);
            this.trendsRangeSelector.Name = "trendsRangeSelector";
            this.trendsRangeSelector.Size = new System.Drawing.Size(802, 140);
            this.trendsRangeSelector.TabIndex = 2;
            this.trendsRangeSelector.Text = "radRangeSelector1";
            // 
            // reportsRangeSelectorPanel
            // 
            this.reportsRangeSelectorPanel.Controls.Add(this.trendsRangeSelector);
            this.reportsRangeSelectorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportsRangeSelectorPanel.Location = new System.Drawing.Point(518, 200);
            this.reportsRangeSelectorPanel.Name = "reportsRangeSelectorPanel";
            this.reportsRangeSelectorPanel.Size = new System.Drawing.Size(802, 140);
            this.reportsRangeSelectorPanel.TabIndex = 3;
            // 
            // UserControlCurrentStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reportsRangeSelectorPanel);
            this.Controls.Add(this.trendsChartView);
            this.Controls.Add(this.occupiedPerDayChartView);
            this.Name = "UserControlCurrentStatus";
            this.Size = new System.Drawing.Size(1320, 340);
            ((System.ComponentModel.ISupportInitialize)(this.occupiedPerDayChartView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trendsChartView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trendsRangeSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsRangeSelectorPanel)).EndInit();
            this.reportsRangeSelectorPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadChartView occupiedPerDayChartView;
        private Telerik.WinControls.UI.RadChartView trendsChartView;
        private Telerik.WinControls.UI.RadRangeSelector trendsRangeSelector;
        private Telerik.WinControls.UI.RadPanel reportsRangeSelectorPanel;
    }
}

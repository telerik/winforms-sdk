namespace HotelApp
{
    partial class UserControlBookingsByType
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
            Telerik.WinControls.UI.CartesianArea cartesianArea1 = new Telerik.WinControls.UI.CartesianArea();
            Telerik.WinControls.UI.CartesianArea cartesianArea2 = new Telerik.WinControls.UI.CartesianArea();
            Telerik.WinControls.UI.CartesianArea cartesianArea3 = new Telerik.WinControls.UI.CartesianArea();
            Telerik.WinControls.UI.CartesianArea cartesianArea4 = new Telerik.WinControls.UI.CartesianArea();
            this.bookingsByTypeChartView = new Telerik.WinControls.UI.RadChartView();
            this.bookingsByRoomTypeChartView = new Telerik.WinControls.UI.RadChartView();
            this.availabilityChartView = new Telerik.WinControls.UI.RadChartView();
            this.averageChartView = new Telerik.WinControls.UI.RadChartView();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsByTypeChartView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsByRoomTypeChartView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.availabilityChartView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.averageChartView)).BeginInit();
            this.SuspendLayout();
            // 
            // bookingsByTypeChartView
            // 
            this.bookingsByTypeChartView.AreaDesign = cartesianArea1;
            this.bookingsByTypeChartView.Dock = System.Windows.Forms.DockStyle.Left;
            this.bookingsByTypeChartView.Location = new System.Drawing.Point(0, 0);
            this.bookingsByTypeChartView.Name = "bookingsByTypeChartView";
            this.bookingsByTypeChartView.ShowGrid = false;
            this.bookingsByTypeChartView.Size = new System.Drawing.Size(300, 300);
            this.bookingsByTypeChartView.TabIndex = 0;
            this.bookingsByTypeChartView.Text = "radChartView1";
            // 
            // bookingsByRoomTypeChartView
            // 
            this.bookingsByRoomTypeChartView.AreaDesign = cartesianArea2;
            this.bookingsByRoomTypeChartView.Dock = System.Windows.Forms.DockStyle.Left;
            this.bookingsByRoomTypeChartView.Location = new System.Drawing.Point(300, 0);
            this.bookingsByRoomTypeChartView.Name = "bookingsByRoomTypeChartView";
            this.bookingsByRoomTypeChartView.ShowGrid = false;
            this.bookingsByRoomTypeChartView.Size = new System.Drawing.Size(300, 300);
            this.bookingsByRoomTypeChartView.TabIndex = 1;
            this.bookingsByRoomTypeChartView.Text = "radChartView1";
            // 
            // availabilityChartView
            // 
            this.availabilityChartView.AreaDesign = cartesianArea3;
            this.availabilityChartView.Dock = System.Windows.Forms.DockStyle.Left;
            this.availabilityChartView.Location = new System.Drawing.Point(600, 0);
            this.availabilityChartView.Name = "availabilityChartView";
            this.availabilityChartView.ShowGrid = false;
            this.availabilityChartView.Size = new System.Drawing.Size(300, 300);
            this.availabilityChartView.TabIndex = 2;
            this.availabilityChartView.Text = "radChartView1";
            // 
            // averageChartView
            // 
            this.averageChartView.AreaDesign = cartesianArea4;
            this.averageChartView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.averageChartView.Location = new System.Drawing.Point(900, 0);
            this.averageChartView.Name = "averageChartView";
            this.averageChartView.ShowGrid = false;
            this.averageChartView.Size = new System.Drawing.Size(420, 300);
            this.averageChartView.TabIndex = 3;
            this.averageChartView.Text = "averageStayChartView";
            // 
            // UserControlBookingsByType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.averageChartView);
            this.Controls.Add(this.availabilityChartView);
            this.Controls.Add(this.bookingsByRoomTypeChartView);
            this.Controls.Add(this.bookingsByTypeChartView);
            this.Name = "UserControlBookingsByType";
            this.Size = new System.Drawing.Size(1320, 300);
            ((System.ComponentModel.ISupportInitialize)(this.bookingsByTypeChartView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsByRoomTypeChartView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.availabilityChartView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.averageChartView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadChartView bookingsByTypeChartView;
        private Telerik.WinControls.UI.RadChartView bookingsByRoomTypeChartView;
        private Telerik.WinControls.UI.RadChartView averageChartView;
        private Telerik.WinControls.UI.RadChartView availabilityChartView;

    }
}

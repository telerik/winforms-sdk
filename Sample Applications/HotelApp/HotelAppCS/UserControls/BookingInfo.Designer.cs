namespace CustomControls
{
    partial class BookingInfo
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.headerContainer = new Telerik.WinControls.UI.RadPanel();
            this.bookingInfoLabel = new Telerik.WinControls.UI.RadLabel();
            this.closeButton = new Telerik.WinControls.UI.RadButton();
            this.roomImageBox = new Telerik.WinControls.UI.RadPanel();
            this.bookingStatusLabel = new Telerik.WinControls.UI.RadLabel();
            this.bookingStatusDropDown = new Telerik.WinControls.UI.RadDropDownList();
            this.bookingStatusContainer = new Telerik.WinControls.UI.RadPanel();
            this.bookingNameContainer = new Telerik.WinControls.UI.RadPanel();
            this.bookingNameLabel = new Telerik.WinControls.UI.RadLabel();
            this.dropDownSeparator = new Telerik.WinControls.UI.RadSeparator();
            this.bookingRoomTypeIcon = new Telerik.WinControls.UI.RadLabel();
            this.manageReservationContainer = new Telerik.WinControls.UI.RadPanel();
            this.manageStatusLabel = new Telerik.WinControls.UI.RadLabel();
            this.roomIdLabel = new Telerik.WinControls.UI.RadLabel();
            this.bookingPriceLabel = new Telerik.WinControls.UI.RadLabel();
            this.paymentSeparator = new Telerik.WinControls.UI.RadSeparator();
            this.bookingDatesGrid = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.headerContainer)).BeginInit();
            this.headerContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingInfoLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingStatusLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingStatusDropDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingStatusContainer)).BeginInit();
            this.bookingStatusContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingNameContainer)).BeginInit();
            this.bookingNameContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingNameLabel)).BeginInit();
            this.bookingNameLabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownSeparator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingRoomTypeIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manageReservationContainer)).BeginInit();
            this.manageReservationContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manageStatusLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomIdLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingPriceLabel)).BeginInit();
            this.bookingPriceLabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentSeparator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingDatesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingDatesGrid.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // headerContainer
            // 
            this.headerContainer.Controls.Add(this.bookingInfoLabel);
            this.headerContainer.Controls.Add(this.closeButton);
            this.headerContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerContainer.Location = new System.Drawing.Point(0, 0);
            this.headerContainer.Name = "headerContainer";
            this.headerContainer.Size = new System.Drawing.Size(270, 50);
            this.headerContainer.TabIndex = 0;
            // 
            // bookingInfoLabel
            // 
            this.bookingInfoLabel.AutoSize = false;
            this.bookingInfoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookingInfoLabel.Location = new System.Drawing.Point(0, 0);
            this.bookingInfoLabel.Margin = new System.Windows.Forms.Padding(0);
            this.bookingInfoLabel.Name = "bookingInfoLabel";
            this.bookingInfoLabel.Size = new System.Drawing.Size(240, 50);
            this.bookingInfoLabel.TabIndex = 1;
            this.bookingInfoLabel.Text = "bookingInfoLabel";
            // 
            // closeButton
            // 
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButton.Location = new System.Drawing.Point(240, 0);
            this.closeButton.Margin = new System.Windows.Forms.Padding(0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(30, 50);
            this.closeButton.TabIndex = 0;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // roomImageBox
            // 
            this.roomImageBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.roomImageBox.Location = new System.Drawing.Point(0, 50);
            this.roomImageBox.Margin = new System.Windows.Forms.Padding(0);
            this.roomImageBox.Name = "roomImageBox";
            this.roomImageBox.Size = new System.Drawing.Size(270, 180);
            this.roomImageBox.TabIndex = 1;
            // 
            // bookingStatusLabel
            // 
            this.bookingStatusLabel.AutoSize = false;
            this.bookingStatusLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.bookingStatusLabel.Location = new System.Drawing.Point(0, 0);
            this.bookingStatusLabel.Name = "bookingStatusLabel";
            this.bookingStatusLabel.Size = new System.Drawing.Size(60, 40);
            this.bookingStatusLabel.TabIndex = 2;
            this.bookingStatusLabel.Text = "Status:";
            // 
            // bookingStatusDropDown
            // 
            this.bookingStatusDropDown.AutoSize = false;
            this.bookingStatusDropDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookingStatusDropDown.Location = new System.Drawing.Point(60, 0);
            this.bookingStatusDropDown.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.bookingStatusDropDown.Name = "bookingStatusDropDown";
            this.bookingStatusDropDown.Size = new System.Drawing.Size(210, 40);
            this.bookingStatusDropDown.TabIndex = 3;
            this.bookingStatusDropDown.Text = "radDropDownList1";
            // 
            // bookingStatusContainer
            // 
            this.bookingStatusContainer.Controls.Add(this.bookingStatusDropDown);
            this.bookingStatusContainer.Controls.Add(this.bookingStatusLabel);
            this.bookingStatusContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.bookingStatusContainer.Location = new System.Drawing.Point(0, 230);
            this.bookingStatusContainer.Name = "bookingStatusContainer";
            this.bookingStatusContainer.Size = new System.Drawing.Size(270, 40);
            this.bookingStatusContainer.TabIndex = 4;
            // 
            // bookingNameContainer
            // 
            this.bookingNameContainer.Controls.Add(this.bookingNameLabel);
            this.bookingNameContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.bookingNameContainer.Location = new System.Drawing.Point(0, 270);
            this.bookingNameContainer.Name = "bookingNameContainer";
            this.bookingNameContainer.Size = new System.Drawing.Size(270, 70);
            this.bookingNameContainer.TabIndex = 5;
            // 
            // bookingNameLabel
            // 
            this.bookingNameLabel.AutoSize = false;
            this.bookingNameLabel.Controls.Add(this.dropDownSeparator);
            this.bookingNameLabel.Controls.Add(this.bookingRoomTypeIcon);
            this.bookingNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookingNameLabel.Location = new System.Drawing.Point(0, 0);
            this.bookingNameLabel.Name = "bookingNameLabel";
            this.bookingNameLabel.Size = new System.Drawing.Size(270, 70);
            this.bookingNameLabel.TabIndex = 1;
            // 
            // dropDownSeparator
            // 
            this.dropDownSeparator.Location = new System.Drawing.Point(70, 0);
            this.dropDownSeparator.Name = "dropDownSeparator";
            this.dropDownSeparator.Size = new System.Drawing.Size(180, 10);
            this.dropDownSeparator.TabIndex = 0;
            this.dropDownSeparator.Text = "radSeparator1";
            // 
            // bookingRoomTypeIcon
            // 
            this.bookingRoomTypeIcon.AutoSize = false;
            this.bookingRoomTypeIcon.Dock = System.Windows.Forms.DockStyle.Right;
            this.bookingRoomTypeIcon.Location = new System.Drawing.Point(200, 0);
            this.bookingRoomTypeIcon.Name = "bookingRoomTypeIcon";
            this.bookingRoomTypeIcon.Size = new System.Drawing.Size(70, 70);
            this.bookingRoomTypeIcon.TabIndex = 0;
            // 
            // manageReservationContainer
            // 
            this.manageReservationContainer.Controls.Add(this.manageStatusLabel);
            this.manageReservationContainer.Controls.Add(this.roomIdLabel);
            this.manageReservationContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.manageReservationContainer.Location = new System.Drawing.Point(0, 340);
            this.manageReservationContainer.Name = "manageReservationContainer";
            this.manageReservationContainer.Size = new System.Drawing.Size(270, 60);
            this.manageReservationContainer.TabIndex = 6;
            // 
            // manageStatusLabel
            // 
            this.manageStatusLabel.AutoSize = false;
            this.manageStatusLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.manageStatusLabel.Location = new System.Drawing.Point(120, 0);
            this.manageStatusLabel.Name = "manageStatusLabel";
            this.manageStatusLabel.Size = new System.Drawing.Size(150, 60);
            this.manageStatusLabel.TabIndex = 1;
            this.manageStatusLabel.Text = "Change reservation";
            this.manageStatusLabel.Click += new System.EventHandler(this.manageStatusLabel_Click);
            // 
            // roomIdLabel
            // 
            this.roomIdLabel.AutoSize = false;
            this.roomIdLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roomIdLabel.Location = new System.Drawing.Point(0, 0);
            this.roomIdLabel.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.roomIdLabel.Name = "roomIdLabel";
            this.roomIdLabel.Size = new System.Drawing.Size(270, 60);
            this.roomIdLabel.TabIndex = 0;
            this.roomIdLabel.Text = "radLabel1";
            // 
            // bookingPriceLabel
            // 
            this.bookingPriceLabel.AutoSize = false;
            this.bookingPriceLabel.Controls.Add(this.paymentSeparator);
            this.bookingPriceLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.bookingPriceLabel.Location = new System.Drawing.Point(0, 530);
            this.bookingPriceLabel.Margin = new System.Windows.Forms.Padding(0);
            this.bookingPriceLabel.Name = "bookingPriceLabel";
            this.bookingPriceLabel.Size = new System.Drawing.Size(270, 59);
            this.bookingPriceLabel.TabIndex = 0;
            this.bookingPriceLabel.Text = "radLabel1";
            // 
            // paymentSeparator
            // 
            this.paymentSeparator.Location = new System.Drawing.Point(8, 3);
            this.paymentSeparator.Name = "paymentSeparator";
            this.paymentSeparator.Size = new System.Drawing.Size(250, 4);
            this.paymentSeparator.TabIndex = 0;
            this.paymentSeparator.Text = "radSeparator1";
            // 
            // bookingDatesGrid
            // 
            this.bookingDatesGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.bookingDatesGrid.Location = new System.Drawing.Point(0, 400);
            this.bookingDatesGrid.Margin = new System.Windows.Forms.Padding(0);
            // 
            // 
            // 
            this.bookingDatesGrid.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.bookingDatesGrid.Name = "bookingDatesGrid";
            this.bookingDatesGrid.Size = new System.Drawing.Size(270, 130);
            this.bookingDatesGrid.TabIndex = 8;
            this.bookingDatesGrid.Text = "radGridView1";
            // 
            // BookingInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bookingPriceLabel);
            this.Controls.Add(this.bookingDatesGrid);
            this.Controls.Add(this.manageReservationContainer);
            this.Controls.Add(this.bookingNameContainer);
            this.Controls.Add(this.bookingStatusContainer);
            this.Controls.Add(this.roomImageBox);
            this.Controls.Add(this.headerContainer);
            this.Name = "BookingInfo";
            this.Size = new System.Drawing.Size(270, 685);
            ((System.ComponentModel.ISupportInitialize)(this.headerContainer)).EndInit();
            this.headerContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookingInfoLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingStatusLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingStatusDropDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingStatusContainer)).EndInit();
            this.bookingStatusContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookingNameContainer)).EndInit();
            this.bookingNameContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookingNameLabel)).EndInit();
            this.bookingNameLabel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dropDownSeparator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingRoomTypeIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manageReservationContainer)).EndInit();
            this.manageReservationContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.manageStatusLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomIdLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingPriceLabel)).EndInit();
            this.bookingPriceLabel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paymentSeparator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingDatesGrid.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingDatesGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel headerContainer;
        private Telerik.WinControls.UI.RadLabel bookingInfoLabel;
        private Telerik.WinControls.UI.RadButton closeButton;
        private Telerik.WinControls.UI.RadPanel roomImageBox;
        private Telerik.WinControls.UI.RadLabel bookingStatusLabel;
        private Telerik.WinControls.UI.RadDropDownList bookingStatusDropDown;
        private Telerik.WinControls.UI.RadPanel bookingStatusContainer;
        private Telerik.WinControls.UI.RadPanel bookingNameContainer;
        private Telerik.WinControls.UI.RadLabel bookingNameLabel;
        private Telerik.WinControls.UI.RadLabel bookingRoomTypeIcon;
        private Telerik.WinControls.UI.RadPanel manageReservationContainer;
        private Telerik.WinControls.UI.RadLabel manageStatusLabel;
        private Telerik.WinControls.UI.RadLabel roomIdLabel;
        private Telerik.WinControls.UI.RadGridView bookingDatesGrid;
        private Telerik.WinControls.UI.RadLabel bookingPriceLabel;
        private Telerik.WinControls.UI.RadSeparator paymentSeparator;
        private Telerik.WinControls.UI.RadSeparator dropDownSeparator;

    }
}

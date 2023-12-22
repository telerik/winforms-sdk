namespace HotelApp
{
    partial class HouseKeepingEditAppointmentDialog
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
            this.doneButton = new Telerik.WinControls.UI.RadButton();
            this.needsRepairsCheckBox = new Telerik.WinControls.UI.RadCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.labelSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelStartTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelEndTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAllDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelResource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbResource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbShowTimeAs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonRecurrence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownListReminder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelReminder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doneButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.needsRepairsCheckBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBackground
            // 
            // 
            // 
            // 
            this.cmbBackground.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            // 
            // dateStart
            // 
            this.dateStart.Text = "8/9/2017";
            this.dateStart.Value = new System.DateTime(2017, 8, 9, 16, 9, 4, 229);
            // 
            // timeStart
            // 
            this.timeStart.Text = "4:09:04 PM";
            this.timeStart.Value = new System.DateTime(2017, 8, 9, 16, 9, 4, 229);
            // 
            // dateEnd
            // 
            this.dateEnd.Text = "8/9/2017";
            this.dateEnd.Value = new System.DateTime(2017, 8, 9, 16, 9, 4, 229);
            // 
            // timeEnd
            // 
            this.timeEnd.Text = "4:09:04 PM";
            this.timeEnd.Value = new System.DateTime(2017, 8, 9, 16, 9, 4, 229);
            // 
            // cmbShowTimeAs
            // 
            // 
            // 
            // 
            this.cmbShowTimeAs.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(316, 343);
            // 
            // buttonRecurrence
            // 
            this.buttonRecurrence.Location = new System.Drawing.Point(397, 342);
            // 
            // radDropDownListReminder
            // 
            this.radDropDownListReminder.Text = "None";
            // 
            // radLabelReminder
            // 
            this.radLabelReminder.Size = new System.Drawing.Size(54, 18);
            this.radLabelReminder.Text = "Reminder";
            // 
            // doneButton
            // 
            this.doneButton.Location = new System.Drawing.Point(168, 342);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(75, 23);
            this.doneButton.TabIndex = 25;
            this.doneButton.Text = "Done";
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // needsRepairsCheckBox
            // 
            this.needsRepairsCheckBox.Location = new System.Drawing.Point(362, 129);
            this.needsRepairsCheckBox.Name = "needsRepairsCheckBox";
            this.needsRepairsCheckBox.Size = new System.Drawing.Size(52, 18);
            this.needsRepairsCheckBox.TabIndex = 26;
            this.needsRepairsCheckBox.Text = "Repair";
            // 
            // CustomEditAppointmentDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 378);
            this.Controls.Add(this.needsRepairsCheckBox);
            this.Controls.Add(this.doneButton);
            this.Name = "CustomEditAppointmentDialog";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MinSize = new System.Drawing.Size(539, 365);
            this.Text = "CustomEditAppointmentDialog";
            this.Controls.SetChildIndex(this.labelSubject, 0);
            this.Controls.SetChildIndex(this.labelLocation, 0);
            this.Controls.SetChildIndex(this.labelBackground, 0);
            this.Controls.SetChildIndex(this.txtSubject, 0);
            this.Controls.SetChildIndex(this.txtLocation, 0);
            this.Controls.SetChildIndex(this.cmbBackground, 0);
            this.Controls.SetChildIndex(this.labelStartTime, 0);
            this.Controls.SetChildIndex(this.labelEndTime, 0);
            this.Controls.SetChildIndex(this.dateStart, 0);
            this.Controls.SetChildIndex(this.timeStart, 0);
            this.Controls.SetChildIndex(this.dateEnd, 0);
            this.Controls.SetChildIndex(this.timeEnd, 0);
            this.Controls.SetChildIndex(this.chkAllDay, 0);
            this.Controls.SetChildIndex(this.labelResource, 0);
            this.Controls.SetChildIndex(this.cmbResource, 0);
            this.Controls.SetChildIndex(this.radLabelReminder, 0);
            this.Controls.SetChildIndex(this.radDropDownListReminder, 0);
            this.Controls.SetChildIndex(this.labelStatus, 0);
            this.Controls.SetChildIndex(this.cmbShowTimeAs, 0);
            this.Controls.SetChildIndex(this.textBoxDescription, 0);
            this.Controls.SetChildIndex(this.buttonOK, 0);
            this.Controls.SetChildIndex(this.buttonCancel, 0);
            this.Controls.SetChildIndex(this.buttonDelete, 0);
            this.Controls.SetChildIndex(this.buttonRecurrence, 0);
            this.Controls.SetChildIndex(this.radSeparator1, 0);
            this.Controls.SetChildIndex(this.radSeparator2, 0);
            this.Controls.SetChildIndex(this.radSeparator3, 0);
            this.Controls.SetChildIndex(this.doneButton, 0);
            this.Controls.SetChildIndex(this.needsRepairsCheckBox, 0);
            ((System.ComponentModel.ISupportInitialize)(this.labelSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelStartTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelEndTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAllDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelResource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbResource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbShowTimeAs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonRecurrence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownListReminder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelReminder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doneButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.needsRepairsCheckBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton doneButton;
        private Telerik.WinControls.UI.RadCheckBox needsRepairsCheckBox;
    }
}

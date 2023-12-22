namespace CustomControls
{
    partial class DateNavigator
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
            this.rightNavigationButton = new Telerik.WinControls.UI.RadButton();
            this.leftNavigationButton = new Telerik.WinControls.UI.RadButton();
            this.dateLabel = new Telerik.WinControls.UI.RadLabel();
            this.navigatorDateTimePicker = new Telerik.WinControls.UI.RadDateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.rightNavigationButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftNavigationButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigatorDateTimePicker)).BeginInit();
            this.SuspendLayout();
            // 
            // rightNavigationButton
            // 
            this.rightNavigationButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightNavigationButton.Location = new System.Drawing.Point(240, 0);
            this.rightNavigationButton.Name = "rightNavigationButton";
            this.rightNavigationButton.Size = new System.Drawing.Size(30, 49);
            this.rightNavigationButton.TabIndex = 0;
            // 
            // leftNavigationButton
            // 
            this.leftNavigationButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.leftNavigationButton.Location = new System.Drawing.Point(210, 0);
            this.leftNavigationButton.Name = "leftNavigationButton";
            this.leftNavigationButton.Size = new System.Drawing.Size(30, 49);
            this.leftNavigationButton.TabIndex = 1;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = false;
            this.dateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateLabel.Location = new System.Drawing.Point(35, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(175, 49);
            this.dateLabel.TabIndex = 2;
            this.dateLabel.Text = "radLabel1";
            // 
            // navigatorDateTimePicker
            // 
            this.navigatorDateTimePicker.AutoSize = false;
            this.navigatorDateTimePicker.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigatorDateTimePicker.Location = new System.Drawing.Point(0, 0);
            this.navigatorDateTimePicker.Name = "navigatorDateTimePicker";
            this.navigatorDateTimePicker.Size = new System.Drawing.Size(35, 49);
            this.navigatorDateTimePicker.TabIndex = 3;
            this.navigatorDateTimePicker.TabStop = false;
            this.navigatorDateTimePicker.Text = "Thursday, May 18, 2017";
            this.navigatorDateTimePicker.Value = new System.DateTime(2017, 5, 18, 15, 37, 25, 339);
            // 
            // DateNavigator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.navigatorDateTimePicker);
            this.Controls.Add(this.leftNavigationButton);
            this.Controls.Add(this.rightNavigationButton);
            this.Name = "DateNavigator";
            this.Size = new System.Drawing.Size(270, 49);
            ((System.ComponentModel.ISupportInitialize)(this.rightNavigationButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftNavigationButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigatorDateTimePicker)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton rightNavigationButton;
        private Telerik.WinControls.UI.RadButton leftNavigationButton;
        private Telerik.WinControls.UI.RadLabel dateLabel;
        private Telerik.WinControls.UI.RadDateTimePicker navigatorDateTimePicker;


    }
}

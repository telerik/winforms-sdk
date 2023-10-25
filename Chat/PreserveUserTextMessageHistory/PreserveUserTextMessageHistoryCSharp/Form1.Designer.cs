namespace PreserveUserTextMessageHistory
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radListControl1 = new Telerik.WinControls.UI.RadListControl();
            this.radChat1 = new Telerik.WinControls.UI.RadChat();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radListControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radChat1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radListControl1
            // 
            this.radListControl1.ItemHeight = 24;
            this.radListControl1.Location = new System.Drawing.Point(12, 13);
            this.radListControl1.Name = "radListControl1";
            this.radListControl1.Size = new System.Drawing.Size(106, 213);
            this.radListControl1.TabIndex = 1;
            this.radListControl1.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.RadListControl1_SelectedIndexChanged);
            this.radListControl1.SelectedIndexChanging += new Telerik.WinControls.UI.Data.PositionChangingEventHandler(this.RadListControl1_SelectedIndexChanging);
            this.radListControl1.ItemDataBound += new Telerik.WinControls.UI.ListItemDataBoundEventHandler(this.RadListControl1_ItemDataBound);
            this.radListControl1.CreatingVisualListItem += new Telerik.WinControls.UI.CreatingVisualListItemEventHandler(this.radListControl1_CreatingVisualListItem);
            this.radListControl1.VisualItemFormatting += new Telerik.WinControls.UI.VisualListItemFormattingEventHandler(this.RadListControl1_VisualItemFormatting);
            // 
            // radChat1
            // 
            this.radChat1.Location = new System.Drawing.Point(128, 13);
            this.radChat1.Name = "radChat1";
            this.radChat1.Size = new System.Drawing.Size(350, 469);
            this.radChat1.TabIndex = 2;
            this.radChat1.Text = "radChat1";
            this.radChat1.TimeSeparatorInterval = System.TimeSpan.Parse("1.00:00:00");
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(12, 232);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(106, 86);
            this.radButton1.TabIndex = 3;
            this.radButton1.Text = "Simulate Message from Selected Member";
            this.radButton1.TextWrap = true;
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // radButton2
            // 
            this.radButton2.Location = new System.Drawing.Point(12, 339);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(106, 24);
            this.radButton2.TabIndex = 4;
            this.radButton2.Text = "Bob send message";
            this.radButton2.Click += new System.EventHandler(this.radButton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 494);
            this.Controls.Add(this.radButton2);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.radChat1);
            this.Controls.Add(this.radListControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.radListControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radChat1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }
        private Telerik.WinControls.UI.RadListControl radListControl1;
        private Telerik.WinControls.UI.RadChat radChat1;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadButton radButton2;
    }
}


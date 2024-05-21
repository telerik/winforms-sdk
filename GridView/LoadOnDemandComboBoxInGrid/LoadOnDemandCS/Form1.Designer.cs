//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;

using Telerik.WinControls.UI;
using Telerik.WinControls;

namespace SampleApp
{
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
	public partial class Form1 : System.Windows.Forms.Form
	{

		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;

		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.  
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.rgData = new Telerik.WinControls.UI.RadGridView();
			((System.ComponentModel.ISupportInitialize)this.rgData).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.rgData.MasterTemplate).BeginInit();
			this.SuspendLayout();
			//
			//rgData
			//
			this.rgData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rgData.Location = new System.Drawing.Point(0, 0);
			this.rgData.Name = "rgData";
			this.rgData.Size = new System.Drawing.Size(852, 481);
			this.rgData.TabIndex = 0;
			//
			//Form1
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(852, 481);
			this.Controls.Add(this.rgData);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)this.rgData.MasterTemplate).EndInit();
			((System.ComponentModel.ISupportInitialize)this.rgData).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

//INSTANT C# NOTE: Converted event handler wireups:
			rgData.CellEndEdit += new Telerik.WinControls.UI.GridViewCellEventHandler(rgData_CellEndEdit);
			rgData.EditorRequired += new Telerik.WinControls.UI.EditorRequiredEventHandler(rgData_EditorRequired);
			base.Load += new System.EventHandler(Form1_Load);

		}
		internal Telerik.WinControls.UI.RadGridView rgData;

	}

}
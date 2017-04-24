
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

partial class AboutBox : Form
{

	//Form overrides dispose to clean up the component list.
	[System.Diagnostics.DebuggerNonUserCode()]
	protected override void Dispose(bool disposing)
	{
		try {
			if (disposing && components != null) {
				components.Dispose();
			}
		} finally {
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBox));
		this.TextBox1 = new System.Windows.Forms.TextBox();
		this.SuspendLayout();
		//
		//TextBox1
		//
		this.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.TextBox1.Font = new System.Drawing.Font("Times New Roman", 14.25f, (System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic), System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
		this.TextBox1.Location = new System.Drawing.Point(9, 9);
		this.TextBox1.Multiline = true;
		this.TextBox1.Name = "TextBox1";
		this.TextBox1.ReadOnly = true;
		this.TextBox1.Size = new System.Drawing.Size(525, 230);
		this.TextBox1.TabIndex = 0;
		this.TextBox1.Text = resources.GetString("TextBox1.Text");
		//
		//AboutBox1
		//
		this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.ClientSize = new System.Drawing.Size(543, 248);
		this.Controls.Add(this.TextBox1);
		this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
		this.MaximizeBox = false;
		this.MinimizeBox = false;
		this.Name = "AboutBox1";
		this.Padding = new System.Windows.Forms.Padding(9);
		this.ShowInTaskbar = false;
		this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "About Kalkulasi Faroidh";
		this.ResumeLayout(false);
		this.PerformLayout();

	}

	internal TextBox TextBox1;
}

//=======================================================
//Service provided by Telerik (www.telerik.com)
//Conversion powered by NRefactory.
//Twitter: @telerik
//Facebook: facebook.com/telerik
//=======================================================

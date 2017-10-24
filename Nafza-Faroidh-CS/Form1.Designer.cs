
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing.Printing;

partial class Form1 : System.Windows.Forms.Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Label3 = new System.Windows.Forms.Label();
            this._ModeAulRodd = new System.Windows.Forms.CheckBox();
            this._Modal = new System.Windows.Forms.NumericUpDown();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this._Tabel = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this._Tingkat = new System.Windows.Forms.ComboBox();
            this._Nama = new System.Windows.Forms.TextBox();
            this._Sisa = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this._Total = new System.Windows.Forms.Label();
            this.Button2 = new System.Windows.Forms.Button();
            this._Submit = new System.Windows.Forms.Button();
            this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Button3 = new System.Windows.Forms.Button();
            this.PrintDiag = new System.Windows.Forms.PrintDialog();
            this.PrintDoc = new System.Drawing.Printing.PrintDocument();
            this.PrintPrev = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this._Modal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.TableLayoutPanel2.SuspendLayout();
            this.TableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label3.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(3, 192);
            this.Label3.MinimumSize = new System.Drawing.Size(0, 30);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(158, 33);
            this.Label3.TabIndex = 9;
            this.Label3.Text = "HARTA";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _ModeAulRodd
            // 
            this._ModeAulRodd.AutoSize = true;
            this._ModeAulRodd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this._ModeAulRodd.Checked = true;
            this._ModeAulRodd.CheckState = System.Windows.Forms.CheckState.Checked;
            this._ModeAulRodd.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ModeAulRodd.Location = new System.Drawing.Point(3, 261);
            this._ModeAulRodd.Name = "_ModeAulRodd";
            this._ModeAulRodd.Size = new System.Drawing.Size(158, 20);
            this._ModeAulRodd.TabIndex = 8;
            this._ModeAulRodd.Text = "Normal";
            this._ModeAulRodd.UseVisualStyleBackColor = false;
            this._ModeAulRodd.Click += new System.EventHandler(this._ModeAulRodd_CheckedChanged);
            // 
            // _Modal
            // 
            this._Modal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._Modal.Dock = System.Windows.Forms.DockStyle.Fill;
            this._Modal.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Modal.Increment = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this._Modal.Location = new System.Drawing.Point(3, 228);
            this._Modal.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this._Modal.MinimumSize = new System.Drawing.Size(4, 0);
            this._Modal.Name = "_Modal";
            this._Modal.Size = new System.Drawing.Size(158, 30);
            this._Modal.TabIndex = 4;
            this._Modal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._Modal.ThousandsSeparator = true;
            this._Modal.ValueChanged += new System.EventHandler(this._Modal_TextChanged);
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TableLayoutPanel2.SetColumnSpan(this.PictureBox1, 2);
            this.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(3, 3);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(638, 54);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 9;
            this.PictureBox1.TabStop = false;
            // 
            // _Tabel
            // 
            this._Tabel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2,
            this.ColumnHeader3,
            this.ColumnHeader4});
            this._Tabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._Tabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Tabel.FullRowSelect = true;
            this._Tabel.HideSelection = false;
            this._Tabel.Location = new System.Drawing.Point(167, 63);
            this._Tabel.Name = "_Tabel";
            this.TableLayoutPanel2.SetRowSpan(this._Tabel, 7);
            this._Tabel.Size = new System.Drawing.Size(474, 218);
            this._Tabel.TabIndex = 3;
            this._Tabel.UseCompatibleStateImageBehavior = false;
            this._Tabel.View = System.Windows.Forms.View.Details;
            this._Tabel.SelectedIndexChanged += new System.EventHandler(this._Tabel_SelectedIndexChanged);
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "NAMA";
            this.ColumnHeader1.Width = 62;
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "STATUS";
            this.ColumnHeader2.Width = 149;
            // 
            // ColumnHeader3
            // 
            this.ColumnHeader3.Text = "BAGIAN";
            this.ColumnHeader3.Width = 120;
            // 
            // ColumnHeader4
            // 
            this.ColumnHeader4.Text = "JATAH";
            this.ColumnHeader4.Width = 136;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(3, 126);
            this.Label2.MinimumSize = new System.Drawing.Size(0, 30);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(158, 33);
            this.Label2.TabIndex = 8;
            this.Label2.Text = "RINCIAN";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(3, 60);
            this.Label1.MinimumSize = new System.Drawing.Size(0, 35);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(158, 35);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "NAMA";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _Tingkat
            // 
            this._Tingkat.AllowDrop = true;
            this._Tingkat.Dock = System.Windows.Forms.DockStyle.Fill;
            this._Tingkat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._Tingkat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this._Tingkat.FormattingEnabled = true;
            this._Tingkat.IntegralHeight = false;
            this._Tingkat.ItemHeight = 15;
            this._Tingkat.Items.AddRange(new object[] {
            "------- KELUARGA ---------",
            "Bapak ",
            "Ibu ",
            "Kakek Shohih",
            "Nenek Shohihah",
            "Anak Lelaki ",
            "Anak Perempuan",
            "Cucu Lelaki dr Anak Lelaki",
            "Cucu Perempuan dr Anak Lelaki",
            "Suami ",
            "Istri ",
            "------- SAUDARA -----------",
            "Sdr Lelaki Sekandung",
            "Sdr Perempuan Sekandung ",
            "Sdr Lelaki Seayah ",
            "Sdr Perempuan Seayah ",
            "Anak Lelaki Sdr Lelaki Sekandung ",
            "Anak Lelaki Sdr Lelaki Seayah ",
            "Paman Sekandung",
            "Paman Seayah",
            "Anak Lelaki Paman Sekandung",
            "Anak Lelaki Paman Seayah",
            "Saudara Seibu",
            "----Wala\' (Pemerdeka Budak)----",
            "Pemerdeka"});
            this._Tingkat.Location = new System.Drawing.Point(3, 162);
            this._Tingkat.Name = "_Tingkat";
            this._Tingkat.Size = new System.Drawing.Size(158, 23);
            this._Tingkat.TabIndex = 5;
            // 
            // _Nama
            // 
            this._Nama.Dock = System.Windows.Forms.DockStyle.Fill;
            this._Nama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this._Nama.Location = new System.Drawing.Point(3, 96);
            this._Nama.Multiline = true;
            this._Nama.Name = "_Nama";
            this._Nama.Size = new System.Drawing.Size(158, 27);
            this._Nama.TabIndex = 1;
            // 
            // _Sisa
            // 
            this._Sisa.AutoSize = true;
            this._Sisa.Location = new System.Drawing.Point(3, 0);
            this._Sisa.Name = "_Sisa";
            this._Sisa.Size = new System.Drawing.Size(30, 13);
            this._Sisa.TabIndex = 7;
            this._Sisa.Text = "Sisa:";
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.Black;
            this.Button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button1.ForeColor = System.Drawing.Color.White;
            this.Button1.Location = new System.Drawing.Point(212, 3);
            this.Button1.Name = "Button1";
            this.TableLayoutPanel1.SetRowSpan(this.Button1, 2);
            this.Button1.Size = new System.Drawing.Size(73, 42);
            this.Button1.TabIndex = 11;
            this.Button1.Text = "Reset";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // _Total
            // 
            this._Total.AutoSize = true;
            this._Total.Location = new System.Drawing.Point(3, 24);
            this._Total.Name = "_Total";
            this._Total.Size = new System.Drawing.Size(34, 13);
            this._Total.TabIndex = 6;
            this._Total.Text = "Total:";
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.Color.Black;
            this.Button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button2.ForeColor = System.Drawing.Color.White;
            this.Button2.Location = new System.Drawing.Point(383, 3);
            this.Button2.Name = "Button2";
            this.TableLayoutPanel1.SetRowSpan(this.Button2, 2);
            this.Button2.Size = new System.Drawing.Size(88, 42);
            this.Button2.TabIndex = 10;
            this.Button2.Text = "About";
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // _Submit
            // 
            this._Submit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this._Submit.BackColor = System.Drawing.Color.Black;
            this._Submit.ForeColor = System.Drawing.Color.White;
            this._Submit.Location = new System.Drawing.Point(23, 287);
            this._Submit.Name = "_Submit";
            this._Submit.Size = new System.Drawing.Size(117, 48);
            this._Submit.TabIndex = 10;
            this._Submit.Text = "SUBMIT";
            this._Submit.UseVisualStyleBackColor = false;
            this._Submit.Click += new System.EventHandler(this._Submit_Click_1);
            // 
            // TableLayoutPanel2
            // 
            this.TableLayoutPanel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TableLayoutPanel2.ColumnCount = 2;
            this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.46584F));
            this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.53416F));
            this.TableLayoutPanel2.Controls.Add(this._Tingkat, 0, 4);
            this.TableLayoutPanel2.Controls.Add(this._Submit, 0, 8);
            this.TableLayoutPanel2.Controls.Add(this.Label1, 0, 1);
            this.TableLayoutPanel2.Controls.Add(this.PictureBox1, 0, 0);
            this.TableLayoutPanel2.Controls.Add(this.Label2, 0, 3);
            this.TableLayoutPanel2.Controls.Add(this._Nama, 0, 2);
            this.TableLayoutPanel2.Controls.Add(this._Tabel, 1, 1);
            this.TableLayoutPanel2.Controls.Add(this._ModeAulRodd, 0, 7);
            this.TableLayoutPanel2.Controls.Add(this.TableLayoutPanel1, 1, 8);
            this.TableLayoutPanel2.Controls.Add(this.Label3, 0, 5);
            this.TableLayoutPanel2.Controls.Add(this._Modal, 0, 6);
            this.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel2.Name = "TableLayoutPanel2";
            this.TableLayoutPanel2.RowCount = 9;
            this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TableLayoutPanel2.Size = new System.Drawing.Size(644, 338);
            this.TableLayoutPanel2.TabIndex = 10;
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TableLayoutPanel1.ColumnCount = 4;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.36842F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.63158F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.TableLayoutPanel1.Controls.Add(this.Button3, 2, 0);
            this.TableLayoutPanel1.Controls.Add(this._Total, 0, 1);
            this.TableLayoutPanel1.Controls.Add(this._Sisa, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.Button2, 3, 0);
            this.TableLayoutPanel1.Controls.Add(this.Button1, 1, 0);
            this.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel1.Location = new System.Drawing.Point(167, 287);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 2;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(474, 48);
            this.TableLayoutPanel1.TabIndex = 12;
            // 
            // Button3
            // 
            this.Button3.BackColor = System.Drawing.Color.Black;
            this.Button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button3.ForeColor = System.Drawing.Color.White;
            this.Button3.Location = new System.Drawing.Point(291, 3);
            this.Button3.Name = "Button3";
            this.TableLayoutPanel1.SetRowSpan(this.Button3, 2);
            this.Button3.Size = new System.Drawing.Size(86, 42);
            this.Button3.TabIndex = 12;
            this.Button3.Text = "Print";
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // PrintDiag
            // 
            this.PrintDiag.UseEXDialog = true;
            // 
            // PrintDoc
            // 
            this.PrintDoc.DocumentName = "Faroidh";
            // 
            // PrintPrev
            // 
            this.PrintPrev.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.PrintPrev.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.PrintPrev.ClientSize = new System.Drawing.Size(400, 300);
            this.PrintPrev.Document = this.PrintDoc;
            this.PrintPrev.Enabled = true;
            this.PrintPrev.Icon = ((System.Drawing.Icon)(resources.GetObject("PrintPrev.Icon")));
            this.PrintPrev.Name = "PrintPrev";
            this.PrintPrev.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 338);
            this.Controls.Add(this.TableLayoutPanel2);
            this.Name = "Form1";
            this.Text = "FAROIDH";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._Modal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.TableLayoutPanel2.ResumeLayout(false);
            this.TableLayoutPanel2.PerformLayout();
            this.TableLayoutPanel1.ResumeLayout(false);
            this.TableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

	}

	internal Label Label3;
	internal CheckBox _ModeAulRodd;
	internal ComboBox _Tingkat;
	internal Label Label1;
	internal ListView _Tabel;
	internal ColumnHeader ColumnHeader1;
	internal ColumnHeader ColumnHeader2;
	internal ColumnHeader ColumnHeader3;
	internal ColumnHeader ColumnHeader4;
	internal PictureBox PictureBox1;
	internal NumericUpDown _Modal;
	internal Label Label2;
	internal TextBox _Nama;
	internal Label _Sisa;
	internal Button Button1;
	internal TableLayoutPanel TableLayoutPanel2;
	internal Button _Submit;
	internal Button Button2;
	internal Label _Total;
	internal TableLayoutPanel TableLayoutPanel1;
	internal PrintDialog PrintDiag;
	internal PrintDocument PrintDoc;
	internal Button Button3;
	internal PrintPreviewDialog PrintPrev;
} 
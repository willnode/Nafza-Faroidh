<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label3 = New System.Windows.Forms.Label()
        Me._ModeAulRodd = New System.Windows.Forms.CheckBox()
        Me._Modal = New System.Windows.Forms.NumericUpDown()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me._Tabel = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me._Tingkat = New System.Windows.Forms.ComboBox()
        Me._Nama = New System.Windows.Forms.TextBox()
        Me._Sisa = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me._Total = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me._Submit = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PrintDiag = New System.Windows.Forms.PrintDialog()
        Me.PrintDoc = New System.Drawing.Printing.PrintDocument()
        Me.PrintPrev = New System.Windows.Forms.PrintPreviewDialog()
        CType(Me._Modal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 192)
        Me.Label3.MinimumSize = New System.Drawing.Size(0, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 33)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "HARTA"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '_ModeAulRodd
        '
        Me._ModeAulRodd.AutoSize = True
        Me._ModeAulRodd.BackColor = System.Drawing.SystemColors.ButtonFace
        Me._ModeAulRodd.Checked = True
        Me._ModeAulRodd.CheckState = System.Windows.Forms.CheckState.Checked
        Me._ModeAulRodd.Dock = System.Windows.Forms.DockStyle.Fill
        Me._ModeAulRodd.Location = New System.Drawing.Point(3, 261)
        Me._ModeAulRodd.Name = "_ModeAulRodd"
        Me._ModeAulRodd.Size = New System.Drawing.Size(158, 20)
        Me._ModeAulRodd.TabIndex = 8
        Me._ModeAulRodd.Text = "Normal"
        Me._ModeAulRodd.UseVisualStyleBackColor = False
        '
        '_Modal
        '
        Me._Modal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Modal.Dock = System.Windows.Forms.DockStyle.Fill
        Me._Modal.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Modal.Increment = New Decimal(New Integer() {2000, 0, 0, 0})
        Me._Modal.Location = New System.Drawing.Point(3, 228)
        Me._Modal.Maximum = New Decimal(New Integer() {-1530494977, 232830, 0, 0})
        Me._Modal.MinimumSize = New System.Drawing.Size(4, 0)
        Me._Modal.Name = "_Modal"
        Me._Modal.Size = New System.Drawing.Size(158, 30)
        Me._Modal.TabIndex = 4
        Me._Modal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me._Modal.ThousandsSeparator = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TableLayoutPanel2.SetColumnSpan(Me.PictureBox1, 2)
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(638, 54)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        '_Tabel
        '
        Me._Tabel.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me._Tabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me._Tabel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Tabel.FullRowSelect = True
        Me._Tabel.HideSelection = False
        Me._Tabel.Location = New System.Drawing.Point(167, 63)
        Me._Tabel.Name = "_Tabel"
        Me.TableLayoutPanel2.SetRowSpan(Me._Tabel, 7)
        Me._Tabel.Size = New System.Drawing.Size(474, 218)
        Me._Tabel.TabIndex = 3
        Me._Tabel.UseCompatibleStateImageBehavior = False
        Me._Tabel.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "NAMA"
        Me.ColumnHeader1.Width = 62
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "STATUS"
        Me.ColumnHeader2.Width = 149
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "BAGIAN"
        Me.ColumnHeader3.Width = 120
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "JATAH"
        Me.ColumnHeader4.Width = 136
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 126)
        Me.Label2.MinimumSize = New System.Drawing.Size(0, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 33)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "RINCIAN"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 60)
        Me.Label1.MinimumSize = New System.Drawing.Size(0, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 35)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "NAMA"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '_Tingkat
        '
        Me._Tingkat.AllowDrop = True
        Me._Tingkat.Dock = System.Windows.Forms.DockStyle.Fill
        Me._Tingkat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._Tingkat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me._Tingkat.FormattingEnabled = True
        Me._Tingkat.IntegralHeight = False
        Me._Tingkat.ItemHeight = 15
        Me._Tingkat.Items.AddRange(New Object() {"------- KELUARGA ---------", "Bapak ", "Ibu ", "Kakek Shohih", "Nenek Shohihah", "Anak Lelaki ", "Anak Perempuan", "Cucu Lelaki dr Anak Lelaki", "Cucu Perempuan dr Anak Lelaki", "Suami ", "Istri ", "------- SAUDARA -----------", "Sdr Lelaki Sekandung", "Sdr Perempuan Sekandung ", "Sdr Lelaki Seayah ", "Sdr Perempuan Seayah ", "Anak Lelaki Sdr Lelaki Sekandung ", "Anak Lelaki Sdr Lelaki Seayah ", "Paman Sekandung", "Paman Seayah", "Anak Lelaki Paman Sekandung", "Anak Lelaki Paman Seayah", "Saudara Seibu", "----Wala' (Pemerdeka Budak)----", "Pemerdeka"})
        Me._Tingkat.Location = New System.Drawing.Point(3, 162)
        Me._Tingkat.Name = "_Tingkat"
        Me._Tingkat.Size = New System.Drawing.Size(158, 23)
        Me._Tingkat.TabIndex = 5
        '
        '_Nama
        '
        Me._Nama.Dock = System.Windows.Forms.DockStyle.Fill
        Me._Nama.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me._Nama.Location = New System.Drawing.Point(3, 96)
        Me._Nama.Multiline = True
        Me._Nama.Name = "_Nama"
        Me._Nama.Size = New System.Drawing.Size(158, 27)
        Me._Nama.TabIndex = 1
        '
        '_Sisa
        '
        Me._Sisa.AutoSize = True
        Me._Sisa.Location = New System.Drawing.Point(3, 0)
        Me._Sisa.Name = "_Sisa"
        Me._Sisa.Size = New System.Drawing.Size(30, 13)
        Me._Sisa.TabIndex = 7
        Me._Sisa.Text = "Sisa:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(215, 3)
        Me.Button1.Name = "Button1"
        Me.TableLayoutPanel1.SetRowSpan(Me.Button1, 2)
        Me.Button1.Size = New System.Drawing.Size(74, 42)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Reset"
        Me.Button1.UseVisualStyleBackColor = False
        '
        '_Total
        '
        Me._Total.AutoSize = True
        Me._Total.Location = New System.Drawing.Point(3, 24)
        Me._Total.Name = "_Total"
        Me._Total.Size = New System.Drawing.Size(35, 13)
        Me._Total.TabIndex = 6
        Me._Total.Text = "Total:"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Black
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(387, 3)
        Me.Button2.Name = "Button2"
        Me.TableLayoutPanel1.SetRowSpan(Me.Button2, 2)
        Me.Button2.Size = New System.Drawing.Size(79, 42)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "About"
        Me.Button2.UseVisualStyleBackColor = False
        '
        '_Submit
        '
        Me._Submit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me._Submit.BackColor = System.Drawing.Color.Black
        Me._Submit.ForeColor = System.Drawing.Color.White
        Me._Submit.Location = New System.Drawing.Point(23, 287)
        Me._Submit.Name = "_Submit"
        Me._Submit.Size = New System.Drawing.Size(117, 48)
        Me._Submit.TabIndex = 10
        Me._Submit.Text = "SUBMIT"
        Me._Submit.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.46584!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.53416!))
        Me.TableLayoutPanel2.Controls.Add(Me._Tingkat, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me._Submit, 0, 8)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me._Nama, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me._Tabel, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me._ModeAulRodd, 0, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel1, 1, 8)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me._Modal, 0, 6)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 9
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(644, 338)
        Me.TableLayoutPanel2.TabIndex = 10
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.36842!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.63158!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Button3, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me._Total, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me._Sisa, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button2, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(167, 287)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(474, 48)
        Me.TableLayoutPanel1.TabIndex = 12
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Black
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(295, 3)
        Me.Button3.Name = "Button3"
        Me.TableLayoutPanel1.SetRowSpan(Me.Button3, 2)
        Me.Button3.Size = New System.Drawing.Size(83, 42)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Print"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'PrintDiag
        '
        Me.PrintDiag.UseEXDialog = True
        '
        'PrintDoc
        '
        Me.PrintDoc.DocumentName = "Faroidh"
        '
        'PrintPrev
        '
        Me.PrintPrev.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPrev.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPrev.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPrev.Document = Me.PrintDoc
        Me.PrintPrev.Enabled = True
        Me.PrintPrev.Icon = CType(resources.GetObject("PrintPrev.Icon"), System.Drawing.Icon)
        Me.PrintPrev.Name = "PrintPrev"
        Me.PrintPrev.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 338)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "FAROIDH"
        CType(Me._Modal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents _ModeAulRodd As CheckBox
    Friend WithEvents _Tingkat As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents _Tabel As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents _Modal As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents _Nama As TextBox
    Friend WithEvents _Sisa As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents _Submit As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents _Total As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PrintDiag As PrintDialog
    Friend WithEvents PrintDoc As Printing.PrintDocument
    Friend WithEvents Button3 As Button
    Friend WithEvents PrintPrev As PrintPreviewDialog
End Class

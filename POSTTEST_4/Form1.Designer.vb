<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(disposing As Boolean)
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
		components = New ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
		MenuStrip1 = New MenuStrip()
		InputDataToolStripMenuItem = New ToolStripMenuItem()
		LihatKartuToolStripMenuItem = New ToolStripMenuItem()
		SimpanDataToolStripMenuItem = New ToolStripMenuItem()
		BukaDataToolStripMenuItem = New ToolStripMenuItem()
		KeluarToolStripMenuItem = New ToolStripMenuItem()
		Label1 = New Label()
		PictureBox1 = New PictureBox()
		Panel1 = New Panel()
		Panel2 = New Panel()
		TabControl1 = New TabControl()
		TabPage1 = New TabPage()
		gbJK = New GroupBox()
		RadioButton8 = New RadioButton()
		RadioButton7 = New RadioButton()
		cboDivisi = New ComboBox()
		dttanggal = New DateTimePicker()
		txtID = New TextBox()
		Label6 = New Label()
		Label5 = New Label()
		Label4 = New Label()
		Label3 = New Label()
		Label2 = New Label()
		txtnama = New TextBox()
		TabPage2 = New TabPage()
		txtAlamat = New TextBox()
		msNoHP = New MaskedTextBox()
		txtEmail = New TextBox()
		Label9 = New Label()
		Label8 = New Label()
		Label7 = New Label()
		TabPage3 = New TabPage()
		btnCetak = New Button()
		gbHobi = New GroupBox()
		CheckBox8 = New CheckBox()
		CheckBox6 = New CheckBox()
		CheckBox7 = New CheckBox()
		CheckBox5 = New CheckBox()
		CheckBox4 = New CheckBox()
		CheckBox3 = New CheckBox()
		CheckBox2 = New CheckBox()
		CheckBox1 = New CheckBox()
		gbJabatan = New GroupBox()
		RadioButton6 = New RadioButton()
		RadioButton5 = New RadioButton()
		RadioButton4 = New RadioButton()
		RadioButton3 = New RadioButton()
		RadioButton2 = New RadioButton()
		RadioButton1 = New RadioButton()
		btnBrowse = New Button()
		pcUpload = New PictureBox()
		OpenFileDialog1 = New OpenFileDialog()
		SaveFileDialog1 = New SaveFileDialog()
		ErrorProvider1 = New ErrorProvider(components)
		MenuStrip1.SuspendLayout()
		CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
		Panel1.SuspendLayout()
		Panel2.SuspendLayout()
		TabControl1.SuspendLayout()
		TabPage1.SuspendLayout()
		gbJK.SuspendLayout()
		TabPage2.SuspendLayout()
		TabPage3.SuspendLayout()
		gbHobi.SuspendLayout()
		gbJabatan.SuspendLayout()
		CType(pcUpload, ComponentModel.ISupportInitialize).BeginInit()
		CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' MenuStrip1
		' 
		MenuStrip1.ImageScalingSize = New Size(20, 20)
		MenuStrip1.Items.AddRange(New ToolStripItem() {InputDataToolStripMenuItem, LihatKartuToolStripMenuItem, SimpanDataToolStripMenuItem, BukaDataToolStripMenuItem, KeluarToolStripMenuItem})
		MenuStrip1.Location = New Point(0, 0)
		MenuStrip1.Name = "MenuStrip1"
		MenuStrip1.Size = New Size(800, 28)
		MenuStrip1.TabIndex = 0
		MenuStrip1.Text = "MenuStrip1"
		' 
		' InputDataToolStripMenuItem
		' 
		InputDataToolStripMenuItem.Name = "InputDataToolStripMenuItem"
		InputDataToolStripMenuItem.Size = New Size(93, 24)
		InputDataToolStripMenuItem.Text = "Input Data"
		' 
		' LihatKartuToolStripMenuItem
		' 
		LihatKartuToolStripMenuItem.Name = "LihatKartuToolStripMenuItem"
		LihatKartuToolStripMenuItem.Size = New Size(94, 24)
		LihatKartuToolStripMenuItem.Text = "Lihat Kartu"
		' 
		' SimpanDataToolStripMenuItem
		' 
		SimpanDataToolStripMenuItem.Name = "SimpanDataToolStripMenuItem"
		SimpanDataToolStripMenuItem.Size = New Size(109, 24)
		SimpanDataToolStripMenuItem.Text = "Simpan Data"
		' 
		' BukaDataToolStripMenuItem
		' 
		BukaDataToolStripMenuItem.Name = "BukaDataToolStripMenuItem"
		BukaDataToolStripMenuItem.Size = New Size(91, 24)
		BukaDataToolStripMenuItem.Text = "Buka Data"
		' 
		' KeluarToolStripMenuItem
		' 
		KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
		KeluarToolStripMenuItem.Size = New Size(65, 24)
		KeluarToolStripMenuItem.Text = "Keluar"
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.BackColor = Color.Black
		Label1.Font = New Font("Microsoft Sans Serif", 18.0F, FontStyle.Bold)
		Label1.ForeColor = Color.FromArgb(255, 215, 0)
		Label1.Location = New Point(167, 32)
		Label1.Name = "Label1"
		Label1.Size = New Size(410, 36)
		Label1.TabIndex = 1
		Label1.Text = "Digital Membership Card " + ChrW(55358) + ChrW(57002)
		Label1.TextAlign = ContentAlignment.MiddleCenter
		' 
		' PictureBox1
		' 
		PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
		PictureBox1.Location = New Point(40, 45)
		PictureBox1.Name = "PictureBox1"
		PictureBox1.Size = New Size(105, 62)
		PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
		PictureBox1.TabIndex = 2
		PictureBox1.TabStop = False
		' 
		' Panel1
		' 
		Panel1.BackColor = Color.Goldenrod
		Panel1.Controls.Add(Label1)
		Panel1.Location = New Point(0, 26)
		Panel1.Name = "Panel1"
		Panel1.Size = New Size(800, 102)
		Panel1.TabIndex = 3
		' 
		' Panel2
		' 
		Panel2.BackColor = Color.Black
		Panel2.Controls.Add(TabControl1)
		Panel2.Location = New Point(0, 124)
		Panel2.Name = "Panel2"
		Panel2.Size = New Size(800, 392)
		Panel2.TabIndex = 4
		' 
		' TabControl1
		' 
		TabControl1.Controls.Add(TabPage1)
		TabControl1.Controls.Add(TabPage2)
		TabControl1.Controls.Add(TabPage3)
		TabControl1.Location = New Point(13, 10)
		TabControl1.Name = "TabControl1"
		TabControl1.SelectedIndex = 0
		TabControl1.Size = New Size(716, 360)
		TabControl1.TabIndex = 0
		' 
		' TabPage1
		' 
		TabPage1.BackColor = SystemColors.Info
		TabPage1.Controls.Add(gbJK)
		TabPage1.Controls.Add(cboDivisi)
		TabPage1.Controls.Add(dttanggal)
		TabPage1.Controls.Add(txtID)
		TabPage1.Controls.Add(Label6)
		TabPage1.Controls.Add(Label5)
		TabPage1.Controls.Add(Label4)
		TabPage1.Controls.Add(Label3)
		TabPage1.Controls.Add(Label2)
		TabPage1.Controls.Add(txtnama)
		TabPage1.ForeColor = SystemColors.ActiveCaptionText
		TabPage1.Location = New Point(4, 29)
		TabPage1.Name = "TabPage1"
		TabPage1.Padding = New Padding(3)
		TabPage1.Size = New Size(708, 327)
		TabPage1.TabIndex = 0
		TabPage1.Text = "Data Utama"
		' 
		' gbJK
		' 
		gbJK.Controls.Add(RadioButton8)
		gbJK.Controls.Add(RadioButton7)
		gbJK.Location = New Point(209, 163)
		gbJK.Name = "gbJK"
		gbJK.Size = New Size(250, 58)
		gbJK.TabIndex = 11
		gbJK.TabStop = False
		' 
		' RadioButton8
		' 
		RadioButton8.AutoSize = True
		RadioButton8.Location = New Point(129, 26)
		RadioButton8.Name = "RadioButton8"
		RadioButton8.Size = New Size(104, 24)
		RadioButton8.TabIndex = 1
		RadioButton8.TabStop = True
		RadioButton8.Text = "Perempuan"
		RadioButton8.UseVisualStyleBackColor = True
		' 
		' RadioButton7
		' 
		RadioButton7.AutoSize = True
		RadioButton7.Location = New Point(6, 26)
		RadioButton7.Name = "RadioButton7"
		RadioButton7.Size = New Size(85, 24)
		RadioButton7.TabIndex = 0
		RadioButton7.TabStop = True
		RadioButton7.Text = "Laki-laki"
		RadioButton7.UseVisualStyleBackColor = True
		' 
		' cboDivisi
		' 
		cboDivisi.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0)
		cboDivisi.FormattingEnabled = True
		cboDivisi.Items.AddRange(New Object() {"Ketua", "Sekretaris", "Bendahara", "KPSMD", "MBKM", "SOSHUMAS", "ADVOKESMA", "MEDIKRAF", "ADSI", "KWH"})
		cboDivisi.Location = New Point(209, 227)
		cboDivisi.Name = "cboDivisi"
		cboDivisi.Size = New Size(250, 27)
		cboDivisi.TabIndex = 10
		' 
		' dttanggal
		' 
		dttanggal.Location = New Point(209, 130)
		dttanggal.Name = "dttanggal"
		dttanggal.Size = New Size(250, 27)
		dttanggal.TabIndex = 7
		' 
		' txtID
		' 
		txtID.BorderStyle = BorderStyle.FixedSingle
		txtID.Font = New Font("Times New Roman", 10.2F)
		txtID.Location = New Point(209, 85)
		txtID.Name = "txtID"
		txtID.Size = New Size(250, 27)
		txtID.TabIndex = 6
		' 
		' Label6
		' 
		Label6.AutoSize = True
		Label6.Font = New Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0)
		Label6.ForeColor = SystemColors.ActiveCaptionText
		Label6.Location = New Point(33, 230)
		Label6.Name = "Label6"
		Label6.Size = New Size(53, 20)
		Label6.TabIndex = 5
		Label6.Text = "Divisi"
		' 
		' Label5
		' 
		Label5.AutoSize = True
		Label5.Font = New Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0)
		Label5.ForeColor = SystemColors.ActiveCaptionText
		Label5.Location = New Point(33, 182)
		Label5.Name = "Label5"
		Label5.Size = New Size(116, 20)
		Label5.TabIndex = 4
		Label5.Text = "Jenis Kelamin"
		' 
		' Label4
		' 
		Label4.AutoSize = True
		Label4.Font = New Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0)
		Label4.ForeColor = SystemColors.ActiveCaptionText
		Label4.Location = New Point(33, 135)
		Label4.Name = "Label4"
		Label4.Size = New Size(115, 20)
		Label4.TabIndex = 3
		Label4.Text = "Tanggal Lahir"
		' 
		' Label3
		' 
		Label3.AutoSize = True
		Label3.Font = New Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0)
		Label3.ForeColor = SystemColors.ActiveCaptionText
		Label3.Location = New Point(33, 87)
		Label3.Name = "Label3"
		Label3.Size = New Size(95, 20)
		Label3.TabIndex = 2
		Label3.Text = "ID Anggota"
		' 
		' Label2
		' 
		Label2.AutoSize = True
		Label2.Font = New Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0)
		Label2.ForeColor = SystemColors.ActiveCaptionText
		Label2.Location = New Point(33, 44)
		Label2.Name = "Label2"
		Label2.Size = New Size(54, 20)
		Label2.TabIndex = 1
		Label2.Text = "Nama"
		' 
		' txtnama
		' 
		txtnama.BorderStyle = BorderStyle.FixedSingle
		txtnama.Font = New Font("Times New Roman", 10.2F)
		txtnama.Location = New Point(209, 42)
		txtnama.Name = "txtnama"
		txtnama.Size = New Size(250, 27)
		txtnama.TabIndex = 0
		' 
		' TabPage2
		' 
		TabPage2.BackColor = Color.Beige
		TabPage2.Controls.Add(txtAlamat)
		TabPage2.Controls.Add(msNoHP)
		TabPage2.Controls.Add(txtEmail)
		TabPage2.Controls.Add(Label9)
		TabPage2.Controls.Add(Label8)
		TabPage2.Controls.Add(Label7)
		TabPage2.ForeColor = SystemColors.ActiveCaptionText
		TabPage2.Location = New Point(4, 29)
		TabPage2.Name = "TabPage2"
		TabPage2.Padding = New Padding(3)
		TabPage2.Size = New Size(708, 327)
		TabPage2.TabIndex = 1
		TabPage2.Text = "Kontak & Info"
		' 
		' txtAlamat
		' 
		txtAlamat.BorderStyle = BorderStyle.FixedSingle
		txtAlamat.Location = New Point(224, 183)
		txtAlamat.Name = "txtAlamat"
		txtAlamat.Size = New Size(258, 27)
		txtAlamat.TabIndex = 3
		' 
		' msNoHP
		' 
		msNoHP.Location = New Point(224, 50)
		msNoHP.Mask = "0000-0000-0000"
		msNoHP.Name = "msNoHP"
		msNoHP.Size = New Size(258, 27)
		msNoHP.TabIndex = 6
		' 
		' txtEmail
		' 
		txtEmail.BorderStyle = BorderStyle.FixedSingle
		txtEmail.Location = New Point(224, 120)
		txtEmail.Name = "txtEmail"
		txtEmail.Size = New Size(258, 27)
		txtEmail.TabIndex = 4
		' 
		' Label9
		' 
		Label9.AutoSize = True
		Label9.Font = New Font("Cambria", 10.2F, FontStyle.Bold)
		Label9.Location = New Point(46, 190)
		Label9.Name = "Label9"
		Label9.Size = New Size(64, 20)
		Label9.TabIndex = 2
		Label9.Text = "Alamat"
		' 
		' Label8
		' 
		Label8.AutoSize = True
		Label8.Font = New Font("Cambria", 10.2F, FontStyle.Bold)
		Label8.Location = New Point(46, 123)
		Label8.Name = "Label8"
		Label8.Size = New Size(53, 20)
		Label8.TabIndex = 1
		Label8.Text = "Email"
		' 
		' Label7
		' 
		Label7.AutoSize = True
		Label7.Font = New Font("Cambria", 10.2F, FontStyle.Bold)
		Label7.Location = New Point(46, 53)
		Label7.Name = "Label7"
		Label7.Size = New Size(131, 20)
		Label7.TabIndex = 0
		Label7.Text = "Nomor Telepon"
		' 
		' TabPage3
		' 
		TabPage3.BackColor = Color.Beige
		TabPage3.Controls.Add(btnCetak)
		TabPage3.Controls.Add(gbHobi)
		TabPage3.Controls.Add(gbJabatan)
		TabPage3.Controls.Add(btnBrowse)
		TabPage3.Controls.Add(pcUpload)
		TabPage3.ForeColor = SystemColors.ActiveCaptionText
		TabPage3.Location = New Point(4, 29)
		TabPage3.Name = "TabPage3"
		TabPage3.Padding = New Padding(3)
		TabPage3.Size = New Size(708, 327)
		TabPage3.TabIndex = 2
		TabPage3.Text = "Profil & Aktifitas"
		' 
		' btnCetak
		' 
		btnCetak.BackColor = SystemColors.ActiveCaption
		btnCetak.Location = New Point(243, 287)
		btnCetak.Name = "btnCetak"
		btnCetak.Size = New Size(414, 29)
		btnCetak.TabIndex = 7
		btnCetak.Text = "Simpan & Cetak Kartu"
		btnCetak.UseVisualStyleBackColor = False
		' 
		' gbHobi
		' 
		gbHobi.Controls.Add(CheckBox8)
		gbHobi.Controls.Add(CheckBox6)
		gbHobi.Controls.Add(CheckBox7)
		gbHobi.Controls.Add(CheckBox5)
		gbHobi.Controls.Add(CheckBox4)
		gbHobi.Controls.Add(CheckBox3)
		gbHobi.Controls.Add(CheckBox2)
		gbHobi.Controls.Add(CheckBox1)
		gbHobi.Location = New Point(243, 156)
		gbHobi.Name = "gbHobi"
		gbHobi.Size = New Size(414, 125)
		gbHobi.TabIndex = 6
		gbHobi.TabStop = False
		gbHobi.Text = "Hoby"
		' 
		' CheckBox8
		' 
		CheckBox8.AutoSize = True
		CheckBox8.Location = New Point(282, 56)
		CheckBox8.Name = "CheckBox8"
		CheckBox8.Size = New Size(83, 24)
		CheckBox8.TabIndex = 8
		CheckBox8.Text = "Gaming"
		CheckBox8.UseVisualStyleBackColor = True
		' 
		' CheckBox6
		' 
		CheckBox6.AutoSize = True
		CheckBox6.Location = New Point(282, 26)
		CheckBox6.Name = "CheckBox6"
		CheckBox6.Size = New Size(69, 24)
		CheckBox6.TabIndex = 7
		CheckBox6.Text = "Musik"
		CheckBox6.UseVisualStyleBackColor = True
		' 
		' CheckBox7
		' 
		CheckBox7.AutoSize = True
		CheckBox7.Location = New Point(150, 86)
		CheckBox7.Name = "CheckBox7"
		CheckBox7.Size = New Size(79, 24)
		CheckBox7.TabIndex = 6
		CheckBox7.Text = "Coding"
		CheckBox7.UseVisualStyleBackColor = True
		' 
		' CheckBox5
		' 
		CheckBox5.AutoSize = True
		CheckBox5.Location = New Point(150, 56)
		CheckBox5.Name = "CheckBox5"
		CheckBox5.Size = New Size(121, 24)
		CheckBox5.TabIndex = 4
		CheckBox5.Text = "Editing Video"
		CheckBox5.UseVisualStyleBackColor = True
		' 
		' CheckBox4
		' 
		CheckBox4.AutoSize = True
		CheckBox4.Location = New Point(150, 26)
		CheckBox4.Name = "CheckBox4"
		CheckBox4.Size = New Size(92, 24)
		CheckBox4.TabIndex = 3
		CheckBox4.Text = "Fotografi"
		CheckBox4.UseVisualStyleBackColor = True
		' 
		' CheckBox3
		' 
		CheckBox3.AutoSize = True
		CheckBox3.Location = New Point(18, 86)
		CheckBox3.Name = "CheckBox3"
		CheckBox3.Size = New Size(118, 24)
		CheckBox3.TabIndex = 2
		CheckBox3.Text = "Desain Grafis"
		CheckBox3.UseVisualStyleBackColor = True
		' 
		' CheckBox2
		' 
		CheckBox2.AutoSize = True
		CheckBox2.Location = New Point(18, 56)
		CheckBox2.Name = "CheckBox2"
		CheckBox2.Size = New Size(82, 24)
		CheckBox2.TabIndex = 1
		CheckBox2.Text = "Menulis"
		CheckBox2.UseVisualStyleBackColor = True
		' 
		' CheckBox1
		' 
		CheckBox1.AutoSize = True
		CheckBox1.Location = New Point(18, 26)
		CheckBox1.Name = "CheckBox1"
		CheckBox1.Size = New Size(97, 24)
		CheckBox1.TabIndex = 0
		CheckBox1.Text = "Membaca"
		CheckBox1.UseVisualStyleBackColor = True
		' 
		' gbJabatan
		' 
		gbJabatan.Controls.Add(RadioButton6)
		gbJabatan.Controls.Add(RadioButton5)
		gbJabatan.Controls.Add(RadioButton4)
		gbJabatan.Controls.Add(RadioButton3)
		gbJabatan.Controls.Add(RadioButton2)
		gbJabatan.Controls.Add(RadioButton1)
		gbJabatan.Location = New Point(243, 25)
		gbJabatan.Name = "gbJabatan"
		gbJabatan.Size = New Size(414, 125)
		gbJabatan.TabIndex = 2
		gbJabatan.TabStop = False
		gbJabatan.Text = "Jabatan"
		' 
		' RadioButton6
		' 
		RadioButton6.AutoSize = True
		RadioButton6.Location = New Point(181, 86)
		RadioButton6.Name = "RadioButton6"
		RadioButton6.Size = New Size(61, 24)
		RadioButton6.TabIndex = 5
		RadioButton6.TabStop = True
		RadioButton6.Text = "Staff"
		RadioButton6.UseVisualStyleBackColor = True
		' 
		' RadioButton5
		' 
		RadioButton5.AutoSize = True
		RadioButton5.Location = New Point(181, 56)
		RadioButton5.Name = "RadioButton5"
		RadioButton5.Size = New Size(116, 24)
		RadioButton5.TabIndex = 4
		RadioButton5.TabStop = True
		RadioButton5.Text = "Kepala Divisi"
		RadioButton5.UseVisualStyleBackColor = True
		' 
		' RadioButton4
		' 
		RadioButton4.AutoSize = True
		RadioButton4.Location = New Point(181, 26)
		RadioButton4.Name = "RadioButton4"
		RadioButton4.Size = New Size(101, 24)
		RadioButton4.TabIndex = 3
		RadioButton4.TabStop = True
		RadioButton4.Text = "Bendahara"
		RadioButton4.UseVisualStyleBackColor = True
		' 
		' RadioButton3
		' 
		RadioButton3.AutoSize = True
		RadioButton3.Location = New Point(18, 86)
		RadioButton3.Name = "RadioButton3"
		RadioButton3.Size = New Size(94, 24)
		RadioButton3.TabIndex = 2
		RadioButton3.TabStop = True
		RadioButton3.Text = "Sekretaris"
		RadioButton3.UseVisualStyleBackColor = True
		' 
		' RadioButton2
		' 
		RadioButton2.AutoSize = True
		RadioButton2.Location = New Point(18, 56)
		RadioButton2.Name = "RadioButton2"
		RadioButton2.Size = New Size(156, 24)
		RadioButton2.TabIndex = 1
		RadioButton2.TabStop = True
		RadioButton2.Text = "Wakil Ketua Umum"
		RadioButton2.UseVisualStyleBackColor = True
		' 
		' RadioButton1
		' 
		RadioButton1.AutoSize = True
		RadioButton1.Location = New Point(18, 26)
		RadioButton1.Name = "RadioButton1"
		RadioButton1.Size = New Size(114, 24)
		RadioButton1.TabIndex = 0
		RadioButton1.TabStop = True
		RadioButton1.Text = "Ketua umum"
		RadioButton1.UseVisualStyleBackColor = True
		' 
		' btnBrowse
		' 
		btnBrowse.BackColor = SystemColors.ActiveCaption
		btnBrowse.Location = New Point(67, 287)
		btnBrowse.Name = "btnBrowse"
		btnBrowse.Size = New Size(94, 29)
		btnBrowse.TabIndex = 1
		btnBrowse.Text = "Browse"
		btnBrowse.UseVisualStyleBackColor = False
		' 
		' pcUpload
		' 
		pcUpload.BackColor = SystemColors.ActiveCaption
		pcUpload.Location = New Point(23, 25)
		pcUpload.Name = "pcUpload"
		pcUpload.Size = New Size(172, 256)
		pcUpload.TabIndex = 0
		pcUpload.TabStop = False
		' 
		' OpenFileDialog1
		' 
		OpenFileDialog1.FileName = "OpenFileDialog1"
		' 
		' ErrorProvider1
		' 
		ErrorProvider1.ContainerControl = Me
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(8.0F, 20.0F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(800, 506)
		Controls.Add(Panel2)
		Controls.Add(PictureBox1)
		Controls.Add(MenuStrip1)
		Controls.Add(Panel1)
		MainMenuStrip = MenuStrip1
		Name = "Form1"
		Text = "Form1"
		MenuStrip1.ResumeLayout(False)
		MenuStrip1.PerformLayout()
		CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
		Panel1.ResumeLayout(False)
		Panel1.PerformLayout()
		Panel2.ResumeLayout(False)
		TabControl1.ResumeLayout(False)
		TabPage1.ResumeLayout(False)
		TabPage1.PerformLayout()
		gbJK.ResumeLayout(False)
		gbJK.PerformLayout()
		TabPage2.ResumeLayout(False)
		TabPage2.PerformLayout()
		TabPage3.ResumeLayout(False)
		gbHobi.ResumeLayout(False)
		gbHobi.PerformLayout()
		gbJabatan.ResumeLayout(False)
		gbJabatan.PerformLayout()
		CType(pcUpload, ComponentModel.ISupportInitialize).EndInit()
		CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
		PerformLayout()
	End Sub


	Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents InputDataToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents LihatKartuToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents SimpanDataToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents BukaDataToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents Label1 As Label
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents Panel1 As Panel
	Friend WithEvents Panel2 As Panel
	Friend WithEvents TabControl1 As TabControl
	Friend WithEvents TabPage1 As TabPage
	Friend WithEvents TabPage2 As TabPage
	Friend WithEvents TabPage3 As TabPage
	Friend WithEvents Label4 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents txtnama As TextBox
	Friend WithEvents Label6 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents txtID As TextBox
	Friend WithEvents dttanggal As DateTimePicker
	Friend WithEvents cboDivisi As ComboBox
	Friend WithEvents txtEmail As TextBox
	Friend WithEvents txtNoHP As TextBox
	Friend WithEvents Label9 As Label
	Friend WithEvents Label8 As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents msNoHP As MaskedTextBox
	Friend WithEvents btnBrowse As Button
	Friend WithEvents pcUpload As PictureBox
	Friend WithEvents gbJabatan As GroupBox
	Friend WithEvents RadioButton4 As RadioButton
	Friend WithEvents RadioButton3 As RadioButton
	Friend WithEvents RadioButton2 As RadioButton
	Friend WithEvents RadioButton1 As RadioButton
	Friend WithEvents RadioButton6 As RadioButton
	Friend WithEvents RadioButton5 As RadioButton
	Friend WithEvents gbHobi As GroupBox
	Friend WithEvents CheckBox4 As CheckBox
	Friend WithEvents CheckBox3 As CheckBox
	Friend WithEvents CheckBox2 As CheckBox
	Friend WithEvents CheckBox1 As CheckBox
	Friend WithEvents btnCetak As Button
	Friend WithEvents CheckBox8 As CheckBox
	Friend WithEvents CheckBox6 As CheckBox
	Friend WithEvents CheckBox7 As CheckBox
	Friend WithEvents CheckBox5 As CheckBox
	Friend WithEvents OpenFileDialog1 As OpenFileDialog
	Friend WithEvents SaveFileDialog1 As SaveFileDialog
	Friend WithEvents ErrorProvider1 As ErrorProvider
	Friend WithEvents txtAlamat As TextBox
	Friend WithEvents gbJK As GroupBox
	Friend WithEvents RadioButton8 As RadioButton
	Friend WithEvents RadioButton7 As RadioButton

End Class

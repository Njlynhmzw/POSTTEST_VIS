<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Formisi
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formisi))
		PictureBox1 = New PictureBox()
		btnbrowse = New Button()
		lblnama = New Label()
		lblumur = New Label()
		lbltgl = New Label()
		lblnotelp = New Label()
		lblalamat = New Label()
		gbjk = New GroupBox()
		RadioButton2 = New RadioButton()
		RadioButton1 = New RadioButton()
		gbhobby = New GroupBox()
		CheckBox10 = New CheckBox()
		CheckBox9 = New CheckBox()
		CheckBox8 = New CheckBox()
		CheckBox7 = New CheckBox()
		CheckBox6 = New CheckBox()
		CheckBox5 = New CheckBox()
		CheckBox4 = New CheckBox()
		CheckBox3 = New CheckBox()
		CheckBox2 = New CheckBox()
		CheckBox1 = New CheckBox()
		btncetak = New Button()
		txtnama = New TextBox()
		txtumur = New TextBox()
		txttelp = New TextBox()
		txtalamat = New TextBox()
		DateTimePicker1 = New DateTimePicker()
		PictureBox2 = New PictureBox()
		CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
		gbjk.SuspendLayout()
		gbhobby.SuspendLayout()
		CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' PictureBox1
		' 
		PictureBox1.Location = New Point(33, 37)
		PictureBox1.Name = "PictureBox1"
		PictureBox1.Size = New Size(185, 285)
		PictureBox1.TabIndex = 0
		PictureBox1.TabStop = False
		' 
		' btnbrowse
		' 
		btnbrowse.BackColor = SystemColors.Info
		btnbrowse.Location = New Point(74, 338)
		btnbrowse.Name = "btnbrowse"
		btnbrowse.Size = New Size(94, 29)
		btnbrowse.TabIndex = 1
		btnbrowse.Text = "Browse"
		btnbrowse.UseVisualStyleBackColor = False
		' 
		' lblnama
		' 
		lblnama.AutoSize = True
		lblnama.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
		lblnama.Font = New Font("Tahoma", 10.2F, FontStyle.Bold)
		lblnama.Location = New Point(257, 37)
		lblnama.Name = "lblnama"
		lblnama.Size = New Size(59, 21)
		lblnama.TabIndex = 2
		lblnama.Text = "Nama"
		' 
		' lblumur
		' 
		lblumur.AutoSize = True
		lblumur.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
		lblumur.Font = New Font("Tahoma", 10.2F, FontStyle.Bold)
		lblumur.Location = New Point(257, 71)
		lblumur.Name = "lblumur"
		lblumur.Size = New Size(57, 21)
		lblumur.TabIndex = 3
		lblumur.Text = "Umur"
		' 
		' lbltgl
		' 
		lbltgl.AutoSize = True
		lbltgl.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
		lbltgl.Font = New Font("Tahoma", 10.2F, FontStyle.Bold)
		lbltgl.Location = New Point(257, 110)
		lbltgl.Name = "lbltgl"
		lbltgl.Size = New Size(126, 21)
		lbltgl.TabIndex = 4
		lbltgl.Text = "Tanggal Lahir"
		' 
		' lblnotelp
		' 
		lblnotelp.AutoSize = True
		lblnotelp.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
		lblnotelp.Font = New Font("Tahoma", 10.2F, FontStyle.Bold)
		lblnotelp.Location = New Point(257, 150)
		lblnotelp.Name = "lblnotelp"
		lblnotelp.Size = New Size(97, 21)
		lblnotelp.TabIndex = 5
		lblnotelp.Text = "No Telpon"
		' 
		' lblalamat
		' 
		lblalamat.AutoSize = True
		lblalamat.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
		lblalamat.Font = New Font("Tahoma", 10.2F, FontStyle.Bold)
		lblalamat.Location = New Point(257, 191)
		lblalamat.Name = "lblalamat"
		lblalamat.Size = New Size(70, 21)
		lblalamat.TabIndex = 6
		lblalamat.Text = "Alamat"
		' 
		' gbjk
		' 
		gbjk.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
		gbjk.Controls.Add(RadioButton2)
		gbjk.Controls.Add(RadioButton1)
		gbjk.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
		gbjk.Location = New Point(257, 230)
		gbjk.Name = "gbjk"
		gbjk.Size = New Size(186, 111)
		gbjk.TabIndex = 7
		gbjk.TabStop = False
		gbjk.Text = "Jenis Kelamin"
		' 
		' RadioButton2
		' 
		RadioButton2.AutoSize = True
		RadioButton2.Location = New Point(16, 67)
		RadioButton2.Name = "RadioButton2"
		RadioButton2.Size = New Size(88, 24)
		RadioButton2.TabIndex = 1
		RadioButton2.TabStop = True
		RadioButton2.Text = "Laki-laki"
		RadioButton2.UseVisualStyleBackColor = True
		' 
		' RadioButton1
		' 
		RadioButton1.AutoSize = True
		RadioButton1.Location = New Point(16, 37)
		RadioButton1.Name = "RadioButton1"
		RadioButton1.Size = New Size(110, 24)
		RadioButton1.TabIndex = 0
		RadioButton1.TabStop = True
		RadioButton1.Text = "Perempuan"
		RadioButton1.UseVisualStyleBackColor = True
		' 
		' gbhobby
		' 
		gbhobby.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
		gbhobby.Controls.Add(CheckBox10)
		gbhobby.Controls.Add(CheckBox9)
		gbhobby.Controls.Add(CheckBox8)
		gbhobby.Controls.Add(CheckBox7)
		gbhobby.Controls.Add(CheckBox6)
		gbhobby.Controls.Add(CheckBox5)
		gbhobby.Controls.Add(CheckBox4)
		gbhobby.Controls.Add(CheckBox3)
		gbhobby.Controls.Add(CheckBox2)
		gbhobby.Controls.Add(CheckBox1)
		gbhobby.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
		gbhobby.Location = New Point(463, 230)
		gbhobby.Name = "gbhobby"
		gbhobby.Size = New Size(325, 163)
		gbhobby.TabIndex = 8
		gbhobby.TabStop = False
		gbhobby.Text = "Hobby"
		' 
		' CheckBox10
		' 
		CheckBox10.AutoSize = True
		CheckBox10.Location = New Point(6, 67)
		CheckBox10.Name = "CheckBox10"
		CheckBox10.Size = New Size(78, 24)
		CheckBox10.TabIndex = 9
		CheckBox10.Text = "coding"
		CheckBox10.UseVisualStyleBackColor = True
		' 
		' CheckBox9
		' 
		CheckBox9.AutoSize = True
		CheckBox9.Location = New Point(6, 97)
		CheckBox9.Name = "CheckBox9"
		CheckBox9.Size = New Size(95, 24)
		CheckBox9.TabIndex = 8
		CheckBox9.Text = "Traveling"
		CheckBox9.UseVisualStyleBackColor = True
		' 
		' CheckBox8
		' 
		CheckBox8.AutoSize = True
		CheckBox8.Location = New Point(6, 127)
		CheckBox8.Name = "CheckBox8"
		CheckBox8.Size = New Size(85, 24)
		CheckBox8.TabIndex = 7
		CheckBox8.Text = "Melukis"
		CheckBox8.UseVisualStyleBackColor = True
		' 
		' CheckBox7
		' 
		CheckBox7.AutoSize = True
		CheckBox7.Location = New Point(111, 36)
		CheckBox7.Name = "CheckBox7"
		CheckBox7.Size = New Size(80, 24)
		CheckBox7.TabIndex = 6
		CheckBox7.Text = "Menari"
		CheckBox7.UseVisualStyleBackColor = True
		' 
		' CheckBox6
		' 
		CheckBox6.AutoSize = True
		CheckBox6.Location = New Point(111, 96)
		CheckBox6.Name = "CheckBox6"
		CheckBox6.Size = New Size(86, 24)
		CheckBox6.TabIndex = 5
		CheckBox6.Text = "Gaming"
		CheckBox6.UseVisualStyleBackColor = True
		' 
		' CheckBox5
		' 
		CheckBox5.AutoSize = True
		CheckBox5.Location = New Point(210, 37)
		CheckBox5.Name = "CheckBox5"
		CheckBox5.Size = New Size(113, 24)
		CheckBox5.TabIndex = 4
		CheckBox5.Text = "Memancing"
		CheckBox5.UseVisualStyleBackColor = True
		' 
		' CheckBox4
		' 
		CheckBox4.AutoSize = True
		CheckBox4.Location = New Point(112, 126)
		CheckBox4.Name = "CheckBox4"
		CheckBox4.Size = New Size(99, 24)
		CheckBox4.TabIndex = 3
		CheckBox4.Text = "Membaca"
		CheckBox4.UseVisualStyleBackColor = True
		' 
		' CheckBox3
		' 
		CheckBox3.AutoSize = True
		CheckBox3.Location = New Point(210, 67)
		CheckBox3.Name = "CheckBox3"
		CheckBox3.Size = New Size(99, 24)
		CheckBox3.TabIndex = 2
		CheckBox3.Text = "Menyanyi"
		CheckBox3.UseVisualStyleBackColor = True
		' 
		' CheckBox2
		' 
		CheckBox2.AutoSize = True
		CheckBox2.Location = New Point(111, 67)
		CheckBox2.Name = "CheckBox2"
		CheckBox2.Size = New Size(86, 24)
		CheckBox2.TabIndex = 1
		CheckBox2.Text = "Gaming"
		CheckBox2.UseVisualStyleBackColor = True
		' 
		' CheckBox1
		' 
		CheckBox1.AutoSize = True
		CheckBox1.Location = New Point(6, 37)
		CheckBox1.Name = "CheckBox1"
		CheckBox1.Size = New Size(86, 24)
		CheckBox1.TabIndex = 0
		CheckBox1.Text = "Gaming"
		CheckBox1.UseVisualStyleBackColor = True
		' 
		' btncetak
		' 
		btncetak.BackColor = SystemColors.Info
		btncetak.Location = New Point(257, 409)
		btncetak.Name = "btncetak"
		btncetak.Size = New Size(525, 29)
		btncetak.TabIndex = 9
		btncetak.Text = "Cetak Kartu"
		btncetak.UseVisualStyleBackColor = False
		' 
		' txtnama
		' 
		txtnama.BorderStyle = BorderStyle.FixedSingle
		txtnama.Location = New Point(421, 30)
		txtnama.Name = "txtnama"
		txtnama.Size = New Size(251, 27)
		txtnama.TabIndex = 10
		' 
		' txtumur
		' 
		txtumur.BorderStyle = BorderStyle.FixedSingle
		txtumur.Location = New Point(421, 69)
		txtumur.Name = "txtumur"
		txtumur.Size = New Size(251, 27)
		txtumur.TabIndex = 11
		' 
		' txttelp
		' 
		txttelp.BorderStyle = BorderStyle.FixedSingle
		txttelp.Location = New Point(421, 148)
		txttelp.Name = "txttelp"
		txttelp.Size = New Size(251, 27)
		txttelp.TabIndex = 12
		' 
		' txtalamat
		' 
		txtalamat.BorderStyle = BorderStyle.FixedSingle
		txtalamat.Location = New Point(421, 189)
		txtalamat.Name = "txtalamat"
		txtalamat.Size = New Size(251, 27)
		txtalamat.TabIndex = 13
		' 
		' DateTimePicker1
		' 
		DateTimePicker1.Location = New Point(421, 105)
		DateTimePicker1.Name = "DateTimePicker1"
		DateTimePicker1.Size = New Size(251, 27)
		DateTimePicker1.TabIndex = 14
		' 
		' PictureBox2
		' 
		PictureBox2.BackColor = Color.Transparent
		PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
		PictureBox2.Location = New Point(-49, -28)
		PictureBox2.Name = "PictureBox2"
		PictureBox2.Size = New Size(912, 505)
		PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
		PictureBox2.TabIndex = 15
		PictureBox2.TabStop = False
		' 
		' Formisi
		' 
		AutoScaleDimensions = New SizeF(8.0F, 20.0F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(800, 450)
		Controls.Add(DateTimePicker1)
		Controls.Add(txtalamat)
		Controls.Add(txttelp)
		Controls.Add(txtumur)
		Controls.Add(txtnama)
		Controls.Add(btncetak)
		Controls.Add(gbhobby)
		Controls.Add(gbjk)
		Controls.Add(lblalamat)
		Controls.Add(lblnotelp)
		Controls.Add(lbltgl)
		Controls.Add(lblumur)
		Controls.Add(lblnama)
		Controls.Add(btnbrowse)
		Controls.Add(PictureBox1)
		Controls.Add(PictureBox2)
		Name = "Formisi"
		Text = "Form1"
		CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
		gbjk.ResumeLayout(False)
		gbjk.PerformLayout()
		gbhobby.ResumeLayout(False)
		gbhobby.PerformLayout()
		CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents btnbrowse As Button
	Friend WithEvents lblnama As Label
	Friend WithEvents lblumur As Label
	Friend WithEvents lbltgl As Label
	Friend WithEvents lblnotelp As Label
	Friend WithEvents lblalamat As Label
	Friend WithEvents gbjk As GroupBox
	Friend WithEvents gbhobby As GroupBox
	Friend WithEvents RadioButton2 As RadioButton
	Friend WithEvents RadioButton1 As RadioButton
	Friend WithEvents CheckBox10 As CheckBox
	Friend WithEvents CheckBox9 As CheckBox
	Friend WithEvents CheckBox8 As CheckBox
	Friend WithEvents CheckBox7 As CheckBox
	Friend WithEvents CheckBox6 As CheckBox
	Friend WithEvents CheckBox5 As CheckBox
	Friend WithEvents CheckBox4 As CheckBox
	Friend WithEvents CheckBox3 As CheckBox
	Friend WithEvents CheckBox2 As CheckBox
	Friend WithEvents CheckBox1 As CheckBox
	Friend WithEvents btncetak As Button
	Friend WithEvents txtnama As TextBox
	Friend WithEvents txtumur As TextBox
	Friend WithEvents txttelp As TextBox
	Friend WithEvents txtalamat As TextBox
	Friend WithEvents DateTimePicker1 As DateTimePicker
	Friend WithEvents PictureBox2 As PictureBox

End Class

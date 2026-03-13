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
		GroupBox1 = New GroupBox()
		txtgenre = New TextBox()
		txtjudul = New TextBox()
		btntambah = New Button()
		lblgenre = New Label()
		lbljudul = New Label()
		GroupBox2 = New GroupBox()
		txtjudulbuku = New TextBox()
		btnhapus = New Button()
		lbljudulbuku = New Label()
		ListBox1 = New ListBox()
		GroupBox1.SuspendLayout()
		GroupBox2.SuspendLayout()
		SuspendLayout()
		' 
		' GroupBox1
		' 
		GroupBox1.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
		GroupBox1.Controls.Add(txtgenre)
		GroupBox1.Controls.Add(txtjudul)
		GroupBox1.Controls.Add(btntambah)
		GroupBox1.Controls.Add(lblgenre)
		GroupBox1.Controls.Add(lbljudul)
		GroupBox1.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
		GroupBox1.Location = New Point(39, 38)
		GroupBox1.Name = "GroupBox1"
		GroupBox1.Size = New Size(328, 214)
		GroupBox1.TabIndex = 0
		GroupBox1.TabStop = False
		GroupBox1.Text = "Tambah Buku"
		' 
		' txtgenre
		' 
		txtgenre.BorderStyle = BorderStyle.FixedSingle
		txtgenre.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		txtgenre.Location = New Point(175, 117)
		txtgenre.Name = "txtgenre"
		txtgenre.Size = New Size(125, 30)
		txtgenre.TabIndex = 4
		' 
		' txtjudul
		' 
		txtjudul.BorderStyle = BorderStyle.FixedSingle
		txtjudul.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		txtjudul.Location = New Point(175, 52)
		txtjudul.Name = "txtjudul"
		txtjudul.Size = New Size(125, 30)
		txtjudul.TabIndex = 2
		' 
		' btntambah
		' 
		btntambah.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
		btntambah.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		btntambah.Location = New Point(206, 166)
		btntambah.Name = "btntambah"
		btntambah.Size = New Size(94, 29)
		btntambah.TabIndex = 3
		btntambah.Text = "Tambah"
		btntambah.UseVisualStyleBackColor = False
		' 
		' lblgenre
		' 
		lblgenre.AutoSize = True
		lblgenre.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblgenre.Location = New Point(29, 124)
		lblgenre.Name = "lblgenre"
		lblgenre.Size = New Size(56, 23)
		lblgenre.TabIndex = 1
		lblgenre.Text = "Genre"
		' 
		' lbljudul
		' 
		lbljudul.AutoSize = True
		lbljudul.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lbljudul.Location = New Point(29, 59)
		lbljudul.Name = "lbljudul"
		lbljudul.Size = New Size(95, 23)
		lbljudul.TabIndex = 0
		lbljudul.Text = "Judul buku"
		' 
		' GroupBox2
		' 
		GroupBox2.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
		GroupBox2.Controls.Add(txtjudulbuku)
		GroupBox2.Controls.Add(btnhapus)
		GroupBox2.Controls.Add(lbljudulbuku)
		GroupBox2.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
		GroupBox2.Location = New Point(441, 38)
		GroupBox2.Name = "GroupBox2"
		GroupBox2.Size = New Size(327, 214)
		GroupBox2.TabIndex = 1
		GroupBox2.TabStop = False
		GroupBox2.Text = "Hapus Buku"
		' 
		' txtjudulbuku
		' 
		txtjudulbuku.BorderStyle = BorderStyle.FixedSingle
		txtjudulbuku.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		txtjudulbuku.Location = New Point(184, 57)
		txtjudulbuku.Name = "txtjudulbuku"
		txtjudulbuku.Size = New Size(125, 30)
		txtjudulbuku.TabIndex = 5
		' 
		' btnhapus
		' 
		btnhapus.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
		btnhapus.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		btnhapus.Location = New Point(206, 166)
		btnhapus.Name = "btnhapus"
		btnhapus.Size = New Size(94, 29)
		btnhapus.TabIndex = 4
		btnhapus.Text = "Hapus"
		btnhapus.UseVisualStyleBackColor = False
		' 
		' lbljudulbuku
		' 
		lbljudulbuku.AutoSize = True
		lbljudulbuku.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lbljudulbuku.Location = New Point(35, 59)
		lbljudulbuku.Name = "lbljudulbuku"
		lbljudulbuku.Size = New Size(95, 23)
		lbljudulbuku.TabIndex = 2
		lbljudulbuku.Text = "Judul Buku"
		' 
		' ListBox1
		' 
		ListBox1.BackColor = SystemColors.Info
		ListBox1.BorderStyle = BorderStyle.FixedSingle
		ListBox1.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		ListBox1.FormattingEnabled = True
		ListBox1.Location = New Point(245, 273)
		ListBox1.Name = "ListBox1"
		ListBox1.Size = New Size(326, 154)
		ListBox1.TabIndex = 2
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(8.0F, 20.0F)
		AutoScaleMode = AutoScaleMode.Font
		BackColor = SystemColors.ActiveCaption
		ClientSize = New Size(800, 450)
		Controls.Add(ListBox1)
		Controls.Add(GroupBox2)
		Controls.Add(GroupBox1)
		Name = "Form1"
		Text = "Data Buku"
		GroupBox1.ResumeLayout(False)
		GroupBox1.PerformLayout()
		GroupBox2.ResumeLayout(False)
		GroupBox2.PerformLayout()
		ResumeLayout(False)
	End Sub

	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents lbljudulbuku As Label
	Friend WithEvents lblgenre As Label
	Friend WithEvents lbljudul As Label
	Friend WithEvents btntambah As Button
	Friend WithEvents btnhapus As Button
	Friend WithEvents txtgenre As TextBox
	Friend WithEvents txtjudul As TextBox
	Friend WithEvents txtjudulbuku As TextBox
	Friend WithEvents ListBox1 As ListBox

End Class

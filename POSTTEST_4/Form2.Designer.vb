<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
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
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
		Panel1 = New Panel()
		Label1 = New Label()
		PictureBox1 = New PictureBox()
		PcTampil = New PictureBox()
		lblData = New Label()
		lblKontak = New Label()
		lblJabatan = New Label()
		lblHobby = New Label()
		FlowLayoutPanel1 = New FlowLayoutPanel()
		Panel1.SuspendLayout()
		CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
		CType(PcTampil, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' Panel1
		' 
		Panel1.BackColor = Color.Goldenrod
		Panel1.Controls.Add(Label1)
		Panel1.Controls.Add(PictureBox1)
		Panel1.Location = New Point(-3, 0)
		Panel1.Name = "Panel1"
		Panel1.Size = New Size(810, 110)
		Panel1.TabIndex = 0
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.BackColor = Color.Black
		Label1.Font = New Font("Microsoft Sans Serif", 18.0F, FontStyle.Bold)
		Label1.ForeColor = Color.FromArgb(CByte(255), CByte(215), CByte(0))
		Label1.Location = New Point(185, 37)
		Label1.Name = "Label1"
		Label1.Size = New Size(410, 36)
		Label1.TabIndex = 4
		Label1.Text = "Digital Membership Card " & ChrW(55358) & ChrW(57002)
		Label1.TextAlign = ContentAlignment.MiddleCenter
		' 
		' PictureBox1
		' 
		PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
		PictureBox1.Location = New Point(48, 26)
		PictureBox1.Name = "PictureBox1"
		PictureBox1.Size = New Size(105, 62)
		PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
		PictureBox1.TabIndex = 3
		PictureBox1.TabStop = False
		' 
		' PcTampil
		' 
		PcTampil.BackColor = SystemColors.ActiveCaption
		PcTampil.Location = New Point(25, 140)
		PcTampil.Name = "PcTampil"
		PcTampil.Size = New Size(205, 284)
		PcTampil.TabIndex = 1
		PcTampil.TabStop = False
		' 
		' lblData
		' 
		lblData.AutoSize = True
		lblData.BackColor = Color.Black
		lblData.Font = New Font("Caladea", 10.2F, FontStyle.Bold)
		lblData.ForeColor = Color.Goldenrod
		lblData.Location = New Point(267, 152)
		lblData.Name = "lblData"
		lblData.Size = New Size(56, 20)
		lblData.TabIndex = 2
		lblData.Text = "Nama"
		' 
		' lblKontak
		' 
		lblKontak.AutoSize = True
		lblKontak.BackColor = Color.Black
		lblKontak.Font = New Font("Caladea", 10.2F, FontStyle.Bold)
		lblKontak.ForeColor = Color.Goldenrod
		lblKontak.Location = New Point(267, 286)
		lblKontak.Name = "lblKontak"
		lblKontak.Size = New Size(65, 20)
		lblKontak.TabIndex = 5
		lblKontak.Text = "Kontak"
		' 
		' lblJabatan
		' 
		lblJabatan.AutoSize = True
		lblJabatan.BackColor = Color.Black
		lblJabatan.Font = New Font("Caladea", 10.2F, FontStyle.Bold)
		lblJabatan.ForeColor = Color.Goldenrod
		lblJabatan.Location = New Point(267, 359)
		lblJabatan.Name = "lblJabatan"
		lblJabatan.Size = New Size(72, 20)
		lblJabatan.TabIndex = 6
		lblJabatan.Text = "Jabatan"
		' 
		' lblHobby
		' 
		lblHobby.AutoSize = True
		lblHobby.BackColor = Color.Black
		lblHobby.Font = New Font("Caladea", 10.2F, FontStyle.Bold)
		lblHobby.ForeColor = Color.Goldenrod
		lblHobby.Location = New Point(268, 402)
		lblHobby.Name = "lblHobby"
		lblHobby.Size = New Size(60, 20)
		lblHobby.TabIndex = 8
		lblHobby.Text = "Hobby"
		' 
		' FlowLayoutPanel1
		' 
		FlowLayoutPanel1.BackColor = SystemColors.ActiveCaptionText
		FlowLayoutPanel1.Location = New Point(-7, 108)
		FlowLayoutPanel1.Name = "FlowLayoutPanel1"
		FlowLayoutPanel1.Size = New Size(810, 380)
		FlowLayoutPanel1.TabIndex = 9
		' 
		' Form2
		' 
		AutoScaleDimensions = New SizeF(8.0F, 20.0F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(800, 450)
		Controls.Add(lblHobby)
		Controls.Add(lblJabatan)
		Controls.Add(lblKontak)
		Controls.Add(lblData)
		Controls.Add(PcTampil)
		Controls.Add(Panel1)
		Controls.Add(FlowLayoutPanel1)
		Name = "Form2"
		Text = "Form2"
		Panel1.ResumeLayout(False)
		Panel1.PerformLayout()
		CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
		CType(PcTampil, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents Panel1 As Panel
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents Label1 As Label
	Friend WithEvents PcTampil As PictureBox
	Friend WithEvents lblData As Label
	Friend WithEvents lblKontak As Label
	Friend WithEvents lblJabatan As Label
	Friend WithEvents lblHobby As Label
	Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
End Class

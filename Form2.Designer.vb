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
		PictureBox1 = New PictureBox()
		Label2 = New Label()
		Label3 = New Label()
		Label4 = New Label()
		Label5 = New Label()
		Label6 = New Label()
		Label1 = New Label()
		PictureBox2 = New PictureBox()
		PictureBox3 = New PictureBox()
		CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
		CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
		CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' PictureBox1
		' 
		PictureBox1.BackColor = Color.Transparent
		PictureBox1.Location = New Point(33, 63)
		PictureBox1.Name = "PictureBox1"
		PictureBox1.Size = New Size(210, 275)
		PictureBox1.TabIndex = 0
		PictureBox1.TabStop = False
		' 
		' Label2
		' 
		Label2.AutoSize = True
		Label2.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
		Label2.Font = New Font("Tahoma", 10.2F)
		Label2.ForeColor = SystemColors.ActiveCaptionText
		Label2.Location = New Point(286, 126)
		Label2.Name = "Label2"
		Label2.Size = New Size(58, 21)
		Label2.TabIndex = 2
		Label2.Text = "Label2"
		' 
		' Label3
		' 
		Label3.AutoSize = True
		Label3.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
		Label3.Font = New Font("Tahoma", 10.2F)
		Label3.ForeColor = SystemColors.ActiveCaptionText
		Label3.Location = New Point(286, 164)
		Label3.Name = "Label3"
		Label3.Size = New Size(58, 21)
		Label3.TabIndex = 3
		Label3.Text = "Label3"
		' 
		' Label4
		' 
		Label4.AutoSize = True
		Label4.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
		Label4.Font = New Font("Tahoma", 10.2F)
		Label4.ForeColor = SystemColors.ActiveCaptionText
		Label4.Location = New Point(286, 203)
		Label4.Name = "Label4"
		Label4.Size = New Size(58, 21)
		Label4.TabIndex = 4
		Label4.Text = "Label4"
		' 
		' Label5
		' 
		Label5.AutoSize = True
		Label5.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
		Label5.Font = New Font("Tahoma", 10.2F)
		Label5.ForeColor = SystemColors.ActiveCaptionText
		Label5.Location = New Point(286, 242)
		Label5.Name = "Label5"
		Label5.Size = New Size(58, 21)
		Label5.TabIndex = 5
		Label5.Text = "Label5"
		' 
		' Label6
		' 
		Label6.AutoSize = True
		Label6.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
		Label6.Font = New Font("Tahoma", 10.2F)
		Label6.ForeColor = SystemColors.ActiveCaptionText
		Label6.Location = New Point(286, 283)
		Label6.Name = "Label6"
		Label6.Size = New Size(58, 21)
		Label6.TabIndex = 6
		Label6.Text = "Label6"
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
		Label1.Font = New Font("Tahoma", 10.2F)
		Label1.ForeColor = SystemColors.ActiveCaptionText
		Label1.Location = New Point(286, 89)
		Label1.Name = "Label1"
		Label1.Size = New Size(58, 21)
		Label1.TabIndex = 1
		Label1.Text = "Label1"
		' 
		' PictureBox2
		' 
		PictureBox2.BackColor = Color.Transparent
		PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
		PictureBox2.Location = New Point(585, 63)
		PictureBox2.Name = "PictureBox2"
		PictureBox2.Size = New Size(181, 167)
		PictureBox2.TabIndex = 8
		PictureBox2.TabStop = False
		' 
		' PictureBox3
		' 
		PictureBox3.BackColor = Color.Transparent
		PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
		PictureBox3.Location = New Point(-21, -57)
		PictureBox3.Name = "PictureBox3"
		PictureBox3.Size = New Size(887, 636)
		PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
		PictureBox3.TabIndex = 9
		PictureBox3.TabStop = False
		' 
		' Form2
		' 
		AutoScaleDimensions = New SizeF(8F, 20F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(800, 450)
		Controls.Add(PictureBox2)
		Controls.Add(Label6)
		Controls.Add(Label5)
		Controls.Add(Label4)
		Controls.Add(Label3)
		Controls.Add(Label2)
		Controls.Add(Label1)
		Controls.Add(PictureBox1)
		Controls.Add(PictureBox3)
		Name = "Form2"
		Text = "Form Hasil"
		CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
		CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
		CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents PictureBox2 As PictureBox
	Friend WithEvents PictureBox3 As PictureBox
End Class

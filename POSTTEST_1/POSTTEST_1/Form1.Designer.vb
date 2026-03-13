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
		IP = New Label()
		txtIP = New TextBox()
		btnTambah = New Button()
		btnReset = New Button()
		txtIPK = New TextBox()
		HasilPredikat = New Label()
		IPK = New Label()
		SuspendLayout()
		' 
		' IP
		' 
		IP.AutoSize = True
		IP.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		IP.Location = New Point(128, 130)
		IP.Name = "IP"
		IP.Size = New Size(100, 23)
		IP.TabIndex = 0
		IP.Text = "IP Semester"
		' 
		' txtIP
		' 
		txtIP.BorderStyle = BorderStyle.FixedSingle
		txtIP.Location = New Point(249, 126)
		txtIP.Name = "txtIP"
		txtIP.Size = New Size(232, 27)
		txtIP.TabIndex = 2
		' 
		' btnTambah
		' 
		btnTambah.BackColor = SystemColors.ButtonFace
		btnTambah.Location = New Point(249, 173)
		btnTambah.Name = "btnTambah"
		btnTambah.Size = New Size(94, 29)
		btnTambah.TabIndex = 3
		btnTambah.Text = "Tambah"
		btnTambah.UseVisualStyleBackColor = False
		' 
		' btnReset
		' 
		btnReset.BackColor = SystemColors.ButtonFace
		btnReset.Location = New Point(381, 173)
		btnReset.Name = "btnReset"
		btnReset.Size = New Size(94, 29)
		btnReset.TabIndex = 4
		btnReset.Text = "Reset"
		btnReset.UseVisualStyleBackColor = False
		' 
		' txtIPK
		' 
		txtIPK.BorderStyle = BorderStyle.FixedSingle
		txtIPK.Location = New Point(249, 234)
		txtIPK.Name = "txtIPK"
		txtIPK.Size = New Size(226, 27)
		txtIPK.TabIndex = 5
		' 
		' HasilPredikat
		' 
		HasilPredikat.AutoSize = True
		HasilPredikat.Location = New Point(312, 299)
		HasilPredikat.Name = "HasilPredikat"
		HasilPredikat.Size = New Size(100, 20)
		HasilPredikat.TabIndex = 6
		HasilPredikat.Text = "Hasil Predikat"
		' 
		' IPK
		' 
		IPK.AutoSize = True
		IPK.BackColor = Color.Transparent
		IPK.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		IPK.ForeColor = Color.Black
		IPK.Location = New Point(128, 234)
		IPK.Name = "IPK"
		IPK.Size = New Size(104, 23)
		IPK.TabIndex = 7
		IPK.Text = "IP Kumulatif"
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(8.0F, 20.0F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(800, 450)
		Controls.Add(IPK)
		Controls.Add(HasilPredikat)
		Controls.Add(txtIPK)
		Controls.Add(btnReset)
		Controls.Add(btnTambah)
		Controls.Add(txtIP)
		Controls.Add(IP)
		ForeColor = SystemColors.Desktop
		Name = "Form1"
		Text = "Form1"
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents IP As Label
	Friend WithEvents txtIP As TextBox
	Friend WithEvents btnTambah As Button
	Friend WithEvents btnReset As Button
	Friend WithEvents txtIPK As TextBox
	Friend WithEvents HasilPredikat As Label
	Friend WithEvents IPK As Label

End Class

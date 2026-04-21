<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

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

	Friend WithEvents panelCenter As System.Windows.Forms.Panel
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents lblSubTitle As System.Windows.Forms.Label
    Friend WithEvents lblUserTag As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents lblPassTag As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnMasuk As System.Windows.Forms.Button
    Friend WithEvents lblFooter As System.Windows.Forms.Label

    Private components As System.ComponentModel.IContainer

	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		panelCenter = New Panel()
		lblWelcome = New Label()
		lblSubTitle = New Label()
		lblUserTag = New Label()
		txtUsername = New TextBox()
		lblPassTag = New Label()
		txtPassword = New TextBox()
		btnMasuk = New Button()
		lblFooter = New Label()
		panelCenter.SuspendLayout()
		SuspendLayout()

		panelCenter.BackColor = Color.White
		panelCenter.Controls.Add(lblWelcome)
		panelCenter.Controls.Add(lblSubTitle)
		panelCenter.Controls.Add(lblUserTag)
		panelCenter.Controls.Add(txtUsername)
		panelCenter.Controls.Add(lblPassTag)
		panelCenter.Controls.Add(txtPassword)
		panelCenter.Controls.Add(btnMasuk)
		panelCenter.Location = New Point(111, 40)
		panelCenter.Name = "panelCenter"
		panelCenter.Size = New Size(500, 310)
		panelCenter.TabIndex = 0

		lblWelcome.Font = New Font("Segoe UI Semibold", 20.0F, FontStyle.Bold)
		lblWelcome.ForeColor = Color.FromArgb(CByte(162), CByte(155), CByte(254))
		lblWelcome.Location = New Point(0, 15)
		lblWelcome.Name = "lblWelcome"
		lblWelcome.Size = New Size(500, 45)
		lblWelcome.TabIndex = 0
		lblWelcome.Text = "˚ʚ Novel Magic ɞ˚"
		lblWelcome.TextAlign = ContentAlignment.MiddleCenter

		lblSubTitle.Font = New Font("Segoe UI", 9.0F, FontStyle.Italic)
		lblSubTitle.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(200))
		lblSubTitle.Location = New Point(3, 60)
		lblSubTitle.Name = "lblSubTitle"
		lblSubTitle.Size = New Size(500, 25)
		lblSubTitle.TabIndex = 1
		lblSubTitle.Text = "Login dulu yuk ke store imyutt, cyutee, lucyuu"
		lblSubTitle.TextAlign = ContentAlignment.MiddleCenter

		lblUserTag.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
		lblUserTag.ForeColor = Color.FromArgb(CByte(255), CByte(159), CByte(243))
		lblUserTag.Location = New Point(100, 95)
		lblUserTag.Name = "lblUserTag"
		lblUserTag.Size = New Size(300, 20)
		lblUserTag.TabIndex = 2
		lblUserTag.Text = "Username ✨"

		txtUsername.BackColor = Color.GhostWhite
		txtUsername.BorderStyle = BorderStyle.FixedSingle
		txtUsername.Font = New Font("Segoe UI", 11.0F)
		txtUsername.Location = New Point(100, 115)
		txtUsername.Name = "txtUsername"
		txtUsername.Size = New Size(300, 32)
		txtUsername.TabIndex = 3

		lblPassTag.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
		lblPassTag.ForeColor = Color.FromArgb(CByte(255), CByte(159), CByte(243))
		lblPassTag.Location = New Point(100, 160)
		lblPassTag.Name = "lblPassTag"
		lblPassTag.Size = New Size(300, 20)
		lblPassTag.TabIndex = 4
		lblPassTag.Text = "Password 🔑"

		txtPassword.BackColor = Color.GhostWhite
		txtPassword.BorderStyle = BorderStyle.FixedSingle
		txtPassword.Font = New Font("Segoe UI", 11.0F)
		txtPassword.Location = New Point(100, 180)
		txtPassword.Name = "txtPassword"
		txtPassword.Size = New Size(300, 32)
		txtPassword.TabIndex = 5
		txtPassword.UseSystemPasswordChar = True

		btnMasuk.BackColor = Color.FromArgb(CByte(85), CByte(239), CByte(196))
		btnMasuk.Cursor = Cursors.Hand
		btnMasuk.FlatAppearance.BorderSize = 0
		btnMasuk.FlatStyle = FlatStyle.Flat
		btnMasuk.Font = New Font("Segoe UI Black", 11.0F)
		btnMasuk.ForeColor = Color.White
		btnMasuk.Location = New Point(100, 235)
		btnMasuk.Name = "btnMasuk"
		btnMasuk.Size = New Size(300, 45)
		btnMasuk.TabIndex = 6
		btnMasuk.Text = "Masuk"
		btnMasuk.UseVisualStyleBackColor = False

		lblFooter.Dock = DockStyle.Bottom
		lblFooter.Font = New Font("Segoe UI", 7.5F)
		lblFooter.ForeColor = Color.FromArgb(CByte(200), CByte(200), CByte(220))
		lblFooter.Location = New Point(0, 375)
		lblFooter.Name = "lblFooter"
		lblFooter.Size = New Size(722, 25)
		lblFooter.TabIndex = 1
		lblFooter.Text = "☁ Crafted with love for Book Lovers • 2026 ☁"
		lblFooter.TextAlign = ContentAlignment.MiddleCenter

		BackColor = Color.FromArgb(CByte(224), CByte(247), CByte(250))
		ClientSize = New Size(722, 400)
		Controls.Add(panelCenter)
		Controls.Add(lblFooter)
		FormBorderStyle = FormBorderStyle.FixedSingle
		MaximizeBox = False
		Name = "Form2"
		StartPosition = FormStartPosition.CenterScreen
		Text = "Sweet Login - Novel System"
		panelCenter.ResumeLayout(False)
		panelCenter.PerformLayout()
		ResumeLayout(False)
	End Sub
End Class
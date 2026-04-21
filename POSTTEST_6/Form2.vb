Public Class Form2
	Private Sub btnMasuk_Click(sender As Object, e As EventArgs) Handles btnMasuk.Click
		If txtUsername.Text = "nou" AndAlso txtPassword.Text = "066" Then
			MessageBox.Show("Login Berhasil! Selamat datang di sistem.", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)
			Form1.Show()
			Me.Hide()
		Else
			MessageBox.Show("Username atau Password salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End If
	End Sub

	Private Sub lblWelcome_Click(sender As Object, e As EventArgs) Handles lblWelcome.Click

	End Sub
End Class
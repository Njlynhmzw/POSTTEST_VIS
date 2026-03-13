Public Class Formisi
    Public Sub HanyaAngka(sender As Object, e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Sub HanyaHuruf(sender As Object, e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) OrElse Char.IsWhiteSpace(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtumur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtumur.KeyPress
        HanyaAngka(sender, e)
    End Sub

    Private Sub txttelp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttelp.KeyPress
        HanyaAngka(sender, e)
    End Sub

    Private Sub txtnama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnama.KeyPress
        HanyaHuruf(sender, e)
    End Sub

    Private Sub btnbrowse_Click(sender As Object, e As EventArgs) Handles btnbrowse.Click

        Dim buka As New OpenFileDialog
        buka.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"

        If buka.ShowDialog = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(buka.FileName)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        End If

    End Sub

    Private Sub btncetak_Click(sender As Object, e As EventArgs) Handles btncetak.Click

        If txtnama.Text = "" Or txtumur.Text = "" Or txttelp.Text = "" Or txtalamat.Text = "" Then
            MessageBox.Show("Inputan tidak boleh kosong")
            Exit Sub
        End If

        If RadioButton1.Checked = False And RadioButton2.Checked = False Then
            MessageBox.Show("Inputan tidak boleh kosong")
            Exit Sub
        End If

        If Not (CheckBox1.Checked Or CheckBox2.Checked Or CheckBox3.Checked Or CheckBox4.Checked Or CheckBox5.Checked Or CheckBox6.Checked Or CheckBox7.Checked Or CheckBox8.Checked Or CheckBox9.Checked Or CheckBox10.Checked) Then
            MessageBox.Show("Inputan tidak boleh kosong")
            Exit Sub
        End If

        Dim hobby As String = ""

        If CheckBox1.Checked Then hobby &= CheckBox1.Text & ", "
        If CheckBox2.Checked Then hobby &= CheckBox2.Text & ", "
        If CheckBox3.Checked Then hobby &= CheckBox3.Text & ", "
        If CheckBox4.Checked Then hobby &= CheckBox4.Text & ", "
        If CheckBox5.Checked Then hobby &= CheckBox5.Text & ", "
        If CheckBox6.Checked Then hobby &= CheckBox6.Text & ", "
        If CheckBox7.Checked Then hobby &= CheckBox7.Text & ", "
        If CheckBox8.Checked Then hobby &= CheckBox8.Text & ", "
        If CheckBox9.Checked Then hobby &= CheckBox9.Text & ", "
        If CheckBox10.Checked Then hobby &= CheckBox10.Text & ", "

        Form2.Label1.Text = txtnama.Text
        Form2.Label2.Text = txtumur.Text
        Form2.Label3.Text = DateTimePicker1.Text
        Form2.Label4.Text = txttelp.Text
        Form2.Label5.Text = hobby
        Form2.Label6.Text = txtalamat.Text

        Form2.PictureBox1.Image = PictureBox1.Image
        Form2.Show()

    End Sub

End Class
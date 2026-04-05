Public Class Form1

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		cboDivisi.Items.AddRange({
			"KPSDM", "MBKM", "SOSHUMAS",
			"ADVOKESMA", "MEDIKRAF", "ADSI", "KWH"
		})

		txtAlamat.Enabled = True
		txtAlamat.ReadOnly = False
	End Sub

	Private Sub txtnama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnama.KeyPress
		If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsWhiteSpace(e.KeyChar) Then
			e.Handled = True
		End If
	End Sub

	Private Sub txtNoHP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoHP.KeyPress
		If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
			e.Handled = True
		End If
	End Sub

	Private Sub txtnama_TextChanged(sender As Object, e As EventArgs) Handles txtnama.TextChanged
		If txtnama.Text = "" Then
			ErrorProvider1.SetError(txtnama, "Nama tidak boleh kosong")
		Else
			ErrorProvider1.SetError(txtnama, "")
		End If
	End Sub

	Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
		If Not txtEmail.Text.Contains("@") Then
			ErrorProvider1.SetError(txtEmail, "Email tidak valid")
		Else
			ErrorProvider1.SetError(txtEmail, "")
		End If
	End Sub

	Private Sub txtAlamat_TextChanged(sender As Object, e As EventArgs) Handles txtAlamat.TextChanged
		If txtAlamat.Text = "" Then
			ErrorProvider1.SetError(txtAlamat, "Alamat tidak boleh kosong")
		Else
			ErrorProvider1.SetError(txtAlamat, "")
		End If
	End Sub

	Private Function AmbilHobi() As String
		Dim hasil As String = ""

		For Each ctrl As Control In gbHobi.Controls
			If TypeOf ctrl Is CheckBox Then
				If CType(ctrl, CheckBox).Checked Then
					hasil &= ctrl.Text & ", "
				End If
			End If
		Next

		Return hasil.TrimEnd(", ".ToCharArray())
	End Function

	Private Function AmbilJabatan() As String
		For Each ctrl As Control In gbJabatan.Controls
			If TypeOf ctrl Is RadioButton Then
				If CType(ctrl, RadioButton).Checked Then
					Return ctrl.Text
				End If
			End If
		Next
		Return ""
	End Function

	Private Function AmbilJK() As String
		For Each ctrl As Control In gbJK.Controls
			If TypeOf ctrl Is RadioButton Then
				If CType(ctrl, RadioButton).Checked Then
					Return ctrl.Text
				End If
			End If
		Next
		Return ""
	End Function

	Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
		OpenFileDialog1.Filter = "Image Files|*.jpg;*.png;*.jpeg"

		If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
			pcUpload.Image = Image.FromFile(OpenFileDialog1.FileName)
		End If
	End Sub

	Private Sub SimpanDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpanDataToolStripMenuItem.Click

		If txtnama.Text = "" Or txtID.Text = "" Or txtNoHP.Text = "" Then
			MessageBox.Show("Data belum lengkap!", "Warning")
			Exit Sub
		End If

		Dim isi As String =
		"Nama:" & txtnama.Text & Environment.NewLine &
		"ID:" & txtID.Text & Environment.NewLine &
		"NoHP:" & txtNoHP.Text & Environment.NewLine &
		"Email:" & txtEmail.Text & Environment.NewLine &
		"Alamat:" & txtAlamat.Text & Environment.NewLine &
		"Divisi:" & cboDivisi.Text & Environment.NewLine &
		"Hobi:" & AmbilHobi() & Environment.NewLine &
		"Jabatan:" & AmbilJabatan()

		Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\data_member.txt"

		IO.File.WriteAllText(path, isi)

		MessageBox.Show("Data berhasil disimpan! Kartu akan ditampilkan 😍", "Sukses")

		Dim f As New Form2

		Dim Data As String =
			"Nama: " & txtnama.Text & vbCrLf &
			"ID Anggota: " & txtID.Text & vbCrLf &
			"Tanggal Lahir: " & dttanggal.Text & vbCrLf &
			"Jenis Kelamin: " & gbJK.Text & vbCrLf &
			"divisi: " & cboDivisi.Text & vbCrLf

		Dim kontak As String =
			"No Hp: " & msNoHP.Text & vbCrLf &
			"Almaat: " & txtAlamat.Text & vbCrLf &
			"Email: " & txtEmail.Text

		f.lblData.Text = Data
		f.lblKontak.Text = kontak
		f.lblHobby.Text = AmbilHobi()
		f.lblJabatan.Text = AmbilJabatan()

		If pcUpload.Image IsNot Nothing Then
			f.PictureBox1.Image = pcUpload.Image
		Else
			MessageBox.Show("Foto belum dipilih!", "Info")
		End If

		f.Show()

	End Sub

	Private Sub LihatKartuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatKartuToolStripMenuItem.Click

		If txtnama.Text = "" Then
			MessageBox.Show("Isi data dulu!", "Warning")
			Exit Sub
		End If

		Dim f As New Form2

		Dim Data As String =
			"Nama: " & txtnama.Text & vbCrLf &
			"ID Anggota: " & txtID.Text & vbCrLf &
			"Tanggal Lahir: " & dttanggal.Text & vbCrLf &
			"Jenis Kelamin: " & gbJK.Text & vbCrLf &
			"divisi: " & cboDivisi.Text & vbCrLf

		Dim kontak As String =
			"No Hp: " & msNoHP.Text & vbCrLf &
			"Almaat: " & txtAlamat.Text & vbCrLf &
			"Email: " & txtEmail.Text

		f.lblData.Text = Data
		f.lblKontak.Text = kontak
		f.lblHobby.Text = AmbilHobi()
		f.lblJabatan.Text = AmbilJabatan()

		If pcUpload.Image IsNot Nothing Then
			f.PcTampil.Image = pcUpload.Image
		End If

		f.Show()

	End Sub

	Private Sub BukaDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukaDataToolStripMenuItem.Click

		OpenFileDialog1.Filter = "Text File|*.txt"

		If OpenFileDialog1.ShowDialog() = DialogResult.OK Then

			Dim lines() As String = IO.File.ReadAllLines(OpenFileDialog1.FileName)

			For Each line As String In lines
				If line.StartsWith("Nama:") Then txtnama.Text = line.Replace("Nama:", "")
				If line.StartsWith("ID:") Then txtID.Text = line.Replace("ID:", "")
				If line.StartsWith("NoHP:") Then txtNoHP.Text = line.Replace("NoHP:", "")
				If line.StartsWith("Email:") Then txtEmail.Text = line.Replace("Email:", "")
				If line.StartsWith("Alamat:") Then txtAlamat.Text = line.Replace("Alamat:", "")
				If line.StartsWith("Komunitas:") Then cboDivisi.Text = line.Replace("Komunitas:", "")
			Next

			MessageBox.Show("Data berhasil dibuka!", "Info")

		End If

	End Sub

	Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click

		If MessageBox.Show("Yakin keluar?", "Konfirmasi",
						   MessageBoxButtons.YesNo) = DialogResult.Yes Then
			Application.Exit()
		End If

	End Sub

	Private Sub msNoHP_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles msNoHP.MaskInputRejected

	End Sub

End Class
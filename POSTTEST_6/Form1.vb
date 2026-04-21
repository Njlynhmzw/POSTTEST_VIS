Public Class Form1

    Sub Kosong()
        txtKodeNovel.Clear()
        txtJudul.Clear()
        txtHarga.Clear()
        txtSearch.Clear()
        ErrorProvider1.Clear()
        txtKodeNovel.Focus()
    End Sub

    Sub TampilData()
        dgvNovel.DataSource = GetAllNovel()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
        Kosong()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If Not ValidasiTextBox(ErrorProvider1, txtKodeNovel, "Kode kosong") Then Exit Sub
        If Not ValidasiTextBox(ErrorProvider1, txtJudul, "Judul kosong") Then Exit Sub
        If Not ValidasiTextBox(ErrorProvider1, txtHarga, "Harga kosong") Then Exit Sub

        If KodeSudahAda(txtKodeNovel.Text) Then
            MessageBox.Show("Kode sudah ada")
            Exit Sub
        End If

        If SimpanNovel(txtKodeNovel.Text, txtJudul.Text, CInt(txtHarga.Text)) Then
            MessageBox.Show("Data berhasil disimpan")
            TampilData()
            Kosong()
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If UbahNovel(txtKodeNovel.Text, txtJudul.Text, CInt(txtHarga.Text)) Then
            MessageBox.Show("Data berhasil diubah")
            TampilData()
            Kosong()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If HapusNovel(txtKodeNovel.Text) Then
            MessageBox.Show("Data berhasil dihapus")
            TampilData()
            Kosong()
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Kosong()
        TampilData()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        dgvNovel.DataSource = SearchNovel(txtSearch.Text)
    End Sub

    Private Sub dgvNovel_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvNovel.CellClick
        If e.RowIndex >= 0 Then
            txtKodeNovel.Text = dgvNovel.Rows(e.RowIndex).Cells("kodeNovel").Value.ToString()
            txtJudul.Text = dgvNovel.Rows(e.RowIndex).Cells("judul").Value.ToString()
            txtHarga.Text = dgvNovel.Rows(e.RowIndex).Cells("harga").Value.ToString()
        End If
    End Sub

    Private Sub txtHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHarga.KeyPress
        HanyaAngka(e)
    End Sub

    Private Sub btnPenjualan_Click(sender As Object, e As EventArgs) Handles btnPenjualan.Click
        Form3.Show()
    End Sub

End Class
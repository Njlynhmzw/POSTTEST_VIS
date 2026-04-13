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

        ErrorProvider1.Clear()

        If Not ValidasiTextBox(ErrorProvider1, txtKodeNovel, "Kode kosong") Then Exit Sub
        If Not ValidasiTextBox(ErrorProvider1, txtJudul, "Judul kosong") Then Exit Sub
        If Not ValidasiTextBox(ErrorProvider1, txtHarga, "Harga kosong") Then Exit Sub

        If KodeSudahAda(txtKodeNovel.Text) Then
            MsgBox("Kode sudah ada")
            Exit Sub
        End If

        If SimpanNovel(txtKodeNovel.Text, txtJudul.Text, CInt(txtHarga.Text)) Then
            MsgBox("Data tersimpan")
            TampilData()
            Kosong()
        End If

    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click

        ErrorProvider1.Clear()

        If Not ValidasiTextBox(ErrorProvider1, txtKodeNovel, "Kode kosong") Then Exit Sub
        If Not ValidasiTextBox(ErrorProvider1, txtJudul, "Judul kosong") Then Exit Sub
        If Not ValidasiTextBox(ErrorProvider1, txtHarga, "Harga kosong") Then Exit Sub

        If UbahNovel(txtKodeNovel.Text, txtJudul.Text, CInt(txtHarga.Text)) Then
            MsgBox("Data diubah")
            TampilData()
            Kosong()
        Else
            MsgBox("Data tidak ditemukan")
        End If

    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click

        If txtKodeNovel.Text = "" Then
            MsgBox("Pilih data dulu")
            Exit Sub
        End If

        If HapusNovel(txtKodeNovel.Text) Then
            MsgBox("Data dihapus")
            TampilData()
            Kosong()
        End If

    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Kosong()
        TampilData()
    End Sub

    Private Sub dgvNovel_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvNovel.CellClick
        If e.RowIndex >= 0 Then
            txtKodeNovel.Text = dgvNovel.Rows(e.RowIndex).Cells("kodeNovel").Value.ToString()
            txtJudul.Text = dgvNovel.Rows(e.RowIndex).Cells("judul").Value.ToString()
            txtHarga.Text = dgvNovel.Rows(e.RowIndex).Cells("harga").Value.ToString()
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text = "" Then
            TampilData()
        Else
            dgvNovel.DataSource = SearchNovel(txtSearch.Text)
        End If
    End Sub

    Private Sub txtHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHarga.KeyPress
        HanyaAngka(e)
    End Sub

End Class
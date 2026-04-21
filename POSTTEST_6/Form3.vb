Public Class Form3

    Sub LoadNovel()
        Dim dt As DataTable = GetAllNovel()

        cmbNovel.DataSource = dt
        cmbNovel.DisplayMember = "judul"
        cmbNovel.ValueMember = "kodeNovel"
    End Sub

    Sub Kosong()
        txtHarga.Clear()
        txtJumlah.Clear()
        txtTotal.Clear()
        txtJumlah.Focus()
    End Sub

    Sub TampilData()
        dgvPenjualan.DataSource = GetAllPenjualan()
        HitungGrandTotal()
    End Sub

    Sub HitungGrandTotal()
        Dim total As Integer = 0

        For Each row As DataGridViewRow In dgvPenjualan.Rows
            If Not row.IsNewRow AndAlso row.Cells("total").Value IsNot Nothing Then
                total += Val(row.Cells("total").Value)
            End If
        Next

        lblGrandTotal.Text = "Total Semua: Rp " & Format(total, "N0")
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadNovel()
        TampilData()
        Kosong()
    End Sub

    Private Sub cmbNovel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNovel.SelectedIndexChanged
        Try
            If cmbNovel.SelectedItem IsNot Nothing Then
                Dim row As DataRowView = CType(cmbNovel.SelectedItem, DataRowView)
                txtHarga.Text = row("harga").ToString()
            End If
        Catch
            txtHarga.Clear()
        End Try
    End Sub

    Private Sub txtJumlah_TextChanged(sender As Object, e As EventArgs) Handles txtJumlah.TextChanged

        If txtJumlah.Text = "" Then
            txtTotal.Clear()
            Exit Sub
        End If

        If IsNumeric(txtJumlah.Text) AndAlso IsNumeric(txtHarga.Text) Then
            Dim jumlah As Integer = Val(txtJumlah.Text)
            Dim harga As Integer = Val(txtHarga.Text)
            txtTotal.Text = (jumlah * harga).ToString()
        Else
            txtTotal.Clear()
        End If

    End Sub

    Private Sub txtJumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtJumlah.KeyPress
        HanyaAngka(e)
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

        If txtJumlah.Text.Trim() = "" Then
            MessageBox.Show("Jumlah tidak boleh kosong")
            txtJumlah.Focus()
            Exit Sub
        End If

        If txtTotal.Text.Trim() = "" Then
            MessageBox.Show("Total belum terhitung")
            Exit Sub
        End If

        Dim kode As String = cmbNovel.SelectedValue.ToString()
        Dim jumlah As Integer = Val(txtJumlah.Text)
        Dim total As Integer = Val(txtTotal.Text)

        If SimpanPenjualan(kode, jumlah, total) Then
            MessageBox.Show("Transaksi berhasil")
            TampilData()
            Kosong()
        End If

    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click

        If dgvPenjualan.CurrentRow Is Nothing Then
            MessageBox.Show("Pilih data yang ingin dihapus")
            Exit Sub
        End If

        Dim id As Integer = Val(dgvPenjualan.CurrentRow.Cells("id_jual").Value)

        Dim konfirmasi As DialogResult = MessageBox.Show(
            "Yakin ingin menghapus transaksi ini?",
            "Konfirmasi",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
        )

        If konfirmasi = DialogResult.Yes Then
            If HapusPenjualan(id) Then
                MessageBox.Show("Transaksi berhasil dihapus")
                TampilData()
            End If
        End If

    End Sub

End Class
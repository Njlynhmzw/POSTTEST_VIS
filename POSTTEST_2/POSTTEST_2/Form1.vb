Public Class Form1

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click

        TambahBuku(txtjudul.Text, txtgenre.Text)

        ListBox1.Items.Clear()
        ListBox1.Items.AddRange(TampilBuku.Split(vbCrLf))

        txtjudul.Clear()
        txtgenre.Clear()

    End Sub


    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click

        If CekBuku(txtjudulbuku.Text) = False Then

            MessageBox.Show("Judul buku tidak ada dalam daftar ", "Error")

        Else

            HapusBuku(txtjudulbuku.Text)

            ListBox1.Items.Clear()
            ListBox1.Items.AddRange(TampilBuku.Split(vbCrLf))

        End If

        txtjudulbuku.Clear()

    End Sub

End Class
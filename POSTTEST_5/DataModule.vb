Imports MySqlConnector

Module DataModule

    Public Function GetAllNovel() As DataTable
        Dim dt As New DataTable()

        Try
            Dim query As String = "SELECT kodeNovel, judul, harga FROM tbnovel ORDER BY kodeNovel ASC"

            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data: " & ex.Message)
        End Try

        Return dt
    End Function

    Public Function SearchNovel(keyword As String) As DataTable
        Dim dt As New DataTable()

        Try
            Dim query As String =
                "SELECT kodeNovel, judul, harga FROM tbnovel " &
                "WHERE kodeNovel LIKE @keyword OR judul LIKE @keyword"

            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal mencari data: " & ex.Message)
        End Try

        Return dt
    End Function

    Public Function KodeSudahAda(kode As String) As Boolean
        Try
            Dim query As String = "SELECT COUNT(*) FROM tbnovel WHERE kodeNovel=@kodeNovel"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kodeNovel", kode)
                    Dim jumlah As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return jumlah > 0
                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal cek data: " & ex.Message)
            Return True
        End Try
    End Function

    Public Function SimpanNovel(kode As String, judul As String, harga As Integer) As Boolean
        Try
            Dim query As String = "INSERT INTO tbnovel VALUES (@kode, @judul, @harga)"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@judul", judul)
                    cmd.Parameters.AddWithValue("@harga", harga)
                    cmd.ExecuteNonQuery()
                End Using

            End Using

            Return True

        Catch ex As Exception
            MessageBox.Show("Gagal simpan: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function UbahNovel(kode As String, judul As String, harga As Integer) As Boolean
        Try
            Dim query As String = "UPDATE tbnovel SET judul=@judul, harga=@harga WHERE kodeNovel=@kode"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@judul", judul)
                    cmd.Parameters.AddWithValue("@harga", harga)
                    Return cmd.ExecuteNonQuery() > 0
                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal ubah: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function HapusNovel(kode As String) As Boolean
        Try
            Dim query As String = "DELETE FROM tbnovel WHERE kodeNovel=@kode"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    Return cmd.ExecuteNonQuery() > 0
                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal hapus: " & ex.Message)
            Return False
        End Try
    End Function

End Module
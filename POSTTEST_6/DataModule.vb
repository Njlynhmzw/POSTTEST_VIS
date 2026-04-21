Imports MySqlConnector

Module DataModule

    ' ================= NOVEL =================
    Public Function GetAllNovel() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT * FROM tbnovel ORDER BY kodeNovel ASC"
            Using conn = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return dt
    End Function

    Public Function SearchNovel(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT * FROM tbnovel WHERE kodeNovel LIKE @key OR judul LIKE @key"
            Using conn = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@key", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return dt
    End Function

    Public Function KodeSudahAda(kode As String) As Boolean
        Try
            Using conn = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand("SELECT COUNT(*) FROM tbnovel WHERE kodeNovel=@kode", conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
                End Using
            End Using
        Catch
            Return True
        End Try
    End Function

    Public Function SimpanNovel(kode As String, judul As String, harga As Integer) As Boolean
        Try
            Using conn = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand("INSERT INTO tbnovel VALUES(@k,@j,@h)", conn)
                    cmd.Parameters.AddWithValue("@k", kode)
                    cmd.Parameters.AddWithValue("@j", judul)
                    cmd.Parameters.AddWithValue("@h", harga)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    Public Function UbahNovel(kode As String, judul As String, harga As Integer) As Boolean
        Try
            Using conn = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand("UPDATE tbnovel SET judul=@j,harga=@h WHERE kodeNovel=@k", conn)
                    cmd.Parameters.AddWithValue("@k", kode)
                    cmd.Parameters.AddWithValue("@j", judul)
                    cmd.Parameters.AddWithValue("@h", harga)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    Public Function HapusNovel(kode As String) As Boolean
        Try
            Using conn = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand("DELETE FROM tbnovel WHERE kodeNovel=@k", conn)
                    cmd.Parameters.AddWithValue("@k", kode)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    ' ================= PENJUALAN =================
    Public Function GetAllPenjualan() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "
                SELECT p.id_jual, n.judul, p.jumlah, p.total
                FROM tbpenjualan p
                JOIN tbnovel n ON p.kodeNovel = n.kodeNovel
                ORDER BY p.id_jual ASC
            "
            Using conn = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return dt
    End Function

    Public Function SimpanPenjualan(kode As String, jumlah As Integer, total As Integer) As Boolean
        Try
            Using conn = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand("INSERT INTO tbpenjualan(kodeNovel,jumlah,total) VALUES(@k,@j,@t)", conn)
                    cmd.Parameters.AddWithValue("@k", kode)
                    cmd.Parameters.AddWithValue("@j", jumlah)
                    cmd.Parameters.AddWithValue("@t", total)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    Public Function GetHargaByKode(kode As String) As Integer
        Try
            Using conn = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand("SELECT harga FROM tbnovel WHERE kodeNovel=@k", conn)
                    cmd.Parameters.AddWithValue("@k", kode)
                    Return Convert.ToInt32(cmd.ExecuteScalar())
                End Using
            End Using
        Catch
            Return 0
        End Try
    End Function

    Public Function HapusPenjualan(id As Integer) As Boolean
        Try
            Using conn = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand("DELETE FROM tbpenjualan WHERE id_jual=@id", conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

End Module
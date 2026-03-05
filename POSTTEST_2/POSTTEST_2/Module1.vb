Public Module ModuleBuku

    Public daftarBuku(99, 1) As String
    Public jumlahBuku As Integer = 0

    Public Sub TambahBuku(ByVal judul As String, ByVal genre As String)

        If jumlahBuku < 100 Then
            daftarBuku(jumlahBuku, 0) = judul
            daftarBuku(jumlahBuku, 1) = genre
            jumlahBuku += 1
        End If

    End Sub


    Public Function CekBuku(ByVal judul As String) As Boolean

        For i As Integer = 0 To jumlahBuku - 1
            If daftarBuku(i, 0) = judul Then
                Return True
            End If
        Next

        Return False

    End Function


    Public Sub HapusBuku(ByVal judul As String)

        For i As Integer = 0 To jumlahBuku - 1

            If daftarBuku(i, 0) = judul Then

                For j As Integer = i To jumlahBuku - 2
                    daftarBuku(j, 0) = daftarBuku(j + 1, 0)
                    daftarBuku(j, 1) = daftarBuku(j + 1, 1)
                Next

                jumlahBuku -= 1
                Exit For

            End If

        Next

    End Sub


    Public Function TampilBuku() As String

        Dim hasil As String = ""

        For i As Integer = 0 To jumlahBuku - 1
            hasil &= daftarBuku(i, 0) & " - " & daftarBuku(i, 1) & vbCrLf
        Next

        Return hasil

    End Function

End Module
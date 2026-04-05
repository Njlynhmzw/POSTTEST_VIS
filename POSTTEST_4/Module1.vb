Imports System.IO
Imports System.Text

Module DataModule
    Public Function BuatIsiCSV(
        nama As String,
        id As String,
        nohp As String,
        email As String,
        alamat As String,
        komunitas As String,
        hobi As String
    ) As String

        Dim sb As New StringBuilder()

        sb.AppendLine("Nama," & nama)
        sb.AppendLine("ID," & id)
        sb.AppendLine("NoHP," & nohp)
        sb.AppendLine("Email," & email)
        sb.AppendLine("Alamat," & alamat)
        sb.AppendLine("Komunitas," & komunitas)
        sb.AppendLine("Hobi," & hobi)

        Return sb.ToString()
    End Function

    Public Function SimpanOtomatis(isi As String) As String
        Try
            Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)

            Dim filePath As String = path & "\data_komunitas_" & Now.ToString("yyyyMMdd_HHmmss") & ".csv"

            File.WriteAllText(filePath, isi)

            Return filePath

        Catch ex As Exception
            Return ""
        End Try
    End Function


    Public Function BukaData(filePath As String) As Dictionary(Of String, String)

        Dim hasil As New Dictionary(Of String, String)

        If Not File.Exists(filePath) Then
            Return Nothing
        End If

        Dim baris() As String = File.ReadAllLines(filePath)

        For Each line As String In baris
            Dim data = line.Split(","c)

            If data.Length = 2 Then
                hasil(data(0)) = data(1)
            End If
        Next

        Return hasil
    End Function


    Public Function AmbilNilai(data As Dictionary(Of String, String), key As String) As String
        If data IsNot Nothing AndAlso data.ContainsKey(key) Then
            Return data(key)
        End If

        Return ""
    End Function

End Module
Public Class Form1

    Dim totalIP As Double
    Dim jumlahSemester As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtIPK.ReadOnly = True
        IPK.Text = "-"
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim Nilai As Double
        Dim NilaiIPK As Double
        Dim Keterangan As String

        Nilai = Val(txtIP.Text)

        totalIP = totalIP + Nilai
        jumlahSemester = jumlahSemester + 1

        NilaiIPK = totalIP / jumlahSemester

        If NilaiIPK >= 2.0 And NilaiIPK <= 2.75 Then
            Keterangan = "Cukup"
        ElseIf NilaiIPK >= 2.76 And NilaiIPK <= 3.0 Then
            Keterangan = "Memuaskan"
        ElseIf NilaiIPK >= 3.01 Then
            Keterangan = "Sangat Memuaskan"
        Else
            Keterangan = "-"
        End If

        txtIPK.Text = NilaiIPK.ToString("0.00")
        HasilPredikat.Text = Keterangan

        txtIP.Text = ""
        txtIP.Focus()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        totalIP = 0
        jumlahSemester = 0

        txtIP.Text = ""
        txtIPK.Text = ""
        IPK.Text = "-"
    End Sub

    Private Sub IPK_Click(sender As Object, e As EventArgs)

    End Sub
End Class
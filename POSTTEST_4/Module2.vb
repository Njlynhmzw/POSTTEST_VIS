Module ValidationModule

    Public Sub HanyaHuruf(e As KeyPressEventArgs)
        If Not (Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Public Sub HanyaAngka(e As KeyPressEventArgs)
        If Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Public Function ValidasiTextBox(ep As ErrorProvider, txt As TextBox, pesan As String) As Boolean
        If txt.Text.Trim = "" Then
            ep.SetError(txt, pesan)
            Return False
        End If
        ep.SetError(txt, "")
        Return True
    End Function

    Public Function ValidasiMaskedTextBox(ep As ErrorProvider, mtb As MaskedTextBox, pesan As String) As Boolean
        If Not mtb.MaskCompleted Then
            ep.SetError(mtb, pesan)
            Return False
        End If
        ep.SetError(mtb, "")
        Return True
    End Function

    Public Function ValidasiEmail(ep As ErrorProvider, txt As TextBox) As Boolean
        If Not txt.Text.Contains("@") Then
            ep.SetError(txt, "Email tidak valid")
            Return False
        End If
        ep.SetError(txt, "")
        Return True
    End Function

    Public Function ValidasiCheckBox(grp As GroupBox, ep As ErrorProvider, pesan As String) As Boolean
        For Each ctrl As Control In grp.Controls
            If TypeOf ctrl Is CheckBox AndAlso CType(ctrl, CheckBox).Checked Then
                ep.SetError(grp, "")
                Return True
            End If
        Next

        ep.SetError(grp, pesan)
        Return False
    End Function

    Public Function ValidasiSemuaInput(ep As ErrorProvider,
        txtNama As TextBox,
        mtbNoHP As MaskedTextBox,
        txtAlamat As TextBox) As Boolean

        Return ValidasiTextBox(ep, txtNama, "Nama kosong") And
               ValidasiMaskedTextBox(ep, mtbNoHP, "No HP salah") And
               ValidasiTextBox(ep, txtAlamat, "Alamat kosong")
    End Function

End Module
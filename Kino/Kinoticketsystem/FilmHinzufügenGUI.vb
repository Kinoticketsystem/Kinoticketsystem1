Public Class FilmHinzufügenGUI
    Private Filmname As String
    Private Filmlänge As Integer
    Private Altersfreigabe As Integer
    Private _3d As Boolean
    Private allesDa As Boolean
    Private Sub cmdFilmHinzufügen_Click(sender As Object, e As EventArgs) Handles cmdFilmHinzufügen.Click
        lstAlleFilme.Items.Clear()

        If txtFilmtitel.Text = "" Then
            allesDa = False
            'MsgBox("Filmtitel ausfüllen")
        Else
            Filmname = txtFilmtitel.Text
            allesDa = True
        End If
        If txtFilmlänge.Text = "" Then
            allesDa = False
            'MsgBox("Filmlänge ausfüllen")
        Else
            Filmlänge = txtFilmlänge.Text
            allesDa = True
        End If
        If txtAltersfreigabe.Text = "" Then
            allesDa = False
            'MsgBox("Altersfreigabe ausfüllen")
        Else

            Altersfreigabe = txtAltersfreigabe.Text
        End If
        If CheckBox1.Checked Then
            _3d = True
        Else
            _3d = False
        End If


        If allesDa = True Then

            Dim film As Film = New Film(Filmname, Filmlänge, Altersfreigabe, _3d)
            Dim b As ArrayList = KinoGUI.DASKINO.getFilmtitel

            If b.Contains(film) Then
                MsgBox("Film breits in der Datenbank")
            Else
                KinoGUI.DASKINO.FilmHinzufügen(film)
            End If
            'Es muss noch in der listbox alle filntitel ausgegebn werden um zu überprüfen,m ob der neue film übergebn wurde ist bei kinogui geschrieben
            Dim a As ArrayList = KinoGUI.DASKINO.getFilmtitel()
            For i = 0 To KinoGUI.DASKINO.getFilmtitel.Count - 1
                lstAlleFilme.Items.Add(a(i).getFilmtitel)
            Next
        Else
                MsgBox("Es sind nicht alle Parameter korrekt ausgefüllt!")
        End If

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub cmdFilmEntfernen_Click(sender As Object, e As EventArgs) Handles cmdFilmEntfernen.Click
        Dim i As Integer = lstAlleFilme.SelectedIndex
        Dim f As Film = KinoGUI.DASKINO.getFilmtitel(i)
        KinoGUI.DASKINO.FilmEntfernen(f)
    End Sub
End Class
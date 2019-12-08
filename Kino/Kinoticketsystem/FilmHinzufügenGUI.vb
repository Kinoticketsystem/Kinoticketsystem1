Public Class FilmHinzufügenGUI
    Private Filmname As String
    Private Filmlänge As Integer
    Private Altersfreigabe As Byte
    Private _3d As Boolean
    Private Sub cmdFilmHinzufügen_Click(sender As Object, e As EventArgs) Handles cmdFilmHinzufügen.Click
        Filmname = txtFilmtitel.Text
        Filmlänge = txtFilmlänge.Text
        Altersfreigabe = txtAltersfreigabe.Text
        If CheckBox1.Checked Then
            _3d = True
        Else
            _3d = False
        End If

        Dim film As Film = New Film(Filmname, Filmlänge, Altersfreigabe, _3d)
        KinoGUI.DASKINO.FilmHinzufügen(film)
        'Es muss noch in der listbox alle filntitel ausgegebn werden um zu überprüfen,m ob der neue film übergebn wurde ist bei kinogui geschrieben
        Dim a As ArrayList = KinoGUI.DASKINO.getFilmtitel()
        For i = 0 To KinoGUI.DASKINO.getFilmtitel.Count - 1 '-1 richtig?
            lstAlleFilme.Items.Add(a(i))
        Next
    End Sub
End Class
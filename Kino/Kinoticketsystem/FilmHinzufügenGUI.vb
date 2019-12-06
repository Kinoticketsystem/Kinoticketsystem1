Public Class FilmHinzufügenGUI
    Private Filmname As String = txtFilmtitel.Text
    Private Filmlänge As Integer = txtFilmlänge.Text
    Private Altersfreigabe As Byte = txtAltersfreigabe.Text
    Private _3d As Boolean
    Private Sub cmdFilmHinzufügen_Click(sender As Object, e As EventArgs) Handles cmdFilmHinzufügen.Click
        If CheckBox1.Checked Then
            _3d = True
        Else
            _3d = False
        End If

        Dim film As Film = New Film(Filmname, Filmlänge, Altersfreigabe, _3d)
        KinoGUI.DASKINO.FilmHinzufügen(film)
        'Es muss noch in der listbox alle filntitel ausgegebn werden um zu überprüfen,m ob der neue film übergebn wurde ist bei kinogui geschrieben
    End Sub
End Class
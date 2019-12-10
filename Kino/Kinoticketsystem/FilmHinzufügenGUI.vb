Public Class FilmHinzufügenGUI
    Private Filmname As String
    Private Filmlänge As Integer
    Private Altersfreigabe As Byte
    Private _3d As Boolean
    Private allesDa As Boolean = False

    Private Sub cmdFilmHinzufügen_Click(sender As Object, e As EventArgs) Handles cmdFilmHinzufügen.Click
        If txtFilmtitel.Text = "" Then
            allesDa = False
        Else
            Filmname = txtFilmtitel.Text
            allesDa = True

        End If
        If txtFilmlänge.Text = "" Then
            allesDa = False
        Else
            Filmlänge = txtFilmlänge.Text
            allesDa = True
        End If

        If txtAltersfreigabe.Text = "" Then
            allesDa = False
        Else
            Altersfreigabe = txtAltersfreigabe.Text
            allesDa = True
        End If

        If CheckBox1.Checked Then
            _3d = True
        Else
            _3d = False
        End If


        Dim film As Film = New Film(Filmname, Filmlänge, Altersfreigabe, _3d)
        KinoGUI.DASKINO.FilmHinzufügen(film)
        'Es muss noch in der listbox alle filntitel ausgegebn werden um zu überprüfen,m ob der neue film übergebn wurde ist bei kinogui geschrieben
        Dim a As ArrayList = KinoGUI.DASKINO.getFilmtitel()
        For i = 0 To KinoGUI.DASKINO.getFilmtitel.Count - 1
            lstAlleFilme.Items.Add(a(i))
        Next
    End Sub

    Private Sub FilmHinzufügenGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
Public Class testFilmfjdgchjm

    Private _Filmtitel As String
    Private _Filmlänge As Integer 'in Minuten
    Private _Altersfreigabe As Integer
    Private _3D As Boolean
    Private _AnzahlFilmWiedergabe As Integer

    Public a As Film = New Film("testFilmName", 122, 18, True)
    Public Filmtest As String = "testFilmname2"
    Public c As String


    Public Sub _FilmtitelAnderntesten()

        a.filmtitelÄndern(Filmtest)
        c = a.getFilmtitel()
        If Not (Filmtest.Equals(c)) Then
            Console.WriteLine("fehler")
        End If
    End Sub


End Class

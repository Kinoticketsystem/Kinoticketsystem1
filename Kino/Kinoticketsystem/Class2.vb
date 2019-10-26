Public Class testFilmfjdgchjm

    Private _Filmtitel As String
    Private _Filmlänge As Integer 'in Minuten
    Private _Altersfreigabe As Integer
    Private _3D As Boolean
    Private _AnzahlFilmWiedergabe As Integer

    Public a As Film = New Film("testFilmName", 122, 18, fals)
    Public Filmtest As String = "testFilmname2"
    Public i As Integer
    Public b As Boolean
    Public s As String


    Public Sub _FilmtitelAnderntesten()

        a.filmtitelÄndern(Filmtest)
        s = a.getFilmtitel()
        If Not (Filmtest.Equals(s)) Then
            Console.WriteLine("fehler filmtitel")
        End If
    End Sub

    Public Sub _FilmlängeÄnderntesten()

        a.filmlängeÄndern(Filmlänge)
        i = a.getFilmlänge()
        If Not (_Filmlänge.Equals(i)) Then
            Console.Writeline("fehler filmlänge")
        End If
    End Sub

    Public Sub _Altersfreigabetesten(Altersfreigabe)
        a.AltersfteigabeÄndern(Altersfreigabe)
        i = a.getAltersfreigabe()
        If Not (_Altersfreigabe.Equals(i)) Then
            Console.Writeline("fehler Altersfreigabe")
        End If
    End Sub

    Public Sub _3Dtesten(3D)
        a0._3DÄndern(3D)
        b = a.Ist3D()
        If Not (_3D.Equals(b)) Then
            Console.Writeline("fehler 3D")
        End If
    End Sub
End Class

Public Class TagesplanTest
    Private _Tagesplan As Tagesplan = New Tagesplan()
    Private _TestFilm1 As Film = New Film("TestFilm1", 120, 16, True)
    Private BeispielVorstellungA As Vorstellung = New Vorstellung("04:56", "04:59", New ArrayList(), New Kinosaal(120, , 7, 14), TestFilm1) '?
    Private BeispielVorstellungB As Vorstellung
    Private BeispielVorstellungC As Vorstellung = New Vorstellung("04:57", "04:58", New ArrayList(), New Kinosaal(), New Film())
    Private BeispielVorstellungAnzahlA As Integer
    Private BeispielVorstellungAnzahlB As Integer

    Private Sub TestVorstellungHinzufügen()
        _Tagesplan.VorstellungHinzufügen(BeispielVorstellungA)
        BeispielVorstellungB = _Tagesplan.getVorstellung(0)

        If Not BeispielVorstellungA.Equals(BeispielVorstellungB) Then
            Console.WriteLine("Problem bei Tagesplan: Vorstellunghinzufügen 1")
        End If

    End Sub

    Private Sub TestVorstellungÄndern()
        _Tagesplan.VorstellungHinzufügen(BeispielVorstellungA)
        BeispielVorstellungB = _Tagesplan.getVorstellung(1)

        If Not BeispielVorstellungA.Equals(BeispielVorstellungB) Then
            Console.WriteLine("Problem bei Tagesplan: Vorstellunghinzufügen 2")
        End If

        _Tagesplan.VorstellungÄndern(BeispielVorstellungC, 1)
        BeispielVorstellungB = _Tagesplan.getVorstellung(1)

        If Not BeispielVorstellungC.Equals(BeispielVorstellungB) Then
            Console.WriteLine("Problem bei Tagesplan: VorstellungÄndern")
        End If

    End Sub

    Private Sub TestVorstellungEntfernen()
        BeispielVorstellungAnzahlA = _TestFilm1.getAnzahlFilmwiedergabe
        _Tagesplan.VorstellungEntfernen(BeispielVorstellungA, 0)
        BeispielVorstellungB = _Tagesplan.getVorstellung(0)
        BeispielVorstellungAnzahlB = _TestFilm1.getAnzahlFilmwiedergabe

        If BeispielVorstellungA.Equals(BeispielVorstellungB) Then
            Console.WriteLine("Problem bei Tagesplan: VorstellungEntfernen")
        End If

        If BeispielVorstellungAnzahlA.Equals(BeispielVorstellungAnzahlB) Then
            Console.WriteLine("Problem bei Tagesplan: VorstellungEntfernen: AnzahlFilmwiedergabe")
        End If

    End Sub

End Class
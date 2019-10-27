Public Class TestTagesplan
    Private _Tagesplan As Tagesplan = New Tagesplan()
    Private TestFilmA As Film = New Film("TestFilmA", 120, 16, True)
    Private TestFilmB As Film = New Film("TestFilmB", 90, 12, False)
    Private BeispielVorstellungA As Vorstellung = New Vorstellung(0, 120, New ArrayList(), TestFilmA)
    Private BeispielVorstellungC As Vorstellung = New Vorstellung(10, 100, New ArrayList(), TestFilmB)

    Private BeispielVorstellungB As Vorstellung
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
        BeispielVorstellungAnzahlA = TestFilmA.getAnzahlFilmwiedergabe
        _Tagesplan.VorstellungEntfernen(BeispielVorstellungA, 0)
        BeispielVorstellungB = _Tagesplan.getVorstellung(0)
        BeispielVorstellungAnzahlB = TestFilmA.getAnzahlFilmwiedergabe

        If BeispielVorstellungA.Equals(BeispielVorstellungB) Then
            Console.WriteLine("Problem bei Tagesplan: VorstellungEntfernen")
        End If

        If BeispielVorstellungAnzahlA.Equals(BeispielVorstellungAnzahlB) Then
            Console.WriteLine("Problem bei Tagesplan: VorstellungEntfernen: AnzahlFilmwiedergabe")
        End If

    End Sub

End Class
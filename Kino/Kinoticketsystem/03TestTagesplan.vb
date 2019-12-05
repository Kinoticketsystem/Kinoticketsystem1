Public Class TestTagesplan
    Private _Tagesplan As Tagesplan = New Tagesplan()
    Private TestFilmA As Film = New Film("TestFilmA", 120, 16, True)
    Private TestFilmB As Film = New Film("TestFilmB", 90, 12, False)
    Private BeispielVorstellungA As Vorstellung = New Vorstellung(0, 120, New ArrayList(), TestFilmA)
    Private BeispielVorstellungC As Vorstellung = New Vorstellung(10, 100, New ArrayList(), TestFilmB)

    Private BeispielVorstellungB As Vorstellung
    Private BeispielVorstellungAnzahlA As Integer
    Private BeispielVorstellungAnzahlB As Integer

    Public Function TestVorstellungHinzufügen()
        _Tagesplan.VorstellungHinzufügen(BeispielVorstellungA)
        BeispielVorstellungB = _Tagesplan.getVorstellung(1)

        If Not BeispielVorstellungA.Equals(BeispielVorstellungB) Then
            Return False
        Else
            Return True
        End If

    End Function

    Public Function TestVorstellungÄndern()
        _Tagesplan.VorstellungHinzufügen(BeispielVorstellungA)
        BeispielVorstellungB = _Tagesplan.getVorstellung(1)

        If Not BeispielVorstellungA.Equals(BeispielVorstellungB) Then
            Return False And "Problem bei Tagesplan: Vorstellunghinzufügen 2"
        Else
            Return True
        End If

        _Tagesplan.VorstellungÄndern(BeispielVorstellungC, 1)
        BeispielVorstellungB = _Tagesplan.getVorstellung(1)

        If Not BeispielVorstellungC.Equals(BeispielVorstellungB) Then
            Return False And "Problem bei Tagesplan: VorstellungÄndern"
        Else
            Return True
        End If

    End Function

    Public Function TestVorstellungEntfernen()
        BeispielVorstellungAnzahlA = TestFilmA.getAnzahlFilmwiedergabe
        _Tagesplan.VorstellungEntfernen(BeispielVorstellungA)
        BeispielVorstellungB = _Tagesplan.getVorstellung(0)
        BeispielVorstellungAnzahlB = TestFilmA.getAnzahlFilmwiedergabe

        If BeispielVorstellungA.Equals(BeispielVorstellungB) Then
            Return False And "VorstellungEntfernen fehlgeschlagen"
        Else
            Return True
        End If

        If BeispielVorstellungAnzahlA.Equals(BeispielVorstellungAnzahlB) Then
            Return False And "Problem bei Tagesplan: VorstellungEntfernen: AnzahlFilmwiedergabe"
        Else
            Return True
        End If

    End Function

End Class
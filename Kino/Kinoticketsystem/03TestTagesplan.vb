Public Class TestTagesplan
    Private _Tagesplan As Tagesplan = New Tagesplan()
    Private TestFilmA As Film = New Film("TestFilmA", 120, 16, True)
    Private TestFilmB As Film = New Film("TestFilmB", 90, 12, False)
    Private TestSaal As Kinosaal = New Kinosaal(60, 6, 10)
    Private BeispielVorstellungA As Vorstellung = New Vorstellung(0, 120, New ArrayList(), TestFilmA, TestSaal)
    Private BeispielVorstellungC As Vorstellung = New Vorstellung(10, 100, New ArrayList(), TestFilmB, TestSaal)

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
            Return False
        Else
            Return True
        End If

        _Tagesplan.VorstellungÄndern(BeispielVorstellungC, 1)
        BeispielVorstellungB = _Tagesplan.getVorstellung(1)

        If Not BeispielVorstellungC.Equals(BeispielVorstellungB) Then
            Return False
        Else
            Return True
        End If

    End Function

    Public Function TestVorstellungEntfernen()
        BeispielVorstellungB = _Tagesplan.getVorstellung(1)
        BeispielVorstellungAnzahlB = TestFilmA.getAnzahlFilmwiedergabe
        BeispielVorstellungAnzahlA = TestFilmA.getAnzahlFilmwiedergabe
        _Tagesplan.VorstellungEntfernen(BeispielVorstellungA)


        If BeispielVorstellungA.Equals(BeispielVorstellungB) Then
            Return False
        Else
            Return True
        End If



    End Function

End Class
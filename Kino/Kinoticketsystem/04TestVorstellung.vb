Public Class TestVorstellung


    Private _Vorstellung As Vorstellung = New Vorstellung(0, 0, New ArrayList(), BeispielFilmC)
    Private BeispielFilmA As Film = New Film("Testfilm", 120, 16, True)
    Private BeispielFilmC As Film = New Film("Film", 90, 12, False)
    Private BeispeilSaalA As Kinosaal = New Kinosaal(120, 7, 14) 'BeispielFilmA wurde rausgenommen aus dem Konstruktor, weil das ni´cht mehr im Konstruktor übergeben wird

    Private BeispielBesucherA As Kunde = New Kunde("Testkunde1")
    Private BeispielBesucherC As Kunde = New Kunde("Testkunde2")

    Private BeispielFilmB As Film
    Private BeispielSaalB As Kinosaal
    Private BeispielBesucherB As Kunde




    Private Sub TestfilmÄndern()
        _Vorstellung.FilmÄndern(BeispielFilmA)
        BeispielFilmB = _Vorstellung.getFilm

        If Not BeispielFilmA.Equals(BeispielFilmB) Then
            Console.WriteLine("Problem bei Vorstellung: FilmÄndern")
        End If

    End Sub

    Private Sub TestBesucherHinzufügen()
        _Vorstellung.BesucherHinzufügen(BeispielBesucherA)
        BeispielBesucherB = _Vorstellung.getBesucher(0)

        If Not BeispielBesucherA.Equals(BeispielBesucherB) Then
            Console.WriteLine("Problem bei Vorstellung: BesucherHinzufügen")
        End If

    End Sub

    Private Sub TestBesucherEntfernen1()
        _Vorstellung.BesucherEntfernen(BeispielBesucherA)
        BeispielBesucherB = _Vorstellung.getBesucher(0)

        If BeispielBesucherA.Equals(BeispielBesucherB) Then
            Console.WriteLine("Problem bei Vorstellung: BesucherEntfernen1")
        End If

    End Sub

    Private Sub TestBesucherEntfernen2()
        _Vorstellung.BesucherHinzufügen(BeispielBesucherA)
        _Vorstellung.BesucherHinzufügen(BeispielBesucherC)
        _Vorstellung.BesucherEntfernen(1)
        BeispielBesucherB = _Vorstellung.getBesucher(1)

        If BeispielBesucherB.Equals(BeispielBesucherA) Or BeispielBesucherB.Equals(BeispielBesucherC) Then
            Console.WriteLine("Problem bei Vorstellung: BesucherEntfernen2")
        End If

    End Sub

    Private Sub TestSaalÄndern()
        _Vorstellung.SaalÄndern(BeispeilSaalA)
        BeispielSaalB = _Vorstellung.getSaal

        If Not BeispielSaalB.Equals(BeispeilSaalA) Then
            Console.WriteLine("Problem bei Vorstellung: SaalÄndern")
        End If

    End Sub

End Class
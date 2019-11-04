Public Class TestKinosaal
    Private TestFilmA As Film = New Film("TestFilmA", 120, 16, True)
    Private BeispielBesucherA As Kunde = New Kunde("Testkunde1")
    Private BeispielBesucherB As Kunde
    Private testsaal1 As Kinosaal = New Kinosaal(60, TestFilmA, 10, 6)
    'Private testsaal2 As Kinosaal
    Private Sub TestSitzplatzBuchen()
        testsaal1.SitzplatzBuchen(4, 1, BeispielBesucherA)
        BeispielBesucherB = testsaal1.getKunde(4, 1)
        If Not BeispielBesucherB.Equals(BeispielBesucherA) Then
            Console.WriteLine("Problem bei Kinosaal: SitzplatzBuchen")
        Else
            Console.WriteLine("passt")
        End If
    End Sub
    Private Sub TestSitzplatzStornieren()

    End Sub
End Class

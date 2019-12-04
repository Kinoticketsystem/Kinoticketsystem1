Public Class Testklassekino
    Public TestTagesplan As Tagesplan
    Public TestKunde As Kunde
    Public TestKinosäle As Kinosaal
    Public TestAnzahlkinosäle As Integer

    Public Function NeueBuchung()
        Dim name As String = "gabor"
        TestKunde = New Kunde(name)
        Dim k As Kunde = TestKunde

        Dim Reihe As Integer = 1
        Dim Anzahl As String = 3
        Dim Sitz As Integer = 3
        Dim TestFilm As Film = New Film("Indiana Jones", 120, 12, False)
        Dim Saal1 As Kinosaal = New Kinosaal(Anzahl, Reihe, Sitz) 'TestFilm wurde rausgenommen aus dem Konstruktor, weil das ni´cht mehr im Konstruktor übergeben wird
        Saal1.SitzplatzBuchen(1, 1, k)
        Return True

    End Function

    Public Function Kinosaal()
        Dim Reihe As Integer = 1
        Dim Anzahl As String = 3
        Dim Sitz As Integer = 3
        Dim TestFilm As Film = New Film("Indiana Jones", 120, 12, False)
        Dim Saal2 As Kinosaal = New Kinosaal(Anzahl, Reihe, Sitz) 'TestFilm wurde rausgenommen aus dem Konstruktor, weil das ni´cht mehr im Konstruktor übergeben wird

        Return True
    End Function
    'Kinosaalentfernen
    Public Function SetFilm()
        Dim TestFilm As Film = New Film("Indiana Jones", 120, 12, False)
        Return True
    End Function
    'Film entfernen
    Public Function SetKunden()
        Dim name As String = "gabor"
        TestKunde = New Kunde(name)
        TestKunde.SetName(name)
        Return True
    End Function

    Public Function SetKundenEntfernen()

        Dim name As String = "gabor"
        TestKunde = New Kunde(name)
        Return True
    End Function

    Public Function SetAnzahlKinosaal()
        Dim i As Integer = 5
        TestAnzahlkinosäle = i
        If TestAnzahlkinosäle = 5 Then
            Return True
        Else
            Return False

        End If
    End Function
End Class
﻿Public Class Testklassekino
    Private TestTagesplan As Tagesplan
    Private TestKunde As Kunde
    Private TestKinosäle As Kinosaal
    Private TestAnzahlkinosäle As Integer

    Private Sub cmdNeueBUchung_Click(sender As Object, e As EventArgs) Handles cmdNeueBUchung.Click
        Dim name As String = "gabor"
        TestKunde = New Kunde(name)
        Dim k As Kunde = TestKunde

        Dim Reihe As Integer = 1
        Dim Anzahl As String = 3
        Dim Sitz As Integer = 3
        Dim TestFilm As Film = New Film("Indiana Jones", 120, 12, False)
        Dim Saal1 As Kinosaal = New Kinosaal(Anzahl, TestFilm, Reihe, Sitz)
        Saal1.SitzplatzBuchen(1, 1, k)

        Console.WriteLine("funktioniert")
    End Sub

    Private Sub cmdtestsetkinosaal_Click(sender As Object, e As EventArgs) Handles cmdtestsetkinosaal.Click
        Dim Reihe As Integer = 1
        Dim Anzahl As String = 3
        Dim Sitz As Integer = 3
        Dim TestFilm As Film = New Film("Indiana Jones", 120, 12, False)
        Dim Saal2 As Kinosaal = New Kinosaal(Anzahl, TestFilm, Reihe, Sitz)
        MsgBox("passt")
    End Sub
    'Kinosaalentfernen
    Private Sub cmdTestSetFilm_Click(sender As Object, e As EventArgs) Handles cmdTestSetFilm.Click
        Dim TestFilm As Film = New Film("Indiana Jones", 120, 12, False)
        MsgBox("passt")
    End Sub
    'Film entfernen
    Private Sub cmdTestSetKunden_Click(sender As Object, e As EventArgs) Handles cmdTestSetKunden.Click
        Dim name As String = "gabor"
        TestKunde = New Kunde(name)
        TestKunde.SetName(name)
        MsgBox("passt")
    End Sub

    Private Sub cmdTestSetKundenEntfernen_Click(sender As Object, e As EventArgs)
        Dim name As String = "gabor"
        TestKunde = New Kunde(name)
        'wie entfernen?
    End Sub

    Private Sub cmdTestSetAnzahlkinosaal_Click(sender As Object, e As EventArgs) Handles cmdTestSetAnzahlkinosaal.Click
        Dim i As Integer = 5
        TestAnzahlkinosäle = i
        If TestAnzahlkinosäle = 5 Then
            MsgBox("läuft")
        End If
    End Sub
End Class
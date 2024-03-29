﻿Imports Kinoticketsystem

Public Class Kinosaal
    Private _AnzahlSitzplätze As Integer
    Private _Anzahlreihe As Integer
    Private _SitzeProReihe As Integer
    'Private x As Integer
    'Private y As Integer
    'Private z As Integer
    Private _Film As Film 'brauchen wir den eigentlich nicht, vielleicht später, aber unnötig den mit übergeben zu müssen im Konstruktor
    Private _Sitzplätze(,) As Kunde
    Private _PreisProPlatz(,) As Double
    Private _Standardpreis As Double = 5.5
    Public _leererPlatz As Kunde = New Kunde("")

    Public Sub New(ByVal AnzahlSitztplätze As Integer, ByVal AnzahlReihe As Integer, ByVal SitzeProReihe As Integer)
        If AnzahlSitztplätze = AnzahlReihe * SitzeProReihe Then
            Me._AnzahlSitzplätze = AnzahlSitztplätze
        Else
            Throw New Exception("Die übergebene Anzahl der Sitzplätze passt nicht zur Länge und Breite der Sitze")
        End If
        'Me._Film = Film
        Dim a(AnzahlReihe + 1, SitzeProReihe + 1) As Kunde 'es wird später für button1 ja 0,0 übergeben

        '  x = AnzahlReihe      'why?
        ' y = SitzeProReihe
        '  z = AnzahlSitztplätze 'why ??????
        _Anzahlreihe = AnzahlReihe
        _SitzeProReihe = SitzeProReihe


        For i As Integer = 0 To AnzahlReihe - 1
            For j As Integer = 0 To SitzeProReihe - 1
                a(i, j) = _leererPlatz
            Next
        Next
        Me._Sitzplätze = a

        'hier ist jetzt erstmal für jeden Platz ein Standardpreis angegeben
        Dim b(AnzahlReihe, SitzeProReihe) As Double

        For k = 0 To AnzahlReihe - 1
            For l = 0 To SitzeProReihe - 1
                b(k, l) = _Standardpreis
            Next
        Next
        _PreisProPlatz = b
    End Sub
    Public Sub New(ByVal Vorstellung As Vorstellung)
        Me.New(Vorstellung.getSaal.getAnzahlSitzplätze, Vorstellung.getSaal.getAnzahlReihe, Vorstellung.getSaal.getSitzeProReihe)
    End Sub
    Friend Function getKunde(i As Integer, j As Integer) As Kunde
        Return _Sitzplätze(i, j)
    End Function
    'Unnötig
    'Public Function getY()
    '    Return y
    'End Function

    'Public Function getX()
    '    Return x
    'End Function
    'Public Function getZ()
    '    Return z
    'End Function
    Public Function getBuchungen()
        Return _Sitzplätze
    End Function
    Public Function getAnzahlSitzplätze()
        Return _AnzahlSitzplätze
    End Function
    Public Function getAnzahlReihe()
        Return _Anzahlreihe
    End Function
    Public Function getSitzeProReihe()
        Return _SitzeProReihe
    End Function
    Public Function getFilm()
        Return _Film
    End Function
    Public Sub SitzplatzBuchen(ByRef gewählterPlatzX As Integer, ByRef gewählterPlatzY As Integer, ByRef kunde As Kunde)
        Me._Sitzplätze(gewählterPlatzX, gewählterPlatzY) = kunde
    End Sub

    Public Function getAnzahlFreiPlätze() As Integer
        getAnzahlFreiPlätze = 0
        For i = 0 To _Anzahlreihe - 1
            For j = 0 To _SitzeProReihe - 1
                If _Sitzplätze(i, j).Equals(_leererPlatz) Then
                    getAnzahlFreiPlätze += 1
                End If
            Next
        Next
    End Function

    Public Sub SitzplatzStornieren(ByRef gewählterPlatzX As Integer, ByRef gewählterPlatzY As Integer, ByRef Kunde As Kunde)
        If _Sitzplätze(gewählterPlatzX, gewählterPlatzY).getName.Equals(Kunde.getName) Then
            Me._Sitzplätze(gewählterPlatzX, gewählterPlatzY) = _leererPlatz
        Else
            KinosaalGUI.FehlerMitFalscherPersonBuchen
            '   Throw New Exception("Es wurde beim Sitzplanstornieren versucht einen Sitzplatz zu stornieren, der vorher von dem übergebenen Kunden nicht gebucht wurde!")
        End If
    End Sub



    Public Function getPreis(x, y) As Double
        Return _PreisProPlatz(x, y)
    End Function
    Public Sub setPreis(x As Integer, y As Integer, neuerPreis As Double)
        If neuerPreis > 0 And neuerPreis < 100.0 Then
            _PreisProPlatz(x, y) = neuerPreis
        Else
            Throw New Exception("der Preis ist kleiner 0 oder größer 100.0")
        End If
    End Sub
    Public Sub setStandardPreis(x As Double)
        _Standardpreis = x

    End Sub
    Public Function getStandardPreis() As Double
        Return _Standardpreis
    End Function
End Class

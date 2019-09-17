﻿Imports Kinoticketsystem

Public Class Tagesplan
    Implements ITagesplan
    Private _Vorstellungen(MaximaleAnzahlFilmeProTag) As Vorstellung
    Private MaximaleAnzahlFilmeProTag As Integer = 10
    Private AnzahlFilmeProTag As Integer

    Public Sub New()
        _Vorstellungen = New Vorstellung() {}
    End Sub
    Public Sub TagesplanErstellen(Vorstellung1 As Vorstellung, Vorstellung2 As Vorstellung, Vorstellung3 As Vorstellung, Vorstellung4 As Vorstellung, Vorstellung5 As Vorstellung) Implements ITagesplan.TagesplanErstellen
        _Vorstellungen(0) = Vorstellung1
        _Vorstellungen(2) = Vorstellung2
        _Vorstellungen(3) = Vorstellung3
        _Vorstellungen(4) = Vorstellung4
        _Vorstellungen(5) = Vorstellung5
        AnzahlFilmeProTag = 5
        'For i As Integer = 0 To MaximaleAnzahlFilmeProTag - 1

        'Next
    End Sub
    'Filmnummer zwischen [1 und MaximaleAnzahlFilmeProTag]
    Public Sub FilmÄndern(Vorstellung As Vorstellung, Filmnummer As Integer) Implements ITagesplan.FilmÄndern
        _Vorstellungen(Filmnummer + 1) = Vorstellung
    End Sub

    Public Sub FilmHinzufügen(Vorstellung As Vorstellung) Implements ITagesplan.FilmHinzufügen
        _Vorstellungen(AnzahlFilmeProTag) = Vorstellung
        AnzahlFilmeProTag = AnzahlFilmeProTag + 1
    End Sub

    Public Sub FilmEntfernen(vorstellung As Vorstellung, Position As Integer) Implements ITagesplan.FilmEntfernen
        _Vorstellungen(AnzahlFilmeProTag) = Nothing
        AnzahlFilmeProTag = AnzahlFilmeProTag - 1
    End Sub

    Public Function getFilme() As Array Implements ITagesplan.getFilme
        Throw New NotImplementedException()
    End Function

    Public Function getFilm(Position As Integer) As Film Implements ITagesplan.getFilm
        Throw New NotImplementedException()
    End Function

    Public Function getAnzahlFilme() As Integer Implements ITagesplan.getAnzahlFilme
        Throw New NotImplementedException()
    End Function
End Class
Imports Kinoticketsystem

Public Class Vorstellung
    'Attribute
    Implements IVorstellung
    Private _Startzeit As Integer 'in Minuten seit 8:00, also 8:0 0 = 0; 9:00 = 60; ...
    Private _Endzeit As Date
    Private _Besucher As ArrayList = New ArrayList()
    Private Saal As Kinosaal 'falls wir keine nummern nehmen
    Private Film As Film



    'Konstruktor
    Public Sub New(ByVal Startzeit As Integer, ByVal Endzeit As Date, ByVal Besucher As ArrayList, ByVal Saal As Kinosaal, ByVal Film As Film)
        Me._Startzeit = Startzeit
        Me._Endzeit = Endzeit
        Me._Besucher = Besucher
        Me.Saal = Saal
        Me.Film = Film

    End Sub

    'Methoden

    Public Sub FilmÄndern(Film As Film) Implements IVorstellung.FilmÄndern
        Me.Film = Film
    End Sub

    Private Sub BesucherHinzufügen(Besucher As Kunde) Implements IVorstellung.BesucherHinzufügen
        _Besucher.Add(Besucher)
    End Sub

    Private Sub SaalÄndern(Saal As Kinosaal) Implements IVorstellung.SaalÄndern
        Me.Saal = Saal
    End Sub
    Public Function getAnfangszeit() As Integer 'Als Minutenanzahl seit 8:00, also 8:0 0 = 0; 9:00 = 60; ...
        Return _Startzeit
    End Function
End Class

Imports Kinoticketsystem

Public Class Vorstellung
    'Attribute
    Implements IVorstellung
    Private _Startzeit As Date 'Verbunden mit Datum?
    Private _Endzeit As Date
    Private Besucher As ArrayList
    Private Saal As Kinosaal 'falls wir keine nummern nehmen
    Private Film As Film



    'Konstruktor
    Public Sub New(ByVal Startzeit As Date, ByVal Endzeit As Date, ByVal Besucher As ArrayList, ByVal Saal As Kinosaal, ByVal Film As Film)
        Me._Startzeit = Startzeit
        Me._Endzeit = Endzeit
        Me.Besucher = Besucher
        Me.Saal = Saal
        Me.Film = Film

    End Sub

    'Methoden

    Public Sub FilmÄndern(Film As Film) Implements IVorstellung.FilmÄndern
        Me.Film = Film
    End Sub

    Private Sub BesucherHinzufügen(Besucher As Kunde) Implements IVorstellung.BesucherHinzufügen
        'Besucher.
    End Sub

    Private Sub SaalÄndern(Saal As Kinosaal) Implements IVorstellung.SaalÄndern
        Me.Saal = Saal
    End Sub
End Class

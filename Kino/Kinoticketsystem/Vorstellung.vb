Imports Kinoticketsystem

Public Class Vorstellung
    'Attribute
    Implements IVorstellung
    Private _Startzeit As Integer 'in Minuten seit 8:00, also 8:0 0 = 0; 9:00 = 60; ...
    Private _Endzeit As Integer 'in Minuten seit 8:00, also 8:0 0 = 0; 9:00 = 60; ...
    Private _Besucher As ArrayList = New ArrayList()
    Private Saal As Kinosaal 'falls wir keine nummern nehmen
    Private Film As Film



    'Konstruktor
    Public Sub New(ByVal Startzeit As Integer, ByVal Endzeit As Integer, ByVal Besucher As ArrayList, ByVal Saal As Kinosaal, ByVal Film As Film)
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
    Public Function getEndzeit() As Integer 'Als Minutenanzahl seit 8:00, also 8:0 0 = 0; 9:00 = 60; ...
        Return _Endzeit
    End Function
    Public Function getSaal() As Kinosaal  'Als Minutenanzahl seit 8:00, also 8:0 0 = 0; 9:00 = 60; ...
        Return Saal
    End Function
    Public Function getBesucher() As ArrayList  'Als Minutenanzahl seit 8:00, also 8:0 0 = 0; 9:00 = 60; ...
        Return _Besucher
    End Function
    Public Function getFilm() As Film 'Als Minutenanzahl seit 8:00, also 8:0 0 = 0; 9:00 = 60; ...
        Return Film
    End Function




    Public Sub setAnfangszeit(a As Integer)
        _Startzeit = a
    End Sub
    Public Sub setEndzeit(b As Integer)
        If (_Startzeit - _Endzeit) < 0 Then
            _Endzeit = b
        Else
            Throw New Exception("Die Endzeit der Vorstellung wird versucht auf einen Zeitpunkt vor der Startzeit festzulegen")
        End If
    End Sub
End Class

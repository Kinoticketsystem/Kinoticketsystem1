Imports Kinoticketsystem

Public Class Vorstellung
    'Attribute
    Implements IVorstellung
    Private _Startzeit As Integer 'in Minuten seit 8:00, also 8:0 0 = 0; 9:00 = 60; ...
    Private _Endzeit As Integer 'in Minuten seit 8:00, also 8:0 0 = 0; 9:00 = 60; ...
    Private _Besucher As ArrayList = New ArrayList()
    Private _Saal As Kinosaal 'falls wir keine nummern nehmen
    Private _Film As Film



    'Konstruktor
    Public Sub New(ByVal Startzeit As Integer, ByVal Endzeit As Integer, ByVal Besucher As ArrayList, ByVal Film As Film) 'ByVal Saal As Kinosaal, 
        If Startzeit >= 0 And Endzeit < 1080 Then 'entspricht nicht vor 8:00 und nicht länger als 2:00
            _Startzeit = Startzeit
            _Endzeit = Endzeit
        Else
            Throw New Exception("die Veranstaltung kann nicht vor 8(=0) anfangen oder länger als 2:00(=1080) gehen")
        End If
        If Endzeit - Startzeit < Film.getFilmlänge Then
            Throw New Exception("Die Veranstaltung geht kürzer als der Film lang ist, das geht nicht !!!")
        End If
        Me._Besucher = Besucher
        '  Me._Saal = Saal
        Me._Film = Film

    End Sub

    'Methoden



    Public Function getAnfangszeit() As Integer 'Als Minutenanzahl seit 8:00, also 8:0 0 = 0; 9:00 = 60; ...
        Return _Startzeit
    End Function
    Public Function getEndzeit() As Integer 'Als Minutenanzahl seit 8:00, also 8:0 0 = 0; 9:00 = 60; ...
        Return _Endzeit
    End Function
    Public Function getSaal() As Kinosaal  'Als Minutenanzahl seit 8:00, also 8:0 0 = 0; 9:00 = 60; ...
        Return _Saal
    End Function
    Public Function getAlleBesucher() As ArrayList  'Als Minutenanzahl seit 8:00, also 8:0 0 = 0; 9:00 = 60; ...
        Return _Besucher
    End Function
    Public Function getBesucher(a As Integer) As Kunde   'Als Minutenanzahl seit 8:00, also 8:0 0 = 0; 9:00 = 60; ...
        Return _Besucher(a)
    End Function

    Public Function getFilm() As Film 'Als Minutenanzahl seit 8:00, also 8:0 0 = 0; 9:00 = 60; ...
        Return _Film
    End Function


    Public Sub FilmÄndern(Film As Film) Implements IVorstellung.FilmÄndern
        Me._Film = Film
    End Sub

    Private Sub BesucherHinzufügen(Besucher As Kunde) Implements IVorstellung.BesucherHinzufügen
        _Besucher.Add(Besucher)
    End Sub
    Private Sub BesucherEntfernen(Besucher As Kunde)
        _Besucher.RemoveAt(_Besucher.LastIndexOf(Besucher))
    End Sub
    Private Sub BesucherEntfernen(Nr As Integer)
        _Besucher.RemoveAt(Nr)
    End Sub


    Private Sub SaalÄndern(Saal As Kinosaal) Implements IVorstellung.SaalÄndern
        Me._Saal = Saal
    End Sub

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

    Public Function getLänge() As Integer
        Return (getEndzeit() - getAnfangszeit())
    End Function
End Class

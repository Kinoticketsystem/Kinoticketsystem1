Imports Kinoticketsystem

Public Class Vorstellung
    'Attribute
    Implements IVorstellung
    Private Startzeit As Date 'Verbunden mit Datum?
    Private Endzeit As Date
    Private Besucher As ArrayList
    Private Saal As String 'falls wir keine nummern nehmen
    Private Film As String



    'Konstruktor
    Public Sub New(ByVal Startzeit As Date, ByVal Endzeit As Date, ByVal Besucher As ArrayList, ByVal Saal As String, ByVal Film As String)
        Me.Startzeit = Startzeit
        Me.Endzeit = Endzeit
        Me.Besucher = Besucher
        Me.Saal = Saal
        Me.Film = Film

    End Sub

    'Methoden

    Public Sub FilmÄndern(Film As String) Implements IVorstellung.FilmÄndern
        Me.Film = txtFilmnummer.Text
        MsgBox("Neuer Film:" & txtFilmnummer.Text)
    End Sub

    Private Sub IVorstellung_BesucherHinzufügen(Besucher As Kunde) Implements IVorstellung.BesucherHinzufügen
        'Besucher.
    End Sub

    Private Sub IVorstellung_SaalÄndern(Saal As String) Implements IVorstellung.SaalÄndern
        Me.Saal = Saal
        MsgBox(Film & "läuft jetzt im Saal" & Saal)
    End Sub
End Class

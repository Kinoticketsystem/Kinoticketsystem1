Imports Kinoticketsystem

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
    Public Sub VorstellungÄndern(Vorstellung As Vorstellung, Filmnummer As Integer) Implements ITagesplan.VorstellungÄndern
        _Vorstellungen(Filmnummer + 1) = Vorstellung
    End Sub

    Public Sub VorstellungHinzufügen(Vorstellung As Vorstellung) Implements ITagesplan.VorstellungHinzufügen
        _Vorstellungen(AnzahlFilmeProTag) = Vorstellung
        AnzahlFilmeProTag = AnzahlFilmeProTag + 1
    End Sub

    Public Sub VorstellungEntfernen(vorstellung As Vorstellung, Position As Integer) Implements ITagesplan.VorstellungEntfernen
        _Vorstellungen(AnzahlFilmeProTag) = Nothing
        AnzahlFilmeProTag = AnzahlFilmeProTag - 1
    End Sub

    Public Function getVorstellungen() As Array Implements ITagesplan.getVorstellungen
        Throw New NotImplementedException()
    End Function

    Public Function getVorstellung(Position As Integer) As Film Implements ITagesplan.getVorstellung
        Throw New NotImplementedException()
    End Function

    Public Function getAnzahlVorstellungen() As Integer Implements ITagesplan.getAnzahlVorstellungen
        Throw New NotImplementedException()
    End Function
End Class
Imports Kinoticketsystem

Public Class Tagesplan
    Implements ITagesplan
    Private MaximaleAnzahlFilmeProTag As Integer = 10
    'Private _Vorstellungen(MaximaleAnzahlFilmeProTag) As Vorstellung 
    Private AnzahlFilmeProTag As Integer
    Private _Vorstellungen As ArrayList = New ArrayList()

    'Es muss zusätzlich zum Konstruktor IMMER auch eine ErstellenMEthode aufgerufen werden
    'Es wird geprüft, ob sich die Vorstellungen überschneiden (ob sie nicht zu früh oder zu spät anfangen siehe Vorstellung)
    Public Sub New()
        ' _Vorstellungen = New Vorstellung() {}
    End Sub
    Public Sub TagesplanErstellen5(Vorstellung1 As Vorstellung, Vorstellung2 As Vorstellung, Vorstellung3 As Vorstellung, Vorstellung4 As Vorstellung, Vorstellung5 As Vorstellung) Implements ITagesplan.TagesplanErstellen
        _Vorstellungen(1) = Vorstellung1
        _Vorstellungen(2) = Vorstellung2
        _Vorstellungen(3) = Vorstellung3
        _Vorstellungen(4) = Vorstellung4
        _Vorstellungen(5) = Vorstellung5
        AnzahlFilmeProTag = 5
        If Vorstellung1.getEndzeit > Vorstellung2.getAnfangszeit Then
            Throw New Exception("die vorstellung2 beginnt, bevor die vorstellung endet")
        End If
        If Vorstellung2.getEndzeit > Vorstellung3.getAnfangszeit Then
            Throw New Exception("die vorstellung3 beginnt, bevor die vorstellung2 endet")
        End If
        If Vorstellung3.getEndzeit > Vorstellung4.getAnfangszeit Then
            Throw New Exception("die vorstellung4 beginnt, bevor die vorstellung3 endet")
        End If
        If Vorstellung4.getEndzeit > Vorstellung5.getAnfangszeit Then
            Throw New Exception("die vorstellung5 beginnt, bevor die vorstellung4 endet")
        End If
    End Sub
    Public Sub TagesplanErstellen4(Vorstellung1 As Vorstellung, Vorstellung2 As Vorstellung, Vorstellung3 As Vorstellung, Vorstellung4 As Vorstellung)
        _Vorstellungen(1) = Vorstellung1
        _Vorstellungen(2) = Vorstellung2
        _Vorstellungen(3) = Vorstellung3
        _Vorstellungen(4) = Vorstellung4
        AnzahlFilmeProTag = 4
        'For i As Integer = 0 To MaximaleAnzahlFilmeProTag - 1

        'Next
        If Vorstellung1.getEndzeit > Vorstellung2.getAnfangszeit Then
            Throw New Exception("die vorstellung2 beginnt, bevor die vorstellung endet")
        End If
        If Vorstellung2.getEndzeit > Vorstellung3.getAnfangszeit Then
            Throw New Exception("die vorstellung3 beginnt, bevor die vorstellung2 endet")
        End If
        If Vorstellung3.getEndzeit > Vorstellung4.getAnfangszeit Then
            Throw New Exception("die vorstellung4 beginnt, bevor die vorstellung3 endet")
        End If
    End Sub
    Public Sub TagesplanErstellen3(Vorstellung1 As Vorstellung, Vorstellung2 As Vorstellung, Vorstellung3 As Vorstellung)
        _Vorstellungen(1) = Vorstellung1
        _Vorstellungen(2) = Vorstellung2
        _Vorstellungen(3) = Vorstellung3
        AnzahlFilmeProTag = 3
        'For i As Integer = 0 To MaximaleAnzahlFilmeProTag - 1

        'Next
        If Vorstellung1.getEndzeit > Vorstellung2.getAnfangszeit Then
            Throw New Exception("die vorstellung2 beginnt, bevor die vorstellung endet")
        End If
        If Vorstellung2.getEndzeit > Vorstellung3.getAnfangszeit Then
            Throw New Exception("die vorstellung3 beginnt, bevor die vorstellung2 endet")
        End If
    End Sub
    Public Sub TagesplanErstellen2(Vorstellung1 As Vorstellung, Vorstellung2 As Vorstellung)
        _Vorstellungen(1) = Vorstellung1
        _Vorstellungen(2) = Vorstellung2
        AnzahlFilmeProTag = 2
        'For i As Integer = 0 To MaximaleAnzahlFilmeProTag - 1

        'Next
        If Vorstellung1.getEndzeit > Vorstellung2.getAnfangszeit Then
            Throw New Exception("die vorstellung2 beginnt, bevor die vorstellung endet")
        End If
    End Sub
    Public Sub TagesplanErstellen1(Vorstellung1 As Vorstellung)
        _Vorstellungen(1) = Vorstellung1
        AnzahlFilmeProTag = 1
        'For i As Integer = 0 To MaximaleAnzahlFilmeProTag - 1

        'Next
    End Sub
    'Filmnummer zwischen [1 und MaximaleAnzahlFilmeProTag]
    Public Sub VorstellungÄndern(Vorstellung As Vorstellung, Vorstellungsnummer As Integer) Implements ITagesplan.VorstellungÄndern
        If (Vorstellungsnummer <= MaximaleAnzahlFilmeProTag) And (Vorstellungsnummer > 0) Then
            _Vorstellungen(Vorstellungsnummer) = Vorstellung
        Else
            Throw New Exception("Die Vorstellung die geändert werden soll, ist nicht an einer Stelle [1;maximaleAnzahlFilmeProTag]")
        End If
    End Sub


    Public Sub VorstellungHinzufügen(Vorstellung As Vorstellung) Implements ITagesplan.VorstellungHinzufügen
        _Vorstellungen(AnzahlFilmeProTag + 1) = Vorstellung
        AnzahlFilmeProTag = AnzahlFilmeProTag + 1
    End Sub

    Public Sub VorstellungEntfernen(vorstellung As Vorstellung, Position As Integer) Implements ITagesplan.VorstellungEntfernen
        _Vorstellungen(Position) = Nothing
        AnzahlFilmeProTag = AnzahlFilmeProTag - 1
    End Sub

    Public Function getVorstellungen() As ArrayList Implements ITagesplan.getVorstellungen
        Return _Vorstellungen
    End Function

    Public Function getVorstellung(Position As Integer) As Vorstellung Implements ITagesplan.getVorstellung
        Return _Vorstellungen(Position)
    End Function

    Public Function getAnzahlVorstellungen() As Integer Implements ITagesplan.getAnzahlVorstellungen
        Return AnzahlFilmeProTag
    End Function
End Class
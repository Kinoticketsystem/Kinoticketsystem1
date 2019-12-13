Imports Kinoticketsystem

Public Class Tagesplan
    Implements ITagesplan
    Private MaximaleAnzahlFilmeProTag As Integer = 10
    Private AnzahlFilmeProTag As Integer
    Private _Saal As Kinosaal
    Private _Vorstellungen As ArrayList = New ArrayList()
    Private _Tag As Integer

    'Es muss zusätzlich zum Konstruktor IMMER auch eine ErstellenMEthode aufgerufen werden
    'Es wird geprüft, ob sich die Vorstellungen überschneiden (ob sie nicht zu früh oder zu spät anfangen siehe Vorstellung)
    Public Sub New()
        ' _Vorstellungen = New Vorstellung() {}
    End Sub
    Public Sub TagesplanErstellen5(Tag As Integer, Vorstellung1 As Vorstellung, Vorstellung2 As Vorstellung, Vorstellung3 As Vorstellung, Vorstellung4 As Vorstellung, Vorstellung5 As Vorstellung) ' Implements ITagesplan.TagesplanErstellen5
        _Vorstellungen.Add(Vorstellung1)
        _Vorstellungen.Add(Vorstellung2)
        _Vorstellungen.Add(Vorstellung3)
        _Vorstellungen.Add(Vorstellung4)
        _Vorstellungen.Add(Vorstellung5)
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
        _Tag = Tag
    End Sub
    Public Sub TagesplanErstellen4(Vorstellung1 As Vorstellung, Vorstellung2 As Vorstellung, Vorstellung3 As Vorstellung, Vorstellung4 As Vorstellung) Implements ITagesplan.TagesplanErstellen4
        _Vorstellungen.Add(Vorstellung1)
        _Vorstellungen.Add(Vorstellung2)
        _Vorstellungen.Add(Vorstellung3)
        _Vorstellungen.Add(Vorstellung4)
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
    Public Sub TagesplanErstellen3(Vorstellung1 As Vorstellung, Vorstellung2 As Vorstellung, Vorstellung3 As Vorstellung) Implements ITagesplan.TagesplanErstellen3
        _Vorstellungen.Add(Vorstellung1)
        _Vorstellungen.Add(Vorstellung2)
        _Vorstellungen.Add(Vorstellung3)
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
    Public Sub TagesplanErstellen2(Vorstellung1 As Vorstellung, Vorstellung2 As Vorstellung) Implements ITagesplan.TagesplanErstellen2
        If Vorstellung1.getAnfangszeit < Vorstellung2.getAnfangszeit Then 'so müsste man es eigentlich noch bei den anderen Tagesplanerstellen implementieren. 
            _Vorstellungen.Add(Vorstellung1)
            _Vorstellungen.Add(Vorstellung2)
            If Vorstellung1.getEndzeit > Vorstellung2.getAnfangszeit Then
                Throw New Exception("die vorstellung2 beginnt, bevor die vorstellung endet")
            End If
        Else
            _Vorstellungen.Add(Vorstellung2)
            _Vorstellungen.Add(Vorstellung1)
            If Vorstellung2.getEndzeit > Vorstellung1.getAnfangszeit Then
                Throw New Exception("die vorstellung2 beginnt, bevor die vorstellung endet")
            End If
        End If

        AnzahlFilmeProTag = 2
        'For i As Integer = 0 To MaximaleAnzahlFilmeProTag - 1

        'Next

    End Sub

    Public Function getNächstenFilm(jetzt As Date) As Vorstellung

        Dim b As ArrayList = _Vorstellungen

        getNächstenFilm = b(0)
        Dim alleFilmeHeuteWarenSchon As Boolean = True
        Dim A As Integer = jetzt.Hour * 60 + jetzt.Minute
        Dim Differenz As Integer = b(0).getAnfangszeit - A
        For i = 0 To AnzahlFilmeProTag - 1
            If (b(i).getAnfangszeit - A) < Differenz And (b(i).getAnfangszeit - A) > 0 Then
                getNächstenFilm = b(i)
                Differenz = (b(i).getAnfangszeit - A)
                alleFilmeHeuteWarenSchon = False
            End If
        Next
        If alleFilmeHeuteWarenSchon Then
            Return New Vorstellung(1070, 1079, New ArrayList, New Film("heute keine Filme mehr", 5, 0, False), _Saal)
        End If
    End Function

    Public Sub TagesplanErstellen1(Vorstellung1 As Vorstellung) Implements ITagesplan.TagesplanErstellen1
        _Vorstellungen.Add(Vorstellung1)
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
        _Vorstellungen.Add(Vorstellung)
        AnzahlFilmeProTag = AnzahlFilmeProTag + 1
    End Sub

    Public Sub VorstellungEntfernen(vorstellung As Vorstellung) Implements ITagesplan.VorstellungEntfernen
        Dim i As Integer = 0
        i = _Vorstellungen.BinarySearch(vorstellung)
        _Vorstellungen.RemoveAt(i)
        AnzahlFilmeProTag = AnzahlFilmeProTag - 1
    End Sub
    Public Sub AlleVorstellungenEntfernen()

    End Sub

    Public Function getVorstellungen() As ArrayList Implements ITagesplan.getVorstellungen
        Return _Vorstellungen
    End Function

    Public Function getVorstellung(Position As Integer) As Vorstellung Implements ITagesplan.getVorstellung

        Return _Vorstellungen(Position - 1) '-1 weil es so in FTagesplan aufgerufen wird Bei Position der Buttons

    End Function

    Public Function getAnzahlVorstellungen() As Integer Implements ITagesplan.getAnzahlVorstellungen
        Return AnzahlFilmeProTag
    End Function

    Public Function getSaal() As Kinosaal Implements ITagesplan.getSaal
        Return _Saal
    End Function
    Public Sub setSaal(a As Kinosaal)
        _Saal = a
    End Sub
    Public Sub setTag(tag As Integer)
        _Tag = tag
    End Sub
    Public Function getFSK(Stelle As Integer) As Integer Implements ITagesplan.getFSK
        Return _Vorstellungen(Stelle).getFilm.getAltersfreigabe
    End Function
End Class
Imports Kinoticketsystem

Public Class FTagesplan
    Private _ersterTag As ITagesplan
    Private _zweiterTag As ITagesplan
    Private _dritterTag As ITagesplan
    Private _vierterTag As ITagesplan
    Private _fünfterTag As ITagesplan
    Private _sechsterTag As ITagesplan
    Private _siebterTag As ITagesplan
    Private _Aendern As Boolean
    Private _Kinosaal As Kinosaal
    Private _Kunde As Kunde = New Kunde("Standard")
    'Die nächsten 7 Tage werden angezeigt
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AnfangstagUndDatümerFestlegen() 'fertig
        PositionDerDatümerFestlegen()   'fertig
        PositionDerFilmButtonsFestlegenX()  'fertig
        'WochenplanAbrufenUndAusgeben()  'muss noch gemacht werden (Erik) 'nicht von hier auslesen, sondern es wird beim aufrufen mit übergeben
        VorübergehendeInitialisierungderVeranstaltungenAlleMitDemGleichenFIlm() 'wird später Standartinitialisierung, falls nichts übergeben wird
        GrößeDerFilmButtonsFestlegen()  'Y - Größe funktioniert nur wenn Veranstaltungen eingelesen und initialisiert wurden, weil  Null referenz
        PositionDerFilmButtonsFestlegenY()  'eigentlich fertig, oder nicht?
        ' ButtonsInvisibleMachen() 'das sind die Buttons die gerade nicht benutzt werden 'werden jetzt benutzt ;-)
        FarbeDerButtonsFestlegen() 'muss noch für fast alle Buttons gemacht werden


    End Sub
    Public Sub InitialisiereDenWochenplan(ByRef ersterTag As ITagesplan, ByRef zweiterTag As ITagesplan, ByRef dritterTag As ITagesplan, ByRef vierterTag As ITagesplan, ByRef fünfterTag As ITagesplan, ByRef sechsterTag As ITagesplan, ByRef siebterTag As ITagesplan)
        _ersterTag = ersterTag
        _zweiterTag = zweiterTag
        _dritterTag = dritterTag
        _vierterTag = vierterTag
        _fünfterTag = fünfterTag
        _sechsterTag = sechsterTag
        _siebterTag = siebterTag
        GrößeDerFilmButtonsFestlegen()
        PositionDerFilmButtonsFestlegenY()
    End Sub
    Public Sub SetKinosaal(a As Kinosaal)
        _Kinosaal = a
    End Sub
    Public Function GetKinosaal() As Kinosaal
        Return _Kinosaal
    End Function

    Private Sub welcheFarbe(ByVal a As Button, tag As Tagesplan, position As Integer)
        position -= 1 'wichtig weil es in FarbeDerButtonsFestlegen der erste mit 1 und nicht mit 0 aufgerufen wird
        Dim b As Integer = tag.getFSK(position)
        If b <= 0 Then
            a.BackColor = Color.White
        ElseIf b <= 6 Then
            a.BackColor = Color.Yellow

        ElseIf b <= 12 Then
            a.BackColor = Color.Green
        ElseIf b <= 16 Then
            a.BackColor = Color.Blue
        Else
            a.BackColor = Color.Red
        End If
        ButtonsSchönMachen(a)
    End Sub
    Private Sub ButtonsSchönMachen(a As Button)
        a.FlatStyle = FlatStyle.Flat 'Notwendig!!!
        a.FlatAppearance.BorderColor = Color.DarkCyan 'kann man machen, ohne sieht aber auch nicht schlecht aus 
        a.FlatAppearance.BorderSize = 3 'kann man machen, aber schmal sieht auch nicht schlecht aus (Standart ist ok)
        a.ForeColor = Color.White 'ganz cool, aber nicht notwendig
    End Sub
    Private Sub FarbeDerButtonsFestlegen()
        'Farbe für alle Buttons machen, müssen ja nicht alle angezeigt wqerden
        'geht nicht wegen array hat ja bei den Veranstaltungen, die es nicht gibt auch kein FSK, also doch select case
        Select Case _ersterTag.getAnzahlVorstellungen
            Case 1
                welcheFarbe(Button1, _ersterTag, 1)
            Case 2
                welcheFarbe(Button1, _ersterTag, 1)
                welcheFarbe(Button2, _ersterTag, 2)
            Case 3
                welcheFarbe(Button1, _ersterTag, 1)
                welcheFarbe(Button2, _ersterTag, 2)
                welcheFarbe(Button3, _ersterTag, 3)
            Case 4
                welcheFarbe(Button1, _ersterTag, 1)
                welcheFarbe(Button2, _ersterTag, 2)
                welcheFarbe(Button3, _ersterTag, 3)
                welcheFarbe(Button4, _ersterTag, 4)
            Case 5
                welcheFarbe(Button1, _ersterTag, 1)
                welcheFarbe(Button2, _ersterTag, 2)
                welcheFarbe(Button3, _ersterTag, 3)
                welcheFarbe(Button4, _ersterTag, 4)
                welcheFarbe(Button5, _ersterTag, 5)
            Case 6
                welcheFarbe(Button1, _ersterTag, 1)
                welcheFarbe(Button2, _ersterTag, 2)
                welcheFarbe(Button3, _ersterTag, 3)
                welcheFarbe(Button4, _ersterTag, 4)
                welcheFarbe(Button5, _ersterTag, 5)
                welcheFarbe(Button6, _ersterTag, 6)
            Case 7
                welcheFarbe(Button1, _ersterTag, 1)
                welcheFarbe(Button2, _ersterTag, 2)
                welcheFarbe(Button3, _ersterTag, 3)
                welcheFarbe(Button4, _ersterTag, 4)
                welcheFarbe(Button5, _ersterTag, 5)
                welcheFarbe(Button6, _ersterTag, 6)
                welcheFarbe(Button7, _ersterTag, 7)
        End Select

        Select Case _zweiterTag.getAnzahlVorstellungen
            Case 1
                welcheFarbe(Button8, _zweiterTag, 1)
            Case 2
                welcheFarbe(Button8, _zweiterTag, 1)
                welcheFarbe(Button9, _zweiterTag, 2)
            Case 3
                welcheFarbe(Button8, _zweiterTag, 1)
                welcheFarbe(Button9, _zweiterTag, 2)
                welcheFarbe(Button10, _zweiterTag, 3)
            Case 4
                welcheFarbe(Button8, _zweiterTag, 1)
                welcheFarbe(Button9, _zweiterTag, 2)
                welcheFarbe(Button10, _zweiterTag, 3)
                welcheFarbe(Button11, _zweiterTag, 4)
            Case 5
                welcheFarbe(Button8, _zweiterTag, 1)
                welcheFarbe(Button9, _zweiterTag, 2)
                welcheFarbe(Button10, _zweiterTag, 3)
                welcheFarbe(Button11, _zweiterTag, 4)
                welcheFarbe(Button12, _zweiterTag, 5)
            Case 6

                welcheFarbe(Button8, _zweiterTag, 1)
                welcheFarbe(Button9, _zweiterTag, 2)
                welcheFarbe(Button10, _zweiterTag, 3)
                welcheFarbe(Button11, _zweiterTag, 4)
                welcheFarbe(Button12, _zweiterTag, 5)
                welcheFarbe(Button13, _zweiterTag, 6)
            Case 7
                welcheFarbe(Button8, _zweiterTag, 1)
                welcheFarbe(Button9, _zweiterTag, 2)
                welcheFarbe(Button10, _zweiterTag, 3)
                welcheFarbe(Button11, _zweiterTag, 4)
                welcheFarbe(Button12, _zweiterTag, 5)
                welcheFarbe(Button13, _zweiterTag, 6)
                welcheFarbe(Button14, _zweiterTag, 7)

        End Select

        Select Case _dritterTag.getAnzahlVorstellungen
            Case 1
                welcheFarbe(Button15, _dritterTag, 1)

            Case 2
                welcheFarbe(Button15, _dritterTag, 1)
                welcheFarbe(Button16, _dritterTag, 2)
            Case 3
                welcheFarbe(Button15, _dritterTag, 1)
                welcheFarbe(Button16, _dritterTag, 2)
                welcheFarbe(Button17, _dritterTag, 3)
            Case 4
                welcheFarbe(Button15, _dritterTag, 1)
                welcheFarbe(Button16, _dritterTag, 2)
                welcheFarbe(Button17, _dritterTag, 3)
                welcheFarbe(Button18, _dritterTag, 4)
            Case 5

                welcheFarbe(Button15, _dritterTag, 1)
                welcheFarbe(Button16, _dritterTag, 2)
                welcheFarbe(Button17, _dritterTag, 3)
                welcheFarbe(Button18, _dritterTag, 4)
                welcheFarbe(Button19, _dritterTag, 5)
            Case 6
                welcheFarbe(Button15, _dritterTag, 1)
                welcheFarbe(Button16, _dritterTag, 2)
                welcheFarbe(Button17, _dritterTag, 3)
                welcheFarbe(Button18, _dritterTag, 4)
                welcheFarbe(Button19, _dritterTag, 5)
                welcheFarbe(Button20, _dritterTag, 6)
            Case 7
                welcheFarbe(Button15, _dritterTag, 1)
                welcheFarbe(Button16, _dritterTag, 2)
                welcheFarbe(Button17, _dritterTag, 3)
                welcheFarbe(Button18, _dritterTag, 4)
                welcheFarbe(Button19, _dritterTag, 5)
                welcheFarbe(Button20, _dritterTag, 6)
                welcheFarbe(Button21, _dritterTag, 7)

        End Select

        Select Case _vierterTag.getAnzahlVorstellungen
            Case 1
                welcheFarbe(Button22, _vierterTag, 1)
            Case 2

                welcheFarbe(Button22, _vierterTag, 1)
                welcheFarbe(Button23, _vierterTag, 2)
            Case 3
                welcheFarbe(Button22, _vierterTag, 1)
                welcheFarbe(Button23, _vierterTag, 2)
                welcheFarbe(Button24, _vierterTag, 3)
            Case 4

                welcheFarbe(Button22, _vierterTag, 1)
                welcheFarbe(Button23, _vierterTag, 2)
                welcheFarbe(Button24, _vierterTag, 3)
                welcheFarbe(Button25, _vierterTag, 4)
            Case 5
                welcheFarbe(Button22, _vierterTag, 1)
                welcheFarbe(Button23, _vierterTag, 2)
                welcheFarbe(Button24, _vierterTag, 3)
                welcheFarbe(Button25, _vierterTag, 4)
                welcheFarbe(Button26, _vierterTag, 5)
            Case 6

                welcheFarbe(Button22, _vierterTag, 1)
                welcheFarbe(Button23, _vierterTag, 2)
                welcheFarbe(Button24, _vierterTag, 3)
                welcheFarbe(Button25, _vierterTag, 4)
                welcheFarbe(Button26, _vierterTag, 5)
                welcheFarbe(Button27, _vierterTag, 6)
            Case 7
                welcheFarbe(Button22, _vierterTag, 1)
                welcheFarbe(Button23, _vierterTag, 2)
                welcheFarbe(Button24, _vierterTag, 3)
                welcheFarbe(Button25, _vierterTag, 4)
                welcheFarbe(Button26, _vierterTag, 5)
                welcheFarbe(Button27, _vierterTag, 6)
                welcheFarbe(Button28, _vierterTag, 7)

        End Select

        Select Case _fünfterTag.getAnzahlVorstellungen
            Case 1
                welcheFarbe(Button29, _fünfterTag, 1)
            Case 2

                welcheFarbe(Button29, _fünfterTag, 1)
                welcheFarbe(Button30, _fünfterTag, 2)
            Case 3
                welcheFarbe(Button29, _fünfterTag, 1)
                welcheFarbe(Button30, _fünfterTag, 2)
                welcheFarbe(Button31, _fünfterTag, 3)
            Case 4

                welcheFarbe(Button29, _fünfterTag, 1)
                welcheFarbe(Button30, _fünfterTag, 2)
                welcheFarbe(Button31, _fünfterTag, 3)
                welcheFarbe(Button32, _fünfterTag, 4)
            Case 5
                welcheFarbe(Button29, _fünfterTag, 1)
                welcheFarbe(Button30, _fünfterTag, 2)
                welcheFarbe(Button31, _fünfterTag, 3)
                welcheFarbe(Button32, _fünfterTag, 4)
                welcheFarbe(Button33, _fünfterTag, 5)
            Case 6
                welcheFarbe(Button29, _fünfterTag, 1)
                welcheFarbe(Button30, _fünfterTag, 2)
                welcheFarbe(Button31, _fünfterTag, 3)
                welcheFarbe(Button32, _fünfterTag, 4)
                welcheFarbe(Button33, _fünfterTag, 5)
                welcheFarbe(Button34, _fünfterTag, 6)
            Case 7
                welcheFarbe(Button29, _fünfterTag, 1)
                welcheFarbe(Button30, _fünfterTag, 2)
                welcheFarbe(Button31, _fünfterTag, 3)
                welcheFarbe(Button32, _fünfterTag, 4)
                welcheFarbe(Button33, _fünfterTag, 5)
                welcheFarbe(Button34, _fünfterTag, 6)
                welcheFarbe(Button35, _fünfterTag, 7)

        End Select

        Select Case _sechsterTag.getAnzahlVorstellungen
            Case 1
                welcheFarbe(Button36, _sechsterTag, 1)
            Case 2
                welcheFarbe(Button36, _sechsterTag, 1)
                welcheFarbe(Button37, _sechsterTag, 2)
            Case 3
                welcheFarbe(Button36, _sechsterTag, 1)
                welcheFarbe(Button37, _sechsterTag, 2)
                welcheFarbe(Button38, _sechsterTag, 3)
            Case 4
                welcheFarbe(Button36, _sechsterTag, 1)
                welcheFarbe(Button37, _sechsterTag, 2)
                welcheFarbe(Button38, _sechsterTag, 3)
                welcheFarbe(Button39, _sechsterTag, 4)
            Case 5

                welcheFarbe(Button36, _sechsterTag, 1)
                welcheFarbe(Button37, _sechsterTag, 2)
                welcheFarbe(Button38, _sechsterTag, 3)
                welcheFarbe(Button39, _sechsterTag, 4)
                welcheFarbe(Button40, _sechsterTag, 5)
            Case 6
                welcheFarbe(Button36, _sechsterTag, 1)
                welcheFarbe(Button37, _sechsterTag, 2)
                welcheFarbe(Button38, _sechsterTag, 3)
                welcheFarbe(Button39, _sechsterTag, 4)
                welcheFarbe(Button40, _sechsterTag, 5)
                welcheFarbe(Button41, _sechsterTag, 6)
            Case 7
                welcheFarbe(Button36, _sechsterTag, 1)
                welcheFarbe(Button37, _sechsterTag, 2)
                welcheFarbe(Button38, _sechsterTag, 3)
                welcheFarbe(Button39, _sechsterTag, 4)
                welcheFarbe(Button40, _sechsterTag, 5)
                welcheFarbe(Button41, _sechsterTag, 6)
                welcheFarbe(Button42, _sechsterTag, 7)

        End Select

        Select Case _siebterTag.getAnzahlVorstellungen
            Case 1
                welcheFarbe(Button43, _siebterTag, 1)
            Case 2

                welcheFarbe(Button43, _siebterTag, 1)
                welcheFarbe(Button44, _siebterTag, 2)
            Case 3
                welcheFarbe(Button43, _siebterTag, 1)
                welcheFarbe(Button44, _siebterTag, 2)
                welcheFarbe(Button45, _siebterTag, 3)
            Case 4

                welcheFarbe(Button43, _siebterTag, 1)
                welcheFarbe(Button44, _siebterTag, 2)
                welcheFarbe(Button45, _siebterTag, 3)
                welcheFarbe(Button46, _siebterTag, 4)
            Case 5
                welcheFarbe(Button43, _siebterTag, 1)
                welcheFarbe(Button44, _siebterTag, 2)
                welcheFarbe(Button45, _siebterTag, 3)
                welcheFarbe(Button46, _siebterTag, 4)
                welcheFarbe(Button47, _siebterTag, 5)
            Case 6
                welcheFarbe(Button43, _siebterTag, 1)
                welcheFarbe(Button44, _siebterTag, 2)
                welcheFarbe(Button45, _siebterTag, 3)
                welcheFarbe(Button46, _siebterTag, 4)
                welcheFarbe(Button47, _siebterTag, 5)
                welcheFarbe(Button48, _siebterTag, 6)
            Case 7
                welcheFarbe(Button43, _siebterTag, 1)
                welcheFarbe(Button44, _siebterTag, 2)
                welcheFarbe(Button45, _siebterTag, 3)
                welcheFarbe(Button46, _siebterTag, 4)
                welcheFarbe(Button47, _siebterTag, 5)
                welcheFarbe(Button48, _siebterTag, 6)
                welcheFarbe(Button49, _siebterTag, 7)
        End Select
    End Sub

    'Private Sub WochenplanAbrufenUndAusgeben() 'unnötig, wird in der Klasse Kino gemacht und dann eine andere Methode genutzt
    'Auslesen aus einer externen Textdatei
    '_ersterTag
    '_zweiterTag
    '_dritterTag
    '_vierterTag
    '_fünfterTag
    '_sechsterTag
    '_siebterTag
    'Anzeigen

    ' Button1.Text = _Montag.
    'PositionDerFilmButtonsFestlegenY()

    ' End Sub
    Private Sub VorübergehendeInitialisierungderVeranstaltungenAlleMitDemGleichenFIlm()
        Dim a As Film = New Film("Star Wars 1", 120, 12, True)
        Dim f As Kinosaal = New Kinosaal(120, 8, 15)

        Dim b As Vorstellung = New Vorstellung(480, 600, Nothing, a, f)
        Dim c As Vorstellung = New Vorstellung(606, 830, Nothing, a, f)
        Dim d As Vorstellung = New Vorstellung(840, 1080, Nothing, a, f)
        Dim e As Vorstellung = New Vorstellung(1380, 1519, Nothing, a, f)

        _ersterTag = New Tagesplan
        _zweiterTag = New Tagesplan
        _dritterTag = New Tagesplan
        _vierterTag = New Tagesplan
        _fünfterTag = New Tagesplan
        _sechsterTag = New Tagesplan
        _siebterTag = New Tagesplan

        _ersterTag.TagesplanErstellen2(b, c)
        _ersterTag.VorstellungHinzufügen(d)
        _ersterTag.VorstellungHinzufügen(e)
        _zweiterTag.TagesplanErstellen1(b)
        _dritterTag.TagesplanErstellen2(b, d)
        _vierterTag.TagesplanErstellen1(b)
        _fünfterTag.TagesplanErstellen2(b, c)
        _sechsterTag.TagesplanErstellen1(b)
        _siebterTag.TagesplanErstellen1(b)
    End Sub
    Private Sub PositionDerFilmButtonsFestlegenY()
        'Wenn die Zahl der Filme pro Tag variiert
        'erster Tag
        Select Case _ersterTag.getAnzahlVorstellungen
            Case 1
                Button1.Top = (_ersterTag.getVorstellung(1).getAnfangszeit()) / 3 + 70
                Button2.Hide()
                Button3.Hide()
                Button4.Hide()
                Button5.Hide()
                Button6.Hide()
                Button7.Hide()
            Case 2
                Button1.Top = (_ersterTag.getVorstellung(1).getAnfangszeit()) / 3 + 70
                Button2.Top = (_ersterTag.getVorstellung(2).getAnfangszeit()) / 3 + 70
                Button3.Hide()
                Button4.Hide()
                Button5.Hide()
                Button6.Hide()
                Button7.Hide()
            Case 3
                Button1.Top = (_ersterTag.getVorstellung(1).getAnfangszeit()) / 3 + 70
                Button2.Top = (_ersterTag.getVorstellung(2).getAnfangszeit()) / 3 + 70
                Button3.Top = (_ersterTag.getVorstellung(3).getAnfangszeit()) / 3 + 70
                Button4.Hide()
                Button5.Hide()
                Button6.Hide()
                Button7.Hide()
            Case 4
                Button1.Top = (_ersterTag.getVorstellung(1).getAnfangszeit()) / 3 + 70
                Button2.Top = (_ersterTag.getVorstellung(2).getAnfangszeit()) / 3 + 70
                Button3.Top = (_ersterTag.getVorstellung(3).getAnfangszeit()) / 3 + 70
                Button4.Top = (_ersterTag.getVorstellung(4).getAnfangszeit()) / 3 + 70
                Button5.Hide()
                Button6.Hide()
                Button7.Hide()
            Case 5
                Button1.Top = (_ersterTag.getVorstellung(1).getAnfangszeit()) / 3 + 70
                Button2.Top = (_ersterTag.getVorstellung(2).getAnfangszeit()) / 3 + 70
                Button3.Top = (_ersterTag.getVorstellung(3).getAnfangszeit()) / 3 + 70
                Button4.Top = (_ersterTag.getVorstellung(4).getAnfangszeit()) / 3 + 70
                Button5.Top = (_ersterTag.getVorstellung(5).getAnfangszeit()) / 3 + 70
                Button6.Hide()
                Button7.Hide()
            Case 6
                Button1.Top = (_ersterTag.getVorstellung(1).getAnfangszeit()) / 3 + 70
                Button2.Top = (_ersterTag.getVorstellung(2).getAnfangszeit()) / 3 + 70
                Button3.Top = (_ersterTag.getVorstellung(3).getAnfangszeit()) / 3 + 70
                Button4.Top = (_ersterTag.getVorstellung(4).getAnfangszeit()) / 3 + 70
                Button5.Top = (_ersterTag.getVorstellung(5).getAnfangszeit()) / 3 + 70
                Button6.Top = (_ersterTag.getVorstellung(6).getAnfangszeit()) / 3 + 70
                Button7.Hide()
            Case 7
                Button1.Top = (_ersterTag.getVorstellung(1).getAnfangszeit()) / 3 + 70
                Button2.Top = (_ersterTag.getVorstellung(2).getAnfangszeit()) / 3 + 70
                Button3.Top = (_ersterTag.getVorstellung(3).getAnfangszeit()) / 3 + 70
                Button4.Top = (_ersterTag.getVorstellung(4).getAnfangszeit()) / 3 + 70
                Button5.Top = (_ersterTag.getVorstellung(5).getAnfangszeit()) / 3 + 70
                Button6.Top = (_ersterTag.getVorstellung(6).getAnfangszeit()) / 3 + 70
                Button7.Top = (_ersterTag.getVorstellung(7).getAnfangszeit()) / 3 + 70
            Case Else
                Throw New Exception("Die Anzahl der gespeicherten Filme für den ersten Tag, entspricht nicht der Anzahl der möglichen darstellbaren Filme (0<x<8")
        End Select
        Select Case _zweiterTag.getAnzahlVorstellungen
            Case 1
                Button8.Top = (_zweiterTag.getVorstellung(1).getAnfangszeit()) / 3 + 70
                Button9.Hide()
                Button10.Hide()
                Button11.Hide()
                Button12.Hide()
                Button13.Hide()
                Button14.Hide()
            Case 2
                Button8.Top = (_zweiterTag.getVorstellung(1).getAnfangszeit()) / 3 + 70
                Button9.Top = (_zweiterTag.getVorstellung(2).getAnfangszeit()) / 3 + 70
                Button10.Hide()
                Button11.Hide()
                Button12.Hide()
                Button13.Hide()
                Button14.Hide()
            Case 3
                Button8.Top = (_zweiterTag.getVorstellung(1).getAnfangszeit()) / 3 + 70
                Button9.Top = (_zweiterTag.getVorstellung(2).getAnfangszeit()) / 3 + 70
                Button10.Top = (_zweiterTag.getVorstellung(3).getAnfangszeit()) / 3 + 70
                Button11.Hide()
                Button12.Hide()
                Button13.Hide()
                Button14.Hide()
            Case 4
                Button8.Top = (_zweiterTag.getVorstellung(1).getAnfangszeit()) / 3 + 70
                Button9.Top = (_zweiterTag.getVorstellung(2).getAnfangszeit()) / 3 + 70
                Button10.Top = (_zweiterTag.getVorstellung(3).getAnfangszeit()) / 3 + 70
                Button11.Top = (_zweiterTag.getVorstellung(4).getAnfangszeit()) / 3 + 70
                Button12.Hide()
                Button13.Hide()
                Button14.Hide()
            Case 5
                Button8.Top = (_zweiterTag.getVorstellung(1).getAnfangszeit()) / 3 + 70
                Button9.Top = (_zweiterTag.getVorstellung(2).getAnfangszeit()) / 3 + 70
                Button10.Top = (_zweiterTag.getVorstellung(3).getAnfangszeit()) / 3 + 70
                Button11.Top = (_zweiterTag.getVorstellung(4).getAnfangszeit()) / 3 + 70
                Button12.Top = (_zweiterTag.getVorstellung(5).getAnfangszeit()) / 3 + 70
                Button13.Hide()
                Button14.Hide()
            Case 6
                Button8.Top = (_zweiterTag.getVorstellung(1).getAnfangszeit()) / 3 + 70
                Button9.Top = (_zweiterTag.getVorstellung(2).getAnfangszeit()) / 3 + 70
                Button10.Top = (_zweiterTag.getVorstellung(3).getAnfangszeit()) / 3 + 70
                Button11.Top = (_zweiterTag.getVorstellung(4).getAnfangszeit()) / 3 + 70
                Button12.Top = (_zweiterTag.getVorstellung(5).getAnfangszeit()) / 3 + 70
                Button13.Top = (_zweiterTag.getVorstellung(6).getAnfangszeit()) / 3 + 70
                Button14.Hide()
            Case 7
                Button8.Top = (_zweiterTag.getVorstellung(1).getAnfangszeit()) / 3 + 70
                Button9.Top = (_zweiterTag.getVorstellung(2).getAnfangszeit()) / 3 + 70
                Button10.Top = (_zweiterTag.getVorstellung(3).getAnfangszeit()) / 3 + 70
                Button11.Top = (_zweiterTag.getVorstellung(4).getAnfangszeit()) / 3 + 70
                Button12.Top = (_zweiterTag.getVorstellung(5).getAnfangszeit()) / 3 + 70
                Button13.Top = (_zweiterTag.getVorstellung(6).getAnfangszeit()) / 3 + 70
                Button14.Top = (_zweiterTag.getVorstellung(7).getAnfangszeit()) / 3 + 70
            Case Else
                Throw New Exception("Die Anzahl der gespeicherten Filme für den zweiten Tag, entspricht nicht der Anzahl der möglichen darstellbaren Filme (0<x<8")
        End Select
        Select Case _dritterTag.getAnzahlVorstellungen
            Case 1
                Button15.Top = (_dritterTag.getVorstellung(1).getAnfangszeit()) / 3 + 70
                Button16.Hide()
                Button17.Hide()
                Button18.Hide()
                Button19.Hide()
                Button20.Hide()
                Button21.Hide()
            Case 2
                Button15.Top = (_dritterTag.getVorstellung(1).getAnfangszeit()) / 3 + 70
                Button16.Top = (_dritterTag.getVorstellung(2).getAnfangszeit()) / 3 + 70
                Button17.Hide()
                Button18.Hide()
                Button19.Hide()
                Button20.Hide()
                Button21.Hide()
            Case 3
                Button15.Top = (_dritterTag.getVorstellung(1).getAnfangszeit()) / 3 + 70
                Button16.Top = (_dritterTag.getVorstellung(2).getAnfangszeit()) / 3 + 70
                Button17.Top = (_dritterTag.getVorstellung(3).getAnfangszeit()) / 3 + 70
                Button18.Hide()
                Button19.Hide()
                Button20.Hide()
                Button21.Hide()
            Case 4
                Button15.Top = (_dritterTag.getVorstellung(1).getAnfangszeit()) / 3 + 70
                Button16.Top = (_dritterTag.getVorstellung(2).getAnfangszeit()) / 3 + 70
                Button17.Top = (_dritterTag.getVorstellung(3).getAnfangszeit()) / 3 + 70
                Button18.Top = (_dritterTag.getVorstellung(4).getAnfangszeit()) / 3 + 70
                Button19.Hide()
                Button20.Hide()
                Button21.Hide()
            Case 5
                Button15.Top = (_dritterTag.getVorstellung(1).getAnfangszeit()) / 3 + 70
                Button16.Top = (_dritterTag.getVorstellung(2).getAnfangszeit()) / 3 + 70
                Button17.Top = (_dritterTag.getVorstellung(3).getAnfangszeit()) / 3 + 70
                Button18.Top = (_dritterTag.getVorstellung(4).getAnfangszeit()) / 3 + 70
                Button19.Top = (_dritterTag.getVorstellung(5).getAnfangszeit()) / 3 + 70
                Button20.Hide()
                Button21.Hide()
            Case 6
                Button15.Top = (_dritterTag.getVorstellung(1).getAnfangszeit()) / 3 + 70
                Button16.Top = (_dritterTag.getVorstellung(2).getAnfangszeit()) / 3 + 70
                Button17.Top = (_dritterTag.getVorstellung(3).getAnfangszeit()) / 3 + 70
                Button18.Top = (_dritterTag.getVorstellung(4).getAnfangszeit()) / 3 + 70
                Button19.Top = (_dritterTag.getVorstellung(5).getAnfangszeit()) / 3 + 70
                Button20.Top = (_dritterTag.getVorstellung(6).getAnfangszeit()) / 3 + 70
                Button21.Hide()
            Case 7
                Button15.Top = (_dritterTag.getVorstellung(1).getAnfangszeit()) / 3 + 70
                Button16.Top = (_dritterTag.getVorstellung(2).getAnfangszeit()) / 3 + 70
                Button17.Top = (_dritterTag.getVorstellung(3).getAnfangszeit()) / 3 + 70
                Button18.Top = (_dritterTag.getVorstellung(4).getAnfangszeit()) / 3 + 70
                Button19.Top = (_dritterTag.getVorstellung(5).getAnfangszeit()) / 3 + 70
                Button20.Top = (_dritterTag.getVorstellung(6).getAnfangszeit()) / 3 + 70
                Button21.Top = (_dritterTag.getVorstellung(7).getAnfangszeit()) / 3 + 70
            Case Else
                Throw New Exception("Die Anzahl der gespeicherten Filme für den dritten Tag, entspricht nicht der Anzahl der möglichen darstellbaren Filme (0<x<8")
        End Select
        Select Case _vierterTag.getAnzahlVorstellungen
            Case 1
                Button22.Top = (_vierterTag.getVorstellung(1).getAnfangszeit()) / 3 + 70
                Button23.Hide()
                Button24.Hide()
                Button25.Hide()
                Button26.Hide()
                Button27.Hide()
                Button28.Hide()
            Case 2
                Button22.Top = (_vierterTag.getVorstellung(1).getAnfangszeit()) / 3 + 70
                Button23.Top = (_vierterTag.getVorstellung(2).getAnfangszeit()) / 3 + 70
                Button24.Hide()
                Button25.Hide()
                Button26.Hide()
                Button27.Hide()
                Button28.Hide()
            Case 3
                Button22.Top = (_vierterTag.getVorstellung(1).getAnfangszeit()) / 3 + 70
                Button23.Top = (_vierterTag.getVorstellung(2).getAnfangszeit()) / 3 + 70
                Button24.Top = (_vierterTag.getVorstellung(3).getAnfangszeit()) / 3 + 70
                Button25.Hide()
                Button26.Hide()
                Button27.Hide()
                Button28.Hide()
            Case 4
                Button22.Top = (_vierterTag.getVorstellung(1).getAnfangszeit()) / 3 + 70
                Button23.Top = (_vierterTag.getVorstellung(2).getAnfangszeit()) / 3 + 70
                Button24.Top = (_vierterTag.getVorstellung(3).getAnfangszeit()) / 3 + 70
                Button25.Top = (_vierterTag.getVorstellung(4).getAnfangszeit()) / 3 + 70
                Button26.Hide()
                Button27.Hide()
                Button28.Hide()
            Case 5
                Button22.Top = (_vierterTag.getVorstellung(1).getAnfangszeit()) / 3 + 70
                Button23.Top = (_vierterTag.getVorstellung(2).getAnfangszeit()) / 3 + 70
                Button24.Top = (_vierterTag.getVorstellung(3).getAnfangszeit()) / 3 + 70
                Button25.Top = (_vierterTag.getVorstellung(4).getAnfangszeit()) / 3 + 70
                Button26.Top = (_vierterTag.getVorstellung(5).getAnfangszeit()) / 3 + 70
                Button27.Hide()
                Button28.Hide()
            Case 6
                Button22.Top = (_vierterTag.getVorstellung(1).getAnfangszeit()) / 3 + 70
                Button23.Top = (_vierterTag.getVorstellung(2).getAnfangszeit()) / 3 + 70
                Button24.Top = (_vierterTag.getVorstellung(3).getAnfangszeit()) / 3 + 70
                Button25.Top = (_vierterTag.getVorstellung(4).getAnfangszeit()) / 3 + 70
                Button26.Top = (_vierterTag.getVorstellung(5).getAnfangszeit()) / 3 + 70
                Button27.Top = (_vierterTag.getVorstellung(6).getAnfangszeit()) / 3 + 70
                Button28.Hide()
            Case 7
                Button22.Top = (_vierterTag.getVorstellung(1).getAnfangszeit()) / 3 + 70
                Button23.Top = (_vierterTag.getVorstellung(2).getAnfangszeit()) / 3 + 70
                Button24.Top = (_vierterTag.getVorstellung(3).getAnfangszeit()) / 3 + 70
                Button25.Top = (_vierterTag.getVorstellung(4).getAnfangszeit()) / 3 + 70
                Button26.Top = (_vierterTag.getVorstellung(5).getAnfangszeit()) / 3 + 70
                Button27.Top = (_vierterTag.getVorstellung(6).getAnfangszeit()) / 3 + 70
                Button28.Top = (_vierterTag.getVorstellung(7).getAnfangszeit()) / 3 + 70
            Case Else
                Throw New Exception("Die Anzahl der gespeicherten Filme für den vierten Tag, entspricht nicht der Anzahl der möglichen darstellbaren Filme (0<x<8")
        End Select
        Select Case _fünfterTag.getAnzahlVorstellungen
            Case 1
                Button29.Top = (_fünfterTag.getVorstellung(1).getAnfangszeit()) / 3 + 70
                Button30.Hide()
                Button31.Hide()
                Button32.Hide()
                Button33.Hide()
                Button34.Hide()
                Button35.Hide()
            Case 2
                Button29.Top = (_fünfterTag.getVorstellung(1).getAnfangszeit()) / 3 + 70
                Button30.Top = (_fünfterTag.getVorstellung(2).getAnfangszeit()) / 3 + 70
                Button31.Hide()
                Button32.Hide()
                Button33.Hide()
                Button34.Hide()
                Button35.Hide()
            Case 3
                Button29.Top = (_fünfterTag.getVorstellung(1).getAnfangszeit()) / 3 + 70
                Button30.Top = (_fünfterTag.getVorstellung(2).getAnfangszeit()) / 3 + 70
                Button31.Top = (_fünfterTag.getVorstellung(3).getAnfangszeit()) / 3 + 70
                Button32.Hide()
                Button33.Hide()
                Button34.Hide()
                Button35.Hide()
            Case 4
                Button29.Top = (_fünfterTag.getVorstellung(1).getAnfangszeit()) / 3 + 70
                Button30.Top = (_fünfterTag.getVorstellung(2).getAnfangszeit()) / 3 + 70
                Button31.Top = (_fünfterTag.getVorstellung(3).getAnfangszeit()) / 3 + 70
                Button32.Top = (_fünfterTag.getVorstellung(4).getAnfangszeit()) / 3 + 70
                Button33.Hide()
                Button34.Hide()
                Button35.Hide()
            Case 5
                Button29.Top = (_fünfterTag.getVorstellung(1).getAnfangszeit()) / 3 + 70
                Button30.Top = (_fünfterTag.getVorstellung(2).getAnfangszeit()) / 3 + 70
                Button31.Top = (_fünfterTag.getVorstellung(3).getAnfangszeit()) / 3 + 70
                Button32.Top = (_fünfterTag.getVorstellung(4).getAnfangszeit()) / 3 + 70
                Button33.Top = (_fünfterTag.getVorstellung(5).getAnfangszeit()) / 3 + 70
                Button34.Hide()
                Button35.Hide()
            Case 6
                Button29.Top = (_fünfterTag.getVorstellung(1).getAnfangszeit()) / 3 + 70
                Button30.Top = (_fünfterTag.getVorstellung(2).getAnfangszeit()) / 3 + 70
                Button31.Top = (_fünfterTag.getVorstellung(3).getAnfangszeit()) / 3 + 70
                Button32.Top = (_fünfterTag.getVorstellung(4).getAnfangszeit()) / 3 + 70
                Button33.Top = (_fünfterTag.getVorstellung(5).getAnfangszeit()) / 3 + 70
                Button34.Top = (_fünfterTag.getVorstellung(6).getAnfangszeit()) / 3 + 70
                Button35.Hide()
            Case 7
                Button29.Top = (_fünfterTag.getVorstellung(1).getAnfangszeit()) / 3 + 70
                Button30.Top = (_fünfterTag.getVorstellung(2).getAnfangszeit()) / 3 + 70
                Button31.Top = (_fünfterTag.getVorstellung(3).getAnfangszeit()) / 3 + 70
                Button32.Top = (_fünfterTag.getVorstellung(4).getAnfangszeit()) / 3 + 70
                Button33.Top = (_fünfterTag.getVorstellung(5).getAnfangszeit()) / 3 + 70
                Button34.Top = (_fünfterTag.getVorstellung(6).getAnfangszeit()) / 3 + 70
                Button35.Top = (_fünfterTag.getVorstellung(7).getAnfangszeit()) / 3 + 70
            Case Else
                Throw New Exception("Die Anzahl der gespeicherten Filme für den fünfter Tag, entspricht nicht der Anzahl der möglichen darstellbaren Filme (0<x<8")

        End Select
        Select Case _sechsterTag.getAnzahlVorstellungen
            Case 1
                Button36.Top = (_sechsterTag.getVorstellung(1).getAnfangszeit()) / 3 + 70
                Button37.Hide()
                Button38.Hide()
                Button39.Hide()
                Button40.Hide()
                Button41.Hide()
                Button42.Hide()
            Case 2
                Button36.Top = (_sechsterTag.getVorstellung(1).getAnfangszeit()) / 3 + 70
                Button37.Top = (_sechsterTag.getVorstellung(2).getAnfangszeit()) / 3 + 70
                Button38.Hide()
                Button39.Hide()
                Button40.Hide()
                Button41.Hide()
                Button42.Hide()
            Case 3
                Button36.Top = (_sechsterTag.getVorstellung(1).getAnfangszeit()) / 3 + 70
                Button37.Top = (_sechsterTag.getVorstellung(2).getAnfangszeit()) / 3 + 70
                Button38.Top = (_sechsterTag.getVorstellung(3).getAnfangszeit()) / 3 + 70
                Button39.Hide()
                Button40.Hide()
                Button41.Hide()
                Button42.Hide()
            Case 4
                Button36.Top = (_sechsterTag.getVorstellung(1).getAnfangszeit()) / 3 + 70
                Button37.Top = (_sechsterTag.getVorstellung(2).getAnfangszeit()) / 3 + 70
                Button38.Top = (_sechsterTag.getVorstellung(3).getAnfangszeit()) / 3 + 70
                Button39.Top = (_sechsterTag.getVorstellung(4).getAnfangszeit()) / 3 + 70
                Button40.Hide()
                Button41.Hide()
                Button42.Hide()
            Case 5
                Button36.Top = (_sechsterTag.getVorstellung(1).getAnfangszeit()) / 3 + 70
                Button37.Top = (_sechsterTag.getVorstellung(2).getAnfangszeit()) / 3 + 70
                Button38.Top = (_sechsterTag.getVorstellung(3).getAnfangszeit()) / 3 + 70
                Button39.Top = (_sechsterTag.getVorstellung(4).getAnfangszeit()) / 3 + 70
                Button40.Top = (_sechsterTag.getVorstellung(5).getAnfangszeit()) / 3 + 70
                Button41.Hide()
                Button42.Hide()
            Case 6
                Button36.Top = (_sechsterTag.getVorstellung(1).getAnfangszeit()) / 3 + 70
                Button37.Top = (_sechsterTag.getVorstellung(2).getAnfangszeit()) / 3 + 70
                Button38.Top = (_sechsterTag.getVorstellung(3).getAnfangszeit()) / 3 + 70
                Button39.Top = (_sechsterTag.getVorstellung(4).getAnfangszeit()) / 3 + 70
                Button40.Top = (_sechsterTag.getVorstellung(5).getAnfangszeit()) / 3 + 70
                Button41.Top = (_sechsterTag.getVorstellung(6).getAnfangszeit()) / 3 + 70
                Button42.Hide()
            Case 7
                Button36.Top = (_sechsterTag.getVorstellung(1).getAnfangszeit()) / 3 + 70
                Button37.Top = (_sechsterTag.getVorstellung(2).getAnfangszeit()) / 3 + 70
                Button38.Top = (_sechsterTag.getVorstellung(3).getAnfangszeit()) / 3 + 70
                Button39.Top = (_sechsterTag.getVorstellung(4).getAnfangszeit()) / 3 + 70
                Button40.Top = (_sechsterTag.getVorstellung(5).getAnfangszeit()) / 3 + 70
                Button41.Top = (_sechsterTag.getVorstellung(6).getAnfangszeit()) / 3 + 70
                Button42.Top = (_sechsterTag.getVorstellung(7).getAnfangszeit()) / 3 + 70
            Case Else
                Throw New Exception("Die Anzahl der gespeicherten Filme für den sechster Tag, entspricht nicht der Anzahl der möglichen darstellbaren Filme (0<x<8")

        End Select
        Select Case _siebterTag.getAnzahlVorstellungen
            Case 1
                Button43.Top = (_siebterTag.getVorstellung(1).getAnfangszeit()) / 3 + 70
                Button44.Hide()
                Button45.Hide()
                Button46.Hide()
                Button47.Hide()
                Button48.Hide()
                Button49.Hide()
            Case 2
                Button43.Top = (_siebterTag.getVorstellung(1).getAnfangszeit()) / 3 + 70
                Button44.Top = (_siebterTag.getVorstellung(2).getAnfangszeit()) / 3 + 70
                Button45.Hide()
                Button46.Hide()
                Button47.Hide()
                Button48.Hide()
                Button49.Hide()
            Case 3
                Button43.Top = (_siebterTag.getVorstellung(1).getAnfangszeit()) / 3 + 70
                Button44.Top = (_siebterTag.getVorstellung(2).getAnfangszeit()) / 3 + 70
                Button45.Top = (_siebterTag.getVorstellung(3).getAnfangszeit()) / 3 + 70
                Button46.Hide()
                Button47.Hide()
                Button48.Hide()
                Button49.Hide()
            Case 4
                Button43.Top = (_siebterTag.getVorstellung(1).getAnfangszeit()) / 3 + 70
                Button44.Top = (_siebterTag.getVorstellung(2).getAnfangszeit()) / 3 + 70
                Button45.Top = (_siebterTag.getVorstellung(3).getAnfangszeit()) / 3 + 70
                Button46.Top = (_siebterTag.getVorstellung(4).getAnfangszeit()) / 3 + 70
                Button47.Hide()
                Button48.Hide()
                Button49.Hide()
            Case 5
                Button43.Top = (_siebterTag.getVorstellung(1).getAnfangszeit()) / 3 + 70
                Button44.Top = (_siebterTag.getVorstellung(2).getAnfangszeit()) / 3 + 70
                Button45.Top = (_siebterTag.getVorstellung(3).getAnfangszeit()) / 3 + 70
                Button46.Top = (_siebterTag.getVorstellung(4).getAnfangszeit()) / 3 + 70
                Button47.Top = (_siebterTag.getVorstellung(5).getAnfangszeit()) / 3 + 70
                Button48.Hide()
                Button49.Hide()
            Case 6
                Button43.Top = (_siebterTag.getVorstellung(1).getAnfangszeit()) / 3 + 70
                Button44.Top = (_siebterTag.getVorstellung(2).getAnfangszeit()) / 3 + 70
                Button45.Top = (_siebterTag.getVorstellung(3).getAnfangszeit()) / 3 + 70
                Button46.Top = (_siebterTag.getVorstellung(4).getAnfangszeit()) / 3 + 70
                Button47.Top = (_siebterTag.getVorstellung(5).getAnfangszeit()) / 3 + 70
                Button48.Top = (_siebterTag.getVorstellung(6).getAnfangszeit()) / 3 + 70
                Button49.Hide()
            Case 7
                Button43.Top = (_siebterTag.getVorstellung(1).getAnfangszeit()) / 3 + 70
                Button44.Top = (_siebterTag.getVorstellung(2).getAnfangszeit()) / 3 + 70
                Button45.Top = (_siebterTag.getVorstellung(3).getAnfangszeit()) / 3 + 70
                Button46.Top = (_siebterTag.getVorstellung(4).getAnfangszeit()) / 3 + 70
                Button47.Top = (_siebterTag.getVorstellung(5).getAnfangszeit()) / 3 + 70
                Button48.Top = (_siebterTag.getVorstellung(6).getAnfangszeit()) / 3 + 70
                Button49.Top = (_siebterTag.getVorstellung(7).getAnfangszeit()) / 3 + 70
            Case Else
                Throw New Exception("Die Anzahl der gespeicherten Filme für den siebter Tag, entspricht nicht der Anzahl der möglichen darstellbaren Filme (0<x<8")

        End Select
    End Sub

    Private Sub PositionDerFilmButtonsFestlegenX()
        Button1.Left = chbMontag.Left
        Button2.Left = chbMontag.Left
        Button3.Left = chbMontag.Left
        Button4.Left = chbMontag.Left
        Button5.Left = chbMontag.Left
        Button6.Left = chbMontag.Left
        Button7.Left = chbMontag.Left

        Button8.Left = chbDienstag.Left
        Button9.Left = chbDienstag.Left
        Button10.Left = chbDienstag.Left
        Button11.Left = chbDienstag.Left
        Button12.Left = chbDienstag.Left
        Button13.Left = chbDienstag.Left
        Button14.Left = chbDienstag.Left

        Button15.Left = chbMittwoch.Left
        Button16.Left = chbMittwoch.Left
        Button17.Left = chbMittwoch.Left
        Button18.Left = chbMittwoch.Left
        Button19.Left = chbMittwoch.Left
        Button20.Left = chbMittwoch.Left
        Button21.Left = chbMittwoch.Left

        Button22.Left = chbDonnerstag.Left
        Button23.Left = chbDonnerstag.Left
        Button24.Left = chbDonnerstag.Left
        Button25.Left = chbDonnerstag.Left
        Button26.Left = chbDonnerstag.Left
        Button27.Left = chbDonnerstag.Left
        Button28.Left = chbDonnerstag.Left

        Button29.Left = chbFreitag.Left
        Button30.Left = chbFreitag.Left
        Button31.Left = chbFreitag.Left
        Button32.Left = chbFreitag.Left
        Button33.Left = chbFreitag.Left
        Button34.Left = chbFreitag.Left
        Button35.Left = chbFreitag.Left

        Button36.Left = chbSamstag.Left
        Button37.Left = chbSamstag.Left
        Button38.Left = chbSamstag.Left
        Button39.Left = chbSamstag.Left
        Button40.Left = chbSamstag.Left
        Button41.Left = chbSamstag.Left
        Button42.Left = chbSamstag.Left

        Button43.Left = chbSonntag.Left
        Button44.Left = chbSonntag.Left
        Button45.Left = chbSonntag.Left
        Button46.Left = chbSonntag.Left
        Button47.Left = chbSonntag.Left
        Button48.Left = chbSonntag.Left
        Button49.Left = chbSonntag.Left
    End Sub

    Private Sub PositionDerDatümerFestlegen()
        Dim A As Integer = chbMontag.Size.Width
        Dim b As Integer = chbDienstag.Size.Width
        Dim c As Integer = chbMittwoch.Size.Width
        Dim d As Integer = chbDonnerstag.Size.Width
        Dim e As Integer = chbFreitag.Size.Width
        Dim f As Integer = chbSamstag.Size.Width
        Dim g As Integer = chbSonntag.Size.Width
        'x-Koordinate festlegen
        chbDienstag.Left = 45 + 150 + A
        chbMittwoch.Left = 150 + A + (45 * 2) + b
        chbDonnerstag.Left = 150 + A + (45 * 3) + b + c
        chbFreitag.Left = 150 + A + (45 * 4) + b + c + d
        chbSamstag.Left = 150 + A + (45 * 5) + b + c + d + e
        chbSonntag.Left = 150 + A + (45 * 6) + b + c + d + e + f
        Me.Size = New Size(150 + A + (45 * 7) + b + c + d + e + f + g, Me.Size.Height)
    End Sub

    Private Sub AnfangstagUndDatümerFestlegen()
        Dim thisDate As Date = Today
        Dim Wochentag As Integer '1 = Sonntag, 2 = Montag, ...
        Wochentag = Weekday(thisDate)

        'Die nächsten 6 Tage
        Dim ZweiterTag As Date = DateAdd(DateInterval.Day, 1.0, thisDate)
        Dim DritterTag As Date = DateAdd(DateInterval.Day, 2, thisDate)
        Dim VierterTag As Date = DateAdd(DateInterval.Day, 3, thisDate)
        Dim FünfterTag As Date = DateAdd(DateInterval.Day, 4, thisDate)
        Dim SechsterTag As Date = DateAdd(DateInterval.Day, 5, thisDate)
        Dim SiebterTag As Date = DateAdd(DateInterval.Day, 6, thisDate)
        'Die Woche beginnt mit dem heutigen Tagen
        Select Case Wochentag
            Case 2 'Montag ist der erste Tag
                chbMontag.Text = chbMontag.Text & thisDate.ToString(" dd.MM.")
                chbDienstag.Text = chbDienstag.Text & ZweiterTag.ToString(" dd.MM.")
                chbMittwoch.Text = chbMittwoch.Text & DritterTag.ToString(" dd.MM.")
                chbDonnerstag.Text = chbDonnerstag.Text & VierterTag.ToString(" dd.MM.")
                chbFreitag.Text = chbFreitag.Text & FünfterTag.ToString(" dd.MM.")
                chbSamstag.Text = chbSamstag.Text & SechsterTag.ToString(" dd.MM.")
                chbSonntag.Text = chbSonntag.Text & SiebterTag.ToString(" dd.MM.")
            Case 3
                chbMontag.Text = "Dienstag" & thisDate.ToString(" dd.MM.")
                chbDienstag.Text = "Mittwoch" & ZweiterTag.ToString(" dd.MM.")
                chbMittwoch.Text = "Donnerstag" & DritterTag.ToString(" dd.MM.")
                chbDonnerstag.Text = "Freitag" & VierterTag.ToString(" dd.MM.")
                chbFreitag.Text = "Samstag" & FünfterTag.ToString(" dd.MM.")
                chbSamstag.Text = "Sonntag" & SechsterTag.ToString(" dd.MM.")
                chbSonntag.Text = "Montag" & SiebterTag.ToString(" dd.MM.")
            Case 4
                chbMontag.Text = "Mittwoch" & thisDate.ToString(" dd.MM.")
                chbDienstag.Text = "Donnerstag" & ZweiterTag.ToString(" dd.MM.")
                chbMittwoch.Text = "Freitag" & DritterTag.ToString(" dd.MM.")
                chbDonnerstag.Text = "Samstag" & VierterTag.ToString(" dd.MM.")
                chbFreitag.Text = "Sonntag" & FünfterTag.ToString(" dd.MM.")
                chbSamstag.Text = "Montag" & SechsterTag.ToString(" dd.MM.")
                chbSonntag.Text = "Dienstag" & SiebterTag.ToString(" dd.MM.")
            Case 5
                chbMontag.Text = "Donnerstag" & thisDate.ToString(" dd.MM.")
                chbDienstag.Text = "Freitag" & ZweiterTag.ToString(" dd.MM.")
                chbMittwoch.Text = "Samstag" & DritterTag.ToString(" dd.MM.")
                chbDonnerstag.Text = "Sonntag" & VierterTag.ToString(" dd.MM.")
                chbFreitag.Text = "Montag" & FünfterTag.ToString(" dd.MM.")
                chbSamstag.Text = "Dienstag" & SechsterTag.ToString(" dd.MM.")
                chbSonntag.Text = "Mittwoch" & SiebterTag.ToString(" dd.MM.")
            Case 6
                chbMontag.Text = "Freitag" & thisDate.ToString(" dd.MM.")
                chbDienstag.Text = "Samstag" & ZweiterTag.ToString(" dd.MM.")
                chbMittwoch.Text = "Sonntag" & DritterTag.ToString(" dd.MM.")
                chbDonnerstag.Text = "Montag" & VierterTag.ToString(" dd.MM.")
                chbFreitag.Text = "Dienstag" & FünfterTag.ToString(" dd.MM.")
                chbSamstag.Text = "Mittwoch" & SechsterTag.ToString(" dd.MM.")
                chbSonntag.Text = "Donnerstag" & SiebterTag.ToString(" dd.MM.")
            Case 7
                chbMontag.Text = "Samstag" & thisDate.ToString(" dd.MM.")
                chbDienstag.Text = "Sonntag" & ZweiterTag.ToString(" dd.MM.")
                chbMittwoch.Text = "Montag" & DritterTag.ToString(" dd.MM.")
                chbDonnerstag.Text = "Dienstag" & VierterTag.ToString(" dd.MM.")
                chbFreitag.Text = "Mittwoch" & FünfterTag.ToString(" dd.MM.")
                chbSamstag.Text = "Donnerstag" & SechsterTag.ToString(" dd.MM.")
                chbSonntag.Text = "Freitag" & SiebterTag.ToString(" dd.MM.")
            Case 1
                chbMontag.Text = "Sonntag" & thisDate.ToString(" dd.MM.")
                chbDienstag.Text = "Montag" & ZweiterTag.ToString(" dd.MM.")
                chbMittwoch.Text = "Dienstag" & DritterTag.ToString(" dd.MM.")
                chbDonnerstag.Text = "Mittwoch" & VierterTag.ToString(" dd.MM.")
                chbFreitag.Text = "Donnerstag" & FünfterTag.ToString(" dd.MM.")
                chbSamstag.Text = "Freitag" & SechsterTag.ToString(" dd.MM.")
                chbSonntag.Text = "Samstag" & SiebterTag.ToString(" dd.MM.")
        End Select
    End Sub

    Private Sub GrößeDerFilmButtonsFestlegen()
        'Größe der Spaltenüberschriften
        Dim A As Size = chbMontag.Size
        Dim b As Size = chbDienstag.Size
        Dim c As Size = chbMittwoch.Size
        Dim d As Size = chbDonnerstag.Size
        Dim es As Size = chbFreitag.Size
        Dim f As Size = chbSamstag.Size
        Dim g As Size = chbSonntag.Size

        'Größe der Filme bestimmen
        'Hier muss noch ausgelesen werden, wie lange ein Film geht und dementsprechend die Größe,
        'die standartmäßig auf 26 ist, verändert werden. 
        Select Case _ersterTag.getAnzahlVorstellungen
            Case 1
                Button1.Size = New Size(A.Width, (_ersterTag.getVorstellung(1).getLänge() / 3))
            Case 2
                Button1.Size = New Size(A.Width, (_ersterTag.getVorstellung(1).getLänge() / 3))
                Button2.Size = New Size(A.Width, (_ersterTag.getVorstellung(2).getLänge() / 3))
            Case 3
                Button1.Size = New Size(A.Width, (_ersterTag.getVorstellung(1).getLänge() / 3))
                Button2.Size = New Size(A.Width, (_ersterTag.getVorstellung(2).getLänge() / 3))
                Button3.Size = New Size(A.Width, (_ersterTag.getVorstellung(3).getLänge() / 3))
            Case 4
                Button1.Size = New Size(A.Width, (_ersterTag.getVorstellung(1).getLänge() / 3))
                Button2.Size = New Size(A.Width, (_ersterTag.getVorstellung(2).getLänge() / 3))
                Button3.Size = New Size(A.Width, (_ersterTag.getVorstellung(3).getLänge() / 3))
                Button4.Size = New Size(A.Width, (_ersterTag.getVorstellung(4).getLänge() / 3))
            Case 5
                Button1.Size = New Size(A.Width, (_ersterTag.getVorstellung(1).getLänge() / 3))
                Button2.Size = New Size(A.Width, (_ersterTag.getVorstellung(2).getLänge() / 3))
                Button3.Size = New Size(A.Width, (_ersterTag.getVorstellung(3).getLänge() / 3))
                Button4.Size = New Size(A.Width, (_ersterTag.getVorstellung(4).getLänge() / 3))
                Button5.Size = New Size(A.Width, (_ersterTag.getVorstellung(5).getLänge() / 3))
            Case 6
                Button1.Size = New Size(A.Width, (_ersterTag.getVorstellung(1).getLänge() / 3))
                Button2.Size = New Size(A.Width, (_ersterTag.getVorstellung(2).getLänge() / 3))
                Button3.Size = New Size(A.Width, (_ersterTag.getVorstellung(3).getLänge() / 3))
                Button4.Size = New Size(A.Width, (_ersterTag.getVorstellung(4).getLänge() / 3))
                Button5.Size = New Size(A.Width, (_ersterTag.getVorstellung(5).getLänge() / 3))
                Button6.Size = New Size(A.Width, (_ersterTag.getVorstellung(6).getLänge() / 3))
            Case 7
                Button1.Size = New Size(A.Width, (_ersterTag.getVorstellung(1).getLänge() / 3))
                Button2.Size = New Size(A.Width, (_ersterTag.getVorstellung(2).getLänge() / 3))
                Button3.Size = New Size(A.Width, (_ersterTag.getVorstellung(3).getLänge() / 3))
                Button4.Size = New Size(A.Width, (_ersterTag.getVorstellung(4).getLänge() / 3))
                Button5.Size = New Size(A.Width, (_ersterTag.getVorstellung(5).getLänge() / 3))
                Button6.Size = New Size(A.Width, (_ersterTag.getVorstellung(6).getLänge() / 3))
                Button7.Size = New Size(A.Width, (_ersterTag.getVorstellung(7).getLänge() / 3))
            Case Else
                '   Throw New Exception("Die Anzahl der gespeicherten Filme für den ersten Tag, entspricht nicht der Anzahl der möglichen darstellbaren Filme (0<x<8")
        End Select
        Select Case _zweiterTag.getAnzahlVorstellungen
            Case 1
                Button8.Size = New Size(b.Width, (_zweiterTag.getVorstellung(1).getLänge() / 3))
            Case 2
                Button8.Size = New Size(b.Width, (_zweiterTag.getVorstellung(1).getLänge() / 3))
                Button9.Size = New Size(b.Width, (_zweiterTag.getVorstellung(2).getLänge() / 3))
            Case 3
                Button8.Size = New Size(b.Width, (_zweiterTag.getVorstellung(1).getLänge() / 3))
                Button9.Size = New Size(b.Width, (_zweiterTag.getVorstellung(2).getLänge() / 3))
                Button10.Size = New Size(b.Width, (_zweiterTag.getVorstellung(3).getLänge() / 3))
            Case 4
                Button8.Size = New Size(b.Width, (_zweiterTag.getVorstellung(1).getLänge() / 3))
                Button9.Size = New Size(b.Width, (_zweiterTag.getVorstellung(2).getLänge() / 3))
                Button10.Size = New Size(b.Width, (_zweiterTag.getVorstellung(3).getLänge() / 3))
                Button11.Size = New Size(b.Width, (_zweiterTag.getVorstellung(4).getLänge() / 3))
            Case 5
                Button8.Size = New Size(b.Width, (_zweiterTag.getVorstellung(1).getLänge() / 3))
                Button9.Size = New Size(b.Width, (_zweiterTag.getVorstellung(2).getLänge() / 3))
                Button10.Size = New Size(b.Width, (_zweiterTag.getVorstellung(3).getLänge() / 3))
                Button11.Size = New Size(b.Width, (_zweiterTag.getVorstellung(4).getLänge() / 3))
                Button12.Size = New Size(b.Width, (_zweiterTag.getVorstellung(5).getLänge() / 3))
            Case 6
                Button8.Size = New Size(b.Width, (_zweiterTag.getVorstellung(1).getLänge() / 3))
                Button9.Size = New Size(b.Width, (_zweiterTag.getVorstellung(2).getLänge() / 3))
                Button10.Size = New Size(b.Width, (_zweiterTag.getVorstellung(3).getLänge() / 3))
                Button11.Size = New Size(b.Width, (_zweiterTag.getVorstellung(4).getLänge() / 3))
                Button12.Size = New Size(b.Width, (_zweiterTag.getVorstellung(5).getLänge() / 3))
                Button13.Size = New Size(b.Width, (_zweiterTag.getVorstellung(6).getLänge() / 3))
            Case 7
                Button8.Size = New Size(b.Width, (_zweiterTag.getVorstellung(1).getLänge() / 3))
                Button9.Size = New Size(b.Width, (_zweiterTag.getVorstellung(2).getLänge() / 3))
                Button10.Size = New Size(b.Width, (_zweiterTag.getVorstellung(3).getLänge() / 3))
                Button11.Size = New Size(b.Width, (_zweiterTag.getVorstellung(4).getLänge() / 3))
                Button12.Size = New Size(b.Width, (_zweiterTag.getVorstellung(5).getLänge() / 3))
                Button13.Size = New Size(b.Width, (_zweiterTag.getVorstellung(6).getLänge() / 3))
                Button14.Size = New Size(b.Width, (_zweiterTag.getVorstellung(7).getLänge() / 3))
        End Select
        Select Case _dritterTag.getAnzahlVorstellungen
            Case 1
                Button15.Size = New Size(c.Width, (_dritterTag.getVorstellung(1).getLänge() / 3))
            Case 2
                Button15.Size = New Size(c.Width, (_dritterTag.getVorstellung(1).getLänge() / 3))
                Button16.Size = New Size(c.Width, (_dritterTag.getVorstellung(2).getLänge() / 3))
            Case 3
                Button15.Size = New Size(c.Width, (_dritterTag.getVorstellung(1).getLänge() / 3))
                Button16.Size = New Size(c.Width, (_dritterTag.getVorstellung(2).getLänge() / 3))
                Button17.Size = New Size(c.Width, (_dritterTag.getVorstellung(3).getLänge() / 3))
            Case 4
                Button15.Size = New Size(c.Width, (_dritterTag.getVorstellung(1).getLänge() / 3))
                Button16.Size = New Size(c.Width, (_dritterTag.getVorstellung(2).getLänge() / 3))
                Button17.Size = New Size(c.Width, (_dritterTag.getVorstellung(3).getLänge() / 3))
                Button18.Size = New Size(c.Width, (_dritterTag.getVorstellung(4).getLänge() / 3))
            Case 5
                Button15.Size = New Size(c.Width, (_dritterTag.getVorstellung(1).getLänge() / 3))
                Button16.Size = New Size(c.Width, (_dritterTag.getVorstellung(2).getLänge() / 3))
                Button17.Size = New Size(c.Width, (_dritterTag.getVorstellung(3).getLänge() / 3))
                Button18.Size = New Size(c.Width, (_dritterTag.getVorstellung(4).getLänge() / 3))
                Button19.Size = New Size(c.Width, (_dritterTag.getVorstellung(5).getLänge() / 3))
            Case 6
                Button15.Size = New Size(c.Width, (_dritterTag.getVorstellung(1).getLänge() / 3))
                Button16.Size = New Size(c.Width, (_dritterTag.getVorstellung(2).getLänge() / 3))
                Button17.Size = New Size(c.Width, (_dritterTag.getVorstellung(3).getLänge() / 3))
                Button18.Size = New Size(c.Width, (_dritterTag.getVorstellung(4).getLänge() / 3))
                Button19.Size = New Size(c.Width, (_dritterTag.getVorstellung(5).getLänge() / 3))
                Button20.Size = New Size(c.Width, (_dritterTag.getVorstellung(6).getLänge() / 3))
            Case 7
                Button15.Size = New Size(c.Width, (_dritterTag.getVorstellung(1).getLänge() / 3))
                Button16.Size = New Size(c.Width, (_dritterTag.getVorstellung(2).getLänge() / 3))
                Button17.Size = New Size(c.Width, (_dritterTag.getVorstellung(3).getLänge() / 3))
                Button18.Size = New Size(c.Width, (_dritterTag.getVorstellung(4).getLänge() / 3))
                Button19.Size = New Size(c.Width, (_dritterTag.getVorstellung(5).getLänge() / 3))
                Button20.Size = New Size(c.Width, (_dritterTag.getVorstellung(6).getLänge() / 3))
                Button21.Size = New Size(c.Width, (_dritterTag.getVorstellung(7).getLänge() / 3))
        End Select
        Select Case _vierterTag.getAnzahlVorstellungen
            Case 1
                Button22.Size = New Size(d.Width, (_vierterTag.getVorstellung(1).getLänge() / 3))
            Case 2
                Button22.Size = New Size(d.Width, (_vierterTag.getVorstellung(1).getLänge() / 3))
                Button23.Size = New Size(d.Width, (_vierterTag.getVorstellung(2).getLänge() / 3))
            Case 3
                Button22.Size = New Size(d.Width, (_vierterTag.getVorstellung(1).getLänge() / 3))
                Button23.Size = New Size(d.Width, (_vierterTag.getVorstellung(2).getLänge() / 3))
                Button24.Size = New Size(d.Width, (_vierterTag.getVorstellung(3).getLänge() / 3))
            Case 4
                Button22.Size = New Size(d.Width, (_vierterTag.getVorstellung(1).getLänge() / 3))
                Button23.Size = New Size(d.Width, (_vierterTag.getVorstellung(2).getLänge() / 3))
                Button24.Size = New Size(d.Width, (_vierterTag.getVorstellung(3).getLänge() / 3))
                Button25.Size = New Size(d.Width, (_vierterTag.getVorstellung(4).getLänge() / 3))
            Case 5
                Button22.Size = New Size(d.Width, (_vierterTag.getVorstellung(1).getLänge() / 3))
                Button23.Size = New Size(d.Width, (_vierterTag.getVorstellung(2).getLänge() / 3))
                Button24.Size = New Size(d.Width, (_vierterTag.getVorstellung(3).getLänge() / 3))
                Button25.Size = New Size(d.Width, (_vierterTag.getVorstellung(4).getLänge() / 3))
                Button26.Size = New Size(d.Width, (_vierterTag.getVorstellung(5).getLänge() / 3))
            Case 6
                Button22.Size = New Size(d.Width, (_vierterTag.getVorstellung(1).getLänge() / 3))
                Button23.Size = New Size(d.Width, (_vierterTag.getVorstellung(2).getLänge() / 3))
                Button24.Size = New Size(d.Width, (_vierterTag.getVorstellung(3).getLänge() / 3))
                Button25.Size = New Size(d.Width, (_vierterTag.getVorstellung(4).getLänge() / 3))
                Button26.Size = New Size(d.Width, (_vierterTag.getVorstellung(5).getLänge() / 3))
                Button27.Size = New Size(d.Width, (_vierterTag.getVorstellung(6).getLänge() / 3))
            Case 7
                Button22.Size = New Size(d.Width, (_vierterTag.getVorstellung(1).getLänge() / 3))
                Button23.Size = New Size(d.Width, (_vierterTag.getVorstellung(2).getLänge() / 3))
                Button24.Size = New Size(d.Width, (_vierterTag.getVorstellung(3).getLänge() / 3))
                Button25.Size = New Size(d.Width, (_vierterTag.getVorstellung(4).getLänge() / 3))
                Button26.Size = New Size(d.Width, (_vierterTag.getVorstellung(5).getLänge() / 3))
                Button27.Size = New Size(d.Width, (_vierterTag.getVorstellung(6).getLänge() / 3))
                Button28.Size = New Size(d.Width, (_vierterTag.getVorstellung(7).getLänge() / 3))
        End Select
        Select Case _fünfterTag.getAnzahlVorstellungen
            Case 1
                Button29.Size = New Size(es.Width, (_fünfterTag.getVorstellung(1).getLänge() / 3))
            Case 2
                Button29.Size = New Size(es.Width, (_fünfterTag.getVorstellung(1).getLänge() / 3))
                Button30.Size = New Size(es.Width, (_fünfterTag.getVorstellung(2).getLänge() / 3))
            Case 3
                Button29.Size = New Size(es.Width, (_fünfterTag.getVorstellung(1).getLänge() / 3))
                Button30.Size = New Size(es.Width, (_fünfterTag.getVorstellung(2).getLänge() / 3))
                Button31.Size = New Size(es.Width, (_fünfterTag.getVorstellung(3).getLänge() / 3))
            Case 4
                Button29.Size = New Size(es.Width, (_fünfterTag.getVorstellung(1).getLänge() / 3))
                Button30.Size = New Size(es.Width, (_fünfterTag.getVorstellung(2).getLänge() / 3))
                Button31.Size = New Size(es.Width, (_fünfterTag.getVorstellung(3).getLänge() / 3))
                Button32.Size = New Size(es.Width, (_fünfterTag.getVorstellung(4).getLänge() / 3))
            Case 5
                Button29.Size = New Size(es.Width, (_fünfterTag.getVorstellung(1).getLänge() / 3))
                Button30.Size = New Size(es.Width, (_fünfterTag.getVorstellung(2).getLänge() / 3))
                Button31.Size = New Size(es.Width, (_fünfterTag.getVorstellung(3).getLänge() / 3))
                Button32.Size = New Size(es.Width, (_fünfterTag.getVorstellung(4).getLänge() / 3))
                Button33.Size = New Size(es.Width, (_fünfterTag.getVorstellung(5).getLänge() / 3))
            Case 6
                Button29.Size = New Size(es.Width, (_fünfterTag.getVorstellung(1).getLänge() / 3))
                Button30.Size = New Size(es.Width, (_fünfterTag.getVorstellung(2).getLänge() / 3))
                Button31.Size = New Size(es.Width, (_fünfterTag.getVorstellung(3).getLänge() / 3))
                Button32.Size = New Size(es.Width, (_fünfterTag.getVorstellung(4).getLänge() / 3))
                Button33.Size = New Size(es.Width, (_fünfterTag.getVorstellung(5).getLänge() / 3))
                Button34.Size = New Size(es.Width, (_fünfterTag.getVorstellung(6).getLänge() / 3))
            Case 7
                Button29.Size = New Size(es.Width, (_fünfterTag.getVorstellung(1).getLänge() / 3))
                Button30.Size = New Size(es.Width, (_fünfterTag.getVorstellung(2).getLänge() / 3))
                Button31.Size = New Size(es.Width, (_fünfterTag.getVorstellung(3).getLänge() / 3))
                Button32.Size = New Size(es.Width, (_fünfterTag.getVorstellung(4).getLänge() / 3))
                Button33.Size = New Size(es.Width, (_fünfterTag.getVorstellung(5).getLänge() / 3))
                Button34.Size = New Size(es.Width, (_fünfterTag.getVorstellung(6).getLänge() / 3))
                Button35.Size = New Size(es.Width, (_fünfterTag.getVorstellung(7).getLänge() / 3))
        End Select
        Select Case _sechsterTag.getAnzahlVorstellungen
            Case 1
                Button36.Size = New Size(f.Width, (_sechsterTag.getVorstellung(1).getLänge() / 3))
            Case 2
                Button36.Size = New Size(f.Width, (_sechsterTag.getVorstellung(1).getLänge() / 3))
                Button37.Size = New Size(f.Width, (_sechsterTag.getVorstellung(2).getLänge() / 3))
            Case 3
                Button36.Size = New Size(f.Width, (_sechsterTag.getVorstellung(1).getLänge() / 3))
                Button37.Size = New Size(f.Width, (_sechsterTag.getVorstellung(2).getLänge() / 3))
                Button38.Size = New Size(f.Width, (_sechsterTag.getVorstellung(3).getLänge() / 3))
            Case 4
                Button36.Size = New Size(f.Width, (_sechsterTag.getVorstellung(1).getLänge() / 3))
                Button37.Size = New Size(f.Width, (_sechsterTag.getVorstellung(2).getLänge() / 3))
                Button38.Size = New Size(f.Width, (_sechsterTag.getVorstellung(3).getLänge() / 3))
                Button39.Size = New Size(f.Width, (_sechsterTag.getVorstellung(4).getLänge() / 3))
            Case 5
                Button36.Size = New Size(f.Width, (_sechsterTag.getVorstellung(1).getLänge() / 3))
                Button37.Size = New Size(f.Width, (_sechsterTag.getVorstellung(2).getLänge() / 3))
                Button38.Size = New Size(f.Width, (_sechsterTag.getVorstellung(3).getLänge() / 3))
                Button39.Size = New Size(f.Width, (_sechsterTag.getVorstellung(4).getLänge() / 3))
                Button40.Size = New Size(f.Width, (_sechsterTag.getVorstellung(5).getLänge() / 3))
            Case 6
                Button36.Size = New Size(f.Width, (_sechsterTag.getVorstellung(1).getLänge() / 3))
                Button37.Size = New Size(f.Width, (_sechsterTag.getVorstellung(2).getLänge() / 3))
                Button38.Size = New Size(f.Width, (_sechsterTag.getVorstellung(3).getLänge() / 3))
                Button39.Size = New Size(f.Width, (_sechsterTag.getVorstellung(4).getLänge() / 3))
                Button40.Size = New Size(f.Width, (_sechsterTag.getVorstellung(5).getLänge() / 3))
                Button41.Size = New Size(f.Width, (_sechsterTag.getVorstellung(6).getLänge() / 3))
            Case 7
                Button36.Size = New Size(f.Width, (_sechsterTag.getVorstellung(1).getLänge() / 3))
                Button37.Size = New Size(f.Width, (_sechsterTag.getVorstellung(2).getLänge() / 3))
                Button38.Size = New Size(f.Width, (_sechsterTag.getVorstellung(3).getLänge() / 3))
                Button39.Size = New Size(f.Width, (_sechsterTag.getVorstellung(4).getLänge() / 3))
                Button40.Size = New Size(f.Width, (_sechsterTag.getVorstellung(5).getLänge() / 3))
                Button41.Size = New Size(f.Width, (_sechsterTag.getVorstellung(6).getLänge() / 3))
                Button42.Size = New Size(f.Width, (_sechsterTag.getVorstellung(7).getLänge() / 3))
        End Select
        Select Case _siebterTag.getAnzahlVorstellungen
            Case 1
                Button43.Size = New Size(g.Width, (_siebterTag.getVorstellung(1).getLänge() / 3))
            Case 2
                Button43.Size = New Size(g.Width, (_siebterTag.getVorstellung(1).getLänge() / 3))
                Button44.Size = New Size(g.Width, (_siebterTag.getVorstellung(2).getLänge() / 3))
            Case 3
                Button43.Size = New Size(g.Width, (_siebterTag.getVorstellung(1).getLänge() / 3))
                Button44.Size = New Size(g.Width, (_siebterTag.getVorstellung(2).getLänge() / 3))
                Button45.Size = New Size(g.Width, (_siebterTag.getVorstellung(3).getLänge() / 3))
            Case 4
                Button43.Size = New Size(g.Width, (_siebterTag.getVorstellung(1).getLänge() / 3))
                Button44.Size = New Size(g.Width, (_siebterTag.getVorstellung(2).getLänge() / 3))
                Button45.Size = New Size(g.Width, (_siebterTag.getVorstellung(3).getLänge() / 3))
                Button46.Size = New Size(g.Width, (_siebterTag.getVorstellung(4).getLänge() / 3))
            Case 5
                Button43.Size = New Size(g.Width, (_siebterTag.getVorstellung(1).getLänge() / 3))
                Button44.Size = New Size(g.Width, (_siebterTag.getVorstellung(2).getLänge() / 3))
                Button45.Size = New Size(g.Width, (_siebterTag.getVorstellung(3).getLänge() / 3))
                Button46.Size = New Size(g.Width, (_siebterTag.getVorstellung(4).getLänge() / 3))
                Button47.Size = New Size(g.Width, (_siebterTag.getVorstellung(5).getLänge() / 3))
            Case 6
                Button43.Size = New Size(g.Width, (_siebterTag.getVorstellung(1).getLänge() / 3))
                Button44.Size = New Size(g.Width, (_siebterTag.getVorstellung(2).getLänge() / 3))
                Button45.Size = New Size(g.Width, (_siebterTag.getVorstellung(3).getLänge() / 3))
                Button46.Size = New Size(g.Width, (_siebterTag.getVorstellung(4).getLänge() / 3))
                Button47.Size = New Size(g.Width, (_siebterTag.getVorstellung(5).getLänge() / 3))
                Button48.Size = New Size(g.Width, (_siebterTag.getVorstellung(6).getLänge() / 3))
            Case 7
                Button43.Size = New Size(g.Width, (_siebterTag.getVorstellung(1).getLänge() / 3))
                Button44.Size = New Size(g.Width, (_siebterTag.getVorstellung(2).getLänge() / 3))
                Button45.Size = New Size(g.Width, (_siebterTag.getVorstellung(3).getLänge() / 3))
                Button46.Size = New Size(g.Width, (_siebterTag.getVorstellung(4).getLänge() / 3))
                Button47.Size = New Size(g.Width, (_siebterTag.getVorstellung(5).getLänge() / 3))
                Button48.Size = New Size(g.Width, (_siebterTag.getVorstellung(6).getLänge() / 3))
                Button49.Size = New Size(g.Width, (_siebterTag.getVorstellung(7).getLänge() / 3))
        End Select

    End Sub

    Private Sub ButtonsInvisibleMachen()
        cmdTagesPlanErstellen.Hide()
        cmdFilmÄndern.Hide()
        'Man könnte hier noch die Position individuell anpassen
    End Sub

    Private Sub cmdFilmÄndern_Click(sender As Object, e As EventArgs) Handles cmdFilmÄndern.Click
        _Aendern = Not _Aendern
        If _Aendern Then
            cmdFilmÄndern.FlatStyle = FlatStyle.Flat
            cmdFilmÄndern.FlatAppearance.BorderColor = Color.Black
            'cmdFilmÄndern.BackColor = New Color.
            'a.FlatAppearance.MouseDownBackColor = Color.Red 'BorderSize = 3

        Else
            cmdFilmÄndern.FlatStyle = FlatStyle.Popup
            ' cmdFilmÄndern.BackColor = Color.Lime
            cmdFilmÄndern.FlatAppearance.BorderSize = 1


        End If


        '    _Montag.FilmÄndern(New Vorstellung(), txtFilmnummer.Text)
        '  Debug.WriteLine("FilmHinzufügen funktioniert nicht") 'lol funktioniert nicht
        '  Select Case True
        '      Case chbMontag.Checked
        ''          _ersterTag.FilmÄndern(New Vorstellung(), txtFilmnummer.Text)
        '      Case chbDienstag.Checked
        '      Case chbMittwoch.Checked
        '      Case chbDonnerstag.Checked
        '      Case chbFreitag.Checked
        '  End Select
    End Sub

    Public Sub filmändern(Tag As Integer, Stelle As Integer, z As Vorstellung)
        'wird aufgerufen, wenn einer der Buttons geklickt wird
        Select Case Tag
            Case 1
                Me._ersterTag.VorstellungÄndern(z, Stelle)
            Case 2
                _zweiterTag.VorstellungÄndern(z, Stelle)
            Case 3
                _dritterTag.VorstellungÄndern(z, Stelle)
            Case 4
                _vierterTag.VorstellungÄndern(z, Stelle)
            Case 5
                _fünfterTag.VorstellungÄndern(z, Stelle)
            Case 6
                _sechsterTag.VorstellungÄndern(z, Stelle)
            Case 7
                _siebterTag.VorstellungÄndern(z, Stelle)
        End Select
        'Buttons neu laden & ändern funktioniert nur, wenn ein bestehender Film geändert wird
        GrößeDerFilmButtonsFestlegen()
        PositionDerFilmButtonsFestlegenY()
    End Sub
    Private Sub chbMontag_CheckedChanged(sender As Object, e As EventArgs) Handles chbMontag.CheckedChanged
        If chbMontag.Checked Then
            chbDienstag.Checked = False
            chbMittwoch.Checked = False
            chbDonnerstag.Checked = False
            chbFreitag.Checked = False
            chbSamstag.Checked = False
            chbSonntag.Checked = False
            cmdTagesPlanErstellen.Show()
            cmdTagesPlanErstellen.Left = chbMontag.Left

        End If
    End Sub
    Private Sub chbDienstag_CheckedChanged(sender As Object, e As EventArgs) Handles chbDienstag.CheckedChanged
        If chbDienstag.Checked Then
            chbMontag.Checked = False
            chbMittwoch.Checked = False
            chbDonnerstag.Checked = False
            chbFreitag.Checked = False
            chbSamstag.Checked = False
            chbSonntag.Checked = False
            cmdTagesPlanErstellen.Show()
            cmdTagesPlanErstellen.Left = chbDienstag.Left
        End If
    End Sub
    Private Sub chbMittwoch_CheckedChanged(sender As Object, e As EventArgs) Handles chbMittwoch.CheckedChanged
        If chbMittwoch.Checked Then
            chbDienstag.Checked = False
            chbMontag.Checked = False
            chbDonnerstag.Checked = False
            chbFreitag.Checked = False
            chbSamstag.Checked = False
            chbSonntag.Checked = False
            cmdTagesPlanErstellen.Show()
            cmdTagesPlanErstellen.Left = chbMittwoch.Left
        End If
    End Sub
    Private Sub chbDonnerstag_CheckedChanged(sender As Object, e As EventArgs) Handles chbDonnerstag.CheckedChanged
        If chbDonnerstag.Checked Then
            chbDienstag.Checked = False
            chbMittwoch.Checked = False
            chbMontag.Checked = False
            chbFreitag.Checked = False
            chbSamstag.Checked = False
            chbSonntag.Checked = False
            cmdTagesPlanErstellen.Show()
            cmdTagesPlanErstellen.Left = chbDonnerstag.Left
        End If
    End Sub
    Private Sub chbFreitag_CheckedChanged(sender As Object, e As EventArgs) Handles chbFreitag.CheckedChanged
        If chbFreitag.Checked Then
            chbDienstag.Checked = False
            chbMittwoch.Checked = False
            chbDonnerstag.Checked = False
            chbMontag.Checked = False
            chbSamstag.Checked = False
            chbSonntag.Checked = False
            cmdTagesPlanErstellen.Show()
            cmdTagesPlanErstellen.Left = chbFreitag.Left
            '     MonthCalendar1.Left = chbMontag.Left
        End If
    End Sub
    Private Sub chbSamstag_CheckedChanged(sender As Object, e As EventArgs) Handles chbSamstag.CheckedChanged
        If chbSamstag.Checked Then
            chbDienstag.Checked = False
            chbMittwoch.Checked = False
            chbDonnerstag.Checked = False
            chbFreitag.Checked = False
            chbMontag.Checked = False
            chbSonntag.Checked = False
            cmdTagesPlanErstellen.Show()
            cmdTagesPlanErstellen.Left = chbSamstag.Left
            '      MonthCalendar1.Left = chbMontag.Left
        End If
    End Sub
    Private Sub chbSonntag_CheckedChanged(sender As Object, e As EventArgs) Handles chbSonntag.CheckedChanged
        If chbSonntag.Checked Then
            chbDienstag.Checked = False
            chbMittwoch.Checked = False
            chbDonnerstag.Checked = False
            chbFreitag.Checked = False
            chbSamstag.Checked = False
            chbMontag.Checked = False
            cmdTagesPlanErstellen.Show()
            cmdTagesPlanErstellen.Left = Size.Width - (cmdTagesPlanErstellen.Width + 45)
            '     MonthCalendar1.Left = chbMontag.Left
        End If
    End Sub
    Private Sub Geklickt(a As Integer, b As Integer)
        Dim c As Vorstellung 'Man kann den Kinosaal aus den Vorstellung am Tag nehmen, oder dadurch, dass er im Wochenplan eh schon gespeichert ist, diesen nehmen (weniger Fehleranfällig)

        If _Aendern Then
            'ohne Infos vom Film
            NeueVorstellung.BringToFront()
            NeueVorstellung.Show()
            NeueVorstellung.PositionÜbergeben(a, b)
            'Die andere Form ruft die Methode Filmändern auf, die den Film ändert
        Else
            Select Case a
                Case 1
                    c = _ersterTag.getVorstellung(b)
                    KinosaalGUI.Aufrufen(New Kinosaal(c), _Kunde)
                    KinosaalGUI.BringToFront()
                    KinosaalGUI.Show()
                Case 2
                    c = _zweiterTag.getVorstellung(b)
                    KinosaalGUI.Aufrufen(New Kinosaal(c), _Kunde)
                    KinosaalGUI.BringToFront()
                    KinosaalGUI.Show()
                Case 3
                    c = _dritterTag.getVorstellung(b)
                    KinosaalGUI.Aufrufen(New Kinosaal(c), _Kunde)
                    KinosaalGUI.BringToFront()
                    KinosaalGUI.Show()
                Case 4
                    c = _vierterTag.getVorstellung(b)
                    KinosaalGUI.Aufrufen(New Kinosaal(c), _Kunde)
                    KinosaalGUI.BringToFront()
                    KinosaalGUI.Show()
                Case 5
                    c = _fünfterTag.getVorstellung(b)
                    KinosaalGUI.Aufrufen(New Kinosaal(c), _Kunde)
                    KinosaalGUI.BringToFront()
                    KinosaalGUI.Show()
                Case 6
                    c = _sechsterTag.getVorstellung(b)
                    KinosaalGUI.Aufrufen(New Kinosaal(c), _Kunde)
                    KinosaalGUI.BringToFront()
                    KinosaalGUI.Show()
                Case 7
                    c = _siebterTag.getVorstellung(b)
                    KinosaalGUI.Aufrufen(New Kinosaal(c), _Kunde)
                    KinosaalGUI.BringToFront()
                    KinosaalGUI.Show()
            End Select
        End If
    End Sub
    Private Sub Button1_MouseMove(sender As Object, e As EventArgs) Handles Button1.MouseMove
        'wird aktiviert immer wenn die Maus über dem Button bewegt wird
        'Zeige ein Bild für den Film

        'Dieses Bild muss natürlich FIlmabhängig sein, das heißt, so wie es jetzt ist funktioniert es nicht!!!

        '     Dim BildVomFilm As Image = Image.FromFile _
        '(System.Environment.GetFolderPath _
        '(System.Environment.SpecialFolder.Personal) _
        '& "\Image.jpg") '.jpg ist wichtig


        'CType(My.Resources.ResourceManager.GetObject("Deadpool 2.png"), Drawing.Image)

        'Image.FromFile("C:\Users\thiemo.rickenstorf\source\repos\Kinoticketsystem1\Kino\Kinoticketsystem\Resources\Avatar.png") 'läuft noch nicht
        MausüberButton(Button1, 1, 1)
    End Sub


    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        mausverlässtButton
    End Sub

    Private Sub mausverlässtButton()
        PictureBox1.Hide()
    End Sub

    Private Sub Button2_MouseMove(sender As Object, e As EventArgs) Handles Button2.MouseMove
        MausüberButton(Button2, 1, 2)
    End Sub
    Private Sub Button3_MouseMove(sender As Object, e As EventArgs) Handles Button3.MouseMove
        MausüberButton(Button3, 1, 3)
    End Sub
    Private Sub Button4_MouseMove(sender As Object, e As EventArgs) Handles Button4.MouseMove
        MausüberButton(Button4, 1, 4)
    End Sub
    Private Sub Button5_MouseMove(sender As Object, e As EventArgs) Handles Button5.MouseMove
        MausüberButton(Button5, 1, 5)
    End Sub
    Private Sub Button6_MouseMove(sender As Object, e As EventArgs) Handles Button6.MouseMove
        MausüberButton(Button6, 1, 6)
    End Sub
    Private Sub Button7_MouseMove(sender As Object, e As EventArgs) Handles Button7.MouseMove
        MausüberButton(Button7, 1, 7)
    End Sub
    Private Sub Button8_MouseMove(sender As Object, e As EventArgs) Handles Button8.MouseMove
        MausüberButton(Button8, 2, 1)
    End Sub
    Private Sub Button9_MouseMove(sender As Object, e As EventArgs) Handles Button9.MouseMove
        MausüberButton(Button9, 2, 2)
    End Sub
    Private Sub Button10_MouseMove(sender As Object, e As EventArgs) Handles Button10.MouseMove
        MausüberButton(Button10, 2, 3)
    End Sub
    Private Sub Button11_MouseMove(sender As Object, e As EventArgs) Handles Button11.MouseMove
        MausüberButton(Button11, 2, 4)
    End Sub
    Private Sub Button12_MouseMove(sender As Object, e As EventArgs) Handles Button12.MouseMove
        MausüberButton(Button12, 2, 5)
    End Sub
    Private Sub Button13_MouseMove(sender As Object, e As EventArgs) Handles Button13.MouseMove
        MausüberButton(Button13, 2, 6)
    End Sub
    Private Sub Button14_MouseMove(sender As Object, e As EventArgs) Handles Button14.MouseMove
        MausüberButton(Button14, 2, 7)
    End Sub
    Private Sub Button15_MouseMove(sender As Object, e As EventArgs) Handles Button15.MouseMove
        MausüberButton(Button15, 3, 1)
    End Sub
    Private Sub Button16_MouseMove(sender As Object, e As EventArgs) Handles Button16.MouseMove
        MausüberButton(Button16, 3, 2)
    End Sub
    Private Sub Button17_MouseMove(sender As Object, e As EventArgs) Handles Button17.MouseMove
        MausüberButton(Button17, 3, 3)
    End Sub
    Private Sub Button18_MouseMove(sender As Object, e As EventArgs) Handles Button18.MouseMove
        MausüberButton(Button18, 3, 4)
    End Sub
    Private Sub Button19_MouseMove(sender As Object, e As EventArgs) Handles Button19.MouseMove
        MausüberButton(Button19, 3, 5)
    End Sub
    Private Sub Button20_MouseMove(sender As Object, e As EventArgs) Handles Button20.MouseMove
        MausüberButton(Button20, 3, 6)
    End Sub
    Private Sub Button21_MouseMove(sender As Object, e As EventArgs) Handles Button21.MouseMove
        MausüberButton(Button21, 3, 7)
    End Sub
    Private Sub Button22_MouseMove(sender As Object, e As EventArgs) Handles Button22.MouseMove
        MausüberButton(Button22, 4, 1)
    End Sub
    Private Sub Button23_MouseMove(sender As Object, e As EventArgs) Handles Button23.MouseMove
        MausüberButton(Button23, 4, 2)
    End Sub
    Private Sub Button24_MouseMove(sender As Object, e As EventArgs) Handles Button24.MouseMove
        MausüberButton(Button24, 4, 3)
    End Sub
    Private Sub Button25_MouseMove(sender As Object, e As EventArgs) Handles Button25.MouseMove
        MausüberButton(Button25, 4, 4)
    End Sub
    Private Sub Button26_MouseMove(sender As Object, e As EventArgs) Handles Button26.MouseMove
        MausüberButton(Button26, 4, 5)
    End Sub
    Private Sub Button27_MouseMove(sender As Object, e As EventArgs) Handles Button27.MouseMove
        MausüberButton(Button27, 4, 6)
    End Sub
    Private Sub Button28_MouseMove(sender As Object, e As EventArgs) Handles Button28.MouseMove
        MausüberButton(Button28, 4, 7)
    End Sub
    Private Sub Button29_MouseMove(sender As Object, e As EventArgs) Handles Button29.MouseMove
        MausüberButton(Button29, 5, 1)
    End Sub
    Private Sub Button30_MouseMove(sender As Object, e As EventArgs) Handles Button30.MouseMove
        MausüberButton(Button30, 5, 2)
    End Sub
    Private Sub Button31_MouseMove(sender As Object, e As EventArgs) Handles Button31.MouseMove
        MausüberButton(Button31, 5, 3)
    End Sub
    Private Sub Button32_MouseMove(sender As Object, e As EventArgs) Handles Button32.MouseMove
        MausüberButton(Button32, 5, 4)
    End Sub
    Private Sub Button33_MouseMove(sender As Object, e As EventArgs) Handles Button33.MouseMove
        MausüberButton(Button33, 5, 5)
    End Sub
    Private Sub Button34_MouseMove(sender As Object, e As EventArgs) Handles Button34.MouseMove
        MausüberButton(Button34, 5, 6)
    End Sub
    Private Sub Button35_MouseMove(sender As Object, e As EventArgs) Handles Button35.MouseMove
        MausüberButton(Button35, 5, 7)
    End Sub
    Private Sub Button36_MouseMove(sender As Object, e As EventArgs) Handles Button36.MouseMove
        MausüberButton(Button36, 6, 1)
    End Sub
    Private Sub Button37_MouseMove(sender As Object, e As EventArgs) Handles Button37.MouseMove
        MausüberButton(Button37, 6, 2)
    End Sub
    Private Sub Button38_MouseMove(sender As Object, e As EventArgs) Handles Button38.MouseMove
        MausüberButton(Button38, 6, 3)
    End Sub
    Private Sub Button39_MouseMove(sender As Object, e As EventArgs) Handles Button39.MouseMove
        MausüberButton(Button39, 6, 4)
    End Sub
    Private Sub Button40_MouseMove(sender As Object, e As EventArgs) Handles Button40.MouseMove
        MausüberButton(Button40, 6, 5)
    End Sub
    Private Sub Button41_MouseMove(sender As Object, e As EventArgs) Handles Button41.MouseMove
        MausüberButton(Button41, 6, 6)
    End Sub
    Private Sub Button42_MouseMove(sender As Object, e As EventArgs) Handles Button42.MouseMove
        MausüberButton(Button42, 6, 7)
    End Sub
    Private Sub Button43_MouseMove(sender As Object, e As EventArgs) Handles Button43.MouseMove
        MausüberButton(Button43, 7, 1)
    End Sub
    Private Sub Button44_MouseMove(sender As Object, e As EventArgs) Handles Button44.MouseMove
        MausüberButton(Button44, 7, 2)
    End Sub
    Private Sub Button45_MouseMove(sender As Object, e As EventArgs) Handles Button45.MouseMove
        MausüberButton(Button45, 7, 3)
    End Sub
    Private Sub Button46_MouseMove(sender As Object, e As EventArgs) Handles Button46.MouseMove
        MausüberButton(Button46, 7, 4)
    End Sub
    Private Sub Button47_MouseMove(sender As Object, e As EventArgs) Handles Button47.MouseMove
        MausüberButton(Button47, 7, 5)
    End Sub
    Private Sub Button48_MouseMove(sender As Object, e As EventArgs) Handles Button48.MouseMove
        MausüberButton(Button48, 7, 6)
    End Sub
    Private Sub Button49_MouseMove(sender As Object, e As EventArgs) Handles Button49.MouseMove
        MausüberButton(Button49, 7, 7)
    End Sub

    Private Sub MausüberButton(a As Button, x As Integer, y As Integer)
        'für alle die gleiche PictureBox verwenden!
        'eigentlich sollte das Bild gar nicht übergeben werden, sondern anhand der Position den Film und damit das passende BIld auslesen!!!
        Dim BildVomFilm As Image = My.Resources.ResourceManager.GetObject("Deadpool 2.png")


        PictureBox1.Location = New Point(a.Location.X + a.Size.Width, a.Location.Y)
        PictureBox1.Show()

        PictureBox1.Image = BildVomFilm
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        Select Case x
            Case 1
                lblTextüberFIlm.Text = _ersterTag.getVorstellung(1).getFilm.getFilminfos()

        End Select
        'hier könnte man noch einen Text über den Film als Array machen
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'NeueVorstellung.BringToFront()
        'NeueVorstellung.Show()
        'NeueVorstellung.PositionÜbergeben(1, 1)
        'Die andere Form ruft die Methode Filmändern auf, die den Film ändert
        Geklickt(1, 1)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Geklickt(1, 2)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Geklickt(1, 3)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Geklickt(1, 4)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Geklickt(1, 5)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Geklickt(1, 6)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Geklickt(1, 7)
        'Die andere Form ruft die Methode Filmändern auf, die den Film ändert
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Geklickt(2, 1)
    End Sub
    'Hier fehlen noch die anderen Tage ab 2.Tag


    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Geklickt(2, 2)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Geklickt(2, 3)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Geklickt(2, 4)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Geklickt(2, 5)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Geklickt(2, 6)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Geklickt(2, 7)
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Geklickt(3, 1)
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Geklickt(3, 2)
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Geklickt(3, 3)
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Geklickt(3, 4)
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Geklickt(3, 5)
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Geklickt(3, 6)
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Geklickt(3, 7)
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Geklickt(4, 1)
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Geklickt(4, 2)
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        Geklickt(4, 3)
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        Geklickt(4, 4)
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        Geklickt(4, 5)
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        Geklickt(4, 6)
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        Geklickt(4, 7)
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        Geklickt(5, 1)
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        Geklickt(5, 2)
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        Geklickt(5, 3)
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        Geklickt(5, 4)
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        Geklickt(5, 5)
    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        Geklickt(5, 6)
    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        Geklickt(5, 7)
    End Sub

    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
        Geklickt(6, 1)
    End Sub

    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
        Geklickt(6, 2)
    End Sub

    Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Button38.Click
        Geklickt(6, 3)
    End Sub

    Private Sub Button39_Click(sender As Object, e As EventArgs) Handles Button39.Click
        Geklickt(6, 4)
    End Sub

    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click
        Geklickt(6, 5)
    End Sub

    Private Sub Button41_Click(sender As Object, e As EventArgs) Handles Button41.Click
        Geklickt(6, 6)
    End Sub

    Private Sub Button42_Click(sender As Object, e As EventArgs) Handles Button42.Click
        Geklickt(6, 7)
    End Sub

    Private Sub Button43_Click(sender As Object, e As EventArgs) Handles Button43.Click
        Geklickt(7, 1)
    End Sub

    Private Sub Button44_Click(sender As Object, e As EventArgs) Handles Button44.Click
        Geklickt(7, 2)
    End Sub

    Private Sub Button45_Click(sender As Object, e As EventArgs) Handles Button45.Click
        Geklickt(7, 3)
    End Sub

    Private Sub Button46_Click(sender As Object, e As EventArgs) Handles Button46.Click
        Geklickt(7, 4)
    End Sub

    Private Sub Button47_Click(sender As Object, e As EventArgs) Handles Button47.Click
        Geklickt(7, 5)
    End Sub

    Private Sub Button48_Click(sender As Object, e As EventArgs) Handles Button48.Click
        Geklickt(7, 6)
    End Sub

    Private Sub Button49_Click(sender As Object, e As EventArgs) Handles Button49.Click
        Geklickt(7, 7)
    End Sub


End Class

'Ein Tagesplan, der speichert wann welcher Film gezeigt wird
'Die Start - und Laufzeit der Filme wird in den einzelnen Filmen gespeichert
Public Interface ITagesplan
    Sub TagesplanErstellen5(ByVal Vorstellung1 As Vorstellung, ByVal Vorstellung2 As Vorstellung, ByVal Vorstellung3 As Vorstellung, ByVal Vorstellung4 As Vorstellung, ByVal Vorstellung5 As Vorstellung)
    Sub TagesplanErstellen4(ByVal Vorstellung1 As Vorstellung, ByVal Vorstellung2 As Vorstellung, ByVal Vorstellung3 As Vorstellung, ByVal Vorstellung4 As Vorstellung)
    Sub TagesplanErstellen3(ByVal Vorstellung1 As Vorstellung, ByVal Vorstellung2 As Vorstellung, ByVal Vorstellung3 As Vorstellung)
    Sub TagesplanErstellen2(ByVal Vorstellung1 As Vorstellung, ByVal Vorstellung2 As Vorstellung)
    Sub TagesplanErstellen1(ByVal Vorstellung1 As Vorstellung)

    'Es muss die Filmnummer übergeben werden (später vielleicht mal die Vorstellung mit der getauscht werden soll oder die Uhrzeit?)
    Sub VorstellungÄndern(ByVal Vorstellung As Vorstellung, ByVal Filmnummer As Integer)
    'wird ans Ende hinzugefügt
    Sub VorstellungHinzufügen(ByVal Vorstellung As Vorstellung)
    Sub VorstellungEntfernen(ByVal vorstellung As Vorstellung)
    Function getVorstellungen() As ArrayList
    Function getVorstellung(ByVal Positiom As Integer) As Vorstellung
    Function getAnzahlVorstellungen() As Integer
    Function getSaal() As Kinosaal
    Function getFSK(a As Integer) As Integer
End Interface
Public Interface IVorstellung
    Sub BesucherHinzufügen(Besucher As Kunde)
    Sub SaalÄndern(Saal As Kinosaal)
    Sub FilmÄndern(Film As Film)
End Interface
Imports Kinoticketsystem

Public Class FTagesplan
    Private _ersterTag As ITagesplan
    Private _zweiterTag As ITagesplan
    Private _dritterTag As ITagesplan
    Private _vierterTag As ITagesplan
    Private _fünfterTag As ITagesplan
    Private _sechsterTag As ITagesplan
    Private _siebterTag As ITagesplan
    'Die nächsten 7 Tage werden angezeigt
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AnfangstagUndDatümerFestlegen() 'fertig
        PositionDerDatümerFestlegen()   'fertig
        PositionDerFilmButtonsFestlegenX()  'fertig
        WochenplanAbrufenUndAusgeben()  'muss noch gemacht werden (Erik)
        VorübergehendeInitialisierungderVeranstaltungenAlleMitDemGleichenFIlm()
        GrößeDerFilmButtonsFestlegen()  'Y - Größe funktioniert nicht wegen Null referenz, weil noch keine Veranstaltungen eingelesen und initialisiert wurden)
        PositionDerFilmButtonsFestlegenY()  'muss noch gemacht werden (eigentlich fertig, oder nicht?)
        ButtonsInvisibleMachen()
    End Sub



    Private Sub WochenplanAbrufenUndAusgeben()
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

    End Sub
    Private Sub VorübergehendeInitialisierungderVeranstaltungenAlleMitDemGleichenFIlm()
        Dim a As Film = New Film("Star Wars 1", 120, 12, True)
        Dim b As Vorstellung = New Vorstellung(0, 120, Nothing, a)
        Dim c As Vorstellung = New Vorstellung(126, 350, Nothing, a)
        _ersterTag = New Tagesplan
        _zweiterTag = New Tagesplan
        _dritterTag = New Tagesplan
        _vierterTag = New Tagesplan
        _fünfterTag = New Tagesplan
        _sechsterTag = New Tagesplan
        _siebterTag = New Tagesplan

        _ersterTag.TagesplanErstellen1(b)
        _zweiterTag.TagesplanErstellen1(b)
        _dritterTag.TagesplanErstellen1(b)
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
        '    _Montag.FilmÄndern(New Vorstellung(), txtFilmnummer.Text)
        WriteLine("FilmHinzufügen funktioniert nicht")
        Select Case True
            Case chbMontag.Checked
      '          _ersterTag.FilmÄndern(New Vorstellung(), txtFilmnummer.Text)
            Case chbDienstag.Checked
            Case chbMittwoch.Checked
            Case chbDonnerstag.Checked
            Case chbFreitag.Checked
        End Select
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
            cmdTagesPlanErstellen.Left = chbSonntag.Left
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        NeueVorstellung.BringToFront()
        NeueVorstellung.Show()
        NeueVorstellung.PositionÜbergeben(1, 1)
        'Die andere Form ruft die Methode Filmändern auf, die den Film ändert
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        NeueVorstellung.BringToFront()
        NeueVorstellung.Show()
        NeueVorstellung.PositionÜbergeben(1, 2)
        'Die andere Form ruft die Methode Filmändern auf, die den Film ändert
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        NeueVorstellung.BringToFront()
        NeueVorstellung.Show()
        NeueVorstellung.PositionÜbergeben(1, 3)
        'Die andere Form ruft die Methode Filmändern auf, die den Film ändert
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        NeueVorstellung.BringToFront()
        NeueVorstellung.Show()
        NeueVorstellung.PositionÜbergeben(1, 4)
        'Die andere Form ruft die Methode Filmändern auf, die den Film ändert
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        NeueVorstellung.BringToFront()
        NeueVorstellung.Show()
        NeueVorstellung.PositionÜbergeben(1, 5)
        'Die andere Form ruft die Methode Filmändern auf, die den Film ändert
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        NeueVorstellung.BringToFront()
        NeueVorstellung.Show()
        NeueVorstellung.PositionÜbergeben(1, 6)
        'Die andere Form ruft die Methode Filmändern auf, die den Film ändert
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        NeueVorstellung.BringToFront()
        NeueVorstellung.Show()
        NeueVorstellung.PositionÜbergeben(1, 7)
        'Die andere Form ruft die Methode Filmändern auf, die den Film ändert
    End Sub
    'Hier fehlen noch die anderen Tage ab 2.Tag
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
    Sub VorstellungEntfernen(ByVal vorstellung As Vorstellung, ByVal Position As Integer)
    Function getVorstellungen() As Array
    Function getVorstellung(ByVal Position As Integer) As Vorstellung
    Function getAnzahlVorstellungen() As Integer
    Function getSaal() As Kinosaal
End Interface
Public Interface IVorstellung
    Sub BesucherHinzufügen(Besucher As Kunde)
    Sub SaalÄndern(Saal As Kinosaal)
    Sub FilmÄndern(Film As Film)
End Interface
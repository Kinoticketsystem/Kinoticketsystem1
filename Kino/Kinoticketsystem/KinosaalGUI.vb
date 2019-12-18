Imports Kinoticketsystem

Public Class KinosaalGUI
    Private _Buttons(120) As Button
    Private _kinosaal As Kinosaal
    Private _AnzahlAusgewähltePlätze As Integer = 0
    Private _Gesamtkosten As Double
    Private _aktuellerKunde As Kunde
    Public _Buchen As Boolean

    'nur fürs zurückgeben (eigentlich nicht ganz sauber programmiert) 'brauchen wir nicht! oder!
    'Private _AusKinosaal As Integer
    'Private _AusTag As Integer
    'Private _NummerDesKinosaals As Integer

    Private Sub KinosaalGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        zeigeNurSovieleButtonsWienötig()
        ' StandartInitialisierung()
        übertrageAnzahlAusgewähltePlätze()
        InitialisiereSitzplan()
        berechneGrößeDerForm()

        'alle BUttons sind von vornherein auf FlatStyle.Popup
    End Sub

    Private Sub buttonsInsArray()

        _Buttons(0) = Button1
        _Buttons(1) = Button2
        _Buttons(2) = Button3
        _Buttons(3) = Button4
        _Buttons(4) = Button5
        _Buttons(5) = Button6
        _Buttons(6) = Button7
        _Buttons(7) = Button8
        _Buttons(8) = Button9
        _Buttons(9) = Button10
        _Buttons(10) = Button11
        _Buttons(11) = Button12
        _Buttons(12) = Button13
        _Buttons(13) = Button14
        _Buttons(14) = Button15
        _Buttons(15) = Button16
        _Buttons(16) = Button17
        _Buttons(17) = Button18
        _Buttons(18) = Button19
        _Buttons(19) = Button20
        _Buttons(20) = Button21
        _Buttons(21) = Button22
        _Buttons(22) = Button23
        _Buttons(23) = Button24
        _Buttons(24) = Button25
        _Buttons(25) = Button26
        _Buttons(26) = Button27
        _Buttons(27) = Button28
        _Buttons(28) = Button29
        _Buttons(29) = Button30
        _Buttons(30) = Button31
        _Buttons(31) = Button32
        _Buttons(32) = Button33
        _Buttons(33) = Button34
        _Buttons(34) = Button35
        _Buttons(35) = Button36
        _Buttons(36) = Button37
        _Buttons(37) = Button38
        _Buttons(38) = Button39
        _Buttons(39) = Button40
        _Buttons(40) = Button41
        _Buttons(41) = Button42
        _Buttons(42) = Button43
        _Buttons(43) = Button44
        _Buttons(44) = Button45
        _Buttons(45) = Button46
        _Buttons(46) = Button47
        _Buttons(47) = Button48
        _Buttons(48) = Button49
        _Buttons(49) = Button50
        _Buttons(50) = Button51
        _Buttons(51) = Button52
        _Buttons(52) = Button53
        _Buttons(53) = Button54
        _Buttons(54) = Button55
        _Buttons(55) = Button56
        _Buttons(56) = Button57
        _Buttons(57) = Button58
        _Buttons(58) = Button59
        _Buttons(59) = Button60
        _Buttons(60) = Button61
        _Buttons(61) = Button62
        _Buttons(62) = Button63
        _Buttons(63) = Button64
        _Buttons(64) = Button65
        _Buttons(65) = Button66
        _Buttons(66) = Button67
        _Buttons(67) = Button68
        _Buttons(68) = Button69
        _Buttons(69) = Button70
        _Buttons(70) = Button71
        _Buttons(71) = Button72
        _Buttons(72) = Button73
        _Buttons(73) = Button74
        _Buttons(74) = Button75
        _Buttons(75) = Button76
        _Buttons(76) = Button77
        _Buttons(77) = Button78
        _Buttons(78) = Button79
        _Buttons(79) = Button80
        _Buttons(80) = Button81
        _Buttons(81) = Button82
        _Buttons(82) = Button83
        _Buttons(83) = Button84
        _Buttons(84) = Button85
        _Buttons(85) = Button86
        _Buttons(86) = Button87
        _Buttons(87) = Button88
        _Buttons(88) = Button89
        _Buttons(89) = Button90
        _Buttons(90) = Button91
        _Buttons(91) = Button92
        _Buttons(92) = Button93
        _Buttons(93) = Button94
        _Buttons(94) = Button95
        _Buttons(95) = Button96
        _Buttons(96) = Button97
        _Buttons(97) = Button98
        _Buttons(98) = Button99
        _Buttons(99) = Button100
        _Buttons(100) = Button101
        _Buttons(101) = Button102
        _Buttons(102) = Button103
        _Buttons(103) = Button104
        _Buttons(104) = Button105
        _Buttons(105) = Button106
        _Buttons(106) = Button107
        _Buttons(107) = Button108
        _Buttons(108) = Button109
        _Buttons(109) = Button110
        _Buttons(110) = Button111
        _Buttons(111) = Button112
        _Buttons(112) = Button113
        _Buttons(113) = Button114
        _Buttons(114) = Button115
        _Buttons(115) = Button116
        _Buttons(116) = Button117
        _Buttons(117) = Button118
        _Buttons(118) = Button119
        _Buttons(119) = Button120
    End Sub

    Public Sub FehlerMitFalscherPersonBuchen()
        MsgBox("Die Plätze, die versucht wurden zu stornieren, wurden von einer anderen Person gebucht.", 0, "Stornierung kann nicht abgeschlossen werden")
        Me.Hide()
        Me.Close()


    End Sub

    Private Sub InitialisiereSitzplan() 'fertig (wichtig: immer dran denken button1 = (0,0))
        buttonsInsArray() 'nicht löschen!
        For i As Integer = 0 To _kinosaal.getAnzahlReihe - 1 ' überall gleich sein muss
            For j As Integer = 0 To _kinosaal.getSitzeProReihe - 1
                Dim a As Kunde = _kinosaal.getKunde(i, j) '= nothing funktioniert nicht. .hasValue müsste man erben vom System, k.P. wie und warum nicht automatisch wie bei Java ;-(

                If Not (_kinosaal._leererPlatz.Equals(a)) And _Buchen Then
                    macheButtons2DUndEnableUndRot(_Buttons((i * _kinosaal.getSitzeProReihe) + j))
                ElseIf Not _Buchen And (_kinosaal._leererPlatz.Equals(a)) Then
                    macheButtons2DUndEnableUndRot(_Buttons((i * _kinosaal.getSitzeProReihe) + j))
                    'Select Case i
                    '    Case 0
                    '        Select Case j
                    '            Case 0
                    '                macheButtons2DUndEnableUndRot(Button1)
                    '            Case 1
                    '                macheButtons2DUndEnableUndRot(Button2)
                    '            Case 3
                    '                macheButtons2DUndEnableUndRot(Button3)
                    '            Case 4
                    '                macheButtons2DUndEnableUndRot(Button4)
                    '            Case 5
                    '                macheButtons2DUndEnableUndRot(Button5)
                    '            Case 6
                    '                macheButtons2DUndEnableUndRot(Button6)
                    '                'bis case 14
                    '        End Select
                    '    Case 1
                    '        Select Case j
                    '            Case 0
                    '                macheButtons2DUndEnableUndRot(Button16)
                    '        End Select
                    '    Case 2
                    '        Select Case j
                    '            Case 0
                    '                macheButtons2DUndEnableUndRot(Button31)
                    '            Case 1
                    '            Case 2
                    '            Case 3
                    '                macheButtons2DUndEnableUndRot(Button34)
                    '        End Select
                    '    Case 3
                    '        Select Case j
                    '            Case 0
                    '                macheButtons2DUndEnableUndRot(Button46)
                    '            Case 1
                    '            Case 2
                    '            Case 3
                    '                macheButtons2DUndEnableUndRot(Button49)
                    '            Case 4
                    '                macheButtons2DUndEnableUndRot(Button50)
                    '        End Select
                    '    Case 4
                    '    Case 5
                    '    Case 6
                    '    Case 7
                    'End Select
                End If
            Next
        Next
    End Sub

    Private Sub StandartInitialisierung()
        _kinosaal = New Kinosaal(8 * 15, 8, 15) '8*15 'New Film("", 120, 12, True) siehe andere Komentare
        _aktuellerKunde = New Kunde("Max Mustermann")
        Dim b As Kunde = New Kunde("Test")
        _kinosaal.SitzplatzBuchen(0, 1, b)  'erste Reihe zweiter Platz
        _kinosaal.SitzplatzBuchen(3, 4, b)  'vierte Reihe fünfter Platz
        _kinosaal.SitzplatzBuchen(5, 10, b)
        zeigeNurSovieleButtonsWienötig()
    End Sub


    Private Sub berechneGrößeDerForm()
        'wie viele Buttons sind drauf * breite Buttons + bisschen was = breite der Form
        'länge der Form = ...
        Select Case _kinosaal.getAnzahlReihe
            Case 8
                Size = New Size(Button106.Left + Button106.Width + 45, Me.Size.Height)
            Case 7
                Size = New Size(Button91.Left + Button91.Width + 45, Me.Size.Height)
            Case 6
                Size = New Size(Button76.Left + Button76.Width + 45, Me.Size.Height)
            Case 5
                Size = New Size(Button61.Left + Button61.Width + 45, Me.Size.Height)
            Case 4
                Size = New Size(Button46.Left + Button46.Width + 45, Me.Size.Height)
            Case 3
                Size = New Size(Button31.Left + Button31.Width + 45, Me.Size.Height)
        End Select
        Select Case _kinosaal.getAnzahlSitzplätze
            Case 15
                Size = New Size(Size.Width, Button15.Location.Y + 70)

            Case 14
                Size = New Size(Size.Width, Button14.Location.Y + 70)
            Case 13
                Size = New Size(Size.Width, Button13.Location.Y + 70)
            Case 12
                Size = New Size(Size.Width, Button12.Location.Y + 70)
            Case 11
                Size = New Size(Size.Width, Button11.Location.Y + 70)
            Case 10
                Size = New Size(Size.Width, Button10.Location.Y + 70)
            Case 9
                Size = New Size(Size.Width, Button9.Location.Y + 70)
            Case 8
                Size = New Size(Size.Width, Button8.Location.Y + 70)
            Case 7
                Size = New Size(Size.Width, Button7.Location.Y + 70)
            Case 6
                Size = New Size(Size.Width, Button6.Location.Y + 70)
            Case 5
                Size = New Size(Size.Width, Button5.Location.Y + 70)
        End Select
        cmdFertig.Location = New Point(Size.Width - cmdFertig.Width - 27, Size.Height - cmdFertig.Height - 50)
    End Sub
    Private Sub zeigeNurSovieleButtonsWienötig()
        If _kinosaal.getAnzahlReihe < 8 Then
            Button106.Hide()
            Button107.Hide()
            Button108.Hide()
            Button109.Hide()
            Button110.Hide()
            Button111.Hide()
            Button112.Hide()
            Button113.Hide()
            Button114.Hide()
            Button115.Hide()
            Button116.Hide()
            Button117.Hide()
            Button118.Hide()
            Button119.Hide()
            Button120.Hide()
            If _kinosaal.getAnzahlReihe < 7 Then
                Button91.Hide()
                Button92.Hide()
                Button93.Hide()
                Button94.Hide()
                Button95.Hide()
                Button96.Hide()
                Button97.Hide()
                Button98.Hide()
                Button99.Hide()
                Button100.Hide()
                Button101.Hide()
                Button102.Hide()
                Button103.Hide()
                Button104.Hide()
                Button105.Hide()
                If _kinosaal.getAnzahlReihe < 6 Then
                    Button76.Hide()
                    Button77.Hide()
                    Button78.Hide()
                    Button79.Hide()
                    Button80.Hide()
                    Button81.Hide()
                    Button82.Hide()
                    Button83.Hide()
                    Button84.Hide()
                    Button85.Hide()
                    Button86.Hide()
                    Button87.Hide()
                    Button88.Hide()
                    Button89.Hide()
                    Button90.Hide()
                End If
            End If
        ElseIf _kinosaal.getAnzahlReihe > 8 Then
            Throw New Exception("Zu viele Reihen (nicht mehr als 8 möglich)")
        End If

        If _kinosaal.getSitzeProReihe < 15 Then
            Button15.Hide()
            Button30.Hide()
            Button45.Hide()
            Button60.Hide()
            Button75.Hide()
            Button90.Hide()
            Button105.Hide()
            Button120.Hide()
            If _kinosaal.getSitzeProReihe < 14 Then
                Button14.Hide()
                Button29.Hide()
                Button44.Hide()
                Button59.Hide()
                Button74.Hide()
                Button89.Hide()
                Button104.Hide()
                Button119.Hide()
                If _kinosaal.getSitzeProReihe < 13 Then
                    Button13.Hide()
                    Button28.Hide()
                    Button43.Hide()
                    Button58.Hide()
                    Button73.Hide()
                    Button88.Hide()
                    Button103.Hide()
                    Button118.Hide()
                    If _kinosaal.getSitzeProReihe < 12 Then
                        Button12.Hide()
                        Button27.Hide()
                        Button42.Hide()
                        Button57.Hide()
                        Button72.Hide()
                        Button87.Hide()
                        Button102.Hide()
                        Button117.Hide()
                        If _kinosaal.getSitzeProReihe < 11 Then
                            Button11.Hide()
                            Button26.Hide()
                            Button41.Hide()
                            Button56.Hide()
                            Button71.Hide()
                            Button86.Hide()
                            Button101.Hide()
                            Button116.Hide()
                            If _kinosaal.getSitzeProReihe < 10 Then
                                Button10.Hide()
                                Button25.Hide()
                                Button40.Hide()
                                Button55.Hide()
                                Button70.Hide()
                                Button85.Hide()
                                Button100.Hide()
                                Button115.Hide()
                                If _kinosaal.getSitzeProReihe < 9 Then
                                    Button9.Hide()
                                    Button24.Hide()
                                    Button39.Hide()
                                    Button54.Hide()
                                    Button69.Hide()
                                    Button84.Hide()
                                    Button99.Hide()
                                    Button114.Hide()
                                    If _kinosaal.getSitzeProReihe < 8 Then
                                        Button8.Hide()
                                        Button23.Hide()
                                        Button38.Hide()
                                        Button53.Hide()
                                        Button68.Hide()
                                        Button83.Hide()
                                        Button98.Hide()
                                        Button113.Hide()
                                        If _kinosaal.getSitzeProReihe < 7 Then
                                            Button7.Hide()
                                            Button22.Hide()
                                            Button37.Hide()
                                            Button52.Hide()
                                            Button67.Hide()
                                            Button82.Hide()
                                            Button97.Hide()
                                            Button112.Hide()
                                            If _kinosaal.getSitzeProReihe < 6 Then
                                                Button6.Hide()
                                                Button21.Hide()
                                                Button36.Hide()
                                                Button51.Hide()
                                                Button66.Hide()
                                                Button81.Hide()
                                                Button96.Hide()
                                                Button111.Hide()
                                                If _kinosaal.getSitzeProReihe < 5 Then
                                                    Throw New Exception("Die Reihe darf nicht kürzer als mindestens 5 Sitze lang sein.")
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        ElseIf _kinosaal.getSitzeProReihe > 15 Then
            Throw New Exception("Die Reihe darf nicht länger als max 15 Sitze lang sein")
        End If

    End Sub

    Public Sub Aufrufen(ByRef a As Kinosaal)
        'noch nicht fertig 'eigentlich schon, oder nicht?
        _kinosaal = a

        zeigeNurSovieleButtonsWienötig()
        übertrageAnzahlAusgewähltePlätze()
        InitialisiereSitzplan()
        berechneGrößeDerForm()
        _aktuellerKunde = New Kunde("Standard")
    End Sub
    'überladen, weil wenn kein Kunde übergeben wird, wird Standardkunde genommen
    'Public Sub VOnWoAufgerufen(kinosaal As Kinosaal, Tag As Integer, nummerdesKinosaals As Integer)
    '    _AusKinosaal = KinoGUI.DASKINO.getKinosäle.IndexOf(kinosaal) + 1 'richtig mit +1?
    '    _AusTag = Tag
    '    _NummerDesKinosaals = nummerdesKinosaals
    'End Sub
    Public Sub Aufrufen(ByRef a As Kinosaal, b As Kunde)
        'noch nicht fertig 'eigentlich schon, oder nicht?
        _kinosaal = a
        _aktuellerKunde = b
        If _Buchen Then
            Me.Text = Text & " - " & _aktuellerKunde.getName & " - " & "Buchen"
        Else
            Me.Text = Text & " - " & _aktuellerKunde.getName & " - " & "Stornieren"
        End If

        zeigeNurSovieleButtonsWienötig()
        übertrageAnzahlAusgewähltePlätze()
        InitialisiereSitzplan()
        berechneGrößeDerForm()

    End Sub
    Public Sub Kundefestlegen(ByVal b As Kunde)
        _aktuellerKunde = b
    End Sub

    Private Sub übertrageAnzahlAusgewähltePlätze()
        If _Buchen Then
            lblAnzahlAusgewähltePlätze.Text = "ausgewählte Plätze: " & _AnzahlAusgewähltePlätze
            If _Gesamtkosten < 10 Then
                lblPreis.Text = "Preis: 0" & Math.Round(_Gesamtkosten, 2).ToString("0.00") & "€"

            Else
                lblPreis.Text = "Preis: " & Math.Round(_Gesamtkosten, 2).ToString("0.00") & "€"

            End If

            If _AnzahlAusgewähltePlätze < 1 Then
                cmdFertig.BackColor = Color.Red
                cmdFertig.Enabled = False
            Else
                cmdFertig.BackColor = Color.Green
                cmdFertig.Enabled = True
            End If
        Else
            lblAnzahlAusgewähltePlätze.Text = "gebuchte Plätze: " & (_kinosaal.getAnzahlSitzplätze - _kinosaal.getAnzahlFreiPlätze)
            lblPreis.Text = "Betrag zurückgeben: "
            If _Gesamtkosten < 10 Then
                lblPreis.Text = "Preis: 0" & Math.Round(_Gesamtkosten, 2).ToString("0.00") & "€"

            Else
                lblPreis.Text = "Preis: " & Math.Round(_Gesamtkosten, 2).ToString("0.00") & "€"

            End If

            If _AnzahlAusgewähltePlätze < 1 Then
                cmdFertig.BackColor = Color.Red
                cmdFertig.Enabled = False
            Else
                cmdFertig.BackColor = Color.Green
                cmdFertig.Enabled = True
            End If
        End If

    End Sub
    Public Sub macheButtons2DUndEnableUndRot(ByRef a As Button)
        a.FlatStyle = FlatStyle.Flat
        a.FlatAppearance.BorderColor = Color.Black
        a.Enabled = False
        a.BackColor = Color.Red
    End Sub
    Private Sub wennButtonGedrückt(ByRef a As Button, ByVal xReihe As Integer, ByVal y As Integer) 'X ist Reihe
        If _Buchen Then
            If a.FlatStyle = FlatStyle.Popup Then
                a.FlatStyle = FlatStyle.Flat
                a.FlatAppearance.BorderColor = Color.Black
                a.BackColor = Color.Orange
                'a.FlatAppearance.MouseDownBackColor = Color.Red 'BorderSize = 3
                _kinosaal.SitzplatzBuchen(xReihe, y, _aktuellerKunde) 'Ist richtig so, also 0,0 für Button1
                _AnzahlAusgewähltePlätze += 1
                _Gesamtkosten += _kinosaal.getPreis(xReihe, y)

            Else
                a.FlatStyle = FlatStyle.Popup
                a.BackColor = Color.Lime
                a.FlatAppearance.BorderSize = 1
                _kinosaal.SitzplatzStornieren(xReihe, y, _aktuellerKunde)
                _AnzahlAusgewähltePlätze -= 1
                _Gesamtkosten -= _kinosaal.getPreis(xReihe, y)
            End If
        Else
            If a.FlatStyle = FlatStyle.Popup Then
                a.FlatStyle = FlatStyle.Flat
                a.FlatAppearance.BorderColor = Color.Black
                a.BackColor = Color.Orange
                'a.FlatAppearance.MouseDownBackColor = Color.Red 'BorderSize = 3
                _kinosaal.SitzplatzStornieren(xReihe, y, _aktuellerKunde) 'Ist richtig so, also 0,0 für Button1
                _AnzahlAusgewähltePlätze += 1
                _Gesamtkosten += _kinosaal.getPreis(xReihe, y)

            Else
                a.FlatStyle = FlatStyle.Popup
                a.BackColor = Color.Lime
                a.FlatAppearance.BorderSize = 1
                _kinosaal.SitzplatzBuchen(xReihe, y, _aktuellerKunde)
                _AnzahlAusgewähltePlätze -= 1
                _Gesamtkosten -= _kinosaal.getPreis(xReihe, y)
            End If
        End If

        übertrageAnzahlAusgewähltePlätze()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        wennButtonGedrückt(Button1, 0, 0)
    End Sub

    Private Sub cmdFertig_Click(sender As Object, e As EventArgs) Handles cmdFertig.Click
        'Dim a As ArrayList = KinoGUI.DASKINO.getTagesplan
        'If _AusKinosaal > 1 Then
        '    Dim b As Tagesplan = a(_AusTag * _AusKinosaal)
        'Else

        'End If
        'KinoGUI.DASKINO.setTagesplanANSTelle(, _AusTag)

        'es wird ja beim auswählen direkt gebucht
        If _Buchen Then

            If (MsgBox("Betrag: " & Math.Round(_Gesamtkosten, 2) & "€", 4, "Buchung abschließen") = 6) Then
                'ja geklickt
                Me.Close()
                Me.Hide()
                FTagesplan.Hide()
                FTagesplan.Close()

                KinoGUI.lblTageseinnahmen.Text = "Geld in der Kasse: " & Math.Round(KinoGUI._GeldInKasse + Me._Gesamtkosten, 2) & "€"
                KinoGUI._GeldInKasse += Me._Gesamtkosten
            End If
        Else
            If (MsgBox("Betrag: " & Math.Round(_Gesamtkosten, 2) & "€", 4, "Stornierung abschließen") = 6) Then
                'ja geklickt
                Me.Close()
                Me.Hide()
                FTagesplan.Hide()
                FTagesplan.Close()

                KinoGUI.lblTageseinnahmen.Text = "Geld in der Kasse: " & Math.Round(KinoGUI._GeldInKasse - Me._Gesamtkosten, 2) & "€"
                KinoGUI._GeldInKasse -= Me._Gesamtkosten
            End If
        End If


        '  Kunde zu beginn auswählen, weil dann mit übergeben beim Buchen
        'KundenGUI.BringToFront()
        'KundenGUI.Show()
        'KundenGUI.
        'Kinosaal übergeben
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        wennButtonGedrückt(Button2, 0, 1)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        wennButtonGedrückt(Button3, 0, 2)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        wennButtonGedrückt(Button4, 0, 3)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        wennButtonGedrückt(Button5, 0, 4)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        wennButtonGedrückt(Button6, 0, 5)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        wennButtonGedrückt(Button7, 0, 6)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        wennButtonGedrückt(Button8, 0, 7)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        wennButtonGedrückt(Button9, 0, 8)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        wennButtonGedrückt(Button10, 0, 9)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        wennButtonGedrückt(Button11, 0, 10)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        wennButtonGedrückt(Button12, 0, 11)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        wennButtonGedrückt(Button13, 0, 12)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        wennButtonGedrückt(Button14, 0, 13)
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        wennButtonGedrückt(Button15, 0, 14)
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        wennButtonGedrückt(Button16, 1, 0)
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        wennButtonGedrückt(Button17, 1, 1)
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        wennButtonGedrückt(Button18, 1, 2)
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        wennButtonGedrückt(Button19, 1, 3)
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        wennButtonGedrückt(Button20, 1, 4)
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        wennButtonGedrückt(Button21, 1, 5)
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        wennButtonGedrückt(Button22, 1, 6)
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        wennButtonGedrückt(Button23, 1, 7)
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        wennButtonGedrückt(Button24, 1, 8)
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        wennButtonGedrückt(Button25, 1, 9)
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        wennButtonGedrückt(Button26, 1, 10)
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        wennButtonGedrückt(Button27, 1, 11)
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        wennButtonGedrückt(Button28, 1, 12)
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        wennButtonGedrückt(Button29, 1, 13)
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        wennButtonGedrückt(Button30, 1, 14)
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        wennButtonGedrückt(Button31, 2, 0)
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        wennButtonGedrückt(Button32, 2, 1)
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        wennButtonGedrückt(Button33, 2, 2)
    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        wennButtonGedrückt(Button34, 2, 3)
    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        wennButtonGedrückt(Button35, 2, 4)
    End Sub

    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
        wennButtonGedrückt(Button36, 2, 5)
    End Sub

    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
        wennButtonGedrückt(Button37, 2, 6)
    End Sub

    Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Button38.Click
        wennButtonGedrückt(Button38, 2, 7)
    End Sub

    Private Sub Button39_Click(sender As Object, e As EventArgs) Handles Button39.Click
        wennButtonGedrückt(Button39, 2, 8)
    End Sub

    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click
        wennButtonGedrückt(Button40, 2, 9)
    End Sub

    Private Sub Button41_Click(sender As Object, e As EventArgs) Handles Button41.Click
        wennButtonGedrückt(Button41, 2, 10)
    End Sub

    Private Sub Button42_Click(sender As Object, e As EventArgs) Handles Button42.Click
        wennButtonGedrückt(Button42, 2, 11)
    End Sub

    Private Sub Button43_Click(sender As Object, e As EventArgs) Handles Button43.Click
        wennButtonGedrückt(Button43, 2, 12)
    End Sub

    Private Sub Button44_Click(sender As Object, e As EventArgs) Handles Button44.Click
        wennButtonGedrückt(Button44, 2, 13)
    End Sub

    Private Sub Button45_Click(sender As Object, e As EventArgs) Handles Button45.Click
        wennButtonGedrückt(Button45, 2, 14)
    End Sub

    Private Sub Button46_Click(sender As Object, e As EventArgs) Handles Button46.Click
        wennButtonGedrückt(Button46, 3, 0)
    End Sub

    Private Sub Button47_Click(sender As Object, e As EventArgs) Handles Button47.Click
        wennButtonGedrückt(Button47, 3, 1)
    End Sub

    Private Sub Button48_Click(sender As Object, e As EventArgs) Handles Button48.Click
        wennButtonGedrückt(Button48, 3, 2)
    End Sub

    Private Sub Button49_Click(sender As Object, e As EventArgs) Handles Button49.Click
        wennButtonGedrückt(Button49, 3, 3)
    End Sub

    Private Sub Button50_Click(sender As Object, e As EventArgs) Handles Button50.Click
        wennButtonGedrückt(Button50, 3, 4)
    End Sub

    Private Sub Button51_Click(sender As Object, e As EventArgs) Handles Button51.Click
        wennButtonGedrückt(Button51, 3, 5)
    End Sub

    Private Sub Button52_Click(sender As Object, e As EventArgs) Handles Button52.Click
        wennButtonGedrückt(Button52, 3, 6)
    End Sub

    Private Sub Button53_Click(sender As Object, e As EventArgs) Handles Button53.Click
        wennButtonGedrückt(Button53, 3, 7)
    End Sub

    Private Sub Button54_Click(sender As Object, e As EventArgs) Handles Button54.Click
        wennButtonGedrückt(Button54, 3, 8)
    End Sub

    Private Sub Button55_Click(sender As Object, e As EventArgs) Handles Button55.Click
        wennButtonGedrückt(Button55, 3, 9)
    End Sub

    Private Sub Button56_Click(sender As Object, e As EventArgs) Handles Button56.Click
        wennButtonGedrückt(Button56, 3, 10)
    End Sub

    Private Sub Button57_Click(sender As Object, e As EventArgs) Handles Button57.Click
        wennButtonGedrückt(Button57, 3, 11)
    End Sub

    Private Sub Button58_Click(sender As Object, e As EventArgs) Handles Button58.Click
        wennButtonGedrückt(Button58, 3, 12)
    End Sub

    Private Sub Button59_Click(sender As Object, e As EventArgs) Handles Button59.Click
        wennButtonGedrückt(Button59, 3, 13)
    End Sub

    Private Sub Button60_Click(sender As Object, e As EventArgs) Handles Button60.Click
        wennButtonGedrückt(Button60, 3, 14)
    End Sub

    Private Sub Button61_Click(sender As Object, e As EventArgs) Handles Button61.Click
        wennButtonGedrückt(Button61, 4, 0)
    End Sub

    Private Sub Button62_Click(sender As Object, e As EventArgs) Handles Button62.Click
        wennButtonGedrückt(Button62, 4, 1)
    End Sub

    Private Sub Button63_Click(sender As Object, e As EventArgs) Handles Button63.Click
        wennButtonGedrückt(Button63, 4, 2)
    End Sub

    Private Sub Button64_Click(sender As Object, e As EventArgs) Handles Button64.Click
        wennButtonGedrückt(Button64, 4, 3)
    End Sub

    Private Sub Button65_Click(sender As Object, e As EventArgs) Handles Button65.Click
        wennButtonGedrückt(Button65, 4, 4)
    End Sub

    Private Sub Button66_Click(sender As Object, e As EventArgs) Handles Button66.Click
        wennButtonGedrückt(Button66, 4, 5)
    End Sub

    Private Sub Button67_Click(sender As Object, e As EventArgs) Handles Button67.Click
        wennButtonGedrückt(Button67, 4, 6)
    End Sub

    Private Sub Button68_Click(sender As Object, e As EventArgs) Handles Button68.Click
        wennButtonGedrückt(Button68, 4, 7)
    End Sub

    Private Sub Button69_Click(sender As Object, e As EventArgs) Handles Button69.Click
        wennButtonGedrückt(Button69, 4, 8)
    End Sub

    Private Sub Button70_Click(sender As Object, e As EventArgs) Handles Button70.Click
        wennButtonGedrückt(Button70, 4, 9)
    End Sub

    Private Sub Button71_Click(sender As Object, e As EventArgs) Handles Button71.Click
        wennButtonGedrückt(Button71, 4, 10)
    End Sub

    Private Sub Button72_Click(sender As Object, e As EventArgs) Handles Button72.Click
        wennButtonGedrückt(Button72, 4, 11)
    End Sub

    Private Sub Button73_Click(sender As Object, e As EventArgs) Handles Button73.Click
        wennButtonGedrückt(Button73, 4, 12)
    End Sub

    Private Sub Button74_Click(sender As Object, e As EventArgs) Handles Button74.Click
        wennButtonGedrückt(Button74, 4, 13)
    End Sub

    Private Sub Button75_Click(sender As Object, e As EventArgs) Handles Button75.Click
        wennButtonGedrückt(Button75, 4, 14)
    End Sub

    Private Sub Button76_Click(sender As Object, e As EventArgs) Handles Button76.Click
        wennButtonGedrückt(Button76, 5, 0)
    End Sub

    Private Sub Button77_Click(sender As Object, e As EventArgs) Handles Button77.Click
        wennButtonGedrückt(Button77, 5, 1)
    End Sub

    Private Sub Button78_Click(sender As Object, e As EventArgs) Handles Button78.Click
        wennButtonGedrückt(Button78, 5, 2)
    End Sub

    Private Sub Button79_Click(sender As Object, e As EventArgs) Handles Button79.Click
        wennButtonGedrückt(Button79, 5, 3)
    End Sub

    Private Sub Button80_Click(sender As Object, e As EventArgs) Handles Button80.Click
        wennButtonGedrückt(Button80, 5, 4)
    End Sub

    Private Sub Button81_Click(sender As Object, e As EventArgs) Handles Button81.Click
        wennButtonGedrückt(Button81, 5, 5)
    End Sub

    Private Sub Button82_Click(sender As Object, e As EventArgs) Handles Button82.Click
        wennButtonGedrückt(Button82, 5, 6)
    End Sub

    Private Sub Button83_Click(sender As Object, e As EventArgs) Handles Button83.Click
        wennButtonGedrückt(Button83, 5, 7)
    End Sub

    Private Sub Button84_Click(sender As Object, e As EventArgs) Handles Button84.Click
        wennButtonGedrückt(Button84, 5, 8)
    End Sub

    Private Sub Button85_Click(sender As Object, e As EventArgs) Handles Button85.Click
        wennButtonGedrückt(Button85, 5, 9)
    End Sub

    Private Sub Button86_Click(sender As Object, e As EventArgs) Handles Button86.Click
        wennButtonGedrückt(Button86, 5, 10)
    End Sub

    Private Sub Button87_Click(sender As Object, e As EventArgs) Handles Button87.Click
        wennButtonGedrückt(Button87, 5, 11)
    End Sub

    Private Sub Button88_Click(sender As Object, e As EventArgs) Handles Button88.Click
        wennButtonGedrückt(Button88, 5, 12)
    End Sub

    Private Sub Button89_Click(sender As Object, e As EventArgs) Handles Button89.Click
        wennButtonGedrückt(Button89, 5, 13)
    End Sub

    Private Sub Button90_Click(sender As Object, e As EventArgs) Handles Button90.Click
        wennButtonGedrückt(Button90, 5, 14)
    End Sub

    Private Sub Button91_Click(sender As Object, e As EventArgs) Handles Button91.Click
        wennButtonGedrückt(Button91, 6, 0)
    End Sub

    Private Sub Button92_Click(sender As Object, e As EventArgs) Handles Button92.Click
        wennButtonGedrückt(Button92, 6, 1)
    End Sub

    Private Sub Button93_Click(sender As Object, e As EventArgs) Handles Button93.Click
        wennButtonGedrückt(Button93, 6, 2)
    End Sub

    Private Sub Button94_Click(sender As Object, e As EventArgs) Handles Button94.Click
        wennButtonGedrückt(Button94, 6, 3)
    End Sub

    Private Sub Button95_Click(sender As Object, e As EventArgs) Handles Button95.Click
        wennButtonGedrückt(Button95, 6, 4)
    End Sub

    Private Sub Button96_Click(sender As Object, e As EventArgs) Handles Button96.Click
        wennButtonGedrückt(Button96, 6, 5)
    End Sub

    Private Sub Button97_Click(sender As Object, e As EventArgs) Handles Button97.Click
        wennButtonGedrückt(Button97, 6, 6)
    End Sub

    Private Sub Button98_Click(sender As Object, e As EventArgs) Handles Button98.Click
        wennButtonGedrückt(Button98, 6, 7)
    End Sub

    Private Sub Button99_Click(sender As Object, e As EventArgs) Handles Button99.Click
        wennButtonGedrückt(Button99, 6, 8)
    End Sub

    Private Sub Button100_Click(sender As Object, e As EventArgs) Handles Button100.Click
        wennButtonGedrückt(Button100, 6, 9)
    End Sub

    Private Sub Button101_Click(sender As Object, e As EventArgs) Handles Button101.Click
        wennButtonGedrückt(Button101, 6, 10)
    End Sub

    Private Sub Button102_Click(sender As Object, e As EventArgs) Handles Button102.Click
        wennButtonGedrückt(Button102, 6, 11)
    End Sub

    Private Sub Button103_Click(sender As Object, e As EventArgs) Handles Button103.Click
        wennButtonGedrückt(Button103, 6, 12)
    End Sub

    Private Sub Button104_Click(sender As Object, e As EventArgs) Handles Button104.Click
        wennButtonGedrückt(Button104, 6, 13)
    End Sub

    Private Sub Button105_Click(sender As Object, e As EventArgs) Handles Button105.Click
        wennButtonGedrückt(Button105, 6, 14)
    End Sub

    Private Sub Button106_Click(sender As Object, e As EventArgs) Handles Button106.Click
        wennButtonGedrückt(Button106, 7, 0)
    End Sub

    Private Sub Button107_Click(sender As Object, e As EventArgs) Handles Button107.Click
        wennButtonGedrückt(Button107, 7, 1)
    End Sub

    Private Sub Button108_Click(sender As Object, e As EventArgs) Handles Button108.Click
        wennButtonGedrückt(Button108, 7, 2)
    End Sub

    Private Sub Button109_Click(sender As Object, e As EventArgs) Handles Button109.Click
        wennButtonGedrückt(Button109, 7, 3)
    End Sub

    Private Sub Button110_Click(sender As Object, e As EventArgs) Handles Button110.Click
        wennButtonGedrückt(Button110, 7, 4)
    End Sub

    Private Sub Button111_Click(sender As Object, e As EventArgs) Handles Button111.Click
        wennButtonGedrückt(Button111, 7, 5)
    End Sub

    Private Sub Button112_Click(sender As Object, e As EventArgs) Handles Button112.Click
        wennButtonGedrückt(Button112, 7, 6)
    End Sub

    Private Sub Button113_Click(sender As Object, e As EventArgs) Handles Button113.Click
        wennButtonGedrückt(Button113, 7, 7)
    End Sub

    Private Sub Button114_Click(sender As Object, e As EventArgs) Handles Button114.Click
        wennButtonGedrückt(Button114, 7, 8)
    End Sub

    Private Sub Button115_Click(sender As Object, e As EventArgs) Handles Button115.Click
        wennButtonGedrückt(Button115, 7, 9)
    End Sub

    Private Sub Button116_Click(sender As Object, e As EventArgs) Handles Button116.Click
        wennButtonGedrückt(Button116, 7, 10)
    End Sub

    Private Sub Button117_Click(sender As Object, e As EventArgs) Handles Button117.Click
        wennButtonGedrückt(Button117, 7, 11)
    End Sub

    Private Sub Button118_Click(sender As Object, e As EventArgs) Handles Button118.Click
        wennButtonGedrückt(Button118, 7, 12)
    End Sub

    Private Sub Button119_Click(sender As Object, e As EventArgs) Handles Button119.Click
        wennButtonGedrückt(Button119, 7, 13)
    End Sub

    Private Sub Button120_Click(sender As Object, e As EventArgs) Handles Button120.Click
        wennButtonGedrückt(Button120, 7, 14)
    End Sub

    Private Sub KinosaalGUI_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        KinoGUI.AnzahlFreiPlätzeBestimmen()
    End Sub
End Class
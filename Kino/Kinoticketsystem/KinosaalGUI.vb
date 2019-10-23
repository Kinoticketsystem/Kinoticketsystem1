Imports Kinoticketsystem

Public Class KinosaalGUI
    Private _Buttons(120) As Button
    Private _kinosaal As Kinosaal
    Private _AnzahlAusgewähltePlätze As Integer = 0
    Private _Gesamtkosten As Double
    Private _aktuellerKunde As Kunde

    Private Sub KinosaalGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  zeigeNurSovieleButtonsWienötig()
        '  berechneGrößeDerForm()
        StandartInitialisierung()
        übertrageAnzahlAusgewähltePlätze()
        InitialisiereSitzplan()
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


        'bis 
        _Buttons(119) = Button120
    End Sub

    Private Sub InitialisiereSitzplan() 'fertig (wichtig: immer dran denken button1 = (0,0)
        buttonsInsArray() 'nicht löschen!

        For i As Integer = 0 To _kinosaal.getX - 1 ' überall gleich sein muss
            For j As Integer = 0 To _kinosaal.getY - 1
                Dim a As Kunde = _kinosaal.getKunde(i, j) '= nothing funktioniert nicht. .hasValue müsste man erben vom System, k.P. wie und warum nicht automatisch wie bei Java ;-(

                If Not (_kinosaal._leererPlatz.Equals(a)) Then
                    macheButtons2DUndEnableUndRot(_Buttons((i * _kinosaal.getY) + j))
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
        _kinosaal = New Kinosaal(8 * 15, New Film("", 120, 12, True), 8, 15)
        _aktuellerKunde = New Kunde("Max Mustermann")
        Dim b As Kunde = New Kunde("Test")
        _kinosaal.SitzplatzBuchen(0, 1, b)  'erste Reihe zweiter Platz
        _kinosaal.SitzplatzBuchen(3, 4, b)  'vierte Reihe fünfter Platz
        ' _kinosaal.SitzplatzBuchen(5, 10, b)
    End Sub

    Private Sub berechneGrößeDerForm()
        'wie viele Buttons sind drauf * breite Buttons + bisschen was = breite der Form
        'länge der Form = ...
        Throw New NotImplementedException()
    End Sub
    Private Sub zeigeNurSovieleButtonsWienötig()
        If _kinosaal.getX < 8 Then
            Button106.Hide()
            '...
            Button120.Hide()
            If _kinosaal.getX < 7 Then
                Button91.Hide()
                '...
                Button105.Hide()
                If _kinosaal.getX < 6 Then
                    '...
                End If
            End If
        Else
            Throw New Exception("Zu viele Reihen (nicht mehr als 8 möglich)")
        End If

        If _kinosaal.getY < 15 Then
            Button15.Hide()
            Button30.Hide()
            Button45.Hide()
            Button60.Hide()
            Button75.Hide()
            Button90.Hide()
            Button105.Hide()
            Button120.Hide()
            If _kinosaal.getY < 14 Then
                Button14.Hide()
                Button28.Hide()
                '..
                If _kinosaal.getY < 5 Then
                    Throw New Exception("Die Reihe darf nicht kürzer als mindestens 5 Sitze lang sein.")
                End If
            End If
        Else
            Throw New Exception("Die Reihe darf nicht länger als max 15 Sitze lang sein")
        End If

    End Sub

    Public Sub Aufrufen(ByRef a As Kinosaal, ByVal b As Kunde)
        _kinosaal = a

        zeigeNurSovieleButtonsWienötig()
        _aktuellerKunde = b
    End Sub

    Private Sub übertrageAnzahlAusgewähltePlätze()
        lblAnzahlAusgewähltePlätze.Text = "ausgewählte Plätze: " & _AnzahlAusgewähltePlätze
        If _AnzahlAusgewähltePlätze < 1 Then
            cmdFertig.BackColor = Color.Red
        Else
            cmdFertig.BackColor = Color.Green
        End If
    End Sub
    Private Sub macheButtons2DUndEnableUndRot(ByRef a As Button)
        a.FlatStyle = FlatStyle.Flat
        a.FlatAppearance.BorderColor = Color.Black
        a.Enabled = False
        a.BackColor = Color.Red
    End Sub
    Private Sub wennButtonGedrückt(ByRef a As Button, ByVal xReihe As Integer, ByVal y As Integer) 'X ist Reihe
        If a.FlatStyle = FlatStyle.Popup Then
            a.FlatStyle = FlatStyle.Flat
            a.FlatAppearance.BorderColor = Color.Black
            a.BackColor = Color.Orange
            'a.FlatAppearance.MouseDownBackColor = Color.Red 'BorderSize = 3
            _kinosaal.SitzplatzBuchen(xReihe, y, _aktuellerKunde) 'Ist richtig so, also 0,0 für Button1
            _AnzahlAusgewähltePlätze += 1
        Else
            a.FlatStyle = FlatStyle.Popup
            a.BackColor = Color.Lime
            a.FlatAppearance.BorderSize = 1
            _kinosaal.SitzplatzStornieren(xReihe, y, _aktuellerKunde)
            _AnzahlAusgewähltePlätze -= 1
        End If
        übertrageAnzahlAusgewähltePlätze()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        wennButtonGedrückt(Button1, 0, 0)
    End Sub

    Private Sub cmdFertig_Click(sender As Object, e As EventArgs) Handles cmdFertig.Click
        Me.Close()
        Me.Hide()
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
        wennButtonGedrückt(Button16, 0, 15)
    End Sub
    'noch 104 mal ;-)
End Class
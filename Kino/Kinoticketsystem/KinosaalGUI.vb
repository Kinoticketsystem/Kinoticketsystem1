Imports Kinoticketsystem

Public Class KinosaalGUI
    Private _kinosaal As Kinosaal
    Private _AnzahlAusgewähltePlätze As Integer = 0
    Private _Gesamtkosten As Double
    Private _aktuellerKunde As Kunde

    Private Sub KinosaalGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  zeigeNurSovieleButtonsWienötig()
        '  berechneGrößeDerForm()
        MacheButtonsZuFlipFlopButtons()
        StandartInitialisierung()
        übertrageAnzahlAusgewähltePlätze()
        InitialisiereSitzplan
    End Sub

    Private Sub InitialisiereSitzplan()
        For i As Integer = 0 To _kinosaal.getX - 1
            For j As Integer = 0 To _kinosaal.getY - 1
                Dim a As Kunde = _kinosaal.getKunde(i, j) '= nothing funktioniert nicht. .hasValue müsste man erben vom System, k.P. wie und warum nicht automatisch wie bei Java ;-(

                If Not (_kinosaal._leererPlatz.Equals(a)) Then
                    Select Case i
                        Case 0
                            Select Case j
                                Case 0
                                    Button1.BackColor = Color.Red
                                    macheButtons2DUndEnable(Button1)
                                Case 1
                                    Button2.BackColor = Color.Red
                                    macheButtons2DUndEnable(Button2)

                                Case 3
                                    Button3.BackColor = Color.Red
                                    macheButtons2DUndEnable(Button3)

                                Case 4
                                    macheButtons2DUndEnable(Button4)
                                    Button4.BackColor = Color.Red
                                Case 5
                                    macheButtons2DUndEnable(Button5)
                                    Button5.BackColor = Color.Red
                                Case 6
                                    macheButtons2DUndEnable(Button6)
                                    Button6.BackColor = Color.Red
                                    'bis case 14
                            End Select
                        Case 1
                            Select Case j
                                Case 0
                                    macheButtons2DUndEnable(Button16)
                                    Button16.BackColor = Color.Red
                            End Select
                        Case 2
                            Select Case j
                                Case 0
                                    macheButtons2DUndEnable(Button31)
                                    Button31.BackColor = Color.Red
                                Case 1
                                Case 2
                                Case 3
                                    macheButtons2DUndEnable(Button34)
                                    Button34.BackColor = Color.Red
                            End Select
                        Case 3
                            Select Case j
                                Case 0
                                    macheButtons2DUndEnable(Button46)
                                    Button46.BackColor = Color.Red
                                Case 1
                                Case 2
                                Case 3
                                    macheButtons2DUndEnable(Button49)
                                    Button49.BackColor = Color.Red
                                Case 4
                                    macheButtons2DUndEnable(Button50)
                                    Button50.BackColor = Color.Red

                            End Select
                        Case 4
                        Case 5
                        Case 6
                        Case 7

                    End Select
                End If
            Next
        Next
    End Sub

    Private Sub StandartInitialisierung()
        _kinosaal = New Kinosaal(120, New Film("", 120, 12, True), 8, 15)
        _aktuellerKunde = New Kunde("Max Mustermann")
        Dim b As Kunde = New Kunde("Test")
        _kinosaal.SitzplatzBuchen(0, 1, b)  'erste Reihe zweiter Platz
        _kinosaal.SitzplatzBuchen(3, 4, b)
        _kinosaal.SitzplatzBuchen(5, 10, b)
    End Sub

    Private Sub MacheButtonsZuFlipFlopButtons()
        Button1.FlatStyle = FlatStyle.Popup

        Button1.FlatAppearance.CheckedBackColor = Color.Black
    End Sub

    Private Sub berechneGrößeDerForm()
        Throw New NotImplementedException()
    End Sub
    Private Sub zeigeNurSovieleButtonsWienötig()
        Throw New NotImplementedException()
        Select Case _kinosaal.getX
            Case 5
                '....
        End Select
        Select Case _kinosaal.getY
            Case 5
                '....hide()
        End Select
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
    Private Sub macheButtons2DUndEnable(ByRef a As Button)
        a.FlatStyle = FlatStyle.Flat
        a.FlatAppearance.BorderColor = Color.Black
        a.Enabled = False
    End Sub
    Private Sub art1(ByRef a As Button, ByVal xReihe As Integer, ByVal y As Integer) 'X ist Reihe
        If a.FlatStyle = FlatStyle.Popup Then
            a.FlatStyle = FlatStyle.Flat
            a.FlatAppearance.BorderColor = Color.Black
            a.BackColor = Color.Orange
            'a.FlatAppearance.MouseDownBackColor = Color.Red 'BorderSize = 3
            _kinosaal.SitzplatzBuchen(xReihe, y, _aktuellerKunde)
            _AnzahlAusgewähltePlätze += 1
        Else
            a.FlatStyle = FlatStyle.Popup
            a.BackColor = Color.Lime
            a.FlatAppearance.BorderSize = 1
            _kinosaal.SitzplatzStornieren(xReihe, y, _aktuellerKunde)
            _AnzahlAusgewähltePlätze -= 1
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        art1(Button1, 1, 1)
        übertrageAnzahlAusgewähltePlätze()
    End Sub

    Private Sub cmdFertig_Click(sender As Object, e As EventArgs) Handles cmdFertig.Click
        Me.Close()
        Me.Hide()
        'Kinosaal übergeben
    End Sub
End Class
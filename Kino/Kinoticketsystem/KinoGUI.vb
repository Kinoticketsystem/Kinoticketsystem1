Imports Kinoticketsystem

Public Class KinoGUI 'Label1, txtTageseinnahmen und lblFreiePlätzeFarbe1 Unötig(Werden nicht gebraucht)
    Private DASKINO As Kino
    'Public alleFilme As ArrayList = New ArrayList() 'eigentlich sollte das hier nicht extra gespeichert werden, sondern in DASKINO
    'Public alleKunden As ArrayList = New ArrayList() 'eigentlich sollte das hier nicht extra gespeichert werden, sondern in DASKINO
    Private _AnzahlKinos As Integer = 6
    'Public alleKinosäle(_AnzahlKinos) As Kinosaal 'eigentlich sollte das hier nicht extra gespeichert werden, sondern in DASKINO ' = New ArrayList() 'vielleicht lieber array, weil feste Größe?
    'Public alleTagespläne As ArrayList = New ArrayList() 'eigentlich sollte das hier nicht extra gespeichert werden, sondern in DASKINO
    Public dasMegaKino As Kino


    Private Sub cmdTexterfassenErik_Click(sender As Object, e As EventArgs) Handles cmdTexterfassen.Click 'cmdTexterfassen nicht mehr vorhanden(Neuer Button)
        TexterfassenTest.BringToFront()
        TexterfassenTest.Visible = True
    End Sub

    'Private Sub KinoGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    Auslesen
    '    DASKINO = New Kino(..., ...., ..., .., ..)
    'End Sub

    Private Sub cmdkinosaalAufrufen_Click(sender As Object, e As EventArgs) Handles cmdkinosaalAufrufen.Click
        KinosaalGUI.BringToFront()
        KinosaalGUI.Show()
    End Sub





    Private Sub cmdNeueBuchung_Click(sender As Object, e As EventArgs) Handles cmdNeueBuchung.Click
        FTagesplan.BringToFront()
        FTagesplan.Visible = True
    End Sub

    Private Sub KinoGUI_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Dim alleFilme As ArrayList = New ArrayList()
        'Dim alleKunden As ArrayList = New ArrayList()
        'Dim alleKinosäle As ArrayList = New ArrayList()
        'Dim alleKinosäle2 As ArrayList = New ArrayList()
        'Dim alleTagespläne As ArrayList = New ArrayList()

        'FileOpen(1, "Filme.txt", OpenMode.Input)
        'While Not EOF(1)
        '    alleFilme.Add(LineInput(1))
        '    Console.WriteLine()
        'End While
        'FileClose(1)

        'FileOpen(1, "Kunden.txt", OpenMode.Input)
        'While Not EOF(1)
        '    alleKunden.Add(LineInput(1))
        '    Console.WriteLine()
        'End While
        'FileClose(1)

        'FileOpen(1, "Kinosäle.txt", OpenMode.Input)
        'While Not EOF(1)
        '    alleKinosäle.Add(LineInput(1))
        '    Console.WriteLine()
        'End While
        'FileClose(1)
        'Dim Sitzplätze As Integer
        'Dim Film As Film
        'Dim Reihen As Integer
        'Dim SitzeproReihe As Integer
        'Dim ZwischenString As String
        'For i = 0 To alleKinosäle.Count - 1
        '    ZwischenString = alleKinosäle.Item(i)
        '    ZwischenString.Replace("Kinosaal", "")
        '    Dim Postion As Integer = InStr(ZwischenString, ": Anzahl Sitzplätze: ")
        '    Sitzplätze = Mid(ZwischenString, Postion)
        '    alleKinosäle2.Add(New Kinosaal(Sitzplätze,))
        'Next

        'FileOpen(1, "Tagespläne.txt", OpenMode.Input)
        'While Not EOF(1)
        '    alleTagespläne.Add(LineInput(1))
        '    Console.WriteLine()
        'End While
        'FileClose(1)
        'dasMegaKino = New Kino(alleKinosäle2.Count, alleFilme, alleKunden, alleTagespläne, alleKinosäle2)
        testInitialisierung()

        FormSchönMachen()
    End Sub

    Private Sub testInitialisierung()
        Dim a(5) As Kinosaal
        Dim c As Film = New Film("Testfilm", 120, 12, True)
        For i = 0 To 5
            a(i) = New Kinosaal(60, 6, 10) 'film fehlt 
        Next
        a(3) = New Kinosaal(120, 8, 15) 'film fehlt
        Dim tagesplänesdv(6) As Tagesplan 'wird bei Kino noch umgesetz, dass man sieben pro Kinosaal braucht
        For i = 0 To 6
            Dim z As Tagesplan = New Tagesplan()
            z.TagesplanErstellen3(New Vorstellung(0, 120, New ArrayList, c), New Vorstellung(130, 250, New ArrayList, c), New Vorstellung(260, 380, New ArrayList, c))
            tagesplänesdv(i) = z
        Next
        DASKINO = New Kino(6, New ArrayList, New ArrayList, tagesplänesdv, a)

    End Sub

    Private Sub FormSchönMachen()
        DatumUndUhrzeitFestlegn()
        AnzahlFreiPlätzeBestimmen()
        nächstenFilmProKinosaalANzeigen
        '....
    End Sub

    Private Sub nächstenFilmProKinosaalANzeigen()
        Dim a() As Tagesplan = DASKINO.getTagesplan 'pro Kinosaal 7 (wird noch umgesetzt) also später dann erst den Tag rausfinden und dann von dem Tagesplan den nächsten FIlm nehmen und wenn alle durch, dann entweder vom nächsten Tag oder Anzeigen für heute keine mehr
        For i = 0 To DASKINO.getTagesplan.GetLength(0) - 1
            labelNächsterFilmBerechnen(i, a(i).getNächstenFilm(Now))
        Next
    End Sub

    Private Sub labelNächsterFilmBerechnen(i As Integer, vorstellung As Vorstellung)
        Select Case i
            Case 0
                lblFilm1.Text = vorstellung.getFilm.getFilmtitel
            Case 1
                lblFilm2.Text = vorstellung.getFilm.getFilmtitel
            Case 2
                lblFilm3.Text = vorstellung.getFilm.getFilmtitel
            Case 3
                lblFilm4.Text = vorstellung.getFilm.getFilmtitel
            Case 4
                lblFilm5.Text = vorstellung.getFilm.getFilmtitel
            Case 5
                lblFilm6.Text = vorstellung.getFilm.getFilmtitel
        End Select
    End Sub

    Private Sub AnzahlFreiPlätzeBestimmen()
        Dim a() As Kinosaal = DASKINO.getKinosäle
        For i = 0 To DASKINO.getKinosäle().GetLength(0) - 1
            If a(i).getAnzahlFreiPlätze > 0 Then
                LabelFreiPlätzeberechnen(i, 0, a(i).getAnzahlFreiPlätze, a(i).getAnzahlSitzplätze)
            ElseIf a(i).getAnzahlFreiPlätze / a(i).getAnzahlSitzplätze < 0.2 Then
                LabelFreiPlätzeberechnen(i, 2, a(i).getAnzahlFreiPlätze, a(i).getAnzahlSitzplätze)
            Else
                LabelFreiPlätzeberechnen(i, 1, a(i).getAnzahlFreiPlätze, a(i).getAnzahlSitzplätze)
            End If
        Next
    End Sub

    Private Sub LabelFreiPlätzeberechnen(c As Integer, frei As Integer, anzahlfreiePlätze As Integer, anzahlPlätze As Integer)
        If frei = 0 Then
            Select Case c
                Case 0
                    lblFreiePlätze1.BackColor = Color.Green
                    lblFreiePlätze1.Text = anzahlfreiePlätze & " von " & anzahlPlätze & " Plätzen frei"
                Case 1
                    lblFreiePlätze2.BackColor = Color.Green
                    lblFreiePlätze2.Text = anzahlfreiePlätze & " von " & anzahlPlätze & " Plätzen frei"
                Case 2
                    lblFreiePlätze3.BackColor = Color.Green
                    lblFreiePlätze3.Text = anzahlfreiePlätze & " von " & anzahlPlätze & " Plätzen frei"
                Case 3
                    lblFreiePlätze4.BackColor = Color.Green
                    lblFreiePlätze4.Text = anzahlfreiePlätze & " von " & anzahlPlätze & " Plätzen frei"
                Case 4
                    lblFreiePlätze5.BackColor = Color.Green
                    lblFreiePlätze5.Text = anzahlfreiePlätze & " von " & anzahlPlätze & " Plätzen frei"
                Case 5
                    lblFreiePlätze6.BackColor = Color.Green
                    lblFreiePlätze6.Text = anzahlfreiePlätze & " von " & anzahlPlätze & " Plätzen frei"
            End Select
        ElseIf frei = 2 Then
            Select Case c
                Case 0
                    lblFreiePlätze1.BackColor = Color.Orange
                    lblFreiePlätze1.Text = anzahlfreiePlätze & " von " & anzahlPlätze & " Plätzen frei"
                Case 1
                    lblFreiePlätze2.BackColor = Color.Orange
                    lblFreiePlätze2.Text = anzahlfreiePlätze & " von " & anzahlPlätze & " Plätzen frei"
                Case 2
                    lblFreiePlätze3.BackColor = Color.Orange
                    lblFreiePlätze3.Text = anzahlfreiePlätze & " von " & anzahlPlätze & " Plätzen frei"
                Case 3
                    lblFreiePlätze4.BackColor = Color.Orange
                    lblFreiePlätze4.Text = anzahlfreiePlätze & " von " & anzahlPlätze & " Plätzen frei"
                Case 4
                    lblFreiePlätze5.BackColor = Color.Orange
                    lblFreiePlätze5.Text = anzahlfreiePlätze & " von " & anzahlPlätze & " Plätzen frei"
                Case 5
                    lblFreiePlätze6.BackColor = Color.Orange
                    lblFreiePlätze6.Text = anzahlfreiePlätze & " von " & anzahlPlätze & " Plätzen frei"
            End Select
        Else
            Select Case c
                Case 0
                    lblFreiePlätze1.BackColor = Color.Red
                    lblFreiePlätze1.Text = anzahlfreiePlätze & " von " & anzahlPlätze & " Plätzen frei"
                Case 1
                    lblFreiePlätze2.BackColor = Color.Red
                    lblFreiePlätze2.Text = anzahlfreiePlätze & " von " & anzahlPlätze & " Plätzen frei"
                Case 2
                    lblFreiePlätze3.BackColor = Color.Red
                    lblFreiePlätze3.Text = anzahlfreiePlätze & " von " & anzahlPlätze & " Plätzen frei"
                Case 3
                    lblFreiePlätze4.BackColor = Color.Red
                    lblFreiePlätze4.Text = anzahlfreiePlätze & " von " & anzahlPlätze & " Plätzen frei"
                Case 4
                    lblFreiePlätze5.BackColor = Color.Red
                    lblFreiePlätze5.Text = anzahlfreiePlätze & " von " & anzahlPlätze & " Plätzen frei"
                Case 5
                    lblFreiePlätze6.BackColor = Color.Red
                    lblFreiePlätze6.Text = anzahlfreiePlätze & " von " & anzahlPlätze & " Plätzen frei"
            End Select
        End If
        If c > 5 Then
            lblDatum.Text = "Array der Kkinosäle größer als 6, als angezeigt werden"
        End If
    End Sub

    Private Sub DatumUndUhrzeitFestlegn()
        Dim thisDate As Date = Today
        lblDatum.Text = thisDate.ToString(" dd.MM.yy")
        lblUhrzeit.Left = lblDatum.Left + 5
        Timer2.Enabled = False
    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim zeit
        zeit = Hour(Now)
        zeit = zeit & ":" & Minute(Now) & ":" & Second(Now)
        lblUhrzeit.Text = zeit
    End Sub

    Private Sub lblUhrzeit_Click(sender As Object, e As EventArgs) Handles lblUhrzeit.Click
        Timer1.Enabled = Not Timer1.Enabled
        Timer2.Enabled = Not Timer2.Enabled
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim zeit
        zeit = Hour(Now)
        zeit = zeit & ":" & Minute(Now)
        lblUhrzeit.Text = zeit
    End Sub
    Private Sub cmdWochenplan_Click(sender As Object, e As EventArgs) Handles cmdWochenplan1.Click
        FTagesplan.BringToFront()
        FTagesplan.Visible = True
        FTagesplan.SetKinosaal(DASKINO.getKinosäle(0))
        'Veranstaltungen übergeben
        'FTagesplan.
    End Sub
    Private Sub cmdWochenplan2_Click(sender As Object, e As EventArgs) Handles cmdWochenplan2.Click
        FTagesplan.BringToFront()
        FTagesplan.Visible = True
        FTagesplan.SetKinosaal((DASKINO.getKinosäle(1)))
        'Veranstaltungen übergeben
        'FTagesplan.
    End Sub

    Private Sub cmdWochenplan3_Click(sender As Object, e As EventArgs) Handles cmdWochenplan3.Click
        FTagesplan.BringToFront()
        FTagesplan.Visible = True
        FTagesplan.SetKinosaal((DASKINO.getKinosäle(2)))
        'Veranstaltungen übergeben
        'FTagesplan.
    End Sub

    Private Sub cmdWochenplan4_Click(sender As Object, e As EventArgs) Handles cmdWochenplan4.Click
        FTagesplan.BringToFront()
        FTagesplan.Visible = True
        FTagesplan.SetKinosaal((DASKINO.getKinosäle((3))))
        'Veranstaltungen übergeben
        'FTagesplan.
    End Sub

    Private Sub cmdWochenplan5_Click(sender As Object, e As EventArgs) Handles cmdWochenplan5.Click
        FTagesplan.BringToFront()
        FTagesplan.Visible = True
        FTagesplan.SetKinosaal((DASKINO.getKinosäle(4)))
        'Veranstaltungen übergeben
        'FTagesplan.
    End Sub

    Private Sub cmdWochenplan6_Click(sender As Object, e As EventArgs) Handles cmdWochenplan6.Click
        FTagesplan.BringToFront()
        FTagesplan.Visible = True
        FTagesplan.SetKinosaal((DASKINO.getKinosäle(5)))
        'Veranstaltungen übergeben
        'FTagesplan.
    End Sub

    Private Sub cmdTestKinosaal_Click(sender As Object, e As EventArgs) Handles cmdTestKinosaal.Click
        Call KinosaalTest.Show()
    End Sub

    Private Sub cmdTestkinotest_Click_1(sender As Object, e As EventArgs) Handles cmdTestkinotest.Click
        Call Testklassekino.Show()
    End Sub

    Private Sub cmdTestTagesplan_Click(sender As Object, e As EventArgs) Handles cmdTestTagesplan.Click

        BringToFront()
    End Sub

    Private Sub cmdTestVorstellung_Click(sender As Object, e As EventArgs) Handles cmdTestVorstellung.Click
        'Call TestVorstellung.Show()
    End Sub
End Class
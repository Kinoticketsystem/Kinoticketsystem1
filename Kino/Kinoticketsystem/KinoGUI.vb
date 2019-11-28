Imports Kinoticketsystem

Public Class KinoGUI 'Label1, txtTageseinnahmen und lblFreiePlätzeFarbe1 Unötig(Werden nicht gebraucht)
    Private DASKINO As Kino

    'Public alleFilme As ArrayList = New ArrayList() 'eigentlich sollte das hier nicht extra gespeichert werden, sondern in DASKINO
    'Public alleKunden As ArrayList = New ArrayList() 'eigentlich sollte das hier nicht extra gespeichert werden, sondern in DASKINO
    Private _AnzahlKinos As Integer = 6
    'Public alleKinosäle(_AnzahlKinos) As Kinosaal 'eigentlich sollte das hier nicht extra gespeichert werden, sondern in DASKINO ' = New ArrayList() 'vielleicht lieber array, weil feste Größe?
    'Public alleTagespläne As ArrayList = New ArrayList() 'eigentlich sollte das hier nicht extra gespeichert werden, sondern in DASKINO



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
        ' FTagesplan.BringToFront()
        ' FTagesplan.Visible = True
        If cmdNeueBuchung.FlatStyle = FlatStyle.Popup Then
            cmdNeueBuchung.FlatStyle = FlatStyle.Flat
            cmdNeueBuchung.FlatAppearance.BorderColor = Color.Black
            cmdBuchungStonieren.FlatStyle = FlatStyle.Popup
        Else
            cmdNeueBuchung.FlatStyle = FlatStyle.Popup
            cmdNeueBuchung.BackColor = Color.Lime
            cmdNeueBuchung.FlatAppearance.BorderSize = 1
            cmdBuchungStonieren.FlatStyle = FlatStyle.Flat
            cmdBuchungStonieren.FlatAppearance.BorderColor = Color.Black

        End If
    End Sub

    Private Sub KinoGUI_Load(sender As Object, e As EventArgs) Handles Me.Load

        'For i = 0 To alleFilme.Count - 1
        '    Dim ZwischenString As String = alleFilme.Item(i)
        '    Dim Position1 As Integer = InStr(ZwischenString, ": Spieldauer: ")
        '    Filmtitel = Mid(ZwischenString, 0, Position1 - 1)
        '    Dim Position2 As Integer = InStrRev(ZwischenString, ": Spieldauer: ") + 13
        '    Dim position3 As Integer = InStr(ZwischenString, " Altersfreigabe: ")
        '    Filmlänge = Mid(ZwischenString, Position2 + 1, position3 - 1)
        '    Dim position4 As Integer = InStrRev(ZwischenString, " Altersfreigabe: ") + 16
        '    Dim position5 As Integer = InStr(ZwischenString, " 3D? ")
        '    Altersfreigabe = Mid(position4 + 1, position5 - 1)
        '    Dim position6 As Integer = InStrRev(ZwischenString, " 3D? ") + 4
        '    ist3D = Mid(ZwischenString, position6)
        '    alleFilme2.Add(New Film(Filmtitel, Filmlänge, Altersfreigabe, ist3D))
        'Next

        'FileOpen(1, "Kunden.txt", OpenMode.Input)
        'While Not EOF(1)
        '    alleKunden.Add(LineInput(1))
        '    Console.WriteLine()
        'End While
        'FileClose(1)
        'For i = 0 To alleKunden.Count - 1
        '    alleKunden2.Add(New Kunde(alleKunden(i)))
        'Next

        'FileOpen(1, "Kinosäle.txt", OpenMode.Input)
        'While Not EOF(1)
        '    alleKinosäle.Add(LineInput(1))
        '    Console.WriteLine()
        'End While
        'FileClose(1)
        'Dim Sitzplätze As Integer

        'Dim Reihen As Integer
        'Dim SitzeproReihe As Integer
        'For i = 0 To alleKinosäle.Count - 1
        '    Dim ZwischenString As String = alleKinosäle.Item(i)
        '    'ZwischenString.Replace("Kinosaal", "")
        '    Dim Position1 As Integer = InStrRev(ZwischenString, ": Anzahl Sitzplätze: ") + 20
        '    Dim Position2 As Integer = InStr(ZwischenString, " Anzahl Reihen: ") + 15
        '    Sitzplätze = Mid(ZwischenString, Position1 + 1, Position2 - 1)
        '    Dim position3 As Integer = InStrRev(ZwischenString, "Anzahl Reihen: ") + 14
        '    Dim position4 As Integer = InStr(ZwischenString, " Sitzplätze pro Reihe: ")
        '    Reihen = Mid(ZwischenString, position3 + 1, position4 - 1)
        '    Dim position5 As Integer = InStrRev(ZwischenString, " Sitzplätze pro Reihe: ") + 22
        '    SitzeproReihe = Mid(ZwischenString, position5 + 1)
        '    alleKinosäle2.Add(New Kinosaal(Sitzplätze, Reihen, SitzeproReihe))
        'Next

        'FileOpen(1, "Tagespläne.txt", OpenMode.Input)
        'While Not EOF(1)
        '    alleTagespläne.Add(LineInput(1))
        '    Console.WriteLine()
        'End While
        'Dim Anfangszeit As Integer
        'Dim Endzeit As Integer
        'Dim vorgestellterFilm As String
        'Dim Vorstellungslänge As Integer
        'Dim Vorstellungsfreigabe As Integer
        'Dim Dimension As Boolean
        'For i = 0 To alleTagespläne.Count - 1
        '    Dim Zwischenstring As String = alleTagespläne.Item(i)

        '    If Zwischenstring.Contains("Tag") Then

        '    Else
        '        Dim position1 As Integer = InStrRev(Zwischenstring, "geht von ") + 8
        '        Dim position2 As Integer = InStr(Zwischenstring, " bis ")
        '        Anfangszeit = Mid(Zwischenstring, position1 + 1, position2 - 1)
        '        Dim position3 As Integer = InStrRev(Zwischenstring, "bis ") + 3
        '        Dim position4 As Integer = InStr(Zwischenstring, ", es läuft ")
        '        Endzeit = Mid(Zwischenstring, position3 + 1, position4 - 1)
        '        Dim position5 As Integer = InStrRev(Zwischenstring, ", es läuft ") + 10
        '        Dim position6 As Integer = InStr(Zwischenstring, " (")
        '        vorgestellterFilm = Mid(Zwischenstring, position5 + 1, position6 - 1)
        '        Dim position7 As Integer = InStrRev(Zwischenstring, " (") + 1
        '        Dim position8 As Integer = InStr(Zwischenstring, ") ab")
        '        Vorstellungslänge = Mid(Zwischenstring, position7 + 1, position8 - 1)
        '        Dim position9 As Integer = InStrRev(Zwischenstring, ") ab ") + 4
        '        Dim position10 As Integer = InStr(Zwischenstring, " 3D: ")
        '        Vorstellungsfreigabe = Mid(Zwischenstring, position9 + 1, position10 - 1)
        '        Dim position11 As Integer = InStrRev(Zwischenstring, " 3D: ") + 4
        '        Dim position12 As Integer = InStr(Zwischenstring, " Saal 1")
        '        Dimension = Mid(Zwischenstring, position11 + 1, position12 - 1)
        '        Dim Film As New Film(vorgestellterFilm, Vorstellungslänge, Vorstellungsfreigabe, Dimension)
        '        alleVorstellungen.Add(New Vorstellung(Anfangszeit, Endzeit, leereListe, Film))
        '    End If

        '    alleTagespläne2.Add(New Tagesplan())

        '    'Hier muss noch geklärt werden, wie die Tagespläne richtig gespeichert werden sollen, da wir eine unendlich große Menge bekommen, aber alles in ein kleines Array gequetscht werden soll. 
        '    'Da muss noch eine Lösung für gefunden werden! --> vorrübergehende Lösung: Tagespläne als ArrayList, statt als fester Array 

        'Next
        'FileClose(1)
        'DASKINO = New Kino(alleKinosäle2.Count, alleFilme2, alleKunden2, alleTagespläne2, alleKinosäle2)
        'testInitialisierung()

        'Einfachere Implementierung: 

        Dim leereListe As ArrayList = New ArrayList()
        Dim alleFilme As ArrayList = New ArrayList() ' StringListe
        Dim alleFilme2 As ArrayList = New ArrayList() ' KlassenListe 
        Dim alleKunden As ArrayList = New ArrayList()
        Dim alleKunden2 As ArrayList = New ArrayList()
        Dim alleKinosäle As ArrayList = New ArrayList()
        Dim alleKinosäle2 As ArrayList = New ArrayList()
        Dim alleTagespläne As ArrayList = New ArrayList()
        Dim alleTagespläne2 As ArrayList = New ArrayList()
        Dim alleVorstellungen As ArrayList = New ArrayList()

        DASKINO = New Kino(alleKinosäle2.Count, alleFilme2, alleKunden2, alleTagespläne2, alleKinosäle2)

        FileOpen(1, "Filme.txt", OpenMode.Input)
        While Not EOF(1)
            alleFilme.Add(LineInput(1))
            Console.WriteLine()
        End While
        FileClose(1)
        Dim Filmtitel As String
        Dim Filmlänge As Integer
        Dim Altersfreigabe As Integer
        Dim ist3D As Boolean
        If alleFilme.Count >= 4 Then
            For i = 0 To alleFilme.Count - 1
                Filmtitel = alleFilme(i * 4 + 0)
                Filmlänge = alleFilme(i * 4 + 1)
                Altersfreigabe = alleFilme(i * 4 + 2)
                ist3D = alleFilme(i * 4 + 3)
                alleFilme2.Add(New Film(Filmtitel, Filmlänge, Altersfreigabe, ist3D))
                DASKINO.FilmHinzufügen(New Film(Filmtitel, Filmlänge, Altersfreigabe, ist3D))
            Next
        End If

        My.Computer.FileSystem.WriteAllText("Filme.txt", "", False) ' löscht den Inhalt der Datei 

        FileOpen(1, "Kunden.txt", OpenMode.Input)
        While Not EOF(1)
            alleKunden.Add(LineInput(1))
            Console.WriteLine()
        End While
        FileClose(1)
        For i = 0 To alleKunden.Count - 1
            alleKunden2.Add(New Kunde(alleKunden(i)))
            DASKINO.KundenHinzufügen(New Kunde(alleKunden(i)))
        Next

        My.Computer.FileSystem.WriteAllText("Kunden.txt", "", False) ' löscht den Inhalt der Datei 

        FileOpen(1, "Kinosäle.txt", OpenMode.Input)
        While Not EOF(1)
            alleKinosäle.Add(LineInput(1))
            Console.WriteLine()
        End While
        FileClose(1)
        Dim Sitzplätze As Integer
        Dim Reihen As Integer
        Dim SitzeproReihe As Integer
        If alleKinosäle.Count >= 4 Then
            For i = 0 To alleFilme.Count - 1
                Sitzplätze = alleKinosäle(i * 4 + 1)
                Reihen = alleKinosäle(i * 4 + 2)
                SitzeproReihe = alleFilme(i * 4 + 3)
                alleKinosäle2.Add(New Kinosaal(Sitzplätze, Reihen, SitzeproReihe))
                DASKINO.KinosaalAmEndeHinzufügen(New Kinosaal(Sitzplätze, Reihen, SitzeproReihe))
            Next
        End If

        My.Computer.FileSystem.WriteAllText("Kinosäle.txt", "", False) ' löscht den Inhalt der Datei

        FileOpen(1, "Tagespläne.txt", OpenMode.Input)
        While Not EOF(1)
            alleTagespläne.Add(LineInput(1))
            Console.WriteLine()
        End While
        FileClose(1)
        Dim Anfangszeit As Integer
        Dim Endzeit As Integer
        Dim vorgestellterFilm As String
        Dim Vorstellungslänge As Integer
        Dim Vorstellungsfreigabe As Integer
        Dim Dimension As Boolean
        If alleTagespläne.Count >= 9 Then
            For i = 0 To alleTagespläne.Count - 1
                Anfangszeit = alleTagespläne(i * 9 + 2)
                Endzeit = alleTagespläne(i * 9 + 3)
                vorgestellterFilm = alleTagespläne(i * 9 + 4)
                Vorstellungslänge = alleTagespläne(i * 9 + 5)
                Vorstellungsfreigabe = alleTagespläne(i * 9 + 6)
                Dimension = alleTagespläne(i * 9 + 7)
                Dim Film As New Film(vorgestellterFilm, Vorstellungslänge, Vorstellungsfreigabe, Dimension)
                alleTagespläne2.Add(New Vorstellung(Anfangszeit, Endzeit, leereListe, Film))

            Next
        End If

        DASKINO.setTagesplan(alleTagespläne2)

        My.Computer.FileSystem.WriteAllText("Tagespläne.txt", "", False) ' löscht den Inhalt der Datei

        FormSchönMachen()
    End Sub


    Private Sub KinoGUI_Closing(sender As Object, e As EventArgs) Handles Me.Load
        'Einfügen in die Textdateien wenn das Programm beendet wird 
        Dim titel As New ArrayList
        Dim säle As New ArrayList
        Dim pläne As New ArrayList
        Dim kunden As New ArrayList
        Dim anzahlKinos As Integer
        titel = DASKINO.getFilmtitel
        säle = DASKINO.getKinosäle
        pläne = DASKINO.getTagesplan
        kunden = DASKINO.getKunden
        anzahlKinos = DASKINO.getAnzahlKinosäle
        Dim neuertext As String
        For i = 0 To kunden.Count - 1
            neuertext = kunden(i)
            FileOpen(1, "Kunden.txt", OpenMode.Append)
            PrintLine(1, neuertext)
            FileClose(1)
            'Dim file1 As System.IO.StreamWriter
            'file1 = My.Computer.FileSystem.OpenTextFileWriter("Kunden.txt", True)
            'file1.WriteLine(neuertext)
            'file1.Close()
        Next
        For j = 0 To titel.Count - 1
            'neuertext = titel(j).getFilmtitel & ": Spieldauer: " & titel(j).getFilmlänge & " Altersfreigabe: " & titel(j).getAltersfreigabe & " 3D? " & titel(j).ist3D
            FileOpen(1, "Filme.txt", OpenMode.Append)
            PrintLine(1, titel(j).getFilmtitel)
            PrintLine(1, titel(j).getFilmlänge)
            PrintLine(1, titel(j).getAltersfreigabe)
            PrintLine(1, titel(j).ist3D)
            FileClose(1)
            'Dim file2 As System.IO.StreamWriter
            'file2 = My.Computer.FileSystem.OpenTextFileWriter("Filme.txt", True)
            'file2.WriteLine(titel(j).getFilmtitel & ": Spieldauer: " & titel(j).getFilmlänge & " Altersfreigabe: " & titel(j).getAltersfreigabe & " 3D? " & titel(j).ist3D)
            'file2.Close()
        Next
        For k = 0 To anzahlKinos - 1
            FileOpen(1, "Kinosäle.txt", OpenMode.Append)
            'PrintLine(1, "Kinosaal" & k & ": Anzahl Sitzplätze: " & Kinosäle(k).getAnzahlSitzplätze & " Anzahl der Reihen: " & Kinosäle(k).getAnzahlReihe & " Sitzplätze pro Reihe: " & Kinosäle(k).getSitzeProReihe)
            PrintLine(1, k)
            PrintLine(1, säle(k).getAnzahlSitzplätze)
            PrintLine(1, säle(k).getAnzahlReihe)
            PrintLine(1, säle(k).getSitzeProReihe)
            FileClose(1)
            '    Dim file3 As System.IO.StreamWriter
            '    file3 = My.Computer.FileSystem.OpenTextFileWriter("Kinosäle.txt", True)
            '    file3.WriteLine("Kinosaal" & k & ": Anzahl Sitzplätze: " & Kinosäle(k).getAnzahlSitzplätze & " Anzahl der Reihen: " & Kinosäle(k).getAnzahlReihe & " Sitzplätze pro Reihe: " & Kinosäle(k).getSitzeProReihe)
            '    file3.Close()
        Next
        For i = 0 To pläne.Count - 1
            Dim plan As Tagesplan = pläne(i)
            Dim AnzahlVorstellungen As Integer = plan.getAnzahlVorstellungen
            'Dim file4 As System.IO.StreamWriter
            'file4 = My.Computer.FileSystem.OpenTextFileWriter("Tagespläne.txt", True)
            'file4.WriteLine(i + 1 & ". Tag:")
            For j = 1 To AnzahlVorstellungen
                Dim Vorstellung As Vorstellung = plan.getVorstellung(j)
                FileOpen(1, "Tagespläne.txt", OpenMode.Append)
                PrintLine(1, i)
                'PrintLine(1, "Vorstellung " & j & ": " & Vorstellung.getAnfangszeit() & " bis " & Vorstellung.getEndzeit() & " : " & Vorstellung.getFilm.getFilmtitel() & " Saal: 1")
                PrintLine(1, j)
                PrintLine(1, Vorstellung.getAnfangszeit())
                PrintLine(1, Vorstellung.getEndzeit())
                PrintLine(1, Vorstellung.getFilm.getFilmtitel())
                PrintLine(1, Vorstellung.getFilm.getFilmlänge)
                PrintLine(1, Vorstellung.getFilm.getAltersfreigabe)
                PrintLine(1, Vorstellung.getFilm.Ist3D)
                PrintLine(1, Vorstellung.getSaal)

                FileClose(1)


                '    'file4.WriteLine(i & ". Tag:")
                '    file4.WriteLine("Vorstellung " & j & " geht von " & Vorstellung.getAnfangszeit() & " bis " & Vorstellung.getEndzeit() & ", es läuft " & Vorstellung.getFilm.getFilmtitel() & " (" & Vorstellung.getFilm.getFilmlänge & ") ab " & Vorstellung.getFilm.getAltersfreigabe & " 3D: " & Vorstellung.getFilm.Ist3D & " Saal 1")

            Next
            'file4.Close()
        Next
    End Sub

    Private Sub reinschreiben()
        DASKINO.getFilmtitel()
    End Sub
    Private Sub testInitialisierung()
        'Dim a(5) As Kinosaal
        'Dim c As Film = New Film("Testfilm", 120, 12, True)
        'For i = 0 To 5
        '    a(i) = New Kinosaal(60, 6, 10) 'film fehlt 
        'Next
        'a(3) = New Kinosaal(120, 8, 15) 'film fehlt
        Dim a As ArrayList = New ArrayList
        Dim c As Film = New Film("Testfilm", 120, 12, True)
        For i = 0 To 5
            a.add(New Kinosaal(60, 6, 10)) 'film fehlt 
        Next
        a(3) = New Kinosaal(120, 8, 15) 'film fehlt
        'Dim tagesplänesdv(6) As Tagesplan 'wird bei Kino noch umgesetz, dass man sieben pro Kinosaal braucht
        'For i = 0 To 6
        '    Dim z As Tagesplan = New Tagesplan()
        '    z.TagesplanErstellen3(New Vorstellung(0, 120, New ArrayList, c), New Vorstellung(130, 250, New ArrayList, c), New Vorstellung(260, 380, New ArrayList, c))
        '    tagesplänesdv(i) = z
        'Next
        Dim tagesplänesdv As ArrayList = New ArrayList 'wird bei Kino noch umgesetz, dass man sieben pro Kinosaal braucht
        For i = 0 To 6
            Dim z As Tagesplan = New Tagesplan()
            z.TagesplanErstellen3(New Vorstellung(0, 120, New ArrayList, c), New Vorstellung(130, 250, New ArrayList, c), New Vorstellung(260, 380, New ArrayList, c))
            tagesplänesdv.Add(z)
        Next
        DASKINO = New Kino(6, New ArrayList, New ArrayList, tagesplänesdv, a)


        ' provisorisch geändert, um Fehler zu vermeiden 


    End Sub

    Private Sub FormSchönMachen()
        DatumUndUhrzeitFestlegn()
        ' AnzahlFreiPlätzeBestimmen()
        '    nächstenFilmProKinosaalANzeigen()
        '....
    End Sub

    Private Sub nächstenFilmProKinosaalANzeigen()
        'Dim a() As Tagesplan = DASKINO.getTagesplan 'pro Kinosaal 7 (wird noch umgesetzt) also später dann erst den Tag rausfinden und dann von dem Tagesplan den nächsten FIlm nehmen und wenn alle durch, dann entweder vom nächsten Tag oder Anzeigen für heute keine mehr
        'For i = 0 To DASKINO.getTagesplan.GetLength(0) - 1
        '    labelNächsterFilmBerechnen(i, a(i).getNächstenFilm(Now))
        'Next
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
        'Dim a() As Kinosaal = DASKINO.getKinosäle
        'For i = 0 To DASKINO.getKinosäle().GetLength(0) - 1
        '    If a(i).getAnzahlFreiPlätze > 0 Then
        '        LabelFreiPlätzeberechnen(i, 0, a(i).getAnzahlFreiPlätze, a(i).getAnzahlSitzplätze)
        '    ElseIf a(i).getAnzahlFreiPlätze / a(i).getAnzahlSitzplätze < 0.2 Then
        '        LabelFreiPlätzeberechnen(i, 2, a(i).getAnzahlFreiPlätze, a(i).getAnzahlSitzplätze)
        '    Else
        '        LabelFreiPlätzeberechnen(i, 1, a(i).getAnzahlFreiPlätze, a(i).getAnzahlSitzplätze)
        '    End If
        'Next
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


    Private Sub cmdTestVorstellung_Click(sender As Object, e As EventArgs) Handles cmdTestVorstellung.Click
        Call Form3.Show()

    End Sub

    Private Sub cmdBuchungStonieren_Click(sender As Object, e As EventArgs) Handles cmdBuchungStonieren.Click
        If cmdBuchungStonieren.FlatStyle = FlatStyle.Popup Then
            cmdBuchungStonieren.FlatStyle = FlatStyle.Flat
            cmdBuchungStonieren.FlatAppearance.BorderColor = Color.Black
            cmdNeueBuchung.FlatStyle = FlatStyle.Popup
        Else
            cmdBuchungStonieren.FlatStyle = FlatStyle.Popup
            cmdBuchungStonieren.BackColor = Color.Lime
            cmdBuchungStonieren.FlatAppearance.BorderSize = 1
            cmdNeueBuchung.FlatStyle = FlatStyle.Flat
            cmdNeueBuchung.FlatAppearance.BorderColor = Color.Black

        End If
    End Sub


End Class
﻿Imports Kinoticketsystem

Public Class KinoGUI 'Label1, txtTageseinnahmen und lblFreiePlätzeFarbe1 Unötig(Werden nicht gebraucht)
    Public DASKINO As Kino

    'Public alleFilme As ArrayList = New ArrayList() 'eigentlich sollte das hier nicht extra gespeichert werden, sondern in DASKINO
    'Public alleKunden As ArrayList = New ArrayList() 'eigentlich sollte das hier nicht extra gespeichert werden, sondern in DASKINO
    Private _AnzahlKinos As Integer = 6
    Public _WochenpläneBearbeiten As Boolean
    Public _Buchung As Boolean = True
    Public _ausgewählterKunde As Kunde
    Public _GeldInKasse As Double = 10
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
        KinosaalGUI._Buchen = True

        If NumericUpDown1.Value = 1 Then
            Dim a As Kinosaal = New Kinosaal(120, 8, 15)
            KinosaalGUI.Aufrufen(a)
            KinosaalGUI.BringToFront()
            KinosaalGUI.Show()

        ElseIf NumericUpDown1.Value = 2 Then
            Dim a As Kinosaal = New Kinosaal(60, 6, 10)
            KinosaalGUI.Aufrufen(a)
            KinosaalGUI.BringToFront()
            KinosaalGUI.Show()
        ElseIf NumericUpDown1.Value = 3 Then
            Dim a As Kinosaal = New Kinosaal(75, 5, 15)
            KinosaalGUI.Aufrufen(a)
            KinosaalGUI.BringToFront()
            KinosaalGUI.Show()
        ElseIf NumericUpDown1.Value = 4 Then
            Dim a As Kinosaal = New Kinosaal(40, 5, 8)
            KinosaalGUI.Aufrufen(a)
            KinosaalGUI.BringToFront()
            KinosaalGUI.Show()
        ElseIf NumericUpDown1.Value = 5 Then
            Dim a As Kinosaal = New Kinosaal(98, 7, 14)
            KinosaalGUI.Aufrufen(a)
            KinosaalGUI.BringToFront()
            KinosaalGUI.Show()
        ElseIf NumericUpDown1.Value = 6 Then
            Dim a As Kinosaal = New Kinosaal(50, 5, 10)



            KinosaalGUI.Aufrufen(a)
            KinosaalGUI.BringToFront()
            KinosaalGUI.Show()
        End If
        KinosaalGUI.cmdFertig.Hide()
        KinosaalGUI.lblAnzahlAusgewähltePlätze.Hide()
        KinosaalGUI.lblPreis.Hide()
    End Sub


    Private Sub cmdNeueBuchung_Click(sender As Object, e As EventArgs) Handles cmdNeueBuchung.Click
        ' FTagesplan.BringToFront()
        ' FTagesplan.Visible = True
        If cmdNeueBuchung.FlatStyle = FlatStyle.Popup Then
            cmdNeueBuchung.FlatStyle = FlatStyle.Flat
            cmdNeueBuchung.FlatAppearance.BorderColor = Color.Red
            cmdBuchungStonieren.FlatAppearance.BorderColor = Color.Black

            cmdBuchungStonieren.FlatStyle = FlatStyle.Popup
            _Buchung = True
            FTagesplan._Stornieren = False
        Else
            cmdNeueBuchung.FlatStyle = FlatStyle.Popup
            ' cmdNeueBuchung.BackColor = Color.Lime
            cmdNeueBuchung.FlatAppearance.BorderSize = 1
            cmdBuchungStonieren.FlatStyle = FlatStyle.Flat
            cmdNeueBuchung.FlatAppearance.BorderColor = Color.Black
            cmdBuchungStonieren.FlatAppearance.BorderColor = Color.Red

            _Buchung = False
            FTagesplan._Stornieren = True
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
        If alleFilme.Count >= 4 And alleFilme.Count Mod 4 = 0 Then 'erstellt nur neue Filme aus dem Strings der Textdatei, wenn mindesten 4 Elemente in der Liste ist und die Anzahl der Elemente ein Vielfaches von 4 ist
            For i = 0 To ((alleFilme.Count / 4) - 1)
                Dim k As Integer = i
                Filmtitel = alleFilme(i * 4 + 0)
                Filmlänge = alleFilme(i * 4 + 1)
                Altersfreigabe = alleFilme(i * 4 + 2)
                If alleFilme(i * 4 + 3) = "True" Then
                    ist3D = True
                Else
                    ist3D = False
                End If
                'alleFilme2.Add(New Film(Filmtitel, Filmlänge, Altersfreigabe, ist3D))
                DASKINO.FilmHinzufügen(New Film(Filmtitel, Filmlänge, Altersfreigabe, ist3D))
            Next
        End If

        'My.Computer.FileSystem.WriteAllText("Filme.txt", "", True) ' löscht den Inhalt der Datei 
        'System.IO.File.WriteAllText("Filme.txt", String.Empty)

        FileOpen(1, "Kunden.txt", OpenMode.Input)
        While Not EOF(1)
            alleKunden.Add(LineInput(1))
            Console.WriteLine()
        End While
        FileClose(1)
        For i = 0 To alleKunden.Count - 1
            'alleKunden2.Add(New Kunde(alleKunden(i)))
            DASKINO.KundenHinzufügen(New Kunde(alleKunden(i)))
        Next

        'My.Computer.FileSystem.WriteAllText("Kunden.txt", "", True) ' löscht den Inhalt der Datei 
        'System.IO.File.WriteAllText("Kunden.txt", String.Empty)

        FileOpen(1, "Kinosäle.txt", OpenMode.Input)
        While Not EOF(1)
            alleKinosäle.Add(LineInput(1))
            Console.WriteLine()
        End While
        FileClose(1)
        Dim Sitzplätze As Integer
        Dim Reihen As Integer
        Dim SitzeproReihe As Integer
        If alleKinosäle.Count >= 4 And alleKinosäle.Count Mod 4 = 0 Then
            For i = 0 To ((alleKinosäle.Count / 4) - 1)
                Sitzplätze = alleKinosäle(i * 4 + 1)
                Reihen = alleKinosäle(i * 4 + 2)
                SitzeproReihe = alleKinosäle(i * 4 + 3)
                'alleKinosäle2.Add(New Kinosaal(Sitzplätze, Reihen, SitzeproReihe))
                DASKINO.KinosaalAmEndeHinzufügen(New Kinosaal(Sitzplätze, Reihen, SitzeproReihe))
            Next
        End If

        'My.Computer.FileSystem.WriteAllText("Kinosäle.txt", "", True) ' löscht den Inhalt der Datei
        'System.IO.File.WriteAllText("Kinosäle.txt", String.Empty)

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
        Dim planplätze As Integer
        Dim planreihen As Integer
        Dim plansitzeproreihe As Integer


        If alleTagespläne.Count >= 11 And alleTagespläne.Count Mod 11 = 0 Then
            For i = 0 To (alleTagespläne.Count / 11)
                If i = (alleTagespläne.Count / 11) Then
                    Dim plan As Tagesplan = New Tagesplan
                    For j = 0 To alleVorstellungen.Count - 1
                        plan.VorstellungHinzufügen(alleVorstellungen(j))
                    Next
                    alleTagespläne2.Add(plan)
                    alleVorstellungen.Clear()
                    Exit For
                End If
                If alleTagespläne(i * 11 + 0).contains("Tag") And i > 0 Then

                    Dim plan As Tagesplan = New Tagesplan
                    For j = 0 To alleVorstellungen.Count - 1
                        plan.VorstellungHinzufügen(alleVorstellungen(j))

                    Next
                    'tag = alleTagespläne(i * 11 + 0).char(0)
                    'plan.setTag(tag)
                    alleTagespläne2.Add(plan)
                    alleVorstellungen.Clear()
                End If

                Anfangszeit = alleTagespläne(i * 11 + 2)
                Endzeit = alleTagespläne(i * 11 + 3)
                vorgestellterFilm = alleTagespläne(i * 11 + 4)
                Vorstellungslänge = alleTagespläne(i * 11 + 5)
                Vorstellungsfreigabe = alleTagespläne(i * 11 + 6)
                If alleTagespläne(i * 11 + 7) = "True" Then
                    Dimension = True
                Else
                    Dimension = False
                End If
                planplätze = alleTagespläne(i * 11 + 8)
                planreihen = alleTagespläne(i * 11 + 9)
                plansitzeproreihe = alleTagespläne(i * 11 + 10)

                Dim Film As New Film(vorgestellterFilm, Vorstellungslänge, Vorstellungsfreigabe, Dimension)
                Dim saal As New Kinosaal(planplätze, planreihen, plansitzeproreihe)
                alleVorstellungen.Add(New Vorstellung(Anfangszeit, Endzeit, leereListe, Film, saal))

            Next
        End If

        DASKINO.setTagesplan(alleTagespläne2)

        'My.Computer.FileSystem.WriteAllText("Tagespläne.txt", "", True) ' löscht den Inhalt der Datei
        'System.IO.File.WriteAllText("Tagespläne.txt", String.Empty)

        FormSchönMachen()
    End Sub

    Private Sub cmdBeenden_Click(sender As Object, e As EventArgs) Handles cmdBeenden.Click

        System.IO.File.WriteAllText("Filme.txt", String.Empty)
        System.IO.File.WriteAllText("Kunden.txt", String.Empty)
        System.IO.File.WriteAllText("Kinosäle.txt", String.Empty)
        System.IO.File.WriteAllText("Tagespläne.txt", String.Empty)

        ' Der Inhalt der Dateien wird erst gelöscht kurz bevor sie neu beschrieben werden, so bleibt der Inhalt im Falle eines Crashes oder bei "Throw Exceptions" bestehen


        'Einfügen in die Textdateien wenn das Programm beendet wird 
        Dim titel As New ArrayList
        Dim säle As New ArrayList
        Dim pläne As New ArrayList
        Dim kunden As New ArrayList
        Dim zwKunde As Kunde
        Dim anzahlKinos As Integer
        titel = DASKINO.getFilmtitel
        säle = DASKINO.getKinosäle
        pläne = DASKINO.getTagesplan
        kunden = DASKINO.getKunden
        anzahlKinos = DASKINO.getAnzahlKinosäle
        Dim neuertext As String
        If kunden.Count > 0 Then
            For i = 0 To kunden.Count - 1
                zwKunde = kunden(i)
                neuertext = zwKunde.getName
                FileOpen(1, "Kunden.txt", OpenMode.Append)
                PrintLine(1, neuertext)
                FileClose(1)
                'Dim file1 As System.IO.StreamWriter
                'file1 = My.Computer.FileSystem.OpenTextFileWriter("Kunden.txt", True)
                'file1.WriteLine(neuertext)
                'file1.Close()
            Next
        End If
        If titel.Count > 0 Then
            For j = 0 To titel.Count - 1
                'neuertext = titel(j).getFilmtitel & ": Spieldauer: " & titel(j).getFilmlänge & " Altersfreigabe: " & titel(j).getAltersfreigabe & " 3D? " & titel(j).ist3D
                FileOpen(1, "Filme.txt", OpenMode.Append)
                PrintLine(1, titel(j).getFilmtitel)
                PrintLine(1, titel(j).getFilmlänge)
                PrintLine(1, titel(j).getAltersfreigabe)
                If titel(j).ist3D = True Then
                    PrintLine(1, "True")
                Else
                    PrintLine(1, "False")
                End If
                FileClose(1)
                'Dim file2 As System.IO.StreamWriter
                'file2 = My.Computer.FileSystem.OpenTextFileWriter("Filme.txt", True)
                'file2.WriteLine(titel(j).getFilmtitel & ": Spieldauer: " & titel(j).getFilmlänge & " Altersfreigabe: " & titel(j).getAltersfreigabe & " 3D? " & titel(j).ist3D)
                'file2.Close()
            Next
        End If
        If anzahlKinos > 0 Then
            For k = 0 To anzahlKinos - 1
                FileOpen(1, "Kinosäle.txt", OpenMode.Append)
                'PrintLine(1, "Kinosaal" & k & ": Anzahl Sitzplätze: " & Kinosäle(k).getAnzahlSitzplätze & " Anzahl der Reihen: " & Kinosäle(k).getAnzahlReihe & " Sitzplätze pro Reihe: " & Kinosäle(k).getSitzeProReihe)
                PrintLine(1, k + 1 & ". Kinosaal:")
                PrintLine(1, säle(k).getAnzahlSitzplätze)
                PrintLine(1, säle(k).getAnzahlReihe)
                PrintLine(1, säle(k).getSitzeProReihe)
                FileClose(1)
                '    Dim file3 As System.IO.StreamWriter
                '    file3 = My.Computer.FileSystem.OpenTextFileWriter("Kinosäle.txt", True)
                '    file3.WriteLine("Kinosaal" & k & ": Anzahl Sitzplätze: " & Kinosäle(k).getAnzahlSitzplätze & " Anzahl der Reihen: " & Kinosäle(k).getAnzahlReihe & " Sitzplätze pro Reihe: " & Kinosäle(k).getSitzeProReihe)
                '    file3.Close()
            Next
        End If
        If pläne.Count > 0 Then
            For i = 0 To pläne.Count - 1
                Dim plan As Tagesplan = pläne(i)
                Dim AnzahlVorstellungen As Integer = plan.getAnzahlVorstellungen
                'Dim file4 As System.IO.StreamWriter
                'file4 = My.Computer.FileSystem.OpenTextFileWriter("Tagespläne.txt", True)
                'FileOpen(1, "Tagespläne.txt", OpenMode.Append)
                ''file4.WriteLine(i + 1 & ". Tag:")
                'PrintLine(1, i+1 & ". Tag:")
                'FileClose(1)
                For j = 1 To AnzahlVorstellungen
                    Dim Vorstellung As Vorstellung = plan.getVorstellung(j)
                    FileOpen(1, "Tagespläne.txt", OpenMode.Append)
                    If j = 1 Then
                        PrintLine(1, i + 1 & ". Tag")
                    Else
                        PrintLine(1, i + 1)
                    End If

                    'PrintLine(1, "Vorstellung " & j & ": " & Vorstellung.getAnfangszeit() & " bis " & Vorstellung.getEndzeit() & " : " & Vorstellung.getFilm.getFilmtitel() & " Saal: 1")
                    PrintLine(1, j & ". Vorstellung:")
                    PrintLine(1, Vorstellung.getAnfangszeit())
                    PrintLine(1, Vorstellung.getEndzeit())
                    PrintLine(1, Vorstellung.getFilm.getFilmtitel())
                    PrintLine(1, Vorstellung.getFilm.getFilmlänge)
                    PrintLine(1, Vorstellung.getFilm.getAltersfreigabe)
                    PrintLine(1, Vorstellung.getFilm.Ist3D)
                    PrintLine(1, Vorstellung.getSaal.getAnzahlSitzplätze)
                    PrintLine(1, Vorstellung.getSaal.getAnzahlReihe)
                    PrintLine(1, Vorstellung.getSaal.getSitzeProReihe)
                    FileClose(1)


                    '    'file4.WriteLine(i & ". Tag:")
                    '    file4.WriteLine("Vorstellung " & j & " geht von " & Vorstellung.getAnfangszeit() & " bis " & Vorstellung.getEndzeit() & ", es läuft " & Vorstellung.getFilm.getFilmtitel() & " (" & Vorstellung.getFilm.getFilmlänge & ") ab " & Vorstellung.getFilm.getAltersfreigabe & " 3D: " & Vorstellung.getFilm.Ist3D & " Saal 1")

                Next
                'file4.Close()
            Next
        End If
        Me.Close()
    End Sub

    'Private Sub KinoGUIclose(sender As Object, e As EventArgs) Handles Me.Load

    'End Sub

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
            a.Add(New Kinosaal(60, 6, 10)) 'film fehlt 
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
            z.TagesplanErstellen3(New Vorstellung(0, 120, New ArrayList, c, New Kinosaal(60, 6, 10)), New Vorstellung(130, 250, New ArrayList, c, New Kinosaal(60, 6, 10)), New Vorstellung(260, 380, New ArrayList, c, New Kinosaal(60, 6, 10)))
            tagesplänesdv.Add(z)
        Next
        DASKINO = New Kino(6, New ArrayList, New ArrayList, tagesplänesdv, a)


        ' provisorisch geändert, um Fehler zu vermeiden 


    End Sub

    Private Sub FormSchönMachen()
        DatumUndUhrzeitFestlegn()
        If cmdNeueBuchung.FlatStyle = FlatStyle.Popup Then
            cmdNeueBuchung.FlatStyle = FlatStyle.Flat
            cmdNeueBuchung.FlatAppearance.BorderColor = Color.Black
            cmdBuchungStonieren.FlatStyle = FlatStyle.Popup
        Else
            cmdNeueBuchung.FlatStyle = FlatStyle.Popup
            cmdNeueBuchung.BackColor = Color.White
            cmdNeueBuchung.FlatAppearance.BorderSize = 1
            cmdBuchungStonieren.FlatStyle = FlatStyle.Flat
            cmdBuchungStonieren.FlatAppearance.BorderColor = Color.Black

        End If
        If cmdNeueBuchung.FlatStyle = FlatStyle.Popup Then
            cmdNeueBuchung.FlatStyle = FlatStyle.Flat
            cmdNeueBuchung.FlatAppearance.BorderColor = Color.Black
            cmdBuchungStonieren.FlatStyle = FlatStyle.Popup
        Else
            cmdNeueBuchung.FlatStyle = FlatStyle.Popup
            cmdNeueBuchung.BackColor = Color.White
            cmdNeueBuchung.FlatAppearance.BorderSize = 1
            cmdBuchungStonieren.FlatStyle = FlatStyle.Flat
            cmdBuchungStonieren.FlatAppearance.BorderColor = Color.Black

        End If
        AnzahlFreiPlätzeBestimmen()
        nächstenFilmProKinosaalANzeigen()
        '....
        NumericUpDown1.Maximum = 6
        NumericUpDown1.Minimum = 1
        NumericUpDown1.Value = 1
        lblTageseinnahmen.Text = "Geld in Kasse: " & Math.Round(_GeldInKasse, 2) & "€"
    End Sub

    Private Sub nächstenFilmProKinosaalANzeigen()
        'Dim a() As Tagesplan = DASKINO.getTagesplan 'pro Kinosaal 7 (wird noch umgesetzt) also später dann erst den Tag rausfinden und dann von dem Tagesplan den nächsten FIlm nehmen und wenn alle durch, dann entweder vom nächsten Tag oder Anzeigen für heute keine mehr
        'For i = 0 To DASKINO.getTagesplan.GetLength(0) - 1
        '    labelNächsterFilmBerechnen(i, a(i).getNächstenFilm(Now))
        'Next
        Dim a As ArrayList = DASKINO.getTagesplan

        labelNächsterFilmBerechnen(0, a(0).getNächstenFilm(TimeOfDay))
        labelNächsterFilmBerechnen(1, a(7).getNächstenFilm(TimeOfDay))
        labelNächsterFilmBerechnen(2, a(13).getNächstenFilm(TimeOfDay))
        labelNächsterFilmBerechnen(3, a(19).getNächstenFilm(TimeOfDay))
        labelNächsterFilmBerechnen(4, a(25).getNächstenFilm(TimeOfDay))
        labelNächsterFilmBerechnen(5, a(31).getNächstenFilm(TimeOfDay))

        'For i = 0 To a.Count - 1 Step 7
        '    labelNächsterFilmBerechnen((i / 7), a(i).getNächstenFilm(TimeOfDay))
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

    Public Sub AnzahlFreiPlätzeBestimmen()
        Dim a As ArrayList = DASKINO.getTagesplan
        Dim b As Vorstellung = a(0).getNächstenFilm(TimeOfDay)

        If b.getSaal.getAnzahlFreiPlätze > 0 Then
            LabelFreiPlätzeberechnen(0, 0, b.getSaal.getAnzahlFreiPlätze, b.getSaal.getAnzahlSitzplätze)
        ElseIf a(0).getNächstenFilm.getSaal.getAnzahlFreiPlätze / a(0).getAnzahlSitzplätze < 0.2 Then
            LabelFreiPlätzeberechnen(0, 2, b.getSaal.getAnzahlFreiPlätze, b.getSaal.getAnzahlSitzplätze)
        Else
            LabelFreiPlätzeberechnen(0, 1, b.getSaal.getAnzahlFreiPlätze, b.getSaal.getAnzahlSitzplätze)
        End If
        Dim zählvariable As Integer = 1
        For i = 7 To a.Count - 1 Step 6
            b = a(i).getNächstenFilm(TimeOfDay)
            If b.getSaal.getAnzahlFreiPlätze > 0 Then
                LabelFreiPlätzeberechnen(zählvariable, 0, b.getSaal.getAnzahlFreiPlätze, b.getSaal.getAnzahlSitzplätze)
            ElseIf b.getSaal.getAnzahlFreiPlätze / b.getSaal.getAnzahlSitzplätze < 0.2 And b.getSaal.getAnzahlFreiPlätze / b.getSaal.getAnzahlSitzplätze > 0 Then
                LabelFreiPlätzeberechnen(zählvariable, 2, b.getSaal.getAnzahlFreiPlätze, b.getSaal.getAnzahlSitzplätze)
            Else
                LabelFreiPlätzeberechnen(zählvariable, 1, b.getSaal.getAnzahlFreiPlätze, b.getSaal.getAnzahlSitzplätze)
            End If
            zählvariable += 1
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
        FTagesplan.SetKinosaal((DASKINO.getKinosäle(0)))
        'so müsste es laufen, wenn 3D arraylist,  besser wäre eigentlich array!!!!
        Dim a As ArrayList = DASKINO.getTagesplan

        FTagesplan.InitialisiereDenWochenplan(_ausgewählterKunde, 1, _WochenpläneBearbeiten, a(0), a(1), a(2), a(3), a(4), a(5), a(6))
        ' FTagesplan.SetKinosaal(DASKINO.getKinosäle(0)) 'muss wieder auskommentiert werden, wenn es Kinosäle gibt
        'Veranstaltungen übergeben
        'FTagesplan.
    End Sub
    Private Sub cmdWochenplan2_Click(sender As Object, e As EventArgs) Handles cmdWochenplan2.Click
        FTagesplan.BringToFront()
        FTagesplan.Visible = True
        FTagesplan.SetKinosaal((DASKINO.getKinosäle(1)))
        Dim a As ArrayList = DASKINO.getTagesplan

        FTagesplan.InitialisiereDenWochenplan(_ausgewählterKunde, 2, _WochenpläneBearbeiten, a(7), a(8), a(9), a(10), a(11), a(12))

        'Veranstaltungen übergeben
        'FTagesplan.
    End Sub

    Private Sub cmdWochenplan3_Click(sender As Object, e As EventArgs) Handles cmdWochenplan3.Click
        FTagesplan.BringToFront()
        FTagesplan.Visible = True
        FTagesplan.SetKinosaal((DASKINO.getKinosäle(2)))
        Dim a As ArrayList = DASKINO.getTagesplan

        FTagesplan.InitialisiereDenWochenplan(_ausgewählterKunde, 3, _WochenpläneBearbeiten, a(13), a(14), a(15), a(16), a(17), a(18))


        'Veranstaltungen übergeben
        'FTagesplan.
    End Sub

    Private Sub cmdWochenplan4_Click(sender As Object, e As EventArgs) Handles cmdWochenplan4.Click
        FTagesplan.BringToFront()
        FTagesplan.Visible = True
        FTagesplan.SetKinosaal((DASKINO.getKinosäle((3))))
        Dim a As ArrayList = DASKINO.getTagesplan

        FTagesplan.InitialisiereDenWochenplan(_ausgewählterKunde, 4, _WochenpläneBearbeiten, a(19), a(20), a(21), a(22), a(23), a(24))


        'Veranstaltungen übergeben
        'FTagesplan.
    End Sub

    Private Sub cmdWochenplan5_Click(sender As Object, e As EventArgs) Handles cmdWochenplan5.Click
        FTagesplan.BringToFront()
        FTagesplan.Visible = True
        FTagesplan.SetKinosaal((DASKINO.getKinosäle(4)))
        Dim a As ArrayList = DASKINO.getTagesplan

        FTagesplan.InitialisiereDenWochenplan(_ausgewählterKunde, 5, _WochenpläneBearbeiten, a(25), a(26), a(27), a(28), a(29), a(30))


        'Veranstaltungen übergeben
        'FTagesplan.
    End Sub

    Private Sub cmdWochenplan6_Click(sender As Object, e As EventArgs) Handles cmdWochenplan6.Click
        FTagesplan.BringToFront()
        FTagesplan.Visible = True
        FTagesplan.SetKinosaal((DASKINO.getKinosäle(5)))
        Dim a As ArrayList = DASKINO.getTagesplan

        FTagesplan.InitialisiereDenWochenplan(_ausgewählterKunde, 6, _WochenpläneBearbeiten, a(31), a(32), a(33), a(34), a(35), a(36))


        'Veranstaltungen übergeben
        'FTagesplan.
    End Sub


    Private Sub cmdTestVorstellung_Click(sender As Object, e As EventArgs) Handles cmdTestVorstellung.Click
        Call Form3.Show()

    End Sub

    Private Sub cmdBuchungStonieren_Click(sender As Object, e As EventArgs) Handles cmdBuchungStonieren.Click
        If cmdBuchungStonieren.FlatStyle = FlatStyle.Popup Then
            cmdBuchungStonieren.FlatStyle = FlatStyle.Flat
            cmdBuchungStonieren.FlatAppearance.BorderColor = Color.Red
            cmdNeueBuchung.FlatStyle = FlatStyle.Popup
            cmdNeueBuchung.FlatAppearance.BorderColor = Color.Black

            _Buchung = False
            FTagesplan._Stornieren = True
        Else
            cmdBuchungStonieren.FlatStyle = FlatStyle.Popup
            'cmdBuchungStonieren.BackColor = Color.Lime
            cmdBuchungStonieren.FlatAppearance.BorderSize = 1
            cmdNeueBuchung.FlatStyle = FlatStyle.Flat
            cmdNeueBuchung.FlatAppearance.BorderColor = Color.Red
            cmdBuchungStonieren.FlatAppearance.BorderColor = Color.Black

            _Buchung = True
            FTagesplan._Stornieren = False
        End If
    End Sub

    Private Sub cmdFilmHinzufügen_Click(sender As Object, e As EventArgs) Handles cmdFilmHinzufügen.Click
        FilmHinzufügenGUI.Show()
        FilmHinzufügenGUI.BringToFront()

        'Dim a As ArrayList = DASKINO.getFilmtitel()
        'For i = 0 To DASKINO.getFilmtitel.Count - 1 '-1 richtig?
        '    KundenGUI.lstSammlung.Items.Add(a(i))
        'Next
    End Sub

    Private Sub cmdKundenDatenbankAufrufen_Click(sender As Object, e As EventArgs) Handles cmdKundenDatenbankAufrufen.Click

        KundenGUI.Show()
        KundenGUI.BringToFront()
        'KundenGUI.lstSammlung.Items.Clear()
        'Dim a As ArrayList = DASKINO.getKunden
        'For i = 0 To DASKINO.getKunden.Count - 1 '-1 richtig?
        '    KundenGUI.lstSammlung.Items.Add(a(i).getName)
        'Next
    End Sub

    Private Sub cmdVorstellungErstellen_Click(sender As Object, e As EventArgs) Handles cmdVorstellungErstellen.Click
        NeueVorstellung.Show()
        NeueVorstellung.BringToFront()
        NeueVorstellung.chlBesucherAuswählen.Items.Clear()
        Dim a As ArrayList = DASKINO.getKunden
        For i = 0 To DASKINO.getKunden.Count - 1 '-1 richtig?
            NeueVorstellung.chlBesucherAuswählen.Items.Add(a(i).getName)
        Next
        NeueVorstellung.chlFilme.Items.Clear()
        Dim b As ArrayList = DASKINO.getFilmtitel
        For i = 0 To DASKINO.getFilmtitel.Count - 1 '-1 richtig?
            NeueVorstellung.chlFilme.Items.Add(b(i).getFilmtitel)
        Next

    End Sub

    Private Sub cmdWochenpläneBearbeiten_Click(sender As Object, e As EventArgs) Handles cmdWochenpläneBearbeiten.Click
        If cmdWochenpläneBearbeiten.FlatStyle = FlatStyle.Popup Then
            _WochenpläneBearbeiten = True
            cmdWochenpläneBearbeiten.FlatStyle = FlatStyle.Flat
            cmdWochenpläneBearbeiten.FlatAppearance.BorderColor = Color.Red
            ' cmdWochenpläneBearbeiten.FlatAppearance.BorderSize = 3
            FTagesplan._Aendern = True
            FTagesplan.ButtonsInvisibleMachenJeNachModus()
            FTagesplan.Text = "Wochenplan - Änderungsmodus"
            FTagesplan.cmdBuchenStattändern.Text = "buchen"
            If FTagesplan._Stornieren Then
                FTagesplan.cmdBuchenStattändern.Text = "stornieren"
            Else
                FTagesplan.cmdBuchenStattändern.Text = "buchen"
            End If
        Else
            _WochenpläneBearbeiten = False
            cmdWochenpläneBearbeiten.FlatStyle = FlatStyle.Popup
            cmdWochenpläneBearbeiten.FlatAppearance.BorderSize = 1
            FTagesplan._Aendern = False
            FTagesplan.cmdBuchenStattändern.Text = "ändern"
            FTagesplan.VeränderungenJeNachSornierenBuchen()
            FTagesplan.ButtonsInvisibleMachenJeNachModus()
        End If
    End Sub

    Private Sub cmdTestTagesplan_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmdNeuerKinosaal_Click(sender As Object, e As EventArgs) Handles cmdNeuerKinosaal.Click
        KinosaalHinzufügenGUI.Show()
        KinosaalHinzufügenGUI.BringToFront()

    End Sub


    Private Sub cmdÄnderungenSpeichern_Click(sender As Object, e As EventArgs) Handles cmdÄnderungenSpeichern.Click

        ' Die neueingegebenen Daten werden in den Satein gespeichert, ohne dass das Programm beendet wird 

        System.IO.File.WriteAllText("Filme.txt", String.Empty)
        System.IO.File.WriteAllText("Kunden.txt", String.Empty)
        System.IO.File.WriteAllText("Kinosäle.txt", String.Empty)
        System.IO.File.WriteAllText("Tagespläne.txt", String.Empty)

        ' Der Inhalt der Dateien wird erst gelöscht kurz bevor sie neu beschrieben werden, so bleibt der Inhalt im Falle eines Crashes oder bei "Throw Exceptions" bestehen


        'Einfügen in die Textdateien wenn das Programm beendet wird 
        Dim titel As New ArrayList
        Dim säle As New ArrayList
        Dim pläne As New ArrayList
        Dim kunden As New ArrayList
        Dim zwKunde As Kunde
        Dim anzahlKinos As Integer
        titel = DASKINO.getFilmtitel
        säle = DASKINO.getKinosäle
        pläne = DASKINO.getTagesplan
        kunden = DASKINO.getKunden
        anzahlKinos = DASKINO.getAnzahlKinosäle
        Dim neuertext As String
        If kunden.Count > 0 Then
            For i = 0 To kunden.Count - 1
                zwKunde = kunden(i)
                neuertext = zwKunde.getName
                FileOpen(1, "Kunden.txt", OpenMode.Append)
                PrintLine(1, neuertext)
                FileClose(1)
                'Dim file1 As System.IO.StreamWriter
                'file1 = My.Computer.FileSystem.OpenTextFileWriter("Kunden.txt", True)
                'file1.WriteLine(neuertext)
                'file1.Close()
            Next
        End If
        If titel.Count > 0 Then
            For j = 0 To titel.Count - 1
                'neuertext = titel(j).getFilmtitel & ": Spieldauer: " & titel(j).getFilmlänge & " Altersfreigabe: " & titel(j).getAltersfreigabe & " 3D? " & titel(j).ist3D
                FileOpen(1, "Filme.txt", OpenMode.Append)
                PrintLine(1, titel(j).getFilmtitel)
                PrintLine(1, titel(j).getFilmlänge)
                PrintLine(1, titel(j).getAltersfreigabe)
                If titel(j).ist3D = True Then
                    PrintLine(1, "True")
                Else
                    PrintLine(1, "False")
                End If
                FileClose(1)
                'Dim file2 As System.IO.StreamWriter
                'file2 = My.Computer.FileSystem.OpenTextFileWriter("Filme.txt", True)
                'file2.WriteLine(titel(j).getFilmtitel & ": Spieldauer: " & titel(j).getFilmlänge & " Altersfreigabe: " & titel(j).getAltersfreigabe & " 3D? " & titel(j).ist3D)
                'file2.Close()
            Next
        End If
        If anzahlKinos > 0 Then
            For k = 0 To anzahlKinos - 1
                FileOpen(1, "Kinosäle.txt", OpenMode.Append)
                'PrintLine(1, "Kinosaal" & k & ": Anzahl Sitzplätze: " & Kinosäle(k).getAnzahlSitzplätze & " Anzahl der Reihen: " & Kinosäle(k).getAnzahlReihe & " Sitzplätze pro Reihe: " & Kinosäle(k).getSitzeProReihe)
                PrintLine(1, k + 1 & ". Kinosaal:")
                PrintLine(1, säle(k).getAnzahlSitzplätze)
                PrintLine(1, säle(k).getAnzahlReihe)
                PrintLine(1, säle(k).getSitzeProReihe)
                FileClose(1)
                '    Dim file3 As System.IO.StreamWriter
                '    file3 = My.Computer.FileSystem.OpenTextFileWriter("Kinosäle.txt", True)
                '    file3.WriteLine("Kinosaal" & k & ": Anzahl Sitzplätze: " & Kinosäle(k).getAnzahlSitzplätze & " Anzahl der Reihen: " & Kinosäle(k).getAnzahlReihe & " Sitzplätze pro Reihe: " & Kinosäle(k).getSitzeProReihe)
                '    file3.Close()
            Next
        End If
        If pläne.Count > 0 Then
            For i = 0 To pläne.Count - 1
                Dim plan As Tagesplan = pläne(i)
                Dim AnzahlVorstellungen As Integer = plan.getAnzahlVorstellungen
                'Dim file4 As System.IO.StreamWriter
                'file4 = My.Computer.FileSystem.OpenTextFileWriter("Tagespläne.txt", True)
                'FileOpen(1, "Tagespläne.txt", OpenMode.Append)
                ''file4.WriteLine(i + 1 & ". Tag:")
                'PrintLine(1, i+1 & ". Tag:")
                'FileClose(1)
                For j = 1 To AnzahlVorstellungen
                    Dim Vorstellung As Vorstellung = plan.getVorstellung(j)
                    FileOpen(1, "Tagespläne.txt", OpenMode.Append)
                    If j = 1 Then
                        PrintLine(1, i + 1 & ". Tag")
                    Else
                        PrintLine(1, i + 1)
                    End If

                    'PrintLine(1, "Vorstellung " & j & ": " & Vorstellung.getAnfangszeit() & " bis " & Vorstellung.getEndzeit() & " : " & Vorstellung.getFilm.getFilmtitel() & " Saal: 1")
                    PrintLine(1, j & ". Vorstellung:")
                    PrintLine(1, Vorstellung.getAnfangszeit())
                    PrintLine(1, Vorstellung.getEndzeit())
                    PrintLine(1, Vorstellung.getFilm.getFilmtitel())
                    PrintLine(1, Vorstellung.getFilm.getFilmlänge)
                    PrintLine(1, Vorstellung.getFilm.getAltersfreigabe)
                    PrintLine(1, Vorstellung.getFilm.Ist3D)
                    PrintLine(1, Vorstellung.getSaal.getAnzahlSitzplätze)
                    PrintLine(1, Vorstellung.getSaal.getAnzahlReihe)
                    PrintLine(1, Vorstellung.getSaal.getSitzeProReihe)
                    FileClose(1)


                    '    'file4.WriteLine(i & ". Tag:")
                    '    file4.WriteLine("Vorstellung " & j & " geht von " & Vorstellung.getAnfangszeit() & " bis " & Vorstellung.getEndzeit() & ", es läuft " & Vorstellung.getFilm.getFilmtitel() & " (" & Vorstellung.getFilm.getFilmlänge & ") ab " & Vorstellung.getFilm.getAltersfreigabe & " 3D: " & Vorstellung.getFilm.Ist3D & " Saal 1")

                Next
                'file4.Close()
            Next
        End If
    End Sub
End Class
Public Class KinoGUI 'Label1, txtTageseinnahmen und lblFreiePlätzeFarbe1 Unötig(Werden nicht gebraucht)
    Private DASKINO As Kino
    Public alleFilme As ArrayList = New ArrayList()
    Public alleKunden As ArrayList = New ArrayList()
    Public alleKinosäle As ArrayList = New ArrayList()
    Public alleTagespläne As ArrayList = New ArrayList()
    Public dasMegaKino As Kino


    Private Sub cmdWochenplan_Click(sender As Object, e As EventArgs) Handles cmdWochenplan1.Click
        FTagesplan.BringToFront()
        FTagesplan.Visible = True
    End Sub

    Private Sub cmdTexterfassenErik_Click(sender As Object, e As EventArgs) Handles cmdTexterfassen.Click 'cmdTexterfassen nicht mehr vorhanden(Neuer Button)
        TexterfassenTest.BringToFront()
        TexterfassenTest.Visible = True
    End Sub

    'Private Sub KinoGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    'Auslesen
    'DASKINO=New Kino(...,....,...,..,..)
    'End Sub

    Private Sub cmdkinosaalAufrufen_Click(sender As Object, e As EventArgs) Handles cmdkinosaalAufrufen.Click
        KinosaalGUI.BringToFront()
        KinosaalGUI.Show()
    End Sub



    Private Sub cmdTestKinosaal_Click(sender As Object, e As EventArgs)
        KinosaalTest.BringToFront()
        KinosaalTest.Show()
    End Sub

    Private Sub cmdNeueBuchung_Click(sender As Object, e As EventArgs) Handles cmdNeueBuchung.Click
        FTagesplan.BringToFront()
        FTagesplan.Visible = True
    End Sub

    Private Sub KinoGUI_Load(sender As Object, e As EventArgs) Handles Me.Load
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

        'FileOpen(1, "Tagespläne.txt", OpenMode.Input)
        'While Not EOF(1)
        '    alleTagespläne.Add(LineInput(1))
        '    Console.WriteLine()
        'End While
        'FileClose(1)
        'dasMegaKino = New Kino(alleKinosäle.Count, alleFilme, alleKunden, alleTagespläne, alleKinosäle)



        FormSchönMachen()
    End Sub

    Private Sub FormSchönMachen()
        DatumUndUhrzeitFestlegn()
        '....
    End Sub

    Private Sub DatumUndUhrzeitFestlegn()
        Dim thisDate As Date = Today
        lblDatum.Text = thisDate.ToString(" dd.MM.yy")
        lblUhrzeit.Left = lblDatum.Left + 5
        Timer2.Enabled = False
    End Sub

    Private Sub cmdTestKinotest_Click(sender As Object, e As EventArgs) Handles cmdTestKino.Click 'cmdTestkino nicht mehr vorhanden(Neuer Button)
        Call Testklassekino.Show()

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
End Class
Public Class KinoGUI
    Private DASKINO As Kino
    Public alleFilme As ArrayList = New ArrayList()
    Public alleKunden As ArrayList = New ArrayList()
    Public alleKinosäle As ArrayList = New ArrayList()
    Public alleTagespläne As ArrayList = New ArrayList()
    Public dasMegaKino As Kino


    Private Sub cmdWochenplan_Click(sender As Object, e As EventArgs) Handles cmdWochenplan.Click
        FTagesplan.BringToFront()
        FTagesplan.Visible = True
    End Sub

    Private Sub cmdTexterfassen_Click(sender As Object, e As EventArgs) Handles cmdTexterfassen.Click
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



    Private Sub cmdKinosaalTest_Click(sender As Object, e As EventArgs)
        KinosaalTest.BringToFront()
        KinosaalTest.Show()
    End Sub

    Private Sub cmdNeueBuchung_Click(sender As Object, e As EventArgs) Handles cmdNeueBuchung.Click
        FTagesplan.BringToFront()
        FTagesplan.Visible = True
    End Sub

    Private Sub KinoGUI_Load(sender As Object, e As EventArgs) Handles Me.Load
        FileOpen(1, "Filme.txt", OpenMode.Input)
        While Not EOF(1)
            alleFilme.Add(LineInput(1))
            Console.WriteLine()
        End While
        FileClose(1)

        FileOpen(1, "Kunden.txt", OpenMode.Input)
        While Not EOF(1)
            alleKunden.Add(LineInput(1))
            Console.WriteLine()
        End While
        FileClose(1)

        FileOpen(1, "Kinosäle.txt", OpenMode.Input)
        While Not EOF(1)
            alleKinosäle.Add(LineInput(1))
            Console.WriteLine()
        End While
        FileClose(1)

        FileOpen(1, "Tagespläne.txt", OpenMode.Input)
        While Not EOF(1)
            alleTagespläne.Add(LineInput(1))
            Console.WriteLine()
        End While
        FileClose(1)
        dasMegaKino = New Kino(alleKinosäle.Count, alleFilme, alleKunden, alleTagespläne, alleKinosäle)
    End Sub

    Private Sub cmdTestKino_Click(sender As Object, e As EventArgs) Handles cmdTestKino.Click
        Call Testklassekino.Show()

    End Sub
End Class
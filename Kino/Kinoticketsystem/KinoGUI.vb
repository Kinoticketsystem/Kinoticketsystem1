Public Class KinoGUI
    Private DASKINO As Kino
    Private Sub cmdWochenplan_Click(sender As Object, e As EventArgs) Handles cmdWochenplan.Click
        FTagesplan.BringToFront()
        FTagesplan.Visible = True
    End Sub

    Private Sub cmdTexterfassen_Click(sender As Object, e As EventArgs) Handles cmdTexterfassen.Click
        TexterfassenTest.BringToFront()
        TexterfassenTest.Visible = True
    End Sub

    Private Sub KinoGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Auslesen
        'DASKINO=New Kino(...,....,...,..,..)
    End Sub

    Private Sub cmdkinosaalAufrufen_Click(sender As Object, e As EventArgs) Handles cmdkinosaalAufrufen.Click
        KinosaalGUI.BringToFront()
        KinosaalGUI.Show()
    End Sub
    Private Sub KinosaalTest_load()
    End Sub

    Private Sub cmdKinosaalTest_Click(sender As Object, e As EventArgs) Handles cmdKinosaalTest.Click

        KinosaalTest.BringToFront()
        KinosaalTest.Show()

    End Sub
End Class
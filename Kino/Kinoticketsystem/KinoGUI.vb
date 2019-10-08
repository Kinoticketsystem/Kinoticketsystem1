Public Class KinoGUI
    Private Sub cmdWochenplan_Click(sender As Object, e As EventArgs) Handles cmdWochenplan.Click
        FTagesplan.BringToFront()
        FTagesplan.Visible = True
    End Sub

    Private Sub cmdTexterfassen_Click(sender As Object, e As EventArgs) Handles cmdTexterfassen.Click
        TexterfassenTest.BringToFront()
        TexterfassenTest.Visible = True
    End Sub

End Class
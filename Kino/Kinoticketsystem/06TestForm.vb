Public Class Form3



    Private Sub cmdTestKinosaal_Click(sender As Object, e As EventArgs)
        Static a As Boolean
        Static b As TestKinosaal
        a = b.TestSitzplatzStornieren
        lstAusgabe.Items.Add(a)

        a = b.TestSitzplatzBuchen
        lstAusgabe.Items.Add(a)
    End Sub

    Private Sub cmdTestkinotest_Click_1(sender As Object, e As EventArgs) Handles cmdTestkinotest.Click
        Static a As Boolean
        Static b As Testklassekino
        a = b.NeueBuchung
        lstAusgabeKino.Items.Add(a)
    End Sub

End Class
Public Class KundenGUI
    Private Sub KundenGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub KundenÜbergeben(a As ArrayList)
        For i = 0 To a.Count
            lstSammlung.Items.Add(a)
        Next
    End Sub
End Class
Public Class KundenGUI

    Private Sub KundenGUI_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim name As String = txtName.Text
        Dim a As Kunde = New Kunde(name)
        '  Dim b As ArrayList
    End Sub
    Public Sub KundenÜbergeben(a As ArrayList)

        For i = 0 To a.Count
            lstSammlung.Items.Add(a)
        Next
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub

    Private Sub cmdLöschenHinzufügen_Click(sender As Object, e As EventArgs) Handles cmdLöschenHinzufügen.Click


    End Sub
End Class
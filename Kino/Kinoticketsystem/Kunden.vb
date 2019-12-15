Public Class KundenGUI
    Private name As String



    Private Sub cmdLöschenHinzufügen_Click(sender As Object, e As EventArgs) Handles cmdLöschenHinzufügen.Click
        lstSammlung.Items.Clear()

        If txtName.Text = "" Then
            MsgBox("Name fehlt")
        Else
            name = txtName.Text
            Dim k As Kunde = New Kunde(name)
            KinoGUI.DASKINO.KundenHinzufügen(k)

        End If

        Dim a As ArrayList = KinoGUI.DASKINO.getKunden

        For i As Integer = 0 To KinoGUI.DASKINO.getKunden.Count - 1
            lstSammlung.Items.Add(a(i).getName)
        Next
        MsgBox("Der Kunde wurde erfolgreich hinzugefügt")
    End Sub

End Class
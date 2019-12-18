Public Class KinosaalHinzufügenGUI
    Private Sub cmdKinosaalHinzufügen_Click(sender As Object, e As EventArgs) Handles cmdKinosaalHinzufügen.Click
        If IsNumeric(txtAnzahlReihe.Text) And IsNumeric(txtSitzeproReihe.Text) = True Then
            Dim plätze As Integer
            Dim reihen As Integer = txtAnzahlReihe.Text
            reihen = Math.Abs(reihen)
            Dim sitze As Integer = txtSitzeproReihe.Text
            sitze = Math.Abs(sitze)
            If reihen > 8 Then
                MsgBox("Maximal 8 Reihen!")
            ElseIf sitze > 15 Then
                MsgBox("Maximal 15 Sitze pro Reihe!")
            Else
                plätze = reihen * sitze
                KinoGUI.DASKINO.KinosaalAmEndeHinzufügen(New Kinosaal(plätze, reihen, sitze))
                MsgBox("Der neue Saal wurde hinzugefügt!")
            End If
        Else
            MsgBox("Bitte geben sie Zahlenwerte in die Textfelder ein, um einen neuen Kinosaal zu erstellen!")
        End If

    End Sub
End Class
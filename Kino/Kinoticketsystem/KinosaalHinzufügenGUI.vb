Public Class KinosaalHinzufügenGUI
    Private Sub cmdKinosaalHinzufügen_Click(sender As Object, e As EventArgs) Handles cmdKinosaalHinzufügen.Click
        If IsNumeric(txtAnzahlReihe.Text) And IsNumeric(txtSitzeproReihe.Text) = True Then
            Dim plätze As Integer
            Dim reihen As Integer
            Dim sitze As Integer
            plätze = reihen * sitze
            KinoGUI.DASKINO.KinosaalAmEndeHinzufügen(New Kinosaal(plätze, reihen, sitze))
            MsgBox("Der neue Saal wurde hinzugefügt!")
        Else
            MsgBox("Bitte geben sie Zahlenwerte in die Textfelder ein, um einen neuen Kinosaal zu erstellen!")
        End If

    End Sub
End Class
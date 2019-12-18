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
            MsgBox("Der Kunde wurde erfolgreich hinzugefügt")
        End If

        Dim a As ArrayList = KinoGUI.DASKINO.getKunden

        For i As Integer = 0 To KinoGUI.DASKINO.getKunden.Count - 1
            lstSammlung.Items.Add(a(i).getName)
        Next

    End Sub

    Private Sub cmdKundeEntfernen_Click(sender As Object, e As EventArgs) Handles cmdKundeEntfernen.Click
        Dim i As Integer = lstSammlung.SelectedIndex
        If i >= 0 Then
            Dim f As Kunde = KinoGUI.DASKINO.getKunden(i)
            KinoGUI.DASKINO.KundeEntfernen(f)
            lstSammlung.Items.Clear()
            Dim a As ArrayList = KinoGUI.DASKINO.getKunden()
            For i = 0 To KinoGUI.DASKINO.getKunden.Count - 1
                lstSammlung.Items.Add(a(i).getName)
            Next
        Else
            MsgBox("Zu entfernenden Kunden auswählen")
        End If

    End Sub

    Private Sub KundenGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstSammlung.Items.Clear()
        Dim a As ArrayList = KinoGUI.DASKINO.getKunden()
        For i = 0 To KinoGUI.DASKINO.getKunden.Count - 1
            lstSammlung.Items.Add(a(i).getName)
        Next
    End Sub
End Class
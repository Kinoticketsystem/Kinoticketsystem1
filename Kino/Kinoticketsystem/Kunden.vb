Public Class KundenGUI
    Private name As String
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

    Private Sub cmdLöschenHinzufügen_Click(sender As Object, e As EventArgs) Handles cmdLöschenHinzufügen.Click
        If txtName.Text = "" Then
            MsgBox("Name fehlt")
        Else
            name = txtName.Text
        End If
        Dim k As Kunde = New Kunde(name)
        KinoGUI.DASKINO.KundenHinzufügen(k)
    End Sub
End Class
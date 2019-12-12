Public Class StartBild

    Private i As Integer = 0

    Private Sub StartBild_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        KinoGUI.Activate()
        Cursor.Hide()
        Me.CenterToScreen()
        Me.WindowState = FormWindowState.Maximized

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        i = i + 1
        If i > 6 Then
            Timer1.Stop()
            KinoGUI.Show()
            Me.Close()
            Cursor.Show()
        End If


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
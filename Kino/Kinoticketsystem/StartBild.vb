Public Class StartBild
    Dim i As Integer = 0

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        i = i + 1
        If i > 3 Then
            Timer1.Stop()
            Me.Close()
            KinoGUI.Show()
        End If
    End Sub

End Class
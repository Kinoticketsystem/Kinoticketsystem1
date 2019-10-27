Public Class testkunde


    Private _Name As String = "Peter"

    Public a As Kunde = New Kunde("Bob")
    Public Kundetest As String = "neuerBob"
    Public s As String
    Public i As Integer
    Private Treuepunkte As Integer = 2

    Public Sub _Nametesten()
        a.SetName(_Name)
        s = a.getName
        If Not (_Name.Equals(s)) Then
            Console.WriteLine("fehler Name Kunde")
        End If
    End Sub

    Public Sub Treuepunktetesten()
        a.setTreuepunkte(Treuepunkte)
        i = a.getTreuepunkte
        If Not (Treuepunkte = i) Then
            Console.WriteLine("fehler Treuepunte")
        End If
    End Sub
End Class

Public Class testkunde


    Private _Name As String

    Public a As Kunde = New Kunde("Bob")
    Public Kundetest As String = "neuerBob"
    Public s As String
    Public i As Integer

    Public Sub _Nametesten()
        a.NameÄndern(Name)
        s = a.getName
        If Not (Nametesten.Equals(s)) Then
            Console.WriteLine("fehler Name Kunde")
        End If
    End Sub

    Public Sub Treuepunktetesten()
        a.setTreuepunkte(Treuepunkte)
        i = a.getTreuepunkte
        If Not (Treuepunktetesten.Equals(i)) Then
            Console.WriteLine("fehler Treuepunte")
        End If
    End Sub
End Class

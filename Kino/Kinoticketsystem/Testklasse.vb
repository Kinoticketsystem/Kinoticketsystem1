Public Class kTestklasse566556
    Public _Tagesplan As Tagesplan  = new Tagesplan()
    Public a As Vorstellung = New Vorstellung("dfbg", 23, 12, True, 43)
    Public b As Vorstellung
    'hallo
    Public Sub New 
        
End Sub
        
Public Sub TestFilmHinzufügen()
        _Tagesplan.VorstellungHinzufügen(a)
        b = _Tagesplan.getVorstellung(0)
        If Not (a.Equals(b)) Then
            'in der Konsole sachen ausgeben
            WriteLine("FilmHinzufügen funktioniert nicht")
        End If
    End Sub

End Class

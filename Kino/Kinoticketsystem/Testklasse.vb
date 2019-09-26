Public Class kTestklasse566556
    Public _Tagesplan As Tagesplan  = new Tagesplan()
    Public a As Film = New Film("dfbg",23,12,True ,43)
    Public b As Film
    'hallo
Public Sub New 
        
End Sub
        
Public Sub TestFilmHinzufügen()
        _Tagesplan.FilmHinzufügen(a)
        b = _Tagesplan.getFilm(0)
        If not(a = b) Then
            'in der Konsole sachen ausgeben
            writeLine("FilmHinzufügen funktioniert nicht")
        End if
End Sub

End Class

Public Class Testklassekino

    ' Private _Kino As Kino = New Kino()

    Private _Kinosäle() As Kinosaal 'Array, für mehrere Kinosäle 
    Private _AnzahlKinosäle As Integer = 1
    Private _Filme() As Film 'Array, weil mehrere Filme
    Private _Kunden As ArrayList = New ArrayList()
    Private _Tagespläne As Tagesplan



    Public Sub neueBuchungPRÜFEN(ByRef gewählterPlatzX As Integer, ByRef gewählterPlatzY As Integer, ByRef kunde As Kunde, Kinosaal As Integer)
        _Kinosäle(Kinosaal).SitzplatzBuchen(gewählterPlatzX, gewählterPlatzY, kunde)
    End Sub
    Public Sub TagesPlanAnzeigenPRÜFEN()
        FTagesplan.BringToFront()
        FTagesplan.Visible = True
    End Sub


    Public Sub KinosaalhinzufügenPRÜFEN()


        _AnzahlKinosäle += 1
        Dim b(_AnzahlKinosäle) As Kinosaal
        For i As Integer = 0 To _AnzahlKinosäle - 1
            b(i) = _Kinosäle(i)
        Next
        '  b(_AnzahlKinosäle - 1) = a
        _Kinosäle = b

        ' Dim b(_AnzahlKinosäle) As Kinosaal = _Kinosäle ist nicht möglich, weil man nicht weiß, wie groß _Kinosäle ist. (Ist jetzt aber auch irrellevant)
        Console.WriteLine("dfjhghmfkjhk")
    End Sub

    Private Sub Testklassekino_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
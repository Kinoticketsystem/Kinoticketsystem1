Public Class Kino
    'Attribute
    Private _Kinosäle() As Kinosaal
    Private _AnzahlKinosäle As Integer = 1
    Private _Filme As Film
    Private _Kunden As ArrayList = New ArrayList()
    Private _Tagespläne As Tagesplan


    'Konstruktur

    Public Sub New(ByVal AnzahlKinos As Integer, ByVal Filme As Film, ByVal Kunden As ArrayList, ByVal Tagesüläne As Tagesplan)
        For i As Integer = 0 To AnzahlKinos - 1

        Next
        '  Me._Kinosäle = Kinosäle
        Me._Filme = Filme
        Me._Kunden = Kunden
        Me._Tagespläne = _Tagespläne
    End Sub

    Public Sub neueBuchung(ByVal Kinosäle As Kinosaal, ByVal Filme As Film, ByVal Kunde As Kunde, ByVal Tagespläne As Tagesplan)
        '      Kinosaal.SitzplatzBuchen(1, 1, Kunde)
    End Sub

End Class

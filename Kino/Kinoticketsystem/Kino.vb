Public Class Kino
    'Attribute
    Private Kinosäle As Kinosaal
    Private Filme As Film
    Private Kunden As Kunde
    Private Tagespläne As Tagesplan


    'Konstruktur

    Public Sub New(ByVal Kinosäle As Kinosaal, ByVal Filme As Film, ByVal Kunden As Kunde, ByVal Tagesüläne As Tagesplan)
        Me.Kinosäle = Kinosäle
        Me.Filme = Filme
        Me.Kunden = Kunden
        Me.Tagespläne = Tagespläne
    End Sub

    Public Sub neueBuchung(ByVal Kinosäle As Kinosaal, ByVal Filme As Film, ByVal Kunde As Kunde, ByVal Tagespläne As Tagesplan)

    End Sub
End Class

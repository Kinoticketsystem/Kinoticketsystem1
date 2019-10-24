Public Class Kino
    'Attribute
    Private _Kinosäle As Kinosaal
    Private _AnzahlKinosäle As Integer = 1
    Private _Filme As Film
    Private _Kunden As ArrayList = New ArrayList()
    Private _Tagespläne As Tagesplan


    'Konstruktur

    Public Sub New(ByVal AnzahlKinos As Integer, ByVal Filme As Film, ByVal Kunden As ArrayList, ByVal Tagespläne As Tagesplan, ByVal Kinosäle As Kinosaal)
        'For i As Integer = 0 To AnzahlKinos - 1

        ' Next
        Me._Kinosäle = Kinosäle
        Me._Filme = Filme
        Me._Kunden = Kunden
        Me._Tagespläne = Tagespläne


    End Sub

    Public Sub neueBuchung(ByRef gewählterPlatzX As Integer, ByRef gewählterPlatzY As Integer, ByRef kunde As Kunde)
        Me.neueBuchung(gewählterPlatzX, gewählterPlatzY, kunde)
    End Sub
    Public Sub TagesPlanAnzeigen()
        FTagesplan.BringToFront()
        FTagesplan.Visible = True
    End Sub
End Class

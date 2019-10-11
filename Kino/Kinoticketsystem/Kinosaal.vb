Imports Kinoticketsystem

Public Class Kinosaal
    Private _AnzahlSitzplätze As Integer
    Private x As Integer
    Private y As Integer
    Private _Film As Film
    Private _Sitzplätze(,) As Kunde
    Public _leererPlatz As Kunde = New Kunde("")

    Public Sub New(ByVal AnzahlSitztplätze As Integer, ByVal Film As Film, ByVal AnzahlReihe As Integer, ByVal SitzeProReihe As Integer)
        If AnzahlSitztplätze = AnzahlReihe * SitzeProReihe Then
            Me._AnzahlSitzplätze = _AnzahlSitzplätze
        Else
            Throw New Exception("Die übergebene Anzahl der Sitzplätze passt nicht zur Länge und Breite der Sitze")
        End If
        Me._Film = Film
        Dim a(AnzahlReihe, SitzeProReihe) As Kunde
        Me._Sitzplätze = a
        x = AnzahlReihe
        y = SitzeProReihe

        For i As Integer = 0 To AnzahlReihe - 1
            For j As Integer = 0 To SitzeProReihe - 1
                a(i, j) = _leererPlatz
            Next
        Next
    End Sub

    Friend Function getKunde(i As Integer, j As Integer) As Kunde
        Return _Sitzplätze(i, j)
    End Function

    Public Function getY()
        Return y
    End Function

    Public Function getX()
        Return x
    End Function

    Public Sub SitzplatzBuchen(ByRef gewählterPlatzX As Integer, ByRef gewählterPlatzY As Integer, ByRef kunde As Kunde)
        Me._Sitzplätze(gewählterPlatzX, gewählterPlatzY) = kunde
    End Sub

    Public Sub SitzplatzStornieren(ByRef gewählterPlatzX As Integer, ByRef gewählterPlatzY As Integer, ByRef Kunde As Kunde)
        If _Sitzplätze(gewählterPlatzX, gewählterPlatzY).Equals(Kunde) Then
            Me._Sitzplätze(gewählterPlatzX, gewählterPlatzY) = Nothing
        Else
            Throw New Exception("Es wurde beim Sitzplanstornieren versucht einen Sitzplatz zu stornieren, der vorher von dem übergebenen Kunden nicht gebucht wurde!")
        End If
    End Sub

End Class

Public Class Kinosaal
    Private _AnzahlSitzplätze As Integer
    Private _Film As Film
    Private _Sitzplätze(,) As Kunde

    Private Sub New(ByVal AnzahlSitztplätze As Integer, ByVal Film As Film, ByVal GrößeX As Integer, ByVal größeY As Integer)
        Me._AnzahlSitzplätze = _AnzahlSitzplätze
        Me._Film = Film
        Dim a(GrößeX, größeY) As Kunde
        Me._Sitzplätze = a
    End Sub

    Public Sub SitzplatzBuchen(ByRef gewählterPlatzX As Integer, ByRef gewählterPlatzY As Integer, ByRef kunde As Kunde)
        Me._Sitzplätze(gewählterPlatzX, gewählterPlatzY) = kunde
    End Sub

    Private Sub SitzplatzStornieren(ByRef gewählterPlatzX As Integer, ByRef gewählterPlatzY As Integer, ByRef Kunde As Kunde)
        If _Sitzplätze(gewählterPlatzX, gewählterPlatzY).Equals(Kunde) Then
            Me._Sitzplätze(gewählterPlatzX, gewählterPlatzY) = Nothing
        Else
            Throw New Exception("Es wurde beim Sitzplanstornieren versucht einen Sitzplatz zu stornieren, der vorher von dem übergebenen Kunden nicht gebucht wurde!")
        End If
    End Sub

End Class

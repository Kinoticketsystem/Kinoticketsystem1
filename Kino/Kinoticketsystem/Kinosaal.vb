Public Class Kinosaal
    Private AnzahlSitzplätze As Integer
    Private Film As String
    Private Sitzplatz(0, 0) As String

    Private Sub New(ByVal AnzahlSitztplätze As Integer, ByVal Film As String, ByVal Sitzplatz As Array)
        Me.AnzahlSitzplätze = AnzahlSitzplätze
        Me.Film = Film
        Me.Sitzplatz = Sitzplatz(AnzahlSitzplätze - 1, 2)
    End Sub

    Public Sub SitzplatzBuchen(ByVal Sitzplatz As String, ByRef gewählterPlatz As Integer, ByRef name As String)
        Me.Sitzplatz(gewählterPlatz, 1) = name
    End Sub

    Private Sub SitzplatzStronieren(ByVal Sitzplatz As String, ByRef gewählterPlatz As Integer, ByRef name As String)
        Me.Sitzplatz(gewählterPlatz, name) = " "
    End Sub

End Class

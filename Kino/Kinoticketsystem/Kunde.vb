Public Class Kunde
    Public _ausgewählteVorstellung As String
    Public _AnzahlTreuePunkte As Integer
    Public _Name As String


    Public Sub New(ByVal _ausgewählteVorstellung As String, ByVal _AnzahlTreuePunkte As Integer, ByVal _Name As String)
        Me._ausgewählteVorstellung = _ausgewählteVorstellung
        Me._AnzahlTreuePunkte = _AnzahlTreuePunkte
        Me._Name = _Name
    End Sub

    Public Sub Filmtitelfestlegen()
        Me._ausgewählteVorstellung = _ausgewählteVorstellung

    End Sub

    Public Sub SetName()
        Me._Name = _Name
    End Sub
End Class

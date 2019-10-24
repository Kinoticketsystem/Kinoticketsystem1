Public Class Kunde
    Private _ausgewählteVorstellung As Vorstellung
    Private _AnzahlTreuePunkte As Integer = 0
    Private _Name As String


    Public Sub New(ByVal Name As String)
        '  Me._ausgewählteVorstellung = ausgewählteVorstellung 'Man soll auch Kunden erstellen, ohne ihnen direkt eine Vorstellung zuweisen zu müssen
        'Me._AnzahlTreuePunkte = AnzahlTreuePunkte ''Man soll auch Kunden erstellen, ohne ihnen direkt Treuepunkte zuweisen zu müssen
        Me._Name = Name
    End Sub

    Public Sub Vorstellungfestlegen(a As Vorstellung)
        Me._ausgewählteVorstellung = a
    End Sub

    Public Sub SetTreuepunkte(A As Integer)
        _AnzahlTreuePunkte = A
    End Sub
    Public Sub ErhöheTreuepunkte(A As Integer)
        _AnzahlTreuePunkte = _AnzahlTreuePunkte + A
    End Sub
    Public Sub SetName(name As String)
        Me._Name = name
    End Sub

    Public Function getName()
        Return Me._Name
    End Function

End Class

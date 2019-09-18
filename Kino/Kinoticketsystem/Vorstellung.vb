Public Class Vorstellung
    'Attribute
    Private Startzeit As Date 'Verbunden mit Datum?
    Private Endzeit As Date
    Private Besucher As ArrayList
    Private Saal As String 'falls wir keine nummern nehmen
    Private Film As String



    'Konstruktor
    Public Sub New(ByVal Startzeit As Date, ByVal Endzeit As Date, ByVal Besucher As ArrayList, ByVal Saal As String, ByVal Film As String)
        Me.Startzeit = Startzeit
        Me.Endzeit = Endzeit
        Me.Besucher = Besucher
        Me.Saal = Saal
        Me.Film = Film

    End Sub

    'Methoden
    Public Sub BesucherHinzufügen()
        'Attribute des Besuchers?
    End Sub

    Public Sub Saaländern()
        Me.Saal = Saal
        MsgBox(Film & "läuft jetzt im Saal" & Saal)
    End Sub

    Public Sub Filmändern()
        Me.Film = txtFilmnummer.Text
        MsgBox("Neuer Film:" & txtFilmnummer.Text)
    End Sub
End Class

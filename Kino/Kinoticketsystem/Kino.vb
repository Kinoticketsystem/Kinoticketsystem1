Public Class Kino
    'Attribute
    Private _Kinosäle() As Kinosaal 'Array, für mehrere Kinosäle 
    Private _AnzahlKinosäle As Integer
    Private _Filme As ArrayList = New ArrayList() 'Array, weil mehrere Filme
    Private _Kunden As ArrayList = New ArrayList()
    Private _Tagespläne(7) As Tagesplan


    'Konstruktur

    Public Sub New(ByVal AnzahlKinos As Integer, ByVal Filme As ArrayList, ByVal Kunden As ArrayList, ByVal Tagespläne As Array, ByVal Kinosaal As Kinosaal)
        _AnzahlKinosäle = AnzahlKinos
        Dim a(AnzahlKinos) As Kinosaal
        If Not (AnzahlKinos = 1) Then
            Throw New Exception("Wenn man nur ein Kinosaal übergibt, muss man bei AnzahlKinos auch 1 eingeben,") 'wenn man nur eins übergeben will, weil man die anderen zum Beispiel später hinzufügen will, muss man den anderen Konstruktor nutzen (new)") 'ergibt keinen SInn für ein kino mit 2 Kinosälen, von dem man 1 übergeben will
        End If
        _Kinosäle = a
        Me._Kinosäle(0) = Kinosaal
        Me._Filme = Filme
        Me._Kunden = Kunden
        Me._Tagespläne = Tagespläne

        Dim b As Integer
        Dim i As Integer
        Do Until b = 1
            If Kunden(i) IsNot Nothing Then
                Dim neuertext As String = Kunden(i)
                FileOpen(1, "Kunden.txt", OpenMode.Append)
                PrintLine(1, neuertext)
                FileClose(1)
                i = i + 1
            Else
                b = 1
            End If
        Loop

        For j = 0 To Filme.Length - 1
            Dim neuertext As String = Filme(j)
            FileOpen(1, "Filme.txt", OpenMode.Append)
            PrintLine(1, neuertext)
            FileClose(1)
        Next

        FileOpen(1, "Kinosäle.txt", OpenMode.Append)
        PrintLine(1, "Kinosaal 1: Anzahl Sitzplätze: " & Kinosaal.getAnzahlSitzplätze & " Anzahl der Reihen: " & Kinosaal.getAnzahlReihe & " Sitzplätze pro Reihe: " & Kinosaal.getSitzeProReihe)
        FileClose(1)


    End Sub
    'Methoden

    Public Sub New(ByVal AnzahlKinos As Integer, ByVal Filme As ArrayList, ByVal Kunden As ArrayList, ByVal Tagespläne As Array, ByVal Kinosaal As Kinosaal, ByVal Kinosaal2 As Kinosaal)
        _AnzahlKinosäle = AnzahlKinos
        If Not (AnzahlKinos = 2) Then
            Throw New Exception("Wenn man zwei Kinosaal übergibt, muss man bei AnzahlKinos auch 2 eingeben, man kann später noch mehr Kinosäle hinzufügen über methoden") 'wenn man nur eins übergeben will, weil man die anderen zum Beispiel später hinzufügen will, muss man den anderen Konstruktor nutzen (new)") 'ergibt keinen SInn für ein kino mit 2 Kinosälen, von dem man 1 übergeben will
        End If
        Dim a(AnzahlKinos) As Kinosaal
        _Kinosäle = a
        Me._Kinosäle(0) = Kinosaal
        _Kinosäle(1) = Kinosaal2

        Me._Filme = Filme
        Me._Kunden = Kunden
        Me._Tagespläne = Tagespläne
    End Sub
    Public Sub neueBuchung(ByRef gewählterPlatzX As Integer, ByRef gewählterPlatzY As Integer, ByRef kunde As Kunde, Kinosaal As Integer)
        _Kinosäle(Kinosaal).SitzplatzBuchen(gewählterPlatzX, gewählterPlatzY, kunde)
    End Sub
    Public Sub TagesPlanAnzeigen()
        FTagesplan.BringToFront()
        FTagesplan.Visible = True
    End Sub


    Public Sub Kinosaalhinzufügen(ByVal a As Kinosaal)
        _AnzahlKinosäle += 1
        Dim b(_AnzahlKinosäle) As Kinosaal
        For i As Integer = 0 To _AnzahlKinosäle - 1
            b(i) = _Kinosäle(i)
        Next
        b(_AnzahlKinosäle - 1) = a
        _Kinosäle = b

        ' Dim b(_AnzahlKinosäle) As Kinosaal = _Kinosäle ist nicht möglich, weil man nicht weiß, wie groß _Kinosäle ist. (Ist jetzt aber auch irrellevant)

    End Sub

    'get
    Public Function getFilmtitel() As ArrayList
        Return _Filme
    End Function
    Public Function getKunde() As ArrayList
        Return _Kunden
    End Function
    Public Function getTagesplan() As Array
        Return _Tagespläne
    End Function

    'set
    Public Sub KundenHinzufügen(ByRef Kunde As Kunde)
        _Kunden.Add(Kunde)
    End Sub
    Public Sub KundeEntfernen(ByRef Kunde As Kunde)
        Dim a As Integer = _Kunden.BinarySearch(Kunde)
        _Kunden.RemoveAt(a)
    End Sub
    Public Sub setTagesplan(ByRef Tagesplan As Array)
        Tagesplan = _Tagespläne
    End Sub
    Public Sub setFilm(ByRef Film As ArrayList)
        Film = _Filme
    End Sub
    ' wie bei kunde

    Public Sub setKinosaal(ByRef Kinosaal As Array)
        Kinosaal = _Kinosäle
    End Sub
    'wie bei kunde 
    Public Sub setAnzahlKinosaal(ByRef AnzahlKinosaal As Integer)
        AnzahlKinosaal = _AnzahlKinosäle
    End Sub
End Class

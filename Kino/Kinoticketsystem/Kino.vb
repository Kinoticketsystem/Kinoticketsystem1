Public Class Kino
    'Attribute
    Private _Kinosäle() As Kinosaal ' = New ArrayList() 'Array, für mehrere Kinosäle () As Kinosaal '
    Private _AnzahlKinosäle As Integer
    Private _Filme As ArrayList = New ArrayList()
    Private _Kunden As ArrayList = New ArrayList()
    Private _Tagespläne() As Tagesplan  'ArrayList = New ArrayList ' Array weil feste Anzahl '7 pro Kinosaal, muss noch gemacht werden!!!!


    'Konstruktur
    'erster ist eher unwichtig, da wir 6 Kinosäle haben
    Public Sub New(ByVal AnzahlKinos As Integer, ByVal Filme As ArrayList, ByVal Kunden As ArrayList, ByVal Tagespläne As Array, ByVal Kinosaal As Kinosaal)
        _AnzahlKinosäle = AnzahlKinos
        Dim a(AnzahlKinos) As Kinosaal 'für array
        If Not (AnzahlKinos = 1) Then
            Throw New Exception("Wenn man nur ein Kinosaal übergibt, muss man bei AnzahlKinos auch 1 eingeben,") 'wenn man nur eins übergeben will, weil man die anderen zum Beispiel später hinzufügen will, muss man den anderen Konstruktor nutzen (new)") 'ergibt keinen SInn für ein kino mit 2 Kinosälen, von dem man 1 übergeben will
        End If
        _Kinosäle = a
        _Kinosäle(0) = Kinosaal
        Me._Filme = Filme
        Me._Kunden = Kunden
        Me._Tagespläne = Tagespläne

        Dim i As Integer
        Dim j As Integer
        Dim neuertext As String

        For i = 0 To Kunden.Count - 1
            neuertext = Kunden(i)
            FileOpen(1, "Kunden.txt", OpenMode.Append)
            PrintLine(1, neuertext)
            FileClose(1)

        Next

        For j = 0 To Filme.Count - 1
            neuertext = Filme(j)
            FileOpen(1, "Filme.txt", OpenMode.Append)
            PrintLine(1, neuertext)
            FileClose(1)
        Next

        FileOpen(1, "Kinosäle.txt", OpenMode.Append)
        PrintLine(1, "Kinosaal 1: Anzahl Sitzplätze: " & Kinosaal.getAnzahlSitzplätze & " Anzahl der Reihen: " & Kinosaal.getAnzahlReihe & " Sitzplätze pro Reihe: " & Kinosaal.getSitzeProReihe)
        FileClose(1)

        For i = 0 To Tagespläne.Length - 1
            Dim plan As Tagesplan = Tagespläne(i)
            Dim AnzahlVorstellungen As Integer = plan.getAnzahlVorstellungen
            For j = 1 To AnzahlVorstellungen
                Dim Vorstellung As Vorstellung = plan.getVorstellung(j)
                FileOpen(1, "Tagespläne.txt", OpenMode.Append)
                PrintLine(1, j & ". Tag:")
                PrintLine(1, "Vorstellung " & j & ": " & Vorstellung.getAnfangszeit() & " bis " & Vorstellung.getEndzeit() & " : " & Vorstellung.getFilm.getFilmtitel() & " Saal: 1")
                FileClose(1)
            Next
        Next
    End Sub

    Public Function getKinosäle() As Array
        Return _Kinosäle
    End Function
    'Methoden

    Public Sub New(ByVal AnzahlKinos As Integer, ByVal Filme As ArrayList, ByVal Kunden As ArrayList, ByVal Tagespläne As Array, ByVal Kinosäle As Array)
        _AnzahlKinosäle = AnzahlKinos

        ' Dim a(AnzahlKinos) As Kinosaal 'für array
        If Not (Kinosäle.GetLength(0) = (AnzahlKinos)) Then
            Throw New Exception(" AnzahlKinos ungleich der ANzahl der übergebenen Kinosäle im Array")
        End If
        _Kinosäle = Kinosäle

        Me._Filme = Filme
        Me._Kunden = Kunden
        Me._Tagespläne = Tagespläne

        Dim i As Integer
        Dim j As Integer
        Dim neuertext As String

        For i = 0 To Kunden.Count - 1
            neuertext = Kunden(i)
            FileOpen(1, "Kunden.txt", OpenMode.Append)
            PrintLine(1, neuertext)
            FileClose(1)

        Next

        For j = 0 To Filme.Count - 1
            neuertext = Filme(j)
            FileOpen(1, "Filme.txt", OpenMode.Append)
            PrintLine(1, neuertext)
            FileClose(1)
        Next

        For k = 0 To AnzahlKinos - 1
            FileOpen(1, "Kinosäle.txt", OpenMode.Append)
            PrintLine(1, "Kinosaal" & k & ": Anzahl Sitzplätze: " & Kinosäle(k).getAnzahlSitzplätze & " Anzahl der Reihen: " & Kinosäle(k).getAnzahlReihe & " Sitzplätze pro Reihe: " & Kinosäle(k).getSitzeProReihe)
            FileClose(1)
        Next

        For i = 0 To _Tagespläne.GetLength(0) - 1
            Dim plan As Tagesplan = Tagespläne(i)
            Dim AnzahlVorstellungen As Integer = plan.getAnzahlVorstellungen
            For j = 1 To AnzahlVorstellungen
                Dim Vorstellung As Vorstellung = plan.getVorstellung(j)
                FileOpen(1, "Tagespläne.txt", OpenMode.Append)
                PrintLine(1, j & ". Tag:")
                PrintLine(1, "Vorstellung " & j & ": " & Vorstellung.getAnfangszeit() & " bis " & Vorstellung.getEndzeit() & " : " & Vorstellung.getFilm.getFilmtitel() & " Saal: 1")
                FileClose(1)
            Next
        Next
    End Sub
    Public Sub neueBuchung(ByRef gewählterPlatzX As Integer, ByRef gewählterPlatzY As Integer, ByRef kunde As Kunde, Kinosaal As Integer)
        _Kinosäle((Kinosaal)).SitzplatzBuchen(gewählterPlatzX, gewählterPlatzY, kunde)
    End Sub
    Public Sub TagesPlanAnzeigen()
        FTagesplan.BringToFront()
        FTagesplan.Visible = True
    End Sub


    'Public Sub Kinosaalhinzufügen(ByVal a As Kinosaal) 'wenn array
    '    _AnzahlKinosäle += 1
    '    Dim b(_AnzahlKinosäle) As Kinosaal
    '    For i As Integer = 0 To _AnzahlKinosäle - 1
    '        b(i) = _Kinosäle(i)
    '    Next
    '    b(_AnzahlKinosäle - 1) = a
    '    _Kinosäle = b

    '    ' Dim b(_AnzahlKinosäle) As Kinosaal = _Kinosäle ist nicht möglich, weil man nicht weiß, wie groß _Kinosäle ist. (Ist jetzt aber auch irrellevant)

    'End Sub

    'get
    Public Function getFilmtitel() As ArrayList
        Return _Filme
    End Function
    Public Function getKunden() As ArrayList
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
        _Tagespläne = Tagesplan
    End Sub

    Public Sub FilmHinzufügen(ByRef Film As Film)
        _Filme.Add(Film)
    End Sub
    ' wie bei kunde
    Public Sub FilmEntfernen(ByRef Film As Film)
        Dim a As Integer = _Filme.BinarySearch(Film)
        _Filme.RemoveAt(a)
    End Sub


    Public Sub KinosaalAmEndeHinzufügen(ByRef Kinosaal As Kinosaal)
        'wird am Ende eingefügt:
        _AnzahlKinosäle += 1
        Dim b(_AnzahlKinosäle) As Kinosaal
        _Kinosäle(_AnzahlKinosäle - 1) = Kinosaal
    End Sub

    Public Sub KinosaalEntfernen(a As Integer)
        'Dim a As Integer
        'Dim I As ArrayList = New ArrayList(_Kinosäle)
        'I = _Kinosäle.Clone
        'a = I.IndexOf(_Kinosäle)
        _Kinosäle(a) = Nothing
        _AnzahlKinosäle -= 1
    End Sub
    Public Sub KinosaalERsetzen(ByRef Kinosaal As Kinosaal, a As Integer)
        _Kinosäle(a) = Kinosaal
    End Sub
    'wie bei kunde 
    Public Sub MehrereKinosäleHInzufügen(neueKinosäle As Array)
        Dim B(_AnzahlKinosäle + neueKinosäle.Length)
        Dim J As Integer = 0
        For i As Integer = _AnzahlKinosäle To (neueKinosäle.Length - 1)
            B(i) = neueKinosäle(J)
            J += 1
        Next
        _AnzahlKinosäle += neueKinosäle.Length
        _Kinosäle = B

    End Sub
End Class

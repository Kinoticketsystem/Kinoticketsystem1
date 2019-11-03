﻿Public Class Kino
    'Attribute
    Private _Kinosäle As ArrayList = New ArrayList() 'Array, für mehrere Kinosäle () As Kinosaal '
    Private _AnzahlKinosäle As Integer
    Private _Filme As ArrayList = New ArrayList() 'Array, weil mehrere Filme
    Private _Kunden As ArrayList = New ArrayList()
    Private _Tagespläne(7) As Tagesplan


    'Konstruktur

    Public Sub New(ByVal AnzahlKinos As Integer, ByVal Filme As ArrayList, ByVal Kunden As ArrayList, ByVal Tagespläne As Array, ByVal Kinosaal As Kinosaal)
        _AnzahlKinosäle = AnzahlKinos
        'Dim a(AnzahlKinos) As Kinosaal 'für array
        If Not (AnzahlKinos = 1) Then
            Throw New Exception("Wenn man nur ein Kinosaal übergibt, muss man bei AnzahlKinos auch 1 eingeben,") 'wenn man nur eins übergeben will, weil man die anderen zum Beispiel später hinzufügen will, muss man den anderen Konstruktor nutzen (new)") 'ergibt keinen SInn für ein kino mit 2 Kinosälen, von dem man 1 übergeben will
        End If
        _Kinosäle.Clear()
        Me._Kinosäle(0) = Kinosaal
        Me._Filme = Filme
        Me._Kunden = Kunden
        Me._Tagespläne = Tagespläne

        Dim b As Integer
        Dim c As Integer
        Dim i As Integer
        Dim j As Integer
        Dim neuertext As String = Kunden(i)

        Do Until b = 1
            If Kunden(i) IsNot Nothing Then
                neuertext = Kunden(i)
                FileOpen(1, "Kunden.txt", OpenMode.Append)
                PrintLine(1, neuertext)
                FileClose(1)
                i = i + 1
            Else
                b = 1
            End If
        Loop

        Do Until c = 1
            If Filme(j) IsNot Nothing Then
                neuertext = Filme(j)
                FileOpen(1, "Filme.txt", OpenMode.Append)
                PrintLine(1, neuertext)
                FileClose(1)
                j = j + 1
            Else
                c = 1
            End If
        Loop

        FileOpen(1, "Kinosäle.txt", OpenMode.Append)
        PrintLine(1, "Kinosaal 1: Anzahl Sitzplätze: " & Kinosaal.getAnzahlSitzplätze & " Anzahl der Reihen: " & Kinosaal.getAnzahlReihe & " Sitzplätze pro Reihe: " & Kinosaal.getSitzeProReihe)
        FileClose(1)

        For i = 1 To 7
            Dim plan As Tagesplan = _Tagespläne(i)
            Dim AnzahlVorstellungen As Integer = plan.getAnzahlVorstellungen
            For j = 1 To AnzahlVorstellungen
                Dim Vorstellung As Vorstellung = plan.getVorstellung(i)
                FileOpen(1, "Tagespläne.txt", OpenMode.Append)
                PrintLine(1, i & ". Tag:")
                PrintLine(1, "Vorstellung " & j & ": " & Vorstellung.getAnfangszeit & " bis " & Vorstellung.getEndzeit & " : " & Vorstellung.getFilm.getFilmtitel & " Saal: 1")
                FileClose(1)
            Next
        Next
    End Sub
    'Methoden

    Public Sub New(ByVal AnzahlKinos As Integer, ByVal Filme As ArrayList, ByVal Kunden As ArrayList, ByVal Tagespläne As Array, ByVal Kinosaal As Kinosaal, ByVal Kinosaal2 As Kinosaal)
        _AnzahlKinosäle = AnzahlKinos
        If Not (AnzahlKinos = 2) Then
            Throw New Exception("Wenn man zwei Kinosaal übergibt, muss man bei AnzahlKinos auch 2 eingeben, man kann später noch mehr Kinosäle hinzufügen über methoden") 'wenn man nur eins übergeben will, weil man die anderen zum Beispiel später hinzufügen will, muss man den anderen Konstruktor nutzen (new)") 'ergibt keinen SInn für ein kino mit 2 Kinosälen, von dem man 1 übergeben will
        End If
        ' Dim a(AnzahlKinos) As Kinosaal 'für array
        _Kinosäle.Clear()
        _Kinosäle(0) = Kinosaal 'alternative .add
        _Kinosäle(1) = Kinosaal2

        Me._Filme = Filme
        Me._Kunden = Kunden
        Me._Tagespläne = Tagespläne
    End Sub
    Public Sub neueBuchung(ByRef gewählterPlatzX As Integer, ByRef gewählterPlatzY As Integer, ByRef kunde As Kunde, Kinosaal As Kinosaal)
        _Kinosäle(_Kinosäle.IndexOf(Kinosaal)).SitzplatzBuchen(gewählterPlatzX, gewählterPlatzY, kunde)
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
    Public Sub FilmHinzufügen(ByRef Film As ArrayList)
        _Filme.Add(Film)
    End Sub
    ' wie bei kunde
    Public Sub FilmEntfernen(ByRef Film As ArrayList)
        Dim a As Integer
        Dim I As ArrayList = New ArrayList(_Filme)
        I = _Filme.Clone
        a = I.IndexOf(Film)
        _Filme.RemoveAt(a)
    End Sub


    Public Sub KinosaalHinzufügen(ByRef Kinosaal As ArrayList)
        _Kinosäle.Add(Kinosaal)
    End Sub

    Public Sub KinosaalEntfernen(ByRef Kinosaal As ArrayList)
        Dim a As Integer
        Dim I As ArrayList = New ArrayList(_Kinosäle)
        I = _Kinosäle.Clone
        a = I.IndexOf(_Kinosäle)
        _Kinosäle.RemoveAt(a)
    End Sub
    'wie bei kunde 
    Public Sub setAnzahlKinosaal(ByRef AnzahlKinosaal As Integer)
        AnzahlKinosaal = _AnzahlKinosäle
    End Sub
End Class

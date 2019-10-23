﻿Public Class Kino
    'Attribute
    Private _Kinosäle() As Kinosaal 'Array, für mehrere Kinosäle 
    Private _AnzahlKinosäle As Integer = 1
    Private _Filme() As Film 'Array, weil mehrere Filme
    Private _Kunden As ArrayList = New ArrayList()
    Private _Tagespläne As Tagesplan


    'Konstruktur

    Public Sub New(ByVal AnzahlKinos As Integer, ByVal Filme As Array, ByVal Kunden As ArrayList, ByVal Tagespläne As Tagesplan, ByVal Kinosaal As Kinosaal)
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
    End Sub
    Public Sub New(ByVal AnzahlKinos As Integer, ByVal Filme As Array, ByVal Kunden As ArrayList, ByVal Tagespläne As Tagesplan, ByVal Kinosaal As Kinosaal, ByVal Kinosaal2 As Kinosaal)
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
    Public Sub neueBuchung(ByRef gewählterPlatzX As Integer, ByRef gewählterPlatzY As Integer, ByRef kunde As Kunde)
        Me.neueBuchung(gewählterPlatzX, gewählterPlatzY, kunde)
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
End Class

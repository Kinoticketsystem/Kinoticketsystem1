Public Class Film

    Private _Filmtitel As String
    Private _Filmlänge As Integer 'in Minuten
    Private _Altersfreigabe As Integer
    Private _3D As Boolean
    Private _AnzahlFilmWiedergabe As Integer



    Public Sub New(ByVal Filmtitel As String, ByVal Filmlänge As Integer, ByVal Altersfreigabe As Integer, ByVal __3D As Boolean)

        Me._Filmtitel = Filmtitel
        Me._Filmlänge = Filmlänge
        Me._Altersfreigabe = Altersfreigabe
        Me._3D = __3D


    End Sub

    Public Sub filmtitelÄndern(filmtest As String)
        _Filmtitel = filmtest
    End Sub

    Public Sub _FilmtitelAndern(ByVal Filmtitel As String)

        Me._Filmtitel = Filmtitel

    End Sub

    Public Sub _FilmlängeÄndern(ByVal Filmlänge As Integer)
        Me._Filmlänge = Filmlänge
    End Sub

    Public Sub _AltersfreigabeÄndern(ByVal Altersfreigabe As Integer)
        Me._Altersfreigabe = Altersfreigabe
    End Sub

    Public Sub _3DÄndern()
        If Me._3D = True Then
            Me._3D = False
        ElseIf Me._3D = False Then
            Me._3D = True
        End If
    End Sub

    Public Function getFilmlänge() As Integer
        Return _Filmlänge
    End Function

    Public Sub _AnzahlFilmWiedergabeerhöhen()
        Me._AnzahlFilmWiedergabe = Me._AnzahlFilmWiedergabe + 1
    End Sub


    Public Function getFilminfos() As String
        ' Dim Art As String
        If Me._3D = True Then
            ' Art = 3D
            Return "Der Film " & _Filmtitel & ":" & " hat eine Spieldauer von " & _Filmlänge & "min, ist ab " & _Altersfreigabe & ", wird in 3D wiedergegeben und wurde bereits " & _AnzahlFilmWiedergabe & " gespielt."
        Else 'If Me._3D = False Then
            ' Art = 2D
            Return "Der Film " & _Filmtitel & ":" & " hat eine Spieldauer von " & _Filmlänge & "min, ist ab " & _Altersfreigabe & ", wird in 2D wiedergegeben und wurde bereits " & _AnzahlFilmWiedergabe & " gespielt."
        End If

        'txt.FilmeDaten.Text = "Der Film", _Filmtitel, ":", "hat eine Spieldauer von", _Filmlänge, " ist ab", _Altersfreigabe, "Wird in", 3D, "wiedergegeben und wurde berreits", _AnzahlFilmWiedergabe, " gespielt."

    End Function

    Public Function Ist3D() As Boolean
        Return _3D
    End Function

    Public Function getAltersfreigabe() As Integer
        Return _Altersfreigabe
    End Function

    Public Function getFilmtitel() As String
        Return _Filmtitel
    End Function
    Public Function getAnzahlFilmwiedergabe() As Integer
        Return _AnzahlFilmWiedergabe
    End Function
    'Public Overrides Function Equals(a As Object) As Boolean
    '    If Me._Filmtitel = a.getFilmtitel And Me._3D = a.Ist3D() Then
    '        Return True
    '    Else
    '        Return False
    '    End If
    'End Function


End Class

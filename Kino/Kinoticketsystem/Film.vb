Public Class Film

    Private _Filmtitel As String
    Private _Filmlänge As Integer
    Private _Altersfreigabe As Integer
    Private _3D As Boolean
    Private _AnzahlFilmWiedergabe As Integer



    Public Sub New(ByVal _Filmtitel As String, ByVal _Filmlänge As Integer, ByVal _Altersfreigabe As Integer, ByVal _3D As Boolean, ByVal _AnzahlFilmWiedergabe As Integer)

        Me._Filmtitel = _Filmtitel
        Me._Filmlänge = _Filmlänge
        Me._Altersfreigabe = _Altersfreigabe
        Me._3D = _3D
        Me._AnzahlFilmWiedergabe = _AnzahlFilmWiedergabe


    End Sub


    Public Sub _FilmtitelAndern()

        Me._Filmtitel = _Filmtitel

    End Sub

    Public Sub _FilmlängeÄndern()
        Me._Filmlänge = _Filmlänge
    End Sub

    Public Sub _AltersfreigabeÄndern()
        Me._Altersfreigabe = _Altersfreigabe
    End Sub

    Public Sub _3DÄndern()
        If Me._3D = True Then
            Me._3D = False
        ElseIf Me._3D = False Then
            Me._3D = True
        End If
    End Sub

    Public Sub _AnzahlFilmWiedergabeÄndern()
        Me._AnzahlFilmWiedergabe = Me._AnzahlFilmWiedergabe + 1
    End Sub


    Public Function getFilminfos(ByVal _Filmtitel As String, ByVal _Filmlänge As Integer, ByVal _Altersfreigabe As String, ByVal _3D As Boolean, ByVal _AnzahlFilmWiedergabe As String) As String
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
End Class

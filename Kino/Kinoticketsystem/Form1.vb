Imports Kinoticketsystem

Public Class FTagesplan
    Private _ersterTag As ITagesplan
    Private _zweiterTag As ITagesplan
    Private _dritterTag As ITagesplan
    Private _vierterTag As ITagesplan
    Private _fünfterTag As ITagesplan
    Private _sechsterTag As ITagesplan
    Private _siebterTag As ITagesplan
    'Die nächsten 7 Tage werden angezeigt
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AnfangstagUndDatümerFestlegen() 'fertig
        PositionDerDatümerFestlegen()   'fertig
        PositionDerFilmButtonsFestlegenX()  'fertig
        WochenplanAbrufenUndAusgeben()  'muss noch gemacht werden (Erik)
        GrößeDerFilmButtonsFestlegen()  'muss noch Y-Größe gemacht werden
        ' PositionDerFilmButtonsFestlegenY()  'muss noch gemacht werden

    End Sub

    Private Sub WochenplanAbrufenUndAusgeben()
        'Auslesen aus einer externen Textdatei
        '_ersterTag
        '_zweiterTag
        '_dritterTag
        '_vierterTag
        '_fünfterTag
        '_sechsterTag
        '_siebterTag
        'Anzeigen

        ' Button1.Text = _Montag.
        'PositionDerFilmButtonsFestlegenY()

    End Sub

    Private Sub PositionDerFilmButtonsFestlegenY()
        'Wenn die Zahl der Filme pro Tag variiert
        'erster Tag
        Select Case _ersterTag.getAnzahlFilme
            Case 1
                Button1.Top = (_ersterTag.getFilm(1).getAnfangszeit()) / 3 + 70
                Button2.Hide()
                Button3.Hide()
                Button4.Hide()
                Button5.Hide()
                Button6.Hide()
                Button7.Hide()
            Case 2
                Button1.Top = (_ersterTag.getFilm(1).getAnfangszeit()) / 3 + 70
                Button2.Top = (_ersterTag.getFilm(2).getAnfangszeit()) / 3 + 70
                Button3.Hide()
                Button4.Hide()
                Button5.Hide()
                Button6.Hide()
                Button7.Hide()
            Case 3
                Button1.Top = (_ersterTag.getFilm(1).getAnfangszeit()) / 3 + 70
                Button2.Top = (_ersterTag.getFilm(2).getAnfangszeit()) / 3 + 70
                Button3.Top = (_ersterTag.getFilm(3).getAnfangszeit()) / 3 + 70
                Button4.Hide()
                Button5.Hide()
                Button6.Hide()
                Button7.Hide()
            Case 4
                Button1.Top = (_ersterTag.getFilm(1).getAnfangszeit()) / 3 + 70
                Button2.Top = (_ersterTag.getFilm(2).getAnfangszeit()) / 3 + 70
                Button3.Top = (_ersterTag.getFilm(3).getAnfangszeit()) / 3 + 70
                Button4.Top = (_ersterTag.getFilm(4).getAnfangszeit()) / 3 + 70
                Button5.Hide()
                Button6.Hide()
                Button7.Hide()
            Case 5
                Button1.Top = (_ersterTag.getFilm(1).getAnfangszeit()) / 3 + 70
                Button2.Top = (_ersterTag.getFilm(2).getAnfangszeit()) / 3 + 70
                Button3.Top = (_ersterTag.getFilm(3).getAnfangszeit()) / 3 + 70
                Button4.Top = (_ersterTag.getFilm(4).getAnfangszeit()) / 3 + 70
                Button5.Top = (_ersterTag.getFilm(5).getAnfangszeit()) / 3 + 70
                Button6.Hide()
                Button7.Hide()
            Case 6
                Button1.Top = (_ersterTag.getFilm(1).getAnfangszeit()) / 3 + 70
                Button2.Top = (_ersterTag.getFilm(2).getAnfangszeit()) / 3 + 70
                Button3.Top = (_ersterTag.getFilm(3).getAnfangszeit()) / 3 + 70
                Button4.Top = (_ersterTag.getFilm(4).getAnfangszeit()) / 3 + 70
                Button5.Top = (_ersterTag.getFilm(5).getAnfangszeit()) / 3 + 70
                Button6.Top = (_ersterTag.getFilm(6).getAnfangszeit()) / 3 + 70
                Button7.Hide()
            Case 7
                Button1.Top = (_ersterTag.getFilm(1).getAnfangszeit()) / 3 + 70
                Button2.Top = (_ersterTag.getFilm(2).getAnfangszeit()) / 3 + 70
                Button3.Top = (_ersterTag.getFilm(3).getAnfangszeit()) / 3 + 70
                Button4.Top = (_ersterTag.getFilm(4).getAnfangszeit()) / 3 + 70
                Button5.Top = (_ersterTag.getFilm(5).getAnfangszeit()) / 3 + 70
                Button6.Top = (_ersterTag.getFilm(6).getAnfangszeit()) / 3 + 70
                Button7.Top = (_ersterTag.getFilm(7).getAnfangszeit()) / 3 + 70
            Case Else
                Throw New Exception("Die Anzahl der gespeicherten Filme für den ersten Tag, entspricht nicht der Anzahl der möglichen darstellbaren Filme (0<x<8")
        End Select
        Select Case _zweiterTag.getAnzahlFilme
            Case 1
                Button8.Top = (_ersterTag.getFilm(6).getAnfangszeit()) / 3 + 70
                Button9.Hide()
                Button10.Hide()
                Button11.Hide()
                Button12.Hide()
                Button13.Hide()
                Button14.Hide()
            Case 2
                Button8.Top = (_ersterTag.getFilm(6).getAnfangszeit()) / 3 + 70
                Button9.Top = (_ersterTag.getFilm(6).getAnfangszeit()) / 3 + 70
                Button10.Hide()
                Button11.Hide()
                Button12.Hide()
                Button13.Hide()
                Button14.Hide()
            Case 3
                Button8.Top = (_ersterTag.getFilm(6).getAnfangszeit()) / 3 + 70
                Button9.Top = (_ersterTag.getFilm(6).getAnfangszeit()) / 3 + 70
                Button10.Top = (_ersterTag.getFilm(6).getAnfangszeit()) / 3 + 70
                Button11.Hide()
                Button12.Hide()
                Button13.Hide()
                Button14.Hide()
            Case 4
                Button8.Top = (_ersterTag.getFilm(6).getAnfangszeit()) / 3 + 70
                Button9.Top = (_ersterTag.getFilm(6).getAnfangszeit()) / 3 + 70
                Button10.Top = (_ersterTag.getFilm(6).getAnfangszeit()) / 3 + 70
                Button11.Top = (_ersterTag.getFilm(6).getAnfangszeit()) / 3 + 70
                Button12.Hide()
                Button13.Hide()
                Button14.Hide()
            Case 5
                Button8.Top = (_ersterTag.getFilm(6).getAnfangszeit()) / 3 + 70
                Button9.Top = (_ersterTag.getFilm(6).getAnfangszeit()) / 3 + 70
                Button10.Top = (_ersterTag.getFilm(6).getAnfangszeit()) / 3 + 70
                Button11.Top = (_ersterTag.getFilm(6).getAnfangszeit()) / 3 + 70
                Button12.Top = (_ersterTag.getFilm(6).getAnfangszeit()) / 3 + 70
                Button13.Hide()
                Button14.Hide()
            Case 6
                Button8.Top = (_ersterTag.getFilm(6).getAnfangszeit()) / 3 + 70
                Button9.Top = (_ersterTag.getFilm(6).getAnfangszeit()) / 3 + 70
                Button10.Top = (_ersterTag.getFilm(6).getAnfangszeit()) / 3 + 70
                Button11.Top = (_ersterTag.getFilm(6).getAnfangszeit()) / 3 + 70
                Button12.Top = (_ersterTag.getFilm(6).getAnfangszeit()) / 3 + 70
                Button13.Top = (_ersterTag.getFilm(6).getAnfangszeit()) / 3 + 70
                Button14.Hide()
            Case 7
                Button8.Top = (_ersterTag.getFilm(6).getAnfangszeit()) / 3 + 70
                Button9.Top = (_ersterTag.getFilm(6).getAnfangszeit()) / 3 + 70
                Button10.Top = (_ersterTag.getFilm(6).getAnfangszeit()) / 3 + 70
                Button11.Top = (_ersterTag.getFilm(6).getAnfangszeit()) / 3 + 70
                Button12.Top = (_ersterTag.getFilm(6).getAnfangszeit()) / 3 + 70
                Button13.Top = (_ersterTag.getFilm(6).getAnfangszeit()) / 3 + 70
                Button14.Top = (_ersterTag.getFilm(6).getAnfangszeit()) / 3 + 70
            Case Else
                Throw New Exception("Die Anzahl der gespeicherten Filme für den zweiten Tag, entspricht nicht der Anzahl der möglichen darstellbaren Filme (0<x<8")
        End Select
    End Sub



    Private Sub PositionDerFilmButtonsFestlegenX()
        Button1.Left = chbMontag.Left
        Button2.Left = chbMontag.Left
        Button3.Left = chbMontag.Left
        Button4.Left = chbMontag.Left
        Button5.Left = chbMontag.Left
        Button6.Left = chbMontag.Left
        Button7.Left = chbMontag.Left

        Button8.Left = chbDienstag.Left
        Button9.Left = chbDienstag.Left
        Button10.Left = chbDienstag.Left
        Button11.Left = chbDienstag.Left
        Button12.Left = chbDienstag.Left
        Button13.Left = chbDienstag.Left
        Button14.Left = chbDienstag.Left

        Button15.Left = chbMittwoch.Left
        Button16.Left = chbMittwoch.Left
        Button17.Left = chbMittwoch.Left
        Button18.Left = chbMittwoch.Left
        Button19.Left = chbMittwoch.Left
        Button20.Left = chbMittwoch.Left
        Button21.Left = chbMittwoch.Left

        Button22.Left = chbDonnerstag.Left
        Button23.Left = chbDonnerstag.Left
        Button24.Left = chbDonnerstag.Left
        Button25.Left = chbDonnerstag.Left
        Button26.Left = chbDonnerstag.Left
        Button27.Left = chbDonnerstag.Left
        Button28.Left = chbDonnerstag.Left

        Button29.Left = chbFreitag.Left
        Button30.Left = chbFreitag.Left
        Button31.Left = chbFreitag.Left
        Button32.Left = chbFreitag.Left
        Button33.Left = chbFreitag.Left
        Button34.Left = chbFreitag.Left
        Button35.Left = chbFreitag.Left

        Button36.Left = chbSamstag.Left
        Button37.Left = chbSamstag.Left
        Button38.Left = chbSamstag.Left
        Button39.Left = chbSamstag.Left
        Button40.Left = chbSamstag.Left
        Button41.Left = chbSamstag.Left
        Button42.Left = chbSamstag.Left

        Button43.Left = chbSonntag.Left
        Button44.Left = chbSonntag.Left
        Button45.Left = chbSonntag.Left
        Button46.Left = chbSonntag.Left
        Button47.Left = chbSonntag.Left
        Button48.Left = chbSonntag.Left
        Button49.Left = chbSonntag.Left
    End Sub

    Private Sub PositionDerDatümerFestlegen()
        Dim A As Integer = chbMontag.Size.Width
        Dim b As Integer = chbDienstag.Size.Width
        Dim c As Integer = chbMittwoch.Size.Width
        Dim d As Integer = chbDonnerstag.Size.Width
        Dim e As Integer = chbFreitag.Size.Width
        Dim f As Integer = chbSamstag.Size.Width
        Dim g As Integer = chbSonntag.Size.Width
        'x-Koordinate festlegen
        chbDienstag.Left = 45 + 150 + A
        chbMittwoch.Left = 150 + A + (45 * 2) + b
        chbDonnerstag.Left = 150 + A + (45 * 3) + b + c
        chbFreitag.Left = 150 + A + (45 * 4) + b + c + d
        chbSamstag.Left = 150 + A + (45 * 5) + b + c + d + e
        chbSonntag.Left = 150 + A + (45 * 6) + b + c + d + e + f
        Me.Size = New Size(150 + A + (45 * 7) + b + c + d + e + f + g, Me.Size.Height)
    End Sub

    Private Sub AnfangstagUndDatümerFestlegen()
        Dim thisDate As Date = Today
        Dim Wochentag As Integer '1 = Sonntag, 2 = Montag, ...
        Wochentag = Weekday(thisDate)

        'Die nächsten 6 Tage
        Dim ZweiterTag As Date = DateAdd(DateInterval.Day, 1.0, thisDate)
        Dim DritterTag As Date = DateAdd(DateInterval.Day, 2, thisDate)
        Dim VierterTag As Date = DateAdd(DateInterval.Day, 3, thisDate)
        Dim FünfterTag As Date = DateAdd(DateInterval.Day, 4, thisDate)
        Dim SechsterTag As Date = DateAdd(DateInterval.Day, 5, thisDate)
        Dim SiebterTag As Date = DateAdd(DateInterval.Day, 6, thisDate)
        'Die Woche beginnt mit dem heutigen Tagen
        Select Case Wochentag
            Case 2 'Montag ist der erste Tag
                chbMontag.Text = chbMontag.Text & thisDate.ToString(" dd.MM.")
                chbDienstag.Text = chbDienstag.Text & ZweiterTag.ToString(" dd.MM.")
                chbMittwoch.Text = chbMittwoch.Text & DritterTag.ToString(" dd.MM.")
                chbDonnerstag.Text = chbDonnerstag.Text & VierterTag.ToString(" dd.MM.")
                chbFreitag.Text = chbFreitag.Text & FünfterTag.ToString(" dd.MM.")
                chbSamstag.Text = chbSamstag.Text & SechsterTag.ToString(" dd.MM.")
                chbSonntag.Text = chbSonntag.Text & SiebterTag.ToString(" dd.MM.")
            Case 3
                chbMontag.Text = "Dienstag" & thisDate.ToString(" dd.MM.")
                chbDienstag.Text = "Mittwoch" & ZweiterTag.ToString(" dd.MM.")
                chbMittwoch.Text = "Donnerstag" & DritterTag.ToString(" dd.MM.")
                chbDonnerstag.Text = "Freitag" & VierterTag.ToString(" dd.MM.")
                chbFreitag.Text = "Samstag" & FünfterTag.ToString(" dd.MM.")
                chbSamstag.Text = "Sonntag" & SechsterTag.ToString(" dd.MM.")
                chbSonntag.Text = "Montag" & SiebterTag.ToString(" dd.MM.")
            Case 4
                chbMontag.Text = "Mittwoch" & thisDate.ToString(" dd.MM.")
                chbDienstag.Text = "Donnerstag" & ZweiterTag.ToString(" dd.MM.")
                chbMittwoch.Text = "Freitag" & DritterTag.ToString(" dd.MM.")
                chbDonnerstag.Text = "Samstag" & VierterTag.ToString(" dd.MM.")
                chbFreitag.Text = "Sonntag" & FünfterTag.ToString(" dd.MM.")
                chbSamstag.Text = "Montag" & SechsterTag.ToString(" dd.MM.")
                chbSonntag.Text = "Dienstag" & SiebterTag.ToString(" dd.MM.")
            Case 5
                chbMontag.Text = "Donnerstag" & thisDate.ToString(" dd.MM.")
                chbDienstag.Text = "Freitag" & ZweiterTag.ToString(" dd.MM.")
                chbMittwoch.Text = "Samstag" & DritterTag.ToString(" dd.MM.")
                chbDonnerstag.Text = "Sonntag" & VierterTag.ToString(" dd.MM.")
                chbFreitag.Text = "Montag" & FünfterTag.ToString(" dd.MM.")
                chbSamstag.Text = "Dienstag" & SechsterTag.ToString(" dd.MM.")
                chbSonntag.Text = "Mittwoch" & SiebterTag.ToString(" dd.MM.")
            Case 6
                chbMontag.Text = "Freitag" & thisDate.ToString(" dd.MM.")
                chbDienstag.Text = "Samstag" & ZweiterTag.ToString(" dd.MM.")
                chbMittwoch.Text = "Sonntag" & DritterTag.ToString(" dd.MM.")
                chbDonnerstag.Text = "Montag" & VierterTag.ToString(" dd.MM.")
                chbFreitag.Text = "Dienstag" & FünfterTag.ToString(" dd.MM.")
                chbSamstag.Text = "Mittwoch" & SechsterTag.ToString(" dd.MM.")
                chbSonntag.Text = "Donnerstag" & SiebterTag.ToString(" dd.MM.")
            Case 7
                chbMontag.Text = "Samstag" & thisDate.ToString(" dd.MM.")
                chbDienstag.Text = "Sonntag" & ZweiterTag.ToString(" dd.MM.")
                chbMittwoch.Text = "Montag" & DritterTag.ToString(" dd.MM.")
                chbDonnerstag.Text = "Dienstag" & VierterTag.ToString(" dd.MM.")
                chbFreitag.Text = "Mittwoch" & FünfterTag.ToString(" dd.MM.")
                chbSamstag.Text = "Donnerstag" & SechsterTag.ToString(" dd.MM.")
                chbSonntag.Text = "Freitag" & SiebterTag.ToString(" dd.MM.")
            Case 1
                chbMontag.Text = "Sonntag" & thisDate.ToString(" dd.MM.")
                chbDienstag.Text = "Montag" & ZweiterTag.ToString(" dd.MM.")
                chbMittwoch.Text = "Dienstag" & DritterTag.ToString(" dd.MM.")
                chbDonnerstag.Text = "Mittwoch" & VierterTag.ToString(" dd.MM.")
                chbFreitag.Text = "Donnerstag" & FünfterTag.ToString(" dd.MM.")
                chbSamstag.Text = "Freitag" & SechsterTag.ToString(" dd.MM.")
                chbSonntag.Text = "Samstag" & SiebterTag.ToString(" dd.MM.")
        End Select
    End Sub

    Private Sub GrößeDerFilmButtonsFestlegen()
        'Größe der Spaltenüberschriften
        Dim A As Size = chbMontag.Size
        Dim b As Size = chbDienstag.Size
        Dim c As Size = chbMittwoch.Size
        Dim d As Size = chbDonnerstag.Size
        Dim es As Size = chbFreitag.Size
        Dim f As Size = chbSamstag.Size
        Dim g As Size = chbSonntag.Size

        'Größe der Filme bestimmen
        'Hier muss noch ausgelesen werden, wie lange ein Film geht und dementsprechend die Größe,
        'die standartmäßig auf 26 ist, verändert werden. 
        Button1.Size = New Size(A.Width, 26)
        Button2.Size = New Size(A.Width, 26)
        Button3.Size = New Size(A.Width, 26)
        Button4.Size = New Size(A.Width, 26)
        Button5.Size = New Size(A.Width, 26)
        Button6.Size = New Size(A.Width, 26)
        Button7.Size = New Size(A.Width, 26)

        Button8.Size = New Size(b.Width, 26)
        Button9.Size = New Size(b.Width, 26)
        Button10.Size = New Size(b.Width, 26)
        Button11.Size = New Size(b.Width, 26)
        Button12.Size = New Size(b.Width, 26)
        Button13.Size = New Size(b.Width, 26)
        Button14.Size = New Size(b.Width, 26)

        Button15.Size = New Size(c.Width, 26)
        Button16.Size = New Size(c.Width, 26)
        Button17.Size = New Size(c.Width, 26)
        Button18.Size = New Size(c.Width, 26)
        Button19.Size = New Size(c.Width, 26)
        Button20.Size = New Size(c.Width, 26)
        Button21.Size = New Size(c.Width, 26)

        Button22.Size = New Size(d.Width, 26)
        Button23.Size = New Size(d.Width, 26)
        Button24.Size = New Size(d.Width, 26)
        Button25.Size = New Size(d.Width, 26)
        Button26.Size = New Size(d.Width, 26)
        Button27.Size = New Size(d.Width, 26)
        Button28.Size = New Size(d.Width, 26)

        Button29.Size = New Size(es.Width, 26)
        Button30.Size = New Size(es.Width, 26)
        Button31.Size = New Size(es.Width, 26)
        Button32.Size = New Size(es.Width, 26)
        Button33.Size = New Size(es.Width, 26)
        Button34.Size = New Size(es.Width, 26)
        Button35.Size = New Size(es.Width, 26)

        Button36.Size = New Size(f.Width, 26)
        Button37.Size = New Size(f.Width, 26)
        Button38.Size = New Size(f.Width, 26)
        Button39.Size = New Size(f.Width, 26)
        Button40.Size = New Size(f.Width, 26)
        Button41.Size = New Size(f.Width, 26)
        Button42.Size = New Size(f.Width, 26)

        Button43.Size = New Size(g.Width, 26)
        Button44.Size = New Size(g.Width, 26)
        Button45.Size = New Size(g.Width, 26)
        Button46.Size = New Size(g.Width, 26)
        Button47.Size = New Size(g.Width, 26)
        Button48.Size = New Size(g.Width, 26)
        Button49.Size = New Size(g.Width, 26)
    End Sub

    Private Sub cmdFilmÄndern_Click(sender As Object, e As EventArgs) Handles cmdFilmÄndern.Click
        '    _Montag.FilmÄndern(New Vorstellung(), txtFilmnummer.Text)

        Select Case True
            Case chbMontag.Checked
                _ersterTag.FilmÄndern(New Vorstellung(), txtFilmnummer.Text)
            Case chbDienstag.Checked
            Case chbMittwoch.Checked
            Case chbDonnerstag.Checked
            Case chbFreitag.Checked
        End Select
    End Sub


End Class

'Ein Tagesplan, der speichert wann welcher Film gezeigt wird
'Die Start - und Laufzeit der Filme wird in den einzelnen Filmen gespeichert
Public Interface ITagesplan
    Sub TagesplanErstellen(ByVal Vorstellung1 As Vorstellung, ByVal Vorstellung2 As Vorstellung, ByVal Vorstellung3 As Vorstellung, ByVal Vorstellung4 As Vorstellung, ByVal Vorstellung5 As Vorstellung)
    'Es muss die Filmnummer übergeben werden (später vielleicht mal die Vorstellung mit der getauscht werden soll oder die Uhrzeit?)
    Sub FilmÄndern(ByVal Vorstellung As Vorstellung, ByVal Filmnummer As Integer)
    'wird ans Ende hinzugefügt
    Sub FilmHinzufügen(ByVal Vorstellung As Vorstellung)
    Sub FilmEntfernen(ByVal vorstellung As Vorstellung, ByVal Position As Integer)
    Function getFilme() As Array
    Function getFilm(ByVal Position As Integer) As Film
    Function getAnzahlFilme() As Integer
End Interface

Public Interface IVorstellung

End Interface
'Gabor
Public Class Kinosaal

End Class
Public Interface ITestinterface
    Sub Testprozedur(ByRef a As Integer)
    Function TestFunktion(ByVal b As Integer)
End Interface

Public Class Testklasse
    Implements ITestinterface

    Public Sub Testprozedur(ByRef a As Integer) Implements ITestinterface.Testprozedur
        Throw New NotImplementedException()
    End Sub

    Public Function TestFunktion(b As Integer) As Object Implements ITestinterface.TestFunktion
        Throw New NotImplementedException()
    End Function
End Class

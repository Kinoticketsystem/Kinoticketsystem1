Imports Kinoticketsystem

Public Class FTagesplan
    Private _Montag As Tagesplan
    'Die nächsten 7 Tage werden angezeigt
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AnfangstagUndDatümerFestlegen()
        'PositionDerDatümerFestlegen()
        'PositionDerFilmButtonsFestlegen()
        GrößeDerFilmButtonsFestlegen()
    End Sub

    'Private Sub PositionDerFilmButtonsFestlegen()
    'End Sub

    'Private Sub PositionDerDatümerFestlegen()
    'End Sub

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdTagesPlanErstellen.Click

    End Sub

    Private Sub cmdFilmÄndern_Click(sender As Object, e As EventArgs) Handles cmdFilmÄndern.Click
        '    _Montag.FilmÄndern(New Vorstellung(), txtFilmnummer.Text)

        Select Case True
            Case chbMontag.Checked
                _Montag.FilmÄndern(New Vorstellung(), txtFilmnummer.Text)
            Case chbDienstag.Checked
            Case chbMittwoch.Checked
            Case chbDonnerstag.Checked
            Case chbFreitag.Checked
        End Select
    End Sub


End Class

'Ein Tagesplan, der speichert wann welcher Film gezeigt wird
'Beim Erstellen müssen die Filme in der richtigen Reihenfolge übergeben werden
Public Interface ITagesplan
    Sub TagesplanErstellen(ByVal Vorstellung1 As Vorstellung, ByVal Vorstellung2 As Vorstellung, ByVal Vorstellung3 As Vorstellung, ByVal Vorstellung4 As Vorstellung, ByVal Vorstellung5 As Vorstellung)
    'Es muss die Filmnummer übergeben werden (später vielleicht mal die Vorstellung mit der getauscht werden soll oder die Uhrzeit?)
    Sub FilmÄndern(ByVal Vorstellung As Vorstellung, ByVal Filmnummer As Integer)
    'wird ans Ende hinzugefügt
    Sub FilmHinzufügen(ByVal Vorstellung As Vorstellung)
    Sub FilmEntfernen(ByVal vorstellung As Vorstellung, ByVal Position As Integer)
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

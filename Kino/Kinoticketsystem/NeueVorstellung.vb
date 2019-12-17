Imports Kinoticketsystem

Public Class NeueVorstellung
    Private _Filmtitel As String
    Private _Startzeit As Integer
    Private _Endzeit As Integer
    Private _Film As Film
    Private _Besucher As ArrayList
    Private _FilmHinzugefügt As Boolean = False
    Private _Tag As Integer
    Private _Position As Integer
    Private _Kinosaal As Kinosaal
    Private _Kinosaalnummer As Integer

    Private Sub NeueVorstellung_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StartuhrzeitWert.DecimalPlaces = 2
        StartuhrzeitWert.Value = 8
        StartuhrzeitWert.Maximum = 24
        StartuhrzeitWert.Minimum = 8
        StartuhrzeitWert.Increment = 0.05
        EnduhrzeitWert.DecimalPlaces = 2
        EnduhrzeitWert.Value = 8
        EnduhrzeitWert.Maximum = 24
        EnduhrzeitWert.Minimum = 8
        EnduhrzeitWert.Increment = 0.05
        NUDKinosaal.Maximum = 6
        NUDKinosaal.Minimum = 1
        NUDKinosaal.Value = 1

    End Sub


    Public Sub datenübergen(c As Vorstellung, Kinosaal As Integer)
        txtname.Text = c.getFilm.getFilmtitel
        For i = 0 To c.getAlleBesucher.Count - 1
            lstBesucher.Items.Add(c.getBesucher(i))
        Next
        NUDKinosaal.Value = Kinosaal
    End Sub

    Public Sub PositionÜbergeben(tag As Integer, Position As Integer)
        _Tag = tag
        _Position = Position
    End Sub


    Private Sub cmdfertig_Click(sender As Object, e As EventArgs) Handles cmdfertig.Click
        '_Filmtitel = txtname.Text
        '_Startzeit = (StartuhrzeitWert.Value * 100) - (8 * 60) '0 ist bei 8:00
        '_Endzeit = (EnduhrzeitWert.Value * 100) - (8 * 60)
        _Tag = NUDTag.Value
        _Kinosaalnummer = NUDKinosaal.Value
        If Not (_FilmHinzugefügt) Then
            lblFilmAuswählen.ForeColor = Color.Red
        Else
            'sich selber nicht hier schließen, damit danach noch ausgelesen werden kann
            Dim z As Vorstellung = New Vorstellung(getStartzeit, getEndzeit, getBesucher, getFilm, _Kinosaal)
            '  FTagesplan.filmändern(_Tag, _Position, z) 'was zum teufel. wer macht denn sowas?
            Dim a As ArrayList = KinoGUI.DASKINO.getKinosäle
            'KinoGUI.DASKINO.VorstellungHinzufügen(a(_Tag - 1), _Position, z)
            KinoGUI.DASKINO.VorstellungEinfügen(_Tag, z, _Kinosaalnummer)
            Me.Close()
        End If

    End Sub

    Private Sub StartuhrzeitWert_ValueChanged(sender As Object, e As EventArgs) Handles StartuhrzeitWert.ValueChanged
        Dim a As Double = Math.Round(StartuhrzeitWert.Value, 1)
        If StartuhrzeitWert.Value >= 8.6 And StartuhrzeitWert.Value < 9 Then
            If a = 8.6 Or a = 8.7 Then
                StartuhrzeitWert.Value = 9
            Else
                StartuhrzeitWert.Value = 8.55
            End If
        ElseIf StartuhrzeitWert.Value >= 9.6 And StartuhrzeitWert.Value < 10 Then
            If a = 9.6 Or a = 9.7 Then
                StartuhrzeitWert.Value = 10
            Else
                StartuhrzeitWert.Value = 9.55
            End If
        ElseIf StartuhrzeitWert.Value >= 10.6 And StartuhrzeitWert.Value < 11 Then
            If a = 10.6 Or a = 10.7 Then
                StartuhrzeitWert.Value = 11
            Else
                StartuhrzeitWert.Value = 10.55
            End If
        ElseIf StartuhrzeitWert.Value >= 11.6 And StartuhrzeitWert.Value < 12 Then
            If a = 11.6 Or a = 11.7 Then
                StartuhrzeitWert.Value = 12
            Else
                StartuhrzeitWert.Value = 11.55
            End If
        ElseIf StartuhrzeitWert.Value >= 12.6 And StartuhrzeitWert.Value < 13 Then
            If a = 12.6 Or a = 12.7 Then
                StartuhrzeitWert.Value = 13
            Else
                StartuhrzeitWert.Value = 12.55
            End If
        ElseIf StartuhrzeitWert.Value >= 13.6 And StartuhrzeitWert.Value < 14 Then
            If a = 13.6 Or a = 13.7 Then
                StartuhrzeitWert.Value = 14
            Else
                StartuhrzeitWert.Value = 13.55
            End If
        ElseIf StartuhrzeitWert.Value >= 14.6 And StartuhrzeitWert.Value < 15 Then
            If a = 14.6 Or a = 14.7 Then
                StartuhrzeitWert.Value = 15
            Else
                StartuhrzeitWert.Value = 14.55
            End If
        ElseIf StartuhrzeitWert.Value >= 15.6 And StartuhrzeitWert.Value < 16 Then
            If a = 15.6 Or a = 15.7 Then
                StartuhrzeitWert.Value = 16
            Else
                StartuhrzeitWert.Value = 15.55
            End If
        ElseIf StartuhrzeitWert.Value >= 16.6 And StartuhrzeitWert.Value < 17 Then
            If a = 16.6 Or a = 16.7 Then
                StartuhrzeitWert.Value = 17
            Else
                StartuhrzeitWert.Value = 16.55
            End If
        ElseIf StartuhrzeitWert.Value >= 17.6 And StartuhrzeitWert.Value < 18 Then
            If a = 17.6 Or a = 17.7 Then
                StartuhrzeitWert.Value = 18
            Else
                StartuhrzeitWert.Value = 17.55
            End If
        ElseIf StartuhrzeitWert.Value >= 18.6 And StartuhrzeitWert.Value < 19 Then
            If a = 18.6 Or a = 18.7 Then
                StartuhrzeitWert.Value = 19
            Else
                StartuhrzeitWert.Value = 18.55
            End If
        ElseIf StartuhrzeitWert.Value >= 19.6 And StartuhrzeitWert.Value < 20 Then
            If a = 19.6 Or a = 19.7 Then
                StartuhrzeitWert.Value = 20
            Else
                StartuhrzeitWert.Value = 19.55
            End If
        ElseIf StartuhrzeitWert.Value >= 20.6 And StartuhrzeitWert.Value < 21 Then
            If a = 20.6 Or a = 20.7 Then
                StartuhrzeitWert.Value = 21
            Else
                StartuhrzeitWert.Value = 20.55
            End If
        ElseIf StartuhrzeitWert.Value >= 21.6 And StartuhrzeitWert.Value < 22 Then
            If a = 21.6 Or a = 21.7 Then
                StartuhrzeitWert.Value = 22
            Else
                StartuhrzeitWert.Value = 21.55
            End If
        ElseIf StartuhrzeitWert.Value >= 22.6 And StartuhrzeitWert.Value < 23 Then
            If a = 22.6 Or a = 22.7 Then
                StartuhrzeitWert.Value = 23
            Else
                StartuhrzeitWert.Value = 22.55
            End If
        ElseIf StartuhrzeitWert.Value >= 23.6 And StartuhrzeitWert.Value < 24 Then
            If a = 23.6 Or a = 23.7 Then
                StartuhrzeitWert.Value = 24
            Else
                StartuhrzeitWert.Value = 23.55
            End If
        ElseIf StartuhrzeitWert.Value >= 24.6 And StartuhrzeitWert.Value < 25 Then
            If a = 24.6 Or a = 24.7 Then
                StartuhrzeitWert.Value = 25
            Else
                StartuhrzeitWert.Value = 24.55
            End If
        End If
    End Sub

    Private Sub EnduhrzeitWert_ValueChanged(sender As Object, e As EventArgs) Handles EnduhrzeitWert.ValueChanged
        Dim a As Double = Math.Round(EnduhrzeitWert.Value, 1)
        If EnduhrzeitWert.Value < StartuhrzeitWert.Value Then
            Try
                EnduhrzeitWert.Value = StartuhrzeitWert.Value + _Film.getFilmlänge / 100
            Catch ex As Exception
                EnduhrzeitWert.Value = StartuhrzeitWert.Value
            End Try
        Else
            If EnduhrzeitWert.Value >= 8.6 And EnduhrzeitWert.Value < 9 Then
                If a = 8.6 Or a = 8.7 Then
                    EnduhrzeitWert.Value = 9
                Else
                    EnduhrzeitWert.Value = 8.55
                End If
            ElseIf EnduhrzeitWert.Value >= 9.6 And EnduhrzeitWert.Value < 10 Then
                If a = 9.6 Or a = 9.7 Then
                    EnduhrzeitWert.Value = 10
                Else
                    EnduhrzeitWert.Value = 9.55
                End If
            ElseIf EnduhrzeitWert.Value >= 10.6 And EnduhrzeitWert.Value < 11 Then
                If a = 10.6 Or a = 10.7 Then
                    EnduhrzeitWert.Value = 11
                Else
                    EnduhrzeitWert.Value = 10.55
                End If
            ElseIf EnduhrzeitWert.Value >= 11.6 And EnduhrzeitWert.Value < 12 Then
                If a = 11.6 Or a = 11.7 Then
                    EnduhrzeitWert.Value = 12
                Else
                    EnduhrzeitWert.Value = 11.55
                End If
            ElseIf EnduhrzeitWert.Value >= 12.6 And EnduhrzeitWert.Value < 13 Then
                If a = 12.6 Or a = 12.7 Then
                    EnduhrzeitWert.Value = 13
                Else
                    EnduhrzeitWert.Value = 12.55
                End If
            ElseIf EnduhrzeitWert.Value >= 13.6 And EnduhrzeitWert.Value < 14 Then
                If a = 13.6 Or a = 13.7 Then
                    EnduhrzeitWert.Value = 14
                Else
                    EnduhrzeitWert.Value = 13.55
                End If
            ElseIf EnduhrzeitWert.Value >= 14.6 And EnduhrzeitWert.Value < 15 Then
                If a = 14.6 Or a = 14.7 Then
                    EnduhrzeitWert.Value = 15
                Else
                    EnduhrzeitWert.Value = 14.55
                End If
            ElseIf EnduhrzeitWert.Value >= 15.6 And EnduhrzeitWert.Value < 16 Then
                If a = 15.6 Or a = 15.7 Then
                    EnduhrzeitWert.Value = 16
                Else
                    EnduhrzeitWert.Value = 15.55
                End If
            ElseIf EnduhrzeitWert.Value >= 16.6 And EnduhrzeitWert.Value < 17 Then
                If a = 16.6 Or a = 16.7 Then
                    EnduhrzeitWert.Value = 17
                Else
                    EnduhrzeitWert.Value = 16.55
                End If
            ElseIf EnduhrzeitWert.Value >= 17.6 And EnduhrzeitWert.Value < 18 Then
                If a = 17.6 Or a = 17.7 Then
                    EnduhrzeitWert.Value = 18
                Else
                    EnduhrzeitWert.Value = 17.55
                End If
            ElseIf EnduhrzeitWert.Value >= 18.6 And EnduhrzeitWert.Value < 19 Then
                If a = 18.6 Or a = 18.7 Then
                    EnduhrzeitWert.Value = 19
                Else
                    EnduhrzeitWert.Value = 18.55
                End If
            ElseIf EnduhrzeitWert.Value >= 19.6 And EnduhrzeitWert.Value < 20 Then
                If a = 19.6 Or a = 19.7 Then
                    EnduhrzeitWert.Value = 20
                Else
                    EnduhrzeitWert.Value = 19.55
                End If
            ElseIf EnduhrzeitWert.Value >= 20.6 And EnduhrzeitWert.Value < 21 Then
                If a = 20.6 Or a = 20.7 Then
                    EnduhrzeitWert.Value = 21
                Else
                    EnduhrzeitWert.Value = 20.55
                End If
            ElseIf EnduhrzeitWert.Value >= 21.6 And EnduhrzeitWert.Value < 22 Then
                If a = 21.6 Or a = 21.7 Then
                    EnduhrzeitWert.Value = 22
                Else
                    EnduhrzeitWert.Value = 21.55
                End If
            ElseIf EnduhrzeitWert.Value >= 22.6 And EnduhrzeitWert.Value < 23 Then
                If a = 22.6 Or a = 22.7 Then
                    EnduhrzeitWert.Value = 23
                Else
                    EnduhrzeitWert.Value = 22.55
                End If
            ElseIf EnduhrzeitWert.Value >= 23.6 And EnduhrzeitWert.Value < 24 Then
                If a = 23.6 Or a = 23.7 Then
                    EnduhrzeitWert.Value = 24
                Else
                    EnduhrzeitWert.Value = 23.55
                End If
            ElseIf EnduhrzeitWert.Value >= 24.6 And EnduhrzeitWert.Value < 25 Then
                If a = 24.6 Or a = 24.7 Then
                    EnduhrzeitWert.Value = 25
                Else
                    EnduhrzeitWert.Value = 24.55
                End If
            End If
        End If

    End Sub

    Private Sub cmdFilmHinZuFügen_Click(sender As Object, e As EventArgs) Handles cmdFilmHinZuFügen.Click

        Dim i As Integer = chlFilme.SelectedIndex
        _Film = KinoGUI.DASKINO.getFilmtitel(i)
        lblFilmlänge.Text = _Film.getFilmlänge & " min"
        'Dim ausgewählterFilm As Film = New Film("", 89, 12, True)
        Dim nachkommastellen As Integer
        Dim vorkommastellen As Integer
        nachkommastellen = StartuhrzeitWert.Value - Math.Truncate(StartuhrzeitWert.Value)
        vorkommastellen = Math.Truncate(StartuhrzeitWert.Value)
        _Startzeit = vorkommastellen * 60 + nachkommastellen * 100
        _Endzeit = _Startzeit + _Film.getFilmlänge
        EnduhrzeitWert.Value = StartuhrzeitWert.Value + _Film.getFilmlänge \ 60 + (_Film.getFilmlänge Mod 60) / 100



        'If (EnduhrzeitWert.Value - StartuhrzeitWert.Value) < ausgewählterFilm.getFilmlänge / 100 Then
        '    EnduhrzeitWert.Value = ausgewählterFilm.getFilmlänge / 100 + StartuhrzeitWert.Value
        'End If
        'If txtname.Text = "" Then
        '    txtname.Text = ausgewählterFilm.getFilmtitel
        'End If
        _FilmHinzugefügt = True
    End Sub

    Public Function getStartzeit() As Integer
        Return _Startzeit
    End Function

    Public Function getEndzeit() As Integer
        Return _Endzeit
    End Function

    Public Function getBesucher() As ArrayList
        Return _Besucher
    End Function

    Public Function getFilm() As Film
        Return _Film
    End Function

    Private Sub chlBesucherAuswählen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles chlBesucherAuswählen.SelectedIndexChanged
        lstBesucher.Items.Clear()
        Dim A As IList = chlBesucherAuswählen.CheckedItems
        For i = 0 To A.Count
            lstBesucher.Items.Add(A(i).getName)
        Next
    End Sub

    Private Sub NUDKinosaal_ValueChanged(sender As Object, e As EventArgs) Handles NUDKinosaal.ValueChanged
        Dim a As ArrayList = KinoGUI.DASKINO.getKinosäle
        _Kinosaal = a(NUDKinosaal.Value - 1)

    End Sub

    Private Sub cmdBesucherNEtfernen_Click(sender As Object, e As EventArgs) Handles cmdBesucherNEtfernen.Click

        Dim a As IList = lstBesucher.SelectedItems
        If a.Count > 0 Then
            For i = 0 To -1
                If lstBesucher.GetSelected(i) Then
                    lstBesucher.Items.RemoveAt(i)
                End If
            Next
        Else
            lstBesucher.Items.Clear()
        End If
    End Sub
End Class
Public Class TexterfassenTest
    Private TestFilmA As Film = New Film("TestFilmA", 120, 16, True)
    Private TestFilmB As Film = New Film("TestFilmB", 90, 12, False)
    Private testsaal1 As Kinosaal = New Kinosaal(60, TestFilmA, 10, 6)
    Private BeispielVorstellungA As Vorstellung = New Vorstellung(0, 120, New ArrayList(), TestFilmA)
    Private BeispielVorstellungC As Vorstellung = New Vorstellung(10, 100, New ArrayList(), TestFilmB)
    Private _Tagespläne As New ArrayList
    Private Testplan As New Tagesplan
    Private FilmListe As New ArrayList
    Private KundenListe As New ArrayList


    Private Sub cmdTexterfassen_Click(sender As Object, e As EventArgs) Handles cmdTexterfassen.Click
        FilmListe.Add("Jaws 45")
        FilmListe.Add("SW 5674")
        FilmListe.Add("cdm")
        KundenListe.Add("J")
        KundenListe.Add("F")
        KundenListe.Add("K")
        Testplan.TagesplanErstellen1(BeispielVorstellungA)
        _Tagespläne.Add(Testplan)
        Dim testkino As Kino = New Kino(1, FilmListe, KundenListe, _Tagespläne, testsaal1)

    End Sub
    'Public Sub texterfassen()


    '    FileOpen(1, "Speichertext.txt", OpenMode.Input)
    '    While Not EOF(1)
    '        lstTextausgabe.Items.Add(LineInput(1))
    '        ' in der Listbox wird der ganze Text aus der Datei angezeigt (Zeile für Zeile ausgelesen)
    '        Console.WriteLine()
    '    End While
    '    FileClose(1)
    'End Sub

    'Public Sub texteinfügen()
    '    Dim neuertext As String = txtInput.Text
    '    'textbox ist die, in der der einzulesende Text geschrieben wird, 
    '    'dieser wird dann in der nächsten Zeile der Datei angefügt 

    '    FileOpen(1, "test.txt", OpenMode.Append)
    '    PrintLine(1, neuertext)
    '    FileClose(1)
    'End Sub

    'Private Sub TexterfassenTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    'End Sub

End Class

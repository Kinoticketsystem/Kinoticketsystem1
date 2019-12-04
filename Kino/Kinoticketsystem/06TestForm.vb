Public Class Form3

    Private Sub cmdTestKinosaal_Click(sender As Object, e As EventArgs)
        Static a As Boolean
        Static b As TestKinosaal
        Dim Übergabe As String

        'Sitzplatzstornieren
        a = b.TestSitzplatzStornieren
        a.ToString(Übergabe)
        lstAusgabe.Items.Add(Übergabe)

        'Sitzplatzbuchen
        a = b.TestSitzplatzBuchen
        a.ToString(Übergabe)
        lstAusgabe.Items.Add(Übergabe)
    End Sub

    Private Sub cmdTestkinotest_Click_1(sender As Object, e As EventArgs) Handles cmdTestkinotest.Click
        Static a As Boolean
        Static b As Testklassekino
        Dim Übergabe As String

        'Neue Buchung 
        a = b.NeueBuchung
        a.ToString(Übergabe)
        lstAusgabeKino.Items.Add(Übergabe)



    End Sub

    Private Sub cmdTestAll_Click(sender As Object, e As EventArgs) Handles cmdTestAll.Click
        'SetFilm
        Dim a As Boolean
        Dim b As Testklassekino ' geht es mit verschieden Klassen?!
        Dim Übergabe As String

        a = b.SetFilm
        a.ToString(Übergabe)
        lstAusgabeKino.Items.Add(Übergabe)
        'SetKunden
        a = b.SetKunden
        a.ToString(Übergabe)
        lstAusgabeKino.Items.Add(Übergabe)
        'SetKundenEntfernen
        a = b.SetKundenEntfernen
        a.ToString(Übergabe)
        lstAusgabeKino.Items.Add(Übergabe)
        'SetAnzahlKinosaal
        a = b.SetAnzahlKinosaal
        a.ToString(Übergabe)
        lstAusgabeKino.Items.Add(Übergabe)






    End Sub

    Private Sub cmdTestTagesplan_Click(sender As Object, e As EventArgs) Handles cmdTestTagesplan.Click
        Dim a As Boolean
        Dim b As TestTagesplan ' geht es mit verschieden Klassen?!
        Dim Übergabe As String
        'TestVorstellung
        a = b.TestVorstellungHinzufügen
        a.ToString(Übergabe)
        lstTagesplan.Items.Add(Übergabe)
        'TestVEntfernen
        a = b.TestVorstellungEntfernen
        a.ToString(Übergabe)
        lstTagesplan.Items.Add(Übergabe)
        'TestVÄndern
        a = b.TestVorstellungÄndern
        a.ToString(Übergabe)
        lstTagesplan.Items.Add(Übergabe)


    End Sub
End Class
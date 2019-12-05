Public Class Form3

    Private Sub cmdTestKinosaal_Click(sender As Object, e As EventArgs)
        'wird nicht aufgerufen
        'Static a As Boolean
        'Static b As TestKinosaal = New TestKinosaal
        'Dim c As String
        '' Dim Übergabe As String

        ''Sitzplatzstornieren
        'a = b.TestSitzplatzStornieren
        'c = a.ToString()
        'lstAusgabe.Items.Add(c)

        ''Sitzplatzbuchen
        'a = b.TestSitzplatzBuchen
        'c = a.ToString()
        'lstAusgabe.Items.Add(c)
    End Sub

    Private Sub cmdTestkinotest_Click_1(sender As Object, e As EventArgs) Handles cmdTestkinotest.Click
        Static a As Boolean
        Static b As Testklassekino = New Testklassekino
        Dim Übergabe As String

        'Neue Buchung 
        a = b.NeueBuchung
        a.ToString(Übergabe)
        lstAusgabeKino.Items.Add(Übergabe)



    End Sub

    Private Sub cmdTestAll_Click(sender As Object, e As EventArgs) Handles cmdTestAll.Click
        'SetFilm
        Dim a As Boolean
        Dim b As Testklassekino = New Testklassekino
        Dim Übergabe As String

        a = b.SetFilm
        a.ToString(Übergabe)
        lstAusgabeKino.Items.Add(a)
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
        Dim b As TestTagesplan = New TestTagesplan
        Dim c As String
        'TestVorstellung
        a = b.TestVorstellungHinzufügen
        c = a.ToString
        lstTagesplan.Items.Add(c)
        'TestVEntfernen
        a = b.TestVorstellungEntfernen
        c = a.ToString
        lstTagesplan.Items.Add(c)
        'TestVÄndern
        a = b.TestVorstellungÄndern
        c = a.ToString
        lstTagesplan.Items.Add(c)


    End Sub

    Private Sub cmdTestKinosaal_Click_1(sender As Object, e As EventArgs) Handles cmdTestKinosaal.Click
        Static a As Boolean
        Static b As TestKinosaal = New TestKinosaal
        Dim c As String
        ' Dim Übergabe As String
        'Sitzplatzbuchen
        a = b.TestSitzplatzBuchen
        c = a.ToString()
        lstAusgabe.Items.Add(c)
        'Sitzplatzstornieren
        a = b.TestSitzplatzStornieren
        c = a.ToString()
        lstAusgabe.Items.Add(c)

    End Sub
End Class
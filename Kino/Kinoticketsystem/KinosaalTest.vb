Public Class KinosaalTest

    Public TestK As Kunde
    Public TestS As Kinosaal
    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdErstellen.Click
        Dim Anzahl As String = txtAnzahl.Text
        Dim Kunde As String = txtEingabeKunde.Text
        Dim Reihe As Integer = txtReihe.Text
        Dim Sitz As Integer = txtSitz.Text

        Dim TestF As Film = New Film("Cool", 100, 12, False)
        TestS = New Kinosaal(Anzahl, TestF, Reihe, Sitz)
        TestK = New Kunde(Kunde)
        MsgBox("passt")
    End Sub

    Public Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim a As Integer = txtEingabeI.Text
        Dim b As Integer = txtEingabeJ.Text
        Dim c As Kunde = TestK
        TestS.SitzplatzBuchen(a, b, c)
        MsgBox("passt")
    End Sub

    Public Sub cmdAufrufen_Click(sender As Object, e As EventArgs) Handles cmdAufrufen.Click
        Dim i As Integer = txtEingabeI.Text
        Dim j As Integer = txtEingabeJ.Text
        txtAusgabeX.Text = TestS.getX()
        txtAusgabeY.Text = TestS.getY()

        Dim a As Kunde = TestS.getKunde(i, j)
        txtKunde.Text = a.getName()
        MsgBox("passt")
    End Sub
End Class
Public Class KundeHinzuFügen
    Private _Kunde As Kunde
    Private Sub lstSammlung_SelectedIndexChanged(sender As Object, e As EventArgs)
        '    _Kunde = CheckedListBox1.ch

    End Sub

    Private Sub KundeHinzuFügen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'die Listbox mit allen Kunden füllen
    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged

    End Sub

    Public Sub übergeben(a As Integer, b As Integer)
        FTagesplan.BuchenNachdemKundeAUsgewähltWUrde(a, b, _Kunde)
    End Sub
End Class
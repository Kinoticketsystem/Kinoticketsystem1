Public Class KundeHinzuFügen
    Private _Kunde As Kunde
    Private ab As Integer
    Private bc As Integer
    Public Buchen As Boolean
    Private _Kunden As ArrayList

    Private Sub KundeHinzuFügen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'die Listbox mit allen Kunden füllen
        _Kunden = KinoGUI.DASKINO.getKunden

        For i As Integer = 0 To KinoGUI.DASKINO.getKunden.Count - 1
            CheckedListBox1.Items.Add(_Kunden(i).getName)
        Next
    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged
        DiesenKundennehmen()
    End Sub
    Private Sub DiesenKundennehmen()
        'For i = 0 To 2
        '    '   Dim list As CheckedListBox  = CheckedListBox1.CheckedItems
        '    If CheckedListBox1.GetSelected(i) > 0 Then
        '        _Kunde = New Kunde(List(0))
        '        
        '    End If
        'Next

        Dim a As IList = CheckedListBox1.SelectedItems()
        _Kunde = New Kunde(a(0))

        If Buchen Then
            FTagesplan.BuchenNachdemKundeAUsgewähltWUrde(ab, bc, _Kunde, True)

        Else
            FTagesplan.BuchenNachdemKundeAUsgewähltWUrde(ab, bc, _Kunde, False)

        End If

        Me.Hide()
        Me.Close()

    End Sub
    Public Sub übergeben(a As Integer, b As Integer, buchenfdv As Boolean)
        ab = a
        bc = b
        Buchen = buchenfdv
    End Sub

    Private Sub cmdSuchen_Click(sender As Object, e As EventArgs) Handles cmdSuchen.Click

        CheckedListBox1.SelectedItem = Stelle()
    End Sub
    Private Function Stelle() As Integer
        Dim name As String = txtSuchen.Text

        For i As Integer = 0 To _Kunden.Count - 1
            If _Kunden(i).getName.Equals(name) Then

                Return i
            Else

            End If

        Next

    End Function
End Class
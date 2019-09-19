Public Class TexterfassenTest
    Public Sub texterfassen()


        FileOpen(1, "Speichertext.txt", OpenMode.Input)
        While Not EOF(1)
            lstTextausgabe.Items.Add(LineInput(1))
            ' in der Listbox wird der ganze Text aus der Datei angezeigt (Zeile für Zeile ausgelesen)
            Console.WriteLine()
        End While
        FileClose(1)
    End Sub

    Public Sub texteinfügen()
        Dim neuertext As String = txtInput.Text
        'textbox ist die, in der der einzulesende Text geschrieben wird, 
        'dieser wird dann in der nächsten Zeile der Datei angefügt 

        FileOpen(1, "test.txt", OpenMode.Append)
        PrintLine(1, neuertext)
        FileClose(1)
    End Sub
End Class

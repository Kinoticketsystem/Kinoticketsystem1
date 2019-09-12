Imports Kinoticketsystem

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class

Public Interface Testinterface
    Sub Testprozedur(ByRef a As Integer)
    Function TestFunktion(ByVal b As Integer)
End Interface

Public Class Testklasse
    Implements Testinterface

    Public Sub Testprozedur(ByRef a As Integer) Implements Testinterface.Testprozedur
        Throw New NotImplementedException()
    End Sub

    Public Function TestFunktion(b As Integer) As Object Implements Testinterface.TestFunktion
        Throw New NotImplementedException()
    End Function
End Class

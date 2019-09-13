Imports Kinoticketsystem

Public Class FTagesplan
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdTagesPlanErstellen.Click

    End Sub
End Class

'Ein Tagesplan mit
Public Interface Tagesplan
    Sub TagesplanErstellen(ByVal Vorstellung1 As Vorstellung, ByVal Vorstellung2 As Vorstellung, ByVal Vorstellung3 As Vorstellung, ByVal Vorstellung4 As Vorstellung)

End Interface

Public Interface Vorstellung

End Interface

Public Class Kinosaal

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

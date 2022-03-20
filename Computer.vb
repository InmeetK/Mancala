Class Computer
    Inherits Player
    Private ComputerDiff As String

    Sub New()
        SetName("Computer" & ComputerDiff)
        SetIsComputer(False)
    End Sub
    Public Sub SetComputerDiff(InputComputerDiff)
        ComputerDiff = InputComputerDiff
    End Sub
End Class
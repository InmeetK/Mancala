Class Player
    Protected Name As String
    Protected IsComputer As Boolean
    Protected IsPlayer1 As Boolean
    Public Function GetName()
        Return Name
    End Function
    Public Sub SetName(InputName As String)
        Name = InputName
    End Sub
    Public Function GetIsComputer()
        Return IsComputer
    End Function
    Public Sub SetIsComputer(InputIsComputer As Boolean)
        IsComputer = InputIsComputer
    End Sub
    Public Function GetIsPlayer1()
        Return IsPlayer1
    End Function
    Public Sub SetIsPlayer1(InputIsPlayer1 As Boolean)
        IsPlayer1 = InputIsPlayer1
    End Sub
End Class
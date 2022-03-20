Public Class Hole
    Protected windowPosition As Point
    Protected seedCount As Integer
    Public button As New Button()

    Public Sub New(x As Integer, y As Integer, initialSeeds As Integer)
        windowPosition.X = x
        windowPosition.Y = y
        button.Size = New Point(70, 70)
        button.BackColor = Color.SandyBrown

        button.Top = windowPosition.Y
        button.Left = windowPosition.X
        seedCount = initialSeeds
        button.Text = seedCount

    End Sub

    Public Function GetSeedCount()
        Return seedCount
    End Function
    Public Sub SetSeedCount(NewSeedCount As Integer)
        seedCount = NewSeedCount
        button.Text = seedCount
    End Sub
    Public Sub AddOneSeed()
        Threading.Thread.Sleep(500)
        SetSeedCount(seedCount + 1)
    End Sub

End Class
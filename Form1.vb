Imports System.Reflection

Public Class Form1

    Class Hole
        Inherits Button
        Protected WindowPosition As Point
        Protected SeedCount As Integer
        Protected Shared HolePosition As Integer

        Public Sub New()

            Select Case HolePosition
                Case 0 To 5
                    WindowPosition.X = 295
                    WindowPosition.Y = 271
                Case 1 To 5
                    WindowPosition.X = 295 + HolePosition * 110
                Case 6

                Case 7
                Case 8
                Case 9
                Case 10
                Case 11
                Case 12
                Case 13


            End Select
            HolePosition += 1
        End Sub
        Public Function GetSeedCount()
            Return SeedCount
        End Function
        Public Sub SetSeedCount(NewSeedCount As Integer)
            SeedCount = NewSeedCount
        End Sub
        Public Sub AddOneSeed()
            Threading.Thread.Sleep(500)
            SetSeedCount(GetSeedCount() + 1)
        End Sub
        Public Sub DisplaySeedCount()

        End Sub
    End Class
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
    Class EasyComputer
        Inherits Computer

    End Class
    Class MediumComputer
        Inherits Computer

    End Class
    Class HardComputer
        Inherits Computer
    End Class
    Private Sub Menu_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        'draw rectangle of the board
        Dim BoardBrush As New SolidBrush(Color.SaddleBrown)
        Dim GapLength As Integer = 40
        Dim xStart As Integer = 100
        Dim yStart As Integer = 100
        Dim Start As New Point(xStart, yStart)
        Dim BoardSize As New Size(1000, 260)
        Dim rect As New Rectangle(Start, BoardSize)
        Me.CreateGraphics.FillRectangle(BoardBrush, rect)
        'draw the stores
        Dim PotBrush As New SolidBrush(Color.SandyBrown)
        Start = New Point(xStart + GapLength, yStart + GapLength)
        Dim StoreSize As New Size(110, 180)
        rect = New Rectangle(Start, StoreSize)
        Me.CreateGraphics.FillEllipse(PotBrush, rect)
        Start = New Point((xStart + BoardSize.Width) - (StoreSize.Width + GapLength), yStart + GapLength)
        rect = New Rectangle(Start, StoreSize)
        Me.CreateGraphics.FillEllipse(PotBrush, rect)
        'draw the hollows
        Dim HollowSize As New Size(70, 70)
        Dim HollowStart = New Point(xStart + StoreSize.Width + GapLength * 2, yStart + GapLength)
        For row = 0 To 1
            For column = 0 To 5
                Start = New Point(HollowStart.X + column * (HollowSize.Width + GapLength), HollowStart.Y + row * (HollowSize.Height + GapLength))
                rect = New Rectangle(Start, HollowSize)
                Me.CreateGraphics.FillEllipse(PotBrush, rect)
            Next
        Next
    End Sub
End Class
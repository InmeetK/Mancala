Imports System.Reflection
Public Class GameWindow
    Dim board As New Board

    Sub main()
    End Sub

    Private Sub board_paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        board.paintBoard(e.Graphics)

    End Sub

    Private Sub createHollows(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim listOfHoles As List(Of Hole) = New List(Of Hole)

        Dim size As New Size(76, 76)
        Dim location As Point
        For index = 0 To 13
            If index > 6 Then
                location = New Point(845 - 110 * (index - 7), 140)
            Else
                location = New Point(295 + 110 * index, 265)
            End If

            Dim hole As Hole = board.makeHollow(index, size, location)
            listOfHoles.Add(hole)
            Controls.Add(hole)
        Next

    End Sub




End Class
Public Class Board
    Private xStart As Integer = 100
    Private yStart As Integer = 100
    Private Start As New Point(xStart, yStart)
    Private BoardBrush As New SolidBrush(Color.SaddleBrown)
    Private BoardSize As New Size(1000, 260)
    Private rect As New Rectangle(Start, BoardSize)
    Public Sub paintBoard(g As Graphics)
        g.FillRectangle(BoardBrush, rect)
        'So now you can pass in the data arguments here of the board'
    End Sub



    Public Function makeHollow(index As Integer, size As Size, location As Point)
        Dim Hole0 As Hole = New Hole(4)
        With Hole0
            .ForeColor = Color.SaddleBrown
            .BackColor = Color.SandyBrown
            .Size = size
            .Name = "Hole" & index
            .Location = location
            .Text = Hole0.seedCount
            .Font = New Font("Consolas", 20.25, FontStyle.Bold)
        End With
        Return Hole0
    End Function
End Class
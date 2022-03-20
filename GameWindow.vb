Imports System.Reflection
Public Class GameWindow
    Dim board As New Board

    Sub main(sender As Object, e As PaintEventArgs)
    End Sub

    Private Sub board_paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        board.paintBoard(e.Graphics)
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

    Public Function getRectangle()
        Return rect
    End Function
    Public Function getBoardBrush()
        Return BoardBrush
    End Function
End Class
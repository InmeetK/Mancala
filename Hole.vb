Imports System.Windows.Forms
Imports System.Drawing.Drawing2D
Public Class Hole
    Inherits Button
    Protected WindowPosition As Point = New Point(0, 0)
    Protected HollowSize As Size = New Size(70, 70)
    Public holeIndex As Integer
    Public seedCount As Integer = 4
    Public seedsToMove As Integer
    Public Sub New(index As Integer)
        holeIndex = index
    End Sub
    Protected Overrides Sub OnPaint(pevent As PaintEventArgs)
        MyBase.OnPaint(pevent)
        Dim grPath As GraphicsPath = New GraphicsPath()
        grPath.AddEllipse(WindowPosition.X, WindowPosition.Y, HollowSize.Width, HollowSize.Height)

        Me.Region = New Region(grPath)
    End Sub
    Public Sub addOneSeed()
        seedCount += 1
        Threading.Thread.CurrentThread.Sleep(500)
        Text = seedCount
    End Sub
    Public Function takeSeeds()
        seedsToMove = seedCount
        seedCount = 0
        Text = seedCount
        Return seedsToMove
    End Function
End Class
Class MancalaHole
    Inherits Hole
    Public Sub New(index As Integer)
        MyBase.New(index)
        seedCount = 0
        HollowSize = New Size(110, 180)
        Enabled = False
    End Sub


End Class
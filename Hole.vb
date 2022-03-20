Imports System.Windows.Forms
Imports System.Drawing.Drawing2D
Public Class Hole
    Inherits Button
    Protected WindowPosition As Point = New Point(0, 0)
    Protected HollowSize As Size = New Size(70, 70)
    Public seedCount As Integer



    Public Sub New(seeds As Integer)
        seedCount = seeds



    End Sub

    Protected Sub holeClick(sender As Object, e As EventArgs) Handles Me.Click
        seedCount += 1
        Text = seedCount
    End Sub
    Protected Overrides Sub OnPaint(pevent As PaintEventArgs)
        MyBase.OnPaint(pevent)
        Dim grPath As GraphicsPath = New GraphicsPath()
        grPath.AddEllipse(WindowPosition.X, WindowPosition.Y, HollowSize.Width, HollowSize.Height)

        Me.Region = New Region(grPath)
    End Sub
End Class
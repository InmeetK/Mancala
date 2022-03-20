<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GameWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.lblHollow6 = New System.Windows.Forms.Label()
        Me.lblHollow13 = New System.Windows.Forms.Label()
        Me.btnResetBoard = New System.Windows.Forms.Button()
        Me.btnPreviousBoard = New System.Windows.Forms.Button()
        Me.lblPlayerMsg = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnMenu
        '
        Me.btnMenu.BackColor = System.Drawing.SystemColors.Control
        Me.btnMenu.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnMenu.Location = New System.Drawing.Point(550, 20)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(100, 25)
        Me.btnMenu.TabIndex = 0
        Me.btnMenu.Text = "Back to Menu"
        Me.btnMenu.UseVisualStyleBackColor = False
        '
        'lblHollow6
        '
        Me.lblHollow6.BackColor = System.Drawing.Color.SandyBrown
        Me.lblHollow6.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblHollow6.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblHollow6.Location = New System.Drawing.Point(969, 212)
        Me.lblHollow6.Name = "lblHollow6"
        Me.lblHollow6.Size = New System.Drawing.Size(72, 36)
        Me.lblHollow6.TabIndex = 17
        Me.lblHollow6.Text = "6"
        Me.lblHollow6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHollow13
        '
        Me.lblHollow13.BackColor = System.Drawing.Color.SandyBrown
        Me.lblHollow13.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblHollow13.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblHollow13.Location = New System.Drawing.Point(159, 212)
        Me.lblHollow13.Name = "lblHollow13"
        Me.lblHollow13.Size = New System.Drawing.Size(72, 36)
        Me.lblHollow13.TabIndex = 26
        Me.lblHollow13.Text = "13"
        Me.lblHollow13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnResetBoard
        '
        Me.btnResetBoard.BackColor = System.Drawing.SystemColors.Control
        Me.btnResetBoard.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnResetBoard.Location = New System.Drawing.Point(700, 20)
        Me.btnResetBoard.Name = "btnResetBoard"
        Me.btnResetBoard.Size = New System.Drawing.Size(100, 25)
        Me.btnResetBoard.TabIndex = 27
        Me.btnResetBoard.Text = "Reset Game"
        Me.btnResetBoard.UseVisualStyleBackColor = False
        '
        'btnPreviousBoard
        '
        Me.btnPreviousBoard.BackColor = System.Drawing.SystemColors.Control
        Me.btnPreviousBoard.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnPreviousBoard.Location = New System.Drawing.Point(400, 20)
        Me.btnPreviousBoard.Name = "btnPreviousBoard"
        Me.btnPreviousBoard.Size = New System.Drawing.Size(100, 25)
        Me.btnPreviousBoard.TabIndex = 28
        Me.btnPreviousBoard.Text = "Previous Turn"
        Me.btnPreviousBoard.UseVisualStyleBackColor = False
        '
        'lblPlayerMsg
        '
        Me.lblPlayerMsg.BackColor = System.Drawing.Color.SaddleBrown
        Me.lblPlayerMsg.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPlayerMsg.ForeColor = System.Drawing.Color.White
        Me.lblPlayerMsg.Location = New System.Drawing.Point(250, 219)
        Me.lblPlayerMsg.Name = "lblPlayerMsg"
        Me.lblPlayerMsg.Size = New System.Drawing.Size(700, 22)
        Me.lblPlayerMsg.TabIndex = 29
        Me.lblPlayerMsg.Text = "Player 1's turn..."
        Me.lblPlayerMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GameWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(1184, 461)
        Me.Controls.Add(Me.lblPlayerMsg)
        Me.Controls.Add(Me.btnPreviousBoard)
        Me.Controls.Add(Me.btnResetBoard)
        Me.Controls.Add(Me.lblHollow13)
        Me.Controls.Add(Me.lblHollow6)
        Me.Controls.Add(Me.btnMenu)
        Me.Name = "GameWindow"
        Me.Text = "GameWindow"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnMenu As Button
    Friend WithEvents lblHollow9 As Label
    Friend WithEvents lblHollow8 As Label
    Friend WithEvents lblHollow7 As Label
    Friend WithEvents lblHollow6 As Label
    Friend WithEvents lblHollow12 As Label
    Friend WithEvents lblHollow11 As Label
    Friend WithEvents lblHollow10 As Label
    Friend WithEvents lblHollow13 As Label
    Friend WithEvents btnResetBoard As Button
    Friend WithEvents btnPreviousBoard As Button
    Friend WithEvents lblPlayerMsg As Label
    Friend WithEvents Hole1 As Hole
End Class

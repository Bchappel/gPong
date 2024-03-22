<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.pbArena = New System.Windows.Forms.PictureBox()
        Me.pbBall = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pbPaddle = New System.Windows.Forms.PictureBox()
        Me.lblLives = New System.Windows.Forms.Label()
        CType(Me.pbArena, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPaddle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbArena
        '
        Me.pbArena.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pbArena.Location = New System.Drawing.Point(59, 8)
        Me.pbArena.Name = "pbArena"
        Me.pbArena.Size = New System.Drawing.Size(1284, 694)
        Me.pbArena.TabIndex = 0
        Me.pbArena.TabStop = False
        '
        'pbBall
        '
        Me.pbBall.Location = New System.Drawing.Point(661, 355)
        Me.pbBall.Name = "pbBall"
        Me.pbBall.Size = New System.Drawing.Size(50, 50)
        Me.pbBall.TabIndex = 1
        Me.pbBall.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 20
        '
        'pbPaddle
        '
        Me.pbPaddle.Location = New System.Drawing.Point(568, 682)
        Me.pbPaddle.Name = "pbPaddle"
        Me.pbPaddle.Size = New System.Drawing.Size(275, 20)
        Me.pbPaddle.TabIndex = 2
        Me.pbPaddle.TabStop = False
        '
        'lblLives
        '
        Me.lblLives.AutoSize = True
        Me.lblLives.Location = New System.Drawing.Point(1208, 42)
        Me.lblLives.Name = "lblLives"
        Me.lblLives.Size = New System.Drawing.Size(13, 13)
        Me.lblLives.TabIndex = 3
        Me.lblLives.Text = "3"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1355, 714)
        Me.Controls.Add(Me.lblLives)
        Me.Controls.Add(Me.pbPaddle)
        Me.Controls.Add(Me.pbBall)
        Me.Controls.Add(Me.pbArena)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pbArena, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPaddle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbArena As System.Windows.Forms.PictureBox
    Friend WithEvents pbBall As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents pbPaddle As System.Windows.Forms.PictureBox
    Friend WithEvents lblLives As System.Windows.Forms.Label

End Class

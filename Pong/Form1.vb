Public Class Form1
    Dim xVel As Integer = 10
    Dim yVel As Integer = 10
    'paddle
    Dim padVel As Integer = 15
    Dim padLeft As Boolean = False
    Dim padRight As Boolean = False
    'Lives
    Dim lives As Integer = 3



    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        pbBall.Left = pbBall.Left + xVel
        pbBall.Top = pbBall.Top + yVel

        'Bounce Code
        If pbBall.Bottom >= pbArena.Bottom Then
            yVel *= -1
            lives -= 1
            lblLives.Text = lives
        End If

        If pbBall.Right >= pbArena.Right Then
            xVel *= -1
        End If


        If pbBall.Top <= pbArena.Top Then
            yVel *= -1
        End If

        If pbBall.Left <= pbArena.Left Then
            xVel *= -1
        End If

        ' paddle code #######################################################################################################################

        If padRight = True And pbPaddle.Right <= pbArena.Right Then
            pbPaddle.Left += padVel
        End If

        If padLeft = True And pbPaddle.Left >= pbArena.Left Then
            pbPaddle.Left -= padVel
        End If

        ' paddle ball clipping ###############################################################################################################

        If pbBall.Bounds.IntersectsWith(pbPaddle.Bounds) Then
            yVel *= -1
        End If




    End Sub

    Private Sub Form1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyData = Keys.Left Then
            padLeft = True
            padRight = False
        End If

        If e.KeyData = Keys.Right Then
            padRight = True
            padLeft = False
        End If
    End Sub

    Private Sub Form1_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyData = Keys.Left Then
            padLeft = False
        End If

        If e.KeyData = Keys.Right Then
            padRight = False
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

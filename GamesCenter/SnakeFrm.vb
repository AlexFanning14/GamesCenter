Public Class SnakeFrm

#Region "Varaibles"

    Dim direction As String
    Dim x As Integer
    Dim y As Integer
    Dim xP As Integer
    Dim yP As Integer
    Dim locationsX As New List(Of Integer)
    Dim locationsY As New List(Of Integer)
    Dim snakes As New List(Of Panel)
    Dim score As Integer
#End Region

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Start()

    End Sub

    Private Sub Start()
        Timer1.Stop()

        Timer1.Start()

        direction = "Right"

        Timer1.Enabled = True

    End Sub




    Private Sub moveIt(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim a = Me.Size

        x = Snake.Location.X

        y = Snake.Location.Y


        If direction = "Right" Then

            Snake.Location = New System.Drawing.Point(x + 40, y)

        End If

        If direction = "Left" Then

            Snake.Location = New System.Drawing.Point(x - 40, y)

        End If

        If direction = "Down" Then

            Snake.Location = New System.Drawing.Point(x, y + 40)

        End If

        If direction = "Up" Then

            Snake.Location = New System.Drawing.Point(x, y - 40)

        End If

        If Snake.Location.X >= 600 Then 'AndAlso direction = "Right" Then

            Snake.Location = New Point(0, Snake.Location.Y)

        End If

        If Snake.Location.X <= -40 Then 'AndAlso direction = "Left" Then

            Snake.Location = New Point(600, Snake.Location.Y)

        End If

        If Snake.Location.Y >= 600 Then 'AndAlso direction = "Down" Then

            Snake.Location = New Point(Snake.Location.X, 0)

        End If

        If Snake.Location.Y <= -40 Then 'AndAlso direction = "Up" Then

            Snake.Location = New Point(Snake.Location.X, 600)

        End If

        xP = Panel1.Location.X

        yP = Panel1.Location.Y



        If ((x - xP < 10 And x - xP > -10) And (y - yP < 10 And y - yP > -10)) Then

            hit()

        End If

        locationsX.Add(x)

        locationsY.Add(y)

        If snakes.Count > 0 Then

            Dim i As Integer = 1

            For Each panel In snakes

                panel.Location = New Point(locationsX(locationsX.Count - i), locationsY(locationsY.Count - i))

                i += 1

            Next

        End If

        For Each panel In snakes
            If Snake.Location = panel.Location Then
                gameOver()
                Exit Sub
            End If
        Next
    End Sub



    Private Sub gameOver()

        Timer1.Stop()

        MsgBox("Game over! Score of " & score)
        score = 0
        Timer1.Interval = 100
        For Each panel In snakes
            Me.Controls.Remove(panel)
        Next
        snakes.Clear()
        Start()

    End Sub

    Private Sub hit()

        xP = RandomNumber(50, 530)

        yP = RandomNumber(50, 530)

        Panel1.Location = New System.Drawing.Point(xP, yP)

        Dim panel As New Panel

        panel.Size = Panel1.Size

        panel.Location = New Point(locationsX(locationsX.Count - 2), locationsY(locationsY.Count - 2))

        Me.Controls.Add(panel)

        panel.BackColor = Snake.BackColor

        snakes.Add(panel)

        Timer1.Interval = Timer1.Interval - 1

        score += 100

        lblScoreCount.Text = score
    End Sub





    Private Function RandomNumber(min As Integer, max As Integer) As Integer

        Dim random As New Random(Guid.NewGuid().GetHashCode())
        Randomize()
        Dim num As Integer = random.Next(min, max)
        Return Math.Round(num / 40) * 40

    End Function





    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.Right AndAlso direction <> "Left" Then

            direction = "Right"

        End If

        If e.KeyCode = Keys.Left AndAlso direction <> "Right" Then

            direction = "Left"

        End If

        If e.KeyCode = Keys.Down AndAlso direction <> "Up" Then

            direction = "Down"

        End If

        If e.KeyCode = Keys.Up AndAlso direction <> "Down" Then

            direction = "Up"

        End If

    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Me.Dispose()
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()

    End Sub
End Class

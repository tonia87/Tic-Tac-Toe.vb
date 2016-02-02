Public Class frmPlay
    Dim a As Player
    Dim b As Player
    'keep who's turn
    Dim turn As Integer = 0
    'keep id of winner
    Dim winner As Integer = 0
    'keep value of winner is or not
    Dim equal As Boolean = False
    Dim valueBtn1 As Integer = 1
    Dim valueBtn2 As Integer = 2
    Dim valueBtn3 As Integer = 3
    Dim valueBtn4 As Integer = 4
    Dim valueBtn5 As Integer = 5
    Dim valueBtn6 As Integer = 6
    Dim valueBtn7 As Integer = 7
    Dim valueBtn8 As Integer = 8
    Dim valueBtn9 As Integer = 9



    Private Sub frmPlay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Me.BackgroundImage = My.Resources.moon

        setNewGame()

    End Sub

    Private Sub setNewGame()

        'a = New Player(1, "X")
        'b = New Player(2, "O")

        'CONSTRUCTOR NEW(INTEGER,BITMAP)
        a = New Player(1, My.Resources.x)
        b = New Player(2, My.Resources.o)

        turn = 1

        'btnArray(1, 1) = btn1
        'btnArray(1, 2) = btn2
        'btnArray(1, 3) = btn3
        'btnArray(2, 1) = btn4
        'btnArray(2, 2) = btn5
        'btnArray(2, 3) = btn6
        'btnArray(3, 1) = btn7
        'btnArray(3, 2) = btn8
        'btnArray(3, 3) = btn9


        'btn1.Text = "1"
        'btn2.Text = "2"
        'btn3.Text = "3"
        'btn4.Text = "4"
        'btn5.Text = "5"
        'btn6.Text = "6"
        'btn7.Text = "7"
        'btn8.Text = "8"
        'btn9.Text = "9"

        btn1.BackgroundImageLayout = ImageLayout.Stretch
        btn2.BackgroundImageLayout = ImageLayout.Stretch
        btn3.BackgroundImageLayout = ImageLayout.Stretch
        btn4.BackgroundImageLayout = ImageLayout.Stretch
        btn5.BackgroundImageLayout = ImageLayout.Stretch
        btn6.BackgroundImageLayout = ImageLayout.Stretch
        btn7.BackgroundImageLayout = ImageLayout.Stretch
        btn8.BackgroundImageLayout = ImageLayout.Stretch
        btn9.BackgroundImageLayout = ImageLayout.Stretch

        btn1.BackgroundImage = My.Resources._3
        btn2.BackgroundImage = My.Resources._2
        btn3.BackgroundImage = My.Resources._1
        btn4.BackgroundImage = My.Resources._4
        btn5.BackgroundImage = My.Resources._5
        btn6.BackgroundImage = My.Resources._6
        btn7.BackgroundImage = My.Resources._7
        btn8.BackgroundImage = My.Resources._8
        btn9.BackgroundImage = My.Resources._9


        lblPLayer.Text = "Next: Player 1"
        lblMessage.Text = "Game initialized..."
        'DELETED
        'lblScoreA.Text = "Score Player 1: "
        'lblScoreB.Text = "Score Player 2: "


    End Sub




    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        btn1.BackgroundImage = ShowOnScreen(turn, 1)
        equal = WinCheck()
        btn1.Enabled = False
        If (equal = False) Then
            'first print turn
            ExchangeTurn()
            'then print equal if exists
            CheckEqual()
        End If


    End Sub

   

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        btn2.BackgroundImage = ShowOnScreen(turn, 2)
        equal = WinCheck()
        btn2.Enabled = False
        If (equal = False) Then
            ExchangeTurn()
            CheckEqual()
        End If


    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        btn3.BackgroundImage = ShowOnScreen(turn, 3)
        equal = WinCheck()
        btn3.Enabled = False
        If (equal = False) Then
            ExchangeTurn()
            CheckEqual()
        End If


    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        btn4.BackgroundImage = ShowOnScreen(turn, 4)
        equal = WinCheck()
        btn4.Enabled = False
        If (equal = False) Then
            ExchangeTurn()
            CheckEqual()
        End If


    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        btn5.BackgroundImage = ShowOnScreen(turn, 5)
        equal = WinCheck()
        btn5.Enabled = False
        If (equal = False) Then
            ExchangeTurn()
            CheckEqual()
        End If


    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        btn6.BackgroundImage = ShowOnScreen(turn, 6)
        equal = WinCheck()
        btn6.Enabled = False
        If (equal = False) Then
            ExchangeTurn()
            CheckEqual()
        End If


    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        btn9.BackgroundImage = ShowOnScreen(turn, 9)
        equal = WinCheck()

        btn9.Enabled = False
        If (equal = False) Then
            ExchangeTurn()
            CheckEqual()
        End If



    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        btn8.BackgroundImage = ShowOnScreen(turn, 8)
        equal = WinCheck()
        btn8.Enabled = False
        If (equal = False) Then
            ExchangeTurn()
            CheckEqual()

        End If


    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        btn7.BackgroundImage = ShowOnScreen(turn, 7)
        equal = WinCheck()
        btn7.Enabled = False
        If (equal = False) Then
            ExchangeTurn()
            CheckEqual()

        End If


    End Sub

    Private Sub ExchangeTurn()
        If (turn = 1) Then
            turn = 2

        Else
            turn = 1
        End If
        lblPLayer.Text = "Next: Player " + turn.ToString()
    End Sub
    Private Function WinCheck()
        'If (btnArray(1, 1).BackgroundImage Is btnArray(2, 2).BackgroundImage) And (btnArray(2, 2).BackgroundImage Is btnArray(3, 3).BackgroundImage) Then
        '    LockScreen()
        '    Return True
        '    Exit Function
        'COMPARISON OF PICTS NEEDS METHOD

        'ElseIf (btnArray(3, 1).BackgroundImage Is btnArray(2, 2).BackgroundImage) And (btnArray(2, 2).BackgroundImage Is btnArray(1, 3).BackgroundImage) Then
        '    LockScreen()
        '    Return True
        '    Exit Function


        'ElseIf (btnArray(1, 1).BackgroundImage Is btnArray(2, 1).BackgroundImage) And (btnArray(2, 1).BackgroundImage Is btnArray(3, 1).BackgroundImage) Then
        '    LockScreen()
        '    Return True
        '    Exit Function

        'ElseIf (btnArray(1, 1).BackgroundImage Is btnArray(1, 2).BackgroundImage) And (btnArray(1, 2).BackgroundImage Is btnArray(1, 3).BackgroundImage) Then
        '    LockScreen()
        '    Return True
        '    Exit Function

        'ElseIf (btnArray(1, 2).BackgroundImage Is btnArray(2, 2).BackgroundImage) And (btnArray(2, 2).BackgroundImage Is btnArray(3, 2).BackgroundImage) Then
        '    winner = turn
        '    LockScreen()
        '    Return True
        '    Exit Function

        'ElseIf (btnArray(1, 3).BackgroundImage Is btnArray(2, 3).BackgroundImage) And (btnArray(2, 3).BackgroundImage Is btnArray(3, 3).BackgroundImage) Then
        '    LockScreen()
        '    Return True
        '    Exit Function

        'ElseIf (btnArray(2, 1).BackgroundImage Is btnArray(2, 2).BackgroundImage) And (btnArray(2, 2).BackgroundImage Is btnArray(2, 3).BackgroundImage) Then
        '    LockScreen()
        '    Return True
        '    Exit Function

        'ElseIf (btnArray(3, 1).BackgroundImage Is btnArray(3, 2).BackgroundImage) And (btnArray(3, 2).BackgroundImage Is btnArray(3, 3).BackgroundImage) Then
        '    LockScreen()
        '    Return True
        '    Exit Function
        'Else
        '    Return False
        'End If
        If (valueBtn1 + valueBtn2 + valueBtn3 = 258) Or (valueBtn1 + valueBtn2 + valueBtn3 = 261) Then
            LockScreen()
            Return True
            Exit Function
        ElseIf (valueBtn4 + valueBtn5 + valueBtn6 = 258) Or (valueBtn4 + valueBtn5 + valueBtn6 = 261) Then
            LockScreen()
            Return True
            Exit Function
        ElseIf (valueBtn7 + valueBtn8 + valueBtn9 = 258) Or (valueBtn7 + valueBtn8 + valueBtn9 = 261) Then
            LockScreen()
            Return True
            Exit Function
        ElseIf (valueBtn1 + valueBtn5 + valueBtn9 = 258) Or (valueBtn1 + valueBtn5 + valueBtn9 = 261) Then
            LockScreen()
            Return True
            Exit Function
        ElseIf (valueBtn7 + valueBtn5 + valueBtn3 = 258) Or (valueBtn7 + valueBtn5 + valueBtn3 = 261) Then
            LockScreen()
            Return True
            Exit Function
        ElseIf (valueBtn1 + valueBtn4 + valueBtn7 = 258) Or (valueBtn1 + valueBtn4 + valueBtn7 = 261) Then
            LockScreen()
            Return True
            Exit Function
        ElseIf (valueBtn2 + valueBtn5 + valueBtn8 = 258) Or (valueBtn2 + valueBtn5 + valueBtn8 = 261) Then
            LockScreen()
            Return True
            Exit Function
        ElseIf (valueBtn3 + valueBtn6 + valueBtn9 = 258) Or (valueBtn3 + valueBtn6 + valueBtn9 = 261) Then
            LockScreen()
            Return True
            Exit Function
        Else
            Return False

        End If
    End Function

    Private Sub CheckEqual()
        If (btn1.Enabled = False) And (btn2.Enabled = False) And (btn3.Enabled = False) And (btn4.Enabled = False) And (btn5.Enabled = False) And (btn6.Enabled = False) And (btn7.Enabled = False) And (btn8.Enabled = False) And (btn9.Enabled = False) Then
            lblMessage.Text = "The game ended up in a draw !! Well done..."
            lblPLayer.Text = "Game finished..."
        End If

    End Sub
    Private Sub LockScreen()
        winner = turn

        lblMessage.Text = "We have a winner!! The winner is : Player " + winner.ToString()
        lblPLayer.Text = "Game finished..."


        btn1.Enabled = False
        btn2.Enabled = False
        btn3.Enabled = False
        btn4.Enabled = False
        btn5.Enabled = False
        btn6.Enabled = False
        btn7.Enabled = False
        btn8.Enabled = False
        btn9.Enabled = False
    End Sub

    Private Sub lblMessage_Click(sender As Object, e As EventArgs) Handles lblMessage.Click

    End Sub

    Private Function ShowOnScreen(t As Integer, pressed As Integer)
        'FOR TURN OF FIRST PLAYER CHANGE VALUE_BTN,RETURN IMAGE
        If (t = 1) Then
            If (pressed = 1) Then
                valueBtn1 = 86
            ElseIf (pressed = 2) Then
                valueBtn2 = 86
            ElseIf (pressed = 3) Then
                valueBtn3 = 86
            ElseIf (pressed = 4) Then
                valueBtn4 = 86
            ElseIf (pressed = 5) Then
                valueBtn5 = 86
            ElseIf (pressed = 6) Then
                valueBtn6 = 86
            ElseIf (pressed = 7) Then
                valueBtn7 = 86
            ElseIf (pressed = 8) Then
                valueBtn8 = 86
            ElseIf (pressed = 9) Then
                valueBtn9 = 86
            End If

            Return My.Resources.x
            'FOR TURN OF SECOND PLAYER CHANGE VALUE_BTN,RETURN IMAGE
        Else
            If (pressed = 1) Then
                valueBtn1 = 87
            ElseIf (pressed = 2) Then
                valueBtn2 = 87
            ElseIf (pressed = 3) Then
                valueBtn3 = 87
            ElseIf (pressed = 4) Then
                valueBtn4 = 87
            ElseIf (pressed = 5) Then
                valueBtn5 = 87
            ElseIf (pressed = 6) Then
                valueBtn6 = 87
            ElseIf (pressed = 7) Then
                valueBtn7 = 87
            ElseIf (pressed = 8) Then
                valueBtn8 = 87
            ElseIf (pressed = 9) Then
                valueBtn9 = 87
            End If

            Return My.Resources.o
        End If
    End Function
End Class
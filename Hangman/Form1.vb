Public Class Form1

    Dim Word As String                      ' will hold the word to be guessed
    Dim WordLength As Integer               ' will hold the length of the word
    Dim Char1 As String                     ' will hold the first letter of the word
    Dim Char2 As String                     ' will hold the second letter of the word
    Dim Char3 As String                     ' will hold the third letter of the word
    Dim Char4 As String                     ' will hold the fourth letter of the word
    Dim Char5 As String                     ' will hold the fifth letter of the word
    Dim Char6 As String                     ' will hold the sixth letter of the word
    Dim GameStarted As Boolean = False      ' will switch to True when the user click on Play Button
    Dim RightTrys As Integer                ' will hold the number of the right guessed letters
    Dim WrongTrys As Integer                ' will hold the number of the wrong guessed letters
    Dim Modifier() As String = {"Battled a shark:", "Written with care:", "Ate all the sandwiches:", "Slept in:"}
    Dim Author() As String = {"Pat", "Justin"}

    'Makes the Labels
    Public Sub funstuff()

        Dim Random As New Random
        Me.Credit1.Text = Modifier(Random.Next(0, Modifier.Length)) + " " + Author(Random.Next(0, Author.Length))
        Me.Credit2.Text = Modifier(Random.Next(0, Modifier.Length)) + " " + Author(Random.Next(0, Author.Length))
    End Sub

    'Draws the starting hanger
    Public Sub DrawHanger()

        Dim pnt As Graphics
        pnt = Me.CreateGraphics
        Dim pencil As New Pen(Color.Black, 2)
        pnt.DrawLine(pencil, 46, 434, 115, 394)
        pnt.DrawLine(pencil, 115, 394, 184, 434)
        pnt.DrawLine(pencil, 115, 394, 115, 220)
        pnt.DrawLine(pencil, 115, 220, 250, 220)
        pnt.DrawLine(pencil, 250, 220, 250, 250)

    End Sub

    'Reset the game
    Public Sub resetGame()
        WrongGuessesLabel.Text = ""
        Dim pnt As Graphics
        pnt = Me.CreateGraphics
        pnt.Clear(Color.White)
        'pnt.Clear(Color.FromArgb(0, 0, 0))
        PlayButton.Visible = True
    End Sub

    'Clears the letters
    Public Sub clearLetters()
        Letter1.Text = ""
        Letter2.Text = ""
        Letter3.Text = ""
        Letter4.Text = ""
        Letter5.Text = ""
        Letter6.Text = ""
    End Sub

    'Win check
    Public Sub CheckForWinning()
        If RightTrys = WordLength Then
            MsgBox("You Won")
            resetGame()
        End If
    End Sub

    'Draws one part of the Hangman for each wrong guess
    Public Sub StartDrawingWhenLosing(ByVal trys As Integer)
        Dim pnt As Graphics
        pnt = Me.CreateGraphics
        Dim pencil As New Pen(Color.Black, 2)
        If trys = 1 Then
            pnt.DrawEllipse(pencil, 228, 250, 40, 40)
        ElseIf trys = 2 Then
            pnt.DrawLine(pencil, 248, 290, 248, 370)
        ElseIf trys = 3 Then
            pnt.DrawLine(pencil, 248, 315, 213, 293)
        ElseIf trys = 4 Then
            pnt.DrawLine(pencil, 248, 315, 283, 293)
        ElseIf trys = 5 Then
            pnt.DrawLine(pencil, 248, 369, 213, 391)
        ElseIf trys = 6 Then
            pnt.DrawLine(pencil, 248, 369, 283, 391)
            TextBox1.Clear()
            Try
                Letter1.Text = Char1
                Letter2.Text = Char2
                Letter3.Text = Char3
                Letter4.Text = Char4
                Letter5.Text = Char5
                Letter6.Text = Char6
            Catch ex As Exception
            End Try
            MsgBox("You Lose")
            resetGame()
        End If
    End Sub

   
    'assign a letter to each Char string
    Public Sub AssignLetters()
        If WordLength = 2 Then
            Char1 = Word.Chars(0).ToString.ToUpper
            Char2 = Word.Chars(1).ToString.ToUpper
        ElseIf WordLength = 3 Then
            Char1 = Word.Chars(0).ToString.ToUpper
            Char2 = Word.Chars(1).ToString.ToUpper
            Char3 = Word.Chars(2).ToString.ToUpper
        ElseIf WordLength = 4 Then
            Char1 = Word.Chars(0).ToString.ToUpper
            Char2 = Word.Chars(1).ToString.ToUpper
            Char3 = Word.Chars(2).ToString.ToUpper
            Char4 = Word.Chars(3).ToString.ToUpper
        ElseIf WordLength = 5 Then
            Char1 = Word.Chars(0).ToString.ToUpper
            Char2 = Word.Chars(1).ToString.ToUpper
            Char3 = Word.Chars(2).ToString.ToUpper
            Char4 = Word.Chars(3).ToString.ToUpper
            Char5 = Word.Chars(4).ToString.ToUpper
        ElseIf WordLength = 6 Then
            Char1 = Word.Chars(0).ToString.ToUpper
            Char2 = Word.Chars(1).ToString.ToUpper
            Char3 = Word.Chars(2).ToString.ToUpper
            Char4 = Word.Chars(3).ToString.ToUpper
            Char5 = Word.Chars(4).ToString.ToUpper
            Char6 = Word.Chars(5).ToString.ToUpper
        End If
    End Sub

    'Hide Lines that aren't needed
    Public Sub hideCharachterLength()
        Line1.Visible = False
        Line2.Visible = False
        Line3.Visible = False
        Line4.Visible = False
        Line5.Visible = False
        Line6.Visible = False
    End Sub

    'Show the length of the word to be guessed
    Public Sub ShowLength(ByVal VisibleLines As Integer)
        hideCharachterLength()
        If VisibleLines = 1 Then
            Line1.Visible = True
        ElseIf VisibleLines = 2 Then
            Line1.Visible = True
            Line2.Visible = True
        ElseIf VisibleLines = 3 Then
            Line1.Visible = True
            Line2.Visible = True
            Line3.Visible = True
        ElseIf VisibleLines = 4 Then
            Line1.Visible = True
            Line2.Visible = True
            Line3.Visible = True
            Line4.Visible = True
        ElseIf VisibleLines = 5 Then
            Line1.Visible = True
            Line2.Visible = True
            Line3.Visible = True
            Line4.Visible = True
            Line5.Visible = True
        ElseIf VisibleLines = 6 Then
            Line1.Visible = True
            Line2.Visible = True
            Line3.Visible = True
            Line4.Visible = True
            Line5.Visible = True
            Line6.Visible = True
        End If
    End Sub

    'Runs on form load
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clearLetters()
        hideCharachterLength()
        funstuff()
    End Sub

    Private Sub revealLetter(holder As Char)
        Dim rightHolder As Integer
        rightHolder = RightTrys
        If Char1 = holder Then
            Letter1.Text = Char1
            RightTrys += 1
        End If
        If Char2 = holder Then
            Letter2.Text = Char2
            RightTrys += 1
        End If
        If Char3 = holder Then
            Letter3.Text = Char3
            RightTrys += 1
        End If
        If Char4 = holder Then
            Letter4.Text = Char4
            RightTrys += 1
        End If
        If Char5 = holder Then
            Letter5.Text = Char5
            RightTrys += 1
        End If
        If Char6 = holder Then
            Letter6.Text = Char6
            RightTrys += 1
        End If
        CheckForWinning()
        If rightHolder = RightTrys Then
            WrongTrys += 1
            StartDrawingWhenLosing(WrongTrys)
            WrongGuessesLabel.Text = WrongGuessesLabel.Text & " " & TextBox1.Text
        End If
        TextBox1.Text = ""
    End Sub
    'Play Button controls
    Private Sub PlayButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlayButton.Click
        Char1 = ""
        Char2 = ""
        Char3 = ""
        Char4 = ""
        Char5 = ""
        Char6 = ""
        DrawHanger()
        Dim number As Integer
        Randomize()
        number = CInt(Math.Floor((ListBox1.Items.Count - 1) * Rnd()))
        Word = ListBox1.Items(number)
        WordLength = Word.Length
        ShowLength(Word.Length)
        clearLetters()
        AssignLetters()
        TextBox1.Focus()
        RightTrys = 0
        WrongTrys = 0
        WrongGuessesLabel.Text = "Wrong Guesses: "
        GameStarted = True
        PlayButton.Visible = False
    End Sub

    'Check to see if the textbox changed
    Private Sub guessButton1_Click(sender As Object, e As EventArgs) Handles guessButton1.Click 'Changed it to a guess button
        'Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If GameStarted = True Then
            If TextBox1.Text = "" Then
            Else
                Dim holder As String
                holder = TextBox1.Text.ToUpper
                revealLetter(holder)
                

                'If TextBox1.Text.ToUpper.Contains(Char1) And Letter1.Text = "" And Char1 <> "" Then
                '    Letter1.Text = Char1
                '    RightTrys += 1
                '    CheckForWinning()
                'ElseIf TextBox1.Text.ToUpper.Contains(Char2) And Letter2.Text = "" And Char2 <> "" Then
                '    Letter2.Text = Char2
                '    RightTrys += 1
                '    CheckForWinning()
                'ElseIf TextBox1.Text.ToUpper.Contains(Char3) And Letter3.Text = "" And Char3 <> "" Then
                '    Letter3.Text = Char3
                '    RightTrys += 1
                '    CheckForWinning()
                'ElseIf TextBox1.Text.ToUpper.Contains(Char4) And Letter4.Text = "" And Char4 <> "" Then
                '    Letter4.Text = Char4
                '    RightTrys += 1
                '    CheckForWinning()
                'ElseIf TextBox1.Text.ToUpper.Contains(Char5) And Letter5.Text = "" And Char5 <> "" Then
                '    Letter5.Text = Char5
                '    RightTrys += 1
                '    CheckForWinning()
                'ElseIf TextBox1.Text.ToUpper.Contains(Char6) And Letter6.Text = "" And Char6 <> "" Then
                '    Letter6.Text = Char6
                '    RightTrys += 1
                '    CheckForWinning()
                'Else
                '    WrongTrys += 1
                '    StartDrawingWhenLosing(WrongTrys)
                '    WrongGuessesLabel.Text = WrongGuessesLabel.Text & " " & TextBox1.Text
                'End If
            End If
        Else
        End If
        TextBox1.Text = ""
    End Sub
    'End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            guessButton1_Click(sender, e)
            'Write whatever you want here
        End If
    End Sub




End Class


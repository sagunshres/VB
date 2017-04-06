Imports System.IO

Public Class HangMan
    Dim graphic As Graphics
    Dim letters() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}
    Dim wordList As String = "wordList.txt"
    Dim wordLength As Integer
    Dim wrongAttempts, rightAttempts As Integer 'counter to check score and winner or loser
    Dim gameStarted As Boolean = False
    Dim word As String
    Dim Char1 As String                     ' will hold the first letter of the word
    Dim Char2 As String                     ' will hold the second letter of the word
    Dim Char3 As String                     ' will hold the third letter of the word
    Dim Char4 As String                     ' will hold the fourth letter of the word
    Dim Char5 As String                     ' will hold the fifth letter of the word
    Dim Char6 As String                     ' will hold the sixth letter of the word

    Private Sub HangMan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        graphic = Me.CreateGraphics() 'load graphic when the form loads
        hideWordLength() 'hides the length of word when form loads
        clearLetters() 'clears letters from the placeholder
        'loadTablePanelLetters() 'load letters into the table panel
        readScore() 'read score from file and display on form

    End Sub

    Private Sub loadTablePanelLetters()
        Dim colCount As Integer = 13
        Dim rowCount As Integer = 2

        Dim f As New System.Drawing.Font("Arial", 10)
        ' goes through the entire table panel and assigns button starting from A through Z
        For rowNo As Integer = 0 To rowCount - 1
            For columnNo As Integer = 0 To colCount - 1
                'declare new button
                Dim button1 As Control = New Button
                Dim buttonname = letters(rowNo * 13 + columnNo)
                With button1
                    .Size = New Size(30, 30)
                    .Tag = rowNo & "," & columnNo
                    .Name = buttonname
                    .Text = buttonname
                    .ForeColor = Color.DarkBlue
                    .BackColor = Color.Azure
                    .Font = f
                    .Location = New Point(rowNo + 30, columnNo + 40)
                End With
                'add handler to new button
                AddHandler button1.Click, AddressOf Button_Click
                'add button to collection of controls on form
                If gameStarted = False Then
                    tlpLetterPanel.Controls.Add(button1, columnNo, rowNo)
                Else
                    tlpLetterPanel.Controls.Clear()
                End If
            Next
        Next

    End Sub
    Private Sub loadWord()
        ' this piece of code reads list of words from a pre loaded file and picks a random word from the list of words.
        ' the random word is then split into single characters
        If File.Exists(wordList) Then
            Dim sr As StreamReader = File.OpenText(wordList)
            Dim lines As New List(Of String)
            Dim rnd As New Random
            Dim line As Integer

            While sr.Peek <> -1
                lines.Add(sr.ReadLine())
            End While
            'generate a randrom number from the total number of lines on the file
            line = rnd.Next(lines.Count + 1)
            Try
                'picks a random word from the wordlist file
                word = lines(line)
                wordLength = word.Length
            Catch ex As Exception
                Me.Close()
            End Try
            showLength(wordLength) 'displays dashed lines according to the length of word

            sr.Close()
            sr.Dispose()
        Else
            MsgBox("Couldn't find the file!")
            Me.Close()
        End If
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs)
        Dim myChar = sender.name
        sender.hide()

        Dim index As Integer
        Dim foundMatch As Boolean = False ' set flag to false and when a match is found it is set back to true
        Dim letterArray() As Char = word.ToCharArray() 'assign each letter from the word into array as separate character

        'this code snippet goes through the entire char array of letters from the word file and matches it against
        'the user input. If one or more matches are found, they are consequently displayed on their appropriate label controls
        'If match is not found, every wrong attempt triggers drawing hangman

        For i As Integer = 0 To (letterArray.Length - 1)
            If Char.ToUpper(letterArray(i)) = myChar Then
                foundMatch = True 'set to true meaning a match if found
                index = i
                Dim lblindex = i + 1 'add 1 to lblindex to match against the lblLetter naming convention
                If lblindex = 1 And lblLetter1.Text = "" Then
                    lblLetter1.Text = myChar
                    rightAttempts += 1
                    CheckForWinning()
                ElseIf lblindex = 2 And lblLetter2.Text = "" Then
                    lblLetter2.Text = myChar
                    rightAttempts += 1
                    CheckForWinning()
                ElseIf lblindex = 3 And lblLetter3.Text = "" Then
                    lblLetter3.Text = myChar
                    rightAttempts += 1
                    CheckForWinning()
                ElseIf lblindex = 4 And lblLetter4.Text = "" Then
                    lblLetter4.Text = myChar
                    rightAttempts += 1
                    CheckForWinning()
                ElseIf lblindex = 5 And lblLetter5.Text = "" Then
                    lblLetter5.Text = myChar
                    rightAttempts += 1
                    CheckForWinning()
                ElseIf lblindex = 6 And lblLetter6.Text = "" Then
                    lblLetter6.Text = myChar
                    rightAttempts += 1
                    CheckForWinning()
                End If
            End If
        Next
        If foundMatch = False Then 'match not found results into wrong attempts
            wrongAttempts += 1
            startDrawingHangman(wrongAttempts)
            lblwrongGuesses.Text = lblwrongGuesses.Text + " " & myChar
        End If

    End Sub

    Private Sub drawHanger()
        'draws hanger for the hangman gae
        Dim pencil As New Pen(Color.Black, 2)
        Try
            graphic.DrawLine(pencil, 115, 100, 88, 124)
            graphic.DrawLine(pencil, 115, 100, 134, 124)
            graphic.DrawLine(pencil, 115, 100, 115, 50)
            graphic.DrawLine(pencil, 115, 50, 250, 50)
            graphic.DrawLine(pencil, 250, 50, 250, 250)
            graphic.DrawLine(pencil, 230, 250, 270, 250)
        Catch ex As Exception
            Me.Close()
        End Try
        
    End Sub

    Private Sub btnStartGame_Click(sender As Object, e As EventArgs) Handles btnStartGame.Click
        loadWord()
        drawHanger()
        loadTablePanelLetters()

        Char1 = ""
        Char2 = ""
        Char3 = ""
        Char4 = ""
        Char5 = ""
        Char6 = ""

        assignLetters() 'assigns the letters from random picked word and assigns them into char1 through char6
        clearLetters()
        wrongAttempts = 0
        rightAttempts = 0
        btnStartGame.Visible = False
        lblwrongGuesses.Text = ""
        gameStarted = True

    End Sub

    Private Sub startDrawingHangman(ByRef trys As Integer)
        'starting drawing hangman on each wrong attempts made until the number of trys get to 6 when the game ends and the player loses
        Dim pencil As New Pen(Color.Black, 2)

        If trys = 1 Then
            graphic.DrawEllipse(pencil, 92, 110, 40, 40)
        ElseIf trys = 2 Then
            graphic.DrawLine(pencil, 115, 150, 115, 210)
        ElseIf trys = 3 Then
            graphic.DrawLine(pencil, 115, 180, 85, 150)
        ElseIf trys = 4 Then
            graphic.DrawLine(pencil, 115, 180, 145, 150)
        ElseIf trys = 5 Then
            graphic.DrawLine(pencil, 115, 210, 85, 245)
        ElseIf trys = 6 Then
            graphic.DrawLine(pencil, 115, 210, 145, 245)
            MsgBox("YOU LOSE!!!")

            findScore(wrongAttempts) 'check score

            Dim result As String = playAgain()
            If result = DialogResult.Yes Then
                loadTablePanelLetters()
                resetGame()
                lblwrongGuesses.Text = ""
            ElseIf result = DialogResult.No Then
                Me.Close()
            End If
        End If
    End Sub

    Private Sub hideWordLength()
        Line1.Visible = False
        Line2.Visible = False
        Line3.Visible = False
        Line4.Visible = False
        Line5.Visible = False
        Line6.Visible = False
    End Sub

    Private Sub showLength(visibleLines As Integer)
        If visibleLines = 1 Then
            Line1.Visible = True
        ElseIf visibleLines = 2 Then
            Line1.Visible = True
            Line2.Visible = True
        ElseIf visibleLines = 3 Then
            Line1.Visible = True
            Line2.Visible = True
            Line3.Visible = True
        ElseIf visibleLines = 4 Then
            Line1.Visible = True
            Line2.Visible = True
            Line3.Visible = True
            Line4.Visible = True
        ElseIf visibleLines = 5 Then
            Line1.Visible = True
            Line2.Visible = True
            Line3.Visible = True
            Line4.Visible = True
            Line5.Visible = True
        ElseIf visibleLines = 6 Then
            Line1.Visible = True
            Line2.Visible = True
            Line3.Visible = True
            Line4.Visible = True
            Line5.Visible = True
            Line6.Visible = True
        End If
    End Sub

    Private Sub assignLetters()
        'assigns individual characters from the word to char1 through char6 variables and changes to upper case letters
        'depending on the word length
        If wordLength = 2 Then
            Char1 = word.Chars(0).ToString.ToUpper
            Char2 = word.Chars(1).ToString.ToUpper
        ElseIf wordLength = 3 Then
            Char1 = word.Chars(0).ToString.ToUpper
            Char2 = word.Chars(1).ToString.ToUpper
            Char3 = word.Chars(2).ToString.ToUpper
        ElseIf wordLength = 4 Then
            Char1 = word.Chars(0).ToString.ToUpper
            Char2 = word.Chars(1).ToString.ToUpper
            Char3 = word.Chars(2).ToString.ToUpper
            Char4 = word.Chars(3).ToString.ToUpper
        ElseIf wordLength = 5 Then
            Char1 = word.Chars(0).ToString.ToUpper
            Char2 = word.Chars(1).ToString.ToUpper
            Char3 = word.Chars(2).ToString.ToUpper
            Char4 = word.Chars(3).ToString.ToUpper
            Char5 = word.Chars(4).ToString.ToUpper
        ElseIf wordLength = 6 Then
            Char1 = word.Chars(0).ToString.ToUpper
            Char2 = word.Chars(1).ToString.ToUpper
            Char3 = word.Chars(2).ToString.ToUpper
            Char4 = word.Chars(3).ToString.ToUpper
            Char5 = word.Chars(4).ToString.ToUpper
            Char6 = word.Chars(5).ToString.ToUpper
        End If
    End Sub

    Private Sub clearLetters()
        lblLetter1.Text = ""
        lblLetter2.Text = ""
        lblLetter3.Text = ""
        lblLetter4.Text = ""
        lblLetter5.Text = ""
        lblLetter6.Text = ""
    End Sub
    Public Sub CheckForWinning()
        'if the number of right attempts equals the word length, game ends and the user wins
        If rightAttempts = wordLength Then
            MsgBox("Bravo!!!You Won.")

            findScore(wrongAttempts) 'find winning score 

            Dim result As String = playAgain()
            If result = DialogResult.Yes Then
                loadTablePanelLetters()
                resetGame()
                lblwrongGuesses.Text = ""
            ElseIf result = DialogResult.No Then
                Me.Close()
            End If
        End If
    End Sub

    Private Sub resetGame()
        lblwrongGuesses.Text = ""
        btnStartGame.Visible = True
        hideWordLength()
        clearLetters()
        graphic.Clear(Color.FromArgb(255, 224, 192))
        gameStarted = False
    End Sub

    Private Function playAgain()
        Dim result As String = MsgBox("Would you like to play again?", MsgBoxStyle.YesNo, "HangMan Game")
        Return result
    End Function

    Private Sub findScore(attempts As Integer)
        'select case depending upon failure attempts and assign score
        Dim score As Integer
        Select Case attempts
            Case 6
                score = 0
            Case 5
                score = 2
            Case 4
                score = 4
            Case 3
                score = 6
            Case 2
                score = 8
            Case 1
                score = 9
            Case 0
                score = 10
            Case Else
        End Select

        'If current score is greater than old score, replace it with current score and save it in file
        If File.Exists("score.txt") Then
            Dim sr As StreamReader = File.OpenText("score.txt")
            Dim oldScore As Integer

            While sr.Peek <> -1
                oldScore = Int32.Parse(sr.ReadLine())
            End While
            sr.Close()
            sr.Dispose()

            If score >= oldScore Then
                Dim sw As New StreamWriter("score.txt")
                sw.WriteLine(score)

                sw.Close()
                sw.Dispose()
            End If

        Else
            MsgBox("Couldn't find the score file!")
            Me.Close()
        End If
        MsgBox("Your score is: " & score)

    End Sub

    Private Sub readScore()
        'reads score from file and displays on label control
        If File.Exists("score.txt") Then
            Dim sr As StreamReader = File.OpenText("score.txt")
            lblScore.Text = sr.ReadLine()

            sr.Close()
            sr.Dispose()
        End If
    End Sub

End Class

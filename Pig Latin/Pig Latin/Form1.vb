Public Class Piglatin
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtInput.Text = ""
        txtOutput.Text = ""
        txtInput.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnTranslate_Click() Handles btnTranslate.Click
        Dim strInput As String = txtInput.Text
        Dim strOutput As New System.Text.StringBuilder() 'use stringbuilder to generate output text string
        Dim vowels() As Char = "AEIOU".ToCharArray() 'define array to hold vowels as char
        Dim symbolsNumbers() As Char = "0123456789@#$%!&.".ToCharArray() 'define array to hold special characters 

        strOutput.Clear()
        If txtInput.Text = "" Then 'check to see if the input text area is empty and dispay message
            MsgBox("Please enter text for translation")
            txtInput.Focus()
        Else
            Dim strArray() As String = strInput.Split(" ") 'split the input string into array with blank space as delimiter
            'the following loop iterates over each word of the string and applies the pig latin rule
            'checking for vowels and consonants and special characters. String builder is used to build the final
            'out string and displayed on the text box
            For Each strElement In strArray
                Dim strFirstCharacter As String = strElement.Substring(0, 1) 'extracts the first letter from the word
                Dim prefixLength As Integer = strElement.ToUpper().IndexOfAny(vowels) 'finds the index if the word contains any vowel
                Dim symbolNumberLength As Integer = strElement.IndexOfAny(symbolsNumbers) 'finds the index if the word contains any symbol

                If symbolNumberLength <> -1 Then 'checks if the word contains any special symbol define in the symbolsNumber array
                    strOutput.Append(strElement & " ") 'if true, do nothing
                Else
                    Select Case strFirstCharacter.ToUpper() 'special character - do nothing
                        Case "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "@", "!", "&", "$", "%", "#"
                            strOutput.Append(strElement & " ")
                        Case "A", "E", "I", "O", "U" 'vowels - add way at the end
                            strOutput.Append(strElement & "way" & " ")
                        Case "B", "C", "D", "F", "G", "H", "J", "K", "L", "M", "N", "P", "Q", "R", "S", "T", "V", "W", "X", "Y", "Z"
                            If prefixLength <> -1 Then 'strips the letters before the first vowel and places it at the end of word followed by ay
                                strOutput.Append(strElement.Substring(prefixLength) & strElement.Substring(0, prefixLength) & "ay" & " ")
                            End If
                        Case Else 'no changes to the output
                            strOutput.Append(strElement & " ")
                    End Select
                End If
            Next

        End If
        txtOutput.Text = strOutput.ToString() 'writes final string to the output text box
    End Sub

    Private Sub Piglatin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtInput.Focus()
    End Sub
End Class

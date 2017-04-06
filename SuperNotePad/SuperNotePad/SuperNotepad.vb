Imports System.IO
Public Class SuperNotepad

    Private Sub SuperNotepad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'First item of combo box is selected
        ToolStripCmbFontStyle.SelectedIndex = 0
    End Sub

    Private Sub mnuFileOpen_Click(sender As Object, e As EventArgs) Handles mnuFileOpen.Click
        'checks if the text is modified first before opening openfile dialog
        Dim myFile As String
        If txtData.Modified Then
            Dim ask As MsgBoxResult
            ask = MsgBox("Do you want to save changes to this file?", MsgBoxStyle.YesNoCancel, "Open Document")
            If ask = MsgBoxResult.Yes Then 'save file if user answers yes
                dlgSaveFile.ShowDialog()
                myFile = dlgSaveFile.FileName

                Dim sw As New StreamWriter(myFile)
                sw.WriteLine(txtData.Text) 'write all the text to file
                txtData.Clear()
                sw.Close() 'close file

            ElseIf ask = MsgBoxResult.No Then 'opens openfile dialog and reads text into textfield
                If dlgOpenFile.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    myFile = dlgOpenFile.FileName

                    txtData.Text = My.Computer.FileSystem.ReadAllText(myFile)
                End If
            End If

        Else 'if text is not modified, read all text into the text area
            If dlgOpenFile.ShowDialog() = Windows.Forms.DialogResult.OK Then
                myFile = dlgOpenFile.FileName

                Dim sr As StreamReader = New StreamReader(myFile)
                While sr.Peek() <> -1 'read until the end of file
                    txtData.Text = sr.ReadToEnd()
                End While
                sr.Close() 'close file
            End If
        End If
    End Sub

    Private Sub mnuFileSave_Click(sender As Object, e As EventArgs) Handles mnuFileSave.Click
        Dim myFile As String
        'saves data from textbox to the file using streamwriter and close the filehandle sw

        dlgSaveFile.Filter = "TXT Files (*.txt)|*.txt"
        If dlgSaveFile.ShowDialog() = Windows.Forms.DialogResult.OK Then
            myFile = dlgSaveFile.FileName

            Dim sw As StreamWriter = New StreamWriter(myFile)
            sw.WriteLine(txtData.Text)
            sw.Close()
            txtData.Clear()

        End If
    End Sub

    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        Me.Close()
    End Sub

    Private Sub mnuFileNew_Click(sender As Object, e As EventArgs) Handles mnuFileNew.Click
        txtData.Clear()
        txtData.Focus()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        'copies content from selected area from the textbox to clipboard
        My.Computer.Clipboard.Clear()
        If txtData.SelectionLength > 0 Then
            My.Computer.Clipboard.SetText(txtData.SelectedText)
        Else
            MsgBox("No text is selected to copy")
        End If
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        'pastes if anything from the clipboard to textbox
        If My.Computer.Clipboard.ContainsText Then
            txtData.SelectedText = My.Computer.Clipboard.GetText
        Else
            MsgBox("Nothing in the clipboard to paste")
        End If
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        'cuts content from selected area from the textbox to clipboard
        My.Computer.Clipboard.Clear()
        If txtData.SelectionLength > 0 Then
            My.Computer.Clipboard.SetText(txtData.SelectedText)
            txtData.SelectedText = ""
        Else
            MsgBox("No text is selected to cut")
        End If
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        txtData.SelectAll()
    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        If txtData.CanUndo = True Then
            txtData.Undo()
            txtData.ClearUndo()
        End If
    End Sub

    Private Sub LeftToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LeftToolStripMenuItem.Click
        txtData.SelectionAlignment = HorizontalAlignment.Left
    End Sub

    Private Sub CenterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CenterToolStripMenuItem.Click
        txtData.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub RightToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RightToolStripMenuItem.Click
        txtData.SelectionAlignment = HorizontalAlignment.Right
    End Sub

    Private Sub FontColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontColorToolStripMenuItem.Click
        If myColorDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtData.ForeColor = myColorDialog.Color
        End If
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        If myFontDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtData.Font = myFontDialog.Font
        End If
    End Sub

    Private Sub ToolStripBold_Click(sender As Object, e As EventArgs) Handles ToolStripBold.Click
        'toggles data into the textbox between bold and existing font style
       
        If txtData.SelectionFont IsNot Nothing Then
            Dim currentFont As System.Drawing.Font = txtData.SelectionFont
            Dim newFontStyle As System.Drawing.FontStyle

            If txtData.SelectionFont.Bold = True Then
                newFontStyle = FontStyle.Regular
            Else
                newFontStyle = FontStyle.Bold
            End If
            ' Else

            txtData.SelectionFont = New Font(currentFont.FontFamily, currentFont.Size, newFontStyle)
        End If


    End Sub

    Private Sub ToolStripAlignLeft_Click(sender As Object, e As EventArgs) Handles ToolStripAlignLeft.Click
        txtData.SelectionAlignment = HorizontalAlignment.Left
    End Sub

    Private Sub ToolStripAlignCenter_Click(sender As Object, e As EventArgs) Handles ToolStripAlignCenter.Click
        txtData.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub ToolStripAlignRight_Click(sender As Object, e As EventArgs) Handles ToolStripAlignRight.Click
        txtData.SelectionAlignment = HorizontalAlignment.Right
    End Sub

    Private Sub ToolStripItalic_Click(sender As Object, e As EventArgs) Handles ToolStripItalic.Click
        'toggles data into the textbox between italic and existing font style
        If txtData.SelectionFont IsNot Nothing Then
            Dim currentFont As System.Drawing.Font = txtData.SelectionFont
            Dim newFontStyle As System.Drawing.FontStyle

            If txtData.SelectionFont.Italic = True Then
                newFontStyle = FontStyle.Regular
            Else
                newFontStyle = FontStyle.Italic
            End If

            txtData.SelectionFont = New Font(currentFont.FontFamily, currentFont.Size, newFontStyle)
        End If
    End Sub

    Private Sub ToolStripUnderline_Click(sender As Object, e As EventArgs) Handles ToolStripUnderline.Click
        'toggles data into the textbox between underline and existing font style
        If txtData.SelectionFont IsNot Nothing Then
            Dim currentFont As System.Drawing.Font = txtData.SelectionFont
            Dim newFontStyle As System.Drawing.FontStyle

            If txtData.SelectionFont.Underline = True Then
                newFontStyle = FontStyle.Regular
            Else
                newFontStyle = FontStyle.Underline
            End If

            txtData.SelectionFont = New Font(currentFont.FontFamily, currentFont.Size, newFontStyle)
        End If
    End Sub

 
    Private Sub ToolStripSave_Click(sender As Object, e As EventArgs) Handles ToolStripSave.Click
        'saves data from textbox to the file using streamwriter and close the filehandle sw
        Dim myFile As String

        dlgSaveFile.Filter = "TXT Files (*.txt)|*.txt" 'offers .txt as file extension
        If dlgSaveFile.ShowDialog() = Windows.Forms.DialogResult.OK Then
            myFile = dlgSaveFile.FileName

            Dim sw As StreamWriter = New StreamWriter(myFile)
            sw.WriteLine(txtData.Text)
            sw.Close()
            txtData.Clear()

        End If
    End Sub

    Private Sub FindToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindToolStripMenuItem.Click
        'finds the search string against the contents in the text box
        Dim searchText As String = Interaction.InputBox("Enter you search keyword", "Search Keyword", "Enter Here")

        If searchText.Length > 0 Then
            ' Obtain the location of the search string in rich textbox
            Dim indexToText As Integer = txtData.Find(searchText)
            If Not indexToText > 0 Then
                MsgBox("Your search string could not be found!")
            End If
        Else
            MsgBox("Enter your search keyword")
        End If

    End Sub

    Private Sub ToolStripCmbFontStyle_Click(sender As Object, e As EventArgs) Handles ToolStripCmbFontStyle.Click
        'applies font style to the textbox contents from combo box
        Dim comboFonts As System.Drawing.Font
        comboFonts = txtData.SelectionFont
        txtData.SelectionFont = New System.Drawing.Font(ToolStripCmbFontStyle.Text, txtData.SelectionFont.Size, txtData.SelectionFont.Style)
    End Sub

    Private Sub ToolStripCmbFontStyle_TextChanged(sender As Object, e As EventArgs) Handles ToolStripCmbFontStyle.TextChanged
        'applies font style to the textbox contents from combo box
        Dim comboFonts As System.Drawing.Font
        comboFonts = txtData.SelectionFont
        txtData.SelectionFont = New System.Drawing.Font(ToolStripCmbFontStyle.Text, txtData.SelectionFont.Size, txtData.SelectionFont.Style)
    End Sub

    Private Sub ToolStripFontSize_Click(sender As Object, e As EventArgs) Handles ToolStripFontSizeIncrease.Click
        'increases font size by 2
        txtData.Font = New Font(txtData.Font.FontFamily, txtData.Font.Size + 2, txtData.Font.Style)
    End Sub

    Private Sub ToolStripFontSizeDecrease_Click(sender As Object, e As EventArgs) Handles ToolStripFontSizeDecrease.Click
        'decreases font size by 2
        txtData.Font = New Font(txtData.Font.FontFamily, txtData.Font.Size - 2, txtData.Font.Style)
    End Sub

    Private Sub ToolStripUndo_Click(sender As Object, e As EventArgs) Handles ToolStripUndo.Click
        If txtData.CanUndo = True Then
            txtData.Undo()
            txtData.ClearUndo()
        End If
    End Sub

    Private Sub BackColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackColorToolStripMenuItem.Click
        If myColorDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtData.BackColor = myColorDialog.Color
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim softwareInfo As String = "This SuperNotepad software is developed as part of project for Certificate in Programming IV course." & _
        "It is developed in Microsoft Visual Studio Premium 2012 to demonstrate the basic understandability of the visual basics programming language." & _
            "The software is targeted for beginners who are learning to use computers and word as it provides limited functionality as compared to other word processing softwares."


        MsgBox(softwareInfo, MsgBoxStyle.Information, "SuperNotepad")
    End Sub
End Class
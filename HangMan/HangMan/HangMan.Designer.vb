<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HangMan
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
        Me.tlpLetterPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.btnStartGame = New System.Windows.Forms.Button()
        Me.lblLetter1 = New System.Windows.Forms.Label()
        Me.lblLetter2 = New System.Windows.Forms.Label()
        Me.lblLetter3 = New System.Windows.Forms.Label()
        Me.lblLetter4 = New System.Windows.Forms.Label()
        Me.lblLetter5 = New System.Windows.Forms.Label()
        Me.lblLetter6 = New System.Windows.Forms.Label()
        Me.Line1 = New System.Windows.Forms.Button()
        Me.Line2 = New System.Windows.Forms.Button()
        Me.Line3 = New System.Windows.Forms.Button()
        Me.Line4 = New System.Windows.Forms.Button()
        Me.Line5 = New System.Windows.Forms.Button()
        Me.Line6 = New System.Windows.Forms.Button()
        Me.wrongGuess = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblwrongGuesses = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tlpLetterPanel
        '
        Me.tlpLetterPanel.ColumnCount = 13
        Me.tlpLetterPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpLetterPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpLetterPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpLetterPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpLetterPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpLetterPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpLetterPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41.0!))
        Me.tlpLetterPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 39.0!))
        Me.tlpLetterPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpLetterPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpLetterPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpLetterPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpLetterPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.tlpLetterPanel.Location = New System.Drawing.Point(16, 422)
        Me.tlpLetterPanel.Name = "tlpLetterPanel"
        Me.tlpLetterPanel.RowCount = 2
        Me.tlpLetterPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpLetterPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpLetterPanel.Size = New System.Drawing.Size(525, 100)
        Me.tlpLetterPanel.TabIndex = 1
        '
        'btnStartGame
        '
        Me.btnStartGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStartGame.Location = New System.Drawing.Point(204, 368)
        Me.btnStartGame.Name = "btnStartGame"
        Me.btnStartGame.Size = New System.Drawing.Size(134, 37)
        Me.btnStartGame.TabIndex = 0
        Me.btnStartGame.Text = "Start Game"
        Me.btnStartGame.UseVisualStyleBackColor = True
        '
        'lblLetter1
        '
        Me.lblLetter1.AutoSize = True
        Me.lblLetter1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetter1.Location = New System.Drawing.Point(146, 319)
        Me.lblLetter1.Name = "lblLetter1"
        Me.lblLetter1.Size = New System.Drawing.Size(0, 36)
        Me.lblLetter1.TabIndex = 3
        '
        'lblLetter2
        '
        Me.lblLetter2.AutoSize = True
        Me.lblLetter2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetter2.Location = New System.Drawing.Point(188, 319)
        Me.lblLetter2.Name = "lblLetter2"
        Me.lblLetter2.Size = New System.Drawing.Size(0, 36)
        Me.lblLetter2.TabIndex = 4
        '
        'lblLetter3
        '
        Me.lblLetter3.AutoSize = True
        Me.lblLetter3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetter3.Location = New System.Drawing.Point(230, 319)
        Me.lblLetter3.Name = "lblLetter3"
        Me.lblLetter3.Size = New System.Drawing.Size(0, 36)
        Me.lblLetter3.TabIndex = 5
        '
        'lblLetter4
        '
        Me.lblLetter4.AutoSize = True
        Me.lblLetter4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetter4.Location = New System.Drawing.Point(272, 319)
        Me.lblLetter4.Name = "lblLetter4"
        Me.lblLetter4.Size = New System.Drawing.Size(0, 36)
        Me.lblLetter4.TabIndex = 6
        '
        'lblLetter5
        '
        Me.lblLetter5.AutoSize = True
        Me.lblLetter5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetter5.Location = New System.Drawing.Point(314, 319)
        Me.lblLetter5.Name = "lblLetter5"
        Me.lblLetter5.Size = New System.Drawing.Size(0, 36)
        Me.lblLetter5.TabIndex = 7
        '
        'lblLetter6
        '
        Me.lblLetter6.AutoSize = True
        Me.lblLetter6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetter6.Location = New System.Drawing.Point(356, 319)
        Me.lblLetter6.Name = "lblLetter6"
        Me.lblLetter6.Size = New System.Drawing.Size(0, 36)
        Me.lblLetter6.TabIndex = 8
        '
        'Line1
        '
        Me.Line1.Enabled = False
        Me.Line1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Line1.Location = New System.Drawing.Point(152, 353)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(25, 2)
        Me.Line1.TabIndex = 9
        Me.Line1.Text = "Button1"
        Me.Line1.UseVisualStyleBackColor = True
        '
        'Line2
        '
        Me.Line2.Enabled = False
        Me.Line2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Line2.Location = New System.Drawing.Point(194, 353)
        Me.Line2.Name = "Line2"
        Me.Line2.Size = New System.Drawing.Size(25, 2)
        Me.Line2.TabIndex = 10
        Me.Line2.Text = "Button2"
        Me.Line2.UseVisualStyleBackColor = True
        '
        'Line3
        '
        Me.Line3.Enabled = False
        Me.Line3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Line3.Location = New System.Drawing.Point(236, 353)
        Me.Line3.Name = "Line3"
        Me.Line3.Size = New System.Drawing.Size(25, 2)
        Me.Line3.TabIndex = 11
        Me.Line3.Text = "Button3"
        Me.Line3.UseVisualStyleBackColor = True
        '
        'Line4
        '
        Me.Line4.Enabled = False
        Me.Line4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Line4.Location = New System.Drawing.Point(278, 353)
        Me.Line4.Name = "Line4"
        Me.Line4.Size = New System.Drawing.Size(25, 2)
        Me.Line4.TabIndex = 12
        Me.Line4.Text = "Button4"
        Me.Line4.UseVisualStyleBackColor = True
        '
        'Line5
        '
        Me.Line5.Enabled = False
        Me.Line5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Line5.Location = New System.Drawing.Point(318, 353)
        Me.Line5.Name = "Line5"
        Me.Line5.Size = New System.Drawing.Size(25, 2)
        Me.Line5.TabIndex = 13
        Me.Line5.Text = "Button5"
        Me.Line5.UseVisualStyleBackColor = True
        '
        'Line6
        '
        Me.Line6.Enabled = False
        Me.Line6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Line6.Location = New System.Drawing.Point(362, 353)
        Me.Line6.Name = "Line6"
        Me.Line6.Size = New System.Drawing.Size(25, 2)
        Me.Line6.TabIndex = 14
        Me.Line6.Text = "Button6"
        Me.Line6.UseVisualStyleBackColor = True
        '
        'wrongGuess
        '
        Me.wrongGuess.AutoSize = True
        Me.wrongGuess.Location = New System.Drawing.Point(13, 28)
        Me.wrongGuess.Name = "wrongGuess"
        Me.wrongGuess.Size = New System.Drawing.Size(114, 17)
        Me.wrongGuess.TabIndex = 15
        Me.wrongGuess.Text = "Wrong Guesses:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(435, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 17)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Top Score: "
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.ForeColor = System.Drawing.Color.Red
        Me.lblScore.Location = New System.Drawing.Point(512, 28)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(0, 17)
        Me.lblScore.TabIndex = 17
        '
        'lblwrongGuesses
        '
        Me.lblwrongGuesses.AutoSize = True
        Me.lblwrongGuesses.ForeColor = System.Drawing.Color.Red
        Me.lblwrongGuesses.Location = New System.Drawing.Point(126, 28)
        Me.lblwrongGuesses.Name = "lblwrongGuesses"
        Me.lblwrongGuesses.Size = New System.Drawing.Size(0, 17)
        Me.lblwrongGuesses.TabIndex = 18
        '
        'HangMan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(556, 532)
        Me.Controls.Add(Me.lblwrongGuesses)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.wrongGuess)
        Me.Controls.Add(Me.Line6)
        Me.Controls.Add(Me.Line5)
        Me.Controls.Add(Me.Line4)
        Me.Controls.Add(Me.Line3)
        Me.Controls.Add(Me.Line2)
        Me.Controls.Add(Me.Line1)
        Me.Controls.Add(Me.lblLetter6)
        Me.Controls.Add(Me.lblLetter5)
        Me.Controls.Add(Me.lblLetter4)
        Me.Controls.Add(Me.lblLetter3)
        Me.Controls.Add(Me.lblLetter2)
        Me.Controls.Add(Me.lblLetter1)
        Me.Controls.Add(Me.btnStartGame)
        Me.Controls.Add(Me.tlpLetterPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "HangMan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HangMan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tlpLetterPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnStartGame As System.Windows.Forms.Button
    Friend WithEvents lblLetter1 As System.Windows.Forms.Label
    Friend WithEvents lblLetter2 As System.Windows.Forms.Label
    Friend WithEvents lblLetter3 As System.Windows.Forms.Label
    Friend WithEvents lblLetter4 As System.Windows.Forms.Label
    Friend WithEvents lblLetter5 As System.Windows.Forms.Label
    Friend WithEvents lblLetter6 As System.Windows.Forms.Label
    Friend WithEvents Line1 As System.Windows.Forms.Button
    Friend WithEvents Line2 As System.Windows.Forms.Button
    Friend WithEvents Line3 As System.Windows.Forms.Button
    Friend WithEvents Line4 As System.Windows.Forms.Button
    Friend WithEvents Line5 As System.Windows.Forms.Button
    Friend WithEvents Line6 As System.Windows.Forms.Button
    Friend WithEvents wrongGuess As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents lblwrongGuesses As System.Windows.Forms.Label

End Class

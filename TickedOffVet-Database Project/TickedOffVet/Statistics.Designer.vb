<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Statistics
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmbSpecies = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.lblShortStay = New System.Windows.Forms.Label()
        Me.lblLongStay = New System.Windows.Forms.Label()
        Me.lblAverageStay = New System.Windows.Forms.Label()
        Me.lblLowCost = New System.Windows.Forms.Label()
        Me.lblHighCost = New System.Windows.Forms.Label()
        Me.lblAverageCost = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblStay = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutTheCompanyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutTheApplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label15 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(309, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 39)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Statistics"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(11, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(426, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "This area allows you to quickly and easily view some useful "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(11, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(449, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "statistics about Ticked Off Vet regarding boarding information."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(14, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(414, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Information here can be used to make informed decisions"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Shortest Stay:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(21, 246)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 17)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Longest Stay:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(21, 279)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 17)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Average Stay:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(256, 216)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(170, 17)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Lowest Boarding Cost:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(252, 246)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(173, 17)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Highest Boarding Cost:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(248, 279)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(177, 17)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Average Boarding Cost:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(106, 330)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 17)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Species:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(71, 367)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(102, 17)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "No. of Stays:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(32, 407)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(141, 17)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Total Amount Paid:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmbSpecies
        '
        Me.cmbSpecies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSpecies.FormattingEnabled = True
        Me.cmbSpecies.Location = New System.Drawing.Point(181, 323)
        Me.cmbSpecies.Name = "cmbSpecies"
        Me.cmbSpecies.Size = New System.Drawing.Size(140, 24)
        Me.cmbSpecies.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(163, 440)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(191, 17)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "Copyright © 2013 Ticked Off "
        '
        'btnReset
        '
        Me.btnReset.ForeColor = System.Drawing.Color.Green
        Me.btnReset.Location = New System.Drawing.Point(382, 374)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(97, 35)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.ForeColor = System.Drawing.Color.Green
        Me.btnCalculate.Location = New System.Drawing.Point(382, 321)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(97, 35)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.Location = New System.Drawing.Point(178, 407)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(82, 17)
        Me.lblTotalCost.TabIndex = 21
        Me.lblTotalCost.Text = "Total Cost"
        '
        'lblShortStay
        '
        Me.lblShortStay.AutoSize = True
        Me.lblShortStay.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShortStay.Location = New System.Drawing.Point(135, 216)
        Me.lblShortStay.Name = "lblShortStay"
        Me.lblShortStay.Size = New System.Drawing.Size(66, 17)
        Me.lblShortStay.TabIndex = 22
        Me.lblShortStay.Text = "Label16"
        '
        'lblLongStay
        '
        Me.lblLongStay.AutoSize = True
        Me.lblLongStay.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLongStay.Location = New System.Drawing.Point(135, 246)
        Me.lblLongStay.Name = "lblLongStay"
        Me.lblLongStay.Size = New System.Drawing.Size(66, 17)
        Me.lblLongStay.TabIndex = 23
        Me.lblLongStay.Text = "Label17"
        '
        'lblAverageStay
        '
        Me.lblAverageStay.AutoSize = True
        Me.lblAverageStay.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverageStay.Location = New System.Drawing.Point(135, 279)
        Me.lblAverageStay.Name = "lblAverageStay"
        Me.lblAverageStay.Size = New System.Drawing.Size(66, 17)
        Me.lblAverageStay.TabIndex = 24
        Me.lblAverageStay.Text = "Label18"
        '
        'lblLowCost
        '
        Me.lblLowCost.AutoSize = True
        Me.lblLowCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLowCost.Location = New System.Drawing.Point(430, 216)
        Me.lblLowCost.Name = "lblLowCost"
        Me.lblLowCost.Size = New System.Drawing.Size(66, 17)
        Me.lblLowCost.TabIndex = 25
        Me.lblLowCost.Text = "Label19"
        '
        'lblHighCost
        '
        Me.lblHighCost.AutoSize = True
        Me.lblHighCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHighCost.Location = New System.Drawing.Point(430, 246)
        Me.lblHighCost.Name = "lblHighCost"
        Me.lblHighCost.Size = New System.Drawing.Size(66, 17)
        Me.lblHighCost.TabIndex = 26
        Me.lblHighCost.Text = "Label20"
        '
        'lblAverageCost
        '
        Me.lblAverageCost.AutoSize = True
        Me.lblAverageCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverageCost.Location = New System.Drawing.Point(430, 279)
        Me.lblAverageCost.Name = "lblAverageCost"
        Me.lblAverageCost.Size = New System.Drawing.Size(66, 17)
        Me.lblAverageCost.TabIndex = 27
        Me.lblAverageCost.Text = "Label21"
        '
        'btnBack
        '
        Me.btnBack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnBack.Location = New System.Drawing.Point(17, 32)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 73)
        Me.btnBack.TabIndex = 4
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblStay
        '
        Me.lblStay.AutoSize = True
        Me.lblStay.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStay.Location = New System.Drawing.Point(178, 367)
        Me.lblStay.Name = "lblStay"
        Me.lblStay.Size = New System.Drawing.Size(95, 17)
        Me.lblStay.TabIndex = 30
        Me.lblStay.Text = "Stay Length"
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = Global.TickedOff.My.Resources.Resources.TickedOff_Logo
        Me.PictureBox1.Location = New System.Drawing.Point(100, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(199, 73)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(510, 28)
        Me.MenuStrip1.TabIndex = 31
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutTheCompanyToolStripMenuItem, Me.AboutTheApplicationToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutTheCompanyToolStripMenuItem
        '
        Me.AboutTheCompanyToolStripMenuItem.Name = "AboutTheCompanyToolStripMenuItem"
        Me.AboutTheCompanyToolStripMenuItem.Size = New System.Drawing.Size(223, 24)
        Me.AboutTheCompanyToolStripMenuItem.Text = "About the company"
        '
        'AboutTheApplicationToolStripMenuItem
        '
        Me.AboutTheApplicationToolStripMenuItem.Name = "AboutTheApplicationToolStripMenuItem"
        Me.AboutTheApplicationToolStripMenuItem.Size = New System.Drawing.Size(223, 24)
        Me.AboutTheApplicationToolStripMenuItem.Text = "About the application"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(13, 180)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(186, 17)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "about business direction."
        '
        'Statistics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 466)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.lblStay)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblAverageCost)
        Me.Controls.Add(Me.lblHighCost)
        Me.Controls.Add(Me.lblLowCost)
        Me.Controls.Add(Me.lblAverageStay)
        Me.Controls.Add(Me.lblLongStay)
        Me.Controls.Add(Me.lblShortStay)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cmbSpecies)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Statistics"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Statistics"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmbSpecies As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lblTotalCost As System.Windows.Forms.Label
    Friend WithEvents lblShortStay As System.Windows.Forms.Label
    Friend WithEvents lblLongStay As System.Windows.Forms.Label
    Friend WithEvents lblAverageStay As System.Windows.Forms.Label
    Friend WithEvents lblLowCost As System.Windows.Forms.Label
    Friend WithEvents lblHighCost As System.Windows.Forms.Label
    Friend WithEvents lblAverageCost As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents lblStay As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutTheCompanyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutTheApplicationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label15 As System.Windows.Forms.Label
End Class

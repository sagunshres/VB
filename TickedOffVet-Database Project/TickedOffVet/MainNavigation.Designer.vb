<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainNavigation
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutTheCompanyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutTheApplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnManagePet = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnStatistics = New System.Windows.Forms.Button()
        Me.btnBoardingCalculator = New System.Windows.Forms.Button()
        Me.btnWatchVideo = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(330, 28)
        Me.MenuStrip1.TabIndex = 0
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
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(102, 24)
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
        'btnManagePet
        '
        Me.btnManagePet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnManagePet.Location = New System.Drawing.Point(60, 114)
        Me.btnManagePet.Name = "btnManagePet"
        Me.btnManagePet.Size = New System.Drawing.Size(91, 80)
        Me.btnManagePet.TabIndex = 2
        Me.btnManagePet.Text = "Manage Pet Information"
        Me.btnManagePet.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.ForeColor = System.Drawing.Color.Green
        Me.btnExport.Location = New System.Drawing.Point(186, 215)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(91, 80)
        Me.btnExport.TabIndex = 5
        Me.btnExport.Text = "Quick Export Pet Information (CSV)"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'btnStatistics
        '
        Me.btnStatistics.ForeColor = System.Drawing.Color.Green
        Me.btnStatistics.Location = New System.Drawing.Point(186, 114)
        Me.btnStatistics.Name = "btnStatistics"
        Me.btnStatistics.Size = New System.Drawing.Size(91, 80)
        Me.btnStatistics.TabIndex = 4
        Me.btnStatistics.Text = "Statistics"
        Me.btnStatistics.UseVisualStyleBackColor = True
        '
        'btnBoardingCalculator
        '
        Me.btnBoardingCalculator.ForeColor = System.Drawing.Color.Green
        Me.btnBoardingCalculator.Location = New System.Drawing.Point(60, 215)
        Me.btnBoardingCalculator.Name = "btnBoardingCalculator"
        Me.btnBoardingCalculator.Size = New System.Drawing.Size(91, 80)
        Me.btnBoardingCalculator.TabIndex = 3
        Me.btnBoardingCalculator.Text = "Boarding Cost Calculator"
        Me.btnBoardingCalculator.UseVisualStyleBackColor = True
        '
        'btnWatchVideo
        '
        Me.btnWatchVideo.ForeColor = System.Drawing.Color.Green
        Me.btnWatchVideo.Location = New System.Drawing.Point(60, 310)
        Me.btnWatchVideo.Name = "btnWatchVideo"
        Me.btnWatchVideo.Size = New System.Drawing.Size(217, 33)
        Me.btnWatchVideo.TabIndex = 6
        Me.btnWatchVideo.Text = "Watch the new promo vide!"
        Me.btnWatchVideo.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(82, 365)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(187, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Copyright © 2013 Ticked Off"
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = Global.TickedOff.My.Resources.Resources.TickedOff_Logo
        Me.PictureBox1.Location = New System.Drawing.Point(69, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(199, 73)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'MainNavigation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 385)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnWatchVideo)
        Me.Controls.Add(Me.btnBoardingCalculator)
        Me.Controls.Add(Me.btnStatistics)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.btnManagePet)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainNavigation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Navigation"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutTheCompanyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutTheApplicationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnManagePet As System.Windows.Forms.Button
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents btnStatistics As System.Windows.Forms.Button
    Friend WithEvents btnBoardingCalculator As System.Windows.Forms.Button
    Friend WithEvents btnWatchVideo As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSuperPaint
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSuperPaint))
        Me.myPictureBox = New System.Windows.Forms.PictureBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdnLine = New System.Windows.Forms.RadioButton()
        Me.rdnBrush = New System.Windows.Forms.RadioButton()
        Me.rdnEraser = New System.Windows.Forms.RadioButton()
        Me.rdnEllipse = New System.Windows.Forms.RadioButton()
        Me.rdnRectangle = New System.Windows.Forms.RadioButton()
        Me.rdnPen = New System.Windows.Forms.RadioButton()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.btnChooseColor = New System.Windows.Forms.Button()
        Me.cmbHeight = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdnFill = New System.Windows.Forms.RadioButton()
        Me.rdnOutline = New System.Windows.Forms.RadioButton()
        Me.cmbWidth = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.myToolTip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.myPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'myPictureBox
        '
        Me.myPictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.myPictureBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.myPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.myPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.myPictureBox.Location = New System.Drawing.Point(130, 66)
        Me.myPictureBox.Name = "myPictureBox"
        Me.myPictureBox.Size = New System.Drawing.Size(575, 398)
        Me.myPictureBox.TabIndex = 0
        Me.myPictureBox.TabStop = False
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(133, 484)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(127, 29)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(354, 484)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(127, 29)
        Me.btnReset.TabIndex = 2
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(578, 484)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(127, 29)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdnLine)
        Me.GroupBox1.Controls.Add(Me.rdnBrush)
        Me.GroupBox1.Controls.Add(Me.rdnEraser)
        Me.GroupBox1.Controls.Add(Me.rdnEllipse)
        Me.GroupBox1.Controls.Add(Me.rdnRectangle)
        Me.GroupBox1.Controls.Add(Me.rdnPen)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(104, 410)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selection"
        '
        'rdnLine
        '
        Me.rdnLine.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdnLine.AutoSize = True
        Me.rdnLine.Image = CType(resources.GetObject("rdnLine.Image"), System.Drawing.Image)
        Me.rdnLine.Location = New System.Drawing.Point(20, 265)
        Me.rdnLine.Name = "rdnLine"
        Me.rdnLine.Size = New System.Drawing.Size(54, 54)
        Me.rdnLine.TabIndex = 6
        Me.rdnLine.TabStop = True
        Me.myToolTip.SetToolTip(Me.rdnLine, "Line")
        Me.rdnLine.UseVisualStyleBackColor = True
        '
        'rdnBrush
        '
        Me.rdnBrush.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdnBrush.AutoSize = True
        Me.rdnBrush.Image = CType(resources.GetObject("rdnBrush.Image"), System.Drawing.Image)
        Me.rdnBrush.Location = New System.Drawing.Point(22, 81)
        Me.rdnBrush.Name = "rdnBrush"
        Me.rdnBrush.Size = New System.Drawing.Size(54, 54)
        Me.rdnBrush.TabIndex = 5
        Me.rdnBrush.TabStop = True
        Me.myToolTip.SetToolTip(Me.rdnBrush, "Brush")
        Me.rdnBrush.UseVisualStyleBackColor = True
        '
        'rdnEraser
        '
        Me.rdnEraser.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdnEraser.AutoSize = True
        Me.rdnEraser.Image = CType(resources.GetObject("rdnEraser.Image"), System.Drawing.Image)
        Me.rdnEraser.Location = New System.Drawing.Point(20, 325)
        Me.rdnEraser.Name = "rdnEraser"
        Me.rdnEraser.Size = New System.Drawing.Size(54, 54)
        Me.rdnEraser.TabIndex = 4
        Me.rdnEraser.TabStop = True
        Me.myToolTip.SetToolTip(Me.rdnEraser, "Eraser")
        Me.rdnEraser.UseVisualStyleBackColor = True
        '
        'rdnEllipse
        '
        Me.rdnEllipse.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdnEllipse.AutoSize = True
        Me.rdnEllipse.Image = CType(resources.GetObject("rdnEllipse.Image"), System.Drawing.Image)
        Me.rdnEllipse.Location = New System.Drawing.Point(20, 203)
        Me.rdnEllipse.Name = "rdnEllipse"
        Me.rdnEllipse.Size = New System.Drawing.Size(56, 56)
        Me.rdnEllipse.TabIndex = 3
        Me.rdnEllipse.TabStop = True
        Me.myToolTip.SetToolTip(Me.rdnEllipse, "Circle")
        Me.rdnEllipse.UseVisualStyleBackColor = True
        '
        'rdnRectangle
        '
        Me.rdnRectangle.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdnRectangle.AutoSize = True
        Me.rdnRectangle.Image = CType(resources.GetObject("rdnRectangle.Image"), System.Drawing.Image)
        Me.rdnRectangle.Location = New System.Drawing.Point(22, 141)
        Me.rdnRectangle.Name = "rdnRectangle"
        Me.rdnRectangle.Size = New System.Drawing.Size(56, 56)
        Me.rdnRectangle.TabIndex = 1
        Me.rdnRectangle.TabStop = True
        Me.myToolTip.SetToolTip(Me.rdnRectangle, "Rectangle")
        Me.rdnRectangle.UseVisualStyleBackColor = True
        '
        'rdnPen
        '
        Me.rdnPen.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdnPen.AutoSize = True
        Me.rdnPen.Image = CType(resources.GetObject("rdnPen.Image"), System.Drawing.Image)
        Me.rdnPen.Location = New System.Drawing.Point(22, 21)
        Me.rdnPen.Name = "rdnPen"
        Me.rdnPen.Size = New System.Drawing.Size(54, 54)
        Me.rdnPen.TabIndex = 0
        Me.rdnPen.TabStop = True
        Me.myToolTip.SetToolTip(Me.rdnPen, "Pen")
        Me.rdnPen.UseVisualStyleBackColor = True
        '
        'btnChooseColor
        '
        Me.btnChooseColor.Image = CType(resources.GetObject("btnChooseColor.Image"), System.Drawing.Image)
        Me.btnChooseColor.Location = New System.Drawing.Point(130, 1)
        Me.btnChooseColor.Name = "btnChooseColor"
        Me.btnChooseColor.Size = New System.Drawing.Size(66, 59)
        Me.btnChooseColor.TabIndex = 5
        Me.myToolTip.SetToolTip(Me.btnChooseColor, "Color Palette")
        Me.btnChooseColor.UseVisualStyleBackColor = True
        '
        'cmbHeight
        '
        Me.cmbHeight.FormattingEnabled = True
        Me.cmbHeight.ItemHeight = 16
        Me.cmbHeight.Items.AddRange(New Object() {"4", "6", "8", "10", "12", "14", "16", "18", "20", "22", "24", "30", "40", "50", "60", "70", "80", "90", "100"})
        Me.cmbHeight.Location = New System.Drawing.Point(223, 36)
        Me.cmbHeight.Name = "cmbHeight"
        Me.cmbHeight.Size = New System.Drawing.Size(75, 24)
        Me.cmbHeight.TabIndex = 6
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdnFill)
        Me.GroupBox2.Controls.Add(Me.rdnOutline)
        Me.GroupBox2.Location = New System.Drawing.Point(447, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(258, 40)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        '
        'rdnFill
        '
        Me.rdnFill.AutoSize = True
        Me.rdnFill.Location = New System.Drawing.Point(153, 13)
        Me.rdnFill.Name = "rdnFill"
        Me.rdnFill.Size = New System.Drawing.Size(46, 21)
        Me.rdnFill.TabIndex = 1
        Me.rdnFill.TabStop = True
        Me.rdnFill.Text = "Fill"
        Me.rdnFill.UseVisualStyleBackColor = True
        '
        'rdnOutline
        '
        Me.rdnOutline.AutoSize = True
        Me.rdnOutline.Location = New System.Drawing.Point(50, 13)
        Me.rdnOutline.Name = "rdnOutline"
        Me.rdnOutline.Size = New System.Drawing.Size(74, 21)
        Me.rdnOutline.TabIndex = 0
        Me.rdnOutline.TabStop = True
        Me.rdnOutline.Text = "Outline"
        Me.rdnOutline.UseVisualStyleBackColor = True
        '
        'cmbWidth
        '
        Me.cmbWidth.FormattingEnabled = True
        Me.cmbWidth.ItemHeight = 16
        Me.cmbWidth.Items.AddRange(New Object() {"4", "6", "8", "10", "12", "14", "16", "18", "20", "22", "24", "30", "40", "50", "60", "70", "80", "90", "100"})
        Me.cmbWidth.Location = New System.Drawing.Point(339, 36)
        Me.cmbWidth.Name = "cmbWidth"
        Me.cmbWidth.Size = New System.Drawing.Size(75, 24)
        Me.cmbWidth.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(220, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Width:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(336, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Height:"
        '
        'frmSuperPaint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(717, 525)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbWidth)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cmbHeight)
        Me.Controls.Add(Me.btnChooseColor)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.myPictureBox)
        Me.Name = "frmSuperPaint"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Super-Paint"
        CType(Me.myPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents myPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents rdnEraser As System.Windows.Forms.RadioButton
    Friend WithEvents rdnEllipse As System.Windows.Forms.RadioButton
    Friend WithEvents rdnRectangle As System.Windows.Forms.RadioButton
    Friend WithEvents rdnPen As System.Windows.Forms.RadioButton
    Friend WithEvents btnChooseColor As System.Windows.Forms.Button
    Friend WithEvents cmbHeight As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rdnFill As System.Windows.Forms.RadioButton
    Friend WithEvents rdnOutline As System.Windows.Forms.RadioButton
    Friend WithEvents cmbWidth As System.Windows.Forms.ComboBox
    Friend WithEvents rdnBrush As System.Windows.Forms.RadioButton
    Friend WithEvents rdnLine As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents myToolTip As System.Windows.Forms.ToolTip

End Class

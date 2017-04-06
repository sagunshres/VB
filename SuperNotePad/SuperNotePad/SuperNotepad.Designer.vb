<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SuperNotepad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SuperNotepad))
        Me.mnuMyMenu = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FindToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextAlignmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeftToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CenterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RightToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dlgOpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.dlgSaveFile = New System.Windows.Forms.SaveFileDialog()
        Me.myToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ToolStripBold = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripItalic = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripUnderline = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripUndo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripFontSizeIncrease = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripFontSizeDecrease = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripCmbFontStyle = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripAlignLeft = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripAlignCenter = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripAlignRight = New System.Windows.Forms.ToolStripButton()
        Me.myContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.myColorDialog = New System.Windows.Forms.ColorDialog()
        Me.myFontDialog = New System.Windows.Forms.FontDialog()
        Me.txtData = New System.Windows.Forms.RichTextBox()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuMyMenu.SuspendLayout()
        Me.myToolStrip.SuspendLayout()
        Me.myContextMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMyMenu
        '
        Me.mnuMyMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.EditToolStripMenuItem, Me.FormatToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.mnuMyMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnuMyMenu.Name = "mnuMyMenu"
        Me.mnuMyMenu.Size = New System.Drawing.Size(667, 28)
        Me.mnuMyMenu.TabIndex = 2
        Me.mnuMyMenu.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileNew, Me.mnuFileOpen, Me.mnuFileSave, Me.ToolStripMenuItem1, Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(44, 24)
        Me.mnuFile.Text = "File"
        '
        'mnuFileNew
        '
        Me.mnuFileNew.Name = "mnuFileNew"
        Me.mnuFileNew.Size = New System.Drawing.Size(114, 24)
        Me.mnuFileNew.Text = "&New"
        '
        'mnuFileOpen
        '
        Me.mnuFileOpen.Name = "mnuFileOpen"
        Me.mnuFileOpen.Size = New System.Drawing.Size(114, 24)
        Me.mnuFileOpen.Text = "&Open"
        '
        'mnuFileSave
        '
        Me.mnuFileSave.Name = "mnuFileSave"
        Me.mnuFileSave.Size = New System.Drawing.Size(114, 24)
        Me.mnuFileSave.Text = "&Save"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(111, 6)
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(114, 24)
        Me.mnuFileExit.Text = "&Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem, Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.SelectAllToolStripMenuItem, Me.ToolStripMenuItem2, Me.FindToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(47, 24)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(140, 24)
        Me.UndoToolStripMenuItem.Text = "Undo"
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(140, 24)
        Me.CutToolStripMenuItem.Text = "Cut"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(140, 24)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(140, 24)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(140, 24)
        Me.SelectAllToolStripMenuItem.Text = "Select &All"
        '
        'FindToolStripMenuItem
        '
        Me.FindToolStripMenuItem.Name = "FindToolStripMenuItem"
        Me.FindToolStripMenuItem.Size = New System.Drawing.Size(140, 24)
        Me.FindToolStripMenuItem.Text = "&Find"
        '
        'FormatToolStripMenuItem
        '
        Me.FormatToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FontToolStripMenuItem, Me.FontColorToolStripMenuItem, Me.TextAlignmentToolStripMenuItem, Me.BackColorToolStripMenuItem})
        Me.FormatToolStripMenuItem.Name = "FormatToolStripMenuItem"
        Me.FormatToolStripMenuItem.Size = New System.Drawing.Size(68, 24)
        Me.FormatToolStripMenuItem.Text = "Format"
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(178, 24)
        Me.FontToolStripMenuItem.Text = "Font"
        '
        'FontColorToolStripMenuItem
        '
        Me.FontColorToolStripMenuItem.Name = "FontColorToolStripMenuItem"
        Me.FontColorToolStripMenuItem.Size = New System.Drawing.Size(178, 24)
        Me.FontColorToolStripMenuItem.Text = "Font Color"
        '
        'TextAlignmentToolStripMenuItem
        '
        Me.TextAlignmentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LeftToolStripMenuItem, Me.CenterToolStripMenuItem, Me.RightToolStripMenuItem})
        Me.TextAlignmentToolStripMenuItem.Name = "TextAlignmentToolStripMenuItem"
        Me.TextAlignmentToolStripMenuItem.Size = New System.Drawing.Size(178, 24)
        Me.TextAlignmentToolStripMenuItem.Text = "Text Alignment"
        '
        'LeftToolStripMenuItem
        '
        Me.LeftToolStripMenuItem.Name = "LeftToolStripMenuItem"
        Me.LeftToolStripMenuItem.Size = New System.Drawing.Size(121, 24)
        Me.LeftToolStripMenuItem.Text = "Left"
        '
        'CenterToolStripMenuItem
        '
        Me.CenterToolStripMenuItem.Name = "CenterToolStripMenuItem"
        Me.CenterToolStripMenuItem.Size = New System.Drawing.Size(121, 24)
        Me.CenterToolStripMenuItem.Text = "Center"
        '
        'RightToolStripMenuItem
        '
        Me.RightToolStripMenuItem.Name = "RightToolStripMenuItem"
        Me.RightToolStripMenuItem.Size = New System.Drawing.Size(121, 24)
        Me.RightToolStripMenuItem.Text = "Right"
        '
        'BackColorToolStripMenuItem
        '
        Me.BackColorToolStripMenuItem.Name = "BackColorToolStripMenuItem"
        Me.BackColorToolStripMenuItem.Size = New System.Drawing.Size(178, 24)
        Me.BackColorToolStripMenuItem.Text = "Back Color"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'dlgOpenFile
        '
        Me.dlgOpenFile.FileName = "OpenFileDialog1"
        '
        'myToolStrip
        '
        Me.myToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripBold, Me.ToolStripItalic, Me.ToolStripUnderline, Me.ToolStripSave, Me.ToolStripUndo, Me.ToolStripSeparator1, Me.ToolStripFontSizeIncrease, Me.ToolStripFontSizeDecrease, Me.ToolStripCmbFontStyle, Me.ToolStripSeparator2, Me.ToolStripAlignLeft, Me.ToolStripAlignCenter, Me.ToolStripAlignRight})
        Me.myToolStrip.Location = New System.Drawing.Point(0, 28)
        Me.myToolStrip.Name = "myToolStrip"
        Me.myToolStrip.Size = New System.Drawing.Size(667, 28)
        Me.myToolStrip.TabIndex = 3
        Me.myToolStrip.Text = "ToolStrip1"
        '
        'ToolStripBold
        '
        Me.ToolStripBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripBold.Image = CType(resources.GetObject("ToolStripBold.Image"), System.Drawing.Image)
        Me.ToolStripBold.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripBold.Name = "ToolStripBold"
        Me.ToolStripBold.Size = New System.Drawing.Size(23, 25)
        Me.ToolStripBold.Text = "Bold"
        '
        'ToolStripItalic
        '
        Me.ToolStripItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripItalic.Image = CType(resources.GetObject("ToolStripItalic.Image"), System.Drawing.Image)
        Me.ToolStripItalic.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripItalic.Name = "ToolStripItalic"
        Me.ToolStripItalic.Size = New System.Drawing.Size(23, 25)
        Me.ToolStripItalic.Text = "Italic"
        '
        'ToolStripUnderline
        '
        Me.ToolStripUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripUnderline.Image = CType(resources.GetObject("ToolStripUnderline.Image"), System.Drawing.Image)
        Me.ToolStripUnderline.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripUnderline.Name = "ToolStripUnderline"
        Me.ToolStripUnderline.Size = New System.Drawing.Size(23, 25)
        Me.ToolStripUnderline.Text = "Underline"
        '
        'ToolStripSave
        '
        Me.ToolStripSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripSave.Image = CType(resources.GetObject("ToolStripSave.Image"), System.Drawing.Image)
        Me.ToolStripSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSave.Name = "ToolStripSave"
        Me.ToolStripSave.Size = New System.Drawing.Size(23, 25)
        Me.ToolStripSave.Text = "Save"
        '
        'ToolStripUndo
        '
        Me.ToolStripUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripUndo.Image = CType(resources.GetObject("ToolStripUndo.Image"), System.Drawing.Image)
        Me.ToolStripUndo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripUndo.Name = "ToolStripUndo"
        Me.ToolStripUndo.Size = New System.Drawing.Size(23, 25)
        Me.ToolStripUndo.Text = "Undo"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 28)
        '
        'ToolStripFontSizeIncrease
        '
        Me.ToolStripFontSizeIncrease.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripFontSizeIncrease.Image = CType(resources.GetObject("ToolStripFontSizeIncrease.Image"), System.Drawing.Image)
        Me.ToolStripFontSizeIncrease.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripFontSizeIncrease.Name = "ToolStripFontSizeIncrease"
        Me.ToolStripFontSizeIncrease.Size = New System.Drawing.Size(23, 25)
        Me.ToolStripFontSizeIncrease.Text = "Increase Font"
        '
        'ToolStripFontSizeDecrease
        '
        Me.ToolStripFontSizeDecrease.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripFontSizeDecrease.Image = CType(resources.GetObject("ToolStripFontSizeDecrease.Image"), System.Drawing.Image)
        Me.ToolStripFontSizeDecrease.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripFontSizeDecrease.Name = "ToolStripFontSizeDecrease"
        Me.ToolStripFontSizeDecrease.Size = New System.Drawing.Size(23, 25)
        Me.ToolStripFontSizeDecrease.Text = "Decrease Font"
        '
        'ToolStripCmbFontStyle
        '
        Me.ToolStripCmbFontStyle.Items.AddRange(New Object() {"Calibri", "Cambria", "Cambria Math", "Latin", "Microsoft Sans Serif", "MS Outlook", "Times New Roman"})
        Me.ToolStripCmbFontStyle.Name = "ToolStripCmbFontStyle"
        Me.ToolStripCmbFontStyle.Size = New System.Drawing.Size(121, 28)
        Me.ToolStripCmbFontStyle.Sorted = True
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 28)
        '
        'ToolStripAlignLeft
        '
        Me.ToolStripAlignLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripAlignLeft.Image = CType(resources.GetObject("ToolStripAlignLeft.Image"), System.Drawing.Image)
        Me.ToolStripAlignLeft.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripAlignLeft.Name = "ToolStripAlignLeft"
        Me.ToolStripAlignLeft.Size = New System.Drawing.Size(23, 25)
        Me.ToolStripAlignLeft.Text = "Align Left"
        '
        'ToolStripAlignCenter
        '
        Me.ToolStripAlignCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripAlignCenter.Image = CType(resources.GetObject("ToolStripAlignCenter.Image"), System.Drawing.Image)
        Me.ToolStripAlignCenter.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripAlignCenter.Name = "ToolStripAlignCenter"
        Me.ToolStripAlignCenter.Size = New System.Drawing.Size(23, 25)
        Me.ToolStripAlignCenter.Text = "Align Center"
        '
        'ToolStripAlignRight
        '
        Me.ToolStripAlignRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripAlignRight.Image = CType(resources.GetObject("ToolStripAlignRight.Image"), System.Drawing.Image)
        Me.ToolStripAlignRight.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripAlignRight.Name = "ToolStripAlignRight"
        Me.ToolStripAlignRight.Size = New System.Drawing.Size(23, 25)
        Me.ToolStripAlignRight.Text = "Align Right"
        '
        'myContextMenuStrip
        '
        Me.myContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.myContextMenuStrip.Name = "myContextMenuStrip"
        Me.myContextMenuStrip.Size = New System.Drawing.Size(110, 52)
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(109, 24)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(109, 24)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'txtData
        '
        Me.txtData.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData.Location = New System.Drawing.Point(12, 59)
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(643, 467)
        Me.txtData.TabIndex = 5
        Me.txtData.Text = ""
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(149, 6)
        '
        'SuperNotepad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 538)
        Me.Controls.Add(Me.txtData)
        Me.Controls.Add(Me.myToolStrip)
        Me.Controls.Add(Me.mnuMyMenu)
        Me.MainMenuStrip = Me.mnuMyMenu
        Me.Name = "SuperNotepad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SuperNotepad"
        Me.mnuMyMenu.ResumeLayout(False)
        Me.mnuMyMenu.PerformLayout()
        Me.myToolStrip.ResumeLayout(False)
        Me.myToolStrip.PerformLayout()
        Me.myContextMenuStrip.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuMyMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dlgOpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents mnuFileSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dlgSaveFile As System.Windows.Forms.SaveFileDialog
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelectAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FindToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FormatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextAlignmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LeftToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CenterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RightToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuFileExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents myToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripBold As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripItalic As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripUnderline As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripUndo As System.Windows.Forms.ToolStripButton
    Friend WithEvents myContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents myColorDialog As System.Windows.Forms.ColorDialog
    Friend WithEvents myFontDialog As System.Windows.Forms.FontDialog
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripFontSizeIncrease As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripCmbFontStyle As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripAlignLeft As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripAlignCenter As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripAlignRight As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtData As System.Windows.Forms.RichTextBox
    Friend WithEvents ToolStripFontSizeDecrease As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
End Class

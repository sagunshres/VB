'Program Name: Super Paint
'Author: Sagun Shrestha
'Date: 4/16/2016
'Description: This basic Super Paint program allows user to draw image on the allocated space 
'               using pen, brush, rectangle, ecllipse and lines. Different colors can be selected
'               for drawing. Corrections can be done with eraser and final work can be saved as 
'               jpeg file in a pre-defined hardcoded location in the filesystem.
'Note: All the icons are inside the icons folder
'       A copy of mybackgroundimage.png is inside the icons folder as well as a backup

Public Class frmSuperPaint
    'Please make sure the location to myBackgroundImage.png is correct or else the program won't work!!!
    'myBackgroundImage.png used as an background image on top of 
    'picturebox particularly for saving our drawn pictures to a file.

    Dim myImage As Image = Image.FromFile(IO.Path.Combine(My.Application.Info.DirectoryPath, "myBackgroundImage.png"))
    Dim myGraphic As Graphics = Graphics.FromImage(myImage)

    'defines the starting position of the mouse with x and y coordinates for drawing lines 
    Dim startX As Integer = 0 'start position x of line
    Dim startY As Integer = 0 'start position y of line
    Dim oldEndX As Integer = 0 'previous ending position of x
    Dim oldEndY As Integer = 0 'previous ending position of y

    'setting the default color as Black
    Dim myColor As Color = Color.Black

    'assigning width and height for combo box
    Dim myWidth, myHeight As Integer

    'setting Mouse Down as false
    Dim down = False

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnChooseColor_Click(sender As Object, e As EventArgs) Handles btnChooseColor.Click
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            myColor = ColorDialog1.Color 'myColor assigned to selected color from the color palette
        End If

    End Sub

    Private Sub myPictureBox_MouseDown(sender As Object, e As MouseEventArgs) Handles myPictureBox.MouseDown
        down = True 'mouseDown set to True 

        'starting position of mouse assigned to startX and startY
        startX = e.X
        startY = e.Y

        'assigning width and height from Combo box
        myWidth = Integer.Parse(cmbWidth.SelectedItem)
        myHeight = Integer.Parse(cmbHeight.SelectedItem)

        'assigning custom pen and brush from color selection from myColor variable
        Dim myPen As New Pen(myColor)
        Dim myBrush As New SolidBrush(myColor)

        'draw rectange at mouse location 
        'also checks to see if its fill or outline from the radio buttons rndFill
        If down = True And rdnRectangle.Checked Then

            If rdnFill.Checked Then
                myGraphic.FillRectangle(myBrush, e.X, e.Y, myWidth, myHeight)
            End If
            myGraphic.DrawRectangle(myPen, e.X, e.Y, myWidth, myHeight)
        End If

        'draw ellipse at mouse location 
        'also checks to see if its fill or outline from the radio buttons rdnEllipse
        If down = True And rdnEllipse.Checked Then

            If rdnFill.Checked Then
                myGraphic.FillEllipse(myBrush, e.X, e.Y, myWidth, myHeight)
            End If
            myGraphic.DrawEllipse(myPen, e.X, e.Y, myWidth, myHeight)
        End If

        myPictureBox.Image = myImage 'saving changes on myImage to myPictureBox

    End Sub

    Private Sub myPictureBox_MouseMove(sender As Object, e As MouseEventArgs) Handles myPictureBox.MouseMove

        'getting width and height from combo box
        myWidth = Integer.Parse(cmbWidth.SelectedItem)
        myHeight = Integer.Parse(cmbHeight.SelectedItem)

        'assigning custom pen and brush from color selection from myColor variable
        Dim myPen As New Pen(myColor)
        Dim myBrush As New SolidBrush(myColor)

        'declaring as static retains its value as a point
        Static last As New Point

        'if mousedown is true and pen checked draw a line 
        If down = True And rdnPen.Checked Then
            myGraphic.DrawLine(myPen, last.X, last.Y, e.X, e.Y)
        End If
        last = e.Location 'assign current location of mouse pointer to last

        'if mousedown is true and brush checked draw with custom width and height
        If down = True And rdnBrush.Checked Then
            myGraphic.FillEllipse(myBrush, e.X, e.Y, myWidth, myHeight)
        End If

        'following code draws single line depending on the mouse position
        'starting position marked with startX and startY
        'ending position marked with oldEndX and oldEndY
        'current position marked with e.X and e.Y
        If down = True And rdnLine.Checked Then
            myGraphic.DrawLine(New Pen(Me.myPictureBox.BackColor), startX, startY, oldEndX, oldEndY) 'display line on picturebox
            myGraphic.DrawLine(myPen, startX, startY, e.X, e.Y)
            oldEndX = e.X
            oldEndY = e.Y
        End If

        If down = True And rdnEraser.Checked Then
            'eraser fills with white color and selected width and height
            myGraphic.FillEllipse(Brushes.White, e.X, e.Y, 20, 20)
        End If

        myPictureBox.Image = myImage 'saving changes on myImage to myPictureBox

    End Sub

    Private Sub myPictureBox_MouseUp(sender As Object, e As MouseEventArgs) Handles myPictureBox.MouseUp
        down = False

    End Sub

    Private Sub frmSuperPaint_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        'default selection for combo box when form loads
        cmbHeight.SelectedIndex = 0
        cmbWidth.SelectedIndex = 0

    End Sub

    Private Sub rdnRectangle_CheckedChanged(sender As Object, e As EventArgs) Handles rdnRectangle.CheckedChanged
        rdnOutline.Checked = True
        cmbHeight.Enabled = True
        cmbWidth.Enabled = True
    End Sub

    Private Sub rdnEllipse_CheckedChanged(sender As Object, e As EventArgs) Handles rdnEllipse.CheckedChanged
        rdnOutline.Checked = True
        cmbHeight.Enabled = True
        cmbWidth.Enabled = True
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'clears the image on picture box
        myGraphic.Clear(Color.White)
        myPictureBox.Image = myImage
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'following code converts the picturebox image to a bitmap before saving as jpeg file
        'picture saved using application path inside the debug folder "..\super paint\bin\debug"
        'bitmap image disposed after use

        Dim bm As New Bitmap(myPictureBox.Width, myPictureBox.Height)
        myPictureBox.DrawToBitmap(bm, New Rectangle(0, 0, myPictureBox.Width, myPictureBox.Height))
        myPictureBox.Image = myImage
        myGraphic.DrawImageUnscaled(bm, Point.Empty)
        bm.Save(IO.Path.Combine(My.Application.Info.DirectoryPath, "myfile.jpg"), Imaging.ImageFormat.Jpeg)
        bm.Dispose()
        MsgBox("Image successfully saved" & vbCrLf & "Path: " & My.Application.Info.DirectoryPath & "\myfile.jpg")

    End Sub

    Private Sub rdnPen_CheckedChanged(sender As Object, e As EventArgs) Handles rdnPen.CheckedChanged
        cmbHeight.Enabled = False
        cmbWidth.Enabled = False
    End Sub

    Private Sub rdnBrush_CheckedChanged(sender As Object, e As EventArgs) Handles rdnBrush.CheckedChanged
        cmbHeight.Enabled = True
        cmbWidth.Enabled = True
    End Sub

    Private Sub rdnLine_CheckedChanged(sender As Object, e As EventArgs) Handles rdnLine.CheckedChanged
        cmbHeight.Enabled = False
        cmbWidth.Enabled = False
    End Sub
End Class

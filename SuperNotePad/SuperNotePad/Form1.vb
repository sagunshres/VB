Imports System.IO
Public Class Form1
    Dim myFile As String = "Products.txt"
    Dim sr As StreamReader

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If File.Exists(myFile) Then
            'Dim sr = New StreamReader(myFile)
            sr = File.OpenText(myFile)

            While sr.Peek() <> -1
                cboProducts.Items.Add(sr.ReadLine())
                'MsgBox(sr.ReadLine())
            End While

        Else
            MsgBox("File doesn't exist!!")

        End If
        sr.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SuperNotepad.Show()
    End Sub
End Class

Imports System.IO
Public Class StudentRegistration
    Dim students(0) As studentInfo 'dynamic array of structures 

    Private Sub btnSaveRecord_Click(sender As Object, e As EventArgs) Handles btnSaveRecord.Click
        'check studentID and firstName field is not empty and save data
        If txtStudentID.Text <> "" And txtFirstName.Text <> "" Then
            Dim temp As studentInfo
            With temp
                .studentID = txtStudentID.Text
                .firstName = txtFirstName.Text
                .surName = txtSurname.Text
                .DOB = dtpDOB.Text
            End With
            saveData(temp) 'saveData function call
        Else
            MsgBox("Please enter all the required information")
        End If
        ClearText()
    End Sub

    Private Sub saveData(data As studentInfo)
        'if file exists save data into csv comma separated file
        If File.Exists("StudentInfo.csv") Then
            Dim sw As New StreamWriter("StudentInfo.csv", True) 'open file in append mode
            Dim outString As String = data.studentID & "," & data.firstName & "," & data.surName & "," & data.DOB ' comma separated string
            sw.WriteLine(outString) 'write comma separated string to file
            MsgBox("Record successfully added")
            sw.Close()
        Else
            MsgBox("File does not exist")
        End If

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        readFile() 'readfile function call
        ClearText() 'clear function call
    End Sub

    Private Sub readFile()
        'this piece of code dynamically assigns the array size according to number of records in the file and assigns value to array elements
        ReDim students(-1)
        Try
            Dim sr As StreamReader = File.OpenText("StudentInfo.csv") 'open file in read mode
            Do While sr.Peek <> -1 'loop runs until the end of line
                Dim strArray() = Split(sr.ReadLine, ",") 'split each line of data on comma as delimiter and save in array
                ReDim Preserve students(students.GetUpperBound(0) + 1) 'increase size of array dynamically and populate each elements
                students(students.GetUpperBound(0)).studentID = strArray(0)
                students(students.GetUpperBound(0)).firstName = strArray(1)
                students(students.GetUpperBound(0)).surName = strArray(2)
                students(students.GetUpperBound(0)).DOB = strArray(3)
            Loop
            sr.Close() 'close reader

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'displays data from structure array to list
        lstOutput.Items.Clear()
        For i As Integer = 0 To students.Length - 1
            lstOutput.Items.Add(students(i).studentID & " " & students(i).firstName & " " & students(i).surName & " " & students(i).DOB)
        Next i

    End Sub

    Private Sub ClearText()
        txtStudentID.Text = ""
        txtFirstName.Text = ""
        txtSurname.Text = ""
        dtpDOB.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        btnUpdate.Visible = False
        btnCancel.Visible = False
        txtStudentID.Enabled = True
        btnRefresh.Enabled = True
        ClearText()
        txtStudentID.Focus()
    End Sub
    Private Sub lstOutput_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstOutput.SelectedIndexChanged
        btnUpdate.Visible = True
        btnCancel.Visible = True
        txtStudentID.Enabled = False
        btnRefresh.Enabled = False
        'assigns values from the list to the respective text boxe in the form inorder to  perform updates
        If lstOutput.SelectedItems.Count > 0 Then
            Dim lstString As String = lstOutput.SelectedItems(0).ToString() 'check selected items from the list and assign to a string
            Dim lstArray As Array = Split(lstString, " ") 'split the string into individual elements with space delimiter under an array
            'assign array elements to respective text box on the form
            txtStudentID.Text = lstArray(0)
            txtFirstName.Text = lstArray(1)
            txtSurname.Text = lstArray(2)
            dtpDOB.Text = lstArray(3)
        End If

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'this piece of code updates individual selected record from the file and saves back to the file
        If txtStudentID.Text <> "" Then
            Dim myID = txtStudentID.Text 'StudentID used as unique identifier to update individual record
            Dim sw As New StreamWriter("StudentInfo.csv", False) 'open file into write mode

            'for all the elements in array structure students, find the record with the matching studentID and make changes to it and save
            'the output string back to file
            For i As Integer = 0 To students.Length - 1
                Dim strOutput = ""
                If students(i).studentID = myID Then 'identify the record to be updated
                    strOutput = txtStudentID.Text & "," & txtFirstName.Text & "," & txtSurname.Text & "," & dtpDOB.Text 'assign values from the textbox to reflect the changes
                End If

                If String.IsNullOrEmpty(strOutput) Then 'don't make any changes to other records in the file
                    strOutput = students(i).studentID & "," & students(i).firstName & "," & students(i).surName & "," & students(i).DOB
                End If
                sw.WriteLine(strOutput) 'write the updated output string to the file
            Next
            sw.Close()

            MsgBox("Record Updated")
            ClearText()
        Else
            MsgBox("Please select a record")

        End If
    End Sub

    Private Sub StudentRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load data into list from file when form loads
        readFile() 'readfile function call
        ClearText() 'cleartext function call
    End Sub
End Class

Imports MySql.Data.MySqlClient
Imports System.IO

Public Class QuickExport
    'declare variable
    Dim mySqlConn As MySqlConnection
    Dim command As MySqlCommand
    Dim mySqlAdp As MySqlDataAdapter
    Dim dt As DataTable
    Dim ds As DataSet
    Dim query As String

    Private Sub QuickExport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'sql query to select pet details and pet owner as lastname, firstname
        query = "select pet.petID, pet.petName, CONCAT(customer.lastName,' ',customer.firstName) AS 'Owner', pet.species, pet.breed, pet.DOB, pet.gender, pet.weight from pet JOIN customer ON pet.customerID = customer.customerID "
        loadData(query) 'function call to load data from database
    End Sub

    Private Sub loadData(query As String)
        'This code establishes connection to database using proper credentials
        'Uses datatable to fill records and datagrid to display the output
        mySqlConn = New MySqlConnection
        mySqlConn.ConnectionString = "server=localhost;userid=root;database=tickedoffvet"

        Try
            mySqlConn.Open()
            'Dim query As String
            mySqlAdp = New MySqlDataAdapter(query, mySqlConn)
            dt = New DataTable()
            mySqlAdp.Fill(dt)

            Dim cb As New MySqlCommandBuilder(mySqlAdp)
            'autogenerate columns using datagrid view
            With dataGridPet
                .AutoGenerateColumns = True
                .DataSource = dt
            End With

            mySqlConn.Close() 'close connection

        Catch ex As MySqlException
            MsgBox(ex.Message) ' error message

        Finally
            mySqlConn.Dispose()
        End Try
        'dialog box to confirm user input with Yes, No question
        Dim result As Integer = MessageBox.Show("Do you want to export Pet Information to CSV file?", "Confirmation", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            'Build the CSV file data as a Comma separated string.
            Dim csv As String = String.Empty

            'Add the Header row for CSV file.
            For Each column As DataGridViewColumn In dataGridPet.Columns
                csv += column.HeaderText & ","c
            Next

            'Add new line.
            csv += vbCr & vbLf

            'Adding the Rows
            For Each row As DataGridViewRow In dataGridPet.Rows
                Try
                    For Each cell As DataGridViewCell In row.Cells
                        'Add the Data rows.
                        If Not cell.Value Is Nothing Then
                            csv += cell.Value.ToString().Replace(",", ";") & ","c
                        End If
                    Next

                    'Add new line.
                    csv += vbCr & vbLf
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Next

            'Exporting to CSV
            Dim folderPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            File.WriteAllText(folderPath & "\PetInformationExport.csv", csv)
            MsgBox("File saved to: " & folderPath & "\PetInformationExport.csv")
            Me.Close()

        Else
            Me.Close()
        End If
    End Sub

End Class
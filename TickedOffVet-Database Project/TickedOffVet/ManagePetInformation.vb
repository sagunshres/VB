Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data

Public Class ManagePetInformation
    'declare variables to be available for the class
    Dim mySqlConn As MySqlConnection
    Dim command As MySqlCommand
    Dim mySqlAdp As MySqlDataAdapter
    Dim dt As DataTable
    Dim ds As DataSet
    Dim query As String
    Dim isAscending As Boolean = True

    Private Sub ManagePetInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'select query which joins pet table and customer table to display pet owner as (lastname, firstname) with other pet details
        query = "select pet.petID, pet.petName, CONCAT(customer.lastName,' ',customer.firstName) AS 'Owner', pet.species, pet.breed, pet.DOB, pet.gender, pet.weight from pet JOIN customer ON pet.customerID = customer.customerID "
        loadData(query) 'function call to load and display data from database
        loadSortData() 'function call to sort and display data from database
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

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        MainNavigation.Focus()
    End Sub

    Private Sub loadSortData()
        'Add items to combo box
        cmbSort.Items.Clear()
        cmbSort.Items.Add("petID")
        cmbSort.Items.Add("petName")
        cmbSort.Items.Add("species")
        cmbSort.Items.Add("breed")
        cmbSort.Items.Add("DOB")
        cmbSort.Items.Add("gender")
        cmbSort.Items.Add("weight")
        cmbSort.Items.Add("Owner")

        cmbSort.SelectedItem = "petID"

    End Sub

    Private Sub cmbSort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSort.SelectedIndexChanged
        'select query which sorts data according to the data item on the combo box
        query = "select pet.petID, pet.petName, CONCAT(customer.lastName,' ',customer.firstName) AS 'Owner', pet.species, pet.breed, pet.DOB, pet.gender, pet.weight from pet JOIN customer ON pet.customerID = customer.customerID ORDER BY " & cmbSort.SelectedItem.ToString & " "
        loadData(query) 'function call to load and display data from database
        isAscending = True
        btnSort.Text = "Ascending"

    End Sub

    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click
        'This piece of code works as a toggle button between Ascending and Descending order
        If isAscending = True Then
            isAscending = False
            btnSort.Text = "Descending"
            'select query for ascending sort
            query = "select pet.petID, pet.petName, CONCAT(customer.lastName,' ',customer.firstName) AS 'Owner', pet.species, pet.breed, pet.DOB, pet.gender, pet.weight from pet JOIN customer ON pet.customerID = customer.customerID ORDER BY " & cmbSort.SelectedItem.ToString & " DESC "
            loadData(query) 'function call to load and display data from database
        ElseIf isAscending = False Then
            isAscending = True
            btnSort.Text = "Ascending"
            'select query for descending sort
            query = "select pet.petID, pet.petName, CONCAT(customer.lastName,' ',customer.firstName) AS 'Owner', pet.species, pet.breed, pet.DOB, pet.gender, pet.weight from pet JOIN customer ON pet.customerID = customer.customerID ORDER BY " & cmbSort.SelectedItem.ToString & " ASC "
            loadData(query) 'function call to load and display data from database
        End If

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        AddPet.Show() 'show form
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        'reloads the datagrid by pulling data from the database
        query = "select pet.petID, pet.petName, CONCAT(customer.lastName,' ',customer.firstName) AS 'Owner', pet.species, pet.breed, pet.DOB, pet.gender, pet.weight from pet JOIN customer ON pet.customerID = customer.customerID "
        loadData(query)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'shows dialog box with Yes/No confirmation 
        Dim result As Integer = MessageBox.Show("Are you sure you want to save changes to the Database?", "Confirmation!", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then 'save changes to database using datatable 
            Try
                dataGridPet.EndEdit()
                mySqlAdp.Update(dt)
                MsgBox("Data Saved Successfully")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Else 'do nothing and reload data from database to the datagrid
            query = "select pet.petID, pet.petName, CONCAT(customer.lastName,' ',customer.firstName) AS 'Owner', pet.species, pet.breed, pet.DOB, pet.gender, pet.weight from pet JOIN customer ON pet.customerID = customer.customerID "
            loadData(query)
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'check if row is selected
        If dataGridPet.SelectedRows.Count > 0 Then 'display dialog box with Yes/No question
            Dim result As Integer = MessageBox.Show("Are you sure you want to delete the selected pets?", "Confirmation!", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Try
                    'delete selected row from the datagrid one at a time
                    For Each row As DataGridViewRow In dataGridPet.SelectedRows
                        dataGridPet.Rows.Remove(row)
                    Next
                    'update changes to database using datatable 
                    dataGridPet.EndEdit()
                    mySqlAdp.Update(dt)
                    MsgBox("Data Deleted")

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else 'If user entered No, do nothing and load data from database to datagrid
                query = "select pet.petID, pet.petName, CONCAT(customer.lastName,' ',customer.firstName) AS 'Owner', pet.species, pet.breed, pet.DOB, pet.gender, pet.weight from pet JOIN customer ON pet.customerID = customer.customerID "
                loadData(query)
            End If
        Else 'if row has not been selected, display message
            MsgBox("Please select a record from the GridView")
        End If


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'cancels any changes made to the datagrid and re-loads the datagrid to show original data before changing
        Dim result As Integer = MessageBox.Show("Are you sure you want to cancel the changes?", "Confirmation!", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            MsgBox("All changes reverted successfully")
            query = "select pet.petID, pet.petName, CONCAT(customer.lastName,' ',customer.firstName) AS 'Owner', pet.species, pet.breed, pet.DOB, pet.gender, pet.weight from pet JOIN customer ON pet.customerID = customer.customerID " 'sql query to select all from pet
            loadData(query)
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close() 'close current form
    End Sub

    Private Sub AboutTheCompanyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutTheCompanyToolStripMenuItem.Click
        'message box showing company message
        Dim companyMessage As String = "Ticked Off is a long-established vet practice that has been operating in the Hornsby area of Sydney for many years. Keith Cabrade, son-in-law of long-term businessman Victor Grahams, owns the magical practice." & vbNewLine & vbNewLine &
                                        "Ticked Off has recently received a series of accolades from the industry for their ingenious invention of the easy-tick-disposal product, the Pop Bag. This incredibly clever invention has catapulted Ticked Off to veterinary fame in a way that no bag has done before!" & vbNewLine & vbNewLine &
                                        "Ticked Off is 100% committed to good service, so hopefully you won't be ticked off... get it?! LOLs. Just a little taste of our witty, vet-flavoured humour."
        MessageBox.Show(companyMessage, "About the Company", MessageBoxButtons.OK)
    End Sub

    Private Sub AboutTheApplicationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutTheApplicationToolStripMenuItem.Click
        'message box showing application message
        Dim applicationMessage As String = "This is a custom-made application designed specifically to meet the needs of the Ticked Off Vet clinic. It includes features/functions that are regularly accessed by staff members, and serves to make their everyday tasks much easier to fulfil." & vbNewLine & vbNewLine &
                                           "Version 2.0 will be out soon... but we won't faucet."
        MessageBox.Show(applicationMessage, "About the Application", MessageBoxButtons.OK)
    End Sub
End Class
Imports MySql.Data.MySqlClient

Public Class AddPet
    'variable declaration for class AddPet
    Dim mySqlConn As MySqlConnection
    Dim command As MySqlCommand
    Dim mysqladp As MySqlDataAdapter
    Dim reader As MySqlDataReader
    Dim ds As DataSet
    Private Sub AddPet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadCustomer() 'Function call to load customer name in customer combo box
        loadSpecies() 'Function call to load pet species in species combo box

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'This if..else statement validates user data input 
        If txtPetName.Text = "" Then
            MsgBox("Enter a pet name")
            txtPetName.Focus()
        ElseIf cmbSpecies.SelectedValue.ToString = "" Then
            MsgBox("Select pet species")
            cmbSpecies.Focus()
        ElseIf dateOfBirth.Value > Date.Now Then
            MsgBox("Date of Birth cannot be a future date")
            dateOfBirth.Focus()
        ElseIf cmbGender.SelectedItem = "" Then
            MsgBox("Select pet gender")
            cmbGender.Focus()
        ElseIf Not IsNumeric(txtWeight.Text) Then
            MsgBox("Please enter pet weight")
            txtWeight.Focus()
        ElseIf (txtWeight.Text) < 0 Then
            MsgBox("Please enter positive numeric value")
            txtWeight.Focus()
        ElseIf cmbCustomer.SelectedValue.ToString = "" Then
            MsgBox("Select customer")
            cmbCustomer.Focus()
        Else
            insertPetData() 'when data is validated, call Function to insert data into database
        End If

    End Sub

    Private Sub loadCustomer()
        'This code establishes connection to database using proper credentials
        mySqlConn = New MySqlConnection
        mySqlConn.ConnectionString = "server=localhost;userid=root;database=tickedoffvet"

        Try
            mySqlConn.Open() 'open database connection
            Dim query As String
            'sql query to select customer name as (lastname, firstname)
            query = "select CONCAT(lastName,' ',firstName) AS 'Owner', customerID from customer"
            mysqladp = New MySqlDataAdapter(query, mySqlConn)
            ds = New DataSet()
            mysqladp.Fill(ds, "customer") 'mysql adapter using dataset

            With cmbCustomer 'load data into cmbCustomer combo box using data source ds
                .DataSource = ds.Tables("customer")
                .DisplayMember = "Owner"
                .ValueMember = "customerID"
                '.Text = "Select Customer"
            End With

            mySqlConn.Close() 'close connection

        Catch ex As MySqlException
            MsgBox(ex.Message)

        Finally
            mySqlConn.Dispose()

        End Try
    End Sub

    Private Sub loadSpecies()
        'This code establishes connection to database using proper credentials
        mySqlConn = New MySqlConnection
        mySqlConn.ConnectionString = "server=localhost;userid=root;database=tickedoffvet"

        Try
            mySqlConn.Open() 'open connection
            Dim query As String
            'query to select uniques species from pet table in ascending order
            query = "select DISTINCT species from pet ORDER BY species ASC"
            mysqladp = New MySqlDataAdapter(query, mySqlConn)
            ds = New DataSet()
            mysqladp.Fill(ds, "pet") 'mysql adapter using dataset

            With cmbSpecies 'load data into cmbSpecies combo box using data source ds
                .DataSource = ds.Tables("pet")
                .DisplayMember = "species"
                .ValueMember = "species"
                '.Text = "Select Species"
            End With
            mySqlConn.Close() 'close connection

        Catch ex As MySqlException
            MsgBox(ex.Message)

        Finally
            mySqlConn.Dispose()

        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub insertPetData()
        'This code establishes connection to database using proper credentials
        mySqlConn = New MySqlConnection
        mySqlConn.ConnectionString = "server=localhost;userid=root;database=tickedoffvet"

        Try
            mySqlConn.Open() 'open database connection
            Dim query As String
            'customize date of birth as yyyy-MM-dd format
            dateOfBirth.Format = DateTimePickerFormat.Custom
            dateOfBirth.CustomFormat = "yyyy-MM-dd"
            'sql query to insert data into pet table using form data input
            query = "Insert into pet(petName, species, breed, DOB, gender, weight, customerID) values ('" & txtPetName.Text.ToString() & "', '" & cmbSpecies.SelectedValue.ToString() & "', '" & txtBreed.Text.ToString() & "', '" & dateOfBirth.Text & "', '" & cmbGender.SelectedItem & "', '" & txtWeight.Text.ToString() & "', '" & cmbCustomer.SelectedValue.ToString() & "')"
            command = New MySqlCommand(query, mySqlConn)
            command.ExecuteNonQuery()

            MsgBox("Data Successfully Updated")
            mySqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            mySqlConn.Dispose()

        End Try

        Me.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        ManagePetInformation.Focus()
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

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close() 'close current form
    End Sub
End Class
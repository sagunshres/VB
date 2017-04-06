Imports MySql.Data.MySqlClient

Public Class Statistics
    'declare variables for the class
    Dim mySqlConn As MySqlConnection
    Dim command As MySqlCommand
    Dim mysqladp As MySqlDataAdapter
    Dim reader As MySqlDataReader
    Dim ds As DataSet
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Close() 'close form
    End Sub

    Private Sub Statistics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clearText() 'clears text
        Try
            'creates new instance of DataBaseManager class as db which establishes connection to database
            Dim db As New DataBaseManager("tickedoffvet")
            'function call named loadcmbSpecies which takes 4 arguments and creates a sql query and returns a datareader
            Dim reader As MySqlDataReader = db.loadcmbSpecies("pet", "Distinct(species)", "", "species")
            'add items to combo box until the datareader has data
            While reader.Read
                cmbSpecies.Items.Add(reader.Item("species").ToString)
            End While
            reader.Close() 'close data reader
            db.disconnect() 'function call named disconnet which closes connection to database

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        MainNavigation.Focus()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'creates new instance of DataBaseManager class as db which establishes connection to database
        Dim db As New DataBaseManager("tickedoffvet")
        'function call named showStatistics which takes 4 arguments and creates a sql query and returns a datareader
        Dim reader As MySqlDataReader = db.showStatistics("staypet",
                                                          "Sum(staypet.duration), Sum(staypet.stayCost)",
                                                          "staypet.species LIKE '" & cmbSpecies.SelectedItem.ToString & "'", "")
        'add items to combo box until the datareader has data
        While reader.Read
            lblStay.Text = reader.Item("Sum(staypet.duration)").ToString + " days"
            lblTotalCost.Text = Format(reader.Item("Sum(staypet.stayCost)"), "C") 'format data into currency format
        End While
        reader.Close() 'close data reader
        db.disconnect() 'function call named disconnet which closes connection to database

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        clearText() 'function call to clear text
    End Sub

    Private Sub clearText()
        'clears text
        lblHighCost.Text = ""
        lblAverageCost.Text = ""
        lblLowCost.Text = ""
        lblLongStay.Text = ""
        lblAverageStay.Text = ""
        lblShortStay.Text = ""
        cmbSpecies.SelectedItem = ""
        lblStay.Text = ""
        lblTotalCost.Text = ""
    End Sub

    Private Sub cmbSpecies_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSpecies.SelectedIndexChanged
        'creates new instance of DataBaseManager class as db which establishes connection to database
        Dim db As New DataBaseManager("tickedoffvet")
        'function call named loadStatistics which takes 4 arguments and creates a sql query and returns a datareader
        Dim reader As MySqlDataReader = db.loadStatistics("staypet",
                          "Max(staypet.duration), Min(staypet.duration), AVG(staypet.duration), Max(staypet.stayCost), Min(staypet.stayCost), Avg(staypet.stayCost)",
                          "staypet.species LIKE '" & cmbSpecies.SelectedItem.ToString & "'", "")
        'assign items to lables until the datareader has data
        While reader.Read
            lblLongStay.Text = reader.Item("Max(staypet.duration)").ToString + " days"
            lblShortStay.Text = reader.Item("Min(staypet.duration)").ToString + " days"
            lblAverageStay.Text = Format(reader.Item("Avg(staypet.duration)"), "0.00").ToString + " days" 'format data upto 2 decimal places
            'format data to display as currency
            lblHighCost.Text = Format(reader.Item("Max(staypet.stayCost)"), "C")
            lblLowCost.Text = Format(reader.Item("Min(staypet.stayCost)"), "C")
            lblAverageCost.Text = Format(reader.Item("Avg(staypet.stayCost)"), "C")
        End While

        reader.Close() 'close data reader
        db.disconnect() 'function call named disconnet which closes connection to database

        lblTotalCost.Text = ""
        lblStay.Text = ""
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

    Private Sub ExitToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close() 'close form
    End Sub
End Class
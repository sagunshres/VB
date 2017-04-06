Imports MySql.Data.MySqlClient

Public Class BoardingCostCalculator

    Private Sub BoardingCostCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clearText() 'clears text
        Try
            'creates new instance of DataBaseManager class as db which establishes connection to database
            Dim db As New DataBaseManager("tickedoffvet")
            'function call named loadcmbSpecies which takes 4 arguments and creates sql query and returns a datareader
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

    Private Sub btnBack_Click(sender As Object, e As EventArgs)
        Me.Close()
        MainNavigation.Focus()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        clearText()
    End Sub

    Private Sub clearText()
        'clears text in the form
        txtPetWeight.Text = ""
        txtStayLength.Text = ""
        cmbSpecies.SelectedItem = ""
        lblTotal.Text = ""
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'variable declaration
        Dim speciesCost As Integer
        Dim totalCost As Double
        Dim speciesWeight As String = txtPetWeight.Text.ToString()
        Dim speciesStay As String = txtStayLength.Text.ToString()

        'this if..else statement validates user data input
        If cmbSpecies.SelectedItem = "" Then
            MsgBox("Select a species")
            cmbSpecies.Focus()
        ElseIf Not IsNumeric(speciesWeight) Then
            MsgBox("Enter a numeric value for Pet Weight")
            txtPetWeight.Focus()
        ElseIf (speciesWeight) <= 0 Then
            MsgBox("Enter valid non-negative weight")
            txtPetWeight.Focus()
        ElseIf Not IsNumeric(speciesStay) Then
            MsgBox("Enter a numeric value for Stay duration")
            txtStayLength.Focus()
        ElseIf (speciesStay) < 0 Then
            MsgBox("Enter a valid non-negative whole number")

        Else 'once data validated, calculate cost of species and total cost
            speciesCost = findSpeciesWeight(cmbSpecies.SelectedItem) 'function call which returns integer value for each individual species
            'fucntion call which returns total cost for boarding an animal
            totalCost = findTotalCost(speciesCost, CDbl(speciesWeight), CDbl(speciesStay))
            lblTotal.Text = Format(totalCost, "C")
        End If
    End Sub

    Private Function findSpeciesWeight(species As Object) As Integer
        'select case to find species weight
        Dim cost As Integer
        Select Case species
            Case "Cat"
                cost = 5
            Case "Dog"
                cost = 5
            Case "Ferret"
                cost = 5
            Case "Goat"
                cost = 12
            Case "Guinea Pig"
                cost = 0
            Case "Horse"
                cost = 22
            Case "Koala"
                cost = 20
            Case "Mouse"
                cost = 0
            Case "Rabbit"
                cost = 3
            Case "Rat"
                cost = 0
            Case "Snake"
                cost = 15
            Case "Tortoise"
                cost = 0
            Case "Yak"
                cost = 108
        End Select

        Return cost 'return respective cost for each individual case
    End Function

    Private Function findTotalCost(speciesCost As Integer, speciesWeight As Double, speciesStay As Integer) As Double
        'The function calculates the total cost for boarding a species of animal according to the fee structure rule provided
        'Declare variables
        Dim baseRate As Integer = 20
        Dim actualWeight As Decimal = 0.0
        Dim totalCost As Decimal = 0.0

        If speciesWeight >= 12.0 Then 'if weight of species is greater or equal to 12
            actualWeight = speciesWeight 'assign species weight to actual weight
        End If

        'calcualte totalcost 
        totalCost = ((baseRate + speciesCost) * speciesStay) + (actualWeight * 1.5)

        'if stay duration is greater than 10 days, provide 10% discount off the totalcost
        If speciesStay > 10 Then
            totalCost = totalCost - totalCost * 0.1 'discounted total cost 
        ElseIf speciesStay <= 0 Then 'if stay duration is less than or equal to zero
            totalCost = 0.0 'total cost should be zero for no pet stay
        End If

        Return totalCost 'return total cost
    End Function

    Private Sub btnBack_Click_1(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        MainNavigation.Focus()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Close()
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
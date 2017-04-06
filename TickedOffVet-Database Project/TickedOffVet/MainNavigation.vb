Public Class MainNavigation

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit() 'closes entire application
    End Sub

    Private Sub btnManagePet_Click(sender As Object, e As EventArgs) Handles btnManagePet.Click
        ManagePetInformation.Show()
    End Sub

    Private Sub btnStatistics_Click(sender As Object, e As EventArgs) Handles btnStatistics.Click
        Statistics.Show()
    End Sub

    Private Sub btnBoardingCalculator_Click(sender As Object, e As EventArgs) Handles btnBoardingCalculator.Click
        BoardingCostCalculator.Show()
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        QuickExport.Show()
    End Sub

    Private Sub btnWatchVideo_Click(sender As Object, e As EventArgs) Handles btnWatchVideo.Click
        'promo video comming soon message
        MsgBox("Promo Video Coming Soon!!!", MessageBoxButtons.OK)
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

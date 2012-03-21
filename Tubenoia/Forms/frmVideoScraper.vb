Public Class frmVideoScraper
    Private Sub btnVideoScraper_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVideoScraperTop.Click
        frmVideoScraperTop.Show()
    End Sub
    Private Sub btnVideoScraperKeywords_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVideoScraperKeywords.Click
        frmVideoScraperKeywords.Show()
    End Sub
    Private Sub btnVideoScraperChannel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVideoScraperChannel.Click
        frmVideoScraperChannel.Show()
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub btnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub btnScrapeViral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnScrapeViral.Click
        frmVideoScraperViral.Show()
    End Sub
    Private Sub btnCommentScraper_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommentScraper.Click
        frmCommentScraper.Show()
    End Sub
End Class
Public Class frmTools
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub btnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub btnCommentObfuscator_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommentObfuscator.Click
        frmCommentObfuscator.Show()
    End Sub
    Private Sub btnVideoTools_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVideoTools.Click
        frmVideoTools.Show()
    End Sub
    Private Sub btnCommentRater_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommentRater.Click
        frmCommentRater.Show()
    End Sub
    Private Sub btnProxyScraper_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProxyScraper.Click
        frmProxyScraper.Show()
    End Sub
    Private Sub btnAccProxBinder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccProxBinder.Click
        frmAccProxBinder.Show()
    End Sub
    Private Sub btnAvatarUploader_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAvatarUploader.Click
        frmAvatarUploader.Show()
    End Sub
    Private Sub btnPasswordChanger_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPasswordChanger.Click
        frmPasswordChanger.Show()
    End Sub
    Private Sub btnFE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFE.Click
        frmFE.Show()
    End Sub
    Private Sub btnAvatarScraper_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAvatarScraper.Click
        frmAvatarScraper.Show()
    End Sub
    Private Sub btnVideoChecker_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVideoChecker.Click
        frmVideoChecker.Show()
    End Sub
End Class
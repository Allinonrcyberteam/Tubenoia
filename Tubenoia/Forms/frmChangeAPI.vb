Public Class frmChangeAPI
    Private Sub frmChangeAPI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtAPI.Text = frmFE.developerKey
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmFE.developerKey = txtAPI.Text
        MsgBox("API Key changed!")
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        frmFE.developerKey = "AI39si4SpQkcgTV6VikC9W1CJVjtbrTd7xtSNlbmyOjyeDztRHgn_MOSORD4efH9S43Yw9FMfZfW8U3BXCiRU62ovMXf0p_ogw"
        txtAPI.Text = "AI39si4SpQkcgTV6VikC9W1CJVjtbrTd7xtSNlbmyOjyeDztRHgn_MOSORD4efH9S43Yw9FMfZfW8U3BXCiRU62ovMXf0p_ogw"
        MsgBox("API Key restored!")
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub btnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
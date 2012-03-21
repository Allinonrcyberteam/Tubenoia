Public Class frmUserScraper
    Private Sub btnUserFromComment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUserFromComment.Click
        frmUserCommentScraper.Show()
    End Sub
    Private Sub btnUserFromFriends_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUserFromFriends.Click
        frmRetrieveFriends.Show()
    End Sub
    Private Sub btnUserFromSubscribers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUserFromSubscribers.Click
        frmRetrieveSubscribers.Show()
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub btnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub btnUserFromAny_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUserFromAny.Click
        Dim Response As String = InputBox("Enter the page you want to scrape from", "Scrape from custom page", "http://www.youtube.com/")
        If Response.Contains("youtube.com") Then
            Try
                Dim F1 As New frmRetrieveAny
                Dim F2 As New WebWrapper
                Dim F3 As New Functions.General
                Dim F4 As New List(Of String)
                F4 = F3.ScrapeUsers(F2.httpGet(Response))
                If F4.Count < 0 Then
                    MsgBox("There was no users on the selected page", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
                For Each Str As String In F4
                    Dim F5 As New ListViewItem
                    F5.Text = Str
                    F5.SubItems.Add("http://www.youtube.com/user/" & Str)
                    F1.lstChannels.Items.Add(F5)
                Next
                F1.Show()
            Catch ex As Exception
                MsgBox("There was an error. " & ex.Message)
            End Try
        End If
    End Sub
End Class
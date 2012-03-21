Imports RssToolkit.Rss
Imports System.IO
Imports System.Net
Imports System.Text

Public Class frmVideoScraperChannel
    Dim F As New Functions.General
    Private Sub frmVideoScraperChannel_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        TITLE.AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub
    Private Sub frmRank_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        F.SetCueText(txtChannel, " Enter username of the channel (example: ""nigahiga"")")
        CheckForIllegalCrossThreadCalls = False
        lstVideos.ContextMenu = lstMenu
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub btnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub btnScrape_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnScrape.Click
        If txtChannel.Text <> "" Then
            Dim T As New Threading.Thread(AddressOf GetChannelVideos)
            T.Start(txtChannel.Text)
            'GetChannelVideos(txtChannel.Text)
        Else
            MsgBox("Please enter a channel name before scraping", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub GetChannelVideos(ByVal Username As String)
        Try
            Dim i As Integer = 1
Start:      Dim responseStream As Stream = WebRequest.Create("http://gdata.youtube.com/feeds/api/users/" & Username & "/uploads?start-index=" & i & "&max-results=50").GetResponse().GetResponseStream()
            Dim objSR As New StreamReader(responseStream, System.Text.Encoding.UTF8)
            Dim strTheWholeFeedAsString As String = objSR.ReadToEnd()
            Dim feed As RssDocument = RssDocument.Load(strTheWholeFeedAsString)
            Dim items As List(Of RssItem)
            items = feed.Channel.Items
            For Each itm As RssItem In items
                Dim ID As String = Split(itm.Guid.Text, "/videos/")(1)
                Dim lst As New ListViewItem
                lst.Text = ID
                lst.SubItems.Add(itm.Title)
                lstVideos.Items.Add(lst)
            Next
            If strTheWholeFeedAsString.Contains("<link rel='next'") Then
                Dim Thing As String = F.GetBetweenR(strTheWholeFeedAsString, "<link rel='next'", "</author>", 0, True)
                Dim Page As String = F.GetBetweenR(Thing, "start-index=", "&amp;", 0, True)
                i = Page
                GoTo Start
            End If
        Catch
        End Try
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Dim S As New StringBuilder
        For Each itm As ListViewItem In lstVideos.Items
            If itm.Index = lstVideos.Items.Count - 1 Then
                S.Append("http://www.youtube.com/watch?v=" & itm.Text)
            Else
                S.AppendLine("http://www.youtube.com/watch?v=" & itm.Text)
            End If
        Next
        Dim SD As New SaveFileDialog
        SD.Filter = "Text Files (*.txt)|*.txt"
        SD.FilterIndex = 1
        SD.Title = "Export log"
        SD.FileName = "Videos.txt"
        If SD.ShowDialog = DialogResult.OK Then
            Dim Sys As New System.IO.StreamWriter(SD.FileName)
            Sys.Write(S.ToString)
            Sys.Flush()
            Sys.Dispose()
            F.Logs("Video Scraper video list exported to " & SD.FileName, 2, frmLog.IL, frmLog.Log)
        End If
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        For Each itm As ListViewItem In lstVideos.SelectedItems
            itm.Remove()
        Next
    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        For Each itm As ListViewItem In lstVideos.Items
            itm.Selected = True
        Next
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        lstVideos.Items.Clear()
    End Sub
    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        If lstVideos.SelectedItems.Count = 1 Then
            Process.Start("http://www.youtube.com/watch?v=" & lstVideos.SelectedItems.Item(0).Text)
        End If
    End Sub
End Class
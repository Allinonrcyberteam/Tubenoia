Imports System.IO
Imports RssToolkit.Rss
Imports System.Net
Imports System.Text

Public Class frmVideoScraperKeywords
    Dim F As New Functions.General
    Private Sub frmVideoScraperChannel_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        TITLE.AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub
    Private Sub frmRank_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        F.SetCueText(txtKeywords, " Enter keywords to search for (example: ""youtube video downloader"")")
        cbOrderby.SelectedItem = cbOrderby.Items.Item(0)
        CheckForIllegalCrossThreadCalls = False
        lstVideos.ContextMenu = lstMenu
        TT1.SetToolTip(btnHelp, "You can use BOOLEAN syntax on your search keywords. You can use NOT (minus sign -) or OR (pipeline character |). " & vbNewLine & vbNewLine & "For example you want ""boating"" or ""sailing"" but not ""fishing"", then you would do ""boating|sailing -fishing""")
        TT1.IsBalloon = True
        TT1.ToolTipIcon = ToolTipIcon.Info
        TT1.InitialDelay = 0
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub btnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub GetKeywordVideos(ByVal Stuff As Object)
        Try
            Dim Res As Integer = 0
            Dim i As Integer = 1
Start:      Dim responseStream As Stream = WebRequest.Create(String.Format("http://gdata.youtube.com/feeds/api/videos?q={0}&orderby={1}&start-index={2}&max-results=50&v=2", F.URLEncode(Stuff(0)), Stuff(1), i)).GetResponse().GetResponseStream()
            Dim objSR As New StreamReader(responseStream, System.Text.Encoding.UTF8)
            Dim strTheWholeFeedAsString As String = objSR.ReadToEnd()
            Dim feed As RssDocument = RssDocument.Load(strTheWholeFeedAsString)
            Dim items As List(Of RssItem)
            items = feed.Channel.Items
            For Each itm As RssItem In items
                Dim ID As String = Split(itm.Guid.Text, "video:")(1)
                Dim lst As New ListViewItem
                lst.Text = ID
                lst.SubItems.Add(itm.Title)
                lstVideos.Items.Add(lst)
            Next
            Res += items.Count
            If Res < Stuff(2) Then
                If strTheWholeFeedAsString.Contains("<link rel='next'") Then
                    Dim Thing As String = F.GetBetweenR(strTheWholeFeedAsString, "<link rel='next'", "</author>", 0, True)
                    Dim Page As String = F.GetBetweenR(Thing, "start-index=", "&amp;", 0, True)
                    i = Page
                    GoTo Start
                End If
            End If
            btnScrape.Text = "Scrape"
            Me.Refresh()
        Catch
        End Try
    End Sub
    Dim S As New List(Of Threading.Thread)
    Private Sub btnScrape_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnScrape.Click
        If btnScrape.Text = "Scrape" Then
            Dim orderby As String = "relevance"
            Select Case StrConv(cbOrderby.Text, VbStrConv.Lowercase)
                Case "relevance"
                    orderby = "relevance"
                Case "published"
                    orderby = "published"
                Case "view count"
                    orderby = "viewCount"
                Case "rating"
                    orderby = "rating"
            End Select
            If txtKeywords.Text <> "" Then
                Dim T As New Threading.Thread(AddressOf GetKeywordVideos)
                S.Add(T)
                T.Start({txtKeywords.Text, orderby, Results.Value})
                btnScrape.Text = "Stop scraping"
                'GetKeywordVideos(txtKeywords.Text, orderby, Results.Value)
            Else
                MsgBox("Please enter keywords before scraping", MsgBoxStyle.Critical)
            End If
        ElseIf btnScrape.Text = "Stop scraping" Then
            For Each T As Threading.Thread In S
                T.Abort()
            Next
            btnScrape.Text = "Scrape"
        End If
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
            Sys.Write(S.ToString )
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
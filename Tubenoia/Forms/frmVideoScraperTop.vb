Imports System.IO
Imports System.Net
Imports RssToolkit.Rss
Imports System.Text

Public Class frmVideoScraperTop
    Dim F As New Functions.General
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub btnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub frmVideoScraper_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lstVideos.ContextMenu = lstMenu
        CheckForIllegalCrossThreadCalls = False
        cbTimespan.SelectedItem = cbTimespan.Items.Item(0)
        cbCategory.SelectedItem = cbCategory.Items.Item(0)
    End Sub
    Private Sub frmVideoScraper_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        TITLE.AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)
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
    Private Sub btnGather_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGather.Click
        Dim cat As String = ""
        If cbCategory.Text <> "" Then
            If cbCategory.Text = "Top rated" Then
                cat = "top_rated"
            ElseIf cbCategory.Text = "Top favorites" Then
                cat = "top_favorites"
            ElseIf cbCategory.Text = "Most viewed" Then
                cat = "most_viewed"
            ElseIf cbCategory.Text = "Most popular" Then
                cat = "most_popular"
            ElseIf cbCategory.Text = "Most recent" Then
                cat = "most_recent"
            ElseIf cbCategory.Text = "Most discussed" Then
                cat = "most_discussed"
            End If
        Else
            MsgBox("Please select the desired category", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Dim strUrl As String
        If cbTimespan.Text <> "" Then
            If cbTimespan.Text = "Today" Then
                If cat = "most_recent" Then
                    strUrl = "http://gdata.youtube.com/feeds/api/standardfeeds/" & cat
                Else
                    strUrl = "http://gdata.youtube.com/feeds/api/standardfeeds/" & cat & "?time=today"
                End If
            ElseIf cbTimespan.Text = "This week" Then
                If cat = "most_recent" Then
                    strUrl = "http://gdata.youtube.com/feeds/api/standardfeeds/" & cat
                Else
                    strUrl = "http://gdata.youtube.com/feeds/api/standardfeeds/" & cat & "?time=this_week"
                End If
            ElseIf cbTimespan.Text = "This month" Then
                If cat = "most_recent" Then
                    strUrl = "http://gdata.youtube.com/feeds/api/standardfeeds/" & cat
                Else
                    strUrl = "http://gdata.youtube.com/feeds/api/standardfeeds/" & cat & "?time=this_month"
                End If
            ElseIf cbTimespan.Text = "All time" Then
                strUrl = "http://gdata.youtube.com/feeds/api/standardfeeds/" & cat
            Else
                strUrl = "http://gdata.youtube.com/feeds/api/standardfeeds/" & cat
            End If
        Else
            MsgBox("Please select the desired timespan", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Dim T As New Threading.Thread(AddressOf GetTop)
        T.Start({strUrl, Results.Value})
    End Sub
    Private Sub GetTop(ByVal Stuff As Object)
        Try
            Dim Res As Integer = 0
            Dim VIS As String = Stuff(0).ToString
            Dim EXT As String = ""
Start:      Dim responseStream As Stream = WebRequest.Create(VIS & EXT).GetResponse().GetResponseStream()
            Dim objSR As New StreamReader(responseStream, System.Text.Encoding.UTF8)
            Dim strTheWholeFeedAsString As String = objSR.ReadToEnd()
            Dim feed As RssDocument = RssDocument.Load(strTheWholeFeedAsString)
            Dim items As System.Collections.Generic.List(Of RssItem)
            items = feed.Channel.Items
            For Each itm As RssItem In items
                Dim ID As String = Split(itm.Guid.Text, "/videos/")(1)
                Dim lst As New ListViewItem
                lst.Text = ID
                lst.SubItems.Add(itm.Title)
                lstVideos.Items.Add(lst)
                Res += 1
            Next
            If Res < Stuff(1) Then
                If strTheWholeFeedAsString.Contains("<link rel='next'") Then
                    Dim Thing As String = F.GetBetweenR(strTheWholeFeedAsString, "<link rel='next'", "</author>", 0, True)
                    Dim Page As String = F.GetBetweenR(Thing, "start-index=", "&amp;", 0, True)
                    Dim URL As String
                    If Stuff(0).ToString.Contains("?time") Then
                        URL = "&start-index=" & Page & "&max-results=25"
                    Else
                        URL = "start-index=" & Page & "&max-results=25"
                    End If
                    EXT = URL
                    GoTo Start
                End If
            End If
        Catch
        End Try
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
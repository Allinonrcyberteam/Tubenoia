Imports System.Text
Imports System.Text.RegularExpressions
Public Class frmVideoScraperViral
    Dim F As New Functions.General
    Dim W As New WebWrapper
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub btnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub frmVideoScraperChannel_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        UPLOADER.AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        Dim S As New StringBuilder
        For Each itm As ListViewItem In lstVideos.Items
            If itm.Index = lstVideos.Items.Count - 1 Then
                S.Append(itm.Text)
            Else
                S.AppendLine(itm.Text)
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
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        lstVideos.Items.Clear()
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        For Each itm As ListViewItem In lstVideos.SelectedItems
            Process.Start(itm.Text)
        Next
    End Sub
    Private Sub btnGather_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGather.Click
        Dim HTML As String = W.httpGet("http://www.youtube.com/trendsdashboard_ajax?action_feed_videos=1&feed=shared&loc=--&gender=--&age=--")
        HTML = System.Web.HttpUtility.HtmlDecode(HTML.Replace("\u003c", "<").Replace("\""", """").Replace("\n", vbNewLine).Replace("\u003e", ">").Replace("\/", "/").Replace("\u0026", "&"))
        Try
            Dim temp() As String = Regex.Split(HTML, "<h4>")
            For i = 1 To UBound(temp)
                Dim Information As String = "<h4>" & Regex.Split(temp(i), "</div>")(0).Trim()
                Dim ID As String = Mid(Split(Information, "watch?v=")(1), 1, 11)
                Dim Title As String = Split(Split(Information, "<a href=""/watch?v=" & ID & """>")(1), "</a>")(0)
                Dim Views As String = Split(Information, "<br/>")(1).Trim
                Dim Uploader As String = F.GetBetweenR(Information, "/user/", """>", 0, True)
                Dim T As New ListViewItem
                T.Text = "http://www.youtube.com/watch?v=" & ID
                T.SubItems.Add(Title)
                T.SubItems.Add(Views)
                T.SubItems.Add(Uploader)
                lstVideos.Items.Add(T)
            Next
        Catch
        End Try
    End Sub
    Private Sub frmVideoScraperViral_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lstVideos.ContextMenu = CM
    End Sub
End Class
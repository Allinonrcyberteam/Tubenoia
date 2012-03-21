Imports System.Text.RegularExpressions
Imports System.Text

Public Class frmCommentScraper
    Dim F As New Functions.General
    Dim W As New WebWrapper
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub btnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub frmCommentScraper_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        F.SetCueText(txtPath, "http://www.youtube.com/watch?v=videoid")
        'CheckForIllegalCrossThreadCalls = False
        lstComments.ContextMenu = CM
    End Sub
    Delegate Sub DW(ByVal LT As ListViewItem)
    Delegate Sub BTNT(ByVal T As String)
    Delegate Sub RW()
    Sub DWe(ByVal LT As ListViewItem)
        lstComments.Items.Add(LT)
    End Sub
    Sub BTNTe(ByVal T As String)
        btnStart.Text = T
    End Sub
    Sub RWe()
        Me.Refresh()
    End Sub
    Private Sub BW_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BW.DoWork
        Dim URL As String = "http://www.youtube.com/all_comments?persist_hl=1&hl=en&v=" & Mid(Split(txtPath.Text, "watch?v=")(1), 1, 11) & "&page="
        Dim Added As Integer
        Dim PNum As Integer = 1
        Dim Page As String
Go:     Page = W.httpGet(URL & PNum)
        Dim temp() As String = Regex.Split(Page, "<li class=""comment """)
        Dim Title As String = Nothing
        For I = 1 To UBound(temp)
            If Not BW.CancellationPending = False Then
                Exit Sub
            End If
            Dim HH As String = Regex.Split(temp(I), "</li>")(0).Trim()
            Dim Content As String
            If HH.Contains("ltr") Then
                Content = System.Web.HttpUtility.HtmlDecode(F.GetBetweenR(HH, "<div class=""comment-text"" dir=""ltr"">", "</div>", 0, True)).Replace("<p>", "").Replace("</p>", vbNewLine).Replace("<span>", "").Replace("</span>", "").Replace("<abbr>", "").Replace("</abbr>", "")
            ElseIf HH.Contains("rtl") Then
                Content = System.Web.HttpUtility.HtmlDecode(F.GetBetweenR(HH, "<div class=""comment-text"" dir=""rtl"">", "</div>", 0, True)).Replace("<p>", "").Replace("</p>", vbNewLine)
            End If
            Content = Replace(Content, Environment.NewLine, "{newline}")
            Content = Replace(Content, ControlChars.Lf, vbNullString)
            Content = Content.Substring(0, Content.Length - 9)
            If Content.Contains("</a>") Then
Check:          Dim AC As String
                AC = F.GetBetweenR(Content, "<a", "</a>", 0, False)
                Dim AC2 As String = Split(AC, """>")(1)
                Content = Replace(Content, "<a" & AC & "</a>", AC2)
                If Content.Contains("</a>") Then
                    GoTo Check
                End If
            End If
            If Content.Substring(0, 1) = "@" Then
                If chkReplies.Checked = True Then
                    Dim LV As New ListViewItem
                    Dim M As Match = Regex.Match(HH, "data-author=\""(.*?)\""", RegexOptions.IgnoreCase)
                    Dim Username As String = ""
                    If M.Success Then
                        Username = M.Groups(1).Value
                    End If
                    Dim M2 As String = F.GetBetweenR(HH, "<span class=\""time\"">", "</span>", 0, True)
                    Dim LT As New ListViewItem
                    LT.Text = Username
                    LT.SubItems.Add(Content)
                    LT.SubItems.Add(M2)
                    If lstComments.InvokeRequired Then
                        lstComments.Invoke(New DW(AddressOf DWe), LT)
                    Else
                        lstComments.Items.Add(LT)
                    End If
                    Added += 1
                End If
            Else
                Dim LV As New ListViewItem
                Dim M As Match = Regex.Match(HH, "data-author=\""(.*?)\""", RegexOptions.IgnoreCase)
                Dim Username As String = ""
                If M.Success Then
                    Username = M.Groups(1).Value
                End If
                Dim M2 As String = F.GetBetweenR(HH, "<span class=\""time\"">", "</span>", 0, True)
                If M2.Contains("playlist") Then
                    M2 = Split(M2, "ago")(0)
                End If
                Dim LT As New ListViewItem
                LT.Text = Username
                LT.SubItems.Add(Content)
                LT.SubItems.Add(M2)
                If lstComments.InvokeRequired Then
                    lstComments.Invoke(New DW(AddressOf DWe), LT)
                Else
                    lstComments.Items.Add(LT)
                End If
                Added += 1
            End If
            If Me.InvokeRequired Then
                Me.Invoke(New RW(AddressOf RWe))
            Else
                Me.Refresh()
            End If
            If Added >= Comments.Value Then
                If btnStart.InvokeRequired Then
                    btnStart.Invoke(New BTNT(AddressOf BTNTe), "Start")
                Else
                    btnStart.Text = "Start"
                End If
                If Me.InvokeRequired Then
                    Me.Invoke(New RW(AddressOf RWe))
                Else
                    Me.Refresh()
                End If
                Exit Sub
            End If
        Next
        If Added < Comments.Value Then
            If Page.Contains(">Next</a>") And Not Page.Contains("Bad page number.") Then
                PNum += 1
                Trace.WriteLine(PNum)
                GoTo Go
            Else
                If btnStart.InvokeRequired Then
                    btnStart.Invoke(New BTNT(AddressOf BTNTe), "Start")
                Else
                    btnStart.Text = "Start"
                End If
                If Me.InvokeRequired Then
                    Me.Invoke(New RW(AddressOf RWe))
                Else
                    Me.Refresh()
                End If
            End If
        End If
    End Sub
    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        Try
            If btnStart.Text = "Start" Then
                If txtPath.Text.Contains("?v=") Then
                    btnStart.Text = "Stop"
                    If BW.IsBusy Then
                        BW.CancelAsync()
                    End If
                    BW.RunWorkerAsync()
                Else
                    MsgBox("Please enter a valid YouTube video URL", MsgBoxStyle.Exclamation)
                End If
            Else
                btnStart.Text = "Start"
                BW.CancelAsync()
            End If
        Catch
            If BW.IsBusy Then
                BW.CancelAsync()
            End If
        End Try
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        lstComments.Items.Clear()
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        Dim TM As New TypingMonkey
        Dim S As New StringBuilder
        For Each itm As ListViewItem In lstComments.Items
            If itm.Index = lstComments.Items.Count - 1 Then
                S.Append(itm.SubItems(1).Text)
            Else
                S.AppendLine(itm.SubItems(1).Text)
            End If
        Next
        Dim SD As New SaveFileDialog
        SD.Filter = "Text File (*.txt)|*.txt"
        SD.FilterIndex = 1
        SD.Title = "Export Comment List"
        SD.FileName = "comments_" & TM.TypeAway(4) & ".txt"
        If SD.ShowDialog = DialogResult.OK Then
            Dim Sys As New System.IO.StreamWriter(SD.FileName)
            Sys.Write(S.ToString)
            Sys.Flush()
            Sys.Dispose()
            F.Logs("Comment Scraper list exported to " & SD.FileName, 2, frmLog.IL, frmLog.Log)
        End If
    End Sub
End Class
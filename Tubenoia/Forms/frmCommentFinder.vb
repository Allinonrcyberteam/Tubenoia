Imports System.Text.RegularExpressions

Public Class frmCommentFinder

    Dim commentIDG As String = ""
    Private S As New WebWrapper
    Private F As New Functions.General
    Public Sub Find(ByVal Stuff As Object) 'ByVal video_id As String, ByVal FUSER As String, ByVal MaxPages As Integer)
        Try
            Dim page As Integer = 1
Check:      If Not page = Stuff(2) Then
                Dim HTML As String = S.httpGet("http://www.youtube.com/all_comments?v=" & Stuff(0) & "&page=" & page & "&persist_hl=1&hl=en")
                If Not HTML.Contains("Bad page number") Then
                    page += 1
                    Dim temp() As String = Regex.Split(HTML, "<li class=""comment """)
                    Dim Title As String = Nothing
                    For I = 1 To UBound(temp)
                        Dim HH As String = Regex.Split(temp(I), "</li>")(0).Trim()
                        Dim LV As New ListViewItem
                        Dim M As Match = Regex.Match(HH, "data-author=\""(.*?)\""", RegexOptions.IgnoreCase)
                        Dim Username As String = ""
                        If M.Success Then
                            Username = M.Groups(1).Value
                            If StrConv(Username, VbStrConv.Lowercase).Contains(StrConv(Stuff(1), VbStrConv.Lowercase)) Then
                                Dim M2 As Match = Regex.Match(HH, "data-id=\""(.*?)\""", RegexOptions.IgnoreCase)
                                If M2.Success Then
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
Checkz:                                 Dim AC As String
                                        AC = F.GetBetweenR(Content, "<a", "</a>", 0, False)
                                        Dim AC2 As String = Split(AC, """>")(1)
                                        Content = Replace(Content, "<a" & AC & "</a>", AC2)
                                        If Content.Contains("</a>") Then
                                            GoTo Checkz
                                        End If
                                    End If
                                    LV.Text = Username
                                    LV.SubItems.Add(M2.Groups(1).Value)
                                    LV.SubItems.Add(Content)
                                    lstComments.Items.Add(LV)

                                    If chkFastStop.Checked = True Then
                                        page = 0
                                        btnSearch.Text = "Search"
                                        Exit Sub
                                    End If
                                End If
                            End If
                        End If
                    Next
                    GoTo Check
                Else
                    page = 0
                    btnSearch.Text = "Search"
                End If
            Else
                page = 0
                btnSearch.Text = "Search"
            End If
        Catch
        End Try
    End Sub
    Private Sub frmCommentFinder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        lstComments.ContextMenu = CM
        F.SetCueText(txtUsername, "Username, or part of it")
        F.SetCueText(txtVideo, "YouTube Video Link")
    End Sub
    Private Sub NButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If Not btnSearch.Text = "Searching..." Then
            If txtVideo.Text.Contains("?v=") Then
                Dim video_id As String = Mid(Split(txtVideo.Text, "?v=")(1), 1, 11)
                Dim T As New Threading.Thread(AddressOf Find)
                T.Start({video_id, txtUsername.Text, Max.Value})
                btnSearch.Text = "Searching..."
            Else
                MsgBox("Please enter a valid video link")
            End If
        End If
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub btnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        For Each itm As ListViewItem In lstComments.SelectedItems
            frmCommentRater.txtCID.Text = itm.SubItems(1).Text
        Next
        Me.Close()
    End Sub
End Class
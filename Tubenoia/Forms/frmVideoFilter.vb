Imports System.IO
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Formatters.Binary
Imports ProjectWIFE
Imports System.Text

Public Class frmVideoFilter
    Private INI As New INI(Configuration.INI_Configuration.DefaultConfig, My.Application.Info.DirectoryPath & "\config.ini")
    Dim MaxThread As Integer
    Dim F As New Functions.General
    Private Sub frmVideoFilter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lstVideos.ContextMenu = CM
        CheckForIllegalCrossThreadCalls = False
        MaxThread = CInt(INI("General")("Threads").Value)
        If MaxThread > 50 Then
            MaxThread = 50
        End If
    End Sub
    Private Sub frmVideoFilter_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Status.AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        Using T As New OpenFileDialog
            If T.ShowDialog = DialogResult.OK Then
                Dim Users = F.Lines(IO.File.ReadAllText(T.FileName))
                For I = 0 To Users.Length - 1
                    If Users(I).Contains("watch?v") Then
                        lstVideos.Items.Add(Users(I))
                    End If
                Next
            End If
        End Using
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub btnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
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
            F.Logs("Video Filter video list exported to " & SD.FileName, 2, frmLog.IL, frmLog.Log)
        End If
    End Sub
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        lstVideos.Items.Clear()
    End Sub
    Dim Channels As New Queue(Of ListViewItem)
    Dim Threads As New List(Of System.ComponentModel.BackgroundWorker)
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        If MenuItem2.Text = "Start" Then
            If lstVideos.Items.Count > 0 Then
                For Each ITM As ListViewItem In lstVideos.Items
                    If Not ITM.BackColor = Color.LightPink Or ITM.BackColor = Color.LightGreen Then
                        Channels.Enqueue(ITM)
                    End If
                Next
                If Channels.Count > 0 Then
                    For i = 0 To MaxThread - 1
                        Dim T As New System.ComponentModel.BackgroundWorker
                        T.WorkerSupportsCancellation = True
                        AddHandler T.DoWork, AddressOf startChecking
                        T.RunWorkerAsync()
                        Threads.Add(T)
                    Next
                    MenuItem2.Text = "Stop"
                End If
            Else
                MsgBox("There is no items in the list", MsgBoxStyle.Exclamation)
            End If
        ElseIf MenuItem2.Text = "Stop" Then
            If Threads.Count > 0 Then
                For Each BW As System.ComponentModel.BackgroundWorker In Threads
                    BW.CancelAsync()
                Next
            End If
            MenuItem2.Text = "Start"
        End If
    End Sub
    Public Sub startChecking()
        If Channels.Count > 0 Then
            Dim Entry As ListViewItem = Channels.Dequeue
            Try
                If rApi.Checked = True Then
                    Dim S As New WebWrapper
                    Dim HTML As String = S.httpGet("http://gdata.youtube.com/feeds/api/videos/" & Mid(Split(Entry.Text, "?v=")(1), 1, 11))
                    If chkViews.Checked = True Then
                        Dim FRs As String
                        If HTML.Contains("viewCount='") Then
                            FRs = F.GetBetweenR(HTML, "viewCount='", "'", 0, True)
                            If Not CInt(FRs) >= friends.Value Then
                                'Not enough views
                                Entry.BackColor = Color.LightPink
                                Entry.SubItems.Add("Not enough views (" & FRs & ")")
                                If MenuItem2.Text = "Stop" And Channels.Count > 0 Then
                                    startChecking()
                                Else
                                    MenuItem2.Text = "Start"
                                End If
                                Return
                            End If
                        Else
                            Entry.BackColor = Color.LightPink
                            Entry.SubItems.Add("Couldn't find view count")
                            If MenuItem2.Text = "Stop" And Channels.Count > 0 Then
                                startChecking()
                            Else
                                MenuItem2.Text = "Start"
                            End If
                            Return
                            'No public view count
                        End If
                    End If
                    If chkRatings.Checked = True Then
                        Dim Uploads As String
                        If HTML.Contains("numRaters='") Then
                            Uploads = F.GetBetweenR(HTML, "numRaters='", "'", 0, True)
                            If Not CInt(Uploads) >= videos.Value Then
                                'Not enough ratings
                                Entry.BackColor = Color.LightPink
                                Entry.SubItems.Add("Not enough ratings (" & Uploads & ")")
                                If MenuItem2.Text = "Stop" And Channels.Count > 0 Then
                                    startChecking()
                                Else
                                    MenuItem2.Text = "Start"
                                End If
                                Return
                            End If
                        Else
                            'No public ratings
                            Entry.BackColor = Color.LightPink
                            Entry.SubItems.Add("Couldn't find rating count")
                            If MenuItem2.Text = "Stop" And Channels.Count > 0 Then
                                startChecking()
                            Else
                                MenuItem2.Text = "Start"
                            End If
                            Return
                        End If
                    End If
                    If chkFavs.Checked = True Then
                        Dim Subscribers As String
                        If HTML.Contains("favoriteCount='") Then
                            Subscribers = F.GetBetweenR(HTML, "favoriteCount='", "'", 0, True)
                            If Not CInt(Subscribers) >= subs.Value Then
                                'Not enough favorites
                                Entry.BackColor = Color.LightPink
                                Entry.SubItems.Add("Not enough favorites (" & Subscribers & ")")
                                If MenuItem2.Text = "Stop" And Channels.Count > 0 Then
                                    startChecking()
                                Else
                                    MenuItem2.Text = "Start"
                                End If
                                Return
                            End If
                        Else
                            'No public favorite count
                            Entry.BackColor = Color.LightPink
                            Entry.SubItems.Add("Couldn't find favorite count")
                            If MenuItem2.Text = "Stop" And Channels.Count > 0 Then
                                startChecking()
                            Else
                                MenuItem2.Text = "Start"
                            End If
                            Return
                        End If
                    End If
                    If chkComments.Checked = True Then
                        Dim Comments As String
                        If HTML.Contains("comments' countHint='") Then
                            Comments = F.GetBetweenR(HTML, "comments' countHint='", "'", 0, True)
                            If Not CInt(Comments) >= commentsz.Value Then
                                'Not enough comments
                                Entry.BackColor = Color.LightPink
                                Entry.SubItems.Add("Not enough comments (" & Comments & ")")
                                If MenuItem2.Text = "Stop" And Channels.Count > 0 Then
                                    startChecking()
                                Else
                                    MenuItem2.Text = "Start"
                                End If
                                Return
                            End If
                        Else
                            'No public comments count
                            Entry.BackColor = Color.LightPink
                            Entry.SubItems.Add("Couldn't find comment count")
                            If MenuItem2.Text = "Stop" And Channels.Count > 0 Then
                                startChecking()
                            Else
                                MenuItem2.Text = "Start"
                            End If
                            Return
                        End If
                    End If
                    Entry.BackColor = Color.LightGreen
                    Entry.SubItems.Add("Matches requirements")
                    If MenuItem2.Text = "Stop" And Channels.Count > 0 Then
                        startChecking()
                    Else
                        MenuItem2.Text = "Start"
                    End If
                    Return
                ElseIf rYT.Checked = True Then
                    Dim S As New WebWrapper
                    Dim HTML As String = S.httpGet("http://www.youtube.com/insight_ajax?action_get_statistics_and_data=1&v=" & Mid(Split(Entry.Text, "?v=")(1), 1, 11))
                    HTML += vbNewLine & S.httpGet("http://www.youtube.com/watch?v=" & Mid(Split(Entry.Text, "?v=")(1), 1, 11))
                    If chkViews.Checked = True Then
                        Dim FRs As String
                        If HTML.Contains("""watch-view-count"">") Then
                            FRs = F.GetBetweenR(HTML, """watch-view-count"">", "</span>", 0, True).Replace(",", "")
                            FRs = F.GetBetweenR(FRs, "<strong>", "</strong>", 0, True)
                            If Not CInt(FRs) >= friends.Value Then
                                'Not enough views
                                Entry.BackColor = Color.LightPink
                                Entry.SubItems.Add("Not enough views (" & FRs & ")")
                                If MenuItem2.Text = "Stop" And Channels.Count > 0 Then
                                    startChecking()
                                Else
                                    MenuItem2.Text = "Start"
                                End If
                                Return
                            End If
                        Else
                            Entry.BackColor = Color.LightPink
                            Entry.SubItems.Add("Couldn't find view count on YouTube")
                            If MenuItem2.Text = "Stop" And Channels.Count > 0 Then
                                startChecking()
                            Else
                                MenuItem2.Text = "Start"
                            End If
                            Return
                            'No public view count
                        End If
                    End If
                    If chkRatings.Checked = True Then
                        Dim Uploads As String
                        If HTML.Contains("<span class=""likes"">") Then
                            Uploads = F.GetBetweenR(HTML, "<span class=""likes"">", "</span>", 0, True).Replace(",", "")
                            If Not CInt(Uploads) >= videos.Value Then
                                'Not enough ratings
                                Entry.BackColor = Color.LightPink
                                Entry.SubItems.Add("Not enough ratings (" & Uploads & ")")
                                If MenuItem2.Text = "Stop" And Channels.Count > 0 Then
                                    startChecking()
                                Else
                                    MenuItem2.Text = "Start"
                                End If
                                Return
                            End If
                        Else
                            'No public ratings
                            Entry.BackColor = Color.LightPink
                            Entry.SubItems.Add("Couldn't find rating count on YouTube")
                            If MenuItem2.Text = "Stop" And Channels.Count > 0 Then
                                startChecking()
                            Else
                                MenuItem2.Text = "Start"
                            End If
                            Return
                        End If
                    End If
                    If chkFavs.Checked = True Then
                        Dim Subscribers As String
                        If HTML.Contains("Favorites: ") Then
                            Subscribers = F.GetBetweenR(HTML, "Favorites: ", "</td>", 0, True).Replace(",", "")
                            If Not CInt(Subscribers) >= subs.Value Then
                                'Not enough favorites
                                Entry.BackColor = Color.LightPink
                                Entry.SubItems.Add("Not enough favorites (" & Subscribers & ")")
                                If MenuItem2.Text = "Stop" And Channels.Count > 0 Then
                                    startChecking()
                                Else
                                    MenuItem2.Text = "Start"
                                End If
                                Return
                            End If
                        Else
                            'No public favorite count
                            Entry.BackColor = Color.LightPink
                            Entry.SubItems.Add("Couldn't find favorite count on YouTube page")
                            If MenuItem2.Text = "Stop" And Channels.Count > 0 Then
                                startChecking()
                            Else
                                MenuItem2.Text = "Start"
                            End If
                            Return
                        End If
                    End If
                    If chkComments.Checked = True Then
                        Dim Comments As String
                        If HTML.Contains("Comments: ") Then
                            Comments = F.GetBetweenR(HTML, "Comments: ", "</td>", 0, True).Replace(",", "")
                            If Not CInt(Comments) >= commentsz.Value Then
                                'Not enough comments
                                Entry.BackColor = Color.LightPink
                                Entry.SubItems.Add("Not enough comments (" & Comments & ")")
                                If MenuItem2.Text = "Stop" And Channels.Count > 0 Then
                                    startChecking()
                                Else
                                    MenuItem2.Text = "Start"
                                End If
                                Return
                            End If
                        Else
                            'No public comments count
                            Entry.BackColor = Color.LightPink
                            Entry.SubItems.Add("Couldn't find comment count on YouTube page")
                            If MenuItem2.Text = "Stop" And Channels.Count > 0 Then
                                startChecking()
                            Else
                                MenuItem2.Text = "Start"
                            End If
                            Return
                        End If
                    End If
                    Entry.BackColor = Color.LightGreen
                    Entry.SubItems.Add("Matches requirements")
                    If MenuItem2.Text = "Stop" And Channels.Count > 0 Then
                        startChecking()
                    Else
                        MenuItem2.Text = "Start"
                    End If
                    Return
                End If
            Catch ex As Exception
                'Failed
                Entry.BackColor = Color.LightPink
                Entry.SubItems.Add("Video not available / API Limit")
                If MenuItem2.Text = "Stop" And Channels.Count > 0 Then
                    startChecking()
                Else
                    MenuItem2.Text = "Start"
                End If
                Return
            End Try
        Else
            MenuItem2.Text = "Start"
        End If
    End Sub
    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        If lstVideos.SelectedItems.Count > 0 Then
            For Each itm As ListViewItem In lstVideos.SelectedItems
                Process.Start(itm.Text)
            Next
        End If
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        Dim I As Integer
        For Each itm As ListViewItem In lstVideos.Items
            If itm.BackColor = Color.LightPink Then
                I += 1
                itm.Remove()
            End If
        Next
        MsgBox("Removed " & I & " filtered videos", MsgBoxStyle.Information)
    End Sub
    Function RemoveDuplicates(ByVal lstView As ListView) As Integer
        Dim itemI As ListViewItem
        Dim itemJ As ListViewItem
        Dim count As Integer
        For i As Integer = lstView.Items.Count - 1 To 0 Step -1
            itemI = lstView.Items(i)
            For z As Integer = i + 1 To lstView.Items.Count - 1 Step 1
                itemJ = lstView.Items(z)
                If itemI.Text = itemJ.Text Then
                    lstView.Items.Remove(itemJ)
                    count = count + 1
                    Exit For
                End If
            Next z
        Next (i)
        Return count
    End Function
    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click
        MsgBox("Removed " & RemoveDuplicates(lstVideos) & " duplicated videos", MsgBoxStyle.Information)
    End Sub
    Private Sub chkFriends_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkViews.CheckedChanged
        If friends.Enabled = False Then
            friends.Enabled = True
        Else
            friends.Enabled = False
        End If
    End Sub
    Private Sub chkSubs_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFavs.CheckedChanged
        If subs.Enabled = False Then
            subs.Enabled = True
        Else
            subs.Enabled = False
        End If
    End Sub
    Private Sub chkVideos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRatings.CheckedChanged
        If videos.Enabled = False Then
            videos.Enabled = True
        Else
            videos.Enabled = False
        End If
    End Sub
    Private Sub chkComments_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkComments.CheckedChanged
        If commentsz.Enabled = False Then
            commentsz.Enabled = True
        Else
            commentsz.Enabled = False
        End If
    End Sub
End Class
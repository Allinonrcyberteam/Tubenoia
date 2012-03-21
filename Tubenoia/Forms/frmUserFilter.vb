Imports System.IO
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Formatters.Binary
Imports ProjectWIFE
Public Class frmUserFilter
    Private INI As New INI(Configuration.INI_Configuration.DefaultConfig, My.Application.Info.DirectoryPath & "\config.ini")
    Dim MaxThread As Integer
    Dim F As New Functions.General
    Private Sub frmUserFilter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lstChannels.ContextMenu = CM
        CheckForIllegalCrossThreadCalls = False
        MaxThread = CInt(INI("General")("Threads").Value)
        If MaxThread > 50 Then
            MaxThread = 50
        End If
    End Sub
    Private Sub frmUserFilter_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Status.AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        Dim OFD As New OpenFileDialog
        OFD.Filter = "Tubenoia Supported Lists (*.TNCL *.TNSL *.TNFL)|*.TNCL;*.TNSL;*.TNFL"
        If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
            'Dim Extension As String = IO.Path.GetExtension(OFD.FileName)
            Dim fStream As FileStream
            Try
                fStream = New FileStream(OFD.FileName, FileMode.Open)
                Dim binFormat As New BinaryFormatter
                Dim f As New List(Of ListViewItem)
                f = binFormat.Deserialize(fStream)
                For Each itm As ListViewItem In f
                    Dim T As New ListViewItem
                    T.Text = itm.Text
                    T.SubItems.Add(itm.SubItems(1))
                    lstChannels.Items.Add(T)
                Next
            Catch anex As ArgumentNullException
                MsgBox("The inventory could not be accessed")
            Catch ex As SerializationException
                MsgBox("The application failed to retrieve the inventory")
            Finally
                fStream.Close()
            End Try
        Else
            Return
        End If
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub btnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        Dim SD As New SaveFileDialog
        SD.Filter = "Tubenoia Channel List (*.TNCL)|*.TNCL"
        SD.FilterIndex = 1
        SD.Title = "Export User Filter List"
        SD.FileName = "filter_export"
        If SD.ShowDialog = DialogResult.OK Then
            Dim fStream As New FileStream(SD.FileName, FileMode.Create)
            Dim binFormat As New BinaryFormatter
            Dim stuff As New List(Of ListViewItem)
            For Each itm As ListViewItem In lstChannels.Items
                stuff.Add(itm)
            Next
            binFormat.Serialize(fStream, stuff)
            F.Logs("User filter list exported to " & SD.FileName, 2, frmLog.IL, frmLog.Log)
            fStream.Close()
        End If
    End Sub
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        lstChannels.Items.Clear()
    End Sub
    Dim Channels As New Queue(Of ListViewItem)
    Dim Threads As New List(Of System.ComponentModel.BackgroundWorker)
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        If MenuItem2.Text = "Start" Then
            If lstChannels.Items.Count > 0 Then
                For Each ITM As ListViewItem In lstChannels.Items
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
                    Dim HTML As String = S.httpGet("http://gdata.youtube.com/feeds/api/users/" & Entry.Text)
                    If chkFriends.Checked = True Then
                        Dim FRs As String
                        If HTML.Contains("contacts' countHint='") Then
                            FRs = F.GetBetweenR(HTML, "contacts' countHint='", "'", 0, True)
                            If Not CInt(FRs) >= friends.Value Then
                                'Not enough friends
                                Entry.BackColor = Color.LightPink
                                Entry.SubItems.Add("Not enough friends (" & FRs & ")")
                                If MenuItem2.Text = "Stop" And Channels.Count > 0 Then
                                    startChecking()
                                Else
                                    MenuItem2.Text = "Start"
                                End If
                                Return
                            End If
                        Else
                            Entry.BackColor = Color.LightPink
                            Entry.SubItems.Add("Couldn't find friend count")
                            If MenuItem2.Text = "Stop" And Channels.Count > 0 Then
                                startChecking()
                            Else
                                MenuItem2.Text = "Start"
                            End If
                            Return
                            'No public friends count
                        End If
                    End If
                    If chkVideos.Checked = True Then
                        Dim Uploads As String
                        If HTML.Contains("uploads' countHint='") Then
                            Uploads = F.GetBetweenR(HTML, "uploads' countHint='", "'", 0, True)
                            If Not CInt(Uploads) >= videos.Value Then
                                'Not enough uploads
                                Entry.BackColor = Color.LightPink
                                Entry.SubItems.Add("Not enough uploads (" & Uploads & ")")
                                If MenuItem2.Text = "Stop" And Channels.Count > 0 Then
                                    startChecking()
                                Else
                                    MenuItem2.Text = "Start"
                                End If
                                Return
                            End If
                        Else
                            'No public uploads count
                            Entry.BackColor = Color.LightPink
                            Entry.SubItems.Add("Couldn't find upload count")
                            If MenuItem2.Text = "Stop" And Channels.Count > 0 Then
                                startChecking()
                            Else
                                MenuItem2.Text = "Start"
                            End If
                            Return
                        End If
                    End If
                    If chkSubs.Checked = True Then
                        Dim Subscribers As String
                        If HTML.Contains("subscriberCount") Then
                            Subscribers = F.GetBetweenR(HTML, "subscriberCount='", "'", 0, True)
                            If Not CInt(Subscribers) >= subs.Value Then
                                'Not enough subscribers
                                Entry.BackColor = Color.LightPink
                                Entry.SubItems.Add("Not enough subscribers (" & Subscribers & ")")
                                If MenuItem2.Text = "Stop" And Channels.Count > 0 Then
                                    startChecking()
                                Else
                                    MenuItem2.Text = "Start"
                                End If
                                Return
                            End If
                        Else
                            'No public subscribers count
                            Entry.BackColor = Color.LightPink
                            Entry.SubItems.Add("Couldn't find subscriber count")
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
                    Dim HTML As String = S.httpGet("http://www.youtube.com/user/" & Entry.Text)
                    If chkFriends.Checked = True Then
                        Dim FRs As String
                        If HTML.Contains("view=friends"" class=""headersSmall"" name=""channel-box-item-count"">") Then
                            FRs = F.GetBetweenR(HTML, "view=friends"" class=""headersSmall"" name=""channel-box-item-count"">", "</a>", 0, True)
                            If Not CInt(FRs) >= friends.Value Then
                                'Not enough friends
                                Entry.BackColor = Color.LightPink
                                Entry.SubItems.Add("Not enough friends (" & FRs & ")")
                                If MenuItem2.Text = "Stop" And Channels.Count > 0 Then
                                    startChecking()
                                Else
                                    MenuItem2.Text = "Start"
                                End If
                                Return
                            End If
                        Else
                            Entry.BackColor = Color.LightPink
                            Entry.SubItems.Add("Couldn't find friend count on YouTube page")
                            If MenuItem2.Text = "Stop" And Channels.Count > 0 Then
                                startChecking()
                            Else
                                MenuItem2.Text = "Start"
                            End If
                            Return
                            'No public friends count
                        End If
                    End If
                    If chkSubs.Checked = True Then
                        Dim Subscribers As String
                        If HTML.Contains("profile_show_subscriber_count") Then
                            Subscribers = F.GetBetweenR(HTML, "profile_show_subscriber_count"">", "</div>", 0, True)
                            If Not CInt(Subscribers) >= subs.Value Then
                                'Not enough subscribers
                                Entry.BackColor = Color.LightPink
                                Entry.SubItems.Add("Not enough subscribers (" & Subscribers & ")")
                                If MenuItem2.Text = "Stop" And Channels.Count > 0 Then
                                    startChecking()
                                Else
                                    MenuItem2.Text = "Start"
                                End If
                                Return
                            End If
                        Else
                            'No public subscribers count
                            Entry.BackColor = Color.LightPink
                            Entry.SubItems.Add("Couldn't find subscriber count on YouTube page")
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
                Entry.SubItems.Add("Channel not available / API Limit")
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
        If lstChannels.SelectedItems.Count > 0 Then
            For Each itm As ListViewItem In lstChannels.SelectedItems
                Process.Start(itm.SubItems(1).Text)
            Next
        End If
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        Dim I As Integer
        For Each itm As ListViewItem In lstChannels.Items
            If itm.BackColor = Color.LightPink Then
                I += 1
                itm.Remove()
            End If
        Next
        MsgBox("Removed " & I & " filtered channels", MsgBoxStyle.Information)
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
        MsgBox("Removed " & RemoveDuplicates(lstChannels) & " duplicated channels", MsgBoxStyle.Information)
    End Sub
    Private Sub chkFriends_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFriends.CheckedChanged
        If friends.Enabled = False Then
            friends.Enabled = True
        Else
            friends.Enabled = False
        End If
    End Sub
    Private Sub chkSubs_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSubs.CheckedChanged
        If subs.Enabled = False Then
            subs.Enabled = True
        Else
            subs.Enabled = False
        End If
    End Sub
    Private Sub chkVideos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkVideos.CheckedChanged
        If videos.Enabled = False Then
            videos.Enabled = True
        Else
            videos.Enabled = False
        End If
    End Sub

    Private Sub rYT_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rYT.CheckedChanged
        If rYT.Checked = True Then
            chkVideos.Checked = False
            chkVideos.Enabled = False
        Else
            chkVideos.Enabled = True
        End If
    End Sub
End Class
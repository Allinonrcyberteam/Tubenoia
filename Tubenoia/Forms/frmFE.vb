Imports System.IO
Imports Google.GData.Client
Imports Google.GData.Extensions
Imports Google.GData.YouTube
Imports Google.GData.Extensions.MediaRss
Imports Google.YouTube
Imports System.Net
Imports System.Text

Public Class frmFE
    Dim F As New Functions.General
    Dim recentStop As Integer = 0
    Dim appName As String = "YouToob Fast Edition"
    Public developerKey As String = "AI39si4SpQkcgTV6VikC9W1CJVjtbrTd7xtSNlbmyOjyeDztRHgn_MOSORD4efH9S43Yw9FMfZfW8U3BXCiRU62ovMXf0p_ogw"
    Private Function Lines(ByVal text As String) As String()
        Dim T As String, O As New List(Of String)
        Using R As New StringReader(text)
            While R.Peek > -1
                T = R.ReadLine
                If T <> "" Then O.Add(T)
            End While
        End Using
        Return O.ToArray
    End Function
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Userlist.Items.Clear()
        Usercount.Text = "TOTAL USERS: " & Userlist.Items.Count
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Using T As New OpenFileDialog
            If T.ShowDialog = DialogResult.OK Then
                Dim Users = Lines(IO.File.ReadAllText(T.FileName))
                Dim Buffer As String()
                For I = 0 To Users.Length - 1
                    If Users(I).Contains(":") Then
                        Buffer = Users(I).Split(":")
                        Userlist.Items.Add(Buffer(0)).SubItems.Add(Buffer(1))
                    End If
                Next
            End If
        End Using
        Usercount.Text = "TOTAL USERS: " & Userlist.Items.Count
    End Sub
    Sub Comment(ByVal Username As String, ByVal Password As String, ByVal Comment As String, ByVal VideoId As String, ByVal settings As YouTubeRequestSettings, ByVal video As Video, ByVal request As YouTubeRequest)
        'Dim settings As New YouTubeRequestSettings(appName, developerKey, Username, Password)
        'Dim request As New YouTubeRequest(settings)
        Dim authToken As String
        'Dim videoEntryUrl As New Uri("http://gdata.youtube.com/feeds/api/videos/" & VideoId)
        Dim c As New Comment()
        c.Content = F.Spin(Comment)
        'Dim video As Video = request.Retrieve(Of Video)(videoEntryUrl)
        Try
            authToken = request.Service.QueryClientLoginToken.ToString
        Catch
            Trace.TraceError("Couldn't log in... wrong user information")
            Exit Sub
        End Try
        Try
            request.AddComment(video, c)
            Logs(Username & " commented " & Chr(34) & c.Content & Chr(34) & " on " & VideoId)
        Catch
            Trace.TraceError("Couldn't post comment.. captcha")
        End Try
    End Sub
    Sub Rate(ByVal Username As String, ByVal Password As String, ByVal VideoId As String, ByVal Rate As Boolean, ByVal settings As YouTubeRequestSettings, ByVal video As Video, ByVal request As YouTubeRequest)
        'Dim settings As New YouTubeRequestSettings(appName, developerKey, Username, Password)
        'Dim request As New YouTubeRequest(settings)
        Dim authToken As String
        'Dim videoEntryUrl As New Uri("http://gdata.youtube.com/feeds/api/videos/" & VideoId)
        'Dim video As Video = request.Retrieve(Of Video)(videoEntryUrl)
        Try
            authToken = request.Service.QueryClientLoginToken.ToString
        Catch
            Trace.TraceError("Couldn't log in... wrong user information")
            Exit Sub
        End Try
        Try
            If Rate = True Then
                video.Rating = 5
                request.Insert(video.RatingsUri, video)
                Logs(Username & " liked " & VideoId)
            Else
                video.Rating = 1
                request.Insert(video.RatingsUri, video)
                Logs(Username & " didn't like " & VideoId)
            End If
        Catch ex As GDataRequestException
            Trace.TraceError(ex.ResponseString)
            If ex.ResponseString.Contains("too_many_recent_calls") Then
                Logs("Couldn't rate with " & Username & " because of too many recent requests")
            End If
        Catch
            Trace.TraceError("Couldn't rate video.. captcha")
        End Try
    End Sub
    Sub Flag(ByVal Username As String, ByVal Password As String, ByVal VideoId As String, ByVal Reason As String, ByVal cReason As String, ByVal settings As YouTubeRequestSettings, ByVal video As Video, ByVal request As YouTubeRequest)
        'Dim settings As New YouTubeRequestSettings(appName, developerKey, Username, Password)
        'Dim request As New YouTubeRequest(settings)
        Dim authToken As String
        'Dim videoEntryUrl As New Uri("http://gdata.youtube.com/feeds/api/videos/" & VideoId)
        'Dim strVideoEntryUrl As String = ("http://gdata.youtube.com/feeds/api/videos/" & VideoId)
        'Dim video As Video = request.Retrieve(Of Video)(videoEntryUrl)
        Try
            authToken = request.Service.QueryClientLoginToken.ToString
        Catch
            Trace.TraceError("Couldn't log in... wrong user information")
            Exit Sub
        End Try

        Try
            Dim c As New Complaint()
            If FlagReason.Text = "Spam" Then
                c.Type = ComplaintEntry.ComplaintType.SPAM
            ElseIf FlagReason.Text = "Dangerous" Then
                c.Type = ComplaintEntry.ComplaintType.DANGEROUS
            ElseIf FlagReason.Text = "Hate" Then
                c.Type = ComplaintEntry.ComplaintType.HATE
            ElseIf FlagReason.Text = "Porn" Then
                c.Type = ComplaintEntry.ComplaintType.PORN
            ElseIf FlagReason.Text = "Spam" Then
                c.Type = ComplaintEntry.ComplaintType.SPAM
            ElseIf FlagReason.Text = "Rights" Then
                c.Type = ComplaintEntry.ComplaintType.RIGHTS
            ElseIf FlagReason.Text = "Violence" Then
                c.Type = ComplaintEntry.ComplaintType.VIOLENCE
            End If
            c.Content = cReason
            request.Insert(video.ComplaintUri, c)
            Logs(Username & " flagged " & VideoId & " as " & FlagReason.Text)
        Catch
            Trace.TraceError("Couldn't flag video.. ")
        End Try
    End Sub
    Sub Favorite(ByVal Username As String, ByVal Password As String, ByVal VideoId As String, ByVal settings As YouTubeRequestSettings, ByVal feedUrl As Uri, ByVal videoEntry As YouTubeEntry, ByVal request As YouTubeRequest)
        'Dim settings As New YouTubeRequestSettings(appName, developerKey, Username, Password)


        Dim authToken As String
        Dim strVideoEntryUrl As String = ("http://gdata.youtube.com/feeds/api/videos/" & VideoId)
        Try
            authToken = request.Service.QueryClientLoginToken.ToString
        Catch
            Trace.TraceError("Couldn't log in... wrong user information")
            Exit Sub
        End Try
        Try
            'Dim videoEntryUrl As New Uri("http://gdata.youtube.com/feeds/api/videos/" & VideoId)
            'Dim video As Video = request.Retrieve(Of Video)(videoEntryUrl)
            'Dim feedURL As New Uri("http://gdata.youtube.com/feeds/api/users/" & "default" & "/favorites")
            'Dim videoEntry As YouTubeEntry = DirectCast(video.YouTubeEntry, YouTubeEntry)
            request.Service.SetAuthenticationToken(authToken)
            request.Service.setUserCredentials(Username, Password)
            request.Service.Insert(feedUrl, videoEntry)
            Logs(Username & " favorited " & VideoId)
        Catch
            Trace.TraceError("Couldn't favorite... ")
        End Try
    End Sub
    Sub Subscribe(ByVal Username As String, ByVal Password As String, ByVal VideoId As String, ByVal settings As YouTubeRequestSettings, ByVal video As Video, ByVal request As YouTubeRequest)
        'Dim settings As New YouTubeRequestSettings(appName, developerKey, Username, Password)
        'Dim request As New YouTubeRequest(settings)

        Dim authToken As String
        'Dim strVideoEntryUrl As String = ("http://gdata.youtube.com/feeds/api/videos/" & VideoId)
        Try
            authToken = request.Service.QueryClientLoginToken.ToString
        Catch
            Trace.TraceError("Couldn't log in... wrong user information")
            Exit Sub
        End Try
        Try
            Dim sErv As New Service
            'Dim videoEntryUrl As New Uri("http://gdata.youtube.com/feeds/api/videos/" & VideoId)
            'Dim video As Video = request.Retrieve(Of Video)(videoEntryUrl)
            Dim s As New Subscription()
            s.Type = SubscriptionEntry.SubscriptionType.channel
            s.UserName = video.Author
            request.Insert(New Uri(YouTubeQuery.CreateSubscriptionUri(Nothing)), s)
            Logs(Username & " subscribed to " & s.UserName)
        Catch
            Trace.TraceError("Couldn't subscribe... ")
        End Try
    End Sub
    Sub Login(ByVal data As Object)
        Dim T As String() = DirectCast(data, String())
        Dim Username As String = T(0)
        Dim Password As String = T(1)
        Dim VideoID As String = T(2)

        Dim settings As New YouTubeRequestSettings(appName, developerKey, Username, Password)
        Dim request As New YouTubeRequest(settings)
        Dim authToken As String
        Dim sComment As String

        Try
            Dim videoEntryUrl As New Uri("http://gdata.youtube.com/feeds/api/videos/" & VideoID)
            Dim strVideoEntryUrl As String = ("http://gdata.youtube.com/feeds/api/videos/" & VideoID)
            Dim video As Video = request.Retrieve(Of Video)(videoEntryUrl)
            Dim feedURL As New Uri("http://gdata.youtube.com/feeds/api/users/" & "default" & "/favorites")
            Dim videoEntry As YouTubeEntry '= DirectCast(video.YouTubeEntry, YouTubeEntry)

            authToken = request.Service.QueryClientLoginToken.ToString

            If chkComment.Checked = True Then
                sComment = Comments.Items.Item(F.RandomInteger(0, Comments.Items.Count - 1)).Text
                Comment(Username, Password, sComment, VideoID, settings, video, request)
            End If
            If chkRate.Checked = True Then
                If rbLike.Checked = True Then
                    Rate(Username, Password, VideoID, True, settings, video, request)
                ElseIf rbDislike.Checked = True Then
                    Rate(Username, Password, VideoID, False, settings, video, request)
                End If
            End If
            If chkFav.Checked = True Then
                videoEntry = DirectCast(video.YouTubeEntry, YouTubeEntry)
                Favorite(Username, Password, VideoID, settings, feedURL, videoEntry, request)
            End If
            If chkFlag.Checked = True Then
                Flag(Username, Password, VideoID, FlagReason.Text, txtReason.Text, settings, video, request)
            End If
            If chkSub.Checked = True Then
                Subscribe(Username, Password, VideoID, settings, video, request)
            End If
            For Each itm As ListViewItem In Userlist.Items
                If itm.Text = Username Then
                    itm.BackColor = Color.LightGreen
                End If
            Next
        Catch te As Threading.ThreadInterruptedException
            Return
        Catch ex As GDataRequestException
            If ex.ResponseString.Contains("Invalid id") Then
                Logs("Video ID is invalid. (" & VideoID & ")")
            ElseIf ex.ResponseString.Contains("Error=AccountDisabled") Then
                Logs(Username & " is invalid. (Account disabled)")
                For Each itm As ListViewItem In Userlist.Items
                    If itm.Text = Username Then
                        itm.BackColor = Color.LightPink
                    End If
                Next
            ElseIf ex.ResponseString.Contains("Error=BadAuthentication") Then
                Logs("Could not log in to " & Username & " (Invalid password)")
                For Each itm As ListViewItem In Userlist.Items
                    If itm.Text = Username Then
                        itm.BackColor = Color.LightPink
                    End If
                Next
            End If
        Catch
            Trace.TraceError("Couldn't log in... wrong user information")
            Logs("Invalid account: " & Username)
            For Each itm As ListViewItem In Userlist.Items
                If itm.Text = Username Then
                    itm.BackColor = Color.LightPink
                End If
            Next
        End Try
        If UsersQueue.Count > 0 Then Login(UsersQueue.Dequeue) Else  : Button3.Text = "START"
    End Sub
    Sub Logs(ByVal logitem As String)
        Try
            Log.SmallImageList = IL
            If StrConv(logitem, vbLowerCase).Contains("invalid") Then
                Log.Items.Add(TimeOfDay & " => " & logitem, 0)
            ElseIf StrConv(logitem, vbLowerCase).Contains("liked") Then
                Log.Items.Add(TimeOfDay & " => " & logitem, 7)
            ElseIf StrConv(logitem, vbLowerCase).Contains("didn't like") Then
                Log.Items.Add(TimeOfDay & " => " & logitem, 6)
            ElseIf StrConv(logitem, vbLowerCase).Contains("flagged") Then
                Log.Items.Add(TimeOfDay & " => " & logitem, 5)
            ElseIf StrConv(logitem, vbLowerCase).Contains("commented") Then
                Log.Items.Add(TimeOfDay & " => " & logitem, 2)
            ElseIf StrConv(logitem, vbLowerCase).Contains("favorite") Then
                Log.Items.Add(TimeOfDay & " => " & logitem, 4)
            ElseIf StrConv(logitem, vbLowerCase).Contains("subscribed") Then
                Log.Items.Add(TimeOfDay & " => " & logitem, 3)
            ElseIf StrConv(logitem, vbLowerCase).Contains("finished") Then
                Log.Items.Add(TimeOfDay & " => " & logitem, 9)
            Else
                Log.Items.Add(TimeOfDay & " => " & logitem, 8)
            End If
        Catch
        End Try
        Try
            If Log.Items.Count <> 0 Then
                Log.Items(Log.Items.Count - 1).EnsureVisible()
            End If
        Catch
        End Try
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Userlist.ContextMenu = CM
        Log.ContextMenu = CM2
        CheckForIllegalCrossThreadCalls = False
        Logs("YouToob FE - Initilized")
        FlagReason.Items.Add("Flag Reason - Please choose")
        FlagReason.Text = FlagReason.Items.Item(FlagReason.Items.Count - 1)
    End Sub
    Private Sub chkRate_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRate.CheckedChanged
        If chkRate.Checked = True Then
            rbDislike.Enabled = True
            rbLike.Enabled = True
        Else
            rbDislike.Enabled = False
            rbLike.Enabled = False
        End If
    End Sub
    Private Sub chkFlag_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFlag.CheckedChanged
        If chkFlag.Checked = True Then
            FlagReason.Enabled = True
            txtReason.Enabled = True
        Else
            FlagReason.Enabled = False
            txtReason.Enabled = False
        End If
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Using T As New OpenFileDialog
            If T.ShowDialog = DialogResult.OK Then
                Dim Users = Lines(IO.File.ReadAllText(T.FileName))
                Dim Buffer As String()
                For I = 0 To Users.Length - 1
                    Comments.Items.Add(Users(I))
                Next
            End If
        End Using
        Commentcount.Text = "TOTAL COMMENTS: " & Comments.Items.Count
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Comments.Items.Clear()
        Commentcount.Text = "TOTAL COMMENTS: " & Comments.Items.Count
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Comments.Items.Add(txtComment.Text)
        Commentcount.Text = "TOTAL COMMENTS: " & Comments.Items.Count
    End Sub
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Using T As New OpenFileDialog
            If T.ShowDialog = DialogResult.OK Then
                Dim Users = Lines(IO.File.ReadAllText(T.FileName))
                For I = 0 To Users.Length - 1
                    If Users(I).Contains("watch?v=") Then
                        Videos.Items.Add(Users(I))
                    End If
                Next
            End If
        End Using
        Videocount.Text = "TOTAL VIDEOS: " & Videos.Items.Count
    End Sub
    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        If txtVideo.Text.Contains("watch?v=") Then
            Videos.Items.Add(txtVideo.Text)
            Videocount.Text = "TOTAL VIDEOS: " & Videos.Items.Count
        Else
            Logs("Not a valid video URL.")
        End If
    End Sub
    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Videos.Items.Clear()
        Videocount.Text = "TOTAL VIDEOS: " & Videos.Items.Count
    End Sub
    Dim UsersQueue As New Queue(Of String())
    Dim TC As List(Of Threading.Thread) = New List(Of Threading.Thread)
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Not Button3.Text = "WORKING..." Then
            If Videos.Items.Count > 0 Then
                If Userlist.Items.Count > 0 Then
                    If chkComment.Checked = True Then
                        If Not Comments.Items.Count > 0 Then
                            Logs("Commenting enabled, load a comment list")
                            Exit Sub
                        End If
                    End If
                    If chkFlag.Checked = True Then
                        If FlagReason.Text = "Flag Reason - Please choose" Then
                            Logs("Flagging enabled, please use a reason")
                            Exit Sub
                        End If
                    End If
                    If recentStop = 1 Then
                        Logs("You stopped an operation recently - please wait a while until the threads a cleared, or restart.")
                    End If
                    'MsgBox(TC.Count)
                    If TC.Count > 0 Then
                        Cancel()
                    End If
                    Logs("YouToob FE - Started - Please be patient - If user list is big, this might take a while")
                    For Each I As ListViewItem In Userlist.Items
                        Dim VideoID As String
                        VideoID = Mid(Split(Videos.Items.Item(F.RandomInteger(0, Videos.Items.Count - 1)).Text, "watch?v=")(1), 1, 11)
                        UsersQueue.Enqueue({I.Text, I.SubItems(1).Text, VideoID})
                    Next
                    For I As Integer = 0 To Threads.Value - 1
                        If UsersQueue.Count > 0 Then
                            Dim T As New Threading.Thread(AddressOf Login)
                            T.Start(UsersQueue.Dequeue)
                            TC.Add(T)
                        End If
                    Next
                    Button3.Text = "WORKING..."
                    'Threads.Enabled = False
                Else
                    Logs("No users in the account list")
                End If
            Else
                Logs("No videos in the video list")
            End If
        Else
            Logs("YouToob FE is currently working")
        End If
    End Sub
    Private Sub Threads_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Threads.Scroll
        rTC.Text = "" & Threads.Value
        If CInt(rTC.Text) <= 10 Then
            rTC.ForeColor = Color.Black
        ElseIf CInt(rTC.Text) <= 20 Then
            rTC.ForeColor = Color.OrangeRed
        ElseIf CInt(rTC.Text) <= 50 Then
            rTC.ForeColor = Color.Red
        Else
            rTC.ForeColor = Color.Black
        End If
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        recentStop = 1
        Cancel()
        Logs("YouToob FE - Stopped")
    End Sub
    Sub Cancel()
        UsersQueue.Clear()
        Dim intCount As Integer = TC.Count
        If intCount > 0 Then
            For Each T As Threading.Thread In TC
                'T.Suspend()
                T.Interrupt()
            Next
            TC.Clear()
        End If
        Button3.Text = "START"
    End Sub
    Private Sub frmFE_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Cancel()
    End Sub
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Log.Items.Clear()
    End Sub
    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        If txtUser.Text.Contains(":") Then
            Dim Users = txtUser.Text
            Dim Buffer As String()
            Buffer = Users.Split(":")
            Userlist.Items.Add(Buffer(0)).SubItems.Add(Buffer(1))
            Usercount.Text = "TOTAL USERS: " & Userlist.Items.Count
        Else
            MsgBox("Please enter it in the correct format (User:Pass)")
        End If
    End Sub
    Private Sub Userlist_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Userlist.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.All
        End If
    End Sub
    Private Sub Userlist_DragDrop(ByVal sender As Object, ByVal e As  _
    System.Windows.Forms.DragEventArgs) Handles Userlist.DragDrop
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim MyFiles() As String
            Dim i As Integer
            MyFiles = e.Data.GetData(DataFormats.FileDrop)
            Dim t As Integer
            For i = 0 To MyFiles.Length - 1
                Dim Users = Lines(IO.File.ReadAllText(MyFiles(i)))
                Dim Buffer As String()
                For o = 0 To Users.Length - 1
                    If Users(o).Contains(":") Then
                        Buffer = Users(o).Split(":")
                        Userlist.Items.Add(Buffer(0)).SubItems.Add(Buffer(1))
                        t += 1
                    End If
                Next
                Logs("Loaded " & t & " users")
                Usercount.Text = "TOTAL USERS: " & Userlist.Items.Count
            Next
        End If
    End Sub
    Private Sub Videos_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Videos.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.All
        End If
    End Sub
    Private Sub Videos_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Videos.DragDrop
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim MyFiles() As String
            Dim i As Integer
            MyFiles = e.Data.GetData(DataFormats.FileDrop)
            Dim t As Integer
            For i = 0 To MyFiles.Length - 1
                Dim Users = Lines(IO.File.ReadAllText(MyFiles(i)))
                For o = 0 To Users.Length - 1
                    If Users(o).Contains("watch?v=") Then
                        Videos.Items.Add(Users(o))
                        t += 1
                    End If
                Next
            Next
            Logs("Loaded " & t & " videos")
            Videocount.Text = "TOTAL VIDEOS: " & Videos.Items.Count
        End If
    End Sub
    Private Sub Comments_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Comments.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.All
        End If
    End Sub
    Private Sub Comments_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Comments.DragDrop
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim MyFiles() As String
            Dim i As Integer
            MyFiles = e.Data.GetData(DataFormats.FileDrop)
            Dim t As Integer
            For i = 0 To MyFiles.Length - 1
                Dim Users = Lines(IO.File.ReadAllText(MyFiles(i)))
                For o = 0 To Users.Length - 1
                    Comments.Items.Add(Users(o))
                    t += 1
                Next
            Next
            Logs("Loaded " & t & " comments")
            Commentcount.Text = "TOTAL COMMENTS: " & Comments.Items.Count
        End If
    End Sub
    Function ExportListview2Excel(ByVal lstview As ListView, ByVal pathing As String) As Boolean
        Dim csvFileContents As New System.Text.StringBuilder
        Dim CurrLine As String = String.Empty
        'csvFileContents.AppendLine(CurrLine.Substring(0, CurrLine.Length))
        CurrLine = String.Empty
        For Each item As ListViewItem In lstview.Items
            For Each subItem As ListViewItem.ListViewSubItem In item.SubItems
                CurrLine += (String.Format("{0}:", subItem.Text))
            Next
            csvFileContents.AppendLine(CurrLine.Substring(0, CurrLine.Length - 1))
            CurrLine = String.Empty
        Next
        Dim Sys As New System.IO.StreamWriter(pathing)
        Sys.WriteLine(csvFileContents.ToString)
        Sys.Flush()
        Sys.Dispose()
    End Function
    Public Function getWebString(ByVal website As String) As String
        Try
            Dim wr As New WebClient
            Dim Request As String = wr.DownloadString(website).ToString
            Dim DeReq As String = Request
            Return DeReq
        Catch
            MsgBox("There was an error trying to connect to the server. Maybe it's down? Please try again later.", MsgBoxStyle.Critical)
            Environment.Exit(0)
        End Try
    End Function
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub btnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub NButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NButton1.Click
        frmChangeAPI.ShowDialog()
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        Dim i As Integer = 0
        For Each itm As ListViewItem In Userlist.Items
            If itm.BackColor = Color.LightPink Then
                itm.Remove()
                i += 1
            End If
        Next
        Usercount.Text = "TOTAL USERS: " & Userlist.Items.Count
        MsgBox("Removed " & i & " non-working accounts!")
    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Dim i As Integer = 0
        For Each itm As ListViewItem In Userlist.Items
            If itm.BackColor.ToString = "Color [Window]" Then
                itm.Remove()
                i += 1
            End If
        Next
        Usercount.Text = "TOTAL USERS: " & Userlist.Items.Count
        MsgBox("Removed " & i & " not checked accounts!")
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        Dim SD As New SaveFileDialog
        SD.Filter = "Text Files (*.txt)|*.txt"
        SD.FilterIndex = 1
        SD.Title = "Export account list"
        SD.FileName = "Account_List.txt"
        If SD.ShowDialog = DialogResult.OK Then
            ExportListview2Excel(Userlist, SD.FileName)
            Logs("Account list exported to " & SD.FileName)
        End If
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Dim SD As New SaveFileDialog
        SD.Filter = "Text Files (*.txt)|*.txt"
        SD.FilterIndex = 1
        SD.Title = "Export log"
        SD.FileName = "Log.txt"
        If SD.ShowDialog = DialogResult.OK Then
            ExportListview2Excel(Log, SD.FileName)
            Logs("Log exported to " & SD.FileName)
        End If
    End Sub
End Class

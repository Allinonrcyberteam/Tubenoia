Imports ProjectWIFE
Public Class frmVideoTools
    Private INI As New INI(Configuration.INI_Configuration.DefaultConfig, My.Application.Info.DirectoryPath & "\config.ini")
    Dim MaxThread As Integer
    Dim F As New Functions.General
    Event ChangeCountAccs(ByVal Count As Integer)
    Event ChangeCountVids(ByVal Count As Integer)
    Event ChangeCountComs(ByVal Count As Integer)
    Private Sub frmVideoTools_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        Userlist.ContextMenu = CMa
        lstComments.ContextMenu = CMc
        lstVideos.ContextMenu = CMv
        MaxThread = CInt(INI("General")("Threads").Value)
        If MaxThread > 50 Then
            MaxThread = 50
        End If
    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Userlist.Items.Clear()
        RaiseEvent ChangeCountAccs(Userlist.Items.Count)
    End Sub
    Private Sub ChangeCountVidsS(ByVal Count As Integer) Handles Me.ChangeCountVids
        lblVideos.Text = String.Format("Videos ({0})", Count)
    End Sub
    Private Sub ChangeCountComsS(ByVal Count As Integer) Handles Me.ChangeCountComs
        lblComments.Text = String.Format("Comments ({0})", Count)
    End Sub
    Private Sub ChangeCountAccsS(ByVal Count As Integer) Handles Me.ChangeCountAccs
        lblAccounts.Text = String.Format("Accounts ({0})", Count)
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        Using T As New OpenFileDialog
            If T.ShowDialog = DialogResult.OK Then
                Dim Users = F.Lines(IO.File.ReadAllText(T.FileName))
                Dim Buffer As String()
                For I = 0 To Users.Length - 1
                    If Users(I).Contains(":") Then
                        Buffer = Users(I).Split(":")
                        If UBound(Buffer) = 5 Then
                            Dim T2 As New ListViewItem
                            T2.Text = Buffer(0)
                            T2.SubItems.Add(Buffer(1))
                            T2.SubItems.Add(Buffer(2))
                            T2.SubItems.Add(Buffer(3))
                            T2.SubItems.Add(Buffer(4))
                            T2.SubItems.Add(Buffer(5))
                            T2.SubItems.Add("")
                            Userlist.Items.Add(T2)
                        ElseIf UBound(Buffer) = 3 Then
                            Dim T2 As New ListViewItem
                            T2.Text = Buffer(0)
                            T2.SubItems.Add(Buffer(1))
                            T2.SubItems.Add(Buffer(2))
                            T2.SubItems.Add(Buffer(3))
                            T2.SubItems.Add("")
                            T2.SubItems.Add("")
                            T2.SubItems.Add("")
                            Userlist.Items.Add(T2)
                        Else
                            Dim T2 As New ListViewItem
                            T2.Text = Buffer(0)
                            T2.SubItems.Add(Buffer(1))
                            T2.SubItems.Add("")
                            T2.SubItems.Add("")
                            T2.SubItems.Add("")
                            T2.SubItems.Add("")
                            T2.SubItems.Add("")
                            Userlist.Items.Add(T2)
                        End If
                    End If
                Next
                RaiseEvent ChangeCountAccs(Userlist.Items.Count)
            End If
        End Using
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub btnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        Using T As New OpenFileDialog
            If T.ShowDialog = DialogResult.OK Then
                Dim Users = F.Lines(IO.File.ReadAllText(T.FileName))
                For I = 0 To Users.Length - 1
                    If Users(I).Contains("watch?v") Then
                        Dim T2 As New ListViewItem
                        T2.Text = Users(I)
                        lstVideos.Items.Add(T2)
                    End If
                Next
                RaiseEvent ChangeCountVids(lstVideos.Items.Count)
            End If
        End Using
    End Sub
    Private Sub chkRate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRate.CheckedChanged
        If chkRate.Checked = True Then
            rbDislike.Enabled = True
            rbLike.Enabled = True
        Else
            rbDislike.Enabled = False
            rbLike.Enabled = False
            rbDislike.Checked = False
            rbLike.Checked = False
        End If
    End Sub
    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        lstVideos.Items.Clear()
        RaiseEvent ChangeCountVids(lstVideos.Items.Count)
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Using T As New OpenFileDialog
            If T.ShowDialog = DialogResult.OK Then
                Dim Users = F.Lines(IO.File.ReadAllText(T.FileName))
                For I = 0 To Users.Length - 1
                    Dim T2 As New ListViewItem
                    T2.Text = Users(I)
                    lstComments.Items.Add(T2)
                Next
                RaiseEvent ChangeCountComs(lstComments.Items.Count)
            End If
        End Using
    End Sub
    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        lstComments.Items.Clear()
        RaiseEvent ChangeCountComs(lstComments.Items.Count)
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        Dim Response As String
        Response = InputBox("Please enter a comment below to add to the list")
        If Response <> Nothing Then
            lstComments.Items.Add(Response)
            RaiseEvent ChangeCountComs(lstComments.Items.Count)
        End If
    End Sub
    Dim Users As New Queue(Of String)
    Private Sub StartIt()
        Try
            Dim S As String
            S = Users.Dequeue
            Dim PLIT As String() = Split(S, ":")
            Dim U As String
            Dim P As String
            Dim I As Integer
            Dim PIP As String
            Dim PPORT As String
            Dim PU As String
            Dim PP As String
            If PLIT(6) <> "" Then
                U = PLIT(0)
                P = PLIT(1)
                I = PLIT(2)
                PIP = PLIT(3)
                PPORT = PLIT(4)
                PU = PLIT(5)
                PP = PLIT(6)
            ElseIf PLIT(4) <> "" Then
                U = PLIT(0)
                P = PLIT(1)
                I = PLIT(2)
                PIP = PLIT(3)
                PPORT = PLIT(4)
            Else
                U = PLIT(0)
                P = PLIT(1)
                I = PLIT(2)
            End If
            If Not lstVideos.Items.Count > 0 Then
                Exit Sub
            End If
            Dim YT As YouTube
            If PU <> Nothing Then
                YT = New YouTube(U, P, Nothing, True, PIP, PPORT, PU, PP)
            ElseIf PIP <> Nothing Then
                YT = New YouTube(U, P, Nothing, True, PIP, PPORT)
            Else
                YT = New YouTube(U, P, Nothing)
            End If
            If YT.Login = "Yes" Then
                Try
                    Userlist.Items(I).BackColor = Color.LightGreen
                    Userlist.Items(I).SubItems(6).Text = "Logged successfully in"
                    If rbLoop.Checked = True Then
                        For Each SA As ListViewItem In lstVideos.Items
                            Dim ID As String = Mid(Split(SA.Text, "?v=")(1), 1, 11)
                            YT.ChangeVideo(SA.Text)
                            YT.ID = ID
                            Userlist.Items(I).SubItems(6).Text = "Going to " & ID
                            If chkRate.Checked = True Then
                                If rbLike.Checked = True Then
                                    If YT.Like = True Then
                                        Userlist.Items(I).SubItems(6).Text = "Successfully liked " & ID
                                    Else
                                        Userlist.Items(I).SubItems(6).Text = "Failed to like!"
                                    End If
                                ElseIf rbDislike.Checked = True Then
                                    If YT.Dislike = True Then
                                        Userlist.Items(I).SubItems(6).Text = "Successfully disliked " & ID
                                    Else
                                        Userlist.Items(I).SubItems(6).Text = "Failed to dislike!"
                                    End If
                                End If
                            End If
                            If chkFav.Checked = True Then
                                If YT.Favorite = True Then
                                    Userlist.Items(I).SubItems(6).Text = "Successfully favorited " & ID
                                Else
                                    Userlist.Items(I).SubItems(6).Text = "Failed to favorite!"
                                End If
                            End If
                            If chkSub.Checked = True Then
                                Dim Suba As String
                                If YT.Subscribe(Suba) = True Then
                                    Userlist.Items(I).SubItems(6).Text = "Successfully subscribed " & Suba
                                Else
                                    Userlist.Items(I).SubItems(6).Text = "Failed to subscribe!"
                                End If
                            End If
                            If chkFR.Checked = True Then
                                Dim Frienda As String
                                If YT.Friend(Frienda) = True Then
                                    Userlist.Items(I).SubItems(6).Text = "Successfully sent request to " & Frienda
                                Else
                                    Userlist.Items(I).SubItems(6).Text = "Failed to send friend request!"
                                End If
                            End If
                            If chkComment.Checked = True Then
                                If lstComments.Items.Count > 0 Then
                                    Dim Index As Integer = F.RandomInteger(0, lstComments.Items.Count - 1)
                                    Dim Comment As String = lstComments.Items(Index).Text
                                    If rbComNo.Checked = True Then
                                        If YT.Comment(Comment) = True Then
                                            Userlist.Items(I).SubItems(6).Text = "Successfully commented " & Comment & " on " & ID
                                        Else
                                            Userlist.Items(I).SubItems(6).Text = "Failed to comment (maybe disabled)!"
                                        End If
                                    ElseIf rbComRem.Checked = True Then
                                        If YT.Comment(Comment) = True Then
                                            Userlist.Items(I).SubItems(6).Text = "Successfully commented " & Comment & " on " & ID
                                            lstComments.Items.RemoveAt(Index)
                                            Userlist.Items(I).SubItems(6).Text = "Successfully removed comment"
                                        Else
                                            Userlist.Items(I).SubItems(6).Text = "Failed to comment!"
                                        End If
                                    End If
                                End If
                            End If
                        Next
                    ElseIf rbRand.Checked = True Then
                        ' RANDOM VIDEO FRA LISTA
                        Dim SA As String
                        If lstVideos.Items.Count > 1 Then
                            SA = lstVideos.Items(F.RandomInteger(0, lstVideos.Items.Count - 1)).Text
                        Else
                            SA = lstVideos.Items(0).Text
                        End If
                        Dim ID As String = Mid(Split(SA, "?v=")(1), 1, 11)
                        YT.ChangeVideo(SA)
                        YT.ID = ID
                        Userlist.Items(I).SubItems(6).Text = "Going to " & ID
                        If chkRate.Checked = True Then
                            If rbLike.Checked = True Then
                                If YT.Like = True Then
                                    Userlist.Items(I).SubItems(6).Text = "Successfully liked " & ID
                                Else
                                    Userlist.Items(I).SubItems(6).Text = "Failed to like!"
                                End If
                            ElseIf rbDislike.Checked = True Then
                                If YT.Dislike = True Then
                                    Userlist.Items(I).SubItems(6).Text = "Successfully disliked " & ID
                                Else
                                    Userlist.Items(I).SubItems(6).Text = "Failed to dislike!"
                                End If
                            End If
                        End If
                        If chkFav.Checked = True Then
                            If YT.Favorite = True Then
                                Userlist.Items(I).SubItems(6).Text = "Successfully favorited " & ID
                            Else
                                Userlist.Items(I).SubItems(6).Text = "Failed to favorite!"
                            End If
                        End If
                        If chkSub.Checked = True Then
                            Dim Suba As String
                            If YT.Subscribe(Suba) = True Then
                                Userlist.Items(I).SubItems(6).Text = "Successfully subscribed " & Suba
                            Else
                                Userlist.Items(I).SubItems(6).Text = "Failed to subscribe!"
                            End If
                        End If
                        If chkFR.Checked = True Then
                            Dim Frienda As String
                            If YT.Friend(Frienda) = True Then
                                Userlist.Items(I).SubItems(6).Text = "Successfully sent request to " & Frienda
                            Else
                                Userlist.Items(I).SubItems(6).Text = "Failed to send friend request!"
                            End If
                        End If
                        If chkComment.Checked = True Then
                            If lstComments.Items.Count > 0 Then
                                Dim Index As Integer = F.RandomInteger(0, lstComments.Items.Count - 1)
                                Dim Comment As String = lstComments.Items(Index).Text
                                If rbComNo.Checked = True Then
                                    If YT.Comment(Comment) = True Then
                                        Userlist.Items(I).SubItems(6).Text = "Successfully commented " & Comment & " on " & ID
                                    Else
                                        Userlist.Items(I).SubItems(6).Text = "Failed to comment!"
                                    End If
                                ElseIf rbComRem.Checked = True Then
                                    If YT.Comment(Comment) = True Then
                                        Userlist.Items(I).SubItems(6).Text = "Successfully commented " & Comment & " on " & ID
                                        lstComments.Items.RemoveAt(Index)
                                        Userlist.Items(I).SubItems(6).Text = "Successfully removed comment"
                                    Else
                                        Userlist.Items(I).SubItems(6).Text = "Failed to comment!"
                                    End If
                                End If
                            End If
                        End If
                    ElseIf rbQue.Checked = True Then
                        Dim SA As ListViewItem
                        Try
                            SA = Videos.Dequeue
                        Catch
                            Userlist.Items(I).SubItems(6).Text = "No more videos in queue"
                            Exit Sub
                        End Try
                        Dim ID As String = Mid(Split(SA.Text, "?v=")(1), 1, 11)
                        YT.ChangeVideo(SA.Text)
                        YT.ID = ID
                        Userlist.Items(I).SubItems(6).Text = "Going to " & ID
                        If chkRate.Checked = True Then
                            If rbLike.Checked = True Then
                                If YT.Like = True Then
                                    Userlist.Items(I).SubItems(6).Text = "Successfully liked " & ID
                                Else
                                    Userlist.Items(I).SubItems(6).Text = "Failed to like!"
                                End If
                            ElseIf rbDislike.Checked = True Then
                                If YT.Dislike = True Then
                                    Userlist.Items(I).SubItems(6).Text = "Successfully disliked " & ID
                                Else
                                    Userlist.Items(I).SubItems(6).Text = "Failed to dislike!"
                                End If
                            End If
                        End If
                        If chkFav.Checked = True Then
                            If YT.Favorite = True Then
                                Userlist.Items(I).SubItems(6).Text = "Successfully favorited " & ID
                            Else
                                Userlist.Items(I).SubItems(6).Text = "Failed to favorite!"
                            End If
                        End If
                        If chkSub.Checked = True Then
                            Dim Suba As String
                            If YT.Subscribe(Suba) = True Then
                                Userlist.Items(I).SubItems(6).Text = "Successfully subscribed " & Suba
                            Else
                                Userlist.Items(I).SubItems(6).Text = "Failed to subscribe!"
                            End If
                        End If
                        If chkFR.Checked = True Then
                            Dim Frienda As String
                            If YT.Friend(Frienda) = True Then
                                Userlist.Items(I).SubItems(6).Text = "Successfully sent request to " & Frienda
                            Else
                                Userlist.Items(I).SubItems(6).Text = "Failed to send friend request!"
                            End If
                        End If
                        If chkComment.Checked = True Then
                            If lstComments.Items.Count > 0 Then
                                Dim Index As Integer = F.RandomInteger(0, lstComments.Items.Count - 1)
                                Dim Comment As String = lstComments.Items(Index).Text
                                If rbComNo.Checked = True Then
                                    If YT.Comment(Comment) = True Then
                                        Userlist.Items(I).SubItems(6).Text = "Successfully commented " & Comment & " on " & ID
                                    Else
                                        Userlist.Items(I).SubItems(6).Text = "Failed to comment!"
                                    End If
                                ElseIf rbComRem.Checked = True Then
                                    If YT.Comment(Comment) = True Then
                                        Userlist.Items(I).SubItems(6).Text = "Successfully commented " & Comment & " on " & ID
                                        lstComments.Items.RemoveAt(Index)
                                        Userlist.Items(I).SubItems(6).Text = "Successfully removed comment"
                                    Else
                                        Userlist.Items(I).SubItems(6).Text = "Failed to comment!"
                                    End If
                                End If
                            End If
                        End If
                    End If
                Catch
                    Userlist.Items(I).BackColor = Color.LightPink
                    Userlist.Items(I).SubItems(6).Text = "Unkown error"
                End Try
            Else
                Userlist.Items(I).BackColor = Color.LightPink
                Userlist.Items(I).SubItems(6).Text = "Login failed"
            End If
            If chkLoop.Checked Then
                Users.Enqueue(S)
            End If
            If Users.Count > 0 Then
                If Delay.Value > 0 Then
                    Threading.Thread.Sleep(Delay.Value * 1000)
                End If

                If Not rbQue.Checked Then
                    StartIt()
                Else
                    If Videos.Count > 0 Then
                        StartIt()
                    End If
                End If
            Else
                btnStart.Text = "Start"
                Me.Refresh()
            End If
        Catch
        End Try
    End Sub
    Dim Videos As New Queue(Of ListViewItem)
    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        If btnStart.Text = "Start" Then
            If Userlist.Items.Count > 0 Then
                If lstVideos.Items.Count > 0 Then
                    If chkComment.Checked = True And lstComments.Items.Count = 0 Then
                        MsgBox("There is no comments in the comment list!", MsgBoxStyle.Information)
                        Exit Sub
                    End If
                    '------
                    For Each itm As ListViewItem In Userlist.Items
                        If itm.SubItems.Count = 7 Then
                            Users.Enqueue(itm.Text & ":" & itm.SubItems(1).Text & ":" & itm.Index & ":" & itm.SubItems(2).Text & ":" & itm.SubItems(3).Text & ":" & itm.SubItems(4).Text & ":" & itm.SubItems(5).Text)
                        ElseIf itm.SubItems.Count = 5 Then
                            Users.Enqueue(itm.Text & ":" & itm.SubItems(1).Text & ":" & itm.Index & ":" & itm.SubItems(2).Text & ":" & itm.SubItems(3).Text)
                        Else
                            Users.Enqueue(itm.Text & ":" & itm.SubItems(1).Text & ":" & itm.Index)
                        End If
                    Next
                    If rbQue.Checked Then
                        For Each itm As ListViewItem In lstVideos.Items
                            Videos.Enqueue(itm)
                        Next
                    End If
                    If Users.Count > 0 Then
                        For i = 0 To MaxThread - 1
                            Dim T As New Threading.Thread(AddressOf StartIt)
                            T.Start()
                        Next
                        btnStart.Text = "Stop"
                    End If
                    '------
                Else
                    MsgBox("There is no videos in the video list!", MsgBoxStyle.Information)
                End If
            Else
                MsgBox("There is no users in the account list!", MsgBoxStyle.Information)
            End If
        ElseIf btnStart.Text = "Stop" Then
            Users.Clear()
            btnStart.Text = "Start"
            Me.Refresh()
        End If
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        Dim Response As String
        Response = InputBox("Please enter a video below to add to the list")
        If Response <> Nothing Then
            If Response.Contains("?v=") Then
                lstVideos.Items.Add(Response)
                RaiseEvent ChangeCountVids(lstVideos.Items.Count)
            End If
        End If
    End Sub
    Private Sub MenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem12.Click
        Dim Response As String
        Response = InputBox("Please enter a account below to add to the list" & vbNewLine & " (username:password(optional :proxy_IP:proxy_PORT:proxy_username:proxy_password) format)")
        If Response <> Nothing Then
            If Response.Contains(":") Then
                Dim Buffer As String()
                Buffer = Response.Split(":")
                If UBound(Buffer) = 5 Then
                    Dim T2 As New ListViewItem
                    T2.Text = Buffer(0)
                    T2.SubItems.Add(Buffer(1))
                    T2.SubItems.Add(Buffer(2))
                    T2.SubItems.Add(Buffer(3))
                    T2.SubItems.Add(Buffer(4))
                    T2.SubItems.Add(Buffer(5))
                    T2.SubItems.Add("")
                    Userlist.Items.Add(T2)
                ElseIf UBound(Buffer) = 3 Then
                    Dim T2 As New ListViewItem
                    T2.Text = Buffer(0)
                    T2.SubItems.Add(Buffer(1))
                    T2.SubItems.Add(Buffer(2))
                    T2.SubItems.Add(Buffer(3))
                    T2.SubItems.Add("")
                    T2.SubItems.Add("")
                    T2.SubItems.Add("")
                    Userlist.Items.Add(T2)
                Else
                    Dim T2 As New ListViewItem
                    T2.Text = Buffer(0)
                    T2.SubItems.Add(Buffer(1))
                    T2.SubItems.Add("")
                    T2.SubItems.Add("")
                    T2.SubItems.Add("")
                    T2.SubItems.Add("")
                    T2.SubItems.Add("")
                    Userlist.Items.Add(T2)
                End If
                RaiseEvent ChangeCountAccs(lstVideos.Items.Count)
            End If
        End If
    End Sub
End Class
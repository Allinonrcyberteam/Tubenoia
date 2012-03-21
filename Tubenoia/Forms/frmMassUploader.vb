Imports System.IO
Imports ProjectWIFE
Imports System.Text
Public Class frmMassUploader
    Private INI As New INI(Configuration.INI_Configuration.DefaultConfig, My.Application.Info.DirectoryPath & "\config.ini")
    Dim F As New Functions.General
    Dim MaxThread As Integer
    Private Sub UpdateProgress(ByVal sender As Object, ByVal Progress As Integer, ByVal index As Integer)
        Dim PG As ProgressbarWithPercentage
        PG = lstQueue.GetEmbeddedControl(13, index)
        PG.Value = Progress
    End Sub
    Private Sub UploadFailed(ByVal sender As Object, ByVal err As String, ByVal index As Integer)
        Dim C As New ProgressbarWithPercentage
        C = lstQueue.GetEmbeddedControl(13, index)

        If lstQueue.InvokeRequired Then
            lstQueue.Invoke(New remC(AddressOf remControl), CInt(index))
        Else
            lstQueue.RemoveEmbeddedControl(lstQueue.GetEmbeddedControl(13, index))
        End If

        lstQueue.Items(index).SubItems.Add(err)
        lstQueue.Items(index).BackColor = Color.LightPink
    End Sub
    Private Sub UploadDone(ByVal sender As Object, ByVal str As String, ByVal index As Integer)
        Dim C As New ProgressbarWithPercentage
        C = lstQueue.GetEmbeddedControl(13, index)
        lstQueue.RemoveEmbeddedControl(C)
        lstQueue.Items(index).SubItems.Add("Video ID: " & str)
        lstQueue.Items(index).BackColor = Color.LightGreen
    End Sub
    Dim III As Integer = 1
    Private Sub addControl(ByVal Index As Integer)
        lstQueue.AddEmbeddedControl(New ProgressbarWithPercentage, 13, Index)
    End Sub
    Delegate Sub addC(ByVal index As Integer)
    Private Sub remControl(ByVal Index As Integer)
        lstQueue.RemoveEmbeddedControl(lstQueue.GetEmbeddedControl(13, Index))
    End Sub
    Delegate Sub remC(ByVal index As Integer)
    Private Sub Start()
        Try
            Dim LV As ListViewItem = Upload_Queue.Dequeue
            Dim Title As String = Uploads(CInt(LV.Text))(0)
            Dim Description As String = Uploads(CInt(LV.Text))(1)
            Dim Keywords As String = Uploads(CInt(LV.Text))(2)
            Dim Category As String = Uploads(CInt(LV.Text))(3)
            Dim File As String = Uploads(CInt(LV.Text))(4)
            Dim Privacy As String = Uploads(CInt(LV.Text))(5)
            Dim AllowRatings As Boolean = CBool(Uploads(CInt(LV.Text))(7))
            Dim AllowComment As String = Uploads(CInt(LV.Text))(6)
            Debug.WriteLine(AllowComment)

            Dim YT As YouTube
            If LV.SubItems(3).Text <> "" Then
                If LV.SubItems(6).Text <> "" Then
                    YT = New YouTube(LV.SubItems(1).Text, LV.SubItems(2).Text, Nothing, True, LV.SubItems(3).Text, LV.SubItems(4).Text, LV.SubItems(5).Text, LV.SubItems(6).Text)
                Else
                    YT = New YouTube(LV.SubItems(1).Text, LV.SubItems(2).Text, Nothing, True, LV.SubItems(3).Text, LV.SubItems(4).Text)
                End If
            Else
                YT = New YouTube(LV.SubItems(1).Text, LV.SubItems(2).Text, Nothing)
            End If
            If lstQueue.InvokeRequired Then
                lstQueue.Invoke(New addC(AddressOf addControl), CInt(LV.Index))
            Else
                lstQueue.AddEmbeddedControl(New ProgressbarWithPercentage, 13, LV.Index)
            End If


            AddHandler YT.UploadProgressChanged, AddressOf Me.UpdateProgress
            AddHandler YT.UploadFinished, AddressOf Me.UploadDone
            AddHandler YT.UploadFailed, AddressOf Me.UploadFailed

            If chkUnique.Checked Then
                Dim First As New FileStream(File, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
                Dim FirstBytes(CInt(First.Length - 1)) As Byte
                First.Read(FirstBytes, 0, CInt(First.Length))
                First.Close()

                Dim TT As New MemoryStream
                TT.Write(FirstBytes, 0, FirstBytes.Length)
                Dim BB(F.RandomInteger(1, 102400)) As Byte
                TT.Write(BB, 0, BB.Length)

                If YT.Login = "Yes" Then
                    YT.UploadBytes(Title, Description, Keywords, Category, TT.ToArray, Privacy, LV.Index, AllowComment, AllowRatings)
                Else
                    If lstQueue.InvokeRequired Then
                        lstQueue.Invoke(New remC(AddressOf remControl), CInt(LV.Index))
                    Else
                        lstQueue.RemoveEmbeddedControl(lstQueue.GetEmbeddedControl(13, LV.Index))
                    End If
                    LV.BackColor = Color.LightPink
                    LV.SubItems.Add("Login failed")
                End If
            Else
                If YT.Login = "Yes" Then
                    YT.Upload(Title, Description, Keywords, Category, File, Privacy, LV.Index, AllowComment, AllowRatings)
                Else
                    If lstQueue.InvokeRequired Then
                        lstQueue.Invoke(New remC(AddressOf remControl), CInt(LV.Index))
                    Else
                        lstQueue.RemoveEmbeddedControl(lstQueue.GetEmbeddedControl(13, LV.Index))
                    End If
                    LV.BackColor = Color.LightPink
                    LV.SubItems.Add("Login failed")
                End If
            End If
            If Upload_Queue.Count > 0 Then
                Start()
            Else
                btnStart.Text = "Start"
            End If
        Catch
        End Try
    End Sub
    Private Sub frmMassUploader_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MaxThread = CInt(INI("General")("Threads").Value)
        If MaxThread > 50 Then
            MaxThread = 50
        End If
        Userlist.ContextMenu = CMa
        lstFiles.ContextMenu = CMf
        lstQueue.ContextMenu = CMq
        CheckForIllegalCrossThreadCalls = False
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
                            Userlist.Items.Add(T2)
                        ElseIf UBound(Buffer) = 3 Then
                            Dim T2 As New ListViewItem
                            T2.Text = Buffer(0)
                            T2.SubItems.Add(Buffer(1))
                            T2.SubItems.Add(Buffer(2))
                            T2.SubItems.Add(Buffer(3))
                            Userlist.Items.Add(T2)
                        Else
                            Userlist.Items.Add(Buffer(0)).SubItems.Add(Buffer(1))
                        End If
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
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Userlist.Items.Clear()
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        lstFiles.Items.Clear()
        Uploads.Clear()
    End Sub
    Dim Uploads As New List(Of Array)
    Dim Uploads_Done As New List(Of ListViewItem)
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        Dim T As New frmAddUpload
        If T.ShowDialog = DialogResult.OK Then
            Dim Title As String = T.txtTitle.Text
            Dim Description As String = T.txtDescription.Text
            Dim Keywords As String = T.txtKeywords.Text
            Dim Category As String = T.Category.SelectedItem
            Dim File As String = T.txtFile.Text
            Dim Privacy As String = T.Privacy.SelectedItem
            Dim AllowRatings As Boolean = IIf(T.chkRatings.Checked, False, True)
            Dim AllowComment As String = "Yes"
            If T.rbComAllow.Checked Then
                AllowComment = "Yes"
            ElseIf T.rbComDisable.Checked Then
                AllowComment = "No"
            ElseIf T.rbComKinda.Checked Then
                AllowComment = "Kinda"
            End If

            Dim LV As New ListViewItem
            LV.Text = Title
            If Description.Length > 30 Then
                LV.SubItems.Add(Mid(Description, 1, 30) & " (...)")
            Else
                LV.SubItems.Add(Description)
            End If


            LV.SubItems.Add(Keywords)
            LV.SubItems.Add(Category)
            LV.SubItems.Add(File)
            LV.SubItems.Add(Privacy)
            lstFiles.Items.Add(LV)

            Uploads.Add({Title, Description, Keywords, Category, File, Privacy, AllowComment, AllowRatings, LV.Index})
        End If
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        For Each itm As ListViewItem In lstFiles.SelectedItems
            itm.Remove()
            Uploads.RemoveAt(itm.Index + 1)
            For Each _itm As ListViewItem In lstQueue.Items
                If _itm.Text = itm.Index + 1 Then
                    _itm.Remove()
                End If
            Next
        Next
    End Sub
    Dim Upload_Queue As New Queue(Of ListViewItem)
    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        If btnStart.Text = "Start" Then
            If Upload_Queue.Count > 0 Then
                For i = 0 To MaxThread - 1
                    Dim T As New Threading.Thread(AddressOf Start)
                    T.Start()
                Next
                btnStart.Text = "Stop"
            Else
                MsgBox("There is no items in the queue")
            End If
        Else
            Upload_Queue.Clear()
            btnStart.Text = "Start"
        End If
    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If lstFiles.Items.Count > 0 Then
            If Userlist.Items.Count > 0 Then
                If rAll.Checked Then
                    For Each Acc As ListViewItem In Userlist.Items
                        For Each Vid As ListViewItem In lstFiles.Items
                            Dim LV As New ListViewItem
                            LV.Text = Vid.Index
                            LV.SubItems.Add(Acc.Text)
                            LV.SubItems.Add(Acc.SubItems(1).Text)
                            If Acc.SubItems.Count = 4 Then
                                LV.SubItems.Add(Acc.SubItems(2).Text)
                                LV.SubItems.Add(Acc.SubItems(3).Text)
                                LV.SubItems.Add("")
                                LV.SubItems.Add("")
                            ElseIf Acc.SubItems.Count = 6 Then
                                LV.SubItems.Add(Acc.SubItems(2).Text)
                                LV.SubItems.Add(Acc.SubItems(3).Text)
                                LV.SubItems.Add(Acc.SubItems(4).Text)
                                LV.SubItems.Add(Acc.SubItems(5).Text)
                            Else
                                LV.SubItems.Add("")
                                LV.SubItems.Add("")
                                LV.SubItems.Add("")
                                LV.SubItems.Add("")
                            End If
                            LV.SubItems.Add(Vid.Text)
                            LV.SubItems.Add(Vid.SubItems(1).Text)
                            LV.SubItems.Add(Vid.SubItems(2).Text)
                            LV.SubItems.Add(Vid.SubItems(3).Text)
                            LV.SubItems.Add(Vid.SubItems(4).Text)
                            LV.SubItems.Add(Vid.SubItems(5).Text)
                            lstQueue.Items.Add(LV)
                            Upload_Queue.Enqueue(LV)
                        Next
                    Next
                ElseIf rRand.Checked Then
                    For Each Acc As ListViewItem In Userlist.Items
                        Dim Vid As ListViewItem = lstFiles.Items(F.RandomInteger(0, lstFiles.Items.Count - 1))
                        Dim LV As New ListViewItem
                        LV.Text = Vid.Index
                        LV.SubItems.Add(Acc.Text)
                        LV.SubItems.Add(Acc.SubItems(1).Text)
                        If Acc.SubItems.Count = 4 Then
                            LV.SubItems.Add(Acc.SubItems(2).Text)
                            LV.SubItems.Add(Acc.SubItems(3).Text)
                            LV.SubItems.Add("")
                            LV.SubItems.Add("")
                        ElseIf Acc.SubItems.Count = 6 Then
                            LV.SubItems.Add(Acc.SubItems(2).Text)
                            LV.SubItems.Add(Acc.SubItems(3).Text)
                            LV.SubItems.Add(Acc.SubItems(4).Text)
                            LV.SubItems.Add(Acc.SubItems(5).Text)
                        Else
                            LV.SubItems.Add("")
                            LV.SubItems.Add("")
                            LV.SubItems.Add("")
                            LV.SubItems.Add("")
                        End If
                        LV.SubItems.Add(Vid.Text)
                        LV.SubItems.Add(Vid.SubItems(1).Text)
                        LV.SubItems.Add(Vid.SubItems(2).Text)
                        LV.SubItems.Add(Vid.SubItems(3).Text)
                        LV.SubItems.Add(Vid.SubItems(4).Text)
                        LV.SubItems.Add(Vid.SubItems(5).Text)
                        lstQueue.Items.Add(LV)
                        Upload_Queue.Enqueue(LV)
                    Next
                End If
            Else
                MsgBox("There is no accounts in the list")
            End If
        Else
            MsgBox("There is no files in the list")
        End If
    End Sub
    Private Sub MenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem12.Click
        Dim S As New StringBuilder
        For Each itm As ListViewItem In lstQueue.Items
            Try
                If itm.Index = lstQueue.Items.Count - 1 Then
                    If itm.SubItems(13).Text.Contains("Video ID") Then
                        Dim ID As String = Split(itm.SubItems(13).Text, "Video ID: ")(1)
                        S.Append("http://www.youtube.com/watch?v=" & ID)
                    End If
                Else
                    If itm.SubItems(13).Text.Contains("Video ID") Then
                        Dim ID As String = Split(itm.SubItems(13).Text, "Video ID: ")(1)
                        S.AppendLine("http://www.youtube.com/watch?v=" & ID)
                    End If
                End If
            Catch
            End Try
        Next
        Dim SD As New SaveFileDialog
        SD.Filter = "Text Files (*.txt)|*.txt"
        SD.FilterIndex = 1
        SD.Title = "Export List"
        SD.FileName = "Videos.txt"
        If SD.ShowDialog = DialogResult.OK Then
            Dim Sys As New System.IO.StreamWriter(SD.FileName)
            Sys.Write(S.ToString)
            Sys.Flush()
            Sys.Dispose()
            F.Logs("Mass Uploader list exported to " & SD.FileName, 2, frmLog.IL, frmLog.Log)
        End If
    End Sub
    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click
        lstQueue.Items.Clear()
        Try
            Upload_Queue.Clear()
        Catch
        End Try
    End Sub
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        Dim Index As Integer
        If lstFiles.SelectedItems.Count > 0 Then
            Index = lstFiles.SelectedItems.Item(0).Index
            Dim UploadItem As Object = Uploads(Index)
            Dim Title As String = UploadItem(0)
            Dim Description As String = UploadItem(1)
            Dim Keywords As String = UploadItem(2)
            Dim Category As String = UploadItem(3)
            Dim File As String = UploadItem(4)
            Dim Privacy As String = UploadItem(5)
            Dim AllowComment As String = UploadItem(6)
            Dim AllowRatings As Boolean = UploadItem(7)

            Dim Window As New frmAddUpload
            Window.txtTitle.Text = Title
            Window.txtDescription.Text = Description
            Window.txtKeywords.Text = Keywords
            Window.txtFile.Text = File
            If AllowComment = "Yes" Then
                Window.rbComAllow.Checked = True
            ElseIf AllowComment = "No" Then
                Window.rbComDisable.Checked = True
            ElseIf AllowComment = "Kinda" Then
                Window.rbComKinda.Checked = True
            End If
            If AllowRatings Then
                Window.chkRatings.Checked = False
            Else
                Window.chkRatings.Checked = True
            End If
            If Window.ShowDialog = Windows.Forms.DialogResult.OK Then
                Uploads(Index).SetValue(Window.txtTitle.Text, 0)
                Uploads(Index).SetValue(Window.txtDescription.Text, 1)
                Uploads(Index).SetValue(Window.txtKeywords.Text, 2)
                Uploads(Index).SetValue(Window.Category.SelectedItem, 3)
                Uploads(Index).SetValue(Window.txtFile.Text, 4)
                Uploads(Index).SetValue(Window.Privacy.SelectedItem, 5)
                AllowRatings = IIf(Window.chkRatings.Checked, False, True)
                If Window.rbComAllow.Checked Then
                    AllowComment = "Yes"
                ElseIf Window.rbComDisable.Checked Then
                    AllowComment = "No"
                ElseIf Window.rbComKinda.Checked Then
                    AllowComment = "Kinda"
                End If
                Uploads(Index).SetValue(AllowComment, 6)
                Uploads(Index).SetValue(AllowRatings, 7)



                UploadItem = Uploads(Index)
                Title = UploadItem(0)
                Description = UploadItem(1)
                Keywords = UploadItem(2)
                Category = UploadItem(3)
                File = UploadItem(4)
                Privacy = UploadItem(5)
                AllowComment = UploadItem(6)
                AllowRatings = UploadItem(7)

                Dim LV As ListViewItem = lstFiles.Items(Index)
                LV.Text = Title
                If Description.Length > 30 Then
                    LV.SubItems(1).Text = Mid(Description, 1, 30) & " (...)"
                Else
                    LV.SubItems(1).Text = Description
                End If
                LV.SubItems(2).Text = Keywords
                LV.SubItems(3).Text = Category
                LV.SubItems(4).Text = File
                LV.SubItems(5).Text = Privacy
            End If
        End If
    End Sub
End Class
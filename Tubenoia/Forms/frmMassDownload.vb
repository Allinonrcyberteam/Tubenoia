Imports ProjectWIFE
Public Class frmMassDownload
    Dim Videos As New Queue(Of ListViewItem)
    Dim Threads As New List(Of Threading.Thread)
    Dim MaxThread As Integer
    Dim F As New Functions.General
    Private INI As New INI(Configuration.INI_Configuration.DefaultConfig, My.Application.Info.DirectoryPath & "\config.ini")
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If Threads.Count > 0 Then
            For Each T As Threading.Thread In Threads
                T.Abort()
            Next
        End If
        Me.Close()
    End Sub
    Private Sub btnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub NButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NButton1.Click
        Dim T As New FolderBrowserDialog
        T.Description = "Please select the folder you want to save the videos inside"
        If T.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtPath.Text = T.SelectedPath & "\"
        End If
    End Sub
    Private Sub frmMassDownload_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Desktop As String = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        txtPath.Text = Desktop & "\"
        CheckForIllegalCrossThreadCalls = False
        lstVideos.ContextMenu = CM
        MaxThread = CInt(INI("General")("Threads").Value)
        If MaxThread > 50 Then
            MaxThread = 50
        End If
        cRes.SelectedItem = cRes.Items(5)
    End Sub
    Private Sub Failed(ByVal index As Integer, ByVal ex As Exception)
        Try
            Dim Item As ListViewItem = lstVideos.Items(index)
            Item.SubItems(2).Text = "Download failed. Error was '" & ex.Message & "'"
            Item.ImageKey = IL.Images.Keys(3)
            Dim PB As ProgressbarWithPercentage
            PB = lstVideos.GetEmbeddedControl(2, Item.Index)
            lstVideos.RemoveEmbeddedControl(PB)
            Item.BackColor = Color.LightGray '
        Catch
        End Try
    End Sub
    Private Sub Completed(ByVal index As Integer)
        Dim Item As ListViewItem = lstVideos.Items(index)
        Item.SubItems(2).Text = "Download completed"
        Item.ImageKey = IL.Images.Keys(1)
        Dim PB As ProgressbarWithPercentage
        PB = lstVideos.GetEmbeddedControl(2, Item.Index)
        lstVideos.RemoveEmbeddedControl(PB)
        Item.BackColor = Color.LightBlue
    End Sub
    Private Sub Percentage(ByVal iPercentage As Integer, ByVal index As Integer)
        Dim Item As ListViewItem = lstVideos.Items(index)
        Dim PB As ProgressbarWithPercentage
        PB = lstVideos.GetEmbeddedControl(2, Item.Index)
        PB.Value = iPercentage
    End Sub
    Private Sub Download(ByVal Stuff As Object)
        Dim Item As ListViewItem = Stuff(0)
        Item.ImageKey = IL.Images.Keys(0)
Start:  Dim YTD As New YouTubeDownloader(Item.SubItems(1).Text, Item.Index)
        AddHandler YTD.FileDownloadPercentageChanged, AddressOf Percentage
        AddHandler YTD.FileDownloadFailed, AddressOf Failed
        AddHandler YTD.FileDownloadComplete, AddressOf Completed
        Dim Res As String = Item.SubItems(3).Text
        If Res.Contains("Highest") Then
            YTD.Download(txtPath.Text, True)
        Else
            YTD.Download(txtPath.Text, False, CInt(Res))
        End If
        If Videos.Count > 0 Then
            Item = Videos.Dequeue
            If lstVideos.InvokeRequired Then
                lstVideos.Invoke(New AEC(AddressOf AEEC), {Item})
               Else
                lstVideos.Items(Item.Index).SubItems(2).Text = vbNullString
                lstVideos.AddEmbeddedControl(New ProgressbarWithPercentage, 2, Item.Index)
            End If
            GoTo Start
        End If
    End Sub
    Sub AEEC(ByVal item As ListViewItem)
        item.ImageKey = IL.Images.Keys(0)
        lstVideos.Items(item.Index).SubItems(2).Text = vbNullString
        lstVideos.AddEmbeddedControl(New ProgressbarWithPercentage, 2, item.Index)
    End Sub
    Delegate Sub AEC(ByVal C As ListViewItem)
    Private Sub Start()
        If lstVideos.Items.Count > 0 Then
            For Each Item As ListViewItem In lstVideos.Items
                If Item.SubItems(2).Text = "Queued" Then
                    Videos.Enqueue(Item)
                End If
            Next
            If Videos.Count > 0 Then
                'MT HERE
                For i = 0 To MaxThread - 1
                    Dim Item As ListViewItem = Videos.Dequeue
                    lstVideos.Items(Item.Index).SubItems(2).Text = vbNullString
                    lstVideos.AddEmbeddedControl(New ProgressbarWithPercentage, 2, Item.Index)
                    Dim T As New Threading.Thread(AddressOf Download)
                    T.Start({Item})
                    Threads.Add(T)
                    If Videos.Count = 0 Then
                        Exit For
                    End If
                Next
            Else
                MsgBox("None of the videos in the list is queued!", MsgBoxStyle.Information)
            End If
        Else
            MsgBox("There are no videos in the list!", MsgBoxStyle.Information)
        End If
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        For Each Item As ListViewItem In lstVideos.SelectedItems
            If Item.SubItems(2).Text <> "Queued" Then
                Item.SubItems(2).Text = "Queued"
                Item.BackColor = Color.White
                Item.ImageKey = IL.Images.Keys(2)
            End If
        Next
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        If MenuItem1.Text = "Start" Then
            Start()
            MenuItem1.Text = "Stop"
        ElseIf MenuItem1.Text = "Stop" Then
            For Each T As Threading.Thread In Threads
                T.Abort()
            Next
            Videos.Clear()
            MenuItem1.Text = "Start"
        End If
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        For Each Item As ListViewItem In lstVideos.Items
            If Item.SubItems(2).Text <> "Queued" Then
                Item.SubItems(2).Text = "Queued"
                Item.BackColor = Color.White
                Item.ImageKey = IL.Images.Keys(2)
            End If
        Next
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        For Each Item As ListViewItem In lstVideos.SelectedItems
            Process.Start(Item.SubItems(1).Text)
        Next
    End Sub
    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        Dim F As New frmAddVideo
        If F.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim T As New ListViewItem("", 2)
            T.SubItems.Add(F.V)
            T.SubItems.Add("Queued")
            T.SubItems.Add(F.R)
            lstVideos.Items.Add(T)
        End If
    End Sub
    Private Sub MenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem12.Click
        For Each itm As ListViewItem In lstVideos.SelectedItems
            itm.SubItems(3).Text = "240"
        Next
    End Sub
    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem13.Click
        For Each itm As ListViewItem In lstVideos.SelectedItems
            itm.SubItems(3).Text = "360"
        Next
    End Sub
    Private Sub MenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem14.Click
        For Each itm As ListViewItem In lstVideos.SelectedItems
            itm.SubItems(3).Text = "480"
        Next
    End Sub
    Private Sub MenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem15.Click
        For Each itm As ListViewItem In lstVideos.SelectedItems
            itm.SubItems(3).Text = "720"
        Next
    End Sub
    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click
        For Each itm As ListViewItem In lstVideos.SelectedItems
            itm.SubItems(3).Text = "1080"
        Next
    End Sub
    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        For Each itm As ListViewItem In lstVideos.SelectedItems
            itm.SubItems(3).Text = "Highest available"
        Next
    End Sub
    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        Using T As New OpenFileDialog
            If T.ShowDialog = DialogResult.OK Then
                Dim Users = F.Lines(IO.File.ReadAllText(T.FileName))
                For I = 0 To Users.Length - 1
                    If Users(I).Contains("watch?v") Then
                        Dim T2 As New ListViewItem("", 2)
                        T2.SubItems.Add(Users(I))
                        T2.SubItems.Add("Queued")
                        T2.SubItems.Add(cRes.Text)
                        lstVideos.Items.Add(T2)
                    End If
                Next
            End If
        End Using
    End Sub
    Private Sub MenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem18.Click
        lstVideos.Items.Clear()
    End Sub
End Class
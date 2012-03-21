Imports System.Text.RegularExpressions
Imports System.IO

Public Class frmAvatarScraper
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub btnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub processLinks()
        Try
            Dim T As New WebWrapper
            Dim value As String = T.httpGet(Links.Dequeue.AbsoluteUri)
            Dim M As MatchCollection = Regex.Matches(value, "http:\/\/.*\.ytimg.com\/.*\/.*\/1\..*\?v=.*\""", RegexOptions.IgnoreCase)
            For Each MM As System.Text.RegularExpressions.Match In M
                Dim Image As String = Split(MM.Value, """")(0)
                If lstURLs.InvokeRequired Then
                    lstURLs.Invoke(New addT(AddressOf addToList), Image)
                Else
                    lstURLs.Items.Add(Image).SubItems.Add("")
                End If
            Next
        Catch
        End Try
        If Links.Count > 0 Then
            processLinks()
        End If
    End Sub
    Delegate Sub addT(ByVal pathPic As String)
    Private Sub addToList(ByVal pathPic As String)
        lstURLs.Items.Add(pathPic).SubItems.Add("")
    End Sub
    Dim Links As New Queue(Of Uri)
    Private Sub btnChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChange.Click
        Dim T As New FolderBrowserDialog
        T.Description = "Please select the folder you want to save the avatars inside"
        If T.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtPath.Text = T.SelectedPath & "\"
        End If
    End Sub
    Private Sub frmAvatarScraper_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Desktop As String = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        txtPath.Text = Desktop & "\"
        lstURLs.ContextMenu = CM1
        lstDownload.ContextMenu = CM
        CheckForIllegalCrossThreadCalls = False
    End Sub
    Dim F As New Functions.General
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        Using T As New OpenFileDialog
            If T.ShowDialog = DialogResult.OK Then
                Dim Users = F.Lines(IO.File.ReadAllText(T.FileName))
                For I = 0 To Users.Length - 1
                    If Users(I).Contains("youtube") Then
                        Dim T2 As New ListViewItem
                        T2.Text = Users(I)
                        lstDownload.Items.Add(T2)
                    End If
                Next
            End If
        End Using
    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Dim Response As String
        Response = InputBox("Please enter a URL below to add to the list")
        If Response <> Nothing Then
            If Response.Contains("youtube") Then
                lstDownload.Items.Add(Response)
            End If
        End If
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        lstDownload.Items.Clear()
    End Sub
    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        lstURLs.Items.Clear()
    End Sub
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        If lstDownload.Items.Count > 0 Then
            For Each itm As ListViewItem In lstDownload.Items
                Dim Link As New Uri(itm.Text)
                Links.Enqueue(Link)
            Next
            If Links.Count > 0 Then
                Dim T As New Threading.Thread(AddressOf processLinks)
                T.Start()
            End If
        Else
            MsgBox("No URLs to scrape avatar URLs from")
        End If
    End Sub
    Dim AvatarLinks As New Queue(Of ListViewItem)
    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        If btnStart.Text = "Start" Then
            If lstURLs.Items.Count > 0 Then
                For Each itm As ListViewItem In lstURLs.Items
                    AvatarLinks.Enqueue(itm)
                Next
                If AvatarLinks.Count > 0 Then
                    Dim T As New Threading.Thread(AddressOf processDownload)
                    T.Start()
                End If
                btnStart.Text = "Stop"
            Else
                MsgBox("No avatar URLs in the list. Please scrape some first")
            End If
        Else
            AvatarLinks.Clear()
            btnStart.Text = "Start"
        End If
    End Sub
    Private Sub Complete(ByVal index As Integer)
        lstURLs.Items(index).SubItems(1).Text = "Download complete"
        lstURLs.Items(index).BackColor = Color.LightGreen
    End Sub
    Private Sub Failed(ByVal index As Integer, ByVal ex As Exception)
        lstURLs.Items(index).SubItems(1).Text = "Download failed. Error: " & ex.Message
        lstURLs.Items(index).BackColor = Color.LightBlue
    End Sub
    Private Sub Progress(ByVal percentage As Integer, ByVal index As Integer)
        lstURLs.Items(index).SubItems(1).Text = String.Format("Downloading {0}%", percentage)
    End Sub
    Private Sub processDownload()
        Try
            Dim TM As New TypingMonkey
            Dim Link As ListViewItem = AvatarLinks.Dequeue
            Dim T As New Download(Link.Index)
            AddHandler T.FileDownloadComplete, AddressOf Complete
            AddHandler T.FileDownloadFailed, AddressOf Failed
            AddHandler T.FileDownloadPercentageChanged, AddressOf Progress
            T.DownloadFileWithProgress(Link.Text, txtPath.Text & TM.TypeAway(18) & ".jpg")
        Catch ex As Exception
        End Try
        If AvatarLinks.Count > 0 Then
            processDownload()
        Else
            btnStart.Text = "Start"
        End If
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
    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        Dim Removed As Integer = RemoveDuplicates(lstURLs)
        MsgBox("Removed " & Removed & " duplicate(s)!")
    End Sub
End Class
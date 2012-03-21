Imports ProjectWIFE
Imports System.Text

Public Class frmVideoChecker
    Dim F As New Functions.General
    Private INI As New INI(Configuration.INI_Configuration.DefaultConfig, My.Application.Info.DirectoryPath & "\config.ini")
    Dim MaxThread As Integer
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub btnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        lstVideos.Items.Clear()
    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Dim Response As String
        Response = InputBox("Please enter a video below to add to the list")
        If Response <> Nothing Then
            If Response.Contains("?v=") Then
                lstVideos.Items.Add(Response)
            End If
        End If
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
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
            End If
        End Using
    End Sub
    Private Sub frmVideoChecker_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lstVideos.ContextMenu = CM
        lstChecker.ContextMenu = CM1
        MaxThread = CInt(INI("General")("Threads").Value)
        If MaxThread > 50 Then
            MaxThread = 50
        End If
        CheckForIllegalCrossThreadCalls = False
    End Sub
    Private Sub CheckVideo()
        Try
            If Not Que.Count > 0 Then
                Return
            End If
            Dim Video As ListViewItem = Que.Dequeue
            Dim VideoID As String = Mid(Split(Video.Text, "=")(1), 1, 11)
            Dim W As New WebWrapper
            Dim Response As String = ""
            Response = W.httpGet("http://gdata.youtube.com/feeds/api/videos/" & VideoID)
            If Response = Nothing Then
                Response = ""
            End If
            Dim Views As String
            Dim Alive As String
            Dim Link As String = Video.Text
            Dim LV As New ListViewItem
            LV.Text = Link
            If Response.Contains("xml version") Then
                Views = F.GetBetweenR(Response, "viewCount='", "'", 0, True)
                Alive = "Yes"
                LV.BackColor = Color.LightGreen
            ElseIf Response = "" Then
                Views = "N/A"
                Alive = "No"
                LV.BackColor = Color.LightPink
            End If
            LV.SubItems.Add(Alive)
            LV.SubItems.Add(Views)
            lstChecker.Items.Add(LV)
        Catch
        End Try
        If Que.Count > 0 Then
            CheckVideo()
        Else
            btnStart.Text = "Start"
            btnStart.Refresh()
        End If
    End Sub
    Dim Que As New Queue(Of ListViewItem)
    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        If btnStart.Text = "Start" Then
            If lstVideos.Items.Count > 0 Then
                For Each itm As ListViewItem In lstVideos.Items
                    Que.Enqueue(itm)
                Next
                For i = 0 To MaxThread - 1
                    Dim T As New Threading.Thread(AddressOf CheckVideo)
                    T.Start()
                Next
                btnStart.Text = "Stop"
            Else
                MsgBox("There is no videos in the video list")
            End If
        Else
            Que.Clear()
            btnStart.Text = "Start"
        End If
    End Sub
    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        Dim S As New StringBuilder
        For Each itm As ListViewItem In lstChecker.Items
            If itm.Index = lstChecker.Items.Count - 1 Then
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
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Dim i As Integer
        For Each itm As ListViewItem In lstChecker.Items
            If itm.BackColor = Color.LightPink Then
                i += 1
                itm.Remove()
            End If
        Next
        MsgBox("Removed " & i & " dead videos from the list!")
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        lstChecker.Items.Clear()
    End Sub
End Class
Imports System.Text.RegularExpressions
Imports System.Text
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO

Public Class frmRetrieveFriends
    Dim F As New Functions.General
    Private Sub frmRetrieveSubscribers_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Channel.AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub
    Private Sub RetrieveSubscribers(ByVal Stuff As Object)
        Try
            Dim W As New WebWrapper
            Dim HTML As String = vbNullString
            Dim Start As Integer = 0
            Dim Added As Integer = 0
Start:      HTML = W.httpGet(String.Format("http://www.youtube.com/profile?user={0}&view=friends&start={1}&persist_hl=1&hl=en", Stuff(0), Start))
            Dim temp() As String = Regex.Split(HTML, "<div class=""user-peep""")
            For I = 1 To UBound(temp)
                If Not BW.CancellationPending Then
                    If Not Added >= Stuff(1) Then
                        Dim HH As String = Regex.Split(temp(I), "</center></div>")(0).Trim()
                        Dim LV As New ListViewItem
                        Dim Res As String = F.GetBetweenR(HH, "href=""", """ onmousedown", 0, True)
                        LV.Text = Split(Res, "/user/")(1)
                        LV.SubItems.Add("http://www.youtube.com" & Res)
                        lstFriends.Items.Add(LV)
                        Added += 1
                    End If
                Else
                    Exit Sub
                End If
            Next
            If Not Start >= Stuff(1) Then
                If HTML.Contains("Next</a>") Then
                    Dim Starters As String = StrReverse(Mid(StrReverse(Split(HTML, "Next</a>")(0)), 1, 30))
                    Dim OLD As Integer = Start
                    Start = F.GetBetweenR(Starters, "&amp;start=", """ >", 0, True)
                    If Not Start = OLD Then
                        GoTo Start
                    End If
                End If
            End If
            btnScrape.Text = "Scrape"
            Me.Refresh()
        Catch
            btnScrape.Text = "Scrape"
            Me.Refresh()
        End Try
    End Sub
    Private Sub btnScrape_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnScrape.Click
        'Dim T As New Threading.Thread(AddressOf RetrieveSubscribers)
        'T.Start({"nigahiga", 1000})
        If txtChannel.Text <> "" Then
            If txtChannel.Text.Contains("/user/") Then
                txtChannel.Text = Split(txtChannel.Text, "/user/")(1)
            End If
            If btnScrape.Text = "Scrape" Then
                If Not BW.IsBusy = True Then
                    BW.RunWorkerAsync()
                    btnScrape.Text = "Stop"
                End If
            ElseIf btnScrape.Text = "Stop" Then
                BW.CancelAsync()
                btnScrape.Text = "Scrape"
            End If
        Else
            MsgBox("Please enter a channel name before proceeding")
        End If
    End Sub
    Private Sub frmRetrieveSubscribers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        F.SetCueText(txtChannel, " Enter username of the channel (example: ""smosh"")")
        lstFriends.ContextMenu = CM
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub btnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub BW_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BW.DoWork
        Dim T As New Threading.Thread(AddressOf RetrieveSubscribers)
        T.Start({txtChannel.Text, Pages.Value})
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        lstFriends.Items.Clear()
    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Dim SD As New SaveFileDialog
        SD.Filter = "Tubenoia Friend List (*.TNFL)|*.TNFL"
        SD.FilterIndex = 1
        SD.Title = "Export Friend List"
        If Not txtChannel.Text = "" Then
            SD.FileName = txtChannel.Text & "_friends.TNFL"
        Else
            SD.FileName = "Friends.TNFL"
        End If
        If SD.ShowDialog = DialogResult.OK Then
            Dim fStream As New FileStream(SD.FileName, FileMode.Create)
            Dim binFormat As New BinaryFormatter
            Dim stuff As New List(Of ListViewItem)
            For Each itm As ListViewItem In lstFriends.Items
                stuff.Add(itm)
            Next
            binFormat.Serialize(fStream, stuff)
            F.Logs("Friend Scraper list exported to " & SD.FileName, 2, frmLog.IL, frmLog.Log)
            fStream.Close()
        End If
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Dim S As New StringBuilder
        For Each itm As ListViewItem In lstFriends.Items
            If itm.Index = lstFriends.Items.Count - 1 Then
                S.Append(itm.Text)
            Else
                S.AppendLine(itm.Text)
            End If
        Next
        Dim SD As New SaveFileDialog
        SD.Filter = "Text File (*.txt)|*.txt"
        SD.FilterIndex = 1
        SD.Title = "Export Friend List"
        If Not txtChannel.Text = "" Then
            SD.FileName = txtChannel.Text & "_friends.txt"
        Else
            SD.FileName = "Friends.txt"
        End If
        If SD.ShowDialog = DialogResult.OK Then
            Dim Sys As New System.IO.StreamWriter(SD.FileName)
            Sys.Write(S.ToString)
            Sys.Flush()
            Sys.Dispose()
            F.Logs("Friend Scraper list exported to " & SD.FileName, 2, frmLog.IL, frmLog.Log)
        End If
    End Sub
    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        For Each itm As ListViewItem In lstFriends.SelectedItems
            itm.Remove()
        Next
    End Sub
End Class